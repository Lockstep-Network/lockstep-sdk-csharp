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

public class ApplicationsClient
{
    private readonly LockstepApi client;

    public ApplicationsClient(LockstepApi client) {
        this.client = client;
    }

    /// <summary>
    /// Retrieves the Application with this identifier.
    /// 
    /// An Application represents a feature available to customers within the Lockstep Platform.  You can create Applications by working with your Lockstep business development manager and publish them on the platform so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer's instance of this Application.  The customer-specific AppEnrollment contains a customer's configuration data for the Application, which is not customer-specific.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the Application to retrieve</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Notes, Attachments, CustomFields</param>
    public async Task<LockstepResponse<ApplicationModel>> RetrieveApplication(Guid? id, string? include)
    {
        var url = $"/api/v1/Applications/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await this.client.Request<ApplicationModel>(Method.GET, url, options, null);
    }

    /// <summary>
    /// Updates an existing Application with the information supplied to this PATCH call.
    /// 
    /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  For example, you can provide the field name "IsActive" and specify the new value "False"; this API will then change the value of IsActive to false.   An Application represents a feature available to customers within the Lockstep Platform.  You can create Applications by working with your Lockstep business development manager and publish them on the platform so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer's instance of this Application.  The customer-specific AppEnrollment contains a customer's configuration data for the Application, which is not customer-specific.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the Application to update</param>
    /// <param name="body">A list of changes to apply to this Application</param>
    public async Task<LockstepResponse<ApplicationModel>> UpdateApplication(Guid? id, object? body)
    {
        var url = $"/api/v1/Applications/{id}";
        return await this.client.Request<ApplicationModel>(Method.PATCH, url, null, body);
    }

    /// <summary>
    /// Deletes the Application referred to by this unique identifier.  Information about this Application is retained but after the DELETE call, this Application is no longer available for use on the Lockstep Platform.  An Application represents a feature available to customers within the Lockstep Platform.  You can create Applications by working with your Lockstep business development manager and publish them on the platform so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer's instance of this Application.  The customer-specific AppEnrollment contains a customer's configuration data for the Application, which is not customer-specific.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="id">The unique ID number of the Application to delete</param>
    public async Task<LockstepResponse<ActionResultModel>> DeleteApplication(Guid? id)
    {
        var url = $"/api/v1/Applications/{id}";
        return await this.client.Request<ActionResultModel>(Method.DELETE, url, null, null);
    }

    /// <summary>
    /// Creates one or more Applications and returns the records as created.  Applications are universal and available across all accounts.
    /// 
    /// An Application represents a feature available to customers within the Lockstep Platform.  You can create Applications by working with your Lockstep business development manager and publish them on the platform so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer's instance of this Application.  The customer-specific AppEnrollment contains a customer's configuration data for the Application, which is not customer-specific.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="body">The Applications to create</param>
    public async Task<LockstepResponse<ApplicationModel[]>> CreateApplications(ApplicationModel[]? body)
    {
        var url = $"/api/v1/Applications";
        return await this.client.Request<ApplicationModel[]>(Method.POST, url, null, body);
    }

    /// <summary>
    /// Queries Applications on the Lockstep Platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.  An Application represents a feature available to customers within the Lockstep Platform.  You can create Applications by working with your Lockstep business development manager and publish them on the platform so that customers can browse and find your Application on the Lockstep Platform Marketplace.  When a customer adds an Application to their account, they obtain an AppEnrollment which represents that customer's instance of this Application.  The customer-specific AppEnrollment contains a customer's configuration data for the Application, which is not customer-specific.
    /// 
    /// See [Applications and Enrollments](https://developer.lockstep.io/docs/applications-and-enrollments) for more information.
    /// 
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Notes, Attachments, CustomFields</param>
    /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    public async Task<LockstepResponse<FetchResult<ApplicationModel>>> QueryApplications(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/Applications/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await this.client.Request<FetchResult<ApplicationModel>>(Method.GET, url, options, null);
    }
}
