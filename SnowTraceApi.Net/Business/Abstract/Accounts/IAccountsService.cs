using SnowTraceApi.Net.Core.Results.Abstract;
using SnowTraceApi.Net.Models.Accounts;

namespace SnowTraceApi.Net.Business.Abstract.Accounts
{
    public interface IAccountsService
    {
        /// <summary>
        /// Returns the AVAX balance of a given address.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="address">the string representing the address to check for balance</param>
        /// <param name="tag">the string pre-defined block parameter, either earliest, pending or latest</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<BalanceModel?>> GetAvaxBalanceForSingleAddressAsync(string apiKey, string address, string tag = "latest", CancellationToken ct = default);

        /// <summary>
        /// Returns the balance of the accounts from a list of addresses.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="addresses">the strings representing the addresses to check for balance, separated by ',' up to 20 addresses per call </param>
        /// <param name="tag">the integer pre-defined block parameter, either earliest, pending or latest</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<BalancesModel?>> GetAvaxBalanceForMultipleAddressesAsync(string apiKey, List<string> addresses, string tag = "latest", CancellationToken ct = default);

        /// <summary>
        /// Returns the list of transactions performed by an address, with optional pagination.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="address">the string representing the addresses to check for balance</param>
        /// <param name="startBlock">the integer block number to start searching for transactions</param>
        /// <param name="endBlock">the integer block number to stop searching for transactions</param>
        /// <param name="page">the integer page number, if pagination is enabled</param>
        /// <param name="offset">the number of transactions displayed per page</param>
        /// <param name="sort">the sorting preference, use asc to sort by ascending and desc to sort by descendin Tip: Specify a smaller startblock and endblock range for faster search results.</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<NormalTransactionsModel?>> GetNormalTransactionsByAddressAsync(string apiKey, string address, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default);

        /// <summary>
        /// Returns the list of internal transactions performed by an address, with optional pagination.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// Tip: Specify a smaller startblock and endblock range for faster search results
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="address">the string representing the addresses to check for balance</param>
        /// <param name="startBlock">the integer block number to start searching for transactions</param>
        /// <param name="endBlock">the integer block number to stop searching for transactions</param>
        /// <param name="page">the integer page number, if pagination is enabled</param>
        /// <param name="offset">the number of transactions displayed per page</param>
        /// <param name="sort">the sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByAddressAsync(string apiKey, string address, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default);

        /// <summary>
        /// Returns the list of internal transactions performed within a transaction.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="txHash">the string representing the transaction hash to check for internal transactions</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByHashAsync(string apiKey, string txHash, CancellationToken ct = default);

        /// <summary>
        /// Returns the list of internal transactions performed within a block range, with optional pagination.
        /// Note : This API endpoint returns a maximum of 10000 records only.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="startBlock">the integer block number to start searching for transactions</param>
        /// <param name="endBlock">the integer block number to stop searching for transactions</param>
        /// <param name="page">the integer page number, if pagination is enabled</param>
        /// <param name="offset">the number of transactions displayed per page</param>
        /// <param name="sort">the sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<InternalTransactionsModel?>> GetInternalTransactionsByBlockRangeAsync(string apiKey, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default);

        /// <summary>
        /// Returns the list of ERC-20 tokens transferred by an address, with optional filtering by token contract.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="address">the string representing the address to check for balance</param>
        /// <param name="contractAddress">the string representing the token contract address to check for balance</param>
        /// <param name="startBlock">the integer block number to start searching for transactions</param>
        /// <param name="endBlock">the integer block number to stop searching for transactions</param>
        /// <param name="page">the integer page number, if pagination is enabled</param>
        /// <param name="offset">the number of transactions displayed per page</param>
        /// <param name="sort">the sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<TokenTransferEventsModel?>> GetTokenTransferEventsByAddressAsync(string apiKey, string address, string contractAddress, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default);

        /// <summary>
        /// Returns the list of ERC-721 ( NFT ) tokens transferred by an address, with optional filtering by token contract.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="address">the string representing the address to check for balance</param>
        /// <param name="contractAddress">the string representing the token contract address to check for balance</param>
        /// <param name="startBlock">the integer block number to start searching for transactions</param>
        /// <param name="endBlock">the integer block number to stop searching for transactions</param>
        /// <param name="page">the integer page number, if pagination is enabled</param>
        /// <param name="offset">the number of transactions displayed per page</param>
        /// <param name="sort">the sorting preference, use asc to sort by ascending and desc to sort by descending</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<NftTransferEventsModel?>> GetNftTransferEventsByAddressAsync(string apiKey, string address, string contractAddress, int startBlock = 0, int endBlock = 99999999, int page = 1, int offset = 10, string sort = "asc", CancellationToken ct = default);

        /// <summary>
        /// Returns the list of blocks mined by an address.
        /// </summary>
        /// <param name="apiKey">SnowTrace API Key</param>
        /// <param name="address">the string representing the address to check for balance</param>
        /// <param name="blocktype">the string pre-defined block type, either blocks for canonical blocks or uncles for uncle blocks only</param>
        /// <param name="page">the integer page number, if pagination is enabled</param>
        /// <param name="offset">the number of transactions displayed per page</param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IDataResult<MinedBlocksModel?>> GetBlockMinedByAddressAsync(string apiKey, string address, string blocktype = "blocks", int page = 1, int offset = 10, CancellationToken ct = default);
    }
}
