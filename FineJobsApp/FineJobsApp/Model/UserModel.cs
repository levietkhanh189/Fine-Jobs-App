public class UserModel
{
    public int UserID;
    public string Username;
    public string Password; // Lưu ý: Mật khẩu nên được mã hóa khi lưu trữ và xử lý
    public string Email;
    public string UserType; // 'Applicant' hoặc 'Company'
    public DateTime CreatedAt;
}