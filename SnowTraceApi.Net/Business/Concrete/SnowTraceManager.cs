using SnowTraceApi.Net.Business.Abstract;
using SnowTraceApi.Net.Business.Abstract.Accounts;
using SnowTraceApi.Net.Business.Concrete.Accounts;

namespace SnowTraceApi.Net.Business.Concrete
{
    public class SnowTraceManager : ISnowTraceService
    {
        public SnowTraceManager()
        {
            AccountsApi = new AccountsManager();
        }

        public IAccountsService AccountsApi { get; set; }
    }
}
