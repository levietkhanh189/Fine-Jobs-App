using System;

public class MessageController
{
    private DALManager dalManager;

    public MessageController(DALManager dalManager)
    {
        this.dalManager = dalManager;
    }

    public void SendMessage(MessageModel messageModel)
    {
        // Xử lý gửi tin nhắn
    }
}