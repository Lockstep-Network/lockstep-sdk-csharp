/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// The totals for a Payment Summary
    /// </summary>
    public class PaymentSummaryTotalsModel
    {

        /// <summary>
        /// The total amount paid.
        /// </summary>
        public decimal? TotalPaidAmount { get; set; }

        /// <summary>
        /// The total amount unapplied.
        /// </summary>
        public decimal? TotalUnappliedBalance { get; set; }
    }
}
