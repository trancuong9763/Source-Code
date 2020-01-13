using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace DoAn
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadSanPham();
        }

        private void LoadSanPham()
        {
            rptSanPham.DataSource = ShopBus.LayDSHoaNoiBat();
            rptSanPham.DataBind();
        }

        protected void rptSanPham_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "ThemGH")
            {
                HttpCookie cookie = Request.Cookies["TenTK"];
                if (cookie != null)
                {
                    GioHangDTO gh = new GioHangDTO();
                    gh.TenTaiKhoan = cookie.Value;
                    gh.MaHoa = e.CommandArgument.ToString();
                    gh.SoLuong = 1;
                    if (GioHangBUS.ThemGH(gh))
                    {
                        Response.Write("<script>alert('Thêm Thành Công')</script>");
                        Response.Redirect(Request.RawUrl);
                       
                    }
                    else
                    {
                        Response.Write("<script>alert('Thêm Thất Bại')</script>");
                    }

                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}