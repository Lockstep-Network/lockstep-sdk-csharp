/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
 * @version    2022.2
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



public class ActivityModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid ActivityId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The ID of the company to which this activity belongs.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The type code of the activity
    /// </summary>
    public string? ActivityTypeCode { get; set; }

    /// <summary>
    /// The name of the activity.  The name is a short name provided by the
    /// person who created the activity that can be displayed in a list.
    /// </summary>
    public string? ActivityName { get; set; }

    /// <summary>
    /// A description of the activity.  This field contains more detailed text about the
    /// activity and can be lengthy.
    /// </summary>
    public string? ActivityDescription { get; set; }

    /// <summary>
    /// The status of the activity.
    /// </summary>
    public string? ActivityStatus { get; set; }

    /// <summary>
    /// True if this activity is currently "open", which indicates that the activitiy is
    /// currently in progress.
    /// </summary>
    public bool IsOpen { get; set; }

    /// <summary>
    /// The priority of the activity.
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// The ID of the user the activity is assigned to.
    /// </summary>
    public Guid? UserAssignedTo { get; set; }

    /// <summary>
    /// The date the activity was assigned.
    /// </summary>
    public DateTime? DateAssigned { get; set; }

    /// <summary>
    /// The date the activity was closed.
    /// </summary>
    public DateTime? DateClosed { get; set; }

    /// <summary>
    /// If this activity has been "snoozed", this field will be non-null and will contain
    /// the date when the activity will be displayed.  Until that date arrives, the activity
    /// will remain hidden.
    /// </summary>
    public DateTime? SnoozeUntilDate { get; set; }

    /// <summary>
    /// The date on which this activity was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID of the user who created this activity.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date on which this activity was last modified.
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified this activity.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// Amount collected (if any) for the activity.
    /// </summary>
    public double? AmountCollected { get; set; }

    /// <summary>
    /// Amount paid (if any) for the activity.
    /// </summary>
    public double? AmountPaid { get; set; }

    /// <summary>
    /// Credit given (if any) for the activity.
    /// </summary>
    public double? CreditGiven { get; set; }

    /// <summary>
    /// True if this activity is to be shown in an "unread" state.  When an activity
    /// is read by a person it is assigned to, this flag is set to false.
    /// </summary>
    public bool IsUnread { get; set; }

    /// <summary>
    /// Activities may be archived when they should be hidden from the user.  When
    /// this flag is true, this activity should be hidden.
    /// </summary>
    public bool IsArchived { get; set; }

    /// <summary>
    /// All attachments attached to applied activity.
    /// 
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All notes attached to this applied activity.
    /// 
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All definitions attached to this applied activity.
    /// 
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this activity.
    /// 
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

};
public class AgingModel
{
    /// <summary>
    /// Aging bucket of outstanding balance data (days past due date of invoice)
    /// </summary>
    public int Bucket { get; set; }

    /// <summary>
    /// Currency code of aging bucket
    /// </summary>
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// Outstanding balance for the given aging bucket
    /// </summary>
    public double OutstandingBalance { get; set; }

};
public class ApiKeyModel
{
    /// <summary>
    /// The unique identifier for the API key.
    /// </summary>
    public Guid ApiKeyId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The name of the API key.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// The API key to use for authentication. This will only be returned upon creation of the API key.
    /// All other times, this value will be `null`.
    /// 
    /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
    /// </summary>
    public string? ApiKey { get; set; }

    /// <summary>
    /// The first 10 characters of the API key.  This information can be used to ensure that you are
    /// looking at the correct API Key, but cannot be used for authentication.
    /// </summary>
    public string? KeyPrefix { get; set; }

    /// <summary>
    /// The date the API key was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The user that created the API key.
    /// </summary>
    public Guid CreatedUserId { get; set; }

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

};
public class AppEnrollmentCustomFieldModel
{
    /// <summary>
    /// Unique id for the app enrollment
    /// </summary>
    public Guid AppEnrollmentId { get; set; }

    /// <summary>
    /// Id of enrolled app
    /// </summary>
    public Guid AppId { get; set; }

    /// <summary>
    /// The name of the application
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Tag for what type of app the application is
    /// </summary>
    public string? AppType { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// Unique Id for the custom field definition
    /// </summary>
    public Guid CustomFieldDefinitionId { get; set; }

    /// <summary>
    /// Text to display in-application for custom field
    /// </summary>
    public string? CustomFieldLabel { get; set; }

    /// <summary>
    /// Data type of the custom field definition
    /// </summary>
    public string? DataType { get; set; }

    /// <summary>
    /// Used for display logic when multiple app enrollment custom fields exist
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// String of data for field
    /// </summary>
    public string? StringValue { get; set; }

    /// <summary>
    /// Number data for field
    /// </summary>
    public double? NumericValue { get; set; }

};
public class AppEnrollmentModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid AppEnrollmentId { get; set; }

    /// <summary>
    /// The ID number of the Application that this enrollment represents.  You can fetch information
    /// about this Application object by specifying `App` in the "Include" parameter for your request.
    /// </summary>
    public Guid AppId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// Determines whether the app enrollment is in use
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// Created date
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Created user ID
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// Last modified date
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// Last user ID to modify
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// Stores schedule information for the application enrollment
    /// see https://en.wikipedia.org/wiki/Cron
    /// </summary>
    public string? CronSettings { get; set; }

    /// <summary>
    /// Flag indicating if the Sync process should be ran on the specified schedule
    /// </summary>
    public bool SyncScheduleIsActive { get; set; }

    /// <summary>
    /// The Application to which this AppEnrollment belongs.  Contains general name, description,
    /// logo, and other metadata about this application.
    /// 
    /// To retrieve this object, specify `App` in the "Include" parameter for your query.
    /// </summary>
    public ApplicationModel? App { get; set; }

    /// <summary>
    /// All definitions attached to this app.
    /// 
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this app.
    /// 
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

    /// <summary>
    /// Data about the last sync attached to this app enrollment
    /// 
    /// To retrieve this collection, specify `LastSync` in the "Include" parameter for your query.
    /// </summary>
    public SyncRequestModel? LastSync { get; set; }

    /// <summary>
    /// Optional data necessary to create an app enrollment for a supported connector.
    /// Only enter relevant fields for the given connector.
    /// </summary>
    public ConnectorInfoModel? ConnectorInfo { get; set; }

};
public class ApplicationModel
{
    /// <summary>
    /// A unique code identifying this application
    /// </summary>
    public Guid AppId { get; set; }

    /// <summary>
    /// The name of this application
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Brief summary of this application shown as a subtitle
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Tag for what type of app this is
    /// </summary>
    public string? AppType { get; set; }

    /// <summary>
    /// The ID of the owner
    /// </summary>
    public Guid OwnerId { get; set; }

    /// <summary>
    /// The URL to visit for more information about this application
    /// </summary>
    public Uri? ProjectUrl { get; set; }

    /// <summary>
    /// The URL for the icon for this application
    /// </summary>
    public Uri? IconUrl { get; set; }

    /// <summary>
    /// The description of the price for this application
    /// </summary>
    public string? PriceTerms { get; set; }

    /// <summary>
    /// The ID of the user who created this application
    /// </summary>
    public Guid? CreatedUserId { get; set; }

    /// <summary>
    /// The ID of the user who last modified this application
    /// </summary>
    public Guid? ModifiedUserId { get; set; }

    /// <summary>
    /// The date this application was created
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// The date this application was last modified
    /// </summary>
    public DateTime? Modified { get; set; }

    /// <summary>
    /// Flag indicating if the application is active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// URL to the Wiki for the Application
    /// </summary>
    public Uri? WikiURL { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// All notes attached to this app.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this app.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All definitions attached to the application.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to the application.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

};
public class ArAgingHeaderInfoModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The aging bucket this data belongs to.
    /// </summary>
    public string? ReportBucket { get; set; }

    /// <summary>
    /// The total number of customers.
    /// </summary>
    public int TotalCustomers { get; set; }

    /// <summary>
    /// The total number of invoices outstanding.
    /// </summary>
    public int TotalInvoicesOutstanding { get; set; }

    /// <summary>
    /// The total amount outstanding.
    /// </summary>
    public double TotalOutstandingAmount { get; set; }

    /// <summary>
    /// The total amount for AR.
    /// </summary>
    public double TotalArAmount { get; set; }

