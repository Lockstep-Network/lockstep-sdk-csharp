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
    /// Aggregated Attachment status information.
    /// </summary>
    public class AttachmentHeaderInfoModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The CompanyId associated with the attachment status report. Providing a null value will
        /// return an attachment summary for all attachments associated to the provided GroupKey
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The total number of attachments associated with the provided GroupKey and CompanyId.
        /// </summary>
        public int? TotalAttachments { get; set; }

        /// <summary>
        /// The total number of archived attachments associated with the provided GroupKey and CompanyId.
        /// </summary>
        public int? TotalArchived { get; set; }

        /// <summary>
        /// The total number of active attachments associated with the provided GroupKey and CompanyId.
        /// </summary>
        public int? TotalActive { get; set; }
    }
}
