using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class UserProfile_UC : UserControl
    {
        ProfileModel ProfileModel;

        public UserProfile_UC()
        {
            InitializeComponent();
        }

        public void LoadUserInfo()
        {
            ProfileModel = ControllerManager.Instance.ProfileController.GetProfileByUserID(ControllerManager.Instance.UserModel.UserID);
            if (ProfileModel != null)
            {
                ProfileModel = ControllerManager.Instance.ProfileController.GetProfileByUserID(ControllerManager.Instance.UserModel.UserID);

                FullName.Text = ProfileModel.fullName;
                Education.Text = ProfileModel.education;
                WorkExperien.Text = ProfileModel.experience;
                Skills.Text = ProfileModel.skills;
                ResumeLink.Text = ProfileModel.resumeLink;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProfileModel = ControllerManager.Instance.ProfileController.GetProfileByUserID(ControllerManager.Instance.UserModel.UserID);
            if (ProfileModel != null)
            {
                //ContactInformation contactInformation = new ContactInformation(CompanyProfileModel.ContactInfo);

                ProfileModel.fullName = FullName.Text;
                ProfileModel.education = Education.Text;
                ProfileModel.experience = WorkExperien.Text;
                ProfileModel.skills = Skills.Text;
                ProfileModel.resumeLink = ResumeLink.Text;

                //ContactInformation contactInformatio = new ContactInformation(Address.Text, Phone.Text, Email.Text);
                //ProfileModel.ContactInfo = contactInformatio.ToString();
                ControllerManager.Instance.ProfileController.UpdateProfile(ProfileModel);
                //in case of success
                MessageBox.Show("Update successfully");
            }
        }

        private void UserProfile_UC_Load_1(object sender, EventArgs e)
        {
            LoadUserInfo();
        }
    }
}
