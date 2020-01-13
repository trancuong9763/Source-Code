<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="shop.aspx.cs" Inherits="DoAn.shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
     <!-- SHOP PAGE -->
    <div class="hero-wrap hero-bread" style="background-image: url('images/3.jpg');">
      <div class="container">
        <div class="row no-gutters slider-text align-items-center justify-content-center">
          <div class="col-md-9 ftco-animate text-center">
          	<p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span>Products</span></p>
            <h1 class="mb-0 bread">Products</h1>
          </div>
        </div>
      </div>
    </div>

    <section class="ftco-section">
    	<div class="container">
    		<div class="row justify-content-center">
    			<div class="col-md-10 mb-5 text-center">
    				<ul class="product-category">
    					<li><a href="shop.aspx" class="active">All</a></li>
                       <li> <asp:DropDownList ID="ddtLoaiHoa" Width="150%"  CssClass="form-control mb-2" OnSelectedIndexChanged="ddtLoaiHoa_SelectedIndexChanged" runat="server"></asp:DropDownList></li>
    				</ul>
    			</div>
    		</div>
    		<div class="row">
                <asp:Repeater ID="rptHoa" runat="server" OnItemCommand="rptHoa_ItemCommand">
                    <ItemTemplate>
                        <div class="col-md-6 col-lg-3 ftco-animate">
    				        <div class="product">
    					        <a href="#" class="img-prod">
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "images/products/" + Eval("AnhMinhHoa") %>'/>
    						        <span class="status">30%</span>
    						        <div class="overlay"></div>
    					        </a>
    					        <div class="text py-3 pb-4 px-3 text-center">
    						        <h3>
                                        <a href="#">
                                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHoa") %>' />
    						            </a>
    						        </h3>
    						        <div class="d-flex">
    							        <div class="pricing">
		    						        <p class="price"><span class="mr-2 price-dc">
                                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("GiaTien") %>'/></span><span class="price-sale">$80.00</span></p>
		    					        </div>
	    					        </div>
	    					        <div class="bottom-area d-flex px-3">
	    						        <div class="m-auto d-flex">
                                            <asp:LinkButton ID="btn_MENU" CssClass="add-to-cart d-flex justify-content-center align-items-center text-center ion-ios-menu " runat="server"></asp:LinkButton>
                                            <asp:LinkButton ID="btn_GH" CssClass="ion-ios-cart buy-now d-flex justify-content-center align-items-center mx-1" CommandName="ThemGH" CommandArgument='<%# Eval("MaHoa") %>' runat="server"></asp:LinkButton>
                                            <asp:LinkButton ID="btn_LIKE" CssClass="heart d-flex justify-content-center align-items-center ion-ios-heart" runat="server"></asp:LinkButton>
    							        </div>
    						        </div>
    					        </div>
    				        </div>
    			        </div>
                    </ItemTemplate>
                </asp:Repeater>
             </div>
    		<div class="row mt-5">
          <div class="col text-center">
            <div class="block-27">
              <ul>
                <li><a href="#">&lt;</a></li>
                <li class="active"><span>1</span></li>
                <li><a href="#">2</a></li>
                <li><a href="#">3</a></li>
                <li><a href="#">4</a></li>
                <li><a href="#">5</a></li>
                <li><a href="#">&gt;</a></li>
              </ul>
            </div>
          </div>
        </div>
    	</div>
    </section>
</asp:Content>
