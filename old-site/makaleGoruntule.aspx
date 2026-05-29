<%@ Language="C#" MasterPageFile="~/talper.master" AutoEventWireup="true" Debug="true" CodeFile="makaleGoruntule.aspx.cs" Inherits="makaleGoruntule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <header class="header-base">
        <div class="container">
        
            <ol class="breadcrumb">
                <li><a href="default.aspx">Anasayfa</a></li>
                <li runat="server" id="anaKategoriAdi"></li>
                <li runat="server" id="altKategoriAdi"></li>
            </ol>
                <h1 id="baslik" runat="server" style="text-transform:none;"></h1>
        </div>
    </header>
    <main>
        <section class="section-base ">
            <div class="container">
                <div class="row">
                    <div class="col-lg-8" runat="server">
                        <div class="row">
                            <div class="col" id="icerik" runat="server">
								
								</div>
                             <div class="col-lg-12" style="margin-top:20px;">

                                  <asp:Label ID="lblGeri" runat="server"></asp:Label>   
                                  <asp:Label ID="lblIleri" runat="server" style="float:right;"></asp:Label>
                                	
								
							
                             </div>

                            </div>
        
                    </div>
                           
							


                    <div class="col-lg-4 widget">
                   
                        <h3 id="altKategori2" runat="server" style='text-transform:none;'></h3>
                        <hr class="space-xs" />
                        <div class="menu-inner menu-inner-vertical" id="kategoridekiDigerBasliklar" runat="server">
                           

                        </div>
                        <hr class="space-sm" /><hr class="space-sm" />
                        <h3 style='text-transform:none;'>TEDAVİ ÖNCESİ</h3>
                        <hr class="space-sm" />
                        <div class="menu-inner menu-inner-vertical menu-inner-image">
                            <ul id="tedaviOncesiIcerik" runat="server" style="text-transform:none;" >
                              
                            </ul>
                        </div>
                        <hr class="space-sm" /><hr class="space-sm" />
                        <h3 style='text-transform:none;'>TEDAVİ SÜRECİ</h3>
                        <hr class="space-sm" />
                        <div class="menu-inner menu-inner-vertical menu-inner-image">
                            <ul id="tedaviSureciIcerik" runat="server" style="text-transform:none;" >
                                
                            </ul>
                        </div>
                        <hr class="space-sm" />
                       
                    </div>
                </div>
            </div>
        </section>
    </main>










<%--    <div id="fb-root"></div>

    <div role="main" class="main">

				<div class="container">

					<div class="row">
						<div class="col-lg-9">

						
							
                            

                              


						</div>

						<div class="col-lg-3">
							<aside class="sidebar">

								

									<div class="tabs mb-4 pb-2">
									<ul class="nav nav-tabs">
										<li class="nav-item active"><a class="nav-link" href="#once" data-toggle="tab"> Tedavi Öncesi</a></li>
										<li class="nav-item"><a class="nav-link" href="#surec" data-toggle="tab">Tedavi Süreci</a></li>
									</ul>
									<div class="tab-content">
										<div class="tab-pane active" id="once">
											<ul class="simple-post-list" id="tedaviOncesiIcerik" runat="server">
										
											
											</ul>
										</div>
										<div class="tab-pane" id="surec">
											<ul class="simple-post-list" id="tedaviSureciIcerik" runat="server">
									
											</ul>
										</div>
									</div>
								</div>

								
							</aside>
						</div>
					</div>

				</div>

			</div>
     <div style="display: none;">
 <div class="gg-fb"><img src="js/ulasti.png" alt="" width="579" height="297" />
 </div>
  <div class="gg-fb2"><img src="js/ulasamadi.png" alt="" width="579" height="297" />
 </div>

 </div>--%>
</asp:Content>

