<%@ Page Language="C#" AutoEventWireup="true" Debug="true" CodeFile="3457.aspx.cs" Inherits="ivfyonetici_talper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="margin:0;">
    <form id="form1" runat="server">
    <div>
    
     <asp:ScriptManager ID="ScriptManager1" runat="server">
     </asp:ScriptManager>
        <%--<link rel="stylesheet" href="../css/demos.css">--%>
 
    <link rel="stylesheet" href="tasarim.css">
       <link rel="stylesheet" href="colorbox.css" />
	 <script src="jquery.min.js"></script>
		<script src="jquery.colorbox-min.js"></script>
      <script type="text/javascript">

          function deneme2() {

              $(".iframe5").colorbox({ iframe: true, fastIframe: false, width: "1100px", height: "400px", transition: "fade", scrolling: true });
          }

      </script>
    
    	<link type="text/css" href="window/css/jquery.window.css" rel="stylesheet" />
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.9/jquery-ui.min.js"></script>
    <script type="text/javascript" src="window/jquery.window.js"></script>
	<script type="text/javascript">
	    function createWindow(link, baslik, genislik, yukseklik, mesaj) {
	        $.window({

	            title: baslik,
	            url: link,
	            iframeRedirectCheckMsg: mesaj,
	            width: genislik,
	            height: 600,
	            modalOpacity: 0.5,
	            showModal: true,
	            showFooter: false,
	            bookmarkable: false,
	            withinBrowserWindow: true

	        });
	    }
	</script>
    
        
        <style>
            #cboxOverlay{ background:#666666; text-decoration:none; }
		    .auto-style313132 {
                height: 24px;
                width: 279px;
            }
		    .auto-style313141 {
                width: 9px;
                height: 30px;
            }
            .auto-style313142 {
                height: 30px;
            }
            .auto-style313144 {
                width: 108px;
                height: 30px;
            }
            .auto-style313145 {
                width: 7px;
                height: 30px;
            }
            .auto-style313149 {
                height: 10px;
                width: 7px;
            }
            .auto-style313150 {
                height: 16px;
                width: 7px;
            }
            .auto-style313151 {
                width: 100%;
            }
            </style>

   
   <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 100%; border-right: black 0px solid; border-top: black 0px solid; border-left: black 0px solid; border-bottom: black 0px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="top">
               <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 33px">
                           <table cellpadding="0" cellspacing="0" style="width: 100%">
                               <tr>
                                   <td style="width: 197px; height: 24px;" valign="middle">
                                       &nbsp; <asp:Label ID="page_label" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" Text="Malzeme Karşılaştırma" style="font-size: 12px"></asp:Label></td>
                                   <td style="height: 24px; text-align: right;" valign="middle">
                                   &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" Font-Names="Arial" Font-Size="13px" Font-Underline="False" OnClick="LinkButton4_Click" style="font-weight: 700">IVF</asp:LinkButton>

                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton3" runat="server" Font-Names="Arial" Font-Size="13px" Font-Underline="False" OnClick="LinkButton3_Click" style="font-weight: 700">FLRY</asp:LinkButton>

                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton2" runat="server" Font-Names="Arial" Font-Size="13px" Font-Underline="False" OnClick="LinkButton2_Click" style="font-weight: 700" Visible="False">Kaynak Log Sorgula</asp:LinkButton>

                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                               
                                       <asp:LinkButton ID="LinkButton1" runat="server" Font-Names="Arial" Font-Size="13px" Font-Underline="False" OnClick="LinkButton1_Click" style="font-weight: 700">Anasayfaya Dön &gt;</asp:LinkButton>

                               
                               &nbsp;&nbsp;

                               
                               </tr>
                           </table>
                       </td>
                   </tr>
               </table>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="true" Width="100%" HorizontalAlign="Center">
                   <br />
                               <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label></asp:Panel>

                     </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table style="width: 90%; font-family: arial, Helvetica, sans-serif; font-size: 12px;" align="center">
                                        <tr>
                                            <td style="width: 9px; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Arial; height: 10px" valign="top">
                                                &nbsp;</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; " valign="top" class="auto-style313149">
                                                &nbsp;</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 10px" valign="top">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 10px" valign="top">
                                                &nbsp;</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 10px" valign="top">
                                                &nbsp;</td>
                                        </tr>
                                        <tr valign="top">
                                            <td style="width: 9px; height: 20px;">
                                            </td>
                                            <td style="width: 108px; height: 30px" valign="top">
                                                <br />
                                                Tarih</td>
                                            <td valign="top" class="auto-style313145">
                                                <br />
                                                :</td>
                                            <td style="height: 30px" valign="top">
                                                    <asp:DropDownList ID="ay" runat="server" SkinID="drop">
                                                        <asp:ListItem Value="">Hepsi</asp:ListItem>
                                                        <asp:ListItem Value="01">Ocak</asp:ListItem>
                                                        <asp:ListItem Value="02">Şubat</asp:ListItem>
                                                        <asp:ListItem Value="03">Mart</asp:ListItem>
                                                        <asp:ListItem Value="04">Nisan</asp:ListItem>
                                                        <asp:ListItem Value="05">Mayıs</asp:ListItem>
                                                        <asp:ListItem Value="06">Haziran</asp:ListItem>
                                                        <asp:ListItem Value="07">Temmuz</asp:ListItem>
                                                        <asp:ListItem Value="08">Ağustos</asp:ListItem>
                                                        <asp:ListItem Value="09">Eylül</asp:ListItem>
                                                        <asp:ListItem Value="10">Ekim</asp:ListItem>
                                                        <asp:ListItem Value="11">Kasım</asp:ListItem>
                                                        <asp:ListItem Value="12">Aralık</asp:ListItem>
                                                    </asp:DropDownList>
                                                    &nbsp;<asp:DropDownList ID="yil" runat="server" SkinID="drop">
                                                              <asp:ListItem>2017</asp:ListItem>
                                                    <asp:ListItem>2018</asp:ListItem>
                                                    <asp:ListItem>2019</asp:ListItem>
                                                    <asp:ListItem>2020</asp:ListItem>
                                                    </asp:DropDownList>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td class="auto-style313141">
                                                </td>
                                            <td valign="top" class="auto-style313144">
                                                </td>
                                            <td valign="top" class="auto-style313145">
                                                &nbsp;</td>
                                            <td valign="top" class="auto-style313142">
                                                    <br />
                                            </td>
                                            <td valign="top" class="auto-style313142">
                                                    </td>
                                            <td valign="top" class="auto-style313142">
                                                    </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 16px;">
                                            </td>
                                            <td style="font-family: arial; font-size: 11px; height: 16px; width: 108px;" valign="top">
                                                &nbsp;</td>
                                            <td style="font-family: arial; font-size: 11px; " valign="top" class="auto-style313150">
                                                &nbsp;</td>
                                            <td style="font-family: arial; font-size: 11px; height: 16px;" valign="top">
                                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sorgula" />
                                                <br />
                                                <br />
                                                </td>
                                            <td style="font-family: arial; font-size: 11px; height: 16px;" valign="top">
                                                &nbsp;</td>
                                            <td style="font-family: arial; font-size: 11px; height: 16px;" valign="top">
                                                &nbsp;</td>
                                        </tr>
                                        </table>
                                </div><asp:Panel ID="Panel1" runat="server" Width="100%" HorizontalAlign="Left">
                                    <br />
                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 33px">
                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                    <tr>
                                                        <td style="text-align: left;" valign="middle" class="auto-style313132">
                                                            &nbsp; <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                Text="Sorgu Sonuçları" style="font-size: 12px"></asp:Label></td>
                                                        <td style="height: 24px; text-align: right;" valign="middle">
                                                            &nbsp;
                                                            
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp; &nbsp; &nbsp;&nbsp;<table style="width: 90%" align="center">
                                        <tr>
                                            <td style="width: 16px">
                                            </td>
                                            <td>
                                               
                                                              
                                                                <asp:Panel ID="Panel3" runat="server">
                                                                    <table cellpadding="2" class="auto-style313151">
                                                                        <tr>
                                                                            <td>
                                                                                <asp:GridView ID="sarfList" runat="server" AutoGenerateColumns="False" CellPadding="4" EnableModelValidation="True" Font-Names="Arial" Font-Size="13px" ForeColor="#333333" GridLines="Horizontal" Width="100%">
                                                                                    <AlternatingRowStyle BackColor="White" />
                                                                                    <Columns>
                                                                                        <asp:BoundField DataField="sarf_adi" HeaderText="Malzeme Kategori Adı">
                                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                                        <ItemStyle HorizontalAlign="Left" />
                                                                                        </asp:BoundField>
                                                                                        <asp:TemplateField HeaderText="Toplam Tutar (IVF)">
                                                                                            <ItemTemplate>
                                                                                                <asp:Label ID="toplamTutarIVF" runat="server"></asp:Label>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle BackColor="#33CC33" HorizontalAlign="Right" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Siklus Sayısı (IVF)">
                                                                                            <ItemTemplate>
                                                                                                <asp:LinkButton ID="toplamSiklusIVF" runat="server" Font-Bold="True" Font-Underline="False"></asp:LinkButton>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle BackColor="#33CC33" HorizontalAlign="Right" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Ortalama (IVF)">
                                                                                            <ItemTemplate>
                                                                                                <asp:Label ID="ortalamaIVF" runat="server"></asp:Label>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle BackColor="#33CC33" HorizontalAlign="Right" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Toplam Tutar (FLRY)">
                                                                                            <ItemTemplate>
                                                                                                <asp:Label ID="toplamTutar" runat="server"></asp:Label>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle HorizontalAlign="Right" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Siklus Sayısı (FLRY)">
                                                                                            <ItemTemplate>
                                                                                                <asp:LinkButton ID="toplamSiklus" runat="server" Font-Bold="True" Font-Underline="False"></asp:LinkButton>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle HorizontalAlign="Right" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:TemplateField>
                                                                                        <asp:TemplateField HeaderText="Ortalama (FLRY)">
                                                                                            <ItemTemplate>
                                                                                                <asp:Label ID="ortalama" runat="server"></asp:Label>
                                                                                            </ItemTemplate>
                                                                                            <HeaderStyle HorizontalAlign="Right" />
                                                                                            <ItemStyle HorizontalAlign="Right" />
                                                                                        </asp:TemplateField>
                                                                                    </Columns>
                                                                                    <EditRowStyle BackColor="#2461BF" />
                                                                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                                                                    <RowStyle BackColor="#EFF3FB" />
                                                                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                                                </asp:GridView>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                                </asp:Panel>
                                                            <br />
                                                            <br />
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp;
                                    <br />
                                    &nbsp;&nbsp;
                                    
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
  
             
    </div>
    </form>
</body>
</html>
