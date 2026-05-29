<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000050.aspx.cs" Inherits="administrator_ebebaba_pages_0000050" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
        border-top: #000000 1px solid; border-left: #000000 1px solid; width: 95%; border-bottom: #000000 1px solid">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                border-right-width: 1px; border-right-color: #d3d3d3; text-align: center;" valign="top">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tbody>
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px; text-align: left;" valign="middle">
                                                &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Tahoma"
                                                    Font-Size="11px" Text="Kitap Konularý"></asp:Label>
                                            </td>
                                            <td style="font-size: 12pt; height: 24px; text-align: right" valign="middle">
                                                &nbsp; &nbsp; &nbsp;</td>
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
                            <td style="text-align: left" valign="top">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="font-weight: normal; width: 178px; height: 16px">
                                        </td>
                                        <td colspan="2" style="height: 16px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 178px">
                                            Ýþlem Yapmak Ýstediðiniz Kitap :&nbsp;</td>
                                        <td colspan="2">
                                            &nbsp;<asp:DropDownList ID="kitaplist" runat="server" AutoPostBack="True"
                                                BackColor="Transparent" Font-Bold="False" Font-Names="verdana" Font-Size="11px"
                                                OnSelectedIndexChanged="kitaplist_SelectedIndexChanged" SkinID="drop" ValidationGroup="ynm">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="kitaplist"
                                                Display="Dynamic" ErrorMessage="Kitap Seçilmedi !" Font-Bold="False" Font-Names="Tahoma"
                                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 178px">
                                            Seçili Kitaba Ait Kategoriler :&nbsp;
                                        </td>
                                        <td colspan="2">
                                            &nbsp;<asp:DropDownList ID="kategorilist" runat="server"
                                                AutoPostBack="True" BackColor="Transparent" Enabled="False" Font-Bold="False"
                                                Font-Names="verdana" Font-Size="11px" OnSelectedIndexChanged="kategorilist_SelectedIndexChanged"
                                                SkinID="drop" ValidationGroup="ynm">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="kategorilist"
                                                Display="Dynamic" ErrorMessage="Kategori Seçilmedi !" Font-Bold="False" Font-Names="Tahoma"
                                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"></asp:RequiredFieldValidator></td>
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
                <asp:GridView ID="konu_listesi" runat="server" AutoGenerateColumns="False" BorderColor="White"
                    BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Font-Size="11px" ForeColor="#333333"
                    PageSize="1" Width="100%" Font-Names="Tahoma" EnableModelValidation="True">
                    <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                    <Columns>
                        <asp:BoundField DataField="konu" HeaderText="Konu Adý">
                            <ItemStyle Width="180px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="tarih" HeaderText="Tarih" />
                        <asp:TemplateField HeaderText="Sýralama">
                            <ItemStyle Width="150px" />
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="ust" runat="server" AlternateText="Bir Üste Taþý" ImageUrl="~/administrator_ebebaba_pages/images/ust.gif"
                                                OnCommand="ust_Command" /></td>
                                    </tr>
                                    <tr>
                                        <td style="width: 100px">
                                            <asp:ImageButton ID="alt" runat="server" AlternateText="Bir Alta Taþý" ImageUrl="~/administrator_ebebaba_pages/images/alt.gif"
                                                OnCommand="alt_Command" /></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="A&#231;ýlýþ">
                            <ItemTemplate>
                                <asp:LinkButton ID="acilis" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="12px"
                                    Font-Underline="False" OnCommand="acilis_Command"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Yayýn">
                            <ItemTemplate>
                                <asp:LinkButton ID="goster" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="12px"
                                    Font-Underline="False" OnCommand="goster_Command"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="hit" HeaderText="G&#246;sterim Sayýsý" />
                        <asp:TemplateField HeaderText="Resim">
                            <ItemTemplate>
                                <asp:Image ID="resim" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Ýþlemler">
                            <ItemTemplate>
                                
                                
                                <img src="../imgs/btnonlygorn.gif" onclick="window.open('konu_goster.aspx?Konu_ID=<%#DataBinder.Eval(Container.DataItem,"konu_id")%>','','width=550,height=400,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')" style="cursor:help" />
                                
                                
                                <asp:ImageButton ID="form_guncelle" runat="server" ImageUrl="~/imgs/btnguncelle.gif"
                                    OnCommand="bilgi_guncelle_Command" />
                                <asp:ImageButton ID="sil" runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm ('Seçili Konuyu Silmek Ýstediðinize Emin Misiniz?')"
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
                        Font-Names="Tahoma" Font-Size="11px" ForeColor="Black" />
                    <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                        ForeColor="#404040" />
                </asp:GridView>
                    &nbsp;</div>
            </td>
        </tr>
    </table>
    <br />
    
  </asp:Content>


