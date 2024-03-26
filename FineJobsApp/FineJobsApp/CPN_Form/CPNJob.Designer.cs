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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            FindApplication = new MaterialSkin.Controls.MaterialButton();
            CountText = new MaterialSkin.Controls.MaterialLabel();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            JobStatus = new MaterialSkin.Controls.MaterialComboBox();
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
            JobName.Location = new Point(17, 19);
            JobName.Margin = new Padding(1, 0, 1, 0);
            JobName.MaximumSize = new Size(129, 20);
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
            materialCard1.Controls.Add(JobStatus);
            materialCard1.Controls.Add(JobType);
            materialCard1.Controls.Add(JobName);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(7, 0);
            materialCard1.Margin = new Padding(7, 7, 7, 7);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(7, 7, 7, 7);
            materialCard1.Size = new Size(586, 65);
            materialCard1.TabIndex = 1;
            materialCard1.Paint += materialCard1_Paint;
            // 
            // FindApplication
            // 
            FindApplication.AutoSize = false;
            FindApplication.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            FindApplication.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            FindApplication.Depth = 0;
            FindApplication.HighEmphasis = true;
            FindApplication.Icon = Properties.Resources.icons8_contacts_100;
            FindApplication.Location = new Point(533, 21);
            FindApplication.Margin = new Padding(2, 3, 2, 3);
            FindApplication.MouseState = MaterialSkin.MouseState.HOVER;
            FindApplication.Name = "FindApplication";
            FindApplication.NoAccentTextColor = Color.Empty;
            FindApplication.Size = new Size(20, 21);
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
            CountText.Location = new Point(17, 39);
            CountText.Margin = new Padding(1, 0, 1, 0);
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
            EditBtn.Location = new Point(470, 21);
            EditBtn.Margin = new Padding(2, 3, 2, 3);
            EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            EditBtn.Name = "EditBtn";
            EditBtn.NoAccentTextColor = Color.Empty;
            EditBtn.Size = new Size(51, 21);
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
            DeleteBtn.Location = new Point(557, 21);
            DeleteBtn.Margin = new Padding(2, 3, 2, 3);
            DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.NoAccentTextColor = Color.Empty;
            DeleteBtn.Size = new Size(21, 21);
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
            JobStatus.Location = new Point(379, 19);
            JobStatus.Margin = new Padding(1, 1, 1, 1);
            JobStatus.MaxDropDownItems = 4;
            JobStatus.MouseState = MaterialSkin.MouseState.OUT;
            JobStatus.Name = "JobStatus";
            JobStatus.Size = new Size(90, 49);
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
            JobType.Location = new Point(171, 21);
            JobType.Margin = new Padding(1, 0, 1, 0);
            JobType.MouseState = MaterialSkin.MouseState.HOVER;
            JobType.Name = "JobType";
            JobType.Size = new Size(94, 29);
            JobType.TabIndex = 1;
            JobType.Text = "Full-time";
            // 
            // CPNJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "CPNJob";
            Size = new Size(649, 176);
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
        private MaterialSkin.Controls.MaterialComboBox JobStatus;
        private MaterialSkin.Controls.MaterialButton FindApplication;
        private MaterialSkin.Controls.MaterialLabel CountText;
    }
}
