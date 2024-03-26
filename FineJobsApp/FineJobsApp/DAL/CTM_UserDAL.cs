using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineJobsApp.DAL
{
    internal class CTM_UserDAL
    {
        private string connectionString;

        public CTM_UserDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        s
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
                            return new UserModel((int)reader["UserID"],
                                (string)reader["Username"],
                                (string)reader["Password"],
                                (string)reader["Email"],
                                (string)reader["UserType"],
                                Convert.ToDateTime(reader["CreatedAt"])
                            );
                        }
                    }
                }
            }
            return null;
        }

        public UserModel CTM_GetUserByEmail(string email)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Users WHERE Email = @Email";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new UserModel((int)reader["UserID"],
                                (string)reader["Username"],
                                (string)reader["Password"],
                                (string)reader["Email"],
                                (string)reader["UserType"],
                                Convert.ToDateTime(reader["CreatedAt"])
                            );
                        }
                    }
                }
            }
            return null;
        }


        public void CTM_AddUser(UserModel user)
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

        public void CTM_UpdateUser(UserModel user)
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

        public void CTM_DeleteUser(int userID)
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
}
