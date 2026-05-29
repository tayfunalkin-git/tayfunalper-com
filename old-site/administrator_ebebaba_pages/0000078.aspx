<%@ Page Title="" Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000078.aspx.cs" Inherits="mainAdminPagesHdn_0000073" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <br>

     <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
               <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TR><TD 
style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2 valign="middle"><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TR><TD style="WIDTH: 202px; HEIGHT: 24px" 
vAlign=middle> &nbsp;<asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Yazı Kategorileri"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>  &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;</TD></TR></TABLE></TD></TR></TABLE>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                               <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" ForeColor="Black"></asp:Label><br />
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <table align="center" cellpadding="0" cellspacing="0" style="width: 97%">
                                    <tr>
                                        <td>
                                            <br />
                                        
      <div class="form-group">  
        <table>
            <tr>
                <td>Tedavi Yazısı Kategori Adı :
        <asp:TextBox ID="kategoriAdi" runat="server" CssClass="form-control" MaxLength="50" Width="197px"></asp:TextBox>
                </td>
                <td style="width: 103px">
                    <br />
        <asp:Button ID="Button3" runat="server" CssClass="btn_1" Text="Ekle" OnClick="Button3_Click" ValidationGroup="tip" />
                </td>
            </tr>
        </table>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="kategoriAdi" Display="Dynamic" SetFocusOnError="True" ValidationGroup="tip"></asp:RequiredFieldValidator>
        <br />
        <br />
                <asp:GridView ID="list" runat="server" AutoGenerateColumns="False" CellPadding="5" Font-Names="Calibri" Font-Size="12pt" ForeColor="#333333" OnRowDataBound="GridView1_RowDataBound" PageSize="5" Width="100%" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Font-Names="Calibri" Font-Size="15px" ForeColor="#284775" Height="25px" HorizontalAlign="Left" />
                    <Columns>
                         <asp:TemplateField HeaderText="Tedavi Yazısı Kategori Adı">
                            <ItemTemplate>
                                <table cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td style="width: 305px">
                                            <asp:Label ID="lblID" runat="server" Visible="False"></asp:Label>
                                            <asp:Label ID="lblTip" runat="server" style="font-size: 14px"></asp:Label>
                                            <asp:TextBox ID="txtTip" runat="server" CssClass="form-control" MaxLength="49" Visible="False" Width="250px"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtTip" Display="Dynamic" EnableClientScript="False" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                        </asp:TemplateField> 
                        <asp:TemplateField HeaderText="Sıralama">
                            <ItemTemplate>
                                <asp:ImageButton ID="ust" runat="server" ImageUrl="~/administrator_ebebaba_pages/tedaviimages/ust.png" OnCommand="ust_Command" />
                                &nbsp;&nbsp;
                                <asp:ImageButton ID="alt" runat="server" ImageUrl="~/administrator_ebebaba_pages/tedaviimages/alt.png" OnCommand="ImageButton4_Command" />
                            </ItemTemplate>
                        </asp:TemplateField>
                      
                        <asp:TemplateField HeaderText="İşlemler">
                            <ItemTemplate>
                                <asp:ImageButton ID="kaydet" runat="server" ImageUrl="~/administrator_ebebaba_pages/tedaviimages/kaydet.gif" OnCommand="kaydet_Command" Visible="False" />
                                <asp:ImageButton ID="duzenle" runat="server" ImageUrl="~/administrator_ebebaba_pages/tedaviimages/duzenle.png" OnCommand="duzenle_Command" />
                                &nbsp;&nbsp;&nbsp;
                                <asp:ImageButton ID="sil" runat="server" ImageUrl="~/administrator_ebebaba_pages/tedaviimages/sil.png" OnClientClick="return confirm('Silmek istediğinize emin misiniz ?');return false;" OnCommand="sil_Command" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#666666" Font-Bold="False" Font-Names="Calibri" Font-Size="14px" Font-Underline="False" ForeColor="White" Height="30px" HorizontalAlign="Left" />
                    <PagerStyle BackColor="Gray" Font-Bold="True" Font-Names="Kalinga" Font-Size="14px" ForeColor="White" Height="30px" HorizontalAlign="Right" />
                    <RowStyle BackColor="White" BorderColor="Silver" BorderStyle="Solid" BorderWidth="1px" Font-Names="Calibri" Font-Size="15px" ForeColor="#333333" Height="25px" HorizontalAlign="Left" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
        <br />
        <br />
    </div>
                                        </td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                        </tr>
                    </table>






</asp:Content>