    /// <summary>
    /// Portion of Total AR this data represents.
    /// </summary>
    public double PercentageOfTotalAr { get; set; }

};
public class ArHeaderInfoModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The date of the report
    /// </summary>
    public DateTime? ReportPeriod { get; set; }

    /// <summary>
    /// The total number of customers.
    /// </summary>
    public int TotalCustomers { get; set; }

    /// <summary>
    /// The total number of invoices.
    /// </summary>
    public int TotalInvoices { get; set; }

    /// <summary>
    /// The total amount invoiced.
    /// </summary>
    public double TotalInvoicedAmount { get; set; }

    /// <summary>
    /// The total number of unapplied payments.
    /// </summary>
    public double TotalUnappliedPayments { get; set; }

    /// <summary>
    /// The total amount of collected payments.
    /// </summary>
    public double TotalCollected { get; set; }

    /// <summary>
    /// The total accounts receivable amount.
    /// </summary>
    public double TotalArAmount { get; set; }

    /// <summary>
    /// The number of paid invoices.
    /// </summary>
    public int TotalInvoicesPaid { get; set; }

    /// <summary>
    /// The number of past due invoices.
    /// </summary>
    public int TotalInvoicesPastDue { get; set; }

    /// <summary>
    /// The number of past due invoices for the last 90 days.
    /// </summary>
    public int TotalInvoices90DaysPastDue { get; set; }

    /// <summary>
    /// The total amount past due.
    /// </summary>
    public double TotalPastDueAmount { get; set; }

    /// <summary>
    /// The total past due for the past 90 days.
    /// </summary>
    public double TotalPastDueAmount90Days { get; set; }

    /// <summary>
    /// Portion of Total AR that is Past due.
    /// </summary>
    public double PercentageOfTotalAr { get; set; }

    /// <summary>
    /// Daily sales outstanding.
    /// </summary>
    public double Dso { get; set; }

    /// <summary>
    /// The total amount invoiced, due this year.
    /// </summary>
    public double TotalInvoiceAmountCurrentYear { get; set; }

    /// <summary>
    /// The total amount invoiced, due last year.
    /// </summary>
    public double TotalInvoiceAmountPreviousYear { get; set; }

    /// <summary>
    /// The total of all payments received this year.
    /// </summary>
    public double TotalPaymentAmountCurrentYear { get; set; }

    /// <summary>
    /// The total amount of payments received in the last 30 days
    /// </summary>
    public int TotalCollectedPastThirtyDays { get; set; }

    /// <summary>
    /// The total amount of Invoices paid in the last 30 days
    /// </summary>
    public int TotalInvoicesPaidPastThirtyDays { get; set; }

    /// <summary>
    /// Portion of Total AR that is 90+ days Past due.
    /// </summary>
    public double PercentageOfTotalAr90DaysPastDue { get; set; }

};
public class AtRiskInvoiceSummaryModel
{
    /// <summary>
    /// The date of the report
    /// </summary>
    public DateTime? ReportDate { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// The unique ID number of this invoice.
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// A reference code that is used to identify this invoice.
    /// The meaning of this field is specific to the ERP or accounting system used by the user.
    /// </summary>
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// The reporting date for this invoice.
    /// </summary>
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// The name of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// The status of the invoice.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The due date of the invoice.
    /// </summary>
    public DateTime? PaymentDueDate { get; set; }

    /// <summary>
    /// The total amount of the Invoice.
    /// </summary>
    public double? InvoiceAmount { get; set; }

    /// <summary>
    /// The remaining balance value of this invoice.
    /// </summary>
    public double? OutstandingBalance { get; set; }

    /// <summary>
    /// A code identifying the type of this Invoice.
    /// </summary>
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// The date stamp for the newest Activity on this Invoice.
    /// </summary>
    public DateTime? NewestActivity { get; set; }

    /// <summary>
    /// The number of days this Invoice is past due.
    /// </summary>
    public int? DaysPastDue { get; set; }

    /// <summary>
    /// The memo text of the payments associated to this invoice.
    /// </summary>
    public string[]? PaymentNumbers { get; set; }

    /// <summary>
    /// The ids of the payments associated to this invoice.
    /// </summary>
    public Guid[]? PaymentIds { get; set; }

};
public class AttachmentHeaderInfoModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The CompanyId associated with the attachment status report. Providing a null value will
    /// return an attachment summary for all attachments associated to the provided GroupKey
    /// </summary>
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// The total number of attachments associated with the provided GroupKey and CompanyId.
    /// </summary>
    public int TotalAttachments { get; set; }

    /// <summary>
    /// The total number of archived attachments associated with the provided GroupKey and CompanyId.
    /// </summary>
    public int TotalArchived { get; set; }

    /// <summary>
    /// The total number of active attachments associated with the provided GroupKey and CompanyId.
    /// </summary>
    public int TotalActive { get; set; }

};
public class AttachmentModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid AttachmentId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The name of the table the attachment is associated with
    /// </summary>
    public string? TableKey { get; set; }

    /// <summary>
    /// The ID of the object the attachment is associated with
    /// </summary>
    public Guid ObjectKey { get; set; }

    /// <summary>
    /// Name of the file
    /// </summary>
    public string? FileName { get; set; }

    /// <summary>
    /// Extension type of the file
    /// </summary>
    public string? FileExt { get; set; }

    /// <summary>
    /// Corresponding AttachmentType object to describe this attachment
    /// </summary>
    public Guid AttachmentTypeId { get; set; }

    /// <summary>
    /// Flag indicating the attachment was archived
    /// </summary>
    public bool IsArchived { get; set; }

    public Guid OriginAttachmentId { get; set; }

    /// <summary>
    /// Flag for if LS clients can see this file
    /// </summary>
    public bool ViewInternal { get; set; }

    /// <summary>
    /// Flag for if Vendors and customers can see this file
    /// </summary>
    public bool ViewExternal { get; set; }

    /// <summary>
    /// The date the attachment was created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Id of the user who made the file
    /// </summary>
    public Guid CreatedUserId { get; set; }

};
public class AvailableGroup
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The number of invoices.
    /// </summary>
    public int InvoiceCount { get; set; }

    /// <summary>
    /// The number of invoice lines.
    /// </summary>
    public int LineCount { get; set; }

    /// <summary>
    /// The number of companies.
    /// </summary>
    public int CompanyCount { get; set; }

    /// <summary>
    /// The number of contacts.
    /// </summary>
    public int ContactCount { get; set; }

    /// <summary>
    /// The number of payments.
    /// </summary>
    public int PaymentCount { get; set; }

    /// <summary>
    /// The number of payments applied.
    /// </summary>
    public int PaymentAppliedCount { get; set; }

};
public class AvailableMigrationsModel
{
    /// <summary>
    /// Indicates which records are available for migration
    /// </summary>
    public AvailableGroup[]? Migrations { get; set; }

};
public class BulkCurrencyConversionModel
{
    /// <summary>
    /// The date for the currency rate
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The currency code This will be validated by the /api/v1/currencies data set
    /// </summary>
    public string? SourceCurrency { get; set; }

};
public class CashflowReportModel
{
    /// <summary>
    /// Timeframe in days the cashflow report is generated on
    /// </summary>
    public int Timeframe { get; set; }

    /// <summary>
    /// Amount of payments collected based in the timeframe
    /// </summary>
    public double PaymentsCollected { get; set; }

    /// <summary>
    /// Number of payments collected based in the timeframe
    /// </summary>
    public int PaymentsCollectedCount { get; set; }

    /// <summary>
    /// Amount of invoices billed based in the timeframe
    /// </summary>
    public double InvoicesBilled { get; set; }

