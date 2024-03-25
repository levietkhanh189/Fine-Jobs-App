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
    public partial class FormInforCompany : Form
    {
        public FormInforCompany()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OverViewCompany_UC overViewCompany_UC = new OverViewCompany_UC();
            addUserControl(overViewCompany_UC);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReviewCompany_UC reviewCompany_UC = new ReviewCompany_UC();
            addUserControl(reviewCompany_UC);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //UC_TopITJob uC_TopITJob = new UC_TopITJob();
            //addUserControl(uC_TopITJob);
        }
    }
}
