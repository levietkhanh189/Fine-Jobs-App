using FineJobsApp.CPN_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp
{
    public partial class CPNDashboardTab : UserControl
    {
        public CPNDashboardTab()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormManager.GetForm<CPNHomeForm>().ChangeTab<CPNApplicationHistoryTab>(HomeTab.ApplicationHistoryTab);
        }
    }
}
