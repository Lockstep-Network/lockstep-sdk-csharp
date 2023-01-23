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
    /// Represents a transcription validation request that is used to validate if file is of a specific type.
    /// </summary>
    public class TranscriptionValidationRequestModel
    {

        /// <summary>
        /// The unique identifier of the transcription validation request.
        /// </summary>
        public Guid? TranscriptionValidationRequestId { get; set; }

        /// <summary>
        /// Group account transcription validation request is associated with.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// A code identifying the status of this transcription validation request.
        ///
        /// Recognized Transcription Validation Request status codes are:
        /// * `New` - Represents a transcription validation request that is considered new and needs work to complete
        /// * `In Progress` - Represents a transcription validation request that is currently being worked on
        /// * `Failed` - Represents a transcription validation request that could not complete the validation process
        /// * `Complete` - Represents a transcription validation request that is considered complete and does not need any further work
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// The date on which this transcription validation request was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this transcription validation request.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this transcription validation request was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this transcription validation request.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// All items attached to this transcription validation request.
        /// To retrieve this collection, specify `Items` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public TranscriptionValidationRequestItemModel[] Items { get; set; }
    }
}
