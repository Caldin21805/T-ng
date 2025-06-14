using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    internal class TaiKhoan
    {
        private string matKhau;
        private string tenTaiKhoan;
        public TaiKhoan()
        {
        }

        public TaiKhoan(string matKhau, string tenTaiKhoan)
        {
            this.matKhau = matKhau;
            this.tenTaiKhoan = tenTaiKhoan;
        }

        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
    }
}
