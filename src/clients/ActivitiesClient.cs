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
 * @version    2022.4
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



public class ActivitiesClient
{
    private readonly LockstepApi _client;

    public ActivitiesClient(LockstepApi client) {
        _client = client;
    }

    /// <summary>
    /// Retrieves the Activity specified by this unique identifier, optionally including nested data sets.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Activity</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Company, Attachments, CustomFields, Notes, References, and UserAssignedToName</param>
    public async Task<LockstepResponse<ActivityModel>> RetrieveActivity(Guid id, string? include)
    {
        var url = $"/api/v1/Activities/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await _client.Request<ActivityModel>(HttpMethod.Get, url, options, null);
    }

    /// <summary>
    /// Updates an activity that matches the specified id with the requested information.
    ///
    /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of the Activity to update</param>
    /// <param name="body">A list of changes to apply to this Activity</param>
    public async Task<LockstepResponse<ActivityModel>> UpdateActivity(Guid id, object body)
    {
        var url = $"/api/v1/Activities/{id}";
        return await _client.Request<ActivityModel>(HttpMethod.Patch, url, null, body);
    }

    /// <summary>
    /// Delete the Activity referred to by this unique identifier.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of the Activity to delete</param>
    public async Task<LockstepResponse<ActivityModel>> DeleteActivity(Guid id)
    {
        var url = $"/api/v1/Activities/{id}";
        return await _client.Request<ActivityModel>(HttpMethod.Delete, url, null, null);
    }

    /// <summary>
    /// Creates one or more activities from a given model.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="body">The Activities to create</param>
    public async Task<LockstepResponse<ActivityModel[]>> CreateActivities(ActivityModel[] body)
    {
        var url = $"/api/v1/Activities";
        return await _client.Request<ActivityModel[]>(HttpMethod.Post, url, null, body);
    }

    /// <summary>
    /// Queries Activities for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
    ///
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Company, Attachments, CustomFields, Notes, References, and UserAssignedToName</param>
    /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    public async Task<LockstepResponse<FetchResult<ActivityModel>>> QueryActivities(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/Activities/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await _client.Request<FetchResult<ActivityModel>>(HttpMethod.Get, url, options, null);
    }

    /// <summary>
    /// Retrieves a list of items representing the activity stream for the supplied activity id.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Activity</param>
    public async Task<LockstepResponse<ActivityStreamItemModel[]>> RetrieveActivityStream(Guid id)
    {
        var url = $"/api/v1/Activities/{id}/stream";
        return await _client.Request<ActivityStreamItemModel[]>(HttpMethod.Get, url, null, null);
    }

    /// <summary>
    /// Forwards an activity by creating a new activity with all child references and assigning the new activity to a new user.
    ///
    /// An Activity contains information about work being done on a specific accounting task. You can use Activities to track information about who has been assigned a specific task, the current status of the task, the name and description given for the particular task, the priority of the task, and any amounts collected, paid, or credited for the task.
    ///
    /// </summary>
    /// <param name="activityId"></param>
    /// <param name="userId"></param>
    public async Task<LockstepResponse<ActivityModel>> ForwardActivity(Guid activityId, Guid userId)
    {
        var url = $"/api/v1/Activities/{activityId}/forward/{userId}";
        return await _client.Request<ActivityModel>(HttpMethod.Post, url, null, null);
    }
}
