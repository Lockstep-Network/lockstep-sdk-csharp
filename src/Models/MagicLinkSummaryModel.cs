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
    /// A historic summary of all magic links sent in a given group
    /// </summary>
    public class MagicLinkSummaryModel
    {

        /// <summary>
        /// Group that the summary is for
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Total number of magic links sent
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// Total number of magic links that failed to send
        /// </summary>
        public int? TotalBounced { get; set; }

        /// <summary>
        /// Total number of visits across all magic links
        /// </summary>
        public int? TotalVisited { get; set; }
    }
}
