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
    public partial class CPNJob : UserControl
    {
        public CPNJob()
        {
            InitializeComponent();
        }

        private void FindApplication_Click(object sender, EventArgs e)
        {

        }

        public void InitializeJobComponents(string jobName, string jobType, string jobStatus, string countText)
        {
            JobName.Text = jobName;

            JobType.Text = jobType;

            JobStatus.Text = jobStatus;
             CountText.Text = countText;
        }

    }
}
