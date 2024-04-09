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
        public CTM_Application(JobModel job, ApplicationModel status)
        {
            InitializeComponent();
            UpdateJobInformation(job);
            UpdateApplicationModel(status);
        }

        public void UpdateJobInformation(JobModel job)
        {
            // Cập nhật thông tin trong các control của JobInfor dựa trên thông tin từ JobModel
            Title.Text = job.Title;
            SkillRequirements.Text = job.SkillRequirements;
            SalaryRange.Text = job.SalaryRange;
            Location.Text = job.Location;
            //jobType.Text = job.JobType;
            //createDate.Text = job.CreatedAt.ToString();
            //status.Text = job.Status;
            //description.Text = job.Description;
           // CompanyButton.Text = ControllerManager.Instance.CompanyProfileController.GetCompanyByID(job.CompanyID).CompanyName;
        }

        public void UpdateApplicationModel(ApplicationModel app) 
        { 
            button2.Text = app.Status;
        }


    }
}
