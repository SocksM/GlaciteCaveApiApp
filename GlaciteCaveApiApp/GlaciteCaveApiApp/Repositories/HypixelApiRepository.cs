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

		public async Task<string> GetCurrentStatsByProfileUuidAsync(string profileUuid)
		{
			string apiUrl = $"https://api.hypixel.net/v2/skyblock/profile?profile={profileUuid}&key={ApiKey}";

			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(apiUrl);
				if (response.IsSuccessStatusCode)
				{
					return await response.Content.ReadAsStringAsync();
				}
				throw new Exception(message: $"Failed to retrieve data. Status code: {response.StatusCode}");
			}
		}
	}
}
