<%@ Page Language="C#" MasterPageFile="~/talper.master" AutoEventWireup="true"  EnableEventValidation="false" CodeFile="ta_yonetim.aspx.cs" Inherits="_doktor_modulu" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


       <header class="header-base">
        <div class="container">
            <h1 style="text-transform:none;">Yönetici Giriş Ekranı / Oturum Aç</h1>
            <ol class="breadcrumb">
                <li><a href="default.aspx">Anasayfa</a></li>
           
            </ol>
        </div>
    </header>
     <main>
        <section class="section-base ">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
     
             <asp:Label ID="uye_adi" runat="server" Font-Bold="True" ForeColor="#000066" 
                    CssClass="yaziicerik" Font-Italic="False"></asp:Label>

                        <br><br>
          
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="uye_k_adi"
                        Display="Dynamic" ErrorMessage="*" SetFocusOnError="True" ValidationGroup="doktor_girisii"></asp:RequiredFieldValidator>
                                      <asp:TextBox ID="uye_k_adi" runat="server" Width="178px" CssClass="input-text" placeholder="Kullanıcı Adınız"
                    TabIndex="10" ValidationGroup="doktor_girisii" 
                    OnTextChanged="uye_k_adi_TextChanged"></asp:TextBox>
        
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="uye_sifre"
                        Display="Dynamic" ErrorMessage="*" SetFocusOnError="True" ValidationGroup="doktor_girisii"></asp:RequiredFieldValidator>
                                    <asp:TextBox ID="uye_sifre" runat="server" CssClass="input-text"  TextMode="Password"
                    Width="178px" TabIndex="11" ValidationGroup="doktor_girisii"  placeholder="Parolanız"
                    OnTextChanged="uye_sifre_TextChanged"></asp:TextBox>
                            
           <br><br>
             <asp:CheckBox ID="beni_hatirla" runat="server" Text="Beni Hatırla" Font-Names="Calibri" Font-Size="12px" TabIndex="13" ValidationGroup="doktor_girisii" />
           <br><br>
                     <asp:Button ID="Button1" runat="server" CssClass="btn btn-sm" onclick="Button1_Click" ValidationGroup="doktor_girisii" Text="Oturum Aç" />
            <br><br>
                   <asp:Label ID="sonuc" runat="server"></asp:Label>
                   

                          

                    </div>
                    </div>
                </div>
            </section>
         </main>

</asp:Content>



