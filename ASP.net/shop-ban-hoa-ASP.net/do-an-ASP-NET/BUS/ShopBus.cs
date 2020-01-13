using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
   public class ShopBus
    {
        public static List<ShopDTO> LayDSHoa()
        {
            return ShopDAO.Lay_DS_Hoa();
        }

        public static List<ShopDTO> LayDSHoaNoiBat()
        {
            return ShopDAO.Lay_DS_Hoa_Noi_Bat();
        }

        public static List<ShopDTO> LayDSHoa(string maLoaiHoa)
        {
            return ShopDAO.Lay_DS_Hoa(maLoaiHoa);
        }

        public static ShopDTO LayThongTinHoa(string maHoa)
        {
            return ShopDAO.LayThongTinHoa(maHoa);
        }

        public static List<ShopDTO> DSHoaLienQuan(string maHoa)
        {
            return ShopDAO.DSHoaLienQuan(maHoa);
        }
    }
}
