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
using LockstepSDK.Models;


namespace LockstepSDK.Clients
{
    /// <summary>
    /// API methods related to Webhooks
    /// </summary>
    public class WebhooksClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public WebhooksClient(LockstepApi client)
        {
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
            return await _client.Request<WebhookModel>(new HttpMethod("PATCH"), url, null, body, null);
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
            var url = $"/api/v1/Webhooks/{id}/regenerate-client-secret";
            return await _client.Request<WebhookModel>(new HttpMethod("PATCH"), url, null, null, null);
        }

        /// <summary>
        /// Queries Webhooks for this account using the specified filtering, sorting, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collection: WebhookRules</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<WebhookModel>>> QueryWebhooks(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Webhooks/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<WebhookModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="webhookId">The unique Lockstep Platform ID number of this Webhook</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collection: Records, RequestMessage, ResponseMessage</param>
        /// <param name="filter">The filter for this query. See [Azure Query Language](https://docs.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities)</param>
        /// <param name="select">The selection for this query. Selection is the desired properties of an entity to pull from the set. If a property is not selected, it will either return as null or empty. See [Azure Query Language](https://docs.microsoft.com/en-us/rest/api/storageservices/querying-tables-and-entities)</param>
        /// <param name="pageSize">The page size for results (default 200).</param>
        /// <param name="pageNumber">The page number for results (default 0).</param>
        public async Task<LockstepResponse<FetchResult<WebhookHistoryTableStorageModel>>> QueryWebhookHistory(Guid webhookId, string include = null, string filter = null, string select = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Webhooks/{webhookId}/history/query";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            if (filter != null) { options["filter"] = filter; }
            if (select != null) { options["select"] = select; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<WebhookHistoryTableStorageModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        ///
        ///
        /// </summary>
        /// <param name="webhookId">The unique Lockstep Platform ID number of this Webhook</param>
        /// <param name="webhookHistoryId">The unique Lockstep Platform ID number of the Webhook History to be retried. Note: the webhook history supplied must have a isSuccessful status of false to be retried.</param>
        public async Task<LockstepResponse<string>> RetryFailedWebhookHistory(Guid webhookId, Guid webhookHistoryId)
        {
            var url = $"/api/v1/Webhooks/{webhookId}/history/{webhookHistoryId}/retry";
            return await _client.Request<string>(HttpMethod.Get, url, null, null, null);
        }
    }
}
