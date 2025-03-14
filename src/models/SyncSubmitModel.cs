/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2025 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2025 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace LockstepSDK.Models
{

    /// <summary>
    /// A SyncSubmitModel represents a task that loads data from a connector to load into the ADS Platform.  Data
    /// contained in a sync will be merged with your existing data.  Each record will be matched with existing data
    /// inside the ADS Platform using the [Identity Column](https://developer.lockstep.io/docs/identity-columns)
    /// rules.  Any record that represents a new AppEnrollmentId+ErpKey will be inserted.  A record that matches an
    /// existing AppEnrollmentId+ErpKey will be updated, but only if the data has changed.
    ///
    /// A Sync process permits either a complete data file or a partial / delta data file.  ADS Platform recommends
    /// using a sliding time window to avoid the risk of clock skew errors that might accidentally omit records.
    /// Best practice is to run a Sync process daily, and to export all data that has changed in the past 48 hours.
    /// </summary>
    public class SyncSubmitModel
    {

        /// <summary>
        /// The unique identifier of the app enrollment that is creating this sync request.
        /// </summary>
        public Guid? AppEnrollmentId { get; set; }

        /// <summary>
        /// A boolean indicating whether a sync from an ERP system should process all the data from the ERP
        /// as opposed to just the delta of changes since the previous sync run. For the Demo Data Connector, setting this
        /// to True refreshes the data with new dates as opposed to leaving it unchanged.
        /// </summary>
        public bool? RunFullSync { get; set; }
    }
}
