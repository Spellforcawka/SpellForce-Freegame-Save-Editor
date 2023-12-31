﻿namespace SFSE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            OpenFileDialog = new OpenFileDialog();
            OpenFileButton = new Button();
            LevelTextBox = new TextBox();
            LevelProgressTrackBar = new TrackBar();
            AgilityLabel = new Label();
            AgilityTextBox = new TextBox();
            CharismaTextBox = new TextBox();
            CharismaLabel = new Label();
            DexterityTextBox = new TextBox();
            DexterityLabel = new Label();
            IntelligenceTextBox = new TextBox();
            IntelligenceLabel = new Label();
            StaminaTextBox = new TextBox();
            StaminaLabel = new Label();
            StrengthTextBox = new TextBox();
            StrengthLabel = new Label();
            WisdomTextBox = new TextBox();
            WisdomLabel = new Label();
            FreeStatPointsTextBox = new TextBox();
            FreeStatPointsLabel = new Label();
            GoldTextBox = new TextBox();
            GoldLabel = new Label();
            SilverTextBox = new TextBox();
            SilverLabel = new Label();
            CopperTextBox = new TextBox();
            CopperLabel = new Label();
            AbilitiesGroupBox = new GroupBox();
            FreeAbilityPointsTextBox = new TextBox();
            FreeAbilityPointsLabel = new Label();
            AbilityLevelLabel = new Label();
            AbilitySubtypeLabel = new Label();
            AbilityTypeLabel = new Label();
            AbilitySlotLabel = new Label();
            AbilityLevelListBox = new ListBox();
            AbilitySlotListBox = new ListBox();
            AbilitySubtypeListBox = new ListBox();
            AbilityTypeListBox = new ListBox();
            StatPointsGroupBox = new GroupBox();
            MoneyGroupBox = new GroupBox();
            LevelGroupBox = new GroupBox();
            AvatarInfoGroupBox = new GroupBox();
            SaveDateContentLabel = new Label();
            AvatarModelContentLabel = new Label();
            AvatarModelLabel = new Label();
            SaveDateLabel = new Label();
            AvatarSexContentLabel = new Label();
            AvatarSexLabel = new Label();
            AvatarNameContentLabel = new Label();
            AvatarNameLabel = new Label();
            ValidateAvatarButton = new Button();
            SaveFileButton = new Button();
            MiscellaneousGroupBox = new GroupBox();
            BypassValidationCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)LevelProgressTrackBar).BeginInit();
            AbilitiesGroupBox.SuspendLayout();
            StatPointsGroupBox.SuspendLayout();
            MoneyGroupBox.SuspendLayout();
            LevelGroupBox.SuspendLayout();
            AvatarInfoGroupBox.SuspendLayout();
            MiscellaneousGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.Filter = "SpellForce Save File|*.sav";
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SpellForce\SAVE\CHAR";
            OpenFileDialog.FileOk += OpenFileDialog_FileOk;
            // 
            // OpenFileButton
            // 
            OpenFileButton.ForeColor = Color.Black;
            OpenFileButton.Location = new Point(12, 12);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(112, 23);
            OpenFileButton.TabIndex = 0;
            OpenFileButton.Text = "Open save file...";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFile_Click;
            // 
            // LevelTextBox
            // 
            LevelTextBox.Enabled = false;
            LevelTextBox.Location = new Point(6, 31);
            LevelTextBox.MaxLength = 2;
            LevelTextBox.Name = "LevelTextBox";
            LevelTextBox.Size = new Size(28, 23);
            LevelTextBox.TabIndex = 0;
            LevelTextBox.Leave += LevelTextBox_Leave;
            // 
            // LevelProgressTrackBar
            // 
            LevelProgressTrackBar.BackColor = Color.Black;
            LevelProgressTrackBar.Enabled = false;
            LevelProgressTrackBar.LargeChange = 25;
            LevelProgressTrackBar.Location = new Point(40, 22);
            LevelProgressTrackBar.Maximum = 100;
            LevelProgressTrackBar.Name = "LevelProgressTrackBar";
            LevelProgressTrackBar.Size = new Size(159, 45);
            LevelProgressTrackBar.SmallChange = 25;
            LevelProgressTrackBar.TabIndex = 1;
            LevelProgressTrackBar.TickFrequency = 25;
            LevelProgressTrackBar.TickStyle = TickStyle.Both;
            LevelProgressTrackBar.Leave += LevelProgressTrackBar_Leave;
            // 
            // AgilityLabel
            // 
            AgilityLabel.AutoSize = true;
            AgilityLabel.Location = new Point(53, 111);
            AgilityLabel.Name = "AgilityLabel";
            AgilityLabel.Size = new Size(44, 15);
            AgilityLabel.TabIndex = 6;
            AgilityLabel.Text = "Agility:";
            // 
            // AgilityTextBox
            // 
            AgilityTextBox.Enabled = false;
            AgilityTextBox.Location = new Point(103, 108);
            AgilityTextBox.MaxLength = 3;
            AgilityTextBox.Name = "AgilityTextBox";
            AgilityTextBox.Size = new Size(28, 23);
            AgilityTextBox.TabIndex = 7;
            AgilityTextBox.Leave += AgilityTextBox_Leave;
            // 
            // CharismaTextBox
            // 
            CharismaTextBox.Enabled = false;
            CharismaTextBox.Location = new Point(103, 195);
            CharismaTextBox.MaxLength = 3;
            CharismaTextBox.Name = "CharismaTextBox";
            CharismaTextBox.Size = new Size(28, 23);
            CharismaTextBox.TabIndex = 13;
            CharismaTextBox.Leave += CharismaTextBox_Leave;
            // 
            // CharismaLabel
            // 
            CharismaLabel.AutoSize = true;
            CharismaLabel.Location = new Point(37, 198);
            CharismaLabel.Name = "CharismaLabel";
            CharismaLabel.Size = new Size(60, 15);
            CharismaLabel.TabIndex = 12;
            CharismaLabel.Text = "Charisma:";
            // 
            // DexterityTextBox
            // 
            DexterityTextBox.Enabled = false;
            DexterityTextBox.Location = new Point(103, 79);
            DexterityTextBox.MaxLength = 3;
            DexterityTextBox.Name = "DexterityTextBox";
            DexterityTextBox.Size = new Size(28, 23);
            DexterityTextBox.TabIndex = 5;
            DexterityTextBox.Leave += DexterityTextBox_Leave;
            // 
            // DexterityLabel
            // 
            DexterityLabel.AutoSize = true;
            DexterityLabel.Location = new Point(40, 82);
            DexterityLabel.Name = "DexterityLabel";
            DexterityLabel.Size = new Size(57, 15);
            DexterityLabel.TabIndex = 4;
            DexterityLabel.Text = "Dexterity:";
            // 
            // IntelligenceTextBox
            // 
            IntelligenceTextBox.Enabled = false;
            IntelligenceTextBox.Location = new Point(103, 137);
            IntelligenceTextBox.MaxLength = 3;
            IntelligenceTextBox.Name = "IntelligenceTextBox";
            IntelligenceTextBox.Size = new Size(28, 23);
            IntelligenceTextBox.TabIndex = 9;
            IntelligenceTextBox.Leave += IntelligenceTextBox_Leave;
            // 
            // IntelligenceLabel
            // 
            IntelligenceLabel.AutoSize = true;
            IntelligenceLabel.Location = new Point(26, 140);
            IntelligenceLabel.Name = "IntelligenceLabel";
            IntelligenceLabel.Size = new Size(71, 15);
            IntelligenceLabel.TabIndex = 8;
            IntelligenceLabel.Text = "Intelligence:";
            // 
            // StaminaTextBox
            // 
            StaminaTextBox.Enabled = false;
            StaminaTextBox.Location = new Point(103, 50);
            StaminaTextBox.MaxLength = 3;
            StaminaTextBox.Name = "StaminaTextBox";
            StaminaTextBox.Size = new Size(28, 23);
            StaminaTextBox.TabIndex = 3;
            StaminaTextBox.Leave += StaminaTextBox_Leave;
            // 
            // StaminaLabel
            // 
            StaminaLabel.AutoSize = true;
            StaminaLabel.Location = new Point(44, 53);
            StaminaLabel.Name = "StaminaLabel";
            StaminaLabel.Size = new Size(53, 15);
            StaminaLabel.TabIndex = 2;
            StaminaLabel.Text = "Stamina:";
            // 
            // StrengthTextBox
            // 
            StrengthTextBox.Enabled = false;
            StrengthTextBox.Location = new Point(103, 22);
            StrengthTextBox.MaxLength = 3;
            StrengthTextBox.Name = "StrengthTextBox";
            StrengthTextBox.Size = new Size(28, 23);
            StrengthTextBox.TabIndex = 1;
            StrengthTextBox.Leave += StrengthTextBox_Leave;
            // 
            // StrengthLabel
            // 
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point(42, 24);
            StrengthLabel.Name = "StrengthLabel";
            StrengthLabel.Size = new Size(55, 15);
            StrengthLabel.TabIndex = 0;
            StrengthLabel.Text = "Strength:";
            // 
            // WisdomTextBox
            // 
            WisdomTextBox.Enabled = false;
            WisdomTextBox.Location = new Point(103, 166);
            WisdomTextBox.MaxLength = 3;
            WisdomTextBox.Name = "WisdomTextBox";
            WisdomTextBox.Size = new Size(28, 23);
            WisdomTextBox.TabIndex = 11;
            WisdomTextBox.Leave += WisdomTextBox_Leave;
            // 
            // WisdomLabel
            // 
            WisdomLabel.AutoSize = true;
            WisdomLabel.Location = new Point(43, 169);
            WisdomLabel.Name = "WisdomLabel";
            WisdomLabel.Size = new Size(54, 15);
            WisdomLabel.TabIndex = 10;
            WisdomLabel.Text = "Wisdom:";
            // 
            // FreeStatPointsTextBox
            // 
            FreeStatPointsTextBox.Enabled = false;
            FreeStatPointsTextBox.Location = new Point(103, 244);
            FreeStatPointsTextBox.MaxLength = 3;
            FreeStatPointsTextBox.Name = "FreeStatPointsTextBox";
            FreeStatPointsTextBox.Size = new Size(28, 23);
            FreeStatPointsTextBox.TabIndex = 15;
            FreeStatPointsTextBox.Leave += FreeStatPointsTextBox_Leave;
            // 
            // FreeStatPointsLabel
            // 
            FreeStatPointsLabel.AutoSize = true;
            FreeStatPointsLabel.Location = new Point(6, 247);
            FreeStatPointsLabel.Name = "FreeStatPointsLabel";
            FreeStatPointsLabel.Size = new Size(91, 15);
            FreeStatPointsLabel.TabIndex = 14;
            FreeStatPointsLabel.Text = "Free Stat Points:";
            // 
            // GoldTextBox
            // 
            GoldTextBox.Enabled = false;
            GoldTextBox.Location = new Point(61, 22);
            GoldTextBox.MaxLength = 10;
            GoldTextBox.Name = "GoldTextBox";
            GoldTextBox.Size = new Size(138, 23);
            GoldTextBox.TabIndex = 1;
            GoldTextBox.Leave += GoldTextBox_Leave;
            // 
            // GoldLabel
            // 
            GoldLabel.AutoSize = true;
            GoldLabel.Location = new Point(20, 25);
            GoldLabel.Name = "GoldLabel";
            GoldLabel.Size = new Size(35, 15);
            GoldLabel.TabIndex = 0;
            GoldLabel.Text = "Gold:";
            // 
            // SilverTextBox
            // 
            SilverTextBox.Enabled = false;
            SilverTextBox.Location = new Point(61, 51);
            SilverTextBox.MaxLength = 10;
            SilverTextBox.Name = "SilverTextBox";
            SilverTextBox.Size = new Size(138, 23);
            SilverTextBox.TabIndex = 3;
            // 
            // SilverLabel
            // 
            SilverLabel.AutoSize = true;
            SilverLabel.Location = new Point(17, 54);
            SilverLabel.Name = "SilverLabel";
            SilverLabel.Size = new Size(38, 15);
            SilverLabel.TabIndex = 2;
            SilverLabel.Text = "Silver:";
            // 
            // CopperTextBox
            // 
            CopperTextBox.Enabled = false;
            CopperTextBox.Location = new Point(61, 80);
            CopperTextBox.MaxLength = 10;
            CopperTextBox.Name = "CopperTextBox";
            CopperTextBox.Size = new Size(138, 23);
            CopperTextBox.TabIndex = 5;
            // 
            // CopperLabel
            // 
            CopperLabel.AutoSize = true;
            CopperLabel.Location = new Point(6, 83);
            CopperLabel.Name = "CopperLabel";
            CopperLabel.Size = new Size(49, 15);
            CopperLabel.TabIndex = 4;
            CopperLabel.Text = "Copper:";
            // 
            // AbilitiesGroupBox
            // 
            AbilitiesGroupBox.BackColor = Color.Black;
            AbilitiesGroupBox.Controls.Add(FreeAbilityPointsTextBox);
            AbilitiesGroupBox.Controls.Add(FreeAbilityPointsLabel);
            AbilitiesGroupBox.Controls.Add(AbilityLevelLabel);
            AbilitiesGroupBox.Controls.Add(AbilitySubtypeLabel);
            AbilitiesGroupBox.Controls.Add(AbilityTypeLabel);
            AbilitiesGroupBox.Controls.Add(AbilitySlotLabel);
            AbilitiesGroupBox.Controls.Add(AbilityLevelListBox);
            AbilitiesGroupBox.Controls.Add(AbilitySlotListBox);
            AbilitiesGroupBox.Controls.Add(AbilitySubtypeListBox);
            AbilitiesGroupBox.Controls.Add(AbilityTypeListBox);
            AbilitiesGroupBox.ForeColor = Color.White;
            AbilitiesGroupBox.Location = new Point(12, 325);
            AbilitiesGroupBox.Name = "AbilitiesGroupBox";
            AbilitiesGroupBox.Size = new Size(348, 277);
            AbilitiesGroupBox.TabIndex = 4;
            AbilitiesGroupBox.TabStop = false;
            AbilitiesGroupBox.Text = "Abilities:";
            // 
            // FreeAbilityPointsTextBox
            // 
            FreeAbilityPointsTextBox.Enabled = false;
            FreeAbilityPointsTextBox.Location = new Point(117, 242);
            FreeAbilityPointsTextBox.MaxLength = 3;
            FreeAbilityPointsTextBox.Name = "FreeAbilityPointsTextBox";
            FreeAbilityPointsTextBox.Size = new Size(28, 23);
            FreeAbilityPointsTextBox.TabIndex = 9;
            FreeAbilityPointsTextBox.Leave += FreeAbilityPointsTextBox_Leave;
            // 
            // FreeAbilityPointsLabel
            // 
            FreeAbilityPointsLabel.AutoSize = true;
            FreeAbilityPointsLabel.Location = new Point(6, 245);
            FreeAbilityPointsLabel.Name = "FreeAbilityPointsLabel";
            FreeAbilityPointsLabel.Size = new Size(105, 15);
            FreeAbilityPointsLabel.TabIndex = 8;
            FreeAbilityPointsLabel.Text = "Free Ability Points:";
            // 
            // AbilityLevelLabel
            // 
            AbilityLevelLabel.AutoSize = true;
            AbilityLevelLabel.Location = new Point(286, 19);
            AbilityLevelLabel.Name = "AbilityLevelLabel";
            AbilityLevelLabel.Size = new Size(37, 15);
            AbilityLevelLabel.TabIndex = 6;
            AbilityLevelLabel.Text = "Level:";
            // 
            // AbilitySubtypeLabel
            // 
            AbilitySubtypeLabel.AutoSize = true;
            AbilitySubtypeLabel.Location = new Point(162, 19);
            AbilitySubtypeLabel.Name = "AbilitySubtypeLabel";
            AbilitySubtypeLabel.Size = new Size(53, 15);
            AbilitySubtypeLabel.TabIndex = 4;
            AbilitySubtypeLabel.Text = "Subtype:";
            // 
            // AbilityTypeLabel
            // 
            AbilityTypeLabel.AutoSize = true;
            AbilityTypeLabel.Location = new Point(42, 19);
            AbilityTypeLabel.Name = "AbilityTypeLabel";
            AbilityTypeLabel.Size = new Size(34, 15);
            AbilityTypeLabel.TabIndex = 2;
            AbilityTypeLabel.Text = "Type:";
            // 
            // AbilitySlotLabel
            // 
            AbilitySlotLabel.AutoSize = true;
            AbilitySlotLabel.Location = new Point(6, 19);
            AbilitySlotLabel.Name = "AbilitySlotLabel";
            AbilitySlotLabel.Size = new Size(30, 15);
            AbilitySlotLabel.TabIndex = 0;
            AbilitySlotLabel.Text = "Slot:";
            // 
            // AbilityLevelListBox
            // 
            AbilityLevelListBox.Enabled = false;
            AbilityLevelListBox.FormattingEnabled = true;
            AbilityLevelListBox.ItemHeight = 15;
            AbilityLevelListBox.Location = new Point(286, 37);
            AbilityLevelListBox.Name = "AbilityLevelListBox";
            AbilityLevelListBox.Size = new Size(44, 199);
            AbilityLevelListBox.TabIndex = 7;
            AbilityLevelListBox.Leave += AbilityLevelListBox_Leave;
            // 
            // AbilitySlotListBox
            // 
            AbilitySlotListBox.Enabled = false;
            AbilitySlotListBox.FormattingEnabled = true;
            AbilitySlotListBox.ItemHeight = 15;
            AbilitySlotListBox.Location = new Point(6, 37);
            AbilitySlotListBox.Name = "AbilitySlotListBox";
            AbilitySlotListBox.Size = new Size(30, 199);
            AbilitySlotListBox.TabIndex = 1;
            AbilitySlotListBox.SelectedIndexChanged += AbilitySlotListBox_SelectedIndexChanged;
            // 
            // AbilitySubtypeListBox
            // 
            AbilitySubtypeListBox.Enabled = false;
            AbilitySubtypeListBox.FormattingEnabled = true;
            AbilitySubtypeListBox.ItemHeight = 15;
            AbilitySubtypeListBox.Location = new Point(162, 37);
            AbilitySubtypeListBox.Name = "AbilitySubtypeListBox";
            AbilitySubtypeListBox.Size = new Size(118, 199);
            AbilitySubtypeListBox.TabIndex = 5;
            AbilitySubtypeListBox.Leave += AbilitySubtypeListBox_Leave;
            // 
            // AbilityTypeListBox
            // 
            AbilityTypeListBox.Enabled = false;
            AbilityTypeListBox.FormattingEnabled = true;
            AbilityTypeListBox.ItemHeight = 15;
            AbilityTypeListBox.Location = new Point(42, 37);
            AbilityTypeListBox.Name = "AbilityTypeListBox";
            AbilityTypeListBox.Size = new Size(114, 199);
            AbilityTypeListBox.TabIndex = 3;
            AbilityTypeListBox.SelectedIndexChanged += AbilityTypeListBox_SelectedIndexChanged;
            AbilityTypeListBox.Leave += AbilityTypeListBox_Leave;
            // 
            // StatPointsGroupBox
            // 
            StatPointsGroupBox.Controls.Add(StrengthTextBox);
            StatPointsGroupBox.Controls.Add(AgilityLabel);
            StatPointsGroupBox.Controls.Add(AgilityTextBox);
            StatPointsGroupBox.Controls.Add(CharismaLabel);
            StatPointsGroupBox.Controls.Add(CharismaTextBox);
            StatPointsGroupBox.Controls.Add(DexterityLabel);
            StatPointsGroupBox.Controls.Add(DexterityTextBox);
            StatPointsGroupBox.Controls.Add(IntelligenceLabel);
            StatPointsGroupBox.Controls.Add(FreeStatPointsTextBox);
            StatPointsGroupBox.Controls.Add(IntelligenceTextBox);
            StatPointsGroupBox.Controls.Add(FreeStatPointsLabel);
            StatPointsGroupBox.Controls.Add(StaminaLabel);
            StatPointsGroupBox.Controls.Add(WisdomTextBox);
            StatPointsGroupBox.Controls.Add(StaminaTextBox);
            StatPointsGroupBox.Controls.Add(WisdomLabel);
            StatPointsGroupBox.Controls.Add(StrengthLabel);
            StatPointsGroupBox.ForeColor = Color.White;
            StatPointsGroupBox.Location = new Point(223, 41);
            StatPointsGroupBox.Name = "StatPointsGroupBox";
            StatPointsGroupBox.Size = new Size(137, 278);
            StatPointsGroupBox.TabIndex = 1;
            StatPointsGroupBox.TabStop = false;
            StatPointsGroupBox.Text = "Stat points:";
            // 
            // MoneyGroupBox
            // 
            MoneyGroupBox.Controls.Add(GoldTextBox);
            MoneyGroupBox.Controls.Add(GoldLabel);
            MoneyGroupBox.Controls.Add(SilverLabel);
            MoneyGroupBox.Controls.Add(CopperTextBox);
            MoneyGroupBox.Controls.Add(SilverTextBox);
            MoneyGroupBox.Controls.Add(CopperLabel);
            MoneyGroupBox.ForeColor = Color.White;
            MoneyGroupBox.Location = new Point(12, 210);
            MoneyGroupBox.Name = "MoneyGroupBox";
            MoneyGroupBox.Size = new Size(205, 109);
            MoneyGroupBox.TabIndex = 3;
            MoneyGroupBox.TabStop = false;
            MoneyGroupBox.Text = "Money:";
            // 
            // LevelGroupBox
            // 
            LevelGroupBox.Controls.Add(LevelProgressTrackBar);
            LevelGroupBox.Controls.Add(LevelTextBox);
            LevelGroupBox.ForeColor = Color.White;
            LevelGroupBox.Location = new Point(12, 129);
            LevelGroupBox.Name = "LevelGroupBox";
            LevelGroupBox.Size = new Size(205, 73);
            LevelGroupBox.TabIndex = 2;
            LevelGroupBox.TabStop = false;
            LevelGroupBox.Text = "Level:";
            // 
            // AvatarInfoGroupBox
            // 
            AvatarInfoGroupBox.Controls.Add(SaveDateContentLabel);
            AvatarInfoGroupBox.Controls.Add(AvatarModelContentLabel);
            AvatarInfoGroupBox.Controls.Add(AvatarModelLabel);
            AvatarInfoGroupBox.Controls.Add(SaveDateLabel);
            AvatarInfoGroupBox.Controls.Add(AvatarSexContentLabel);
            AvatarInfoGroupBox.Controls.Add(AvatarSexLabel);
            AvatarInfoGroupBox.Controls.Add(AvatarNameContentLabel);
            AvatarInfoGroupBox.Controls.Add(AvatarNameLabel);
            AvatarInfoGroupBox.ForeColor = Color.White;
            AvatarInfoGroupBox.Location = new Point(12, 41);
            AvatarInfoGroupBox.Name = "AvatarInfoGroupBox";
            AvatarInfoGroupBox.Size = new Size(205, 82);
            AvatarInfoGroupBox.TabIndex = 7;
            AvatarInfoGroupBox.TabStop = false;
            AvatarInfoGroupBox.Text = "Avatar Info:";
            // 
            // SaveDateContentLabel
            // 
            SaveDateContentLabel.AutoSize = true;
            SaveDateContentLabel.Location = new Point(73, 64);
            SaveDateContentLabel.Name = "SaveDateContentLabel";
            SaveDateContentLabel.Size = new Size(0, 15);
            SaveDateContentLabel.TabIndex = 7;
            // 
            // AvatarModelContentLabel
            // 
            AvatarModelContentLabel.AutoSize = true;
            AvatarModelContentLabel.Location = new Point(73, 49);
            AvatarModelContentLabel.Name = "AvatarModelContentLabel";
            AvatarModelContentLabel.Size = new Size(0, 15);
            AvatarModelContentLabel.TabIndex = 5;
            // 
            // AvatarModelLabel
            // 
            AvatarModelLabel.AutoSize = true;
            AvatarModelLabel.Location = new Point(6, 49);
            AvatarModelLabel.Name = "AvatarModelLabel";
            AvatarModelLabel.Size = new Size(44, 15);
            AvatarModelLabel.TabIndex = 4;
            AvatarModelLabel.Text = "Model:";
            // 
            // SaveDateLabel
            // 
            SaveDateLabel.AutoSize = true;
            SaveDateLabel.Location = new Point(6, 64);
            SaveDateLabel.Name = "SaveDateLabel";
            SaveDateLabel.Size = new Size(61, 15);
            SaveDateLabel.TabIndex = 6;
            SaveDateLabel.Text = "Save Date:";
            // 
            // AvatarSexContentLabel
            // 
            AvatarSexContentLabel.AutoSize = true;
            AvatarSexContentLabel.Location = new Point(73, 34);
            AvatarSexContentLabel.Name = "AvatarSexContentLabel";
            AvatarSexContentLabel.Size = new Size(0, 15);
            AvatarSexContentLabel.TabIndex = 3;
            // 
            // AvatarSexLabel
            // 
            AvatarSexLabel.AutoSize = true;
            AvatarSexLabel.Location = new Point(6, 34);
            AvatarSexLabel.Name = "AvatarSexLabel";
            AvatarSexLabel.Size = new Size(28, 15);
            AvatarSexLabel.TabIndex = 2;
            AvatarSexLabel.Text = "Sex:";
            // 
            // AvatarNameContentLabel
            // 
            AvatarNameContentLabel.AutoSize = true;
            AvatarNameContentLabel.Location = new Point(73, 19);
            AvatarNameContentLabel.Name = "AvatarNameContentLabel";
            AvatarNameContentLabel.Size = new Size(0, 15);
            AvatarNameContentLabel.TabIndex = 1;
            // 
            // AvatarNameLabel
            // 
            AvatarNameLabel.AutoSize = true;
            AvatarNameLabel.Location = new Point(6, 19);
            AvatarNameLabel.Name = "AvatarNameLabel";
            AvatarNameLabel.Size = new Size(42, 15);
            AvatarNameLabel.TabIndex = 0;
            AvatarNameLabel.Text = "Name:";
            // 
            // ValidateAvatarButton
            // 
            ValidateAvatarButton.Enabled = false;
            ValidateAvatarButton.ForeColor = Color.Black;
            ValidateAvatarButton.Location = new Point(130, 12);
            ValidateAvatarButton.Name = "ValidateAvatarButton";
            ValidateAvatarButton.Size = new Size(112, 23);
            ValidateAvatarButton.TabIndex = 5;
            ValidateAvatarButton.Text = "Validate Avatar";
            ValidateAvatarButton.UseVisualStyleBackColor = true;
            ValidateAvatarButton.Click += ValidateAvatarButton_Click;
            // 
            // SaveFileButton
            // 
            SaveFileButton.Enabled = false;
            SaveFileButton.ForeColor = Color.Black;
            SaveFileButton.Location = new Point(248, 12);
            SaveFileButton.Name = "SaveFileButton";
            SaveFileButton.Size = new Size(112, 23);
            SaveFileButton.TabIndex = 6;
            SaveFileButton.Text = "Write to save file!";
            SaveFileButton.UseVisualStyleBackColor = true;
            SaveFileButton.Click += SaveFileButton_Click;
            // 
            // MiscellaneousGroupBox
            // 
            MiscellaneousGroupBox.Controls.Add(BypassValidationCheckBox);
            MiscellaneousGroupBox.ForeColor = Color.White;
            MiscellaneousGroupBox.Location = new Point(12, 608);
            MiscellaneousGroupBox.Name = "MiscellaneousGroupBox";
            MiscellaneousGroupBox.Size = new Size(349, 47);
            MiscellaneousGroupBox.TabIndex = 8;
            MiscellaneousGroupBox.TabStop = false;
            MiscellaneousGroupBox.Text = "Miscellaneous";
            // 
            // BypassValidationCheckBox
            // 
            BypassValidationCheckBox.AutoSize = true;
            BypassValidationCheckBox.Enabled = false;
            BypassValidationCheckBox.ForeColor = Color.White;
            BypassValidationCheckBox.Location = new Point(7, 22);
            BypassValidationCheckBox.Name = "BypassValidationCheckBox";
            BypassValidationCheckBox.Size = new Size(178, 19);
            BypassValidationCheckBox.TabIndex = 0;
            BypassValidationCheckBox.Text = "Bypass player data validation";
            BypassValidationCheckBox.UseVisualStyleBackColor = true;
            BypassValidationCheckBox.CheckedChanged += BypassValidationCheckBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(372, 667);
            Controls.Add(MiscellaneousGroupBox);
            Controls.Add(SaveFileButton);
            Controls.Add(ValidateAvatarButton);
            Controls.Add(AvatarInfoGroupBox);
            Controls.Add(LevelGroupBox);
            Controls.Add(MoneyGroupBox);
            Controls.Add(StatPointsGroupBox);
            Controls.Add(AbilitiesGroupBox);
            Controls.Add(OpenFileButton);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(388, 706);
            MinimumSize = new Size(388, 706);
            Name = "MainForm";
            Text = "SpellForce Freegame Save Editor";
            ((System.ComponentModel.ISupportInitialize)LevelProgressTrackBar).EndInit();
            AbilitiesGroupBox.ResumeLayout(false);
            AbilitiesGroupBox.PerformLayout();
            StatPointsGroupBox.ResumeLayout(false);
            StatPointsGroupBox.PerformLayout();
            MoneyGroupBox.ResumeLayout(false);
            MoneyGroupBox.PerformLayout();
            LevelGroupBox.ResumeLayout(false);
            LevelGroupBox.PerformLayout();
            AvatarInfoGroupBox.ResumeLayout(false);
            AvatarInfoGroupBox.PerformLayout();
            MiscellaneousGroupBox.ResumeLayout(false);
            MiscellaneousGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog OpenFileDialog;
        private Button OpenFileButton;
        private TextBox LevelTextBox;
        private TrackBar LevelProgressTrackBar;
        private Label AgilityLabel;
        private TextBox AgilityTextBox;
        private TextBox CharismaTextBox;
        private Label CharismaLabel;
        private TextBox DexterityTextBox;
        private Label DexterityLabel;
        private TextBox IntelligenceTextBox;
        private Label IntelligenceLabel;
        private TextBox StaminaTextBox;
        private Label StaminaLabel;
        private TextBox StrengthTextBox;
        private Label StrengthLabel;
        private TextBox WisdomTextBox;
        private Label WisdomLabel;
        private TextBox FreeStatPointsTextBox;
        private Label FreeStatPointsLabel;
        private TextBox GoldTextBox;
        private Label GoldLabel;
        private TextBox SilverTextBox;
        private Label SilverLabel;
        private TextBox CopperTextBox;
        private Label CopperLabel;
        private GroupBox AbilitiesGroupBox;
        private TextBox FreeAbilityPointsTextBox;
        private Label FreeAbilityPointsLabel;
        private Label AbilityLevelLabel;
        private Label AbilitySubtypeLabel;
        private Label AbilityTypeLabel;
        private Label AbilitySlotLabel;
        private ListBox AbilityLevelListBox;
        private ListBox AbilitySlotListBox;
        private ListBox AbilitySubtypeListBox;
        private ListBox AbilityTypeListBox;
        private GroupBox StatPointsGroupBox;
        private GroupBox MoneyGroupBox;
        private GroupBox LevelGroupBox;
        private GroupBox AvatarInfoGroupBox;
        private Label AvatarNameLabel;
        private Label AvatarModelContentLabel;
        private Label AvatarModelLabel;
        private Label SaveDateLabel;
        private Label AvatarSexContentLabel;
        private Label AvatarSexLabel;
        private Label AvatarNameContentLabel;
        private Label SaveDateContentLabel;
        private Button ValidateAvatarButton;
        private Button SaveFileButton;
        private GroupBox MiscellaneousGroupBox;
        private CheckBox BypassValidationCheckBox;
    }
}
