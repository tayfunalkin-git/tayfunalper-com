<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000418.aspx.cs" Inherits="ivfyonetici_0000068" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 0px solid; border-top: black 0px solid; border-left: black 0px solid; border-bottom: black 0px solid;" width="100%">
       <tr>
           <td valign="bottom">
               <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td colspan="2">
                           <table border="0" cellpadding="0" cellspacing="0" width="100%" style="height: 33px">
                               <tr>
                                   <td background="../imgs/ust_menu_bg.jpg" colspan="2" valign="middle">
                                       <table cellpadding="0" cellspacing="0" style="width: 100%">
                                           <tr>
                                               <td style="width: 202px; height: 24px" valign="middle">
                                                   &nbsp; <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                       Font-Size="11px" Text="Çalýþma Takip Log" style="font-size: 12px"></asp:Label></td>
                                               <td style="height: 24px; text-align: right" valign="middle">
                                                   </td>
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
                   &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label><br />
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table width="90%" border="0" cellpadding="0" cellspacing="0" align="center">
                                        <tr>
                                            <td style="text-align: center;" colspan="7" valign="middle">
                                                <span style="color: darkgray"><span style="font-size: 11px; font-family: Arial"><strong>
                                                    <br />
                                                    </strong></span> </span><strong> <span style="font-size: 11px; font-family: Arial">Kayýtlarda Ara : </span></strong>&nbsp;<asp:TextBox ID="arama" runat="server"
                                                        SkinID="txtsiklus" ValidationGroup="liste4"></asp:TextBox>
                                                &nbsp;<asp:Button ID="Button1" runat="server" Font-Size="12px" OnClick="Button1_Click"
                                                    SkinID="btn" Text="Ara" ValidationGroup="liste4" />&nbsp;<asp:Button ID="Button2" runat="server" Font-Size="12px" OnClick="Button2_Click"
                                                    SkinID="btn" Text="Tümünü Listele" /><br />
                                                <br />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="arama"
                                                    Display="Dynamic" ErrorMessage="Arama Sözcüðü Girilmedi !!" Font-Names="Arial" Font-Size="11px" SetFocusOnError="True"
                                                    ValidationGroup="liste4" Font-Bold="True"></asp:RequiredFieldValidator>
                                                <asp:Label ID="Label15" runat="server" Visible="False"></asp:Label>
                                            </td>
                                        </tr>
                                    </table>
                                    <br />
                                <asp:GridView ID="loglist" runat="server" AutoGenerateColumns="False" CellPadding="4"
                                    Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="#333333" Width="90%" HorizontalAlign="Center" AllowPaging="True" EnableModelValidation="True" OnPageIndexChanging="loglist_PageIndexChanging" PageSize="60" style="font-size: 12px">
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <Columns>
                                        <asp:BoundField DataField="kullaniciAdi" HeaderText="Ýþlem Yapan">
                                        <ControlStyle Width="120px" />
                                        <HeaderStyle HorizontalAlign="Left" />
                                        <ItemStyle Width="15%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="islem" HeaderText="Yapýlan Ýþlemler">
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="70%" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="tarih" HeaderText="Ýþlem Tarihi">
                                            <HeaderStyle HorizontalAlign="Left" />
                                            <ItemStyle Width="15%" />
                                        </asp:BoundField>
                                    </Columns>
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#0099CC" ForeColor="White" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <EditRowStyle BackColor="#999999" />
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                </asp:GridView>
                                    <br />
                                </div>
                            </td>
                        </tr>
                    </table>
    <br />


</asp:Content>


