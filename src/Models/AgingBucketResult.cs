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
    /// The aging data for an individual bucket
    /// </summary>
    public class AgingBucketResult
    {

        /// <summary>
        /// The different buckets used for aging.
        /// </summary>
        public int? Bucket { get; set; }

        /// <summary>
        /// The outstanding amount for the given bucket in the group&#39;s base currency.
        /// </summary>
        public decimal? Value { get; set; }
    }
}
