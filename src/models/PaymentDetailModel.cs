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
    /// Contains detailed information about a Payment.
    /// </summary>
    public class PaymentDetailModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this Payment.
        /// </summary>
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// The ID of the customer to which this Payment belongs.
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The name of the customer to which this Payment belongs.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Memo or reference text (ex. memo field on a check).
        /// </summary>
        public string MemoText { get; set; }

        /// <summary>
        /// Reference code for the payment for the given Erp system.
        /// </summary>
        public string ReferenceCode { get; set; }

        /// <summary>
        /// The name of the Primary Contact for the Customer.
        /// </summary>
        public string PrimaryContact { get; set; }

        /// <summary>
        /// The Email address of the Customer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Total amount of this Payment.
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// Unapplied balance of this Payment.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }

        /// <summary>
        /// The type of payment, Payment or AP Payment.
        /// </summary>
        public string PaymentType { get; set; }

        /// <summary>
        /// The date of this Payment.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PaymentDate { get; set; }

        /// <summary>
        /// Payment post date.
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string PostDate { get; set; }

        /// <summary>
        /// The phone number of the Customer&#39;s Primary Contact.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The fax number of the Customer&#39;s Primary Contact.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The first line of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// The second line of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The third line of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// The city of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state/region of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string StateRegion { get; set; }

        /// <summary>
        /// The postal/zip code of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The 2 character country code of the address for the Customer&#39;s Primary Contact.
        /// </summary>
        public string CountryCode { get; set; }
    }
}
