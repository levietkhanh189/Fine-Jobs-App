using System;

public class ApplicationController
{
    public ApplicationController()
    {
    }

    public List<ApplicationModel> GetApplicationsForToday()
    {
        return DALManager.Instance.Application.GetApplicationsForToday(ControllerManager.Instance.UserModel.UserID);
    }

    public List<ApplicationModel> GetApplicationsByStatus(string status)
    {
        return DALManager.Instance.Application.GetApplicationsByStatus(status, ControllerManager.Instance.UserModel.UserID);
    }

    public List<ApplicationModel> GetApplicationsBySearch(string keyword)
    {
        return DALManager.Instance.Application.SearchApplications(keyword, ControllerManager.Instance.UserModel.UserID);
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

    //lấy application theo jobID và userID
    public ApplicationModel GetApplicationByJobIDAndUserID(int jobID, int userID)
    {
        return DALManager.Instance.Application.GetApplicationByJobIDAndUserID(jobID, userID);
    }

    //add application
    public void AddApplication(ApplicationModel application)
    {
        DALManager.Instance.Application.AddApplication(application);
    }
}