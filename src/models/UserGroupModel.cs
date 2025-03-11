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
    /// A UserGroup represents the groups that the user is a member of.
    /// A user may have varying permissions/access within a Group.
    /// </summary>
    public class UserGroupModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The name of the Permission Level for the group.
        /// </summary>
        public string UserRole { get; set; }

        /// <summary>
        /// The name of the group
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// The user&#39;s status in the group
        /// </summary>
        public string Status { get; set; }
    }
}
