using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CPN_Form
{
    public partial class CPNApplicantTab : UserControl
    {
        List<ProfileModel> models = new List<ProfileModel>();

        public CPNApplicantTab()
        {
            InitializeComponent();
        }

        private void CPNApplicationHistoryTab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
           models = ControllerManager.Instance.ProfileController.GetAllProfiles();
           LoadApplicants(models);
        }

        public void LoadApplicants(List<ProfileModel> applicantModels)
        {
            scrollview.Controls.Clear();
            foreach (var applicant in applicantModels)
            {
                scrollview.Controls.Add(CreateApplicant(applicant));
            }
        }

        public CPNApplicant CreateApplicant(ProfileModel profile)
        {
            CPNApplicant application = new CPNApplicant();
            UserModel user = ControllerManager.Instance.UserController.GetUserByUserID(profile.UserID);
            application.InitializeComponentsValues(profile.FullName, profile.Education, profile.Experience, profile.Skills);
            application.AddData(user, profile);
            return application;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            LoadApplicationSearch(searchTextBox.Text);
        }

        public void LoadApplicationSearch(string keyword)
        {
           models = ControllerManager.Instance.ProfileController.SearchProfiles(keyword);
           LoadApplicants(models);
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            LoadData();
        }
    }
}
