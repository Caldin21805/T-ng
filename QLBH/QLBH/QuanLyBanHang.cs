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
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl(new TimKiemKhachHang());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
         void UserControl(UserControl control) // gọi thư viện usercontrol
        {
            //"clear" và "add" trong panel thường sẽ đi đôi với nhau...
            panelMain.Controls.Clear(); // Xóa nội dung cũ
            panelMain.Controls.Add(control); // Thêm usercontrol vào panel
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl(new DanhMucKhachHang());

        }

        private void quảnLýKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserControl(new QuanLyKhachHang());
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl(new TimKiemHoaDon());
        }


        private void MnuLapHoaDon_Click(object sender, EventArgs e)
        {
            UserControl(new LapHoaDon());
        }
    }
}
