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
    /// Contains information about the user&#39;s magic link
    /// </summary>
    public class MagicLinkStatusModel
    {

        /// <summary>
        /// The id of the Magic link used to authenticate.
        /// </summary>
        public Guid? MagicLinkId { get; set; }

        /// <summary>
        /// The id of the application for the Magic Link
        /// </summary>
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// The id of the target company for the Magic Link
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The id of the accounting profile for the Magic Link
        /// </summary>
        public Guid? AccountingProfileId { get; set; }

        /// <summary>
        /// The UTC date and time when this magic link expires.
        /// </summary>
        public DateTime? Expires { get; set; }
    }
}