    /// <summary>
    /// Number of invoices billed in the timeframe
    /// </summary>
    public int InvoicesBilledCount { get; set; }

};
public class CodeDefinitionModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid CodeDefinitionId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The type of the Code Definition
    /// </summary>
    public string? CodeType { get; set; }

    /// <summary>
    /// The Code to be defined.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// The definition of the Code
    /// </summary>
    public string? CodeDescription { get; set; }

    /// <summary>
    /// The date that the Code Definition was created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID of the user who created the Code Definition
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date the Code Definition was last modified
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified the Code Definition
    /// </summary>
    public Guid ModifiedUserId { get; set; }

};
public class CompanyModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The short name of the company.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// This field indicates the type of company.  It can be one of a limited number of values:
    /// Company, Customer, Group, or Vendor.  A company that represents both a customer and a vendor
    /// is identified as a CustomerVendor.
    /// 
    /// * `Company` - This record represents a company that is part of the organization of the account holder.
    /// * `Customer` - This record represents a business entity that purchases things from the account holder.
    /// * `Group` - Only one record of type `GROUP` exists in each account.  Contains your account profile.
    /// * `Vendor` - This record represents a business entity that sells things to the account holder.
    /// * `CustomerVendor` - Both a customer and a vendor.
    /// </summary>
    public string? CompanyType { get; set; }

    /// <summary>
    /// The status of the company.  Companies can be either `Active` or `Inactive`.  When matched to a
    /// Lockstep corporate profile, this value will change to reflect that this record will be kept
    /// in sync with that company's identity.
    /// </summary>
    public string? CompanyStatus { get; set; }

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
    public Guid EnterpriseId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// This flag indicates whether the company is currently active.  An inactive company
    /// should be hidden from the user interface but will still be available for querying.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The default currency code used by this business entity.  This value can be overridden
    /// for invoices in a different currency code.
    /// 
    /// For a list of defined currency codes, see [Query Currencies](https://developer.lockstep.io/reference/get_api-v1-definitions-currencies)
    /// </summary>
    public string? DefaultCurrencyCode { get; set; }

    /// <summary>
    /// The URL of this company's logo, if known.
    /// </summary>
    public string? CompanyLogoUrl { get; set; }

    /// <summary>
    /// The Lockstep `ContactId` of the primary contact for this company.
    /// </summary>
    public Guid? PrimaryContactId { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? Address3 { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? StateRegion { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Address info
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Phone number
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Fax number
    /// </summary>
    public string? FaxNumber { get; set; }

    /// <summary>
    /// The date this company was created
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// The ID of the user who created this company
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date this company was last modified
    /// </summary>
    public DateTime? Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified this company
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// The name of the user who last modified this company
    /// </summary>
    public string? ModifiedUserName { get; set; }

    /// <summary>
    /// Federal Tax ID
    /// </summary>
    public string? TaxId { get; set; }

    /// <summary>
    /// Dun & Bradstreet Number
    /// </summary>
    public string? DunsNumber { get; set; }

    /// <summary>
    /// AP (Accounts Payable) Email Address
    /// </summary>
    public string? ApEmailAddress { get; set; }

    /// <summary>
    /// AR (Accounts Receivable) Email Address
    /// </summary>
    public string? ArEmailAddress { get; set; }

    /// <summary>
    /// For companies that use a custom domain name for their email system, this is
    /// the domain name used by this company.  If this value is known, new emails that
    /// come in from this domain will be connected to this company.
    /// </summary>
    public string? DomainName { get; set; }

    /// <summary>
    /// Identifier for classification of this company.
    /// </summary>
    public Guid? CompanyClassificationCodeDefId { get; set; }

    /// <summary>
    /// Description of the company.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Website URL for this company.
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// The AppEnrollmentId of the application that imported this company record.  For accounts
    /// with more than one financial system connected, this field identifies the originating
    /// financial system that produced this record.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// All notes attached to this company.
    /// 
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this company.
    /// 
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All contacts attached to this company.
    /// 
    /// To retrieve this collection, specify `Contacts` in the "Include" parameter for your query.
    /// </summary>
    public ContactModel[]? Contacts { get; set; }

    /// <summary>
    /// All invoices attached to this company.
    /// 
    /// To retrieve this collection, specify `Invoices` in the "Include" parameter for your query. For more information on Invoices, see [InvoiceModel](https://developer.lockstep.io/reference/get_api-v1-invoices-id).
    /// </summary>
    public object[]? Invoices { get; set; }

    /// <summary>
    /// All definitions attached to this company.
    /// 
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this company.
    /// 
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

    /// <summary>
    /// Classification code definition for this company.
    /// 
    /// To retrieve this collection, specify `Classification` in the "Include" parameter for your query.
    /// </summary>
    public CodeDefinitionModel? CompanyClassificationCodeDefinition { get; set; }

};
public class ConnectorInfoModel
{
    /// <summary>
    /// The authorization code returned from the first step of the OAuth2 flow
    /// https://oauth.net/2/grant-types/authorization-code/
    /// </summary>
    public string? AuthCode { get; set; }

    /// <summary>
    /// The realm id of the account being granted permissions to access
    /// </summary>
    public string? RealmId { get; set; }

    /// <summary>
    /// The redirect uri used for step one of the OAuth2.0 flow.
    /// </summary>
    public string? RedirectUri { get; set; }

    /// <summary>
    /// The email an email connection is being created for.
    /// </summary>
    public string? Email { get; set; }

};
public class ContactModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid ContactId { get; set; }

    /// <summary>
    /// The ID of the company to which this contact belongs.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// The name of the contact.
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// A friendly human-readable code that describes this Contact.
    /// </summary>
    public string? ContactCode { get; set; }

    /// <summary>
    /// The title of the contact.
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// The role code for the contact.
    /// </summary>
    public string? RoleCode { get; set; }

    /// <summary>
    /// The email address of the contact.
    /// </summary>
    public string? EmailAddress { get; set; }

    /// <summary>
    /// The phone number of the contact.
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// The fax number of the contact.
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// The first line of the address.
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// The second line of the address.
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// The third line of the address.
    /// </summary>
    public string? Address3 { get; set; }

    /// <summary>
    /// The city of the address.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// The state/region of the address.
    /// </summary>
    public string? StateRegion { get; set; }

    /// <summary>
    /// The postal/zip code of the address.
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// The two character country code of the address. This will be validated by the /api/v1/countries data set
    /// </summary>
    public string? CountryCode { get; set; }

    /// <summary>
    /// Flag indicating if the contact is active.
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The webpage url of the contact.
    /// </summary>
    public Uri? WebpageUrl { get; set; }

    /// <summary>
    /// The picture/avatar url of the contact.
    /// </summary>
    public Uri? PictureUrl { get; set; }

    /// <summary>
    /// The date on which this record was created.
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// The ID of the user who created this contact.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date on which this record was last modified.
    /// </summary>
    public DateTime? Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified this contact.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// All notes attached to this company.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this company.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All definitions attached to this contact.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this contact.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

};
public class CountryModel
{
    /// <summary>
    /// Name of the country
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 2 letter alphabetic code for the given country
    /// </summary>
    public string? Alpha2 { get; set; }

    /// <summary>
    /// 3 letter alphabetic code for the given country
    /// </summary>
    public string? Alpha3 { get; set; }

    /// <summary>
    /// Unique 3 digit number for the given country
    /// </summary>
    public int CountryCode { get; set; }

    /// <summary>
    /// Region of the country
    /// </summary>
    public string? Region { get; set; }

    /// <summary>
    /// Subregion of the country
    /// </summary>
    public string? SubRegion { get; set; }

    /// <summary>
    /// Intermediate region of the country
    /// </summary>
    public string? IntermediateRegion { get; set; }

    /// <summary>
    /// Numeric code for a region
    /// </summary>
    public int RegionCode { get; set; }

    /// <summary>
    /// Numeric code for a subregion
    /// </summary>
    public int SubRegionCode { get; set; }

    /// <summary>
    /// Numeric code for an intermediate region
    /// </summary>
    public int IntermediateRegionCode { get; set; }

    /// <summary>
    /// French name of the country
    /// </summary>
    public string? FrenchName { get; set; }

    /// <summary>
    /// A different name for a country
    /// </summary>
    public string? Aliases { get; set; }

};
public class CreditMemoAppliedModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid CreditMemoAppliedId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The id of the invoice
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The id of the credit memo invoice
    /// </summary>
    public Guid CreditMemoInvoiceId { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// Reference number for the applied credit memo.
    /// </summary>
    public int EntryNumber { get; set; }

    /// <summary>
    /// Date payment applied to credit memo.
    /// </summary>
    public DateTime ApplyToInvoiceDate { get; set; }

    /// <summary>
    /// Amount applied to credit memo.
    /// </summary>
    public double CreditMemoAppliedAmount { get; set; }

    /// <summary>
    /// Date credit memo applied record was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The id of the user who created this applied credit memo.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// Date credit memo applied record was modified.
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The id of the user who modified this applied credit memo.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// All attachments attached to applied Credit Memo.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All notes attached to this applied Credit Memo.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All definitions attached to this applied Credit Memo.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this Credit Memo.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

};
public class CreditMemoInvoiceModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid CreditMemoAppliedId { get; set; }

    /// <summary>
    /// The id of the invoice
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The id of the credit memo invoice
    /// </summary>
    public Guid CreditMemoInvoiceId { get; set; }

    /// <summary>
    /// Date invoice applied to credit memo.
    /// </summary>
    public DateTime? ApplyToInvoiceDate { get; set; }

    /// <summary>
    /// Amount applied to credit memo.
    /// </summary>
    public double CreditMemoAppliedAmount { get; set; }

    /// <summary>
    /// An additional reference code that is sometimes used to identify this invoice.
    /// The meaning of this field is specific to the ERP or accounting system used by the user.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// The ID number of the company that created this invoice.
    /// </summary>
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// A code identifying the status of this invoice.
    /// </summary>
    public string? InvoiceStatusCode { get; set; }

    /// <summary>
    /// The total value of this invoice, inclusive of all taxes and line items.
    /// </summary>
    public double? TotalAmount { get; set; }

    /// <summary>
    /// The remaining balance value of this invoice.
    /// </summary>
    public double? OutstandingBalanceAmount { get; set; }

};
public class CurrencyModel
{
    /// <summary>
    /// Alphabetic code for the given currency
    /// </summary>
    public string? AlphaCode { get; set; }

    /// <summary>
    /// Numeric code for the given currency
    /// </summary>
    public string? NumericCode { get; set; }

    /// <summary>
    /// Name of currency
    /// </summary>
    public string? CurrencyName { get; set; }

