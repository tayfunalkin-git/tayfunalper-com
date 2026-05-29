<%@ Page Title="" Language="C#" MasterPageFile="~/talper.master" AutoEventWireup="true" CodeFile="aramaSonuclari.aspx.cs" Inherits="aramaSonuclari" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <header class="header-base">
        <div class="container">
            <h1 id="baslik" runat="server" style="text-transform:none;"></h1>
            <ol class="breadcrumb">
                <li><a href="default.aspx">Anasayfa</a></li>
                  <li>Arama Sonuçları</li>
            </ol>
        </div>
    </header>

        <main>

          
        <section class="section-base ">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12"  runat="server">

                     <asp:TextBox ID="txtAranacakKelime" runat="server" CssClass="input-text" ValidationGroup="doktor_girisii"  placeholder="Aramak İstediğiniz Kelimeyi Giriniz"></asp:TextBox>
                           <br><br> 
                     <asp:Button ID="Button1" runat="server"  class="btn btn-sm" OnClick="Button1_Click" ValidationGroup="doktor_girisii" Text="ARA" />
                        <br><br>

                        <div class="row">

                    
                           <div class="col-lg-12">
                               <div class="row">

                              
                        <div data-tab-anima="fade-in" class="col-lg-12">
                            <div class="panel active">
                                

                                    <div id="aramaSonuclariDiv" runat="server">


						</div>


                               
                            
                            </div>
                       </div>
                        </div>
                    </div>

                            </div>





						


                    </div>

                    </div></div></section></main>



</asp:Content>

