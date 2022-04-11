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
    /// Represents unsupported ERP systems
    /// </summary>
    public class ErpModel
    {

        /// <summary>
        /// Unique ID for this ERP
        /// </summary>
        public Guid? ErpSystemId { get; set; }

        /// <summary>
        /// Name of ERP
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flag to indicate if ERP is supported
        /// </summary>
        public bool? IsSupported { get; set; }
    }
}
