using System.IO;
using System.Text;
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
            Program.SaveFilePath = OpenFileDialog.FileName;
            FileStream saveFileStream = File.OpenRead(Program.SaveFilePath);
            Program.SaveFile = new SaveFile(saveFileStream);
            saveFileStream.Close();
            Program.SaveFileData = new SaveData(Program.SaveFile.DecompressedChunks[0].Data);

            ValidateAvatarButton.Enabled = true;
            SaveFileButton.Enabled = true;

            AvatarNameContentLabel.Text = new String(Program.SaveFileData.AvatarData.Name);
            AvatarSexContentLabel.Text = Program.SaveFileData.AvatarData.Sex == 1 ? "Female" : "Male";
            AvatarModelContentLabel.Text = Program.SaveFileData.AvatarData.Model.ToString();
            DateTime SaveTimestamp = new DateTime(1970, 1, 1).AddSeconds(Program.SaveFileData.FileData.Timestamp);
            SaveDateContentLabel.Text = SaveTimestamp.ToString();

            LevelTextBox.Enabled = true;
            LevelTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Level);

            LevelProgressTrackBar.Enabled = true;
            LevelProgressTrackBar.Value = Experience.ToPercent(Program.SaveFileData.AvatarData.Level, Program.SaveFileData.AvatarData.Experience);

            AgilityTextBox.Enabled = true;
            AgilityTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Agility);

            CharismaTextBox.Enabled = true;
            CharismaTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Charisma);

            DexterityTextBox.Enabled = true;
            DexterityTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Dexterity);

            IntelligenceTextBox.Enabled = true;
            IntelligenceTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Intelligence);

            StaminaTextBox.Enabled = true;
            StaminaTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Stamina);

            StrengthTextBox.Enabled = true;
            StrengthTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Strength);

            WisdomTextBox.Enabled = true;
            WisdomTextBox.Text = Convert.ToString(Program.SaveFileData.AvatarData.Wisdom);

            FreeStatPointsTextBox.Enabled = true;
            FreeStatPointsTextBox.Text = Program.SaveFileData.AvatarData.FreeStatPoints.ToString();

            AbilitySlotListBox.Enabled = true;
            AbilitySlotListBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            AbilitySlotListBox.SelectedIndex = 0;

            AbilityTypeListBox.Enabled = true;
            AbilityTypeListBox.DataSource = Enum.GetValues(typeof(Program.AbilityType));
            AbilityTypeListBox.SelectedItem = (Program.AbilityType)Program.SaveFileData.AvatarData.AbilityData[AbilitySlotListBox.SelectedIndex].Type;

            AbilitySubtypeListBox.Enabled = true;
            Program.UpdateSubtypeValue(AbilityTypeListBox, AbilitySubtypeListBox, Program.SaveFileData.AvatarData.AbilityData[0].SubType);

            AbilityLevelListBox.Enabled = true;
            AbilityLevelListBox.DataSource = Enum.GetValues(typeof(Program.AbilityLevel));
            AbilityLevelListBox.SelectedItem = (Program.AbilityLevel)Program.SaveFileData.AvatarData.AbilityData[0].Level;

            FreeAbilityPointsTextBox.Enabled = true;
            FreeAbilityPointsTextBox.Text = Program.SaveFileData.AvatarData.FreeAbilityPoints.ToString();

            GoldTextBox.Enabled = true;
            GoldTextBox.Text = Program.SaveFileData.AvatarData.Gold.ToString();

            SilverTextBox.Enabled = true;
            SilverTextBox.Text = Program.SaveFileData.AvatarData.Silver.ToString();

            CopperTextBox.Enabled = true;
            CopperTextBox.Text = Program.SaveFileData.AvatarData.Copper.ToString();
        }

        private void AbilitySlotListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            AbilityTypeListBox.SelectedItem = (Program.AbilityType)Program.SaveFileData.AvatarData.AbilityData[slot].Type;
            Program.UpdateSubtypeValue(AbilityTypeListBox, AbilitySubtypeListBox, Program.SaveFileData.AvatarData.AbilityData[slot].SubType);
            AbilityLevelListBox.SelectedItem = (Program.AbilityLevel)Program.SaveFileData.AvatarData.AbilityData[slot].Level;
        }

        private void AbilityTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.UpdateSubtypeChoices(AbilityTypeListBox, AbilitySubtypeListBox);
        }

        private void ValidateAvatarButton_Click(object sender, EventArgs e)
        {
            var level = Program.SaveFileData.AvatarData.Level;

            var stats = Program.SaveFileData.AvatarData.Agility +
                Program.SaveFileData.AvatarData.Charisma +
                Program.SaveFileData.AvatarData.Dexterity +
                Program.SaveFileData.AvatarData.Intelligence +
                Program.SaveFileData.AvatarData.Stamina +
                Program.SaveFileData.AvatarData.Strength +
                Program.SaveFileData.AvatarData.Wisdom +
                Program.SaveFileData.AvatarData.FreeStatPoints;

            var abilities = 0;
            for (var i = 0; i < 10; i++)
            {
                var abilityLevel = Program.SaveFileData.AvatarData.AbilityData[i].Level;
                abilities += (abilityLevel == 255) ? 0 : abilityLevel;
            }
            abilities += Program.SaveFileData.AvatarData.FreeAbilityPoints;

            var experience = Program.SaveFileData.AvatarData.Experience;

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
                Program.SaveFileData.AvatarData.Level = level;
                Program.SaveFileData.AvatarData.Experience = Experience.FromPercent(level, (byte)LevelProgressTrackBar.Value);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [1, 50].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LevelProgressTrackBar_Leave(object sender, EventArgs e)
        {
            Program.SaveFileData.AvatarData.Experience = Experience.FromPercent(Program.SaveFileData.AvatarData.Level, (byte)LevelProgressTrackBar.Value);
        }

        private void GoldTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.SaveFileData.AvatarData.Gold = Convert.ToInt32(GoldTextBox.Text);
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
                Program.SaveFileData.AvatarData.Silver = Convert.ToInt32(SilverTextBox.Text);
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
                Program.SaveFileData.AvatarData.Copper = Convert.ToInt32(CopperTextBox.Text);
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
                Program.SaveFileData.AvatarData.Strength = Convert.ToInt16(StrengthTextBox.Text);
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
                Program.SaveFileData.AvatarData.Stamina = Convert.ToInt16(StaminaTextBox.Text);
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
                Program.SaveFileData.AvatarData.Dexterity = Convert.ToInt16(DexterityTextBox.Text);
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
                Program.SaveFileData.AvatarData.Agility = Convert.ToInt16(AgilityTextBox.Text);
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
                Program.SaveFileData.AvatarData.Intelligence = Convert.ToInt16(IntelligenceTextBox.Text);
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
                Program.SaveFileData.AvatarData.Wisdom = Convert.ToInt16(WisdomTextBox.Text);
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
                Program.SaveFileData.AvatarData.Charisma = Convert.ToInt16(CharismaTextBox.Text);
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
                Program.SaveFileData.AvatarData.FreeStatPoints = Convert.ToInt16(FreeStatPointsTextBox.Text);
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
            Program.SaveFileData.AvatarData.AbilityData[slot].Type = value;
            if (value == 255)
            {
                Program.SaveFileData.AvatarData.AbilityData[slot].SubType = value;
                Program.SaveFileData.AvatarData.AbilityData[slot].Level = value;
            }
        }

        private void AbilitySubtypeListBox_Leave(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            var value = (AbilitySubtypeListBox.SelectedValue == null) ? (byte)255 : (byte)AbilitySubtypeListBox.SelectedValue;
            Program.SaveFileData.AvatarData.AbilityData[slot].SubType = value;
            if (value == 255)
            {
                Program.SaveFileData.AvatarData.AbilityData[slot].Type = value;
                Program.SaveFileData.AvatarData.AbilityData[slot].Level = value;
            }
        }

        private void AbilityLevelListBox_Leave(object sender, EventArgs e)
        {
            var slot = AbilitySlotListBox.SelectedIndex;
            var value = (AbilityLevelListBox.SelectedValue == null) ? (byte)255 : (byte)AbilityLevelListBox.SelectedValue;
            Program.SaveFileData.AvatarData.AbilityData[slot].Level = value;
            if (value == 255)
            {
                Program.SaveFileData.AvatarData.AbilityData[slot].Type = value;
                Program.SaveFileData.AvatarData.AbilityData[slot].SubType = value;
            }
        }

        private void FreeAbilityPointsTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Program.SaveFileData.AvatarData.FreeAbilityPoints = Convert.ToInt16(FreeAbilityPointsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number in a range [0, 32767].", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int timestamp = (int)t.TotalSeconds;
            
            File.Copy(Program.SaveFilePath, Program.SaveFilePath + ".bak-" + timestamp);
            Program.SaveFile.DecompressedChunks[0] = new DecompressedSaveChunk(Program.SaveFileData);

            File.Delete(Program.SaveFilePath);

            FileStream fs = new FileStream(Program.SaveFilePath, FileMode.Create, FileAccess.Write);

            // SaveFile serialization
            fs.Write(BitConverter.GetBytes(Program.SaveFile.Header.Magic));
            fs.Write(BitConverter.GetBytes(Program.SaveFile.Header.Version));
            fs.Write(BitConverter.GetBytes(Program.SaveFile.Header.Padding1));
            fs.Write(BitConverter.GetBytes(Program.SaveFile.Header.Padding2));
            fs.Write(BitConverter.GetBytes(Program.SaveFile.Header.Padding3));

            for (int i = 0; i < Program.SaveFile.DecompressedChunks.Count; ++i)
            {
                // save file chunk ids start at 7001
                // file ID 7001 (save data) has unknown properties of 1 and 8
                // file ID 7002 (mods data, when save file comes from game version 1.61) has unknown properties of 1 and 1
                CompressedSaveChunk compressedSaveChunk = new CompressedSaveChunk(Program.SaveFile.DecompressedChunks[i], new CompressedChunkHeader{Id = 7001 + i, Unk1 = 1, Unk2 = (Int16)(i == 0 ? 8 : 1)});  
                fs.Write(BitConverter.GetBytes(compressedSaveChunk.Header.Id));                                                                                                                                                                                                                                                                                                       
                fs.Write(BitConverter.GetBytes(compressedSaveChunk.Header.Unk1));
                fs.Write(BitConverter.GetBytes(compressedSaveChunk.Header.CompressedSize));
                fs.Write(BitConverter.GetBytes(compressedSaveChunk.Header.Unk2));
                fs.Write(BitConverter.GetBytes(compressedSaveChunk.Header.DecompressedSize));
                fs.Write(compressedSaveChunk.Data);
            }

            fs.Close();

            MessageBox.Show("Save file written successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
