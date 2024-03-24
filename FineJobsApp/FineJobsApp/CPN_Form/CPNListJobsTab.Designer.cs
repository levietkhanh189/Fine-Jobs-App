namespace FineJobsApp.CPN_Form
{
    partial class CPNListJobsTab
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            SearchBtn = new MaterialSkin.Controls.MaterialButton();
            SearchTextbox = new MaterialSkin.Controls.MaterialTextBox();
            scrollview = new FlowLayoutPanel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            RightBtn = new MaterialSkin.Controls.MaterialButton();
            LeftBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(104, 89);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(322, 19);
            materialLabel2.TabIndex = 9;
            materialLabel2.Text = "Pleasure in the job puts perfection in the work";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(104, 20);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(197, 58);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "List Jobs";
            // 
            // SearchBtn
            // 
            SearchBtn.AutoSize = false;
            SearchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SearchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SearchBtn.Depth = 0;
            SearchBtn.HighEmphasis = true;
            SearchBtn.Icon = Properties.Resources.icons8_search_128;
            SearchBtn.Location = new Point(1400, 28);
            SearchBtn.Margin = new Padding(4, 6, 4, 6);
            SearchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SearchBtn.Name = "SearchBtn";
            SearchBtn.NoAccentTextColor = Color.Empty;
            SearchBtn.Size = new Size(107, 50);
            SearchBtn.TabIndex = 7;
            SearchBtn.Text = "Search";
            SearchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SearchBtn.UseAccentColor = false;
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // SearchTextbox
            // 
            SearchTextbox.AnimateReadOnly = false;
            SearchTextbox.BorderStyle = BorderStyle.None;
            SearchTextbox.Depth = 0;
            SearchTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SearchTextbox.LeadingIcon = null;
            SearchTextbox.Location = new Point(1018, 28);
            SearchTextbox.MaxLength = 50;
            SearchTextbox.MouseState = MaterialSkin.MouseState.OUT;
            SearchTextbox.Multiline = false;
            SearchTextbox.Name = "SearchTextbox";
            SearchTextbox.Size = new Size(375, 50);
            SearchTextbox.TabIndex = 6;
            SearchTextbox.Text = "";
            SearchTextbox.TrailingIcon = null;
            // 
            // scrollview
            // 
            scrollview.AutoScroll = true;
            scrollview.Location = new Point(104, 150);
            scrollview.Name = "scrollview";
            scrollview.Size = new Size(1385, 597);
            scrollview.TabIndex = 5;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(1405, 776);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(10, 19);
            materialLabel3.TabIndex = 12;
            materialLabel3.Text = "1";
            // 
            // RightBtn
            // 
            RightBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RightBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            RightBtn.Depth = 0;
            RightBtn.HighEmphasis = true;
            RightBtn.Icon = null;
            RightBtn.Location = new Point(1443, 768);
            RightBtn.Margin = new Padding(4, 6, 4, 6);
            RightBtn.MouseState = MaterialSkin.MouseState.HOVER;
            RightBtn.Name = "RightBtn";
            RightBtn.NoAccentTextColor = Color.Empty;
            RightBtn.Size = new Size(64, 36);
            RightBtn.TabIndex = 11;
            RightBtn.Text = ">";
            RightBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            RightBtn.UseAccentColor = false;
            RightBtn.UseVisualStyleBackColor = true;
            // 
            // LeftBtn
            // 
            LeftBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LeftBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LeftBtn.Depth = 0;
            LeftBtn.HighEmphasis = true;
            LeftBtn.Icon = null;
            LeftBtn.Location = new Point(1313, 768);
            LeftBtn.Margin = new Padding(4, 6, 4, 6);
            LeftBtn.MouseState = MaterialSkin.MouseState.HOVER;
            LeftBtn.Name = "LeftBtn";
            LeftBtn.NoAccentTextColor = Color.Empty;
            LeftBtn.Size = new Size(64, 36);
            LeftBtn.TabIndex = 10;
            LeftBtn.Text = "<";
            LeftBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            LeftBtn.UseAccentColor = false;
            LeftBtn.UseVisualStyleBackColor = true;
            // 
            // CPNListJobsTab
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabel3);
            Controls.Add(RightBtn);
            Controls.Add(LeftBtn);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(SearchBtn);
            Controls.Add(SearchTextbox);
            Controls.Add(scrollview);
            Name = "CPNListJobsTab";
            Size = new Size(1592, 824);
            Load += CPNListJobsTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton SearchBtn;
        private MaterialSkin.Controls.MaterialTextBox SearchTextbox;
        private FlowLayoutPanel scrollview;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton RightBtn;
        private MaterialSkin.Controls.MaterialButton LeftBtn;
    }
}
