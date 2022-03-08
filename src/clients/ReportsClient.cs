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
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace LockstepSDK
{
    /// <summary>
    /// Lockstep Platform methods related to Reports
    /// </summary>
    public class ReportsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ReportsClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves a current Cash Flow report for this account.
        ///
        /// The Cash Flow report indicates the amount of payments retrieved and invoices billed within a given timeframe.  You can use this report to determine the overall balance of money coming into and out of your accounts receivable and accounts payable businesses.
        ///
        /// </summary>
        /// <param name="timeframe">Number of days of data to include for the Cash Flow Report (default is 30 days from today)</param>
        public async Task<LockstepResponse<CashflowReportModel>> CashFlow(int? timeframe)
        {
            var url = $"/api/v1/Reports/cashflow";
            var options = new Dictionary<string, object>();
            if (timeframe != null) { options["timeframe"] = timeframe; }
            return await _client.Request<CashflowReportModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieves a current Daily Sales Outstanding (DSO) report for this account.
        ///
        /// Daily Sales Outstanding, or DSO, is a metric that indicates the average number of days that it takes for an invoice to be fully paid.  You can use this report to identify whether a company is improving on its ability to collect on invoices.
        ///
        /// </summary>
        public async Task<LockstepResponse<DailySalesOutstandingReportModel[]>> DailySalesOutstanding()
        {
            var url = $"/api/v1/Reports/dailysalesoutstanding";
            return await _client.Request<DailySalesOutstandingReportModel[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieves a current Risk Rate report for this account.
        ///
        /// Risk Rate is a metric that indicates the percentage of total AR balance left unpaid after 90 days.  You can use this report to identify the percentage of invoice value that is not being collected in a timely manner.
        ///
        /// </summary>
        public async Task<LockstepResponse<RiskRateModel[]>> RiskRates()
        {
            var url = $"/api/v1/Reports/riskrates";
            return await _client.Request<RiskRateModel[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieves AR header information up to the date specified.
        ///
        /// </summary>
        /// <param name="reportDate">The date of the report.</param>
        /// <param name="companyId">Include a company to get AR data for a specific company, leave as null to include all Companies.</param>
#if DOT_NET_FRAMEWORK
        public async Task<LockstepResponse<ArHeaderInfoModel>> AccountsReceivableHeader(DateTime reportDate, Guid companyId)
#else
        public async Task<LockstepResponse<ArHeaderInfoModel>> AccountsReceivableHeader(DateTime reportDate, Guid? companyId)
#endif
        {
            var url = $"/api/v1/Reports/ar-header";
            var options = new Dictionary<string, object>();
            options["reportDate"] = reportDate;
            if (companyId != null) { options["companyId"] = companyId; }
            return await _client.Request<ArHeaderInfoModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// The Aging Report contains information about the total dollar value of invoices broken down by their age. Last default or specified bucket treated as a catch all bucket for values that fit in that bucket or beyond.
        ///
        /// You can specify viewing parameters for the aging report such as currency code and date bucket configuration. You can also view aging data for an entire account or a specific company.
        ///
        /// This information is recalculated when invoice data changes.  After each invoice data change occurs, Lockstep queues up a calculation based on the current invoice data at that time.  This information is calculated and persisted for each customer so that the report will be available quickly.
        ///
        /// To force a recalculation of aging data, specify the `recalculate` option.  Note that forcing a recalculation will slow your API response time.
        ///
        /// </summary>
        /// <param name="CompanyId">Company aging buckets are filtered by (all company aging returned if not company specified)</param>
        /// <param name="Recalculate">Force api to recalculate aging data, cached data may be returned when set to false</param>
        /// <param name="CurrencyCode">Currency aging buckets are converted to (all aging data returned without currency conversion if no currency is specified)</param>
        /// <param name="CurrencyProvider">Currency provider currency rates should be returned from to convert aging amounts to (default Lockstep currency provider used if no data provider specified)</param>
        /// <param name="Buckets">Customized buckets used for aging calculations (default buckets [0,30,60,90,120,180] will be used if buckets not specified)</param>
#if DOT_NET_FRAMEWORK
        public async Task<LockstepResponse<AgingModel[]>> Invoiceagingreport(Guid CompanyId, bool? Recalculate, string CurrencyCode, string CurrencyProvider, int[] Buckets)
#else
        public async Task<LockstepResponse<AgingModel[]>> Invoiceagingreport(Guid? CompanyId, bool? Recalculate, string? CurrencyCode, string? CurrencyProvider, int[]? Buckets)
#endif
        {
            var url = $"/api/v1/Reports/aging";
            var options = new Dictionary<string, object>();
            if (CompanyId != null) { options["CompanyId"] = CompanyId; }
            if (Recalculate != null) { options["Recalculate"] = Recalculate; }
            if (CurrencyCode != null) { options["CurrencyCode"] = CurrencyCode; }
            if (CurrencyProvider != null) { options["CurrencyProvider"] = CurrencyProvider; }
            if (Buckets != null) { options["Buckets"] = Buckets; }
            return await _client.Request<AgingModel[]>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieves AR Aging Header information report broken down by aging bucket.
        ///
        /// The AR Aging Header report contains aggregated information about the `TotalInvoicesPastDue`, `TotalCustomers`, and their respective `PercentageOfTotalAr` grouped by their aging `ReportBucket`.
        ///
        /// </summary>
        public async Task<LockstepResponse<ArAgingHeaderInfoModel[]>> AccountsReceivableAgingHeader()
        {
            var url = $"/api/v1/Reports/ar-aging-header";
            return await _client.Request<ArAgingHeaderInfoModel[]>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Retrieves Attachment Header information for the requested companyId.
        ///
        /// The Attachment Header report contains aggregated information about the `TotalAttachments`, `TotalArchived`, and `TotalActive` attachment classifications.
        ///
        /// </summary>
        /// <param name="companyId">Include a specific company to get Attachment data for, leave as null to include all Companies.</param>
#if DOT_NET_FRAMEWORK
        public async Task<LockstepResponse<AttachmentHeaderInfoModel>> AttachmentsHeaderInformation(Guid companyId)
#else
        public async Task<LockstepResponse<AttachmentHeaderInfoModel>> AttachmentsHeaderInformation(Guid? companyId)
#endif
        {
            var url = $"/api/v1/Reports/attachments-header";
            var options = new Dictionary<string, object>();
            if (companyId != null) { options["companyId"] = companyId; }
            return await _client.Request<AttachmentHeaderInfoModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Generates a Trial Balance Report for the given time range.
        ///
        /// The Attachment Header report contains aggregated information about the `TotalAttachments`, `TotalArchived`, and `TotalActive` attachment classifications.
        ///
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
#if DOT_NET_FRAMEWORK
        public async Task<LockstepResponse<TrialBalanceReportModel>> TrialBalanceReport(DateTime startDate, DateTime endDate)
#else
        public async Task<LockstepResponse<TrialBalanceReportModel>> TrialBalanceReport(DateTime? startDate, DateTime? endDate)
#endif
        {
            var url = $"/api/v1/Reports/trial-balance";
            var options = new Dictionary<string, object>();
            if (startDate != null) { options["startDate"] = startDate; }
            if (endDate != null) { options["endDate"] = endDate; }
            return await _client.Request<TrialBalanceReportModel>(HttpMethod.Get, url, options, null, null);
        }
    }
}
