using Newtonsoft.Json;
using PruebaT.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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


        public async Task<Search<SPerson>> searchpeople(String offset, String size, String[] agg) 
        {
            var lp = new Search<SPerson> { };
            HttpClient client = Initial();
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage res = await client.PostAsync("people/_search/", content);

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                lp = JsonConvert.DeserializeObject<Search<SPerson>>(result);
            }

            return lp;
        }

        public async Task<Search<SOpp>> searchoppt(String offset, String size, String[] agg) 
        {
            var lo = new Search<SOpp> { };
            HttpClient client = Initial();
            var content = new StringContent("", Encoding.UTF8, "application/json");
            HttpResponseMessage res = await client.PostAsync("opportunities/_search/", content);

            if (res.IsSuccessStatusCode)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                lo = JsonConvert.DeserializeObject<Search<SOpp>>(result);
            }


            return lo;
        }

    }
}
