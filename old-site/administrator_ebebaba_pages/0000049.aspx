<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000049.aspx.cs" Inherits="administrator_ebebaba_pages_0000049" Theme="SkinFile" %>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
     
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://www.sceditor.com/minified/themes/default.min.css" type="text/css" />

	
		<script src="https://www.sceditor.com/minified/jquery.sceditor.bbcode.min.js"></script>

   <script>
       $(function () {
           // Replace all textarea tags with SCEditor
           $("#ctl00_ContentPlaceHolder1_mesaj").sceditor({
               plugins: 'xhtml',
               toolbar: "font,size,bold,italic,underline|subscript,superscript|left,center,right,justify|orderedlist|table|print|pastetext|color|source|link",
               style: 'https://www.sceditor.com/minified/jquery.sceditor.default.min.css'
           });


       });
</script>
    <asp:ScriptManager id="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
     <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tbody>
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px" valign="middle">
                                                &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Tahoma"
                                                    Font-Size="11px" Text="Yeni Yardým Konusu Ekle"></asp:Label>
                                            </td>
                                            <td style="font-size: 12pt; height: 24px; text-align: right" valign="middle">
                                                <asp:ImageButton ID="btnKaydet" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif"
                                                    OnClick="btn_kaydet_Click" ValidationGroup="ynm" />&nbsp;</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; background-color: #ffffff; border-right-width: 1px; border-right-color: #d3d3d3;">
                        <tr>
                            <td style="text-align: center">
                                <br />
                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><br />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt; font-family: Times New Roman;">
            <td valign="top">
                <div align="left">
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; text-align: center;"
                                valign="top">
                                <br />
                                <table style="width: 100%">
                                    <tr>
                                        <td style="font-size: 11px; width: 100px; color: black; font-family: Tahoma; text-align: left; height: 22px;" valign="top">
                                            Kitaplar :
                                        </td>
                                        <td colspan="2" style="text-align: left; height: 22px;" valign="top">
                                            &nbsp;<asp:DropDownList ID="kitaplist" runat="server" BackColor="Transparent" Font-Bold="False"
                                    Font-Names="verdana" Font-Size="11px" SkinID="drop" ValidationGroup="ynm" AutoPostBack="True" OnSelectedIndexChanged="kitaplist_SelectedIndexChanged">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="kitaplist"
                                                Display="Dynamic" ErrorMessage="Kitap Seçilmedi !" Font-Bold="False" Font-Names="Tahoma"
                                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 11px; width: 100px; color: black; font-family: Tahoma; text-align: left; height: 22px;" valign="top">
                                            Kategoriler :
                                        </td>
                                        <td colspan="2" style="text-align: left; height: 22px;" valign="top">
                                            &nbsp;<asp:DropDownList ID="kategorilist" runat="server" BackColor="Transparent" Font-Bold="False"
                                    Font-Names="verdana" Font-Size="11px" SkinID="drop" ValidationGroup="ynm" Enabled="False">
                                            </asp:DropDownList>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="kategorilist"
                                                Display="Dynamic" ErrorMessage="Kategori Seçilmedi !" Font-Bold="False" Font-Names="Tahoma"
                                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 11px; width: 100px; colorr: black; font-family: Tahoma; text-align: left; height: 22px;" valign="top">
                                            Konu Baþlýðý :
                                        </td>
                                        <td colspan="2" style="text-align: left; height: 22px;" valign="top">
                                            &nbsp;<asp:TextBox ID="konu" runat="server" SkinID="txtsiklus" Width="305px" ValidationGroup="ynm"></asp:TextBox>&nbsp;
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="konu"
                                        Display="Dynamic" ErrorMessage="Konu Alaný Boþ Geçilemez !" SetFocusOnError="True" ValidationGroup="ynm" Font-Bold="False" Font-Names="Tahoma" Font-Size="11px"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 11px; width: 100px; color: black; font-family: Tahoma; text-align: left"
                                            valign="top">
                                            <asp:Label ID="Label3" runat="server" Text="Anasayfa Metni :" Visible="False"></asp:Label></td>
                                        <td colspan="2" style="text-align: left" valign="top">
                                            &nbsp;<asp:TextBox ID="anasayfametni" runat="server" Height="81px" SkinID="txtsiklus"
                                                TextMode="MultiLine" ValidationGroup="ynm" Visible="False" Width="305px"></asp:TextBox>&nbsp;
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="anasayfametni"
                                                Display="Dynamic" ErrorMessage="Anasayfa Metni Boþ Geçilemez !" Font-Bold="False"
                                                Font-Names="Tahoma" Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"
                                                Visible="False"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr style="font-size: 11px">
                                        <td style="width: 100px; text-align: left; height: 22px;" valign="top">
                                            <span style="color: black; font-family: Tahoma"><span style="color: black">Y</span>ayýnlansýn
                                                mý? : </span>
                                        </td>
                                        <td style="width: 100px; text-align: left; height: 22px;" valign="top">
                                            <asp:CheckBox ID="yayin" runat="server" /></td>
                                        <td style="width: 100px; height: 22px;" valign="top">
                                        </td>
                                    </tr>
                                    <tr style="font-size: 11px">
                                        <td style="width: 100px; text-align: left; height: 22px; font-family: Tahoma; color:Black" 
                                            valign="top">
                                            Resim :
                                            <asp:Label ID="Label15" runat="server" Visible="False"></asp:Label>
                                        </td>
                                        <td style="text-align: left; height: 22px;" valign="top" colspan="2">
                                            &nbsp;<asp:FileUpload ID="resim" runat="server" SkinID="fupload" />
