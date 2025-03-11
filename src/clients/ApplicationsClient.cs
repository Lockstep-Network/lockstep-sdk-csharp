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
    /// API methods related to Applications
    /// </summary>
    public class ApplicationsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ApplicationsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Application with this identifier.
        ///
        /// An Application represents a feature available to customers within the ADS Platform.  You can create Applications by working with your ADS Platform business development manager and publish them on the platform so that customers can browse and find your Application on the ADS Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer&#39;s instance of this Application.  The customer-specific AppEnrollment contains a customer&#39;s configuration data for the Application, which is not customer-specific.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Application to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Notes, Attachments, CustomFields, Enrollments</param>
        public async Task<LockstepResponse<ApplicationModel>> RetrieveApplication(Guid id, string include = null)
        {
            var url = $"/api/v1/Applications/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<ApplicationModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries Applications on the ADS Platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// An Application represents a feature available to customers within the ADS Platform.  You can create Applications by working with your ADS Platform business development manager and publish them on the platform so that customers can browse and find your Application on the ADS Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer&#39;s instance of this Application.  The customer-specific AppEnrollment contains a customer&#39;s configuration data for the Application, which is not customer-specific.
        ///
        /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Notes, Attachments, CustomFields, Enrollments</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<ApplicationModel>>> QueryApplications(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Applications/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<ApplicationModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
