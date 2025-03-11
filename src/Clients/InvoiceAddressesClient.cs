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
    /// API methods related to InvoiceAddresses
    /// </summary>
    public class InvoiceAddressesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public InvoiceAddressesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the invoice address specified by this unique identifier, optionally including nested data sets.
        ///
        /// An Invoice Address contains address information about an invoice. You can use Invoice Addresses to track information about locations important to an invoice such as: where a company&#39;s goods are shipped from, where a company&#39;s goods are shipped to or billing addresses to name a few.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of this invoice address</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve.</param>
        public async Task<LockstepResponse<InvoiceAddressModel>> RetrieveInvoiceAddress(Guid id, string include = null)
        {
            var url = $"/api/v1/invoice-addresses/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<InvoiceAddressModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Deletes the Invoice Address by this unique identifier.
        ///
        /// An Invoice Address contains address information about an invoice. You can use Invoice Addresses to track information about locations important to an invoice such as: where a company&#39;s goods are shipped from, where a company&#39;s goods are shipped to or billing addresses to name a few.
        ///
        /// </summary>
        /// <param name="id">The unique ID of the Invoice Address to delete</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteInvoiceAddress(Guid id)
        {
            var url = $"/api/v1/invoice-addresses/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Updates an existing Invoice Address with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone. As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged. This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// An Invoice Address contains address information about an invoice. You can use Invoice Addresses to track information about locations important to an invoice such as: where a company&#39;s goods are shipped from, where a company&#39;s goods are shipped to or billing addresses to name a few.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Invoice Address to update</param>
        /// <param name="body">A list of changes to apply to this Invoice Address</param>
        public async Task<LockstepResponse<InvoiceAddressModel>> UpdateInvoiceAddress(Guid id, object body)
        {
            var url = $"/api/v1/invoice-addresses/{id}";
            return await _client.Request<InvoiceAddressModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Creates one or more Invoice Addresses within this account and returns the records as created.
        ///
        /// An Invoice Address contains address information about an invoice. You can use Invoice Addresses to track information about locations important to an invoice such as: where a company&#39;s goods are shipped from, where a company&#39;s goods are shipped to or billing addresses to name a few.
        ///
        /// </summary>
        /// <param name="body">The Invoice Address to create</param>
        public async Task<LockstepResponse<InvoiceAddressModel[]>> CreateInvoiceAddress(InvoiceAddressModel[] body)
        {
            var url = $"/api/v1/invoice-addresses";
            return await _client.Request<InvoiceAddressModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Invoice Addresses for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<InvoiceAddressModel>>> QueryInvoiceAddresses(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/invoice-addresses/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<InvoiceAddressModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
