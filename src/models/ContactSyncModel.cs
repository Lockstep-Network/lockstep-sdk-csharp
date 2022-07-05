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
    /// The ContactSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the ContactSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the Lockstep
    /// platform.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [ContactModel](https://developer.lockstep.io/docs/contactmodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class ContactSyncModel
    {

        /// <summary>
        /// This is the primary key of the Contact record. For this field, you should use whatever the contact&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your contact records in a database, whatever the primary key for the contact table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// As some ERP systems don&#39;t maintain a unique key for Contacts, we also support syncing Contacts with ERP keys
        /// of the form {prefix}|{index}, for example ContactPrefix|1, ContactPrefix|2 and so on.
        ///
        /// For this reason, please ensure that your Contact ERP keys don&#39;t otherwise contain the &#39;|&#39; symbol or that it
        /// is replaced by an alternate symbol if they do.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The original primary key or unique ID of the company to which this contact belongs.  This value should
        /// match the [Company ErpKey](https://developer.lockstep.io/docs/importing-companies#erpkey) field on the
        /// [CompanySyncModel](https://developer.lockstep.io/docs/importing-companies).
        /// </summary>
        public string CompanyErpKey { get; set; }

        /// <summary>
        /// The name of the contact.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// A friendly human-readable code that describes this Contact.
        /// </summary>
        public string ContactCode { get; set; }

        /// <summary>
        /// The title of the contact.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The role code for the contact.
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// The email address of the contact.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The phone number of the contact.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The fax number of the contact.
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string StateRegion { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// The mailing address information for this contact.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// True if this contact is considered &quot;active&quot;.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// A webpage URL for more information about this contact.
        /// </summary>
        public string WebpageUrl { get; set; }

        /// <summary>
        /// If available, the URL of a photograph that shows this contact.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
