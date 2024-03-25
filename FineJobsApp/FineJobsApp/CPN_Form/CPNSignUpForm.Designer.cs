namespace FineJobsApp
{
    partial class CPNSignUpForm
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
            EmailTextbox = new MaterialSkin.Controls.MaterialTextBox();
            PasswordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            TittleLable = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            LoginButton = new MaterialSkin.Controls.MaterialButton();
            SignupButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            PasswordTextbox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            CompanyNameTextbox = new MaterialSkin.Controls.MaterialTextBox();
            CodeTextbox = new MaterialSkin.Controls.MaterialTextBox();
            SendCodeButton = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
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
            EmailTextbox.Location = new Point(100, 247);
            EmailTextbox.MaxLength = 50;
            EmailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            EmailTextbox.Multiline = false;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(316, 50);
            EmailTextbox.TabIndex = 1;
            EmailTextbox.Text = "";
            EmailTextbox.TrailingIcon = null;
            EmailTextbox.Click += EmailTextbox_Click;
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
            PasswordTextbox.Location = new Point(100, 329);
            PasswordTextbox.MaxLength = 50;
            PasswordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Password = true;
            PasswordTextbox.ScrollBars = RichTextBoxScrollBars.None;
            PasswordTextbox.Size = new Size(316, 50);
            PasswordTextbox.TabIndex = 2;
            PasswordTextbox.Text = "";
            PasswordTextbox.TrailingIcon = null;
            // 
            // TittleLable
            // 
            TittleLable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TittleLable.AutoSize = true;
            TittleLable.Depth = 0;
            TittleLable.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            TittleLable.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            TittleLable.HighEmphasis = true;
            TittleLable.Location = new Point(86, 94);
            TittleLable.MouseState = MaterialSkin.MouseState.HOVER;
            TittleLable.Name = "TittleLable";
            TittleLable.Size = new Size(330, 41);
            TittleLable.TabIndex = 3;
            TittleLable.Text = "Welcome To Fine-App";
            TittleLable.UseAccent = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(100, 225);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 17);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Email";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(100, 307);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(63, 17);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Password";
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
            LoginButton.Location = new Point(128, 582);
            LoginButton.Margin = new Padding(4, 6, 4, 6);
            LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(247, 39);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginButton.UseAccentColor = false;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // SignupButton
            // 
            SignupButton.Anchor = AnchorStyles.Top;
            SignupButton.AutoSize = false;
            SignupButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SignupButton.BackColor = SystemColors.ControlLight;
            SignupButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            SignupButton.Depth = 0;
            SignupButton.DrawShadows = false;
            SignupButton.HighEmphasis = false;
            SignupButton.Icon = null;
            SignupButton.Location = new Point(128, 527);
            SignupButton.Margin = new Padding(4, 6, 4, 6);
            SignupButton.MouseState = MaterialSkin.MouseState.HOVER;
            SignupButton.Name = "SignupButton";
            SignupButton.NoAccentTextColor = Color.Empty;
            SignupButton.Size = new Size(247, 43);
            SignupButton.TabIndex = 7;
            SignupButton.Text = "Sign Up";
            SignupButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SignupButton.UseAccentColor = false;
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(287, 347);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(1, 0);
            materialLabel3.TabIndex = 8;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(100, 389);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(103, 17);
            materialLabel4.TabIndex = 10;
            materialLabel4.Text = "Password Again";
            // 
            // PasswordTextbox2
            // 
            PasswordTextbox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox2.AnimateReadOnly = false;
            PasswordTextbox2.BorderStyle = BorderStyle.None;
            PasswordTextbox2.Depth = 0;
            PasswordTextbox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextbox2.Hint = "Enter your password again";
            PasswordTextbox2.LeadingIcon = null;
            PasswordTextbox2.Location = new Point(100, 411);
            PasswordTextbox2.MaxLength = 50;
            PasswordTextbox2.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox2.Multiline = false;
            PasswordTextbox2.Name = "PasswordTextbox2";
            PasswordTextbox2.Password = true;
            PasswordTextbox2.Size = new Size(316, 50);
            PasswordTextbox2.TabIndex = 9;
            PasswordTextbox2.Text = "";
            PasswordTextbox2.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel5.Location = new Point(100, 150);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(102, 17);
            materialLabel5.TabIndex = 12;
            materialLabel5.Text = "Company Name";
            // 
            // CompanyNameTextbox
            // 
            CompanyNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CompanyNameTextbox.AnimateReadOnly = false;
            CompanyNameTextbox.BorderStyle = BorderStyle.None;
            CompanyNameTextbox.Depth = 0;
            CompanyNameTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CompanyNameTextbox.Hint = "Enter your company name";
            CompanyNameTextbox.LeadingIcon = null;
            CompanyNameTextbox.Location = new Point(100, 172);
            CompanyNameTextbox.MaxLength = 50;
            CompanyNameTextbox.MouseState = MaterialSkin.MouseState.OUT;
            CompanyNameTextbox.Multiline = false;
            CompanyNameTextbox.Name = "CompanyNameTextbox";
            CompanyNameTextbox.Size = new Size(316, 50);
            CompanyNameTextbox.TabIndex = 11;
            CompanyNameTextbox.Text = "";
            CompanyNameTextbox.TrailingIcon = null;
            CompanyNameTextbox.Click += CompanyNameTextbox_Click;
            // 
            // CodeTextbox
            // 
            CodeTextbox.AnimateReadOnly = false;
            CodeTextbox.BorderStyle = BorderStyle.None;
            CodeTextbox.Depth = 0;
            CodeTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CodeTextbox.Hint = "Enter your code";
            CodeTextbox.LeadingIcon = null;
            CodeTextbox.Location = new Point(100, 468);
            CodeTextbox.MaxLength = 50;
            CodeTextbox.MouseState = MaterialSkin.MouseState.OUT;
            CodeTextbox.Multiline = false;
            CodeTextbox.Name = "CodeTextbox";
            CodeTextbox.Size = new Size(208, 50);
            CodeTextbox.TabIndex = 13;
            CodeTextbox.Text = "";
            CodeTextbox.TrailingIcon = null;
            CodeTextbox.Click += CompanyNameTextbox_Click;
            // 
            // SendCodeButton
            // 
            SendCodeButton.AutoSize = false;
            SendCodeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendCodeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            SendCodeButton.Depth = 0;
            SendCodeButton.HighEmphasis = true;
            SendCodeButton.Icon = null;
            SendCodeButton.Location = new Point(315, 474);
            SendCodeButton.Margin = new Padding(4, 6, 4, 6);
            SendCodeButton.MouseState = MaterialSkin.MouseState.HOVER;
            SendCodeButton.Name = "SendCodeButton";
            SendCodeButton.NoAccentTextColor = Color.Empty;
            SendCodeButton.Size = new Size(101, 41);
            SendCodeButton.TabIndex = 14;
            SendCodeButton.Text = "Send Code";
            SendCodeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            SendCodeButton.UseAccentColor = false;
            SendCodeButton.UseVisualStyleBackColor = true;
            SendCodeButton.Click += SendCodeButton_Click;
            // 
            // CPNSignUpForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(524, 650);
            Controls.Add(SendCodeButton);
            Controls.Add(CodeTextbox);
            Controls.Add(materialLabel5);
            Controls.Add(CompanyNameTextbox);
            Controls.Add(materialLabel4);
            Controls.Add(PasswordTextbox2);
            Controls.Add(materialLabel3);
            Controls.Add(SignupButton);
            Controls.Add(LoginButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TittleLable);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            HelpButton = true;
            MaximumSize = new Size(940, 994);
            MinimumSize = new Size(470, 497);
            Name = "CPNSignUpForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COMPANY SIGN UP";
            ResumeLayout(false);
            PerformLayout();
        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox EmailTextbox;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextbox;
        private MaterialSkin.Controls.MaterialLabel TittleLable;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialButton SignupButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextbox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox CompanyNameTextbox;
        private MaterialSkin.Controls.MaterialTextBox CodeTextbox;
        private MaterialSkin.Controls.MaterialButton SendCodeButton;
    }
}