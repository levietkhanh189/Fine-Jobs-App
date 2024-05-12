namespace AnimationSliding_Sign_In_Sign_Up.CTM_Form
{
    partial class UC_MyJobs
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
            label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(24, 10);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 3;
            label1.Text = "Applied Jobs";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.AliceBlue;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(568, 60);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 463);
            panel1.TabIndex = 5;
            // 
            // UC_MyJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UC_MyJobs";
            Size = new Size(568, 523);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}
