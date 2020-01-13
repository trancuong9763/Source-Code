using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ShopDTO
    {
        private string maHoa;
        private string tenHoa;
        private int giaTien;
        private int soLuongTonKho;
        private string maLoaiHoa;
        private string anhMinhHoa;
        private bool trangThai;

        public string MaHoa
        {
            get
            {
                return maHoa;
            }

            set
            {
                maHoa = value;
            }
        }

        public string TenHoa
        {
            get
            {
                return tenHoa;
            }

            set
            {
                tenHoa = value;
            }
        }

        public int GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
            }
        }

        public int SoLuongTonKho
        {
            get
            {
                return soLuongTonKho;
            }

            set
            {
                soLuongTonKho = value;
            }
        }

        public string AnhMinhHoa
        {
            get
            {
                return anhMinhHoa;
            }

            set
            {
                anhMinhHoa = value;
            }
        }

        public bool TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }

        public string MaLoaiHoa
        {
            get
            {
                return maLoaiHoa;
            }

            set
            {
                maLoaiHoa = value;
            }
        }

        public ShopDTO()
        {
            TrangThai = true;
            SoLuongTonKho = 0;
            GiaTien = 0;
            MaLoaiHoa = "1";
        }
    }
}
