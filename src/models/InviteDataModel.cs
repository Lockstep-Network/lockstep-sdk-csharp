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
    /// Model containing information about a user for the invite/onboarding process.
    /// </summary>
    public class InviteDataModel
    {

        /// <summary>
        /// The email address of the invited user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The status of the user.
        /// </summary>
        public string UserStatus { get; set; }
    }
}
