public class UserModel
{
    public int UserID;
    public string Username;
    public string Password; // Lưu ý: Mật khẩu nên được mã hóa khi lưu trữ và xử lý
    public string Email;
    public string UserType; // 'Applicant' hoặc 'Company'
    public DateTime CreatedAt;

    public UserModel(string username, string password, string email, string userType, DateTime createdAt)
    {
        Username = username;
        Password = password;
        Email = email;
        UserType = userType;
        CreatedAt = createdAt;
    }

    public UserModel(int userID, string username, string password, string email, string userType, DateTime createdAt)
    {
        UserID = userID;
        Username = username;
        Password = password;
        Email = email;
        UserType = userType;
        CreatedAt = createdAt;
    }
}