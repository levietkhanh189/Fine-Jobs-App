using System;
using System.Collections.Generic;
using Npgsql; // Use Npgsql for PostgreSQL
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM CompanyProfiles WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                using (NpgsqlDataReader reader = command.ExecuteReader())
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
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"]) // Assuming ApplyDate is a mistake and should be CreatedAt
                        };
                    }
                }
            }
        }
        return null;
    }

    public void AddCompanyProfile(CompanyProfileModel companyProfile)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO CompanyProfiles (UserID, CompanyName, Description, Industry, Website, ContactInfo, CreatedAt) VALUES (@UserID, @CompanyName, @Description, @Industry, @Website, @ContactInfo, @CreatedAt)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE CompanyProfiles SET CompanyName = @CompanyName, Description = @Description, Industry = @Industry, Website = @Website, ContactInfo = @ContactInfo WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
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

    public List<CompanyProfileModel> GetAllCompanies()
    {
        List<CompanyProfileModel> companies = new List<CompanyProfileModel>();

        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT * FROM CompanyProfiles";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CompanyProfileModel company = new CompanyProfileModel
                        {
                            CompanyProfileID = (int)reader["CompanyProfileID"],
                            UserID = (int)reader["UserID"],
                            CompanyName = (string)reader["CompanyName"],
                            Description = (string)reader["Description"],
                            Industry = (string)reader["Industry"],
                            Website = (string)reader["Website"],
                            ContactInfo = (string)reader["ContactInfo"],
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        };

                        companies.Add(company);
                    }
                }
            }
        }

        return companies;
    }

    public CompanyProfileModel GetCompanyProfileByCompanyID(int companyId)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM CompanyProfiles WHERE CompanyId = @CompanyId";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@CompanyId", companyId);
                using (NpgsqlDataReader reader = command.ExecuteReader())
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
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"]) // Assuming ApplyDate is a mistake and should be CreatedAt
                        };
                    }
                }
            }
        }
        return null;
    }


}
