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
    /// Contains Public Company Profile data.
    /// </summary>
    public class PublicCompanyProfileModel
    {

        /// <summary>
        /// The unique ID of the company associated with this profile.
        /// </summary>
        public Guid? CompanyId { get; set; }

        /// <summary>
        /// The short name of the company associated with this profile.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// The URL of this company&#39;s logo, if known.
        /// </summary>
        public string CompanyLogoUrl { get; set; }

        /// <summary>
        /// Website URL for the company associated with this profile.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// Description of the company associated with this profile.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The public url slug for this Public Company Profile.
        /// </summary>
        public string PublicUrlSlug { get; set; }
    }
}
