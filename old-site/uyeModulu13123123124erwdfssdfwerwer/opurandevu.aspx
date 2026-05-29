<%@ Page Language="C#" EnableEventValidation="false" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="opurandevu.aspx.cs" Inherits="ivfyonetici_opurandevu" Theme="SkinFile" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <br />
     <asp:ScriptManager ID="ScriptManager1" runat="server">
     
     
    </asp:ScriptManager>
    &nbsp;
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: #000000 1px solid;
        border-top: #000000 1px solid; border-left: #000000 1px solid; width: 95%; border-bottom: #000000 1px solid">
        <tr>
            <td valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td background="../../imgs/ust_menu_bg.jpg" colspan="2" style="height: 24px">
                            <table cellpadding="0" cellspacing="0" style="width: 100%">
                                <tr>
                                    <td style="width: 202px; height: 24px" valign="middle">
                                        &nbsp;<asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Names="Arial"
                                            Font-Size="11px" Text="OPU Randevu Kaydı"></asp:Label></td>
                                    <td style="height: 24px; text-align: right" valign="middle">
                                        &nbsp;&nbsp;</td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="panel_sonuc2" runat="server" HorizontalAlign="Center" Visible="False"
                    Width="100%">
                    <br />
                    &nbsp;<asp:Label ID="sonuc22" runat="server" Font-Bold="True" Font-Names="Arial"
                        Font-Size="11px" ForeColor="Black"></asp:Label><br />
                </asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt; font-family: Times New Roman">
            <td valign="top" >
                <div align="left">
                    <table cellpadding="0" cellspacing="0" style="overflow: hidden; clip: rect(10px 10px 10px 10px)"
                        width="100%">
                        <tr>
                            <td colspan="8" style="font-size: 11px; color: gray; font-family: verdana; height: 13px"
                                valign="top">
                                <table cellpadding="0" cellspacing="0" style="width: 100%">
                                    <tr>
                                        <td colspan="2" style="height: 28px" valign="middle">
                                            <span>
                                                <table cellspacing="1" style="width: 100%">
                                                    <tr>
                                                        <td align="center" style="text-align: left">
                                                            <span>&nbsp;<asp:GridView id="listopu" runat="server" Font-Size="11px" Font-Names="Arial" Width="90%" ForeColor="#333333" CellPadding="4" AutoGenerateColumns="False" HorizontalAlign="Center">
<RowStyle VerticalAlign="Top" BackColor="#F7F6F3" ForeColor="#333333"></RowStyle>
<Columns>
<asp:TemplateField HeaderText="Se&#231;"><ItemTemplate>
    <asp:RadioButton ID="sec" runat="server" />
    <asp:Label ID="raporID" runat="server" Visible="False"></asp:Label>
</ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle VerticalAlign="Middle" Width="30px"></ItemStyle>
</asp:TemplateField>
<asp:TemplateField HeaderText="Toplantı Tarihi"><ItemTemplate>
                                                            <asp:Label ID="tarih0" runat="server"></asp:Label>
                                                                                             
                                                        
</ItemTemplate>

<HeaderStyle HorizontalAlign="Left"></HeaderStyle>

<ItemStyle VerticalAlign="Middle" Width="90px"></ItemStyle>
</asp:TemplateField>
    <asp:BoundField DataField="tedavibaslamatarihi" HeaderText="Tedavi Başlama Tarihi">
        <HeaderStyle HorizontalAlign="Left" />
    </asp:BoundField>
    <asp:TemplateField HeaderText="Varsayılan Siklus / SAT">
        <ItemTemplate>
            <asp:Label ID="siklus" runat="server"></asp:Label>
            <asp:Label ID="sat" runat="server"></asp:Label>
        </ItemTemplate>
        <HeaderStyle HorizontalAlign="Left" />
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Durum"></asp:TemplateField>
    <asp:TemplateField HeaderText="OPU İptal">
        <ItemTemplate>
            <asp:LinkButton ID="iptal" runat="server" OnClientClick="return confirm('OPU randevusunu iptal etmek istediğinize emin misiniz?')">İptal</asp:LinkButton>
        </ItemTemplate>
    </asp:TemplateField>
</Columns>

<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></FooterStyle>

<PagerStyle HorizontalAlign="Center" BackColor="#284775" ForeColor="White"></PagerStyle>

<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White"></HeaderStyle>

<EditRowStyle BackColor="#999999"></EditRowStyle>

<AlternatingRowStyle BackColor="White" ForeColor="#284775"></AlternatingRowStyle>
</asp:GridView>
                                                                <br />
                                                                <br />
                                                                <table align="center" style="width: 90%; border-right: silver 1px solid; border-top: silver 1px solid; border-left: silver 1px solid; border-bottom: silver 1px solid;">
                                                                    <tr>
                                                                        <td style="text-align: center">
                                                                            <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                                                                                <tr>
                                                                                    <td style="width: 7px; height: 21px; background-color: gainsboro; text-align: left">
                                                                                    </td>
                                                                                    <td style="height: 21px; background-color: gainsboro; text-align: left">
                                                                                        <span style="font-size: 11px; color: black; font-family: Arial"><strong>Randevu Seçimi</strong></span></td>
                                                                                </tr>
                                                                            </table>
                                                                            <span>
                                                                                <br />
                                                                                <table style="width: 100%">
                                                                                    <tr>
                                                                                        <td style="text-align: center">
                                                                                            <span style="color: black">
                                                                                            Tarih :</span>
                                                                                            <asp:TextBox ID="tarih" runat="server" SkinID="txtNormal"></asp:TextBox>&nbsp;<asp:ImageButton
                                                                                                ID="takvim" runat="server" ImageUrl="~/imgs/btnclndr.gif" ImageAlign="AbsMiddle" />&nbsp;
                                                                                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" SkinID="btn" Text="Sorgula"
                                                                                                ValidationGroup="tar" />
                                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tarih"
                                                                                                Display="Dynamic" SetFocusOnError="True" ValidationGroup="tar"></asp:RequiredFieldValidator></td>
                                                                                    </tr>
                                                                                </table>
                                                                            </span>
                                                                            <br />
                                                                            &nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#000000"></asp:Label>
                                                                            <asp:Label ID="Label2" runat="server" ForeColor="#000000"></asp:Label>
                                                                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center"
                                                                                Width="60%">
                                                                                <Columns>
                                                                                    <asp:TemplateField HeaderText="Saat">
                                                                                        <ItemTemplate>
                                                                                            <asp:Label ID="saat" runat="server"></asp:Label>
                                                                                        </ItemTemplate>
                                                                                        <ItemStyle Width="130px" />
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField>
                                                                                        <ItemTemplate>
                                                                                            <asp:RadioButton ID="onay" runat="server" ValidationGroup="on" />
                                                                                        </ItemTemplate>
                                                                                        <ItemStyle HorizontalAlign="Center" />
                                                                                    </asp:TemplateField>
                                                                                    <asp:BoundField DataField="aralik" HeaderText="aralık" />
                                                                                </Columns>
                                                                            </asp:GridView>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <br />
                                                            </span>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </span>
                                            <br />
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
    
     <script type="text/javascript">
          
  Calendar.setup({
inputField    : "ctl00_ContentPlaceHolder1_tarih",    
button : "ctl00_ContentPlaceHolder1_takvim",   
   align         : "Tr"
            });
          </script>
</asp:Content>



