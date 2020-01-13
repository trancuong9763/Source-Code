using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class GioHangDAO
    {
        public static DataTable Lay_GH(string tenTK)
        {
            string query = "SELECT gh.MaHoa, TenHoa, GiaTien, gh.SoLuong, GiaTien * gh.SoLuong AS ThanhTien FROM GioHang gh INNER JOIN Hoa h ON gh.MaHoa = h.MaHoa WHERE TenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTaiKhoan", tenTK);
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static bool KTGHTonTai(GioHangDTO gh)
        {
            string query = "SELECT COUNT(*) FROM GioHang WHERE TenTaiKhoan = @TenTaiKhoan AND MaHoa = @MaHoa";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TenTaiKhoan", gh.TenTaiKhoan);
            param[1] = new SqlParameter("@MaHoa", gh.MaHoa);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static bool ThemGH(GioHangDTO gh)
        {
            string query = "INSERT INTO GioHang (TenTaiKhoan, MaHoa, SoLuong) VALUES (@TenTaiKhoan, @MaHoa, @SoLuong)";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TenTaiKhoan", gh.TenTaiKhoan);
            param[1] = new SqlParameter("@MaHoa", gh.MaHoa);
            param[2] = new SqlParameter("@SoLuong", gh.SoLuong);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }

        public static bool SuaGH(GioHangDTO gh)
        {
            string query = "UPDATE GioHang SET SoLuong = SoLuong + @SoLuong WHERE TenTaiKhoan = @TenTaiKhoan AND MaHoa = @MaHoa";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TenTaiKhoan", gh.TenTaiKhoan);
            param[1] = new SqlParameter("@MaHoa", gh.MaHoa);
            param[2] = new SqlParameter("@SoLuong", gh.SoLuong);
            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }

        public static bool XoaitemGH(string maHoa)
        {
            string query = "DELETE GioHang where MaHoa=@mahoa";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@mahoa", maHoa);
            return DataProvider.ExecuteDeleteQuery(query, param) == 1;
        }
        public static bool XoaGioHang(string tenTaiKhoan)
        {
            string query = "DELETE FROM GioHang WHERE TenTaiKhoan = @tenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tenTaiKhoan", tenTaiKhoan);
            return DataProvider.ExecuteDeleteQuery(query, param) == 1;
        }

        public static GioHangDTO ConvertToDTO(DataRow dr)
        {
            GioHangDTO gh = new GioHangDTO();
            gh.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            gh.MaHoa = dr["MaHoa"].ToString();
            gh.SoLuong = Convert.ToInt32(dr["SoLuong"]);
            return gh;
        }

        public static int TongSanPham(string tenTaiKhoan)
        {
            string query = "SELECT COUNT(*) FROM GioHang WHERE TenTaiKhoan = @tenTaiKhoan";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@tenTaiKhoan", tenTaiKhoan);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]);
        }
    }
}
