namespace FineJobsApp.CTM_Form
{
    partial class CTM_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTM_Application));
            panel2 = new Panel();
            label3 = new Label();
            Time = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            SalaryRange = new Label();
            Location = new Label();
            SkillRequirements = new Label();
            CompanyButton = new Button();
            Title = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 224, 229);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Time);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(SalaryRange);
            panel2.Controls.Add(Location);
            panel2.Controls.Add(SkillRequirements);
            panel2.Controls.Add(CompanyButton);
            panel2.Controls.Add(Title);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(429, 307);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 210);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 17;
            label3.Text = "Open at:";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.ForeColor = Color.SlateGray;
            Time.Location = new Point(76, 204);
            Time.Name = "Time";
            Time.Size = new Size(139, 21);
            Time.TabIndex = 14;
            Time.Text = "Ho Chi Minh City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 4);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 16;
            label2.Text = "Applied at:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(87, -1);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 15;
            label1.Text = "Ho Chi Minh City";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Location = new Point(46, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 58);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 180, 180);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(12, 15);
            button2.Name = "button2";
            button2.Size = new Size(322, 29);
            button2.TabIndex = 5;
            button2.Text = "More Information";
            button2.UseVisualStyleBackColor = false;
            // 
            // SalaryRange
            // 
            SalaryRange.AutoSize = true;
            SalaryRange.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalaryRange.Location = new Point(17, 129);
            SalaryRange.Name = "SalaryRange";
            SalaryRange.Size = new Size(91, 18);
            SalaryRange.TabIndex = 6;
            SalaryRange.Text = "Salary: 300$";
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(18, 182);
            Location.Name = "Location";
            Location.Size = new Size(99, 15);
            Location.TabIndex = 4;
            Location.Text = "Ho Chi Minh City";
            // 
            // SkillRequirements
            // 
            SkillRequirements.AutoSize = true;
            SkillRequirements.Location = new Point(17, 156);
            SkillRequirements.Name = "SkillRequirements";
            SkillRequirements.Size = new Size(126, 15);
            SkillRequirements.TabIndex = 3;
            SkillRequirements.Text = "[\"C#\", \".NET\", \"Azure\"]";
            SkillRequirements.Click += SkillRequirements_Click;
            // 
            // CompanyButton
            // 
            CompanyButton.FlatStyle = FlatStyle.Flat;
            CompanyButton.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyButton.ForeColor = Color.Black;
            CompanyButton.Image = (Image)resources.GetObject("CompanyButton.Image");
            CompanyButton.ImageAlign = ContentAlignment.MiddleLeft;
            CompanyButton.Location = new Point(18, 62);
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
            Title.Location = new Point(17, 31);
            Title.Name = "Title";
            Title.Size = new Size(253, 18);
            Title.TabIndex = 1;
            Title.Text = "Senior iOS Native Engineer (Swift)";
            // 
            // CTM_Application
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CTM_Application";
            Size = new Size(434, 312);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label SalaryRange;
        private Button button2;
        private Label Location;
        private Label SkillRequirements;
        private Button CompanyButton;
        private Label Title;
        private Panel panel1;
        private Label label1;
        private Label Time;
        private Label label3;
        private Label label2;
    }
}
