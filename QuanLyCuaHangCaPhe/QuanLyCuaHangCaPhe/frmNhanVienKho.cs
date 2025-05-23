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

namespace QuanLyCuaHangCaPhe
{
    public partial class frmNhanVienKho: Form
    {
        private Form currentChildForm;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public frmNhanVienKho()
        {
            InitializeComponent();
        }
        private void OpenForm(Form childForm, string tenTrang)
        {
            if (currentChildForm != null) currentChildForm.Close();

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDeskTop.Controls.Add(childForm);
            pnlDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTieuDe.Text = tenTrang;
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNguyenLieu(), "Danh sách nguyên liệu");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmNhanVienKho_Load(object sender, EventArgs e)
        {
            Function.Connect();
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            OpenForm(new frmNhapKho(), "Nhập kho");
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenForm(new frmBaoCaoKho(), "Báo cáo kho");
        }
    }
}
