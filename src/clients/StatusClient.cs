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
    /// API methods related to Status
    /// </summary>
    public class StatusClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public StatusClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Verifies that your application can successfully call the Lockstep Platform API and returns a successful code regardless of your authentication status or permissions.
        ///
        /// The Ping API can be used to verify that your app is working correctly.  The Ping API will always return 200 OK.  If you call this API and you receive a code other than 200 OK, you should check your network connectivity.  A response code of anything other than 200 means that a routing issue or proxy issue may prevent your application from reaching the Lockstep API
        /// </summary>
        public async Task<LockstepResponse<StatusModel>> Ping()
        {
            var url = $"/api/v1/Status";
            return await _client.Request<StatusModel>(HttpMethod.Get, url, null, null, null);
        }
    }
}
