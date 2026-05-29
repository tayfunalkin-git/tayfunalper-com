<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000420.aspx.cs" Inherits="ivfyonetici_0000070" Debug="true" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<script language=javascript>

function ac(gelen)
{

document.getElementById('ctl00_ContentPlaceHolder1_ac'+gelen).style.display = "none";
document.getElementById('ctl00_ContentPlaceHolder1_kapat'+gelen).style.display = "block";
document.getElementById('ctl00_ContentPlaceHolder1_detaysnc'+gelen).style.display = "block";
document.getElementById('ctl00_ContentPlaceHolder1_td'+gelen).style.display =  "block";
}


function kapat(gelen)
{

document.getElementById('ctl00_ContentPlaceHolder1_ac'+gelen).style.display = "block";
document.getElementById('ctl00_ContentPlaceHolder1_kapat'+gelen).style.display = "none";
document.getElementById('ctl00_ContentPlaceHolder1_detaysnc'+gelen).style.display =  "none";
document.getElementById('ctl00_ContentPlaceHolder1_td'+gelen).style.display =  "none";
}



</script>
    <script src="jquery.min.js"></script>
    <link type="text/css" href="window/css/jquery.window.css" rel="stylesheet" />
      <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.9/jquery-ui.min.js"></script>
    <script type="text/javascript" src="window/jquery.window.js"></script>
	<script type="text/javascript">
	    function createWindow(link, baslik, genislik, yukseklik, mesaj) {
	        $.window({

	            title: baslik,
	            url: link,
	            iframeRedirectCheckMsg: mesaj,
	            width: genislik,
	            height: 600,
	            modalOpacity: 0.5,
	            showModal: true,
	            showFooter: false,
	            bookmarkable: false,
	            withinBrowserWindow: true

	        });
	    }
	</script>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 100%; border-right: black 0px solid; border-top: black 0px solid; border-left: black 0px solid; border-bottom: black 0px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="top">
               <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 33px">
                           <table cellpadding="0" cellspacing="0" style="width: 100%">
                               <tr>
                                   <td style="width: 260px; height: 24px;" valign="middle">
                                       &nbsp; <asp:Label ID="page_label" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" Text="Çalýþma Takip Yeni" style="font-size: 12px"></asp:Label></td>
                                   <td style="height: 24px; text-align: right;" valign="middle">
                                   &nbsp;

                               
                               </tr>
                           </table>
                       </td>
                   </tr>
               </table>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                               <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label></asp:Panel>

                     </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table style="width: 90%" align="center">
                                        <tr>
                                            <td style="width: 9px; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; width: 84px; color: black; font-family: Arial; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; width: 6px; color: black; font-family: Arial; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; width: 115px; color: black; font-family: Arial; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; width: 77px; color: black; font-family: Arial; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; width: 95px; color: black; font-family: Arial; height: 10px">
                                                <asp:DropDownList ID="goruntu" runat="server" SkinID="drop" Visible="False">
                                                    <asp:ListItem Value="+" Selected="True">Pozitif</asp:ListItem>
                                                    <asp:ListItem Value="-">Negatif</asp:ListItem>
                                                </asp:DropDownList>
                                            </td>
                                            <td style="font-size: 11px; width: 7px; color: black; font-family: Arial; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 10px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 84px; height: 20px;">
                                                Kurum</td>
                                            <td style="font-size: 11px; width: 6px; color: black; font-family: Arial; height: 20px;">
                                                :</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 115px; height: 20px;">
                                                <asp:DropDownList ID="txtkurum" runat="server" SkinID="drop">
                                                </asp:DropDownList></td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 77px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 95px; height: 20px;">
                                                Baþlangýç Tarihi</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 7px; height: 20px;">
                                                :</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 20px;">
                                                <asp:DropDownList ID="baslangicay" runat="server" SkinID="drop">
                                                    <asp:ListItem Value="01">Ocak</asp:ListItem>
                                                    <asp:ListItem Value="02">Þubat</asp:ListItem>
                                                    <asp:ListItem Value="03">Mart</asp:ListItem>
                                                    <asp:ListItem Value="04">Nisan</asp:ListItem>
                                                    <asp:ListItem Value="05">Mayýs</asp:ListItem>
                                                    <asp:ListItem Value="06">Haziran</asp:ListItem>
                                                    <asp:ListItem Value="07">Temmuz</asp:ListItem>
                                                    <asp:ListItem Value="08">Aðustos</asp:ListItem>
                                                    <asp:ListItem Value="09">Eyl&#252;l</asp:ListItem>
                                                    <asp:ListItem Value="10">Ekim</asp:ListItem>
                                                    <asp:ListItem Value="11">Kasým</asp:ListItem>
                                                    <asp:ListItem Value="12">Aralýk</asp:ListItem>
                                                </asp:DropDownList>&nbsp;<asp:DropDownList ID="baslangicyil" runat="server" SkinID="drop">
                                                          <asp:ListItem>2017</asp:ListItem>
                                                    <asp:ListItem>2018</asp:ListItem>
                                                    <asp:ListItem>2019</asp:ListItem>
                                                    <asp:ListItem>2020</asp:ListItem>
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 84px; height: 20px;">
                                                Tedavi Türü</td>
                                            <td style="font-size: 11px; width: 6px; color: black; font-family: Arial; height: 20px;">
                                                :</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 115px; height: 20px;">
                                                <asp:DropDownList ID="txttedavituru" runat="server" SkinID="drop">
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="renk" runat="server" SkinID="drop" Visible="False">
                                                </asp:DropDownList></td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 77px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 95px; height: 20px;">
                                                Bitiþ Tarihi</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 7px; height: 20px;">
                                                :</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 20px;">
                                                <asp:DropDownList ID="bitisay" runat="server" SkinID="drop">
                                                    <asp:ListItem Value="01">Ocak</asp:ListItem>
                                                    <asp:ListItem Value="02">Þubat</asp:ListItem>
                                                    <asp:ListItem Value="03">Mart</asp:ListItem>
                                                    <asp:ListItem Value="04">Nisan</asp:ListItem>
                                                    <asp:ListItem Value="05">Mayýs</asp:ListItem>
                                                    <asp:ListItem Value="06">Haziran</asp:ListItem>
                                                    <asp:ListItem Value="07">Temmuz</asp:ListItem>
                                                    <asp:ListItem Value="08">Aðustos</asp:ListItem>
                                                    <asp:ListItem Value="09">Eyl&#252;l</asp:ListItem>
                                                    <asp:ListItem Value="10">Ekim</asp:ListItem>
                                                    <asp:ListItem Value="11">Kasým</asp:ListItem>
                                                    <asp:ListItem Value="12">Aralýk</asp:ListItem>
                                                </asp:DropDownList>&nbsp;<asp:DropDownList ID="bitisyil" runat="server" SkinID="drop">
                                                          <asp:ListItem>2017</asp:ListItem>
                                                    <asp:ListItem>2018</asp:ListItem>
                                                    <asp:ListItem>2019</asp:ListItem>
                                                    <asp:ListItem>2020</asp:ListItem>
                                                </asp:DropDownList></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 84px; height: 20px;">
                                                Tedavi Protokolü</td>
                                            <td style="font-size: 11px; width: 6px; color: black; font-family: Arial; height: 20px;">
                                                :</td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 115px; height: 20px;">
                                                <asp:DropDownList ID="txttedaviprotokolu" runat="server" SkinID="drop">
                                                </asp:DropDownList></td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 77px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 95px; height: 20px;">
                                                Süzgeç
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; width: 7px; height: 20px;">
                                                :</td>
                                            <td style="font-size: 11px; width: 107px; color: black; font-family: Arial; height: 20px;">
                                                <asp:RadioButtonList ID="suzgec" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                                    <asp:ListItem Selected="True">Aylýk</asp:ListItem>
                                                    <asp:ListItem>Yýllýk</asp:ListItem>
                                                </asp:RadioButtonList></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 24px">
                                            </td>
                                            <td style="width: 84px; height: 24px">
                                                <span style="font-size: 11px; font-family: Arial">Siklus Doktoru</span></td>
                                            <td style="width: 6px; height: 24px">
                                                <span style="font-size: 11px; font-family: Arial">:</span></td>
                                            <td style="width: 115px; height: 24px">
                                                <asp:DropDownList ID="drp_dr" runat="server" SkinID="drop">
                                                </asp:DropDownList></td>
                                            <td style="width: 77px; height: 24px">
                                            </td>
                                            <td style="font-family: arial, Helvetica, sans-serif; font-size: 11px;">
                                                Adres ili / ilçesi</td>
                                            <td style="font-family: arial, Helvetica, sans-serif;">
                                                :</td>
                                            <td valign="top">
                                                <asp:TextBox ID="adres" runat="server" Width="217px"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr valign="top">
                                            <td style="width: 9px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 84px; height: 24px">
                                                <span style="font-size: 11px; font-family: Arial">Dýþ Doktor</span></td>
                                            <td style="width: 6px; height: 24px">
                                                :</td>
                                            <td style="width: 115px; height: 24px">
                                                <asp:DropDownList ID="drp_dis" runat="server" SkinID="drop">
                                                </asp:DropDownList></td>
                                            <td style="width: 77px; height: 24px">
                                                &nbsp;</td>
                                            <td style="font-family: arial, Helvetica, sans-serif; font-size: 11px;" rowspan="2">
                                                Kaynak </td>
                                            <td style="font-family: arial, Helvetica, sans-serif;" rowspan="2">
                                                :</td>
                                            <td rowspan="2" valign="top">
                                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                                    <ContentTemplate>
                                                        <asp:DropDownList ID="kaynak" runat="server" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="kaynak_SelectedIndexChanged">
                                                            <asp:ListItem Value="">Seçiniz</asp:ListItem>
                                                            <asp:ListItem Value="H">Hastamýz</asp:ListItem>
                                                            <asp:ListItem Value="K">Kadýn Doðum Dr.</asp:ListItem>
                                                            <asp:ListItem Value="D">Diðer Dr.</asp:ListItem>
                                                            <asp:ListItem Value="S">Saðlýk Çalýþaný</asp:ListItem>
                                                            <asp:ListItem Value="M">Medya</asp:ListItem>
                                                        </asp:DropDownList>
                                                        <asp:DropDownList ID="drpH" runat="server" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="drpH_SelectedIndexChanged" Visible="False">
                                                        </asp:DropDownList>
                                                        <asp:DropDownList ID="drpK" runat="server" SkinID="drop" Visible="False">
                                                        </asp:DropDownList>
                                                        <asp:DropDownList ID="drpD" runat="server" SkinID="drop" Visible="False">
                                                        </asp:DropDownList>
                                                        <asp:DropDownList ID="drpS" runat="server" SkinID="drop" Visible="False">
                                                        </asp:DropDownList>
                                                        <asp:DropDownList ID="drpM" runat="server" SkinID="drop" Visible="False">
                                                        </asp:DropDownList>
                                                        <br />
                                                        <asp:RadioButton ID="bilinmeyen" runat="server" AutoPostBack="True" OnCheckedChanged="bilinmeyen_CheckedChanged" Text="Ýsmini bilmediði bir hastamýz" Font-Names="Arial" style="font-size: 11px" Visible="False" />
                                                        <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel2" DisplayAfter="300">
                                                            <ProgressTemplate>
                                                                <img src="loading.gif" style="width: 25px; height: 25px" />
                                                            </ProgressTemplate>
                                                        </asp:UpdateProgress>
                                                    </ContentTemplate>
                                                </asp:UpdatePanel>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 84px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 6px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 115px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 77px; height: 24px">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 84px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 6px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 115px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 77px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 95px; height: 24px">
                                                &nbsp;</td>
                                            <td style="width: 7px; height: 24px">
                                                &nbsp;</td>
                                            <td style="height: 24px">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 30px;">
                                            </td>
                                            <td style="font-family: arial, Helvetica, sans-serif; font-size: 11px;">
                                                Ýnfertilite
                                            </td>
                                            <td style="font-family: arial, Helvetica, sans-serif; font-size: 11px;">
                                                :</td>
                                            <td style="height: 30px" colspan="5">
                                                <asp:Button ID="Button1" runat="server" Text="Tüm Sikluslar" OnClick="Button1_Click" Width="150px" />&nbsp;<asp:Button
                                                    ID="Button3" runat="server" Text="Tüm OPU'lar"
                                                    Width="150px" OnClick="Button3_Click" />&nbsp;<asp:Button
                                                    ID="Button4" runat="server" OnClick="Button4_Click" Text="Çalýþma Takip (Ýnfertilite)"
                                                    Width="220px" />
                                                &nbsp;<asp:DropDownList ID="drp_dr2" runat="server" SkinID="drop" Visible="False">
                                                </asp:DropDownList>&nbsp;<asp:CheckBox ID="ckt" runat="server" Font-Names="Arial" Font-Size="13px" Text="Kayýt Tarihi Eksik Olanlar" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 30px;">
                                                &nbsp;</td>
                                            <td style="font-family: arial, Helvetica, sans-serif; font-size: 11px;">
                                                Erkek</td>
                                            <td style="font-family: arial, Helvetica, sans-serif; font-size: 11px;">
                                                :</td>
                                            <td style="height: 30px" colspan="5">
                                                <asp:Button
                                                    ID="Button6" runat="server" OnClick="Button6_Click" Text="Çalýþma Takip (Erkek)"
                                                    Width="220px" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="8" style="height: 30px; text-align: center">
                                                <asp:Label ID="Label42" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    ForeColor="#FF0000"></asp:Label></td>
                                        </tr>
                                    </table>
                                </div><asp:Panel ID="Panel1" runat="server" Visible="False" Width="100%" HorizontalAlign="Left">
                                    <br />
                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 33px">
                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                    <tr>
                                                        <td style="width: 196px; height: 24px; text-align: left;" valign="middle">
                                                            &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                Text="Sorgu Sonuçlarý" style="font-size: 12px"></asp:Label></td>
                                                        <td style="height: 24px; text-align: right;" valign="middle">
                                                            &nbsp;
                                                            
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp; &nbsp; &nbsp;
                                    <table style="width: 90%" align="center">
                                        <tr>
                                            <td style="width: 16px">
                                            </td>
                                            <td>
                                                <table id="headr" width="100%" runat="server" visible ="false">
                                                    <tr>
                                                        <td colspan="6" style="height: 35px; text-align: left" valign="middle">
                                                            <span style="color: firebrick; font-family: Arial"><strong>&nbsp; Tüp Bebek Merkezi - Gebelik &amp; Siklus Oraný
                                                                Sorgulama Sonuçlarý
                                                                <span style="font-size: 11px">( </span>
                                                                <asp:Label ID="Label33" runat="server" Font-Size="11px" Font-Bold="False" ForeColor="#000000"></asp:Label>
                                                                <span style="font-size: 11px">)</span></strong></span></td>
                                                    </tr>
                                                    <tr>
                                                        <td colspan="6" style="height: 11px; text-align: center" valign="middle">
                                                        </td>
                                                    </tr>
                                                </table>
                                    <table runat="Server" cellpadding="0" cellspacing="3" id="snc2" width="98%">
                                        <tr>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Kurum</td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Tedavi Türü</td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Tedavi Protokolü
                                            </td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Baþlangýç Tarihi</td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Bitiþ Tarihi</td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">Siklus Doktor</td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Dýþ Doktoru</td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; border-left: black 1px solid; color: white; border-bottom: black 1px solid;
                                                font-family: Arial; height: 21px; background-color: #5d7b9d">
                                                &nbsp;Süzgeç</td>
                                            <td style="border-top-width: 1px; border-left-width: 1px; font-size: 11px; border-left-color: black;
                                                border-bottom-width: 1px; border-bottom-color: black; color: black;
                                                border-top-color: black; font-family: Arial; height: 21px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;<asp:Label ID="Label28" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label></td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;<asp:Label ID="Label29" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label></td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;<asp:Label ID="Label30" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label></td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;<asp:Label ID="Label31" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label></td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;<asp:Label ID="Label32" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label></td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold; font-size: 11px; background-image: none; border-left: black 1px solid; color: black; border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                <asp:Label ID="Label34" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label>
                                            </td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;&nbsp;<asp:Label ID="Label76" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label>
                                            </td>
                                            <td style="border-right: black 1px solid; border-top: black 1px solid; font-weight: bold;
                                                font-size: 11px; background-image: none; border-left: black 1px solid; color: black;
                                                border-bottom: black 1px solid; font-family: Arial; height: 21px">
                                                &nbsp;<asp:Label ID="Label44" runat="server" Font-Bold="True" ForeColor="#3300CC"></asp:Label></td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 21px; font-weight: bold; background-image: none; border-top-width: 1px; border-left-width: 1px; border-left-color: black; border-bottom-width: 1px; border-bottom-color: black; border-top-color: black; border-right-width: 1px; border-right-color: black;">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                width: 118px; color: black; border-top-color: black; font-family: Arial; height: 17px;
                                                border-right-width: 1px; border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">&nbsp;</td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 17px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black; color: black; border-top-color: black; font-family: Arial; height: 17px;
                                                border-right-width: 1px; border-right-color: black">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                width: 118px; color: black; border-top-color: black; font-family: Arial; height: 14px;
                                                border-right-width: 1px; border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">&nbsp;</td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black;
                                                color: black; border-top-color: black; font-family: Arial; height: 14px; border-right-width: 1px;
                                                border-right-color: black">
                                            </td>
                                            <td align="left" style="border-top-width: 1px; border-left-width: 1px; font-size: 11px;
                                                border-left-color: black; border-bottom-width: 1px; border-bottom-color: black; color: black; border-top-color: black; font-family: Arial; height: 14px;
                                                border-right-width: 1px; border-right-color: black">
                                            </td>
                                        </tr>
                                    </table>
                                                <br />
                                                <br />
                                                <table align="center" width="900px">
                                                    <tr>
                                                        <td>

                                                            <asp:DataList ID="list" runat="server" ShowHeader="False">
                                                                <ItemTemplate>

                                                                    <asp:Panel ID="pnlOPU" runat="server">
                                                                    <table cellpadding="1" cellspacing="1" width="900px">
                                                                        <tr>
                                                        <td style="font-weight: bold; font-size: 11px; width: 180px; color: white;
                                                            font-family: arial; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label><br />
                                                            <br /><asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Black" Visible="false"></asp:Label><asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Red" Visible="false"></asp:Label>
                                                            <asp:Label ID="Label43" runat="server" ForeColor="White"></asp:Label>
                                                            <br />
                                                            <asp:ImageButton ID="ac" runat="server" ImageUrl="~/imgs/ac.gif" />
                                                            <asp:ImageButton ID="kapat" runat="server" Style="display:none;"  ImageUrl="~/imgs/kapat.gif" /></td>
                                                           <td style="border: 1px solid black; background-color: ghostwhite; text-align: center; ">
                                                               &nbsp;</td>
                                                                        </tr>
                                                                    </table>
                                                                    </asp:Panel>

                                                                                            <asp:GridView ID="detay2" runat="server" CellPadding="3" Font-Bold="False" Font-Names="Arial"
                                                                        Font-Size="11px" ForeColor="#333333" Width="900px" Style="display:none;"  AutoGenerateColumns="False" EnableModelValidation="True">
                                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                        <EditRowStyle BackColor="#999999" />
                                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                        <Columns>
                                                                         <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:ImageButton ID="edt" runat="server" ImageUrl="edit.png" />
                                                            </ItemTemplate>
                                                                             <ItemStyle Width="30px" />
                                                        </asp:TemplateField>
                                                                            <asp:TemplateField HeaderText="Adý ve Soyadý">
                                                                                <ItemTemplate>
                                                                                    <asp:LinkButton ID="lbAd" runat="server" Font-Underline="False" ForeColor="Black"></asp:LinkButton>
                                                                                </ItemTemplate>
                                                                                <ItemStyle Width="140px" />
                                                                            </asp:TemplateField>
                                                                            <asp:BoundField DataField="yas" HeaderText="Yaþ" ItemStyle-Width="20px">
                                                                            <ItemStyle Width="20px" />
                                                                            </asp:BoundField>
                                                                            <%--<asp:BoundField DataField="Siklus" HeaderText="Siklus" />--%>
                                                                            <asp:BoundField DataField="OPU" HeaderText="OPU" ItemStyle-Width="98px">
                                                                            <ItemStyle Width="98px" />
                                                                            </asp:BoundField>
                                                                            <asp:BoundField DataField="ET" HeaderText="ET" ItemStyle-Width="98px">
                                                                            <ItemStyle Width="98px" />
                                                                            </asp:BoundField>
                                                                            <asp:BoundField DataField="sDr" HeaderText="Siklus Doktoru" ItemStyle-Width="168px">
                                                                          
                                                                            <ItemStyle Width="168px" />
                                                                            </asp:BoundField>
                                                                          
                                                                            <asp:BoundField HeaderText="Dýþ Doktor" ItemStyle-Width="85px">
                                                                            <ItemStyle Width="85px" />
                                                                            </asp:BoundField>
                                                                            
                                                                        </Columns>
                                                                    </asp:GridView>
                                                                </ItemTemplate>
                                                                <HeaderTemplate>
                                                <table cellpadding="1" cellspacing="1">
                                                    <tr>
                                                        <td colspan="1" style="width: 215px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid;">
                                                            &nbsp; &nbsp;
                                                        </td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 108px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            OPU/Siklus</td>

                                                            <td 
                                                            style="font-weight: bold; font-size: 11px; width: 115px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            ET/Siklus</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 80px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            Gebelik<br />T. Gebelik</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 80px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            Devam Edenler</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 78px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                Biyokimyasal G / G</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 78px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                Abortus / G</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 80px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            Doðum / G&nbsp;</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 84px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            Çoðul G / G</td>
                                                        <td 
                                                            style="font-weight: bold; font-size: 11px; width: 77px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                            Hiperstim.</td>
                                                    </tr>
           
                                                </table>
                                                                </HeaderTemplate>
                                                            </asp:DataList>
                                                            <asp:DataList ID="list4" runat="server" ShowHeader="False" Visible="False">
                                                                <ItemTemplate>

                                                                    <asp:Panel ID="pnlTum" runat="server">
                                                                    <table cellpadding="1" cellspacing="1" width="900px">
                                                                        <tr>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 180px; color: white;
                                                            font-family: arial; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label77" runat="server" ForeColor="White"></asp:Label>
                                                                                <br />
                                                                                <br />
                                                                                <asp:Label ID="Label78" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black" Visible="false"></asp:Label>
                                                                                <asp:Label ID="Label79" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Red" Visible="false"></asp:Label>
                                                                                <asp:Label ID="Label80" runat="server" ForeColor="White"></asp:Label>
                                                                                <br />
                                                                                <asp:ImageButton ID="ac0" runat="server" ImageUrl="~/imgs/ac.gif" />
                                                                                <asp:ImageButton ID="kapat0" runat="server" ImageUrl="~/imgs/kapat.gif" Style="display:none;" />
                                                                            </td>
                                                                            <td style="border: 1px solid black; background-color: ghostwhite; text-align: center; ">&nbsp;</td>
                                                                        </tr>
                                                                    </table>
