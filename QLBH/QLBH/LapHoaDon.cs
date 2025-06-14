using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class LapHoaDon : UserControl
    {

        public LapHoaDon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XuLyThemHoaDon();
        }

        private void XuLyThemHoaDon()
        {
            var ChiTietHoaDons = new Dictionary<int,int>();
            var tongTien = 0.0;
            foreach (DataGridViewRow row in DgvSanPhamMua.Rows)
            {
                var maSP = Convert.ToInt32(row.Cells[0].Value ?? 0);
                var soLuong = Convert.ToInt32(row.Cells[1].Value ?? 0);
                var donGia = Convert.ToDouble(row.Cells[2].Value ?? 0);
                if(maSP > 0)
                {
                    ChiTietHoaDons[maSP] = soLuong;
                    tongTien = tongTien + (soLuong * donGia);
                }
            }
            var cthds = ChiTietHoaDons.Select(x => $"{x.Key},{x.Value}");

            var sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("MaHD", SqlDbType.Int);
            sqlParameters[0].Direction = ParameterDirection.Output;
            sqlParameters[1] = new SqlParameter("MaKH", CboKhachHang.SelectedValue);
            sqlParameters[2] = new SqlParameter("MaKH", "  " );
            sqlParameters[2] = new SqlParameter("MaKH", string.Join(";", cthds));

            LblMaHD.Text = sqlParameters[0].Value.ToString();
            LblTongTien.Text = tongTien.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LapHoaDon_Load(object sender, EventArgs e)
        {
            CboKhachHang.DisplayMember = "TenCty";
            CboKhachHang.ValueMember = "MaKH";
            CboKhachHang.DataSource = DataProvider.TruyVanDuLieu("SELECT MaKH, TenCty FROM KhachHang");
            var DgvSP = DgvSanPhamMua.Columns["MaSP"] as DataGridViewComboBoxColumn;
            DgvSP.DisplayMember = "TenSP";
            DgvSP.ValueMember = "MaSP";
            DgvSP.DataSource = DataProvider.TruyVanDuLieu("SELECT * FROM  SanPham");
        
                  
        }

        private void DgvHDCboSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 )
            {
                AutoFillOrderItem(e.RowIndex);
            } 
        }

        private void DgvHDCboSanPham_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        void AutoFillOrderItem(int rowIndex)
        {
            var masp = DgvSanPhamMua.Rows[rowIndex].Cells[0].Value;
            if (masp != null)
            {
                var sanPham = DataProvider.TruyVanDuLieu($"SELECT * FROM SanPham WHERE MaSP='{masp}'");
                DgvSanPhamMua.Rows[rowIndex].Cells[2].Value = sanPham.Rows[0]["DonGia"].ToString();

                var soLuong = Convert.ToInt32(DgvSanPhamMua.Rows[rowIndex].Cells[1].Value ?? 0);
                var donGia = Convert.ToDouble(DgvSanPhamMua.Rows[rowIndex].Cells[2].Value ?? 0);
                DgvSanPhamMua.Rows[rowIndex].Cells[3].Value = soLuong * donGia;
            }

        }

        private void LblMaHD_Click(object sender, EventArgs e)
        {

        }
    }
}
