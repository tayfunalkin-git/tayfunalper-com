<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resimYukleIcerik.aspx.cs" Debug="true" Inherits="administrator_ebebaba_pages_resimYukle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
       	<script src="js/jquery.Jcrop.js" type="text/javascript"></script> 
	<link href="js/jquery.Jcrop.css" type="text/css" rel="stylesheet" /> 

     <script type="text/javascript">


           function refreshParent() {
            var loc = "havuzicerik.aspx";
             window.opener.location = loc;

         }


         $(function () {
             jQuery('#resim500').Jcrop({
                 onSelect: storeCoords,
                 maxSize: [480, 500]
                

             });

            
         })

    function storeCoords(c) {
        jQuery('#X500').val(c.x);
        jQuery('#Y500').val(c.y);
        jQuery('#W500').val(c.w);
        jQuery('#H500').val(c.h);
    };

        </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 274px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="font-family: arial, Helvetica, sans-serif; font-size: 12px"><strong>Resim Seçiniz : </strong>
    
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="resim" Display="Dynamic" ErrorMessage="Resim Seçiniz !" SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator>
&nbsp;<asp:FileUpload ID="resim" runat="server" CssClass="form-control" />
                </td>
                <td>
                    <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Resmi Yükle" CssClass="btn_1" ValidationGroup="kyd" />
                    &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Kırp ve Kaydet" CssClass="btn_2" Visible="False" />
                        &nbsp;<asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="12px" style="font-weight: 700"></asp:Label>
                </td>
            </tr>
        </table>
        </div>
        <asp:Panel ID="Panel1" runat="server" Visible="False">
            <table class="auto-style1" style="font-family: arial, Helvetica, sans-serif; font-size: 12px; font-weight: bold;">
                <tr>
                    <td>
                        <asp:Image ID="resim500" runat="server"/>
                    </td>
                </tr>
            </table>
            <asp:HiddenField ID="X500" runat="server"/>
      <asp:HiddenField ID="Y500" runat="server"/>
      <asp:HiddenField ID="W500" runat="server"/>
      <asp:HiddenField ID="H500" runat="server"/>
        </asp:Panel>
    </form>
</body>
</html>
