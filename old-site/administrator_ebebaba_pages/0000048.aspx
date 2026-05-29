<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000048.aspx.cs" Inherits="administrator_ebebaba_pages_0000048" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" width="95%">
        <tr>
            <td style="background-color: #ffffff">
                <asp:Panel ID="guncelle" runat="server" align="center" HorizontalAlign="Left" Visible="False"
                    Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
                        border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid"
                        width="100%">
                        <tr>
                            <td colspan="3">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tbody>
                                        <tr>
                                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                    <tbody>
                                                        <tr>
                                                            <td style="width: 202px; height: 24px" valign="middle">
                                                                &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                                                    Text="Kategori Adı Güncelleme"></asp:Label>
                                                            </td>
                                                            <td style="height: 24px; text-align: right" valign="middle">
                                                                &nbsp;&nbsp;
                                                                <asp:ImageButton ID="Button2" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnguncelle.gif"
                                                                    OnClick="Button2_Click1" ValidationGroup="gun" />&nbsp;</td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 179px; height: 25px; font-size: 11px; font-family: Tahoma;">
                                <span style="font-size: 11px; font-family: Verdana">&nbsp; <span style="font-family: Tahoma">
                                    ID : </span></span>
                            </td>
                            <td colspan="2" style="height: 24px;">
                                &nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Verdana" Font-Size="11px"></asp:Label></td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="width: 179px; height: 25px; font-size: 11px; font-family: Tahoma;">
                                <span style="font-size: 11px; font-family: Verdana">&nbsp; Kategori Adı<span style="font-family: Tahoma">
                                    : </span></span>
                            </td>
                            <td colspan="2" style="height: 25px;">
                                &nbsp;<asp:TextBox ID="alanadi2" runat="server" SkinID="txtNormal" ValidationGroup="gun" MaxLength="40"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="alanadi2"
                                        Display="Dynamic" ErrorMessage="Kategori Adı Boş Geçilemez !" SetFocusOnError="True" Font-Names="Tahoma" Font-Size="11px" ValidationGroup="gun"></asp:RequiredFieldValidator>
                                    </td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="width: 179px; height: 25px; font-size: 11px; font-family: Tahoma;">
                                <span style="font-size: 8pt"><span style="font-family: Verdana">&nbsp; Yayınlansın mı?
                                </span><span style="font-family: Tahoma">: </span></span>
                            </td>
                            <td colspan="2" style="height: 16px;">
                                <asp:CheckBox ID="yayin" runat="server" /></td>
                        </tr>
                    </table>
                    <br />
                </asp:Panel>
            </td>
        </tr>
    </table>
    <table align="center" style="width: 95%" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td style="background-color: #ffffff;">
            </td>
        </tr>
    </table>
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
        border-top: #000000 1px solid; border-left: #000000 1px solid; width: 95%; border-bottom: #000000 1px solid">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                border-right-width: 1px; border-right-color: #d3d3d3; text-align: left;" valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tbody>
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px; text-align: left;" valign="middle">
                                                &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Tahoma"
                                                    Font-Size="11px" Text="Kitap Kategorileri"></asp:Label>
                                            </td>
                                            <td style="font-size: 12pt; height: 24px; text-align: right" valign="middle">
                                                &nbsp; &nbsp;
                                                <asp:ImageButton ID="Button1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif"
                                                    OnClick="Button1_Click" ValidationGroup="kyd" />&nbsp;</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <span style="font-size: 11px; font-family: Tahoma"><strong>
                    <asp:Panel ID="panel_sonuc" runat="server" HorizontalAlign="Center" Visible="False"
                        Width="100%">
                        <br />
                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label>&nbsp;<br />
                    </asp:Panel>
                    <table style="width: 100%">
                        <tr>
                            <td style="text-align: left">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="font-weight: normal; width: 178px; height: 16px">
                                        </td>
                                        <td colspan="2" style="height: 16px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 178px">
                                İşlem Yapmak İstediğiniz Kitap :&nbsp;</td>
                                        <td colspan="2">
                                            <asp:DropDownList ID="kitaplist" runat="server"
                                    AutoPostBack="True" OnSelectedIndexChanged="kitaplist_SelectedIndexChanged" SkinID="drop"
                                    ValidationGroup="kyd">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="kitaplist"
                                    Display="Dynamic" ErrorMessage="Kitap Seçilmedi !" Font-Names="Tahoma" Font-Size="11px"
                                    SetFocusOnError="True" ValidationGroup="kyd" Font-Bold="False"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 178px">
                                Seçili Kitaba
                                Yeni Kategori Adı Ekle :&nbsp; 
                                        </td>
                                        <td colspan="2">
                                <asp:TextBox ID="alanadi1" runat="server" SkinID="txtNormal" ValidationGroup="kyd" MaxLength="40"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic"
                                        ErrorMessage="Kategori Adı Boş Geçilemez" SetFocusOnError="True" ControlToValidate="alanadi1" Font-Names="Tahoma" Font-Size="11px" ValidationGroup="kyd" Font-Bold="False"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 178px; height: 16px">
                                        </td>
                                        <td colspan="2" style="height: 16px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3" style="height: 21px">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                    ForeColor="Navy"></asp:Label></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </strong></span>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <div align="left" style="text-align: left">
                    <asp:GridView ID="list" runat="server" AutoGenerateColumns="False" BorderColor="White"
                        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Font-Size="11px" ForeColor="#333333"
                        PageSize="20" Width="100%" Height="76px" CaptionAlign="Left">
                        <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="Kategori Adi">
                                <ItemTemplate>
                                    <asp:LinkButton ID="kat_adi" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                        Font-Underline="False" OnCommand="kat_adi_Command"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="tarih" HeaderText="Eklenme Tarihi" />
                            <asp:TemplateField HeaderText="Sıralama">
                                <ItemTemplate>
                                    <table style="width: 100%" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td style="width: 100px">
                                                <asp:ImageButton ID="ust" runat="server" AlternateText="Bir Üste Taşı" ImageUrl="~/administrator_ebebaba_pages/images/ust.gif"
                                                    OnCommand="ust_Command" /></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 100px">
                                                <asp:ImageButton ID="alt" runat="server" AlternateText="Bir Alta Taşı" ImageUrl="~/administrator_ebebaba_pages/images/alt.gif"
                                                    OnCommand="alt_Command" /></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Yayın">
                                <ItemTemplate>
                                    <asp:LinkButton ID="goster" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="12px"
                                        Font-Underline="False" OnCommand="goster_Command"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="İşlemler">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ad_guncelle" runat="server" ImageUrl="~/imgs/btnguncelle.gif"
                                        OnCommand="ad_guncelle_Command" />
                                    <asp:ImageButton ID="sil" runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('Kitap Kategorisini Silmek İstediğinize Emin Misiniz?')"
                                        OnCommand="sil_Command" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            Font-Names="Tahoma" ForeColor="#333333" Font-Size="11px" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="Silver" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="Gainsboro" BorderStyle="Double" BorderWidth="1px" Font-Bold="True"
                            Font-Names="Tahoma" Font-Size="11px" ForeColor="Black" HorizontalAlign="Left" />
                        <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            ForeColor="#404040" />
                    </asp:GridView>
                    &nbsp;</div>
            </td>
        </tr>
    </table>
    <br />
</asp:Content>


