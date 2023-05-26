using CryptocurrencyWpf.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWpf.Services
{
    public class ApiService
    {
        private const string CoinCapApiUrl = "https://api.coincap.io/v2";

        public async Task<List<Cryptocurrency>> GetCryptocurrencies()
        {
            using (var client = new HttpClient())
            {
                string url = $"{CoinCapApiUrl}/assets?limit=10";
                string response = await client.GetStringAsync(url);

                JObject json = JObject.Parse(response);
                JArray data = (JArray)json["data"];

                return data.ToObject<List<Cryptocurrency>>();
            }
        }
    }
}
