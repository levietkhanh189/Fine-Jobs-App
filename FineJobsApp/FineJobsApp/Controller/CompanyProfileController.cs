using System;

public class CompanyProfileController
{
    public CompanyProfileController()
    {
    }

    public void CreateFirstCompanyProfile(UserModel userModel)
    {
        CompanyProfileModel companyProfile = new CompanyProfileModel();
        companyProfile.UserID = ControllerManager.Instance.UserController.GetUserID(userModel.Email);
        companyProfile.CompanyName = userModel.Username;
        companyProfile.CreatedAt = userModel.CreatedAt;
        companyProfile.Industry = "Unknown";
        companyProfile.Description = "Unknown";
        companyProfile.Website = "Unknown";
        companyProfile.ContactInfo = "Unknown";
        DALManager.Instance.CompanyProfile.AddCompanyProfile(companyProfile);

    }

    public void UpdateCompanyProfile(CompanyProfileModel companyProfileModel)
    {
        DALManager.Instance.CompanyProfile.UpdateCompanyProfile(companyProfileModel);
    }

    public CompanyProfileModel GetCompanyProfileByUserID(int userID)
    {
        return DALManager.Instance.CompanyProfile.GetCompanyProfileByUserID(userID);
    }

    public List<CompanyProfileModel> GetAllCompanies()
    {
        return DALManager.Instance.CompanyProfile.GetAllCompanies();

    }

    public CompanyProfileModel GetCompanyProfile(int userID)
    {
        return DALManager.Instance.CompanyProfile.GetCompanyProfileByUserID(userID);

    }

    public CompanyProfileModel GetCompanyByID(int companyID)
    {
        return DALManager.Instance.CompanyProfile.GetCompanyProfileByUserID(companyID);

    }
}