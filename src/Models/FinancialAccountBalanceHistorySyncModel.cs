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
    /// The FinancialAccountBalanceHistorySyncModel represents information coming into ADS from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the FinancialAccountBalanceHistorySyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// If the FinancialAccountBalanceHistorySyncModels are imported via a connector instead, please ensure that all records are passed in
    /// on every sync. Records that are not passed in will be assumed to be deleted.
    ///
    /// Once imported, this record will be available in the ADS Platform API as a [FinancialAccountBalanceHistoryModel](https://developer.lockstep.io/docs/financialaccountbalancehistorymodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class FinancialAccountBalanceHistorySyncModel
    {

        /// <summary>
        /// The code for the Financial Account. Can either be a general ledger or
        /// an account code.
        /// </summary>
        public string FinancialAccountCode { get; set; }

        /// <summary>
        /// This is the primary key of the FinancialAccount record. For this field, you should use whatever the company&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        /// Example: If you store your company records in a database, whatever the primary key for the company table is
        /// in the database should be the ErpKey.
        /// Example: If you use a financial system such as QuickBooks or Xero, look for the primary ID number of the
        /// company record within that financial system.
        /// </summary>
        public string FinancialAccountErpKey { get; set; }

        /// <summary>
        /// The financial year that this period falls under
        /// </summary>
        public int? FinancialYear { get; set; }

        /// <summary>
        /// The period number (1-12 or 1-13) that this balance history is for
        /// </summary>
        public int? PeriodNumber { get; set; }

        /// <summary>
        /// The start date of this period.
        /// </summary>
        public DateTime? PeriodStartDate { get; set; }

        /// <summary>
        /// The end date of this period.
        /// </summary>
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// The status of this period. The status should be Closed if the books for this period have been closed,
        /// if not the status should be Open. The status can also be Deleted if there was a recalculation that needed
        /// to occur, for example due to a change in financial year settings.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The current or end balance of this period.
        /// </summary>
        public decimal? Balance { get; set; }

        /// <summary>
        /// The balance type of this period. If left null, the balance type will be determined by the balance.
        /// </summary>
        public int? BalanceType { get; set; }
    }
}
