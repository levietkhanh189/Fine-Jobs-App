using System;
using System.Collections.Generic;

public class DALManager
{
    private static DALManager instance;
    public static DALManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new DALManager();
            }
            return instance;
        }
    }

    private string connectionString = "Server=ep-falling-sea-a1pnxa8v.ap-southeast-1.aws.neon.tech;Database=neondb;User Id=levietkhanh189;Password=60lOBpFIbshP;Port=5432";

    public UserDAL User;
    public ProfileDAL Profile;
    public JobDAL Job;
    public ApplicationDAL Application;
    public MessageDAL Message;
    public CompanyProfileDAL CompanyProfile;

    public DALManager()
    {
        InitializeDALs();
    }

    private void InitializeDALs()
    {
        User = new UserDAL(connectionString);
        Profile = new ProfileDAL(connectionString);
        Job = new JobDAL(connectionString);
        Application = new ApplicationDAL(connectionString);
        Message = new MessageDAL(connectionString);
        CompanyProfile = new CompanyProfileDAL(connectionString);
    }
}