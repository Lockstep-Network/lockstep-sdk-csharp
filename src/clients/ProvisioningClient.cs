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
 * @version    2022.4
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



public class ProvisioningClient
{
    private readonly LockstepApi _client;

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
        return await _client.Request<ProvisioningResponseModel>(HttpMethod.Post, url, null, body);
    }

    /// <summary>
    /// Updates user, company and group metadata for a User of status 'Onboarding' and finalizes a user's onboarding process by changing the user status to 'Active'
    ///
    /// </summary>
    /// <param name="body">Represents a User and their related metadata</param>
    public async Task<LockstepResponse<ProvisioningResponseModel>> FinalizeUserAccountProvisioning(ProvisioningFinalizeRequestModel body)
    {
        var url = $"/api/v1/Provisioning/finalize";
        return await _client.Request<ProvisioningResponseModel>(HttpMethod.Post, url, null, body);
    }

    /// <summary>
    ///
    ///
    /// </summary>
    /// <param name="body"></param>
    public async Task<LockstepResponse<ActionResultModel>> ProvisionFreeDeveloperAccount(DeveloperAccountSubmitModel body)
    {
        var url = $"/api/v1/Provisioning/free-account";
        return await _client.Request<ActionResultModel>(HttpMethod.Post, url, null, body);
    }
}
