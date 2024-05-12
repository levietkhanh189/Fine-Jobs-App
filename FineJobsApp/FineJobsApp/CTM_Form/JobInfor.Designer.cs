namespace AnimationSliding_Sign_In_Sign_Up.CTM_Form
{
    partial class JobInfor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobInfor));
            panel2 = new Panel();
            button1 = new Button();
            SalaryRange = new Label();
            button2 = new Button();
            Location = new Label();
            SkillRequirements = new Label();
            CompanyButton = new Button();
            Title = new Label();
            Time = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 224, 229);
            panel2.Controls.Add(Time);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(SalaryRange);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(Location);
            panel2.Controls.Add(SkillRequirements);
            panel2.Controls.Add(CompanyButton);
            panel2.Controls.Add(Title);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 304);
            panel2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(238, 180, 180);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(46, 222);
            button1.Name = "button1";
            button1.Size = new Size(322, 29);
            button1.TabIndex = 7;
            button1.Text = "Apply Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SalaryRange
            // 
            SalaryRange.AutoSize = true;
            SalaryRange.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalaryRange.Location = new Point(18, 139);
            SalaryRange.Name = "SalaryRange";
            SalaryRange.Size = new Size(91, 18);
            SalaryRange.TabIndex = 6;
            SalaryRange.Text = "Salary: 300$";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 180, 180);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(46, 264);
            button2.Name = "button2";
            button2.Size = new Size(322, 29);
            button2.TabIndex = 5;
            button2.Text = "More Information";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(18, 191);
            Location.Name = "Location";
            Location.Size = new Size(99, 15);
            Location.TabIndex = 4;
            Location.Text = "Ho Chi Minh City";
            // 
            // SkillRequirements
            // 
            SkillRequirements.AutoSize = true;
            SkillRequirements.Location = new Point(18, 168);
            SkillRequirements.Name = "SkillRequirements";
            SkillRequirements.Size = new Size(126, 15);
            SkillRequirements.TabIndex = 3;
            SkillRequirements.Text = "[\"C#\", \".NET\", \"Azure\"]";
            // 
            // CompanyButton
            // 
            CompanyButton.FlatStyle = FlatStyle.Flat;
            CompanyButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyButton.ForeColor = Color.Black;
            CompanyButton.Image = (Image)resources.GetObject("CompanyButton.Image");
            CompanyButton.ImageAlign = ContentAlignment.MiddleLeft;
            CompanyButton.Location = new Point(19, 68);
            CompanyButton.Name = "CompanyButton";
            CompanyButton.Size = new Size(374, 51);
            CompanyButton.TabIndex = 2;
            CompanyButton.Text = "ANDPAD VietNam Co., Ltd";
            CompanyButton.UseVisualStyleBackColor = true;
            CompanyButton.Click += CompanyButton_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(18, 37);
            Title.Name = "Title";
            Title.Size = new Size(253, 18);
            Title.TabIndex = 1;
            Title.Text = "Senior iOS Native Engineer (Swift)";
            Title.Click += Title_Click;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.ForeColor = Color.SlateGray;
            Time.Location = new Point(10, 9);
            Time.Name = "Time";
            Time.Size = new Size(139, 21);
            Time.TabIndex = 8;
            Time.Text = "Ho Chi Minh City";
            // 
            // JobInfor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "JobInfor";
            Size = new Size(432, 311);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label SkillRequirements;
        private System.Windows.Forms.Button CompanyButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label SalaryRange;
        private Button button1;
        private Label Time;
    }
}
