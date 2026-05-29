<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000005.aspx.cs" Inherits="administrator_ebebaba_pages_0000005" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;" width="95%">
        <tr>
            <td valign="bottom">
               <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TR><TD 
style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TR><TD style="WIDTH: 202px; HEIGHT: 24px" 
vAlign=middle> &nbsp;
    <asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Kayýtlý Doktorlar"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>  &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;</TD></TR></TABLE></TD></TR></TABLE>
                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                    <br />
                    &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><br />
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="border-top-width: 1px; border-right: #d3d3d3 1px solid; border-left: #d3d3d3 1px solid;
                border-top-color: #d3d3d3; border-bottom: #d3d3d3 1px solid;" valign="top">
                <div align="left">
                    <asp:Panel ID="other_info" runat="server" Visible="False" Width="100%">
                        &nbsp;<table align="center" cellpadding="0" cellspacing="0" style="border-right: black 1px solid;
                            border-top: black 1px solid; overflow: hidden; border-left: black 1px solid;
                            clip: rect(10px 10px 10px 10px); border-bottom: black 1px solid" width="90%">
                            <tr>
                                <td colspan="7" style="font-size: 11px; color: gray; font-family: verdana; height: 23px">
                                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tr>
                                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 23px; text-align: left"
                                                valign="middle">
                                                &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                                    ForeColor="Black" Text="Seçilen Doktorun Diðer Bilgileri"></asp:Label>
                                                &nbsp;</td>
                                        </tr>
                                    </table>
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="height: 30px; text-align: left">
                                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%">
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 136px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 43px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 193px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 139px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Adý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label2" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: Tahoma">
                                                Ev Tel :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label9" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 130px; color: #000000; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr style="color: #000000">
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Soyadý :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label3" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: Tahoma">
                                                Ýþ Tel :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label10" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 130px; color: #000000; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr style="color: #000000">
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                E - Mail :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label4" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: Tahoma">
                                                Cep Tel :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label11" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 15px;
                                                text-align: right">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Adres :</td>
                                            <td colspan="5" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:Label ID="Label6" runat="server" ForeColor="Black"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 15px;
                                                text-align: right">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Kullanýcý Adý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label7" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Þifre :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:Label ID="Label8" runat="server" ForeColor="Black"></asp:Label></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 15px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 10px">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 10px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 10px">
                                            </td>
                                            <td colspan="6" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <strong>Konsülte
                                                Hastalarý</strong>
                                                <asp:Label ID="Label1" runat="server" ForeColor="#000099" Font-Bold="True"></asp:Label>
                                                :</td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 10px">
                                            </td>
                                            <td colspan="6" style="font-size: 11px; color: black; font-family: Tahoma;">
                                                
                                                  <asp:GridView ID="doktorlistesi" runat="server" AutoGenerateColumns="False" BorderStyle="None"
                                                    BorderWidth="0px" GridLines="None" ShowHeader="False" Width="100%" CellPadding="0">
                                                    <Columns>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="hasta_adi" runat="server" Font-Underline="True" ForeColor="#000000"
                                                                    OnClientClick="return confirm('Hasta Sayfasýna Gitmek Ýstediðinize Emin Misiniz?')"
                                                                    OnCommand="hasta_adi_Command" Font-Bold="False"></asp:LinkButton>&nbsp;
                                                                <asp:LinkButton ID="siklus_adi" runat="server" Font-Underline="True" OnClientClick="return confirm('Belirtilen Siklusa Gitmek Ýstediðinize Emin Misiniz?')"
                                                                    OnCommand="siklus_adi_Command"></asp:LinkButton>&nbsp;
                                                                <asp:LinkButton ID="ipt" runat="server" Font-Underline="False" OnClientClick="return confirm('Paylaþýmý Kaldýrmak Ýstediðinize Emin Misiniz?')"
                                                                    OnCommand="ipt_Command">(Kaldýr)</asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns><RowStyle Height="15px" />
                                                </asp:GridView>
                                                
                                                
                                                </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 16px">
                                            </td>
                                            <td colspan="6" style="font-size: 11px; color: gray; font-family: verdana; height: 16px">
                                                <hr />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 10px">
                                            </td>
                                            <td colspan="6" style="font-size: 11px; color: gray; font-family: verdana; height: 10px">
                                                <span style="font-family: Tahoma"><span style="color: black"><strong>Kendi Kaydettiði
                                                    Hastalarý</strong> </span></span>
                                                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                                    ForeColor="#000099"></asp:Label>
                                                :</td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 10px">
                                            </td>
                                            <td colspan="6" style="font-size: 11px; color: gray; font-family: verdana; height: 10px">
                                                <asp:GridView ID="kendilistesi" runat="server" AutoGenerateColumns="False" BorderStyle="None"
                                                    BorderWidth="0px" GridLines="None" ShowHeader="False" Width="100%" CellPadding="0">
                                                    <RowStyle Height="15px" />
                                                    <Columns>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="hasta_adi" runat="server" Font-Bold="False" Font-Names="Tahoma"
                                                                    Font-Underline="True" ForeColor="#000000" OnClientClick="return confirm('Hasta Sayfasýna Gitmek Ýstediðinize Emin Misiniz?')"
                                                                    OnCommand="hasta_adi_Command"></asp:LinkButton>&nbsp;
                                                                <asp:LinkButton ID="siklus_adi" runat="server" Font-Names="Tahoma" Font-Underline="True"
                                                                    OnClientClick="return confirm('Belirtilen Siklusa Gitmek Ýstediðinize Emin Misiniz?')"
                                                                    OnCommand="siklus_adi_Command"></asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                                </td>
                            </tr>
                        </table>
                        <br />
                    </asp:Panel>
                                                    <asp:GridView ID="doktor_listesi" runat="server" AutoGenerateColumns="False"
                                                        BorderStyle="Solid" CellPadding="4" ForeColor="#333333"
                                                        PageSize="1" Width="100%" BorderColor="White" BorderWidth="1px" Font-Size="11px">
                                                        <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                                                        <Columns>
                                                            <asp:BoundField DataField="uye_k_adi" HeaderText="Kullanýcý Adý">
                                                                <ItemStyle Width="100px" />
                                                            </asp:BoundField>
                                                            <asp:TemplateField HeaderText="Adý - Soyadý">
                                                                <ItemStyle Width="150px" />
                                                                <ItemTemplate>
                                                                    <asp:Label ID="adi_soyadi" runat="server" Font-Bold="True"></asp:Label>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Doktor Yetki">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="doktor_uyelik" runat="server" Font-Size="12px" Font-Underline="False" OnCommand="doktor_uyelik_Command"></asp:LinkButton>
                                                                </ItemTemplate>
                                                                <ItemStyle Width="100px" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Admin Yetki">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="admin_uyelik" runat="server" Font-Size="12px" Font-Underline="False" OnCommand="admin_uyelik_Command"></asp:LinkButton>
                                                                </ItemTemplate>
                                                                <ItemStyle Width="100px" />
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Ortak Kullanýcý">
                                                                <ItemTemplate>
                                                                    <asp:LinkButton ID="ortak_kullanici" runat="server" Font-Size="12px" Font-Underline="False"
                                                                        OnCommand="ortak_kullanici_Command"></asp:LinkButton>
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                            <asp:TemplateField HeaderText="Ýþlemler">
                                                                <ItemTemplate>
                                                                    <asp:ImageButton ID="bilgi_guncelle" runat="server" ImageUrl="~/imgs/btnguncelle.gif"
                                                                        OnCommand="bilgi_guncelle_Command" AlternateText="Doktor Bilgilerini Güncelle" />
                                                                    <asp:ImageButton ID="diger_bilgiler" runat="server" ImageUrl="~/imgs/btndigerbilgiler.gif"
                                                                        OnCommand="diger_bilgiler_Command" AlternateText="Doktorun Diðer Bilgileri" />
                                                                    <asp:ImageButton ID="sil" runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm ('Seçili Doktor Kaydýný Silmek Ýstediðinize Eminmisiniz? Silinmek istenilen kayýdýn silinmesi halinde atanmýþ hastalarýn atamasý iptal olacaktýr.')"
                                                                        OnCommand="sil_Command" AlternateText="Doktor Kaydýný Sil" />
                                                                </ItemTemplate>
                                                            </asp:TemplateField>
                                                        </Columns>
                                                        <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                                            Font-Names="Tahoma" ForeColor="#333333" Font-Size="11px" Height="15px" />
                                                        <EditRowStyle BackColor="#999999" />
                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                        <PagerStyle BackColor="Silver" ForeColor="White" HorizontalAlign="Center" />
                                                        <HeaderStyle BackColor="Gainsboro" BorderStyle="Double" BorderWidth="1px" Font-Bold="True"
                                                            Font-Names="Tahoma" Font-Size="11px" ForeColor="Black" />
                                                        <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                                            ForeColor="#404040" />
                                                    </asp:GridView>
                    </div>
            </td>
        </tr>
    </table>
    <div style="text-align: center">
        &nbsp;</div>
    <br />
</asp:Content>


