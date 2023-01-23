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
    /// A request to transcribe the provided file content to a Lockstep Platform object.
    /// </summary>
    public class TranscriptionRequestSubmit
    {

        /// <summary>
        /// The base64 string of document content
        /// </summary>
        public string FileContent { get; set; }

        /// <summary>
        /// The location of the file provided
        /// </summary>
        public string FileContentUrl { get; set; }

        /// <summary>
        /// The name of the file provided
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The type of LockstepApi2.Models.TranscriptionRequestSubmit.InvoiceTypeCode requested to transcribe content to.
        /// </summary>
        public string InvoiceTypeCode { get; set; }

        /// <summary>
        /// Group account transcription validation request item is associated with.
        /// </summary>
        public Guid? TranscriptionValidationRequestId { get; set; }
    }
}
