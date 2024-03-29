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
    /// Represents the daily sales outstanding report
    /// </summary>
    public class DailySalesOutstandingReportModel
    {

        /// <summary>
        /// Timeframe (month) the daily sales outstanding values are associated with
        /// </summary>
        public DateTime? Timeframe { get; set; }

        /// <summary>
        /// Time (in days) between an invoice was completed paid off and when the invoice was issued
        /// </summary>
        public decimal? DailySalesOutstanding { get; set; }
    }
}
