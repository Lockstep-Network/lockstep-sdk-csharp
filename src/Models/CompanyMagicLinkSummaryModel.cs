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
    /// A summary of companies combined with their most recent magic links
    /// </summary>
    public class CompanyMagicLinkSummaryModel
    {

        /// <summary>
        /// The unique id for this company
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The short name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// This field indicates the type of company.  It can be one of a limited number of values:
        /// Company, Customer, Group, Vendor, or Third Party.  A company that represents both a customer and a vendor
        /// is identified as a CustomerVendor.
        ///
        /// * `Company` - This record represents a company that is part of the organization of the account holder.
        /// * `Customer` - This record represents a business entity that purchases things from the account holder.
        /// * `Group` - Only one record of type `GROUP` exists in each account.  Contains your account profile.
        /// * `Vendor` - This record represents a business entity that sells things to the account holder.
        /// * `Third Party` - This record represents a business entity that is neither a customer nor vendor.
        /// * `CustomerVendor` - Both a customer and a vendor.
        /// * `CompanyProfile` - Profile for a Company, each Company should have at most 1 profile, used only for Profile Management.
        /// </summary>
        public string CompanyType { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The name of the primary contact for this company
        /// </summary>
        public string PrimaryContactName { get; set; }

        /// <summary>
        /// The email of the primary contact for this company
        /// </summary>
        public string PrimaryContactEmailAddress { get; set; }

        /// <summary>
        /// The point of contact for this company
        /// </summary>
        public string PointOfContact { get; set; }

        /// <summary>
        /// The total outstanding amount for this company
        /// </summary>
        public decimal? OutstandingAmount { get; set; }

        /// <summary>
        /// The total amount past due for this company
        /// </summary>
        public decimal? AmountPastDue { get; set; }

        /// <summary>
        /// The total number of open invoices for this company
        /// </summary>
        public int? TotalOpenInvoices { get; set; }

        /// <summary>
        /// The total number of invoices that are past due for this company
        /// </summary>
        public int? PastDue { get; set; }

        /// <summary>
        /// Total number of visits for all magic links sent for this company
        /// </summary>
        public int? TotalVisits { get; set; }

        /// <summary>
        /// Total number of sent links for this company
        /// </summary>
        public int? LinksSent { get; set; }

        /// <summary>
        /// Created date of the most recent magic link made for this company
        /// </summary>
        public DateTime? LatestMagicLinkDate { get; set; }

        /// <summary>
        /// Id of the most recent magic link made for this company
        /// </summary>
        public Guid? LatestMagicLinkId { get; set; }

        /// <summary>
        /// Status of the most recent magic link made for this company
        /// </summary>
        public int? LatestMagicLinkStatus { get; set; }

        /// <summary>
        /// Expiration date of the most recent magic link made for this company
        /// </summary>
        public DateTime? LatestMagicLinkExpirationDate { get; set; }

        /// <summary>
        /// The currency code associated with this company based on the related invoices and payments.
        /// `Multi` - Multiple currency codes are present.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The invite status of this company
        /// </summary>
        public string InviteStatus { get; set; }

        /// <summary>
        /// The UTC date and time the invite status was last modified
        /// </summary>
        public DateTime? InviteStatusModified { get; set; }

        /// <summary>
        /// The user id of the user who last modified the invite status
        /// </summary>
        public Guid? InviteStatusModifiedUserId { get; set; }

        /// <summary>
        /// This flag indicates whether the company is currently active.
        /// </summary>
        public bool? IsActive { get; set; }
    }
}
