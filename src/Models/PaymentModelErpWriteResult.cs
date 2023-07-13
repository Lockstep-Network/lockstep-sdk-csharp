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
    /// Contains results of a write back request
    /// </summary>
    public class PaymentModelErpWriteResult
    {

        /// <summary>
        /// The id of the connected AppEnrollmentModel
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The ErpKey for the object written to the Erp if created
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// An optional message to return with the result
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The id of the SyncRequestModel the requests were added to
        /// </summary>
        public Guid? SyncRequestId { get; set; }

        /// <summary>
        /// Results from the ERP write operation
        /// </summary>
        public PaymentModel[] Results { get; set; }
    }
}
