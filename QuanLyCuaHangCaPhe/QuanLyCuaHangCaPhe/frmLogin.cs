using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangCaPhe
{
    public partial class frmLogin: Form
    {
        bool hidePass = true;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (hidePass)
            {
                txtMatkhau.UseSystemPasswordChar = true;
                hidePass = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = false;
                hidePass = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "" || txtMatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql = "SELECT nv.*, cv.TenChucVu FROM NhanVien nv " +
                             "JOIN ChucVu cv ON nv.MaChucVu = cv.MaChucVu " +
                             "WHERE nv.MaNhanVien = '" + txtTaikhoan.Text + "' " +
                             "AND nv.MatKhau = '" + txtMatkhau.Text + "'";

                DataTable dt = Function.GetDataToTable(sql);

                if (dt.Rows.Count > 0)
                {
                    string tenChucVu = dt.Rows[0]["TenChucVu"].ToString();

                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // Ẩn form login

                    if (tenChucVu == "QuanLy")
                    {
                        FormQuanLy formQL = new FormQuanLy();
                        formQL.ShowDialog();
                    }
                    else if (tenChucVu == "Thu ngan")
                    {
                        frmQuanlybanhang_Nhanvien formTN = new frmQuanlybanhang_Nhanvien();
                        formTN.ShowDialog();
                    }
                    else if (tenChucVu == "Thu kho")
                    {
                        frmNhanVienKho formTK = new frmNhanVienKho();
                        formTK.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Chức vụ không được hỗ trợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Show(); // Hiện lại form login nếu lỗi
                    }

                    this.Show(); // Hiện lại form login khi form con đóng
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
