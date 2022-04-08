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
    /// Input format used for bulk conversion route
    /// </summary>
    public class BulkCurrencyConversionModel
    {

        /// <summary>
        /// The date for the currency rate
        ///
        /// This is a date-only field stored as a string in ISO 8601 (YYYY-MM-DD) format.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The currency code This will be validated by the /api/v1/definitions/currencies data set
        /// </summary>
        public string SourceCurrency { get; set; }
    }
}
