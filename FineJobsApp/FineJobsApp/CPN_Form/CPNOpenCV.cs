using MaterialSkin.Controls;
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
    public partial class CPNOpenCV : MaterialForm
    {
        public CPNOpenCV()
        {
            InitializeComponent();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void CPNOpenCV_Load(object sender, EventArgs e)
        {

        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser(string url)
        {
            await initizated();
            webView21.CoreWebView2.Navigate(url);
            webView21.ZoomFactor = 0.5;
        }
    }
}
