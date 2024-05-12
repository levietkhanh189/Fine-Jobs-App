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
        OverViewCompany_UC overViewCompany_UC;
        ReviewCompany_UC reviewCompany_UC;

        public FormInforCompany(CompanyProfileModel companyProfileModel)
        {
            InitializeComponent();
            overViewCompany_UC = new OverViewCompany_UC(companyProfileModel);
            //cập nhật tên công ty
            CompanyName.Text = companyProfileModel.CompanyName;
            Contact.Text = companyProfileModel.ContactInfo;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void FormInforCompany_Load(object sender, EventArgs e)
        {
            //vừa vô hiện usercontrol overview
            addUserControl(overViewCompany_UC);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            addUserControl(reviewCompany_UC);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            addUserControl(overViewCompany_UC);
        }
    }
}
