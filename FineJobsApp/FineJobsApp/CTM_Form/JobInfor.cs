using FineJobsApp.CPN_Form;
using FineJobsApp.CTM_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up.CTM_Form
{
    public partial class JobInfor : UserControl
    {
        CTM_FormInforJob cTM_FormInforJob;
        CTM_ApplyForm cTM_ApplyForm;
        FormInforCompany formInforCompany;

        public JobInfor(JobModel j)
        {
            InitializeComponent();
            UpdateJobInformation(j);
            cTM_FormInforJob = new CTM_FormInforJob(j);
            cTM_ApplyForm = new CTM_ApplyForm(j);
            formInforCompany = new FormInforCompany(ControllerManager.Instance.CompanyProfileController.GetCompanyByID(j.CompanyID));
        }

        public void UpdateJobInformation(JobModel job)
        {
            //cập nhật tên công ty
            CompanyButton.Text = ControllerManager.Instance.CompanyProfileController.GetCompanyByID(job.CompanyID).CompanyName;
            // Cập nhật thông tin trong các control của JobInfor dựa trên thông tin từ JobModel
            Title.Text = job.Title;
            SkillRequirements.Text = job.SkillRequirements;
            SalaryRange.Text = job.SalaryRange;
            Location.Text = job.Location;
            Time.Text = job.CreatedAt.ToString();
            //jobTypeLabel.Text = job.JobType;
            //createdAtLabel.Text = job.CreatedAt.ToString();
            //statusLabel.Text = job.Status;
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cTM_FormInforJob.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cTM_ApplyForm.ShowDialog();
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            formInforCompany.ShowDialog();
        }
    }
}
