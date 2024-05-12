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
    public partial class DashBoardControl : UserControl
    {
        public DashBoardControl()
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            UC_AllJobs uC_AllJobs = new UC_AllJobs();
            addUserControl(uC_AllJobs);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserProfile_UC userProfile_UC = new UserProfile_UC();
            addUserControl(userProfile_UC);
        }
    }
}
