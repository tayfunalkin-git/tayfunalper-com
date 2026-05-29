<%@ Page Language="C#" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" AutoEventWireup="true" CodeFile="gelecekteki_gebelik_firsatlari.aspx.cs" Inherits="ivfyonetici_hasta_modulu_gelecekteki_gebelik_firsatlari" EnableEventValidation="false" ValidateRequest="false"  Theme="skinFile"%>
 
  
  <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <script>
    $(function () {
        $.datepicker.setDefaults($.datepicker.regional[""]);
        $("#ctl00_ContentPlaceHolder1_hasta_at").datepicker($.datepicker.regional["tr"]);
        $("#locale").change(function () {
            $("#ctl00_ContentPlaceHolder1_hasta_at").datepicker("option",
				$.datepicker.regional[$(this).val()]);
        });
    });

	</script>


          <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0>
                    <TBODY>
                        <TR>
                            <TD style="HEIGHT: 24px" 
background="../uyeModulu/images/ust_menu_bg.jpg" colSpan=2>
                                <TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0>
                                    <TBODY>
                                        <TR>
                                            <TD style="WIDTH: 176px; HEIGHT: 24px" 
vAlign=middle>
                                                &nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    Text="Sisteme Kayýtlý Adet Tarihleri"></asp:Label></td>
                                            <TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>
                                <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" 
                                                    ImageAlign="AbsMiddle" ImageUrl="~/btn_kaydet.gif" ValidationGroup="ynm" />&nbsp;</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
                <table style="width: 100%">
                    <tr>
                        <td style="text-align: center">
                            <br />
                                <asp:Label ID="Labelsonuc" runat="server" Font-Bold="True" 
                                Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label>
                                <br />
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="Panel4" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; border-left-width: 1px;
                        border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                        width: 100%; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <br />
                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><br />
                                <asp:ImageButton ID="btnEvet" runat="server" ImageUrl="~/imgs/btnevet.gif" OnClick="btnEvet_Click"
                                    Visible="False" />&nbsp;<asp:ImageButton ID="btnHayir" runat="server" ImageUrl="~/imgs/btnhayir.gif"
                                        OnClick="btnHayir_Click" Visible="False" />
                                <br />
                                <br />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; height: 77px; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top">
                <div align="center" style="text-align: left">
                    <table cellpadding="0" cellspacing="0" style="width: 100%">
                        <tr>
                            <td colspan="3" style="font-size: 11px; color: black; font-family: verdana; height: 41px;
                                text-align: center; text-decoration: none">
                                <span style="font-family: Arial">
                                Yeni Adet Tarihi :</span>
                                <asp:TextBox ID="hasta_at" runat="server" MaxLength="10" SkinID="txtNormal" TabIndex="3"
                                    Width="115px" ValidationGroup="ynm"></asp:TextBox>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="hasta_at"
                                    Display="Dynamic" ErrorMessage="Adet Tarihi Boþ Geçilemez" 
                                    Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" 
                                    ValidationGroup="ynm" style="color: #FF0000"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="hasta_at"
                                    Display="Dynamic" ErrorMessage="Ör : AT Formatý 20.01.2009 veya 200109" Font-Size="11px"
                                    SetFocusOnError="True" 
                                    ValidationExpression="(\d\d.\d\d.\d\d\d\d)|(\d\d\d\d\d\d)" Font-Names="Arial" 
                                    ValidationGroup="ynm" style="color: #FF0000"></asp:RegularExpressionValidator><br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="border-right: #d3d3d3 1px solid; border-top: #d3d3d3 1px solid;
                                font-size: 11px; border-left: #d3d3d3 1px solid; width: 100%; color: black; border-bottom: #d3d3d3 1px solid;
                                font-family: verdana; text-decoration: none">
                                <asp:GridView ID="list" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                                    BorderColor="White" BorderStyle="Solid" BorderWidth="1px" CellPadding="4" Font-Size="11px"
                                    ForeColor="#333333" OnPageIndexChanging="list_PageIndexChanging" PageSize="15"
                                    Width="100%" Font-Names="Arial" EnableModelValidation="True">
                                    <FooterStyle BackColor="WhiteSmoke" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="sat" HeaderText="Adet Tarihi" />
                                        <asp:BoundField DataField="ekleyen" HeaderText="Ekleyen" />
                                        <asp:BoundField DataField="eklenme_tarihi" HeaderText="Eklenme Tarihi" />
                                        <asp:TemplateField HeaderText="Sil" Visible="False">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="sil" runat="server" CausesValidation="False" OnClientClick='return confirm("Hasta Adet Tarihi Kalýcý Olarak Silinecektir.Onaylýyormusunuz?")'
                                                    OnCommand="sil_Command">Sil</asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <RowStyle BackColor="#F7F6F3" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                        Font-Names="Arial" ForeColor="#333333" />
                                    <EditRowStyle BackColor="#999999" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="Gainsboro" ForeColor="Transparent" HorizontalAlign="Center" />
                                    <HeaderStyle BackColor="Gainsboro" BorderStyle="Double" BorderWidth="1px" Font-Bold="True"
                                        Font-Names="Arial" Font-Size="11px" ForeColor="Black" HorizontalAlign="Left" />
                                    <AlternatingRowStyle BackColor="Snow" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"
                                        ForeColor="#404040" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>
  
    
  

    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                          <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 24px" 
