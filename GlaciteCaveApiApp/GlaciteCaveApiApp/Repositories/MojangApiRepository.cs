using GlaciteCaveApiApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlaciteCaveApiApp.Repositories
{
    public class MojangApiRepository
    {
        private readonly string _baseUrl = "https://api.mojang.com/";

        public async Task<MojangApiPlayer> GetUidByUsername(string username)
        {
			string apiUrl = _baseUrl + "users/profiles/minecraft/" + username;
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(apiUrl);
				if (response.IsSuccessStatusCode)
				{
					return JsonConvert.DeserializeObject<MojangApiPlayer>( await response.Content.ReadAsStringAsync());
				}
				throw new Exception(message: $"Failed to retrieve data. Status code: {response.StatusCode}");
			}
		}
    }
}
