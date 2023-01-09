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
    /// Represents the result of an action.
    ///
    /// In the Lockstep API, an Action is returned when an API call does not produce any data
    /// but does produce messages that can be useful in understanding what work was performed.
    /// You may use the messages text to display user visible error messages or the results of
    /// various operations.
    /// </summary>
    public class ActionResultModel
    {

        /// <summary>
        /// If the API call produced messages, this element will contain a list of user-visible
        /// text strings that contain information about what work occurred in the API.
        /// </summary>
        public string[] Messages { get; set; }
    }
}
