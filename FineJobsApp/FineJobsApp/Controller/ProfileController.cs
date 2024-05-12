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

    public ProfileModel GetProfileByUserID(int userID)
    {
        return DALManager.Instance.Profile.GetProfileByUserID(userID);
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
        ProfileController profileController = new ProfileController();
        ProfileModel existingProfile = profileController.GetProfile(profileModel.userID);

        if (existingProfile != null)
        {
            // Hồ sơ đã tồn tại, cập nhật
            bool updateResult = profileController.UpdateProfile(profileModel);

            if (updateResult)
            {
                Console.WriteLine("Cập nhật hồ sơ thành công.");
            }
            else
            {
                Console.WriteLine("Cập nhật hồ sơ thất bại.");
            }
        }
        else
        {
            // Hồ sơ chưa tồn tại, thêm mới
            profileController.AddProfile(profileModel);
            Console.WriteLine("Thêm mới hồ sơ thành công.");
        }
    }

    public bool UpdateProfile(ProfileModel profile)
    {
        return DALManager.Instance.Profile.UpdateProfile(profile);
    }

    public void AddProfile(ProfileModel profile)
    {
        DALManager.Instance.Profile.AddProfile(profile);
    }

    public void CreateFirstUserProfile(UserModel userModel)
    {
        ProfileModel profileModel = new ProfileModel();
        profileModel.userID = ControllerManager.Instance.UserController.GetUserID(userModel.Email);
        profileModel.fullName = userModel.Username;
        profileModel.skills = "Unknown";
        profileModel.experience = "Unknown";
        profileModel.education = "Unknown";
        profileModel.resumeLink = "Unknown";
        DALManager.Instance.Profile.AddProfile(profileModel);
    }
}