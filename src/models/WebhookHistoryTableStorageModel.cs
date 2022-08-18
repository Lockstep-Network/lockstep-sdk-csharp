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
    /// Represents the Webhook Trigger History
    /// </summary>
    public class WebhookHistoryTableStorageModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The WebhookId uniquely identifies the webhook used to send notification that an event action has taken place.
        /// </summary>
        public Guid? WebhookId { get; set; }

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? WebhookHistoryId { get; set; }

        /// <summary>
        /// Event type which fired webhook
        ///
        /// [entity].[action]
        /// </summary>
        public string EventType { get; set; }

        /// <summary>
        /// Flag whether request was sent to callback url successfully or blocked by failing or because it was disabled.
        /// </summary>
        public bool? RequestSent { get; set; }

        /// <summary>
        /// Flag whether webhook notification was successful overall (if webhook disabled should always return true otherwise
        /// depends on the response from the callback url)
        /// </summary>
        public bool? IsSuccessful { get; set; }

        /// <summary>
        /// Response status code that is returned when calling a callback url.
        /// </summary>
        public string ResponseStatusCode { get; set; }

        /// <summary>
        /// Message containing information about the webhook callback results
        /// </summary>
        public string ProcessResultMessage { get; set; }

        /// <summary>
        /// Number of times message failed to be sent over to callback url before succeeding or failing out.
        /// The maximum value should is based on webhook.
        /// </summary>
        public int? FailureCount { get; set; }

        /// <summary>
        /// Timestamp of when a request is sent to a webhook callback.
        /// Contains the last time message is sent if failures occur.
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The records sent with the webhook.
        /// </summary>
        public string Records { get; set; }

        /// <summary>
        /// The request message sent with the webhook.
        /// </summary>
        public string RequestMessage { get; set; }

        /// <summary>
        /// The response received back from the webhook.
        /// </summary>
        public string ResponseMessage { get; set; }
    }
}
