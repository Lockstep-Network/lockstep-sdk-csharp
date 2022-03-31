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
    /// Lockstep Platform methods related to CustomFieldValues
    /// </summary>
    public class CustomFieldValuesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public CustomFieldValuesClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves all Custom Field Definitions.
        ///
        /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="definitionId">The unique Lockstep Platform ID number of the Custom Field Definition for the Custom Field Value to retrieve.</param>
        /// <param name="recordKey">The unique Lockstep Platform ID number of the Lockstep Platform object the Custom Field Value is attached to.</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: CustomFieldDefinition</param>
        public async Task<LockstepResponse<CustomFieldValueModel>> RetrieveField(Guid definitionId, Guid recordKey, string include = null)
        {
            var url = $"/api/v1/CustomFieldValues/{definitionId}/{recordKey}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<CustomFieldValueModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing Custom Field with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="definitionId">The unique Lockstep Platform ID number of the Custom Field Definition for the Custom Field Value to retrieve.</param>
        /// <param name="recordKey">The unique Lockstep Platform ID number of the Lockstep Platform object the Custom Field Value is attached to.</param>
        /// <param name="body">A list of changes to apply to this Custom Field</param>
        public async Task<LockstepResponse<CustomFieldValueModel>> UpdateField(Guid definitionId, Guid recordKey, object body)
        {
            var url = $"/api/v1/CustomFieldValues/{definitionId}/{recordKey}";
            return await _client.Request<CustomFieldValueModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the Custom Field referred to by this unique identifier.
        ///
        /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="definitionId">The unique Lockstep Platform ID number of the Custom Field Definition for the Custom Field Value to retrieve.</param>
        /// <param name="recordKey">The unique Lockstep Platform ID number of the Lockstep Platform object the Custom Field Value is attached to.</param>
        public async Task<LockstepResponse<ActionResultModel>> DeleteField(Guid definitionId, Guid recordKey)
        {
            var url = $"/api/v1/CustomFieldValues/{definitionId}/{recordKey}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Custom Fields and returns the records as created.
        ///
        /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="body">The Custom Fields to create</param>
        public async Task<LockstepResponse<CustomFieldValueModel[]>> CreateFields(CustomFieldValueModel[] body)
        {
            var url = $"/api/v1/CustomFieldValues";
            return await _client.Request<CustomFieldValueModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Custom Fields within the Lockstep platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: CustomFieldDefinition</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<CustomFieldValueModel>>> QueryFields(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/CustomFieldValues/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<CustomFieldValueModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
