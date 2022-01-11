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
 * @version    2022.2
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



using RestSharp;

public class CustomFieldDefinitionsClient
{
    private readonly LockstepApi client;

    public CustomFieldDefinitionsClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Retrieves the Custom Field Definition specified by this unique identifier.
    /// 
    /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.  See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Custom Field Definition</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No additional data collections are currently defined on this object, but may be supported in the future.</param>
    public async Task<LockstepResponse<CustomFieldDefinitionModel>> RetrieveFieldDefinition(Guid? id, string? include)
    {
        var url = $"/api/v1/CustomFieldDefinitions/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await this.client.Request<CustomFieldDefinitionModel>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Updates an existing Custom Field Definition with the information supplied to this PATCH call.
    /// 
    /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
    /// 
    /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.  See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of the Custom Field Definition to update</param>
    /// <param name="body">A list of changes to apply to this Custom Field Definition</param>
    public async Task<LockstepResponse<CustomFieldDefinitionModel>> UpdateFieldDefinition(Guid? id, object? body)
    {
        var url = $"/api/v1/CustomFieldDefinitions/{id}";
        return await this.client.Request<CustomFieldDefinitionModel>(Method.PATCH, url, null, body);
    }

    /// <summary>
    /// Deletes the Custom Field Definition referred to by this unique identifier.
    /// 
    /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.  See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of the Custom Field Definition to delete</param>
    public async Task<LockstepResponse<CustomFieldDefinitionModel>> DeleteFieldDefinition(Guid? id)
    {
        var url = $"/api/v1/CustomFieldDefinitions/{id}";
        return await this.client.Request<CustomFieldDefinitionModel>(Method.DELETE, url, null, null);
    }

    /// <summary>
    /// Creates one or more Custom Field Definitions and returns the records as created.  A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.  See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// 
    /// </summary>
    /// <param name="body">The Custom Field Definitions to create</param>
    public async Task<LockstepResponse<CustomFieldDefinitionModel[]>> CreateFieldDefinitions(CustomFieldDefinitionModel[]? body)
    {
        var url = $"/api/v1/CustomFieldDefinitions";
        return await this.client.Request<CustomFieldDefinitionModel[]>(Method.POST, url, null, body);
    }

    /// <summary>
    /// Queries Custom Field Definitions within the Lockstep platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
    /// 
    /// A Custom Field represents metadata added to an object within the Lockstep Platform.  Lockstep provides a core definition for each object.  The core definition is intended to represent a level of compatibility that provides support across most accounting systems and products.  When a user or developer requires information beyond this core definition, you can use Custom Fields to represent this information.  See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// 
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No additional data collections are currently defined on this object, but may be supported in the future.</param>
    /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    public async Task<LockstepResponse<FetchResult<CustomFieldDefinitionModel>>> QueryFieldDefinitions(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/CustomFieldDefinitions/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await this.client.Request<FetchResult<CustomFieldDefinitionModel>>(Method.GET, url, options, null);
    }
}
