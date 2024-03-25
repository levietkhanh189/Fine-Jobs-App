using System;

public class ApplicationController
{
    public ApplicationController()
    {
    }

    public List<ApplicationModel> GetApplicationsByCurrentCompany()
    {
        return ServiceManager.Instance.Application.GetApplicationByCurrentCompany();
    }

    public int CountApplicationsByJobID(int jobId)
    {
        return DALManager.Instance.Application.GetApplicationsByJobID(jobId).Count;
    }

    public void UpdateApplicationStatus(int applicationId, string status)
    {
        // Xử lý cập nhật trạng thái của ứng dụng/job apply
    }
}