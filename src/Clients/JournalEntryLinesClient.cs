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
    /// API methods related to JournalEntryLines
    /// </summary>
    public class JournalEntryLinesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public JournalEntryLinesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Journal Entry Line specified by this unique identifier, optionally including nested data sets.
        ///
        /// </summary>
        /// <param name="id">The unique Sage Network Platform ID number of this journal entry line; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: JournalEntry</param>
        public async Task<LockstepResponse<JournalEntryLineModel>> RetrieveJournalEntryLine(Guid id, string include = null)
        {
            var url = $"/api/v1/journal-entry-lines/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<JournalEntryLineModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries Journal Entry Lines for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: JournalEntry</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<JournalEntryLineModel>>> QueryJournalEntryLines(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/journal-entry-lines/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<JournalEntryLineModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}