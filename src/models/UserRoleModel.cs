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
    /// Represents a role for a user
    /// </summary>
    public class UserRoleModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS Platform when this record is
        /// added to the ADS Platform.
        /// </summary>
        public Guid? UserRoleId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The name of the user role
        /// </summary>
        public string UserRoleName { get; set; }

        /// <summary>
        /// The date that the user role was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the user role
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the user role was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the user role
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
