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
    /// API methods related to WorkflowStatuses
    /// </summary>
    public class WorkflowStatusesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public WorkflowStatusesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Workflow Status specified by this unique identifier.
        ///
        /// A Workflow Status represents the state for a specific workflow for an entity. A Workflow Status may be generic for common use cases or specific to a set of predefined statuses.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Workflow Status to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Children, Parents</param>
        public async Task<LockstepResponse<WorkflowStatusModel>> RetrieveWorkflowStatus(Guid id, string include = null)
        {
            var url = $"/api/v1/workflow-statuses/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<WorkflowStatusModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries Workflow Statuses using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Accounting Data Services Developer website.
        ///
        /// A Workflow Status represents the state for a specific workflow for an entity. A Workflow Status may be generic for common use cases or specific to a set of predefined statuses.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<WorkflowStatusModel>>> QueryWorkflowStatuses(string filter = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/workflow-statuses/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<WorkflowStatusModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
