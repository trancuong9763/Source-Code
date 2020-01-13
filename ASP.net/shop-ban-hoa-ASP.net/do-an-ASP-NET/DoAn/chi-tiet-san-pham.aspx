<%@ Page Title="" Language="C#" MasterPageFile="~/Master-page-do-an.Master" AutoEventWireup="true" CodeBehind="chi-tiet-san-pham.aspx.cs" Inherits="DoAn.chi_tiet_san_pham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphIndex" runat="server">
     <!-- CHI TIET SAN PHAM PAGE -->
        <div class="hero-wrap hero-bread" style="background-image: url('images/bg_1.jpg');">
      <div class="container">
        <div class="row no-gutters slider-text align-items-center justify-content-center">
          <div class="col-md-9 ftco-animate text-center">
          	<p class="breadcrumbs"><span class="mr-2"><a href="index.html">Home</a></span> <span class="mr-2"><a href="index.html">Product</a></span> <span>Product Single</span></p>
            <h1 class="mb-0 bread">Product Single</h1>
          </div>
        </div>
      </div>
    </div>

    <section class="ftco-section">
    	<div class="container">
    		<div class="row">
    			<div class="col-lg-6 mb-5 ftco-animate">
    				<a href="#" class="image-popup">
                        <asp:Image ID="imgAnhMinhHoa" runat="server" CssClass="img-fluid" />
    				</a>
    			</div>
    			<div class="col-lg-6 product-details pl-md-5 ftco-animate">
    				<h3><asp:Label runat="server" ID="lblTenHoa" /></h3>
    				<p class="price"><span><asp:Label runat="server" ID="lblGiaTien" />đ</span></p>
    				
						<div class="row mt-4">
							<div class="w-100"></div>
							<div class="input-group col-md-6 d-flex mb-3">
	          	</div>
          	</div>
          	        <p>
                        <asp:Button Text="Thêm vào giỏ hàng" ID="btnThemGH" OnClick="btnThemGH_Click" runat="server" CssClass="btn btn-black py-3 px-5" />
          	        </p>
    			</div>
    		</div>
    	</div>
    </section>

    <section class="ftco-section">
    	<div class="container">
				<div class="row justify-content-center mb-3 pb-3">
          <div class="col-md-12 heading-section text-center ftco-animate">
          	<span class="subheading">Sản phẩm</span>
            <h2 class="mb-4">Sản phẩm liên quan</h2>
          </div>
        </div>   		
    	</div>
    	<div class="container">
    		<div class="row">
                <asp:Repeater runat="server" ID="rptSanPhamLienQuan" OnItemCommand="rptSanPhamLienQuan_ItemCommand">
                    <ItemTemplate>
                        <div class="col-md-6 col-lg-3 ftco-animate">
    				        <div class="product">
                                <asp:HyperLink
                                    NavigateUrl='<%# "/chi-tiet-san-pham.aspx?mahoa=" + Eval("MaHoa") %>' 
                                    runat="server"
                                    CssClass="img-prod" >
                                    <asp:Image ImageUrl='<%# "images/products/" +Eval("AnhMinhHoa")%>' runat="server" />
    						        <div class="overlay"></div>
                                </asp:HyperLink>
    					        <div class="text py-3 pb-4 px-3 text-center">
    						        <h3><asp:Label Text='<%# Eval("TenHoa") %>' runat="server" /></h3>
    						        <div class="d-flex">
    							        <div class="pricing">
		    						        <p class="price"><asp:Label Text='<%# "$ " + Eval("GiaTien") %>' runat="server" /></p>
		    					        </div>
	    					        </div>
    						        <div class="bottom-area d-flex px-3">
	    						        <div class="m-auto d-flex">
	    							        <a href="#" class="add-to-cart d-flex justify-content-center align-items-center text-center">
	    								        <span><i class="ion-ios-menu"></i></span>
	    							        </a>
	    							        <asp:LinkButton ID="btn_GH" CssClass="ion-ios-cart buy-now d-flex justify-content-center align-items-center mx-1" CommandName="ThemGH" CommandArgument='<%# Eval("MaHoa") %>' runat="server"></asp:LinkButton>
	    							        <a href="#" class="heart d-flex justify-content-center align-items-center ">
	    								        <span><i class="ion-ios-heart"></i></span>
	    							        </a>
    							        </div>
    						        </div>
    					        </div>
    				        </div>
    			    </div>
                    </ItemTemplate>
                </asp:Repeater>
    			
    		</div>
    	</div>
    </section>
</asp:Content>
