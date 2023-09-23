using SnowTraceApi.Net.Core.Results.Abstract;

namespace SnowTraceApi.Net.Core.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message, long code) : base(success, message, code)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
