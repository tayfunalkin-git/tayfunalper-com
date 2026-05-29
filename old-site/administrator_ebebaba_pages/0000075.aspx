<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000075.aspx.cs" Inherits="ebebaba_0000063" Debug="true" Theme="SkinFile"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
   <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="top">
               <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                           <table cellpadding="0" cellspacing="0" style="width: 100%">
                               <tr>
                                   <td style="width: 197px; height: 24px;" valign="middle">
                                       &nbsp;<asp:Label ID="page_label" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" Text="Ýstatistikler"></asp:Label></td>
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
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="width: 9px; height: 17px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 17px">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 10px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 10px">
                                                Baþlangýç Tarihi :&nbsp;<asp:DropDownList ID="baslangicgun" runat="server" SkinID="drop">
                                                    <asp:ListItem Value="01">01</asp:ListItem>
                                                    <asp:ListItem Value="02">02</asp:ListItem>
                                                    <asp:ListItem Value="03">03</asp:ListItem>
                                                    <asp:ListItem Value="04">04</asp:ListItem>
                                                    <asp:ListItem Value="05">05</asp:ListItem>
                                                    <asp:ListItem Value="06">06</asp:ListItem>
                                                    <asp:ListItem Value="07">07</asp:ListItem>
                                                    <asp:ListItem Value="08">08</asp:ListItem>
                                                    <asp:ListItem Value="09">09</asp:ListItem>
                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                    <asp:ListItem Value="11">11</asp:ListItem>
                                                    <asp:ListItem Value="12">12</asp:ListItem>
                                                    <asp:ListItem>13</asp:ListItem>
                                                    <asp:ListItem>14</asp:ListItem>
                                                    <asp:ListItem>15</asp:ListItem>
                                                    <asp:ListItem>16</asp:ListItem>
                                                    <asp:ListItem>17</asp:ListItem>
                                                    <asp:ListItem>18</asp:ListItem>
                                                    <asp:ListItem>19</asp:ListItem>
                                                    <asp:ListItem>20</asp:ListItem>
                                                    <asp:ListItem>21</asp:ListItem>
                                                    <asp:ListItem>22</asp:ListItem>
                                                    <asp:ListItem>23</asp:ListItem>
                                                    <asp:ListItem>24</asp:ListItem>
                                                    <asp:ListItem>25</asp:ListItem>
                                                    <asp:ListItem>26</asp:ListItem>
                                                    <asp:ListItem>27</asp:ListItem>
                                                    <asp:ListItem>28</asp:ListItem>
                                                    <asp:ListItem>29</asp:ListItem>
                                                    <asp:ListItem>30</asp:ListItem>
                                                    <asp:ListItem>31</asp:ListItem>
                                                </asp:DropDownList>
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
                                                    <asp:ListItem>2010</asp:ListItem>
                                                    <asp:ListItem>2011</asp:ListItem>
                                                    <asp:ListItem>2012</asp:ListItem>
                                                    <asp:ListItem>2013</asp:ListItem>
                                                    <asp:ListItem>2014</asp:ListItem>
                                                    <asp:ListItem>2015</asp:ListItem>
                                                    <asp:ListItem>2016</asp:ListItem>
                                                </asp:DropDownList>&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                                Bitiþ Tarihi :&nbsp;<asp:DropDownList ID="bitisgun" runat="server" SkinID="drop">
                                                    <asp:ListItem Value="01">01</asp:ListItem>
                                                    <asp:ListItem Value="02">02</asp:ListItem>
                                                    <asp:ListItem Value="03">03</asp:ListItem>
                                                    <asp:ListItem Value="04">04</asp:ListItem>
                                                    <asp:ListItem Value="05">05</asp:ListItem>
                                                    <asp:ListItem Value="06">06</asp:ListItem>
                                                    <asp:ListItem Value="07">07</asp:ListItem>
                                                    <asp:ListItem Value="08">08</asp:ListItem>
                                                    <asp:ListItem Value="09">09</asp:ListItem>
                                                    <asp:ListItem Value="10">10</asp:ListItem>
                                                    <asp:ListItem Value="11">11</asp:ListItem>
                                                    <asp:ListItem Value="12">12</asp:ListItem>
                                                    <asp:ListItem>13</asp:ListItem>
                                                    <asp:ListItem>14</asp:ListItem>
                                                    <asp:ListItem>15</asp:ListItem>
                                                    <asp:ListItem>16</asp:ListItem>
                                                    <asp:ListItem>17</asp:ListItem>
                                                    <asp:ListItem>18</asp:ListItem>
                                                    <asp:ListItem>19</asp:ListItem>
                                                    <asp:ListItem>20</asp:ListItem>
                                                    <asp:ListItem>21</asp:ListItem>
                                                    <asp:ListItem>22</asp:ListItem>
                                                    <asp:ListItem>23</asp:ListItem>
                                                    <asp:ListItem>24</asp:ListItem>
                                                    <asp:ListItem>25</asp:ListItem>
                                                    <asp:ListItem>26</asp:ListItem>
                                                    <asp:ListItem>27</asp:ListItem>
                                                    <asp:ListItem>28</asp:ListItem>
                                                    <asp:ListItem>29</asp:ListItem>
                                                    <asp:ListItem>30</asp:ListItem>
                                                    <asp:ListItem>31</asp:ListItem>
                                                </asp:DropDownList>
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
                                                </asp:DropDownList>
                                                <asp:DropDownList ID="bitisyil" runat="server" SkinID="drop">
                                                    <asp:ListItem>2010</asp:ListItem>
                                                    <asp:ListItem>2011</asp:ListItem>
                                                    <asp:ListItem>2012</asp:ListItem>
                                                    <asp:ListItem>2013</asp:ListItem>
                                                    <asp:ListItem>2014</asp:ListItem>
                                                    <asp:ListItem>2015</asp:ListItem>
                                                    <asp:ListItem>2016</asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; Gösterim Þekli
                                                :
                                                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"
                                                    RepeatLayout="Flow">
                                                    <asp:ListItem Selected="True">G&#252;nl&#252;k</asp:ListItem>
                                                    <asp:ListItem>Aylýk</asp:ListItem>
                                                </asp:RadioButtonList></td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 20px">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 20px">
                                                <hr />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 9px; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: Arial; height: 20px;">
                                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sorgula" /></td>
                                        </tr>
                                        </table>
                                </div><asp:Panel ID="Panel1" runat="server" Visible="False" Width="100%" HorizontalAlign="Left">
                                    <br />
                                    <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                        <tr>
                                            <td background="../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                                    <tr>
                                                        <td style="width: 196px; height: 24px; text-align: left;" valign="middle">
                                                            &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                                Text="Sorgu Sonuçlarý"></asp:Label></td>
                                                        <td style="height: 24px; text-align: right;" valign="middle">
                                                            &nbsp;
                                                            
                                                            &nbsp;</td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="text-align: center">
                                                <br />
                                                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    ForeColor="Black"></asp:Label><br />
                                            </td>
                                        </tr>
                                    </table>
                                    <table width="100%">
                                        <tr>
                                            <td style="text-align: center">
                                                <br />
                                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" Font-Names="Arial" 
                                                    Font-Size="11px" ForeColor="#333333" GridLines="Vertical" 
                                                    AutoGenerateColumns="False" EnableModelValidation="True">
                                        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="Tarih">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="tarih" runat="server" Font-Underline="False" 
                                                        style="font-size: 12px"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Toplam Sayfa / Farklý Sayfa">
                                                <ItemTemplate>
                                                    <asp:Label ID="sayfa" runat="server" style="font-size: 12px"></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Farklý Ziyaretçi Sayýsý">
                                                <ItemTemplate>
                                                    <asp:Label ID="ziyaretci" runat="server" style="font-size: 12px"></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <EditRowStyle BackColor="#999999" />
                                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    </asp:GridView>
                                            </td>
                                        </tr>
                                    </table>
                                    &nbsp;</asp:Panel>
                            </td>
                        </tr>
                    </table>
    <br />
    
</asp:Content>


