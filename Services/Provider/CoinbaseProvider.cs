namespace BitcoinInfo.Provider
{
    using System;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class CoinbaseProvider : IProvider
    {
        private const string apiUrl = "https://blockchain.info/";
        private const string apiKey = "";

        public async Task<string> GetExchangeRate()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(apiUrl);
                    var response = await client.GetAsync($"ticker");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    return stringResult;
                }
                catch (HttpRequestException httpRequestException)
                {
                    return $"{httpRequestException.Message}";
                }
            }
        }
    }
}