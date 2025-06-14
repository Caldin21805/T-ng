using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class TimKiemHoaDon : UserControl
    {
        public TimKiemHoaDon() 
        {
            InitializeComponent();
        }
        private void    TimKiemHoaDon_Load(object sender, EventArgs e) 
        {
            LoadThanhPho();
            LoadNhanVien();
            LoadSanPham();
        } 
        //---------------------------------combobox
        private void    LoadSanPham()  //ComboBox Dgv - "Sản phẩm" trong CTHD 
        {
            //Lấy Data từ CSDL
            var query = "SELECT MaSP, TenSP FROM SanPham";
           
            //Đổ data vào ComboBox Dgv
            var cboMaSP = (DataGridViewComboBoxColumn) DgvChiTietHoaDon.Columns["MaSP"];
            cboMaSP.ValueMember     = "MaSP";
            cboMaSP.DisplayMember   = "TenSP";
            cboMaSP.DataSource      = DataProvider.TruyVanDuLieu(query);
        }
        private void    LoadNhanVien() //ComboBox Dgv - "Nhân Viên Lập HĐ" trong HD   
        {
            //Lấy dữ liệu từ CSDL 
            var query = "SELECT MaNV, CONCAT(Ho, ' ', Ten) as HoTen FROM NhanVien";
        
            //Đổ data vào ComboBox Dgv
            var cboMaNV = (DataGridViewComboBoxColumn) DgvHoaDon.Columns["MaNV"];
            cboMaNV.ValueMember     = "MaNV";
            cboMaNV.DisplayMember   = "HoTen";
            cboMaNV.DataSource      = DataProvider.TruyVanDuLieu(query);
        }
        private void    LoadThanhPho() //ComboBox - "Thành phố" trong form 
        {
            //lấy data từ CSDL
            var query = "SELECT * FROM ThanhPho ORDER BY TenThanhPho";

            //Đổ data vào ComboBox
            CboThanhPho.ValueMember     = "MaThanhPho";
            CboThanhPho.DisplayMember   = "TenThanhPho";
            CboThanhPho.DataSource      = DataProvider.TruyVanDuLieu(query);
        }
        private void    LoadKhachHang()//ComboBox - "Khách hàng" trong form
        {
            //Lấy data từ CSDL => biến đổi thành DataTable
            var query = $"SELECT MaKH, TenCty FROM KhachHang WHERE  MaThanhPho = '{CboThanhPho.SelectedValue}' ORDER BY TenCty";
            var dtKhachHang = DataProvider.TruyVanDuLieu(query);

            //Đổ data vào ComboBox 
            CboKhachHang.ValueMember    = "MaKH";
            CboKhachHang.DisplayMember  = "TenCty";
            CboKhachHang.DataSource     = dtKhachHang;
            
            //Đổ data vào ComboBox Dgv 
            var hdCboMaKh = DgvHoaDon.Columns["MaKH"] as DataGridViewComboBoxColumn;
            hdCboMaKh.ValueMember   = "MaKH";
            hdCboMaKh.DisplayMember = "TenCty";
            hdCboMaKh.DataSource    = dtKhachHang;

            //Đếm số dòng rows (đếm số lượng khách)
            TxtSoKH.Text = dtKhachHang.Rows.Count.ToString();
        }
        //---------------------------------Mấu chốt chính
        private void    LoadHoaDon()  //Dgv HoaDon 
        {
            //Lấy data từ CSDL => biến đổi thành DataTable
            var query = $"SELECT * FROM HoaDon WHERE MaKH = '{CboKhachHang.SelectedValue}'";
            var dtHoaDon = DataProvider.TruyVanDuLieu(query);

            //Đổ data vào Dgv 
            DgvHoaDon.DataSource = dtHoaDon;

            //Đếm số lượng hóa đơn 
            TxtSoHD.Text = dtHoaDon.Rows.Count.ToString();
        }
        //----------------------------------
        private void    comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //cái sự kiện SelectedIndexChanged này cách hoạt động của nó là khi nó bị thay đổi thì nó Auto kích hoạt
        {
            LoadKhachHang();
        }
        private void    CboKhachHang_SelectedIndexChanged(object sender, EventArgs e) 
        {
            LoadHoaDon();
        }
        private void    DgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex > -1) //Chặn không cho lỗi khi bấm vào tiêu đề hàng header = -1
            {
                var sql = $"SELECT cthd.*, sp.DonGia, SoLuong * DonGia  as ThanhTien FROM ChiTietHoaDon cthd JOIN SanPham sp ON cthd.MaSP = sp.MaSP WHERE MaHD = '{DgvHoaDon.Rows[e.RowIndex].Cells[0].Value}'";
                var dtCTHD = DataProvider.TruyVanDuLieu(sql);
                DgvChiTietHoaDon.DataSource = dtCTHD;
                TxtSoMH.Text = dtCTHD.Rows.Count.ToString();
            }
        }
    }
}

