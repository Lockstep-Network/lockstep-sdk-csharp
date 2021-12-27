namespace LockstepSDK;

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