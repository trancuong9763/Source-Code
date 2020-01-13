using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHoaDTO
    {
        private string maLoaiHoa;

        public string MaLoaiHoa
        {
            get { return maLoaiHoa; }
            set { maLoaiHoa = value; }
        }
        private string tenLoaiHoa;

        public string TenLoaiHoa
        {
            get { return tenLoaiHoa; }
            set { tenLoaiHoa = value; }
        }
        private bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public LoaiHoaDTO()
        {
            TrangThai = true;
        }

    }
}
