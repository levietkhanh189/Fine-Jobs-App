using System;

public class ProfileController
{
    public ProfileController()
    {
    }

    public ProfileModel GetProfile(int profileId)
    {
        return DALManager.Instance.Profile.GetProfileByProfileID(profileId);
    }

    public void AddOrUpdateProfile(ProfileModel profileModel)
    {
        // Xử lý thêm hoặc cập nhật hồ sơ
    }
}