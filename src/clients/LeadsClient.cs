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
    /// API methods related to Leads
    /// </summary>
    public class LeadsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public LeadsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates one or more Leads within the Lockstep platform and returns the records as created.
        ///
        /// A Lead is a person who is interested in the Lockstep platform but needs certain new features in order to use it. If you are interested in the Lockstep platform, you can create a lead with your information and our team will prioritize the feature you need.
        ///
        /// </summary>
        /// <param name="body">The Leads to create</param>
        public async Task<LockstepResponse<LeadModel[]>> CreateLeads(LeadModel[] body)
        {
            var url = $"/api/v1/Leads";
            return await _client.Request<LeadModel[]>(HttpMethod.Post, url, null, body, null);
        }
    }
}
