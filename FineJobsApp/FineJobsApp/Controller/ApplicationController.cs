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
        ApplicationModel application = DALManager.Instance.Application.GetApplicationByApplicationID(applicationId);
        // Cập nhật trạng thái của đơn ứng tuyển có ApplicationID được cung cấp
        DALManager.Instance.Application.UpdateApplicationStatus(applicationId, status);
    }

    public List<ApplicationModel> GetApplicationsByUserId(int userID)
    {
        return DALManager.Instance.Application.GetApplicationsByUserID(userID).ToList();
    }
}