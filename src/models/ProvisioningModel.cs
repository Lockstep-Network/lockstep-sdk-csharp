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
    /// Represents the data sent during the onboarding flow
    /// </summary>
    public class ProvisioningModel
    {

        /// <summary>
        /// The full name of the new user
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The information necessary to enroll the user in their ERP
        /// </summary>
        public ErpInfoModel Erp { get; set; }
    }
}
