namespace GlaciteCaveApiApp.Models.HypixelApi
{
	public class MiningCore
	{
		public Node nodes { get; set; }
		public double experience { get; set; }
		public double[] HotmAndLeftOverExp { 
			get {
				switch (experience)
				{
					case < 3_000:
						return new double[] { 1, experience };
					case < 12_000: 
						return new double[] { 2, experience - 3_000 };
					case < 37_000:
						return new double[] { 3, experience - 12_000 };
					case < 97_000:
						return new double[] { 4, experience - 37_000 };
					case < 197_000:
						return new double[] { 5, experience - 97_000 };
					case < 347_000:
						return new double[] { 6, experience - 197_000 };
					case < 557_000:
						return new double[] { 7, experience - 347_000 };
					case < 847_000:
						return new double[] { 8, experience - 557_000 };
					case < 1_247_000:
						return new double[] { 9, experience - 847_000 };
				}
				return new double[] { 10, 0 };
			}
		} 
		public double powder_glacite { get; set; }
		public double powder_spent_glacite { get; set; }
		public double glacitePowderTotal { get { return powder_glacite + powder_spent_glacite; } }
	}
}