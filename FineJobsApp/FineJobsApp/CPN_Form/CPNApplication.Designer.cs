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
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
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
            StatusBtn.Location = new Point(225, 51);
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
            materialButton2.Location = new Point(90, 122);
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
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.HighEmphasis = true;
            materialLabel2.Location = new Point(90, 14);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(196, 29);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Application Status";
            materialLabel2.UseAccent = true;
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
            materialComboBox1.Items.AddRange(new object[] { "New", "Pending", "Interview", "Accepted", "Rejected" });
            materialComboBox1.Location = new Point(46, 50);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(158, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 2;
            materialComboBox1.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(473, 80);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "materialLabel1";
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
            materialCard1.Controls.Add(materialButton2);
            materialCard1.Controls.Add(StatusBtn);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(materialComboBox1);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(880, 49);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(380, 196);
            materialCard1.TabIndex = 5;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(pictureBox2);
            materialCard2.Controls.Add(materialLabel1);
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
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton StatusBtn;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}
