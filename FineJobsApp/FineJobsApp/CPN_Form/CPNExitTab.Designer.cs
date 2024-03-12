namespace FineJobsApp.CPN_Form
{
    partial class CPNExitTab
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
            ExitButton = new MaterialSkin.Controls.MaterialButton();
            LogoutButton = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top;
            ExitButton.AutoSize = false;
            ExitButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ExitButton.Depth = 0;
            ExitButton.HighEmphasis = false;
            ExitButton.Icon = null;
            ExitButton.Location = new Point(570, 592);
            ExitButton.Margin = new Padding(4, 6, 4, 6);
            ExitButton.MaximumSize = new Size(320, 62);
            ExitButton.MinimumSize = new Size(320, 62);
            ExitButton.MouseState = MaterialSkin.MouseState.HOVER;
            ExitButton.Name = "ExitButton";
            ExitButton.NoAccentTextColor = Color.Empty;
            ExitButton.Size = new Size(320, 62);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit app";
            ExitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            ExitButton.UseAccentColor = false;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.Top;
            LogoutButton.AutoSize = false;
            LogoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogoutButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LogoutButton.Depth = 0;
            LogoutButton.HighEmphasis = true;
            LogoutButton.Icon = null;
            LogoutButton.Location = new Point(570, 497);
            LogoutButton.Margin = new Padding(4, 6, 4, 6);
            LogoutButton.MaximumSize = new Size(320, 62);
            LogoutButton.MinimumSize = new Size(320, 62);
            LogoutButton.MouseState = MaterialSkin.MouseState.HOVER;
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NoAccentTextColor = Color.Empty;
            LogoutButton.Size = new Size(320, 62);
            LogoutButton.TabIndex = 1;
            LogoutButton.Text = "Logout";
            LogoutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LogoutButton.UseAccentColor = false;
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Light", 96F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H1;
            materialLabel1.Location = new Point(387, 189);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(682, 115);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Have a nice day!";
            // 
            // CPNExitTab
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel1);
            Controls.Add(LogoutButton);
            Controls.Add(ExitButton);
            Name = "CPNExitTab";
            Size = new Size(1592, 824);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton ExitButton;
        private MaterialSkin.Controls.MaterialButton LogoutButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
