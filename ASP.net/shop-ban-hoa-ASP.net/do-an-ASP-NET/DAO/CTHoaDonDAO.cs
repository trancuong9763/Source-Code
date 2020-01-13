using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class CTHoaDonDAO
    {
        public static bool ThemCTHD(CTHoaDonDTO cthd)
        {
            string query = "INSERT INTO CTHoaDon(MaHD, MaHoa, SoLuong, DonGia) VALUES(@MaHD, @MaHoa, @SoLuong, @DonGia)";
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@MaHD", cthd.MaHD);
            param[1] = new SqlParameter("@MaHoa",cthd.MaHoa);
            param[2] = new SqlParameter("@SoLuong",cthd.SoLuong);
            param[3] = new SqlParameter("@DonGia",cthd.DonGia);
            return DataProvider.ExecuteInsertQuery(query,param)==1;
        }
    }
}
