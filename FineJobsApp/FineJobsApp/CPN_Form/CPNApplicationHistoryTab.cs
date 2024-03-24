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
    public partial class CPNApplicationHistoryTab : UserControl
    {
        public CPNApplicationHistoryTab()
        {
            InitializeComponent();
        }

        private void CPNApplicationHistoryTab_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                scrollview.Controls.Add(new CPNApplication());
            }
        }
    }
}
