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
    /// A model representing a company identifier.
    /// </summary>
    public class CompanyIdentifierModel
    {

        /// <summary>
        /// The type of identifier.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The value of the identifier.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// The jurisdiction of the identifier.
        /// </summary>
        public string Jurisdiction { get; set; }

        /// <summary>
        /// The sub-jurisdiction of the identifier, ISO3166-1 or ISO3166-2 code.
        /// </summary>
        public string Subjurisdiction { get; set; }
    }
}
