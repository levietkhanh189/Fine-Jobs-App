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
        private JobFormType formType;
        private JobModel jobModel;

        public void InitializeJobComponents(JobFormType formType, string jobName = "", string jobType = "", string salary = "", string skill = "", string description = "", string location = "")
        {
            this.formType = formType;
            SetupFormType(formType);
            JobNameTextbox.Text = jobName;

            JobType.SelectedIndex = JobType.Items.IndexOf(jobType);
            SalaryTextbox.Text = salary;
            LocationTextbox.Text = location;
            DescriptionTextbox.Text = description;
            if (skill != "")
                SkillText.Text = $"Skills: {skill}";
            else
                SkillText.Text = "You need to add direct skills.";
        }

        public void AddJobModel(JobModel jobModel)
        {
            this.jobModel = jobModel;
        }

        public void SetupFormType(JobFormType formType)
        {
            if (formType == JobFormType.Create)
            {
                LockControl(false);
                SaveButton.Text = "Create";
            }
            else
            {
                LockControl(true);
                SaveButton.Text = "Change It";
            }
        }
        bool isShow = false;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(formType == JobFormType.Create)
            {
                CreateJob();
                this.Hide();
            }
            else
            {
                if (isShow == false) 
                {
                    LockControl(false);
                }
                else
                {
                    UpdateJob();
                    LockControl(true);
                }
            }
        }

        private void CreateJob()
        {
            jobModel = new JobModel();
            jobModel.Title = JobNameTextbox.Text;
            jobModel.Location = LocationTextbox.Text;
            jobModel.JobType = JobType.Text;
            jobModel.SalaryRange = SalaryTextbox.Text;
            jobModel.SkillRequirements = SkillTextBox.Text;
            jobModel.Description = DescriptionTextbox.Text;
            jobModel.CreatedAt = DateTime.Now;
            jobModel.Status = "Active";
            jobModel.CompanyID = ControllerManager.Instance.UserModel.UserID;
            ControllerManager.Instance.JobController.AddJob(jobModel);
        }

        private void UpdateJob()
        {
            if (jobModel == null)
            {
                jobModel.Title = JobNameTextbox.Text;
                jobModel.Location = LocationTextbox.Text;
                jobModel.JobType = JobType.Text;
                jobModel.SalaryRange = SalaryTextbox.Text;
                jobModel.SkillRequirements = SkillTextBox.Text;
                jobModel.Description = DescriptionTextbox.Text;
                ControllerManager.Instance.JobController.UpdateJob(jobModel);
            }
        }

        public void LockControl(bool value)
        {
            isShow = !value;
            JobNameTextbox.Enabled = !value;
            JobType.Enabled = !value;
            SalaryTextbox.Enabled = !value;
            DescriptionTextbox.Enabled = !value;
            SkillTextBox.Enabled = !value;
            LocationTextbox.Enabled = !value;
        }

        private void SkillTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SkillTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CPNCreateNewJob_Load(object sender, EventArgs e)
        {

        }


    }
    public enum JobFormType
    {
        Create,
        Update
    }
}
