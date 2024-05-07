namespace FineJobsApp.CPN_Form
{
    partial class CPNSettingTab
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
            scrollview = new FlowLayoutPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            PasswordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            EmailTextbox = new MaterialSkin.Controls.MaterialTextBox();
            ReloadBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(68, 51);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(324, 58);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Setting - Owner";
            // 
            // scrollview
            // 
            scrollview.AutoScroll = true;
            scrollview.Location = new Point(560, 149);
            scrollview.Name = "scrollview";
            scrollview.Size = new Size(956, 579);
            scrollview.TabIndex = 6;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(383, 452);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(99, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Create HR";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(89, 347);
            materialLabel2.Margin = new Padding(2, 0, 2, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(63, 17);
            materialLabel2.TabIndex = 11;
            materialLabel2.Text = "Password";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel3.Location = new Point(89, 253);
            materialLabel3.Margin = new Padding(2, 0, 2, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(37, 17);
            materialLabel3.TabIndex = 10;
            materialLabel3.Text = "Email";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox.AnimateReadOnly = false;
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Depth = 0;
            PasswordTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextbox.Hint = "Enter your password";
            PasswordTextbox.LeadingIcon = null;
            PasswordTextbox.Location = new Point(89, 370);
            PasswordTextbox.Margin = new Padding(2);
            PasswordTextbox.MaxLength = 50;
            PasswordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Password = true;
            PasswordTextbox.Size = new Size(393, 50);
            PasswordTextbox.TabIndex = 9;
            PasswordTextbox.Text = "";
            PasswordTextbox.TrailingIcon = null;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextbox.AnimateReadOnly = false;
            EmailTextbox.BorderStyle = BorderStyle.None;
            EmailTextbox.Depth = 0;
            EmailTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailTextbox.Hint = "Enter your email";
            EmailTextbox.LeadingIcon = null;
            EmailTextbox.Location = new Point(89, 276);
            EmailTextbox.Margin = new Padding(2);
            EmailTextbox.MaxLength = 50;
            EmailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            EmailTextbox.Multiline = false;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(393, 50);
            EmailTextbox.TabIndex = 8;
            EmailTextbox.Text = "";
            EmailTextbox.TrailingIcon = null;
            // 
            // ReloadBtn
            // 
            ReloadBtn.AutoSize = false;
            ReloadBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReloadBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ReloadBtn.Depth = 0;
            ReloadBtn.HighEmphasis = true;
            ReloadBtn.Icon = Properties.Resources.icons8_reload_90;
            ReloadBtn.Location = new Point(1477, 751);
            ReloadBtn.Margin = new Padding(4, 6, 4, 6);
            ReloadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ReloadBtn.Name = "ReloadBtn";
            ReloadBtn.NoAccentTextColor = Color.Empty;
            ReloadBtn.Size = new Size(39, 36);
            ReloadBtn.TabIndex = 20;
            ReloadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ReloadBtn.UseAccentColor = false;
            ReloadBtn.UseVisualStyleBackColor = true;
            ReloadBtn.Click += ReloadBtn_Click;
            // 
            // CPNSettingTab
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReloadBtn);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel3);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            Controls.Add(materialButton1);
            Controls.Add(scrollview);
            Controls.Add(materialLabel1);
            Name = "CPNSettingTab";
            Size = new Size(1592, 824);
            Load += CPNSettingTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlowLayoutPanel scrollview;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextbox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextbox;
        private MaterialSkin.Controls.MaterialButton ReloadBtn;
    }
}
