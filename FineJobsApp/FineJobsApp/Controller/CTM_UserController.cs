using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineJobsApp.Controller
{
    public class CTM_UserController
    {
        public static int CTM_userCode;
        public CTM_UserController()
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
            CTM_userCode = MailController.SendEmailCode(username);
        }

        public bool Register(UserModel userModel, string code)
        {
            if (CTM_userCode != int.Parse(code))
            {
                return false;
            }
            DALManager.Instance.User.AddUser(userModel);
            return true;
        }

        public bool RegisterCompany(UserModel userModel, string code)
        {
            if (CTM_userCode != int.Parse(code))
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
}
