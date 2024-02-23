public class JobModel
{
    public int JobID;
    public int CompanyID;
    public string Title;
    public string Description;
    public string SkillRequirements;// JSON hoặc XML chứa yêu cầu kỹ năng
    public string SalaryRange;
    public string Location;
    public string JobType; // 'Full-time', 'Part-time', v.v.
    public DateTime CreatedAt;
    public string Status; // 'Open', 'Closed'
}