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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoardControl dashBoardControl = new DashBoardControl();
            addUserControl(dashBoardControl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashBoardControl dashBoardControl = new DashBoardControl();
            addUserControl(dashBoardControl);

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_AllJobs uC_AllJobs = new UC_AllJobs();
            addUserControl(uC_AllJobs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TopCompany_UC topCompany_UC = new TopCompany_UC();
            addUserControl(topCompany_UC);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CVControl1 cVControl1 = new CVControl1();
            addUserControl(cVControl1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserProfile_UC userProfileUC = new UserProfile_UC();
            addUserControl(userProfileUC);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UC_MyJobs uC_MyJobs = new UC_MyJobs();
            addUserControl(uC_MyJobs);
        }
    }
}
