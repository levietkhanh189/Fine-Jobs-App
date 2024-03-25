using AnimationSliding_Sign_In_Sign_Up.CTM_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class TopCompany_UC : UserControl
    {
        public TopCompany_UC()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ReviewCompany_UC reviewCompany_UC = new ReviewCompany_UC();
            addUserControl(reviewCompany_UC);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_AllJobs uC_AllJobs = new UC_AllJobs();
            addUserControl(uC_AllJobs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInforCompany formInforCompany = new FormInforCompany();
            formInforCompany.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();

        }

        private void LoadDanhSach()
        {
            // Lấy danh sách tất cả các công ty
            List<CompanyProfileModel> companies = ControllerManager.Instance.CompanyProfileController.GetAllCompanies();

            if (companies.Count > 0)
            {
                int totalHeight = 0; // Sử dụng totalHeight thay vì totalWidth
                int verticalSpacing = 40; // Khoảng cách giữa các UserControl theo chiều dọc

                foreach (CompanyProfileModel company in companies)
                {
                    // Tạo UserControl UC_InforCompany và cập nhật thông tin của công ty
                    CompanyInfor companyInfor = new CompanyInfor(company);

                    // Tính toán vị trí để căn giữa UserControl theo chiều ngang
                    int horizontalMargin = (panel2.Width - companyInfor.Width) / 2;

                    // Đặt vị trí của UserControl
                    companyInfor.Location = new Point(horizontalMargin, totalHeight); // Vị trí theo chiều dọc

                    // Thêm UserControl vào panel2
                    panel2.Controls.Add(companyInfor);

                    // Cập nhật lại tổng chiều cao của panel2
                    totalHeight += companyInfor.Height + verticalSpacing;
                }

                // Đặt lại kích thước của panel2 để đảm bảo nó đủ lớn để chứa tất cả các UserControl
                panel2.Size = new Size(panel2.Width, totalHeight);
            }
            else
            {
                MessageBox.Show("Không có thông tin công ty nào trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
