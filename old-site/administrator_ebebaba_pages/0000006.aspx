<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000006.aspx.cs" Inherits="administrator_ebebaba_pages_0000006" Theme="SkinFile"%>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager id="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <cc1:maskededitextender id="MaskedEditExtender1" runat="server" mask="0(999)999-99-99"
        targetcontrolid="ceptel"></cc1:maskededitextender>
    <cc1:maskededitextender id="MaskedEditExtender2" runat="server" mask="0(999)999-99-99"
        targetcontrolid="evtel"></cc1:maskededitextender>
    <cc1:maskededitextender id="MaskedEditExtender3" runat="server" mask="0(999)999-99-99"
        targetcontrolid="istel"></cc1:maskededitextender>


    <br />

   <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;" width="95%">
       <tr>
           <td valign="bottom">
               <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td colspan="2">
                           <table border="0" cellpadding="0" cellspacing="0" width="100%">
                               <tr>
                                   <td background="../imgs/ust_menu_bg.jpg" colspan="2" valign="middle">
                                       <table cellpadding="0" cellspacing="0" style="width: 100%">
                                           <tr>
                                               <td style="width: 202px; height: 24px" valign="middle">
                                                   &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Tahoma"
                                                       Font-Size="11px" Text="Doktor Bilgi Güncelleme"></asp:Label></td>
                                               <td style="height: 24px; text-align: right" valign="middle">
                                                   <asp:ImageButton ID="btnKaydet" runat="server" Enabled="False" ImageAlign="AbsMiddle"
                                                       ImageUrl="~/imgs/btnguncelle.gif" OnClick="btnKaydet_Click1" AlternateText="Bilgilerdeki Deðiþiklikleri Kaydet" />&nbsp;</td>
                                           </tr>
                                       </table>
                                   </td>
                               </tr>
                           </table>
                       </td>
                   </tr>
               </table>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                   &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" ForeColor="Black"></asp:Label><br />
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table width="100%" border="0" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td style="height: 28px; text-align: center;" colspan="7" valign="middle">
                                                <span style="color: darkgray"><span style="font-size: 11px; font-family: Tahoma"><strong>
                                                    <br />
                                                    Doktor Listesi</strong> :</span> </span>
                                                <asp:DropDownList ID="doktorList" runat="server" ValidationGroup="liste" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="doktorList_SelectedIndexChanged">
                                                </asp:DropDownList><br />
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="doktorList"
                                                    Display="Dynamic" ErrorMessage="Doktor Seçilmedi !" Font-Names="Tahoma" Font-Size="11px" SetFocusOnError="True"
                                                    ValidationGroup="liste" Font-Bold="True"></asp:RequiredFieldValidator></td>
                                        </tr>
                                    </table>
                                    <table width="100%">
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 10px" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 10px" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                Adý :
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="doktor_adi" runat="server" SkinID="txtNormal" TabIndex="1" Width="120px" MaxLength="30" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="doktor_adi"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                Ev Tel :
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="evtel" runat="server" Width="120px" SkinID="txtNormal" TabIndex="5" MaxLength="14" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="150">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="doktor_adi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö|.)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma" colspan="2">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="evtel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                Soyadý :</td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="doktor_soyadi" runat="server" Width="120px" SkinID="txtNormal" TabIndex="2" MaxLength="30" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="doktor_soyadi"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                Ýþ Tel :
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="istel" runat="server" Width="120px" SkinID="txtNormal" TabIndex="6" MaxLength="14" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma" colspan="2">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="doktor_soyadi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="istel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                E-Mail :</td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="email" runat="server" Width="120px" SkinID="txtNormal" TabIndex="3" MaxLength="40" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                Cep Tel :</td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="ceptel" runat="server" Width="120px" SkinID="txtNormal" TabIndex="7" MaxLength="14" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="150">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email"
                                                    Display="Dynamic" ErrorMessage="Mail Adresi Geçerli Deðil !" SetFocusOnError="True"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="ceptel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                Adres :</td>
                                            <td colspan="4" style="font-size: 11px; color: black; font-family: Tahoma;">
                                                <asp:TextBox ID="doktor_adres" runat="server" Width="384px" SkinID="txtNormal" TabIndex="4" MaxLength="30" Height="42px" TextMode="MultiLine" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right;" width="150">
                                                </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                Kullanýcý Adý :
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                <asp:TextBox ID="kullanici_adi" runat="server" Width="120px" SkinID="txtOzel" TabIndex="8" MaxLength="25" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="kullanici_adi"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right" width="150">
                                            </td>
                                            <td colspan="3" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="kullanici_adi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harf & Rakam Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö|[0-9])+"></asp:RegularExpressionValidator></td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right;" width="150">
                                                </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                Þifre :</td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                <asp:TextBox ID="sifre" runat="server" Width="120px" SkinID="txtOzel" TabIndex="9" MaxLength="25" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="sifre"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                                </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right; height: 16px;" width="150">
                                            </td>
                                            <td colspan="3" style="font-size: 11px; color: black; font-family: Tahoma; height: 16px;">
                                                </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; height: 16px;">
                                            </td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 16px;" width="100">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="150">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td colspan="4" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:CheckBox ID="doktoryetki" runat="server" BorderColor="Black"
                                                    BorderStyle="Solid" BorderWidth="0px" ForeColor="Black" Height="21px" Text="Doktor Yetkisi"
                                                    Width="110px" Enabled="False" Font-Bold="True" Font-Underline="False" />
                                                <asp:CheckBox ID="yoneticiyetki" runat="server" BorderColor="Black"
                                                    BorderStyle="Solid" BorderWidth="0px" ForeColor="Black" Height="21px" Text="Yönetici Yetkisi"
                                                    Width="110px" Enabled="False" Font-Bold="True" Font-Underline="False" /></td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="100">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                                <br />
                            </td>
                        </tr>
                    </table>
    <br />


</asp:Content>


