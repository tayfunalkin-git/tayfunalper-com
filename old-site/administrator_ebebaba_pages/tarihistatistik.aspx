<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tarihistatistik.aspx.cs" Inherits="ebebaba_0000063" Debug="true" Theme="SkinFile"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            height: 14px;
        }
        .style6
        {
            width: 100%;
        }
        .style7
        {
            width: 374px;
            text-align: left;
        }
        .style8
        {
            text-align: left;
        }
        .style9
        {
            width: 21px;
        }
        .style10
        {
            width: 133px;
        }
        .style11
        {
            width: 11px;
        }
    </style>
</head>
<body>

<form runat="server">
   <table align="center" border="0" cellpadding="0" cellspacing="0" 
        style="width: 95%; ">
                        <tr>
                            <td valign="top" style="text-align: center">
                                &nbsp;<br />
                                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="False" 
                                    Font-Underline="False" oncommand="LinkButton1_Command" 
                                    style="font-size: medium; font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FF0000">&lt;&lt; </asp:LinkButton>
&nbsp;&nbsp; <asp:Label ID="page_label0" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" style="font-size: medium"></asp:Label>&nbsp;<asp:Label 
                                    ID="page_label" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" Text="Ýstatistikler" 
                                    style="font-size: medium"></asp:Label>&nbsp;&nbsp;&nbsp;
                                <asp:LinkButton ID="LinkButton2" runat="server" Font-Underline="False" 
                                    oncommand="LinkButton2_Command" 
                                    style="font-size: medium; font-family: Arial, Helvetica, sans-serif; font-weight: 700; color: #FF0000">&gt;&gt; </asp:LinkButton>
                                <br />
                                <br />
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" 
                                                    Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" 
                                                    Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                <br />
                                <asp:Panel ID="Panel1" runat="server" Visible="False" Width="100%" 
                                    HorizontalAlign="Left" style="text-align: center">
                                    <table width="100%" style="height: 29px">
                                        <tr>
                                            <td style="text-align: left" class="style1">
                                                <br />
                                                <table align="left" cellspacing="1" class="style6">
                                                    <tr>
                                                        <td class="style7" valign="top">
                                                            <asp:Label ID="page_label3" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                Font-Size="11px" style="font-size: medium" Text="Ýstatistikler"></asp:Label>
                                                            <br />
                                                            <br />
                                                            <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
                                                                EnableModelValidation="True" Font-Names="Arial" Font-Size="11px" 
                                                                ForeColor="#333333" GridLines="None" style="text-align: left" Width="100%">
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                <EditRowStyle BackColor="#999999" />
                                                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
                                                                    HorizontalAlign="Left" />
                                                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                            </asp:GridView>
                                                            <div class="style8">
                                                                <br />
                                                                <span style="font-size: 10px; font-family: Arial">Toplam Gösterim Sayýsý :
                                                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                    Font-Size="11px"></asp:Label>
                                                                </span>
                                                                <br style="text-align: left" />
                                                                <span style="font-size: 10px; font-family: Arial">Toplam Farklý Ziyaretçi Sayýsý 
                                                                :
                                                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                    Font-Size="11px"></asp:Label>
                                                                </span>
                                                            </div>
                                                        </td>
                                                        <td class="style9" style="text-align: left" valign="top">
                                                            &nbsp;</td>
                                                        <td class="style10" style="text-align: left" valign="top">
                                                            <asp:Label ID="page_label1" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                Font-Size="11px" style="font-size: medium" Text="Ziyaretçiler"></asp:Label>
                                                            <br />
                                                            <br />
                                                            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                                                CellPadding="4" EnableModelValidation="True" Font-Names="Arial" 
                                                                Font-Size="11px" ForeColor="#333333" GridLines="None" style="text-align: left" 
                                                                Width="100%">
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                <Columns>
                                                                    <asp:TemplateField HeaderText="IP Adresi">
                                                                        <ItemTemplate>
                                                                            <asp:LinkButton ID="ip" runat="server" Font-Underline="False" 
                                                                                oncommand="ip_Command" style="font-size: 12px"></asp:LinkButton>
                                                                        </ItemTemplate>
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                                <EditRowStyle BackColor="#999999" />
                                                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                            </asp:GridView>
                                                        </td>
                                                        <td class="style11" style="text-align: left" valign="top">
                                                            &nbsp;</td>
                                                        <td style="text-align: left" valign="top">
                                                            <asp:Label ID="page_label2" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                Font-Size="11px" style="font-size: medium"></asp:Label>
                                                            <br />
                                                            <br />
                                                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                                                CellPadding="4" EnableModelValidation="True" Font-Names="Arial" 
                                                                Font-Size="11px" ForeColor="#333333" GridLines="None" style="text-align: left" 
                                                                Width="100%">
                                                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                <Columns>
                                                                    <asp:TemplateField HeaderText="Sayfa">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="sayfa" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="Sayfaya Geliþ Zamaný">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="saat" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:TemplateField>
                                                                    <asp:TemplateField HeaderText="Kaldýðý Süre">
                                                                        <ItemTemplate>
                                                                            <asp:Label ID="sure" runat="server"></asp:Label>
                                                                        </ItemTemplate>
                                                                        <HeaderStyle HorizontalAlign="Left" />
                                                                    </asp:TemplateField>
                                                                </Columns>
                                                                <EditRowStyle BackColor="#999999" />
                                                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                            </asp:GridView>
                                                            <br />
                                                        </td>
                                                    </tr>
                                                </table>
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                                <br />
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp;</asp:Panel>
                            </td>
                        </tr>
                    </table>
    <br />
    
        </div>
    </form>
</body>
</html>

