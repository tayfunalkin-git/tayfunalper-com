<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master"  CodeFile="0000064.aspx.cs" Inherits="administrator_ebebaba_pages_0000064" Theme="SkinFile" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<script type="text/javascript">

function SelectAllCheckboxes(parentCheckBox) 

{ 
 var children = parentCheckBox.children; 


var theBox = (parentCheckBox.type == "checkbox") ? parentCheckBox: parentCheckBox.children.item[0]; 


var checkboxes = theBox.form.elements;

if(parentCheckBox.checked)
{



for(i=0; i<checkboxes.length; i++) 

{ 


if(checkboxes[i].type == "checkbox" && checkboxes[i].id != "ctl00_ContentPlaceHolder1_gelenmesajlar_ctl01_chkAll") 

{
checkboxes[i].checked = true;
}



} 
}

else

{


for(i=0; i<checkboxes.length; i++) 

{ 


if(checkboxes[i].type == "checkbox" && checkboxes[i].id != "ctl00_ContentPlaceHolder1_gelenmesajlar_ctl01_chkAll") 

{checkboxes[i].checked = false;}



} 

}
}
</script>


    <br />

   <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
             <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD style="WIDTH: 419px; HEIGHT: 24px" 
vAlign=middle> &nbsp;<asp:Label id="Label15" runat="server" Font-Size="11px" Font-Names="Arial" 
                             Font-Bold="True"></asp:Label>
                                                            &nbsp;<asp:Label id="Label14" runat="server" 
                             Font-Size="11px" Font-Names="Arial" 
                             Font-Bold="True" Text="e-Demokrasi Mesajlarý"></asp:Label>
                                                            <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle><asp:ImageButton id="Button1" runat="server" CausesValidation="False" ImageUrl="~/imgs/btnokundu.gif" ImageAlign="AbsMiddle" OnClientClick="return confirm('Seçili Mesajlarý Okundu Olarak Ýþaretlemek Ýstediðinizden Eminmisiniz?')" OnCommand="LinkButton2_Command"></asp:ImageButton> 
<asp:ImageButton id="Button2" runat="server" ImageUrl="~/imgs/btnsil.gif" ImageAlign="AbsMiddle" OnClientClick="return confirm('Seçili Mesajlar Silinecektir.Onaylýyormusunuz?')" OnCommand="LinkButton1_Command"></asp:ImageButton>&nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                   &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px" ForeColor="Black"></asp:Label><br />
                   <br />
               </asp:Panel>
               </td>
       </tr>
                        <tr>
                            <td valign="top">
                                <div align="left">
                                    <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="100%" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td colspan="7" style="font-size: 11px; color: gray; border-top-color: darkgray;
                                                border-bottom: darkgray 1px solid; font-family: verdana; text-align: center">
                                                &nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 23px" colspan="7">
                                                                <asp:GridView ID="gelenmesajlar" runat="server" AutoGenerateColumns="False" BorderColor="White"
                                                                    BorderStyle="Solid" BorderWidth="1px" CellPadding="0" Width="100%" 
                                                                    AllowPaging="True" OnPageIndexChanging="gelenmesajlar_PageIndexChanging" 
                                                                    PageSize="15" OnRowDataBound="gelenmesajlar_RowDataBound" 
                                                                    EnableModelValidation="True" style="margin-right: 0px">
                                                                    
                                                                    <Columns>
                                                                    
                                                                        <asp:TemplateField>
                                                                        <HeaderTemplate>
                                                                        
                                                                        <input id="chkAll" onclick="SelectAllCheckboxes(this);" runat="server" type="checkbox" />
                                                                        
                                                                       

                                                                        </HeaderTemplate>
                                                                            <ItemTemplate>
                                                                                <asp:CheckBox ID="secmesaj" runat="server" />
                                                                                <asp:Image ID="yeni" runat="server" ImageUrl="~/administrator_ebebaba_pages/images/mail.gif" Visible="False" />
                                                                                <asp:Image ID="okundu" runat="server" ImageUrl="~/administrator_ebebaba_pages/images/acik.gif" Visible="False" />
                                                                                <asp:Image ID="cevap" runat="server" ImageUrl="~/administrator_ebebaba_pages/images/giden.gif" Visible="False" />
                                                                            </ItemTemplate>
                                                                            <ItemStyle HorizontalAlign="Left" Width="70px" VerticalAlign="Middle" />
                                                                            <HeaderStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField HeaderText="G&#246;nderen" >
                                                                            <ItemStyle Width="180px" />
                                                                        </asp:BoundField>
                                                                        <asp:TemplateField HeaderText="Mesaj Tipi">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="mesajTip" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Gönderen Tipi">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="gonderenTip" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Gönderim Tipi">
                                                                            <ItemTemplate>
                                                                                <asp:Label ID="gonderimTip" runat="server"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField HeaderText="Mesaja Git">
                                                                            <ItemTemplate>
                                                                                <asp:LinkButton ID="konum" runat="server" oncommand="konu_Command">Mesaja Git</asp:LinkButton>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:BoundField DataField="tarih" HeaderText="G&#246;nderme Tarihi">
                                                                            <ItemStyle Width="140px" />
                                                                        </asp:BoundField>
                                                                        <asp:BoundField DataField="mesaj_id" Visible="False" />
                                                                        
                                                                    </Columns>
                                                                    <AlternatingRowStyle Height="20px" />
                                                                    <RowStyle Height="20px" Font-Names="Arial" Font-Size="11px" />
                                                                    <SelectedRowStyle BackColor="Yellow" Wrap="True" />
                                                                    <PagerStyle BackColor="WhiteSmoke" HorizontalAlign="Right" Font-Names="Arial" Font-Size="11px" ForeColor="Gray" />
                                                                    <HeaderStyle BackColor="Gainsboro" Height="20px" VerticalAlign="Middle" ForeColor="Black" Font-Bold="True" Font-Names="Arial" Font-Size="11px" />
                                                                </asp:GridView>
                                                                
                                                                
                                                                
                                                                
                                            </td>
                                        </tr>
                                       
                                    </table> 
                                </div>
    <table  align="center" cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="text-align: right;">
                <table cellpadding="0" cellspacing="0" style="width: 100%">
                    <tr>
                        <td style="height: 28px; text-align: left">
                            &nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Arial" Font-Size="11px"></asp:Label>
                                                            <asp:LinkButton ID="arasonc" runat="server" CausesValidation="False" OnClick="arasonc_Click"
                                                                Visible="False" Font-Names="Arial" Font-Size="11px">Arama Sonuçlarý Modundan Çýk</asp:LinkButton></td>
                        <td style="height: 28px">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="aranacak"
                                Display="Dynamic" ErrorMessage="Aranacak Anahtar Kelimeyi Giriniz." Font-Names="Arial"
                                Font-Size="11px" SetFocusOnError="True" ValidationGroup="ara"></asp:RequiredFieldValidator>
                                                            <asp:TextBox ID="aranacak" runat="server" SkinID="txtOzel" Width="124px" ValidationGroup="ara"></asp:TextBox>&nbsp;<asp:ImageButton
                                                                ID="Button3" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnara.gif"
                                                                OnClick="Button3_Click1" ValidationGroup="ara" />&nbsp;</td>
                    </tr>
                </table>
                </td>
        </tr>
    </table>
                            </td>
                        </tr>
                    </table>
<br />
                                    
                                              
</asp:Content>


