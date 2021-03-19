using MyApplicationUsingApi.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MyApplicationUsingApi.Services
{
    public class ApiService : IApiService
    {
        public async Task<TeamsList> GetCurrencyInformationAsync()
        {
            TeamsList retuncalender = null;
            HttpClient client = new HttpClient();
            var CalenderInfo = await client.GetAsync("http://data.nba.net/data/10s/prod/v1/2020/teams.json");

            if (CalenderInfo.IsSuccessStatusCode)
            {
                var teams = await CalenderInfo.Content.ReadAsStringAsync();
                retuncalender = JsonConvert.DeserializeObject<TeamsList>(teams);             
                
            }

            return retuncalender;
        }
    }
}
