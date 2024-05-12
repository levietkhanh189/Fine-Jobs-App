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

    public List<ApplicationModel> GetApplicationsForToday(int companyId)
    {
        List<ApplicationModel> applications = new List<ApplicationModel>();
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE ApplyDate >= CURRENT_DATE AND ApplyDate < CURRENT_DATE + INTERVAL '1 day' AND JobID IN (SELECT JobID FROM Jobs WHERE CompanyID = @CompanyID)";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CompanyID", companyId);

            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ApplicationModel application = new ApplicationModel
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                    JobID = Convert.ToInt32(reader["JobID"]),
                    ApplicantID = Convert.ToInt32(reader["ApplicantID"]),
                    Status = reader["Status"].ToString(),
                    ApplyDate = Convert.ToDateTime(reader["ApplyDate"])
                };
                applications.Add(application);
            }
            connection.Close();
        }
        return applications;
    }


    public List<ApplicationModel> GetApplicationsByStatus(string status, int companyId)
    {
        List<ApplicationModel> applications = new List<ApplicationModel>();
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE Status = @Status AND JobID IN (SELECT JobID FROM Jobs WHERE CompanyID = @CompanyID)";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Status", status);
            command.Parameters.AddWithValue("@CompanyID", companyId);

            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ApplicationModel application = new ApplicationModel
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                    JobID = Convert.ToInt32(reader["JobID"]),
                    ApplicantID = Convert.ToInt32(reader["ApplicantID"]),
                    Status = reader["Status"].ToString(),
                    ApplyDate = Convert.ToDateTime(reader["ApplyDate"])
                };
                applications.Add(application);
            }
            connection.Close();
        }
        return applications;
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

    public List<ApplicationModel> SearchApplications(string keyword, int companyId)
    {
        List<ApplicationModel> applications = new List<ApplicationModel>();
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = @"
            SELECT * FROM Applications 
            WHERE (CAST(ApplicationID AS TEXT) LIKE @Keyword 
                OR CAST(JobID AS TEXT) LIKE @Keyword 
                OR CAST(ApplicantID AS TEXT) LIKE @Keyword 
                OR Status LIKE @Keyword) 
                AND JobID IN (SELECT JobID FROM Jobs WHERE CompanyID = @CompanyID)";

            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
            command.Parameters.AddWithValue("@CompanyID", companyId);

            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ApplicationModel application = new ApplicationModel
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]),
                    JobID = Convert.ToInt32(reader["JobID"]),
                    ApplicantID = Convert.ToInt32(reader["ApplicantID"]),
                    Status = reader["Status"].ToString(),
                    ApplyDate = Convert.ToDateTime(reader["ApplyDate"])
                };
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

    public List<ApplicationModel> GetApplicationsByUserID(int userID)
    {
        List<ApplicationModel> applications = new List<ApplicationModel>();
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE ApplicantID = @UserID";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@UserID", userID);
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
            string checkSql = "SELECT COUNT(*) FROM Applications WHERE JobID = @JobID AND ApplicantID = @UserID";
            NpgsqlCommand checkCommand = new NpgsqlCommand(checkSql, connection);
            checkCommand.Parameters.AddWithValue("@JobID", application.JobID);
            checkCommand.Parameters.AddWithValue("@UserID", application.ApplicantID);

            connection.Open();
            int count = Convert.ToInt32(checkCommand.ExecuteScalar());
            connection.Close();

            if (count > 0)
            {
                // Ứng viên đã áp dụng cho công việc này rồi, bạn có thể thông báo ở đây.
                Console.WriteLine("Bạn đã apply cho công việc này rồi.");
                return;
            }

            string insertSql = "INSERT INTO Applications (JobID, ApplicantID, Status, ApplyDate) VALUES (@JobID, @UserID, @Status, @ApplyDate)";
            NpgsqlCommand command = new NpgsqlCommand(insertSql, connection);
            command.Parameters.AddWithValue("@JobID", application.JobID);
            command.Parameters.AddWithValue("@UserID", application.ApplicantID);
            command.Parameters.AddWithValue("@Status", application.Status);
            command.Parameters.AddWithValue("@ApplyDate", application.ApplyDate);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    //lấy thông tin application theo jobID và userID
    public ApplicationModel GetApplicationByJobIDAndUserID(int jobID, int userID)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Applications WHERE JobID = @JobID AND ApplicantID = @UserID";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@JobID", jobID);
            command.Parameters.AddWithValue("@UserID", userID);
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
        return null; // Trả về null nếu không tìm thấy Application với JobID và UserID cung cấp
    }

}
