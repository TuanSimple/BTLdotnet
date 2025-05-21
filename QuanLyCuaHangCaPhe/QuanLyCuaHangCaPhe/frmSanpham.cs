using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace QuanLyCuaHangCaPhe
{
    public partial class frmSanpham : Form
    {
        DataTable SanPham;
        DataTable ChiTietSanPham;
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            //Khi form load thì sẽ gọi hàm Connect để kết nối với CSDL
            QuanLyCuaHangCaPhe.Function.Connect();
            txtMasanpham.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            //Gọi hàm load dữ liệu vào datagridview
            Load_DataGridViewSP();
            //Gọi hàm load dữ liệu vào combobox
            string sql = "SELECT * FROM Loai";
            QuanLyCuaHangCaPhe.Function.FillCombo(sql, cboDanhmuc, "Maloai", "Tenloai");
            cboDanhmuc.SelectedIndex = -1; //Đặt giá trị mặc định cho combobox
            ResetValues();

            //ẩn
            txtMasanpham.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            txtAnh.Enabled = false;
        }
        private void Load_DataGridViewSP()
        {
            string sql;
            sql = "SELECT MaSanPham, TenSanPham, TenLoai, GiaBan, HinhAnh, GiaNhap from SanPham s  join Loai l on l.MaLoai=s.MaLoai";
            SanPham = QuanLyCuaHangCaPhe.Function.GetDataToTable(sql);
            //Gán dữ liệu từ bảng vào datagridview
            dataGridViewQLyCaPhe.DataSource = SanPham;

            //đặt tên cho các cột
            dataGridViewQLyCaPhe.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridViewQLyCaPhe.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewQLyCaPhe.Columns[2].HeaderText = "Danh mục";
            dataGridViewQLyCaPhe.Columns[3].HeaderText = "Giá bán";
            dataGridViewQLyCaPhe.Columns[4].HeaderText = "Hình ảnh";
            dataGridViewQLyCaPhe.Columns[5].HeaderText = "Giá nhập";
            dataGridViewQLyCaPhe.Columns[0].Width = 150;
            dataGridViewQLyCaPhe.Columns[1].Width = 200;
            dataGridViewQLyCaPhe.Columns[2].Width = 150;
            dataGridViewQLyCaPhe.Columns[3].Width = 100;
            dataGridViewQLyCaPhe.Columns[4].Width = 100;
            dataGridViewQLyCaPhe.Columns[5].Width = 100;
            // In đậm tên các cột
            dataGridViewQLyCaPhe.ColumnHeadersDefaultCellStyle.Font = new Font(
                dataGridViewQLyCaPhe.Font.FontFamily,
                dataGridViewQLyCaPhe.Font.Size,
                FontStyle.Bold
            );

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridViewQLyCaPhe.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridViewQLyCaPhe.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dataGridViewQLyCaPhe_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (SanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Lấy dòng hiện tại
            txtMasanpham.Text = dataGridViewQLyCaPhe.CurrentRow.Cells["MaSanPham"].Value.ToString();
            txtTensanpham.Text = dataGridViewQLyCaPhe.CurrentRow.Cells["TenSanPham"].Value.ToString();
            // ma = dataGridViewQLyCaPhe.CurrentRow.Cells["MaLoai"].Value.ToString();
            // cboDanhmuc.Text = QuanLyCuaHangCaPhe.Function.GetFieldValues("SELECT TenLoai FROM Loai WHERE MaLoai = N'" + ma + "'");
            cboDanhmuc.Text = dataGridViewQLyCaPhe.CurrentRow.Cells["TenLoai"].Value.ToString();
            txtGiaban.Text = dataGridViewQLyCaPhe.CurrentRow.Cells["GiaBan"].Value.ToString();
            txtAnh.Text = QuanLyCuaHangCaPhe.Function.GetFieldValues("SELECT HinhAnh FROM SanPham WHERE MaSanPham = N'" + txtMasanpham.Text + "'");
            txtGianhap.Text = dataGridViewQLyCaPhe.CurrentRow.Cells["GiaNhap"].Value.ToString();
            //hien thị hình ảnh lên picturebox neu ko co hien thi tbao loi
            if (!string.IsNullOrEmpty(txtAnh.Text) && File.Exists(txtAnh.Text))
            {
                picAnh.Image = Image.FromFile(txtAnh.Text);
            }
            else
            {
                picAnh.Image = null;
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            string selectedMaSanPham = dataGridViewQLyCaPhe.CurrentRow.Cells["MaSanPham"].Value.ToString();
            Load_DataGridViewChiTietSP(selectedMaSanPham);

        }
        private void Load_DataGridViewChiTietSP(string maSanPham)
        {
            string sql;
            sql = $"SELECT MaSanPham, n.MaNguyenLieu, n.TenNguyenLieu, SoLuongDung, ChiPhi FROM ChiTietSanPham c join NguyenLieu n on c.MaNguyenLieu = n.MaNguyenLieu WHERE MaSanPham = N'{maSanPham}'";
            ChiTietSanPham = QuanLyCuaHangCaPhe.Function.GetDataToTable(sql);
            // Gán dữ liệu từ bảng vào datagridview
            dataGridViewChiTietSP.DataSource = ChiTietSanPham;

            // Đặt tên cho các cột
            dataGridViewChiTietSP.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridViewChiTietSP.Columns[1].HeaderText = "Mã nguyên liệu";
            dataGridViewChiTietSP.Columns[2].HeaderText = "Tên nguyên liệu";
            dataGridViewChiTietSP.Columns[3].HeaderText = "Số lượng dùng";
            dataGridViewChiTietSP.Columns[4].HeaderText = "Chi phí";
            dataGridViewChiTietSP.Columns[0].Width = 70;
            dataGridViewChiTietSP.Columns[1].Width = 100;
            dataGridViewChiTietSP.Columns[2].Width = 100;
            dataGridViewChiTietSP.Columns[3].Width = 100;
            dataGridViewChiTietSP.Columns[4].Width = 50;

            // In đậm tên các cột
            dataGridViewChiTietSP.ColumnHeadersDefaultCellStyle.Font = new Font(
                dataGridViewChiTietSP.Font.FontFamily,
                dataGridViewChiTietSP.Font.Size,
                FontStyle.Bold
            );

            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dataGridViewChiTietSP.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dataGridViewChiTietSP.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        public void ResetValues()
        {
            txtMasanpham.Text = "";
            txtTensanpham.Text = "";
            cboDanhmuc.Text = "";
            txtGiaban.Text = "";
        }

       
            private void dataGridViewChiTietSP_Click(object sender, EventArgs e)
        {
            string ma1= "";
            string ma2 = "";
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasanpham.Focus();
                return;
            }
            if (SanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Lấy dòng hiện tại
            ma2 = dataGridViewChiTietSP.CurrentRow.Cells["MaSanPham"].Value.ToString();
            cboMaSPChitiet.Text = QuanLyCuaHangCaPhe.Function.GetFieldValues("SELECT MaSanPham FROM SanPham WHERE MaSanPham = N'" + ma2 + "'");
            txtSoluongdung.Text = dataGridViewChiTietSP.CurrentRow.Cells["SoLuongDung"].Value.ToString();
            //txtTennguyenlieu.Text = dataGridViewChiTietSP.CurrentRow.Cells["TenNguyenLieu"].Value.ToString();
            // ma = dataGridViewQLyCaPhe.CurrentRow.Cells["MaLoai"].Value.ToString();
            ma1 = dataGridViewChiTietSP.CurrentRow.Cells["MaNguyenLieu"].Value.ToString();
            cboNguyenlieu.Text = QuanLyCuaHangCaPhe.Function.GetFieldValues("SELECT TenNguyenLieu FROM NguyenLieu WHERE MaNguyenLieu = N'" + ma1 + "'");

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = true;
            btnOpen.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues();
            txtMasanpham.Enabled = true;
            txtTensanpham.Enabled = true;
            cboDanhmuc.Enabled = true;
            txtGiaban.Enabled = false;
            txtGianhap.Enabled = false;
            txtAnh.Enabled = true;
            txtMasanpham.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK);
                txtMasanpham.Focus();
                return;
            }
            if (txtTensanpham.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK);
                txtTensanpham.Focus();
                return;
            }
            
            
            if (cboDanhmuc.Text == "")
            {
                MessageBox.Show("Bạn phải chọn loại sản phẩm", "Thông báo", MessageBoxButtons.OK);
                cboDanhmuc.Focus();
                return;
            }
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ảnh", "Thông báo", MessageBoxButtons.OK);
                txtAnh.Focus();
                return;
            }
            //check khóa chính mã hàng
            sql = "SELECT MaSanPham FROM SanPham WHERE MaSanPham=N'" + txtMasanpham.Text.Trim() + "'";

            if (QuanLyCuaHangCaPhe.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasanpham.Focus();
                txtMasanpham.Text = "";
                return;
            }
            //Thêm mới
            sql = "INSERT INTO SanPham (MaSanPham, TenSanPham,MaLoai, HinheAnh) " +
      "VALUES (N'" + txtMasanpham.Text + "', N'" + txtTensanpham.Text + "', N'" + cboDanhmuc.SelectedValue.ToString() +
      "', N'" + txtAnh.Text + "')";

            QuanLyCuaHangCaPhe.Function.RunSql(sql);
            Load_DataGridViewSP();
            ResetValues();

            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "jpg(*.jpg)|*.jpg|png(*.png)|*.png|All files(*.*)|*.*\"";
            open.InitialDirectory = "D:\\LẬP TRÌNH .NET\\BTLdotnet\\Picture";
            open.FilterIndex = 1;
            open.Title = "Chọn ảnh";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = open.FileName;
                picAnh.Image = Image.FromFile(txtAnh.Text);
            }

        }

        public void ResetValues1()
        {
            cboMaSPChitiet.Text = "";
            cboNguyenlieu.Text = "";
            txtSoluongdung.Text = "";
   
        }
        private void btnThemChitiet_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = true;
            btnOpen.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues1();
            cboMaSPChitiet.Enabled = true;
            cboNguyenlieu.Enabled = true;
            txtSoluongdung.Enabled = true;
            cboMaSPChitiet.Focus();

            string sqlSanPham = "SELECT MaSanPham, TenSanPham FROM SanPham";
            QuanLyCuaHangCaPhe.Function.FillCombo(sqlSanPham, cboMaSPChitiet, "MaSanPham", "TenSanPham");
            cboMaSPChitiet.SelectedIndex = -1;

            string sqlNguyenLieu = "SELECT MaNguyenLieu, TenNguyenLieu FROM NguyenLieu";
            QuanLyCuaHangCaPhe.Function.FillCombo(sqlNguyenLieu, cboNguyenlieu, "MaNguyenLieu", "TenNguyenLieu");
            cboNguyenlieu.SelectedIndex = -1;

            cboMaSPChitiet.Enabled = true;
            cboNguyenlieu.Enabled = true;
            txtSoluongdung.Enabled = true;
            cboMaSPChitiet.Focus();
        }

        private void btnLuuChitiet_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMaSPChitiet.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã sản phẩm", "Thông báo", MessageBoxButtons.OK);
                cboMaSPChitiet.Focus();
                return;
            }
            if (cboNguyenlieu.Text == "")
            {
                MessageBox.Show("Bạn phải chọn nguyên liệu", "Thông báo", MessageBoxButtons.OK);
                cboNguyenlieu.Focus();
                return;
            }


            if (txtSoluongdung.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng dùng", "Thông báo", MessageBoxButtons.OK);
                cboDanhmuc.Focus();
                return;
            }

            //check khóa chính mã hàng
            sql = "SELECT MaSanPham,MaNguyenLieu FROM ChiTietSanPham WHERE MaSanPham=N'" + cboMaSPChitiet.Text.Trim() + "'";

            if (QuanLyCuaHangCaPhe.Function.CheckKey(sql))
            {
                MessageBox.Show("Mã sản phẩm và mã nguyên liệu này này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaSPChitiet.Focus();
                cboMaSPChitiet.Text = "";
                return;
            }
            //Thêm mới
            sql = "INSERT INTO ChiTietSanPham (MaSanPham, MaNguyenLieu,SoLuongDung) " +
      "VALUES (N'" + cboMaSPChitiet.SelectedValue.ToString() + "', N'" + cboNguyenlieu.SelectedValue.ToString() + "', N'" + txtSoluongdung.Text +
      "')";

            QuanLyCuaHangCaPhe.Function.RunSql(sql);
            Load_DataGridViewSP();
            ResetValues1();

            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            string sql1= "";
            if (SanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (txtMasanpham.Text == "")
            {
                MessageBox.Show("Bạn phải chọn hàng để xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql1= "delete ChiTietSanPham where MaSanPham = N'" + txtMasanpham.Text + "'";
                sql = "delete SanPham where MaSanPham = N'" + txtMasanpham.Text + "'";
                QuanLyCuaHangCaPhe.Function.RunSqlDel(sql1);
                QuanLyCuaHangCaPhe.Function.RunSqlDel(sql);
                Load_DataGridViewSP();
                ResetValues();
            }


        }
    }
}
