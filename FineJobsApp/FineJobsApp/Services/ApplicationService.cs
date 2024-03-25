using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineJobsApp;

namespace FineJobsApp.Services
{
    public class ApplicationService
    {
        public List<ApplicationModel> GetApplicationByCurrentCompany()
        {
            List<ApplicationModel> applications = new List<ApplicationModel>();
            List<JobModel> jobs = DALManager.Instance.Job.GetJobsByCompany(ControllerManager.Instance.UserModel.UserID);
            foreach (var job in jobs)
            {
                applications.AddRange(DALManager.Instance.Application.GetApplicationsByJobID(job.JobID));
            }
            return applications;
        }
    }
}
