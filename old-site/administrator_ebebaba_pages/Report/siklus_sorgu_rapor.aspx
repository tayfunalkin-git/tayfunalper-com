<%@ Page Language="C#" AutoEventWireup="true"  Theme="SkinFile" CodeFile="siklus_sorgu_rapor.aspx.cs" Inherits="rapor_siklusum" %>

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
 </head>
<body>
    <form id="form1" runat="server">
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
            border-top: #000000 1px solid; border-left: #000000 1px solid; width: 100%; border-bottom: #000000 1px solid">
            <tr>
                <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                    border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                    border-right-width: 1px; border-right-color: #d3d3d3; text-align: right;" valign="top">
                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                        <tbody>
                            <tr>
                                <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tbody>
                                            <tr>
                                                <td style="width: 487px; height: 24px; text-align: left" valign="middle">
                                                    &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                        Font-Size="11px" Text="Hasta Siklus Bilgileri Raporu - Rapor Önizleme"></asp:Label><span style="font-size: 8pt;
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
                    &nbsp;</td>
            </tr>
            <tr style="font-size: 12pt; font-family: Times New Roman">
                <td>
                    <br />
                    <table  align="center" border="0" width="700">
                        <tr>
                            <td>
        <CR:CrystalReportViewer ID="raporum" runat="server" DisplayGroupTree="False" HasCrystalLogo="False" HasToggleGroupTreeButton="False" HasZoomFactorList="False" Height="50px" ShowAllPageIds="True" Width="350px" AutoDataBind="True" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" HasViewList="False"/>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>

