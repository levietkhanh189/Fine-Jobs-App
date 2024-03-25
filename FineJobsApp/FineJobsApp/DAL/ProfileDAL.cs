using System;
using System.Collections.Generic;
using Npgsql; // Use Npgsql for PostgreSQL
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Profiles WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userId);
                using (NpgsqlDataReader reader = command.ExecuteReader())
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

    public ProfileModel GetProfileByProfileID(int profileId)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Profiles WHERE ProfileID = @ProfileID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ProfileID", profileId);
                using (NpgsqlDataReader reader = command.ExecuteReader())
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO Profiles (UserID, FullName, Skills, Experience, Education, ResumeLink) VALUES (@UserID, @FullName, @Skills, @Experience, @Education, @ResumeLink)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
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
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE Profiles SET FullName = @FullName, Skills = @Skills, Experience = @Experience, Education = @Education, ResumeLink = @ResumeLink WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
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