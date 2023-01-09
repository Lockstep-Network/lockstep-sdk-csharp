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
    /// API methods related to InvoiceLines
    /// </summary>
    public class InvoiceLinesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public InvoiceLinesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates one or more invoice lines within this account and returns the created records
        ///
        /// </summary>
        /// <param name="body"></param>
        public async Task<LockstepResponse<InvoiceLineModel[]>> CreateInvoiceLine(InvoiceLineModel[] body)
        {
            var url = $"/api/v1/invoice-lines";
            return await _client.Request<InvoiceLineModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="body">The unique Lockstep Platform ID numbers of the Invoice Lines to delete; NOT the customer's ERP keys</param>
        public async Task<LockstepResponse<DeleteResult>> DeleteInvoiceLines(BulkDeleteRequestModel body)
        {
            var url = $"/api/v1/invoice-lines";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, body, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="invoiceLineId">Unique id of the the InvoiceLine</param>
        public async Task<LockstepResponse<InvoiceLineModel>> RetrievesInvoiceLine(Guid invoiceLineId)
        {
            var url = $"/api/v1/invoice-lines/{invoiceLineId}";
            return await _client.Request<InvoiceLineModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates an existing Invoice Line with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone. As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged. This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// </summary>
        /// <param name="invoiceLineId">Unique id of the the InvoiceLine</param>
        /// <param name="body">A list of changes to apply to this Invoice Line</param>
        public async Task<LockstepResponse<InvoiceLineModel>> UpdateInvoiceLine(Guid invoiceLineId, object body)
        {
            var url = $"/api/v1/invoice-lines/{invoiceLineId}";
            return await _client.Request<InvoiceLineModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="invoiceLineId">Unique id of the the InvoiceLine</param>
        public async Task<LockstepResponse<DeleteResult>> DeletesInvoiceLine(Guid invoiceLineId)
        {
            var url = $"/api/v1/invoice-lines/{invoiceLineId}";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Queries Invoice Lines for the account using specified filtering More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve.</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax]</param>
        /// <param name="pageSize">The page size for results (default 200, maximum of 10,000)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        public async Task<LockstepResponse<FetchResult<InvoiceLineModel>>> QueryInvoiceLines(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/invoice-lines/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<InvoiceLineModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
