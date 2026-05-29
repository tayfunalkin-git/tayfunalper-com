<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000052.aspx.cs" Inherits="administrator_ebebaba_pages_0000047" Theme="SkinFile" ValidateRequest="false" %>
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
                                                                &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                                                    Text="Video Bilgi Güncelleme"></asp:Label>
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
                                </table><asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Visible="False"
                        Width="100%">
                                    <br />
                                    &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                        ForeColor="Black"></asp:Label><br />
                                </asp:Panel>
                            </td>
                        </tr>
                        <tr>
                            <td style="height: 26px; font-size: 11px; width: 97px; font-family: Tahoma;">
                                <span style="font-size: 11px; font-family: Verdana">&nbsp;<span style="font-family: Tahoma">ID : </span></span>
                            </td>
                            <td style="height: 24px">
                                &nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Tahoma" Font-Size="11px"></asp:Label></td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="height: 26px; font-size: 11px; width: 97px; font-family: Tahoma;">
                                <span style="font-size: 11px; font-family: Verdana">&nbsp;Video Baþlýðý <span style="font-family: Tahoma">
                                    : </span></span>
                            </td>
                            <td style="height: 25px">
                                &nbsp;<asp:TextBox ID="alanadi2" runat="server" MaxLength="99" 
                                    SkinID="txtNormal" ValidationGroup="gun" Width="257px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="alanadi2"
                                    Display="Dynamic" ErrorMessage="*" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"
                                    ValidationGroup="gun"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="alanadi2"
                                    Display="Dynamic" ErrorMessage="' ve + karakterini kullanamazsýnýz !" Font-Names="Tahoma"
                                    Font-Size="11px" ValidationExpression="[^'+]+" ValidationGroup="gun"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="height: 26px; font-size: 11px; width: 97px; font-family: Tahoma;">
                                &nbsp;Video Embed Kod : </td>
                            <td style="height: 25px">
                                &nbsp;
                                <asp:TextBox ID="alanadi4" runat="server" SkinID="txtNormal" 
                                    ValidationGroup="gun" Width="255px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="alanadi4" Display="Dynamic" ErrorMessage="*" 
                                    Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True" 
                                    ValidationGroup="gun"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="height: 26px; font-size: 11px; width: 97px; font-family: Tahoma;">
                                &nbsp;Paylaþým URL :
                            </td>
                            <td style="height: 25px">
                                &nbsp;&nbsp;<asp:TextBox ID="alanadi5" runat="server" SkinID="txtNormal" 
                                    ValidationGroup="gun" Width="255px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                    ControlToValidate="alanadi5" Display="Dynamic" ErrorMessage="*" 
                                    Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True" 
                                    ValidationGroup="gun"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="font-size: 11px; width: 97px; font-family: Tahoma; height: 26px">
                                <span style="font-size: 8pt;"><span style="font-family: Verdana;">&nbsp;<span 
                                    style="font-size: 11px; font-family: Tahoma;">Yayýnlansýn mý?</span></span><span 
                                    style="font-size: 11px; font-family: Tahoma;"> : </span></span>
                            </td>
                            <td style="height: 26px">
                                <asp:CheckBox ID="yayin2" runat="server" BorderWidth="0px" 
                                    ValidationGroup="gun" />
                            </td>
                        </tr>
                        <tr style="font-size: 12pt; font-family: Times New Roman">
                            <td style="font-size: 11px; width: 97px; font-family: Tahoma; height: 26px" 
                                valign="top">
                                <span style="font-family: Tahoma"><span style="font-size: 8pt">&nbsp;Video<span 
                                    style="font-size: 11px"> Resmi</span></span><span style="font-size: 11px;"> 
                                : </span></span>
                            </td>
                            <td style="height: 123px" valign="top">
                                &nbsp;<asp:FileUpload ID="kitap_res2" runat="server" SkinID="fupload" />
                                <asp:ImageButton ID="ImageButton2" runat="server" 
                                    AlternateText="Video Resmini Deðiþtir" ImageAlign="AbsMiddle" 
                                    ImageUrl="~/imgs/kontrol.gif" OnClick="ImageButton2_Click" 
                                    ValidationGroup="tunc" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ControlToValidate="kitap_res2" Display="Dynamic" 
                                    ErrorMessage="Video Resmi Seçilmedi !" Font-Bold="False" Font-Names="Tahoma" 
                                    Font-Size="11px" SetFocusOnError="True" ValidationGroup="tunc"></asp:RequiredFieldValidator>
                                <br />
                                &nbsp;<asp:Image ID="resim2" runat="server" Height="75px" ImageAlign="AbsMiddle" 
                                    Width="75px" />
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
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px" valign="middle">
                                                &nbsp;<asp:Label 
                                                    ID="Label14" runat="server" Font-Bold="True" Font-Names="Tahoma"
                                                    Font-Size="11px" Text="Videolar"></asp:Label>
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
                <span style="font-size: 11px; font-family: Tahoma"><asp:Panel ID="panel_sonuc" runat="server" HorizontalAlign="Center" Visible="False"
                        Width="100%">
                    <br />
                    &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                        ForeColor="Black"></asp:Label><br />
                </asp:Panel>
                    <strong></strong>
                    <table style="width: 100%; font-weight: bold;">
                        <tr>
                            <td style="text-align: left">
                                Yeni Video&nbsp; Ekle ; &nbsp; 
                                <br />
                                <br />
                                <table border="0" cellpadding="0" cellspacing="0"
                        width="100%">
                                    <tr>
                                        <td style="height: 25px; font-weight: normal; width: 96px; text-align: left;">
                                            Video Baþlýðý<span style="font-size: 11px; font-family: Verdana"><span 
                                                style="font-family: Tahoma"> : : </span></span>
                                        </td>
                                        <td style="height: 25px; font-family: Tahoma; text-align: left;">
                                            &nbsp;
                                <asp:TextBox ID="alanadi1" runat="server" MaxLength="99" SkinID="txtNormal" 
                                                ValidationGroup="kyd" Width="240px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="alanadi1"
                                    Display="Dynamic" ErrorMessage="Video Baþlýðý Boþ Geçilemez !" Font-Bold="False" 
                                                Font-Names="Tahoma" Font-Size="11px"
                                    SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="alanadi1"
                                    Display="Dynamic" ErrorMessage="' ve + karakterini kullanamazsýnýz !" Font-Bold="False"
                                    Font-Names="Tahoma" Font-Size="11px" ValidationExpression="[^'+]+" ValidationGroup="kyd"></asp:RegularExpressionValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 96px; height: 25px; text-align: left">
                                            Video Resmi :
                                        </td>
                                        <td style="font-family: Tahoma; height: 25px; text-align: left">
                                            &nbsp;
                                            <asp:FileUpload ID="kitap_res" runat="server" SkinID="fupload" Width="327px" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="kitap_res"
                                                Display="Dynamic" ErrorMessage="Video Resmi Seçilmedi !" Font-Bold="False" Font-Names="Tahoma"
                                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 96px; height: 25px; text-align: left">
                                            Video Embed Kod :</td>
                                        <td style="font-family: Tahoma; height: 25px; text-align: left">
                                            &nbsp;
                <span style="font-size: 11px; font-family: Tahoma">
                                <asp:TextBox ID="alanadi3" runat="server" SkinID="txtNormal" ValidationGroup="kyd" 
                                                Width="242px"></asp:TextBox>
                </span>
                                            &nbsp;<span style="font-size: 11px; font-family: Tahoma"><asp:RequiredFieldValidator 
                                                ID="RequiredFieldValidator5" runat="server" ControlToValidate="alanadi3"
                                    Display="Dynamic" ErrorMessage="Video Embed Kod Boþ Geçilemez !" Font-Bold="False" 
                                                Font-Names="Tahoma" Font-Size="11px"
                                    SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator>
                </span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 96px; height: 25px; text-align: left">
                                            Paylaþým URL : </td>
                                        <td style="font-family: Tahoma; height: 25px; text-align: left">
                <span style="font-size: 11px; font-family: Tahoma">&nbsp;
                                <asp:TextBox ID="alanadi6" runat="server" SkinID="txtNormal" ValidationGroup="kyd" 
                                                Width="242px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator 
                                                ID="RequiredFieldValidator7" runat="server" ControlToValidate="alanadi6"
                                    Display="Dynamic" ErrorMessage="Video Paylaþým URL Boþ Geçilemez !" Font-Bold="False" 
                                                Font-Names="Tahoma" Font-Size="11px"
                                    SetFocusOnError="True" ValidationGroup="kyd"></asp:RequiredFieldValidator>
                </span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="font-weight: normal; width: 96px; height: 25px; text-align: left">
                                            Yayýnlansýn mý?</td>
                                        <td style="font-family: Tahoma; height: 25px; text-align: left">
                                            <asp:CheckBox ID="yayin" runat="server" BorderWidth="0px" /></td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                        </tr>
                    </table>
                </span>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <div align="left" style="text-align: left">
                    <asp:GridView ID="list" runat="server" AutoGenerateColumns="False" BorderColor="White"
                        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Font-Names="Tahoma" Font-Size="11px"
                        ForeColor="#333333" PageSize="20" Width="100%" 
                        EnableModelValidation="True">
                        <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                        <Columns>
                            <asp:TemplateField HeaderText="Video Baþlýðý">
                                <ItemTemplate>
                                    <asp:LinkButton ID="adi" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                        Font-Underline="False" OnCommand="adi_Command"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sýralama">
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
                            <asp:TemplateField HeaderText="Yayýn">
                                <ItemTemplate>
                                    <asp:LinkButton ID="goster" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="12px"
                                        Font-Underline="False" OnCommand="goster_Command"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Resim">
                                <ItemTemplate>
                                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tr>
                                            <td style="text-align: left" valign="middle">
                                                <asp:Image ID="kitap_res" runat="server" Height="50px" ImageAlign="AbsMiddle" Width="50px" />
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Ýþlemler">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ad_guncelle" runat="server" CausesValidation="False" ImageUrl="~/imgs/btnguncelle.gif"
                                        OnCommand="ad_guncelle_Command" />
                                    <asp:ImageButton ID="sil" runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('Kitap Kaydýný Silmek Ýstediðinize Eminmisiniz?')"
                                        OnCommand="sil_Command" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                            Font-Names="Tahoma" Font-Size="11px" ForeColor="#333333" />
                        <EditRowStyle BackColor="#999999" />
                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                        <PagerStyle BackColor="Gainsboro" ForeColor="White" HorizontalAlign="Center" />
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


