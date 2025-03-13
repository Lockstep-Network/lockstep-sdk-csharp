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
    /// Contains data about the current user.
    /// </summary>
    public class UserDataResponseModel
    {

        /// <summary>
        /// Data about the user, the properties returned will depend on the requested information.
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// The ADS Platform ID of the user
        /// </summary>
        public Guid? UserId { get; set; }
    }
}
