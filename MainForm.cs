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

        private unsafe void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileStream saveFileStream = File.OpenRead(OpenFileDialog.FileName);
            Program.LoadedData = new SaveData(new SaveFile(saveFileStream).DecompressedChunks[0].Data);

            ValidateAvatarButton.Enabled = true;

            AvatarNameContentLabel.Text = new String(Program.LoadedData.Avatar.Name);
            AvatarSexContentLabel.Text = Program.LoadedData.Avatar.Sex == 1 ? "Female" : "Male";
            AvatarModelContentLabel.Text = Program.LoadedData.Avatar.Model.ToString();
            DateTime SaveTimestamp = new DateTime(1970, 1, 1).AddSeconds(Program.LoadedData.File.Timestamp);
            SaveDateContentLabel.Text = SaveTimestamp.ToString();

            LevelTextBox.Enabled = true;
            LevelTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Level);

            LevelProgressTrackBar.Enabled = true;
            LevelProgressTrackBar.Value = Experience.ToPercent(Program.LoadedData.Avatar.Level, Program.LoadedData.Avatar.Experience);

            AgilityTextBox.Enabled = true;
            AgilityTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Agility);

            CharismaTextBox.Enabled = true;
            CharismaTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Charisma);

            DexterityTextBox.Enabled = true;
            DexterityTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Dexterity);

            IntelligenceTextBox.Enabled = true;
            IntelligenceTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Intelligence);

            StaminaTextBox.Enabled = true;
            StaminaTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Stamina);

            StrengthTextBox.Enabled = true;
            StrengthTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Strength);

            WisdomTextBox.Enabled = true;
            WisdomTextBox.Text = Convert.ToString(Program.LoadedData.Avatar.Wisdom);

            FreeStatPointsTextBox.Enabled = true;
            FreeStatPointsTextBox.Text = Program.LoadedData.Avatar.FreeStatPoints.ToString();

            AbilitySlotListBox.Enabled = true;
            AbilitySlotListBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            AbilitySlotListBox.SelectedIndex = 0;

            AbilityTypeListBox.Enabled = true;
            AbilityTypeListBox.DataSource = Enum.GetValues(typeof(Program.AbilityType));
            AbilityTypeListBox.SelectedItem = (Program.AbilityType)Program.LoadedData.Avatar.AbilityData[AbilitySlotListBox.SelectedIndex].Type;

            AbilitySubtypeListBox.Enabled = true;
            Program.UpdateSubtypeValue(AbilityTypeListBox, AbilitySubtypeListBox, Program.LoadedData.Avatar.AbilityData[0].SubType);

            AbilityLevelListBox.Enabled = true;
            AbilityLevelListBox.DataSource = Enum.GetValues(typeof(Program.AbilityLevel));
            AbilityLevelListBox.SelectedItem = (Program.AbilityLevel)Program.LoadedData.Avatar.AbilityData[0].Level;

            FreeAbilityPointsTextBox.Enabled = true;
            FreeAbilityPointsTextBox.Text = Program.LoadedData.Avatar.FreeAbilityPoints.ToString();

            GoldTextBox.Enabled = true;
            GoldTextBox.Text = Program.LoadedData.Avatar.Gold.ToString();

            SilverTextBox.Enabled = true;
            SilverTextBox.Text = Program.LoadedData.Avatar.Silver.ToString();

            CopperTextBox.Enabled = true;
            CopperTextBox.Text = Program.LoadedData.Avatar.Copper.ToString();
        }

        private void AbilitySlotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            AbilityTypeListBox.SelectedItem = (Program.AbilityType)Program.LoadedData.Avatar.AbilityData[slot].Type;
            Program.UpdateSubtypeValue(AbilityTypeListBox, AbilitySubtypeListBox, Program.LoadedData.Avatar.AbilityData[slot].SubType);
            AbilityLevelListBox.SelectedItem = (Program.AbilityLevel)Program.LoadedData.Avatar.AbilityData[slot].Level;
        }

        private void AbilityTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.UpdateSubtypeChoices(AbilityTypeListBox, AbilitySubtypeListBox);
        }

        private void ValidateAvatarButton_Click(object sender, EventArgs e)
        {
            var level = Program.LoadedData.Avatar.Level;

            var stats = Program.LoadedData.Avatar.Agility +
                Program.LoadedData.Avatar.Charisma +
                Program.LoadedData.Avatar.Dexterity +
                Program.LoadedData.Avatar.Intelligence +
                Program.LoadedData.Avatar.Stamina +
                Program.LoadedData.Avatar.Strength +
                Program.LoadedData.Avatar.Wisdom +
                Program.LoadedData.Avatar.FreeStatPoints;

            var abilities = 0;
            for (var i = 0; i < 10; i++)
            {
                var abilityLevel = Program.LoadedData.Avatar.AbilityData[i].Level;
                abilities += (abilityLevel == 255) ? 0 : abilityLevel;
            }
            abilities += Program.LoadedData.Avatar.FreeAbilityPoints;

            var experience = Program.LoadedData.Avatar.Experience;

            if (experience < Experience.ForLevel[level] || experience > Experience.ForLevel[(byte)(level + 1)])
            {
                MessageBox.Show(
                    "Wrong experience value for current level! Play with the level progress slide; if the problem persists, report a bug!",
                    "Wrong experience value!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (abilities != (2 * level))
            {
                MessageBox.Show(
                    "Wrong ability points count for current level!\nExpected: " + (2 * level).ToString() + ", Got: " + abilities.ToString() + ".",
                    "Wrong ability points count!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else if (stats != (5 * (level - 1) + 205))
            {
                MessageBox.Show(
                    "Wrong stat points count for current level!\nExpected: " + (5 * (level - 1) + 205).ToString() + ", Got: " + stats.ToString() + ".",
                    "Wrong stat points count!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                MessageBox.Show(
                    "All good!",
                    "All good!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        private void LevelTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Byte level = Convert.ToByte(LevelTextBox.Text);
                if (level > 50 || level < 1) throw new Exception();
                Program.LoadedData.Avatar.Level = level;
                Program.LoadedData.Avatar.Experience = Experience.FromPercent(level, (byte)LevelProgressTrackBar.Value);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [1, 50].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LevelProgressTrackBar_Leave(object sender, EventArgs e)
        {
            Program.LoadedData.Avatar.Experience = Experience.FromPercent(Program.LoadedData.Avatar.Level, (byte)LevelProgressTrackBar.Value);
        }

        private void GoldTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Gold = Convert.ToInt32(GoldTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 2147483647].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilverTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Silver = Convert.ToInt32(SilverTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 2147483647].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopperTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Copper = Convert.ToInt32(CopperTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 2147483647].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StrengthTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Strength = Convert.ToInt16(StrengthTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaminaTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Stamina = Convert.ToInt16(StaminaTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DexterityTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Dexterity = Convert.ToInt16(DexterityTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgilityTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Agility = Convert.ToInt16(AgilityTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IntelligenceTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Intelligence = Convert.ToInt16(IntelligenceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WisdomTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Wisdom = Convert.ToInt16(WisdomTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CharismaTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.Charisma = Convert.ToInt16(CharismaTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FreeStatPointsTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.FreeStatPoints = Convert.ToInt16(FreeStatPointsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbilityTypeListBox_Leave(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            var value = (AbilityTypeListBox.SelectedValue == null) ? (byte)255 : (byte)AbilityTypeListBox.SelectedValue;
            Program.LoadedData.Avatar.AbilityData[slot].Type = value;
            if (value == 255)
            {
                Program.LoadedData.Avatar.AbilityData[slot].SubType = value;
                Program.LoadedData.Avatar.AbilityData[slot].Level = value;
            }
        }

        private void AbilitySubtypeListBox_Leave(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            var value = (AbilitySubtypeListBox.SelectedValue == null) ? (byte)255 : (byte)AbilitySubtypeListBox.SelectedValue;
            Program.LoadedData.Avatar.AbilityData[slot].SubType = value;
            if (value == 255)
            {
                Program.LoadedData.Avatar.AbilityData[slot].Type = value;
                Program.LoadedData.Avatar.AbilityData[slot].Level = value;
            }
        }

        private void AbilityLevelListBox_Leave(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            var value = (AbilityLevelListBox.SelectedValue == null) ? (byte)255 : (byte)AbilityLevelListBox.SelectedValue;
            Program.LoadedData.Avatar.AbilityData[slot].Level = value;
            if (value == 255)
            {
                Program.LoadedData.Avatar.AbilityData[slot].Type = value;
                Program.LoadedData.Avatar.AbilityData[slot].SubType = value;
            }
        }

        private void FreeAbilityPointsTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.LoadedData.Avatar.FreeAbilityPoints = Convert.ToInt16(FreeAbilityPointsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
