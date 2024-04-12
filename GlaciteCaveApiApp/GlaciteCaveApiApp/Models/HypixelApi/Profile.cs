namespace GlaciteCaveApiApp.Models.HypixelApi
{
	public class Profile
	{
		public string profile_id { get; set; }
		//public CommunityUpgrades community_upgrades { get; set; }
		public Dictionary<string, Member> members { get; set; }
		public string cute_name { get; set; }
		public bool selected { get; set; }
	}
}