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

    public void UpdateJob(JobModel jobModel)
    {
        DALManager.Instance.Job.UpdateJob(jobModel);
    }

    public JobModel GetJob(int jobId)
    {
        return DALManager.Instance.Job.GetJob(jobId);
    }

    public List<JobModel> GetJobsByCurrentComapy()
    {
        return DALManager.Instance.Job.GetJobsByCompany(ControllerManager.Instance.UserModel.UserID);
    }
}