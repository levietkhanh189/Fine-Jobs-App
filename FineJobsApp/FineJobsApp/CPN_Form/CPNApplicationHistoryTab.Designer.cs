﻿namespace FineJobsApp.CPN_Form
{
    partial class CPNApplicationHistoryTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            scrollview = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // scrollview
            // 
            scrollview.AutoScroll = true;
            scrollview.Location = new Point(108, 63);
            scrollview.Name = "scrollview";
            scrollview.Size = new Size(1378, 526);
            scrollview.TabIndex = 0;
            // 
            // CPNApplicationHistoryTab
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scrollview);
            Name = "CPNApplicationHistoryTab";
            Size = new Size(1592, 824);
            Load += CPNApplicationHistoryTab_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel scrollview;
    }
}