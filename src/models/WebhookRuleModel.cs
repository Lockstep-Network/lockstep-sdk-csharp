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
    /// A Webhook Rule is a subscription to receive notifications automatically for
    ///
    /// Currently supported objects:
    ///  * `SyncRequest` - Receive a notification when a new sync request has completed for the group key.
    /// </summary>
    public class WebhookRuleModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? WebhookRuleId { get; set; }

        /// <summary>
        /// The unique Webhook ID that will be used to fire the webhook for this rule.
        /// </summary>
        public Guid? WebhookId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// A Webhook rule is setup to be fired based on `TableKey` and `EventType`.
        /// For example, a Webhook setup for when an Invoice is Created would have a `TableKey` value of
        /// `Invoice` and an `EventType` value of `I` (Insert).
        ///
        /// The `TableKey` value contains the name of the table within the Lockstep Platform to which this metadata
        /// is connected.
        ///
        /// For more information, see [linking metadata to an object](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public string TableKey { get; set; }

        /// <summary>
        /// A Webhook rule is setup to be fired based on `TableKey` and `EventType`.
        /// For example, a Webhook setup for when an Invoice is Created would have a `TableKey` value of
        /// `Invoice` and an `EventType` value of `I` (Insert).
        ///
        /// The `EventType` value is one of the following:
        /// - I (Insert)
        /// - D (Delete)
        /// - U (Update)
        ///
        /// For more information, see [linking metadata to an object](https://developer.lockstep.io/docs/custom-fields#linking-metadata-to-an-object).
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// The expiration date for the given webhook subscription. Once the expiration date passes,
        /// notifications will no longer be sent to the callback url.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The filter for this webhook rule (if necessary) . See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)
        /// </summary>
        public string Filter { get; set; }

        /// <summary>
        /// The format of the content to be returned in the webhook notifications. Current options are &#39;Full&#39; or &#39;Id&#39;.
        /// </summary>
        public string RequestContentType { get; set; }

        /// <summary>
        /// The date this webhook rule was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this webhook rule
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date this webhook rule was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this webhook rule
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