&nbsp;
                                            <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                                                Text="Resmi Yeniden Yükle" Visible="False" Width="178px" />
&nbsp; </td>
                                    </tr>
                                </table>
                                <span style="font-family: Tahoma"><strong><span style="color: black"></span></strong></span><br />
                                
                                <asp:Panel ID="Panel3" runat="server" Width="100%">
                                    <br />
                                
                                    <asp:TextBox ID="mesaj" runat="server" Width="100%" Height="420px" TextMode="MultiLine" CssClass="ctl00_ContentPlaceHolder1_mesaj" ValidationGroup="ynm"></asp:TextBox>
                                
                                
                                </asp:Panel>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
    
    
       



    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tbody>
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px" valign="middle">
                                                &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                                    Text="Resim Havuzu"></asp:Label>
                                            </td>
                                            <td style="font-size: 12pt; height: 24px; text-align: right" valign="middle">
                                                <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnresimgoster.gif"
                                                    OnClick="ImageButton1_Click" />&nbsp;</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <asp:Panel ID="Panel1" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; background-color: #ffffff; border-right-width: 1px; border-right-color: #d3d3d3;">
                        <tr>
                            <td style="text-align: center">
                                <br />
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><br />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt; font-family: Times New Roman;">
            <td valign="top">
                <div align="left">
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; text-align: left;"
                                valign="top">
                                <br />
                                <asp:DataList ID="resimler" runat="server" BackColor="White" BorderColor="Gainsboro"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Both" HorizontalAlign="Center"
                                    RepeatColumns="5" Width="96%">
                                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                    <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                    <ItemTemplate>
                                        <table style="width: 100%">
                                            <tr>
                                                <td colspan="2" style="height: 41px; text-align: center">
                                                    <img height="100" src='../imgyardim/<%# DataBinder.Eval(Container.DataItem, "resim_adi")%>'
                                                        width="125" /></td>
                                            </tr>
                                            <tr>
                                                <td colspan="2" style="text-align: center">
                                                    <asp:Panel ID="Panel2" runat="server" Height="50px" Width="90%">
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td colspan="2" style="text-align: center">
                                                                    <asp:ImageButton ID="sil" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "resim_id")%>' CommandName='<%# DataBinder.Eval(Container.DataItem, "resim_adi")%>'
                                                                        ImageUrl="~/imgs/btnekle2.gif" OnCommand="ekle_command" /></td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                    <ItemStyle BackColor="White" ForeColor="#330099" />
                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                </asp:DataList></td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>

    <br />
     
</asp:Content>


