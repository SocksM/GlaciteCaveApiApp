using GlaciteCaveApiApp.Models.HypixelApi;
using GlaciteCaveApiApp.Models.MojangApi;
using GlaciteCaveApiApp.Repositories;

namespace GlaciteCaveApiApp
{
	public partial class Form1 : Form
	{
		private MojangApiPlayer _currentPlayer;
		private HypixelApiResponseRoot _currentHypixelApiResponseRoot;

		private MojangApiRepository _mojangApiRepository;

		public Form1()
		{
			InitializeComponent();
			_mojangApiRepository = new MojangApiRepository();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
			//string relativeFilePath = Path.Combine("..", "..", "..", "..", "..", "..", "LasApiKeyUsed.txt");

			//string absoluteFilePath = Path.GetFullPath(Path.Combine(currentDirectory, relativeFilePath));
			//// C:\Github\GlaciteCaveApiApp\GlaciteCaveApiApp\GlaciteCaveApiApp\LastApiKeyUsed.txt
			//if (File.Exists(absoluteFilePath))
			//{
			//	string fileContents = File.ReadAllText(absoluteFilePath);
			//	if (!string.IsNullOrEmpty(fileContents))
			//	{
			//		apiKeyTextBox.Text = fileContents;
			//	}
			//}
		}

		private async void lookupButton_Click(object sender, EventArgs e)
		{
			try
			{
				_currentPlayer = await _mojangApiRepository.GetUuidByUsername(usernameTextBox.Text);
				HypixelApiRepository hypixelApiRepository = new HypixelApiRepository(apiKeyTextBox.Text);
				_currentHypixelApiResponseRoot = await hypixelApiRepository.GetCurrentStatsByMcUuidAsync(_currentPlayer.id);

				profileComboBox.Items.Clear();
				foreach (Profile profile in _currentHypixelApiResponseRoot.profiles)
				{
					profileComboBox.Items.Add(profile.cute_name);
				}
				profileComboBox.SelectedIndex = 0;
				LoadData();
				//File.WriteAllText(@"", apiKeyTextBox.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LoadData()
		{
			try
			{
				Member selectedMember = null;
				foreach (Profile profile in _currentHypixelApiResponseRoot.profiles)
				{
					if (profile.cute_name == profileComboBox.Text)
					{
						foreach (KeyValuePair<string, Member> member in profile.members)
						{
							if (member.Key == _currentPlayer.id)
							{
								selectedMember = member.Value;
								break;
							}
						}
						break;
					}
				}

				hotmLabel.Text = $"HOTM: {selectedMember?.mining_core?.HotmAndLeftOverExp[0] ?? 0} + {selectedMember?.mining_core?.HotmAndLeftOverExp[1] ?? 0} exp";
				potmLabel.Text = $"POTM: {selectedMember?.mining_core?.nodes.special_0 ?? 0}";
				glacitePowderLabel.Text = $"Glacite Powder: {selectedMember?.mining_core?.glacitePowderTotal ?? 0}";

				mageLabel.Text = $"Glacite Mage: {selectedMember?.bestiary?.kills?.glacite_mage_155 ?? 0}";
				bowmanLabel.Text = $"Glacite Bowman: {selectedMember?.bestiary?.kills?.glacite_bowman_165 ?? 0}";
				muttLabel.Text = $"Glacite Mutt: {selectedMember?.bestiary?.kills?.glacite_mutt_180 ?? 0}";
				caverLabel.Text = $"Glacite Caver: {selectedMember?.bestiary?.kills?.glacite_caver_200 ?? 0}";


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
