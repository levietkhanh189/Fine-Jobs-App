namespace FineJobsApp
{
    partial class CPNHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPNHomeForm));
            HomeTabControl = new MaterialSkin.Controls.MaterialTabControl();
            DashboardTab = new TabPage();
            CompanyInfoTab = new TabPage();
            ListJobsTab = new TabPage();
            ApplicantTab = new TabPage();
            ApplicationHistoryTab = new TabPage();
            MessagesTab = new TabPage();
            SettingTab = new TabPage();
            Logout = new TabPage();
            imageList1 = new ImageList(components);
            HomeTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // HomeTabControl
            // 
            HomeTabControl.Controls.Add(DashboardTab);
            HomeTabControl.Controls.Add(CompanyInfoTab);
            HomeTabControl.Controls.Add(ListJobsTab);
            HomeTabControl.Controls.Add(ApplicantTab);
            HomeTabControl.Controls.Add(ApplicationHistoryTab);
            HomeTabControl.Controls.Add(MessagesTab);
            HomeTabControl.Controls.Add(SettingTab);
            HomeTabControl.Controls.Add(Logout);
            HomeTabControl.Depth = 0;
            HomeTabControl.Dock = DockStyle.Fill;
            HomeTabControl.ImageList = imageList1;
            HomeTabControl.Location = new Point(2, 63);
            HomeTabControl.Margin = new Padding(2, 3, 2, 3);
            HomeTabControl.MaximumSize = new Size(1613, 891);
            HomeTabControl.MinimumSize = new Size(1613, 891);
            HomeTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            HomeTabControl.Multiline = true;
            HomeTabControl.Name = "HomeTabControl";
            HomeTabControl.SelectedIndex = 0;
            HomeTabControl.Size = new Size(1613, 891);
            HomeTabControl.TabIndex = 0;
            HomeTabControl.SelectedIndexChanged += HomeTabControl_SelectedIndexChanged;
            // 
            // DashboardTab
            // 
            DashboardTab.AutoScroll = true;
            DashboardTab.AutoScrollMargin = new Size(1592, 824);
            DashboardTab.AutoScrollMinSize = new Size(1592, 824);
            DashboardTab.CausesValidation = false;
            DashboardTab.ImageKey = "icons8-home-100.png";
            DashboardTab.Location = new Point(10, 106);
            DashboardTab.Margin = new Padding(2, 3, 2, 3);
            DashboardTab.Name = "DashboardTab";
            DashboardTab.Padding = new Padding(2, 3, 2, 3);
            DashboardTab.Size = new Size(1593, 775);
            DashboardTab.TabIndex = 0;
            DashboardTab.Text = "Dashboard";
            DashboardTab.UseVisualStyleBackColor = true;
            // 
            // CompanyInfoTab
            // 
            CompanyInfoTab.ImageKey = "icons8-myspace-100.png";
            CompanyInfoTab.Location = new Point(10, 106);
            CompanyInfoTab.Margin = new Padding(2, 3, 2, 3);
            CompanyInfoTab.Name = "CompanyInfoTab";
            CompanyInfoTab.Size = new Size(1593, 775);
            CompanyInfoTab.TabIndex = 5;
            CompanyInfoTab.Text = "Company Info";
            CompanyInfoTab.UseVisualStyleBackColor = true;
            // 
            // ListJobsTab
            // 
            ListJobsTab.ImageKey = "icons8-binoculars-100.png";
            ListJobsTab.Location = new Point(10, 106);
            ListJobsTab.Margin = new Padding(2, 3, 2, 3);
            ListJobsTab.Name = "ListJobsTab";
            ListJobsTab.Padding = new Padding(2, 3, 2, 3);
            ListJobsTab.Size = new Size(1593, 775);
            ListJobsTab.TabIndex = 1;
            ListJobsTab.Text = "List Jobs";
            ListJobsTab.UseVisualStyleBackColor = true;
            // 
            // ApplicantTab
            // 
            ApplicantTab.ImageKey = "icons8-search-128.png";
            ApplicantTab.Location = new Point(10, 106);
            ApplicantTab.Name = "ApplicantTab";
            ApplicantTab.Size = new Size(1593, 775);
            ApplicantTab.TabIndex = 7;
            ApplicantTab.Text = "Applicants";
            ApplicantTab.UseVisualStyleBackColor = true;
            // 
            // ApplicationHistoryTab
            // 
            ApplicationHistoryTab.ImageKey = "icons8-contacts-100.png";
            ApplicationHistoryTab.Location = new Point(10, 106);
            ApplicationHistoryTab.Margin = new Padding(2, 3, 2, 3);
            ApplicationHistoryTab.Name = "ApplicationHistoryTab";
            ApplicationHistoryTab.Size = new Size(1593, 775);
            ApplicationHistoryTab.TabIndex = 2;
            ApplicationHistoryTab.Text = "Application History";
            ApplicationHistoryTab.UseVisualStyleBackColor = true;
            // 
            // MessagesTab
            // 
            MessagesTab.ImageKey = "icons8-speech-bubble-100.png";
            MessagesTab.Location = new Point(10, 106);
            MessagesTab.Margin = new Padding(2, 3, 2, 3);
            MessagesTab.Name = "MessagesTab";
            MessagesTab.Size = new Size(1593, 775);
            MessagesTab.TabIndex = 4;
            MessagesTab.Text = "Messages";
            MessagesTab.UseVisualStyleBackColor = true;
            // 
            // SettingTab
            // 
            SettingTab.ImageKey = "icons8-support-100.png";
            SettingTab.Location = new Point(10, 106);
            SettingTab.Margin = new Padding(2, 3, 2, 3);
            SettingTab.Name = "SettingTab";
            SettingTab.Size = new Size(1593, 775);
            SettingTab.TabIndex = 3;
            SettingTab.Text = "Setting";
            SettingTab.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            Logout.ImageIndex = 7;
            Logout.Location = new Point(10, 106);
            Logout.Margin = new Padding(2, 3, 2, 3);
            Logout.Name = "Logout";
            Logout.Size = new Size(1593, 775);
            Logout.TabIndex = 6;
            Logout.Text = "Logout | Exit";
            Logout.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-binoculars-100.png");
            imageList1.Images.SetKeyName(1, "icons8-contacts-100.png");
            imageList1.Images.SetKeyName(2, "icons8-document-100.png");
            imageList1.Images.SetKeyName(3, "icons8-home-100.png");
            imageList1.Images.SetKeyName(4, "icons8-myspace-100.png");
            imageList1.Images.SetKeyName(5, "icons8-speech-bubble-100.png");
            imageList1.Images.SetKeyName(6, "icons8-support-100.png");
            imageList1.Images.SetKeyName(7, "icons8-logout-100.png");
            imageList1.Images.SetKeyName(8, "icons8-search-128.png");
            // 
            // CPNHomeForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1633, 968);
            Controls.Add(HomeTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = HomeTabControl;
            Margin = new Padding(2, 3, 2, 3);
            Name = "CPNHomeForm";
            Padding = new Padding(2, 63, 2, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company Home";
            Load += CPNHomeForm_Load;
            HomeTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl HomeTabControl;
        private TabPage DashboardTab;
        private TabPage ListJobsTab;
        private ImageList imageList1;
        private TabPage ApplicationHistoryTab;
        private TabPage SettingTab;
        private TabPage MessagesTab;
        private TabPage CompanyInfoTab;
        private TabPage Logout;
        private TabPage ApplicantTab;
    }
}