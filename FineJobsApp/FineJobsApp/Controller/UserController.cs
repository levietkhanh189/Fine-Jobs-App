using AnimationSliding_Sign_In_Sign_Up;
using FineJobsApp;
using FineJobsApp.Controller;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

public class UserController
{
    public static int userCode;
    public UserController()
    {
    }

    public bool Login(string username, string password, string type)
    {
        UserModel user = DALManager.Instance.User.GetUserByEmail(username);
        if (user == null || user.Password != password)
        {
            return false;  
        }

        ControllerManager.Instance.SetUserModel(user);
        return true;
    }


    public void SendCode(string username)
    {
        userCode = MailController.SendEmailCode(username);
    }

    public bool Register(UserModel userModel,string code)
    {
        if(userCode != int.Parse(code))
        {
            return false;
        }
        DALManager.Instance.User.AddUser(userModel);
        return true;
    }

    public bool RegisterCompany(UserModel userModel, string code)
    {
        if (userCode != int.Parse(code))
        {
            return false;
        }
        DALManager.Instance.User.AddUser(userModel);
        return true;
    }

    public int GetUserID(string email)
    {
        UserModel user = DALManager.Instance.User.GetUserByEmail(email);
        return user.UserID;
    }

    public UserModel GetUserByUserID(int userId)
    {
        UserModel user = DALManager.Instance.User.GetUserByID(userId);
        return user;
    }

    public bool UpdateUser(UserModel userModel)
    {
        UserModel user = DALManager.Instance.User.GetUserByID(userModel.UserID);
        if (user == null)
        {
            return false;
        }
        DALManager.Instance.User.UpdateUser(userModel);
        return true;
    }
}