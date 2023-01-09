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
    /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to
    /// calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync
    /// or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
    /// </summary>
    public class FinancialYearSettingModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? FinancialYearSettingId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

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
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// The end date of the financial year. Should be entered in MM-DD format.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// The date on which this financial year setting record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this financial year setting.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this financial year setting record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this financial year setting.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
