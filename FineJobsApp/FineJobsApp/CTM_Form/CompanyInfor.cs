using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up.CTM_Form
{
    public partial class CompanyInfor : UserControl
    {
        FormInforCompany formInforCompany;

        public CompanyInfor(CompanyProfileModel i)
        {
            InitializeComponent();
            UpdateCompanyInformation(i);
            formInforCompany = new FormInforCompany(i);
        }

        public void UpdateCompanyInformation(CompanyProfileModel companyProfileModel)
        {
            // Cập nhật thông tin trong các control của CompanyInfor dựa trên thông tin từ CompanyProfileModel
            Industry.Text = companyProfileModel.Industry;
            CompanyButton.Text = companyProfileModel.CompanyName;
            website.Text = companyProfileModel.Website;
            contactinfo.Text = companyProfileModel.ContactInfo;
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            formInforCompany.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
