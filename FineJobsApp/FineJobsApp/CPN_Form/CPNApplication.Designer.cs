namespace FineJobsApp.CPN_Form
{
    partial class CPNApplication
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StatusBtn = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            StatusCombox = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            ResumeBtn = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            JobTittle = new MaterialSkin.Controls.MaterialLabel();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            Education = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            Experience = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            Skills = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ApplicationName = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // StatusBtn
            // 
            StatusBtn.AutoSize = false;
            StatusBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StatusBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            StatusBtn.Depth = 0;
            StatusBtn.HighEmphasis = true;
            StatusBtn.Icon = null;
            StatusBtn.Location = new Point(232, 95);
            StatusBtn.Margin = new Padding(4, 6, 4, 6);
            StatusBtn.MouseState = MaterialSkin.MouseState.HOVER;
            StatusBtn.Name = "StatusBtn";
            StatusBtn.NoAccentTextColor = Color.Empty;
            StatusBtn.Size = new Size(96, 48);
            StatusBtn.TabIndex = 1;
            StatusBtn.Text = "Change";
            StatusBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            StatusBtn.UseAccentColor = false;
            StatusBtn.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(102, 175);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(195, 44);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Contact";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = true;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            materialLabel2.HighEmphasis = true;
            materialLabel2.Location = new Point(54, 19);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(277, 41);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Application Status";
            materialLabel2.UseAccent = true;
            // 
            // StatusCombox
            // 
            StatusCombox.AutoResize = false;
            StatusCombox.BackColor = Color.FromArgb(255, 255, 255);
            StatusCombox.Depth = 0;
            StatusCombox.DrawMode = DrawMode.OwnerDrawVariable;
            StatusCombox.DropDownHeight = 174;
            StatusCombox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusCombox.DropDownWidth = 121;
            StatusCombox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            StatusCombox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            StatusCombox.FormattingEnabled = true;
            StatusCombox.IntegralHeight = false;
            StatusCombox.ItemHeight = 43;
            StatusCombox.Items.AddRange(new object[] { "New", "Pending", "Interview", "Accepted", "Rejected" });
            StatusCombox.Location = new Point(54, 95);
            StatusCombox.MaxDropDownItems = 4;
            StatusCombox.MouseState = MaterialSkin.MouseState.OUT;
            StatusCombox.Name = "StatusCombox";
            StatusCombox.Size = new Size(158, 49);
            StatusCombox.StartIndex = 0;
            StatusCombox.TabIndex = 2;
            StatusCombox.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(10, 7);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(83, 24);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Fullname";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.human;
            pictureBox2.Location = new Point(66, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 256);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialDivider1);
            materialCard1.Controls.Add(ResumeBtn);
            materialCard1.Controls.Add(materialButton2);
            materialCard1.Controls.Add(StatusBtn);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(StatusCombox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(880, 3);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(380, 297);
            materialCard1.TabIndex = 5;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(46, 72);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(303, 5);
            materialDivider1.TabIndex = 6;
            materialDivider1.Text = "materialDivider1";
            // 
            // ResumeBtn
            // 
            ResumeBtn.AutoSize = false;
            ResumeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResumeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ResumeBtn.Depth = 0;
            ResumeBtn.HighEmphasis = true;
            ResumeBtn.Icon = null;
            ResumeBtn.Location = new Point(102, 231);
            ResumeBtn.Margin = new Padding(4, 6, 4, 6);
            ResumeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ResumeBtn.Name = "ResumeBtn";
            ResumeBtn.NoAccentTextColor = Color.Empty;
            ResumeBtn.Size = new Size(195, 44);
            ResumeBtn.TabIndex = 5;
            ResumeBtn.Text = "Resume";
            ResumeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ResumeBtn.UseAccentColor = false;
            ResumeBtn.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(JobTittle);
            materialCard2.Controls.Add(materialCard3);
            materialCard2.Controls.Add(pictureBox2);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(5, 3);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(860, 297);
            materialCard2.TabIndex = 6;
            // 
            // JobTittle
            // 
            JobTittle.AutoSize = true;
            JobTittle.Depth = 0;
            JobTittle.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            JobTittle.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            JobTittle.HighEmphasis = true;
            JobTittle.Location = new Point(349, 19);
            JobTittle.MouseState = MaterialSkin.MouseState.HOVER;
            JobTittle.Name = "JobTittle";
            JobTittle.Size = new Size(235, 41);
            JobTittle.TabIndex = 12;
            JobTittle.Text = "Unity Developer";
            JobTittle.UseAccent = true;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(Education);
            materialCard3.Controls.Add(materialLabel8);
            materialCard3.Controls.Add(Experience);
            materialCard3.Controls.Add(materialLabel6);
            materialCard3.Controls.Add(Skills);
            materialCard3.Controls.Add(materialLabel4);
            materialCard3.Controls.Add(ApplicationName);
            materialCard3.Controls.Add(materialLabel1);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(349, 83);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(483, 214);
            materialCard3.TabIndex = 11;
            // 
            // Education
            // 
            Education.AutoSize = true;
            Education.Depth = 0;
            Education.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Education.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Education.Location = new Point(118, 156);
            Education.MouseState = MaterialSkin.MouseState.HOVER;
            Education.Name = "Education";
            Education.Size = new Size(330, 29);
            Education.TabIndex = 10;
            Education.Text = "Bachelor in Computer Science\t";
            Education.TextAlign = ContentAlignment.TopCenter;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel8.Location = new Point(10, 160);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(89, 24);
            materialLabel8.TabIndex = 9;
            materialLabel8.Text = "Education";
            // 
            // Experience
            // 
            Experience.AutoSize = true;
            Experience.Depth = 0;
            Experience.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Experience.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Experience.Location = new Point(118, 107);
            Experience.MouseState = MaterialSkin.MouseState.HOVER;
            Experience.Name = "Experience";
            Experience.Size = new Size(351, 29);
            Experience.TabIndex = 8;
            Experience.Text = "3 years as a software developer.\t";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel6.Location = new Point(10, 111);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(99, 24);
            materialLabel6.TabIndex = 7;
            materialLabel6.Text = "Experience";
            // 
            // Skills
            // 
            Skills.AutoSize = true;
            Skills.Depth = 0;
            Skills.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Skills.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Skills.Location = new Point(118, 55);
            Skills.MouseState = MaterialSkin.MouseState.HOVER;
            Skills.Name = "Skills";
            Skills.Size = new Size(197, 29);
            Skills.TabIndex = 6;
            Skills.Text = "\"C#\", \".NET\", \"SQL\"";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(10, 59);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(48, 24);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Skills";
            // 
            // ApplicationName
            // 
            ApplicationName.AutoSize = true;
            ApplicationName.Depth = 0;
            ApplicationName.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            ApplicationName.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            ApplicationName.Location = new Point(118, 3);
            ApplicationName.MouseState = MaterialSkin.MouseState.HOVER;
            ApplicationName.Name = "ApplicationName";
            ApplicationName.Size = new Size(150, 29);
            ApplicationName.TabIndex = 4;
            ApplicationName.Text = "Nguyen Van A";
            // 
            // CPNApplication
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "CPNApplication";
            Size = new Size(1274, 305);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton StatusBtn;
        private MaterialSkin.Controls.MaterialComboBox StatusCombox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialButton ResumeBtn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel Experience;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel Skills;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel ApplicationName;
        private MaterialSkin.Controls.MaterialLabel Education;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel JobTittle;
        private MaterialSkin.Controls.MaterialCard materialCard3;
    }
}
