namespace FineJobsApp.CPN_Form
{
    partial class CPNApplicant
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            ResumeBtn = new MaterialSkin.Controls.MaterialButton();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            Education = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            Experience = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            Skills = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ApplicationName = new MaterialSkin.Controls.MaterialLabel();
            ContactBtn = new MaterialSkin.Controls.MaterialButton();
            StatusCombox = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
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
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(ResumeBtn);
            materialCard2.Controls.Add(materialCard3);
            materialCard2.Controls.Add(ContactBtn);
            materialCard2.Controls.Add(pictureBox2);
            materialCard2.Controls.Add(StatusCombox);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(5, 3);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1255, 297);
            materialCard2.TabIndex = 6;
            // 
            // ResumeBtn
            // 
            ResumeBtn.AutoSize = false;
            ResumeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ResumeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ResumeBtn.Depth = 0;
            ResumeBtn.HighEmphasis = true;
            ResumeBtn.Icon = null;
            ResumeBtn.Location = new Point(1003, 236);
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
            ResumeBtn.Click += ResumeBtn_Click;
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
            materialCard3.Location = new Point(339, 19);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(859, 214);
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
            // ContactBtn
            // 
            ContactBtn.AutoSize = false;
            ContactBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContactBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ContactBtn.Depth = 0;
            ContactBtn.HighEmphasis = true;
            ContactBtn.Icon = null;
            ContactBtn.Location = new Point(800, 236);
            ContactBtn.Margin = new Padding(4, 6, 4, 6);
            ContactBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ContactBtn.Name = "ContactBtn";
            ContactBtn.NoAccentTextColor = Color.Empty;
            ContactBtn.Size = new Size(195, 44);
            ContactBtn.TabIndex = 4;
            ContactBtn.Text = "Contact";
            ContactBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ContactBtn.UseAccentColor = true;
            ContactBtn.UseVisualStyleBackColor = true;
            ContactBtn.Click += ContactBtn_Click;
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
            StatusCombox.Items.AddRange(new object[] { "Normal", "Favorite", "Talent" });
            StatusCombox.Location = new Point(339, 231);
            StatusCombox.MaxDropDownItems = 4;
            StatusCombox.MouseState = MaterialSkin.MouseState.OUT;
            StatusCombox.Name = "StatusCombox";
            StatusCombox.Size = new Size(158, 49);
            StatusCombox.StartIndex = 0;
            StatusCombox.TabIndex = 2;
            StatusCombox.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // CPNApplicant
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard2);
            Name = "CPNApplicant";
            Size = new Size(1274, 305);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            materialCard2.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel Experience;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel Skills;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel ApplicationName;
        private MaterialSkin.Controls.MaterialLabel Education;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton ResumeBtn;
        private MaterialSkin.Controls.MaterialButton ContactBtn;
        private MaterialSkin.Controls.MaterialComboBox StatusCombox;
    }
}
