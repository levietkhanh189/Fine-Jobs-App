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
    public partial class CPNApplicationHistoryTab : UserControl
    {
        List<CPNApplication> applications = new List<CPNApplication>();
        List<ApplicationModel> models = new List<ApplicationModel>();

        public CPNApplicationHistoryTab()
        {
            InitializeComponent();
        }

        private void CPNApplicationHistoryTab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            models = ControllerManager.Instance.ApplicationController.GetApplicationsByCurrentCompany();
            LoadApplications(models);
        }

        public void LoadApplicationForToday()
        {
            models = ControllerManager.Instance.ApplicationController.GetApplicationsForToday();
            LoadApplications(models);
        }

        public void LoadApplicationInterview()
        {
            models = ControllerManager.Instance.ApplicationController.GetApplicationsByStatus("Interview");
            LoadApplications(models);
        }

        public void LoadApplications(List<ApplicationModel> applicationModels)
        {
            scrollview.Controls.Clear();
            foreach (var application in applicationModels)
            {
                CPNApplication appli = CreateApplication(application);
                if(appli != null)
                    scrollview.Controls.Add(appli);
            }
        }

        public CPNApplication CreateApplication(ApplicationModel model)
        {
            CPNApplication application = new CPNApplication();
            ProfileModel profile = ControllerManager.Instance.ProfileController.GetProfile(model.ApplicantID);
            if(profile == null)
                return null;
            JobModel job = ControllerManager.Instance.JobController.GetJob(model.JobID);
            if (job == null)
                return null;
            UserModel user = ControllerManager.Instance.UserController.GetUserByUserID(model.ApplicantID);
            if (user == null)
                return null;
            application.InitializeComponentsValues(profile.FullName, job.Title, profile.Education, profile.Experience, profile.Skills, model.Status);
            application.AddData(user, profile, model);
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
            models = ControllerManager.Instance.ApplicationController.GetApplicationsBySearch(keyword);
            LoadApplications(models);
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            LoadData();
        }
    }
}
