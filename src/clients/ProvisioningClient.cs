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
    /// Lockstep Platform methods related to Provisioning
    /// </summary>
    public class ProvisioningClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProvisioningClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Creates a new User or updates an Invited user based on metadata provided by the User during the onboarding process
        ///
        /// </summary>
        /// <param name="body">Represents a User and their related metadata</param>
        public async Task<LockstepResponse<ProvisioningResponseModel>> ProvisionUserAccount(ProvisioningModel body)
        {
            var url = $"/api/v1/Provisioning";
            return await _client.Request<ProvisioningResponseModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Updates user, company and group metadata for a User of status &#39;Onboarding&#39; and finalizes a user&#39;s onboarding process by changing the user status to &#39;Active&#39;
        ///
        /// </summary>
        /// <param name="body">Represents a User and their related metadata</param>
        public async Task<LockstepResponse<ProvisioningResponseModel>> FinalizeUserAccountProvisioning(ProvisioningFinalizeRequestModel body)
        {
            var url = $"/api/v1/Provisioning/finalize";
            return await _client.Request<ProvisioningResponseModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Creates a new account for a developer, sending an email with information on how to access the API.
        /// </summary>
        /// <param name="body"></param>
        public async Task<LockstepResponse<ActionResultModel>> ProvisionFreeDeveloperAccount(DeveloperAccountSubmitModel body)
        {
            var url = $"/api/v1/Provisioning/free-account";
            return await _client.Request<ActionResultModel>(HttpMethod.Post, url, null, body, null);
        }
    }
}
