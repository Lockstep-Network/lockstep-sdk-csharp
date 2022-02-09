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

namespace LockstepSDK;



public class UserRolesClient
{
    private readonly LockstepApi _client;

    public UserRolesClient(LockstepApi client) {
        _client = client;
    }

    /// <summary>
    /// Retrieves the User Role with this identifier.
    ///
    /// </summary>
    /// <param name="id">The unique ID number of the User Role to retrieve</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
    public async Task<LockstepResponse<UserRoleModel>> RetrieveUserRole(Guid id, string? include)
    {
        var url = $"/api/v1/UserRoles/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await _client.Request<UserRoleModel>(HttpMethod.Get, url, options, null, null);
    }

    /// <summary>
    /// Queries User Roles for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
    ///
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
    /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    public async Task<LockstepResponse<FetchResult<UserRoleModel>>> QueryUserRoles(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/UserRoles/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await _client.Request<FetchResult<UserRoleModel>>(HttpMethod.Get, url, options, null, null);
    }
}
