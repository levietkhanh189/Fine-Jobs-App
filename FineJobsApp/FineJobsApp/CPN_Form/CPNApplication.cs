using FineJobsApp.Controller;
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
    public partial class CPNApplication : UserControl
    {
        private ProfileModel profile;
        private UserModel user;
        private ApplicationModel application;
        public CPNApplication()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //CustomList Using UserControl And FlowLayoutPanel
        public void InitializeComponentsValues(string appName, string jobTitle, string education, string experience, string skills, string statusOption)
        {
            ApplicationName.Text = appName;
            JobTittle.Text = jobTitle;
            Education.Text = education;
            Experience.Text = experience;
            Skills.Text = skills;
            StatusCombox.Text = statusOption;
            StatusCombox.Enabled = false;
        }
        public void AddData(UserModel user, ProfileModel profile, ApplicationModel application)
        {
            this.profile = profile;
            this.user = user;
            this.application = application;
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            MailController.OpenGmailWithRecipient(this.user.Email);
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            ServiceManager.Instance.OpenLink.OpenUrl(this.profile.ResumeLink);
        }
        bool isShow = false;
        private void StatusBtn_Click(object sender, EventArgs e)
        {
            isShow = !isShow;
            StatusCombox.Enabled = isShow;

            if (isShow)
            {
                StatusBtn.Text = "Save";
            }
            else
            {
                ControllerManager.Instance.ApplicationController.UpdateApplicationStatus(application.ApplicationID, StatusCombox.Text);
                StatusBtn.Text = "Change";
            }
        }
    }
}
