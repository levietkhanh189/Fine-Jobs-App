using AnimationSliding_Sign_In_Sign_Up.CTM_Form;
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
    public partial class UC_TopITJob : UserControl
    {
        public UC_TopITJob(CTM_JobModel j)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInforCompany formInforCompany = new FormInforCompany();
            formInforCompany.Show();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //panel2.Controls.Clear();
            //panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void button5_Click(object sender, EventArgs e)
        {

            FrmHome frmHome = new FrmHome();
            frmHome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
