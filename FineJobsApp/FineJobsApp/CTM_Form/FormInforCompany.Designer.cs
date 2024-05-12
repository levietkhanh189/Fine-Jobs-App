namespace AnimationSliding_Sign_In_Sign_Up
{
    partial class FormInforCompany
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInforCompany));
            panel1 = new Panel();
            button2 = new Button();
            Contact = new Label();
            CompanyName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 34, 34);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Contact);
            panel1.Controls.Add(CompanyName);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 120);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(754, 0);
            button2.Name = "button2";
            button2.Size = new Size(43, 39);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Contact
            // 
            Contact.AutoSize = true;
            Contact.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Contact.ForeColor = SystemColors.ButtonFace;
            Contact.Location = new Point(147, 64);
            Contact.Name = "Contact";
            Contact.Size = new Size(153, 17);
            Contact.TabIndex = 2;
            Contact.Text = "District 1, Ho Chi Minh";
            // 
            // CompanyName
            // 
            CompanyName.AutoSize = true;
            CompanyName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CompanyName.ForeColor = SystemColors.ButtonHighlight;
            CompanyName.Location = new Point(144, 20);
            CompanyName.Name = "CompanyName";
            CompanyName.Size = new Size(287, 30);
            CompanyName.TabIndex = 1;
            CompanyName.Text = "ANDPAD VietNam Co., Ltd";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(50, 0, 0, 0);
            pictureBox1.Size = new Size(123, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(809, 509);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(46, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(714, 60);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(137, 59);
            button4.TabIndex = 1;
            button4.Text = "Overview";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.White;
            panel4.Location = new Point(46, 136);
            panel4.Name = "panel4";
            panel4.Size = new Size(714, 326);
            panel4.TabIndex = 1;
            // 
            // FormInforCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 629);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInforCompany";
            Text = "FormInforCompany";
            Load += FormInforCompany_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Button button2;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
        private Panel panel4;
    }
}