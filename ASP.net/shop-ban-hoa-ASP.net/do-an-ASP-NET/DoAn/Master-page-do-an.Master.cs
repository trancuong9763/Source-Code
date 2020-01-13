using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;

namespace DoAn
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                HttpCookie cookie = Request.Cookies["TenTK"];
                if (cookie != null)
                {
                    lbl.Text = "Xin Chào " + cookie.Value;
                    btn_DX.Visible = true;
                    linkDangNhap.Visible = false;
                    linkDangKy.Visible = false;
                    lblTongSanPham.Text = GioHangBUS.TongSanPham(cookie.Value) + "";
                }

                else
                {
                    lbl.Text = "Xin Chào Khách Hàng";
                    btn_DX.Visible = false;
                    linkDangNhap.Visible = true;
                    linkDangKy.Visible = true;
                }
        }

        protected void btn_DX_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["TenTK"];
            Response.Cookies.Add(cookie);
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Redirect(Request.RawUrl);
        }
    }
}