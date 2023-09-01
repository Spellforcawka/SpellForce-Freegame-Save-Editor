using System.IO;
using System.Windows.Forms;

namespace SFSE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog(this);
        }

        private void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileStream saveFileStream = File.OpenRead(OpenFileDialog.FileName);
            Program.LoadedData = new SaveData(new SaveFile(saveFileStream).DecompressedChunks[0].Data);

            ValidateAvatarButton.Enabled = true;

            AvatarNameContentLabel.Text = new String(Program.LoadedData.AvatarName);
            AvatarSexContentLabel.Text = Program.LoadedData.AvatarSex == 1 ? "Female" : "Male";
            AvatarModelContentLabel.Text = Program.LoadedData.AvatarModel.ToString();
            DateTime SaveTimestamp = new DateTime(1970, 1, 1).AddSeconds(Program.LoadedData.Timestamp);
            SaveDateContentLabel.Text = SaveTimestamp.ToString();

            LevelTextBox.Enabled = true;
            LevelTextBox.Text = Convert.ToString(Program.LoadedData.AvatarLevel);

            LevelProgressTrackBar.Enabled = true;
            LevelProgressTrackBar.Value = Experience.ToPercent(Program.LoadedData.AvatarLevel, Program.LoadedData.AvatarExperience);

            AgilityTextBox.Enabled = true;
            AgilityTextBox.Text = Convert.ToString(Program.LoadedData.AvatarAgility);

            CharismaTextBox.Enabled = true;
            CharismaTextBox.Text = Convert.ToString(Program.LoadedData.AvatarCharisma);

            DexterityTextBox.Enabled = true;
            DexterityTextBox.Text = Convert.ToString(Program.LoadedData.AvatarDexterity);

            IntelligenceTextBox.Enabled = true;
            IntelligenceTextBox.Text = Convert.ToString(Program.LoadedData.AvatarIntelligence);

            StaminaTextBox.Enabled = true;
            StaminaTextBox.Text = Convert.ToString(Program.LoadedData.AvatarStamina);

            StrengthTextBox.Enabled = true;
            StrengthTextBox.Text = Convert.ToString(Program.LoadedData.AvatarStrength);

            WisdomTextBox.Enabled = true;
            WisdomTextBox.Text = Convert.ToString(Program.LoadedData.AvatarWisdom);

            FreeStatPointsTextBox.Enabled = true;
            FreeStatPointsTextBox.Text = Program.LoadedData.AvatarFreeStatPoints.ToString();

            AbilitySlotListBox.Enabled = true;
            AbilitySlotListBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            AbilitySlotListBox.SelectedIndex = 0;

            AbilityTypeListBox.Enabled = true;
            AbilityTypeListBox.DataSource = Enum.GetValues(typeof(Program.AbilityType));
            AbilityTypeListBox.SelectedItem = (Program.AbilityType)Program.LoadedData.AvatarAbilities[AbilitySlotListBox.SelectedIndex].Type;

            AbilitySubtypeListBox.Enabled = true;
            Program.UpdateSubtypeValue(AbilityTypeListBox, AbilitySubtypeListBox, Program.LoadedData.AvatarAbilities[0].SubType);

            AbilityLevelListBox.Enabled = true;
            AbilityLevelListBox.DataSource = Enum.GetValues(typeof(Program.AbilityLevel));
            AbilityLevelListBox.SelectedItem = (Program.AbilityLevel)Program.LoadedData.AvatarAbilities[0].Level;

            FreeAbilityPointsTextBox.Enabled = true;
            FreeAbilityPointsTextBox.Text = Program.LoadedData.AvatarFreeAbilityPoints.ToString();

            GoldTextBox.Enabled = true;
            GoldTextBox.Text = Program.LoadedData.AvatarGold.ToString();

            SilverTextBox.Enabled = true;
            SilverTextBox.Text = Program.LoadedData.AvatarSilver.ToString();

            CopperTextBox.Enabled = true;
            CopperTextBox.Text = Program.LoadedData.AvatarCopper.ToString();
        }

        private void AbilitySlotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbilityTypeListBox.SelectedItem = (Program.AbilityType)Program.LoadedData.AvatarAbilities[AbilitySlotListBox.SelectedIndex].Type;
            Program.UpdateSubtypeValue(AbilityTypeListBox, AbilitySubtypeListBox, Program.LoadedData.AvatarAbilities[AbilitySlotListBox.SelectedIndex].SubType);
            AbilityLevelListBox.SelectedItem = (Program.AbilityLevel)Program.LoadedData.AvatarAbilities[AbilitySlotListBox.SelectedIndex].Level;
        }

        private void AbilityTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.UpdateSubtypeChoices(AbilityTypeListBox, AbilitySubtypeListBox);
        }

        private void ValidateAvatarButton_Click(object sender, EventArgs e)
        {
            var level = Program.LoadedData.AvatarLevel;

            var stats = Program.LoadedData.AvatarAgility +
                Program.LoadedData.AvatarCharisma +
                Program.LoadedData.AvatarDexterity +
                Program.LoadedData.AvatarIntelligence +
                Program.LoadedData.AvatarStamina +
                Program.LoadedData.AvatarStrength +
                Program.LoadedData.AvatarWisdom +
                Program.LoadedData.AvatarFreeStatPoints;

            var abilities = 0;
            for (var i = 0; i < 10; i++)
            {
                var abilityLevel = Program.LoadedData.AvatarAbilities[i].Level;
                abilities += abilityLevel == 255 ? 0 : abilityLevel;
            }
            abilities += Program.LoadedData.AvatarFreeAbilityPoints;

            var experience = Program.LoadedData.AvatarExperience;

            if (experience < Experience.ForLevel[level] || experience > Experience.ForLevel[(byte)(level+1)])
            {
                MessageBox.Show(
                    "Wrong experience value for current level! Play with the level progress slide; if the problem persists, report a bug!",
                    "Wrong experience value!", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            } else if (abilities != (2 * level))
            {
                MessageBox.Show(
                    "Wrong ability points count for current level!\nExpected: " + (2 * level).ToString() + ", Got: " + abilities.ToString() + ".",
                    "Wrong ability points count!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            } else if (stats != (5 * (level - 1) + 205))
            {
                MessageBox.Show(
                    "Wrong stat points count for current level!\nExpected: " + (5 * (level - 1) + 205).ToString() + ", Got: " + stats.ToString() + ".",
                    "Wrong stat points count!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            } else
            {
                MessageBox.Show(
                    "All good!",
                    "All good!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

    }
}
