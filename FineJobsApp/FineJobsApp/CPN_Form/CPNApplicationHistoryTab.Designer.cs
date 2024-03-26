namespace FineJobsApp.CPN_Form
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
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            SearchBtn = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            LeftBtn = new MaterialSkin.Controls.MaterialButton();
            RightBtn = new MaterialSkin.Controls.MaterialButton();
            PageText = new MaterialSkin.Controls.MaterialLabel();
            ReloadBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // scrollview
            // 
            scrollview.AutoScroll = true;
            scrollview.Location = new Point(101, 169);
            scrollview.Name = "scrollview";
            scrollview.Size = new Size(1385, 579);
            scrollview.TabIndex = 0;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(1015, 77);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(375, 50);
            materialTextBox1.TabIndex = 1;
            materialTextBox1.Text = "";
            materialTextBox1.TrailingIcon = null;
            // 
            // SearchBtn
            // 
            SearchBtn.AutoSize = false;
            SearchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SearchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SearchBtn.Depth = 0;
            SearchBtn.HighEmphasis = true;
            SearchBtn.Icon = Properties.Resources.icons8_search_128;
            SearchBtn.Location = new Point(1397, 77);
            SearchBtn.Margin = new Padding(4, 6, 4, 6);
            SearchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SearchBtn.Name = "SearchBtn";
            SearchBtn.NoAccentTextColor = Color.Empty;
            SearchBtn.Size = new Size(98, 50);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SearchBtn.UseAccentColor = false;
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            materialLabel1.Location = new Point(101, 39);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(267, 58);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Applications";
            materialLabel1.Click += materialLabel1_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(101, 108);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(454, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "The power that knowledge possesses is hidden in its application";
            // 
            // LeftBtn
            // 
            LeftBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LeftBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LeftBtn.Depth = 0;
            LeftBtn.HighEmphasis = true;
            LeftBtn.Icon = null;
            LeftBtn.Location = new Point(1245, 770);
            LeftBtn.Margin = new Padding(4, 6, 4, 6);
            LeftBtn.MouseState = MaterialSkin.MouseState.HOVER;
            LeftBtn.Name = "LeftBtn";
            LeftBtn.NoAccentTextColor = Color.Empty;
            LeftBtn.Size = new Size(64, 36);
            LeftBtn.TabIndex = 5;
            LeftBtn.Text = "<";
            LeftBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            LeftBtn.UseAccentColor = false;
            LeftBtn.UseVisualStyleBackColor = true;
            // 
            // RightBtn
            // 
            RightBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RightBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            RightBtn.Depth = 0;
            RightBtn.HighEmphasis = true;
            RightBtn.Icon = null;
            RightBtn.Location = new Point(1375, 770);
            RightBtn.Margin = new Padding(4, 6, 4, 6);
            RightBtn.MouseState = MaterialSkin.MouseState.HOVER;
            RightBtn.Name = "RightBtn";
            RightBtn.NoAccentTextColor = Color.Empty;
            RightBtn.Size = new Size(64, 36);
            RightBtn.TabIndex = 6;
            RightBtn.Text = ">";
            RightBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            RightBtn.UseAccentColor = false;
            RightBtn.UseVisualStyleBackColor = true;
            // 
            // PageText
            // 
            PageText.AutoSize = true;
            PageText.Depth = 0;
            PageText.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            PageText.Location = new Point(1337, 778);
            PageText.MouseState = MaterialSkin.MouseState.HOVER;
            PageText.Name = "PageText";
            PageText.Size = new Size(10, 19);
            PageText.TabIndex = 7;
            PageText.Text = "1";
            // 
            // ReloadBtn
            // 
            ReloadBtn.AutoSize = false;
            ReloadBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReloadBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ReloadBtn.Depth = 0;
            ReloadBtn.HighEmphasis = true;
            ReloadBtn.Icon = Properties.Resources.icons8_reload_90;
            ReloadBtn.Location = new Point(1447, 770);
            ReloadBtn.Margin = new Padding(4, 6, 4, 6);
            ReloadBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ReloadBtn.Name = "ReloadBtn";
            ReloadBtn.NoAccentTextColor = Color.Empty;
            ReloadBtn.Size = new Size(39, 36);
            ReloadBtn.TabIndex = 8;
            ReloadBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ReloadBtn.UseAccentColor = false;
            ReloadBtn.UseVisualStyleBackColor = true;
            ReloadBtn.Click += ReloadBtn_Click;
            // 
            // CPNApplicationHistoryTab
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ReloadBtn);
            Controls.Add(PageText);
            Controls.Add(RightBtn);
            Controls.Add(LeftBtn);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(SearchBtn);
            Controls.Add(materialTextBox1);
            Controls.Add(scrollview);
            Name = "CPNApplicationHistoryTab";
            Size = new Size(1592, 824);
            Load += CPNApplicationHistoryTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel scrollview;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton SearchBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton LeftBtn;
        private MaterialSkin.Controls.MaterialButton RightBtn;
        private MaterialSkin.Controls.MaterialLabel PageText;
        private MaterialSkin.Controls.MaterialButton ReloadBtn;
    }
}
