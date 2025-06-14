namespace QLBH
{
    partial class LapHoaDon
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
            this.CboKhachHang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMaHD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvSanPhamMua = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLuuHoaDon = new System.Windows.Forms.Button();
            this.BtnInHoaDon = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTongTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSanPhamMua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "lập hóa đơn bán hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // CboKhachHang
            // 
            this.CboKhachHang.FormattingEnabled = true;
            this.CboKhachHang.Location = new System.Drawing.Point(112, 63);
            this.CboKhachHang.Name = "CboKhachHang";
            this.CboKhachHang.Size = new System.Drawing.Size(328, 28);
            this.CboKhachHang.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 2;
            this.button1.Tag = "A";
            this.button1.Text = "Thêm KH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HĐ:";
            // 
            // LblMaHD
            // 
            this.LblMaHD.AutoSize = true;
            this.LblMaHD.Location = new System.Drawing.Point(91, 124);
            this.LblMaHD.Name = "LblMaHD";
            this.LblMaHD.Size = new System.Drawing.Size(45, 20);
            this.LblMaHD.TabIndex = 0;
            this.LblMaHD.Text = "####";
            this.LblMaHD.Click += new System.EventHandler(this.LblMaHD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "sản phẩm mua";
            // 
            // DgvSanPhamMua
            // 
            this.DgvSanPhamMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSanPhamMua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.DgvSanPhamMua.Location = new System.Drawing.Point(26, 188);
            this.DgvSanPhamMua.Name = "DgvSanPhamMua";
            this.DgvSanPhamMua.RowHeadersWidth = 62;
            this.DgvSanPhamMua.RowTemplate.Height = 28;
            this.DgvSanPhamMua.Size = new System.Drawing.Size(811, 272);
            this.DgvSanPhamMua.TabIndex = 3;
            this.DgvSanPhamMua.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHDCboSanPham_CellValueChanged);
            this.DgvSanPhamMua.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DgvHDCboSanPham_UserAddedRow);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Sản phẩm";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaSP.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // BtnLuuHoaDon
            // 
            this.BtnLuuHoaDon.Location = new System.Drawing.Point(26, 526);
            this.BtnLuuHoaDon.Name = "BtnLuuHoaDon";
            this.BtnLuuHoaDon.Size = new System.Drawing.Size(172, 75);
            this.BtnLuuHoaDon.TabIndex = 2;
            this.BtnLuuHoaDon.Tag = "A";
            this.BtnLuuHoaDon.Text = "Tạo mới hóa đơn";
            this.BtnLuuHoaDon.UseVisualStyleBackColor = true;
            this.BtnLuuHoaDon.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnInHoaDon
            // 
            this.BtnInHoaDon.Location = new System.Drawing.Point(522, 526);
            this.BtnInHoaDon.Name = "BtnInHoaDon";
            this.BtnInHoaDon.Size = new System.Drawing.Size(167, 75);
            this.BtnInHoaDon.TabIndex = 2;
            this.BtnInHoaDon.Tag = "A";
            this.BtnInHoaDon.Text = "In hóa đơn";
            this.BtnInHoaDon.UseVisualStyleBackColor = true;
            this.BtnInHoaDon.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền";
            // 
            // LblTongTien
            // 
            this.LblTongTien.AutoSize = true;
            this.LblTongTien.Location = new System.Drawing.Point(628, 477);
            this.LblTongTien.Name = "LblTongTien";
            this.LblTongTien.Size = new System.Drawing.Size(18, 20);
            this.LblTongTien.TabIndex = 0;
            this.LblTongTien.Text = "0";
            // 
            // LapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DgvSanPhamMua);
            this.Controls.Add(this.BtnInHoaDon);
            this.Controls.Add(this.BtnLuuHoaDon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CboKhachHang);
            this.Controls.Add(this.LblMaHD);
            this.Controls.Add(this.LblTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LapHoaDon";
            this.Size = new System.Drawing.Size(834, 613);
            this.Load += new System.EventHandler(this.LapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSanPhamMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboKhachHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvSanPhamMua;
        private System.Windows.Forms.Button BtnLuuHoaDon;
        private System.Windows.Forms.Button BtnInHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTongTien;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}