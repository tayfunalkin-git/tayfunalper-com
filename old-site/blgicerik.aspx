<%@ Language="C#" MasterPageFile="~/talper.master" AutoEventWireup="true" CodeFile="blgicerik.aspx.cs" Inherits="makaleGoruntule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
   <div role="main" class="main">
				<section class="page-header">
					<div class="container">
						<div class="row">
							<div class="col">
								<ul class="breadcrumb">
									<li><a href="Default.aspx">Anasayfa</a></li>
                                     <li><a href="blog.aspx">Blog</a></li>
                                      <li class="active" id="blogKategorisi" runat="server" visible="false"></li>
									
								</ul>
							</div>
						</div>
						<div class="row">
							<div class="col">
								<h1 id="baslik" runat="server"></h1>
							</div>
						</div>
					</div>
				</section>

				<div class="container">
					<div class="row">
						<div class="col-lg-9">
                            <div class="blog-posts" id="icerik" runat="server">

                                </div>


             

                                    <div class="post-block post-leave-comment" id="yorumAlani">
											<h3 class="heading-primary">Yorum Yaz</h3>

                                   <form id="commentForm" name="commentForm">

												<div class="form-row">
													<div class="form-group col-lg-6">
														<label>Adınız ve Soyadınız *</label>
														<input type="text" value="" maxlength="100" class="form-control" name="txtCommnetName" id="txtCommnetName" required>
                                                    </div>
                                                    <div class="form-group col-lg-6">
															<label>E-Posta Adresiniz *</label>
														<input type="email" value="" maxlength="100" class="form-control" name="txtCommnetEmail" id="txtCommnetEmail" required>
													
                                                    </div>
													
												</div>

                        												<div class="form-row">
													<div class="form-group col">
														<label>Yorumunuz *</label>
														<textarea maxlength="5000" rows="10" class="form-control" name="txtCommentComment" id="txtCommentComment" required></textarea>
													</div>
												</div>
												<div class="form-row">
													<div class="form-group col-lg-3">
                                                      
                                                         <input id="btnComment"  name="btnComment" type="submit" value="Kaydet" class="btn btn-primary btn-lg" data-loading-text="Loading..."/>
                                                        <asp:HiddenField ID="comID" runat="server" />
                                                        <asp:HiddenField ID="comIP" runat="server" />

                                                               
													</div>
                                                    	<div class="form-group col-lg-9" id="commentResult">
                                                     
													</div>
												</div>
                                        </form>
									
										</div>
                            
                            
                         



										
						</div>

						<div class="col-lg-3">
							<aside class="sidebar">

								<h4 class="heading-primary">BLOG KATEGORİLERİ</h4>
								<ul class="nav nav-list flex-column mb-5" id="kategoridekiDigerBasliklar" runat="server">
								
								</ul>

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
 
       

</asp:Content>

