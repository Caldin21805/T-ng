namespace QLBH
{
    partial class QuanLyKhachHang
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
            this.LbMaKH = new System.Windows.Forms.Label();
            this.LbTenCty = new System.Windows.Forms.Label();
            this.LbDiaChi = new System.Windows.Forms.Label();
            this.LbThanhPho = new System.Windows.Forms.Label();
            this.LbDienThoai = new System.Windows.Forms.Label();
            this.TxtMaKH = new System.Windows.Forms.TextBox();
            this.TxtTenCty = new System.Windows.Forms.TextBox();
            this.TxtDiaChi = new System.Windows.Forms.TextBox();
            this.TxtDienThoai = new System.Windows.Forms.TextBox();
            this.CboThanhPho = new System.Windows.Forms.ComboBox();
            this.DgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnHuy = new System.Windows.Forms.Button();
            this.BtnTaiLai = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaThanhPho = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbMaKH
            // 
            this.LbMaKH.AutoSize = true;
            this.LbMaKH.Location = new System.Drawing.Point(12, 26);
            this.LbMaKH.Name = "LbMaKH";
            this.LbMaKH.Size = new System.Drawing.Size(57, 20);
            this.LbMaKH.TabIndex = 0;
            this.LbMaKH.Text = "Mã KH";
            this.LbMaKH.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbTenCty
            // 
            this.LbTenCty.AutoSize = true;
            this.LbTenCty.Location = new System.Drawing.Point(6, 70);
            this.LbTenCty.Name = "LbTenCty";
            this.LbTenCty.Size = new System.Drawing.Size(63, 20);
            this.LbTenCty.TabIndex = 0;
            this.LbTenCty.Text = "Công ty";
            this.LbTenCty.Click += new System.EventHandler(this.label2_Click);
            // 
            // LbDiaChi
            // 
            this.LbDiaChi.AutoSize = true;
            this.LbDiaChi.Location = new System.Drawing.Point(12, 118);
            this.LbDiaChi.Name = "LbDiaChi";
            this.LbDiaChi.Size = new System.Drawing.Size(57, 20);
            this.LbDiaChi.TabIndex = 0;
            this.LbDiaChi.Text = "Địa chỉ";
            // 
            // LbThanhPho
            // 
            this.LbThanhPho.AutoSize = true;
            this.LbThanhPho.Location = new System.Drawing.Point(558, 26);
            this.LbThanhPho.Name = "LbThanhPho";
            this.LbThanhPho.Size = new System.Drawing.Size(85, 20);
            this.LbThanhPho.TabIndex = 0;
            this.LbThanhPho.Text = "Thành phố";
            this.LbThanhPho.Click += new System.EventHandler(this.label1_Click);
            // 
            // LbDienThoai
            // 
            this.LbDienThoai.AutoSize = true;
            this.LbDienThoai.Location = new System.Drawing.Point(558, 70);
            this.LbDienThoai.Name = "LbDienThoai";
            this.LbDienThoai.Size = new System.Drawing.Size(81, 20);
            this.LbDienThoai.TabIndex = 0;
            this.LbDienThoai.Text = "Điện thoại";
            this.LbDienThoai.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtMaKH
            // 
            this.TxtMaKH.Location = new System.Drawing.Point(85, 26);
            this.TxtMaKH.Name = "TxtMaKH";
            this.TxtMaKH.Size = new System.Drawing.Size(447, 26);
            this.TxtMaKH.TabIndex = 1;
            this.TxtMaKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtTenCty
            // 
            this.TxtTenCty.Location = new System.Drawing.Point(84, 70);
            this.TxtTenCty.Name = "TxtTenCty";
            this.TxtTenCty.Size = new System.Drawing.Size(447, 26);
            this.TxtTenCty.TabIndex = 1;
            this.TxtTenCty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtDiaChi
            // 
            this.TxtDiaChi.Location = new System.Drawing.Point(84, 118);
            this.TxtDiaChi.Name = "TxtDiaChi";
            this.TxtDiaChi.Size = new System.Drawing.Size(447, 26);
            this.TxtDiaChi.TabIndex = 1;
            this.TxtDiaChi.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(649, 67);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Size = new System.Drawing.Size(294, 26);
            this.TxtDienThoai.TabIndex = 1;
            // 
            // CboThanhPho
            // 
            this.CboThanhPho.FormattingEnabled = true;
            this.CboThanhPho.Location = new System.Drawing.Point(649, 26);
            this.CboThanhPho.Name = "CboThanhPho";
            this.CboThanhPho.Size = new System.Drawing.Size(293, 28);
            this.CboThanhPho.TabIndex = 2;
            // 
            // DgvKhachHang
            // 
            this.DgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenCty,
            this.DiaChi,
            this.MaThanhPho,
            this.DienThoai});
            this.DgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvKhachHang.Location = new System.Drawing.Point(3, 23);
            this.DgvKhachHang.Name = "DgvKhachHang";
            this.DgvKhachHang.RowHeadersWidth = 62;
            this.DgvKhachHang.RowTemplate.Height = 28;
            this.DgvKhachHang.Size = new System.Drawing.Size(938, 443);
            this.DgvKhachHang.TabIndex = 3;
            this.DgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKhachHang_CellClick);
            this.DgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKhachHang_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvKhachHang);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 469);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 473);
            this.panel1.TabIndex = 5;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(12, 642);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(121, 56);
            this.BtnThem.TabIndex = 6;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(139, 642);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(121, 56);
            this.BtnSua.TabIndex = 6;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Location = new System.Drawing.Point(266, 642);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(121, 56);
            this.BtnLuu.TabIndex = 6;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnHuy
            // 
            this.BtnHuy.Location = new System.Drawing.Point(393, 642);
            this.BtnHuy.Name = "BtnHuy";
            this.BtnHuy.Size = new System.Drawing.Size(121, 56);
            this.BtnHuy.TabIndex = 6;
            this.BtnHuy.Text = "Hủy";
            this.BtnHuy.UseVisualStyleBackColor = true;
            this.BtnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // BtnTaiLai
            // 
            this.BtnTaiLai.Location = new System.Drawing.Point(821, 642);
            this.BtnTaiLai.Name = "BtnTaiLai";
            this.BtnTaiLai.Size = new System.Drawing.Size(121, 56);
            this.BtnTaiLai.TabIndex = 6;
            this.BtnTaiLai.Text = "Tải lại";
            this.BtnTaiLai.UseVisualStyleBackColor = true;
            this.BtnTaiLai.Click += new System.EventHandler(this.BtnTaiLai_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(520, 642);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(121, 56);
            this.BtnXoa.TabIndex = 6;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenCty
            // 
            this.TenCty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCty.DataPropertyName = "TenCty";
            this.TenCty.HeaderText = "CÔNG TY";
            this.TenCty.MinimumWidth = 8;
            this.TenCty.Name = "TenCty";
            this.TenCty.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "ĐỊA CHỈ";
            this.DiaChi.MinimumWidth = 8;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // MaThanhPho
            // 
            this.MaThanhPho.DataPropertyName = "MaThanhPho";
            this.MaThanhPho.HeaderText = "THÀNH PHỐ";
            this.MaThanhPho.MinimumWidth = 8;
            this.MaThanhPho.Name = "MaThanhPho";
            this.MaThanhPho.Width = 150;
            // 
            // DienThoai
            // 
            this.DienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "ĐIỆN THOẠI";
            this.DienThoai.MinimumWidth = 8;
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.ReadOnly = true;
            this.DienThoai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DienThoai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 718);
            this.Controls.Add(this.BtnTaiLai);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnHuy);
            this.Controls.Add(this.BtnLuu);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.CboThanhPho);
            this.Controls.Add(this.TxtDiaChi);
            this.Controls.Add(this.TxtDienThoai);
            this.Controls.Add(this.TxtTenCty);
            this.Controls.Add(this.TxtMaKH);
            this.Controls.Add(this.LbDiaChi);
            this.Controls.Add(this.LbDienThoai);
            this.Controls.Add(this.LbThanhPho);
            this.Controls.Add(this.LbTenCty);
            this.Controls.Add(this.LbMaKH);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyKhachHang";
            this.Text = "Quản Lý Khách Hàng";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbMaKH;
        private System.Windows.Forms.Label LbTenCty;
        private System.Windows.Forms.Label LbDiaChi;
        private System.Windows.Forms.Label LbThanhPho;
        private System.Windows.Forms.Label LbDienThoai;
        private System.Windows.Forms.TextBox TxtMaKH;
        private System.Windows.Forms.TextBox TxtTenCty;
        private System.Windows.Forms.TextBox TxtDiaChi;
        private System.Windows.Forms.TextBox TxtDienThoai;
        private System.Windows.Forms.ComboBox CboThanhPho;
        private System.Windows.Forms.DataGridView DgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button BtnHuy;
        private System.Windows.Forms.Button BtnTaiLai;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaThanhPho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
    }
}