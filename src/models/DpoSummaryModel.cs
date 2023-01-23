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
    /// Represents a summary of outstanding amounts for bills to vendors and their associated daily payable outstanding value.
    /// </summary>
    public class DpoSummaryModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of the vendor.
        /// </summary>
        public Guid? VendorId { get; set; }

        /// <summary>
        /// The name of the vendor.
        /// </summary>
        public string VendorName { get; set; }

        /// <summary>
        /// The name of the primary contact.
        /// </summary>
        public string PrimaryContact { get; set; }

        /// <summary>
        /// The total number of outstanding bills.
        /// </summary>
        public int? Bills { get; set; }

        /// <summary>
        /// The group&#39;s base currency code.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The total amount outstanding at the group&#39;s base currency.
        /// </summary>
        public decimal? AmountOutstanding { get; set; }

        /// <summary>
        /// The days payable outstanding value.
        /// </summary>
        public decimal? Dpo { get; set; }
    }
}
