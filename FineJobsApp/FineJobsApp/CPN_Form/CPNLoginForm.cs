﻿using FineJobsApp.CPN_Form;
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
    public partial class CPNLoginForm : MaterialForm
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

        public CPNLoginForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void EmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void TittleLable_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ControllerManager.Instance.UserController.Login(EmailTextbox.Text, PasswordTextbox.Text, "Company"))
            {
                this.Hide();
                FormManager.ShowForm<CPNHomeForm>();
            }
            else
            {
                MessageBox.Show("Email or Password is incorrect");
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.ShowForm<CPNSignUpForm>();
        }

        private void PasswordTextbox_Click_1(object sender, EventArgs e)
        {

        }

        private void EmailTextbox_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.ShowForm<CPNForgotPasswordForm>();
        }

        private void CPNLoginForm_Load(object sender, EventArgs e)
        {
            EmailTextbox.Text = "info@techinc.com";
            PasswordTextbox.Text = "hashed_password_4";
        }

        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