    /// <summary>
    /// Number of places after the decimal for this currency
    /// </summary>
    public int MinorUnit { get; set; }

    /// <summary>
    /// Symbol for the given currency
    /// </summary>
    public string? Symbol { get; set; }

};
public class CurrencyRateModel
{
    /// <summary>
    /// The source currency
    /// </summary>
    public string? SourceCurrency { get; set; }

    /// <summary>
    /// The destination currency
    /// </summary>
    public string? DestinationCurrency { get; set; }

    /// <summary>
    /// The date for the currency rate
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The currency rate value
    /// </summary>
    public double? CurrencyRate { get; set; }

};
public class CustomerDetailsModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this customer
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The unique ID of this customer
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Customer address info
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// Customer address info
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// Customer address info
    /// </summary>
    public string? Address3 { get; set; }

    /// <summary>
    /// Customer address info
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Customer address info
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Customer address info
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Customer address country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Customer phone number
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Customer fax number
    /// </summary>
    public string? FaxNumber { get; set; }

    /// <summary>
    /// Customer AR email address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Customer primary contact id
    /// </summary>
    public Guid ContactId { get; set; }

    /// <summary>
    /// Customer primary contact name
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// Customer primary contact email address
    /// </summary>
    public string? ContactEmail { get; set; }

    /// <summary>
    /// Customer number of outstanding invoices
    /// </summary>
    public int OutstandingInvoices { get; set; }

    /// <summary>
    /// Customer total outstanding invoice amount
    /// </summary>
    public double OutstandingAmount { get; set; }

    /// <summary>
    /// Customer total past due amount
    /// </summary>
    public double AmountPastDue { get; set; }

    /// <summary>
    /// Customer payments collected
    /// </summary>
    public CustomerDetailsPaymentModel[]? Payments { get; set; }

};
public class CustomerDetailsPaymentModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// Unique identifier for payment
    /// </summary>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Unique identifier for payment applied
    /// </summary>
    public Guid? PaymentAppliedId { get; set; }

    /// <summary>
    /// Payment type
    /// </summary>
    public string? PaymentType { get; set; }

    /// <summary>
    /// Unique identifier for invoice payment is associated with
    /// </summary>
    public Guid? InvoiceId { get; set; }

    /// <summary>
    /// Invoice type payment is associated with
    /// </summary>
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// Invoice reference code payment is associated with
    /// </summary>
    public string? InvoiceReferenceCode { get; set; }

    /// <summary>
    /// Invoice total amount payment is associated with
    /// </summary>
    public double InvoiceTotalAmount { get; set; }

    /// <summary>
    /// Date payment placed
    /// </summary>
    public DateTime PaymentDate { get; set; }

    /// <summary>
    /// Amount payment was made for
    /// </summary>
    public double PaymentAmount { get; set; }

};
public class CustomerSummaryModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this company.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The name of the company.
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// The name of the primary contact.
    /// </summary>
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// The number of outstanding invoices for this customer.
    /// </summary>
    public int? OutstandingInvoices { get; set; }

    /// <summary>
    /// The number of open invoices.
    /// </summary>
    public int? TotalInvoicesOpen { get; set; }

    /// <summary>
    /// The number of past due invoices.
    /// </summary>
    public int? TotalInvoicesPastDue { get; set; }

    /// <summary>
    /// The number of closed invoices for this customer.
    /// </summary>
    public int? ClosedInvoices { get; set; }

    /// <summary>
    /// The total from collected payments.
    /// </summary>
    public double? AmountCollected { get; set; }

    /// <summary>
    /// The total balance of outstanding invoices.
    /// </summary>
    public double? OutstandingAmount { get; set; }

    /// <summary>
    /// The total amount past due for this customer.
    /// </summary>
    public double? AmountPastDue { get; set; }

    /// <summary>
    /// The total value of unapplied Payments for this Customer.
    /// </summary>
    public double? UnappliedPayments { get; set; }

    /// <summary>
    /// Portion of Total AR for this Customer that is Past due. (TotalPastDue / Total AR).
    /// </summary>
    public double? PercentOfTotalAr { get; set; }

    /// <summary>
    /// Daily sales outstanding value for this Customer.
    /// </summary>
    public double? Dso { get; set; }

    /// <summary>
    /// The date stamp for the newest Activity on this Customer.
    /// </summary>
    public DateTime? NewestActivity { get; set; }

};
public class CustomFieldDefinitionModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid CustomFieldDefinitionId { get; set; }

    /// <summary>
    /// Table to which this definition belongs
    /// </summary>
    public string? TableKey { get; set; }

    /// <summary>
    /// Id of app this definition belongs to
    /// </summary>
    public Guid? AppId { get; set; }

    /// <summary>
    /// Text to display in-application for custom field
    /// </summary>
    public string? CustomFieldLabel { get; set; }

    /// <summary>
    /// Data type of this definition
    /// </summary>
    public string? DataType { get; set; }

    /// <summary>
    /// Used for display logic when multiple custom fields exist
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Date created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Id of user who created this definition
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// Date modified
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// Id of user who modified this definition
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

};
public class CustomFieldValueModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid CustomFieldDefinitionId { get; set; }

    /// <summary>
    /// Additional key if source table doesn't have a unique id
    /// </summary>
    public Guid RecordKey { get; set; }

    /// <summary>
    /// String of data for field
    /// </summary>
    public string? StringValue { get; set; }

    /// <summary>
    /// Number data for field
    /// </summary>
    public double NumericValue { get; set; }

    /// <summary>
    /// Date created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Id of user who created this value
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// Date modified
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// Id of user who modified this value
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// Definition of the value
    /// </summary>
    public CustomFieldDefinitionModel? CustomFieldDefinition { get; set; }

};
public class DailySalesOutstandingReportModel
{
    /// <summary>
    /// Timeframe (month) the daily sales outstanding values are associated with
    /// </summary>
    public DateTime Timeframe { get; set; }

    /// <summary>
    /// Number of invoices the average daily sales outstanding is calculated on
    /// </summary>
    public int InvoiceCount { get; set; }

    /// <summary>
    /// Time (in days) between an invoice was completed paid off and when the invoice was issued
    /// </summary>
    public double DailySalesOutstanding { get; set; }

};
public class EmailModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid EmailId { get; set; }

    /// <summary>
    /// The unique ID number of this email's conversation thread.
    /// </summary>
    public Guid ThreadId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The ID number of the company that created this email.
    /// </summary>
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// The email address for the sender of this email.
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// The email address for the recipient(s) of this email.
    /// </summary>
    public string? EmailTo { get; set; }

    /// <summary>
    /// The email address for the CC recipient(s) of this email
    /// </summary>
    public string? EmailCC { get; set; }

    /// <summary>
    /// The subject line of this email.
    /// </summary>
    public string? EmailSubject { get; set; }

    /// <summary>
    /// The body content of this email.
    /// </summary>
    public string? EmailBody { get; set; }

    /// <summary>
    /// The date on which this email was sent.
    /// </summary>
    public DateTime? SentDate { get; set; }

    /// <summary>
    /// A status flag indicating if this email is unread.
    /// </summary>
    public bool IsUnread { get; set; }

    /// <summary>
    /// A status flag indicating if this email is priority status.
    /// </summary>
    public bool IsPriority { get; set; }

    /// <summary>
    /// A status flag indicating if this email is marked as spam.
    /// </summary>
    public bool IsSpam { get; set; }

    /// <summary>
    /// The date on which this email was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID number of the user who created this email.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// A status flag indicating if this email is to be sent.
    /// </summary>
    public bool ToBeSent { get; set; }

    /// <summary>
    /// The ID number of the customer that sent this email.
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// The date on which this email was received.
    /// </summary>
    public DateTime? ReceivedTimeStamp { get; set; }

    /// <summary>
    /// The date on which this email was opened.
    /// </summary>
    public DateTime? OpenedTimestamp { get; set; }

    /// <summary>
    /// The number of times this email was viewed.
    /// </summary>
    public int ViewCount { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// The id of the email in an external system if imported.
    /// </summary>
    public string? ExternalEmailId { get; set; }

    /// <summary>
    /// The id of the email thread in an external system if imported.
    /// </summary>
    public string? ExternalThreadId { get; set; }

    /// <summary>
    /// The email address(es) for the BCC recipient(s) of this email
    /// </summary>
    public string? EmailBcc { get; set; }

    /// <summary>
    /// The type message being sent (New, Reply, Forward) or null for messages not being sent.
    /// </summary>
    public string? SendType { get; set; }

    /// <summary>
    /// The date on which this email was modified.
    /// Email modification should only be done by internal services.
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID of the user who modified this email.
    /// Email modification should only be done by internal services.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// If the message being sent is a reply or a forward, the id of the the email being replied to or forwarded.
    /// Otherwise null.
    /// </summary>
    public Guid? ResponseOriginId { get; set; }

    /// <summary>
    /// The email object associated with the response origin id.
    /// </summary>
    public EmailModel? ResponseOrigin { get; set; }

    /// <summary>
    /// All notes attached to this email.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this email.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All definitions attached to this email.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this email.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

};
public class ErpInfoDataModel
{
    /// <summary>
    /// The authorization code returned from the first step of the OAuth2 flow
    /// https://oauth.net/2/grant-types/authorization-code/
    /// </summary>
    public string? AuthCode { get; set; }

