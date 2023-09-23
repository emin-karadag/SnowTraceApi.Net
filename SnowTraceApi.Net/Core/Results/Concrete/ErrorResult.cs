namespace SnowTraceApi.Net.Core.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message, 0)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
