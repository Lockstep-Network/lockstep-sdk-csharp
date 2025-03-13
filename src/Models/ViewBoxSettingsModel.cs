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
    /// Optional meta data for image view box settings.
    /// </summary>
    public class ViewBoxSettingsModel
    {

        /// <summary>
        /// ViewBox minX setting for this Company&#39;s logo.
        /// </summary>
        public decimal? LogoViewBoxMinX { get; set; }

        /// <summary>
        /// ViewBox minY setting for this Company&#39;s logo.
        /// </summary>
        public decimal? LogoViewBoxMinY { get; set; }

        /// <summary>
        /// ViewBox width setting for this Company&#39;s logo.
        /// </summary>
        public decimal? LogoViewBoxWidth { get; set; }

        /// <summary>
        /// ViewBox height setting for this Company&#39;s logo.
        /// </summary>
        public decimal? LogoViewBoxHeight { get; set; }
    }
}
