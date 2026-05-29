<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000004.aspx.cs" Inherits="administrator_ebebaba_pages_0000004" Theme="SkinFile"%>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager id="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <cc1:maskededitextender id="MaskedEditExtender1" runat="server" mask="0(999)999-99-99"
        targetcontrolid="evtel"></cc1:maskededitextender>
    <cc1:maskededitextender id="MaskedEditExtender2" runat="server" mask="0(999)999-99-99"
        targetcontrolid="istel"></cc1:maskededitextender>
    <cc1:maskededitextender id="MaskedEditExtender3" runat="server" mask="0(999)999-99-99"
        targetcontrolid="ceptel"></cc1:maskededitextender>


    <br />

   <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
               <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TR><TD 
style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2 valign="middle"><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TR><TD style="WIDTH: 202px; HEIGHT: 24px" 
vAlign=middle> &nbsp;<asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Yeni Doktor - Yönetici Kaydý"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>  &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:ImageButton ID="btnKaydet" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif"
        OnClick="btnKaydet_Click1" AlternateText="Doktor Kaydýný Tamamla" />&nbsp;</TD></TR></TABLE></TD></TR></TABLE>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                               <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" ForeColor="Black"></asp:Label><br />
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%">
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 16px" width="170">
                                            </td>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 16px" colspan="5">
                                                <span style="font-family: Tahoma"><span style="color: #ff0000">*</span> <span style="color: red">
                                                    ' lý alanlarýn doldurulmasý zorunludur.</span></span></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 16px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="170">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Adý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="doktor_adi" runat="server" SkinID="txtNormal" TabIndex="1" Width="120px" MaxLength="30"></asp:TextBox>
                                                <span style="color: #ff0000">*</span><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="doktor_adi"
                                                    Display="Dynamic" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Ev Tel :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="evtel" runat="server" Width="120px" SkinID="txtNormal" TabIndex="5" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="170">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="doktor_adi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö|.)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;" colspan="2">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="evtel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="170">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Soyadý :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="doktor_soyadi" runat="server" Width="120px" SkinID="txtNormal" TabIndex="2" MaxLength="30"></asp:TextBox>
                                                <span style="color: #ff0000">*</span>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="doktor_soyadi"
                                                    Display="Dynamic" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Ýþ Tel :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="istel" runat="server" Width="120px" SkinID="txtNormal" TabIndex="6" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="170">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;" colspan="2">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="doktor_soyadi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="istel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="170">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                E-Mail :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="email" runat="server" Width="120px" SkinID="txtNormal" TabIndex="3" MaxLength="40"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                Cep Tel :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="ceptel" runat="server" Width="120px" SkinID="txtNormal" TabIndex="7" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana" width="170">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email"
                                                    Display="Dynamic" ErrorMessage="Mail Adresi Geçerli Deðil !" SetFocusOnError="True"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="ceptel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="170">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;" valign="top">
                                                Adres :</td>
                                            <td colspan="4" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:TextBox ID="doktor_adres" runat="server" Width="384px" SkinID="txtGenisliksiz" TabIndex="4" MaxLength="30" Height="42px" TextMode="MultiLine"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana;">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right;" width="170">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                                Kullanýcý Adý :
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma">
                                                <asp:TextBox ID="kullanici_adi" runat="server" Width="120px" SkinID="txtOzel" TabIndex="8" MaxLength="25"></asp:TextBox>
                                                <span style="color: #ff0000">*</span>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="kullanici_adi"
                                                    Display="Dynamic" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"></asp:RequiredFieldValidator><asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Kullanýcý Adýnýn Kullanýlabilirliðini Denetle" ImageUrl="~/administrator_ebebaba_pages/images/kontrol.gif" CausesValidation="False" OnClick="ImageButton1_Click" ImageAlign="AbsMiddle" /><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/administrator_ebebaba_pages/images/auto.gif" AlternateText="Kullanýcý Adý Ve Þifreyi Otomatik Al" CausesValidation="False" OnClick="ImageButton2_Click" ImageAlign="AbsMiddle" /></td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana;">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right" width="170">
                                            </td>
                                            <td colspan="3" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="kullanici_adi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harf & Rakam Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö|[0-9])+"></asp:RegularExpressionValidator></td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right;" width="170">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                                Þifre :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                                <asp:TextBox ID="sifre" runat="server" Width="120px" SkinID="txtOzel" TabIndex="9" MaxLength="25"></asp:TextBox>
                                                <span style="color: #ff0000">*</span>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="sifre"
                                                    Display="Dynamic" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                                </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana;">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: right" width="170">
                                            </td>
                                            <td colspan="3" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="sifre"
                                                    Display="Dynamic" ErrorMessage="Sadece Harf & Rakam Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö|[0-9])+"></asp:RegularExpressionValidator></td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana;" width="170">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px;">
                                                <asp:CheckBox ID="yonetici_onay" runat="server" BorderColor="White"
                                                    BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" Height="22px" Text="Yönetici Yetkisi"
                                                    Width="132px" Font-Underline="False" Font-Bold="True" /></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana;">
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


