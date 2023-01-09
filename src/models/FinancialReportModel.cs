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
    /// Represents a Financial Report
    /// </summary>
    public class FinancialReportModel
    {

        /// <summary>
        /// The name of the report (&quot;*Report Type* for *Company*&quot;)
        /// </summary>
        public string ReportName { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The start date of the financial report
        /// </summary>
        public DateTime? ReportStartDate { get; set; }

        /// <summary>
        /// The end date of the financial report
        /// </summary>
        public DateTime? ReportEndDate { get; set; }

        /// <summary>
        /// The created date of the financial report
        /// </summary>
        public DateTime? ReportCreatedDate { get; set; }

        /// <summary>
        /// The rows of the financial report
        /// </summary>
        public FinancialReportRowModel[] Rows { get; set; }
    }
}
