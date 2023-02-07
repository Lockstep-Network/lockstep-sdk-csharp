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
    /// API methods related to AttachmentLinks
    /// </summary>
    public class AttachmentLinksClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public AttachmentLinksClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Attachment Link with the provided Attachment Link identifier.
        ///
        /// An Attachment Link is a link that associates one Attachment with one object within Lockstep.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <param name="objectKey"></param>
        /// <param name="tableName"></param>
        public async Task<LockstepResponse<AttachmentLinkModel>> RetrieveAttachmentLink(Guid attachmentId, Guid objectKey, string tableName)
        {
            var url = $"/api/v1/AttachmentLinks";
            var options = new Dictionary<string, object>();
            options["attachmentId"] = attachmentId;
            options["objectKey"] = objectKey;
            options["tableName"] = tableName;
            return await _client.Request<AttachmentLinkModel>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Creates one Attachment Link from the provided arguments.
        ///
        /// An Attachment Link is a link that associates one Attachment with one object within Lockstep.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="body"></param>
        public async Task<LockstepResponse<AttachmentLinkModel[]>> UploadAttachment(AttachmentLinkModel[] body)
        {
            var url = $"/api/v1/AttachmentLinks";
            return await _client.Request<AttachmentLinkModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Delete the specified link between an object and its attachment.
        ///
        /// An Attachment Link is a link that associates one Attachment with one object within Lockstep.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <param name="objectKey"></param>
        /// <param name="tableName"></param>
        public async Task<LockstepResponse<DeleteResult>> DeleteAttachmentLink(Guid? attachmentId = null, Guid? objectKey = null, string tableName = null)
        {
            var url = $"/api/v1/AttachmentLinks";
            var options = new Dictionary<string, object>();
            if (attachmentId != null) { options["attachmentId"] = attachmentId; }
            if (objectKey != null) { options["objectKey"] = objectKey; }
            if (tableName != null) { options["tableName"] = tableName; }
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, options, null, null);
        }

        /// <summary>
        /// Queries Attachment Links for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// An Attachment Link is a link that associates one Attachment with one object within Lockstep.
        ///
        /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
        ///
        /// </summary>
        /// <param name="filter">The filter to use to select from the list of available Attachments, in the [Searchlight query syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. No collections are currently available for querying but may be available in the future.</param>
        /// <param name="order">The sort order for the results, in the [Searchlight order syntax](https://github.com/tspence/csharp-searchlight).</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500)</param>
        /// <param name="pageNumber">The page number for results (default 0)</param>
        public async Task<LockstepResponse<FetchResult<AttachmentLinkModel>>> QueryAttachmentLinks(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/AttachmentLinks/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<AttachmentLinkModel>>(HttpMethod.Get, url, options, null, null);
        }
    }
}
