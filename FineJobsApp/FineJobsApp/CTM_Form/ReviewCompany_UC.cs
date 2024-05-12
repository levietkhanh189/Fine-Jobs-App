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
    public partial class ReviewCompany_UC : UserControl
    {
        public ReviewCompany_UC(CompanyProfileModel companyProfileModel)
        {
            InitializeComponent();
            //LoadDanhSach(companyProfileModel);
        }

        private void ReviewCompany_UC_Load_1(object sender, EventArgs e)
        {

        }

        private void LoadDanhSach(CompanyProfileModel companyProfileModel)
        {
            // Lấy danh sách công việc từ JobController
            List<JobModel> jobs = ControllerManager.Instance.JobController.GetJobsByCompany(companyProfileModel.UserID);

            if (jobs.Count > 0)
            {
                int totalHeight = 0; // Sử dụng totalHeight thay vì totalWidth
                int verticalSpacing = 40; // Khoảng cách giữa các UserControl theo chiều dọc

                foreach (JobModel job in jobs)
                {
                    // Tạo UserControl JobInfor với thông tin công việc
                    JobInfor ucjob = new JobInfor(job);

                    // Tính toán vị trí để căn giữa UserControl theo chiều ngang
                    int horizontalMargin = (panel1.Width - ucjob.Width) / 2;

                    // Đặt vị trí của UserControl
                    ucjob.Location = new Point(horizontalMargin, totalHeight); // Vị trí theo chiều dọc

                    // Thêm UserControl vào panel3
                    panel1.Controls.Add(ucjob);

                    // Cập nhật lại tổng chiều cao của panel3
                    totalHeight += ucjob.Height + verticalSpacing;
                }

                // Đặt lại kích thước của panel3 để đảm bảo nó đủ lớn để chứa tất cả các UserControl
                panel1.Size = new Size(panel1.Width, totalHeight);
            }
            else
            {
                MessageBox.Show("Không có công việc nào trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
