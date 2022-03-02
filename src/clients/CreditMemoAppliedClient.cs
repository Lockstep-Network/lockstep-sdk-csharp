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
    /// Lockstep Platform methods related to CreditMemoApplied
    /// </summary>
    public class CreditMemoAppliedClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CreditMemoAppliedClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Credit Memo Application specified by this unique identifier, optionally including nested data sets.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, Lockstep creates a Credit Memo Application record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Application records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Credit Memo Application; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel>> RetrieveCreditMemoApplication(Guid id, string? include)
        {
            var url = $"/api/v1/CreditMemoApplied/{id}";
            var options = new Dictionary<string, object?>();
            options["include"] = include;
            return await _client.Request<CreditMemoAppliedModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing Credit memo Application with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, Lockstep creates a Credit Memo Application record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Application records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Credit Memo Application to update; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Credit Memo Application</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel>> UpdateCreditMemoApplication(Guid id, object body)
        {
            var url = $"/api/v1/CreditMemoApplied/{id}";
            return await _client.Request<CreditMemoAppliedModel>(HttpMethod.Patch, url, null, body, null);
        }

        /// <summary>
        /// Deletes the Credit Memo Application referred to by this unique identifier.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, Lockstep creates a Credit Memo Application record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Application records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Credit Memo Application to delete; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel>> DeleteCreditMemoApplication(Guid id)
        {
            var url = $"/api/v1/CreditMemoApplied/{id}";
            return await _client.Request<CreditMemoAppliedModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Credit Memo Applications within this account and returns the records as created.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, Lockstep creates a Credit Memo Application record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Application records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="body">The Credit Memo Applications to create</param>
        public async Task<LockstepResponse<CreditMemoAppliedModel[]>> CreateCreditMemoApplications(CreditMemoAppliedModel[] body)
        {
            var url = $"/api/v1/CreditMemoApplied";
            return await _client.Request<CreditMemoAppliedModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Credit Memo Applications for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// Credit Memos reflect credits granted to a customer for various reasons, such as discounts or refunds. Credit Memos may be applied to Invoices as Payments. When a Credit Memo is applied as payment to an Invoice, Lockstep creates a Credit Memo Application record to track the amount from the Credit Memo that was applied as payment to the Invoice. You can examine Credit Memo Application records to track which Invoices were paid using this Credit.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<CreditMemoAppliedModel>>> QueryCreditMemoApplications(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
        {
            var url = $"/api/v1/CreditMemoApplied/query";
            var options = new Dictionary<string, object?>();
            options["filter"] = filter;
            options["include"] = include;
            options["order"] = order;
            options["pageSize"] = pageSize;
            options["pageNumber"] = pageNumber;
            return await _client.Request<FetchResult<CreditMemoAppliedModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
