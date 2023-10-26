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



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// An Financial account refers to records of assets, liabilities, income, expenses, and equity.
    /// </summary>
    public class FinancialAccountModel
    {

        /// <summary>
        /// The unique identifier for the Financial Account.
        /// </summary>
        public Guid? FinancialAccountId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

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
        /// The App Enrollment Id for the Financial Account.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The name of the Financial Account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The status of the Financial Account. Possible values are Active,
        /// Inactive, Deleted or Archived.
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

        /// <summary>
        /// The date the FinancialAccount was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The user that has created the Financial Account.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the Financial Account was modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The user that has modified the Financial Account.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
