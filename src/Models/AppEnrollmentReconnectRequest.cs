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
    /// Information to reconnect an ERP.
    /// </summary>
    public class AppEnrollmentReconnectRequest
    {

        /// <summary>
        /// The OAuth authentication code.
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// The OAuth authentication code.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the web services account with access permissions.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The access token id for the connector enrollment.
        /// </summary>
        public string TokenId { get; set; }

        /// <summary>
        /// The access token secret for the connector enrollment.
        /// </summary>
        public string TokenSecret { get; set; }
    }
}
