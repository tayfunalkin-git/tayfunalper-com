<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000040.aspx.cs" Inherits="administrator_ebebaba_pages_0000036" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
     <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
             
             
             
                  <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tbody>
                        <tr>
                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tbody>
                                        <tr>
                                            <td style="width: 202px; height: 24px" valign="middle">
                                                &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Tahoma"
                                                    Font-Size="11px" Text="Resim Havuzu"></asp:Label>
                                            </td>
                                            <td style="font-size: 12pt; height: 24px; text-align: right" valign="middle">
                                                &nbsp;&nbsp;</td>
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
                                <asp:Label ID="sonuc2" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
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
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; height: 13px;"
                                valign="top">
                                            <table align="center" width="100%">
                                                <tr style="color: #000000">
                                                    <td style="font-size: 11px; color: #000000; font-family: verdana; height: 49px; text-align: center" colspan="4">
                                                        <span style="font-size: 8pt">
                                                            <br />
                                                            Resim Havuzu Ýçerisindeki Resimler , Yardým konularý yada kitap konularýnda kullanýlmak
                                                            istenilen resimlerin toplandýðý bölümdür.<br />
                                                            <br />
                                                            <span style="font-family: Tahoma"><strong>
                                                            Yeni Resim </strong></span></span><span
                                                                style="font-family: Tahoma"><strong>
                                                        :</strong></span><span>&nbsp;</span><asp:FileUpload ID="resim_upl" runat="server" SkinID="fupload" Font-Names="Tahoma" Font-Size="11px" />&nbsp;<asp:ImageButton
                                                                    ID="Button3" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif"
                                                                    OnClick="Button3_Click" /><br />
                                                        <br />
                                                        <br />
                                                        <span style="font-size: 8pt"><span style="font-size: 11px; font-family: Tahoma"><strong>
                                                            Kayýtlý Resimler -</strong></span> </span>
                                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                                    ForeColor="#3300FF"></asp:Label><br />
                                                        <br />
                                            <asp:DataList ID="resimler" runat="server" RepeatColumns="5" Width="96%" BackColor="White" BorderColor="Gainsboro" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" GridLines="Both" HorizontalAlign="Center" RepeatDirection="Horizontal">
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
                                                                                <asp:ImageButton ID="sil" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "resim_id")%>' runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('Seçili Resmin Silinmesi Halinde Resmi Kullanan sayfalarda bu resim görüntülenemeyecektir.Yine de Silmek Ýstediðinize Emin Misiniz?')"
                                                                                    OnCommand="sil_Command" /></td>
                                                                        </tr>
                                                                    </table>
                                                                </asp:Panel>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </ItemTemplate>
                                                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                                <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                                <ItemStyle BackColor="White" ForeColor="#330099" />
                                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                            </asp:DataList><br />
                                                    </td>
                                                </tr>
                                            </table>
                                </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
    <br />
     
</asp:Content>


