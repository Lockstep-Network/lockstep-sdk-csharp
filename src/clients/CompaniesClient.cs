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
    /// API methods related to Companies
    /// </summary>
    public class CompaniesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CompaniesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Company specified by this unique identifier, optionally including nested data sets.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Company; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, Contacts, CustomFields, Invoices, Notes, Classification</param>
        public async Task<LockstepResponse<CompanyModel>> RetrieveCompany(Guid id, string include = null)
        {
            var url = $"/api/v1/Companies/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<CompanyModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates a Company that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Company; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Company</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<CompanyModel>> UpdateCompany(Guid id, object body)
        {
            var url = $"/api/v1/Companies/{id}";
            return await _client.Request<CompanyModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Delete the Company referred to by this unique identifier.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Company; NOT the customer's ERP key</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<DeleteResult>> DeleteCompany(Guid id)
        {
            var url = $"/api/v1/Companies/{id}";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Companies from a given model.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="body">The Companies to create</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<CompanyModel[]>> CreateCompanies(CompanyModel[] body)
        {
            var url = $"/api/v1/Companies";
            return await _client.Request<CompanyModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Delete the Companies referred to by these unique identifiers.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="body">The unique ADS Platform ID numbers of the Companies to delete; NOT the customer's ERP key</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<DeleteResult>> DeleteCompanies(BulkDeleteRequestModel body)
        {
            var url = $"/api/v1/Companies";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, body, null);
        }

        /// <summary>
        /// Queries Companies for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, Contacts, CustomFields, Invoices, Notes, Classification</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        public async Task<LockstepResponse<FetchResult<CompanyModel>>> QueryCompanies(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Companies/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<CompanyModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries Customer Summaries for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// The Customer Summary View represents a slightly different view of the data and includes some extra fields that might be useful. For more information, see the data format of the Customer Summary Model.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        /// <param name="reportDate">The date to calculate the fields on. If no date is entered the current UTC date will be used.</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<FetchResult<CustomerSummaryModel>>> QueryCustomerSummary(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null, DateTime? reportDate = null)
        {
            var url = $"/api/v1/Companies/views/customer-summary";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            if (reportDate != null) { options["reportDate"] = reportDate; }
            return await _client.Request<FetchResult<CustomerSummaryModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries Vendor Summaries for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// The Vendor Summary View represents a slightly different view of the data and includes some extra fields that might be useful. For more information, see the data format of the Vendor Summary Model.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        /// <param name="reportDate">The date to calculate the fields on. If no date is entered the current UTC date will be used.</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<FetchResult<VendorSummaryModel>>> QueryVendorSummary(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null, DateTime? reportDate = null)
        {
            var url = $"/api/v1/Companies/views/vendor-summary";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            if (reportDate != null) { options["reportDate"] = reportDate; }
            return await _client.Request<FetchResult<VendorSummaryModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        /// <param name="legacy">Generates query data based on legacy approach of executing SQL view queries.</param>
        public async Task<LockstepResponse<FetchResult<CompanyMagicLinkSummaryModel>>> QueryMagicLinkSummary(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null, bool? legacy = null)
        {
            var url = $"/api/v1/Companies/views/magic-link-summary";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            if (legacy != null) { options["legacy"] = legacy; }
            return await _client.Request<FetchResult<CompanyMagicLinkSummaryModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieves the Company Details specified by this unique identifier, optionally including nested data sets.
        ///
        /// The Company Detail View represents a slightly different view of the data and includes some extra fields that might be useful. For more information, see the data format of the Company Detail Model.
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Company; NOT the company's ERP key</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<CompanyDetailsModel>> RetrieveCompanyDetail(Guid id)
        {
            var url = $"/api/v1/Companies/views/details/{id}";
            return await _client.Request<CompanyDetailsModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Sets the logo for specified company. The logo will be stored in the ADS Platform and will be **publicly accessible**.
        ///
        /// .jpg, .jpeg, .png, and .webp are supported. 2MB maximum. If no logo is uploaded, the existing logo will be deleted. JFIF and EXIF are not supported. If you upload a JPEG and get an error, verify the file is not one of these formats.
        ///
        /// A Company represents a customer, a vendor, or a company within the organization of the account holder. Companies can have parents and children, representing an organizational hierarchy of corporate entities. You can use Companies to track projects and financial data under this Company label.
        ///
        /// Optional view box meta data for the provided logo may be supplied using the following query parameters. Please note that you must supply either all of the values or none of the values. &lt;ul&gt;&lt;li&gt;min_x&lt;/li&gt;&lt;li&gt;min_y&lt;/li&gt;&lt;li&gt;width&lt;/li&gt;&lt;li&gt;height&lt;/li&gt;&lt;/ul&gt;
        ///
        /// See [Vendors, Customers, and Companies](https://developer.lockstep.io/docs/companies-customers-and-vendors) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Company; NOT the customer's ERP key</param>
        /// <param name="min_x">ViewBox minX setting for this Company's logo.</param>
        /// <param name="min_y">ViewBox minY setting for this Company's logo.</param>
        /// <param name="width">ViewBox width setting for this Company's logo.</param>
        /// <param name="height">ViewBox height setting for this Company's logo.</param>
        /// <param name="filename">The full path of a file to upload to the API</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<CompanyModel>> SetCompanyLogo(Guid id, string filename, decimal? min_x = null, decimal? min_y = null, decimal? width = null, decimal? height = null)
        {
            var url = $"/api/v1/Companies/{id}/logo";
            var options = new Dictionary<string, object>();
            if (min_x != null) { options["min_x"] = min_x; }
            if (min_y != null) { options["min_y"] = min_y; }
            if (width != null) { options["width"] = width; }
            if (height != null) { options["height"] = height; }
            return await _client.Request<CompanyModel>(HttpMethod.Post, url, options, null, filename);
        }

        /// <summary>
        /// Update view box meta data for the given Company id.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Company; NOT the customer's ERP key</param>
        /// <param name="body">The `ViewBoxSettingsModel` containing meta data value updates</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<CompanyModel>> Updatelogoviewboxsettings(Guid id, ViewBoxSettingsModel body)
        {
            var url = $"/api/v1/Companies/{id}/logo-settings";
            return await _client.Request<CompanyModel>(new HttpMethod("PATCH"), url, null, body, null);
        }
    }
}
