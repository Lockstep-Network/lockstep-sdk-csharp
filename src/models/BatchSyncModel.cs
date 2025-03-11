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
    /// A BatchSyncModel contains a collection of records to load into the ADS Platform.  Data contained
    /// in this batch will be merged with your existing data.  Each record will be matched with existing data inside
    /// the ADS Platform using the [Identity Column](https://developer.lockstep.io/docs/identity-columns) rules.
    /// Any record that represents a new AppEnrollmentId+ErpKey will be inserted.  A record that matches an existing
    /// AppEnrollmentId+ErpKey will be updated, but only if the data has changed.
    ///
    /// A Sync process permits either a complete data file or a partial / delta data file.  ADS recommends
    /// using a sliding time window to avoid the risk of clock skew errors that might accidentally omit records.
    /// Best practice is to run a Sync process daily, and to export all data that has changed in the past 48 hours.
    /// </summary>
    public class BatchSyncModel
    {

        /// <summary>
        /// The optional existing app enrollment to associate with the data in this batch.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// True if this is a full sync, false if this is a partial sync. Defaults to false.
        /// </summary>
        public bool? IsFullSync { get; set; }

        /// <summary>
        /// The optional current batch number for this batch sync.
        /// </summary>
        public int? CurrentBatch { get; set; }

        /// <summary>
        /// The optional total number of batchs for this batch sync.
        /// </summary>
        public int? TotalBatches { get; set; }

        /// <summary>
        /// The optional existing parent sync request id for the batch sync.
        /// </summary>
        public Guid? ParentSyncRequestId { get; set; }

        /// <summary>
        /// A list of Company records to merge with your ADS Platform data
        /// </summary>
        public CompanySyncModel[] Companies { get; set; }

        /// <summary>
        /// A list of Contact records to merge with your ADS Platform data
        /// </summary>
        public ContactSyncModel[] Contacts { get; set; }

        /// <summary>
        /// A list of CreditMemoApplied records to merge with your ADS Platform data
        /// </summary>
        public CreditMemoAppliedSyncModel[] CreditMemoApplications { get; set; }

        /// <summary>
        /// A list of Invoice records to merge with your ADS Platform data
        /// </summary>
        public InvoiceSyncModel[] Invoices { get; set; }

        /// <summary>
        /// A list of InvoiceLine records to merge with your ADS Platform data
        /// </summary>
        public InvoiceLineSyncModel[] InvoiceLines { get; set; }

        /// <summary>
        /// A list of InvoiceWorkflowStatus records to merge with your ADS Platform data
        /// </summary>
        public InvoiceWorkflowStatusSyncModel[] InvoiceWorkflowStatuses { get; set; }

        /// <summary>
        /// A list of CustomField records to merge with your ADS Platform data
        /// </summary>
        public CustomFieldSyncModel[] CustomFields { get; set; }

        /// <summary>
        /// A list of Payment records to merge with your ADS Platform data
        /// </summary>
        public PaymentSyncModel[] Payments { get; set; }

        /// <summary>
        /// A list of PaymentApplied records to merge with your ADS Platform data
        /// </summary>
        public PaymentAppliedSyncModel[] PaymentApplications { get; set; }

        /// <summary>
        /// A list of FinancialYearSetting records to merge with your ADS Platform data
        /// </summary>
        public FinancialYearSettingSyncModel[] FinancialYearSettings { get; set; }

        /// <summary>
        /// A list of FinancialAccount records to merge with your ADS Platform data
        /// </summary>
        public FinancialAccountSyncModel[] FinancialAccounts { get; set; }

        /// <summary>
        /// A list of FinancialAccountBalanceHistory records to merge with your ADS Platform data
        /// </summary>
        public FinancialAccountBalanceHistorySyncModel[] FinancialAccountBalanceHistories { get; set; }

        /// <summary>
        /// A list of BaseCurrency records to merge with your ADS Platform data
        /// </summary>
        public BaseCurrencySyncModel[] BaseCurrencies { get; set; }

        /// <summary>
        /// A list of JournalEntry records to merge with your ADS Platform data
        /// </summary>
        public JournalEntrySyncModel[] JournalEntries { get; set; }

        /// <summary>
        /// A list of JournalEntryLine records to merge with your ADS Platform data
        /// </summary>
        public JournalEntryLineSyncModel[] JournalEntryLines { get; set; }
    }
}
