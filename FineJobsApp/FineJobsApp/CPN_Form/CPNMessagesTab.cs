using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;

namespace FineJobsApp.CPN_Form
{
    public partial class CPNMessagesTab : UserControl
    {
        public CPNMessagesTab()
        {
            InitializeComponent();
        }
        private void CPNMessagesTab_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://mail.google.com/");
            webView21.ZoomFactor = 0.5;
        }

    }
}
