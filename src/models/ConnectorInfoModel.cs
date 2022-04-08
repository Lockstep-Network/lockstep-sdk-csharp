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

namespace LockstepSDK
{

    /// <summary>
    /// Represents all possible data required to set up an app enrollment for a connector.
    /// Only send required fields for the given connector.
    /// </summary>
    public class ConnectorInfoModel
    {

        /// <summary>
        /// The authorization code returned from the first step of the OAuth2 flow
        /// https://oauth.net/2/grant-types/authorization-code/
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// The realm id of the account being granted permissions to access
        /// </summary>
        public string RealmId { get; set; }

        /// <summary>
        /// The redirect uri used for step one of the OAuth2.0 flow.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// The email an email connection is being created for.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The username of the web services account with access permissions.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The password for the web services account with access permissions.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The server name a connection is being created for.
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// The port number of the server a connection is being created for.
        /// </summary>
        public int? ServerPort { get; set; }
    }
}
