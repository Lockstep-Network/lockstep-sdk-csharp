namespace LockstepSDK;

public class LockstepResponse<T>
{
    public bool Success { get; set; }
    public T Value { get; set; }
    public ErrorResult Error { get; set; }
}