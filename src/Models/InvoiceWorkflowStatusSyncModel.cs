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
    /// The InvoiceWorkflowStatusSyncModel represents information coming into ADS from an external financial system or other
    /// enterprise resource planning system.  To import data from an external system, convert your original data into
    /// the InvoiceWorkflowStatusSyncModel format and call the [Upload Sync File API](https://developer.lockstep.io/reference/post_api-v1-sync-zip).
    /// This API retrieves all of the data you uploaded in a compressed ZIP file and imports it into the ADS
    /// Platform.
    ///
    /// Once imported, this record will be available in the ADS Platform API as an [InvoiceWorkflowStatusHistoryModel](https://developer.lockstep.io/docs/invoiceworkflowstatushistorymodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class InvoiceWorkflowStatusSyncModel
    {

        /// <summary>
        /// This is the primary key of the Invoice record. For this field, you should use whatever the invoice&#39;s unique
        /// identifying number is in the originating system. Search for a unique, non-changing number within the
        /// originating financial system for this record.
        ///
        /// Example: If you store your invoice records in a database, whatever the primary key for the invoice table is
        /// in the database should be the &quot;ErpKey&quot;.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string InvoiceErpKey { get; set; }

        /// <summary>
        /// Workflow status of the invoice.
        /// </summary>
        public Guid? WorkflowStatusId { get; set; }

        /// <summary>
        /// Notes associated to workflow status
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Workflow status code dictated by government standards
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The date when the workflow status was updated for the e-invoice
        /// </summary>
        public DateTime? Created { get; set; }
    }
}
