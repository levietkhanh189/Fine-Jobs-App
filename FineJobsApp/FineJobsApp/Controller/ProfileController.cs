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

    public List<ProfileModel> SearchProfiles(string keyword)
    {
        return DALManager.Instance.Profile.SearchProfiles(keyword);
    }

    public List<ProfileModel> GetAllProfiles()
    {
        return DALManager.Instance.Profile.GetAllProfiles();
    }

    public void AddOrUpdateProfile(ProfileModel profileModel)
    {
        // Xử lý thêm hoặc cập nhật hồ sơ
    }

    public void AddProfile(ProfileModel profile)
    {
        DALManager.Instance.Profile.AddProfile(profile);
    }
}