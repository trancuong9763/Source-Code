using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class LoaiHoaDAO
    {
        public static List<LoaiHoaDTO> Lay_Loai_Hoa()
        {
            string query = "SELECT * FROM LoaiHoa";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<LoaiHoaDTO> lst = new List<LoaiHoaDTO>();
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lst.Add(ConvertToDTO(dr));
            }
            return lst;
        }
        public static LoaiHoaDTO ConvertToDTO(DataRow dr)
        {
            LoaiHoaDTO lh = new LoaiHoaDTO();
            lh.MaLoaiHoa = dr["MaLoaiHoa"].ToString();
            lh.TenLoaiHoa = dr["TenLoaiHoa"].ToString();
            lh.TrangThai = Convert.ToBoolean(dr["TrangThai"]);
            return lh;
        }
    }
}
