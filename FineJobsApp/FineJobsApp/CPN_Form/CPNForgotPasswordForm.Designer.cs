namespace FineJobsApp.CPN_Form
{
    partial class CPNForgotPasswordForm
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
            SendCodeButton = new MaterialSkin.Controls.MaterialButton();
            CodeTextbox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            PasswordTextbox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            LoginButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TittleLable = new MaterialSkin.Controls.MaterialLabel();
            PasswordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            EmailTextbox = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // SendCodeButton
            // 
            SendCodeButton.AutoSize = false;
            SendCodeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendCodeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            SendCodeButton.Depth = 0;
            SendCodeButton.HighEmphasis = true;
            SendCodeButton.Icon = null;
            SendCodeButton.Location = new Point(326, 442);
            SendCodeButton.Margin = new Padding(4, 6, 4, 6);
            SendCodeButton.MouseState = MaterialSkin.MouseState.HOVER;
            SendCodeButton.Name = "SendCodeButton";
            SendCodeButton.NoAccentTextColor = Color.Empty;
            SendCodeButton.Size = new Size(101, 41);
            SendCodeButton.TabIndex = 28;
            SendCodeButton.Text = "Send Code";
            SendCodeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            SendCodeButton.UseAccentColor = false;
            SendCodeButton.UseVisualStyleBackColor = true;
            // 
            // CodeTextbox
            // 
            CodeTextbox.AnimateReadOnly = false;
            CodeTextbox.BorderStyle = BorderStyle.None;
            CodeTextbox.Depth = 0;
            CodeTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            CodeTextbox.LeadingIcon = null;
            CodeTextbox.Location = new Point(111, 436);
            CodeTextbox.MaxLength = 50;
            CodeTextbox.MouseState = MaterialSkin.MouseState.OUT;
            CodeTextbox.Multiline = false;
            CodeTextbox.Name = "CodeTextbox";
            CodeTextbox.Size = new Size(208, 50);
            CodeTextbox.TabIndex = 27;
            CodeTextbox.Text = "Enter your code";
            CodeTextbox.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(111, 357);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(103, 17);
            materialLabel4.TabIndex = 24;
            materialLabel4.Text = "Password Again";
            // 
            // PasswordTextbox2
            // 
            PasswordTextbox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox2.AnimateReadOnly = false;
            PasswordTextbox2.BorderStyle = BorderStyle.None;
            PasswordTextbox2.Depth = 0;
            PasswordTextbox2.Font = new Font("Microsoft Sans Serif", 4.8F);
            PasswordTextbox2.LeadingIcon = null;
            PasswordTextbox2.Location = new Point(111, 379);
            PasswordTextbox2.MaxLength = 50;
            PasswordTextbox2.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox2.Multiline = false;
            PasswordTextbox2.Name = "PasswordTextbox2";
            PasswordTextbox2.Password = true;
            PasswordTextbox2.Size = new Size(316, 50);
            PasswordTextbox2.TabIndex = 23;
            PasswordTextbox2.Text = "123456789";
            PasswordTextbox2.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(298, 315);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(1, 0);
            materialLabel3.TabIndex = 22;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.AutoSize = false;
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            LoginButton.Depth = 0;
            LoginButton.HighEmphasis = true;
            LoginButton.Icon = null;
            LoginButton.Location = new Point(139, 524);
            LoginButton.Margin = new Padding(4, 6, 4, 6);
            LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(247, 47);
            LoginButton.TabIndex = 20;
            LoginButton.Text = "Login";
            LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginButton.UseAccentColor = false;
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(111, 275);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(94, 17);
            materialLabel2.TabIndex = 19;
            materialLabel2.Text = "New Password";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(111, 193);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 17);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "Email";
            // 
            // TittleLable
            // 
            TittleLable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TittleLable.AutoSize = true;
            TittleLable.Depth = 0;
            TittleLable.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            TittleLable.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            TittleLable.HighEmphasis = true;
            TittleLable.Location = new Point(67, 108);
            TittleLable.MouseState = MaterialSkin.MouseState.HOVER;
            TittleLable.Name = "TittleLable";
            TittleLable.Size = new Size(404, 41);
            TittleLable.TabIndex = 17;
            TittleLable.Text = "Create your new password";
            TittleLable.UseAccent = true;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox.AnimateReadOnly = false;
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Depth = 0;
            PasswordTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            PasswordTextbox.LeadingIcon = null;
            PasswordTextbox.Location = new Point(111, 297);
            PasswordTextbox.MaxLength = 50;
            PasswordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Password = true;
            PasswordTextbox.Size = new Size(316, 50);
            PasswordTextbox.TabIndex = 16;
            PasswordTextbox.Text = "123456789";
            PasswordTextbox.TrailingIcon = null;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextbox.AnimateReadOnly = false;
            EmailTextbox.BorderStyle = BorderStyle.None;
            EmailTextbox.Depth = 0;
            EmailTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            EmailTextbox.LeadingIcon = null;
            EmailTextbox.Location = new Point(111, 215);
            EmailTextbox.MaxLength = 50;
            EmailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            EmailTextbox.Multiline = false;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(316, 50);
            EmailTextbox.TabIndex = 15;
            EmailTextbox.Text = "Enter your email";
            EmailTextbox.TrailingIcon = null;
            // 
            // CPNForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 650);
            Controls.Add(SendCodeButton);
            Controls.Add(CodeTextbox);
            Controls.Add(materialLabel4);
            Controls.Add(PasswordTextbox2);
            Controls.Add(materialLabel3);
            Controls.Add(LoginButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TittleLable);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            Name = "CPNForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CPNForgotPasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SendCodeButton;
        private MaterialSkin.Controls.MaterialTextBox CodeTextbox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextbox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel TittleLable;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextbox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextbox;
    }
}