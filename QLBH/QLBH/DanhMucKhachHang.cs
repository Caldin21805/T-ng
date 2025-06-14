using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Import thư viện ADO.NET


namespace QLBH
{
    public partial class DanhMucKhachHang : UserControl
    {
        string ChuoiKetNoi = @"Server=DESKTOP-CR690E6;Database=QLBanHang;Trusted_Connection=True;";
        public DanhMucKhachHang()
        {
            InitializeComponent();
        }
        //LOAD
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadThanhPho(); // Tải danh sách thành phố trước
            LoadKhachHang(); // Sau đó mới tải danh sách khách hàng
        }



        void LoadThanhPho()
        {
           var connection = new SqlConnection(ChuoiKetNoi);
            try
            {
                connection.Open();
                // Thực hiện các thao tác truy vấn dữ liệu ở đây
                var dataAdapter = new SqlDataAdapter("SELECT * FROM ThanhPho Order by TenThanhPho", connection); //query
                var dtThanhPho = new DataTable(); //dữ liệu dạng bảng
                dataAdapter.Fill(dtThanhPho);//đổ dữ liệu vào dạng bảng 

                //Tìm ComboBox trong datagridvie
                var cboThanhPho = (DataGridViewComboBoxColumn) dgvKhachHang.Columns["ABC"];

                    cboThanhPho.DataSource = dtThanhPho;
                    cboThanhPho.DisplayMember = "TenThanhPho";
                    cboThanhPho.ValueMember = "MaThanhPho";
               
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                connection.Close();  // Đóng kết nối khi xong
            }
        }


        void LoadKhachHang()
        {
            var connection = new SqlConnection(ChuoiKetNoi);

            try
            {
                connection.Open();
                // Thực hiện các thao tác truy vấn dữ liệu ở đây
                string query = "SELECT * FROM KhachHang ORDER BY TenCty";
                var adapter = new SqlDataAdapter(query, connection); //Gọi class từ ADO.NET để query 
                var dtKhachHang = new DataTable(); //Gọi class này từ ADO.NET nhằm lưu trữ và đại dữ liệu dưới dạng bảng từ data của CSDL truyền về (là row or column). Hiện tại nó đang rỗng!
                adapter.Fill(dtKhachHang);  // Đổ dữ liệu vừa query ở trên trong adapter vào dtKhachHang
                dgvKhachHang.DataSource = dtKhachHang; //ở đây khi gán obj datatable vào datasource trong dgv thì dgv chính là "cầu nối" giữa dữ liệu của cấu trúc datatable và giao diện hiển thị form 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
            finally
            {
                connection.Close();  // Đóng kết nối khi xong
            }
        }


        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}