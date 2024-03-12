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
    public partial class CPNExitTab : UserControl
    {
        public CPNExitTab()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            FormManager.HideAll();
            FormManager.ShowForm<CPNLoginForm>();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FormManager.ExitApplication();
        }
    }
}
