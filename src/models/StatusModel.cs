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
    /// Represents the status of a user&#39;s credentials
    /// </summary>
    public class StatusModel
    {

        /// <summary>
        /// If authentication is successful, contains the username of the logged-in user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// If authentication is successful, contains the email address of the logged-in user.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// If authentication is successful, contains subscription account name of logged-in user.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// If authentication is successful, contains subscription account company id of logged-in user.
        /// </summary>
        public Guid? AccountCompanyId { get; set; }

        /// <summary>
        /// If authentication is successful, contains the unique identifier of the logged-in user.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <summary>
        /// If authentication is successful, contains the group key of the logged-in user.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Returns true if authentication for this API was successful.
        /// </summary>
        public bool? LoggedIn { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The set of roles for this user.
        /// </summary>
        public string[] Roles { get; set; }

        /// <summary>
        /// Date and time user has last logged into Azure B2C.
        /// </summary>
        public DateTime? LastLoggedIn { get; set; }

        /// <summary>
        /// The id of the API key used to authenticate.
        /// </summary>
        public Guid? ApiKeyId { get; set; }

        /// <summary>
        /// If authentication is successful, contains the user status of the logged-in user.
        /// </summary>
        public string UserStatus { get; set; }

        /// <summary>
        /// The environment currently being used
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// The version currently being used
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// If authentication is successful, contains the onboarding session status of the logged-in user&#39;s group account.
        /// </summary>
        public bool? OnboardingScheduled { get; set; }

        /// <summary>
        /// Magic link information about the user
        /// </summary>
        public MagicLinkStatusModel MagicLink { get; set; }

        /// <summary>
        /// Statuses for the dependencies of this api.
        /// OK if the dependency is working.
        /// </summary>
        public object Dependencies { get; set; }

        /// <summary>
        /// The set of Groups that the user has access to.
        /// You can use the /api/v1/useraccounts/change-group endpoint to change your active group.
        /// </summary>
        public UserGroupModel[] UserGroups { get; set; }

        /// <summary>
        /// Base Currency of the group
        /// </summary>
        public string BaseCurrencyCode { get; set; }
    }
}
