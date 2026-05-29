<%@ Page Language="C#"  MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ivfyonetici_hasta_modulu_Default" EnableEventValidation="false" ValidateRequest="false"%>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    
    <script language=javascript>
    
    
    
    function expnd(gelen)
    {
        
    alert(gelen);
    
    }


    </script>

    <asp:ScriptManager id="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    
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
                                <table border="0" cellpadding="1" cellspacing="1" style="width: 100%" background="images/ust_menu_bg.jpg">
                                    <tr>
                                        <td style="height: 22px">
                                            &nbsp;<asp:Label ID="infertilite_alan" runat="server" Font-Bold="True" Font-Names="Arial"
                                                Font-Size="12px">Plan</asp:Label>
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
                                    <asp:Label ID="lbltarih" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <br />
                                    <asp:Label ID="lblkategori" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
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
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 1px solid;
        border-top: black 1px solid; border-left: black 1px solid; width: 95%; border-bottom: black 1px solid">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td style="border-top-width: 1px; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                            border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="middle">
                            <asp:Panel ID="Panel1" runat="server" Direction="LeftToRight" Width="100%">
                                <table border="0" cellpadding="1" cellspacing="1" style="width: 100%" background="images/ust_menu_bg.jpg">
                                    <tr>
                                        <td style="height: 22px">
                                            &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12px">Tedavi</asp:Label>
                                            <asp:Label ID="say2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12px"></asp:Label></td>
                                        <td style="height: 22px; text-align: right" valign="middle">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="panel_sonuc2" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; border-left-width: 1px;
                        border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                        width: 100%; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <asp:Label ID="sonuc2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td id="Td1" style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="top">
                <asp:DataList ID="inferbilgi2" runat="server" BorderWidth="0px" CellPadding="2" CellSpacing="2"
                    RepeatColumns="1" Width="100%">
                    <ItemTemplate>
                        <table border="0" cellpadding="3" cellspacing="0" style="border-right: gainsboro 1px solid;
                            border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid"
                            width="100%">
                            <tr>
                                <td bordercolordark="#ffffff" style="border-right: lightgrey 1px solid" valign="top"
                                    width="110">
                                    <asp:Label ID="lbltarih2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <br />
                                    <asp:Label ID="lblkategori2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <br />
                                    <asp:Label ID="lblsiklus2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                <td colspan="2" valign="top">
                                    <asp:Label ID="lblmesaj2" runat="server" Font-Names="Arial" Font-Size="12px"></asp:Label>&nbsp;
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
                                                <asp:Label ID="ektarih2" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                <span style="font-size: 11px; font-family: Arial">&nbsp;<span style="color: black">
                                                    |</span> &nbsp; &nbsp; Kaydeden :&nbsp; </span>
                                                <asp:Label ID="ekleyen2" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
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
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 1px solid;
        border-top: black 1px solid; border-left: black 1px solid; width: 95%; border-bottom: black 1px solid">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td style="border-top-width: 1px; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                            border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="middle">
                            <asp:Panel ID="Panel2" runat="server" Direction="LeftToRight" Width="100%">
                                <table border="0" cellpadding="1" cellspacing="1" style="width: 100%" background="images/ust_menu_bg.jpg">
                                    <tr>
                                        <td style="height: 22px">
                                            &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12px">Özet</asp:Label>
                                            <asp:Label ID="say3" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="12px"></asp:Label></td>
                                        <td style="height: 22px; text-align: right" valign="middle">
                                            &nbsp;</td>
                                    </tr>
                                </table>
                            </asp:Panel>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="Panel3" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; border-left-width: 1px;
                        border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                        width: 100%; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td id="Td2" style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="top">
                <asp:UpdateProgress id="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1"
                    DisplayAfter="10">
                    <progresstemplate>
<asp:Image id="Image1" runat="server" ImageUrl="~/yukleniyor.gif" ImageAlign="AbsMiddle"></asp:Image><SPAN style="FONT-SIZE: 11px; FONT-FAMILY: Arial">Yükleniyor...</SPAN> 
</progresstemplate>
                </asp:UpdateProgress>
                <asp:UpdatePanel id="UpdatePanel1" runat="server"><contenttemplate>
<asp:DataList id="ozet" runat="server" Width="100%" RepeatColumns="1" CellSpacing="2" CellPadding="2" BorderWidth="0px">
<ItemStyle Wrap="True" BorderColor="Gainsboro"></ItemStyle>

