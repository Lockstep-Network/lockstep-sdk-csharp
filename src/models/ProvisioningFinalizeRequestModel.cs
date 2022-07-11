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
    /// Represents the data to finalize onboarding for a user
    /// </summary>
    public class ProvisioningFinalizeRequestModel
    {

        /// <summary>
        /// The full name of the user
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The time zone of the user
        /// </summary>
        public string TimeZone { get; set; }

        /// <summary>
        /// The default currency of the user
        /// </summary>
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// The company information for the user and group
        /// </summary>
        public CompanyModel Company { get; set; }

        /// <summary>
        /// Optional connector information needed to enroll user to their email connector
        /// </summary>
        public ErpInfoModel EmailConnector { get; set; }
    }
}
