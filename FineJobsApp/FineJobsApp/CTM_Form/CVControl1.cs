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
    public partial class CVControl1 : UserControl
    {
        public CVControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Cấu hình SaveFileDialog
                saveFileDialog.Title = "Save File";
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Chỉnh sửa filter dựa trên nhu cầu

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Đường dẫn file mà người dùng muốn lưu
                    string filePath = saveFileDialog.FileName;

                    // Dữ liệu bạn muốn lưu
                    string dataToSave = "Đây là dữ liệu bạn muốn lưu.";

                    // Ghi dữ liệu vào file
                    File.WriteAllText(filePath, dataToSave);
                }
            }
        }
    }
}
