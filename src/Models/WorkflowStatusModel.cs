/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// A Workflow Status represents the state for a specific workflow for an entity.
    /// </summary>
    public class WorkflowStatusModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS Platform when this record is
        /// added to the Accounting Data Services platform.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of the workflow status.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The description explaining the use of the workflow status.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The prior workflow status ID.
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public Guid? ParentWorkflowStatusId { get; set; }

        /// <summary>
        /// The category of the workflow status.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The code of the workflow status.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether notes are required or not.
        /// </summary>
        public bool? IsNotesRequired { get; set; }

        /// <summary>
        /// Indicates whether a reason is required or not.
        /// </summary>
        public bool? IsReasonRequired { get; set; }

        /// <summary>
        /// Indicates whether the status change should be reported to the ERP or not.
        /// </summary>
        public bool? PromoteToErp { get; set; }

        /// <summary>
        /// Possible sources for a Workflow Status.
        /// </summary>
        public int? StatusSource { get; set; }

        /// <summary>
        /// The date that the workflow status was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the workflow status.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date that the workflow status was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the workflow status.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The parent workflow statuses for the workflow status.
        ///
        /// To retrieve this collection, specify `Parents` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public WorkflowStatusModel[] Parents { get; set; }

        /// <summary>
        /// The children workflow statuses for the workflow status.
        ///
        /// To retrieve this collection, specify `Children` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public WorkflowStatusModel[] Children { get; set; }
    }
}
