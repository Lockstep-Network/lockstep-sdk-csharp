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
    /// Represents a balance for a financial account for a given period of time.
    /// </summary>
    public class FinancialAccountBalanceHistoryModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? FinancialAccountBalanceHistoryId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The id of the Financial Account that this balance history is for.
        /// </summary>
        public Guid? FinancialAccountId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

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
        /// Financial Account Balance Types
        /// </summary>
        public int? BalanceType { get; set; }

        /// <summary>
        /// The name of the BalanceType for this record.
        /// </summary>
        public string BalanceTypeName { get; set; }

        /// <summary>
        /// The date on which this financial account balance history record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this financial account balance history.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this financial account balance history record was modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this financial account balance history.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
