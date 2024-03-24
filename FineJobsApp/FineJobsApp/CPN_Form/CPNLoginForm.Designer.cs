namespace FineJobsApp
{
    partial class CPNLoginForm
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
            SuspendLayout();
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextbox.AnimateReadOnly = false;
            EmailTextbox.BorderStyle = BorderStyle.None;
            EmailTextbox.Depth = 0;
            EmailTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            EmailTextbox.LeadingIcon = null;
            EmailTextbox.Location = new Point(98, 192);
            EmailTextbox.MaxLength = 50;
            EmailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            EmailTextbox.Multiline = false;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(316, 50);
            EmailTextbox.TabIndex = 1;
            EmailTextbox.Text = "levietkhanh189@gmail.com";
            EmailTextbox.TrailingIcon = null;
            EmailTextbox.TextChanged += EmailTextbox_TextChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox.AnimateReadOnly = false;
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Depth = 0;
            PasswordTextbox.Font = new Font("Microsoft Sans Serif", 4.8F);
            PasswordTextbox.LeadingIcon = null;
            PasswordTextbox.Location = new Point(98, 287);
            PasswordTextbox.MaxLength = 50;
            PasswordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Password = true;
            PasswordTextbox.Size = new Size(316, 50);
            PasswordTextbox.TabIndex = 2;
            PasswordTextbox.Text = "123456789";
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
            TittleLable.Location = new Point(142, 96);
            TittleLable.MouseState = MaterialSkin.MouseState.HOVER;
            TittleLable.Name = "TittleLable";
            TittleLable.Size = new Size(225, 41);
            TittleLable.TabIndex = 3;
            TittleLable.Text = "Welcome Back";
            TittleLable.UseAccent = true;
            TittleLable.Click += TittleLable_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(98, 170);
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
            materialLabel2.Location = new Point(98, 265);
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
            LoginButton.Location = new Point(130, 367);
            LoginButton.Margin = new Padding(4, 6, 4, 6);
            LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(256, 36);
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
            SignupButton.Location = new Point(130, 415);
            SignupButton.Margin = new Padding(4, 6, 4, 6);
            SignupButton.MouseState = MaterialSkin.MouseState.HOVER;
            SignupButton.Name = "SignupButton";
            SignupButton.NoAccentTextColor = Color.Empty;
            SignupButton.Size = new Size(256, 36);
            SignupButton.TabIndex = 7;
            SignupButton.Text = "Sign Up";
            SignupButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SignupButton.UseAccentColor = false;
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(276, 340);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(138, 17);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Forgot your password";
            // 
            // CPNLoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(524, 515);
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
            Name = "CPNLoginForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Login";
            ResumeLayout(false);
            PerformLayout();
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
    }
}