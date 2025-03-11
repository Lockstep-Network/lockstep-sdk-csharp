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



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LockstepSDK.Models;


namespace LockstepSDK.Clients
{
    /// <summary>
    /// API methods related to WebhookRules
    /// </summary>
    public class WebhookRulesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public WebhookRulesClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Webhook Rule specified by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this Webhook Rule</param>
        public async Task<LockstepResponse<WebhookRuleModel>> RetrieveWebhookRule(Guid id)
        {
            var url = $"/api/v1/WebhookRules/{id}";
            return await _client.Request<WebhookRuleModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates a webhook rule that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Webhook Rule to update.</param>
        /// <param name="body">A list of changes to apply to this Webhook Rule</param>
        public async Task<LockstepResponse<WebhookRuleModel>> UpdateWebhookRule(Guid id, object body)
        {
            var url = $"/api/v1/WebhookRules/{id}";
            return await _client.Request<WebhookRuleModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the Webhook Rule referred to by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of the Webhook Rule to delete.</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteWebhookRule(Guid id)
        {
            var url = $"/api/v1/WebhookRules/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more webhook rules from a given model.
        ///
        /// </summary>
        /// <param name="body">The Webhook Rules to create</param>
        public async Task<LockstepResponse<WebhookRuleModel[]>> CreateWebhookRules(WebhookRuleModel[] body)
        {
            var url = $"/api/v1/WebhookRules";
            return await _client.Request<WebhookRuleModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Webhook Rules for this account using the specified filtering, sorting, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the ADS Platform Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<WebhookRuleModel>>> QueryWebhookRules(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/WebhookRules/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<WebhookRuleModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
