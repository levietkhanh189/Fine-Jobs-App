using AnimationSliding_Sign_In_Sign_Up;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FineJobsApp
{
    public partial class CTM_SignUpForm : MaterialForm
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // width of ellipse
             int nHeightEllipse // height of ellipse
        );

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Tạo vùng bo tròn cho form
            IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20); // 20, 20 đại diện cho độ rộng và độ cao của elip dùng để tạo góc bo tròn.
            this.Region = Region.FromHrgn(ptr);
            //Giải phóng vùng đã tạo
            DeleteObject(ptr);
        }

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        public static extern bool DeleteObject(IntPtr hObject);

        public CTM_SignUpForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void InitializeComponent()
        {
            materialLabel5 = new MaterialLabel();
            UserNameTextbox = new MaterialTextBox();
            materialLabel4 = new MaterialLabel();
            PasswordTextbox2 = new MaterialTextBox();
            materialLabel3 = new MaterialLabel();
            SignupButton = new MaterialButton();
            LoginButton = new MaterialButton();
            materialLabel2 = new MaterialLabel();
            materialLabel1 = new MaterialLabel();
            TittleLable = new MaterialLabel();
            PasswordTextbox = new MaterialTextBox();
            EmailTextbox = new MaterialTextBox();
            SendCodeButton = new MaterialButton();
            CodeTextbox = new MaterialTextBox();
            materialLabel7 = new MaterialLabel();
            SuspendLayout();
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkinManager.fontType.Subtitle2;
            materialLabel5.Location = new Point(38, 126);
            materialLabel5.Margin = new Padding(1, 0, 1, 0);
            materialLabel5.MouseState = MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(71, 17);
            materialLabel5.TabIndex = 26;
            materialLabel5.Text = "User Name";
            // 
            // UserNameTextbox
            // 
            UserNameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UserNameTextbox.AnimateReadOnly = false;
            UserNameTextbox.BorderStyle = BorderStyle.None;
            UserNameTextbox.Depth = 0;
            UserNameTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserNameTextbox.Hint = "Enter your name";
            UserNameTextbox.LeadingIcon = null;
            UserNameTextbox.Location = new Point(38, 134);
            UserNameTextbox.Margin = new Padding(1);
            UserNameTextbox.MaxLength = 50;
            UserNameTextbox.MouseState = MouseState.OUT;
            UserNameTextbox.Multiline = false;
            UserNameTextbox.Name = "UserNameTextbox";
            UserNameTextbox.Size = new Size(284, 50);
            UserNameTextbox.TabIndex = 25;
            UserNameTextbox.Text = "";
            UserNameTextbox.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkinManager.fontType.Subtitle2;
            materialLabel4.Location = new Point(38, 280);
            materialLabel4.Margin = new Padding(1, 0, 1, 0);
            materialLabel4.MouseState = MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(103, 17);
            materialLabel4.TabIndex = 24;
            materialLabel4.Text = "Password Again";
            // 
            // PasswordTextbox2
            // 
            PasswordTextbox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox2.AnimateReadOnly = false;
            PasswordTextbox2.BorderStyle = BorderStyle.None;
            PasswordTextbox2.Depth = 0;
            PasswordTextbox2.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextbox2.Hint = "Enter your password again";
            PasswordTextbox2.LeadingIcon = null;
            PasswordTextbox2.Location = new Point(38, 281);
            PasswordTextbox2.Margin = new Padding(1);
            PasswordTextbox2.MaxLength = 50;
            PasswordTextbox2.MouseState = MouseState.OUT;
            PasswordTextbox2.Multiline = false;
            PasswordTextbox2.Name = "PasswordTextbox2";
            PasswordTextbox2.Password = true;
            PasswordTextbox2.Size = new Size(284, 50);
            PasswordTextbox2.TabIndex = 23;
            PasswordTextbox2.Text = "";
            PasswordTextbox2.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkinManager.fontType.Button;
            materialLabel3.HighEmphasis = true;
            materialLabel3.Location = new Point(55, 227);
            materialLabel3.Margin = new Padding(1, 0, 1, 0);
            materialLabel3.MouseState = MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(1, 0);
            materialLabel3.TabIndex = 22;
            // 
            // SignupButton
            // 
            SignupButton.Anchor = AnchorStyles.Top;
            SignupButton.AutoSize = false;
            SignupButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SignupButton.BackColor = SystemColors.ControlLight;
            SignupButton.Density = MaterialButton.MaterialButtonDensity.Dense;
            SignupButton.Depth = 0;
            SignupButton.DrawShadows = false;
            SignupButton.HighEmphasis = false;
            SignupButton.Icon = null;
            SignupButton.Location = new Point(263, 361);
            SignupButton.Margin = new Padding(2);
            SignupButton.MouseState = MouseState.HOVER;
            SignupButton.Name = "SignupButton";
            SignupButton.NoAccentTextColor = Color.Empty;
            SignupButton.Size = new Size(113, 34);
            SignupButton.TabIndex = 21;
            SignupButton.Text = "Sign Up";
            SignupButton.Type = MaterialButton.MaterialButtonType.Contained;
            SignupButton.UseAccentColor = false;
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click_1;
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.Top;
            LoginButton.AutoSize = false;
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.Density = MaterialButton.MaterialButtonDensity.Dense;
            LoginButton.Depth = 0;
            LoginButton.HighEmphasis = true;
            LoginButton.Icon = null;
            LoginButton.Location = new Point(263, 399);
            LoginButton.Margin = new Padding(2);
            LoginButton.MouseState = MouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(113, 37);
            LoginButton.TabIndex = 20;
            LoginButton.Text = "Login";
            LoginButton.Type = MaterialButton.MaterialButtonType.Contained;
            LoginButton.UseAccentColor = false;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkinManager.fontType.Subtitle2;
            materialLabel2.Location = new Point(38, 224);
            materialLabel2.Margin = new Padding(1, 0, 1, 0);
            materialLabel2.MouseState = MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(63, 17);
            materialLabel2.TabIndex = 19;
            materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkinManager.fontType.Subtitle2;
            materialLabel1.Location = new Point(38, 154);
            materialLabel1.Margin = new Padding(1, 0, 1, 0);
            materialLabel1.MouseState = MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(37, 17);
            materialLabel1.TabIndex = 18;
            materialLabel1.Text = "Email";
            // 
            // TittleLable
            // 
            TittleLable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TittleLable.AutoSize = true;
            TittleLable.Depth = 0;
            TittleLable.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            TittleLable.FontType = MaterialSkinManager.fontType.H4;
            TittleLable.HighEmphasis = true;
            TittleLable.Location = new Point(13, 74);
            TittleLable.Margin = new Padding(1, 0, 1, 0);
            TittleLable.MouseState = MouseState.HOVER;
            TittleLable.Name = "TittleLable";
            TittleLable.Size = new Size(330, 41);
            TittleLable.TabIndex = 17;
            TittleLable.Text = "Welcome To Fine-App";
            TittleLable.UseAccent = true;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextbox.AnimateReadOnly = false;
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Depth = 0;
            PasswordTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTextbox.Hint = "Enter your password";
            PasswordTextbox.LeadingIcon = null;
            PasswordTextbox.Location = new Point(38, 229);
            PasswordTextbox.Margin = new Padding(1);
            PasswordTextbox.MaxLength = 50;
            PasswordTextbox.MouseState = MouseState.OUT;
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Password = true;
            PasswordTextbox.ScrollBars = RichTextBoxScrollBars.None;
            PasswordTextbox.Size = new Size(284, 50);
            PasswordTextbox.TabIndex = 16;
            PasswordTextbox.Text = "";
            PasswordTextbox.TrailingIcon = null;
            // 
            // EmailTextbox
            // 
            EmailTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextbox.AnimateReadOnly = false;
            EmailTextbox.BorderStyle = BorderStyle.None;
            EmailTextbox.Depth = 0;
            EmailTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailTextbox.Hint = "Enter your email";
            EmailTextbox.LeadingIcon = null;
            EmailTextbox.Location = new Point(38, 177);
            EmailTextbox.Margin = new Padding(1);
            EmailTextbox.MaxLength = 50;
            EmailTextbox.MouseState = MouseState.OUT;
            EmailTextbox.Multiline = false;
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(284, 50);
            EmailTextbox.TabIndex = 15;
            EmailTextbox.Text = "";
            EmailTextbox.TrailingIcon = null;
            // 
            // SendCodeButton
            // 
            SendCodeButton.AutoSize = false;
            SendCodeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendCodeButton.Density = MaterialButton.MaterialButtonDensity.Dense;
            SendCodeButton.Depth = 0;
            SendCodeButton.HighEmphasis = true;
            SendCodeButton.Icon = null;
            SendCodeButton.Location = new Point(391, 236);
            SendCodeButton.Margin = new Padding(2);
            SendCodeButton.MouseState = MouseState.HOVER;
            SendCodeButton.Name = "SendCodeButton";
            SendCodeButton.NoAccentTextColor = Color.Empty;
            SendCodeButton.Size = new Size(130, 43);
            SendCodeButton.TabIndex = 38;
            SendCodeButton.Text = "Send Code";
            SendCodeButton.Type = MaterialButton.MaterialButtonType.Outlined;
            SendCodeButton.UseAccentColor = false;
            SendCodeButton.UseVisualStyleBackColor = true;
            SendCodeButton.Click += SendCodeButton_Click;
            // 
            // CodeTextbox
            // 
            CodeTextbox.AnimateReadOnly = false;
            CodeTextbox.BorderStyle = BorderStyle.None;
            CodeTextbox.Depth = 0;
            CodeTextbox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CodeTextbox.Hint = "Enter your code";
            CodeTextbox.LeadingIcon = null;
            CodeTextbox.Location = new Point(378, 177);
            CodeTextbox.Margin = new Padding(1);
            CodeTextbox.MaxLength = 50;
            CodeTextbox.MouseState = MouseState.OUT;
            CodeTextbox.Multiline = false;
            CodeTextbox.Name = "CodeTextbox";
            CodeTextbox.Size = new Size(163, 50);
            CodeTextbox.TabIndex = 37;
            CodeTextbox.Text = "";
            CodeTextbox.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = MaterialSkinManager.fontType.Button;
            materialLabel7.HighEmphasis = true;
            materialLabel7.Location = new Point(90, 349);
            materialLabel7.Margin = new Padding(1, 0, 1, 0);
            materialLabel7.MouseState = MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(1, 0);
            materialLabel7.TabIndex = 33;
            // 
            // CTM_SignUpForm
            // 
            ClientSize = new Size(565, 469);
            Controls.Add(SendCodeButton);
            Controls.Add(CodeTextbox);
            Controls.Add(materialLabel7);
            Controls.Add(materialLabel5);
            Controls.Add(UserNameTextbox);
            Controls.Add(materialLabel4);
            Controls.Add(PasswordTextbox2);
            Controls.Add(materialLabel3);
            Controls.Add(SignupButton);
            Controls.Add(LoginButton);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(TittleLable);
            Controls.Add(PasswordTextbox);
            Controls.Add(EmailTextbox);
            Name = "CTM_SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialLabel materialLabel5;
        private MaterialTextBox UserNameTextbox;
        private MaterialLabel materialLabel4;
        private MaterialTextBox PasswordTextbox2;
        private MaterialLabel materialLabel3;
        private MaterialButton SignupButton;
        private MaterialButton LoginButton;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialLabel TittleLable;
        private MaterialTextBox PasswordTextbox;
        private MaterialTextBox EmailTextbox;

        private void SignupButton_Click_1(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel(UserNameTextbox.Text, PasswordTextbox.Text, EmailTextbox.Text, "Applicant", DateTime.Now);
            bool status = ControllerManager.Instance.UserController.Register(userModel, CodeTextbox.Text);
            if (status)
            {
                ControllerManager.Instance.ProfileController.CreateFirstUserProfile(userModel);
                this.Hide();
                FormManager.ShowForm<FrmLogin>();
            }
            else
            {
                MessageBox.Show("Code or password is not correct");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormManager.ShowForm<FrmLogin>();
        }

        private MaterialButton SendCodeButton;
        private MaterialTextBox CodeTextbox;
        private MaterialLabel materialLabel7;

        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            ControllerManager.Instance.UserController.SendCode(EmailTextbox.Text);
        }
    }
}
