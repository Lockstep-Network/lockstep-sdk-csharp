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
    /// Model containing information to create a new developer account.
    /// </summary>
    public class DeveloperAccountSubmitModel
    {

        /// <summary>
        /// The first name of the person requesting the developer account.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person requesting the developer account.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The email address of the developer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The company name of the developer.
        /// </summary>
        public string CompanyName { get; set; }
    }
}
