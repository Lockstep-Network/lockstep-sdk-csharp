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
    /// Represents the response from SAGE GMS API
    /// </summary>
    public class EmailReplyGeneratorResponse
    {

        /// <summary>
        /// The id for this request in the GMS system
        /// </summary>
        public Guid? Message_id { get; set; }

        /// <summary>
        /// A list of suggested email reply responses
        /// </summary>
        public EmailReplyGeneratorSuggestions[] Suggestions { get; set; }
    }
}
