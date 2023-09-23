using SnowTraceApi.Net.Core.Results.Abstract;

namespace SnowTraceApi.Net.Core.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message, long code) : this(success)
        {
            Message = message;
            Code = code;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
        public long Code { get; }
    }
}
