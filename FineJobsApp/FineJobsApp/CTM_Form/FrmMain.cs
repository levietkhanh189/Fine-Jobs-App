using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AnimationSliding_Sign_In_Sign_Up.FrmLogin;

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class FrmMain : Form
    {
        public string _username;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        public FrmMain(string username)
        {
            InitializeComponent();
            _username = username;
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            webView21.EnsureCoreWebView2Async();
            InitLoadHtml();
        }
        private void InitLoadHtml()
        {

            webView21.CoreWebView2InitializationCompleted += WebView21_CoreWebView2InitializationCompleted;
            webView21.Dock = DockStyle.Fill;
            this.Controls.Add(webView21);
        }

        private void WebView21_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            var uri = new Uri(String.Format("file:///{0}/html/dashboard.html", curDir));
            webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

            webView21.CoreWebView2.Navigate(uri.ToString());
            webView21.WebMessageReceived += WebView21_WebMessageReceived;

            webView21.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
        }

        private async void CoreWebView2_DOMContentLoaded(object sender, Microsoft.Web.WebView2.Core.CoreWebView2DOMContentLoadedEventArgs e)
        {
            await SetUsername("Xin chào, " + _username.ToUpper());
        }

        private  void WebView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            var jsonObject = JsonConvert.DeserializeObject<JsonObject>(e.WebMessageAsJson);
            var idElemnt = jsonObject.Value;
            switch (jsonObject.Key)
            {
                case "click":
                    if (idElemnt != null && idElemnt != "")
                    {
                        MessageBox.Show($"Bạn click: {idElemnt}", "Message");
                    }
                    break;

            }
        }

        private async Task SetUsername(string username)
        {
            string script = $"setUsername('{username}');";
            var result = await webView21.CoreWebView2.ExecuteScriptAsync(script);

        }

        private  void FrmMain_Load(object sender, EventArgs e)
        {
          
        }
    }
}
