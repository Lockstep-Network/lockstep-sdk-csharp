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
    /// Represents the group totals for the values found in the daily payable outstanding summary
    /// </summary>
    public class DpoSummaryGroupTotalModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The total number of vendors with outstanding bills
        /// </summary>
        public int? Vendors { get; set; }

        /// <summary>
        /// The total number of bills outstanding
        /// </summary>
        public int? Bills { get; set; }

        /// <summary>
        /// The total amount outstanding
        /// </summary>
        public decimal? AmountOutstanding { get; set; }

        /// <summary>
        /// The total dpo for the group key
        /// </summary>
        public decimal? Dpo { get; set; }
    }
}
