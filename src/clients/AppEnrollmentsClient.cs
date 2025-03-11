/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LockstepSDK.Models;


namespace LockstepSDK.Clients
{
    /// <summary>
    /// API methods related to AppEnrollments
    /// </summary>
    public class AppEnrollmentsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public AppEnrollmentsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the App Enrollment with this identifier.
        ///
        /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the ADS Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the App Enrollment to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: App, CustomFields, LastSync, LastSuccessfulSync</param>
        public async Task<LockstepResponse<AppEnrollmentModel>> RetrieveAppEnrollment(Guid id, string include = null)
        {
            var url = $"/api/v1/AppEnrollments/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<AppEnrollmentModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing App Enrollment with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  For example, you can provide the field name &quot;IsActive&quot; and specify the new value &quot;False&quot;; this API will then change the value of IsActive to false.
        ///
        /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the ADS Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the App Enrollment to update</param>
        /// <param name="body">A list of changes to apply to this App Enrollment</param>
        public async Task<LockstepResponse<AppEnrollmentModel>> UpdateAppEnrollment(Guid id, object body)
        {
            var url = $"/api/v1/AppEnrollments/{id}";
            return await _client.Request<AppEnrollmentModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the App Enrollment referred to by this unique identifier. An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the ADS Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the App Enrollment to delete</param>
        /// <param name="removeEnrollmentData">Option to remove all associated app enrollment data when deleting app enrollment (default false)</param>
        public async Task<LockstepResponse<DeleteResult>> DeleteAppEnrollment(Guid id, bool? removeEnrollmentData = null)
        {
            var url = $"/api/v1/AppEnrollments/{id}";
            var options = new Dictionary<string, object>();
            if (removeEnrollmentData != null) { options["removeEnrollmentData"] = removeEnrollmentData; }
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, options, null, null);
        }

        /// <summary>
        /// Creates one or more App Enrollments within this account and returns the records as created.
        ///
        /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the ADS Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="startSync">Option to start sync immediately after creation of app enrollments (default false)</param>
        /// <param name="body">The App Enrollments to create</param>
        public async Task<LockstepResponse<AppEnrollmentModel[]>> CreateAppEnrollments(AppEnrollmentModel[] body, bool? startSync = null)
        {
            var url = $"/api/v1/AppEnrollments";
            var options = new Dictionary<string, object>();
            if (startSync != null) { options["startSync"] = startSync; }
            return await _client.Request<AppEnrollmentModel[]>(HttpMethod.Post, url, options, body, null);
        }

        /// <summary>
        /// Updates the settings associated with this App Enrollment
        ///
        /// </summary>
        /// <param name="id">The id for the app enrollment</param>
        /// <param name="body">Information to reconnect the App Enrollment</param>
        public async Task<LockstepResponse<CustomFieldValueModel[]>> ReconnectAppEnrollment(Guid id, AppEnrollmentReconnectInfo body)
        {
            var url = $"/api/v1/AppEnrollments/{id}/reconnect";
            return await _client.Request<CustomFieldValueModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries App Enrollments for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the ADS Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: App, CustomFields, LastSync, LastSuccessfulSync</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<AppEnrollmentModel>>> QueryAppEnrollments(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/AppEnrollments/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<AppEnrollmentModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries custom fields settings for app enrollment within the ADS Platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the ADS Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the App Enrollment for which we retrieve custom fields</param>
        public async Task<LockstepResponse<FetchResult<AppEnrollmentCustomFieldModel>>> QueryEnrollmentFields(Guid id)
        {
            var url = $"/api/v1/AppEnrollments/settings/{id}";
            return await _client.Request<FetchResult<AppEnrollmentCustomFieldModel>>(HttpMethod.Get, url, null, null, null);
        }
    }
}
