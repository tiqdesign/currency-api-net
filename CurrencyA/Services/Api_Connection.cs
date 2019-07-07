using CurrencyA.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyA.Services
{
    public class Api_Connection
    {
      
        HttpClient client = new HttpClient();

        public async Task<Currency> GetCurrency(string base_cur, string rate_cur, string date_cur)
        {
            var data = await client.GetStringAsync("https://api.ratesapi.io/api/"+date_cur+"?base="+base_cur+"&symbols="+rate_cur);

            var c1 = JsonConvert.DeserializeObject<Currency>(data);
            return c1;
        }
    }
}
