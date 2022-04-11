/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2022 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK
{

    /// <summary>
    /// An Activity contains information about work being done on a specific accounting task.
    /// You can use Activities to track information about who has been assigned a specific task,
    /// the current status of the task, the name and description given for the particular task,
    /// the priority of the task, and any amounts collected, paid, or credited for the task.
    /// </summary>
    public class ActivityModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? ActivityId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The ID of the company to which this activity belongs.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The type code of the activity
        /// </summary>
        public string ActivityTypeCode { get; set; }

        /// <summary>
        /// The name of the activity.  The name is a short name provided by the
        /// person who created the activity that can be displayed in a list.
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// A description of the activity.  This field contains more detailed text about the
        /// activity and can be lengthy.
        /// </summary>
        public string ActivityDescription { get; set; }

        /// <summary>
        /// The status of the activity.
        /// </summary>
        public string ActivityStatus { get; set; }

        /// <summary>
        /// True if this activity is currently &quot;open&quot;, which indicates that the activity is
        /// currently in progress.
        /// </summary>
        public bool? IsOpen { get; set; }

        /// <summary>
        /// The priority of the activity.
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// The ID of the user the activity is assigned to.
        /// </summary>
        public Guid? UserAssignedTo { get; set; }

        /// <summary>
        /// The date the activity was assigned.
        /// </summary>
        public DateTime? DateAssigned { get; set; }

        /// <summary>
        /// The date the activity was closed.
        /// </summary>
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// If this activity has been &quot;snoozed&quot;, this field will be non-null and will contain
        /// the date when the activity will be displayed.  Until that date arrives, the activity
        /// will remain hidden.
        /// </summary>
        public DateTime? SnoozeUntilDate { get; set; }

        /// <summary>
        /// The date on which this activity was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this activity.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date on which this activity was last modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this activity.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// Amount collected (if any) for the activity.
        /// </summary>
        public decimal? AmountCollected { get; set; }

        /// <summary>
        /// Amount paid (if any) for the activity.
        /// </summary>
        public decimal? AmountPaid { get; set; }

        /// <summary>
        /// Credit given (if any) for the activity.
        /// </summary>
        public decimal? CreditGiven { get; set; }

        /// <summary>
        /// True if this activity is to be shown in an &quot;unread&quot; state.  When an activity
        /// is read by a person it is assigned to, this flag is set to false.
        /// </summary>
        public bool? IsUnread { get; set; }

        /// <summary>
        /// Activities may be archived when they should be hidden from the user.  When
        /// this flag is true, this activity should be hidden.
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// The company associated with the activity
        ///
        /// To retrieve this collection, specify `Company` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public CompanyModel Company { get; set; }

        /// <summary>
        /// The name of the user the activity is assigned to
        /// </summary>
        public string UserAssignedToName { get; set; }

        /// <summary>
        /// A collection of attachments linked to this record.  To retrieve this collection, specify `Attachments` in
        /// the `include` parameter when retrieving data.
        ///
        /// To create an attachment, use the [Upload Attachment](https://developer.lockstep.io/reference/post_api-v1-attachments)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public AttachmentModel[] Attachments { get; set; }

        /// <summary>
        /// A collection of notes linked to this record.  To retrieve this collection, specify `Notes` in the
        /// `include` parameter when retrieving data.
        ///
        /// To create a note, use the [Create Note](https://developer.lockstep.io/reference/post_api-v1-notes)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public NoteModel[] Notes { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldDefinitions` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldDefinitionModel[] CustomFieldDefinitions { get; set; }

        /// <summary>
        /// A collection of custom fields linked to this record.  To retrieve this collection, specify
        /// `CustomFieldValues` in the `include` parameter when retrieving data.
        ///
        /// To create a custom field, use the [Create Custom Field](https://developer.lockstep.io/reference/post_api-v1-customfieldvalues)
        /// endpoint with the `TableKey` to `Activity` and the `ObjectKey` set to the `ActivityId` for this record.  For
        /// more information on extensibility, see [linking extensible metadata to objects](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public CustomFieldValueModel[] CustomFieldValues { get; set; }

        /// <summary>
        /// All references attached to this applied activity.
        ///
        /// To retrieve this collection, specify `References` in the &quot;Include&quot; parameter for your query.
        /// </summary>
        public ActivityXRefModel[] References { get; set; }
    }
}
