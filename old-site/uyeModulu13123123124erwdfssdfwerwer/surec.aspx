<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="surec.aspx.cs" Inherits="a_heyet" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <%--  <asp:ScriptManager ID="ScriptManager1" runat="server"/>--%>

       <asp:Label ID="adi" runat="server" Visible="False"></asp:Label>
       <asp:Label ID="ID" runat="server" Visible="False"></asp:Label>
    <br /><table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td background="../uyeModulu/images/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                            <table cellpadding="0" cellspacing="0" style="width: 100%">
                                <tr>
                                    <td style="width: 239px; height: 24px;" valign="middle">
                                        &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                            Text="Daha Önceki Başvurular ve Süreç"></asp:Label></td>
                                    <td style="height: 24px; text-align: right; font-size: 12pt;" valign="middle">
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr style="font-size: 12pt; font-family: Times New Roman;">
            <td valign="top">
                <div align="left">
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; height: 13px;"
                                valign="top">
                                <table cellpadding="0" cellspacing="0" style="width: 100%;">
                                    <tr>
                                        <td colspan="2" style="height: 28px; " valign="middle">
                                            <span><span style="font-family: Arial"><strong>
                                                <br />
                                                <table style="width: 100%">
                                                    <tr>
                                                        <td style="text-align: center">
                                                <asp:Label
                                                        ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                        ForeColor="Black"></asp:Label><br />
                                                            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Black"></asp:Label></td>
                                                    </tr>
                                                </table>
                                                <br />
                                                    
                                                    
                                                    
                                                    
                                <asp:GridView ID="list" runat="server" AutoGenerateColumns="False"
                                    BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
                                    CellPadding="4" Font-Size="11px"
                                    ForeColor="#333333" PageSize="50"
                                    Width="95%" Font-Names="Arial" HorizontalAlign="Center" EnableModelValidation="True">
                                    <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                      
                                        <asp:TemplateField HeaderText="Hasta Adı - Soyadı">
                                        
                                                <ItemTemplate>
                                                    <asp:Label ID="hastaAdi" runat="server" Font-Bold="False"></asp:Label>
                                              
                                             </ItemTemplate>
                                          
                                                <ItemStyle HorizontalAlign="Left" Font-Bold="True" Width="150px">
                                                    
                                            </ItemStyle>
                                             </asp:TemplateField>
                                                    
                                   
                                        <asp:BoundField DataField="kayittarihi" HeaderText="Başvuru Tarihi" >
                                 
                                                <ItemStyle HorizontalAlign="Left" Font-Bold="False" Width="90px">
                                               </ItemStyle>
                                        </asp:BoundField>
                                 
                                  
                                                <asp:BoundField DataField="ekleyen" HeaderText="Başvuruyu Ekleyen">
                                       
                                                    <ItemStyle HorizontalAlign="Left" Font-Bold="False" Width="150px">
                                                    </ItemStyle>
                                                    
                                      </asp:BoundField>
                                        <asp:TemplateField HeaderText="Karar Tarihi">
                                            <ItemTemplate>
                                              
                                                    
                                                                                        <asp:Label ID="heyettarihi" runat="server" Font-Bold="False"></asp:Label>&nbsp;
                                                                                        
                                                   
                                               
                                            </ItemTemplate>
                                            <ItemStyle Width="100px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Durum" Visible="False">
                                            <ItemTemplate>
                                                <asp:Label ID="drm" runat="server" Font-Bold="False"></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="110px" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Süreç">
                                            <ItemTemplate>
                                                <asp:Label ID="sonuc" runat="server" Font-Bold="False"></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle HorizontalAlign="Left" Font-Bold="False">
                                                    </ItemStyle>
                                        </asp:TemplateField>
                                          
                          
                                        <asp:TemplateField HeaderText="İptal" Visible="False">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="ipt" runat="server" CausesValidation="False" 
                                                    
                                                    
                                                    OnClientClick='return confirm("Başvuru İptal Edilecektir.Onaylıyormusunuz?")' 
                                                    oncommand="ipt_Command1" Font-Underline="False">İptal</asp:LinkButton>
                                            </ItemTemplate>
                                        
                                                <ItemStyle HorizontalAlign="Left" Width="40px">
                                                    
                                                  </ItemStyle>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Sil" Visible="False">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbSil" runat="server" Font-Underline="False" OnClientClick="return confirm('Hastaya ait heyet ve tedavi kaydı bilgilerini silmek istediğinize eminmisiniz? ')"
                                                    OnCommand="lbSil_Command">Sil</asp:LinkButton>
                                            </ItemTemplate>
                                            <ItemStyle Width="25px" />
                                        </asp:TemplateField>
                                  
                            
                                    </Columns>
                                    <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                        Font-Names="Arial" ForeColor="#333333" VerticalAlign="Top" />
                                    <EditRowStyle BackColor="#999999" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="Gainsboro" ForeColor="Transparent" HorizontalAlign="Center" />
                                    <HeaderStyle BackColor="Gainsboro" BorderStyle="Double" BorderWidth="1px" Font-Bold="True"
                                        Font-Names="Arial" Font-Size="11px" ForeColor="Black" HorizontalAlign="Left" />
                                    <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                        ForeColor="#404040" />
                                </asp:GridView>
                                                &nbsp;<br />
                                            </strong></span></span>
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
    <br />
</asp:Content>




