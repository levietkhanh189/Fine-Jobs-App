using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CPNHumanResource : UserControl
    {
        UserModel user;
        public CPNHumanResource()
        {
            InitializeComponent();
        }

        public void InitializeComponentsValues(UserModel user)
        {
            this.user = user;
            Email.Text = user.Email;
            Password.Text = user.Password;
        }
        bool isDelete = false;
        private void Delete_Click(object sender, EventArgs e)
        {
            if(isDelete == true)
            {
                MessageBox.Show("User has been deleted");
                return;
            }
            isDelete = true;
            ControllerManager.Instance.UserController.DeleteUser(user.UserID);
        }
    }
}
