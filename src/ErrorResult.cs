/***
 * Lockstep Software Development Kit for C#
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

using System.Collections.Generic;

namespace LockstepSDK
{
    /// <summary>
    /// Represents a failed API request.
    /// </summary>
    public class ErrorResult
    {
        /// <summary>
        /// A description of the type of error that occurred.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// A short title describing the error.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// If an error code is applicable, this contains an error number.
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// The set of errors that occurred.
        /// </summary>
        public Dictionary<string, string[]> Errors { get; set; }

        /// <summary>
        /// The full content of the HTTP response.
        /// </summary>
        public string Content { get; set; }
    }
}
