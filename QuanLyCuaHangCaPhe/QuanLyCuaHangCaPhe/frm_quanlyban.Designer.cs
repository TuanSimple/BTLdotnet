namespace QuanLyCuaHangCaPhe
{
    partial class frm_quanlyban
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
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSoluongghe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTinhtrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.datagridBan = new System.Windows.Forms.DataGridView();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnLamoi = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.flpBan.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBan)).BeginInit();
            this.SuspendLayout();
            // 
            // flpBan
            // 
            this.flpBan.BackColor = System.Drawing.Color.Beige;
            this.flpBan.Controls.Add(this.iconButton1);
            this.flpBan.Controls.Add(this.iconButton2);
            this.flpBan.Location = new System.Drawing.Point(720, 130);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(533, 504);
            this.flpBan.TabIndex = 18;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(257, 198);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "B01";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(266, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(257, 198);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "B02";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.txtSoluongghe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTinhtrang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaban);
            this.panel1.Location = new System.Drawing.Point(109, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 194);
            this.panel1.TabIndex = 17;
            // 
            // txtSoluongghe
            // 
            this.txtSoluongghe.Location = new System.Drawing.Point(172, 94);
            this.txtSoluongghe.Name = "txtSoluongghe";
            this.txtSoluongghe.Size = new System.Drawing.Size(324, 31);
            this.txtSoluongghe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bàn ";
            // 
            // cboTinhtrang
            // 
            this.cboTinhtrang.FormattingEnabled = true;
            this.cboTinhtrang.Location = new System.Drawing.Point(172, 143);
            this.cboTinhtrang.Name = "cboTinhtrang";
            this.cboTinhtrang.Size = new System.Drawing.Size(324, 33);
            this.cboTinhtrang.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng ghế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tình trạng ";
            // 
            // txtMaban
            // 
            this.txtMaban.Location = new System.Drawing.Point(172, 42);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(324, 31);
            this.txtMaban.TabIndex = 3;
            // 
            // datagridBan
            // 
            this.datagridBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBan.Location = new System.Drawing.Point(109, 330);
            this.datagridBan.Name = "datagridBan";
            this.datagridBan.RowHeadersWidth = 82;
            this.datagridBan.RowTemplate.Height = 33;
            this.datagridBan.Size = new System.Drawing.Size(587, 304);
            this.datagridBan.TabIndex = 16;
//            this.datagridBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridBan_CellContentClick);
            // 
            // ibtnThem
            // 
            this.ibtnThem.BackColor = System.Drawing.Color.Green;
            this.ibtnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.ibtnThem.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.IconSize = 30;
            this.ibtnThem.Location = new System.Drawing.Point(97, 691);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(150, 70);
            this.ibtnThem.TabIndex = 19;
            this.ibtnThem.Text = "Thêm ";
            this.ibtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnThem.UseVisualStyleBackColor = false;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.BackColor = System.Drawing.Color.Green;
            this.ibtnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnSua.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.IconSize = 30;
            this.ibtnSua.Location = new System.Drawing.Point(336, 691);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(150, 70);
            this.ibtnSua.TabIndex = 20;
            this.ibtnSua.Text = "Sửa";
            this.ibtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSua.UseVisualStyleBackColor = false;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.BackColor = System.Drawing.Color.Green;
            this.ibtnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnXoa.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.IconSize = 30;
            this.ibtnXoa.Location = new System.Drawing.Point(578, 691);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(150, 70);
            this.ibtnXoa.TabIndex = 21;
            this.ibtnXoa.Text = "Xóa ";
            this.ibtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnXoa.UseVisualStyleBackColor = false;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.BackColor = System.Drawing.Color.Green;
            this.ibtnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.ibtnLuu.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.IconSize = 30;
            this.ibtnLuu.Location = new System.Drawing.Point(800, 691);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(150, 70);
            this.ibtnLuu.TabIndex = 22;
            this.ibtnLuu.Text = "Lưu";
            this.ibtnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // ibtnLamoi
            // 
            this.ibtnLamoi.BackColor = System.Drawing.Color.Green;
            this.ibtnLamoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLamoi.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnLamoi.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ibtnLamoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLamoi.IconSize = 30;
            this.ibtnLamoi.Location = new System.Drawing.Point(1026, 691);
            this.ibtnLamoi.Name = "ibtnLamoi";
            this.ibtnLamoi.Size = new System.Drawing.Size(150, 70);
            this.ibtnLamoi.TabIndex = 23;
            this.ibtnLamoi.Text = "Làm mới ";
            this.ibtnLamoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLamoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnLamoi.UseVisualStyleBackColor = false;
            this.ibtnLamoi.Click += new System.EventHandler(this.ibtnLamoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(385, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(609, 67);
            this.label4.TabIndex = 24;
            this.label4.Text = "Danh sách quản lý bàn";
            // 
            // frm_quanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 826);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ibtnLamoi);
            this.Controls.Add(this.ibtnLuu);
            this.Controls.Add(this.ibtnXoa);
            this.Controls.Add(this.ibtnSua);
            this.Controls.Add(this.ibtnThem);
            this.Controls.Add(this.flpBan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datagridBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_quanlyban";
            this.Text = "frm_quanlyban";
            this.Load += new System.EventHandler(this.frm_quanlyban_Load);
            this.flpBan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSoluongghe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTinhtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.DataGridView datagridBan;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnLamoi;
        public FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
    }
}