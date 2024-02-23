public class UserModel
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; } // Lưu ý: Mật khẩu nên được mã hóa khi lưu trữ và xử lý
    public string Email { get; set; }
    public string UserType { get; set; } // 'Applicant' hoặc 'Company'
    public DateTime CreatedAt { get; set; }
}