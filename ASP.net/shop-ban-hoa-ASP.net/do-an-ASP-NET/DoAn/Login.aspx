<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DoAn.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
     <div class="container-login">
      <div class="form-login">
        <h3>Đăng nhập</h3>
         <div class="input-group">
              <asp:Label ID="Label1" runat="server" Text="Tên Đăng Nhập"></asp:Label>
              <asp:TextBox ID="txtTenDN" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvTenDN" runat="server" ControlToValidate="txtTenDN"  Display="Dynamic" ErrorMessage="Chưa nhập tên đăng nhập"></asp:RequiredFieldValidator>
              <asp:CustomValidator ID="cusTenDN" ControlToValidate="txtTenDN" runat="server" ErrorMessage="Tên đăng nhập hoặc mật khẩu đã sai" OnServerValidate="cusTenDN_ServerValidate"  Display="Dynamic"></asp:CustomValidator>
          </div>
          <div class="input-group">
             <asp:Label ID="Label2" runat="server" Text="Mật Khẩu"></asp:Label>
             <asp:TextBox ID="txtDN_MK" TextMode="Password" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvDN_MK" runat="server" ControlToValidate="txtDN_MK" ErrorMessage="Chưa nhập mật khẩu" Display="Dynamic"></asp:RequiredFieldValidator>
          </div>
          <asp:Button id="btnDangNhap" runat="server" CssClass="btn" Text="Đăng Nhập" OnClick="Button1_Click" />
        <div class="remember-password">
          <input type="checkbox">
          <label for="Lưu mật khẩu">Nhớ mật khẩu</label>
        </div>
        <div class="forgot-password">
          <a href="#">Quên mật khẩu ?</a>
        </div>
        </div>
      </div>
</asp:Content>
