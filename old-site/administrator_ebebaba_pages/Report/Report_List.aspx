<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Report_List.aspx.cs" Inherits="administrator_ebebaba_pages_Report_Report_List" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Rapor Listesi</title>
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/css/default.css"
        rel="stylesheet" type="text/css" />
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
            border-top: #000000 1px solid; border-left: #000000 1px solid; width: 100%; border-bottom: #000000 1px solid">
            <tr>
                <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                    border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                    border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tbody>
                            <tr>
                                <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tbody>
                                            <tr>
                                                <td style="width: 202px; height: 24px; text-align: left;" valign="middle">
                                                    &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                        Font-Size="11px" Text="Ebebaba Rapor Listesi"></asp:Label><span style="font-size: 8pt;
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
                </td>
            </tr>
            <tr style="font-size: 12pt; font-family: Times New Roman">
                <td valign="top">
                    <div align="left">
                        <table cellpadding="0" cellspacing="0" style="overflow: hidden; clip: rect(10px 10px 10px 10px)"
                            width="100%">
                            <tr>
                                <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; height: 13px"
                                    valign="top">
                                    <table align="center" width="100%">
                                        <tr style="color: #000000">
                                            <td colspan="4" style="font-size: 11px; color: #000000; font-family: verdana; height: 49px;
                                                text-align: center">
                                                <br />
        <table style="border-right: darkgray 1px solid; border-top: darkgray 1px solid; border-left: darkgray 1px solid; border-bottom: darkgray 1px solid">
            <tr>
                <td style="width: 34px">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imgs/yazdir.gif" OnClick="ImageButton1_Click" /></td>
                <td style="width: 208px; text-align: left; font-weight: bold; font-size: 11px; color: navy; font-family: arial;">
                    Hasta Siklus Bilgileri Raporu</td>
            </tr>
        </table>
                                                <br />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
        </table>
        <br />
        <br />
    </form>
</body>
</html>

