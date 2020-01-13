using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDonDTO
    {
        private string maHD;

        public string MaHD
        {
            get { return maHD; }
            set { maHD = value; }
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
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public CTHoaDonDTO()
        {
            SoLuong = 1;
            DonGia = 0;
        }
    }
}
