/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2023 Lockstep, Inc.
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
    /// API methods related to MagicLinks
    /// </summary>
    public class MagicLinksClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public MagicLinksClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Magic Link specified by this unique identifier, optionally including nested data sets.
        ///
        /// </summary>
        /// <param name="id">The id of the Magic Link</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: User</param>
        public async Task<LockstepResponse<MagicLinkModel>> RetrieveMagicLink(Guid id, string include = null)
        {
            var url = $"/api/v1/useraccounts/magic-links/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<MagicLinkModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Revokes the magic link with the specified id so it cannot be used to call the API.
        ///
        /// Revocation will be received by all servers within five minutes of revocation. API calls made using this magic link after the revocation will fail. A revoked magic link cannot be un-revoked.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this magic link</param>
        public async Task<LockstepResponse<ActionResultModel>> RevokeMagicLink(Guid id)
        {
            var url = $"/api/v1/useraccounts/magic-links/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Queries Magic Links for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: User</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        public async Task<LockstepResponse<FetchResult<MagicLinkModel>>> QueryMagicLinks(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/useraccounts/magic-links/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<MagicLinkModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Gets a summary of all magic links created during the specified date range, returns no content if there are no magic links for the specified date range
        ///
        /// </summary>
        /// <param name="from">The date that the summary starts from (default one year ago from today)</param>
        /// <param name="to">The date that the summary ends at (default today)</param>
        public async Task<LockstepResponse<MagicLinkSummaryModel>> MagicLinkSummary(DateTime? from = null, DateTime? to = null)
        {
            var url = $"/api/v1/useraccounts/magic-links/summary";
            var options = new Dictionary<string, object>();
            if (from != null) { options["from"] = from; }
            if (to != null) { options["to"] = to; }
            return await _client.Request<MagicLinkSummaryModel>(HttpMethod.Get, url, options, null, null);
        }
    }
}
