<%@ Page Language="C#"  EnableEventValidation="false" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000079.aspx.cs" Inherits="administrator_ebebaba_pages_0000049" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
                                                    Font-Size="11px" Text="Yeni Duyuru Ekle"></asp:Label>
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
                                            &nbsp;&nbsp;
                                            Baþlýk :
                                        </td>
                                        <td colspan="2" style="text-align: left; height: 22px;" valign="top">
                                            &nbsp;<asp:TextBox ID="konu" runat="server" SkinID="txtsiklus" Width="305px" ValidationGroup="ynm"></asp:TextBox>&nbsp;
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="konu"
                                        Display="Dynamic" ErrorMessage="Konu Alaný Boþ Geçilemez !" SetFocusOnError="True" ValidationGroup="ynm" Font-Bold="False" Font-Names="Tahoma" Font-Size="11px"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 11px; width: 100px; color: black; font-family: Tahoma; text-align: left"
                                            valign="top">
                                            &nbsp;&nbsp; Link :&nbsp;</td>
                                        <td colspan="2" style="text-align: left" valign="top">
                                            &nbsp;<asp:TextBox ID="link" runat="server" SkinID="txtsiklus" Width="305px" ValidationGroup="ynm"></asp:TextBox>&nbsp;<asp:RegularExpressionValidator 
                                                ID="RegularExpressionValidator1" runat="server" ControlToValidate="link" 
                                                Display="Dynamic" ErrorMessage="Link Hatalý !" SetFocusOnError="True" 
                                                style="font-family: Tahoma; font-size: 11px" 
                                                ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
&nbsp;<span style="font-family: Tahoma; font-size: 11px">Örn : http://www.ebebaba.com</span></td>
                                    </tr>
                                    <tr>
                                        <td style="font-size: 11px; width: 100px; color: black; font-family: Tahoma; text-align: left"
                                            valign="top">
                                            &nbsp;&nbsp;
                                            <asp:Label ID="Label3" runat="server" Text="Metin :"></asp:Label></td>
                                        <td colspan="2" style="text-align: left" valign="top">
                                            &nbsp;<asp:TextBox ID="anasayfametni" runat="server" Height="127px" SkinID="txtsiklus"
                                                TextMode="MultiLine" ValidationGroup="ynm" Width="387px"></asp:TextBox>&nbsp;
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="anasayfametni"
                                                Display="Dynamic" ErrorMessage="Metin Boþ Geçilemez !" Font-Bold="False"
                                                Font-Names="Tahoma" Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynm"
                                                Visible="False"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr style="font-size: 11px">
                                        <td style="width: 100px; text-align: left; height: 22px;" valign="top">
                                            <span style="color: black; font-family: Tahoma"><span style="color: black">&nbsp;&nbsp; Y</span>ayýnlansýn
                                                mý? : </span>
                                        </td>
                                        <td style="width: 100px; text-align: left; height: 22px;" valign="top">
                                            <asp:CheckBox ID="yayin" runat="server" /></td>
                                        <td style="width: 100px; height: 22px;" valign="top">
                                        </td>
                                    </tr>
                                    </table>
                                <br />
                                
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
    
    
      
    <br />
  
     
</asp:Content>


