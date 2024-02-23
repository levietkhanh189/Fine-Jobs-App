using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

public class ProfileDAL
{
    private string connectionString;

    public ProfileDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public ProfileModel GetProfileByUserID(int userId)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Profile WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ProfileModel
                        {
                            ProfileID = (int)reader["ProfileID"],
                            UserID = (int)reader["UserID"],
                            FullName = (string)reader["FullName"],
                            Skills = (string)reader["Skills"],
                            Experience = (string)reader["Experience"],
                            Education = (string)reader["Education"],
                            ResumeLink = (string)reader["ResumeLink"],
                        };
                    }
                }
            }
        }
        return null;
    }

    public void AddProfile(ProfileModel profile)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO Profile (UserID, FullName, Skills, Experience, Education, ResumeLink) VALUES (@UserID, @FullName, @Skills, @Experience, @Education, @ResumeLink)";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", profile.UserID);
                command.Parameters.AddWithValue("@FullName", profile.FullName);
                command.Parameters.AddWithValue("@Skills", profile.Skills);
                command.Parameters.AddWithValue("@Experience", profile.Experience);
                command.Parameters.AddWithValue("@Education", profile.Education);
                command.Parameters.AddWithValue("@ResumeLink", profile.ResumeLink);
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateProfile(ProfileModel profile)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE Profile SET FullName = @FullName, Skills = @Skills, Experience = @Experience, Education = @Education, ResumeLink = @ResumeLink WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", profile.UserID);
                command.Parameters.AddWithValue("@FullName", profile.FullName);
                command.Parameters.AddWithValue("@Skills", profile.Skills);
                command.Parameters.AddWithValue("@Experience", profile.Experience);
                command.Parameters.AddWithValue("@Education", profile.Education);
                command.Parameters.AddWithValue("@ResumeLink", profile.ResumeLink);
                command.ExecuteNonQuery();
            }
        }
    }

}