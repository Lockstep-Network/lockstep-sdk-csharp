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



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// The FinancialYearSettingSyncModel represents information coming into ADS from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the FinancialYearSettingSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// Once imported, this record will be available in the ADS Platform API as a [FinancialYearSettingModel](https://developer.lockstep.io/docs/financialyearsettingmodel).
    /// Sync is supported for only one FinancialYearSetting per app enrollment and one FinancialYearSetting imported outside of
    /// an app enrollment - please submit only one model here.  If multiple models are submitted, only the latest one is considered for Sync.
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class FinancialYearSettingSyncModel
    {

        /// <summary>
        /// The type of financial year, either Calendar or Fiscal.
        /// </summary>
        public string YearType { get; set; }

        /// <summary>
        /// Total number of periods in the year. For Calendar year types this should always be 12. For Fiscal year types
        /// this can either be 12 or 13 for a 4 week 13 period year.
        /// </summary>
        public int? TotalPeriods { get; set; }

        /// <summary>
        /// The start date of the financial year. Should be entered in MM-DD format.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// The end date of the financial year. Should be entered in MM-DD format.
        /// </summary>
        public string EndDate { get; set; }
    }
}
