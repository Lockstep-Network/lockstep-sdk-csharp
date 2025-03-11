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
    /// Country model for ISO-3166
    /// </summary>
    public class CountryModel
    {

        /// <summary>
        /// Name of the country
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 2 letter alphabetic code for the given country
        /// </summary>
        public string Alpha2 { get; set; }

        /// <summary>
        /// 3 letter alphabetic code for the given country
        /// </summary>
        public string Alpha3 { get; set; }

        /// <summary>
        /// Unique 3 digit number for the given country
        /// </summary>
        public int? CountryCode { get; set; }

        /// <summary>
        /// Region of the country
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Subregion of the country
        /// </summary>
        public string SubRegion { get; set; }

        /// <summary>
        /// Intermediate region of the country
        /// </summary>
        public string IntermediateRegion { get; set; }

        /// <summary>
        /// Numeric code for a region
        /// </summary>
        public int? RegionCode { get; set; }

        /// <summary>
        /// Numeric code for a subregion
        /// </summary>
        public int? SubRegionCode { get; set; }

        /// <summary>
        /// Numeric code for an intermediate region
        /// </summary>
        public int? IntermediateRegionCode { get; set; }

        /// <summary>
        /// French name of the country
        /// </summary>
        public string FrenchName { get; set; }

        /// <summary>
        /// A different name for a country
        /// </summary>
        public string Aliases { get; set; }
    }
}
