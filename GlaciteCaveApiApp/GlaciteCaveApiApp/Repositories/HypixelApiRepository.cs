using GlaciteCaveApiApp.Models.HypixelApi;
using GlaciteCaveApiApp.Models.MojangApi;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlaciteCaveApiApp.Repositories
{
    public class HypixelApiRepository
    {
		readonly string ApiKey;

		public HypixelApiRepository(string apiKey)
		{
			this.ApiKey = apiKey;
		}

		public async Task<HypixelApiResponseRoot> GetCurrentStatsByProfileUuidAsync(string mcUuid)
		{
			// https://api.hypixel.net/v2/skyblock/profiles?key=429d9617-5f61-48d3-941d-e90e1fc86369&uuid=5e22209be5864a088761aa6bde56a090
			string apiUrl = $"https://api.hypixel.net/v2/skyblock/profiles?uuid={mcUuid}&key={ApiKey}";

			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(apiUrl);
				if (response.IsSuccessStatusCode)
				{
					return JsonConvert.DeserializeObject<HypixelApiResponseRoot>(await response.Content.ReadAsStringAsync());
				}
				throw new Exception(message: $"Failed to retrieve data. Status code: {response.StatusCode}");
			}
		}
	}
}
