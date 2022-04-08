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
    /// An API Key is an authentication token that you may use with the Lockstep API.  Because API Keys
    /// do not have an expiration date, they are well suited for unattended processes.  Each API Key
    /// is associated with a user, and may be revoked to prevent it from accessing the Lockstep API.
    /// When you create an API Key, make sure to save the value in a secure location.  Lockstep cannot
    /// retrieve an API Key once it is created.
    ///
    /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
    /// </summary>
    public class ApiKeyModel
    {

        /// <summary>
        /// The unique identifier for the API key.
        /// </summary>
        public Guid? ApiKeyId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The name of the API key.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// For convenience, a call to createApiKey will contain the name of the environment for this API key,
        /// typically SBX or PRD. This can help you distinguish between keys created on the Sandbox environment
        /// from those created on Production.
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// The API key to use for authentication. This will only be returned upon creation of the API key.
        /// All other times, this value will be `null`.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// The first 10 characters of the API key.  This information can be used to ensure that you are
        /// looking at the correct API Key, but cannot be used for authentication.
        /// </summary>
        public string KeyPrefix { get; set; }

        /// <summary>
        /// The date the API key was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The user that created the API key.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the API key was revoked.
        /// </summary>
        public DateTime? Revoked { get; set; }

        /// <summary>
        /// The user who revoked the API key.
        /// </summary>
        public Guid? RevokedUserId { get; set; }

        /// <summary>
        /// The UTC datetime when the API key expires.
        /// </summary>
        public DateTime? Expires { get; set; }
    }
}
