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
    /// API methods related to Transactions
    /// </summary>
    public class TransactionsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TransactionsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Queries transactions (invoices/credit memos/payments) for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="currentDate">The date the days past due value will be calculated against. If no currentDate is provided the current UTC date will be used.</param>
        public async Task<LockstepResponse<TransactionModelTransactionSummaryTotalModelSummaryFetchResult>> QueryTransactions(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null, DateTime? currentDate = null)
        {
            var url = $"/api/v1/Transactions/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            if (currentDate != null) { options["currentDate"] = currentDate; }
            return await _client.Request<TransactionModelTransactionSummaryTotalModelSummaryFetchResult>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieves a list of transaction details for the supplied transaction id.
        ///
        /// A Transaction Detail contains information about the associated Transaction. This information can be an invoice associated to a payment or credit memo or a payment or credit memo used as payment for one or more invoices.
        ///
        /// </summary>
        /// <param name="id"></param>
        public async Task<LockstepResponse<TransactionDetailModel[]>> RetrieveTransactionDetails(Guid id)
        {
            var url = $"/api/v1/Transactions/{id}/details";
            return await _client.Request<TransactionDetailModel[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