    /// <summary>
    /// The realm id of the account being granted permissions to access
    /// </summary>
    public string? RealmId { get; set; }

    /// <summary>
    /// The redirect uri used for step one of the OAuth2.0 flow.
    /// </summary>
    public string? RedirectUri { get; set; }

};
public class ErpInfoModel
{
    /// <summary>
    /// The id of the ERP's App
    /// </summary>
    public Guid AppId { get; set; }

    /// <summary>
    /// The data required to store for connector access
    /// </summary>
    public ConnectorInfoModel? Data { get; set; }

};
public class ErpModel
{
    /// <summary>
    /// Unique ID for this ERP
    /// </summary>
    public Guid ErpSystemId { get; set; }

    /// <summary>
    /// Name of ERP
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Flag to indicate if ERP is supported
    /// </summary>
    public bool IsSupported { get; set; }

};
public class InviteDataModel
{
    /// <summary>
    /// The email address of the invited user.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// The status of the user.
    /// </summary>
    public string? UserStatus { get; set; }

};
public class InviteModel
{
    /// <summary>
    /// The invited email address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// True if the invite was sent successfully
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// The invited user, may be null if the user could not be invited
    /// </summary>
    public UserAccountModel? InvitedUser { get; set; }

    /// <summary>
    /// The error message if the invite was not successful
    /// </summary>
    public string? ErrorMessage { get; set; }

};
public class InviteSubmitModel
{
    /// <summary>
    /// The email address of the user to invite
    /// </summary>
    public string? Email { get; set; }

};
public class InvoiceAddressModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid InvoiceAddressId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The ID number of the invoice this address belongs to
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The first line of the address.
    /// </summary>
    public string? Line1 { get; set; }

    /// <summary>
    /// The second line of the address.
    /// </summary>
    public string? Line2 { get; set; }

    /// <summary>
    /// The third line of the address.
    /// </summary>
    public string? Line3 { get; set; }

    /// <summary>
    /// The name of the city for this address.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// The state or region part of this address.
    /// </summary>
    public string? Region { get; set; }

    /// <summary>
    /// The postal code for this address.
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// The country for this address.
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// The latitude of this address, if available.
    /// </summary>
    public float? Latitude { get; set; }

    /// <summary>
    /// The longitude of this address, if available.
    /// </summary>
    public float? Longitude { get; set; }

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

};
public class InvoiceHistoryModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID number of this invoice history entry.
    /// </summary>
    public Guid InvoiceHistoryId { get; set; }

    /// <summary>
    /// The unique ID of the Invoice represented by this history entry.  This ID was automatically assigned
    /// by Lockstep to the Invoice record when it was added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The ID number of the company that created this invoice.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// The purchase order code as it exists in the user's ERP or accounting system.
    /// </summary>
    public string? PurchaseOrderCode { get; set; }

    /// <summary>
    /// An additional reference code that is sometimes used to identify this invoice.
    /// The meaning of this field is specific to the ERP or accounting system used by the user.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// A code identifying the salesperson responsible for writing this invoice.
    /// </summary>
    public string? SalespersonCode { get; set; }

    /// <summary>
    /// A string identifying the salesperson responsible for writing this invoice.
    /// </summary>
    public string? SalespersonName { get; set; }

    /// <summary>
    /// A code identifying the type of this invoice.
    /// </summary>
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// A code identifying the status of this invoice.
    /// </summary>
    public string? InvoiceStatusCode { get; set; }

    /// <summary>
    /// A code identifying the terms given to the purchaser.
    /// </summary>
    public string? TermsCode { get; set; }

    /// <summary>
    /// If the customer negotiated any special terms different from the standard terms above, describe them here.
    /// </summary>
    public string? SpecialTerms { get; set; }

    /// <summary>
    /// The three-character ISO 4217 currency code used for this invoice. This will be validated by the /api/v1/currencies data set
    /// </summary>
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// The total value of this invoice, inclusive of all taxes and line items.
    /// </summary>
    public double? TotalAmount { get; set; }

    /// <summary>
    /// The total sales (or transactional) tax calculated for this invoice.
    /// </summary>
    public double? SalesTaxAmount { get; set; }

    /// <summary>
    /// The total discounts given by the seller to the buyer on this invoice.
    /// </summary>
    public double? DiscountAmount { get; set; }

    /// <summary>
    /// The remaining balance value of this invoice.
    /// </summary>
    public double? OutstandingBalanceAmount { get; set; }

    /// <summary>
    /// The reporting date for this invoice.
    /// </summary>
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// The date when discounts were adjusted for this invoice.
    /// </summary>
    public DateTime? DiscountDate { get; set; }

    /// <summary>
    /// The date when this invoice posted to the company's general ledger.
    /// </summary>
    public DateTime? PostedDate { get; set; }

    /// <summary>
    /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
    /// services.
    /// </summary>
    public DateTime? InvoiceClosedDate { get; set; }

    /// <summary>
    /// The date when the remaining outstanding balance is due.
    /// </summary>
    public DateTime? PaymentDueDate { get; set; }

    /// <summary>
    /// The date and time when this record was imported from the user's ERP or accounting system.
    /// </summary>
    public DateTime? ImportedDate { get; set; }

    /// <summary>
    /// The ID number of the invoice's origination address
    /// </summary>
    public Guid? PrimaryOriginAddressId { get; set; }

    /// <summary>
    /// The ID number of the invoice's bill-to address
    /// </summary>
    public Guid? PrimaryBillToAddressId { get; set; }

    /// <summary>
    /// The ID number of the invoice's ship-to address
    /// </summary>
    public Guid? PrimaryShipToAddressId { get; set; }

    /// <summary>
    /// The date on which this invoice record was created.
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// The ID number of the user who created this invoice.
    /// </summary>
    public Guid? CreatedUserId { get; set; }

    /// <summary>
    /// The date on which this invoice record was last modified.
    /// </summary>
    public DateTime? Modified { get; set; }

    /// <summary>
    /// The ID number of the user who most recently modified this invoice.
    /// </summary>
    public Guid? ModifiedUserId { get; set; }

};
public class InvoiceLineModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid InvoiceLineId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The ID number of the invoice this line belongs to.
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system, if it was
    /// different from the original `LineNumber`.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// The line number of this line, as defined in the originating ERP or accounting system.  You can sort on this number to
    /// get the original view of lines within the invoice.
    /// </summary>
    public string? LineNumber { get; set; }

    /// <summary>
    /// A code number identifying the product or service that is specified on this line.
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Description of this invoice line.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// For lines measured in a unit other than "quantity", this code indicates the measurement system for the quantity field.
    /// If the line is measured in quantity, this field is null.
    /// </summary>
    public string? UnitMeasureCode { get; set; }

    /// <summary>
    /// The price of a single unit for this line.
    /// </summary>
    public double UnitPrice { get; set; }

    /// <summary>
    /// The quantity of items for ths line.
    /// </summary>
    public double? Quantity { get; set; }

    /// <summary>
    /// The number of items that have been shipped.
    /// </summary>
    public double? QuantityShipped { get; set; }

    /// <summary>
    /// The number of items that has been received.
    /// </summary>
    public double? QuantityReceived { get; set; }

    /// <summary>
    /// The total amount for this line.
    /// </summary>
    public double? TotalAmount { get; set; }

    /// <summary>
    /// If this line is tax exempt, this code indicates the reason for the exemption.
    /// </summary>
    public string? ExemptionCode { get; set; }

    /// <summary>
    /// If null, the products specified on this line were delivered on the same date as all other lines.
    /// If not null, this line was delivered or finalized on a different date than the overall invoice.
    /// </summary>
    public DateTime? ReportingDate { get; set; }

    /// <summary>
    /// An optional ID number for the line's origin address.
    /// </summary>
    public Guid? OverrideOriginAddressId { get; set; }

    /// <summary>
    /// An optional ID number for the line's bill to address.
    /// </summary>
    public Guid? OverrideBillToAddressId { get; set; }

    /// <summary>
    /// An optional ID number for the line's ship to address.
    /// </summary>
    public Guid? OverrideShipToAddressId { get; set; }

    /// <summary>
    /// The date on which this line was created.
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// The ID number of the user who created this line.
    /// </summary>
    public Guid? CreatedUserId { get; set; }

    /// <summary>
    /// The date on which this line was last modified.
    /// </summary>
    public DateTime? Modified { get; set; }

    /// <summary>
    /// The ID number of the user who most recently modified this line.
    /// </summary>
    public Guid? ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// All notes attached to this company.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this company.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

};
public class InvoiceModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The ID number of the company that created this invoice.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// The purchase order code as it exists in the user's ERP or accounting system.
    /// </summary>
    public string? PurchaseOrderCode { get; set; }

    /// <summary>
    /// An additional reference code that is sometimes used to identify this invoice.
    /// The meaning of this field is specific to the ERP or accounting system used by the user.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// A code identifying the salesperson responsible for writing this quote, invoice, or order.
    /// </summary>
    public string? SalespersonCode { get; set; }

    /// <summary>
    /// A string identifying the salesperson responsible for writing this quote, invoice, or order.
    /// </summary>
    public string? SalespersonName { get; set; }

    /// <summary>
    /// A code identifying the type of this invoice.
    /// </summary>
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// A code identifying the status of this invoice.
    /// </summary>
    public string? InvoiceStatusCode { get; set; }

    /// <summary>
    /// A code identifying the terms given to the purchaser.
    /// </summary>
    public string? TermsCode { get; set; }

    /// <summary>
    /// If the customer negotiated any special terms different from the standard terms above, describe them here.
    /// </summary>
    public string? SpecialTerms { get; set; }

    /// <summary>
    /// The three-character ISO 4217 currency code used for this invoice.
    /// </summary>
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// The total value of this invoice, inclusive of all taxes and line items.
    /// </summary>
    public double? TotalAmount { get; set; }

    /// <summary>
    /// The total sales (or transactional) tax calculated for this invoice.
    /// </summary>
    public double? SalesTaxAmount { get; set; }

    /// <summary>
    /// The total discounts given by the seller to the buyer on this invoice.
    /// </summary>
    public double? DiscountAmount { get; set; }

    /// <summary>
    /// The remaining balance value of this invoice.
    /// </summary>
    public double? OutstandingBalanceAmount { get; set; }

    /// <summary>
    /// The reporting date for this invoice.
    /// </summary>
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// The date when discounts were adjusted for this invoice.
    /// </summary>
    public DateTime? DiscountDate { get; set; }

    /// <summary>
    /// The date when this invoice posted to the company's general ledger.
    /// </summary>
    public DateTime? PostedDate { get; set; }

    /// <summary>
    /// The date when the invoice was closed and finalized after completion of all payments and delivery of all products and
    /// services.
    /// </summary>
    public DateTime? InvoiceClosedDate { get; set; }

    /// <summary>
    /// The date when the remaining outstanding balance is due.
    /// </summary>
    public DateTime? PaymentDueDate { get; set; }

    /// <summary>
    /// The date and time when this record was imported from the user's ERP or accounting system.
    /// </summary>
    public DateTime? ImportedDate { get; set; }

    /// <summary>
    /// The ID number of the invoice's origination address
    /// </summary>
    public Guid? PrimaryOriginAddressId { get; set; }

    /// <summary>
    /// The ID number of the invoice's bill-to address
    /// </summary>
    public Guid? PrimaryBillToAddressId { get; set; }

    /// <summary>
    /// The ID number of the invoice's ship-to address
    /// </summary>
    public Guid? PrimaryShipToAddressId { get; set; }

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
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// Is the invoice voided?
    /// </summary>
    public bool IsVoided { get; set; }

    /// <summary>
    /// Is the invoice in dispute?
    /// </summary>
    public bool InDispute { get; set; }

    /// <summary>
    /// Should the invoice be excluded from aging calculations?
    /// </summary>
    public bool ExcludeFromAging { get; set; }

    /// <summary>
    /// All addresses connected to this invoice.
    /// To retrieve this collection, specify `Addresses` in the "Include" parameter for your query.
    /// </summary>
    public InvoiceAddressModel[]? Addresses { get; set; }

    /// <summary>
    /// All lines attached to this invoice.
    /// To retrieve this collection, specify `Lines` in the "Include" parameter for your query.
    /// </summary>
    public InvoiceLineModel[]? Lines { get; set; }

    /// <summary>
    /// All payments attached to this invoice, the amount of the payment applied to this Invoice, and the date the Payment was applied.
    /// To retrieve this collection, specify `Payments` in the "Include" parameter for your query.
    /// </summary>
    public InvoicePaymentDetailModel[]? Payments { get; set; }

    /// <summary>
    /// All notes attached to this invoice.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this invoice.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// The Company associated to this invoice.
    /// To retrieve this item, specify `Company` in the "Include" parameter for your query.
    /// </summary>
    public CompanyModel? Company { get; set; }

    /// <summary>
    /// The Customer associated to the invoice customer
    /// To retrieve this item, specify `Customer` in the "Include" parameter for your query.
    /// </summary>
    public CompanyModel? Customer { get; set; }

    /// <summary>
    /// The Contact associated to the invoice customer
    /// To retrieve this item, specify `Customer` in the "Include" parameter for your query.
    /// </summary>
    public ContactModel? CustomerPrimaryContact { get; set; }

    /// <summary>
    /// The credit memos associated to this invoice.
    /// To retrieve this item, specify `CreditMemos` in the "Include" parameter for your query.
    /// </summary>
    public CreditMemoInvoiceModel[]? CreditMemos { get; set; }

    /// <summary>
    /// All custom field values associated with this invoice
    /// To retrieve this item, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

    /// <summary>
    /// All custom field definitions
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

};
public class InvoicePaymentDetailModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique identifier of this PaymentApplied record.
    /// </summary>
    public Guid PaymentAppliedId { get; set; }

    /// <summary>
    /// The database id of the invoice
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The database id of the Payment.
    /// </summary>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Date Payment applied to Invoice.
    /// </summary>
    public DateTime? ApplyToInvoiceDate { get; set; }

    /// <summary>
    /// Amount applied to Invoice.
    /// </summary>
    public double PaymentAppliedAmount { get; set; }

    /// <summary>
    /// An additional reference code that is sometimes used to identify this Payment.
    /// The meaning of this field is specific to the ERP or accounting system used by the user.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// The ID number of the Company (CompanyType = "Customer") that created this Payment.
    /// </summary>
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// The total value of this Payment.
    /// </summary>
    public double? PaymentAmount { get; set; }

    /// <summary>
    /// The remaining balance value of this Payment.
    /// </summary>
    public double? UnappliedAmount { get; set; }

};
public class InvoiceSummaryModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The ID number of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// The unique ID number of this invoice.
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// A reference code that is used to identify this invoice.
    /// The meaning of this field is specific to the ERP or accounting system used by the user.
    /// </summary>
    public string? InvoiceNumber { get; set; }

    /// <summary>
    /// The reporting date for this invoice.
    /// </summary>
    public DateTime? InvoiceDate { get; set; }

    /// <summary>
    /// The name of the counterparty for the invoice, for example, a customer or vendor.
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// The status of the invoice.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The due date of the invoice.
    /// </summary>
    public DateTime? PaymentDueDate { get; set; }

    /// <summary>
    /// The total amount of the Invoice.
    /// </summary>
    public double? InvoiceAmount { get; set; }

    /// <summary>
    /// The remaining balance value of this invoice.
    /// </summary>
    public double? OutstandingBalance { get; set; }

    /// <summary>
    /// A code identifying the type of this Invoice.
    /// </summary>
    public string? InvoiceTypeCode { get; set; }

    /// <summary>
    /// The date stamp for the newest Activity on this Invoice.
    /// </summary>
    public DateTime? NewestActivity { get; set; }

    /// <summary>
    /// The number of days this Invoice is past due.
    /// </summary>
    public int? DaysPastDue { get; set; }

    /// <summary>
    /// The memo text of the payments associated to this invoice.
    /// </summary>
    public string[]? PaymentNumbers { get; set; }

    /// <summary>
    /// The ids of the payments associated to this invoice.
    /// </summary>
    public Guid[]? PaymentIds { get; set; }

};
public class LeadModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid LeadId { get; set; }

    /// <summary>
    /// Name of lead
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Name of company of lead
    /// </summary>
    public string? Company { get; set; }

    /// <summary>
    /// Email of lead
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Requested ERP of lead
    /// </summary>
    public string? ErpSystem { get; set; }

};
public class MigrationResultModel
{
    /// <summary>
    /// If the API call produced messages, this element will contain a list of user-visible
    /// text strings that contain information about what work occurred in the API.
    /// </summary>
    public string[]? Messages { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The number of invoices migrated
    /// </summary>
    public int InvoiceCount { get; set; }

    /// <summary>
    /// The number of addresses migrated
    /// </summary>
    public int AddressCount { get; set; }

    /// <summary>
    /// The number of invoice and invoice line fields migrated
    /// </summary>
    public int InvoiceFieldCount { get; set; }

    /// <summary>
    /// The number of invoice lines migrated
    /// </summary>
    public int LineCount { get; set; }

    /// <summary>
    /// The number of contacts migrated
    /// </summary>
    public int ContactCount { get; set; }

    /// <summary>
    /// The number of companies migrated
    /// </summary>
    public int CompanyCount { get; set; }

    /// <summary>
    /// The number of payments migrated
    /// </summary>
    public int PaymentCount { get; set; }

    /// <summary>
    /// The number of payment fields migrated
    /// </summary>
    public int PaymentFieldCount { get; set; }

    /// <summary>
    /// The number of payments applied migrated
    /// </summary>
    public int PaymentAppliedCount { get; set; }

};
public class NoteModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid NoteId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The name of the table the note is associated with
    /// </summary>
    public string? TableKey { get; set; }

