<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kullanici_degistir.aspx.cs" Inherits="administrator_ebebaba_pages_kullanici_degistir"  Theme="SkinFile"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Ortak Kullanýcý Deðiþikliði</title>
</head>
<body style="font-size: 12pt">
    <form id="form1" runat="server">
          <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 1px solid;
            border-top: black 1px solid; border-left: black 1px solid; width: 95%; border-bottom: black 1px solid">
            <tr>
                <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                    border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                    border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tr>
                                        <td style="width: 118px; height: 24px" valign="middle">
                                            &nbsp;<asp:Label ID="page_label" runat="server" Font-Bold="True" Font-Names="Arial"
                                                Font-Size="11px" Text="Kullanýcý Deðiþikliði"></asp:Label></td>
                                        <td style="color: #ff0000; height: 24px; text-align: right" valign="middle">
                                            &nbsp; &nbsp;&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <asp:Panel ID="panel_sonuc" runat="server" HorizontalAlign="Center"
                        Width="100%">
                        <br />
                        <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></asp:Panel>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <div align="center">
                        <br />
                        <table>
                            <tr>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 100px; color: black;
                                    font-family: arial;">
                                    Ortak Kullanýcýlar
                                </td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 6px; color: black;
                                    font-family: arial;">
                                    :</td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 98px; color: black;
                                    font-family: arial;">
                                    <asp:DropDownList ID="ortak_kullanici_kutu" runat="server" BackColor="White" Font-Bold="True"
                                        Font-Names="Arial" Font-Size="11px" ForeColor="#000040" SkinID="drop" ValidationGroup="ayni">
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 100px; color: black;
                                    font-family: arial;">
                                    Þifre</td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 6px; color: black;
                                    font-family: arial;">
                                    :</td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 98px; color: black;
                                    font-family: arial;">
                                    <asp:TextBox ID="txtsifre" runat="server" SkinID="txtGenisliksiz" TextMode="Password" TabIndex="1" ValidationGroup="ayni"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 100px; color: black;
                                    font-family: arial">
                                    Oturum Süresi</td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 6px; color: black;
                                    font-family: arial">
                                    :</td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 98px; color: black;
                                    font-family: arial">
                                    <asp:DropDownList ID="baglanti_suresi" runat="server" SkinID="drop">
                                        <asp:ListItem Selected="True" Value="15">15 Dk.</asp:ListItem>
                                        <asp:ListItem Value="30">30 Dk.</asp:ListItem>
                                        <asp:ListItem Value="45">45 Dk.</asp:ListItem>
                                        <asp:ListItem Value="60">60 Dk.</asp:ListItem>
                                        <asp:ListItem Value="90">90 Dk.</asp:ListItem>
                                        <asp:ListItem Value="120">120 Dk.</asp:ListItem>
                                    </asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 100px; color: black;
                                    font-family: arial;">
                                </td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 6px; color: black;
                                    font-family: arial;">
                                </td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 98px; color: black;
                                    font-family: arial;">
                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imgs/btnoturum.gif"
                                        OnClick="ImageButton1_Click" TabIndex="2" ValidationGroup="ayni" /></td>
                            </tr>
                            <tr>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 100px; color: black;
                                    font-family: arial">
                                </td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 6px; color: black;
                                    font-family: arial">
                                </td>
                                <td align="left" style="font-weight: bold; font-size: 11px; width: 98px; color: black;
                                    font-family: arial">
                                </td>
                            </tr>
                        </table>
                    </div>
                    <br />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

