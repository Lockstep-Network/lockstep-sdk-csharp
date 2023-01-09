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
    /// API methods related to ProfilesAccounting
    /// </summary>
    public class ProfilesAccountingClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProfilesAccountingClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Accounting Profile specified by this unique identifier, optionally including nested data sets.
        ///
        /// An Accounting Profile is a child of a Company Profile, and collectively, they comprise the identity and necessary information for an accounting  team to work with trading partners, financial institutions, auditors, and others. You can use Accounting Profiles to define an accounting function by what the function does and how to interface with the function.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Accounting Profile</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        public async Task<LockstepResponse<AccountingProfileModel>> RetrieveAccountingProfile(Guid id, string include = null)
        {
            var url = $"/api/v1/profiles/accounting/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<AccountingProfileModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an accounting profile that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// An Accounting Profile is a child of a Company Profile, and collectively, they comprise the identity and necessary information for an accounting  team to work with trading partners, financial institutions, auditors, and others. You can use Accounting Profiles to define an accounting function by what the function does and how to interface with the function.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Accounting Profile to update</param>
        /// <param name="body">A list of changes to apply to this Accounting Profile</param>
        public async Task<LockstepResponse<AccountingProfileModel>> UpdateAccountingProfile(Guid id, object body)
        {
            var url = $"/api/v1/profiles/accounting/{id}";
            return await _client.Request<AccountingProfileModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Delete the Accounting Profile referred to by this unique identifier.
        ///
        /// An Accounting Profile is a child of a Company Profile, and collectively, they comprise the identity and necessary information for an accounting  team to work with trading partners, financial institutions, auditors, and others. You can use Accounting Profiles to define an accounting function by what the function does and how to interface with the function.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Accounting Profile to disable</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteAccountingProfile(Guid id)
        {
            var url = $"/api/v1/profiles/accounting/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more accounting profiles from a given model.
        ///
        /// An Accounting Profile is a child of a Company Profile, and collectively, they comprise the identity and necessary information for an accounting  team to work with trading partners, financial institutions, auditors, and others. You can use Accounting Profiles to define an accounting function by what the function does and how to interface with the function.
        ///
        /// </summary>
        /// <param name="body">The Accounting Profiles to create</param>
        public async Task<LockstepResponse<AccountingProfileModel[]>> CreateAccountingProfiles(AccountingProfileModel[] body)
        {
            var url = $"/api/v1/profiles/accounting";
            return await _client.Request<AccountingProfileModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Accounting Profiles for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// An Accounting Profile is a child of a Company Profile, and collectively, they comprise the identity and necessary information for an accounting  team to work with trading partners, financial institutions, auditors, and others. You can use Accounting Profiles to define an accounting function by what the function does and how to interface with the function.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<AccountingProfileModel>>> QueryAccountingProfiles(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/profiles/accounting/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<AccountingProfileModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieves all the Contacts associated with the Accounting Profile by this unique identifier, optionally including nested data sets.
        ///
        /// A Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Accounting Profile</param>
        public async Task<LockstepResponse<ContactModel[]>> RetrieveAllAccountingProfileContacts(Guid id)
        {
            var url = $"/api/v1/profiles/accounting/{id}/contacts/models";
            return await _client.Request<ContactModel[]>(HttpMethod.Get, url, null, null, null);
        }
    }
}
