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
    /// Represents a failed API request
    /// </summary>
    public class ErrorResult
    {
        /// <summary>
        /// A description of the type of error that occurred.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Type { get; internal set; }
#else
        public string? Type { get; internal set; }
#endif

        /// <summary>
        /// A short title describing the error.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Title { get; internal set; }
#else
        public string? Title { get; internal set; }
#endif

        /// <summary>
        /// If an error code is applicable, this contains an error number.
        /// </summary>
        public int? Status { get; internal set; }

        /// <summary>
        /// If detailed information about this error is available, this value contains more information.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Detail { get; internal set; }
#else
        public string? Detail { get; internal set; }
#endif

        /// <summary>
        /// If this error corresponds to a specific instance or object, this field indicates which one.
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Instance { get; internal set; }
#else
        public string? Instance { get; internal set; }
#endif

        /// <summary>
        /// The full content of the HTTP response
        /// </summary>
#if DOT_NET_FRAMEWORK
        public string Content { get; internal set; }
#else
        public string? Content { get; internal set; }
#endif
    }

    /// <summary>
    /// DEPRECATED
    /// </summary>
    public class TestTimeoutException : ErrorResult
    {
    }
}