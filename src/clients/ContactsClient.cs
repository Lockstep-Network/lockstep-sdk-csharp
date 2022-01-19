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
 * @version    2022.3
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */

namespace LockstepSDK;



public class ContactsClient
{
    private readonly LockstepApi _client;

    public ContactsClient(LockstepApi client) {
        _client = client;
    }

    /// <summary>
    /// Retrieves the Contact specified by this unique identifier, optionally including nested data sets.  A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of this Contact; NOT the customer's ERP key</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
    public async Task<LockstepResponse<ContactModel>> RetrieveContact(Guid? id, string? include)
    {
        var url = $"/api/v1/Contacts/{id}";
        var options = new Dictionary<string, object?>();
        options["include"] = include;
        return await _client.Request<ContactModel>(HttpMethod.Get, url, options, null);
    }

    /// <summary>
    /// Updates a contact that matches the specified id with the requested information.
    /// 
    /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.  A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of the Contact to update; NOT the customer's ERP key</param>
    /// <param name="body">A list of changes to apply to this Contact</param>
    public async Task<LockstepResponse<ContactModel>> UpdateContact(Guid? id, object? body)
    {
        var url = $"/api/v1/Contacts/{id}";
        return await _client.Request<ContactModel>(HttpMethod.Patch, url, null, body);
    }

    /// <summary>
    /// Disable the Contact referred to by this unique identifier.
    /// 
    /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
    /// 
    /// </summary>
    /// <param name="id">The unique Lockstep Platform ID number of the Contact to disable; NOT the customer's ERP key</param>
    public async Task<LockstepResponse<ActionResultModel>> DisableContact(Guid? id)
    {
        var url = $"/api/v1/Contacts/{id}";
        return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null);
    }

    /// <summary>
    /// Creates one or more contacts from a given model.
    /// 
    /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
    /// 
    /// </summary>
    /// <param name="body">The Contacts to create</param>
    public async Task<LockstepResponse<ContactModel[]>> CreateContacts(ContactModel[]? body)
    {
        var url = $"/api/v1/Contacts";
        return await _client.Request<ContactModel[]>(HttpMethod.Post, url, null, body);
    }

    /// <summary>
    /// Queries Contacts for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
    /// 
    /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.  A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
    /// 
    /// </summary>
    /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Attachments, CustomFields, Notes</param>
    /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
    public async Task<LockstepResponse<FetchResult<ContactModel>>> QueryContacts(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
    {
        var url = $"/api/v1/Contacts/query";
        var options = new Dictionary<string, object?>();
        options["filter"] = filter;
        options["include"] = include;
        options["order"] = order;
        options["pageSize"] = pageSize;
        options["pageNumber"] = pageNumber;
        return await _client.Request<FetchResult<ContactModel>>(HttpMethod.Get, url, options, null);
    }
}
