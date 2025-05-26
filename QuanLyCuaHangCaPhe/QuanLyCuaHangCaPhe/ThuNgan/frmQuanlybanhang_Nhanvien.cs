using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyCuaHangCaPhe
{
    public partial class frmQuanlybanhang_Nhanvien : Form
    {
        public frmQuanlybanhang_Nhanvien()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
        }

        private void frmQuanlybanhang_Nhanvien_Load(object sender, EventArgs e)
        {
            Function.Connect();
            iconButton1_Click(iconButton1, EventArgs.Empty);

        }
        private Button currentButton = null;
        private Color defaultBackColor = Color.White;
        private Color selectedBackColor = Color.MediumAquamarine; 
        private Color selectedForeColor = Color.White;
        private Color defaultForeColor = Color.Green;


        private void ShowFormInPanel(Form frm, Panel panel)
        {
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel.Controls.Clear();
            panel.Controls.Add(frm);
            frm.Show();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            //hiển thị danh sách bàn
            ShowFormInPanel(new frmBanhang_Nhanvien(), pnelQuanlybanhang);
            ActivateButton((Button)sender);
        }
        
        //Đổi màu button khi click
        private void ActivateButton(Button senderButton)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = defaultBackColor;
                currentButton.ForeColor = defaultForeColor;
            }

            currentButton = senderButton;
            currentButton.BackColor = selectedBackColor;
            currentButton.ForeColor = selectedForeColor;
        }

        private void btnBaocaohoadon_nhanvien_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmBaocaohoadon_Nhanvien(), pnelQuanlybanhang);
            ActivateButton((Button)sender);
        }

        private void pnelQuanlybanhang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin f = new frmLogin();
                f.Show();
            }
        }
    }
}
