<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000067.aspx.cs" Inherits="administrator_ebebaba_pages_0000067" Theme="SkinFile"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
               <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD 
style="WIDTH: 202px; HEIGHT: 24px" vAlign=middle> &nbsp;<asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Arial" Font-Bold="True" Text="Giden Kitap Mesaj Bilgisi"></asp:Label> 
</TD><TD style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle><asp:ImageButton id="Button1" onclick="Button1_Click1" runat="server" CausesValidation="False" ImageUrl="~/imgs/btngeridon.gif" ImageAlign="AbsMiddle"></asp:ImageButton> 
<asp:ImageButton id="Button2" onclick="Button2_Click1" runat="server" CausesValidation="False" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('Mesaj Silinecektir.Onaylýyormusunuz?')" ImageAlign="AbsMiddle"></asp:ImageButton>&nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
                <asp:Panel ID="Panel3" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                    <br />
                    &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><br />
                </asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt">
            <td valign="top">
                <div align="left">
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 16px">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 16px" valign="middle">
                            </td>
                            <td colspan="5" style="font-size: 11px; color: gray; font-family: verdana; height: 16px"
                                valign="middle">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 15px;">
                                &nbsp;</td>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 15px;" valign="middle">
                                <span style="color: black; font-family: Arial;">
                                                Alýcý : </span>
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 15px;" colspan="5" valign="middle">
                                <asp:Label ID="Label3" runat="server" ForeColor="Black" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label>
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<span style="font-family: Arial">
                                    &nbsp;</span><span
                                    style="color: black"><span style="font-family: Arial">Tarih :</span>
                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label>
                                        &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True"
                                            Font-Names="Arial" Font-Size="11px"></asp:Label></span></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 14px;">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: black; font-family: verdana; height: 14px;">
                            </td>
                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana; height: 14px;">
                            </td>
                            <td style="font-size: 11px; color: black; font-family: verdana; height: 14px;" colspan="2">
                            </td>
                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 14px;">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 15px;
                                text-align: right">
                            </td>
                            <td style="font-size: 11px; width: 92px; color: black; font-family: verdana; height: 15px"
                                valign="middle">
                                <span style="font-family: Arial">Email :</span></td>
                            <td colspan="5" style="font-size: 11px; color: gray; font-family: verdana; height: 15px"
                                valign="middle">
                                <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 15px;
                                text-align: right">
                            </td>
                            <td style="font-size: 11px; width: 92px; color: black; font-family: verdana; height: 15px"
                                valign="middle">
                            </td>
                            <td colspan="5" style="font-size: 11px; color: gray; font-family: verdana; height: 15px"
                                valign="middle">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; text-align: right; height: 15px;">
                            </td>
                            <td style="font-size: 11px; width: 92px; color: black; font-family: verdana; height: 15px;" valign="middle">
                                <span style="font-family: Arial">
                                Konu : </span>
                            </td>
                            <td colspan="5" style="font-size: 11px; color: gray; font-family: verdana; height: 15px;" valign="middle">
                                <asp:Label ID="Label4" runat="server" ForeColor="Navy" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 14px;">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: black; font-family: verdana; height: 14px;">
                            </td>
                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana; height: 14px;">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: black; font-family: verdana; height: 14px;">
                            </td>
                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 14px;">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; text-align: right; height: 15px;" valign="top">
                            </td>
                            <td style="font-size: 11px; width: 92px; color: black; font-family: verdana; height: 15px;" valign="middle">
                                <span style="font-family: Arial">
                                Mesaj : </span>
                            </td>
                            <td style="font-size: 11px; color: black; font-family: verdana; height: 15px;" colspan="5" valign="middle">
                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 15px;" colspan="7">
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>


</asp:Content>


