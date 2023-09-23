using System.Web;

namespace SnowTraceApi.Net.Core.Utilities
{
    public class SnowTraceHelper
    {
        const string VERSION = "v2";
        internal const string MAINNET_URL = "https://api.snowtrace.io/api";
        const string FUJI_TESTNET_URL = "https://api-testnet.snowtrace.io/api";

        internal static Uri GetBaseUrl()
        {
            return new Uri($"{MAINNET_URL}{VERSION}");
        }

        internal static string GetRequestUrl(string url, string version = "")
        {
            version = string.IsNullOrEmpty(version) ? VERSION : version;
            return $"{MAINNET_URL}{version}{url}";
        }

        internal static string CreateQueryString(Dictionary<string, string>? parameters)
        {
            parameters ??= new Dictionary<string, string>();
            return $"?{string.Join("&", parameters.Where(p => !string.IsNullOrEmpty(p.Value))
                .Select(p => $"{p.Key}={HttpUtility.UrlEncode(p.Value)}"))}";
        }
    }
}
