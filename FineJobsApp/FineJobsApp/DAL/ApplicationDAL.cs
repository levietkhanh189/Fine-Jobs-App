using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class ApplicationDAL
{
    private string connectionString;

    public ApplicationDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<ApplicationModel> GetApplicationsByJobID(int jobID)
    {
        List<ApplicationModel> applications = new List<ApplicationModel>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE JobID = @JobID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@JobID", jobID);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ApplicationModel application = new ApplicationModel();
                application.ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                application.JobID = Convert.ToInt32(reader["JobID"]);
                application.ApplicantID = Convert.ToInt32(reader["ApplicantID"]);
                application.Status = reader["Status"].ToString();
                application.ApplyDate = Convert.ToDateTime(reader["ApplyDate"]);
                applications.Add(application);
            }
            connection.Close();
        }
        return applications;
    }   
    
    public void AddApplication(ApplicationModel application)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "INSERT INTO Application (JobID, ApplicantID, Status, ApplyDate) VALUES (@JobID, @UserID, @Status, @ApplyDate)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@JobID", application.JobID);
            command.Parameters.AddWithValue("@UserID", application.ApplicantID);
            command.Parameters.AddWithValue("@Status", application.Status);
            command.Parameters.AddWithValue("@ApplyDate", application.ApplyDate);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    public void UpdateApplicationStatus(int applicationId, string status)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string sql = "UPDATE Applications SET Status = @Status WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

}