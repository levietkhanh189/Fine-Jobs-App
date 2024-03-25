using AnimationSliding_Sign_In_Sign_Up.CTM_Form;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class UC_AllJobs : UserControl
    {
        public UC_AllJobs()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        //private void addUserControl(UserControl userControl)
        //{
        //    userControl.Dock = DockStyle.Fill;
        //    panel2.Controls.Clear();
        //    panel2.Controls.Add(userControl);
        //    userControl.BringToFront();
        //}

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormInforCompany formInforCompany = new FormInforCompany();
            formInforCompany.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để người dùng nhập từ khóa tìm kiếm
            string keyword = ""; // Đây là nơi bạn lưu từ khóa tìm kiếm, có thể sử dụng hộp thoại để lấy từ người dùng

            // Gọi hàm tìm kiếm từ JobController
            List<JobModel> searchResults = ControllerManager.Instance.JobController.SearchJobs(keyword);

            // Xóa các UserControl hiện có khỏi panel3
            panel3.Controls.Clear();

            if (searchResults.Count > 0)
            {
                int totalHeight = 0; // Sử dụng totalHeight thay vì totalWidth
                int verticalSpacing = 40; // Khoảng cách giữa các UserControl theo chiều dọc

                foreach (JobModel job in searchResults)
                {
                    // Tạo UserControl JobInfor với thông tin công việc
                    JobInfor ucjob = new JobInfor(job);

                    // Tính toán vị trí để căn giữa UserControl theo chiều ngang
                    int horizontalMargin = (panel3.Width - ucjob.Width) / 2;

                    // Đặt vị trí của UserControl
                    ucjob.Location = new Point(horizontalMargin, totalHeight); // Vị trí theo chiều dọc

                    // Thêm UserControl vào panel3
                    panel3.Controls.Add(ucjob);

                    // Cập nhật lại tổng chiều cao của panel3
                    totalHeight += ucjob.Height + verticalSpacing;
                }

                // Đặt lại kích thước của panel3 để đảm bảo nó đủ lớn để chứa tất cả các UserControl
                panel3.Size = new Size(panel3.Width, totalHeight);
            }
            else
            {
                MessageBox.Show("Không có kết quả phù hợp với từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ApplyJob_UC applyJob_UC = new ApplyJob_UC();
            addUserControl(applyJob_UC);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }

        private void LoadDanhSach()
        {
            // Lấy danh sách công việc từ JobController
            List<JobModel> jobs = ControllerManager.Instance.JobController.GetAllJob();

            if (jobs.Count > 0)
            {
                int totalHeight = 0; // Sử dụng totalHeight thay vì totalWidth
                int verticalSpacing = 40; // Khoảng cách giữa các UserControl theo chiều dọc

                foreach (JobModel job in jobs)
                {
                    // Tạo UserControl JobInfor với thông tin công việc
                    JobInfor ucjob = new JobInfor(job);

                    // Tính toán vị trí để căn giữa UserControl theo chiều ngang
                    int horizontalMargin = (panel3.Width - ucjob.Width) / 2;

                    // Đặt vị trí của UserControl
                    ucjob.Location = new Point(horizontalMargin, totalHeight); // Vị trí theo chiều dọc

                    // Thêm UserControl vào panel3
                    panel3.Controls.Add(ucjob);

                    // Cập nhật lại tổng chiều cao của panel3
                    totalHeight += ucjob.Height + verticalSpacing;
                }

                // Đặt lại kích thước của panel3 để đảm bảo nó đủ lớn để chứa tất cả các UserControl
                panel3.Size = new Size(panel3.Width, totalHeight);
            }
            else
            {
                MessageBox.Show("Không có công việc nào trong danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
