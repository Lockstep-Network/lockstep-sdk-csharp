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



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace LockstepSDK
{
    /// <summary>
    /// API methods related to FinancialYearSettings
    /// </summary>
    public class FinancialYearSettingsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public FinancialYearSettingsClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Financial Year Setting specified by this unique identifier.
        ///
        /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Financial Year Setting</param>
        public async Task<LockstepResponse<FinancialYearSettingModel>> RetrieveFinancialYearSetting(Guid id)
        {
            var url = $"/api/v1/FinancialYearSettings/{id}";
            return await _client.Request<FinancialYearSettingModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates a financial year setting that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Financial Year Setting to update</param>
        /// <param name="body">A list of changes to apply to this Financial Year Setting</param>
        public async Task<LockstepResponse<FinancialYearSettingModel>> UpdateFinancialYearSetting(Guid id, object body)
        {
            var url = $"/api/v1/FinancialYearSettings/{id}";
            return await _client.Request<FinancialYearSettingModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Delete the Financial Year Setting referred to by this unique identifier.
        ///
        /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Financial Year Setting to disable</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteFinancialYearSetting(Guid id)
        {
            var url = $"/api/v1/FinancialYearSettings/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates a financial year setting from a given model.
        ///
        /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
        ///
        /// </summary>
        /// <param name="body">The Financial Year Setting to create</param>
        public async Task<LockstepResponse<FinancialYearSettingModel>> CreateFinancialYearSetting(FinancialYearSettingModel body)
        {
            var url = $"/api/v1/FinancialYearSettings";
            return await _client.Request<FinancialYearSettingModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Financial Year Settings for this account using the specified filtering, sorting, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A Financial Year Setting is used to to set the type, beginning, end, and number of periods of a year used to calculate accounting reports. The financial setting can either be for a specific app enrollment id via a sync or, when the financial year setting is manually created, will cover all account data without an app enrollment id.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<FinancialYearSettingModel>>> QueryFinancialYearSettings(string filter = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/FinancialYearSettings/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<FinancialYearSettingModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
