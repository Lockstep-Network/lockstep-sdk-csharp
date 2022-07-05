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
    /// Contains information for payables that will be due soon
    /// </summary>
    public class PayablesComingDueModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Number of bills due for this time period
        /// </summary>
        public int? NumberOfBillsDue { get; set; }

        /// <summary>
        /// The unique Lockstep Id for the Vendor
        /// </summary>
        public Guid? VendorId { get; set; }

        /// <summary>
        /// Name for this company
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// Primary Contact for this company
        /// </summary>
        public string PrimaryContact { get; set; }

        /// <summary>
        /// Percentage of total for this time period
        /// </summary>
        public decimal? PercentageOfTotal { get; set; }

        /// <summary>
        /// Total amount due for this time period
        /// </summary>
        public decimal? TotalAmountDue { get; set; }

        /// <summary>
        /// This model represents all the payables that are
        /// either already due or due within this date.
        /// </summary>
        public DateTime? DueDate { get; set; }
    }
}
