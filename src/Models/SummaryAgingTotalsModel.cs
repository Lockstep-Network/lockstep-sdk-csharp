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
    /// Represents summary aging bucket total.
    /// </summary>
    public class SummaryAgingTotalsModel
    {

        /// <summary>
        /// Aging bucket outstanding balance is associated to.
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Aging outstanding balance value.
        /// </summary>
        public decimal? OutstandingBalance { get; set; }
    }
}
