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
    /// Information about result of delete operations
    /// </summary>
    public class DeleteResult
    {

        /// <summary>
        /// If the API call produced messages, this element will contain a list of user-visible
        /// text strings that contain information about what work occurred in the API.
        /// </summary>
        public string[] Messages { get; set; }
    }
}
