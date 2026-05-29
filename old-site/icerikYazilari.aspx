<%@ Page Title="" Language="C#" MasterPageFile="~/talper.master" AutoEventWireup="true" CodeFile="icerikYazilari.aspx.cs" Inherits="randevu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  


         <header class="header-base">
        <div class="container">
            <div class="row">
              
                  <div class="col-lg-12 col-md-12"> <h1 style="text-transform:none;" id="baslik" runat="server"></h1></div>
 
            </div>
          
           
             

            
           
          
        </div>
    </header>
    <main>
              <style>

            @media only screen and (max-width: 600px) {
  .resSol {
    width:100%;padding-right:0px;padding-bottom:0px;
  }
   .resSag {
    width:100%;padding-left:0px;padding-bottom:0px;
  }
}
        .resSol {
        width:400px;float:left;padding-right:10px;padding-bottom:10px;
        }
          .resSag {
        width:400px;float:right;padding-left:10px;padding-bottom:10px;
        }
    </style>
            <section class="section-base">
            <div class="container">
                <div class="row" data-anima="fade-bottom" data-time="1000">
                    <div class="col-lg-12" id="icerik" runat="server">
                      
              
                    </div>
                 
                </div>
              
              
            </div>
        </section>
        </main>
</asp:Content>

