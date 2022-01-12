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
 * @version    2022.2
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



public class LeadsClient
{
    private readonly LockstepApi _client;

    public LeadsClient(LockstepApi client) {
        _client = client;
    }

    /// <summary>
    /// Creates one or more Leads within the Lockstep platform and returns the records as created.
    /// 
    /// A Lead is a person who is interested in the Lockstep platform but needs certain new features in order to use it. If you are interested in the Lockstep platform, you can create a lead with your information and our team will prioritize the feature you need.
    /// </summary>
    /// <param name="body">The Leads to create</param>
    public async Task<LockstepResponse<LeadModel[]>> CreateLeads(LeadModel[]? body)
    {
        var url = $"/api/v1/Leads";
        return await _client.Request<LeadModel[]>(HttpMethod.Post, url, null, body);
    }
}
