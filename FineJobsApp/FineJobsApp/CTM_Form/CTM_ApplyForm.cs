using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CTM_Form
{
    public partial class CTM_ApplyForm : Form
    {
        // Tạo một biến để lưu trữ thông tin cá nhân khi người dùng nhập
        private ProfileModel profile;

        public CTM_ApplyForm(JobModel job)
        {
            InitializeComponent();
            JobName.Text = job.Title;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem các trường thông tin có được nhập đầy đủ không
            if (string.IsNullOrEmpty(textBoxFullName.Text) ||
                string.IsNullOrEmpty(textBoxSkills.Text) ||
                string.IsNullOrEmpty(textBoxExperience.Text) ||
                string.IsNullOrEmpty(textBoxEducation.Text) ||
                string.IsNullOrEmpty(textBoxResumeLink.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo đối tượng ProfileModel và gán giá trị từ các control trên giao diện
            profile = new ProfileModel
            {
                FullName = textBoxFullName.Text,
                Skills = textBoxSkills.Text,
                Experience = textBoxExperience.Text,
                Education = textBoxEducation.Text,
                ResumeLink = textBoxResumeLink.Text
            };

            // Sau khi người dùng nhập thông tin và nhấn nút "Apply", bạn có thể sử dụng đối tượng profile để làm gì đó, ví dụ: lưu vào cơ sở dữ liệu hoặc gửi thông tin đến nhà tuyển dụng.

            // Ví dụ:
            // ControllerManager.Instance.ProfileController.SubmitProfile(profile);
            ControllerManager.Instance.ProfileController.AddProfile(profile);

            // Sau khi hoàn thành quá trình ứng tuyển, bạn có thể hiển thị thông báo hoặc thực hiện hành động khác
            MessageBox.Show("Đã gửi đơn ứng tuyển thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form ứng tuyển sau khi hoàn thành
        }
    }
}

