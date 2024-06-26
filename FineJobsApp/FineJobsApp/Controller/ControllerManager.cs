using FineJobsApp.Controller;
using System;

public class ControllerManager
{
    private static ControllerManager instance;
    public static ControllerManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ControllerManager();
            }
            return instance;
        }
    }
    public UserController UserController { get; private set; }

    public CTM_UserController CTM_UserController { get; private set; }

    public ProfileController ProfileController { get; private set; }
    public JobController JobController { get; private set; }
    public ApplicationController ApplicationController { get; private set; }
    public MessageController MessageController { get; private set; }
    public CompanyProfileController CompanyProfileController { get; private set; }
    public UserModel UserModel { get; private set; }
    public ControllerManager()
    {
        InitializeControllers();
    }

    private void InitializeControllers()
    {
        UserController = new UserController();
        CTM_UserController = new CTM_UserController();
        ProfileController = new ProfileController();
        JobController = new JobController();
        ApplicationController = new ApplicationController();
        MessageController = new MessageController();
        CompanyProfileController = new CompanyProfileController();
    }

    public void SetUserModel(UserModel userModel)
    {
        if (userModel.UserType == "HR")
        {
            userModel.UserID = Convert.ToInt32(userModel.Username);
        }

        UserModel = userModel;
    }
}