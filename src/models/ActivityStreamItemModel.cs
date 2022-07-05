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

namespace LockstepSDK.Models
{

    /// <summary>
    /// Represents an item belonging to the activity stream.
    /// </summary>
    public class ActivityStreamItemModel
    {

        /// <summary>
        /// The object key of the activity stream item.
        /// </summary>
        public Guid? ObjectKey { get; set; }

        /// <summary>
        /// The type code of the activity stream item.
        /// </summary>
        public string ActivityStreamType { get; set; }

        /// <summary>
        /// The text body description for this Activity Stream Item.
        /// </summary>
        public string TextValue { get; set; }

        /// <summary>
        /// The date on which this activity stream item was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this activity.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The sender&#39;s email address if activity stream item is an Email.
        /// </summary>
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// The recipient&#39;s email address if activity stream item is an Email.
        /// </summary>
        public string ToEmailAddress { get; set; }

        /// <summary>
        /// The name of the contact sending the activity otherwise null.
        /// </summary>
        public string FromContactName { get; set; }

        /// <summary>
        /// The name of the contact sending the activity otherwise null.
        /// </summary>
        public string ToContactName { get; set; }
    }
}
