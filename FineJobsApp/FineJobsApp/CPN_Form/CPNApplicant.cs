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
    public partial class CPNApplicant : UserControl
    {
        private ProfileModel profile;
        private UserModel user;

        public CPNApplicant()
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
        public void InitializeComponentsValues(string appName, string education, string experience, string skills)
        {
            ApplicationName.Text = appName;
            Education.Text = education;
            Experience.Text = experience;
            Skills.Text = skills;
        }
        public void AddData(UserModel user, ProfileModel profile)
        {
            this.profile = profile;
            this.user = user;
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            //MailController.OpenGmailWithRecipient(this.user.Email);
            CPNMessagesTab messagesTab = FormManager.GetForm<CPNHomeForm>().ChangeTab<CPNMessagesTab>(HomeTab.MessagesTab);
            messagesTab.MailTo(this.user.Email);
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            FormManager.ShowForm<CPNOpenCV>().InitBrowser(this.profile.ResumeLink);
        }
    }
}
