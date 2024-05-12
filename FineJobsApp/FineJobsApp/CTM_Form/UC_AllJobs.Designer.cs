namespace AnimationSliding_Sign_In_Sign_Up
{
    partial class UC_AllJobs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AllJobs));
            textBoxSearch = new TextBox();
            button6 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold);
            textBoxSearch.Location = new Point(42, 37);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(446, 22);
            textBoxSearch.TabIndex = 15;
            textBoxSearch.Text = "Locking for jobs";
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Font = new Font("Arial Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(494, 29);
            button6.Name = "button6";
            button6.Size = new Size(98, 34);
            button6.TabIndex = 16;
            button6.Text = "Search";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(textBoxSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 68);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(204, 204, 204);
            label1.Location = new Point(100, 14);
            label1.Name = "label1";
            label1.Size = new Size(371, 45);
            label1.TabIndex = 0;
            label1.Text = "Top IT jobs in Viet Nam";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 153, 153);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 76);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoSize = true;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 144);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(663, 394);
            panel3.TabIndex = 3;
            // 
            // UC_AllJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_AllJobs";
            Size = new Size(663, 538);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearch;
        private Button button6;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
    }
}
