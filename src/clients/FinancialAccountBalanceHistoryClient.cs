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
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace LockstepSDK
{
    public class FinancialAccountBalanceHistoryClient
    {
        private readonly LockstepApi _client;

        public FinancialAccountBalanceHistoryClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Financial Account Balance History specified by this unique identifier.
        ///
        /// A Financial Account Balance History records either the current or end of period balance for a corresponding financial account.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Financial Account Balance History</param>
        public async Task<LockstepResponse<FinancialAccountBalanceHistoryModel>> RetrieveFinancialAccountBalanceHistory(Guid id)
        {
            var url = $"/api/v1/FinancialAccountBalanceHistory/{id}";
            return await _client.Request<FinancialAccountBalanceHistoryModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates a Financial Account Balance History that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Financial Account Balance History records either the current or end of period balance for a corresponding financial account.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Financial Account Balance History to update</param>
        /// <param name="body">A list of changes to apply to this Financial Account Balance History</param>
        public async Task<LockstepResponse<FinancialAccountBalanceHistoryModel>> UpdateFinancialAccountBalanceHistory(Guid id, object body)
        {
            var url = $"/api/v1/FinancialAccountBalanceHistory/{id}";
            return await _client.Request<FinancialAccountBalanceHistoryModel>(HttpMethod.Patch, url, null, body, null);
        }

        /// <summary>
        /// Delete the Financial Account Balance History referred to by this unique identifier.
        ///
        /// A Financial Account Balance History records either the current or end of period balance for a corresponding financial account.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Financial Account Balance History to disable</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteFinancialAccountBalanceHistory(Guid id)
        {
            var url = $"/api/v1/FinancialAccountBalanceHistory/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates a Financial Account Balance History from a given model.
        ///
        /// A Financial Account Balance History records either the current or end of period balance for a corresponding financial account.
        ///
        /// </summary>
        /// <param name="body">The Financial Account Balance Histories to create</param>
        public async Task<LockstepResponse<FinancialAccountBalanceHistoryModel>> CreateFinancialAccountBalanceHistory(FinancialAccountBalanceHistoryModel[] body)
        {
            var url = $"/api/v1/FinancialAccountBalanceHistory";
            return await _client.Request<FinancialAccountBalanceHistoryModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Financial Account Balance History for this account using the specified filtering, sorting, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A Financial Account Balance History records either the current or end of period balance for a corresponding financial account.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<FinancialAccountBalanceHistoryModel>>> QueryFinancialAccountBalanceHistory(string? filter, string? order, int? pageSize, int? pageNumber)
        {
            var url = $"/api/v1/FinancialAccountBalanceHistory/query";
            var options = new Dictionary<string, object?>();
            options["filter"] = filter;
            options["order"] = order;
            options["pageSize"] = pageSize;
            options["pageNumber"] = pageNumber;
            return await _client.Request<FetchResult<FinancialAccountBalanceHistoryModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}