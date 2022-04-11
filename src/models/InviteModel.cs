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
    /// Model from the User invite process
    /// </summary>
    public class InviteModel
    {

        /// <summary>
        /// The invited email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// True if the invite was sent successfully
        /// </summary>
        public bool? Success { get; set; }

        /// <summary>
        /// The invited user, may be null if the user could not be invited
        /// </summary>
        public UserAccountModel InvitedUser { get; set; }

        /// <summary>
        /// The error message if the invite was not successful
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
