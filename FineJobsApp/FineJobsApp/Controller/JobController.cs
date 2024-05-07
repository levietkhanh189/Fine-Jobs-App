using System;

public class JobController
{
    public JobController()
    {
    }

    public void AddJob(JobModel jobModel)
    {
        DALManager.Instance.Job.AddJob(jobModel);
    }

    public void ApplyForJob(int applicationId, int jobId, int userId)
    {
        // Xử lý ứng tuyển công việc
    }

    public JobModel GetJob(int jobID)
    {
        return DALManager.Instance.Job.GetJob(jobID);
    }

    public List<JobModel> GetAllJob()
    {
        return DALManager.Instance.Job.GetJobs();
    }
    public void UpdateJob(JobModel jobModel)
    {
        DALManager.Instance.Job.UpdateJob (jobModel);
    }

    public List<JobModel> GetJobsByCurrentComapy()
    {
        return DALManager.Instance.Job.GetJobsByCompany(ControllerManager.Instance.UserModel.UserID);
    }

    public List<JobModel> SearchJobs(string keyword)
    {
        return DALManager.Instance.Job.SearchJobs( keyword, ControllerManager.Instance.UserModel.UserID);
    }
}