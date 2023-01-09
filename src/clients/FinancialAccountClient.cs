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
    /// API methods related to FinancialAccount
    /// </summary>
    public class FinancialAccountClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public FinancialAccountClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates a financial account with the specified name.
        ///
        /// </summary>
        /// <param name="body">Metadata about the financial account to create.</param>
        public async Task<LockstepResponse<FinancialAccountModel>> CreateFinancialAccount(FinancialAccountModel[] body)
        {
            var url = $"/api/v1/FinancialAccount";
            return await _client.Request<FinancialAccountModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Retrieves the financial account specified by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Account; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<FinancialAccountModel>> RetrieveFinancialAccount(Guid id)
        {
            var url = $"/api/v1/FinancialAccount/{id}";
            return await _client.Request<FinancialAccountModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Account to update; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Account</param>
        public async Task<LockstepResponse<FinancialAccountModel>> UpdateFinancialAccount(Guid id, object body)
        {
            var url = $"/api/v1/FinancialAccount/{id}";
            return await _client.Request<FinancialAccountModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the Financial Account referred to by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Financial Account to disable; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteFinancialAccount(Guid id)
        {
            var url = $"/api/v1/FinancialAccount/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve.</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<FinancialAccountModel>>> QueryFinancialAccounts(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/FinancialAccount/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<FinancialAccountModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
