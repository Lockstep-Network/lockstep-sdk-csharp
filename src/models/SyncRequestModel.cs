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



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// Represents a Sync action that loads data from a connector into the Lockstep Platform.  Users can
    /// request Sync actions manually using Lockstep Inbox, or via the [Create Sync API](https://developer.lockstep.io/reference/post_api-v1-sync).
    /// Each Sync action is tied to an [AppEnrollment](https://developer.lockstep.io/docs/applications-and-enrollments).
    /// When the Sync action is complete, the field `StatusCode` will be set to either `Success` or `Failed`.
    ///
    /// You can fetch a list of detailed results for the Sync API by calling Retrieve or Query with an `include`
    /// parameter of `details`.  These detailed results contain line-by-line errors that were detected during
    /// processing of this sync.
    /// </summary>
    public class SyncRequestModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? SyncRequestId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The status of processing for this SyncRequest.  When a SyncRequest is created, it is flagged as `Ready`.
        /// When it is picked up for execution, its status moves to `In Progress`.  When it is complete, its status
        /// will move to `Success` or `Failed`.  If another API call cancels the SyncRequest, its status will move
        /// to `Cancelled`.
        ///
        /// * Ready
        /// * In Progress
        /// * Cancelled
        /// * Failed
        /// * Success
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// The name of the OperationType for this SyncRequest
        /// </summary>
        public string OperationTypeName { get; set; }

        /// <summary>
        /// The name of the OperationType for this SyncRequest
        /// </summary>
        public int? OperationType { get; set; }

        /// <summary>
        /// Message containing information about the sync request results
        /// </summary>
        public string ProcessResultMessage { get; set; }

        /// <summary>
        /// A boolean indicating whether a sync from an ERP system should process all the data from the ERP
        /// as opposed to just the delta of changes since the previous sync run
        /// </summary>
        public string RunFullSync { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the AppEnrollment object that executed this sync request
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The date this sync request was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The date this sync request was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this sync request.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The detailed list of results and errors that occurred during the processing of this SyncRequest.  This
        /// information is available only after the SyncRequest has completed.  You will only be able to fetch this
        /// field if the SyncRequest&#39;s `StatusCode` field is set to `Cancelled`, `Success`, or `Failed`.
        ///
        /// To retrieve this collection, add the keyword `details` to the `include` parameter on your Retrieve or
        /// Query requests.
        /// </summary>
        public object Details { get; set; }
    }
}
