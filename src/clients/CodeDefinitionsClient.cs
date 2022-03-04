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
    /// Lockstep Platform methods related to CodeDefinitions
    /// </summary>
    public class CodeDefinitionsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CodeDefinitionsClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the CodeDefinition specified by this unique identifier, optionally including nested data sets.
        ///
        /// A CodeDefinition contains information around system code values and their definitions.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this CodeDefinition</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
#if DOT_NET_FRAMEWORK
        public async Task<LockstepResponse<CodeDefinitionModel>> RetrieveCodeDefinition(Guid id, string include)
#else
        public async Task<LockstepResponse<CodeDefinitionModel>> RetrieveCodeDefinition(Guid id, string? include)
#endif
        {
            var url = $"/api/v1/CodeDefinitions/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<CodeDefinitionModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries CodeDefinitions for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A CodeDefinition contains information around system code values and their definitions.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
#if DOT_NET_FRAMEWORK
        public async Task<LockstepResponse<FetchResult<CodeDefinitionModel>>> QueryCodeDefinitions(string filter, string include, string order, int? pageSize, int? pageNumber)
#else
        public async Task<LockstepResponse<FetchResult<CodeDefinitionModel>>> QueryCodeDefinitions(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
#endif
        {
            var url = $"/api/v1/CodeDefinitions/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<CodeDefinitionModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
