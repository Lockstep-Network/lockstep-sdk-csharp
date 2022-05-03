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

namespace LockstepSDK
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
        public decimal? AmountPaidLast30 { get; set; }

        /// <summary>
        /// The outstanding advance pay balance with this Vendor
        /// </summary>
        public decimal? AdvancePayOutstanding { get; set; }

        /// <summary>
        /// The amount billed from this Vendor in the last 30 days
        /// </summary>
        public decimal? AmountBilledLast30 { get; set; }

        /// <summary>
        /// The outstanding balance with this Vendor
        /// </summary>
        public decimal? AmountBilledOutstanding { get; set; }

        /// <summary>
        /// The number of open bills with this Vendor
        /// </summary>
        public int? OpenBillCount { get; set; }

        /// <summary>
        /// The number of bills paid to this Vendor in the last 30 days
        /// </summary>
        public int? PaidBillCount { get; set; }

        /// <summary>
        /// The total count of open bills and those paid in the last 30 days
        /// </summary>
        public int? TotalBillCount { get; set; }
    }
}
