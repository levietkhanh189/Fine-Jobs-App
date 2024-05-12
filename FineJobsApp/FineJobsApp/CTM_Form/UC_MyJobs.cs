using FineJobsApp.CTM_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up.CTM_Form
{
    public partial class UC_MyJobs : UserControl
    {
        public UC_MyJobs()
        {
            InitializeComponent();
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            // Lấy danh sách đơn ứng tuyển của người dùng hiện tại
            List<ApplicationModel> applications = ControllerManager.Instance.ApplicationController.GetApplicationsByUserId(ControllerManager.Instance.UserModel.UserID);

            if (applications.Count > 0)
            {
                int totalHeight = 0; // Sử dụng totalHeight thay vì totalWidth
                int verticalSpacing = 40; // Khoảng cách giữa các UserControl theo chiều dọc

                foreach (ApplicationModel application in applications)
                {
                    // Lấy thông tin công việc từ ApplicationModel
                    JobModel job = ControllerManager.Instance.JobController.GetJob(application.JobID);

                    // Tạo UserControl JobInfor với thông tin công việc và trạng thái apply
                    CTM_Application ucjob = new CTM_Application(job, application);

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
                panel1.Size = new Size(panel3.Width, totalHeight);
            }
            else
            {
                MessageBox.Show("Bạn chưa nộp đơn ứng tuyển nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        


    }
}
