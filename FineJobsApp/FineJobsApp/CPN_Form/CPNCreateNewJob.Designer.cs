namespace FineJobsApp.CPN_Form
{
    partial class CPNCreateNewJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            JobNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            SaveButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            JobType = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            LocationTextbox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            SalaryTextbox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            SkillTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            DescriptionTextbox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel5.Location = new Point(17, 10);
            materialLabel5.Margin = new Padding(2, 0, 2, 0);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(66, 17);
            materialLabel5.TabIndex = 26;
            materialLabel5.Text = "Job Name";
            // 
            // JobNameTextbox
            // 
            JobNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JobNameTextbox.AnimateReadOnly = false;
            JobNameTextbox.BorderStyle = BorderStyle.None;
            JobNameTextbox.Depth = 0;
            JobNameTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            JobNameTextbox.Hint = "Enter job name";
            JobNameTextbox.LeadingIcon = null;
            JobNameTextbox.Location = new Point(17, 33);
            JobNameTextbox.Margin = new Padding(2);
            JobNameTextbox.MaxLength = 50;
            JobNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            JobNameTextbox.Multiline = false;
            JobNameTextbox.Name = "JobNameTextbox";
            JobNameTextbox.Size = new Size(295, 50);
            JobNameTextbox.TabIndex = 25;
            JobNameTextbox.Text = "";
            JobNameTextbox.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(406, 355);
            materialLabel3.Margin = new Padding(2, 0, 2, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(1, 0);
            materialLabel3.TabIndex = 22;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top;
            SaveButton.AutoSize = false;
            SaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveButton.BackColor = SystemColors.ControlLight;
            SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            SaveButton.Depth = 0;
            SaveButton.HighEmphasis = false;
            SaveButton.Icon = null;
            SaveButton.Location = new Point(506, 832);
            SaveButton.Margin = new Padding(4, 6, 4, 6);
            SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaveButton.Name = "SaveButton";
            SaveButton.NoAccentTextColor = Color.Empty;
            SaveButton.Size = new Size(246, 43);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Save";
            SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveButton.UseAccentColor = true;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(17, 638);
            materialLabel1.Margin = new Padding(2, 0, 2, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(60, 17);
            materialLabel1.TabIndex = 27;
            materialLabel1.Text = "Job Type";
            // 
            // JobType
            // 
            JobType.AutoResize = false;
            JobType.BackColor = Color.FromArgb(255, 255, 255);
            JobType.Depth = 0;
            JobType.DrawMode = DrawMode.OwnerDrawVariable;
            JobType.DropDownHeight = 174;
            JobType.DropDownStyle = ComboBoxStyle.DropDownList;
            JobType.DropDownWidth = 121;
            JobType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            JobType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            JobType.FormattingEnabled = true;
            JobType.IntegralHeight = false;
            JobType.ItemHeight = 43;
            JobType.Items.AddRange(new object[] { "Part-Time", "Full-Time" });
            JobType.Location = new Point(17, 658);
            JobType.Margin = new Padding(2);
            JobType.MaxDropDownItems = 4;
            JobType.MouseState = MaterialSkin.MouseState.OUT;
            JobType.Name = "JobType";
            JobType.Size = new Size(134, 49);
            JobType.StartIndex = 0;
            JobType.TabIndex = 28;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(187, 636);
            materialLabel2.Margin = new Padding(2, 0, 2, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(57, 17);
            materialLabel2.TabIndex = 30;
            materialLabel2.Text = "Location";
            // 
            // LocationTextbox
            // 
            LocationTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LocationTextbox.AnimateReadOnly = false;
            LocationTextbox.BorderStyle = BorderStyle.None;
            LocationTextbox.Depth = 0;
            LocationTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LocationTextbox.Hint = "Enter location";
            LocationTextbox.LeadingIcon = null;
            LocationTextbox.Location = new Point(187, 656);
            LocationTextbox.Margin = new Padding(2);
            LocationTextbox.MaxLength = 50;
            LocationTextbox.MouseState = MaterialSkin.MouseState.OUT;
            LocationTextbox.Multiline = false;
            LocationTextbox.Name = "LocationTextbox";
            LocationTextbox.Size = new Size(295, 50);
            LocationTextbox.TabIndex = 29;
            LocationTextbox.Text = "";
            LocationTextbox.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(351, 10);
            materialLabel4.Margin = new Padding(2, 0, 2, 0);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(41, 17);
            materialLabel4.TabIndex = 32;
            materialLabel4.Text = "Salary";
            // 
            // SalaryTextbox
            // 
            SalaryTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalaryTextbox.AnimateReadOnly = false;
            SalaryTextbox.BorderStyle = BorderStyle.None;
            SalaryTextbox.Depth = 0;
            SalaryTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SalaryTextbox.Hint = "10.000.000-50.000.000";
            SalaryTextbox.LeadingIcon = null;
            SalaryTextbox.Location = new Point(351, 33);
            SalaryTextbox.Margin = new Padding(2);
            SalaryTextbox.MaxLength = 50;
            SalaryTextbox.MouseState = MaterialSkin.MouseState.OUT;
            SalaryTextbox.Multiline = false;
            SalaryTextbox.Name = "SalaryTextbox";
            SalaryTextbox.Size = new Size(183, 50);
            SalaryTextbox.TabIndex = 31;
            SalaryTextbox.Text = "";
            SalaryTextbox.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel6.Location = new Point(17, 96);
            materialLabel6.Margin = new Padding(2, 0, 2, 0);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(114, 17);
            materialLabel6.TabIndex = 34;
            materialLabel6.Text = "Skill Requirement";
            // 
            // SkillTextBox
            // 
            SkillTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SkillTextBox.AnimateReadOnly = false;
            SkillTextBox.BorderStyle = BorderStyle.None;
            SkillTextBox.Depth = 0;
            SkillTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SkillTextBox.Hint = "Enter here";
            SkillTextBox.LeadingIcon = null;
            SkillTextBox.Location = new Point(17, 119);
            SkillTextBox.Margin = new Padding(2);
            SkillTextBox.MaxLength = 50;
            SkillTextBox.MouseState = MaterialSkin.MouseState.OUT;
            SkillTextBox.Multiline = false;
            SkillTextBox.Name = "SkillTextBox";
            SkillTextBox.Size = new Size(676, 50);
            SkillTextBox.TabIndex = 33;
            SkillTextBox.Text = "";
            SkillTextBox.TrailingIcon = null;
            SkillTextBox.Click += SkillTextBox_Click;
            SkillTextBox.TextChanged += SkillTextBox_TextChanged;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(DescriptionTextbox);
            materialCard1.Controls.Add(materialLabel7);
            materialCard1.Controls.Add(materialLabel6);
            materialCard1.Controls.Add(SkillTextBox);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(SalaryTextbox);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(LocationTextbox);
            materialCard1.Controls.Add(JobType);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(JobNameTextbox);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(26, 84);
            materialCard1.Margin = new Padding(15, 14, 15, 14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(15, 14, 15, 14);
            materialCard1.Size = new Size(716, 730);
            materialCard1.TabIndex = 36;
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.AnimateReadOnly = false;
            DescriptionTextbox.BackgroundImageLayout = ImageLayout.None;
            DescriptionTextbox.CharacterCasing = CharacterCasing.Normal;
            DescriptionTextbox.Depth = 0;
            DescriptionTextbox.HideSelection = true;
            DescriptionTextbox.Hint = "Enter job description";
            DescriptionTextbox.Location = new Point(17, 223);
            DescriptionTextbox.Margin = new Padding(2);
            DescriptionTextbox.MaxLength = 32767;
            DescriptionTextbox.MouseState = MaterialSkin.MouseState.OUT;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.PasswordChar = '\0';
            DescriptionTextbox.ReadOnly = false;
            DescriptionTextbox.ScrollBars = ScrollBars.None;
            DescriptionTextbox.SelectedText = "";
            DescriptionTextbox.SelectionLength = 0;
            DescriptionTextbox.SelectionStart = 0;
            DescriptionTextbox.ShortcutsEnabled = true;
            DescriptionTextbox.Size = new Size(676, 410);
            DescriptionTextbox.TabIndex = 39;
            DescriptionTextbox.TabStop = false;
            DescriptionTextbox.TextAlign = HorizontalAlignment.Left;
            DescriptionTextbox.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel7.Location = new Point(17, 189);
            materialLabel7.Margin = new Padding(2, 0, 2, 0);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(74, 17);
            materialLabel7.TabIndex = 37;
            materialLabel7.Text = "Description";
            // 
            // CPNCreateNewJob
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 898);
            Controls.Add(materialCard1);
            Controls.Add(SaveButton);
            Margin = new Padding(2);
            Name = "CPNCreateNewJob";
            Padding = new Padding(2, 64, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Infomation";
            Load += CPNCreateNewJob_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox JobNameTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox JobType;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox LocationTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox SalaryTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox SkillTextBox;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 DescriptionTextbox;
    }
}