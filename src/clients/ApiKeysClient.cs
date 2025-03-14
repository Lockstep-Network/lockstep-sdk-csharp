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
    /// API methods related to ApiKeys
    /// </summary>
    public class ApiKeysClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ApiKeysClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the API Key with this identifier.
        ///
        /// An API Key is an authentication token that you may use with the ADS Platform API.  Because API Keys do not have an expiration date, they are well suited for unattended processes.  Each API Key is associated with a user, and may be revoked to prevent it from accessing the ADS Platform API. When you create an API Key, make sure to save the value in a secure location.  ADS Platform cannot retrieve an API Key once it is created.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the API Key to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future.</param>
        public async Task<LockstepResponse<ApiKeyModel>> RetrieveAPIKey(Guid id, string include = null)
        {
            var url = $"/api/v1/ApiKeys/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<ApiKeyModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Immediately revokes the API Key with the specified id so it cannot be used to call the API.
        ///
        /// The ADS Platform guarantees that revocation will be received by all servers within five minutes of revocation.  API calls made using this API key after the revocation will fail.  A revoked API Key cannot be un-revoked and may be removed 60 days after revocation.
        ///
        /// An API Key is an authentication token that you may use with the ADS Platform API.  Because API Keys do not have an expiration date, they are well suited for unattended processes.  Each API Key is associated with a user, and may be revoked to prevent it from accessing the ADS Platform API. When you create an API Key, make sure to save the value in a secure location.  ADS Platform cannot retrieve an API Key once it is created.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        ///
        /// </summary>
        /// <param name="id">The unique ADS Platform ID number of this API Key</param>
        public async Task<LockstepResponse<ActionResultModel>> RevokeAPIKey(Guid id)
        {
            var url = $"/api/v1/ApiKeys/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates an API key with the specified name.
        ///
        /// An API Key is an authentication token that you may use with the ADS Platform API.  Because API Keys do not have an expiration date, they are well suited for unattended processes.  Each API Key is associated with a user, and may be revoked to prevent it from accessing the ADS Platform API. When you create an API Key, make sure to save the value in a secure location.  ADS Platform cannot retrieve an API Key once it is created.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        ///
        /// </summary>
        /// <param name="body">Metadata about the API Key to create.</param>
        public async Task<LockstepResponse<ApiKeyModel>> CreateAPIKey(ApiKeyModel body)
        {
            var url = $"/api/v1/ApiKeys";
            return await _client.Request<ApiKeyModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries API Keys for this user using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// An API Key is an authentication token that you may use with the ADS Platform API.  Because API Keys do not have an expiration date, they are well suited for unattended processes.  Each API Key is associated with a user, and may be revoked to prevent it from accessing the ADS Platform API. When you create an API Key, make sure to save the value in a secure location.  ADS Platform cannot retrieve an API Key once it is created.
        ///
        /// For more information, see [API Keys](https://developer.lockstep.io/docs/api-keys).
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future.</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<ApiKeyModel>>> QueryAPIKeys(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/ApiKeys/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<ApiKeyModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
