<%@ Control Language="C#" AutoEventWireup="true" CodeFile="in_form.ascx.cs" Inherits="ivfyonetici_hasta_modulu_in_form" Debug="true" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>

<style type="text/css">
    .style2
    {
        width: 17px;
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
    }
    .style5
    {
        width: 79px;
    }
    .style6
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
    }
    .style9
    {
        width: 239px;
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
    }
    .style10
    {
        width: 79px;
        height: 45px;
    }
    .style11
    {
        width: 239px;
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
        height: 45px;
    }
    .style12
    {
        width: 17px;
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
        height: 45px;
    }
    .style13
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: 11px;
        height: 45px;
    }
    .style14
    {
        font-family: Arial, Helvetica, sans-serif;
        font-size: 10px;
        color: #FF0000;
    }
</style>

<table border="0" cellpadding="0" cellspacing="0" style="width: 96%" align=center>
        <tr>
            <td style="text-align: left; height: 67px;">
            
            <asp:Panel ID="form" runat="server" Visible="false" Width="99%" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px;
        border-left-width: 1px; border-left-color: #dcdcdc; border-bottom-width: 1px;
        border-bottom-color: #dcdcdc; border-top-color: #dcdcdc; border-right-width: 1px;
        border-right-color: #dcdcdc" width="100%">
                        <tr>
                            <td style="border-top-width: 1px;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3; text-align: center;" valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td style="border-bottom-width: 1px; border-bottom-color: #d3d3d3; font-size: 12pt; font-family: Times New Roman; height: 22px; border-top-width: 1px; border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="top">
                                            <asp:Panel ID="Panel2" runat="server" Width="100%">
                                                <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-style: none; border-right-style: none; border-left-style: none;" height="24">
                                                    <tr>
                                                        <td background="images/ust_menu_bg.jpg" style="width: 7px; height: 22px; text-align: left">
                                                        </td>
                                                        <td background="images/ust_menu_bg.jpg" style="width: 20px; height: 22px; text-align: left">
                                                            <img id="ac3" src="images/ac.gif" runat="server" onclick ="ac3();" style ="display:none" /><img id="kapa3" runat="server" src="images/kapat.gif" onclick ="kapa3();"/></td>
                                                        <td style="height: 22px; text-align: left;" background="images/ust_menu_bg.jpg">
                                                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px">Embriyoloji Lab Formu</asp:Label>&nbsp;</td>
                                                        <td style="text-align: right; height: 22px; font-size: 12pt; font-family: Times New Roman;" background="images/ust_menu_bg.jpg">
                                                            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                                                            <asp:ImageButton ID="btnKaydet" runat="server" 
                                                                ImageUrl="images/btnguncelle.gif" OnClick="btnKaydet_Click1" 
                                                                ImageAlign="AbsMiddle" Visible="False" />
                                                            <asp:ImageButton ID="d_kaydet" runat="server" ImageUrl="~/uye_modulu/images/btn_kaydet.gif" 
                                                                OnClick="d_kaydet_Click1" ImageAlign="AbsMiddle" ValidationGroup="ynmtc" 
                                                                Visible="False"/>
                                                            <asp:ImageButton ID="ipt" runat="server" ImageUrl="~/uye_modulu/images/btniptl.gif" 
                                                                OnClick="ipt_Click1" Visible="False" ImageAlign="AbsMiddle" />
                                                            &nbsp;
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Panel ID="Panel3" runat="server" Visible="False" Width="100%">
                                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;">
                                        <tr>
                                            <td style="height: 30px; text-align: center">
                                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    ForeColor="Black"></asp:Label>
                                                <asp:Label ID="lblHastaID" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblSiklusID" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblHastaAdi" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblSiklusAdi" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblSiklusTarihi" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblSiklusAy" runat="server" Visible="False"></asp:Label>
                                                <asp:Label ID="lblSiklusYil" runat="server" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                </td>
                        </tr>
                        <tr>
                            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top" id="Td1">
                              
                                <div id="gizlenecek3" runat="server" style="width:100%;display:block;">
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="durum" runat="server" 
                                        style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: 12px;"></asp:Label>
                                    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label7" runat="server" 
                                        style="font-size: 12px; font-weight: 700; font-family: Arial, Helvetica, sans-serif;"></asp:Label>
                                    <br />
                                  
  <asp:Panel ID="Panel4" runat="server">
                                        <table cellpadding="3" cellspacing="0" width="100%">
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    &nbsp;</td>
                                                <td class="style2">
                                                    &nbsp;</td>
                                                <td class="style6">
                                                    <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" 
                                                        style="color: #FF0000">Veritabanındaki Verileri Çek</asp:LinkButton> </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Yıl
                                                </td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl1" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt1" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Ay</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl2" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt2" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hafta
                                                </td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl3" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt3" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Sıra No</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl4" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt4" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Dosya No
                                                </td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl5" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt5" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hasta Adı Soyadı
                                                </td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl6" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt6" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Eşinin Adı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl7" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt7" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Tel No</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl8" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt8" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hastanın Yaşı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl9" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt9" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Kaçıncı Deneme</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl10" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt10" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Opu Gün</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl11" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt11" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Opu&nbsp; Ay</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl12" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt12" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Opu Yıl</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl13" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt13" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Sperm Hazırlama Methodu</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl14" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt14" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl15" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt15" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Enjekte Edilen Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl16" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt16" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Fertilize Olan Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl17" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt17" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    ET Günü</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl18" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt18" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transfer Edilen Birinci Emb.Blastomer Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl19" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt19" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transfer Edilen İkinci Emb.Blastomer Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl20" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt20" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transfer Edilen Embriyo Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl21" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt21" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Opu Yapan Doktor</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl22" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt22" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    ICSI Hasta Sırası</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl23" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt23" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9" valign="top">
                                                    Katater</td>
                                                <td class="style2" valign="top">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl24" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:ListBox ID="txt24" runat="server" Height="112px" SelectionMode="Multiple" 
                                                        Width="179px" AppendDataBoundItems="True" AutoPostBack="false"></asp:ListBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transfer Medyumu Lot No</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl25" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt25" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transfer Medyumu</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl26" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt26" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase yapan Embriyolog</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl27" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt27" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    ICSI Yapan Embriyolog</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl28" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt28" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transferi Yapan Doktor</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl29" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt29" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Kültür Lot No</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl30" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt30" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Kültür Medyumu</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl31" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt31" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9" valign="top">
                                                    Transfer Özelliği</td>
                                                <td class="style2" valign="top">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl32" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:ListBox ID="txt32" runat="server" Height="112px" Width="179px" 
                                                        SelectionMode="Multiple">
                                                    </asp:ListBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Kriyo Yapılan / Yapılabilecek Embriyo Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl33" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt33" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Kriyo Notu</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl77" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt77" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False" Width="200px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Transferi Yapan Embriyolog</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl34" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt34" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9" valign="top">
                                                    İlaç</td>
                                                <td class="style2" valign="top">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl35" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:ListBox ID="txt35" runat="server" Height="112px" Width="179px" 
                                                        SelectionMode="Multiple">
                                                    </asp:ListBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    İlk B-Hcg</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl36" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt36" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Gebelik</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl37" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt37" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    İmplantasyon</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl38" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt38" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Ongoing Gebelik</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl39" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt39" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Doğan Bebek Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl40" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt40" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    ICSI Pipeti</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl41" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:DropDownList ID="txt41" runat="server" SkinID="drop" Visible="False">
                                                    </asp:DropDownList>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    ICSI Lot</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl42" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt42" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    AHA</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl43" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt43" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Siklus Tipi</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl44" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:ListBox ID="txt44" runat="server" Height="112px" SelectionMode="Multiple" 
                                                        Width="179px"></asp:ListBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Stimülasyon Gün Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl45" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt45" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    E2</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl46" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt46" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    HCG Günü Endometriyum</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl47" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt47" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Male Endikasyon</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl48" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:ListBox ID="txt48" runat="server" Height="112px" Width="179px" 
                                                        SelectionMode="Multiple">
                                                    </asp:ListBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Female Endikasyon</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl49" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:ListBox ID="txt49" runat="server" Height="112px" Width="179px" 
                                                        SelectionMode="Multiple">
                                                    </asp:ListBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl50" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt50" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase Sonrası MII Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl51" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt51" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase Sonrası MI Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl52" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt52" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase Sonrası GV Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl53" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt53" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase Sonrası Empty Zona Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl54" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt54" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase Sonrası Defekt Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl55" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt55" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hyase Sonrası Kayıp Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl56" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt56" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    OPU Günü ICSI Uygulanan MII Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl57" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt57" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    OPU Günü ICSI Uygulanan MI Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl58" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt58" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVF Sonrası Uygulanan Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl59" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt59" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVF Sonrası Uygulanan MII Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl60" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt60" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVF Sonrası Fertilize Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl61" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt61" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVM Sonrası ICSI Uygulanan Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl62" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt62" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVM Sonrası Fertilize Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl63" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt63" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" style="display:none" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVM Sonrası Fertilize Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl64" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt64" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total 1 PN Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl65" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt65" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total 2 PN Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl66" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt66" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total 3 PN ve &gt; Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl67" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt67" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total Dejenere Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl68" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt68" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total Fertilize Oosit Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl69" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt69" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    1.Gün Yarıklanma Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl70" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt70" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    IVM Sonrası Yarıklanma Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl71" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt71" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Total Yarıklanma</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl72" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt72" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Hastanın G1 Embriyo Sayısı</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl73" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt73" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9">
                                                    Katater Lot</td>
                                                <td class="style2">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl74" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt74" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style5">
                                                    &nbsp;</td>
                                                <td class="style9" valign="top">
                                                    Not</td>
                                                <td class="style2" valign="top">
                                                    :</td>
                                                <td class="style6">
                                                    <asp:Label ID="lbl75" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt75" runat="server" Height="130px" SkinID="txtsiklus" 
                                                        TextMode="MultiLine" ValidationGroup="ynmtc" Visible="False" Width="368px"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style10">
                                                    &nbsp;</td>
                                                <td class="style11" valign="top">
                                                    G2 Embriyo Sayısı</td>
                                                <td class="style12" valign="top">
                                                    :</td>
                                                <td class="style13" valign="top">
                                                    <asp:Label ID="lbl76" runat="server" style="font-weight: 700"></asp:Label>
                                                    <asp:TextBox ID="txt76" runat="server" SkinID="txtsiklus" 
                                                        ValidationGroup="ynmtc" Visible="False"></asp:TextBox>
                                                </td>
                                            </tr>
                                            <tr onclick="this.bgColor='#EEEEEE'" onMouseout="this.bgColor='#FFFFFF'" 
                                                onMouseover="this.bgColor='#EEEEEE'">
                                                <td class="style10">
                                                </td>
                                                <td class="style11" valign="top">
                                                </td>
                                                <td class="style12" valign="top">
                                                </td>
                                                <td class="style13">
                                                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Kaydet" 
                                                        Visible="False" />
                                                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                                                        Text="Güncelle" />
                                                    &nbsp;<asp:Button ID="iptal" runat="server" onclick="iptal_Click" Text="İptal" 
                                                        Visible="False" />
                                                    &nbsp;<asp:Label ID="Label6" runat="server" 
                                                        style="font-size: 12px; font-weight: 700"></asp:Label>
                                                </td>
                                            </tr>
                                        </table>
                                    </asp:Panel>
                               
                                    <br />


                                    

                                  
                                    <br />
                                    <br />
                                </div>
                                
                            </td>
                        </tr>
                    </table>
                    
                </asp:Panel>
            </td>
        </tr>
    </table>
<br />


