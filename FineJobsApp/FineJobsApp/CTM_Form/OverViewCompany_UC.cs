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
    public partial class OverViewCompany_UC : UserControl
    {
        ReviewCompany_UC reviewCompany_UC;
        public OverViewCompany_UC(CompanyProfileModel companyProfileModel)
        {
            InitializeComponent();
            reviewCompany_UC = new ReviewCompany_UC(companyProfileModel);
            LoadUserInfo(companyProfileModel);
        }

        private void OverViewCompany_UC_Load(object sender, EventArgs e)
        {

        }

        public void LoadUserInfo(CompanyProfileModel companyProfileModel)
        {
            CPNType.Text = companyProfileModel.Industry;
            CPNContact.Text = companyProfileModel.ContactInfo;
            Web.Text = companyProfileModel.Website;
            CPNDate.Text = companyProfileModel.CreatedAt.ToShortDateString();
            CPNDes.Text = companyProfileModel.Description;
        }

    }
}
