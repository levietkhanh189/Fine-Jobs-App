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
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(SalaryRange);
            panel2.Controls.Add(Location);
            panel2.Controls.Add(SkillRequirements);
            panel2.Controls.Add(CompanyButton);
            panel2.Controls.Add(Title);
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 430);
            panel2.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Location = new Point(53, 312);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 78);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 180, 180);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(14, 20);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(368, 39);
            button2.TabIndex = 5;
            button2.Text = "More Information";
            button2.UseVisualStyleBackColor = false;
            // 
            // SalaryRange
            // 
            SalaryRange.AutoSize = true;
            SalaryRange.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SalaryRange.Location = new Point(19, 165);
            SalaryRange.Name = "SalaryRange";
            SalaryRange.Size = new Size(117, 21);
            SalaryRange.TabIndex = 6;
            SalaryRange.Text = "Salary: 300$";
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(21, 255);
            Location.Name = "Location";
            Location.Size = new Size(120, 20);
            Location.TabIndex = 4;
            Location.Text = "Ho Chi Minh City";
            // 
            // SkillRequirements
            // 
            SkillRequirements.AutoSize = true;
            SkillRequirements.Location = new Point(19, 204);
            SkillRequirements.Name = "SkillRequirements";
            SkillRequirements.Size = new Size(155, 20);
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
            CompanyButton.Location = new Point(21, 71);
            CompanyButton.Margin = new Padding(3, 4, 3, 4);
            CompanyButton.Name = "CompanyButton";
            CompanyButton.Size = new Size(427, 68);
            CompanyButton.TabIndex = 2;
            CompanyButton.Text = "ANDPAD VietNam Co., Ltd";
            CompanyButton.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(19, 29);
            Title.Name = "Title";
            Title.Size = new Size(309, 21);
            Title.TabIndex = 1;
            Title.Text = "Senior iOS Native Engineer (Swift)";
            // 
            // CTM_Application
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "CTM_Application";
            Size = new Size(518, 447);
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
    }
}
