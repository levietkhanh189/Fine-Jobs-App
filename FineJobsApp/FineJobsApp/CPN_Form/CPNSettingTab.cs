using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CPN_Form
{
    public partial class CPNSettingTab : UserControl
    {
        public List<UserModel> Models = new List<UserModel>();
        private int userID;
        public CPNSettingTab()
        {
            InitializeComponent();
        }

        private void CPNSettingTab_Load(object sender, EventArgs e)
        {
            userID = ControllerManager.Instance.UserModel.UserID;
        }

        public void LoadData()
        {
            Models = ControllerManager.Instance.UserController.GetUserModels(userID + "");
            LoadUsers(Models);
        }

        public void LoadUsers(List<UserModel> userModels)
        {
            scrollview.Controls.Clear();
            foreach (var user in userModels)
            {
                scrollview.Controls.Add(CPNHumanResource(user));
            }
        }

        public CPNHumanResource CPNHumanResource(UserModel user)
        {
            CPNHumanResource humanResource = new CPNHumanResource();
            humanResource.InitializeComponentsValues(user);
            return humanResource;
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel(userID+"",PasswordTextbox.Text,EmailTextbox.Text,"HR",DateTime.Now);
            ControllerManager.Instance.UserController.RegisterHR(user);
            LoadData();
            PasswordTextbox.Text = "";
            EmailTextbox.Text = "";
        }
    }
}
