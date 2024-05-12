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

        //tạo biến lấy id của công việc 
        private int jobID;

        public CTM_ApplyForm(JobModel job)
        {
            InitializeComponent();
            JobName.Text = job.Title;
            jobID = job.JobID;
        }

        private void button1_Click(object sender, EventArgs e)
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
                fullName = textBoxFullName.Text,
                skills = textBoxSkills.Text,
                experience = textBoxExperience.Text,
                education = textBoxEducation.Text,
                resumeLink = textBoxResumeLink.Text
            };

            // Sau khi người dùng nhập thông tin và nhấn nút "Apply", bạn có thể sử dụng đối tượng profile để làm gì đó, ví dụ: lưu vào cơ sở dữ liệu hoặc gửi thông tin đến nhà tuyển dụng.

            //update thông tin profile
            ControllerManager.Instance.ProfileController.UpdateProfile(profile);

           //khi profile khác null thì sẽ cập nhật application
           if (profile !=  null)
            {
                //cập nhật đối tượng application
                ApplicationModel application = new ApplicationModel
                {
                    JobID = jobID,
                    ApplicantID = ControllerManager.Instance.UserModel.UserID,
                    ApplyDate = DateTime.Now,
                    Status = "New",
                };

                ControllerManager.Instance.ApplicationController.AddApplication(application);

                // Sau khi hoàn thành quá trình ứng tuyển, bạn có thể hiển thị thông báo hoặc thực hiện hành động khác
                MessageBox.Show("Đã gửi đơn ứng tuyển thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form ứng tuyển sau khi hoàn thành
            }
        }

        private void CTM_ApplyForm_Load(object sender, EventArgs e)
        {
            profile = ControllerManager.Instance.ProfileController.GetProfileByUserID(ControllerManager.Instance.UserModel.UserID);
            if (profile != null)
            {
                profile = ControllerManager.Instance.ProfileController.GetProfileByUserID(ControllerManager.Instance.UserModel.UserID);

                textBoxFullName.Text = profile.fullName;
                textBoxEducation.Text = profile.education;
                textBoxExperience.Text = profile.experience;
                textBoxSkills.Text = profile.skills;
                textBoxResumeLink.Text = profile.resumeLink;
            }
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

