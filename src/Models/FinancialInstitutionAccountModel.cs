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
    /// An Financial Institution Account represents an account used for monetary transactions. E.g. - checking, savings,  or credit card accounts.
    /// </summary>
    public class FinancialInstitutionAccountModel
    {

        /// <summary>
        /// The unique identifier for the Financial Institution Account.
        /// </summary>
        public Guid? FinancialInstitutionAccountId { get; set; }

        /// <summary>
        /// The GroupKey uniquely identifies a single Lockstep Platform account.  All records for this
        /// account will share the same GroupKey value.  GroupKey values cannot be changed once created.
        ///
        /// For more information, see [Accounts and GroupKeys](https://developer.lockstep.io/docs/accounts-and-groupkeys).
        /// </summary>
        public Guid? GroupKey { get; set; }

        /// <summary>
        /// An alternate account id for the Financial Institution Account.
        /// </summary>
        public string BankAccountId { get; set; }

        /// <summary>
        /// The External Id for the Financial Institution Account.
        /// </summary>
        public string ErpKey { get; set; }

        /// <summary>
        /// The App Enrollment Id this Financial Institution is associated with.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// The name of the Financial Institution Account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The status of the Financial Institution Account. Possible values are active,
        /// inactive, deleted or archived.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The description for the Financial Institution Account.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The classification for the Financial Institution Account. Possible values are Asset, Equity,
        /// Expense, Liability or Income.
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// The date the Financial Institution Account was created.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// The user that has created the Financial Institution Account.
        /// </summary>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// The date the Financial Institution Account was modified.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The user that has modified the Financial Institution Account.
        /// </summary>
        public Guid? ModifiedUserId { get; set; }
    }
}
