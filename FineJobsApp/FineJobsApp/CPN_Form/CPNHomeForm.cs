﻿using MaterialSkin.Controls;
using MaterialSkin;
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
using FineJobsApp.CPN_Form;

namespace FineJobsApp
{
    public partial class CPNHomeForm : MaterialForm
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

        public CPNHomeForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SetUpUserControl();
        }

        public void SetUpUserControl()
        {
            AddUserControl(new CPNDashboardTab(), 0);
            AddUserControl(new CPNCompanyInfoTab(), 1);
            AddUserControl(new CPNListJobsTab(), 2);
            AddUserControl(new CPNApplicationHistoryTab(), 3);
            AddUserControl(new CPNMessagesTab(), 4);
            AddUserControl(new CPNSettingTab(), 5);
            AddUserControl(new CPNExitTab(), 6);
        }

        public void AddUserControl(UserControl userControl,int index)
        {
            userControl.Dock = DockStyle.Fill;
            HomeTabControl.TabPages[index].Controls.Add(userControl);
        }
    }
}