    /// <summary>
    /// The ID of the object the note is associated with
    /// </summary>
    public Guid ObjectKey { get; set; }

    /// <summary>
    /// The text of the note
    /// </summary>
    public string? NoteText { get; set; }

    /// <summary>
    /// The type of the note
    /// </summary>
    public string? NoteType { get; set; }

    /// <summary>
    /// Flag indicating if the note has been archived
    /// </summary>
    public bool IsArchived { get; set; }

    /// <summary>
    /// The date the note was created
    /// </summary>
    public DateTime? Created { get; set; }

    /// <summary>
    /// The ID of the user who created the note
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The name of the user who created the note
    /// </summary>
    public string? CreatedUserName { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

};
public class PaymentAppliedModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid PaymentAppliedId { get; set; }

    /// <summary>
    /// The Invoice this payment is applied to.
    /// </summary>
    public Guid InvoiceId { get; set; }

    /// <summary>
    /// The Payment applied to the invoice.
    /// </summary>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// Reference number for the payment applied.
    /// </summary>
    public int EntryNumber { get; set; }

    /// <summary>
    /// Date payment applied to invoice.
    /// </summary>
    public DateTime ApplyToInvoiceDate { get; set; }

    /// <summary>
    /// Amount applied to invoice.
    /// </summary>
    public double PaymentAppliedAmount { get; set; }

