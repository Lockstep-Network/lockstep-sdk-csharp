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
    /// A summary of companies combined with their most recent magic links
    /// </summary>
    public class CompanyMagicLinkSummaryModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        ///
        /// For the ID of this record in its originating financial system, see `ErpKey`.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The short name of the company.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The unique ID of this record as it was known in its originating financial system.
        ///
        /// If this company record was imported from a financial system, it will have the value `ErpKey`
        /// set to the original primary key number of the record as it was known in the originating financial
        /// system.  If this record was not imported, this value will be `null`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

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
        /// If this business entity is part of an organization, this value is non-null and it is set
        /// to the `CompanyId` value of the parent company of this business entity.
        ///
        /// If this value is null, this business entity is a standalone.
        /// </summary>
        public Guid? ParentCompanyId { get; set; }

        /// <summary>
        /// For convenience, this field indicates the top-level parent company.  This can be used
        /// to jump directly to the top parent in complex organizational hierarchies.
        /// </summary>
        public Guid? EnterpriseId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// This flag indicates whether the company is currently active.  An inactive company
        /// should be hidden from the user interface but will still be available for querying.
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// The default currency code used by this business entity.  This value can be overridden
        /// for invoices in a different currency code.
        ///
        /// For a list of defined currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies)
        /// </summary>
        public string DefaultCurrencyCode { get; set; }

        /// <summary>
        /// The URL of this company&#39;s logo, if known.
        /// </summary>
        public string CompanyLogoUrl { get; set; }

        /// <summary>
        /// The Lockstep `ContactId` of the primary contact for this company.
        /// </summary>
        public Guid? PrimaryContactId { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string StateRegion { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Address info
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Time zone
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Fax number
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// The date this company was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this company
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date this company was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this company
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// Federal Tax ID
        /// </summary>
        public string TaxId { get; set; }

        /// <summary>
        /// Dun &amp; Bradstreet Number
        /// </summary>
        public string DunsNumber { get; set; }

        /// <summary>
        /// Indicates the preferred invoice delivery method. Examples include Print, Email, Fax
        /// </summary>
        public string PreferredDeliveryMethod { get; set; }

        /// <summary>
        /// For companies that use a custom domain name for their email system, this is
        /// the domain name used by this company.  If this value is known, new emails that
        /// come in from this domain will be connected to this company.
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Identifier for classification of this company.
        /// </summary>
        public Guid? CompanyClassificationCodeDefId { get; set; }

        /// <summary>
        /// Description of the company.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Website URL for this company.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// Company Email Address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The public url slug for the Company.
        /// </summary>
        public string PublicUrlSlug { get; set; }

        /// <summary>
        /// State Tax ID
        /// </summary>
        public string StateTaxId { get; set; }

        /// <summary>
        /// The state where the company was registered.
        /// </summary>
        public string StateOfIncorporation { get; set; }

        /// <summary>
        /// Linkedin Url
        /// </summary>
        public string LinkedInUrlSlug { get; set; }

        /// <summary>
        /// This flag indicates whether the company is verified.
        /// </summary>
        public bool? IsVerified { get; set; }

        /// <summary>
        /// The date this company was last verified.
        /// </summary>
        public DateTime? LastVerifiedDate { get; set; }

        /// <summary>
        /// View box settings for the company logo.
        /// </summary>
        public ViewBoxSettingsModel ViewBoxSettings { get; set; }

        /// <summary>
        /// The unique ID of the Service Fabric organisation to which this record belongs.
        /// </summary>
        public Guid? ServiceFabricOrgId { get; set; }

        /// <summary>
        /// The unique ID of this record within Service Fabric.
        /// </summary>
        public Guid? ServiceFabricCompanyId { get; set; }

        /// <summary>
        /// A unique identification number assigned to the company by the national registration office.
        /// </summary>
        public string CompanyRegistrationNumber { get; set; }

        /// <summary>
        /// An optional reference to a real company, making this a profile.
        /// </summary>
        public Guid? ProfileReferenceId { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// All contacts attached to this company.
        ///
        /// To retrieve this collection, specify `Contacts` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public ContactModel[] Contacts { get; set; }

        /// <summary>
        /// All invoices attached to this company.
        ///
        /// To retrieve this collection, specify `Invoices` in the &quot;Include&quot; parameter for your query. For more information on Invoices, see [InvoiceModel](https://developer.lockstep.io/reference/get_api-v1-invoices-id).
        /// </summary>
        public object[] Invoices { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Company` and the `ObjectKey` set to the `CompanyId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }

        /// <summary>
        /// Classification code definition for this company.
        ///
        /// To retrieve this collection, specify `Classification` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public CodeDefinitionModel CompanyClassificationCodeDefinition { get; set; }

        /// <summary>
        /// Created date of the most recent magic link made for this company
        /// </summary>
        public DateTime? LatestMagicLinkDate { get; set; }

        /// <summary>
        /// Id of the most recent magic link made for this company
        /// </summary>
        public Guid? LatestMagicLinkId { get; set; }

        /// <summary>
        /// Possible statuses for a Magic Link.
        /// </summary>
        public int? LatestMagicLinkStatus { get; set; }
    }
}
