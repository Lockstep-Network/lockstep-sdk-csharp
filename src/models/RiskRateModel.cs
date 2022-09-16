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
    /// Represents a risk rate calculation for a single month
    /// </summary>
    public class RiskRateModel
    {

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The month the risk rate was calculated for
        /// </summary>
        public DateTime? ReportDate { get; set; }

        /// <summary>
        /// The string name of the month the risk rate was calculated for
        /// </summary>
        public string InvoiceMonthName { get; set; }

        /// <summary>
        /// The count of all invoices in the calculation month
        /// </summary>
        public int? TotalInvoiceCount { get; set; }

        /// <summary>
        /// The sum of the total amount for invoices in the calculation month
        /// </summary>
        public decimal? TotalInvoiceAmount { get; set; }

        /// <summary>
        /// The count of open invoices over 90 days from the calculation month
        /// </summary>
        public int? AtRiskCount { get; set; }

        /// <summary>
        /// The sum of the outstanding balance of open invoices over 90 days from the calculation month
        /// </summary>
        public decimal? AtRiskAmount { get; set; }

        /// <summary>
        /// The percentage of all open invoices for the calculation month that are over 90 days based on count
        /// </summary>
        public decimal? AtRiskCountPercentage { get; set; }

        /// <summary>
        /// The percentage of all open invoices for the calculation month that are over 90 days based on outstanding balance
        /// </summary>
        public decimal? AtRiskPercentage { get; set; }
    }
}
