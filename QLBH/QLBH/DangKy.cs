using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLBH
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool CheckAcconnut(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em,@"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void btnDK_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTk.Text;
            string matkhau = txtMK.Text;
            string xnmatkhau = txtXacNhanMK.Text;
            string em = txtEmail.Text;
            if (!CheckAcconnut(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu  dài 6-24 ký tự , với các ký tự chữ và số , chữ hoa và chữ thường! ");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu chính xác ! ");
                return;
            }
            if (!CheckEmail(em))

            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email! ");
                return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan  where Email='" + em + "' ").Count != 0)

            {
                MessageBox.Show("Email này đã đăng ký vui lòng đăng ký Email mới  ");
                return;
            }
            try
            {
                string  query = "Insert into TaiKhoan values ('" + tentk+ "','"+matkhau +"','"+em + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công, Bạn có muốn đăng nhập luôn không? ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                { 
                    this.Close();
                }
            }
            catch
             {
                MessageBox.Show("Tên tài khoản này đã được dùng , vui lòng đăng ký tài khoản khác!");
             }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
