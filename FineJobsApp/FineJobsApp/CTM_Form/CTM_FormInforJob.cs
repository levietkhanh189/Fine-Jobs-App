﻿using AnimationSliding_Sign_In_Sign_Up;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CTM_Form
{
    public partial class CTM_FormInforJob : Form
    {
        CTM_ApplyForm CTM_ApplyForm;
        FormInforCompany formInforCompany;
        public CTM_FormInforJob(JobModel job)
        {
            InitializeComponent();
            UpdateJobInformation(job);
            CTM_ApplyForm = new CTM_ApplyForm(job);
            formInforCompany = new FormInforCompany(ControllerManager.Instance.CompanyProfileController.GetCompanyByID(job.CompanyID));
        }

        public void UpdateJobInformation(JobModel job)
        {
            // Cập nhật thông tin trong các control của JobInfor dựa trên thông tin từ JobModel
            Title.Text = job.Title;
            SkillRequirements.Text = job.SkillRequirements;
            SalaryRange.Text = job.SalaryRange;
            Location.Text = job.Location;
            jobType.Text = job.JobType;
            createDate.Text = job.CreatedAt.ToString();
            status.Text = job.Status;
            description.Text = job.Description;
            CompanyButton.Text = ControllerManager.Instance.CompanyProfileController.GetCompanyByID(job.CompanyID).CompanyName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mở form ứng tuyển
            CTM_ApplyForm.ShowDialog();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            //mở form thông tin công ty
            //FormInforCompany formInforCompany = new FormInforCompany();
            formInforCompany.ShowDialog();
        }
    }
}
