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
    /// Contains information for Lockstep to support/assist a user.
    /// </summary>
    public class SupportAccessModel
    {

        /// <summary>
        /// The code required to assist the user.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The UTC date and time when the support access will expire.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }
    }
}
