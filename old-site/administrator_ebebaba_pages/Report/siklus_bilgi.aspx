<%@ Page Language="C#" AutoEventWireup="true"  Theme="SkinFile" CodeFile="siklus_bilgi.aspx.cs" Inherits="siklus_bilgi_admin" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
            border-top: #000000 1px solid; border-left: #000000 1px solid; width: 100%; border-bottom: #000000 1px solid">
            <tr>
                <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                    border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                    border-right-width: 1px; border-right-color: #d3d3d3; text-align: right;" valign="bottom">
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tbody>
                            <tr>
                                <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tbody>
                                            <tr>
                                                <td style="width: 202px; height: 24px; text-align: left" valign="middle">
                                                    &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                        Font-Size="11px" Text="Hasta Siklus Bilgileri Raporu"></asp:Label><span style="font-size: 8pt;
                                                            font-family: Arial"><strong> </strong></span>
                                                </td>
                                                <td style="font-weight: bold; font-size: 8pt; font-family: Arial; height: 24px; text-align: right"
                                                    valign="middle">
                                                    &nbsp;&nbsp;</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Names="Arial"
                        Font-Size="11px" OnClick="LinkButton1_Click">Rapor Listesi</asp:LinkButton>&nbsp;</td>
            </tr>
            <tr style="font-size: 12pt; font-family: Times New Roman">
                <td valign="top">
                    <div align="left">
                        <asp:Panel ID="panel_sonuc" runat="server" HorizontalAlign="Center" Visible="False"
                            Width="100%">
                            <br />
                            &nbsp;<asp:Label ID="sonuc2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                ForeColor="Black"></asp:Label><br />
                        </asp:Panel>
                        <br />
                        <table cellpadding="0" cellspacing="0" style="overflow: hidden; clip: rect(10px 10px 10px 10px)"
                            width="100%">
                            <tr>
                                <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; height: 13px"
                                    valign="top">
                                    <table align="center" width="100%">
                                        <tr style="color: #000000">
                                            <td colspan="4" style="font-size: 11px; color: #000000; font-family: verdana; height: 49px;
                                                text-align: left">
                                                <br />
                                                <table align="center" border="0" style="border-right: darkgray 1px solid; border-top: darkgray 1px solid;
                                                    border-left: darkgray 1px solid; width: 51%; border-bottom: darkgray 1px solid">
                                                    <tr>
                                                        <td style="width: 52px; height: 27px">
                                                        </td>
                                                        <td style="height: 27px">
                                                            Hasta</td>
                                                        <td style="height: 27px">
                                                            :</td>
                                                        <td style="height: 27px">
                                                            <asp:DropDownList ID="hasta_list" runat="server" AutoPostBack="True" BackColor="Transparent"
                                                                Font-Bold="False" Font-Names="verdana" Font-Size="11px" OnSelectedIndexChanged="hasta_list_SelectedIndexChanged">
                                                            </asp:DropDownList></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 52px; height: 27px">
                                                        </td>
                                                        <td style="height: 27px">
                                                            Siklus</td>
                                                        <td style="height: 27px">
                                                            :</td>
                                                        <td style="height: 27px">
                                                            <asp:DropDownList ID="siklus_list" runat="server" BackColor="Transparent" Font-Bold="False"
                                                                Font-Names="verdana" Font-Size="11px">
                                                            </asp:DropDownList></td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width: 52px; height: 27px">
                                                        </td>
                                                        <td style="height: 27px">
                                                        </td>
                                                        <td style="height: 27px">
                                                        </td>
                                                        <td style="height: 27px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Rapor Göster" SkinID="btn" /></td>
                                                    </tr>
                                                </table>
                                                <br />
                                                &nbsp;<br />
                                            </td>
                                        </tr>
                                    </table>
                                    <table border="0" style="width: 100%">
                                        <tr>
                                            <td>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table><br>
        <CR:CrystalReportViewer ID="raporum" runat="server" AutoDataBind="True" ClientTarget="Uplevel" DisplayGroupTree="False" HasCrystalLogo="False" HasToggleGroupTreeButton="False" HasViewList="False" HasZoomFactorList="False" Height="50px" ReuseParameterValuesOnRefresh="True" Width="350px" />
    </form>
</body>
</html>

