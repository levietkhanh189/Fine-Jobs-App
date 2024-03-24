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
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            SalaryTextbox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            SkillTextBox = new MaterialSkin.Controls.MaterialTextBox();
            AddSkillBtn = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            SkillText = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel5.Location = new Point(17, 10);
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
            JobNameTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            JobNameTextbox.LeadingIcon = null;
            JobNameTextbox.Location = new Point(17, 32);
            JobNameTextbox.MaxLength = 50;
            JobNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            JobNameTextbox.Multiline = false;
            JobNameTextbox.Name = "JobNameTextbox";
            JobNameTextbox.Size = new Size(296, 50);
            JobNameTextbox.TabIndex = 25;
            JobNameTextbox.Text = "Enter job name";
            JobNameTextbox.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(405, 354);
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
            SaveButton.Location = new Point(505, 833);
            SaveButton.Margin = new Padding(4, 6, 4, 6);
            SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            SaveButton.Name = "SaveButton";
            SaveButton.NoAccentTextColor = Color.Empty;
            SaveButton.Size = new Size(247, 43);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "Save";
            SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveButton.UseAccentColor = true;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(17, 638);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(60, 17);
            materialLabel1.TabIndex = 27;
            materialLabel1.Text = "Job Type";
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Part-Time", "Full-Time" });
            materialComboBox1.Location = new Point(17, 658);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(134, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 28;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(187, 635);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(57, 17);
            materialLabel2.TabIndex = 30;
            materialLabel2.Text = "Location";
            // 
            // materialTextBox1
            // 
            materialTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 4.8F);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(187, 657);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(296, 50);
            materialTextBox1.TabIndex = 29;
            materialTextBox1.Text = "Enter location";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(384, 10);
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
            SalaryTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            SalaryTextbox.LeadingIcon = null;
            SalaryTextbox.Location = new Point(384, 32);
            SalaryTextbox.MaxLength = 50;
            SalaryTextbox.MouseState = MaterialSkin.MouseState.OUT;
            SalaryTextbox.Multiline = false;
            SalaryTextbox.Name = "SalaryTextbox";
            SalaryTextbox.Size = new Size(182, 50);
            SalaryTextbox.TabIndex = 31;
            SalaryTextbox.Text = "10.000.000-50.000.000";
            SalaryTextbox.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel6.Location = new Point(17, 96);
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
            SkillTextBox.Font = new Font("Microsoft Sans Serif", 4.8F);
            SkillTextBox.LeadingIcon = null;
            SkillTextBox.Location = new Point(17, 118);
            SkillTextBox.MaxLength = 50;
            SkillTextBox.MouseState = MaterialSkin.MouseState.OUT;
            SkillTextBox.Multiline = false;
            SkillTextBox.Name = "SkillTextBox";
            SkillTextBox.Size = new Size(94, 50);
            SkillTextBox.TabIndex = 33;
            SkillTextBox.Text = "Enter here";
            SkillTextBox.TrailingIcon = null;
            // 
            // AddSkillBtn
            // 
            AddSkillBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddSkillBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddSkillBtn.Depth = 0;
            AddSkillBtn.HighEmphasis = true;
            AddSkillBtn.Icon = null;
            AddSkillBtn.Location = new Point(152, 132);
            AddSkillBtn.Margin = new Padding(4, 6, 4, 6);
            AddSkillBtn.MouseState = MaterialSkin.MouseState.HOVER;
            AddSkillBtn.Name = "AddSkillBtn";
            AddSkillBtn.NoAccentTextColor = Color.Empty;
            AddSkillBtn.Size = new Size(92, 36);
            AddSkillBtn.TabIndex = 35;
            AddSkillBtn.Text = "Add Skill";
            AddSkillBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddSkillBtn.UseAccentColor = false;
            AddSkillBtn.UseVisualStyleBackColor = true;
            AddSkillBtn.Click += AddSkillBtn_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialMultiLineTextBox1);
            materialCard1.Controls.Add(materialLabel7);
            materialCard1.Controls.Add(materialCard2);
            materialCard1.Controls.Add(AddSkillBtn);
            materialCard1.Controls.Add(materialLabel6);
            materialCard1.Controls.Add(SkillTextBox);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(SalaryTextbox);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialTextBox1);
            materialCard1.Controls.Add(materialComboBox1);
            materialCard1.Controls.Add(materialLabel1);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(JobNameTextbox);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(26, 84);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(717, 729);
            materialCard1.TabIndex = 36;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(SkillText);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(288, 118);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(351, 50);
            materialCard2.TabIndex = 36;
            // 
            // SkillText
            // 
            SkillText.AutoSize = true;
            SkillText.Depth = 0;
            SkillText.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            SkillText.Location = new Point(17, 17);
            SkillText.MouseState = MaterialSkin.MouseState.HOVER;
            SkillText.Name = "SkillText";
            SkillText.Size = new Size(203, 19);
            SkillText.TabIndex = 0;
            SkillText.Text = "You need to add direct skills.";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel7.Location = new Point(17, 189);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(74, 17);
            materialLabel7.TabIndex = 37;
            materialLabel7.Text = "Description";
            // 
            // materialMultiLineTextBox1
            // 
            materialMultiLineTextBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialMultiLineTextBox1.BorderStyle = BorderStyle.None;
            materialMultiLineTextBox1.Depth = 0;
            materialMultiLineTextBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialMultiLineTextBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialMultiLineTextBox1.Location = new Point(17, 209);
            materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            materialMultiLineTextBox1.Size = new Size(645, 423);
            materialMultiLineTextBox1.TabIndex = 38;
            materialMultiLineTextBox1.Text = "";
            // 
            // CPNCreateNewJob
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 897);
            Controls.Add(materialCard1);
            Controls.Add(SaveButton);
            Name = "CPNCreateNewJob";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Job Infomation";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox JobNameTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox SalaryTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox SkillTextBox;
        private MaterialSkin.Controls.MaterialButton AddSkillBtn;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel SkillText;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}