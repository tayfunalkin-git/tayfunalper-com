<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000051.aspx.cs" Inherits="administrator_ebebaba_pages_0000051" Theme="SkinFile" %>
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


    <br />
     <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
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
                                                    Font-Size="11px" Text="Kitap Konusu Güncelleme"></asp:Label>
                                            </td>
                                            <td style="font-size: 12pt; height: 24px; text-align: right" valign="middle">
                                                <asp:ImageButton ID="Button1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btngeridon.gif"
                                                    OnClick="Button1_Click1" ValidationGroup="ynm" CausesValidation="False" />
                                                <asp:ImageButton ID="btnKaydet" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnguncelle.gif"
                                                    OnClick="btn_kaydet_Click" ValidationGroup="ynm" />&nbsp;</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt; font-family: Times New Roman;">
            <td valign="top">
                <div align="left">
                    <table cellpadding="0" cellspacing="0" style="width: 100%; border-bottom: lightgrey 1px solid;">
                        <tr>
                            <td colspan="2" style="text-align: center">
                                <span style="font-size: 11px; font-family: Verdana">
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Tahoma; height: 13px;
                                                text-align: left">
                                            </td>
                                            <td colspan="2" style="height: 13px; text-align: left">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Tahoma; text-align: left">
                                                Kitaplar :
                                            </td>
                                            <td colspan="2" style="text-align: left">
                                                &nbsp;<asp:DropDownList ID="kitaplist" runat="server" AutoPostBack="True" BackColor="Transparent"
                                                    Font-Bold="False" Font-Names="verdana" Font-Size="11px" OnSelectedIndexChanged="kitaplist_SelectedIndexChanged"
                                                    SkinID="drop" ValidationGroup="ynm">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="kitaplist"
                                                    Display="Dynamic" ErrorMessage="Kitap Seçilmedi !" Font-Bold="False" Font-Names="Tahoma"
                                                    Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"></asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr style="color: #000000">
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Tahoma; text-align: left">
                                                Kategoriler :
                                            </td>
                                            <td colspan="2" style="text-align: left">
                                                &nbsp;<asp:DropDownList ID="kategorilist" runat="server" BackColor="Transparent"
                                                    Enabled="False" Font-Bold="False" Font-Names="verdana" Font-Size="11px" OnSelectedIndexChanged="kategorilist_SelectedIndexChanged"
                                                    SkinID="drop" ValidationGroup="ynm" AutoPostBack="True">
                                                </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="kategorilist"
                                Display="Dynamic" ErrorMessage="Kategori Seçilmedi !" SetFocusOnError="True" ValidationGroup="ynm"></asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Tahoma; text-align: left">
                                                Konular :</td>
                                            <td colspan="2" style="text-align: left">
                                                &nbsp;<asp:DropDownList ID="konulist" runat="server" AutoPostBack="True" BackColor="Transparent"
                                                    Enabled="False" Font-Bold="False" Font-Names="verdana" Font-Size="11px" SkinID="drop"
                                                    ValidationGroup="ynm" OnSelectedIndexChanged="konulist_SelectedIndexChanged">
                                                </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="konulist"
                                Display="Dynamic" ErrorMessage="Konu Seçilmedi !" SetFocusOnError="True" ValidationGroup="ynm" Font-Names="Tahoma"></asp:RequiredFieldValidator></td>
                                        </tr>
                                    </table>
                                    <table style="width: 100%; border-bottom: #000000 1px solid">
                                        <tr>
                                            <td colspan="3" style="text-align: center; height: 12px;">
                                                &nbsp; &nbsp;
                                            </td>
                                        </tr>
                                    </table>
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Tahoma; height: 15px;
                                                text-align: left">
                                            </td>
                                            <td colspan="2" style="height: 15px; text-align: left">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 108px; color: black; font-family: Tahoma; text-align: left; height: 22px;" valign="top">
                                                Konu Baþlýðý :
                                            </td>
                                            <td colspan="2" style="text-align: left; height: 22px;" valign="top">
                                                &nbsp;<asp:TextBox ID="y_konu" runat="server" SkinID="txtsiklus" Width="274px" Enabled="False"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="y_konu"
                                        Display="Dynamic" ErrorMessage="Konu Boþ Geçilemez !" SetFocusOnError="True" ValidationGroup="ynm" Font-Names="Tahoma"></asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr style="font-size: 11px">
                                            <td style="width: 108px; text-align: left" valign="top">
                                                <asp:Label ID="Label3" runat="server" Font-Names="Tahoma" Text="Anasayfa Metni :"
                                                    Visible="False"></asp:Label></td>
                                            <td colspan="2" style="text-align: left" valign="top">
                                                &nbsp;<asp:TextBox ID="anasayfametni" runat="server" Height="106px" SkinID="txtsiklus"
                                                    TextMode="MultiLine" Visible="False" Width="274px"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="anasayfametni"
                                                    Display="Dynamic" ErrorMessage="Anasayfa Metni Boþ Geçilemez !" Font-Names="Tahoma"
                                                    SetFocusOnError="True" ValidationGroup="ynm" Visible="False"></asp:RequiredFieldValidator></td>
                                        </tr>
                                        <tr style="font-size: 11px">
                                            <td style="width: 108px; text-align: left; height: 22px;" valign="top">
                                                <span style="color: black; font-family: Tahoma"><span style="color: black">Y</span>ayýnlansýn
                                                    mý? : </span>
                                            </td>
                                            <td style="width: 100px; text-align: left; height: 22px;" valign="top">
                                                <asp:CheckBox ID="yayin" runat="server" Enabled="False" /></td>
                                            <td style="width: 100px; height: 22px;" valign="top">
                                            </td>
                                        </tr>
                                        </span>
                                <span style="font-size: 11px; ">
                                        <tr style="font-size: 11px">
                                            <td style="width: 108px; text-align: left; height: 22px; font-family: Tahoma;" 
                                                valign="top">
                                                Resim :
                                                <asp:Label ID="Label15" runat="server"></asp:Label>
                                            </td>
                                            </span>
                                <span style="font-size: 11px; font-family: Verdana">
                                            <td style="text-align: left; height: 22px;" valign="top" colspan="2">
                                                &nbsp;<asp:FileUpload ID="resim" runat="server" />
