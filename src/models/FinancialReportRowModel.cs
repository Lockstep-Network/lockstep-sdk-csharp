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
    /// Represents a row of a financial Report report
    /// </summary>
    public class FinancialReportRowModel
    {

        /// <summary>
        /// Describes what type of row this row is (Header, Summary, Classification, Category, Subcategory, Data)
        /// </summary>
        public string RowType { get; set; }

        /// <summary>
        /// The label for the row if it is a Classification, Category, or Subcategory.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The sub rows of this row if it is a Classification, Category, or Subcategory.
        /// </summary>
        public FinancialReportRowModel[] Rows { get; set; }

        /// <summary>
        /// The cells of the row
        /// </summary>
        public FinancialReportCellModel[] Cells { get; set; }
    }
}
