using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp.CPN_Form
{
    public partial class CPNApplication : UserControl
    {
        public CPNApplication()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //CustomList Using UserControl And FlowLayoutPanel
        public void InitializeComponentsValues(string appName, string jobTitle, string education, string experience, string skills, string statusOption)
        {
            ApplicationName.Text = appName;
            JobTittle.Text = jobTitle;
            Education.Text = education;
            Experience.Text = experience;
            Skills.Text = skills;
            StatusCombox.Text = statusOption;
            StatusCombox.Enabled = false;
        }


    }
}
