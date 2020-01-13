using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
   public class LoaiHoaBUS
    {
       public static List<LoaiHoaDTO> LayDSLoaiHoa()
       {
           return LoaiHoaDAO.Lay_Loai_Hoa();
       }
    }
}
