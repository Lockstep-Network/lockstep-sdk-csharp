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
    /// Represents the daily payable outstanding report
    /// </summary>
    public class DailyPayableOutstandingReportModel
    {

        /// <summary>
        /// Timeframe (quarter) the daily payable outstanding values are associated with
        /// </summary>
        public DateTime? Timeframe { get; set; }

        /// <summary>
        /// Number of invoices the average daily payable outstanding is calculated on
        /// </summary>
        public int? InvoiceCount { get; set; }

        /// <summary>
        /// Time (in days) between an invoice was completed paid off and when the invoice was issued
        /// </summary>
        public decimal? DailyPayableOutstanding { get; set; }
    }
}
