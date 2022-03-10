/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2021 Lockstep, Inc.
 * @version    2021.39
 * @link       https://github.com/tspence/lockstep-sdk-csharp
 */

namespace LockstepSDK
{

    /// <summary>
    /// Represents a response to an API action that does not return data
    /// </summary>
    public class ActionResultModel
    {
        /// <summary>
        /// A list of messages returned by this API call
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string[] Messages { get; internal set; }
#else
        public string[]? Messages { get; internal set; }
#endif
    }
}