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

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            CPNListJobsTab listJobsTab = FormManager.GetForm<CPNHomeForm>().ChangeTab<CPNListJobsTab>(HomeTab.ListJobsTab);
            listJobsTab.LoadCurrentOpenJob();
        }

        private void CPNDashboardTab_Load(object sender, EventArgs e)
        {
            InitBrowser();
            LoadData();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        public async void InitBrowser()
        {
            await initizated();
            webView21.CoreWebView2.Navigate("https://calendar.google.com/calendar/");
            webView21.ZoomFactor = 0.5;
        }
        private void LoadData()
        {
            newApplicationText.Text = ControllerManager.Instance.ApplicationController.GetApplicationsForToday().Count + "";
            currentOpenJobsText.Text = ControllerManager.Instance.JobController.SearchJobs("Open").Count + "";
            interviewText.Text = ControllerManager.Instance.ApplicationController.GetApplicationsByStatus("Interview").Count + "";
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            CPNApplicationHistoryTab applicationHistoryTab = FormManager.GetForm<CPNHomeForm>().ChangeTab<CPNApplicationHistoryTab>(HomeTab.ApplicationHistoryTab);
            applicationHistoryTab.LoadApplicationForToday();
        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            CPNApplicationHistoryTab applicationHistoryTab = FormManager.GetForm<CPNHomeForm>().ChangeTab<CPNApplicationHistoryTab>(HomeTab.ApplicationHistoryTab);
            applicationHistoryTab.LoadApplicationInterview();
        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void currentOpenJobsText_Click(object sender, EventArgs e)
        {

        }
    }
}
