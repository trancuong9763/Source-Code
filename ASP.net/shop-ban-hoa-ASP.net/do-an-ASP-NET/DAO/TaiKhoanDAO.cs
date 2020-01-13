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
    public class TaiKhoanDAO
    {
        public static bool KT_TK(string TenTK)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan=@TenTK ";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTK", TenTK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static TaiKhoanDTO LayThongTinTK(string tentk)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan= @TenTK";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@TenTK", tentk);
            return ConvertTODTO(DataProvider.ExecuteSelectQuery(query, param).Rows[0]);
        }

        public static bool KT_DN(TaiKhoanDTO tk)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan=@TenTK AND MatKhau=@MK ";
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@TenTK", tk.TenTaiKhoan);
            param[1] = new SqlParameter("@MK", tk.MatKhau);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }
        public static bool KT_MK(string MK)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE MatKhau=@MK";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MK", MK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0])== 1;
        }
        public static bool Them_TK(TaiKhoanDTO tk)
        {
            string query = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email, SDT, DiaChi, HoTen, LaAdmin, TrangThai) VALUES (@TenTaiKhoan, @MatKhau, @Email, @SDT, @DiaChi, @HoTen, @LaAdmin, @TrangThai)";
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@TenTaiKhoan", tk.TenTaiKhoan);
            param[1] = new SqlParameter("@MatKhau", tk.MatKhau);
            param[2] = new SqlParameter("@Email", tk.Email);
            param[3] = new SqlParameter("@SDT", tk.SoDienThoai);
            param[4] = new SqlParameter("@DiaChi", tk.DiaChi);
            param[5] = new SqlParameter("@HoTen", tk.HoTen);
            param[6] = new SqlParameter("@LaAdmin", tk.LaAdmin);
            param[7] = new SqlParameter("@TrangThai", tk.TrangThai);
            return DataProvider.ExecuteInsertQuery(query, param) == 1;
        }
        public static TaiKhoanDTO ConvertTODTO(DataRow dr)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.TenTaiKhoan = dr["TenTaiKhoan"].ToString();
            tk.MatKhau = dr["MatKhau"].ToString();
            tk.Email = dr["Email"].ToString();
            tk.SoDienThoai = dr["SDT"].ToString();
            tk.DiaChi = dr["DiaChi"].ToString();
            tk.HoTen = dr["HoTen"].ToString();
            tk.LaAdmin = Convert.ToBoolean(dr["LaAdmin"]);
            tk.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return tk;
        }
    }
}
