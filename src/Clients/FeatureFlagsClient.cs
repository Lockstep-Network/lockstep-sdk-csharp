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
    /// API methods related to FeatureFlags
    /// </summary>
    public class FeatureFlagsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public FeatureFlagsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the specified feature flags. True if they are enabled, false otherwise.
        ///
        /// </summary>
        /// <param name="body"></param>
        public async Task<LockstepResponse<FeatureFlagsResponseModel>> RetrieveFeatureFlags(FeatureFlagsRequestModel body)
        {
            var url = $"/api/v1/feature-flags";
            return await _client.Request<FeatureFlagsResponseModel>(HttpMethod.Post, url, null, body, null);
        }
    }
}
