using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class FormCV : Form
    {
        public FormCV()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CVControl1 cVControl1 = new CVControl1();
            addUserControl(cVControl1);

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            CVControl1 cVControl1 = new CVControl1();
            addUserControl(cVControl1);

        }
    }
}
