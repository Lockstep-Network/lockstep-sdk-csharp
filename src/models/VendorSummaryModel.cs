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
    /// Contains summarized data for a vendor
    /// </summary>
    public class VendorSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this Vendor
        /// </summary>
        public Guid? VendorId { get; set; }

        /// <summary>
        /// The name of this Vendor
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// The app enrollment ID this Vendor is associated with
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The name of this Vendor&#39;s primary contact
        /// </summary>
        public string PrimaryContactName { get; set; }

        /// <summary>
        /// This Vendor&#39;s primary contact id
        /// </summary>
        public Guid? PrimaryContactId { get; set; }

        /// <summary>
        /// The amount paid to this Vendor in the last 30 days
        /// </summary>
        public decimal? AmountPaidPastThirtyDays { get; set; }

        /// <summary>
        /// The outstanding advance pay balance on payments in the last 30 days
        /// </summary>
        public decimal? AdvancePayPastThirtyDays { get; set; }

        /// <summary>
        /// The outstanding advance pay balance with this Vendor
        /// </summary>
        public decimal? AdvancePayOutstanding { get; set; }

        /// <summary>
        /// The amount billed from this Vendor in the last 30 days
        /// </summary>
        public decimal? AmountBilledPastThirtyDays { get; set; }

        /// <summary>
        /// The outstanding balance with this Vendor for bills in the last 30 days
        /// </summary>
        public decimal? AmountBilledOutstandingPastThirtyDays { get; set; }

        /// <summary>
        /// The outstanding balance with this Vendor
        /// </summary>
        public decimal? AmountBilledOutstanding { get; set; }

        /// <summary>
        /// The number of bills received from this Vendor in the last 30 days
        /// </summary>
        public int? BillCountPastThirtyDays { get; set; }

        /// <summary>
        /// The number of bills from this Vendor that were paid in full in the last 30 days
        /// </summary>
        public int? PaidBillCountPastThirtyDays { get; set; }

        /// <summary>
        /// The number of open bills with this Vendor
        /// </summary>
        public int? OpenBillCount { get; set; }

        /// <summary>
        /// The number of bills paid to this Vendor
        /// </summary>
        public int? PaidBillCount { get; set; }

        /// <summary>
        /// The total count of open and closed bills.
        /// </summary>
        public int? TotalBillCount { get; set; }

        /// <summary>
        /// The days payabale outstanding.
        /// </summary>
        public decimal? Dpo { get; set; }

        /// <summary>
        /// The modified date of the Vendor
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
