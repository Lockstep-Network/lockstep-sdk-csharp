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
    /// API methods related to Contacts
    /// </summary>
    public class ContactsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ContactsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Contact specified by this unique identifier, optionally including nested data sets.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Contact; NOT the customer's ERP key</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        public async Task<LockstepResponse<ContactModel>> RetrieveContact(Guid id, string include = null)
        {
            var url = $"/api/v1/Contacts/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<ContactModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates a contact that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Contact to update; NOT the customer's ERP key</param>
        /// <param name="body">A list of changes to apply to this Contact</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<ContactModel>> UpdateContact(Guid id, object body)
        {
            var url = $"/api/v1/Contacts/{id}";
            return await _client.Request<ContactModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Delete the Contact referred to by this unique identifier.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Contact to delete; NOT the customer's ERP key</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<DeleteResult>> DeleteContact(Guid id)
        {
            var url = $"/api/v1/Contacts/{id}";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more contacts from a given model.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="body">The Contacts to create</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<ContactModel[]>> CreateContacts(ContactModel[] body)
        {
            var url = $"/api/v1/Contacts";
            return await _client.Request<ContactModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Delete the Contacts referred to by these unique identifiers.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="body">The unique ADS Platform ID numbers of the Contacts to delete; NOT the customer's ERP keys</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<DeleteResult>> DeleteContacts(BulkDeleteRequestModel body)
        {
            var url = $"/api/v1/Contacts";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, body, null);
        }

        /// <summary>
        /// Queries Contacts for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<ContactModel>>> QueryContacts(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Contacts/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<ContactModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
