using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineJobsApp.Services;

public class ServiceManager
{
    private static ServiceManager instance;
    public static ServiceManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ServiceManager();
            }
            return instance;
        }
    }

    public ServiceManager()
    {
        InitializeServices();
    }

    private void InitializeServices()
    {
        Application = new ApplicationService();
        OpenLink = new OpenLink();
    }
    public OpenLink OpenLink;
    public ApplicationService Application;

}

