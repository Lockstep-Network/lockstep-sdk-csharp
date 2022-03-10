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
    /// <summary>
    /// Lockstep Platform methods related to InvoiceHistory
    /// </summary>
    public class InvoiceHistoryClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public InvoiceHistoryClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the history of the Invoice specified by this unique identifier.
        ///
        /// An Invoice represents a bill sent from one company to another.  The Lockstep Platform tracks changes to each Invoice so that you can observe the changes over time.  You can view the InvoiceHistory list to monitor and observe the changes of this Invoice and track the dates when changes occurred.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this invoice; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<FetchResult<InvoiceHistoryModel>>> RetrieveInvoiceHistory(Guid id)
        {
            var url = $"/api/v1/InvoiceHistory/{id}";
            return await _client.Request<FetchResult<InvoiceHistoryModel>>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Queries Invoice History for this account using the specified filtering, sorting, and pagination rules requested.
        ///
        /// An Invoice represents a bill sent from one company to another.  The Lockstep Platform tracks changes to each Invoice so that you can observe the changes over time.  You can view the InvoiceHistory list to monitor and observe the changes of this Invoice and track the dates when changes occurred.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available for querying but may be available in the future.</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<InvoiceHistoryModel>>> QueryInvoiceHistory(string filter, string include, string order, int? pageSize, int? pageNumber)
        {
            var url = $"/api/v1/InvoiceHistory/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<InvoiceHistoryModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
