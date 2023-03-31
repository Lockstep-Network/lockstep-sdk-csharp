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
    /// Represents the request to the SAGE GMS API
    /// </summary>
    public class EmailReplyGeneratorRequest
    {

        /// <summary>
        /// The date associated with the email
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// The body associated with the email
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The subject associated with the email
        /// </summary>
        public string Subject { get; set; }
    }
}
