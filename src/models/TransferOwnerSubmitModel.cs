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
    /// Model used to submit a transfer ownership request
    /// </summary>
    public class TransferOwnerSubmitModel
    {

        /// <summary>
        /// The ID of the user to transfer ownership to.
        /// </summary>
        public Guid? TargetUserId { get; set; }
    }
}
