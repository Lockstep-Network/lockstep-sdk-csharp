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
    /// Represents a Code Definition.  Codes can be used as shortened, human readable strings.
    /// Additionally, this table can be used to store lists of system values for Lockstep objects.
    /// </summary>
    public class CodeDefinitionModel
    {

        /// <summary>
        /// The unique ID of this record, automatically assigned by Lockstep when this record is
        /// added to the Lockstep platform.
        /// </summary>
        public Guid? CodeDefinitionId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// The type of the Code Definition
        /// </summary>
        public string CodeType { get; set; }

        /// <summary>
        /// The Code to be defined.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The definition of the Code
        /// </summary>
        public string CodeDescription { get; set; }

        /// <summary>
        /// The date that the Code Definition was created
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The ID of the user who created the Code Definition
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the Code Definition was last modified
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ID of the user who last modified the Code Definition
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
