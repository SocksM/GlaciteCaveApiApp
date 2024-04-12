using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlaciteCaveApiApp.Models.HypixelApi
{
	public class HypixelApiResponseRoot
	{
		public bool success { get; set; }
		public List<Profile> profiles { get; set; }
	}
}
