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
    /// Contains company details data
    /// </summary>
    public class CompanyDetailsModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The unique ID of this company
        /// </summary>
        public Guid? CustomerId { get; set; }

        /// <summary>
        /// The unique ID of this company
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Company address info
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Company address info
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Company address info
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// Company address info
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Company address info
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Company address info
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Company address country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Company phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Company fax number
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// Company email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Company primary contact id
        /// </summary>
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Company primary contact name
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Company primary contact email address
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Company number of outstanding invoices
        /// </summary>
        public int? OutstandingInvoices { get; set; }

        /// <summary>
        /// Company total outstanding invoice amount
        /// </summary>
        public decimal? OutstandingAmount { get; set; }

        /// <summary>
        /// Company total past due amount
        /// </summary>
        public decimal? AmountPastDue { get; set; }

        /// <summary>
        /// Company payments collected
        /// </summary>
        public CompanyDetailsPaymentModel[] Payments { get; set; }
    }
}
