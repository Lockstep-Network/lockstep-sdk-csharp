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
    /// Represents a transcription validation request item to be validated.
    /// </summary>
    public class TranscriptionValidationRequestItemModel
    {

        /// <summary>
        /// The unique identifier of the transcription validation request item.
        /// </summary>
        public Guid? TranscriptionValidationRequestItemId { get; set; }

        /// <summary>
        /// The ID number of the transcription validation request this item belongs to.
        /// </summary>
        public Guid? TranscriptionValidationRequestId { get; set; }

        /// <summary>
        /// Group account transcription validation request item is associated with.
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Generated hash of the file being validated.
        /// </summary>
        public string FileHash { get; set; }

        /// <summary>
        /// Original name of the file on disk, without its extension.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Original extension name of the file on disk.
        /// </summary>
        public string FileExt { get; set; }

        /// <summary>
        /// Location of file in blob storage to be validated.
        /// </summary>
        public string FileLocation { get; set; }

        /// <summary>
        /// Transcription result
        /// </summary>
        public string TranscriptionResult { get; set; }

        /// <summary>
        /// Transcription process start date
        /// </summary>
        public DateTime? ProcessStart { get; set; }

        /// <summary>
        /// Transcription process end date
        /// </summary>
        public DateTime? ProcessEnd { get; set; }

        /// <summary>
        /// Amount of times item was processed to retrieve the transcription data
        /// </summary>
        public int? RetryCount { get; set; }

        /// <summary>
        /// Feedback result specified by the client when the transcription result is not correct. This feedback result will be sent back to the transcription services to retrain and improve models over time.
        /// </summary>
        public string FeedbackResult { get; set; }

        /// <summary>
        /// Date when feedback result was sent back to transcription service.
        /// </summary>
        public DateTime? FeedbackSent { get; set; }

        /// <summary>
        /// A code identifying the status of this transcription validation request item.
        ///
        /// Recognized Transcription Validation Request status codes are:
        /// * `New` - Represents a transcription validation request item that is considered new and needs work to complete
        /// * `In Progress` - Represents a transcription validation request item that is currently being worked on
        /// * `Failed` - Represents a transcription validation request item that could not complete the validation process
        /// * `Complete` - Represents a transcription validation request item that is considered complete and does not need any further work
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// The date on which this transcription validation request item was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID number of the user who created this transcription validation request item.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this transcription validation request item was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID number of the user who most recently modified this transcription validation request item.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
