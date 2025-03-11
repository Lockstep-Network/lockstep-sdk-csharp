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
    /// API methods related to CreditMemosApplied
    /// </summary>
    public class CreditMemosAppliedClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CreditMemosAppliedClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Credit Memo Applied specified by this unique identifier, optionally including nested data sets.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, ADS Platform creates a Credit Memo Applied record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Applied records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Credit Memo Applied; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes, Invoice, CreditMemoInvoice</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel>> RetrieveCreditMemoApplied(Guid id, string include = null)
        {
            var url = $"/api/v1/credit-memos-applied/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<CreditMemoAppliedModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing Credit Memo Applied with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, ADS Platform creates a Credit Memo Applied record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Applied records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Credit Memo Applied to update; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Credit Memo Applied</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel>> UpdateCreditMemosApplied(Guid id, object body)
        {
            var url = $"/api/v1/credit-memos-applied/{id}";
            return await _client.Request<CreditMemoAppliedModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the Credit Memo Applied referred to by this unique identifier.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, ADS Platform creates a Credit Memo Applied record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Applied records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Credit Memo Applied to delete; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteCreditMemoApplied(Guid id)
        {
            var url = $"/api/v1/credit-memos-applied/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Credit Memos Applied within this account and returns the records as created.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, ADS Platform creates a Credit Memo Applied record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Applied records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="body">The Credit Memos Applied to create</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel[]>> CreateCreditMemosApplied(CreditMemoAppliedModel[] body)
        {
            var url = $"/api/v1/credit-memos-applied";
            return await _client.Request<CreditMemoAppliedModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Credit Memos Applied for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, ADS Platform creates a Credit Memo Applied record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Applied records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<CreditMemoAppliedModel>>> QueryCreditMemosApplied(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/credit-memos-applied/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<CreditMemoAppliedModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
