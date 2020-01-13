using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static bool ThemTK(TaiKhoanDTO tk)
        {
            if(TaiKhoanDAO.KT_TK(tk.TenTaiKhoan))
            {
                return false;
            }

            else
            {
                return TaiKhoanDAO.Them_TK(tk);
            }
        }

        public static bool KT_TK(string tenTK)
        {
            if(TaiKhoanDAO.KT_TK(tenTK))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool KT_TKDN(TaiKhoanDTO tk)
        {
            if (TaiKhoanDAO.KT_DN(tk))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static TaiKhoanDTO LayThongTinTK(string tenTK)
        {
            if (!TaiKhoanDAO.KT_TK(tenTK))
            {
                return null;
            }
            else
            {
                return TaiKhoanDAO.LayThongTinTK(tenTK);
            }
        }
    }
}
