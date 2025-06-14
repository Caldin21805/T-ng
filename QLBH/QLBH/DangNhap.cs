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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void llblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.ShowDialog();
        }

        private void llblDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }
        Modify modify= new Modify();

        private void btnDN_Click(object sender, EventArgs e)
        {
            string tentk=txtTenDN.Text;
            string matkhau = txtMKDN.Text;
            if(tentk.Trim()==" ") { MessageBox.Show("Vui lòng nhập tên tài khoản!");return; }
            if (matkhau.Trim() == " ") { MessageBox.Show("Vui lòng nhập tên mật khẩu!"); return; }
            else
            {
                string query = "Select* from TaiKhoan where TenTaiKhoan ='" + tentk + "' and MatKhau='" + matkhau + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
					QuanLyBanHang quanLyBanHang =new QuanLyBanHang();// đưa trang chủ vào đây
                    quanLyBanHang.ShowDialog();
					this.Close();
                }
                else
                {
                    MessageBox.Show("tên tài khoản hoặc mật khẩu không chính xác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
