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
    /// Represents an aging record
    /// </summary>
    public class AgingModel
    {

        /// <summary>
        /// Aging bucket of outstanding balance data (days past due date of invoice)
        /// </summary>
        public int? Bucket { get; set; }

        /// <summary>
        /// Currency code of aging bucket
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Outstanding balance for the given aging bucket
        /// </summary>
        public decimal? OutstandingBalance { get; set; }
    }
}
