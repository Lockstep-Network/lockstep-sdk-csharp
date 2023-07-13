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
    /// Lockstep.Shared.Models.Sync.ErpWriteSyncSubmitModel`1 represents a request to write back a collection
    ///             of requests to the connected AppEnrollment.
    /// </summary>
    public class InsertPaymentRequestModelErpWriteSyncSubmitModel
    {

        /// <summary>
        /// The connected App Enrollment id.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// An array of requests to write back.
        /// </summary>
        public InsertPaymentRequestModel[] Requests { get; set; }
    }
}
