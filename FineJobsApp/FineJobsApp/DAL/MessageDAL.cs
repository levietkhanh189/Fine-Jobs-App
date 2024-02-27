using System;
using System.Collections.Generic;
using Npgsql; // Use Npgsql for PostgreSQL
using System.Linq;

public class MessageDAL
{
    private string connectionString;

    public MessageDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<MessageModel> GetMessagesBetweenUsers(int user1ID, int user2ID)
    {
        List<MessageModel> messages = new List<MessageModel>();
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "SELECT * FROM Messages WHERE (SenderID = @User1ID AND ReceiverID = @User2ID) OR (SenderID = @User2ID AND ReceiverID = @User1ID)";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@User1ID", user1ID);
            command.Parameters.AddWithValue("@User2ID", user2ID);
            connection.Open();
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MessageModel message = new MessageModel();
                message.MessageID = Convert.ToInt32(reader["MessageID"]);
                message.SenderID = Convert.ToInt32(reader["SenderID"]);
                message.ReceiverID = Convert.ToInt32(reader["ReceiverID"]);
                message.MessageText = reader["MessageText"].ToString();
                message.SentAt = Convert.ToDateTime(reader["SentAt"]);
                messages.Add(message);
            }
            connection.Close();
        }
        return messages;
    }

    public void SendMessage(MessageModel message)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            string sql = "INSERT INTO Messages (SenderID, ReceiverID, MessageText, SentAt) VALUES (@SenderID, @ReceiverID, @MessageText, @SentAt)";
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@SenderID", message.SenderID);
            command.Parameters.AddWithValue("@ReceiverID", message.ReceiverID);
            command.Parameters.AddWithValue("@MessageText", message.MessageText);
            command.Parameters.AddWithValue("@SentAt", message.SentAt);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }

    private Task<int> SomeLongRunningOperationAsync()
    {
        return Task.Run(() =>
        {
            // Simulate a long-running task
            Thread.Sleep(5000);
            return 123; // Return some result
        });
    }

}