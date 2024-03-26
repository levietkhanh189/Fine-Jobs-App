namespace AnimationSliding_Sign_In_Sign_Up
{
    partial class TopCompany_UC
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
            panel1 = new Panel();
            panel4 = new Panel();
            label10 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(204, 204, 204);
            label1.Location = new Point(41, 16);
            label1.Name = "label1";
            label1.Size = new Size(541, 54);
            label1.TabIndex = 0;
            label1.Text = "Vietnam Best IT Companies";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 153, 153);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 102);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(label10);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(714, 59);
            panel4.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 22);
            label10.Name = "label10";
            label10.Size = new Size(496, 20);
            label10.TabIndex = 8;
            label10.Text = "*Based on Vietnamese employees feedback from 1/1/2023 to 12/31/2023";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 161);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 389);
            panel2.TabIndex = 5;
            // 
            // TopCompany_UC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TopCompany_UC";
            Size = new Size(714, 550);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Panel panel4;
        private Label label10;
        private Panel panel2;
    }
}
