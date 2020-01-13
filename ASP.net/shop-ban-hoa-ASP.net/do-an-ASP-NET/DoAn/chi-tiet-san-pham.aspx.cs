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
    public partial class chi_tiet_san_pham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string maHoa = Request.QueryString["mahoa"];

                //Response.Write(maHoa);

                if (string.IsNullOrEmpty(maHoa))
                {
                    Response.Redirect("index.aspx");
                    return;
                }

                ShopDTO hoa = ShopBus.LayThongTinHoa(maHoa);
                List<ShopDTO> DSHoaLienQuan = ShopBus.DSHoaLienQuan(maHoa);
                rptSanPhamLienQuan.DataSource = DSHoaLienQuan;
                rptSanPhamLienQuan.DataBind();

                if (hoa == null)
                {
                    Response.Redirect("index.aspx");
                    return;
                }

                lblTenHoa.Text = hoa.TenHoa;
                lblGiaTien.Text = hoa.GiaTien + "";
                imgAnhMinhHoa.ImageUrl = "images/products/" + hoa.AnhMinhHoa;

            }
        }

        protected void btnThemGH_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["TenTK"];
            if (cookie != null)
            {
                GioHangDTO gh = new GioHangDTO();
                gh.TenTaiKhoan = cookie.Value;
                gh.MaHoa = Request.QueryString["mahoa"];
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

        protected void rptSanPhamLienQuan_ItemCommand(object source, RepeaterCommandEventArgs e)
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