<%@ Page Language="C#"  MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" AutoEventWireup="true" CodeFile="kronolojik_infertilite.aspx.cs" Inherits="ivfyonetici_hasta_modulu_kro" EnableEventValidation="false" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 1px solid;
        border-top: black 1px solid; border-left: black 1px solid; width: 95%; border-bottom: black 1px solid">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td style="border-top-width: 1px; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                            border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;
                            height: 22px" valign="middle">
                            <asp:Panel ID="infertilite_ana_panel" runat="server" Direction="LeftToRight" Width="100%">
                                <table border="0" cellpadding="1" cellspacing="1" style="width: 100%" background="../uyeModulu/images/ust_menu_bg.jpg">
                                    <tr>
                                        <td style="height: 22px">
                                            &nbsp;<asp:Label ID="infertilite_alan" runat="server" Font-Bold="True" Font-Names="Arial"
                                                Font-Size="12px">Ýnfertilite Bilgileri (Kronolojik Sýralama)</asp:Label>
                                            <asp:Label ID="say" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12px"></asp:Label></td>
                                        <td style="height: 22px; text-align: right" valign="middle">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; border-left-width: 1px;
                        border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                        width: 100%; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td id="yeni_kayit" style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="top">
                <asp:DataList ID="inferbilgi" runat="server" BorderWidth="0px" CellPadding="2" CellSpacing="2"
                    RepeatColumns="1" Width="100%">
                    <ItemTemplate>
                        <table border="0" cellpadding="3" cellspacing="0" style="border-right: gainsboro 1px solid;
                            border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid"
                            width="100%">
                            <tr>
                                <td bordercolordark="#ffffff" style="border-right: lightgrey 1px solid" valign="top"
                                    width="110">
                                    <asp:Label ID="lbltarih" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="lblalan" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <asp:Label ID="lblkategori" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label>
                                    <br />
                                    <br />
                                    <asp:Label ID="lblsiklus" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                <td colspan="2" valign="top">
                                    <asp:Label ID="lblmesaj" runat="server" Font-Names="Arial" Font-Size="12px"></asp:Label>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td bordercolordark="#ffffff" style="border-right: lightgrey 1px solid" valign="top"
                                    width="110">
                                    &nbsp;</td>
                                <td bgcolor="ghostwhite" colspan="2" style="border-top: gainsboro 1px solid; text-align: right"
                                    valign="top">
                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tr>
                                            <td style="text-align: left">
                                                <span style="font-size: 11px; font-family: Arial">Kayýt Tarihi : </span>
                                                <asp:Label ID="ektarih" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                <span style="font-size: 11px; font-family: Arial">&nbsp;<span style="color: black">
                                                    |</span> &nbsp; &nbsp; Kaydeden :&nbsp; </span>
                                                <asp:Label ID="ekleyen" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                <span style="font-size: 11px; cursor: hand; font-family: Arial">&nbsp; | &nbsp; &nbsp;
                                                    <a onclick="window.open('infertilite_guncelleme_bilgi.aspx?ID=<%#DataBinder.Eval(Container.DataItem ,"kayit_id")%>','','width=500,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')">
                                                        Güncelleyenler</a></span></td>
                                            <td style="text-align: right">
                                                &nbsp;&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <ItemStyle Wrap="True" />
                    <SeparatorStyle BackColor="Olive" />
                </asp:DataList>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>



