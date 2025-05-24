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
    public partial class frm_quanlyban : Form
    {
        public frm_quanlyban()
        {
            InitializeComponent();
        }
        DataTable tblban;
        private void frm_quanlyban_Load(object sender, EventArgs e)
        {
            Function.Connect();
            txtMaban.Enabled = false;
            ibtnLuu.Enabled = false;
            Load_DataGridView();
            LoadFlowLayoutPanel();
            cboTinhtrang.Items.Clear();
            cboTinhtrang.Items.Add("1");
            cboTinhtrang.Items.Add("0");
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql = "SELECT * FROM Ban";
            tblban = Function.GetDataToTable(sql);
            datagridBan.DataSource = tblban;
            datagridBan.Columns[0].HeaderText = "Mã bàn";
            datagridBan.Columns[1].HeaderText = "Số lượng bàn";
            datagridBan.Columns[2].HeaderText = "Trạng thái";
            datagridBan.Columns[0].Width = 100;
            datagridBan.Columns[1].Width = 150;
            datagridBan.Columns[2].Width = 150;
            datagridBan.AllowUserToAddRows = false;
            datagridBan.EditMode = DataGridViewEditMode.EditProgrammatically;
            DoiMauTrangThaiBan();
        }
        private void DoiMauTrangThaiBan()
        {
            foreach (DataGridViewRow row in datagridBan.Rows)
            {
                if (row.Cells["Tinhtrang"].Value != null)
                {
                    string tinhtrang = row.Cells["Tinhtrang"].Value.ToString();
                    if (tinhtrang == "1")
                        row.DefaultCellStyle.BackColor = Color.LightPink; // Đang dùng
                    else
                        row.DefaultCellStyle.BackColor = Color.LightGreen; // Trống
                }
            }
        }
        private void LoadFlowLayoutPanel()
        {
            flpBan.Controls.Clear(); // Xóa dữ liệu cũ
            string sql = "SELECT * FROM Ban";
            DataTable dtBan = Function.GetDataToTable(sql);

            foreach (DataRow row in dtBan.Rows)
            {
                Button btn = new Button();
                btn.Width = 100;
                btn.Height = 100;
                btn.Text = row["Maban"].ToString();

                // Áp dụng màu sắc theo trạng thái
                if (row["Tinhtrang"].ToString() == "1")
                    btn.BackColor = Color.LightPink; // Đang dùng
                else
                    btn.BackColor = Color.LightGreen; // Trống

                // Thêm sự kiện click nếu muốn xử lý chọn bàn
                btn.Click += (s, e) =>
                {
                    txtMaban.Text = row["Maban"].ToString();
                    txtSoluongghe.Text = row["Soluongghe"].ToString();
                    cboTinhtrang.Text = row["Tinhtrang"].ToString();
                };

                flpBan.Controls.Add(btn); // Thêm vào FlowLayoutPanel
            }
        }
        private void ResetValues()
        {
            txtMaban.Text = "";
            txtSoluongghe.Text = "";
            cboTinhtrang.Text = "";
            ibtnThem.Enabled = true;
            ibtnXoa.Enabled = true;
            txtMaban.Focus();
        }

        private void ibtnThem_Click(object sender, EventArgs e)
        {
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = true;
            ibtnThem.Enabled = false;
            ResetValues();
            txtMaban.Enabled = true;
            txtSoluongghe.Enabled = true;
            txtSoluongghe.Focus();
            cboTinhtrang.Enabled = true;
            cboTinhtrang.Focus();
        }

        private void ibtnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblban.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaban.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!int.TryParse(txtSoluongghe.Text.Trim(), out int soluongghe))
            {
                MessageBox.Show("Số lượng bàn phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluongghe.Focus();
                return;
            }
            if (cboTinhtrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinhtrang.Focus();
                return;
            }
            sql = "UPDATE Ban SET Soluongghe = " + soluongghe + ", Tinhtrang = N'" + cboTinhtrang.Text.Trim() + "' WHERE Maban = N'" + txtMaban.Text.Trim() + "'";
            Function.RunSql(sql);
            Load_DataGridView();
            ResetValues();
        }

        private void ibtnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblban.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaban.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE Ban WHERE Maban = N'" + txtMaban.Text.Trim() + "'";
                Function.RunSqlDel(sql);
                LoadFlowLayoutPanel();
                Load_DataGridView();
                ResetValues();
            }
        }
        private void ibtnLuu_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaban.Focus();
                return;
            }
            if (!int.TryParse(txtSoluongghe.Text, out int soluong))
            {
                MessageBox.Show("Số lượng bàn phải là số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluongghe.Focus();
                return;
            }
            if (cboTinhtrang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTinhtrang.Focus();
                return;
            }
            sql = "SELECT Maban FROM Ban WHERE Maban=N'" + txtMaban.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã bàn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaban.Focus();
                txtMaban.Text = "";
                return;
            }
            sql = "INSERT INTO Ban(Maban, Soluongghe, Tinhtrang) VALUES(N'" + txtMaban.Text.Trim() + "', " + soluong + ", N'" + cboTinhtrang.Text.Trim() + "')";
            Function.RunSql(sql);
            LoadFlowLayoutPanel();
            Load_DataGridView();  // Nạp lại bảng
            ResetValues();        // Đặt lại các textbox
            ibtnXoa.Enabled = true;
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = true;
            ibtnLuu.Enabled = false;
            txtMaban.Enabled = false;
        }

        private void ibtnLamoi_Click(object sender, EventArgs e)
        {
            ResetValues();
            ibtnThem.Enabled = true;
            ibtnSua.Enabled = false;
            ibtnXoa.Enabled = false;
            ibtnLuu.Enabled = false;
            txtMaban.Enabled = false;
        }

       
    }
}
