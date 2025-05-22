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
            ((System.ComponentModel.ISupportInitialize)(this.dGridBaocaohoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // dGridBaocaohoadon
            // 
            this.dGridBaocaohoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridBaocaohoadon.Location = new System.Drawing.Point(70, 40);
            this.dGridBaocaohoadon.Name = "dGridBaocaohoadon";
            this.dGridBaocaohoadon.RowHeadersWidth = 51;
            this.dGridBaocaohoadon.RowTemplate.Height = 24;
            this.dGridBaocaohoadon.Size = new System.Drawing.Size(763, 605);
            this.dGridBaocaohoadon.TabIndex = 0;
            this.dGridBaocaohoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridBaocaohoadon_CellContentClick);
            // 
            // frmBaocaohoadon_Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 686);
            this.Controls.Add(this.dGridBaocaohoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaocaohoadon_Nhanvien";
            this.Text = "frmBaocaohoadon_Nhanvien";
            this.Load += new System.EventHandler(this.frmBaocaohoadon_Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridBaocaohoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGridBaocaohoadon;
    }
}