&nbsp;<asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Resmi Deðiþtir" />
                                                <br />
                                                <br />
&nbsp;<asp:Image ID="resim2" runat="server" />
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="mesaj"
                                Display="Dynamic" ErrorMessage="Konu Ýçeriði Boþ Geçilemez !" Font-Names="Tahoma"
                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm" Font-Bold="True"></asp:RequiredFieldValidator></span></td>
                        </tr>
                    </table>
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana;"
                                valign="top">
                                
                                <asp:Panel ID="Panel3" runat="server" Width="100%">
                                
                                    <asp:TextBox ID="mesaj" runat="server" ValidationGroup="ynm" Width="100%" Height="420px" TextMode="MultiLine" CssClass="ctl00_ContentPlaceHolder1_mesaj"></asp:TextBox></asp:Panel>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
    
    
           

    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
        border-top: #000000 1px solid; border-left: #000000 1px solid; width: 95%; border-bottom: #000000 1px solid">
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
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; border-left-width: 1px;
                        border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                        width: 100%; border-top-color: #d3d3d3; background-color: #ffffff; border-right-width: 1px;
                        border-right-color: #d3d3d3">
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
        <tr style="font-size: 12pt; font-family: Times New Roman">
            <td valign="top">
                <div align="left">
                    <table cellpadding="0" cellspacing="0" style="overflow: hidden; clip: rect(10px 10px 10px 10px)"
                        width="100%">
                        <tr>
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; text-align: left"
                                valign="top">
                                <br />
                                <asp:DataList ID="resimler" runat="server" BackColor="White" BorderColor="Gainsboro"
                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Both" HorizontalAlign="Center"
                                    RepeatColumns="5" Width="96%" RepeatDirection="Horizontal">
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
                                                                    <asp:ImageButton ID="sil" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "resim_id")%>'
                                                                        CommandName='<%# DataBinder.Eval(Container.DataItem, "resim_adi")%>' ImageUrl="~/imgs/btnekle2.gif"
                                                                        OnCommand="ekle_command" /></td>
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
     
</asp:Content>


