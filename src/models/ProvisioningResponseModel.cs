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
    /// Represents the response to either a successful or failed account provisioning
    /// </summary>
    public class ProvisioningResponseModel
    {

        /// <summary>
        /// If provisioning is successful, contains the username of the created user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// If provisioning is successful, contains subscription account name of created user.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// If provisioning is successful, contains the unique identifier of the created user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// If provisioning is successful, contains the group key of the created user.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// If provisioning is successful, contains the app enrollment id of the created app enrollment.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// if provisioning is successful, contains the sync request id of the sync that was started for the app enrollment.
        /// </summary>
        public Guid? SyncRequestId { get; set; }

        /// <summary>
        /// The error message(s).
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
