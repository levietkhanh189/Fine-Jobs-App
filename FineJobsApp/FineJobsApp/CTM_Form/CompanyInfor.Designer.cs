namespace AnimationSliding_Sign_In_Sign_Up.CTM_Form
{
    partial class CompanyInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyInfor));
            panel6 = new Panel();
            button5 = new Button();
            button2 = new Button();
            contactinfo = new Label();
            website = new Label();
            CompanyButton = new Button();
            Industry = new Label();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(238, 224, 229);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(contactinfo);
            panel6.Controls.Add(website);
            panel6.Controls.Add(CompanyButton);
            panel6.Controls.Add(Industry);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(437, 237);
            panel6.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(238, 180, 180);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(220, 170);
            button5.Name = "button5";
            button5.Size = new Size(163, 34);
            button5.TabIndex = 6;
            button5.Text = "See jobs";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 180, 180);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(21, 170);
            button2.Name = "button2";
            button2.Size = new Size(163, 34);
            button2.TabIndex = 5;
            button2.Text = "See reviews";
            button2.UseVisualStyleBackColor = false;
            // 
            // contactinfo
            // 
            contactinfo.AutoSize = true;
            contactinfo.Location = new Point(18, 132);
            contactinfo.Name = "contactinfo";
            contactinfo.Size = new Size(99, 15);
            contactinfo.TabIndex = 4;
            contactinfo.Text = "Ho Chi Minh City";
            // 
            // website
            // 
            website.AutoSize = true;
            website.Location = new Point(18, 106);
            website.Name = "website";
            website.Size = new Size(43, 15);
            website.TabIndex = 3;
            website.Text = "Hybrid";
            // 
            // CompanyButton
            // 
            CompanyButton.FlatStyle = FlatStyle.Flat;
            CompanyButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyButton.ForeColor = Color.Black;
            CompanyButton.Image = (Image)resources.GetObject("CompanyButton.Image");
            CompanyButton.ImageAlign = ContentAlignment.MiddleLeft;
            CompanyButton.Location = new Point(20, 44);
            CompanyButton.Name = "CompanyButton";
            CompanyButton.Size = new Size(305, 51);
            CompanyButton.TabIndex = 2;
            CompanyButton.Text = "ANDPAD VietNam Co., Ltd";
            CompanyButton.UseVisualStyleBackColor = true;
            CompanyButton.Click += CompanyButton_Click;
            // 
            // Industry
            // 
            Industry.AutoSize = true;
            Industry.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Industry.ForeColor = Color.Crimson;
            Industry.Location = new Point(17, 12);
            Industry.Name = "Industry";
            Industry.Size = new Size(88, 17);
            Industry.TabIndex = 0;
            Industry.Text = "#1 NFQ Asia";
            // 
            // CompanyInfor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Name = "CompanyInfor";
            Size = new Size(442, 242);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label contactinfo;
        private System.Windows.Forms.Label website;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Label Industry;
    }
}
