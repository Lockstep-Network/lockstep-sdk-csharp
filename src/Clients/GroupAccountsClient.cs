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
    /// API methods related to GroupAccounts
    /// </summary>
    public class GroupAccountsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public GroupAccountsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves group account data for the current user.
        ///
        /// </summary>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<GroupAccountModel>> RetrieveGroupAccountData()
        {
            var url = $"/api/v1/GroupAccounts/me";
            return await _client.Request<GroupAccountModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates a group account that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Group Account to retrieve</param>
        /// <param name="body">A list of changes to apply to this Group Account</param>
        [Obsolete("This endpoint is deprecated.")]
        public async Task<LockstepResponse<GroupAccountModel>> UpdateGroupAccount(Guid id, object body)
        {
            var url = $"/api/v1/GroupAccounts/{id}";
            return await _client.Request<GroupAccountModel>(new HttpMethod("PATCH"), url, null, body, null);
        }
    }
}
