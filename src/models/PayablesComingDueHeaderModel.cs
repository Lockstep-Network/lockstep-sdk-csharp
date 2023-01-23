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
    /// Contains summary information for payables that will be due soon
    /// </summary>
    public class PayablesComingDueHeaderModel
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
        /// Number of total vendors for this time period
        /// </summary>
        public int? NumberOfVendors { get; set; }

        /// <summary>
        /// Percentage of total for this time period
        /// </summary>
        public decimal? PercentageOfTotal { get; set; }

        /// <summary>
        /// The group&#39;s base currency code.
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// Total amount due for this time period in the group&#39;s base currency.
        /// </summary>
        public decimal? TotalAmountDue { get; set; }

        /// <summary>
        /// This model represents all the payables that are
        /// either already due or due within this date.
        /// </summary>
        public DateTime? DueDate { get; set; }
    }
}