<SeparatorStyle BackColor="Olive"></SeparatorStyle>
<ItemTemplate>
<TABLE style="BORDER-RIGHT: gainsboro 1px solid; BORDER-TOP: gainsboro 1px solid; BORDER-LEFT: gainsboro 1px solid; BORDER-BOTTOM: gainsboro 1px solid" borderColor=gainsboro cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="BORDER-RIGHT: lightgrey 1px solid" vAlign=top width=110 borderColorDark=#ffffff rowSpan=3>&nbsp;<asp:ImageButton 
        id="acik" runat="server" ImageUrl="~/ac.gif" OnCommand="acik_Command1" 
        __designer:wfdid="w8"></asp:ImageButton><asp:ImageButton id="kapali" 
        runat="server" ImageUrl="~/kapat.gif" Visible="False" 
        OnCommand="kapali_Command" __designer:wfdid="w9"></asp:ImageButton>&nbsp; <asp:LinkButton id="lblsiklus3" runat="server" ForeColor="#000000" Font-Size="11px" Font-Names="Arial" Font-Bold="True" __designer:wfdid="w21"></asp:LinkButton><BR /><asp:Label id="Label3" runat="server" Visible="False" __designer:wfdid="w11"></asp:Label></TD>
    <TD style="FONT-SIZE: 12pt; FONT-FAMILY: Times New Roman" vAlign=top><TABLE style="BORDER-TOP-WIDTH: 1px; BORDER-LEFT-WIDTH: 1px; BORDER-LEFT-COLOR: black; BORDER-BOTTOM-WIDTH: 1px; BORDER-BOTTOM-COLOR: black; BORDER-TOP-COLOR: black; BORDER-RIGHT-WIDTH: 1px; BORDER-RIGHT-COLOR: black" cellSpacing=0 cellPadding=2 width="100%"><TBODY><TR><TD style="BORDER-RIGHT: gainsboro 1px solid" vAlign=top width="30%" rowSpan=1><asp:Label id="lblmesaj1" runat="server" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w12"></asp:Label>&nbsp;<SPAN style="FONT-SIZE: 8pt"></SPAN></TD><TD style="BORDER-RIGHT: gainsboro 1px solid; FONT-SIZE: 8pt" vAlign=top width="35%"><asp:Label id="lblmesaj2" runat="server" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w13"></asp:Label>&nbsp;</TD><TD style="FONT-SIZE: 12pt" vAlign=top width="35%"><asp:Label id="lblmesaj3" runat="server" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w14"></asp:Label>&nbsp;</TD></TR></TBODY></TABLE><SPAN style="FONT-SIZE: 8pt; FONT-FAMILY: Arial"></SPAN></TD></TR><TR style="FONT-SIZE: 8pt; FONT-FAMILY: Arial">
    <TD style="BORDER-TOP: gainsboro 1px solid; TEXT-ALIGN: left" vAlign=top><asp:Panel id="ayr" runat="server" Width="100%" Visible="False" __designer:wfdid="w15"><TABLE style="BORDER-TOP-WIDTH: 1px; BORDER-LEFT-WIDTH: 1px; BORDER-LEFT-COLOR: gainsboro; BORDER-BOTTOM-WIDTH: 1px; BORDER-BOTTOM-COLOR: gainsboro; BORDER-TOP-COLOR: gainsboro; BORDER-RIGHT-WIDTH: 1px; BORDER-RIGHT-COLOR: gainsboro" cellSpacing=0 cellPadding=2 width="100%"><TBODY><TR><TD style="BORDER-RIGHT: gainsboro 1px solid" vAlign=top width="30%"><asp:Label id="lblmesaj4" runat="server" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w16"></asp:Label>&nbsp;</TD><TD style="BORDER-TOP-WIDTH: 1px; BORDER-RIGHT: gainsboro 1px solid; BORDER-LEFT-WIDTH: 1px; BORDER-LEFT-COLOR: gainsboro; BORDER-BOTTOM-WIDTH: 1px; BORDER-BOTTOM-COLOR: gainsboro; BORDER-TOP-COLOR: gainsboro" vAlign=top width="35%"><asp:Label id="lblmesaj5" runat="server" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w17"></asp:Label>&nbsp;</TD><TD vAlign=top width="35%"><asp:Label id="lblmesaj6" runat="server" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w18"></asp:Label>&nbsp;</TD></TR></TBODY></TABLE><TABLE style="BORDER-TOP: gainsboro 1px solid; WIDTH: 100%" cellSpacing=0 cellPadding=0 border=0><TBODY><TR><TD style="HEIGHT: 23px; BACKGROUND-COLOR: ghostwhite; TEXT-ALIGN: right" vAlign=middle colSpan=2><SPAN style="FONT-SIZE: 11px"></SPAN>&nbsp;Siklus Kayýt Tarihi : <asp:Label id="ektarih3" runat="server" ForeColor="DimGray" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w19"></asp:Label> <SPAN style="FONT-SIZE: 11px">&nbsp;<SPAN style="COLOR: black"> |</SPAN> &nbsp; &nbsp; Siklusu Kaydeden :&nbsp;</SPAN><asp:Label id="ekleyen3" runat="server" ForeColor="DimGray" Font-Size="11px" Font-Names="Arial" __designer:wfdid="w20"></asp:Label>&nbsp;</TD></TR></TBODY></TABLE></asp:Panel></TD></TR></TBODY></TABLE>
</ItemTemplate>
</asp:DataList> 
</contenttemplate>
                </asp:UpdatePanel></td>
        </tr>
    </table>
    <br />
</asp:Content>



