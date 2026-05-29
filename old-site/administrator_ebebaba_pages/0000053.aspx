<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000053.aspx.cs"  Inherits="ebebabaadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contentplaceholder1" Runat="Server">
    
<script language="Javascript"><!-- // load htmlarea
_editor_url = "";                     // URL to htmlarea files
var win_ie_ver = parseFloat(navigator.appVersion.split("MSIE")[1]);
if (navigator.userAgent.indexOf('Mac')        >= 0) { win_ie_ver = 0; }
if (navigator.userAgent.indexOf('Windows CE') >= 0) { win_ie_ver = 0; }
if (navigator.userAgent.indexOf('Opera')      >= 0) { win_ie_ver = 0; }
if (win_ie_ver >= 5.5) {
  document.write('<scr' + 'ipt src="' +_editor_url+ 'editor.js"');
  document.write(' language="Javascript"></scr' + 'ipt>');  
} else { document.write('<scr'+'ipt>function editor_generate() { return false; }</scr'+'ipt>'); }
// --></script>


<script language="JavaScript">
<!--
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);
//-->
</script>

    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Italic="True"
                                            Font-Names="Calibri" Font-Size="14px" ForeColor="DarkOrange" 
                                            Text="Forum İşlemleri"></asp:Label>
    <br />
    <br />

    <table align="center" cellpadding="1" cellspacing="1" width="90%">
        <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
            <td colspan="3" style="text-align: left" valign="top">
                <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                    border-bottom-color: gray" width="100%">
                    <tr>
                        <td style="background-color: aliceblue">
                            <table cellpadding="0" cellspacing="0">
                                <tr>
                                    <td style="border-color: lightgrey; border-width: 1px; height: 25px; width: 130px;">
                                        &nbsp;<span
                                                style="font-family: Calibri">&nbsp;</span></td>
                                </tr>
                            </table>
                        </td>
                        <td align="right" style="font-size: 9pt; font-family: Calibri; background-color: aliceblue"
                            valign="middle">
                            <asp:Menu ID="menuadmin" runat="server" BackColor="AliceBlue" DynamicHorizontalOffset="2"
                                Font-Names="Calibri" Font-Size="12px" ForeColor="Black" Orientation="Horizontal"
                                StaticSubMenuIndent="10px" Width="85%" OnMenuItemClick="menumesaj_MenuItemClick">
                                <StaticSelectedStyle BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                                <StaticMenuItemStyle HorizontalPadding="5px" ItemSpacing="100px" VerticalPadding="2px" />
                                <DynamicHoverStyle ForeColor="Black" Font-Underline="True" />
                                <DynamicMenuStyle BackColor="#F7F6F3" />
                                <DynamicSelectedStyle BackColor="#5D7B9D" />
                                <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                                <StaticHoverStyle ForeColor="Black" Font-Underline="False" />
                                <Items>
                                    <asp:MenuItem Text="Forum İşlemleri" Value="kategori">
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="Onay Bekleyen &#220;yeler" Value="uye"></asp:MenuItem>
                                    <asp:MenuItem Text="Onay Bekleyen Konular" Value="konu">
                                    </asp:MenuItem>
                                    <asp:MenuItem Text="Onay Bekleyen Cevaplar" Value="cevap"></asp:MenuItem>
                                    <asp:MenuItem Text="Toplu Mail G&#246;nder" Value="mail"></asp:MenuItem>
                                    <asp:MenuItem Text="Forum Ayarları" Value="ayar"></asp:MenuItem>
                                </Items>
                            </asp:Menu>
                            <a href="#yeni"></a>
                        </td>
                    </tr>
                </table>
                <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                    font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                    font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                    border-right-color: lightgrey" width="100%">
                    <tr>
                        <td style="text-align: justify">
                <table align="center" style="width: 90%">
                    <tr>
                        <td style="width: 100px">
                            <asp:Label ID="Label8" runat="server" Font-Names="Tahoma" Font-Size="11px"></asp:Label></td>
                    </tr>
                </table>
                    <asp:Panel ID="guncelle" runat="server" align="center" HorizontalAlign="Left" Visible="False"
                        Width="100%">
                        <table align="center" cellpadding="1" cellspacing="1" width="95%">
                            <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                                <td colspan="3" style="text-align: left" valign="top">
                                    <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                        border-bottom-color: gray" width="100%">
                                        <tr>
                                            <td style="background-color: aliceblue">
                                                <table cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                            border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                            height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                            &nbsp;<asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="13px" ForeColor="DarkOrange" 
                                                                Text="Forum Adı Güncelleme"></asp:Label>
                                                            <span style="font-family: Calibri">&nbsp;</span></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td align="right" 
                                                style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                                valign="middle">
                                                <asp:ImageButton ID="Button2" runat="server" 
                                                    AlternateText="Değişiklikleri Kaydet" ImageAlign="AbsMiddle" 
                                                    ImageUrl="~/forum/imgs/save.png" OnClick="Button2_Click1" 
                                                    ValidationGroup="gun" />
                                                &nbsp;<a href="#yeni"></a></td>
                                        </tr>
                                    </table>
                                    <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                        font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                        font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                        border-right-color: lightgrey" width="100%">
                                        <tr>
                                            <td style="text-align: justify">
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td style="width: 147px">
                                                        </td>
                                                        <td style="width: 354px">
                                                            <asp:Label ID="Label2" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                Font-Size="12px" Visible="False"></asp:Label>
                                                        </td>
                                                        <td style="font-size: 9pt">
                                                        </td>
                                                    </tr>
                                                    <tr style="font-size: 9pt">
                                                        <td style="font-size: 12px; width: 147px; font-family: Tahoma; height: 30px" 
                                                            valign="top">
                                                            &nbsp;<span style="color: #000000; font-family: Calibri;"><em>Forum Adı : </em>
                                                            </span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                                ControlToValidate="alanadi2" Display="Dynamic" ErrorMessage="*" 
                                                                Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True" 
                                                                ValidationGroup="gun"></asp:RequiredFieldValidator>
                                                        </td>
                                                        <td style="width: 354px; height: 30px" valign="top">
                                                            <asp:TextBox ID="alanadi2" runat="server" CssClass="textBoxStyle6" 
                                                                ValidationGroup="gun" Width="323px"></asp:TextBox>
                                                        </td>
                                                        <td style="height: 30px">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="font-size: 12px; width: 147px; font-family: Tahoma" valign="top">
                                                            &nbsp;<span style="color: #000000"><span style="font-family: Calibri"><em>Forum 
                                                            Açıklaması :</em></span> </span>
                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                                                ControlToValidate="aciklama2" Display="Dynamic" ErrorMessage="*" 
                                                                Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True" 
                                                                ValidationGroup="gun"></asp:RequiredFieldValidator>
                                                        </td>
                                                        <td style="width: 354px" valign="top">
                                                            <asp:TextBox ID="aciklama2" runat="server" CssClass="textBoxStyle6" 
                                                                Height="90px" TextMode="MultiLine" ValidationGroup="gun" Width="329px"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                <asp:Panel ID="kategoripanel" runat="server" Width="100%" Visible="False">
                    <br />
                    <table align="center" cellpadding="1" cellspacing="1" width="95%">
                        <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                            <td colspan="3" style="text-align: left" valign="top">
                                <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                    border-bottom-color: gray" width="100%">
                                    <tr>
                                        <td style="background-color: aliceblue">
                                            <table cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                        border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                        height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                        &nbsp;<asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" 
                                                            Font-Names="Calibri" Font-Size="13px" ForeColor="DarkOrange" 
                                                            Text="Yeni Forum Ekle - Forumlar"></asp:Label>
                                                        <span style="font-family: Calibri">&nbsp;</span></td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td align="right" 
                                            style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                            valign="middle">
                                            <asp:ImageButton ID="Button1" runat="server" AlternateText="Kaydet" 
                                                ImageAlign="AbsMiddle" ImageUrl="~/forum/imgs/save.png" OnClick="Button1_Click" 
                                                ValidationGroup="kyd" />
                                            &nbsp;<a href="#yeni"></a></td>
                                    </tr>
                                </table>
                                <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                    font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                    font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                    border-right-color: lightgrey" width="100%">
                                    <tr>
                                        <td style="text-align: justify">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td style="width: 147px">
                                                    </td>
                                                    <td style="width: 354px">
                                                        <asp:Label ID="sonuc" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                            Font-Size="12px"></asp:Label>
                                                    </td>
                                                    <td style="font-size: 9pt">
                                                    </td>
                                                </tr>
                                                <tr style="font-size: 9pt">
                                                    <td style="font-size: 12px; width: 147px; font-family: Tahoma; height: 30px" 
                                                        valign="top">
                                                        &nbsp;<span style="color: #000000"><span style="font-family: Calibri"><em>Forum Adı :</em></span>
                                                        </span>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                            ControlToValidate="alanadi1" Display="Dynamic" ErrorMessage="*" 
                                                            Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True" 
                                                            ValidationGroup="kyd"></asp:RequiredFieldValidator>
                                                    </td>
                                                    <td style="width: 354px; height: 30px" valign="top">
                                                        <asp:TextBox ID="alanadi1" runat="server" CssClass="textBoxStyle6" 
                                                            ValidationGroup="kyd" Width="323px"></asp:TextBox>
                                                    </td>
                                                    <td style="height: 30px">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="font-size: 12px; width: 147px; font-family: Tahoma" valign="top">
                                                        &nbsp;<span style="color: #000000; font-family: Calibri;"><em>Forum Açıklaması : </em>
                                                        </span>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                                            ControlToValidate="aciklama1" Display="Dynamic" ErrorMessage="*" 
                                                            Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True" 
                                                            ValidationGroup="kyd"></asp:RequiredFieldValidator>
                                                    </td>
                                                    <td style="width: 354px" valign="top">
                                                        <asp:TextBox ID="aciklama1" runat="server" CssClass="textBoxStyle6" 
                                                            Height="90px" TextMode="MultiLine" ValidationGroup="kyd" Width="329px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                            <asp:GridView ID="list" runat="server" AutoGenerateColumns="False" 
                                                BorderColor="White" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" 
                                                Font-Italic="True" Font-Names="Calibri" Font-Size="12px" ForeColor="#333333" 
                                                PageSize="20" Width="100%">
                                                <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                                                <Columns>
                                                    <asp:TemplateField>
                                                        <ItemTemplate>
                                                            <asp:ImageButton ID="ad_guncelle" runat="server" CausesValidation="False" 
                                                                ImageUrl="~/forum/imgs/edit.png" OnCommand="ad_guncelle_Command" />
                                                            <asp:ImageButton ID="sil" runat="server" ImageUrl="~/forum/imgs/silinen.png" 
                                                                OnClientClick="return confirm('Forumu  Silmek İstediğinize Eminmisiniz?')" 
                                                                OnCommand="sil_Command" />
                                                        </ItemTemplate>
                                                        <ItemStyle HorizontalAlign="Center" Width="60px" />
                                                    </asp:TemplateField>
                                                    <asp:TemplateField HeaderText="Sıralama">
                                                        <ItemTemplate>
                                                            <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                <tr>
                                                                    <td style="width: 100px">
                                                                        <asp:ImageButton ID="ust" runat="server" AlternateText="Bir Üste Taşı" 
                                                                            ImageUrl="~/forum/imgs/ust.gif" OnCommand="ust_Command" />
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 100px">
                                                                        <asp:ImageButton ID="alt" runat="server" AlternateText="Bir Alta Taşı" 
                                                                            ImageUrl="~/forum/imgs/alt.gif" OnCommand="alt_Command" />
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </ItemTemplate>
                                                        <ItemStyle HorizontalAlign="Center" Width="50px" />
                                                    </asp:TemplateField>
                                                    <asp:BoundField DataField="kategoriAdi" HeaderText="Forum Adı">
                                                    <ItemStyle Width="300px" />
                                                    </asp:BoundField>
                                                    <asp:BoundField DataField="kategoriAciklama" HeaderText="Açıklama" />
                                                </Columns>
                                                <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" 
                                                    BorderWidth="1px" Font-Names="Tahoma" Font-Size="11px" ForeColor="#333333" />
                                                <EditRowStyle BackColor="#999999" />
                                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                <PagerStyle BackColor="Gainsboro" ForeColor="White" HorizontalAlign="Center" />
                                                <HeaderStyle BackColor="Gainsboro" BorderStyle="Double" BorderWidth="1px" 
                                                    Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" ForeColor="Black" 
                                                    HorizontalAlign="Left" />
                                                <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" 
                                                    BorderWidth="1px" ForeColor="#404040" />
                                            </asp:GridView>
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="konupanel" runat="server" Width="100%" Visible="False">
                    <span style="font-size: 12px; font-family: Tahoma"><strong>
                        <table align="center" cellpadding="1" cellspacing="1" width="95%">
                            <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                                <td colspan="3" style="text-align: left" valign="top">
                                    <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                        border-bottom-color: gray" width="100%">
                                        <tr>
                                            <td style="background-color: aliceblue">
                                                <table cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                            border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                            height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                            &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="13px" ForeColor="DarkOrange" 
                                                                Text="Onay Bekleyen Konular"></asp:Label>
                                                            <span style="font-size: 12px; font-family: Calibri"><em>(</em></span><asp:Label 
                                                                ID="konusayisi" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="12px" ForeColor="Black"></asp:Label>
                                                            <span style="font-family: Calibri"><span style="font-size: 12px"><em>)<span>&nbsp;</span></em></span></span></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td align="right" 
                                                style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                                valign="bottom">
                                                <a href="#yeni"></a>
                                            </td>
                                        </tr>
                                    </table>
                                    <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                        font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                        font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                        border-right-color: lightgrey" width="100%">
                                        <tr>
                                            <td style="text-align: justify">
                                                <asp:DataList ID="konular" runat="server" Width="100%">
                                                    <ItemStyle BackColor="GhostWhite" />
                                                    <ItemTemplate>
                                                        <br />
                                                        <table cellpadding="1" cellspacing="1" style="width: 100%">
                                                            <tr>
                                                                <td style="border-right: lightgrey 1px dotted; width: 150px" valign="top">
                                                                    <table cellpadding="2" cellspacing="2" width="150">
                                                                        <tr>
                                                                            <td style="height: 20px; text-align: center">
                                                                                <asp:LinkButton ID="adsoyad" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" Font-Underline="False" ForeColor="Black"></asp:LinkButton>
                                                                                <br />
                                                                                <asp:Label ID="tip" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                    Font-Size="13px"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="text-align: center">
                                                                                <asp:Image ID="uyeResim" runat="server" BorderColor="#404040" 
                                                                                    BorderStyle="Dotted" BorderWidth="1px" Width="80px" />
                                                                                <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="text-align: center">
                                                                                <asp:Image ID="imgdurum" runat="server" ImageAlign="AbsMiddle" />
                                                                                <asp:Label ID="durum" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                    Font-Size="13px"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="text-align: center">
                                                                                <br />
                                                                                <asp:ImageButton ID="btnonay" runat="server" ImageUrl="~/imgs/btnonay.gif" 
                                                                                    OnCommand="btnonay_Command" />
                                                                                <asp:ImageButton ID="btnsil" runat="server" ImageUrl="~/imgs/btnsil.gif" 
                                                                                    OnClientClick="return confirm('Silmek İstediğinize Emin Misiniz?')" 
                                                                                    OnCommand="btnsil_Command" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    &nbsp;
                                                                </td>
                                                                <td style="width: 1px">
                                                                </td>
                                                                <td valign="top">
                                                                    <table cellpadding="0" cellspacing="0" width="100%">
                                                                        <tr>
                                                                            <td style="width: 67px; height: 3px">
                                                                                <span style="font-size: 12px; font-family: Tahoma"></span>
                                                                            </td>
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                            <td style="border-top-width: 1px; border-left-width: 1px; font-size: 13px; border-left-color: lightblue; border-top-color: lightblue; border-bottom: black 1px dotted; font-family: calibri;
                                                    height: 20px; border-right-width: 1px; border-right-color: lightblue; font-style: italic;">
                                                                                <span><span><span style="color: #000000"><span style="font-size: 13px">Forum :
                                                                                </span>
                                                                                <asp:Label ID="forum" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                <br />
                                                                                <span style="font-size: 13px">Konu : </span></span>
                                                                                <asp:Label ID="baslik" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                <span style="font-size: 13px">&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; </span></span>
                                                                                <span style="font-size: 13px">Gönderim Zamanı : </span></span>
                                                                                <asp:Label ID="tarih" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                    Font-Size="13px" ForeColor="Gray"></asp:Label>
                                                                                <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                            <td rowspan="8" valign="top">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr>
                                                                                        <td valign="top">
                                                                                            <br />
                                                                                            <asp:Label ID="icerik" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                                Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                            <br />
                                                                                            <br />
                                                                                            <br />
                                                                                            <br />
                                                                                            <asp:Panel ID="imzapaneli" runat="server" Width="100%">
                                                                                                <br />
                                                                                                <br />
                                                                                                <br />
                                                                                                <hr />
                                                                                                <asp:Label ID="imza" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                                    Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                            </asp:Panel>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                    </ItemTemplate>
                                                    <AlternatingItemStyle BackColor="White" />
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <br />
                    </strong></span>
                    </asp:Panel>
                <asp:Panel ID="cevappanel" runat="server" Width="100%" Visible="False">
                    <strong><span style="font-size: 9pt"><span style="font-family: Tahoma">
                        <table align="center" cellpadding="1" cellspacing="1" width="95%">
                            <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                                <td colspan="3" style="text-align: left" valign="top">
                                    <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                        border-bottom-color: gray" width="100%">
                                        <tr>
                                            <td style="background-color: aliceblue">
                                                <table cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                            border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                            height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                            &nbsp;<asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="13px" ForeColor="DarkOrange" 
                                                                Text="Onay Bekleyen Cevaplar"></asp:Label>
                                                            <span style="font-size: 12px; font-family: Calibri"><em>(</em></span><asp:Label 
                                                                ID="Label6" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="12px" ForeColor="Black"></asp:Label>
                                                            <span style="font-family: Calibri"><span style="font-size: 12px"><em>)<span>&nbsp;</span></em></span></span></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td align="right" 
                                                style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                                valign="bottom">
                                                <a href="#yeni"></a>
                                            </td>
                                        </tr>
                                    </table>
                                    <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                        font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                        font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                        border-right-color: lightgrey" width="100%">
                                        <tr>
                                            <td style="text-align: justify">
                                                <asp:DataList ID="cevaplar" runat="server" Width="100%">
                                                    <ItemStyle BackColor="GhostWhite" />
                                                    <ItemTemplate>
                                                        <br />
                                                        <table cellpadding="1" cellspacing="1" style="width: 100%">
                                                            <tr>
                                                                <td style="border-right: lightgrey 1px dotted; width: 150px" valign="top">
                                                                    <table cellpadding="2" cellspacing="2" width="150">
                                                                        <tr>
                                                                            <td style="height: 20px; text-align: center">
                                                                                <asp:LinkButton ID="adsoyad" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" Font-Underline="False" ForeColor="Black"></asp:LinkButton>
                                                                                <br />
                                                                                <asp:Label ID="tip" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                    Font-Size="13px"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="text-align: center">
                                                                                <asp:Image ID="uyeResim" runat="server" BorderColor="#404040" 
                                                                                    BorderStyle="Dotted" BorderWidth="1px" Width="80px" />
                                                                                <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="text-align: center">
                                                                                <asp:Image ID="imgdurum" runat="server" ImageAlign="AbsMiddle" />
                                                                                <asp:Label ID="durum" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                                                    Font-Size="13px"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="text-align: center">
                                                                                <br />
                                                                                <asp:ImageButton ID="btnonay" runat="server" ImageUrl="~/imgs/btnonay.gif" 
                                                                                    OnCommand="btnonay2_Command" />
                                                                                <asp:ImageButton ID="btnsil" runat="server" ImageUrl="~/imgs/btnsil.gif" 
                                                                                    OnClientClick="return confirm('Silmek İstediğinize Emin Misiniz?')" 
                                                                                    OnCommand="btnsil2_Command" />
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                    &nbsp;
                                                                </td>
                                                                <td style="width: 1px">
                                                                </td>
                                                                <td valign="top">
                                                                    <table cellpadding="0" cellspacing="0" width="100%">
                                                                        <tr>
                                                                            <td style="width: 67px; height: 3px">
                                                                                <span style="font-size: 12px; font-family: Tahoma"></span>
                                                                            </td>
                                                                        </tr>
                                                                        <tr style="font-family: Calibri">
                                                                            <td style="border-top-width: 1px; border-left-width: 1px; font-size: 13px; border-left-color: lightblue; border-top-color: lightblue; border-bottom: black 1px dotted; font-family: calibri;
                                                                height: 20px; border-right-width: 1px; border-right-color: lightblue; font-style: italic;">
                                                                                <span style="font-size: 11px; font-family: Tahoma; font-weight: normal;">
                                                                                <span style="font-size: 9pt; font-weight: normal;">
                                                                                <span style="font-size: 12px; color: #000000; font-weight: normal;">Forum :&nbsp;
                                                                                <asp:Label ID="forum" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                <br />
                                                                                Konu : </span>
                                                                                <asp:Label ID="baslik" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; </span><span style="color: gray">Gönderim Zamanı : </span></span>
                                                                                <asp:Label ID="tarih" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="Gray"></asp:Label>
                                                                                <br />
                                                                            </td>
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                            <td rowspan="8" valign="top">
                                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                    <tr>
                                                                                        <td valign="top">
                                                                                            <br />
                                                                                            <asp:Label ID="icerik" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                                                Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                            <br />
                                                                                            <br />
                                                                                            <br />
                                                                                            <br />
                                                                                            <asp:Panel ID="imzapaneli" runat="server" Width="100%">
                                                                                                <br />
                                                                                                <br />
                                                                                                <br />
                                                                                                <br />
                                                                                                <hr />
                                                                                                <asp:Label ID="imza" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                                            </asp:Panel>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                        <tr style="font-weight: bold">
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <br />
                                                    </ItemTemplate>
                                                    <AlternatingItemStyle BackColor="White" />
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </span></span></strong><span style="font-size: 12px; color: #000000; font-family: Tahoma"><strong></strong></span></asp:Panel>
                <asp:Panel ID="mailpanel" runat="server" Width="100%" Visible="False">
                    <span style="font-size: 12px; font-family: Tahoma">
                        <br />
                        <strong>&nbsp; </strong><span style="color: #000099; font-size: 13px; font-family: Calibri;">
                            <em>Tüm Üyelere Mail Göndermek İçin Konu ve Mesajınızı Yazınız.</em></span><br />
                            <br />
                        <table width: style="width: 100%" 100%">
                            <tr>
                                <td style="width: 107px; height: 30px; font-size: 13px; font-style: italic; font-family: calibri;" valign="top">
                                    &nbsp;<span style="color: #000000">Gönderen : </span>
                                </td>
                                <td style="height: 30px" valign="top">
                                    <span style="color: #000000; font-size: 13px; font-family: Calibri;"><em>
                                    bilgi@tayfunalper.com</em></span></td>
                            </tr>
                            <tr>
                                <td style="width: 107px; height: 30px; font-size: 13px; font-style: italic; font-family: calibri;" valign="top">
                                    &nbsp;<span style="color: #000000">Konu :</span>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="konu"
                                        Display="Dynamic" ErrorMessage="*" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"
                                        ValidationGroup="mail"></asp:RequiredFieldValidator></td>
                                <td style="height: 30px" valign="top">
                                    <asp:TextBox ID="konu" runat="server" CssClass="textBoxStyle6" ValidationGroup="mail"
                                        Width="323px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 107px; height: 30px; font-size: 13px; font-style: italic; font-family: calibri;" valign="top">
                                    &nbsp;<span style="color: #000000">Mesaj :</span>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="mesaj"
                                        Display="Dynamic" ErrorMessage="*" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"
                                        ValidationGroup="mail"></asp:RequiredFieldValidator></td>
                                <td style="height: 30px; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid;" valign="top">
                                    <asp:TextBox ID="mesaj" runat="server" BorderColor="#E0E0E0" BorderStyle="Solid"
                                        BorderWidth="1px" ValidationGroup="mail"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td style="width: 107px">
                                </td>
                                <td>
                                    <asp:ImageButton ID="mesajgonder" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/forum/imgs/gonder.png"
                                        OnClick="mesajgonder_Click" ValidationGroup="mail" />
                                    <asp:Label ID="Label1" runat="server" Font-Names="Calibri" Font-Size="13px" Font-Italic="True"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="width: 107px">
                                </td>
                                <td>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                </td>
                            </tr>
                        </table>
                        <asp:Panel ID="gidenpanel" runat="server" Visible="False" Width="100%">
                            <table align="center" cellpadding="1" cellspacing="1" width="95%">
                                <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                                    <td colspan="3" style="text-align: left" valign="top">
                                        <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                            border-bottom-color: gray" width="100%">
                                            <tr>
                                                <td style="background-color: aliceblue">
                                                    <table cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                                border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                                height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                                &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="DarkOrange" 
                                                                    Text="Daha Önce Gönderilen Toplu Mailler"></asp:Label>
                                                                <asp:Label ID="gidensayi" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                    Font-Names="Calibri" Font-Size="13px" ForeColor="#000099"></asp:Label>
                                                                <asp:LinkButton ID="gidensil" runat="server" Font-Bold="False" 
                                                                    Font-Italic="True" Font-Names="Calibri" Font-Size="13px" Font-Underline="False" 
                                                                    ForeColor="#000000" OnClick="gidensil_Click" 
                                                                    OnClientClick="return confirm('Seçili Mesajlar Silinecektir.Onaylıyor Musunuz?')">Sil</asp:LinkButton>
                                                                <asp:Label ID="Label10" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                    Font-Names="Calibri" Font-Size="13px"></asp:Label>
                                                                <span style="font-family: Calibri">&nbsp;</span></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                                <td align="right" 
                                                    style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                                    valign="bottom">
                                                    <a href="#yeni"></a>
                                                </td>
                                            </tr>
                                        </table>
                                        <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                            font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                            font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                            border-right-color: lightgrey" width="100%">
                                            <tr>
                                                <td style="text-align: justify">
                                                    <table align="center" cellpadding="0" cellspacing="0" style="border-right: lightgrey 1px solid;
                                border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; width: 95%;
                                border-bottom: lightgrey 1px solid">
                                                        <tr>
                                                            <td colspan="2" 
                                                                style="height: 30px; background-color: inactivecaption; text-align: right">
                                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                                    <tr>
                                                                        <td style="width: 30px; text-align: center">
                                                                            <asp:CheckBox ID="gidensecana" runat="server" />
                                                                        </td>
                                                                        <td colspan="4" style="text-align: right">
                                                                            <asp:TextBox ID="gidendeara" runat="server" AutoPostBack="True" 
                                                                                CssClass="textBoxStyleArama" OnTextChanged="gidendeara_TextChanged" 
                                                                                ValidationGroup="den"></asp:TextBox>
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2" 
                                                                style="height: 25px; background-color: #ffffff; text-align: left">
                                                                <asp:DataList ID="gidenmesajlistesi" runat="server" CellPadding="0" 
                                                                    Width="100%">
                                                                    <ItemStyle Height="30px" />
                                                                    <ItemTemplate>
                                                                        <table cellpadding="0" cellspacing="0" 
                                                                            style="width: 100%; border-bottom: #000000 1px dotted">
                                                                            <tr>
                                                                                <td style="width: 30px; height: 31px; text-align: center">
                                                                                    <asp:CheckBox ID="gidensec" runat="server" />
                                                                                </td>
                                                                                <td style="width: 25px; height: 31px; text-align: left">
                                                                                </td>
                                                                                <td style="width: 10px; height: 31px; text-align: left">
                                                                                </td>
                                                                                <td style="width: 399px; height: 31px; text-align: left">
                                                                                    <asp:LinkButton ID="gidenkonu" runat="server" Font-Bold="False" 
                                                                                        Font-Italic="True" Font-Names="Calibri" Font-Size="12px" Font-Underline="False" 
                                                                                        ForeColor="Navy" OnCommand="gidenkonu_Command"></asp:LinkButton>
                                                                                </td>
                                                                                <td style="width: 150px; height: 31px; text-align: left">
                                                                                    <asp:Label ID="gidistarih" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                                        Font-Names="Calibri" Font-Size="12px" Font-Underline="False" ForeColor="Black"></asp:Label>
                                                                                    <asp:Label ID="gidenmesajID" runat="server" Font-Italic="True" 
                                                                                        Font-Names="Calibri" Font-Size="12px" Visible="False"></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </ItemTemplate>
                                                                </asp:DataList>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="gidenmesajoku" runat="server" Visible="False" Width="100%">
                            <br />
                            &nbsp; &nbsp;&nbsp;
                            <asp:LinkButton ID="gidenmesajsil" runat="server" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="12px" Font-Underline="True" ForeColor="Maroon" OnClientClick="return confirm('Mesajı Silmek İstediğinize Emin  Misiniz?')"
                                OnCommand="gidenmesajsil_Command" Font-Italic="True">Mesajı Sil</asp:LinkButton>
                            |
                            <asp:LinkButton ID="gidenedon" runat="server" Font-Bold="False" Font-Names="Calibri"
                                Font-Size="12px" Font-Underline="True" ForeColor="Maroon" OnClick="gidenedon_Click" Font-Italic="True">Toplu Mailllere Geri Dön</asp:LinkButton>
                            <asp:Label ID="mesajokumesajid2" runat="server" Visible="False" Font-Italic="True" Font-Names="Calibri" Font-Underline="True" ForeColor="Maroon"></asp:Label>
                            <asp:Label ID="mesajialan" runat="server" Visible="False" Font-Italic="True" Font-Names="Calibri" Font-Underline="True" ForeColor="Maroon"></asp:Label><br />
                            <br />
                            <table cellpadding="1" cellspacing="0" width="100%">
                                <tr>
                                    <td style="font-size: 13px; width: 125px; color: #000000; font-family: calibri; height: 30px; font-style: italic;"
                                        valign="top">
                                        &nbsp; &nbsp; &nbsp; Alıcı<span style="font-size: 12px; font-family: Tahoma"> : </span>
                                    </td>
                                    <td style="width: 567px; height: 30px" valign="top">
                                        <em><span style="font-family: Calibri">Tüm Üyeler</span></em></td>
                                    <td rowspan="7" valign="top">
                                        <span style="font-size: 12px; color: #ff0000; font-family: Tahoma"></span><span style="font-size: 9pt;
                                            color: #ff0000; font-family: Tahoma"></span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="font-size: 13px; width: 125px; color: #000000; font-family: calibri; height: 30px; font-style: italic;"
                                        valign="top">
                                        &nbsp; &nbsp; &nbsp; Tarih :</td>
                                    <td style="width: 567px; height: 30px" valign="top">
                                        <asp:Label ID="mesajokutarih2" runat="server" Font-Names="Calibri" Font-Size="12px"
                                            ForeColor="Black" Font-Italic="True"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="font-size: 13px; width: 125px; color: #000000; font-family: calibri; height: 30px; font-style: italic;"
                                        valign="top">
                                        &nbsp; &nbsp;&nbsp; &nbsp;Konu :
                                    </td>
                                    <td style="width: 567px; height: 30px" valign="top">
                                        <asp:Label ID="mesajokukonu2" runat="server" Font-Names="Calibri" Font-Size="12px"
                                            ForeColor="Black" Font-Italic="True"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="font-size: 13px; width: 125px; color: #000000; font-family: calibri; height: 30px; font-style: italic;"
                                        valign="top">
                                        &nbsp; &nbsp; &nbsp; Mesaj :</td>
                                    <td rowspan="4" style="width: 567px" valign="top">
                                        <asp:Label ID="mesajokumesaj2" runat="server" Font-Names="Calibri" Font-Size="12px"
                                            ForeColor="Black" Font-Italic="True"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="font-size: 12px; width: 125px; color: #000099; font-family: Tahoma; height: 26px"
                                        valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="font-size: 12px; width: 125px; color: #000099; font-family: Tahoma; height: 26px"
                                        valign="top">
                                        &nbsp;&nbsp;</td>
                                </tr>
                                <tr>
                                    <td style="font-size: 12px; width: 125px; color: #000099; font-family: Tahoma" valign="top">
                                    </td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                        </span>
                </asp:Panel>
                <asp:Panel ID="forumpanel" runat="server" Width="100%" Visible="False">
                    <table align="center" cellpadding="1" cellspacing="1" width="95%">
                        <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                            <td colspan="3" style="text-align: left" valign="top">
                                <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                    border-bottom-color: gray" width="100%">
                                    <tr>
                                        <td style="background-color: aliceblue">
                                            <table cellpadding="0" cellspacing="0">
                                                <tr>
                                                    <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                        border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                        height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                        &nbsp;<asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Italic="True" 
                                                            Font-Names="Calibri" Font-Size="14px" ForeColor="DarkOrange" 
                                                            Text="Forum Ayarları"></asp:Label>
                                                        <span style="font-family: Calibri">&nbsp;</span></td>
                                                </tr>
                                            </table>
                                        </td>
                                        <td align="right" 
                                            style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                            valign="middle">
                                            <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="AbsMiddle" 
                                                ImageUrl="~/forum/imgs/save.png" OnClick="ImageButton1_Click" />
                                            &nbsp;<a href="#yeni"></a></td>
                                    </tr>
                                </table>
                                <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                    font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                    font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                    border-right-color: lightgrey" width="100%">
                                    <tr>
                                        <td style="text-align: justify">
                                            <table style="width: 100%">
                                                <tr>
                                                    <td style="width: 7px">
                                                    </td>
                                                    <td style="font-size: 13px; width: 251px; color: black; font-family: calibri; font-style: italic;">
                                                        Üyelik Yönetici Onayı İle Gerçekleşsin :
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="uyelik" runat="server" Font-Italic="True" 
                                                            Font-Names="Calibri" Font-Size="13px" />
                                                    </td>
                                                    <td style="width: 11px">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 7px">
                                                    </td>
                                                    <td style="font-size: 13px; width: 251px; color: black; font-family: calibri; font-style: italic;">
                                                        Konular Yönetici Onayı İle Açılabilsin :
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="cbkonu" runat="server" Font-Italic="True" 
                                                            Font-Names="Calibri" Font-Size="13px" />
                                                    </td>
                                                    <td style="width: 11px">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 7px">
                                                    </td>
                                                    <td style="font-size: 13px; width: 251px; color: black; font-family: calibri; font-style: italic;">
                                                        Cevaplar Yönetici Onayı İle Yayınlansın :
                                                    </td>
                                                    <td>
                                                        <asp:CheckBox ID="cbcevap" runat="server" Font-Italic="True" 
                                                            Font-Names="Calibri" Font-Size="13px" />
                                                    </td>
                                                    <td style="width: 11px">
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="width: 7px; height: 35px;">
                                                    </td>
                                                    <td style="width: 251px; height: 35px;">
                                                    </td>
                                                    <td style="height: 35px">
                                                        &nbsp;<asp:Label ID="ayarsnc" runat="server" Font-Italic="True" Font-Names="Calibri" 
                                                            Font-Size="13px"></asp:Label>
                                                    </td>
                                                    <td style="width: 11px; height: 35px;">
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="uyepanel" runat="server" Width="100%" Visible="False">
                    <span style="font-size: 9pt"><span style="font-family: Tahoma"><strong><span style="color: #000000">
                        <table align="center" cellpadding="1" cellspacing="1" width="95%">
                            <tr style="font-size: 12pt; color: #808080; font-family: Times New Roman">
                                <td colspan="3" style="text-align: left" valign="top">
                                    <table cellpadding="0" cellspacing="0" style="border-top: lightblue 1px solid; border-bottom-width: 1px;
                                        border-bottom-color: gray" width="100%">
                                        <tr>
                                            <td style="background-color: aliceblue">
                                                <table cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: lightgrey;
                                                            border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-color: lightgrey;
                                                            height: 25px; border-right-width: 1px; border-right-color: lightgrey">
                                                            &nbsp;<asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="14px" ForeColor="DarkOrange" 
                                                                Text="Onay Bekleyen Üyeler"></asp:Label>
                                                            <span style="font-size: 13px; font-family: Calibri"><em>(</em></span><asp:Label 
                                                                ID="Label4" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                Font-Names="Calibri" Font-Size="12px" ForeColor="Black"></asp:Label>
                                                            <span style="font-family: Calibri"><span style="font-size: 13px"><em>)<span>&nbsp;</span></em></span></span></td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td align="right" 
                                                style="font-size: 9pt; font-family: Calibri; background-color: aliceblue" 
                                                valign="bottom">
                                                <a href="#yeni"></a>
                                            </td>
                                        </tr>
                                    </table>
                                    <table cellpadding="5" cellspacing="2" style="border-top: lightgrey 1px solid; border-left-width: 1px;
                                        font-size: 9pt; border-left-color: lightgrey; border-bottom: lightgrey 1px solid;
                                        font-family: Calibri; background-color: ghostwhite; border-right-width: 1px;
                                        border-right-color: lightgrey" width="100%">
                                        <tr>
                                            <td style="text-align: justify">
                                                <asp:Label ID="snc" runat="server" Font-Bold="False" Font-Italic="True" 
                                                    Font-Size="13px"></asp:Label>
                                                <br />
                                                <asp:DataList ID="uyelist" runat="server" CellPadding="0" Width="100%">
                                                    <AlternatingItemStyle BackColor="WhiteSmoke" />
                                                    <ItemStyle BackColor="WhiteSmoke" Height="30px" />
                                                    <ItemTemplate>
                                                        <table cellpadding="0" cellspacing="0" 
                                                            style="width: 100%; border-bottom: #000000 1px dotted">
                                                            <tr>
                                                                <td colspan="4" style="height: 31px; text-align: left">
                                                                    &nbsp;<asp:Label ID="uyead" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                        Font-Names="Calibri" Font-Size="13px" ForeColor="Black"></asp:Label>
                                                                    <asp:Label ID="uyemail" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                        Font-Names="Calibri" Font-Size="13px" ForeColor="#000099"></asp:Label>
                                                                    <asp:Label ID="durum" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                        Font-Names="Calibri" Font-Size="13px" ForeColor="Red"></asp:Label>
                                                                </td>
                                                                <td style="width: 50px; height: 31px; text-align: left">
                                                                    <asp:Label ID="uye_id" runat="server" Font-Bold="False" Font-Italic="True" 
                                                                        Font-Names="Calibri" Font-Size="13px" Visible="False"></asp:Label>
                                                                </td>
                                                                <td style="width: 100px; height: 31px; text-align: left">
                                                                    <asp:ImageButton ID="imgsil" runat="server" ImageUrl="~/forum/imgs/silinen.png" 
                                                                        OnClientClick="return confirm('Üyelik Başvurusu İptal Edilcektir.Onaylıyor Musunuz?')" 
                                                                        OnCommand="imgsil_Command" />
                                                                    <asp:ImageButton ID="imgonay" runat="server" 
                                                                        ImageUrl="~/forum/imgs/yoneticiyetki.png" 
                                                                        OnClientClick="return confirm('Üyenin Hesabı Aktif Hale Gelecektir.Onaylıyor Musunuz?')" 
                                                                        OnCommand="imgonay_Command" />
                                                                    &nbsp;</td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                </asp:DataList>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                        <br />
                    </span> </strong></span></span></asp:Panel>
                <asp:Panel ID="sikayetpanel" runat="server" Width="100%">
                </asp:Panel>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
      <script language="javascript">



