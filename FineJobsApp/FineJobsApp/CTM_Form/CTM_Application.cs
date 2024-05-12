using AnimationSliding_Sign_In_Sign_Up;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FineJobsApp.CTM_Form
{

    public partial class CTM_Application : UserControl
    {
        FormInforCompany formInforCompany;
        public CTM_Application(JobModel job, ApplicationModel status)
        {
            InitializeComponent();
            UpdateJobInformation(job);
            UpdateApplicationModel(status);
            formInforCompany = new FormInforCompany(ControllerManager.Instance.CompanyProfileController.GetCompanyByID(job.CompanyID));
        }

        public void UpdateJobInformation(JobModel job)
        {
            // Cập nhật thông tin trong các control của JobInfor dựa trên thông tin từ JobModel
            Title.Text = job.Title;
            SkillRequirements.Text = job.SkillRequirements;
            SalaryRange.Text = job.SalaryRange;
            Location.Text = job.Location;
            Time.Text = job.CreatedAt.ToString();
            //cập nhật tên công ty
            CompanyButton.Text = ControllerManager.Instance.CompanyProfileController.GetCompanyByID(job.CompanyID).CompanyName;
            //thoi gian nop ho so
            label1.Text = ControllerManager.Instance.ApplicationController.GetApplicationByJobIDAndUserID(job.JobID, ControllerManager.Instance.UserModel.UserID).ApplyDate.ToString();
        }

        public void UpdateApplicationModel(ApplicationModel app)
        {
            button2.Text = app.Status;
        }

        private void SkillRequirements_Click(object sender, EventArgs e)
        {

        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            formInforCompany.ShowDialog();
        }
    }
}
