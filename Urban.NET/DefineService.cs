using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Urban.NET
{
    public class UrbanService
    {
        HttpClient client;
        public static string URL = "http://api.urbandictionary.com/v0/define?term=";
        public Data data;

        public async Task<Data> Data(string word)
        { 
            client = new HttpClient();
            var wordSearch = WebUtility.UrlEncode(word);
            string request = await client.GetStringAsync(URL + word);
            Data data = JsonConvert.DeserializeObject<Data>(request);
          
            if (data.ResultType == "no_results")
            {
                throw new Exception($"The definition for {word} wasn't found.");
            }
            return data;
            
        }

    }
}
