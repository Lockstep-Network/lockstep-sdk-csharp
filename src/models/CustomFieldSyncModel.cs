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
    /// The CustomFieldSyncModel represents information coming into Lockstep from an external financial system or other
    /// enterprise resource planning system.  [Custom Fields](https://developer.lockstep.io/docs/custom-fields#custom-fields)
    /// represent custom data extensions that you can use with the Lockstep Platform.  If you need to store extra
    /// information about an object that does not match Lockstep&#39;s official schema, you can store it in the Custom
    /// Field system using CustomFieldSyncModel.
    ///
    /// To store a custom field for an object, create a CustomFieldSyncModel record containing the `TableKey` and
    /// `ErpKey` of the entity to which you will attach a custom field. Next specify the field&#39;s `CustomFieldLabel`
    /// and either a `StringValue` or `NumericValue`.
    ///
    /// Once imported, this record will be available in the Lockstep API as a [CustomFieldValueModel](https://developer.lockstep.io/docs/customfieldvaluemodel).
    ///
    /// For more information on writing your own connector, see [Connector Data](https://developer.lockstep.io/docs/connector-data).
    /// </summary>
    public class CustomFieldSyncModel
    {

        /// <summary>
        /// Indicates what action to take when an existing object has been found during the sync process.
        /// </summary>
        public int? OnMatchAction { get; set; }

        /// <summary>
        /// This is the primary key of the record to which you will attach this custom field. You should provide the
        /// identifying number as it is stored in the originating financial system. Search for a unique, non-changing
        /// number within the originating financial system for this record.
        ///
        /// Custom Fields are identified by the `TableKey` and `ErpKey` values together.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named &quot;ApprovalStatusCode&quot;.  For the `ErpKey` field, specify the value `100047878`.
        ///
        /// For more information, see [Identity Columns](https://developer.lockstep.io/docs/identity-columns).
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// Custom Fields are identified by the `TableKey` and `ErpKey` values together.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named &quot;ApprovalStatusCode&quot;.  For the `TableKey` field, specify the value `Invoice`.
        ///
        /// Recognized types include:
        /// * `Company` - Link this custom field to a CompanySyncModel
        /// * `Contact` - Link this custom field to a ContactSyncModel
        /// * `Invoice` - Link this custom field to an InvoiceSyncModel
        /// * `InvoiceLine` - Link this custom field to an InvoiceLineSyncModel
        /// * `Payment` - Link this custom field to a PaymentSyncModel
        /// </summary>
        public string TableKey { get; set; }

        /// <summary>
        /// A label that uniquely identifies this custom field within your software.
        ///
        /// Example: You have an invoice whose ID number is 100047878, and you wish to store a custom field on that
        /// invoice named &quot;ApprovalStatusCode&quot;.  For the `CustomFieldLabel` field, specify the value `ApprovalStatusCode`.
        /// </summary>
        public string CustomFieldLabel { get; set; }

        /// <summary>
        /// The value of this custom field.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// If known, the date when this record was created according to the originating financial system
        /// in which this record is maintained.  If the originating financial system does not maintain a
        /// created-date, leave this field null.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// If known, the date when this record was most recently modified according to the originating
        /// financial system in which this record is maintained.  If the originating financial system does
        /// not maintain a most-recently-modified-date, leave this field null.
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
