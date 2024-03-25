using System;
using System.Collections.Generic;
using Npgsql; // Replaced System.Data.SqlClient with Npgsql
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE JobID = @JobID";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@JobID", jobID);
            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
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

    public ApplicationModel GetApplicationByApplicationID(int applicationID)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read()) // Sử dụng if thay vì while vì chỉ có một kết quả
            {
                ApplicationModel application = new ApplicationModel
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                    JobID = Convert.ToInt32(reader["JobID"]),
                    ApplicantID = Convert.ToInt32(reader["ApplicantID"]),
                    Status = reader["Status"].ToString(),
                    ApplyDate = Convert.ToDateTime(reader["ApplyDate"])
                };
                connection.Close();
                return application;
            }
        }
        return null; // Trả về null nếu không tìm thấy Application với ID cung cấp
    }


    public void AddApplication(ApplicationModel application)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "INSERT INTO Application (JobID, ApplicantID, Status, ApplyDate) VALUES (@JobID, @UserID, @Status, @ApplyDate)";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "UPDATE Applications SET Status = @Status WHERE ApplicationID = @ApplicationID";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
