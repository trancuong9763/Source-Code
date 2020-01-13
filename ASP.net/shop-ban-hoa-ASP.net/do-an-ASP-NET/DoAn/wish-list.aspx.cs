using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
using System.Data;

namespace DoAn
{
    public partial class wishlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["TenTK"];
                if (cookie != null)
                {
                    string tenTK = cookie.Value;
                    DataTable dtbkb = GioHangBUS.LayGH(tenTK);
                    grvGioHang.DataSource = dtbkb;
                    grvGioHang.DataBind();
                    lblTongTien.Text = GioHangBUS.TinhTongTienGH(tenTK).ToString();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            
        }

        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["TenTK"];
            string tentk = cookie.Value;
            TaiKhoanDTO tk = TaiKhoanBUS.LayThongTinTK(tentk);
            HoaDonDTO hd = new HoaDonDTO();
            hd.TenTaiKhoan = tentk;
            hd.NgayMua = DateTime.Now;
            hd.DiaChiGiaoHang = tk.DiaChi;
            hd.SdtGiaoHang = tk.SoDienThoai;
            hd.TongTien = GioHangBUS.TinhTongTienGH(tentk);
            hd.MaHD = HoaDonBUS.ThemHD(hd);
            GioHangBUS.XoaGioHang(tentk);

            DataTable dtbKQ = GioHangBUS.LayGH(tentk);
            foreach (DataRow dr in dtbKQ.Rows)
            {
                CTHoaDonDTO cthd = new CTHoaDonDTO();
                cthd.MaHD = hd.MaHD;
                cthd.MaHoa = dr["MaHoa"].ToString();
                cthd.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                cthd.DonGia = Convert.ToInt32(dr["GiaTien"]);
                CTHoaDonBUS.ThemCTHD(cthd);
            }

        }

        protected void grvGioHang_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string maHoa = e.CommandArgument.ToString();   
            if(e.CommandName == "Delete")
            {
                GioHangBUS.XoaitemGH(maHoa);
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}