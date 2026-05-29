<%@ Page Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" AutoEventWireup="true" CodeFile="0000062.aspx.cs" Inherits="administrator_ebebaba_pages_0000022" Theme="SkinFile"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    <br />
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
        <tr>
            <td valign="bottom">
              <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD 
style="WIDTH: 202px; HEIGHT: 24px" vAlign=middle> &nbsp;
    <asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" 
                              Text="Gelen Soru"></asp:Label> </TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle><asp:ImageButton id="Button1" runat="server" CausesValidation="False" ImageUrl="~/imgs/btngeridon.gif" ImageAlign="AbsMiddle" OnClick="Button1_Click1"></asp:ImageButton> 
<asp:ImageButton id="Button2" runat="server" ImageUrl="~/imgs/btnsil.gif" OnClientClick="return confirm('Mesaj Silinecektir.Onaylýyormusunuz?')" ImageAlign="AbsMiddle" CausesValidation="False" OnClick="Button2_Click1"></asp:ImageButton>&nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
                <asp:Panel ID="Panel3" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                    <br />
                    &nbsp;<asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label><br />
                </asp:Panel>
            </td>
        </tr>
        <tr style="font-size: 12pt">
            <td valign="top">
                <div align="left">
                    <table width="100%" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 14px">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 14px; width: 76px;" 
                                valign="middle">
                            </td>
                            <td colspan="4" style="font-size: 11px; color: gray; font-family: Tahoma; height: 14px"
                                valign="middle">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 19px;">
                                &nbsp;</td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 19px; width: 76px;" 
                                valign="middle">
                                <span style="color: black">Gönderen : </span>
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 19px;" 
                                colspan="4" valign="middle">
                                <asp:Label ID="Label3" runat="server" ForeColor="Black" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:Label>
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;<span
                                    style="color: black">Tarih :
                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:Label>
                                    &nbsp; &nbsp;</span></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 10px;">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: gray; font-family: Tahoma; border-bottom: lightgrey 1px solid; height: 10px;">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; border-bottom: lightgrey 1px solid; height: 10px;">
                            </td>
                            <td style="font-size: 11px; color: black; font-family: verdana; height: 10px;">
                            </td>
                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 10px;">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 15px;
                                text-align: right">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px; width: 76px;" 
                                valign="middle">
                                <span style="color: black">Email :</span></td>
                            <td colspan="4" style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px"
                                valign="middle">
                                <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                    ForeColor="Black"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 15px;
                                text-align: right">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px; width: 76px;" 
                                valign="middle">
                            </td>
                            <td colspan="4" style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px"
                                valign="middle">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; text-align: right; height: 15px;">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px; width: 76px;" 
                                valign="middle">
                                <span style="color: black">Soru : </span>
                            </td>
                            <td colspan="4" 
                                style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px;" 
                                valign="middle">
                                <asp:Label ID="Label4" runat="server" ForeColor="Black" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; height: 10px;">
                            </td>
                            <td colspan="2" style="font-size: 11px; color: gray; font-family: Tahoma; border-bottom: lightgrey 1px solid; height: 10px;">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; border-bottom: lightgrey 1px solid; height: 10px;">
                            </td>
                            <td style="font-size: 11px; color: black; font-family: verdana; height: 10px;">
                            </td>
                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 10px;">
                            </td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; width: 62px; color: gray; font-family: verdana; text-align: right; height: 15px;" valign="top">
                            </td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px; width: 76px;" 
                                valign="middle">
                                &nbsp;</td>
                            <td style="font-size: 11px; color: gray; font-family: Tahoma; height: 15px;" 
                                colspan="4" valign="middle">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 15px;" 
                                colspan="6">
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
    </table>


    <br />

   <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td valign="bottom">
             <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TBODY><TR><TD style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TBODY><TR><TD 
style="WIDTH: 221px; HEIGHT: 24px" vAlign=middle> &nbsp;
    <asp:Label id="Label1" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Cevapla (Mail Olarak Cevaplanýr)"></asp:Label> </TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>
    &nbsp;<asp:ImageButton id="btnKaydet" runat="server" ImageUrl="~/imgs/mesajgonder.gif" ImageAlign="AbsMiddle" OnClick="btnKaydet_Click1"></asp:ImageButton>&nbsp;</TD></TR></TBODY></TABLE></TD></TR></TBODY></TABLE>
               <asp:Panel ID="panel_sonuc" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                   &nbsp;<asp:Label ID="sonuc" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"
                                   ForeColor="Black"></asp:Label><br />
               </asp:Panel>
           </td>
       </tr>
       <tr>
           <td valign="top">
               <div align="left">
                   <table style="overflow: hidden; clip: rect(10px 10px 10px 10px)" width="98%">
                       <tr>
                           <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 23px">
                           </td>
                           <td style="font-size: 11px; width: 170px; color: gray; font-family: verdana; height: 23px">
                           </td>
                           <td colspan="4" 
                               style="font-size: 11px; color: gray; font-family: verdana; height: 23px">
                           </td>
                       </tr>
                       <tr>
                           <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 20px;">
                           </td>
                           <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma; height: 20px;" valign="top">
                               <span style="color: black">Gönderen : </span>
                           </td>
                           <td style="font-size: 11px; color: gray; font-family: verdana; height: 20px;" 
                               colspan="4">
                               <asp:Label ID="Label7" runat="server" ForeColor="Black" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px">Prof.Dr. Tayfun ALPER</asp:Label>
                               <asp:Label ID="Label9" runat="server" ForeColor="Black" Visible="False"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 20px;">
                                            </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma; height: 20px;" valign="top">
                                                Alýcý :</td>
                                            <td style="font-size: 11px; color: black; font-family: verdana; height: 20px;" 
                                                colspan="4">
                                                <asp:Label ID="Label8" runat="server" ForeColor="Black" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px"></asp:Label>
                                                <asp:Label ID="Label10" runat="server" ForeColor="Black" Visible="False"></asp:Label></td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; height: 5px;">
                                            </td>
                                            <td colspan="2" style="font-size: 11px; color: black; font-family: Tahoma; width: 170px; height: 5px;">
                                                </td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: verdana; height: 5px;">
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: verdana; height: 5px;">
                                                </td>
                                            <td style="font-size: 11px; width: 130px; color: gray; font-family: verdana; height: 5px;">
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; width: 54px; color: gray; font-family: verdana; text-align: right;" valign="top">
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="msjmesaj"
                                                    Display="Dynamic" ErrorMessage="*" Font-Names="Tahoma" Font-Size="12px" SetFocusOnError="True"></asp:RequiredFieldValidator></td>
                                            <td style="font-size: 11px; width: 170px; color: black; font-family: Tahoma; height: 20px;" valign="top">
                                                Cevap :
                                            </td>
                                            <td style="font-size: 11px; color: black; font-family: verdana;" colspan="4">
                                                <asp:TextBox ID="msjmesaj" runat="server" Height="70px" TextMode="MultiLine" Width="446px" SkinID="txtGenisliksiz"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td style="font-size: 11px; color: gray; font-family: verdana; height: 20px;" 
                                                colspan="6">
                                            </td>
                                        </tr>
                                    </table>
                                </div>
                            </td>
                        </tr>
                    </table>
    <br />


</asp:Content>


