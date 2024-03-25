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
    public partial class CPNListJobsTab : UserControl
    {
        List<JobModel> models = new List<JobModel>();
        public CPNListJobsTab()
        {
            InitializeComponent();
        }

        private void CPNListJobsTab_Load(object sender, EventArgs e)
        {
            models = ControllerManager.Instance.JobController.GetJobsByCurrentComapy();
            foreach (var job in models)
            {
                scrollview.Controls.Add(CreateJob(job));
            }
        }

        public CPNJob CreateJob(JobModel model)
        {
            CPNJob job = new CPNJob();
            int count = ControllerManager.Instance.ApplicationController.CountApplicationsByJobID(model.JobID);
            job.InitializeJobComponents(model.Title, model.JobType, model.Status,count+" Applications");
            return job;
        }

        private void CreatJobBtn_Click(object sender, EventArgs e)
        {
             FormManager.ShowForm<CPNCreateNewJob>().InitializeJobComponents();
        }
    }
}
