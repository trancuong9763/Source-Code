<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="DoAn.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
      <div class="container-register">
      <div class="content">
        <div class="content-left">
          <div class="intro">
            <h2>Counting House</h2>
            <span>Là một website chuyên cung cấp dịch vụ điện hoa, quà tặng chuyên nghiệp đến khắp các tỉnh, thành phố trên cả nước. Với Thông điệp "Flower Delivery Expert", 
                      chúng tôi hướng đến một dịch vụ chuyên nghiệp trong việc truyền tải những thông điệp, cảm xúc của người tặng đến người nhận.</span>
          </div>
          <div class="image-overplay"></div>
          <img src="images/image-intro.jpg" alt=""/>
        </div>
        <div class="content-right">
          <h3>Đăng ký</h3>
          <div class="input-group">
              <asp:Label ID="Label1" runat="server" Text="Tên Tài Khoản"></asp:Label>
              <asp:TextBox ID="txtTK" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvTenTK" runat="server" ControlToValidate="txtTK"  Display="Dynamic" ErrorMessage="Chưa nhập tên tài khoản"></asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revTenTK" ControlToValidate="txtTK" runat="server" ErrorMessage="Tên tài khoản từ 6-20 kí tự, chỉ gồm chữ cái, chữ số, dấu gạch dưới" ValidationExpression="\w{6,20}" Display="Dynamic"></asp:RegularExpressionValidator>
              <asp:CustomValidator ID="cusTenTK" ControlToValidate="txtTK" runat="server" ErrorMessage="Tên tài khoản đã có người sử dụng" OnServerValidate="cusTenTK_ServerValidate" Display="Dynamic"></asp:CustomValidator>
          </div>
          <div class="input-group">
             <asp:Label ID="Label2" runat="server" Text="Mật Khẩu"></asp:Label>
             <asp:TextBox ID="txtMK" TextMode="Password" runat="server"></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvMK" runat="server" ControlToValidate="txtMK" ErrorMessage="Chưa nhập mật khẩu" Display="Dynamic"></asp:RequiredFieldValidator>
             <asp:RegularExpressionValidator ID="revMK" ControlToValidate="txtMK" runat="server" ErrorMessage="Mật Khẩu từ 6-20 kí tự, chỉ gồm chữ cái, chữ số, dấu gạch dưới" ValidationExpression="\w{6,20}" Display="Dynamic"></asp:RegularExpressionValidator>
              
          </div>
          <div class="input-group">
            <asp:Label ID="Label3" runat="server" Text="Nhập Lại Mật Khẩu"></asp:Label>
              <asp:TextBox ID="txtMK2" TextMode="Password" runat="server"></asp:TextBox>
              <asp:RequiredFieldValidator ID="rfvMK2" ControlToValidate="txtMK2" runat="server" ErrorMessage="Chưa nhập mật khẩu" Display="Dynamic"></asp:RequiredFieldValidator>
              <asp:CompareValidator ID="cpvMK2" runat="server" ControlToValidate="txtMK2" ControlToCompare="txtMK" ErrorMessage="Mật khẩu không trùng khớp" Display="Dynamic"></asp:CompareValidator>
          </div>
          <div class="input-group">
            <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="txtEmail" TextMode="Email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="txtEmail" runat="server" ErrorMessage="Chưa nhập Email" Display="Dynamic"></asp:RequiredFieldValidator>
          </div>
            <div class="input-group">
            <asp:Label ID="Label5" runat="server" Text="Họ Tên"></asp:Label>
            <asp:TextBox ID="txtHoTen" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvHoTen" ControlToValidate="txtHoTen" runat="server" ErrorMessage="Chưa nhập họ tên" Display="Dynamic"></asp:RequiredFieldValidator>
          </div>
          <div class="input-group">
           <asp:Label ID="Label6" runat="server" Text="Số Điện Thoại"></asp:Label>
           <asp:TextBox ID="txtSDT" TextMode="Phone"  runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvSDT" ControlToValidate="txtSDT" runat="server" ErrorMessage="Chưa nhập số điện thoại" Display="Dynamic"></asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator ID="revSDT" ControlToValidate="txtSDT" runat="server" ErrorMessage="Số điện thoại không hợp lệ" ValidationExpression="0\d{9}" Display="Dynamic"></asp:RegularExpressionValidator>
          </div>
           <div class="input-group">
           <asp:Label ID="Label7" runat="server" Text="Địa Chỉ"></asp:Label>
           <asp:TextBox ID="txtDC" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator ID="rfvDC" ControlToValidate="txtDC" runat="server" ErrorMessage="Chưa nhập địa chỉ" Display="Dynamic"></asp:RequiredFieldValidator>
           </div>
          <asp:Button ID="Button1" runat="server" Text="Đăng ký" OnClick="Button1_Click" />
        </div>
      </div>
    </div>
</asp:Content>
