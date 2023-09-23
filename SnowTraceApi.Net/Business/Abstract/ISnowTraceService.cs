using SnowTraceApi.Net.Business.Abstract.Accounts;

namespace SnowTraceApi.Net.Business.Abstract
{
    public interface ISnowTraceService
    {
        public IAccountsService AccountsApi { get; set; }
    }
}
