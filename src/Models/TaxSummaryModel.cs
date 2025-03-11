/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// Represents the tax information for this invoice
    /// </summary>
    public class TaxSummaryModel
    {

        /// <summary>
        /// The tax code for this invoice
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// The tax rate for this invoice
        /// </summary>
        public decimal? TaxRate { get; set; }

        /// <summary>
        /// The tax total for this invoice
        /// </summary>
        public decimal? TaxTotal { get; set; }

        /// <summary>
        /// The base currency tax total for this invoice
        /// </summary>
        public decimal? BaseCurrencyTaxTotal { get; set; }
    }
}
