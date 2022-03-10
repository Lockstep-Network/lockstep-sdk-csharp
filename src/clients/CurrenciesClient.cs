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
    /// Lockstep Platform methods related to Currencies
    /// </summary>
    public class CurrenciesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CurrenciesClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieve a currency conversation rate from one currency to another as of the specified date.              Optionally, you can specify which currency data provider to use.
        ///
        ///              The currency rate model contains all of the information used to make the API call, plus the rate to              use for the conversion.
        ///
        /// </summary>
        /// <param name="sourceCurrency">The ISO 4217 currency code of the origin currency. For a list of currency codes, call List Currencies.</param>
        /// <param name="destinationCurrency">The ISO 4217 currency code of the target currency. For a list of currency codes, call List Currencies.</param>
        /// <param name="date">The date for which we should cto use for this currency conversion.</param>
        /// <param name="dataProvider">Optionally, you can specify a data provider.</param>
        public async Task<LockstepResponse<CurrencyRateModel>> Retrievecurrencyrate(string sourceCurrency, string destinationCurrency, DateTime date, string dataProvider)
        {
            var url = $"/api/v1/Currencies/{sourceCurrency}/{destinationCurrency}";
            var options = new Dictionary<string, object>();
            if (date != null) { options["date"] = date; }
            if (dataProvider != null) { options["dataProvider"] = dataProvider; }
            return await _client.Request<CurrencyRateModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Receives an array of dates and currencies and a destination currency and returns an array of the corresponding currency rates to the given destination currency (Limit X).
        ///
        /// </summary>
        /// <param name="destinationCurrency">The currency to convert to.</param>
        /// <param name="body">A list of dates and source currencies.</param>
        public async Task<LockstepResponse<CurrencyRateModel[]>> Bulkcurrencydata(BulkCurrencyConversionModel[] body, string destinationCurrency)
        {
            var url = $"/api/v1/Currencies/bulk";
            var options = new Dictionary<string, object>();
            if (destinationCurrency != null) { options["destinationCurrency"] = destinationCurrency; }
            return await _client.Request<CurrencyRateModel[]>(HttpMethod.Post, url, options, body, null);
        }
    }
}
