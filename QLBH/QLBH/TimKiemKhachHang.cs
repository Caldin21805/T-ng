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
    public partial class TimKiemKhachHang : UserControl
    {
        public TimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //Điểm mấu chốt: Vì đây là một sự kiện của cboThanhPho,
                                                                                  //tức là khi DataSource của cbo này được nhận dữ liệu tức là nó
                                                                                  //không rỗng thì hệ thống sẽ tự động kích hoạt sự kiện của cbo này
                                                                                  //là SelectIndexChanged. sự kiện này sẽ mặc định chọn dòng đầu tiên
                                                                                  //tức là index = 0, sau đó gọi hàm layKhachHangTheoThanhPho();
                                                                                  //và truyền ngầm index = 0 vào layKhachHangTheoThanhPho().
                                                                                  //Đó là tổng quan cách hoạt động khi nói tại sao Load không 
                                                                                  //thấy truy vấn khách hàng mà vẫn có data đầy đủ khách hàng
                                                                                  //khi bấm Run

        {
            layKhachHangTheoThanhPho();
        }

        private void TimKiemKhachHang_Load(object sender, EventArgs e)
        {
            cboThanhPho.DisplayMember = "TenThanhPho";
            cboThanhPho.ValueMember = "MaThanhPho";
            cboThanhPho.DataSource = DataProvider.TruyVanDuLieu("Select * from THanhPho ");

            //ép cho chọn thành phố đầu tiên với index = 0;
            cboThanhPho.SelectedIndex = 0;
            layKhachHangTheoThanhPho();
        }

        private void layKhachHangTheoThanhPho()
        {
            var query = $"select * from khachhang where MaThanhPho='{cboThanhPho.SelectedValue.ToString()}'";
            var dtKhachHang = DataProvider.TruyVanDuLieu(query); //dataprovider ở giúp làm gọn hơn, nó sẽ gọi adapter nè rồi biến adapter thành kiểu DataTable 
            dgvKhachHang.DataSource = dtKhachHang; // cuối cùng là gắn cái DataTable hồi nãy vào Datasource của datagridview để hiển thị ra màn hình
            txtSoLuongKhachHang.Text = dtKhachHang.Rows.Count.ToString(); //Gọi box của thằng textbox ra bằng ".Text" để hiển thị số lượng dòng. Thêm vào đó trong DataTable dùng Rows để đếm số dòng và cuối cùng đổi nó thành String để nó tương ứng với kiểu TextBox.

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
