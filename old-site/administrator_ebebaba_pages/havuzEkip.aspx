<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeFile="havuzEkip.aspx.cs" Inherits="mainAdminPagesHdn_havuz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 434px;
        }
    </style>

         <style type="text/css">

.hovergallery img{
-webkit-transform:scale(1.1); /*Webkit: Scale down image to 0.8x original size*/
-moz-transform:scale(1.1); /*Mozilla scale version*/
-o-transform:scale(1.1); /*Opera scale version*/
-webkit-transition-duration: 0.5s; /*Webkit: Animation duration*/
-moz-transition-duration: 0.5s; /*Mozilla duration version*/
-o-transition-duration: 0.5s; /*Opera duration version*/
opacity: 0.7; /*initial opacity of images*/
margin: 0 0px 0px 0; /*margin between images*/
}

.hovergallery img:hover{
-webkit-transform:scale(1.3); /*Webkit: Scale up image to 1.2x original size*/
-moz-transform:scale(1.3); /*Mozilla scale version*/
-o-transform:scale(1.3); /*Opera scale version*/
box-shadow:0px 0px 0px gray; /*CSS3 shadow: 30px blurred shadow all around image*/
-webkit-box-shadow:0px 0px 30px gray; /*Safari shadow version*/
-moz-box-shadow:0px 0px 30px gray; /*Mozilla shadow version*/
opacity: 1;
}

             .auto-style3 {
                 font-weight: normal;
                 color: #0000CC;
             }

         </style>

    <script>

        function ekle(resimAdi,tur)
        {

            if (tur == "kapak")
            {
                var anaNesneAdi = "ctl00_ContentPlaceHolder1_txtKapak";
            var gosterilecekYer = "ctl00_ContentPlaceHolder1_secilenKapakResmi";
            var html = "<img src='../uploadImages/" + resimAdi + "_450.jpg'/>";
            //alert(html);
            window.opener.parent.$("#" + anaNesneAdi).val(resimAdi);
            window.opener.parent.$("#" + gosterilecekYer).html(html);
           window.close();
            }
            else if (tur == "icerik")
            {

           
                var anaNesneAdi = "ctl00_ContentPlaceHolder1_txtIcerik";
                var html = "<br><img src='../uploadImages/" + resimAdi + "_450.jpg'/><br>";
                parent.$("#" + anaNesneAdi).summernote('pasteHTML', html);
                window.parent.jQuery.colorbox.close();

            }
           

           // alert(resimAdi);
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
  


        <table class="auto-style1" cellpadding="0" cellspacing="0">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" style="font-size: 20px; font-weight: 700;" Text="EKİP RESİM HAVUZU"></asp:Label>
                </td>
                <td style="text-align: right">
                    <asp:Button ID="Button1" runat="server" CssClass="btn_2" Text="YENİ RESMİ YÜKLE" OnClick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
        <br />
        Ekip Resim Havuzundaki Resim Sayısı : <asp:Label ID="Label15" runat="server" style="color: #000099"></asp:Label>
    
        <br />
        <span class="auto-style3">(Kullanmak istediğiniz resmin üzerine tıklayınız.)</span></div>
        <br />
        <asp:DataList ID="resimList" runat="server" RepeatColumns="3" Width="100%" RepeatDirection="Horizontal" >
            <AlternatingItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" VerticalAlign="Top" />
            <ItemStyle Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" VerticalAlign="Top" />
            <ItemTemplate>

                <asp:Label ID="resim" runat="server" Text=""></asp:Label>
              
                  
                                    <asp:Label ID="Label14" runat="server"></asp:Label>
                <asp:Button ID="sil" runat="server" CssClass="btn_3" OnClientClick="return confirm('Resim yazında kullanılıyor olabilir.Kalıcı olarak silinecektir.Eminmisiniz?');return false;" OnCommand="sil_Command" Text="SİL" />
                                    <br />
                                    <br />
                                    <br />
                                </ItemTemplate>
        </asp:DataList>
    </form>
</body>
</html>
