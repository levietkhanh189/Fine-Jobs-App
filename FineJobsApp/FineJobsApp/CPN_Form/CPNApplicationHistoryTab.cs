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
            models = ControllerManager.Instance.ApplicationController.GetApplicationsByCurrentCompany();
            LoadApplications(models);
        }

        public void LoadApplications(List<ApplicationModel> applicationModels)
        {
            scrollview.Controls.Clear();
            foreach (var application in applicationModels)
            {
                scrollview.Controls.Add(CreateApplication(application));
            }
        }

        public CPNApplication CreateApplication(ApplicationModel model)
        {
            CPNApplication application = new CPNApplication();
            ProfileModel profile = ControllerManager.Instance.ProfileController.GetProfile(model.ApplicantID);
            JobModel job = ControllerManager.Instance.JobController.GetJob(model.JobID);
            UserModel user = ControllerManager.Instance.UserController.GetUserByUserID(model.ApplicantID);
            application.InitializeComponentsValues(profile.FullName, job.Title, profile.Education, profile.Experience, profile.Skills, model.Status);
            application.AddData(user, profile,model);
            return application;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
