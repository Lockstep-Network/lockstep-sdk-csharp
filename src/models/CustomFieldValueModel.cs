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
    /// A Custom Field represents metadata added to an object within the ADS Platform.  ADS provides a
    /// core definition for each object.  The core definition is intended to represent a level of compatibility
    /// that provides support across most accounting systems and products.  When a user or developer requires
    /// information beyond this core definition, you can use Custom Fields to represent this information.
    ///
    /// See [Extensibility](https://developer.lockstep.io/docs/extensibility) for more information.
    /// </summary>
    public class CustomFieldValueModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Additional key if source table doesn&#39;t have a unique id
        /// </summary>
        public Guid? RecordKey { get; set; }

        /// <summary>
        /// Table to which this definition belongs
        /// </summary>
        public string TableKey { get; set; }

        /// <summary>
        /// Text to display in-application for custom field
        /// </summary>
        public string CustomFieldLabel { get; set; }

        /// <summary>
        /// Data type of this definition
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Id of user who created this value
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// Date modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Id of user who modified this value
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The AppEnrollmentId of the application that imported this attachment record.  For accounts
        /// with more than one financial system connected, this field identifies the originating
        /// financial system that produced this record.  This value is null if this record
        /// was not loaded from an external ERP or financial system.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The value of this custom field.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Definition of the value
        /// </summary>
        public CustomFieldDefinitionModel CustomFieldDefinition { get; set; }
    }
}