background="../uyeModulu/images/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD style="WIDTH: 237px; HEIGHT: 24px" 
vAlign=middle>&nbsp;
    <asp:Label id="page_label" runat="server" Font-Size="11px" Font-Names="Arial" Font-Bold="True" Text="Gelecekteki Gebelik Fýrsatlarý"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>   &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
    &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
        &nbsp;&nbsp; &nbsp;&nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
                <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; height: 77px; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top">
                <div align="center">
                    <br />
                        <asp:Panel ID="Panel1" runat="server" Width="95%">
                        <table id="tablem" cellpadding="0" cellspacing="1">
                            <tr>
                                <td style="height: 25px;" width="75">
                                    <asp:Panel ID="yas24" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas23" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas22" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas21" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas20" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas19" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px;" width="70">
                                    <asp:Panel ID="yas18" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="10">
                                </td>
                                <td bgcolor="whitesmoke" colspan="2" style="height: 25px">
                                    <span style="font-size: 10px; font-family: Verdana"><span style="font-size: 11px;
                                        font-family: Arial">Doðum Tarihi :</span> </span>
                                    <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="height: 25px;" colspan="6">
                                    </td>
                                <td style="height: 25px;" width="70">
                                    <asp:Panel ID="yas17" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="10">
                                </td>
                                <td style="height: 25px; background-color: #dcdcdc;" width="75">
                                    <span style="font-weight: bold; font-size: 11px; color: black; font-family: Arial">
                                    Hasta Yaþý</span></td>
                                <td style="color: black; height: 25px; background-color: #dcdcdc" width="100">
                                    <span style="color: black;"><span style="font-family: Arial"><span style="font-size: 11px">
                                        <strong>
                                    Bu Yaþtaki<br />
                                        Aylarý</strong></span></span></span></td>
                            </tr>
                            <tr>
                                <td style="height: 25px;" width="75">
                                    <asp:Panel ID="yas10" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas11" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas12" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas13" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas14" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas15" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px;" width="70">
                                    <asp:Panel ID="yas16" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="10">
                                </td>
                                <td rowspan="3" width="75">
                                    <asp:Panel ID="yas1" runat="server" Height="77px" Width="100%" Font-Size="13px" ForeColor="Navy" HorizontalAlign="Center">
                                        <br />
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="100"><asp:Panel ID="ay12" runat="server" 
                                        Height="25px" Width="100%" BackColor="Gray" BorderStyle="None" 
                                        BorderWidth="0px" ForeColor="White">
                                </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 25px;" width="75">
                                    <asp:Panel ID="yas9" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                </td>
                                <td style="height: 25px" width="75">
                                </td>
                                <td style="height: 25px" width="75">
                                </td>
                                <td style="height: 25px" width="75">
                                </td>
                                <td style="height: 25px" width="75">
                                </td>
                                <td style="height: 25px;" width="70">
                                </td>
                                <td style="height: 25px" width="10">
                                </td>
                                <td style="height: 25px" width="100"><asp:Panel ID="ay11" runat="server" 
                                        Height="25px" Width="100%" BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 25px;" width="75">
                                    <asp:Panel ID="yas8" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas7" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas6" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas5" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas4" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="75">
                                    <asp:Panel ID="yas3" runat="server" Height="25px" Width="100%">
                                    </asp:Panel>
                                </td>
                                <td colspan="2" style="height: 25px">
                                    <asp:Panel ID="yas2" runat="server" Height="25px" Width="100%" Font-Underline="False">
                                    </asp:Panel>
                                </td>
                                <td style="height: 25px" width="100"><asp:Panel ID="ay10" runat="server" 
                                        Height="25px" Width="100%" BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td width="75"><asp:Panel ID="ay1" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="75"><asp:Panel ID="ay2" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="75"><asp:Panel ID="ay3" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="75"><asp:Panel ID="ay4" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="75"><asp:Panel ID="ay5" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="75"><asp:Panel ID="ay6" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td colspan="2"><asp:Panel ID="ay7" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="75"><asp:Panel ID="ay8" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                                <td width="100"><asp:Panel ID="ay9" runat="server" Height="25px" Width="100%" 
                                        BackColor="Gray" ForeColor="White">
                                </asp:Panel>
                                </td>
                            </tr>
                        </table>
                        </asp:Panel>
                    &nbsp;</div>
            </td>
        </tr>
    </table>
      <br />
      <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-right: black 1px solid;
          border-top: black 1px solid; border-left: black 1px solid; width: 95%; border-bottom: black 1px solid">
          <tr>
              <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                  border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3;
                  border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                  <asp:Panel ID="Panel5" runat="server" Visible="False" Width="100%">
                      <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; border-left-width: 1px;
                          border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                          width: 100%; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3">
                          <tr>
                              <td style="height: 30px; text-align: center">
                                  <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                      ForeColor="Black"></asp:Label></td>
                          </tr>
                      </table>
                  </asp:Panel>
                  <table border="0" cellpadding="1" cellspacing="1" style="width: 100%">
                      <tr>
                          <td style="width: 403px" valign="middle">
                              <asp:CheckBoxList ID="son" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="12px"
                                  RepeatDirection="Horizontal" Width="400px">
                                  <asp:ListItem Value="1">Azoospermi</asp:ListItem>
                                  <asp:ListItem Value="2">Over Yetersizliði</asp:ListItem>
                                  <asp:ListItem Value="3">PKOS</asp:ListItem>
                                  <asp:ListItem Value="4">Diðer</asp:ListItem>
                              </asp:CheckBoxList></td>
                          <td style="text-align: right" valign="middle">
                              <asp:ImageButton ID="ImageButton3" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btn_kaydet.gif"
                                  OnClick="ImageButton3_Click" Visible="False" />&nbsp;</td>
                      </tr>
                      <tr>
                          <td colspan="2" valign="middle">
                              <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                  ForeColor="#FF0000" Text="Uyarý Mesajý :  " Visible="False"></asp:Label><asp:Label ID="mesajsonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                  Visible="False"></asp:Label></td>
                      </tr>
                  </table>
              </td>
          </tr>
          </table>
      <br />
      <asp:Panel ID="Panel6" runat="server" Width="100%">
      
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                                      <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR>
                                          <TD style="HEIGHT: 24px" 
