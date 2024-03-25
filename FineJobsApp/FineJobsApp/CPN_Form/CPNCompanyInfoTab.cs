using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CPN_Form
{
    public partial class CPNCompanyInfoTab : UserControl
    {
        CompanyProfileModel CompanyProfileModel;
        public CPNCompanyInfoTab()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SwitchToViewMode(false);
        }

        public void SwitchToViewMode(bool value)
        {
            LockControl(value);
            if (value)
            {
                SaveBtn.Hide();
                CancleBtn.Hide();
                UpdateBtn.Show();
            }
            else
            {
                SaveBtn.Show();
                CancleBtn.Show();
                UpdateBtn.Hide();
            }
        }

        private void CPNCompanyInfoTab_Load(object sender, EventArgs e)
        {
            SwitchToViewMode(true);
            LoadCompanyInfo();
        }

        public void LoadCompanyInfo()
        {
            CompanyProfileModel = ControllerManager.Instance.CompanyProfileController.GetCompanyProfileByUserID(ControllerManager.Instance.UserModel.UserID);
            if (CompanyProfileModel != null)
            {
                ContactInformation contactInformation = new ContactInformation(CompanyProfileModel.ContactInfo);

                CompanyName.Text = CompanyProfileModel.CompanyName;
                Address.Text = contactInformation.Address;
                Phone.Text = contactInformation.Phone;
                Email.Text = contactInformation.Email;
                Website.Text = CompanyProfileModel.Website;
                Description.Text = CompanyProfileModel.Description;
                Industry.Text = CompanyProfileModel.Industry;
            }
        }

        public void LockControl(bool value)
        {
            CompanyName.Enabled = !value;
            Address.Enabled = !value;
            Phone.Enabled = !value;
            Email.Enabled = !value;
            Website.Enabled = !value;
            Description.Enabled = !value;
            Industry.Enabled = !value;
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            LoadCompanyInfo();
            SwitchToViewMode(true);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveNewInfo();
            SwitchToViewMode(true);
        }

        private void SaveNewInfo()
        {
            CompanyProfileModel.CompanyName = CompanyName.Text;
            CompanyProfileModel.Description = Description.Text;
            CompanyProfileModel.Website = Website.Text;
            CompanyProfileModel.Industry = Industry.Text;
            ContactInformation contactInformatio = new ContactInformation(Address.Text, Phone.Text, Email.Text);
            CompanyProfileModel.ContactInfo = contactInformatio.ToString();
            ControllerManager.Instance.CompanyProfileController.UpdateCompanyProfile(CompanyProfileModel);
        }
    }
}
