namespace FineJobsApp.CPN_Form
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
            JobCard = new MaterialSkin.Controls.MaterialCard();
            FindApplication = new MaterialSkin.Controls.MaterialButton();
            CountText = new MaterialSkin.Controls.MaterialLabel();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            JobStatus = new MaterialSkin.Controls.MaterialComboBox();
            JobType = new MaterialSkin.Controls.MaterialLabel();
            JobCard.SuspendLayout();
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
            JobName.MaximumSize = new Size(275, 41);
            JobName.MouseState = MaterialSkin.MouseState.HOVER;
            JobName.Name = "JobName";
            JobName.Size = new Size(235, 41);
            JobName.TabIndex = 0;
            JobName.Text = "Unity Developer";
            JobName.UseAccent = true;
            // 
            // JobCard
            // 
            JobCard.BackColor = Color.FromArgb(255, 255, 255);
            JobCard.Controls.Add(FindApplication);
            JobCard.Controls.Add(CountText);
            JobCard.Controls.Add(EditBtn);
            JobCard.Controls.Add(DeleteBtn);
            JobCard.Controls.Add(JobStatus);
            JobCard.Controls.Add(JobType);
            JobCard.Controls.Add(JobName);
            JobCard.Depth = 0;
            JobCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            JobCard.Location = new Point(14, 0);
            JobCard.Margin = new Padding(14);
            JobCard.MouseState = MaterialSkin.MouseState.HOVER;
            JobCard.Name = "JobCard";
            JobCard.Padding = new Padding(14);
            JobCard.Size = new Size(1246, 133);
            JobCard.TabIndex = 1;
            JobCard.Click += JobCard_Click;
            // 
            // FindApplication
            // 
            FindApplication.AutoSize = false;
            FindApplication.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FindApplication.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            FindApplication.Depth = 0;
            FindApplication.HighEmphasis = true;
            FindApplication.Icon = Properties.Resources.icons8_contacts_100;
            FindApplication.Location = new Point(1133, 43);
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
            CountText.Location = new Point(37, 79);
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
            EditBtn.Location = new Point(998, 43);
            EditBtn.Margin = new Padding(4, 6, 4, 6);
            EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            EditBtn.Name = "EditBtn";
            EditBtn.NoAccentTextColor = Color.Empty;
            EditBtn.Size = new Size(108, 43);
            EditBtn.TabIndex = 4;
            EditBtn.Text = "Change";
            EditBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditBtn.UseAccentColor = false;
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
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
            // JobStatus
            // 
            JobStatus.AutoResize = false;
            JobStatus.BackColor = Color.FromArgb(255, 255, 255);
            JobStatus.Depth = 0;
            JobStatus.DrawMode = DrawMode.OwnerDrawVariable;
            JobStatus.DropDownHeight = 174;
            JobStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            JobStatus.DropDownWidth = 121;
            JobStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            JobStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            JobStatus.FormattingEnabled = true;
            JobStatus.IntegralHeight = false;
            JobStatus.ItemHeight = 43;
            JobStatus.Items.AddRange(new object[] { "Open", "Close" });
            JobStatus.Location = new Point(805, 38);
            JobStatus.MaxDropDownItems = 4;
            JobStatus.MouseState = MaterialSkin.MouseState.OUT;
            JobStatus.Name = "JobStatus";
            JobStatus.Size = new Size(186, 49);
            JobStatus.StartIndex = 0;
            JobStatus.TabIndex = 2;
            // 
            // JobType
            // 
            JobType.AutoSize = true;
            JobType.Depth = 0;
            JobType.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            JobType.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            JobType.ForeColor = Color.Cyan;
            JobType.Location = new Point(363, 43);
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
            Controls.Add(JobCard);
            Name = "CPNJob";
            Size = new Size(1274, 147);
            JobCard.ResumeLayout(false);
            JobCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel JobName;
        private MaterialSkin.Controls.MaterialCard JobCard;
        private MaterialSkin.Controls.MaterialLabel JobType;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
        private MaterialSkin.Controls.MaterialComboBox JobStatus;
        private MaterialSkin.Controls.MaterialButton FindApplication;
        private MaterialSkin.Controls.MaterialLabel CountText;
    }
}
