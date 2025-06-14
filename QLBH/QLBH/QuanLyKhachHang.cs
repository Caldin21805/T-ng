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
    public partial class QuanLyKhachHang : UserControl
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            SettingEnable(true); 

            //Trước khi thêm thông tin mới, xóa giúp giá trị đang nhập nếu ô thông tin có chứa => đỡ mất công xóa tay
            TxtMaKH.     Clear();
            TxtTenCty.   Clear();
            TxtDiaChi.   Clear();
            TxtDienThoai.Clear();
        } //Nút thêm

        private void BtnSua_Click(object sender, EventArgs e)
        {
            SettingEnable(true);
            isEdit = true;  //Khi sự kiện click này được kích hoạt thì edit = true 
            TxtMaKH.Enabled = false; //không cho phép sửa khóa Primarykey khi đang sửa
        } //Nút Sửa (click vào là true)

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if(isEdit) //isEdit = false
            {
                //Trường hợp Lưu này dành cho Nút Thêm vì khi bấm vào nút thêm thì Nút Lưu sẽ Enable True
                var DML_Update = $"Update KhachHang Set TenCty = N'{TxtTenCty.Text}', " +
                    $"DiaChi= N'{TxtDiaChi.Text}', " +
                    $"DienThoai = N'{TxtDienThoai.Text}', MaThanhPho = N'{CboThanhPho.SelectedValue}' " +
                    $"Where MaKH = '{TxtMaKH.Text}'";

                //Thực hiện Định nghĩa dữ liệu trong CSDL bằng DataProvider
                DataProvider.DinhNghiaDuLieu(DML_Update);
                isEdit = false;
            }
            else  //isEdit = false
            {
                //Trường hợp Lưu này dành cho Nút Sửa
                var DML_Insert = $"Insert into KhachHang(MaKH, TenCty, DiaChi,DienThoai,MaThanhPho) VALUES('{TxtMaKH.Text}', N'{TxtTenCty.Text}',N'{TxtDiaChi.Text}', N'{TxtDienThoai.Text}', N'{CboThanhPho.SelectedValue}')";
                DataProvider.DinhNghiaDuLieu(DML_Insert);
            }
            LoadKhachHang();
            SettingEnable(false);
        } //Nút Lưu

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            isEdit = true;
            this.SettingEnable(false); // Quay lại mặc định như khi vừa chạy Run
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {

            var traLoi = MessageBox.Show("Xác nhận xóa?", "Thông báo ", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
                //Xóa ra khỏi CSDL
                var DML_Delete = $"DELETE FROM KhachHang WHERE MaKH = '{TxtMaKH.Text}'"; //dựa vào textbox chứa mã KH để xóa
                DataProvider.DinhNghiaDuLieu(DML_Delete);
                //Refresh
                LoadKhachHang();
            }

        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            LoadKhachHang();// Refresh
            
        }

        private void DgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đưa dữ liệu tại hàng có vị trí là e.RowIndex và cột là MaKH lên ô nhập txtMaKH
            TxtMaKH.Text      = DgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            TxtTenCty.Text    = DgvKhachHang.Rows[e.RowIndex].Cells["MaKH"].Value.ToString();
            TxtDiaChi.Text    = DgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            TxtDienThoai.Text = DgvKhachHang.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            // Chọn mục có thành phố như cột thành phố tại hàng đang chọn của ô lưới
            CboThanhPho.SelectedValue = DgvKhachHang.Rows[e.RowIndex].Cells["MaThanhPho"].Value;

            // Khi bấm vào một hàng bất kỳ cụ thể là khi kích hoạt sự kiện này nó sẽ tự động Không cho phép sửa gì trên
            // ô thông tin
            SettingEnable(false); 
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadThanhPho();
            LoadKhachHang();
            SettingEnable(false);
        }

        private void LoadKhachHang()
        {
            string query = "Select * from KhachHang";
            DgvKhachHang.DataSource= DataProvider.TruyVanDuLieu(query); 
        }

        private void LoadThanhPho()
        {
            string query = "select * from ThanhPho";
            var dtThanhPho = DataProvider.TruyVanDuLieu(query);

            //Datatable ở đây như là một kiểu data container và nó sẽ được đổ vào các loại control khác không chỉ dgv. 
            //Đổ dữ liệu vào Cbo...
            CboThanhPho.DataSource      = dtThanhPho;
            CboThanhPho.DisplayMember   = "TenThanhPho";
            CboThanhPho.ValueMember     = "MaThanhPho";

            //Đổ dữ liệu vào Cbo của Datagridview...
            var DgvCboThanhPho = (DataGridViewComboBoxColumn) DgvKhachHang.Columns["MaThanhPho"]; //Lý do chính tại sao phải ép lại thành thuộc tính ComboBox dù trước đó đã tạo cột đóvới thuộc tính ComboBox rồi. Bởi vì ta đang gọi thuộc tính là ".Columns" để xác định cột cần tìm. Sau khi tìm được rồithì phải ép lại về Combobox để làm việc với các thuộc tínhDataSource, Display, Value trong Datagridview
            DgvCboThanhPho.DataSource    = dtThanhPho;
            DgvCboThanhPho.DisplayMember = "TenThanhPho";
            DgvCboThanhPho.ValueMember   = "MaThanhPho";
        }

        // Biến lưu giữ trạng thái (đang cập nhật hay thêm mới) được sử dụng trong sự kiện nút Lưu
        bool isEdit = false;
        /// Thay đổi trạng thái các nút nhấn
        void SettingEnable(bool status) // status: True  (enabled = on)
                                        // status: False (enabled = off)
        {
            //Set trạng thái các ô nhập liệu
            TxtMaKH.     Enabled = status;    //Ô nhập Mã KH
            TxtTenCty.   Enabled = status;    //Ô nhập Công ty
            TxtDiaChi.   Enabled = status;    //Ô nhập Địa chỉ
            CboThanhPho. Enabled = status;    //Combobox Thành Phố
            TxtDienThoai.Enabled = status;    //Ô nhập Điện thoại

            //Set trạng thái bộ nút (Thêm/Sửa trái ngược với textbox ở trên)
            BtnThem.     Enabled = !status;   //Nút Thêm
            BtnSua.      Enabled = !status;   //Nút Sửa

            //không cho trạng thái xóa khi đang edit (status = True)
            BtnXoa.      Enabled = !status;   //Nút Xóa
            BtnHuy.      Enabled = status;    //Nút Hủy
            BtnLuu.      Enabled = status;    //Nút Lưu

        }


        
    }
}



