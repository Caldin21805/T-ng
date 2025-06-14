namespace QLBH
{
    partial class TimKiemHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboThanhPho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSoHD = new System.Windows.Forms.TextBox();
            this.DgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.CthdMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSoMH = new System.Windows.Forms.TextBox();
            this.DgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TxtSoKH = new System.Windows.Forms.TextBox();
            this.CboKhachHang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thành Phố";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách Hàng";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // CboThanhPho
            // 
            this.CboThanhPho.FormattingEnabled = true;
            this.CboThanhPho.Location = new System.Drawing.Point(158, 9);
            this.CboThanhPho.Name = "CboThanhPho";
            this.CboThanhPho.Size = new System.Drawing.Size(243, 28);
            this.CboThanhPho.TabIndex = 2;
            this.CboThanhPho.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(676, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng hóa đơn";
            // 
            // TxtSoHD
            // 
            this.TxtSoHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSoHD.Location = new System.Drawing.Point(876, 359);
            this.TxtSoHD.Name = "TxtSoHD";
            this.TxtSoHD.Size = new System.Drawing.Size(68, 26);
            this.TxtSoHD.TabIndex = 3;
            // 
            // DgvChiTietHoaDon
            // 
            this.DgvChiTietHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CthdMaHD,
            this.MaSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.DgvChiTietHoaDon.Location = new System.Drawing.Point(7, 398);
            this.DgvChiTietHoaDon.Name = "DgvChiTietHoaDon";
            this.DgvChiTietHoaDon.RowHeadersWidth = 62;
            this.DgvChiTietHoaDon.RowTemplate.Height = 28;
            this.DgvChiTietHoaDon.Size = new System.Drawing.Size(958, 235);
            this.DgvChiTietHoaDon.TabIndex = 4;
            // 
            // CthdMaHD
            // 
            this.CthdMaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CthdMaHD.DataPropertyName = "CthdMaHD";
            this.CthdMaHD.HeaderText = "MÃ HD";
            this.CthdMaHD.MinimumWidth = 8;
            this.CthdMaHD.Name = "CthdMaHD";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "SẢN PHẨM";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "ĐƠN GIÁ";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "THÀNH TIỀN";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // TxtSoMH
            // 
            this.TxtSoMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSoMH.Location = new System.Drawing.Point(879, 640);
            this.TxtSoMH.Name = "TxtSoMH";
            this.TxtSoMH.Size = new System.Drawing.Size(68, 26);
            this.TxtSoMH.TabIndex = 3;
            // 
            // DgvHoaDon
            // 
            this.DgvHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.NgayLapHD,
            this.NgayNhanHang,
            this.MaNV});
            this.DgvHoaDon.Location = new System.Drawing.Point(-2, 120);
            this.DgvHoaDon.Name = "DgvHoaDon";
            this.DgvHoaDon.RowHeadersWidth = 62;
            this.DgvHoaDon.RowTemplate.Height = 28;
            this.DgvHoaDon.Size = new System.Drawing.Size(957, 233);
            this.DgvHoaDon.TabIndex = 5;
            this.DgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHoaDon_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "MÃ HD";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "KHÁCH HÀNG";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaKH.Width = 150;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "NGÀY LẬP HĐ";
            this.NgayLapHD.MinimumWidth = 8;
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // NgayNhanHang
            // 
            this.NgayNhanHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhanHang.DataPropertyName = "NgayNhanHang";
            this.NgayNhanHang.HeaderText = "NGÀY NHẬN HÀNG";
            this.NgayNhanHang.MinimumWidth = 8;
            this.NgayNhanHang.Name = "NgayNhanHang";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "NHÂN VIÊN LẬP HĐ";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 150;
            // 
            // TxtSoKH
            // 
            this.TxtSoKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSoKH.Location = new System.Drawing.Point(558, 13);
            this.TxtSoKH.Name = "TxtSoKH";
            this.TxtSoKH.Size = new System.Drawing.Size(71, 26);
            this.TxtSoKH.TabIndex = 6;
            // 
            // CboKhachHang
            // 
            this.CboKhachHang.FormattingEnabled = true;
            this.CboKhachHang.Location = new System.Drawing.Point(158, 57);
            this.CboKhachHang.Name = "CboKhachHang";
            this.CboKhachHang.Size = new System.Drawing.Size(243, 28);
            this.CboKhachHang.TabIndex = 7;
            this.CboKhachHang.SelectedIndexChanged += new System.EventHandler(this.CboKhachHang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(3, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(3, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(666, 636);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng mặt hàng";
            // 
            // TimKiemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 678);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CboKhachHang);
            this.Controls.Add(this.TxtSoKH);
            this.Controls.Add(this.DgvHoaDon);
            this.Controls.Add(this.DgvChiTietHoaDon);
            this.Controls.Add(this.TxtSoMH);
            this.Controls.Add(this.TxtSoHD);
            this.Controls.Add(this.CboThanhPho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimKiemHoaDon";
            this.Text = "TimKiemHoaDon";
            this.Load += new System.EventHandler(this.TimKiemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboThanhPho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSoHD;
        private System.Windows.Forms.DataGridView DgvChiTietHoaDon;
        private System.Windows.Forms.TextBox TxtSoMH;
        private System.Windows.Forms.DataGridView DgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CthdMaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox TxtSoKH;
        private System.Windows.Forms.ComboBox CboKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
    }
}