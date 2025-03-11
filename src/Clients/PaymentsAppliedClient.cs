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
    /// API methods related to PaymentsApplied
    /// </summary>
    public class PaymentsAppliedClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public PaymentsAppliedClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Payment Applied specified by this unique identifier, optionally including nested data sets.
        ///
        /// A Payment Applied is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Applied contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// A Payment Applied can also be used to add funds to a Payment by way of a refund Payment. In this scenario the Payment Applied contains information about which Payment is being funded and which refund Payment supplied the funds.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Payment Applied; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Invoice, Payment, Refund</param>
        public async Task<LockstepResponse<PaymentAppliedModel>> RetrievePaymentApplied(Guid id, string include = null)
        {
            var url = $"/api/v1/payments-applied/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<PaymentAppliedModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing Payment Applied with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Payment Applied is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Applied contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// A Payment Applied can also be used to add funds to a Payment by way of a refund Payment. In this scenario the Payment Applied contains information about which Payment is being funded and which refund Payment supplied the funds.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Payment Applied to update; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Payment Applied</param>
        public async Task<LockstepResponse<PaymentAppliedModel>> UpdatePaymentApplied(Guid id, object body)
        {
            var url = $"/api/v1/payments-applied/{id}";
            return await _client.Request<PaymentAppliedModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the Payment Applied referred to by this unique identifier.
        ///
        /// A Payment Applied is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Applied contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// A Payment Applied can also be used to add funds to a Payment by way of a refund Payment. In this scenario the Payment Applied contains information about which Payment is being funded and which refund Payment supplied the funds.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Payment Applied to delete; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<ActionResultModel>> DeletePaymentApplied(Guid id)
        {
            var url = $"/api/v1/payments-applied/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Payments Applied within this account and returns the records as created.
        ///
        /// A Payment Applied is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Applied contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// A Payment Applied can also be used to add funds to a Payment by way of a refund Payment. In this scenario the Payment Applied contains information about which Payment is being funded and which refund Payment supplied the funds.
        ///
        /// </summary>
        /// <param name="body">The Payments Applied to create</param>
        public async Task<LockstepResponse<PaymentAppliedModel[]>> CreatePaymentsApplied(PaymentAppliedModel[] body)
        {
            var url = $"/api/v1/payments-applied";
            return await _client.Request<PaymentAppliedModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Payments Applied for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// A Payment Applied is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Applied contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// A Payment Applied can also be used to add funds to a Payment by way of a refund Payment. In this scenario the Payment Applied contains information about which Payment is being funded and which refund Payment supplied the funds.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Invoice, Payment, Refund</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<PaymentAppliedModel>>> QueryPaymentsApplied(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/payments-applied/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<PaymentAppliedModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
