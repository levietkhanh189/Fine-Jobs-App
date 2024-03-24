using MaterialSkin.Controls;
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

namespace FineJobsApp.CPN_Form
{
    public partial class CPNCreateNewJob : MaterialForm
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

        public CPNCreateNewJob()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void AddSkillBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
