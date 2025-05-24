namespace QuanLyCuaHangCaPhe
{
    partial class frm_quanlytaikhoan
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
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnLammoi = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.mskSodienthoai = new System.Windows.Forms.MaskedTextBox();
            this.mskNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaque = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.chkNu = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.cboMachucvu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.datagridtaikhoan = new System.Windows.Forms.DataGridView();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.BackColor = System.Drawing.Color.Green;
            this.ibtnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnLuu.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.IconSize = 30;
            this.ibtnLuu.Location = new System.Drawing.Point(586, 867);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(150, 70);
            this.ibtnLuu.TabIndex = 23;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // ibtnLammoi
            // 
            this.ibtnLammoi.BackColor = System.Drawing.Color.Green;
            this.ibtnLammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnLammoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLammoi.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnLammoi.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLammoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLammoi.IconSize = 30;
            this.ibtnLammoi.Location = new System.Drawing.Point(1076, 867);
            this.ibtnLammoi.Name = "ibtnLammoi";
            this.ibtnLammoi.Size = new System.Drawing.Size(150, 70);
            this.ibtnLammoi.TabIndex = 24;
            this.ibtnLammoi.Text = "Làm mới ";
            this.ibtnLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLammoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLammoi.UseVisualStyleBackColor = false;
            this.ibtnLammoi.Click += new System.EventHandler(this.ibtnLammoi_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.BackColor = System.Drawing.Color.Green;
            this.ibtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnXoa.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 30;
            this.ibtnXoa.Location = new System.Drawing.Point(825, 867);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(150, 70);
            this.ibtnXoa.TabIndex = 25;
            this.ibtnXoa.Text = "Xóa ";
            this.ibtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoa.UseVisualStyleBackColor = false;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.BackColor = System.Drawing.Color.Green;
            this.ibtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnSua.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.IconSize = 30;
            this.ibtnSua.Location = new System.Drawing.Point(339, 867);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(150, 70);
            this.ibtnSua.TabIndex = 26;
            this.ibtnSua.Text = "Sửa ";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = false;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnThem.BackColor = System.Drawing.Color.Green;
            this.ibtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibtnThem.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 30;
            this.ibtnThem.Location = new System.Drawing.Point(100, 867);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(150, 70);
            this.ibtnThem.TabIndex = 27;
            this.ibtnThem.Text = "Thêm";
            this.ibtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = false;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.Controls.Add(this.txtLuong);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtMatkhau);
            this.panel2.Controls.Add(this.mskSodienthoai);
            this.panel2.Controls.Add(this.mskNgaysinh);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(669, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 297);
            this.panel2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ngày sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Địa chỉ email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(180, 74);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(319, 31);
            this.txtMatkhau.TabIndex = 16;
            // 
            // mskSodienthoai
            // 
            this.mskSodienthoai.Location = new System.Drawing.Point(180, 123);
            this.mskSodienthoai.Mask = "(999) 000-0000";
            this.mskSodienthoai.Name = "mskSodienthoai";
            this.mskSodienthoai.Size = new System.Drawing.Size(319, 31);
            this.mskSodienthoai.TabIndex = 2;
            // 
            // mskNgaysinh
            // 
            this.mskNgaysinh.Location = new System.Drawing.Point(180, 175);
            this.mskNgaysinh.Mask = "0000/00/00";
            this.mskNgaysinh.Name = "mskNgaysinh";
            this.mskNgaysinh.Size = new System.Drawing.Size(319, 31);
            this.mskNgaysinh.TabIndex = 0;
            this.mskNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboMaque);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTennhanvien);
            this.panel1.Controls.Add(this.chkNu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chkNam);
            this.panel1.Controls.Add(this.cboMachucvu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtManhanvien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(106, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 297);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giới tính";
            // 
            // cboMaque
            // 
            this.cboMaque.FormattingEnabled = true;
            this.cboMaque.Location = new System.Drawing.Point(214, 179);
            this.cboMaque.Name = "cboMaque";
            this.cboMaque.Size = new System.Drawing.Size(237, 33);
            this.cboMaque.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quê quán";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(214, 80);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(237, 31);
            this.txtTennhanvien.TabIndex = 11;
            // 
            // chkNu
            // 
            this.chkNu.AutoSize = true;
            this.chkNu.Location = new System.Drawing.Point(380, 229);
            this.chkNu.Name = "chkNu";
            this.chkNu.Size = new System.Drawing.Size(71, 29);
            this.chkNu.TabIndex = 1;
            this.chkNu.Text = "Nữ";
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã nhân viên ";
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(214, 229);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(88, 29);
            this.chkNam.TabIndex = 0;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // cboMachucvu
            // 
            this.cboMachucvu.FormattingEnabled = true;
            this.cboMachucvu.Location = new System.Drawing.Point(214, 129);
            this.cboMachucvu.Name = "cboMachucvu";
            this.cboMachucvu.Size = new System.Drawing.Size(237, 33);
            this.cboMachucvu.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(214, 28);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(237, 31);
            this.txtManhanvien.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chức vụ ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(293, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(751, 67);
            this.label11.TabIndex = 28;
            this.label11.Text = "Danh sách quản lý tài khoản";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // datagridtaikhoan
            // 
            this.datagridtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridtaikhoan.Location = new System.Drawing.Point(106, 443);
            this.datagridtaikhoan.Name = "datagridtaikhoan";
            this.datagridtaikhoan.RowHeadersWidth = 82;
            this.datagridtaikhoan.RowTemplate.Height = 33;
            this.datagridtaikhoan.Size = new System.Drawing.Size(1126, 403);
            this.datagridtaikhoan.TabIndex = 29;
            this.datagridtaikhoan.Click += new System.EventHandler(this.datagridtaikhoan_Click_1);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(180, 230);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(319, 31);
            this.txtLuong.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 230);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Lương ";
            // 
            // frm_quanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 1066);
            this.Controls.Add(this.datagridtaikhoan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.ibtnLammoi);
            this.Controls.Add(this.ibtnXoa);
            this.Controls.Add(this.ibtnSua);
            this.Controls.Add(this.ibtnThem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_quanlytaikhoan";
            this.Text = "frm_quanlytaikhoan";
            this.Load += new System.EventHandler(this.frm_quanlytaikhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridtaikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnLammoi;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.MaskedTextBox mskSodienthoai;
        private System.Windows.Forms.MaskedTextBox mskNgaysinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaque;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.CheckBox chkNu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.ComboBox cboMachucvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datagridtaikhoan;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label label12;
    }
}