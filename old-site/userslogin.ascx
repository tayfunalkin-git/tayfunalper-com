<%@ Control Language="C#" AutoEventWireup="true" CodeFile="userslogin.ascx.cs" Inherits="userslogin"  %>

   <script type="text/javascript" src="jquery-1.4.1.js">
</script>
<script type="text/javascript">
    $(document).ready(function () {

        $("#btnGiris").click(function () {
           
                        $("#ctl00_userslogin21_snc").html("Kullanıcı Bilgileriniz Sorgulanıyor.Lütfen Bekleyiniz...").fadeIn(3000, 0.50);
                        $.post("forum/uyeGirisYap.aspx?ad=" + $("#ctl00_userslogin21_EbebabaKullaniciAdi").val() + "&sifre=" + $("#ctl00_userslogin21_EbebabaSifre").val(),
                   function (msg) {
                       if (msg != "1") {
                           $("#ctl00_userslogin21_snc").html(msg);
                       }
                       else {
                           $("#ctl00_userslogin21_snc").html("Oturumunuz Açılıyor...").fadeIn(5000,0.25);
                           window.location.reload();

                       }

                   }, "", "text")

        })

    });
</script>

   
 <style type="text/css"> 
 
    @import url("Style.css"); 
     .style5
     {
         font-family: Tahoma, Helvetica, sans-serif;
         color: #FFFFFF;
     }
     .style9
     {
         width: 19px;
     }
     .style10
     {
         width: 479px;
     }
     #btnGiris
     {
         height: 23px;
     }
 </style>

 

 
<table cellpadding="2" class="apPanelStyle" width="850px">
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style10">
                                        <span style="font-size: 12px">
                                        <span><span class="style5">Kullanıcı Adı : </span></span></span>
                                        <asp:TextBox 
                                            ID="EbebabaKullaniciAdi" runat="server" 
                Font-Bold="False" Font-Names="Tahoma" 
                                            Font-Size="12px" MaxLength="15" ValidationGroup="uyem" 
                                            Width="85px"></asp:TextBox>
                                        <span>
                                        <span style="font-size: 12px"><em>&nbsp;</em></span></span><span 
                style="font-size: 12px"><em>&nbsp; 
                                        <span>&nbsp;</span></em><span><span 
                                            class="style5">Şifre : </span></span>
                                        </span>
                                        <asp:TextBox 
                                            ID="EbebabaSifre" runat="server" 
                Font-Bold="False" Font-Names="Tahoma" 
                                            Font-Size="12px" MaxLength="15" TextMode="Password" 
                                            ValidationGroup="uyem" Width="85px"></asp:TextBox>
                                        <span style="font-size: 12px"><em> 
                                        &nbsp; <input id="btnGiris" type="button" value="Giriş" /></em></span></td>
        <td style="text-align: right">
                                    <asp:Menu ID="Menum" runat="server" 
    DisappearAfter="0" Font-Bold="False" Font-Names="Calibri"
                                        Font-Size="13px" ForeColor="White" 
    Height="1px" meta:resourcekey="mainMenuResource1"
                                        Orientation="Horizontal" 
    StaticSubMenuIndent="" Width="300px">
                                        <StaticMenuStyle HorizontalPadding="0px" VerticalPadding="0px" />
                                        <StaticSelectedStyle ForeColor="White" />
                                        <StaticMenuItemStyle BackColor="#333333" ForeColor="White" Height="20px" 
                                            HorizontalPadding="10px" />
                                        <DynamicHoverStyle BackColor="#993333" BorderColor="White" BorderStyle="Solid" BorderWidth="1px"
                                            Font-Names="Calibri" Font-Size="13px" ForeColor="White" />
                                        <DynamicMenuItemStyle BackColor="DarkOrange" BorderColor="White" BorderStyle="Solid"
                                            BorderWidth="1px" Font-Names="Calibri" Font-Size="13px" ForeColor="White" HorizontalPadding="3px"
                                            VerticalPadding="3px" />
                                        <Items>
                                            <asp:MenuItem NavigateUrl="~/forum/kayit.aspx" Text="Üye Ol" Value="Üye Ol">
                                            </asp:MenuItem>
                                            <asp:MenuItem NavigateUrl="~/forum/aktivasyon.aspx" 
                                                Text="Şifremi Unuttum / Aktivasyon İşlemleri" Value="Şifremi Unuttum">
                                            </asp:MenuItem>
                                        </Items>
                                        <StaticHoverStyle BackColor="#333333" Font-Names="Calibri" Font-Size="13px" Font-Underline="False"
                                            ForeColor="White" />
                                    </asp:Menu>
                            </td>
    </tr>
    <tr>
        <td class="style9">
            &nbsp;</td>
        <td class="style10">
                                        <asp:Label ID="snc" runat="server" 
                Font-Italic="False" Font-Names="Calibri" 
                                            Font-Size="12px" style="color: #000000"></asp:Label>
                                    </td>
        <td>
            &nbsp;</td>
    </tr>
</table>

            
       