</asp:Panel>


                                                                    <asp:GridView ID="detay4" runat="server" AutoGenerateColumns="False" CellPadding="3" EnableModelValidation="True" Font-Bold="False" Font-Names="Arial" Font-Size="11px" ForeColor="#333333" Style="display:none;" Width="900px">
                                                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                        <EditRowStyle BackColor="#999999" />
                                                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                        <Columns>
                                                                            <asp:TemplateField>
                                                                                <ItemTemplate>
                                                                                    <asp:ImageButton ID="edt0" runat="server" ImageUrl="edit.png" />
                                                                                </ItemTemplate>
                                                                                <ItemStyle Width="30px" />
                                                                            </asp:TemplateField>
                                                                            <asp:TemplateField HeaderText="Adý ve Soyadý">
                                                                                <ItemTemplate>
                                                                                    <asp:LinkButton ID="lbAd0" runat="server" Font-Underline="False" ForeColor="Black"></asp:LinkButton>
                                                                                </ItemTemplate>
                                                                                <ItemStyle Width="140px" />
                                                                            </asp:TemplateField>
                                                                            <asp:BoundField DataField="yas" HeaderText="Yaþ" ItemStyle-Width="20px">
                                                                            <ItemStyle Width="20px" />
                                                                            </asp:BoundField>
                                                                            <%--<asp:BoundField DataField="Siklus" HeaderText="Siklus" />--%>
                                                                            <asp:BoundField DataField="OPU" HeaderText="OPU" ItemStyle-Width="98px">
                                                                            <ItemStyle Width="98px" />
                                                                            </asp:BoundField>
                                                                            <asp:BoundField DataField="ET" HeaderText="ET" ItemStyle-Width="98px">
                                                                            <ItemStyle Width="98px" />
                                                                            </asp:BoundField>
                                                                            <asp:BoundField DataField="sDr" HeaderText="Siklus Doktoru" ItemStyle-Width="168px">
                                                                            <ItemStyle Width="168px" />
                                                                            </asp:BoundField>
                                                                            <asp:BoundField HeaderText="Dýþ Doktor" ItemStyle-Width="85px">
                                                                            <ItemStyle Width="85px" />
                                                                            </asp:BoundField>
                                                                           
                                                                        </Columns>
                                                                    </asp:GridView>
                                                                </ItemTemplate>
                                                                <HeaderTemplate>
                                                                    <table cellpadding="1" cellspacing="1">
                                                                        <tr>
                                                                            <td colspan="1" style="width: 215px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid;">&nbsp; &nbsp; </td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 108px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">OPU/Siklus</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 115px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">ET/Siklus</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 80px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Gebelik<br />T. Gebelik</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 80px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Devam Edenler</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 78px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Biyokimyasal G / G</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 78px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Abortus / G</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 80px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Doðum / G&nbsp;</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 84px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Çoðul G / G</td>
                                                                            <td style="font-weight: bold; font-size: 11px; width: 77px; color: white;
                                                            font-family: arial; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">Hiperstim.</td>
                                                                        </tr>
                                                                    </table>
                                                                </HeaderTemplate>
                                                            </asp:DataList>
                                                         <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                                           <ContentTemplate>

                                                            <asp:DataList ID="list3" runat="server">
                                                                <HeaderTemplate>
                                                                    <table cellpadding="1" cellspacing="1">
                                                                        <tr>
                                                                            <td colspan="1" 
                                                                                style="width: 300px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid;">
                                                                                &nbsp; &nbsp;
                                                                            </td>
                                                                            <%--     <td ID="td11" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label48" runat="server">OPU<br>/Siklus</br></asp:Label>
                                                                            </td>--%>
                                                                            <%--     <td ID="td12" runat="server" 
                                                                                style="width: 100px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label49" runat="server">ET /<br>Dönem</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td13" runat="server" 
                                                                                style="width: 70px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label50" runat="server">Ýmplantasyon<br>(Geb/Embriyo)</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td14" runat="server" 
                                                                                style="width: 70px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label51" runat="server">Gebelik/<br>Transfer</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td15" runat="server" 
                                                                                style="width: 70px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label52" runat="server">FKA(+)/<br>Transfer</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td16" runat="server" 
                                                                                style="width: 100px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label53" runat="server">Gebelik<br>Embriyo</br></asp:Label>
                                                                            </td>
                                                                              <td ID="td3" runat="server" 
                                                                                style="width: 100px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label15" runat="server">Doðum/<br>Transfer</br></asp:Label>
                                                                            </td>--%>
                                                                      
                                                                            
                                                                            <td ID="td20" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label63" runat="server">Çalýþma Protokol Kodu</asp:Label>
                                                                            </td>
                                                                            <td ID="td21" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label64" runat="server">Baþlama Tarihi</asp:Label>
                                                                            </td>
                                                                            <td ID="td22" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label65" runat="server">Bitiþ Tarihi</asp:Label>
                                                                            </td>
                                                                            <td ID="td23" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label66" runat="server">Kayýt Tarihi</asp:Label>
                                                                            </td>
                                                                             <td ID="td24" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label3" runat="server">Deðer</asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </HeaderTemplate>
                                                                <ItemTemplate>

                                                                    <asp:Panel ID="pnlInfertilite" runat="server">
                                                                    <table cellpadding="1" cellspacing="1" width="900px">
                                                                        <tr>
                                                                            <td rowspan="2" 
                                                                                style="font-weight: bold; font-size: 11px; width: 300px; color: white;
                                                            font-family: arial; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label68" runat="server" ForeColor="White"></asp:Label>
                                                                                <br />
                                                                                <br />
                                                                                <asp:Label ID="Label69" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black" Visible="false"></asp:Label>
                                                                                <asp:Label ID="Label70" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red" Visible="false"></asp:Label>
                                                                                <asp:Label ID="Label71" runat="server" ForeColor="White"></asp:Label>
                                                                                <br />
                                                                                <asp:ImageButton ID="ac" runat="server" ImageUrl="~/imgs/ac.gif" />
                                                                                <asp:ImageButton ID="kapat" runat="server" ImageUrl="~/imgs/kapat.gif" 
                                                                                    Style="display:none;" />
                                                                            </td>
                                                                            <%--  <td style="width: 100px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>--%>
                                                                            <%--  <td style="width: 100px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 100px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                              <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>--%>
                                                                            <td style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; " 
                                                                                rowspan="2">
                                                                                <asp:Label ID="Label72" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; " 
                                                                                rowspan="2">
                                                                                <asp:Label ID="Label73" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; " 
                                                                                rowspan="2">
                                                                                <asp:Label ID="Label74" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; " 
                                                                                rowspan="2">
                                                                                <asp:Label ID="Label75" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                          <td style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; " 
                                                                                rowspan="2">
                                                                                <asp:Label ID="Label175" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <%--   <td style="width: 140px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>--%>
                                                                            <%--        <td style="width: 100px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 100px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                             <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>--%>
                                                                                                                                                     
                                                                        </tr>
                                                                    </table>
                                                                    </asp:Panel>
                                                                    
                                                                 
                                                                    
                                                                    
                                                                               <asp:GridView ID="detay3" runat="server"  AutoGenerateColumns="False" CellPadding="3" EnableModelValidation="True" Font-Bold="False" Font-Names="Arial" Font-Size="11px" ForeColor="#333333" Width="900px">
                                                                                   <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                                   <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                                   <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                                   <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                                                   <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                                   <EditRowStyle BackColor="#999999" />
                                                                                   <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                                   <Columns>
                                                                                       <asp:TemplateField>
                                                                                           <ItemTemplate>
                                                                                               <asp:ImageButton ID="edt" runat="server" ImageUrl="edit.png" OnCommand="editres_Command" />
                                                                                               <asp:ImageButton ID="save" runat="server" ImageUrl="save.png" OnCommand="save_Command" Visible="False" />
                                                                                               <asp:Label ID="hID" runat="server" Visible="False"></asp:Label>
                                                                                               <asp:Label ID="skls" runat="server" Visible="False"></asp:Label>
                                                                                           </ItemTemplate>
                                                                                       </asp:TemplateField>
                                                                                       <%--   <asp:BoundField DataField="yas" HeaderText="Yaþ" ItemStyle-Width="20px" />
                                                                            <asp:BoundField DataField="OPU" HeaderText="OPU" ItemStyle-Width="72px" />
                                                                            <asp:BoundField DataField="ET" HeaderText="ET" ItemStyle-Width="72px" />--%>
                                                                                       <asp:TemplateField HeaderText="Adý Soyadý">
                                                                                           <ItemTemplate>
                                                                                               <asp:LinkButton ID="adiSoyadi" runat="server" Font-Underline="False" ForeColor="Black"></asp:LinkButton>
                                                                                               <asp:Label ID="lblSDr" runat="server" Text="&lt;br&gt;Siklus Dr:" Visible="False"></asp:Label>
                                                                                               &nbsp;<asp:DropDownList ID="sdr" runat="server" style="font-size: 11px" Visible="False">
                                                                                               </asp:DropDownList>
                                                                                               &nbsp;&nbsp;
                                                                                               <asp:Label ID="lblDDr" runat="server" Text="Dýþ Dr :" Visible="False"></asp:Label>
                                                                                               <asp:DropDownList ID="ddr" runat="server" style="font-size: 11px" Visible="False">
                                                                                               </asp:DropDownList>
                                                                                               &nbsp;<asp:Label ID="lblSiklusDr" runat="server" Visible="False"></asp:Label>
                                                                                               <asp:Label ID="lblDisDr" runat="server" Visible="False"></asp:Label>
                                                                                           </ItemTemplate>
                                                                                           <ItemStyle Width="280px" />
                                                                                       </asp:TemplateField>
                                                                                       <asp:TemplateField HeaderText="Çalýþma Protokol Kodu">
                                                                                           <ItemTemplate>
                                                                                               <asp:Label ID="calismaProtokolKodu" runat="server"></asp:Label>
                                                                                               &nbsp;<asp:TextBox ID="txtCalismaProtokolKodu" runat="server" Visible="False" Width="100px"></asp:TextBox>
                                                                                           </ItemTemplate>
                                                                                           <ItemStyle Width="150px" />
                                                                                       </asp:TemplateField>
                                                                                       <asp:TemplateField HeaderText="Baþlama Tarihi">
                                                                                           <ItemTemplate>
                                                                                               <asp:Label ID="baslamaTarihi" runat="server"></asp:Label>
                                                                                               &nbsp;<asp:TextBox ID="txtBaslamaTarihi" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                           </ItemTemplate>
                                                                                           <ItemStyle Width="150px" />
                                                                                       </asp:TemplateField>
                                                                                       <asp:TemplateField HeaderText="Bitiþ Tarihi">
                                                                                           <ItemTemplate>
                                                                                               <asp:Label ID="bitisTarihi" runat="server"></asp:Label>
                                                                                               &nbsp;<asp:TextBox ID="txtBitisTarihi" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                           </ItemTemplate>
                                                                                           <ItemStyle Width="150px" />
                                                                                       </asp:TemplateField>
                                                                                       <asp:TemplateField HeaderText="Kayýt Tarihi">
                                                                                           <ItemTemplate>
                                                                                               <asp:Label ID="kayitTarihi" runat="server"></asp:Label>
                                                                                               &nbsp;<asp:TextBox ID="txtKayitTarihi" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                           </ItemTemplate>
                                                                                           <ItemStyle Width="150px" />
                                                                                       </asp:TemplateField>

                                                                                        <asp:TemplateField HeaderText="Deðer">
                                                                                           <ItemTemplate>
                                                                                               <asp:Label ID="deger" runat="server"></asp:Label>
                                                                                               &nbsp;<asp:TextBox ID="txtdeger" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                           </ItemTemplate>
                                                                                           <ItemStyle Width="150px" />
                                                                                       </asp:TemplateField>

                                                                                   </Columns>
                                                                               </asp:GridView>
                                                                      
                                                                    
                                                                </ItemTemplate>
                                                            </asp:DataList>
                                                                               <br />
                                                                               <asp:DataList ID="list5" runat="server">
                                                                                   <HeaderTemplate>
                                                                                       <table cellpadding="1" cellspacing="1">
                                                                                           <tr>
                                                                                               <td colspan="1" style="width: 300px; border-right: white 1px solid; border-top: white 1px solid; border-left: white 1px solid; border-bottom: white 1px solid;">&nbsp; &nbsp; </td>
                                                                                               <%--     <td ID="td11" runat="server" 
                                                                                style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label48" runat="server">OPU<br>/Siklus</br></asp:Label>
                                                                            </td>--%><%--     <td ID="td12" runat="server" 
                                                                                style="width: 100px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label49" runat="server">ET /<br>Dönem</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td13" runat="server" 
                                                                                style="width: 70px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label50" runat="server">Ýmplantasyon<br>(Geb/Embriyo)</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td14" runat="server" 
                                                                                style="width: 70px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label51" runat="server">Gebelik/<br>Transfer</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td15" runat="server" 
                                                                                style="width: 70px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label52" runat="server">FKA(+)/<br>Transfer</br></asp:Label>
                                                                            </td>
                                                                            <td ID="td16" runat="server" 
                                                                                style="width: 100px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label53" runat="server">Gebelik<br>Embriyo</br></asp:Label>
                                                                            </td>
                                                                              <td ID="td3" runat="server" 
                                                                                style="width: 100px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                <asp:Label ID="Label15" runat="server">Doðum/<br>Transfer</br></asp:Label>
                                                                            </td>--%>
                                                                                               <td id="td25" runat="server" style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                                   <asp:Label ID="Label176" runat="server">Çalýþma Protokol Kodu</asp:Label>
                                                                                               </td>
                                                                                               <td id="td26" runat="server" style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                                   <asp:Label ID="Label177" runat="server">Baþlama Tarihi</asp:Label>
                                                                                               </td>
                                                                                               <td id="td27" runat="server" style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                                   <asp:Label ID="Label178" runat="server">Bitiþ Tarihi</asp:Label>
                                                                                               </td>
                                                                                               <td id="td28" runat="server" style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                                   <asp:Label ID="Label179" runat="server">Kayýt Tarihi</asp:Label>
                                                                                               </td>
                                                                                               <td id="td29" runat="server" style="width: 150px; height: 40px; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid; font-weight: bold; font-size: 11px; color: white; font-family: arial;">
                                                                                                   <asp:Label ID="Label180" runat="server">Deðer</asp:Label>
                                                                                               </td>
                                                                                           </tr>
                                                                                       </table>
                                                                                   </HeaderTemplate>
                                                                                   <ItemTemplate>
                                                                                       <asp:Panel ID="pnlErkek" runat="server">


                                                                                      

                                                                                       <table cellpadding="1" cellspacing="1" width="900px">
                                                                                           <tr>
                                                                                               <td rowspan="2" style="font-weight: bold; font-size: 11px; width: 300px; color: white;
                                                            font-family: arial; background-color: #5d7b9d; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                                   <asp:Label ID="Label181" runat="server" ForeColor="White"></asp:Label>
                                                                                                   <br />
                                                                                                   <br />
                                                                                                   <asp:Label ID="Label182" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black" Visible="false"></asp:Label>
                                                                                                   <asp:Label ID="Label183" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Red" Visible="false"></asp:Label>
                                                                                                   <asp:Label ID="Label184" runat="server" ForeColor="White"></asp:Label>
                                                                                                   <br />
                                                                                                   <asp:ImageButton ID="ac1" runat="server" ImageUrl="~/imgs/ac.gif" />
                                                                                                   <asp:ImageButton ID="kapat1" runat="server" ImageUrl="~/imgs/kapat.gif" Style="display:none;" />
                                                                                               </td>
                                                                                               <%--  <td style="width: 100px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label44" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>--%><%--  <td style="width: 100px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label45" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 100px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>
                                                                              <td style="width: 70px; height: 21px; background-color: ghostwhite; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                            </td>--%>
                                                                                               <td rowspan="2" style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; ">
                                                                                                   <asp:Label ID="Label185" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                                               </td>
                                                                                               <td rowspan="2" style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; ">
                                                                                                   <asp:Label ID="Label186" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                                               </td>
                                                                                               <td rowspan="2" style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; ">
                                                                                                   <asp:Label ID="Label187" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                                               </td>
                                                                                               <td rowspan="2" style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; ">
                                                                                                   <asp:Label ID="Label188" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                                               </td>
                                                                                               <td rowspan="2" style="border: 1px solid black; width: 150px; background-color: ghostwhite; text-align: center; ">
                                                                                                   <asp:Label ID="Label189" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label>
                                                                                               </td>
                                                                                           </tr>
                                                                                           <tr>
                                                                                               <%--   <td style="width: 140px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>--%><%--        <td style="width: 100px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                            <td style="width: 100px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>
                                                                             <td style="width: 70px; height: 20px; background-color: aliceblue; text-align: center; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
                                                                                <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Names="Arial" 
                                                                                    Font-Size="11px" ForeColor="Red"></asp:Label>
                                                                            </td>--%>
                                                                                           </tr>
                                                                                       </table>  


                                                                                       </asp:Panel>
                                                                                       <asp:GridView ID="detay5" runat="server" AutoGenerateColumns="False" CellPadding="3" EnableModelValidation="True" Font-Bold="False" Font-Names="Arial" Font-Size="11px" ForeColor="#333333" style="margin-right: 0px" Width="900px">
                                                                                           <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                                                                           <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                                           <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                                                                           <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                                                                           <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                                                                           <EditRowStyle BackColor="#999999" />
                                                                                           <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                                                                           <Columns>
                                                                                               <asp:TemplateField>
                                                                                                   <ItemTemplate>
                                                                                                       <asp:ImageButton ID="edt1" runat="server" ImageUrl="edit.png" OnCommand="edt1_Command" />
                                                                                                       <asp:ImageButton ID="save0" runat="server" ImageUrl="save.png" OnCommand="save0_Command" ValidationGroup="erkek" Visible="False" />
                                                                                                       <asp:Label ID="hID0" runat="server" Visible="False"></asp:Label>
                                                                                                   </ItemTemplate>
                                                                                               </asp:TemplateField>
                                                                                               <%--   <asp:BoundField DataField="yas" HeaderText="Yaþ" ItemStyle-Width="20px" />
                                                                            <asp:BoundField DataField="OPU" HeaderText="OPU" ItemStyle-Width="72px" />
                                                                            <asp:BoundField DataField="ET" HeaderText="ET" ItemStyle-Width="72px" />--%>
                                                                                               <asp:TemplateField HeaderText="Adý Soyadý">
                                                                                                   <ItemTemplate>
                                                                                                       <asp:LinkButton ID="adiSoyadi0" runat="server" Font-Underline="False" ForeColor="Black"></asp:LinkButton>
                                                                                                   </ItemTemplate>
                                                                                                   <ItemStyle Width="280px" />
                                                                                               </asp:TemplateField>
                                                                                               <asp:TemplateField HeaderText="Çalýþma Protokol Kodu">
                                                                                                   <ItemTemplate>
                                                                                                       <asp:Label ID="calismaProtokolKodu0" runat="server"></asp:Label>
                                                                                                       &nbsp;<asp:TextBox ID="txtCalismaProtokolKodu0" runat="server" Visible="False" Width="100px"></asp:TextBox>
                                                                                                   </ItemTemplate>
                                                                                                   <ItemStyle Width="150px" />
                                                                                               </asp:TemplateField>
                                                                                               <asp:TemplateField HeaderText="Baþlama Tarihi">
                                                                                                   <ItemTemplate>
                                                                                                       <asp:Label ID="baslamaTarihi0" runat="server"></asp:Label>
                                                                                                       &nbsp;<asp:TextBox ID="txtBaslamaTarihi0" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                                       <asp:RegularExpressionValidator ID="rebat" runat="server" ControlToValidate="txtBaslamaTarihi0" Display="Dynamic" ErrorMessage="Format : 01.01.2014" Font-Bold="True" Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d)" ValidationGroup="erkek" Width="111px"></asp:RegularExpressionValidator>
                                                                                                   </ItemTemplate>
                                                                                                   <ItemStyle Width="150px" />
                                                                                               </asp:TemplateField>
                                                                                               <asp:TemplateField HeaderText="Bitiþ Tarihi">
                                                                                                   <ItemTemplate>
                                                                                                       <asp:Label ID="bitisTarihi0" runat="server"></asp:Label>
                                                                                                       &nbsp;<asp:TextBox ID="txtBitisTarihi0" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                                       <asp:RegularExpressionValidator ID="rebit" runat="server" ControlToValidate="txtBitisTarihi0" Display="Dynamic" ErrorMessage="Format : 01.01.2014" Font-Bold="True" Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d)" ValidationGroup="erkek" Width="111px"></asp:RegularExpressionValidator>
                                                                                                   </ItemTemplate>
                                                                                                   <ItemStyle Width="150px" />
                                                                                               </asp:TemplateField>
                                                                                               <asp:TemplateField HeaderText="Kayýt Tarihi">
                                                                                                   <ItemTemplate>
                                                                                                       <asp:Label ID="kayitTarihi0" runat="server"></asp:Label>
                                                                                                       &nbsp;<asp:TextBox ID="txtKayitTarihi0" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                                       <asp:RegularExpressionValidator ID="rekat" runat="server" ControlToValidate="txtKayitTarihi0" Display="Dynamic" ErrorMessage="Format : 01.01.2014" Font-Bold="True" Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d)" ValidationGroup="erkek" Width="111px"></asp:RegularExpressionValidator>
                                                                                                   </ItemTemplate>
                                                                                                   <ItemStyle Width="150px" />
                                                                                               </asp:TemplateField>
                                                                                               <asp:TemplateField HeaderText="Deðer">
                                                                                                   <ItemTemplate>
                                                                                                       <asp:Label ID="deger0" runat="server"></asp:Label>
                                                                                                       &nbsp;<asp:TextBox ID="txtdeger0" runat="server" Visible="False" Width="85px"></asp:TextBox>
                                                                                                       <asp:RangeValidator ID="redeg" runat="server" ControlToValidate="txtdeger0" Display="Dynamic" ErrorMessage="Sayýsal Deðer Giriniz!" MaximumValue="15000" MinimumValue="0" SetFocusOnError="True" style="font-weight: 700" Type="Integer" ValidationGroup="erkek"></asp:RangeValidator>
                                                                                                   </ItemTemplate>
                                                                                                   <ItemStyle Width="150px" />
                                                                                               </asp:TemplateField>
                                                                                           </Columns>
                                                                                       </asp:GridView>
                                                                               
                                                                                       
                                                                                         </ItemTemplate>
                                                                               </asp:DataList>
                                                           </ContentTemplate></asp:UpdatePanel>


                                                            </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp;&nbsp;<br />
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="height: 34px; text-align: center">
                                                <span style="font-size: 12px; font-family: Arial"></span>
                                                <asp:DropDownList ID="sonc" runat="server" Visible="False">
                                                    <asp:ListItem>Excel Olarak</asp:ListItem>
                                                </asp:DropDownList><span style="font-size: 12px; font-family: Arial"> </span>
                                                <asp:Button ID="Button2" runat="server" Font-Bold="False" OnClick="Button2_Click"
                                                    Text="Aktar" Visible="False" /></td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
    
    <br />

  


</asp:Content>


