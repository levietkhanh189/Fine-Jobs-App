using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp
{
    public partial class CPNSignUpForm : MaterialForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse
        );

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Tạo vùng bo tròn cho form
            IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20); // 20, 20 đại diện cho độ rộng và độ cao của elip dùng để tạo góc bo tròn.
            this.Region = Region.FromHrgn(ptr);
            // Giải phóng vùng đã tạo
            DeleteObject(ptr);
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);

        public CPNSignUpForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.ShowForm<CPNLoginForm>();
        }

        private void CodeTextbox_Click(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextbox_Click(object sender, EventArgs e)
        {

        }

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            ControllerManager.Instance.UserController.SendCode(EmailTextbox.Text);
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel(CompanyNameTextbox.Text, PasswordTextbox.Text, EmailTextbox.Text,"Company",DateTime.Now);
            bool status = ControllerManager.Instance.UserController.RegisterCompany(userModel,CodeTextbox.Text);
            if(status)
            {
                ControllerManager.Instance.CompanyProfileController.CreateFirstCompanyProfile(userModel);
                this.Hide();
                FormManager.ShowForm<CPNLoginForm>();
            }
            else
            {
                MessageBox.Show("Code or password is not correct");
            }
        }
    }
}
