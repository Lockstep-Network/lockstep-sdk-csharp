/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2021 Lockstep, Inc.
 * @version    2021.39
 * @link       https://github.com/tspence/lockstep-sdk-csharp
 */


using RestSharp;

namespace LockstepSDK;

public class ReportsClient
{
    private readonly LockstepApi client;

    public ReportsClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Retrieves a current Cash Flow report for this account.
    /// 
    /// The Cash Flow report indicates the amount of payments retrieved and invoices billed within a given timeframe.  You can use this report to determine the overall balance of money coming into and out of your accounts receivable and accounts payable businesses.
    /// 
    /// </summary>
    /// <param name="timeframe">Number of days of data to include for the Cash Flow Report (default is 30 days from today)</param>
    public async Task<LockstepResponse<CashflowReportModel>> CashFlow(int timeframe)
    {
        var url = $"/api/v1/Reports/cashflow";
        var options = new Dictionary<string, object>();
        options["timeframe"] = timeframe;
        return await this.client.Request<CashflowReportModel>(Method.GET, url, options, null);
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
        return await this.client.Request<DailySalesOutstandingReportModel[]>(Method.GET, url, null, null);
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
        return await this.client.Request<RiskRateModel[]>(Method.GET, url, null, null);
    }

    /// <summary>
    /// Retrieves AR header information up to the date specified.
    /// 
    /// </summary>
    /// <param name="reportDate">The date of the report.</param>
    /// <param name="companyId">Include a company to get AR data for a specific company, leave as null to include all Companies.</param>
    public async Task<LockstepResponse<ArHeaderInfoModel>> AccountsReceivableHeader(DateTime reportDate, Guid companyId)
    {
        var url = $"/api/v1/Reports/ar-header";
        var options = new Dictionary<string, object>();
        options["reportDate"] = reportDate;
        options["companyId"] = companyId;
        return await this.client.Request<ArHeaderInfoModel>(Method.GET, url, options, null);
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
    public async Task<LockstepResponse<AgingModel[]>> Invoiceagingreport(Guid CompanyId, bool Recalculate, string CurrencyCode, string CurrencyProvider, int[] Buckets)
    {
        var url = $"/api/v1/Reports/aging";
        var options = new Dictionary<string, object>();
        options["CompanyId"] = CompanyId;
        options["Recalculate"] = Recalculate;
        options["CurrencyCode"] = CurrencyCode;
        options["CurrencyProvider"] = CurrencyProvider;
        options["Buckets"] = Buckets;
        return await this.client.Request<AgingModel[]>(Method.GET, url, options, null);
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
        return await this.client.Request<ArAgingHeaderInfoModel[]>(Method.GET, url, null, null);
    }
}
