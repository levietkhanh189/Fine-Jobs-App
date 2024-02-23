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

    public UserDAL User { get; private set; }
    public ProfileDAL Profile { get; private set; }
    public JobDAL Job { get; private set; }
    public ApplicationDAL Application { get; private set; }
    public MessageDAL Message { get; private set; }
    public CompanyProfileDAL CompanyProfile { get; private set; }

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