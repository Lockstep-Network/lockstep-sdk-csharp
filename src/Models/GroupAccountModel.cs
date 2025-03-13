/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// Represents an account for an entire group
    /// </summary>
    public class GroupAccountModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The name of the group
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// The primary user for the group
        /// </summary>
        public Guid? PrimaryUserId { get; set; }

        /// <summary>
        /// The CompanyId of the Company the group is associated with
        /// </summary>
        public Guid? GroupCompanyId { get; set; }

        /// <summary>
        /// Base Currency of the group
        /// </summary>
        public string BaseCurrencyCode { get; set; }

        /// <summary>
        /// The active status of the group
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// The onboarding session status of the group
        /// </summary>
        public bool? OnboardingScheduled { get; set; }

        /// <summary>
        /// The date this group account was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this group account
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date this group account was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this group account
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The 2-letter ISO country code for the group
        /// </summary>
        public string CountryCode { get; set; }
    }
}
