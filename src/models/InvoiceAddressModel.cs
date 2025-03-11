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
    /// Represents a single address for an invoice
    /// </summary>
    public class InvoiceAddressModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS when this record is
        /// added to the ADS Platform.
        /// </summary>
        public Guid? InvoiceAddressId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The ID number of the invoice this address belongs to
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        public string Line1 { get; set; }

        /// <summary>
        /// The second line of the address.
        /// </summary>
        public string Line2 { get; set; }

        /// <summary>
        /// The third line of the address.
        /// </summary>
        public string Line3 { get; set; }

        /// <summary>
        /// The name of the city for this address.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The state or region part of this address.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The postal code for this address.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The country for this address.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The latitude of this address, if available.
        /// </summary>
        public decimal? Latitude { get; set; }

        /// <summary>
        /// The longitude of this address, if available.
        /// </summary>
        public decimal? Longitude { get; set; }

        /// <summary>
        /// The date on which this address record was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this address.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this address record was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this address.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }
    }
}
