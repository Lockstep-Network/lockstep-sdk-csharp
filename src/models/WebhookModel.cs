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
    /// A Webhook is a subscription to receive notifications automatically to the supplied
    /// callback url when changes are made to a supported object.
    ///
    /// Currently supported objects:
    ///  * `SyncRequest` - Receive a notification when a new sync request has completed for the group key.
    /// </summary>
    public class WebhookModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
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
        /// A name for the webhook subscription.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The status of the webhook (Active, Inactive, Errored).
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// When the StatusCode is set to Errored a message is supplied for why it was errored.
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// An secret set during webhook creation that can be used to verify that the notification
        /// is coming from the Lockstep API.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// The format of the content to be returned in the webhook notifications. Options TBD.
        /// </summary>
        public string RequestContentType { get; set; }

        /// <summary>
        /// The HTTP Method to be used on the callback URL for use in notifications (GET, POST, PATCH, PUT).
        /// </summary>
        public string CallbackHttpMethod { get; set; }

        /// <summary>
        /// The URL where the notification will be sent via the method set in CallbackHttpMethod.
        ///
        /// When creating a webhook, the Lockstep API will make a call to this url via the method
        /// set in the CallbackHttpMethod property with a query parameter of &quot;code&quot; set to an encoded
        /// string. To successfully create the webhook, the call must return a successful status code
        /// with the query parameter&#39;s value as the plain text content.
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The expiration date for the given webhook subscription. Once the expiration date passes,
        /// notifications will no longer be sent to the callback url.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The amount of times a notification should be retried before marking the webhook as errored.
        /// </summary>
        public int? RetryCount { get; set; }

        /// <summary>
        /// The date this webhook was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created this webhook
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date this webhook was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified this webhook
        /// </summary>
        public Guid? ModifiedUserId { get; set; }

        /// <summary>
        /// The partition key used for the webhook callback history
        /// </summary>
        public string PartitionKey { get; set; }
    }
}
