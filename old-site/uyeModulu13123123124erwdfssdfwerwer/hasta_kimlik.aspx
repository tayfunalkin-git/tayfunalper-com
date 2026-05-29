<%@ Page Language="C#"  EnableEventValidation = "false" ValidateRequest="false" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" Theme="skinFile" AutoEventWireup="true" CodeFile="hasta_kimlik.aspx.cs" Inherits="ivfyonetici_hasta_modulu_hasta_kimlik" %>

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
    <cc1:maskededitextender id="MaskedEditExtender4" runat="server" mask="0(999)999-99-99"
        targetcontrolid="cepteles"></cc1:maskededitextender>
    <br />
    
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
          <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 24px" 
background="images/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD style="WIDTH: 100px; HEIGHT: 24px" 
vAlign=middle> <asp:Label id="page_label" runat="server" Font-Size="11px" Font-Names="Arial" Font-Bold="True" Text="Kimlik Bilgileri"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>   &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<asp:ImageButton 
                              id="ImageButton10" onclick="ImageButton3_Click" runat="server" 
                              ImageUrl="~/imgs/btnguncelle.gif" 
                              AlternateText="Bilgileri Güncellemek Ýçin Kutularý Aç" ImageAlign="AbsBottom" 
                              CausesValidation="False" Visible="False" />
    <asp:ImageButton ID="btnKaydet" runat="server" AlternateText="Deðiþiklikleri Kaydet"
        ImageAlign="AbsBottom" ImageUrl="~/btn_kaydet.gif" OnClick="btnKaydet_Click1" />
    <img align="absMiddle" src="images/guncelleyenler.gif"  
                              onclick ="window.open('hasta_kimlik_guncelleme_bilgi.aspx','','width=460,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')" 
                              style="cursor:hand;" alt="Hasta Bilgilerini Güncelleyenler Listesi" />&nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%">
                   <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;">
                       <tr>
                           <td style="height: 30px; background-color: white; text-align: center">
                               <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label></td>
                       </tr>
                   </table>
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td style="height: 77px; border-top-width: 1px; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top">
                                <div align="left">
                                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="98%">
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 136px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 43px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 139px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 20px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Adý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                <asp:TextBox ID="hasta_adi" runat="server" SkinID="txtNormal" TabIndex="1" Width="77px" MaxLength="30" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="hasta_adi"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Ev Tel :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana">
                                                <asp:TextBox ID="evtel" runat="server" Width="115px" SkinID="txtNormal" 
                                                    TabIndex="5" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="hasta_adi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: arial; width: 170px;" colspan="2">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="evtel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Soyadý :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                <asp:TextBox ID="hasta_soyadi" runat="server" Width="115px" SkinID="txtNormal" TabIndex="2" MaxLength="30" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="hasta_soyadi"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Ýþ Tel :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana">
                                                <asp:TextBox ID="istel" runat="server" Width="115px" SkinID="txtNormal" 
                                                    TabIndex="6" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="hasta_soyadi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="istel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Doðum Tarihi :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                <asp:TextBox ID="hasta_dt" runat="server" Width="115px" SkinID="txtNormal" TabIndex="3" MaxLength="10" Enabled="False"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="hasta_dt"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Verdana" Font-Size="14px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Cep Tel :</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana">
                                                <asp:TextBox ID="ceptel" runat="server" Width="115px" SkinID="txtNormal" 
                                                    TabIndex="7" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="hasta_dt"
                                                    Display="Dynamic" ErrorMessage="Ör : Doðum Tarihi Formatý 24.05.1975 veya 240575"
                                                    SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d)|(\d\d\d\d\d\d)"
                                                    Width="100%"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="ceptel"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Eþinin Adý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                <asp:TextBox ID="hasta_es_adi" runat="server" Width="115px" SkinID="txtNormal" TabIndex="3" MaxLength="30" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Cep Tel (Eþi) :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana">
                                                <asp:TextBox ID="cepteles" runat="server" Width="115px" SkinID="txtNormal" 
                                                    TabIndex="8" MaxLength="14"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="hasta_es_adi"
                                                    Display="Dynamic" ErrorMessage="Sadece Harfleri Kullanýnýz." SetFocusOnError="True"
                                                    ValidationExpression="([A-Z]|[a-z]|\s|ð|ü|ý|þ|i|ç|ö|Ð|Ü|Ý|Þ|Ç|Ö)+"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="cepteles"
                                                    Display="Dynamic" ErrorMessage="Geçersiz Telefon Formatý" ValidationExpression="\d{10}" SetFocusOnError="True"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                Eþinin Yaþý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                <asp:TextBox ID="hasta_es_yas" runat="server" Width="30px" SkinID="txtNormal" 
                                                    TabIndex="4" MaxLength="2"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                                E - Mail :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana">
                                                <asp:TextBox ID="email" runat="server" Width="115px" SkinID="txtNormal" 
                                                    TabIndex="9" MaxLength="40"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="hasta_es_yas"
                                                    Display="Dynamic" ErrorMessage="Yaþ Deðeri 18 - 80 Arasý Olmalýdýr." MaximumValue="80"
                                                    MinimumValue="18" Type="Integer"></asp:RangeValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: arial; width: 170px;">
                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email"
                                                    Display="Dynamic" ErrorMessage="Mail Adresi Geçerli Deðil !" SetFocusOnError="True"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 15px;
                                                text-align: right">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 15px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 16px;
                                                text-align: right">
                                            </td>
                                            <td colspan="5" style="font-size: 11px; color: black; font-family: arial;
                                                background-color: ghostwhite; text-align: center">
                                                Kilosu :
                                                <asp:TextBox ID="kilo" runat="server" MaxLength="3" SkinID="txtkucuk" 
                                                    Width="9px"></asp:TextBox>
                                                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="kilo"
                                                    Display="Dynamic" ErrorMessage="Kilo Deðeri 40-100 Arasý Olmalýdýr." MaximumValue="100"
                                                    MinimumValue="40" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
                                                &nbsp; &nbsp;Boyu :
                                                <asp:TextBox ID="boy" runat="server" MaxLength="4" SkinID="txtkucuk" 
                                                    Width="9px"></asp:TextBox>
                                                <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="boy" Display="Dynamic"
                                                    ErrorMessage="Boy Formatý : 1xx" MaximumValue="199" MinimumValue="100" SetFocusOnError="True"
                                                    Type="Integer"></asp:RangeValidator></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 16px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 16px;
                                                text-align: right">
                                            </td>
                                            <td colspan="5" style="font-size: 11px; color: black; font-family: arial;
                                                background-color: aliceblue; text-align: center">
                                                G :
                                                <asp:TextBox ID="sg" runat="server" MaxLength="2" SkinID="txtkucuk" Width="9px" Enabled="False"></asp:TextBox>
                                                &nbsp;&nbsp; P :
                                                <asp:TextBox ID="sp" runat="server" MaxLength="2" SkinID="txtkucuk" Width="9px" Enabled="False"></asp:TextBox>
                                                &nbsp;&nbsp; A :
                                                <asp:TextBox ID="sa" runat="server" MaxLength="2" SkinID="txtkucuk" Width="9px" Enabled="False"></asp:TextBox>
                                                &nbsp; &nbsp;C :
                                                <asp:TextBox ID="sc" runat="server" MaxLength="2" SkinID="txtkucuk" Width="9px" Enabled="False"></asp:TextBox>
                                                &nbsp;&nbsp; E :
                                                <asp:TextBox ID="se" runat="server" MaxLength="2" SkinID="txtkucuk" Width="9px" Enabled="False"></asp:TextBox></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 16px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 17px;
                                                text-align: right">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana; height: 17px">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 17px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 15px; text-align: right;">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                                Kullanýcý Adý :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                                <asp:TextBox ID="kullanici_adi" runat="server" Width="115px" SkinID="txtOzel" TabIndex="10" MaxLength="25" Enabled="False"></asp:TextBox>
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: arial;">
                                                Þifre :
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana;">
                                                <asp:TextBox ID="sifre" runat="server" Width="115px" SkinID="txtOzel" 
                                                    TabIndex="11" MaxLength="25"></asp:TextBox>
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 15px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; text-align: right">
                                            </td>
                                            <td colspan="5" style="font-size: 11px; color: black; font-family: verdana">
                                                &nbsp;</td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 15px; text-align: right;">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana;">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana;">
                                                &nbsp;</td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana;">
                                                </td>
                                            <td style="font-size: 11px; color: black; font-family: verdana;" colspan="2">
                                                <span style="font-size: 9px; color: darkgray">Þifre Güncellemesi sadece hastaya 
                                                aittir.</span></td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 15px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana;">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: gray; font-family: verdana">
                                                </td>
                                            <td style="font-size: 11px; width: 43px; color: gray; font-family: verdana;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: gray; font-family: verdana;">
                                            </td>
                                            <td style="font-size: 11px; width: 139px; color: gray; font-family: verdana;">
                                            </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana;">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                               </td>
                        </tr>
                    </table>
                    
    <br />
    
    
</asp:Content>



