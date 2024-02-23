using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Users WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                using (SqlDataReader reader = command.ExecuteReader())
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
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO Users (Username, Password, Email, UserType, CreatedAt) VALUES (@Username, @Password, @Email, @UserType, @CreatedAt)";
            using (SqlCommand command = new SqlCommand(sql, connection))
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
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "UPDATE Users SET Username = @Username, Password = @Password, Email = @Email, UserType = @UserType WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
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
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "DELETE FROM Users WHERE UserID = @UserID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@UserID", userID);
                command.ExecuteNonQuery();
            }
        }
    }
}