using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GioHangDTO
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private string maHoa;

        public string MaHoa
        {
            get { return maHoa; }
            set { maHoa = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public GioHangDTO()
        {
            SoLuong = 1;
        }
    }
}
