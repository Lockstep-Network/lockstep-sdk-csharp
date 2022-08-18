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



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// The FinancialAccountSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the FinancialAccountSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [FinancialAccountModel](https://developer.lockstep.io/docs/financialaccountmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class FinancialAccountSyncModel
    {

        /// <summary>
        /// The code for the Financial Account. Can either be a general ledger or
        /// an account code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The External Id for the Financial Account.
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The name of the Financial Account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The status of the Financial Account. Possible values are active,
        /// inactive, deleted or archived.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The cashflow type for the Financial Account. Examples include cash, financing, investment
        /// or operation.
        /// </summary>
        public string CashflowType { get; set; }

        /// <summary>
        /// The description for the Financial Account.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The classification for the Financial Account. Possible values are Asset, Equity,
        /// Expense, Liability or Income.
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// The category for the Financial Account. Examples include Current Asset, Current Liability, Common Stock
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The subcategory for the Financial Account. Examples include Cash, Property, Bank Loan, etc.
        /// </summary>
        public string Subcategory { get; set; }
    }
}