    /// <summary>
    /// Date payment applied record was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The id of the user who created this applied payment.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// Date payment applied record was modified.
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The id of the user who modified this applied payment.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// The invoice associated with this applied payment.
    /// </summary>
    public InvoiceModel? Invoice { get; set; }

};
public class PaymentDetailHeaderModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The total number of Customers.
    /// </summary>
    public int? CustomerCount { get; set; }

    /// <summary>
    /// The total amount collected.
    /// </summary>
    public double? AmountCollected { get; set; }

    /// <summary>
    /// The total unapplied amount.
    /// </summary>
    public double? UnappliedAmount { get; set; }

    /// <summary>
    /// The number of paid invoices.
    /// </summary>
    public int? PaidInvoiceCount { get; set; }

    /// <summary>
    /// The number of open invoices.
    /// </summary>
    public int? OpenInvoiceCount { get; set; }

};
public class PaymentDetailModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this Payment.
    /// </summary>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// The ID of the customer to which this Payment belongs.
    /// </summary>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// The name of the customer to which this Payment belongs.
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// Memo or reference text (ex. memo field on a check).
    /// </summary>
    public string? MemoText { get; set; }

    /// <summary>
    /// Reference code for the payment for the given Erp system.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// The name of the Primary Contact for the Customer.
    /// </summary>
    public string? PrimaryContact { get; set; }

    /// <summary>
    /// The Email address of the Customer.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Total amount of this Payment.
    /// </summary>
    public double PaymentAmount { get; set; }

    /// <summary>
    /// Unapplied balance of this Payment.
    /// </summary>
    public double UnappliedAmount { get; set; }

    /// <summary>
    /// The type of payment, Payment or AP Payment.
    /// </summary>
    public string? PaymentType { get; set; }

    /// <summary>
    /// The date of this Payment.
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Payment post date.
    /// </summary>
    public DateTime? PostDate { get; set; }

    /// <summary>
    /// The phone number of the Customer's Primary Contact.
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// The fax number of the Customer's Primary Contact.
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// The first line of the address for the Customer's Primary Contact.
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// The second line of the address for the Customer's Primary Contact.
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// The third line of the address for the Customer's Primary Contact.
    /// </summary>
    public string? Address3 { get; set; }

    /// <summary>
    /// The city of the address for the Customer's Primary Contact.
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// The state/region of the address for the Customer's Primary Contact.
    /// </summary>
    public string? StateRegion { get; set; }

    /// <summary>
    /// The postal/zip code of the address for the Customer's Primary Contact.
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// The 2 character country code of the address for the Customer's Primary Contact.
    /// </summary>
    public string? CountryCode { get; set; }

};
public class PaymentModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// For the ID of this record in its originating financial system, see `ErpKey`.
    /// </summary>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// The ID of the company to which this payment belongs.
    /// </summary>
    public Guid CompanyId { get; set; }

    /// <summary>
    /// The unique ID of this record as it was known in its originating financial system.
    /// 
    /// If this company record was imported from a financial system, it will have the value `ErpKey`
    /// set to the original primary key number of the record as it was known in the originating financial
    /// system.  If this record was not imported, this value will be `null`.
    /// 
    /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
    /// </summary>
    public string? ErpKey { get; set; }

    /// <summary>
    /// The type of payment, cash or check.
    /// </summary>
    public string? PaymentType { get; set; }

    /// <summary>
    /// Cash, check, credit card, wire transfer.
    /// </summary>
    public string? TenderType { get; set; }

    /// <summary>
    /// Has the payment been fully applied?
    /// </summary>
    public bool IsOpen { get; set; }

    /// <summary>
    /// Memo or reference text (ex. memo field on a check).
    /// </summary>
    public string? MemoText { get; set; }

    /// <summary>
    /// The date of this payment.
    /// </summary>
    public DateTime PaymentDate { get; set; }

    /// <summary>
    /// Payment post date.
    /// </summary>
    public DateTime PostDate { get; set; }

    /// <summary>
    /// Total amount of this payment.
    /// </summary>
    public double PaymentAmount { get; set; }

    /// <summary>
    /// Unapplied balance of this payment.
    /// </summary>
    public double UnappliedAmount { get; set; }

    /// <summary>
    /// Currency of the payment. This will be validated by the /api/v1/currencies data set
    /// </summary>
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// Reference code for the payment for the given Erp system.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// The date on which this record was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID of the user who created this payment.
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date on which this record was last modified.
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified this payment.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// AppEnrollmentId for this record; used for mapping purposes.
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// Is the payment voided?
    /// </summary>
    public bool IsVoided { get; set; }

    /// <summary>
    /// Is the payment in dispute?
    /// </summary>
    public bool InDispute { get; set; }

    /// <summary>
    /// All applications this payment is associated with.
    /// To retrieve this collection, specify `Applications` in the "Include" parameter for your query.
    /// </summary>
    public PaymentAppliedModel[]? Applications { get; set; }

    /// <summary>
    /// All notes attached to this payment.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this payment.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All definitions attached to this payment.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldDefinitionModel[]? CustomFieldDefinitions { get; set; }

    /// <summary>
    /// All values attached to this payment.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

};
public class PaymentSummaryModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The id of the payment
    /// </summary>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Memo or reference text (ex. memo field on a check).
    /// </summary>
    public string? MemoText { get; set; }

    /// <summary>
    /// Reference code for the payment for the given Erp system.
    /// </summary>
    public string? ReferenceCode { get; set; }

    /// <summary>
    /// The type of payment, Payment or AP Payment.
    /// </summary>
    public string? PaymentType { get; set; }

    /// <summary>
    /// The date of this payment.
    /// </summary>
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Total amount of this payment.
    /// </summary>
    public double PaymentAmount { get; set; }

    /// <summary>
    /// Unapplied balance of this payment.
    /// </summary>
    public double UnappliedAmount { get; set; }

    /// <summary>
    /// The number of invoices associated to this payment.
    /// </summary>
    public int? InvoiceCount { get; set; }

    /// <summary>
    /// The number of payments applied to this payment.
    /// </summary>
    public double? TotalPaymentsApplied { get; set; }

    /// <summary>
    /// The reference codes of the invoices associated to this payment.
    /// </summary>
    public string[]? InvoiceList { get; set; }

    /// <summary>
    /// The ids of the invoices associated to this payment.
    /// </summary>
    public Guid[]? InvoiceIdList { get; set; }

    /// <summary>
    /// The name of the customer for this payment.
    /// </summary>
    public string? CustomerName { get; set; }

    /// <summary>
    /// The id of the customer for this payment.
    /// </summary>
    public Guid? CustomerId { get; set; }

};
public class ProvisioningFinalizeRequestModel
{
    /// <summary>
    /// The full name of the user
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// The time zone of the user
    /// </summary>
    public string? TimeZone { get; set; }

    /// <summary>
    /// The default currency of the user
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The company information for the user and group
    /// </summary>
    public CompanyModel? Company { get; set; }

