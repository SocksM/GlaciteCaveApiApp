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

		}

		private async void lookupButton_Click(object sender, EventArgs e)
		{
			try
			{
				_currentPlayer = await _mojangApiRepository.GetUidByUsername(usernameTextBox.Text);
				HypixelApiRepository hypixelApiRepository = new HypixelApiRepository(apiKeyTextBox.Text);
				_currentHypixelApiResponseRoot = await hypixelApiRepository.GetCurrentStatsByProfileUuidAsync(_currentPlayer.id);

				profileComboBox.Items.Clear();
				foreach (Profile profile in _currentHypixelApiResponseRoot.profiles)
				{
					profileComboBox.Items.Add(profile.cute_name);
				}
				profileComboBox.SelectedIndex = 0;
				LoadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			LoadData();
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

				hotmLabel.Text = $"HOTM: {selectedMember.mining_core.HotmAndLeftOverExp[0]} + {selectedMember.mining_core.HotmAndLeftOverExp[1]} exp";
				potmLabel.Text = $"POTM: {selectedMember.mining_core.nodes.special_0}";
				glacitePowderLabel.Text = $"Glacite Powder: {selectedMember.mining_core.glacitePowderTotal}";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
