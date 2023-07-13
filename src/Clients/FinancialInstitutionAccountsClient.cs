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
    /// API methods related to FinancialInstitutionAccounts
    /// </summary>
    public class FinancialInstitutionAccountsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public FinancialInstitutionAccountsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the financial institution account specified by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this institution account; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<FinancialInstitutionAccountModel>> RetrieveFinancialInstitutionAccounts(Guid id)
        {
            var url = $"/api/v1/financial-institution-accounts/{id}";
            return await _client.Request<FinancialInstitutionAccountModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future.</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<FinancialInstitutionAccountModel>>> QueryFinancialInstitutionAccounts(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/financial-institution-accounts/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<FinancialInstitutionAccountModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
