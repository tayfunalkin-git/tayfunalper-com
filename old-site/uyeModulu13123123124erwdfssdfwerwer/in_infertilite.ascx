<%@ Control Language="C#" AutoEventWireup="true" CodeFile="in_infertilite.ascx.cs" Inherits="ivfyonetici_hasta_modulu_in_infertilite" %>
<table border="0" cellpadding="1" cellspacing="1" style="border-top-width: 1px; border-left-width: 1px;
    border-left-color: lightgrey; border-bottom-width: 1px; border-bottom-color: lightgrey;
    width: 100%; border-top-color: lightgrey; border-right-width: 1px; border-right-color: lightgrey">
    <tr>
        <td>
            <table cellpadding="0" cellspacing="0" style="width: 100%">
                <tr>
                    <td style="height: 40px">
                        <table cellpadding="0" cellspacing="0" style="width: 100%">
                            <tr>
                                <td colspan="2" height="40" valign="middle">
                                    <table cellpadding="3" cellspacing="0" style="border-top: black 1px solid; border-left: black 1px solid;
                                        width: 100%; border-bottom: black 1px solid">
                                        <tr>
                                            <td style="height: 54px; text-align: center; border-right-width: 1px; border-right-color: black">
                                                <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="False" Font-Names="Arial"
                                                    Font-Size="11px" Font-Underline="False" ForeColor="Black" OnCommand="LinkButton3_Command"></asp:LinkButton>
                                                <br />
                                                <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                        </tr>
                                    </table>
                                </td>
                                <td style="height: 40px" valign="middle">
                                    <asp:DataList ID="inferlist" runat="server" BackColor="Black" BorderColor="Black"
                                        BorderStyle="Solid" BorderWidth="1px" CellPadding="0" GridLines="Vertical" Height="42px"
                                        RepeatDirection="Horizontal" Width="100%">
                                        <ItemTemplate>
                                            <table id="tablom" runat="Server" border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                                                <tr>
                                                    <td colspan="2" style="text-align: center; border-bottom: black 1px solid;" valign="top">
                                                        <br />
                                                        &nbsp;<asp:LinkButton ID="inferadi" runat="server" Font-Bold="False" Font-Names="Arial"
                                                            Font-Size="11px" Font-Underline="False" ForeColor="#000000"></asp:LinkButton><br />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" style="text-align: center" valign="bottom">
                                                        <asp:Panel ID="infrrenk" runat="server" Height="21px" Width="100%">
                                                            <asp:Label ID="sayi" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Black"></asp:Label></asp:Panel>
                                                    </td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                                        <SelectedItemStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                                        <ItemStyle BackColor="White" BorderColor="Black" ForeColor="#003399" />
                                        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                                        <SeparatorStyle BorderColor="Black" />
                                    </asp:DataList></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>

