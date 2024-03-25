public class CompanyProfileModel
{
    public int CompanyProfileID;
    public int UserID;
    public string CompanyName;
    public string Description;
    public string Industry;
    public string Website;
    public string ContactInfo;
    public DateTime CreatedAt;
}

public class ContactInformation
{
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public ContactInformation(string address, string phone, string email)
    {
        Address = address;
        Phone = phone;
        Email = email;
    }

    public ContactInformation(string contactInfo)
    {
        var lines = contactInfo.Split('\n');

        foreach (var line in lines)
        {
            if (line.StartsWith("Address:"))
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
        return $"Address: {Address}\nPhone: {Phone}\nEmail: {Email}";
    }
}
