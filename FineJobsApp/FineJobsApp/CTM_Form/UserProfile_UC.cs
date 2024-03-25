using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class UserProfile_UC : UserControl
    {
        public UserProfile_UC()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }
    }
}
