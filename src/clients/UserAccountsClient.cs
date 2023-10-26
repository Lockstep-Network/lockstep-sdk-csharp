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
    /// API methods related to UserAccounts
    /// </summary>
    public class UserAccountsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserAccountsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the User with this identifier.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the User to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Notes, Attachments, CustomFields, AccountingRole</param>
        public async Task<LockstepResponse<UserAccountModel>> RetrieveUser(Guid id, string include = null)
        {
            var url = $"/api/v1/UserAccounts/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<UserAccountModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates a User that matches the specified id with the requested information. The following limitations are applied when updating a user:
        ///
        /// &lt;list type=&quot;bullet&quot;&gt;&lt;item&gt;Only Group Owners and Admins can change other users.&lt;/item&gt;&lt;item&gt;When updating another user, only the role and status can be updated.&lt;/item&gt;&lt;item&gt;A user can only change their own status when their current status is Onboarding.&lt;/item&gt;&lt;item&gt;A user can never change their own role.&lt;/item&gt;&lt;item&gt;Nobody can change the owner&#39;s role or status. See the &quot;/transfer-owner&quot; route for changing the owner.&lt;/item&gt;&lt;item&gt;A user can change their own personal information.&lt;/item&gt;&lt;/list&gt;
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the User to retrieve</param>
        /// <param name="body">A list of changes to apply to this User</param>
        public async Task<LockstepResponse<UserAccountModel>> UpdateUser(Guid id, object body)
        {
            var url = $"/api/v1/UserAccounts/{id}";
            return await _client.Request<UserAccountModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Disable the user referred to by this unique identifier.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this User</param>
        public async Task<LockstepResponse<ActionResultModel>> DisableUser(Guid id)
        {
            var url = $"/api/v1/UserAccounts/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Invite a user with the specified email to join your accounting group. The user will receive an email to set up their account.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="body">The user to invite</param>
        public async Task<LockstepResponse<InviteModel[]>> InviteUser(InviteSubmitModel[] body)
        {
            var url = $"/api/v1/UserAccounts/invite";
            return await _client.Request<InviteModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Retrieves invite information for the specified invite token.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="code">The code of the invite</param>
        public async Task<LockstepResponse<InviteDataModel>> RetrieveInviteData(Guid? code = null)
        {
            var url = $"/api/v1/UserAccounts/invite";
            var options = new Dictionary<string, object>();
            if (code != null) { options["code"] = code; }
            return await _client.Request<InviteDataModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Transfer the ownership of a group to another user. This API must be called by the current owner of the group.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="body"></param>
        public async Task<LockstepResponse<TransferOwnerModel>> TransferOwner(TransferOwnerSubmitModel body)
        {
            var url = $"/api/v1/UserAccounts/transfer-owner";
            return await _client.Request<TransferOwnerModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Users for this account using the specified filtering, sorting, nested fetch, and pagination rules requested. A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Notes, Attachments, CustomFields, AccountingRole</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<UserAccountModel>>> QueryUsers(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/UserAccounts/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<UserAccountModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Change the active GroupKey of the calling user.
        ///
        /// A User represents a person who has the ability to authenticate against the Lockstep Platform and use services such as Lockstep Inbox.  A User is uniquely identified by an Azure identity, and each user must have an email address defined within their account.  All Users must validate their email to make use of Lockstep platform services.  Users may have different privileges and access control rights within the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="groupKey"></param>
        public async Task<LockstepResponse<UserAccountModel>> ChangeUserGroup(Guid groupKey)
        {
            var url = $"/api/v1/UserAccounts/change-group";
            var options = new Dictionary<string, object>();
            options["groupKey"] = groupKey;
            return await _client.Request<UserAccountModel>(HttpMethod.Post, url, options, null, null);
        }

        /// <summary>
        /// Retrieves the user data for the current user. This allows for retrieving extended user data such as UTM parameters.
        ///
        /// </summary>
        /// <param name="include">The set of data to retrieve. To avoid any casing confusion, these values are converted to upper case. Possible values are: UTM</param>
        public async Task<LockstepResponse<UserDataResponseModel>> GetUserData(string[] include)
        {
            var url = $"/api/v1/UserAccounts/user-data";
            var options = new Dictionary<string, object>();
            options["include"] = include;
            return await _client.Request<UserDataResponseModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Set support access for the calling user.
        ///
        /// Support access allows Lockstep to access the user&#39;s account to troubleshoot issues. Access is granted for a limited time, can be revoked at any time, and requires a code to verify the access.
        ///
        /// Every call to this API will regenerate the support access code.
        ///
        /// </summary>
        /// <param name="body"></param>
        public async Task<LockstepResponse<SupportAccessModel>> SetSupportAccess(SupportAccessRequest body)
        {
            var url = $"/api/v1/UserAccounts/support-access";
            return await _client.Request<SupportAccessModel>(HttpMethod.Post, url, null, body, null);
        }
    }
}
