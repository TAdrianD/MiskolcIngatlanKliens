using MiskolcIngatlanKliens.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiskolcIngatlanKliens.Services
{
    internal class IngatlanService
    {
        public static async Task<List<Ingatlan>> GetAll(HttpClient client)
        {
            List<Ingatlan> result = await client.GetFromJsonAsync<List<Ingatlan>>("Ingatlan");
            if (result is not null)
            {
                return result;
            }
            else
            {
                return new List<Ingatlan>();
            }
            //feltoltendo.Clear();
            //result.ForEach(feltoltendo.Add);
        }

        public async static Task<string> InsertNew(HttpClient client, Ingatlan ujIngatlan)
        {
            string uj = JsonSerializer.Serialize(ujIngatlan, JsonSerializerOptions.Default);
            string url = $"{client.BaseAddress}Ingatlan";
            var content = new StringContent(uj, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            var valasz = await response.Content.ReadAsStringAsync();
            return valasz;
        }
    }
}
