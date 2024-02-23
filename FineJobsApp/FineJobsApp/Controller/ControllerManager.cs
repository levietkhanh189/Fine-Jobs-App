using System;

public class ControllerManager
{
    public UserController UserController { get; private set; }
    public ProfileController ProfileController { get; private set; }
    public JobController JobController { get; private set; }
    public ApplicationController ApplicationController { get; private set; }
    public MessageController MessageController { get; private set; }
    public CompanyProfileController CompanyProfileController { get; private set; }

    private DALManager dalManager;

    public ControllerManager()
    {
        InitializeControllers();
    }

    private void InitializeControllers()
    {
        UserController = new UserController();
        ProfileController = new ProfileController();
        JobController = new JobController();
        ApplicationController = new ApplicationController();
        MessageController = new MessageController();
        CompanyProfileController = new CompanyProfileController();
    }
}