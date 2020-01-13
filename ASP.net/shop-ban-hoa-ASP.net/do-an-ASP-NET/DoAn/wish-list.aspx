<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="wish-list.aspx.cs" Inherits="DoAn.wishlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Giỏ Hàng</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
    <!-- WISH LIST SHOP-->
        <div class="hero-wrap-contain hero-bread" style="background-image: url('images/cart.gif'); ">
      <div class="container">
       <%-- <div class="row no-gutters slider-text align-items-center justify-content-center">
          <div class="col-md-9 ftco-animate text-center">
          	<p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span>Cartlist</span></p>
            <h1 class="mb-0 bread">My Cart</h1>
          </div>
        </div>--%>
      </div>
    </div>


			<div class="container">

                         <asp:GridView ID="grvGioHang" runat="server" CssClass="table table-striped table-hover" GridLines="None" AutoGenerateColumns="False" OnRowCommand="grvGioHang_RowCommand">
                             <Columns>
                                 <asp:BoundField DataField="TenHoa" HeaderText="Tên Hoa" />
                                 <asp:BoundField DataField="GiaTien" HeaderText="Giá Tiền" />
                                 <asp:BoundField DataField="SoLuong" HeaderText="Số Lượng" />
                                 <asp:BoundField DataField="ThanhTien" HeaderText="Thành Tiền" />
                                 <asp:TemplateField ShowHeader="False">
                                     <ItemTemplate>
                                         <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" CausesValidation="False" CommandName="Delete" Text="Xoá sản phẩm" CommandArgument='<%# Eval("MaHoa") %>' />
                                     </ItemTemplate>
                                 </asp:TemplateField>
                             </Columns>
                             

                                </asp:GridView>
                                Tổng tiền: <asp:Label ID="lblTongTien" runat="server" Text="0"></asp:Label> VNĐ
                                <asp:Button ID="btnThanhToan" runat="server" CssClass="btn btn-success" Text="Thanh toán" OnClick="btnThanhToan_Click"/>
		</div>
</asp:Content>

