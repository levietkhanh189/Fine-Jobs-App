namespace FineJobsApp.CPN_Form
{
    partial class CPNNotifyForm
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
            TittleLable = new MaterialSkin.Controls.MaterialLabel();
            SubmitBtn = new MaterialSkin.Controls.MaterialButton();
            CancleBtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // TittleLable
            // 
            TittleLable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TittleLable.AutoSize = true;
            TittleLable.Depth = 0;
            TittleLable.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            TittleLable.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            TittleLable.HighEmphasis = true;
            TittleLable.Location = new Point(166, 156);
            TittleLable.Margin = new Padding(2, 0, 2, 0);
            TittleLable.MouseState = MaterialSkin.MouseState.HOVER;
            TittleLable.Name = "TittleLable";
            TittleLable.Size = new Size(251, 58);
            TittleLable.TabIndex = 18;
            TittleLable.Text = "Notification";
            TittleLable.TextAlign = ContentAlignment.MiddleCenter;
            TittleLable.UseAccent = true;
            // 
            // SubmitBtn
            // 
            SubmitBtn.AutoSize = false;
            SubmitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SubmitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SubmitBtn.Depth = 0;
            SubmitBtn.HighEmphasis = true;
            SubmitBtn.Icon = null;
            SubmitBtn.Location = new Point(123, 266);
            SubmitBtn.Margin = new Padding(4, 6, 4, 6);
            SubmitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.NoAccentTextColor = Color.Empty;
            SubmitBtn.Size = new Size(348, 62);
            SubmitBtn.TabIndex = 19;
            SubmitBtn.Text = "Submit";
            SubmitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SubmitBtn.UseAccentColor = false;
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // CancleBtn
            // 
            CancleBtn.AutoSize = false;
            CancleBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            CancleBtn.Depth = 0;
            CancleBtn.HighEmphasis = true;
            CancleBtn.Icon = null;
            CancleBtn.Location = new Point(125, 338);
            CancleBtn.Margin = new Padding(4, 6, 4, 6);
            CancleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            CancleBtn.Name = "CancleBtn";
            CancleBtn.NoAccentTextColor = Color.Empty;
            CancleBtn.Size = new Size(346, 57);
            CancleBtn.TabIndex = 20;
            CancleBtn.Text = "Cancle";
            CancleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            CancleBtn.UseAccentColor = false;
            CancleBtn.UseVisualStyleBackColor = true;
            // 
            // CPNNotifyForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 465);
            Controls.Add(CancleBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(TittleLable);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CPNNotifyForm";
            Padding = new Padding(2, 64, 2, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CPNNotifyForm";
            Load += CPNNotifyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel TittleLable;
        private MaterialSkin.Controls.MaterialButton SubmitBtn;
        private MaterialSkin.Controls.MaterialButton CancleBtn;
    }
}