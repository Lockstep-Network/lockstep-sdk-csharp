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

namespace LockstepSDK.Models
{

    /// <summary>
    /// State model for ISO-3166-2
    /// </summary>
    public class StateModel
    {

        /// <summary>
        /// Name of the state
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 2 letter alphabetic code for the given state
        /// </summary>
        public string Alpha2 { get; set; }

        /// <summary>
        /// A different name for a state
        /// </summary>
        public string Aliases { get; set; }
    }
}