background="images/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD style="WIDTH: 314px; HEIGHT: 24px" 
vAlign=middle> &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
        Text="Bu Dönemde Gebelik Fýrsatýnýn En Ýyi Olduðu Günler"></asp:Label></td>
    <TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
                <asp:Panel ID="Panel2" runat="server" Visible="False" Width="100%">
                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;">
                        <tr>
                            <td style="height: 30px; text-align: center">
                                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; height: 77px; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top">
                <div align="center">
                    <br />
                    <asp:Panel ID="Panel3" runat="server" Width="95%">
                        <table cellpadding="1" cellspacing="1">
                            <tr>
                                <td width="100">
                                    <asp:Panel ID="tar1" runat="server" Height="60px" Width="100%" BackColor="#D9FDD9">
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td width="100">
                                    <asp:Panel ID="tar2" runat="server" Height="60px" Width="100%" BackColor="#B3FAB3">
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td width="100">
                                    <asp:Panel ID="tar3" runat="server" Height="60px" Width="100%" BackColor="#8CF88C">
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td width="100">
                                    <asp:Panel ID="tar4" runat="server" Height="60px" Width="100%" BackColor="#8CF88C">
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td width="100">
                                    <asp:Panel ID="tar5" runat="server" Height="60px" Width="100%" BackColor="#3ADB3A">
                                        <br />
                                    </asp:Panel>
                                </td>
                                <td width="100">
                                    <asp:Panel ID="tar6" runat="server" Height="60px" Width="100%" BackColor="#D9FDD9">
                                        <br />
                                    </asp:Panel>
                                </td>
                            </tr>
                            <tr>
                                <td bgcolor="#dcdcdc" colspan="6" style="height: 20px" width="600">
                                    <span style="font-size: 12px; font-family: Arial">SAT :<asp:Label ID="st" runat="server"></asp:Label>
                                        &nbsp;&nbsp; | &nbsp;&nbsp; Siklus :<asp:Label ID="sk" runat="server"></asp:Label>
                                        &nbsp;&nbsp; | &nbsp;&nbsp; Bir Sonraki Olasý AT :<asp:Label ID="at" runat="server"></asp:Label></span></td>
                            </tr>
                        </table>
                        <br />
                        <table style="width: 100%">
                            <tr>
                                <td style="text-align: left">
                                    <span style="font-size: 11px; font-family: Arial"><strong><span style="font-size: 12px;
                                        color: #ff0000">*</span> </strong>Siklus Hesaplamasý son 3 AT 'ye bakýlarak hesaplanmaktadýr.Eðer
                                        son girilen 3 AT arasýndaki farklar 21 den küçük yada 35 ten büyükse sadece son
                                        AT baz alýnarak ortalama siklus deðeri 28 iþleme tabi tutulur<br />
                                        <span style="color: #ff0000">
                                            <br />
                                            *</span> Güncel tarih SAT &#39; ý &nbsp;35 gün geçerse gebelik fýrsatýnýn en iyi 
                                    olduðu günler hesaplanmaz.</span></td>
                            </tr>
                        </table>
                    </asp:Panel>
                    &nbsp;</div>
            </td>
        </tr>
    </table>
    
    </asp:Panel>
    
  
    
    <br />
      <asp:GridView ID="GridView1" runat="server">
      </asp:GridView>
</asp:Content>



