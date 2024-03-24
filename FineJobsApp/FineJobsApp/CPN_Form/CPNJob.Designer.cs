﻿namespace FineJobsApp.CPN_Form
{
    partial class CPNJob
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
            JobName = new MaterialSkin.Controls.MaterialLabel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            FindApplication = new MaterialSkin.Controls.MaterialButton();
            CountText = new MaterialSkin.Controls.MaterialLabel();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            JobType = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // JobName
            // 
            JobName.AutoSize = true;
            JobName.Depth = 0;
            JobName.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            JobName.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            JobName.HighEmphasis = true;
            JobName.Location = new Point(37, 38);
            JobName.MouseState = MaterialSkin.MouseState.HOVER;
            JobName.Name = "JobName";
            JobName.Size = new Size(235, 41);
            JobName.TabIndex = 0;
            JobName.Text = "Unity Developer";
            JobName.UseAccent = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(FindApplication);
            materialCard1.Controls.Add(CountText);
            materialCard1.Controls.Add(EditBtn);
            materialCard1.Controls.Add(DeleteBtn);
            materialCard1.Controls.Add(materialComboBox1);
            materialCard1.Controls.Add(JobType);
            materialCard1.Controls.Add(JobName);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1246, 133);
            materialCard1.TabIndex = 1;
            // 
            // FindApplication
            // 
            FindApplication.AutoSize = false;
            FindApplication.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FindApplication.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            FindApplication.Depth = 0;
            FindApplication.HighEmphasis = true;
            FindApplication.Icon = Properties.Resources.icons8_contacts_100;
            FindApplication.Location = new Point(1133, 41);
            FindApplication.Margin = new Padding(4, 6, 4, 6);
            FindApplication.MouseState = MaterialSkin.MouseState.HOVER;
            FindApplication.Name = "FindApplication";
            FindApplication.NoAccentTextColor = Color.Empty;
            FindApplication.Size = new Size(43, 43);
            FindApplication.TabIndex = 6;
            FindApplication.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            FindApplication.UseAccentColor = true;
            FindApplication.UseVisualStyleBackColor = true;
            FindApplication.Click += FindApplication_Click;
            // 
            // CountText
            // 
            CountText.AutoSize = true;
            CountText.Depth = 0;
            CountText.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            CountText.Location = new Point(152, 90);
            CountText.MouseState = MaterialSkin.MouseState.HOVER;
            CountText.Name = "CountText";
            CountText.Size = new Size(120, 19);
            CountText.TabIndex = 5;
            CountText.Text = "100 Applications";
            // 
            // EditBtn
            // 
            EditBtn.AutoSize = false;
            EditBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditBtn.Depth = 0;
            EditBtn.HighEmphasis = true;
            EditBtn.Icon = Properties.Resources.icons8_edit_144;
            EditBtn.Location = new Point(1063, 41);
            EditBtn.Margin = new Padding(4, 6, 4, 6);
            EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            EditBtn.Name = "EditBtn";
            EditBtn.NoAccentTextColor = Color.Empty;
            EditBtn.Size = new Size(43, 43);
            EditBtn.TabIndex = 4;
            EditBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditBtn.UseAccentColor = false;
            EditBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            DeleteBtn.AutoSize = false;
            DeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DeleteBtn.Depth = 0;
            DeleteBtn.HighEmphasis = true;
            DeleteBtn.Icon = Properties.Resources.icons8_delete_90;
            DeleteBtn.Location = new Point(1184, 43);
            DeleteBtn.Margin = new Padding(4, 6, 4, 6);
            DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.NoAccentTextColor = Color.Empty;
            DeleteBtn.Size = new Size(44, 44);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            DeleteBtn.UseAccentColor = false;
            DeleteBtn.UseVisualStyleBackColor = true;
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
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Items.AddRange(new object[] { "Open", "Close" });
            materialComboBox1.Location = new Point(855, 38);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(186, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 2;
            // 
            // JobType
            // 
            JobType.AutoSize = true;
            JobType.Depth = 0;
            JobType.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            JobType.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            JobType.ForeColor = Color.Cyan;
            JobType.Location = new Point(307, 47);
            JobType.MouseState = MaterialSkin.MouseState.HOVER;
            JobType.Name = "JobType";
            JobType.Size = new Size(94, 29);
            JobType.TabIndex = 1;
            JobType.Text = "Full-time";
            // 
            // CPNJob
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Name = "CPNJob";
            Size = new Size(1274, 147);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel JobName;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel JobType;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton FindApplication;
        private MaterialSkin.Controls.MaterialLabel CountText;
    }
}