    /// <summary>
    /// Optional connector information needed to enroll user to their email connector
    /// </summary>
    public ErpInfoModel? EmailConnector { get; set; }

};
public class ProvisioningModel
{
    /// <summary>
    /// The full name of the new user
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// The information necessary to enroll the user in their ERP
    /// </summary>
    public ErpInfoModel? Erp { get; set; }

};
public class ProvisioningResponseModel
{
    /// <summary>
    /// If provisioning is successful, contains the username of the created user.
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// If provisioning is successful, contains subscription account name of created user.
    /// </summary>
    public string? AccountName { get; set; }

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
    public string? ErrorMessage { get; set; }

};
public class RiskRateModel
{
    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The month the risk rate was calculated for
    /// </summary>
    public DateTime ReportPeriod { get; set; }

    /// <summary>
    /// The string name of the month the risk rate was calculated for
    /// </summary>
    public string? InvoiceMonthName { get; set; }

    /// <summary>
    /// The count of all invoices in the calculation month
    /// </summary>
    public int TotalInvoiceCount { get; set; }

    /// <summary>
    /// The sum of the total amount for invoices in the calculation month
    /// </summary>
    public double TotalInvoiceAmount { get; set; }

    /// <summary>
    /// The count of open invoices over 90 days from the calculation month
    /// </summary>
    public int AtRiskCount { get; set; }

    /// <summary>
    /// The sum of the outstanding balance of open invoices over 90 days from the calculation month
    /// </summary>
    public double AtRiskAmount { get; set; }

    /// <summary>
    /// The percentage of all open invoices for the calculation month that are over 90 days based on count
    /// </summary>
    public double AtRiskCountPercentage { get; set; }

    /// <summary>
    /// The percentage of all open invoices for the calculation month that are over 90 days based on outstanding balance
    /// </summary>
    public double AtRiskPercentage { get; set; }

};
public class StateModel
{
    /// <summary>
    /// Name of the state
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 2 letter alphabetic code for the given state
    /// </summary>
    public string? Alpha2 { get; set; }

    /// <summary>
    /// A different name for a state
    /// </summary>
    public string? Aliases { get; set; }

};
public class StatusModel
{
    /// <summary>
    /// If authentication is successful, contains the username of the logged-in user.
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// If authentication is successful, contains subscription account name of logged-in user.
    /// </summary>
    public string? AccountName { get; set; }

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
    public bool LoggedIn { get; set; }

    /// <summary>
    /// The error message.
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// The set of roles for this user.
    /// </summary>
    public string[]? Roles { get; set; }

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
    public string? UserStatus { get; set; }

    /// <summary>
    /// The environment currently being used
    /// </summary>
    public string? Environment { get; set; }

    /// <summary>
    /// Statuses for the dependencies of this api.
    /// OK if the dependency is working.
    /// </summary>
    public object? Dependencies { get; set; }

};
public class SyncEntityResultModel
{
    /// <summary>
    /// The number of entities inserted
    /// </summary>
    public int InsertCount { get; set; }

    /// <summary>
    /// The number of entities updated
    /// </summary>
    public int UpdateCount { get; set; }

    /// <summary>
    /// The number of entities skipped
    /// </summary>
    public int SkipCount { get; set; }

    /// <summary>
    /// The number of errors encountered during sync
    /// </summary>
    public int ErrorCount { get; set; }

    /// <summary>
    /// The errors encountered during sync keyed by ERP key
    /// </summary>
    public object? Errors { get; set; }

};
public class SyncRequestModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid SyncRequestId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// Potential values = Cancelled, Ready, In Progress, Success, Failed
    /// </summary>
    public string? StatusCode { get; set; }

    /// <summary>
    /// Message containing information about the sync request results
    /// </summary>
    public string? ProcessResultMessage { get; set; }

    /// <summary>
    /// App enrollment sync request is for
    /// </summary>
    public Guid? AppEnrollmentId { get; set; }

    /// <summary>
    /// The date this sync request was created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The date this sync request was last modified
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID number of the user who most recently modified this sync request.
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// The detailed results from the sync.
    /// To retrieve this collection, set `includeDetails` to true in your GET requests.
    /// </summary>
    public object? Details { get; set; }

};
public class SyncSubmitModel
{
    /// <summary>
    /// The identifier of the app enrollment
    /// </summary>
    public Guid AppEnrollmentId { get; set; }

};
public class TransferOwnerModel
{
    /// <summary>
    /// The previous owner of the account.
    /// </summary>
    public UserAccountModel? PreviousOwner { get; set; }

    /// <summary>
    /// The new owner of the account.
    /// </summary>
    public UserAccountModel? NewOwner { get; set; }

};
public class TransferOwnerSubmitModel
{
    /// <summary>
    /// The ID of the user to transfer ownership to.
    /// </summary>
    public Guid TargetUserId { get; set; }

};
public class UserAccountModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// 
    /// This record provides a link to the user's Azure AD B2C OID.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The full name of the user
    /// </summary>
    public string? UserName { get; set; }

    /// <summary>
    /// The email of the user
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// The status of the user's account
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// The date that the user account was created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID of the user who created the user account
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date the user account was last modified
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified the user account
    /// </summary>
    public Guid ModifiedUserId { get; set; }

    /// <summary>
    /// The name of the user who last modified the user account
    /// </summary>
    public string? ModifiedUserName { get; set; }

    /// <summary>
    /// The ID of the user in Azure B2C
    /// </summary>
    public Guid? B2CUserId { get; set; }

    /// <summary>
    /// The id of the Permission Level for the user.
    /// </summary>
    public Guid UserRole { get; set; }

    /// <summary>
    /// The date timestamp when the invite was sent to the user.
    /// </summary>
    public DateTime? InviteSent { get; set; }

    /// <summary>
    /// The phone number of the user.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The fax number of the user.
    /// </summary>
    public string? FaxNumber { get; set; }

    /// <summary>
    /// The title of the user; free text field
    /// </summary>
    public string? Title { get; set; }

    /// <summary>
    /// FK to the CodeDefinition table; CodeType = 'AccountingRole'
    /// </summary>
    public Guid? AccountingRoleCodeDefId { get; set; }

    /// <summary>
    /// Address Line 1 for this User
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// Address Line 2 for this User
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// Address Line 3 for this User
    /// </summary>
    public string? Address3 { get; set; }

    /// <summary>
    /// City for this User
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Region ("state" in the US) for this User
    /// </summary>
    public string? StateRegion { get; set; }

    /// <summary>
    /// Postal Code this User
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Country for this User This will be validated by the /api/v1/countries data set
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Image URL for this User
    /// </summary>
    public string? ImageURL { get; set; }

    /// <summary>
    /// Description for this User.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Last date time user logged into Azure B2C.
    /// </summary>
    public DateTime? B2CLastLoggedIn { get; set; }

    /// <summary>
    /// The default currency code used by this user entity.  This value can be overridden
    /// for invoices in a different currency code.
    /// 
    /// For a list of defined currency codes, see [TODO]()
    /// </summary>
    public string? DefaultCurrencyCode { get; set; }

    /// <summary>
    /// All notes attached to this User.
    /// To retrieve this collection, specify `Notes` in the "Include" parameter for your query.
    /// </summary>
    public NoteModel[]? Notes { get; set; }

    /// <summary>
    /// All attachments attached to this User.
    /// To retrieve this collection, specify `Attachments` in the "Include" parameter for your query.
    /// </summary>
    public AttachmentModel[]? Attachments { get; set; }

    /// <summary>
    /// All values attached to this User.
    /// To retrieve this collection, specify `CustomFieldValues` in the "Include" parameter for your query.
    /// </summary>
    public CustomFieldValueModel[]? CustomFieldValues { get; set; }

    /// <summary>
    /// Accounting role definition for this User.
    /// To retrieve this collection, specify `AccountingRole` in the "Include" parameter for your query.
    /// </summary>
    public CodeDefinitionModel? AccountingRoleCodeDefinition { get; set; }

};
public class UserRoleModel
{
    /// <summary>
    /// The unique ID of this record, automatically assigned by Lockstep when this record is
    /// added to the Lockstep platform.
    /// </summary>
    public Guid UserRoleId { get; set; }

    /// <summary>
    /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
    /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
    /// 
    /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
    /// </summary>
    public Guid GroupKey { get; set; }

    /// <summary>
    /// The name of the user role
    /// </summary>
    public string? UserRoleName { get; set; }

    /// <summary>
    /// The date that the user role was created
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The ID of the user who created the user role
    /// </summary>
    public Guid CreatedUserId { get; set; }

    /// <summary>
    /// The date the user role was last modified
    /// </summary>
    public DateTime Modified { get; set; }

    /// <summary>
    /// The ID of the user who last modified the user role
    /// </summary>
    public Guid ModifiedUserId { get; set; }

};
