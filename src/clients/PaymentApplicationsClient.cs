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
    public class PaymentApplicationsClient
    {
        private readonly LockstepApi _client;

        public PaymentApplicationsClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Payment Application specified by this unique identifier, optionally including nested data sets.
        ///
        /// A Payment Application is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Payment Application; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Invoice</param>
        public async Task<LockstepResponse<PaymentAppliedModel>> RetrievePaymentApplication(Guid id, string? include)
        {
            var url = $"/api/v1/PaymentApplications/{id}";
            var options = new Dictionary<string, object?>();
            options["include"] = include;
            return await _client.Request<PaymentAppliedModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing Payment Application with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.  A Payment Application is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Payment Application to update; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Payment Application</param>
        public async Task<LockstepResponse<PaymentAppliedModel>> UpdatePaymentApplication(Guid id, object body)
        {
            var url = $"/api/v1/PaymentApplications/{id}";
            return await _client.Request<PaymentAppliedModel>(HttpMethod.Patch, url, null, body, null);
        }

        /// <summary>
        /// Deletes the Payment Application referred to by this unique identifier.
        ///
        /// A Payment Application is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Payment Application to delete; NOT the customer's ERP key</param>
        public async Task<LockstepResponse<ActionResultModel>> DeletePaymentApplication(Guid id)
        {
            var url = $"/api/v1/PaymentApplications/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Payment Applications within this account and returns the records as created.
        ///
        /// A Payment Application is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// </summary>
        /// <param name="body">The Payment Applications to create</param>
        public async Task<LockstepResponse<PaymentAppliedModel[]>> CreatePaymentApplications(PaymentAppliedModel[] body)
        {
            var url = $"/api/v1/PaymentApplications";
            return await _client.Request<PaymentAppliedModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Payment Applications for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.  A Payment Application is created by a business who receives a Payment from a customer.  A customer may make a single Payment to match an Invoice exactly, a partial Payment for an Invoice, or a single Payment may be made for multiple smaller Invoices.  The Payment Application contains information about which Invoices are connected to which Payments and for which amounts.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Invoice</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<PaymentAppliedModel>>> QueryPaymentApplications(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
        {
            var url = $"/api/v1/PaymentApplications/query";
            var options = new Dictionary<string, object?>();
            options["filter"] = filter;
            options["include"] = include;
            options["order"] = order;
            options["pageSize"] = pageSize;
            options["pageNumber"] = pageNumber;
            return await _client.Request<FetchResult<PaymentAppliedModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
