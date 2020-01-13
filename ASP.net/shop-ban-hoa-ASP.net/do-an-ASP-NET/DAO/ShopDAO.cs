using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ShopDAO
    {
        public static List<ShopDTO> Lay_DS_Hoa()
        {
            string query = "SELECT * FROM Hoa";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<ShopDTO> lstHoa = new List<ShopDTO>();
            foreach(DataRow dr in dtbKetQua.Rows)
            {
                lstHoa.Add(ConvertToDTO(dr));
            }
            return lstHoa;
            
        }

        public static List<ShopDTO> DSHoaLienQuan(string maHoa)
        {
            string maLoaiHoa = layMaLoaiHoa(maHoa);
            string query = "SELECT TOP 4 * FROM Hoa WHERE MaLoaiHoa = @maLoaiHoa AND NOT MaHoa = @MaHoa";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@maLoaiHoa", maLoaiHoa);
            param[1] = new SqlParameter("@maHoa", maHoa);
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<ShopDTO> lstHoa = new List<ShopDTO>();
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lstHoa.Add(ConvertToDTO(dr));
            }
            return lstHoa;

        }

        public static string layMaLoaiHoa(string maHoa)
        {
            string query = "SELECT MaLoaiHoa FROM Hoa WHERE MaHoa = @maHoa";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maHoa", maHoa);

            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString();

        }

        public static List<ShopDTO> Lay_DS_Hoa(string maLoaiHoa)
        {
            string query = "SELECT * FROM Hoa Where MaLoaiHoa=@MaLoaiHoa";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MaLoaiHoa", maLoaiHoa);
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<ShopDTO> lstHoa = new List<ShopDTO>();
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lstHoa.Add(ConvertToDTO(dr));
            }
            return lstHoa;

        }

        public static List<ShopDTO> Lay_DS_Hoa_Noi_Bat()
        {
            String query = "SELECT TOP 4 * FROM Hoa ";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<ShopDTO> lstHoa = new List<ShopDTO>();
            foreach (DataRow dr in dtbKetQua.Rows )
            {
                lstHoa.Add(ConvertToDTO(dr));
            }
            return lstHoa;
        }

        public static ShopDTO ConvertToDTO(DataRow dr)
        {
            ShopDTO sp = new ShopDTO();
            sp.MaHoa = dr["MaHoa"].ToString();
            sp.TenHoa = dr["TenHoa"].ToString();
            sp.GiaTien = Convert.ToInt32(dr["GiaTien"]);
            sp.SoLuongTonKho = Convert.ToInt32(dr["SoLuongTonKho"]);
            sp.MaLoaiHoa = dr["MaLoaiHoa"].ToString();
            sp.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            sp.AnhMinhHoa = dr["AnhMinhHoa"].ToString();
            return sp;
            
        }

        public static ShopDTO LayThongTinHoa(string maHoa)
        {
            string query = "SELECT * FROM Hoa WHERE MaHoa = @maHoa";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@maHoa", maHoa);

            return ConvertToDTO(DataProvider.ExecuteSelectQuery(query,param).Rows[0]);
        }
    }
}
