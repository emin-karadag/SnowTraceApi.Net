using SnowTraceApi.Net.Business.Abstract.Accounts;
using SnowTraceApi.Net.Core.Results.Abstract;
using SnowTraceApi.Net.Core.Results.Concrete;
using SnowTraceApi.Net.Core.Utilities;
using SnowTraceApi.Net.Models.Accounts;

namespace SnowTraceApi.Net.Business.Concrete.Accounts
{
    public class AccountsManager : IAccountsService
    {
        public async Task<IDataResult<BalanceModel?>> GetAvaxBalanceForSingleAddressAsync(string apiKey, string address, string tag = "latest", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "balance" },
                    { "address", address },
                    { "tag", tag },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<BalanceModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<BalanceModel>(ex.Message);
            }
        }

        public async Task<IDataResult<BalancesModel?>> GetAvaxBalanceForMultipleAddressesAsync(string apiKey, List<string> addresses, string tag = "latest", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "balancemulti" },
                    { "address", string.Join(",",addresses) },
                    { "tag", tag },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<BalancesModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<BalancesModel>(ex.Message);
            }
        }

        public async Task<IDataResult<NormalTransactionsModel?>> GetNormalTransactionsByAddressAsync(string apiKey, string address, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlist" },
                    { "address", address },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<NormalTransactionsModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<NormalTransactionsModel>(ex.Message);
            }
        }

        public async Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByAddressAsync(string apiKey, string address, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlistinternal" },
                    { "address", address },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<InternalTransactionsModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<InternalTransactionsModel>(ex.Message);
            }
        }

        public async Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByHashAsync(string apiKey, string txHash, CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlistinternal" },
                    { "txhash", txHash },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<InternalTransactionsModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<InternalTransactionsModel>(ex.Message);
            }
        }

        public async Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByBlockRangeAsync(string apiKey, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "txlistinternal" },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<InternalTransactionsModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<InternalTransactionsModel>(ex.Message);
            }
        }

        public async Task<IDataResult<TokenTransferEventsModel?>> GetTokenTransferEventsByAddressAsync(string apiKey, string address, string contractAddress, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "tokentx" },
                    { "contractaddress", contractAddress },
                    { "address", address },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<TokenTransferEventsModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<TokenTransferEventsModel>(ex.Message);
            }
        }

        public async Task<IDataResult<NftTransferEventsModel?>> GetNftTransferEventsByAddressAsync(string apiKey, string address, string contractAddress, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "tokennfttx" },
                    { "contractaddress", contractAddress },
                    { "address", address },
                    { "startblock", startBlock.ToString() },
                    { "endblock", endBlock.ToString() },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "sort", sort },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<NftTransferEventsModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<NftTransferEventsModel>(ex.Message);
            }
        }

        public async Task<IDataResult<MinedBlocksModel?>> GetBlockMinedByAddressAsync(string apiKey, string address, string blocktype = "blocks", int page = 1, int offset = 10, CancellationToken ct = default)
        {
            try
            {
                var parameters = new Dictionary<string, string>
                {
                    { "module", "account" },
                    { "action", "getminedblocks" },
                    { "address", address },
                    { "blocktype", blocktype },
                    { "page", page.ToString() },
                    { "offset", offset.ToString() },
                    { "apikey", apiKey },
                };

                var result = await RequestHelper.SendRequestAsync<MinedBlocksModel>(parameters, ct: ct);
                return result;
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<MinedBlocksModel>(ex.Message);
            }
        }
    }
}
