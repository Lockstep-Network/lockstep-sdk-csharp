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



using RestSharp;

public class MigrationClient
{
    private readonly LockstepApi client;

    public MigrationClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Migrates all customer data from the Lockstep Collect system to the API, including all stored data for contacts, companies, payments, and invoices.
    /// 
    /// </summary>
    public async Task<LockstepResponse<MigrationResultModel>> MigrateData()
    {
        var url = $"/api/v1/Migration";
        return await this.client.Request<MigrationResultModel>(Method.POST, url, null, null);
    }

    /// <summary>
    /// Lists all of the customer, contact, payment, and invoice data currently available for Migration.
    /// 
    /// </summary>
    public async Task<LockstepResponse<AvailableMigrationsModel>> ListMigrations()
    {
        var url = $"/api/v1/Migration/list";
        return await this.client.Request<AvailableMigrationsModel>(Method.GET, url, null, null);
    }
}
