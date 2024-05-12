public class ProfileModel
{
    public int ProfileID;
    public int UserID;
    public string FullName;
    public string Skills; // JSON hoặc XML chứa danh sách kỹ năng
    public string Experience;
    public string Education;
    public string ResumeLink;
}

public class CMT_ContactInformation
{
    public string Title { get; set; }

    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public CMT_ContactInformation(string title, DateTime birthdate ,string address, string phone, string email)
    {
        Title = title;
        BirthDate = birthdate;
        Address = address;
        Phone = phone;
        Email = email;
    }

    public CMT_ContactInformation(string contactInfo)
    {
        var lines = contactInfo.Split('\n');

        foreach (var line in lines)
        {
            if (line.StartsWith("Title:"))
            {
                Title = line.Replace("Title:", "").Trim();
            }
            else if (line.StartsWith("BirthDate:"))
            {
                BirthDate = Convert.ToDateTime(line.Replace("BirthDate:", "").Trim());
            }
            else if (line.StartsWith("Address:"))
            {
                Address = line.Replace("Address:", "").Trim();
            }
            else if (line.StartsWith("Phone:"))
            {
                Phone = line.Replace("Phone:", "").Trim();
            }
            else if (line.StartsWith("Email:"))
            {
                Email = line.Replace("Email:", "").Trim();
            }   
        }
    }

    // Hàm chuyển đổi thông tin liên lạc về dạng chuỗi
    public override string ToString()
    {
        return $"Title: {Title}\nBirthDate: {BirthDate}\nAddress: {Address}\nPhone: {Phone}\nEmail: {Email}";
    }
}   