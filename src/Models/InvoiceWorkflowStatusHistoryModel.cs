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
    /// A Invoice Workflow Status History represents prior workflow statuses of an E-Invoice.
    /// </summary>
    public class InvoiceWorkflowStatusHistoryModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by ADS Platform when this record is
        /// added to the Accounting Data Services platform.
        /// </summary>
        public Guid? InvoiceWorkflowStatusHistoryId { get; set; }

        /// <summary>
        /// The invoice ID associated with the invoice workflow status history.
        /// </summary>
        public Guid? InvoiceId { get; set; }

        /// <summary>
        /// The workflow status ID associated with the invoice workflow status history.
        /// </summary>
        public Guid? WorkflowStatusId { get; set; }

        /// <summary>
        /// The workflow status name associated with the invoice workflow status history.
        /// </summary>
        public string WorkflowStatusName { get; set; }

        /// <summary>
        /// The workflow transition ID associated with the invoice workflow status history.
        /// </summary>
        public Guid? WorkflowTransitionId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Accounting Data Services Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The notes for the invoice workflow status history.
        /// </summary>
        public string WorkflowStatusNotes { get; set; }

        /// <summary>
        /// The reason code for the invoice workflow status history.
        ///
        /// Specific reason codes are defined by the workflow status.
        /// </summary>
        public string WorkflowStatusReasonCode { get; set; }

        /// <summary>
        /// The date that the invoice workflow status history was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the invoice workflow status history.
        /// </summary>
        public Guid? CreatedUserId { get; set; }
    }
}
