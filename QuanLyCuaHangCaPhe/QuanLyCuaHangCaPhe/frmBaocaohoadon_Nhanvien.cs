using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangCaPhe
{
    public partial class frmBaocaohoadon_Nhanvien : Form
    {
        public frmBaocaohoadon_Nhanvien()
        {
            InitializeComponent();
        }

        private void frmBaocaohoadon_Nhanvien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

        }
        //load dữ liệu lên datagridview
        DataTable dtHoaDon;

        private void LoadDataGridView()
        {
            string sql_HOADON;
            sql_HOADON = "SELECT hdb.MaHoaDonBan, nv.TenNhanVien, hdb.MaBan, km.MucKhuyenMai, " +
             "CASE WHEN hdb.TrangThai = 0 THEN N'Chưa thanh toán' " +
             "     WHEN hdb.TrangThai = 1 THEN N'Đã thanh toán' " +
             "     ELSE N'Không xác định' END AS TrangThai, " +
             "ht.TenHinhThuc " +
             "FROM HoaDonBan hdb " +
             "LEFT JOIN NhanVien nv ON hdb.MaNhanVien = nv.MaNhanVien " +
             "LEFT JOIN KhuyenMai km ON hdb.MaKhuyenMai = km.MaKhuyenMai " +
             "LEFT JOIN HinhThuc ht ON hdb.HinhThuc = ht.MaHinhThuc;";

            dtHoaDon = Function.GetDataToTable(sql_HOADON);
            dGridBaocaohoadon.DataSource = dtHoaDon;

            //do dl tu bang vao datagridview

            dGridBaocaohoadon.Columns[0].HeaderText = "Mã hóa đơn";
            dGridBaocaohoadon.Columns[1].HeaderText = "Tên nhân viên";
            dGridBaocaohoadon.Columns[2].HeaderText = "Mã bàn";
            dGridBaocaohoadon.Columns[3].HeaderText = "Mức khuyến mãi";
            dGridBaocaohoadon.Columns[4].HeaderText = "Trạng thái";
            dGridBaocaohoadon.Columns[5].HeaderText = "Hình thức";

            dGridBaocaohoadon.Columns[0].Width = 50;
            dGridBaocaohoadon.Columns[1].Width = 200;
            dGridBaocaohoadon.Columns[2].Width = 100;
            dGridBaocaohoadon.Columns[3].Width = 100;
            dGridBaocaohoadon.Columns[4].Width = 150;
            dGridBaocaohoadon.Columns[5].Width = 100;

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dGridBaocaohoadon.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dGridBaocaohoadon.EditMode = DataGridViewEditMode.EditProgrammatically;



        }

        private void dGridBaocaohoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