var config = new Object();    // create new config object

config.width = "100%";
config.height = "300px";
config.bodyStyle = 'background-color:white; border:0; font-family: "Tahoma"; font-size: x-small; ';
config.debug = 0;

// NOTE:  You can remove any of these blocks and use the default config!

config.toolbar = [
    ['fontname'],
    ['fontsize'],
    ['linebreak'],
    ['bold','italic','underline','separator'],
    ['strikethrough','subscript','superscript','separator'],
    ['justifyleft','justifycenter','justifyright','separator'],
    ['OrderedList','UnOrderedList','Outdent','Indent','separator'],
    ['forecolor','backcolor','separator'],
    ['HorizontalRule','Createlink','InsertTable','InsertImage','htmlmode','separator'],
   
];

config.fontnames = {
    "Tahoma":           "Tahoma, helvetica, sans-serif",
    "Courier New":     "courier new, courier, mono",
    "Georgia":         "Georgia, Times New Roman, Times, Serif",
    "Tahoma":          "Tahoma, Tahoma, Helvetica, sans-serif",
    "Times New Roman": "times new roman, times, serif",
    "Verdana":         "Verdana, Tahoma, Helvetica, sans-serif",
    "impact":          "impact",
    "WingDings":       "WingDings"
    
};
config.fontsizes = {
    "1 (10 px)":  "1",
    "2 (11 px)": "2",
    "3 (12 px)": "3",
    "4 (13 px)": "4",
    "5 (14 px)": "5",
    "6 (16 px)": "6",
    "7 (18 px)": "7"
  };
editor_generate('ctl00_ContentPlaceHolder1_mesaj',config);

</script>
</asp:Content>


