namespace FineJobsApp.CPN_Form
{
    partial class CPNCompanyInfoTab
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
            PictureBox pictureBox1;
            CompanyName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            Description = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            Website = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            Phone = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            Address = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            Email = new MaterialSkin.Controls.MaterialTextBox();
            UpdateBtn = new MaterialSkin.Controls.MaterialButton();
            SaveBtn = new MaterialSkin.Controls.MaterialButton();
            CancleBtn = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(1082, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // CompanyName
            // 
            CompanyName.AnimateReadOnly = false;
            CompanyName.BorderStyle = BorderStyle.None;
            CompanyName.Depth = 0;
            CompanyName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CompanyName.LeadingIcon = null;
            CompanyName.Location = new Point(71, 189);
            CompanyName.MaxLength = 50;
            CompanyName.MouseState = MaterialSkin.MouseState.OUT;
            CompanyName.Multiline = false;
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(297, 50);
            CompanyName.TabIndex = 0;
            CompanyName.Text = "";
            CompanyName.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(61, 32);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(462, 58);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Company information";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(71, 104);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(604, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Updating your information will offer you the most relevant content and conversations.";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(71, 167);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(122, 19);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Company Name*";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(71, 348);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(88, 19);
            materialLabel4.TabIndex = 5;
            materialLabel4.Text = "Description*";
            // 
            // Description
            // 
            Description.AnimateReadOnly = false;
            Description.BorderStyle = BorderStyle.None;
            Description.Depth = 0;
            Description.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Description.LeadingIcon = null;
            Description.Location = new Point(71, 370);
            Description.MaxLength = 50;
            Description.MouseState = MaterialSkin.MouseState.OUT;
            Description.Multiline = false;
            Description.Name = "Description";
            Description.Size = new Size(831, 50);
            Description.TabIndex = 4;
            Description.Text = "";
            Description.TrailingIcon = null;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(71, 260);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(65, 19);
            materialLabel5.TabIndex = 7;
            materialLabel5.Text = "Industry*";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(71, 282);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(297, 50);
            materialTextBox2.TabIndex = 6;
            materialTextBox2.Text = "";
            materialTextBox2.TrailingIcon = null;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(71, 446);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.RightToLeft = RightToLeft.No;
            materialLabel6.Size = new Size(57, 19);
            materialLabel6.TabIndex = 9;
            materialLabel6.Text = "Website";
            // 
            // Website
            // 
            Website.AnimateReadOnly = false;
            Website.BorderStyle = BorderStyle.None;
            Website.Depth = 0;
            Website.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Website.LeadingIcon = null;
            Website.Location = new Point(71, 468);
            Website.MaxLength = 50;
            Website.MouseState = MaterialSkin.MouseState.OUT;
            Website.Multiline = false;
            Website.Name = "Website";
            Website.Size = new Size(297, 50);
            Website.TabIndex = 8;
            Website.Text = "";
            Website.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(71, 540);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.RightToLeft = RightToLeft.No;
            materialLabel7.Size = new Size(53, 19);
            materialLabel7.TabIndex = 11;
            materialLabel7.Text = "Phone*";
            // 
            // Phone
            // 
            Phone.AnimateReadOnly = false;
            Phone.BorderStyle = BorderStyle.None;
            Phone.Depth = 0;
            Phone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Phone.LeadingIcon = null;
            Phone.Location = new Point(71, 562);
            Phone.MaxLength = 50;
            Phone.MouseState = MaterialSkin.MouseState.OUT;
            Phone.Multiline = false;
            Phone.Name = "Phone";
            Phone.Size = new Size(297, 50);
            Phone.TabIndex = 10;
            Phone.Text = "";
            Phone.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(71, 719);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(65, 19);
            materialLabel8.TabIndex = 13;
            materialLabel8.Text = "Address*";
            // 
            // Address
            // 
            Address.AnimateReadOnly = false;
            Address.BorderStyle = BorderStyle.None;
            Address.Depth = 0;
            Address.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Address.LeadingIcon = null;
            Address.Location = new Point(71, 741);
            Address.MaxLength = 50;
            Address.MouseState = MaterialSkin.MouseState.OUT;
            Address.Multiline = false;
            Address.Name = "Address";
            Address.Size = new Size(831, 50);
            Address.TabIndex = 12;
            Address.Text = "";
            Address.TrailingIcon = null;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(71, 631);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.RightToLeft = RightToLeft.No;
            materialLabel9.Size = new Size(48, 19);
            materialLabel9.TabIndex = 15;
            materialLabel9.Text = "Email*";
            // 
            // Email
            // 
            Email.AnimateReadOnly = false;
            Email.BorderStyle = BorderStyle.None;
            Email.Depth = 0;
            Email.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Email.LeadingIcon = null;
            Email.Location = new Point(71, 653);
            Email.MaxLength = 50;
            Email.MouseState = MaterialSkin.MouseState.OUT;
            Email.Multiline = false;
            Email.Name = "Email";
            Email.Size = new Size(297, 50);
            Email.TabIndex = 14;
            Email.Text = "";
            Email.TrailingIcon = null;
            // 
            // UpdateBtn
            // 
            UpdateBtn.AutoSize = false;
            UpdateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            UpdateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            UpdateBtn.Depth = 0;
            UpdateBtn.HighEmphasis = true;
            UpdateBtn.Icon = null;
            UpdateBtn.Location = new Point(1182, 673);
            UpdateBtn.Margin = new Padding(4, 6, 4, 6);
            UpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.NoAccentTextColor = Color.Empty;
            UpdateBtn.Size = new Size(181, 50);
            UpdateBtn.TabIndex = 17;
            UpdateBtn.Text = "Update Info";
            UpdateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            UpdateBtn.UseAccentColor = false;
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.AutoSize = false;
            SaveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SaveBtn.Depth = 0;
            SaveBtn.HighEmphasis = true;
            SaveBtn.Icon = null;
            SaveBtn.Location = new Point(1286, 735);
            SaveBtn.Margin = new Padding(4, 6, 4, 6);
            SaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SaveBtn.Name = "SaveBtn";
            SaveBtn.NoAccentTextColor = Color.Empty;
            SaveBtn.Size = new Size(181, 50);
            SaveBtn.TabIndex = 18;
            SaveBtn.Text = "Save New Info";
            SaveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SaveBtn.UseAccentColor = true;
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // CancleBtn
            // 
            CancleBtn.AutoSize = false;
            CancleBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancleBtn.Depth = 0;
            CancleBtn.HighEmphasis = true;
            CancleBtn.Icon = null;
            CancleBtn.Location = new Point(1082, 735);
            CancleBtn.Margin = new Padding(4, 6, 4, 6);
            CancleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            CancleBtn.Name = "CancleBtn";
            CancleBtn.NoAccentTextColor = Color.Empty;
            CancleBtn.Size = new Size(181, 50);
            CancleBtn.TabIndex = 19;
            CancleBtn.Text = "Cancle";
            CancleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            CancleBtn.UseAccentColor = true;
            CancleBtn.UseVisualStyleBackColor = true;
            // 
            // CPNCompanyInfoTab
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(CancleBtn);
            Controls.Add(SaveBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(materialLabel9);
            Controls.Add(Email);
            Controls.Add(materialLabel8);
            Controls.Add(Address);
            Controls.Add(materialLabel7);
            Controls.Add(Phone);
            Controls.Add(materialLabel6);
            Controls.Add(Website);
            Controls.Add(materialLabel5);
            Controls.Add(materialTextBox2);
            Controls.Add(materialLabel4);
            Controls.Add(Description);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(CompanyName);
            MaximumSize = new Size(1592, 824);
            MinimumSize = new Size(1592, 824);
            Name = "CPNCompanyInfoTab";
            Size = new Size(1592, 824);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox CompanyName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox Description;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox Website;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox Phone;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox Address;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox Email;
        private MaterialSkin.Controls.MaterialButton UpdateBtn;
        private MaterialSkin.Controls.MaterialButton SaveBtn;
        private MaterialSkin.Controls.MaterialButton CancleBtn;
        private PictureBox pictureBox1;
    }
}
