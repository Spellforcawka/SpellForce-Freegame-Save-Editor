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
    }
}
