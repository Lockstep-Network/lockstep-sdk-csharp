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
    /// A summary of AR Aging for a given Group Key. This aging data is presented
    /// in buckets of days overdue in the group&#39;s base currency.
    /// </summary>
    public class AgingModel
    {

        /// <summary>
        /// The Group Key the aging data is calculated for.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The total AR outstanding amount in the group&#39;s base currency.
        /// </summary>
        public decimal? Total { get; set; }

        /// <summary>
        /// The outstanding amount in the group&#39;s base currency, grouped by days overdue.
        /// </summary>
        public AgingBucketResult[] Buckets { get; set; }
    }
}
