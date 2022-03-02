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
    /// Lockstep Platform methods related to Notes
    /// </summary>
    public class NotesClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public NotesClient(LockstepApi client) {
            _client = client;
        }

        /// <summary>
        /// Retrieves the note with the specified note identifier.
        ///
        /// A note is a customizable text string that can be attached to various account attributes within Lockstep. You can use notes for internal communication, correspondence with clients, or personal reminders. The Note Model represents a note and a number of different metadata attributes related to the creation, storage, and ownership of the note.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="id">The unique ID number of the Note to retrieve</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        public async Task<LockstepResponse<NoteModel>> RetrieveNote(Guid id, string? include)
        {
            var url = $"/api/v1/Notes/{id}";
            var options = new Dictionary<string, object?>();
            options["include"] = include;
            return await _client.Request<NoteModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Archives the Note with the unique ID specified.
        ///
        /// A note is a customizable text string that can be attached to various account attributes within Lockstep. You can use notes for internal communication, correspondence with clients, or personal reminders. The Note Model represents a note and a number of different metadata attributes related to the creation, storage, and ownership of the note.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="id">Note id to be archived</param>
        public async Task<LockstepResponse<ActionResultModel>> ArchiveNote(Guid id)
        {
            var url = $"/api/v1/Notes/{id}";
            return await _client.Request<ActionResultModel>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more notes from the specified array of Note Models
        ///
        /// A note is a customizable text string that can be attached to various account attributes within Lockstep. You can use notes for internal communication, correspondence with clients, or personal reminders. The Note Model represents a note and a number of different metadata attributes related to the creation, storage, and ownership of the note.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="body">The array of notes to be created</param>
        public async Task<LockstepResponse<NoteModel[]>> CreateNotes(NoteModel[] body)
        {
            var url = $"/api/v1/Notes";
            return await _client.Request<NoteModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Notes on the Lockstep Platform using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// A note is a customizable text string that can be attached to various account attributes within Lockstep. You can use notes for internal communication, correspondence with clients, or personal reminders. The Note Model represents a note and a number of different metadata attributes related to the creation, storage, and ownership of the note.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter to use to select from the list of available applications, in the [Searchlight query syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available but may be offered in the future</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 200, maximum of 10,000)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        public async Task<LockstepResponse<FetchResult<NoteModel>>> QueryNotes(string? filter, string? include, string? order, int? pageSize, int? pageNumber)
        {
            var url = $"/api/v1/Notes/query";
            var options = new Dictionary<string, object?>();
            options["filter"] = filter;
            options["include"] = include;
            options["order"] = order;
            options["pageSize"] = pageSize;
            options["pageNumber"] = pageNumber;
            return await _client.Request<FetchResult<NoteModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
