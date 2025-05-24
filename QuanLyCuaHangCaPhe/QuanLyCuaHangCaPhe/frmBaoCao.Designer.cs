namespace QuanLyCuaHangCaPhe
{
    partial class frmBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNgay = new System.Windows.Forms.RadioButton();
            this.rdoKhoang = new System.Windows.Forms.RadioButton();
            this.PanelTime = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnInBC = new System.Windows.Forms.Button();
            this.txtBangchu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.ckbHD = new System.Windows.Forms.CheckBox();
            this.ckbSP = new System.Windows.Forms.CheckBox();
            this.cboSP = new System.Windows.Forms.ComboBox();
            this.mskNgay = new System.Windows.Forms.DateTimePicker();
            this.PanelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Location = new System.Drawing.Point(182, 198);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Size = new System.Drawing.Size(108, 24);
            this.rdoNgay.TabIndex = 1;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Theo ngày";
            this.rdoNgay.UseVisualStyleBackColor = true;
            this.rdoNgay.CheckedChanged += new System.EventHandler(this.rdoNgay_CheckedChanged);
            // 
            // rdoKhoang
            // 
            this.rdoKhoang.AutoSize = true;
            this.rdoKhoang.Location = new System.Drawing.Point(566, 198);
            this.rdoKhoang.Name = "rdoKhoang";
            this.rdoKhoang.Size = new System.Drawing.Size(127, 24);
            this.rdoKhoang.TabIndex = 3;
            this.rdoKhoang.TabStop = true;
            this.rdoKhoang.Text = "Theo khoảng";
            this.rdoKhoang.UseVisualStyleBackColor = true;
            this.rdoKhoang.CheckedChanged += new System.EventHandler(this.rdoKhoang_CheckedChanged);
            // 
            // PanelTime
            // 
            this.PanelTime.Controls.Add(this.label3);
            this.PanelTime.Controls.Add(this.label2);
            this.PanelTime.Controls.Add(this.dateTimePicker2);
            this.PanelTime.Controls.Add(this.dateTimePicker1);
            this.PanelTime.Location = new System.Drawing.Point(700, 188);
            this.PanelTime.Name = "PanelTime";
            this.PanelTime.Size = new System.Drawing.Size(416, 40);
            this.PanelTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(264, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(140, 26);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.Value = new System.DateTime(2025, 5, 22, 17, 1, 27, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(139, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(182, 250);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(922, 352);
            this.dataGridView.TabIndex = 6;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(438, 670);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(93, 31);
            this.btnLammoi.TabIndex = 7;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(590, 670);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(93, 31);
            this.btnHienthi.TabIndex = 8;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnInBC
            // 
            this.btnInBC.Location = new System.Drawing.Point(752, 670);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(93, 31);
            this.btnInBC.TabIndex = 9;
            this.btnInBC.Text = "In báo cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // txtBangchu
            // 
            this.txtBangchu.AutoSize = true;
            this.txtBangchu.Location = new System.Drawing.Point(178, 616);
            this.txtBangchu.Name = "txtBangchu";
            this.txtBangchu.Size = new System.Drawing.Size(85, 20);
            this.txtBangchu.TabIndex = 10;
            this.txtBangchu.Text = "Bằng chữ: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(975, 607);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(129, 26);
            this.txtTongtien.TabIndex = 12;
            // 
            // ckbHD
            // 
            this.ckbHD.AutoSize = true;
            this.ckbHD.Location = new System.Drawing.Point(289, 135);
            this.ckbHD.Name = "ckbHD";
            this.ckbHD.Size = new System.Drawing.Size(133, 24);
            this.ckbHD.TabIndex = 13;
            this.ckbHD.Text = "Theo hóa đơn";
            this.ckbHD.UseVisualStyleBackColor = true;
            this.ckbHD.CheckedChanged += new System.EventHandler(this.ckbHD_CheckedChanged);
            // 
            // ckbSP
            // 
            this.ckbSP.AutoSize = true;
            this.ckbSP.Location = new System.Drawing.Point(711, 135);
            this.ckbSP.Name = "ckbSP";
            this.ckbSP.Size = new System.Drawing.Size(145, 24);
            this.ckbSP.TabIndex = 14;
            this.ckbSP.Text = "Theo sản phẩm";
            this.ckbSP.UseVisualStyleBackColor = true;
            this.ckbSP.CheckedChanged += new System.EventHandler(this.ckbSP_CheckedChanged);
            // 
            // cboSP
            // 
            this.cboSP.FormattingEnabled = true;
            this.cboSP.Location = new System.Drawing.Point(862, 131);
            this.cboSP.Name = "cboSP";
            this.cboSP.Size = new System.Drawing.Size(121, 28);
            this.cboSP.TabIndex = 15;
            // 
            // mskNgay
            // 
            this.mskNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskNgay.Location = new System.Drawing.Point(296, 195);
            this.mskNgay.Name = "mskNgay";
            this.mskNgay.Size = new System.Drawing.Size(139, 26);
            this.mskNgay.TabIndex = 16;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 726);
            this.Controls.Add(this.mskNgay);
            this.Controls.Add(this.cboSP);
            this.Controls.Add(this.ckbSP);
            this.Controls.Add(this.ckbHD);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBangchu);
            this.Controls.Add(this.btnInBC);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.PanelTime);
            this.Controls.Add(this.rdoKhoang);
            this.Controls.Add(this.rdoNgay);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.PanelTime.ResumeLayout(false);
            this.PanelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.RadioButton rdoKhoang;
        private System.Windows.Forms.Panel PanelTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnInBC;
        private System.Windows.Forms.Label txtBangchu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.CheckBox ckbHD;
        private System.Windows.Forms.CheckBox ckbSP;
        private System.Windows.Forms.ComboBox cboSP;
        private System.Windows.Forms.DateTimePicker mskNgay;
    }
}