using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CPN_Form
{
    public partial class CPNCreateNewJob : MaterialForm
    {
        public CPNCreateNewJob()
        {
            InitializeComponent();
        }

        private void AddSkillBtn_Click(object sender, EventArgs e)
        {

        }
        private JobFormType formType;
        private JobModel jobModel;

        public void InitializeJobComponents(JobFormType formType, string jobName = "", string jobType = "", string salary = "", string skill = "", string description = "", string location = "")
        {
            this.formType = formType;
            SetupFormType(formType);
            JobNameTextbox.Text = jobName;

            JobType.SelectedIndex = JobType.Items.IndexOf(jobType);
            SalaryTextbox.Text = salary;
            LocationTextbox.Text = location;
            DescriptionTextbox.Text = description;
            SkillTextBox.Text = skill;
        }

        public void AddJobModel(JobModel jobModel)
        {
            this.jobModel = jobModel;
        }

        public void SetupFormType(JobFormType formType)
        {
            if (formType == JobFormType.Create)
            {
                LockControl(false);
                SaveButton.Text = "Create";
            }
            else
            {
                LockControl(true);
                SaveButton.Text = "Change It";
            }
        }
        bool isShow = false;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(formType == JobFormType.Create)
            {
                CreateJob();
                this.Hide();
            }
            else
            {
                if (isShow == false) 
                {
                    LockControl(false);
                }
                else
                {
                    UpdateJob();
                    LockControl(true);
                }
            }
        }

        private void CreateJob()
        {
            jobModel = new JobModel();
            jobModel.Title = JobNameTextbox.Text;
            jobModel.Location = LocationTextbox.Text;
            jobModel.JobType = JobType.Text;
            jobModel.SalaryRange = SalaryTextbox.Text;
            jobModel.SkillRequirements = SkillTextBox.Text;
            jobModel.Description = DescriptionTextbox.Text;
            jobModel.CreatedAt = DateTime.Now;
            jobModel.Status = "Active";
            jobModel.CompanyID = ControllerManager.Instance.UserModel.UserID;
            ControllerManager.Instance.JobController.AddJob(jobModel);
        }

        private void UpdateJob()
        {
            if (jobModel == null)
            {
                jobModel.Title = JobNameTextbox.Text;
                jobModel.Location = LocationTextbox.Text;
                jobModel.JobType = JobType.Text;
                jobModel.SalaryRange = SalaryTextbox.Text;
                jobModel.SkillRequirements = SkillTextBox.Text;
                jobModel.Description = DescriptionTextbox.Text;
                ControllerManager.Instance.JobController.UpdateJob(jobModel);
            }
        }

        public void LockControl(bool value)
        {
            isShow = !value;
            JobNameTextbox.Enabled = !value;
            JobType.Enabled = !value;
            SalaryTextbox.Enabled = !value;
            DescriptionTextbox.Enabled = !value;
            SkillTextBox.Enabled = !value;
            LocationTextbox.Enabled = !value;
        }

        private void SkillTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SkillTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPNCreateNewJob_Load(object sender, EventArgs e)
        {

        }

    }
    public enum JobFormType
    {
        Create,
        Update
    }
}
