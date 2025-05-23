namespace QuanLyCuaHangCaPhe
{
    partial class frmBaocaohoadon_Nhanvien
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
            this.dGridBaocaohoadon = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.cbTinhtrangthanhtoan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGridChitiethoadon = new System.Windows.Forms.DataGridView();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMakhuyenmai = new System.Windows.Forms.TextBox();
            this.txtMuckhuyenmai = new System.Windows.Forms.TextBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTonghoadon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGridBaocaohoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridChitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridBaocaohoadon
            // 
            this.dGridBaocaohoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBaocaohoadon.Location = new System.Drawing.Point(70, 79);
            this.dGridBaocaohoadon.Name = "dGridBaocaohoadon";
            this.dGridBaocaohoadon.RowHeadersWidth = 51;
            this.dGridBaocaohoadon.RowTemplate.Height = 24;
            this.dGridBaocaohoadon.Size = new System.Drawing.Size(756, 566);
            this.dGridBaocaohoadon.TabIndex = 0;
            this.dGridBaocaohoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBaocaohoadon_CellContentClick);
            this.dGridBaocaohoadon.Click += new System.EventHandler(this.dGridBaocaohoadon_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(626, 54);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(200, 22);
            this.Time.TabIndex = 2;
            this.Time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // cbTinhtrangthanhtoan
            // 
            this.cbTinhtrangthanhtoan.FormattingEnabled = true;
            this.cbTinhtrangthanhtoan.Items.AddRange(new object[] {
            "All",
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbTinhtrangthanhtoan.Location = new System.Drawing.Point(499, 52);
            this.cbTinhtrangthanhtoan.Name = "cbTinhtrangthanhtoan";
            this.cbTinhtrangthanhtoan.Size = new System.Drawing.Size(121, 24);
            this.cbTinhtrangthanhtoan.TabIndex = 3;
            this.cbTinhtrangthanhtoan.SelectedIndexChanged += new System.EventHandler(this.cbTinhtrangthanhtoan_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(337, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1022, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chi Tiết Hóa Đơn";
            // 
            // dGridChitiethoadon
            // 
            this.dGridChitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridChitiethoadon.Location = new System.Drawing.Point(880, 79);
            this.dGridChitiethoadon.Name = "dGridChitiethoadon";
            this.dGridChitiethoadon.RowHeadersWidth = 51;
            this.dGridChitiethoadon.RowTemplate.Height = 24;
            this.dGridChitiethoadon.Size = new System.Drawing.Size(497, 303);
            this.dGridChitiethoadon.TabIndex = 6;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(1006, 424);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(113, 22);
            this.txtMahoadon.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(877, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(877, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã khuyến mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(1153, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mức khuyến mãi";
            // 
            // txtMakhuyenmai
            // 
            this.txtMakhuyenmai.Location = new System.Drawing.Point(1006, 460);
            this.txtMakhuyenmai.Name = "txtMakhuyenmai";
            this.txtMakhuyenmai.Size = new System.Drawing.Size(113, 22);
            this.txtMakhuyenmai.TabIndex = 14;
            // 
            // txtMuckhuyenmai
            // 
            this.txtMuckhuyenmai.Location = new System.Drawing.Point(1277, 460);
            this.txtMuckhuyenmai.Name = "txtMuckhuyenmai";
            this.txtMuckhuyenmai.Size = new System.Drawing.Size(100, 22);
            this.txtMuckhuyenmai.TabIndex = 15;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(1277, 424);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(100, 22);
            this.txtTinhtrang.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(1185, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tình trạng";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.Dev;
            this.btnHuy.IconColor = System.Drawing.Color.Honeydew;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHuy.IconSize = 25;
            this.btnHuy.Location = new System.Drawing.Point(1264, 513);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 56);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseCompatibleTextRendering = true;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.Location = new System.Drawing.Point(1241, 609);
            this.txtTongtien.Multiline = true;
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(136, 36);
            this.txtTongtien.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(1152, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tổng tiền";
            // 
            // txtTonghoadon
            // 
            this.txtTonghoadon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonghoadon.Location = new System.Drawing.Point(1078, 609);
            this.txtTonghoadon.Multiline = true;
            this.txtTonghoadon.Name = "txtTonghoadon";
            this.txtTonghoadon.Size = new System.Drawing.Size(68, 36);
            this.txtTonghoadon.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(955, 625);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Tổng hóa đơn";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(1156, 528);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 22);
            this.txtPass.TabIndex = 28;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // frmBaocaohoadon_Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 686);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTonghoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.txtMuckhuyenmai);
            this.Controls.Add(this.txtMakhuyenmai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.dGridChitiethoadon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTinhtrangthanhtoan);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.dGridBaocaohoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaocaohoadon_Nhanvien";
            this.Text = "frmBaocaohoadon_Nhanvien";
            this.Load += new System.EventHandler(this.frmBaocaohoadon_Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBaocaohoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridChitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridBaocaohoadon;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.ComboBox cbTinhtrangthanhtoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGridChitiethoadon;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMakhuyenmai;
        private System.Windows.Forms.TextBox txtMuckhuyenmai;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnHuy;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTonghoadon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
    }
}