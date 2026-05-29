<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="tedaviOnerisi.aspx.cs" Inherits="a_heyet" Theme="SkinFile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
       <script>
           $(function () {
               $(".ht").datepicker({
                   showOn: "button",
                   buttonImage: "../btnclndr.gif",
                   buttonImageOnly: true
               });

               $(".ht").datepicker($.datepicker.regional["tr"]);
               $(".ht").datepicker("option", "changeYear", true);
               $(".ht").datepicker("option", "changeMonth", true);
               $(".ht").datepicker("option", "constrainInput", false);
               $(".ht").datepicker("option", "duration", "fast");

           });
	</script>
     <asp:ScriptManager ID="ScriptManager1" runat="server"/>

    <br />
     <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td valign="bottom">
             <table border="0" cellpadding="0" cellspacing="0" width="100%">
                   <tr>
                       <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                           <table cellpadding="0" cellspacing="0" style="width: 100%">
                               <tr>
                                   <td style="width: 202px; height: 24px;" valign="middle">
                                       &nbsp;<asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Names="Arial"
                                                    Font-Size="11px" Text="Tedavi Önerisi"></asp:Label></td>
                                   <td style="height: 24px; text-align: right;" valign="middle">
                                       &nbsp;</td>
                               </tr>
                           </table>
                       </td>
                   </tr>
               </table>
                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                    <br />
                    &nbsp;<asp:Label ID="sonuc2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><span>
                    <span style="font-family: Arial"><strong>
                    <br />
                    &nbsp;&nbsp;</strong></span></span></asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt; font-family: Times New Roman;">
            <td valign="top">
                <div align="left">
                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                        <tr>
                            <td colspan="8" style="font-size: 11px; font-family: Arial; height: 12px;"
                                valign="top">
                                <table cellpadding="0" cellspacing="0" style="width: 100%;">
                                    <tr>
                                        <td colspan="2" style="height: 28px; " valign="middle">
                                            <span><span style="font-family: Arial">
                                            <strong>
                                                <br />
                                                    <table cellspacing="1" style="width: 100%">
                                                        <tr>
                                                            <td style="width: 273px">
                                                                &nbsp;</td>
                                                            <td>
                                                                <asp:RadioButtonList ID="secim" runat="server" CellPadding="5" CellSpacing="10" 
                                                                    RepeatLayout="Flow" style="font-size: 12px; font-weight: 700" 
                                                                    ValidationGroup="basvuru">
                                                                    <asp:ListItem Value="0">Tüp Bebek Tedavisi Olabilir</asp:ListItem>
                                                                    <asp:ListItem Value="1">Randevu Listesine Al / Tedaviye Başla</asp:ListItem>
                                                                </asp:RadioButtonList>
&nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 273px">
                                                                &nbsp;</td>
                                                            <td>
                                            <span><span style="font-family: Arial">
                                            <strong>
                                                                <br />
                                       <asp:ImageButton ID="onayla" runat="server" ImageAlign="AbsMiddle" 
                                           ImageUrl="~/imgs/btnonay.gif" OnClick="onayla_Click1" 
                                           ValidationGroup="basvuru" Width="70px" />&nbsp;
                                            </strong>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                                    ControlToValidate="secim" Display="Dynamic" 
                                                                    ErrorMessage="Lütfen bir seçenek işaretleyiniz ." SetFocusOnError="True" 
                                                                    style="font-size: 12px" ValidationGroup="basvuru"></asp:RequiredFieldValidator>
                                                                </span>
                                                    
                                                    
                                                    
                                                    
                                                    </span>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 273px">
                                                                &nbsp;</td>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                            </table>
                                            </strong>
                                            <table align="center" cellpadding="0" cellspacing="0" style="width: 80%">
                                                <tr>
                                                    <td>
                                            <span><span style="font-family: Arial">
                                            <strong>
                                                        <asp:Panel ID="Panel1" runat="server" BackColor="#FFFFCC" BorderColor="#999999" 
                                                            BorderStyle="Solid" BorderWidth="1px" Height="51px" HorizontalAlign="Center" 
                                                            Visible="False" Width="100%">
                                                            <SPAN>
                                                                <TABLE cellSpacing=0 cellPadding=0>
                                                                    <TBODY>
                                                                        <TR>
                                                                            <TD vAlign=middle style="text-align: center">
                                                                                <br />
                                                                                <asp:RadioButtonList id="yer" runat="server" __designer:wfdid="w32" 
                    CellPadding="0" RepeatLayout="Flow" RepeatDirection="Horizontal" 
                    OnSelectedIndexChanged="yer_SelectedIndexChanged" CellSpacing="0" 
                    AutoPostBack="True">
                                                                                    <asp:ListItem Value="1">MP-SAMSUN</asp:ListItem>
                                                                                    <asp:ListItem Value="2">Diğer Kurum</asp:ListItem>
                                                                                    <asp:ListItem Value="3">Beklemede</asp:ListItem>
                                                                                </asp:RadioButtonList>
                                                                                <asp:RequiredFieldValidator id="kontrol" runat="server" ControlToValidate="yer" Display="Dynamic" ErrorMessage="◄" SetFocusOnError="True" ValidationGroup="onayla"></asp:RequiredFieldValidator>
                                                                                <asp:Label id="lblyer" runat="server" Visible="False" Text="/ Tedavi Yeri : " 
                    ForeColor="#000099" __designer:wfdid="w34"></asp:Label>
                                                                                <asp:TextBox id="txtyer" runat="server" Visible="False" Width="106px" 
                    __designer:wfdid="w35"></asp:TextBox>
                                                                                <span><span style="font-family: Arial"><strong>
                                                                                <asp:RequiredFieldValidator ID="kontrol4" runat="server" __designer:wfdid="w38" 
                                                                                    ControlToValidate="txtyer" Display="Dynamic" ErrorMessage="◄" 
                                                                                    SetFocusOnError="True" ValidationGroup="onayla"></asp:RequiredFieldValidator>
                                                                                </strong></span></span>
                                                                                <asp:Label id="lbltarih" runat="server" Visible="False" 
                    Text="/ Tedavi Tarihi : " ForeColor="#000099" __designer:wfdid="w36"></asp:Label>
                                                                                <asp:DropDownList id="drptarih" runat="server" Visible="False" 
                    __designer:wfdid="w37" SkinID="drop">
                                                                                </asp:DropDownList>
                                                                                <asp:RequiredFieldValidator id="kontrol2" runat="server" __designer:wfdid="w38" 
                    ControlToValidate="drptarih" Display="Dynamic" ErrorMessage="◄" SetFocusOnError="True" ValidationGroup="onayla"></asp:RequiredFieldValidator>
                                                                                &nbsp;
                                                                                <asp:Label id="lblmazeret" runat="server" Visible="False" Text="/ Nedeni : " 
                    ForeColor="#000099" __designer:wfdid="w7"></asp:Label>
                                                                                <asp:DropDownList id="drpmazeret" runat="server" Visible="False" 
                    __designer:wfdid="w40" SkinID="drop">
                                                                                </asp:DropDownList>
                                                                                <asp:RequiredFieldValidator id="kontrol3" runat="server" __designer:wfdid="w41" 
                    ControlToValidate="drpmazeret" Display="Dynamic" ErrorMessage="◄" SetFocusOnError="True" ValidationGroup="onayla"></asp:RequiredFieldValidator>
                                                                                <asp:ImageButton id="kaydet" runat="server" ImageUrl="~/imgs/btn_kaydet.gif" 
                    ImageAlign="AbsMiddle" ValidationGroup="onayla" onclick="kaydet_Click">
                                                                                </asp:ImageButton>
                                                                            </TD>
                                                                        </TR>
                                                                    </TBODY>
                                                                </TABLE>
                                                            </SPAN>
                                                        </asp:Panel>
                                            </strong></span>
                                                    
                                                    
                                                    
                                                    
                                                    </span>
                                                        <br />
                                            <span>
                                            <span style="font-family: Arial">
                                            <strong>
                                                        <asp:Panel ID="Panel2" runat="server" BackColor="#FFFFCC" BorderColor="#999999" 
                                                            BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center" 
                                                            Visible="False" Width="100%">
                                                            <asp:Panel ID="Panel3" runat="server">
                                                                <asp:Label ID="Label16" runat="server" Visible="False"></asp:Label>
                                                                <span><span style="font-family: Arial"><strong>
                                                                <asp:Label ID="Label17" runat="server" Visible="False"></asp:Label>
                                                                </strong></span></span>
                                                                <br />
                                                                Tedaviye Başlanacak Siklus
                                                                <asp:Label ID="Label15" runat="server"></asp:Label>
                                                                &nbsp;mi?<br />
                                                                <br />
                                                                <span><span style="font-family: Arial"><strong>
                                                                <asp:ImageButton ID="kaydet0" runat="server" ImageAlign="AbsMiddle" 
                                                                    ImageUrl="~/imgs/btnevet.gif" onclick="kaydet0_Click" 
                                                                    onclientclick="return confirm('Hastanın Belirtilen Siklusu ile tedavisi başlayacaktır.Onaylıyormusunuz?')" 
                                                                    ValidationGroup="onayla" />
                                                                &nbsp;<asp:ImageButton ID="kaydet1" runat="server" ImageAlign="AbsMiddle" 
                                                                    ImageUrl="~/imgs/btnhayir.gif" onclick="kaydet1_Click" />
                                                                <br />
                                                                </strong></span></span>
                                                                <br />
                                                            </asp:Panel>
                                                            <span><span style="font-family: Arial"><strong>
                                                            <asp:Panel ID="Panel4" runat="server" Visible="False">
                                                                <br />
                                                                Aktif Edilebilecek Siklus Var Mı ?<br />
                                                                <br />
                                                                <span><span style="font-family: Arial"><strong>
                                                                <asp:DropDownList ID="siklus" runat="server" __designer:wfdid="w37" 
                                                                    SkinID="drop" ValidationGroup="onayla3">
                                                                </asp:DropDownList>
                                                                <br />
                                                                </strong></span></span>
                                                                <br />
                                                                <span><span style="font-family: Arial"><strong>
                                                                <asp:ImageButton ID="kaydet2" runat="server" ImageAlign="AbsMiddle" 
                                                                    ImageUrl="~/imgs/btnevet.gif" onclick="kaydet2_Click" 
                                                                    onclientclick="return confirm('Seçilen Siklus Aktif Edilerek Tedavi Süreci Başlayacaktır.Onaylıyormusunuz?')" 
                                                                    ValidationGroup="onayla3" />
                                                                &nbsp;<asp:ImageButton ID="kaydet3" runat="server" ImageAlign="AbsMiddle" 
                                                                    ImageUrl="~/imgs/btnhayir.gif" onclick="kaydet3_Click1" />
                                                                <br />
                                                                </strong></span></span>
                                                                <br />
                                                            </asp:Panel>
                                                            <asp:Panel ID="Panel5" runat="server" Visible="False">
                                                                <br />
                                                                Yeni Sikus Ekle Ve Tedaviyi Başlat<br />
                                                                <br />
                                                                <span style="color: black; font-family: Arial">Gün :&nbsp;</span><asp:DropDownList 
                                                                    ID="siklus_gun" runat="server" SkinID="drop">
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
                                                                </asp:DropDownList>
                                                                <span style="color: black; font-family: Arial">&nbsp; &nbsp; &nbsp; Ay : </span>
                                                                <asp:DropDownList ID="siklus_ay" runat="server" SkinID="drop">
                                                                    <asp:ListItem Value="01">Ocak</asp:ListItem>
                                                                    <asp:ListItem Value="02">Şubat</asp:ListItem>
                                                                    <asp:ListItem Value="03">Mart</asp:ListItem>
                                                                    <asp:ListItem Value="04">Nisan</asp:ListItem>
                                                                    <asp:ListItem Value="05">Mayıs</asp:ListItem>
                                                                    <asp:ListItem Value="06">Haziran</asp:ListItem>
                                                                    <asp:ListItem Value="07">Temmuz</asp:ListItem>
                                                                    <asp:ListItem Value="08">Ağustos</asp:ListItem>
                                                                    <asp:ListItem Value="09">Eylül</asp:ListItem>
                                                                    <asp:ListItem Value="10">Ekim</asp:ListItem>
                                                                    <asp:ListItem Value="11">Kasım</asp:ListItem>
                                                                    <asp:ListItem Value="12">Aralık</asp:ListItem>
                                                                </asp:DropDownList>
                                                                <span style="color: black; font-family: Arial">&nbsp; &nbsp;&nbsp; Yıl :&nbsp;</span><asp:DropDownList 
                                                                    ID="siklus_yil" runat="server" SkinID="drop">
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
                                                                </asp:DropDownList>
                                                                <span><span style="font-family: Arial"><strong>
                                                                <br />
                                                                </strong></span></span>
                                                                <br />
                                                                <span><span style="font-family: Arial"><strong>
                                                                <asp:ImageButton ID="kaydet4" runat="server" ImageAlign="AbsMiddle" 
                                                                    ImageUrl="~/imgs/btnonay.gif" onclick="kaydet4_Click" />
                                                                <br />
                                                                </strong></span></span>
                                                                <br />
                                                            </asp:Panel>
                                                            </strong></span></span>
                                                        </asp:Panel>
                                            </strong>
                                                    
                                                    
                                                    
                                                    
                                                    </span>
                                                    
                                                    
                                                    
                                                    
                                                    </span>
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                            </span>
                                                    
                                                    
                                                    
                                                    
                                                    </span></td>
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
    <br />
</asp:Content>




