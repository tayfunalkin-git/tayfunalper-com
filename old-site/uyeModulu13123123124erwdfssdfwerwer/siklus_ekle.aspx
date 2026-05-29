<%@ Page Language="C#" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" AutoEventWireup="true" CodeFile="siklus_ekle.aspx.cs" Inherits="ivfyonetici_hasta_modulu_siklus_ekle"  Theme="SkinFile" EnableEventValidation="false" ValidateRequest="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                      <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0>
                    <TBODY>
                        <TR>
                            <TD style="HEIGHT: 24px" 
background="../../imgs/ust_menu_bg.jpg" colSpan=2>
                                <TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0>
                                    <TBODY>
                                        <TR>
                                            <TD style="WIDTH: 82px; HEIGHT: 24px" 
vAlign=middle>
                                                &nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    Text="Siklus Ekle"></asp:Label></td>
                                            <TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>
                                <asp:ImageButton ID="btnKaydet" runat="server" OnClick="btnKaydet_Click1" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif" ValidationGroup="ynm" />&nbsp;</td>
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
                            <td style="text-align: center">
                                <br />
                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black" Font-Italic="False"></asp:Label><br />
                                <br />
                                <asp:ImageButton ID="Button1" runat="server" ImageUrl="~/imgs/btnevet.gif" OnClick="Button1_Click1"
                                    Visible="False" />
                                <asp:ImageButton ID="Button2" runat="server" ImageUrl="~/imgs/btnhayir.gif" OnClick="Button2_Click1"
                                    Visible="False" /></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; height: 77px; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top">
                <div align="left">
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%">
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; text-align: center;" colspan="7" rowspan="2">
                                <br />
                                <span style="color: black; font-family: Arial">
                                Siklus Kaydý, Güncel Tarih Bilgisine Göre Aþaðýdaki Deðerler ile Kaydedilecektir.<br />
                                <br />
                                Gün :&nbsp;</span><asp:DropDownList ID="siklus_gun" runat="server" SkinID="drop">
                                    <asp:ListItem Value="1">01</asp:ListItem>
                                    <asp:ListItem Value="2">02</asp:ListItem>
                                    <asp:ListItem Value="3">03</asp:ListItem>
                                    <asp:ListItem Value="4">04</asp:ListItem>
                                    <asp:ListItem Value="5">05</asp:ListItem>
                                    <asp:ListItem Value="6">06</asp:ListItem>
                                    <asp:ListItem Value="7">07</asp:ListItem>
                                    <asp:ListItem Value="8">08</asp:ListItem>
                                    <asp:ListItem Value="9">09</asp:ListItem>
                                    <asp:ListItem>10</asp:ListItem>
                                    <asp:ListItem>11</asp:ListItem>
                                    <asp:ListItem>12</asp:ListItem>
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
                                </asp:DropDownList><span style="color: black; font-family: Arial">
                                &nbsp; &nbsp; &nbsp;
                                Ay : </span>
                            <asp:DropDownList ID="siklus_ay" runat="server" SkinID="drop">
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
                                </asp:DropDownList><span style="color: black; font-family: Arial">
                                &nbsp; &nbsp;&nbsp;
                                Yýl :&nbsp;</span><asp:DropDownList ID="siklus_yil" runat="server" SkinID="drop">
                                    <asp:ListItem>2006</asp:ListItem>
                                    <asp:ListItem>2007</asp:ListItem>
                                    <asp:ListItem>2008</asp:ListItem>
                                    <asp:ListItem>2009</asp:ListItem>
                                    <asp:ListItem>2010</asp:ListItem>
                                    <asp:ListItem>2011</asp:ListItem>
                                    <asp:ListItem>2012</asp:ListItem>
                                    <asp:ListItem>2013</asp:ListItem>
                                    <asp:ListItem>2014</asp:ListItem>
                                    <asp:ListItem>2015</asp:ListItem>
                                    <asp:ListItem>2016</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: black; font-family: verdana">
                            </td>
                            <td style="font-size: 11px; width: 170px; color: #000000; font-family: verdana">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: #000000; font-family: verdana">
                            </td>
                            <td style="font-size: 11px; width: 130px; color: #000000; font-family: verdana">
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>



