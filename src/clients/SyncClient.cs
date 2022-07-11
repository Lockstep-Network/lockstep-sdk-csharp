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
    /// API methods related to Sync
    /// </summary>
    public class SyncClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public SyncClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Requests a new Sync task from the Application specified in the request and returns a token that can be used to check the progress and status of the task.
        ///
        /// A Sync task represents an action performed by an Application for a particular account.  An Application can provide many different tasks as part of their capabilities.  Sync tasks are executed in the background and will continue running after they are created.  Use one of the creation APIs to request execution of a task. To check on the progress of the task, call GetSync or QuerySync.
        ///
        /// </summary>
        /// <param name="body">Information about the Sync to execute</param>
        public async Task<LockstepResponse<SyncRequestModel>> CreateSync(SyncSubmitModel body)
        {
            var url = $"/api/v1/Sync";
            return await _client.Request<SyncRequestModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Creates a new batch import Sync task that imports all the models provided to this API call.
        ///
        /// A Sync task represents ingestion of data from a source.  For each data model in the source, the Sync process will determine whether the data is new, updated, or unchanged from data that already exists within the Lockstep Platform.  For records that are new, the Sync process will add them to the Lockstep Platform data.  For records that are updated, the Sync process will update existing data to match the newly uploaded records.  If records have not changed, no action will be taken.
        ///
        /// You can use this Batch Import process to load data in bulk directly into the Lockstep Platform.
        ///
        /// </summary>
        /// <param name="body">Information about the Sync to execute</param>
        public async Task<LockstepResponse<SyncRequestModel>> CreateBatchImport(BatchSyncModel body)
        {
            var url = $"/api/v1/Sync/batch";
            return await _client.Request<SyncRequestModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Requests a new Sync task from a ZIP file you provide.  This ZIP file can contain one or more files with data from the customer&#39;s platform.  Individual files can be in the format CSV or JSONL (JSON with Lines).
        ///
        /// A Sync task represents an action performed by an Application for a particular account.  An Application can provide many different tasks as part of their capabilities.  Sync tasks are executed in the background and will continue running after they are created.  Use one of the creation APIs to request execution of a task. To check on the progress of the task, call GetSync or QuerySync.
        ///
        /// </summary>
        /// <param name="filename">The full path of a file to upload to the API</param>
        public async Task<LockstepResponse<SyncRequestModel>> UploadSyncFile(string filename)
        {
            var url = $"/api/v1/Sync/zip";
            return await _client.Request<SyncRequestModel>(HttpMethod.Post, url, null, null, filename);
        }

        /// <summary>
        /// Updates an existing Sync with the information supplied to this PATCH call.
        ///
        /// This API is restricted to internal service users and may not be called by customers or partners.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  For example, you can provide the field name &quot;IsActive&quot; and specify the new value &quot;False&quot;; this API will then change the value of IsActive to false.
        ///
        /// A Sync task represents an action performed by an Application for a particular account.  An Application can provide many different tasks as part of their capabilities.  Sync tasks are executed in the background and will continue running after they are created.  Use one of the creation APIs to request execution of a task. To check on the progress of the task, call GetSync or QuerySync.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Sync to update</param>
        /// <param name="body">A list of changes to apply to this Application</param>
        public async Task<LockstepResponse<SyncRequestModel>> UpdateSync(Guid id, object body)
        {
            var url = $"/api/v1/Sync/{id}";
            return await _client.Request<SyncRequestModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Retrieves the status and information about a Sync operation by the requested ID.  Provides status and progress information about this task.
        ///
        /// A Sync task represents an action performed by an Application for a particular account.  An Application can provide many different tasks as part of their capabilities.  Sync tasks are executed in the background and will continue running after they are created.  Use one of the creation APIs to request execution of a task. To check on the progress of the task, call GetSync or QuerySync.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Sync task to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Details</param>
        public async Task<LockstepResponse<SyncRequestModel>> RetrieveSync(Guid id, string include = null)
        {
            var url = $"/api/v1/Sync/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<SyncRequestModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Cancels a Sync process for an Application if the request is still being processed within the Application. This does not cancel Sync processes which have already proceeded to completion within the Application, or Sync processes outside of Applications such as from a Zip file or Batch Import.
        ///
        /// A Sync task represents an action performed by an Application for a particular account.  An Application can provide many different tasks as part of their capabilities.  Sync tasks are executed in the background and will continue running after they are created.  Use one of the creation APIs to request execution of a task. To check on the progress of the task, call GetSync or QuerySync.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Sync task to cancel</param>
        public async Task<LockstepResponse<SyncRequestModel>> CancelSync(Guid id)
        {
            var url = $"/api/v1/Sync/{id}";
            return await _client.Request<SyncRequestModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Queries Sync tasks for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A Sync task represents an action performed by an Application for a particular account.  An Application can provide many different tasks as part of their capabilities.  Sync tasks are executed in the background and will continue running after they are created.  Use one of the creation APIs to request execution of a task. To check on the progress of the task, call GetSync or QuerySync.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Details</param>
        /// <param name="order">The sort order for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 200). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<SyncRequestModel>>> QuerySyncs(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Sync/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<SyncRequestModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
