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

public class CodeDefinitionsClient
{
    private readonly LockstepApi client;

    public CodeDefinitionsClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Retrieves the CodeDefinition specified by this unique identifier, optionally including nested data sets.
    /// 
    /// A CodeDefinition contains information around system code values and their definitions.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this CodeDefinition</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
    public async Task<LockstepResponse<CodeDefinitionModel>> RetrieveCodeDefinition(Guid? id, string? include)
    {
        var url = $"/api/v1/CodeDefinitions/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await this.client.Request<CodeDefinitionModel>(Method.GET, url, options, null);
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
    public async Task<LockstepResponse<FetchResult<CodeDefinitionModel>>> QueryCodeDefinitions(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/CodeDefinitions/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await this.client.Request<FetchResult<CodeDefinitionModel>>(Method.GET, url, options, null);
    }
}
