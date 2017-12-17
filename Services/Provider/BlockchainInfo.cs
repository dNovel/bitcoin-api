// <copyright file="BlockchainInfo.cs" company="Dominik Steffen">
// Please do not change anything without asking for permission. No warranty as this is private code.
// </copyright>

namespace BitcoinInfo.Provider
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using BitcoinInfo.Models;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// An implementation of a specific API
    /// </summary>
    public class BlockchainInfo : IProvider
    {
        private const string ApiUrl = "https://blockchain.info/";
        private const string ApiKey = "";

        /// <summary>
        /// Gets the API key
        /// </summary>
        /// <returns></returns>
        public string GetApiKey()
        {
            return ApiKey;
        }

        /// <summary>
        /// Gets the base uri address
        /// </summary>
        /// <returns></returns>
        public string GetBaseUri()
        {
            return ApiUrl;
        }

        /// <summary>
        /// Gets the current exchange rate
        /// </summary>
        /// <returns></returns>
        public async Task<List<CoursePacket>> GetExchangeRate()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(ApiUrl);
                    var response = await client.GetAsync($"ticker");
                    response.EnsureSuccessStatusCode();
                    var content = response.Content;

                    JObject jObj = JObject.Parse(await content.ReadAsStringAsync());

                    List<CoursePacket> courseObj = new List<CoursePacket>();
                    foreach (KeyValuePair<string, JToken> dSet in jObj)
                    {
                        var packet = dSet.Value.ToObject<CoursePacket>();
                        packet.Currency = dSet.Key;
                        courseObj.Add(packet);
                    }

                    return courseObj;
                }
                catch (HttpRequestException httpRequestException)
                {
                    Console.WriteLine($"{httpRequestException.Message}");
                    return new List<CoursePacket>();
                }
            }
        }
    }
}