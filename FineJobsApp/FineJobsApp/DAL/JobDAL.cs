using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class JobDAL
{
    private string connectionString;

    public JobDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<JobModel> GetJobs()
    {
        List<JobModel> jobs = new List<JobModel>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Jobs";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                JobModel job = new JobModel();
                job.JobID = Convert.ToInt32(reader["JobID"]);
                job.CompanyID = Convert.ToInt32(reader["CompanyID"]);
                job.Title = reader["Title"].ToString();
                job.Description = reader["Description"].ToString();
                job.SkillRequirements = reader["SkillRequirements"].ToString();
                job.Location = reader["Location"].ToString();
                job.SalaryRange = reader["SalaryRange"].ToString();
                job.JobType = reader["JobType"].ToString();
                job.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
                job.Status = reader["Status"].ToString();
                jobs.Add(job);
            }
            connection.Close();
        }
        return jobs;
    }

    public void AddJob(JobModel job)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "INSERT INTO Jobs (CompanyID, Title, Description, SkillRequirements, SalaryRange, Location, JobType, CreatedAt, Status) VALUES (@CompanyID, @Title, @Description, @SkillRequirements, @SalaryRange, @Location, @JobType, @CreatedAt, @Status)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CompanyID", job.CompanyID);
            command.Parameters.AddWithValue("@Title", job.Title);
            command.Parameters.AddWithValue("@Description", job.Description);
            command.Parameters.AddWithValue("@SkillRequirements", job.SkillRequirements);
            command.Parameters.AddWithValue("@SalaryRange", job.SalaryRange);
            command.Parameters.AddWithValue("@Location", job.Location);
            command.Parameters.AddWithValue("@JobType", job.JobType);
            command.Parameters.AddWithValue("@CreatedAt", job.CreatedAt);
            command.Parameters.AddWithValue("@Status", job.Status);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void UpdateJob(JobModel job)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "UPDATE Jobs SET CompanyID = @CompanyID, Title = @Title, Description = @Description, SkillRequirements = @SkillRequirements, SalaryRange = @SalaryRange, Location = @Location, JobType = @JobType, CreatedAt = @CreatedAt, Status = @Status WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CompanyID", job.CompanyID);
            command.Parameters.AddWithValue("@Title", job.Title);
            command.Parameters.AddWithValue("@Description", job.Description);
            command.Parameters.AddWithValue("@SkillRequirements", job.SkillRequirements);
            command.Parameters.AddWithValue("@SalaryRange", job.SalaryRange);
            command.Parameters.AddWithValue("@Location", job.Location);
            command.Parameters.AddWithValue("@JobType", job.JobType);
            command.Parameters.AddWithValue("@CreatedAt", job.CreatedAt);
            command.Parameters.AddWithValue("@Status", job.Status);
            command.Parameters.AddWithValue("@JobID", job.JobID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void DeleteJob(int jobID)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "DELETE FROM Jobs WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@JobID", jobID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}