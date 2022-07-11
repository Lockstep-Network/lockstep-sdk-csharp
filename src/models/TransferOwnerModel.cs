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
    /// Model from the transfer ownership process.
    /// </summary>
    public class TransferOwnerModel
    {

        /// <summary>
        /// The previous owner of the account.
        /// </summary>
        public UserAccountModel PreviousOwner { get; set; }

        /// <summary>
        /// The new owner of the account.
        /// </summary>
        public UserAccountModel NewOwner { get; set; }
    }
}
