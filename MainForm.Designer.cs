namespace SFSE
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
            OpenFileDialog = new OpenFileDialog();
            OpenFileButton = new Button();
            LevelLabel = new Label();
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
            AbilityTypeListBox = new ListBox();
            AbilitySubtypeListBox = new ListBox();
            AbilitySlotListBox = new ListBox();
            AbilityLevelListBox = new ListBox();
            AbilitySlotLabel = new Label();
            AbilityTypeLabel = new Label();
            AbilitySubtypeLabel = new Label();
            AbilityLevelLabel = new Label();
            FreeAbilityPointsTextBox = new TextBox();
            FreeAbilityPointsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LevelProgressTrackBar).BeginInit();
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
            OpenFileButton.Size = new Size(98, 23);
            OpenFileButton.TabIndex = 0;
            OpenFileButton.Text = "Open save file...";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFile_Click;
            // 
            // LevelLabel
            // 
            LevelLabel.AutoSize = true;
            LevelLabel.Location = new Point(66, 67);
            LevelLabel.Name = "LevelLabel";
            LevelLabel.Size = new Size(37, 15);
            LevelLabel.TabIndex = 1;
            LevelLabel.Text = "Level:";
            // 
            // LevelTextBox
            // 
            LevelTextBox.Enabled = false;
            LevelTextBox.Location = new Point(109, 64);
            LevelTextBox.MaxLength = 2;
            LevelTextBox.Name = "LevelTextBox";
            LevelTextBox.Size = new Size(28, 23);
            LevelTextBox.TabIndex = 2;
            // 
            // LevelProgressTrackBar
            // 
            LevelProgressTrackBar.BackColor = Color.Black;
            LevelProgressTrackBar.Enabled = false;
            LevelProgressTrackBar.LargeChange = 25;
            LevelProgressTrackBar.Location = new Point(143, 55);
            LevelProgressTrackBar.Maximum = 100;
            LevelProgressTrackBar.Name = "LevelProgressTrackBar";
            LevelProgressTrackBar.Size = new Size(155, 45);
            LevelProgressTrackBar.SmallChange = 25;
            LevelProgressTrackBar.TabIndex = 4;
            LevelProgressTrackBar.TickFrequency = 25;
            LevelProgressTrackBar.TickStyle = TickStyle.Both;
            // 
            // AgilityLabel
            // 
            AgilityLabel.AutoSize = true;
            AgilityLabel.Location = new Point(59, 197);
            AgilityLabel.Name = "AgilityLabel";
            AgilityLabel.Size = new Size(44, 15);
            AgilityLabel.TabIndex = 5;
            AgilityLabel.Text = "Agility:";
            // 
            // AgilityTextBox
            // 
            AgilityTextBox.Enabled = false;
            AgilityTextBox.Location = new Point(109, 194);
            AgilityTextBox.MaxLength = 3;
            AgilityTextBox.Name = "AgilityTextBox";
            AgilityTextBox.Size = new Size(28, 23);
            AgilityTextBox.TabIndex = 6;
            // 
            // CharismaTextBox
            // 
            CharismaTextBox.Enabled = false;
            CharismaTextBox.Location = new Point(109, 281);
            CharismaTextBox.MaxLength = 3;
            CharismaTextBox.Name = "CharismaTextBox";
            CharismaTextBox.Size = new Size(28, 23);
            CharismaTextBox.TabIndex = 8;
            // 
            // CharismaLabel
            // 
            CharismaLabel.AutoSize = true;
            CharismaLabel.Location = new Point(43, 284);
            CharismaLabel.Name = "CharismaLabel";
            CharismaLabel.Size = new Size(60, 15);
            CharismaLabel.TabIndex = 7;
            CharismaLabel.Text = "Charisma:";
            // 
            // DexterityTextBox
            // 
            DexterityTextBox.Enabled = false;
            DexterityTextBox.Location = new Point(109, 165);
            DexterityTextBox.MaxLength = 3;
            DexterityTextBox.Name = "DexterityTextBox";
            DexterityTextBox.Size = new Size(28, 23);
            DexterityTextBox.TabIndex = 10;
            // 
            // DexterityLabel
            // 
            DexterityLabel.AutoSize = true;
            DexterityLabel.Location = new Point(46, 168);
            DexterityLabel.Name = "DexterityLabel";
            DexterityLabel.Size = new Size(57, 15);
            DexterityLabel.TabIndex = 9;
            DexterityLabel.Text = "Dexterity:";
            // 
            // IntelligenceTextBox
            // 
            IntelligenceTextBox.Enabled = false;
            IntelligenceTextBox.Location = new Point(109, 223);
            IntelligenceTextBox.MaxLength = 3;
            IntelligenceTextBox.Name = "IntelligenceTextBox";
            IntelligenceTextBox.Size = new Size(28, 23);
            IntelligenceTextBox.TabIndex = 12;
            // 
            // IntelligenceLabel
            // 
            IntelligenceLabel.AutoSize = true;
            IntelligenceLabel.Location = new Point(32, 226);
            IntelligenceLabel.Name = "IntelligenceLabel";
            IntelligenceLabel.Size = new Size(71, 15);
            IntelligenceLabel.TabIndex = 11;
            IntelligenceLabel.Text = "Intelligence:";
            // 
            // StaminaTextBox
            // 
            StaminaTextBox.Enabled = false;
            StaminaTextBox.Location = new Point(109, 136);
            StaminaTextBox.MaxLength = 3;
            StaminaTextBox.Name = "StaminaTextBox";
            StaminaTextBox.Size = new Size(28, 23);
            StaminaTextBox.TabIndex = 14;
            // 
            // StaminaLabel
            // 
            StaminaLabel.AutoSize = true;
            StaminaLabel.Location = new Point(50, 139);
            StaminaLabel.Name = "StaminaLabel";
            StaminaLabel.Size = new Size(53, 15);
            StaminaLabel.TabIndex = 13;
            StaminaLabel.Text = "Stamina:";
            // 
            // StrengthTextBox
            // 
            StrengthTextBox.Enabled = false;
            StrengthTextBox.Location = new Point(109, 107);
            StrengthTextBox.MaxLength = 3;
            StrengthTextBox.Name = "StrengthTextBox";
            StrengthTextBox.Size = new Size(28, 23);
            StrengthTextBox.TabIndex = 16;
            // 
            // StrengthLabel
            // 
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point(48, 110);
            StrengthLabel.Name = "StrengthLabel";
            StrengthLabel.Size = new Size(55, 15);
            StrengthLabel.TabIndex = 15;
            StrengthLabel.Text = "Strength:";
            // 
            // WisdomTextBox
            // 
            WisdomTextBox.Enabled = false;
            WisdomTextBox.Location = new Point(109, 252);
            WisdomTextBox.MaxLength = 3;
            WisdomTextBox.Name = "WisdomTextBox";
            WisdomTextBox.Size = new Size(28, 23);
            WisdomTextBox.TabIndex = 18;
            // 
            // WisdomLabel
            // 
            WisdomLabel.AutoSize = true;
            WisdomLabel.Location = new Point(49, 255);
            WisdomLabel.Name = "WisdomLabel";
            WisdomLabel.Size = new Size(54, 15);
            WisdomLabel.TabIndex = 17;
            WisdomLabel.Text = "Wisdom:";
            // 
            // FreeStatPointsTextBox
            // 
            FreeStatPointsTextBox.Enabled = false;
            FreeStatPointsTextBox.Location = new Point(109, 310);
            FreeStatPointsTextBox.MaxLength = 3;
            FreeStatPointsTextBox.Name = "FreeStatPointsTextBox";
            FreeStatPointsTextBox.Size = new Size(28, 23);
            FreeStatPointsTextBox.TabIndex = 20;
            // 
            // FreeStatPointsLabel
            // 
            FreeStatPointsLabel.AutoSize = true;
            FreeStatPointsLabel.Location = new Point(12, 313);
            FreeStatPointsLabel.Name = "FreeStatPointsLabel";
            FreeStatPointsLabel.Size = new Size(91, 15);
            FreeStatPointsLabel.TabIndex = 19;
            FreeStatPointsLabel.Text = "Free Stat Points:";
            // 
            // AbilityTypeListBox
            // 
            AbilityTypeListBox.FormattingEnabled = true;
            AbilityTypeListBox.ItemHeight = 15;
            AbilityTypeListBox.Location = new Point(48, 399);
            AbilityTypeListBox.Name = "AbilityTypeListBox";
            AbilityTypeListBox.Size = new Size(114, 199);
            AbilityTypeListBox.TabIndex = 0;
            AbilityTypeListBox.SelectedIndexChanged += AbilityTypeListBox_SelectedIndexChanged;
            // 
            // AbilitySubtypeListBox
            // 
            AbilitySubtypeListBox.FormattingEnabled = true;
            AbilitySubtypeListBox.ItemHeight = 15;
            AbilitySubtypeListBox.Location = new Point(168, 399);
            AbilitySubtypeListBox.Name = "AbilitySubtypeListBox";
            AbilitySubtypeListBox.Size = new Size(118, 199);
            AbilitySubtypeListBox.TabIndex = 21;
            // 
            // AbilitySlotListBox
            // 
            AbilitySlotListBox.Enabled = false;
            AbilitySlotListBox.FormattingEnabled = true;
            AbilitySlotListBox.ItemHeight = 15;
            AbilitySlotListBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            AbilitySlotListBox.Location = new Point(12, 399);
            AbilitySlotListBox.Name = "AbilitySlotListBox";
            AbilitySlotListBox.Size = new Size(30, 199);
            AbilitySlotListBox.TabIndex = 22;
            AbilitySlotListBox.SelectedIndexChanged += AbilitySlotListBox_SelectedIndexChanged;
            // 
            // AbilityLevelListBox
            // 
            AbilityLevelListBox.Enabled = false;
            AbilityLevelListBox.FormattingEnabled = true;
            AbilityLevelListBox.ItemHeight = 15;
            AbilityLevelListBox.Location = new Point(292, 399);
            AbilityLevelListBox.Name = "AbilityLevelListBox";
            AbilityLevelListBox.Size = new Size(44, 199);
            AbilityLevelListBox.TabIndex = 23;
            // 
            // AbilitySlotLabel
            // 
            AbilitySlotLabel.AutoSize = true;
            AbilitySlotLabel.Location = new Point(12, 381);
            AbilitySlotLabel.Name = "AbilitySlotLabel";
            AbilitySlotLabel.Size = new Size(30, 15);
            AbilitySlotLabel.TabIndex = 24;
            AbilitySlotLabel.Text = "Slot:";
            // 
            // AbilityTypeLabel
            // 
            AbilityTypeLabel.AutoSize = true;
            AbilityTypeLabel.Location = new Point(48, 381);
            AbilityTypeLabel.Name = "AbilityTypeLabel";
            AbilityTypeLabel.Size = new Size(34, 15);
            AbilityTypeLabel.TabIndex = 25;
            AbilityTypeLabel.Text = "Type:";
            // 
            // AbilitySubtypeLabel
            // 
            AbilitySubtypeLabel.AutoSize = true;
            AbilitySubtypeLabel.Location = new Point(168, 381);
            AbilitySubtypeLabel.Name = "AbilitySubtypeLabel";
            AbilitySubtypeLabel.Size = new Size(53, 15);
            AbilitySubtypeLabel.TabIndex = 26;
            AbilitySubtypeLabel.Text = "Subtype:";
            // 
            // AbilityLevelLabel
            // 
            AbilityLevelLabel.AutoSize = true;
            AbilityLevelLabel.Location = new Point(292, 381);
            AbilityLevelLabel.Name = "AbilityLevelLabel";
            AbilityLevelLabel.Size = new Size(37, 15);
            AbilityLevelLabel.TabIndex = 27;
            AbilityLevelLabel.Text = "Level:";
            // 
            // FreeAbilityPointsTextBox
            // 
            FreeAbilityPointsTextBox.Enabled = false;
            FreeAbilityPointsTextBox.Location = new Point(123, 604);
            FreeAbilityPointsTextBox.MaxLength = 3;
            FreeAbilityPointsTextBox.Name = "FreeAbilityPointsTextBox";
            FreeAbilityPointsTextBox.Size = new Size(28, 23);
            FreeAbilityPointsTextBox.TabIndex = 29;
            // 
            // FreeAbilityPointsLabel
            // 
            FreeAbilityPointsLabel.AutoSize = true;
            FreeAbilityPointsLabel.Location = new Point(12, 607);
            FreeAbilityPointsLabel.Name = "FreeAbilityPointsLabel";
            FreeAbilityPointsLabel.Size = new Size(105, 15);
            FreeAbilityPointsLabel.TabIndex = 28;
            FreeAbilityPointsLabel.Text = "Free Ability Points:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(348, 638);
            Controls.Add(FreeAbilityPointsTextBox);
            Controls.Add(FreeAbilityPointsLabel);
            Controls.Add(AbilityLevelLabel);
            Controls.Add(AbilitySubtypeLabel);
            Controls.Add(AbilityTypeLabel);
            Controls.Add(AbilitySlotLabel);
            Controls.Add(AbilityLevelListBox);
            Controls.Add(AbilitySlotListBox);
            Controls.Add(AbilitySubtypeListBox);
            Controls.Add(AbilityTypeListBox);
            Controls.Add(FreeStatPointsTextBox);
            Controls.Add(FreeStatPointsLabel);
            Controls.Add(WisdomTextBox);
            Controls.Add(WisdomLabel);
            Controls.Add(StrengthTextBox);
            Controls.Add(StrengthLabel);
            Controls.Add(StaminaTextBox);
            Controls.Add(StaminaLabel);
            Controls.Add(IntelligenceTextBox);
            Controls.Add(IntelligenceLabel);
            Controls.Add(DexterityTextBox);
            Controls.Add(DexterityLabel);
            Controls.Add(CharismaTextBox);
            Controls.Add(CharismaLabel);
            Controls.Add(AgilityTextBox);
            Controls.Add(AgilityLabel);
            Controls.Add(LevelProgressTrackBar);
            Controls.Add(LevelTextBox);
            Controls.Add(LevelLabel);
            Controls.Add(OpenFileButton);
            ForeColor = Color.White;
            Name = "MainForm";
            Text = "SpellForce Freegame Save Editor";
            ((System.ComponentModel.ISupportInitialize)LevelProgressTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog OpenFileDialog;
        private Button OpenFileButton;
        private Label LevelLabel;
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
        private ListBox AbilityTypeListBox;
        private ListBox AbilitySubtypeListBox;
        private ListBox AbilitySlotListBox;
        private ListBox AbilityLevelListBox;
        private Label AbilitySlotLabel;
        private Label AbilityTypeLabel;
        private Label AbilitySubtypeLabel;
        private Label AbilityLevelLabel;
        private TextBox FreeAbilityPointsTextBox;
        private Label FreeAbilityPointsLabel;
    }
}
