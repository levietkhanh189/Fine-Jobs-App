namespace FineJobsApp.CPN_Form
{
    partial class CPNHumanResource
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
            Email = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Password = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            Delete = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Depth = 0;
            Email.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Email.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Email.Location = new Point(130, 35);
            Email.MouseState = MaterialSkin.MouseState.HOVER;
            Email.Name = "Email";
            Email.Size = new Size(297, 29);
            Email.TabIndex = 6;
            Email.Text = "levietkhanh189@gmail.com";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(43, 39);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(50, 24);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "Email";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Depth = 0;
            Password.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            Password.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            Password.Location = new Point(607, 34);
            Password.MouseState = MaterialSkin.MouseState.HOVER;
            Password.Name = "Password";
            Password.Size = new Size(92, 29);
            Password.TabIndex = 8;
            Password.Text = "1234343";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel3.Location = new Point(490, 39);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(89, 24);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Password";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Delete.Depth = 0;
            Delete.HighEmphasis = false;
            Delete.Icon = null;
            Delete.Location = new Point(806, 34);
            Delete.Margin = new Padding(4, 6, 4, 6);
            Delete.MouseState = MaterialSkin.MouseState.HOVER;
            Delete.Name = "Delete";
            Delete.NoAccentTextColor = Color.Empty;
            Delete.Size = new Size(97, 36);
            Delete.TabIndex = 9;
            Delete.Text = "Delete HR";
            Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Delete.UseAccentColor = false;
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // CPNHumanResource
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Delete);
            Controls.Add(Password);
            Controls.Add(materialLabel3);
            Controls.Add(Email);
            Controls.Add(materialLabel1);
            Name = "CPNHumanResource";
            Size = new Size(947, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Email;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel Password;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton Delete;
    }
}
