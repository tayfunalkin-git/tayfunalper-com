<%@ Page Language="C#" AutoEventWireup="true" CodeFile="infertilite_guncelleme_bilgi.aspx.cs" Inherits="ivfyonetici_hasta_modulu_infertilite_guncelleme_bilgi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ýnfertilite Bilgileri Güncelleme Detaylarý</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" style="border-right: #d3d3d3 1px solid;
            border-top: #d3d3d3 1px solid; border-left: #d3d3d3 1px solid; width: 100%; border-bottom: #d3d3d3 1px solid">
            <tr>
                <td style="height: 34px; background-color: #f5f5f5; text-align: center">
                    <asp:Label ID="sonuc" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                        ForeColor="Black"></asp:Label></td>
            </tr>
        </table>
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td style="font-size: 11px; width: 230px; color: black; font-family: verdana; height: 10px;
                    text-decoration: none">
                </td>
                <td style="font-size: 11px; width: 300px; color: black; font-family: verdana; height: 10px;
                    text-decoration: none">
                    </td>
                <td style="font-size: 11px; color: black; font-family: verdana; height: 10px; text-decoration: none">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-size: 11px; color: black; font-family: verdana; text-decoration: none">
                    <asp:GridView ID="list" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        BorderColor="White" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Font-Size="11px"
                        ForeColor="#333333" OnPageIndexChanging="list_PageIndexChanging" PageSize="15"
                        Width="100%">
                        <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="guncelleyen" HeaderText="G&#252;ncelleyen" />
                            <asp:BoundField DataField="tarih" HeaderText="G&#252;ncellemeTarihi" />
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            Font-Names="Verdana" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="Gainsboro" ForeColor="Transparent" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="Silver" BorderStyle="Double" BorderWidth="1px" Font-Bold="True"
                            Font-Names="Verdana" Font-Size="11px" ForeColor="Black" HorizontalAlign="Left" />
                        <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            ForeColor="#404040" />
                    </asp:GridView>
                </td>
                <td style="font-size: 11px; color: black; font-family: verdana; text-decoration: none">
                </td>
            </tr>
            <tr>
                <td colspan="2" style="font-size: 11px; color: black; font-family: verdana; text-align: center;
                    text-decoration: none">
                    <span style="color: #0000ff; text-decoration: underline"><a href="javascript:window.close();">KAPAT</a></span></td>
                <td style="font-size: 11px; color: black; font-family: verdana; text-decoration: none">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>


