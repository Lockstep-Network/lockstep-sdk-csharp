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
    /// Contains information about a sync process for an entity.
    /// </summary>
    public class SyncEntityResultModel
    {

        /// <summary>
        /// The number of entities inserted
        /// </summary>
        public int? InsertCount { get; set; }

        /// <summary>
        /// The number of entities updated
        /// </summary>
        public int? UpdateCount { get; set; }

        /// <summary>
        /// The number of entities deleted
        /// </summary>
        public int? DeleteCount { get; set; }

        /// <summary>
        /// The number of entities skipped
        /// </summary>
        public int? SkipCount { get; set; }

        /// <summary>
        /// The number of errors encountered during sync
        /// </summary>
        public int? ErrorCount { get; set; }

        /// <summary>
        /// The errors encountered during sync keyed by ERP key
        /// </summary>
        public object Errors { get; set; }
    }
}
