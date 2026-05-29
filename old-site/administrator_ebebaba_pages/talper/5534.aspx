<%@ Page Language="C#" AutoEventWireup="true" CodeFile="5534.aspx.cs" Inherits="ivfyonetici_talper_5534" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <%-- <link rel="stylesheet" href="demos.css">
 --%>
    <link rel="stylesheet" href="tasarim.css">
    <style type="text/css">
        .auto-style1 {
            height: 24px;
            width: 361px;
        }
    </style>
</head>
<body style="margin:0;">
    <form id="form1" runat="server">
    <div>
      <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 0px solid; border-top: black 0px solid; border-left: black 0px solid; border-bottom: black 0px solid;" width="100%">
       <tr>
           <td valign="bottom">
               <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td colspan="2">
                           <table border="0" cellpadding="0" cellspacing="0" width="100%" style="height: 33px">
                               <tr>
                                   <td background="../../imgs/ust_menu_bg.jpg" colspan="2" valign="middle">
                                       <table cellpadding="0" cellspacing="0" style="width: 100%">
                                           <tr>
                                               <td valign="middle" class="auto-style1">
                                                   &nbsp; 
                                                   <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                       Font-Size="11px" Text="Kaynak Kayıt / Güncelleme Log Kayıtları" style="font-size: 12px"></asp:Label></td>
                                               <td style="height: 24px; text-align: right" valign="middle">

                               
                                       <asp:LinkButton ID="LinkButton2" runat="server" Font-Names="Arial" Font-Size="13px" Font-Underline="False" OnClick="LinkButton2_Click" style="font-weight: 700">Gelir - Gider Durumu</asp:LinkButton>

                               
                               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

                               
                                       <asp:LinkButton ID="LinkButton1" runat="server" Font-Names="Arial" Font-Size="13px" Font-Underline="False" OnClick="LinkButton1_Click" style="font-weight: 700">Anasayfaya Dön &gt;</asp:LinkButton>

                               
                               &nbsp;&nbsp;&nbsp;
                                                   </td>
                                           </tr>
                                       </table>
                                   </td>
                               </tr>
                           </table>
                       </td>
                   </tr>
               </table>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                   &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label><br />
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table width="90%" border="0" cellpadding="0" cellspacing="0" align="center">
                                        <tr>
                                            <td style="text-align: center;" colspan="7" valign="middle">
                                                <span style="color: darkgray"><span style="font-size: 11px; font-family: Arial"><strong>
                                                    <br />
                                                    </strong></span> </span><strong> <span style="font-size: 11px; font-family: Arial">Kayıtlarda Ara : </span></strong>&nbsp;<asp:TextBox ID="arama" runat="server"
                                                        SkinID="txtsiklus" ValidationGroup="liste4"></asp:TextBox>
                                                &nbsp;<asp:Button ID="Button1" runat="server" Font-Size="12px" OnClick="Button1_Click"
                                                    SkinID="btn" Text="Ara" ValidationGroup="liste4" />&nbsp;<br />
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="arama"
                                                    Display="Dynamic" ErrorMessage="Arama Sözcüğü Girilmedi !!" Font-Names="Arial" Font-Size="11px" SetFocusOnError="True"
                                                    ValidationGroup="liste4" Font-Bold="True"></asp:RequiredFieldValidator>
                                                <asp:Label ID="Label15" runat="server" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                <asp:GridView ID="loglist" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="#333333" Width="90%" HorizontalAlign="Center" AllowPaging="True" EnableModelValidation="True" OnPageIndexChanging="loglist_PageIndexChanging" PageSize="60" style="font-size: 12px">
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="islemYapan" HeaderText="İşlem Yapan Kullanıcı">
                                        <ControlStyle Width="120px" />
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <ItemStyle Width="15%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="hastaAdi" HeaderText="İşlem Yapılan Hasta">
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <ItemStyle Width="20%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="islem" HeaderText="Seçilen Kaynak">
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="50%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="islemTarihi" HeaderText="İşlem Tarihi">
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="15%" />
                                        </asp:BoundField>
                                    </Columns>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#0099CC" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                </asp:GridView>
                                    <br />
                                </div>
                            </td>
                        </tr>
                    </table>
    <br />

    </div>
    </form>
</body>
</html>
