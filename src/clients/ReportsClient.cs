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
    /// API methods related to Reports
    /// </summary>
    public class ReportsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ReportsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Generates an AR Aging Report.
        ///
        /// </summary>
        /// <param name="reportDate">The date used for calculation of days overdue. Defaults to current UTC date.</param>
        /// <param name="companyId">An optional Company ID to filter the aging to a specific company.</param>
        public async Task<LockstepResponse<AgingModel>> ARAgingReport(DateTime? reportDate = null, Guid? companyId = null)
        {
            var url = $"/api/v1/Reports/ar/aging";
            var options = new Dictionary<string, object>();
            if (reportDate != null) { options["reportDate"] = reportDate; }
            if (companyId != null) { options["companyId"] = companyId; }
            return await _client.Request<AgingModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Generates an AP Aging Report.
        ///
        /// </summary>
        /// <param name="reportDate">The date used for calculation of days overdue. Defaults to current UTC date.</param>
        public async Task<LockstepResponse<AgingModel>> APAgingReport(DateTime? reportDate = null)
        {
            var url = $"/api/v1/Reports/ap/aging";
            var options = new Dictionary<string, object>();
            if (reportDate != null) { options["reportDate"] = reportDate; }
            return await _client.Request<AgingModel>(HttpMethod.Get, url, options, null, null);
        }
    }
}
