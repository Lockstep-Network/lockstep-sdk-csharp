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
    /// Represents leads for creating new ERP connectors
    /// </summary>
    public class LeadModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? LeadId { get; set; }

        /// <summary>
        /// Name of lead
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Name of company of lead
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Email of lead
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Requested ERP of lead
        /// </summary>
        public string ErpSystem { get; set; }
    }
}
