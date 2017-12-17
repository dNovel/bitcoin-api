namespace BitcoinInfo.Provider
{
    using System;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using BitcoinInfo.Models;

    public class BlockchainInfo : IProvider
    {
        private const string apiUrl = "https://blockchain.info/";
        private const string apiKey = "";

        public string GetApiKey()
        {
            return apiKey;
        }

        public string GetBaseUri()
        {
            return apiUrl;
        }

        public async Task<List<CoursePacket>> GetExchangeRate()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(apiUrl);
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