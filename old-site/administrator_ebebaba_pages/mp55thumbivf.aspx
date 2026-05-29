<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mp55thumbivf.aspx.cs" Inherits="ivfyonetici_mp55thumb"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 323px;
        }
        .auto-style2 {
            width: 153px;
        }
        .auto-style3 {
            width: 153px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
        .auto-style5 {
            width: 153px;
            height: 24px;
        }
        .auto-style6 {
            height: 24px;
        }
        .auto-style7 {
            height: 25px;
            width: 8px;
        }
        .auto-style8 {
            height: 24px;
            width: 8px;
        }
        .auto-style9 {
            width: 8px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial"></asp:Label>
&nbsp;
    
        <br />
    
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" style="font-size: 12px; color: #FF0000"></asp:Label>
&nbsp;
        <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <table cellpadding="2" class="auto-style1">
            <tr>
                <td class="auto-style3" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Siklus Dr</td>
                <td class="auto-style7" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style4" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:DropDownList ID="siklusDr" runat="server" SkinID="drop">
                    </asp:DropDownList>
                &nbsp;<asp:Label ID="lblSiklusDr" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Dış Dr</td>
                <td class="auto-style7" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style4" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:DropDownList ID="disDr" runat="server" SkinID="drop">
                    </asp:DropDownList>
                    <asp:Label ID="lblDisDr" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Çalışma Protokol Kodu</td>
                <td class="auto-style7" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style4" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:TextBox ID="txtCp" runat="server" Height="20px" SkinID="txtsiklus"></asp:TextBox>
                    <asp:Label ID="lblCp" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Başlama Tarihi</td>
                <td class="auto-style7" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style4" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:TextBox ID="txtBat" runat="server" Height="20px" ></asp:TextBox>
                    <asp:Label ID="lblBat" runat="server" Visible="False"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                                                        runat="server" ControlToValidate="txtBat" Display="Dynamic" 
                                                        ErrorMessage="Format : 01.01.2014" Font-Bold="True" Font-Names="Arial" 
                                                        Font-Size="11px" SetFocusOnError="True" 
                                                        ValidationExpression="(\d\d.\d\d.\d\d\d\d)" Width="111px"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Bitiş Tarihi</td>
                <td class="auto-style7" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style4" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:TextBox ID="txtBit" runat="server" Height="20px" ></asp:TextBox>
                    <asp:Label ID="lblBit" runat="server" Visible="False"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
                                                        runat="server" ControlToValidate="txtBit" Display="Dynamic" 
                                                        ErrorMessage="Format : 01.01.2014" Font-Bold="True" Font-Names="Arial" 
                                                        Font-Size="11px" SetFocusOnError="True" 
                                                        ValidationExpression="(\d\d.\d\d.\d\d\d\d)" Width="111px"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Kayıt Tarihi</td>
                <td class="auto-style8" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style6" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:TextBox ID="txtKt" runat="server" Height="20px" ></asp:TextBox>
                    <asp:Label ID="lblKt" runat="server" Visible="False"></asp:Label>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
                                                        runat="server" ControlToValidate="txtKt" Display="Dynamic" 
                                                        ErrorMessage="Format : 01.01.2014" Font-Bold="True" Font-Names="Arial" 
                                                        Font-Size="11px" SetFocusOnError="True" 
                                                        ValidationExpression="(\d\d.\d\d.\d\d\d\d)" Width="111px"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">Değer</td>
                <td class="auto-style8" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">:</td>
                <td class="auto-style6" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:TextBox ID="txtDeger" runat="server" Height="20px" >0</asp:TextBox>
                    <asp:Label ID="lblDeger" runat="server" Visible="False"></asp:Label>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtDeger" Display="Dynamic" ErrorMessage="Sayısal Değer Giriniz!" MaximumValue="15000" MinimumValue="0" SetFocusOnError="True" style="font-weight: 700" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">&nbsp;</td>
                <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">&nbsp;</td>
                <td style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:Button ID="Button1" runat="server" Text="Kaydet &amp; Güncelle" Width="157px" BackColor="#FFFF99" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Height="30px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    <asp:Button ID="Button2" runat="server" Text="Kapat" Width="91px" BackColor="Aqua" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Height="30px" OnClick="Button1_Click" OnClientClick="window.close();" Visible="False" />
                </td>
                <td class="auto-style9" style="font-family: arial, Helvetica, sans-serif; font-size: 12px">&nbsp;</td>
                <td style="font-family: arial, Helvetica, sans-serif; font-size: 12px">
                    &nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="Label4" runat="server" Font-Names="Arial" Font-Size="13px" style="font-weight: 700"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
