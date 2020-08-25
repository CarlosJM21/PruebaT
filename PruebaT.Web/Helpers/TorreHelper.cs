using Newtonsoft.Json;
using PruebaT.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaT.Web.Helpers
{
    public class TorreHelper:ITorreHelper
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://search.torre.co/");
            return client;
        }

        public async Task<Bio> bio(string Username)
        {
            Bio Biografia = new Bio();
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://torre.bio/api/bios/");

            HttpResponseMessage res = await client.GetAsync(Username);

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                Biografia = JsonConvert.DeserializeObject<Bio>(results);
            }
            return Biografia;
        }

        public async Task<Opportunity> Job(string id)
        {
            var o = new Opportunity();

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://torre.co/api/opportunities/");
            String Url = id;
            
            HttpResponseMessage res = await client.GetAsync(Url);

            if (res.IsSuccessStatusCode)
            {
                var results = res.Content.ReadAsStringAsync().Result;
                o = JsonConvert.DeserializeObject<Opportunity>(results);
            }
            
            return o;
        }


    }
}
