﻿using System;
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
    public partial class CPNJob : UserControl
    {
        private JobModel jobModel;
        public CPNJob()
        {
            InitializeComponent();
        }

        private void FindApplication_Click(object sender, EventArgs e)
        {

        }

        public void InitializeJobComponents(JobModel jobModel, string jobName, string jobType, string jobStatus, string countText)
        {
            this.jobModel = jobModel;
            JobName.Text = jobName;

            JobType.Text = jobType;

            JobStatus.Text = jobStatus;
            CountText.Text = countText;
            JobStatus.Enabled = false;
        }

        private bool isEdit = false;
        private void EditBtn_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;
            if (isEdit)
            {
                EditBtn.Text = "Save";
                JobStatus.Enabled = true;
            }
            else
            {
                EditBtn.Text = "Edit";
                JobStatus.Enabled = false;
                jobModel.Status = JobStatus.Text;
                ControllerManager.Instance.JobController.UpdateJob(jobModel);
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
            FormManager.ShowForm<CPNCreateNewJob>().InitializeJobComponents(JobFormType.Update,jobModel.Title,jobModel.JobType,jobModel.SalaryRange,jobModel.SkillRequirements,jobModel.Description);
        }
    }
}
