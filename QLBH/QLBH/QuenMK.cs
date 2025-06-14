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
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();

        private void btnDN_Click(object sender, EventArgs e)
        {
            string em = txtEmDK.Text;
            if(em.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!");
            }
            else
            {
                string query = "Select* from  TaiKhoan Where Email ='" + em +"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu:  " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa đăng ký!";
                }
            }
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {

        }
        private void QuenMK_Load_1(object sender, EventArgs e)
        {

        }


        private void QuenMK_Load_2(object sender, EventArgs e)
        {

        }
    }
}