<br />
<%if (Request.QueryString["infertilite_kategori_id"] != null && Request.QueryString["siklus_id"] != null)
      { %> 

<div style="text-align: center">
    <table border="0" cellpadding="0" cellspacing="0" style="width:96%">
        <tr>
            <td style="text-align: left">
            
            <asp:Panel ID="infer" runat="server"  Visible="False" Width="99%" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px;
        border-left-width: 1px; border-left-color: #dcdcdc; border-bottom-width: 1px;
        border-bottom-color: #dcdcdc; border-top-color: #dcdcdc; border-right-width: 1px;
        border-right-color: #dcdcdc" width="100%">
                        <tr>
                            <td style="border-top-width: 1px;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%" align=center>
                                    <tr>
                                        <td style="border-bottom-width: 1px; border-bottom-color: #d3d3d3; height: 22px; font-size: 12pt; font-family: Times New Roman; border-top-width: 1px; border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="top">
                                            <asp:Panel ID="infertilite_ana_panel" runat="server" Width="100%">
                                                <table border="0" cellpadding="1" cellspacing="1" style="width: 100%">
                                                    <tr>
                                                        <td style="height: 22px;">
                                                            &nbsp;<asp:Label ID="infertilite_alan" runat="server" Font-Bold="True" Font-Names="Arial"
                                    Font-Size="11px"></asp:Label>&nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True"
                                        Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                            <td style="text-align: right; height: 22px; font-size: 12pt; font-family: Times New Roman;">
                                <asp:DropDownList ID="infertilite_renk" runat="server" BackColor="Transparent" Font-Bold="False"
                                    Font-Names="verdana" Font-Size="11px" AutoPostBack="True" 
                                    OnSelectedIndexChanged="infertilite_renk_SelectedIndexChanged" 
                                    ValidationGroup="yn" SkinID="drop" Visible="False">
                                </asp:DropDownList>&nbsp;<asp:ImageButton ID="Button7" runat="server" ImageAlign="AbsMiddle"
                                    ImageUrl="~/imgs/btnekle.gif" OnClick="Button7_Click1" Visible="False" />

                                <img align="absMiddle" onclick="window.open('renk_guncelleme_bilgi.aspx?infertilite_kategori_id=<%=Request.QueryString["infertilite_kategori_id"]%>&siklus_id=<%=Request.QueryString["siklus_id"] %>','','width=460,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')"
                                    src="images/guncelleyenler.gif" style="cursor: hand" /></td>
                        </tr>
                    </table>
                </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                            
                            
                            
                            
                            
                            
                            
                            
                            
                                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                                    &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    ForeColor="Black"></asp:Label></asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top" id="yeni_kayit">
                <asp:DataList ID="inferbilgi" runat="server" BorderWidth="0px" CellPadding="2" CellSpacing="2"
                    RepeatColumns="1" Width="100%">
                    <ItemTemplate>
                        <table border="0" cellpadding="3" cellspacing="0" style="border-right: gainsboro 1px solid;
                            border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid"
                            width="100%">
                            <tr>
                                <td bordercolordark="#ffffff" style="border-right: lightgrey 1px solid" valign="top"
                                    width="115">
                                    <asp:Label ID="lbltarih" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <br />
                                    <asp:Label ID="lblkategori" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                <td valign="top">
                                    <asp:Label ID="lblmesaj" runat="server" Font-Names="Arial" Font-Size="12px"></asp:Label>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td bordercolordark="#ffffff" style="border-right: lightgrey 1px solid" valign="top"
                                    width="115">
                                    &nbsp;</td>
                                <td bgcolor="ghostwhite" style="border-top: gainsboro 1px solid; text-align: right"
                                    valign="top">
                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tr>
                                            <td style="text-align: left">
                                                <span style="font-size: 11px; font-family: Arial">Kayıt Tarihi : </span>
                                                <asp:Label ID="ektarih" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                <span style="font-size: 11px; font-family: Arial">&nbsp;<span style="color: black">
                                                    |</span> &nbsp; &nbsp; Kaydeden :&nbsp; </span>
                                                <asp:Label ID="ekleyen" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                &nbsp;&nbsp;<span style="font-size: 8pt; cursor:hand; font-family: Arial"> | &nbsp; </span><a
                                                     onclick="window.open('infertilite_guncelleme_bilgi.aspx?ID=<%#DataBinder.Eval(Container.DataItem , "kayit_id")%>','','width=500,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')">
                                                    <span style="font-size: 8pt; cursor:hand; font-family : Arial;">Güncelleyenler</span></a></td>
                                            <td style="text-align: right">
                                                <asp:ImageButton ID="guncelle" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnguncelle.gif"
                                                    OnCommand="guncelle_Command" Visible="False" />&nbsp;<asp:ImageButton 
                                                    ID="sil" runat="server" ImageAlign="AbsMiddle"
                                                        ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('İnfertilite Kaydı Kalıcı Olarak Silinecektir.Onaylıyormusunuz?')"
                                                        OnCommand="sil_Command" Visible="False" /></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <ItemStyle Wrap="True" />
                    <SeparatorStyle BackColor="Olive" />
                </asp:DataList></td>
        </tr>
    </table>
                    </asp:Panel></td>
        </tr>
    </table>
</div>
                    
                    <%} %>