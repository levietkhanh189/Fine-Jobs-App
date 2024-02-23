using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class CompanyProfileDAL
{
    private string connectionString;

    public CompanyProfileDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public CompanyProfileModel GetCompanyProfileByUserID(int userId)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM CompanyProfile WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new CompanyProfileModel
                        {
                            CompanyProfileID = (int)reader["CompanyProfileID"],
                            UserID = (int)reader["UserID"],
                            CompanyName = (string)reader["CompanyName"],
                            Description = (string)reader["Description"],
                            Industry = (string)reader["Industry"],
                            Website = (string)reader["Website"],
                            ContactInfo = (string)reader["ContactInfo"],
                            CreatedAt = Convert.ToDateTime(reader["ApplyDate"])
                        };
                    }
                }
            }
        }
        return null;
    }

    public void AddCompanyProfile(CompanyProfileModel companyProfile)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO CompanyProfile (UserID, CompanyName, Description, Industry, Website, ContactInfo, CreatedAt) VALUES (@UserID, @CompanyName, @Description, @Industry, @Website, @ContactInfo, @CreatedAt)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", companyProfile.UserID);
                command.Parameters.AddWithValue("@CompanyName", companyProfile.CompanyName);
                command.Parameters.AddWithValue("@Description", companyProfile.Description);
                command.Parameters.AddWithValue("@Industry", companyProfile.Industry);
                command.Parameters.AddWithValue("@Website", companyProfile.Website);
                command.Parameters.AddWithValue("@ContactInfo", companyProfile.ContactInfo);
                command.Parameters.AddWithValue("@CreatedAt", companyProfile.CreatedAt);
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateCompanyProfile(CompanyProfileModel companyProfile)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE CompanyProfile SET CompanyName = @CompanyName, Description = @Description, Industry = @Industry, Website = @Website, ContactInfo = @ContactInfo WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@CompanyName", companyProfile.CompanyName);
                command.Parameters.AddWithValue("@Description", companyProfile.Description);
                command.Parameters.AddWithValue("@Industry", companyProfile.Industry);
                command.Parameters.AddWithValue("@Website", companyProfile.Website);
                command.Parameters.AddWithValue("@ContactInfo", companyProfile.ContactInfo);
                command.Parameters.AddWithValue("@UserID", companyProfile.UserID);
                command.ExecuteNonQuery();
            }
        }
    }

}