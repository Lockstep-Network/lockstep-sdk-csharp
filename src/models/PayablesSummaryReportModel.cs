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
    /// Represents the payables summary report based on a timeframe
    /// </summary>
    public class PayablesSummaryReportModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Timeframe in days the payables summary report is generated on
        /// </summary>
        public int? Timeframe { get; set; }

        /// <summary>
        /// Amount of payments made based in the timeframe
        /// </summary>
        public decimal? TotalPaymentsAmount { get; set; }

        /// <summary>
        /// Number of payments made based in the timeframe
        /// </summary>
        public int? TotalPaymentsCount { get; set; }

        /// <summary>
        /// Amount of bills received based in the timeframe
        /// </summary>
        public decimal? TotalAmountBilled { get; set; }

        /// <summary>
        /// Number of bills received in the timeframe
        /// </summary>
        public int? TotalBillsCount { get; set; }
    }
}
