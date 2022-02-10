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
    public class WebhooksClient
    {
        private readonly LockstepApi _client;

        public WebhooksClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Webhook specified by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Webhook</param>
        public async Task<LockstepResponse<WebhookModel>> RetrieveWebhook(Guid id)
        {
            var url = $"/api/v1/Webhooks/{id}";
            return await _client.Request<WebhookModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates a webhook that matches the specified id with the requested information.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Webhook to update.</param>
        /// <param name="body">A list of changes to apply to this Webhook</param>
        public async Task<LockstepResponse<WebhookModel>> UpdateWebhook(Guid id, object body)
        {
            var url = $"/api/v1/Webhooks/{id}";
            return await _client.Request<WebhookModel>(HttpMethod.Patch, url, null, body, null);
        }

        /// <summary>
        /// Deletes the Webhook referred to by this unique identifier.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Webhook to delete.</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteWebhook(Guid id)
        {
            var url = $"/api/v1/Webhooks/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more webhooks from a given model.
        ///
        /// </summary>
        /// <param name="body">The Webhooks to create</param>
        public async Task<LockstepResponse<WebhookModel[]>> CreateWebhooks(WebhookModel[] body)
        {
            var url = $"/api/v1/Webhooks";
            return await _client.Request<WebhookModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Updates a webhook that matches the specified id with a new client secret.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Webhook to update.</param>
        public async Task<LockstepResponse<WebhookModel>> RegenerateClientSecret(Guid id)
        {
            var url = $"/api/v1/Webhooks/{id}/regenerateclientsecret";
            return await _client.Request<WebhookModel>(HttpMethod.Patch, url, null, null, null);
        }

        /// <summary>
        /// Queries Webhooks for this account using the specified filtering, sorting, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<WebhookModel>>> QueryWebhooks(string? filter, string? order, int? pageSize, int? pageNumber)
        {
            var url = $"/api/v1/Webhooks/query";
            var options = new Dictionary<string, object?>();
            options["filter"] = filter;
            options["order"] = order;
            options["pageSize"] = pageSize;
            options["pageNumber"] = pageNumber;
            return await _client.Request<FetchResult<WebhookModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}