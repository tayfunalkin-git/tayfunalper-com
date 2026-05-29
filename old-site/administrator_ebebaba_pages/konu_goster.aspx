<%@ Page Language="C#" AutoEventWireup="true" CodeFile="konu_goster.aspx.cs" Inherits="konu_goster2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table border="0" cellpadding="0" cellspacing="0" style="border-right: #d3d3d3 1px solid;
            border-top: #d3d3d3 1px solid; border-left: #d3d3d3 1px solid; width: 100%; border-bottom: #d3d3d3 1px solid">
            <tr>
                <td style="height: 23px; background-color: #f5f5f5; text-align: left">
                    &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                        ForeColor="Gray"></asp:Label></td>
            </tr>
        </table>
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td style="font-size: 11px; color: black; font-family: verdana; height: 33px;
                    text-decoration: none" colspan="3">
                    <br />
                    &nbsp;<asp:Label ID="eklenmetarihi" runat="server" Font-Bold="False" Font-Names="Tahoma" Font-Size="11px" ForeColor="Gray"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2" style="font-size: 11px; color: black; font-family: verdana; text-decoration: none">
                    &nbsp;</td>
                <td style="font-size: 11px; color: black; font-family: verdana; text-decoration: none">
                </td>
            </tr>
            <tr>
                <td colspan="3" style="font-size: 11px; color: black; font-family: verdana; text-align: center;
                    text-decoration: none; height: 14px;">
                    <span style="color: #0000ff; text-decoration: underline; font-family: Tahoma;"><a href="javascript:window.close();">KAPAT</a></span></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>

