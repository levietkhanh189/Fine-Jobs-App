namespace AnimationSliding_Sign_In_Sign_Up
{
    partial class FrmLogin
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
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            SignupButton = new MaterialSkin.Controls.MaterialButton();
            LoginButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            TittleLable = new MaterialSkin.Controls.MaterialLabel();
            PasswordTextbox = new MaterialSkin.Controls.MaterialTextBox();
            EmailTextbox = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // materialLabel3
            // 
            materialLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(491, 639);
            materialLabel3.Margin = new Padding(1, 0, 1, 0);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(138, 17);
            materialLabel3.TabIndex = 16;
            materialLabel3.Text = "Forgot your password";
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
            SignupButton.Location = new Point(491, 733);
            SignupButton.Margin = new Padding(2, 3, 2, 3);
            SignupButton.MouseState = MaterialSkin.MouseState.HOVER;
            SignupButton.Name = "SignupButton";
            SignupButton.NoAccentTextColor = Color.Empty;
            SignupButton.Size = new Size(154, 37);
            SignupButton.TabIndex = 15;
            SignupButton.Text = "Sign Up";
            SignupButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SignupButton.UseAccentColor = false;
            SignupButton.UseVisualStyleBackColor = false;
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
            LoginButton.Location = new Point(491, 670);
            LoginButton.Margin = new Padding(2, 3, 2, 3);
            LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(153, 45);
            LoginButton.TabIndex = 14;
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
            materialLabel2.Location = new Point(388, 500);
            materialLabel2.Margin = new Padding(1, 0, 1, 0);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(63, 17);
            materialLabel2.TabIndex = 13;
            materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(388, 420);
            materialLabel1.Margin = new Padding(1, 0, 1, 0);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 17);
            materialLabel1.TabIndex = 12;
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
            TittleLable.Location = new Point(443, 378);
            TittleLable.Margin = new Padding(1, 0, 1, 0);
            TittleLable.MouseState = MaterialSkin.MouseState.HOVER;
            TittleLable.Name = "TittleLable";
            TittleLable.Size = new Size(260, 41);
            TittleLable.TabIndex = 11;
            TittleLable.Text = "CTM Home Form";
            TittleLable.UseAccent = true;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox.AnimateReadOnly = false;
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Depth = 0;
            PasswordTextbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextbox.Hint = "Enter your password";
            PasswordTextbox.LeadingIcon = null;
            PasswordTextbox.Location = new Point(388, 517);
            PasswordTextbox.Margin = new Padding(1);
            PasswordTextbox.MaxLength = 50;
            PasswordTextbox.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Password = true;
            PasswordTextbox.Size = new Size(344, 50);
            PasswordTextbox.TabIndex = 10;
            PasswordTextbox.Text = "";
            PasswordTextbox.TrailingIcon = null;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextbox.AnimateReadOnly = false;
            EmailTextbox.BorderStyle = BorderStyle.None;
            EmailTextbox.Depth = 0;
            EmailTextbox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailTextbox.Hint = "Enter your email";
            EmailTextbox.LeadingIcon = null;
            EmailTextbox.Location = new Point(388, 431);
            EmailTextbox.Margin = new Padding(1);
            EmailTextbox.MaxLength = 50;
            EmailTextbox.MouseState = MaterialSkin.MouseState.OUT;
            EmailTextbox.Multiline = false;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(344, 50);
            EmailTextbox.TabIndex = 9;
            EmailTextbox.Text = "";
            EmailTextbox.TrailingIcon = null;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 929);
            Controls.Add(materialLabel3);
            Controls.Add(SignupButton);
            Controls.Add(LoginButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TittleLable);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton SignupButton;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel TittleLable;
        private MaterialSkin.Controls.MaterialTextBox PasswordTextbox;
        private MaterialSkin.Controls.MaterialTextBox EmailTextbox;
    }
}

