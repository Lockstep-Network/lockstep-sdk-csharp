namespace LockstepSDK;

public class ErrorResult
{
    public string type { get; internal set; }
    public string title { get; internal set; }
    public int  status { get; internal set; }
    public string detail { get; internal set; }
    public string instance { get; internal set; }
}

public class TestTimeoutException : ErrorResult {}
