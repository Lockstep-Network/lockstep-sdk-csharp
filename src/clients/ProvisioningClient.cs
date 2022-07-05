/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
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
    /// API methods related to Provisioning
    /// </summary>
    public class ProvisioningClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProvisioningClient(LockstepApi client)
        {
            _client = client;
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
