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
    /// Contains group level payment data.
    /// </summary>
    public class PaymentDetailHeaderModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The total number of Customers.
        /// </summary>
        public int? CustomerCount { get; set; }

        /// <summary>
        /// The total amount collected.
        /// </summary>
        public decimal? AmountCollected { get; set; }

        /// <summary>
        /// The total unapplied amount.
        /// </summary>
        public decimal? UnappliedAmount { get; set; }

        /// <summary>
        /// The number of paid invoices.
        /// </summary>
        public int? PaidInvoiceCount { get; set; }

        /// <summary>
        /// The number of open invoices.
        /// </summary>
        public int? OpenInvoiceCount { get; set; }
    }
}
