using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace LoginExample.Data.Impl
{
    public class AdultService : IAdultData
    {


        public async Task<IList<Adult>> GetAdultsAsync()
        {
            using HttpClient client = new HttpClient();
            Task<string> stringAsync = client.GetStringAsync("https://localhost:5002/Person");
            string message = await stringAsync;
            IList<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return result;
        }
        

        public async Task AddAdultAsync(Adult adult)
        {
            using HttpClient client = new HttpClient();
            string adultAsJson = JsonSerializer.Serialize(adult, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            HttpContent content1 = new StringContent(adultAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync( "https://localhost:5002/Person", content1 );
        }

        
        public async Task RemoveAdultAsync(int id)
        {
            using HttpClient client = new HttpClient();
            await client.DeleteAsync("https://localhost:5002/Person" + $"/{id}");
        }




    }
}