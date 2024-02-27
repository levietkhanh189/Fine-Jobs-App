using System;
using System.Collections.Generic;
using Npgsql; // Use Npgsql for PostgreSQL
using System.Linq;

public class UserDAL
{
    private string connectionString;

    public UserDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public UserModel GetUserByID(int userID)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Users WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserModel
                        {
                            UserID = (int)reader["UserID"],
                            Username = (string)reader["Username"],
                            Password = (string)reader["Password"],
                            Email = (string)reader["Email"],
                            UserType = (string)reader["UserType"],
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        };
                    }
                }
            }
        }
        return null;
    }

    public void AddUser(UserModel user)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO Users (Username, Password, Email, UserType, CreatedAt) VALUES (@Username, @Password, @Email, @UserType, @CreatedAt)";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@UserType", user.UserType);
                command.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);
                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateUser(UserModel user)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE Users SET Username = @Username, Password = @Password, Email = @Email, UserType = @UserType WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@UserType", user.UserType);
                command.Parameters.AddWithValue("@UserID", user.UserID);
                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteUser(int userID)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string sql = "DELETE FROM Users WHERE UserID = @UserID";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                command.ExecuteNonQuery();
            }
        }
    }
}