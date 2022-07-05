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

using System;
using System.Net;
using LockstepSDK.Models;

namespace LockstepSDK
{
    /// <summary>
    /// Represents a response from a Lockstep Platform API call
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LockstepResponse<T> where T: class
    {
        /// <summary>
        /// True if the API call succeeded
        /// </summary>
        public bool Success { get; internal set; }

        /// <summary>
        /// The HTTP response code provided by the remote server
        /// </summary>
        public HttpStatusCode Status { get; internal set; }

        /// <summary>
        /// If successful, this contains the results of the API call
        /// </summary>
        public T Value { get; internal set; }

        /// <summary>
        /// If this API retrieved a file, the contents are here
        /// </summary>
        public byte[] FileData { get; internal set; }

        /// <summary>
        /// If not successful, this contains information about the error
        /// </summary>
        public ErrorResult Error { get; internal set; }

        /// <summary>
        /// The length of time, in milliseconds, that the Lockstep Platform server took responding to this request. 
        /// </summary>
        public int ServerDuration { get; set; }

        /// <summary>
        /// The length of time, in milliseconds, that it took to complete this API call including all network delays,
        /// proxy requests, decompression, and JSON parsing.
        /// </summary>
        public long TotalRoundtrip { get; set; }
    }
}