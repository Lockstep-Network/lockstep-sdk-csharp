/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2023 Lockstep, Inc.
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
    /// API methods related to Transcriptions
    /// </summary>
    public class TranscriptionsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public TranscriptionsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Transcription Validation Request specified by this unique identifier, optionally including nested data sets.
        ///
        /// A Transcription Validation Request represents a collection of files sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the transcription validation request</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Items</param>
        public async Task<LockstepResponse<TranscriptionValidationRequestModel>> RetrieveTranscriptionValidationRequest(Guid id, string include = null)
        {
            var url = $"/api/v1/Transcriptions/validate/{id}";
            var options = new Dictionary<string, object>();
            if (include != null) { options["include"] = include; }
            return await _client.Request<TranscriptionValidationRequestModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Updates an existing Transcription Validation Request with the information supplied to this PATCH call.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A Transcription Validation Request represents a collection of files sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Transcription Validation Request to update</param>
        /// <param name="body">A list of changes to apply to this Transcription Validation Request</param>
        public async Task<LockstepResponse<TranscriptionValidationRequestModel>> UpdateTranscriptionValidationRequest(Guid id, object body)
        {
            var url = $"/api/v1/Transcriptions/validate/{id}";
            return await _client.Request<TranscriptionValidationRequestModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the Transcription Validation Request and all associated items referred to by this unique identifier.
        ///
        /// A Transcription Validation Request represents a collection of files sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the transcription validation request to delete</param>
        public async Task<LockstepResponse<DeleteResult>> DeleteTranscriptionValidationRequest(Guid id)
        {
            var url = $"/api/v1/Transcriptions/validate/{id}";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one Transcription Validation Request with all the associated request items within this account and returns the record as created.
        ///
        /// A Transcription Validation Request represents a collection of files sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="body">The files which will be verified</param>
        public async Task<LockstepResponse<TranscriptionValidationRequestModel>> CreateTranscriptionValidationRequest(TranscriptionRequestSubmit[] body)
        {
            var url = $"/api/v1/Transcriptions/validate";
            return await _client.Request<TranscriptionValidationRequestModel>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries transcription validation requests transactions for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: Items</param>
        /// <param name="order">The sort order for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<TranscriptionValidationRequestModel>>> QueryTranscriptionValidationRequests(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Transcriptions/validate/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<TranscriptionValidationRequestModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Retrieves the LockstepApi2.Models.TranscriptionValidationRequestItemModel specified by this unique identifier.
        ///
        /// A LockstepApi2.Models.TranscriptionValidationRequestItemModel represents a file sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="body">The LockstepApi2.Models.TranscriptionValidationRequestItemModels to add to an existing LockstepApi2.Models.TranscriptionValidationRequestItemModel</param>
        public async Task<LockstepResponse<TranscriptionValidationRequestItemModel[]>> CreatesaLockstepApi2.Models.TranscriptionValidationRequestItemModel(TranscriptionRequestSubmit[] body)
        {
            var url = $"/api/v1/Transcriptions/validation-items";
            return await _client.Request<TranscriptionValidationRequestItemModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Retrieves the LockstepApi2.Models.TranscriptionValidationRequestItemModel specified by this unique identifier.
        ///
        /// A LockstepApi2.Models.TranscriptionValidationRequestItemModel represents a file sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the LockstepApi2.Models.TranscriptionValidationRequestItemModel</param>
        public async Task<LockstepResponse<TranscriptionValidationRequestItemModel>> RetrieveaLockstepApi2.Models.TranscriptionValidationRequestItemModel(Guid id)
        {
            var url = $"/api/v1/Transcriptions/validation-items/{id}";
            return await _client.Request<TranscriptionValidationRequestItemModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Updates the LockstepApi2.Models.TranscriptionValidationRequestItemModel specified by this unique identifier.
        ///
        /// The PATCH method allows you to change specific values on the object while leaving other values alone.  As input you should supply a list of field names and new values.  If you do not provide the name of a field, that field will remain unchanged.  This allows you to ensure that you are only updating the specific fields desired.
        ///
        /// A LockstepApi2.Models.TranscriptionValidationRequestItemModel represents a file sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the LockstepApi2.Models.TranscriptionValidationRequestItemModel</param>
        /// <param name="body">A list of changes to apply to this LockstepApi2.Models.TranscriptionValidationRequestItemModel</param>
        public async Task<LockstepResponse<TranscriptionValidationRequestItemModel>> UpdateaLockstepApi2.Models.TranscriptionValidationRequestItemModel(Guid id, object body)
        {
            var url = $"/api/v1/Transcriptions/validation-items/{id}";
            return await _client.Request<TranscriptionValidationRequestItemModel>(new HttpMethod("PATCH"), url, null, body, null);
        }

        /// <summary>
        /// Deletes the LockstepApi2.Models.TranscriptionValidationRequestItemModel specified by this unique identifier.
        ///
        /// A LockstepApi2.Models.TranscriptionValidationRequestItemModel represents a file sent from the client to verify the file type using the machine learning platform Sage AI.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the LockstepApi2.Models.TranscriptionValidationRequestItemModel</param>
        public async Task<LockstepResponse<DeleteResult>> DeleteaLockstepApi2.Models.TranscriptionValidationRequestItemModel(Guid id)
        {
            var url = $"/api/v1/Transcriptions/validation-items/{id}";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Queries LockstepApi2.Models.TranscriptionValidationRequestItemModels for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future ///</param>
        /// <param name="order">The sort order for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<TranscriptionValidationRequestItemModel>>> QueryTranscriptionValidationRequestItems(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/Transcriptions/validation-items/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<TranscriptionValidationRequestItemModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
