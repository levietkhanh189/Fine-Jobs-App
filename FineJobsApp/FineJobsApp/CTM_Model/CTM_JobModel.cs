using System;

namespace FineJobsApp.CTM_Model
{
    public class CTM_JobModel
    {
        public CTM_JobModel(string ranking, string companyName, string jobTitle, string workType, string location/*, DateTime postedTime*/)
        {
            Ranking = ranking;
            CompanyName = companyName;
            JobTitle = jobTitle;
            WorkType = workType;
            Location = location;
            //PostedTime = postedTime;
        }

        public string Ranking { get; set; } // "#1 NFQ Asia" could be parsed to get the ranking number
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public string WorkType { get; set; } // E.g., "Hybrid"
        public string Location { get; set; }
        //public DateTime PostedTime { get; set; } // If you need to keep track of when the job was posted
    }
}