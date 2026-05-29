<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000076.aspx.cs" Inherits="administrator_ebebaba_pages_0000026" Theme="SkinFile" %>
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
                            <td colspan="2">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tbody>
                                        <tr>
                                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                    <tbody>
                                                        <tr>
                                                            <td style="width: 202px; height: 24px" valign="middle">
                                                                &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                    Text="IP Güncelleme"></asp:Label>
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
                            <td style="height: 24px" width="170">
                                <span style="font-size: 11px; font-family: Verdana">&nbsp; <span style="font-family: Arial">
                                    ID : </span></span>
                            </td>
                            <td style="height: 24px">
                                <asp:Label ID="Label2" runat="server" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="height: 25px" width="170">
                                &nbsp; <span style="font-family: Verdana; font-size: 11px">Adres Tanýmý : &nbsp;</span></td>
                            <td style="height: 25px">
                                <span style="font-size: 11px; font-family: Arial"><strong>
                                <asp:TextBox ID="tanim2" runat="server" MaxLength="100" SkinID="txtNormal" 
                                    ValidationGroup="kyd"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ControlToValidate="tanim2" Display="Dynamic" ErrorMessage="*" 
                                    Font-Names="Arial" Font-Size="12px" SetFocusOnError="True" 
                                    ValidationGroup="gun"></asp:RequiredFieldValidator>
                                </strong></span></td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="height: 25px" width="170">
                                <span style="font-size: 11px; font-family: Verdana">&nbsp; IP Adresi<span 
                                    style="font-family: Arial"> : </span></span>
                            </td>
                            <td style="height: 25px">
                                <asp:TextBox ID="alanadi2" runat="server" MaxLength="16" SkinID="txtNormal" 
                                    ValidationGroup="gun"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ControlToValidate="alanadi2" Display="Dynamic" ErrorMessage="*" 
                                    Font-Names="Arial" Font-Size="12px" SetFocusOnError="True" 
                                    ValidationGroup="gun"></asp:RequiredFieldValidator>
                                &nbsp;</td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="height: 16px" width="170">
                            </td>
                            <td style="height: 16px">
                            </td>
                        </tr>
                    </table>
                    <br />
                </asp:Panel>
            </td>
        </tr>
    </table>
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
        border-top: #000000 1px solid; border-left: #000000 1px solid; width: 95%; border-bottom: #000000 1px solid">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tbody>
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px" valign="middle">
                                                &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" Text="Kýsýtlanan IP Adresleri"></asp:Label>
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
                <span style="font-size: 11px; font-family: Arial"><strong>
                    <asp:Panel ID="panel_sonuc" runat="server" HorizontalAlign="Center" Visible="False"
                        Width="100%">
                        <br />
                        &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                            ForeColor="Black"></asp:Label>
                        <br />
                        <br />
                        <br />
                    </asp:Panel>
                    <table style="width: 100%">
                        <tr>
                            <td style="height: 24px" width="170" __designer:mapid="425">
                                <span style="font-size: 11px; font-family: Verdana" __designer:mapid="426">&nbsp; 
                                Adres Tanýmý : </span>
                            </td>
                            <td style="height: 24px" __designer:mapid="428">
                <span style="font-size: 11px; font-family: Arial"><strong>
                                <asp:TextBox ID="tanim" runat="server" MaxLength="100" SkinID="txtNormal" 
                                    ValidationGroup="kyd"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator 
                                    ID="RequiredFieldValidator3" runat="server" ControlToValidate="tanim"
                                    Display="Dynamic" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                    SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator>
                </strong></span>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 25px" width="170" __designer:mapid="42b">
                                <span style="font-size: 11px; font-family: Verdana" __designer:mapid="42c">&nbsp; IP Adresi<span 
                                    style="font-family: Arial" __designer:mapid="42d">
                                    : </span></span>
                            </td>
                            <td style="height: 25px" __designer:mapid="42e">
                                <span style="font-size: 11px; font-family: Arial"><strong>
                                <asp:TextBox ID="alanadi1" runat="server" MaxLength="16" SkinID="txtNormal" ValidationGroup="kyd"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="alanadi1"
                                    Display="Dynamic" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                    SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator>
                </strong></span>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 16px" width="170" __designer:mapid="432">
                            </td>
                            <td style="height: 16px" __designer:mapid="433">
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
                        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Font-Names="Arial" Font-Size="11px"
                        ForeColor="#333333" PageSize="20" Width="100%" 
                        EnableModelValidation="True">
                        <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:BoundField DataField="tanim" HeaderText="Adres Tanýmý" />
                            <asp:BoundField DataField="IP" HeaderText="IP Adresleri" />
                            <asp:TemplateField HeaderText="Ýþlemler">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ad_guncelle" runat="server" CausesValidation="False" ImageUrl="~/imgs/btnguncelle.gif"
                                        OnCommand="ad_guncelle_Command" />
                                    <asp:ImageButton ID="sil" runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('IP Adresini Silmek Ýstediðinize Eminmisiniz?')"
                                        OnCommand="sil_Command" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            Font-Names="Arial" Font-Size="11px" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="Gainsboro" ForeColor="White" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="Gainsboro" BorderStyle="Double" BorderWidth="1px" Font-Bold="True"
                            Font-Names="Arial" Font-Size="11px" ForeColor="Black" HorizontalAlign="Left" />
                        <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            ForeColor="#404040" />
                    </asp:GridView>
                    &nbsp;</div>
            </td>
        </tr>
    </table>
</asp:Content>


