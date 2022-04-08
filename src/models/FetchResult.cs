/***
 * Lockstep Software Development Kit for C#
 *
 * (c) 2021-2022 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Ted Spence <tspence@lockstep.io>
 * @copyright  2021-2021 Lockstep, Inc.
 * @version    2021.39
 * @link       https://github.com/tspence/lockstep-sdk-csharp
 */

namespace LockstepSDK
{

    /// <summary>
    /// Represents a response to a Query API call
    /// </summary>
    /// <typeparam name="T">The type of records returned by this query</typeparam>
    public class FetchResult<T>
    {
        /// <summary>
        /// The total number of rows matching the filter.  If unknown, returns null.
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        /// If the original request was submitted using Page Size-based pagination, contains the page size for this query.  Null otherwise.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// If the original request was submitted using Page Size-based pagination, contains the page number of this current result.  Null otherwise.
        ///
        /// To get the next page of results, make a new request with the same pageSize but add one to the pageNumber.
        /// </summary>
        public int? PageNumber { get; set; }

        /// <summary>
        /// The paginated and filtered list of records matching the parameters you supplied.
        /// </summary>
        public T[] Records { get; set; }
    }
}