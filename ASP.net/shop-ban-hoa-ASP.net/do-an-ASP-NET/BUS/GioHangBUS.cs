using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class GioHangBUS
    {
          public static DataTable LayGH(string tenTK)
        {
            return GioHangDAO.Lay_GH(tenTK);
        }

        public static int TinhTongTienGH(string tenTK)
        {
            DataTable dtbKetQua = GioHangDAO.Lay_GH(tenTK);
            int tongTien = 0;
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                tongTien += Convert.ToInt32(dr["ThanhTien"]);
            }
            return tongTien;
        }

        public static bool ThemGH(GioHangDTO gh)
        {
            if (GioHangDAO.KTGHTonTai(gh))
            {
                return GioHangDAO.SuaGH(gh);
            }
            else
            {
                return GioHangDAO.ThemGH(gh);
            }
        }

        public static bool XoaitemGH(string maHoa )
        {
            return GioHangDAO.XoaitemGH(maHoa);
        }

        public static bool XoaGioHang(string tenTaiKhoan)
        {
            return GioHangDAO.XoaGioHang(tenTaiKhoan);
        }

        public static int TongSanPham(string tenTaiKhoan)
        {
            return GioHangDAO.TongSanPham(tenTaiKhoan);
        }
    }

}

