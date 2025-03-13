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
    /// App enrollment and custom field merged into one
    /// </summary>
    public class AppEnrollmentCustomFieldModel
    {

        /// <summary>
        /// Unique id for the app enrollment
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// Id of enrolled app
        /// </summary>
        public Guid? AppId { get; set; }

        /// <summary>
        /// The name of the application
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tag for what type of app the application is
        /// </summary>
        public string AppType { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single ADS Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// Unique Id for the custom field definition
        /// </summary>
        public Guid? CustomFieldDefinitionId { get; set; }

        /// <summary>
        /// Text to display in-application for custom field
        /// </summary>
        public string CustomFieldLabel { get; set; }

        /// <summary>
        /// Data type of the custom field definition
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Used for display logic when multiple app enrollment custom fields exist
        /// </summary>
        public int? SortOrder { get; set; }

        /// <summary>
        /// String of data for field
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public string StringValue { get; set; }

        /// <summary>
        /// Number data for field
        /// </summary>
        [Obsolete("This field is deprecated.")]
        public decimal? NumericValue { get; set; }

        /// <summary>
        /// Value for the field
        /// </summary>
        public string Value { get; set; }
    }
}
