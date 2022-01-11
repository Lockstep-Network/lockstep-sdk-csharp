/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
 * @version    2022.2
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



using RestSharp;

public class AppEnrollmentsClient
{
    private readonly LockstepApi client;

    public AppEnrollmentsClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Retrieves the App Enrollment with this identifier.
    /// 
    /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the App Enrollment to retrieve</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: App, CustomFields</param>
    public async Task<LockstepResponse<AppEnrollmentModel>> RetrieveAppEnrollment(Guid? id, string? include)
    {
        var url = $"/api/v1/AppEnrollments/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await this.client.Request<AppEnrollmentModel>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Updates an existing App Enrollment with the information supplied to this PATCH call.
    /// 
    /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  For example, you can provide the field name "IsActive" and specify the new value "False"; this API will then change the value of IsActive to false.
    /// 
    /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the App Enrollment to update</param>
    /// <param name="body">A list of changes to apply to this App Enrollment</param>
    public async Task<LockstepResponse<AppEnrollmentModel>> UpdateAppEnrollment(Guid? id, object? body)
    {
        var url = $"/api/v1/AppEnrollments/{id}";
        return await this.client.Request<AppEnrollmentModel>(Method.PATCH, url, null, body);
    }

    /// <summary>
    /// Deletes the App Enrollment referred to by this unique identifier. An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the App Enrollment to delete</param>
    /// <param name="removeEnrollmentData">Option to remove all associated app enrollment data when deleting app enrollment (default false)</param>
    public async Task<LockstepResponse<ActionResultModel>> DeleteAppEnrollment(Guid? id, bool? removeEnrollmentData)
    {
        var url = $"/api/v1/AppEnrollments/{id}";
        var options = new Dictionary<string, object?>();
        options["removeEnrollmentData"] = removeEnrollmentData;
        return await this.client.Request<ActionResultModel>(Method.DELETE, url, options, null);
    }

    /// <summary>
    /// Creates one or more App Enrollments within this account and returns the records as created.
    /// 
    /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="body">The App Enrollments to create</param>
    public async Task<LockstepResponse<AppEnrollmentModel[]>> CreateAppEnrollments(AppEnrollmentModel[]? body)
    {
        var url = $"/api/v1/AppEnrollments";
        return await this.client.Request<AppEnrollmentModel[]>(Method.POST, url, null, body);
    }

    /// <summary>
    /// Queries App Enrollments for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
    /// 
    /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: App, CustomFields, LastSync</param>
    /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    public async Task<LockstepResponse<FetchResult<AppEnrollmentModel>>> QueryAppEnrollments(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/AppEnrollments/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await this.client.Request<FetchResult<AppEnrollmentModel>>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Queries custom fields settings for app enrollment within the Lockstep platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
    /// 
    /// An App Enrollment represents an app that has been enrolled to the current account.  When you sign up for an app using the Lockstep Platform, you obtain an enrollment record for that app.  Example types of apps include connectors and feature enhancement apps. The App Enrollment object contains information about this app, its configuration, and settings.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the App Enrollment for which we retrieve custom fields</param>
    public async Task<LockstepResponse<FetchResult<AppEnrollmentCustomFieldModel>>> QueryEnrollmentFields(Guid? id)
    {
        var url = $"/api/v1/AppEnrollments/settings/{id}";
        return await this.client.Request<FetchResult<AppEnrollmentCustomFieldModel>>(Method.GET, url, null, null);
    }
}
