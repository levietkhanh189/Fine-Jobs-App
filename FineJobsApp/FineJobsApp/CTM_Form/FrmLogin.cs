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

namespace AnimationSliding_Sign_In_Sign_Up
{
    public partial class FrmLogin : Form
    {
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        public FrmLogin()
        {
            InitializeComponent();
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
            var uri = new Uri(String.Format("file:///{0}/html/index.html", curDir));
            webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
          
            webView21.CoreWebView2.Navigate(uri.ToString());
            webView21.WebMessageReceived += WebView21_WebMessageReceived;
        }
        public struct JsonObject
        {
            public string Key;
            public string Value;
        }

        private  async Task<string> GetTextboxValue(string elementId)
        {
            string script = $"document.getElementById('{elementId}').value";
            var result = await webView21.CoreWebView2.ExecuteScriptAsync(script);
            return result.Trim('"');
        }

        private async Task SetFocus(string elementId)
        {
            string script = $"setFocusOnInput('{elementId}');";
            var result = await webView21.CoreWebView2.ExecuteScriptAsync(script);
           
        }

        private async Task ShowSnackBar(string message, int timeout = 3000)
        {
            message = $"<i class=\"fa fa-exclamation-triangle\" style=\"color: white; font-size: 16px;\"> </i> {message}";
            string script = $"showSnackbar('{message}', {timeout});";
            var result = await webView21.CoreWebView2.ExecuteScriptAsync(script);
          
        }

        private async void WebView21_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            var jsonObject = JsonConvert.DeserializeObject<JsonObject>(e.WebMessageAsJson);
            var idElemnt = jsonObject.Value;
            switch (jsonObject.Key)
            {
                case "click":
                    if(idElemnt != null && idElemnt != "")
                    {
                        if(idElemnt == "btnLogin")
                        {
                           await ProcessLogin();
                        }
                    }
                    break;

            }
        }

        private async Task ProcessLogin()
        {
            var username = await GetTextboxValue("txtUsername");
            var password = await GetTextboxValue("txtPassword");
            if(username == "")
            {
                await ShowSnackBar("Chưa nhập tên đăng nhập.");
                await SetFocus("txtUsername");
                return;
            }

            if (password == "")
            {
                await ShowSnackBar("Chưa nhập mật khẩu.");
                await SetFocus("txtPassword");
                return;
            }

            if( password == "123")
            {
                //hiện FrmHome
                FrmHome frm = new FrmHome();
                frm.Show();
                this.Hide();
            }
            else
            {
                await ShowSnackBar("Tên đăng nhập hoặc mật khẩu không đúng.");
            }

        }
    }
}
