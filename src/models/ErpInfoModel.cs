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
    /// Represents the ERP object sent in a provisioning request
    /// </summary>
    public class ErpInfoModel
    {

        /// <summary>
        /// The id of the ERP&#39;s App
        /// </summary>
        public Guid? AppId { get; set; }

        /// <summary>
        /// The data required to store for connector access
        /// </summary>
        public ConnectorInfoModel Data { get; set; }
    }
}
