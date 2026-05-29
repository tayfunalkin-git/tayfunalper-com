<%@ Page Title="" Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000077.aspx.cs" Inherits="mainAdminPagesHdn_0000073" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <link href="https://netdna.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.css" rel="stylesheet">
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.js"></script> 
<script src="https://netdna.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.js"></script> 

<!-- include summernote css/js -->
<link href="https://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.12/summernote.css" rel="stylesheet">
   <script src="https://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.12/summernote.js"></script>


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
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>  &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;<&nbsp;</TD></TR></TABLE></TD></TR></TABLE>
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
                                            <p>
        <table style="width: 100%" cellpadding="0" cellspacing="0">
            <tr>
                <td style="color: #0000CC">Yazıyı Nereye Eklemek İstiyorsunuz?</td>
            </tr>
        </table>
        <asp:DropDownList ID="turList" runat="server" CssClass="form-control" Width="198px">
        </asp:DropDownList>
    </p>
    <p>
        <span style="color: #0000CC">Hangi Kategorilerde Görünsün ?</span><br />
        <asp:CheckBoxList ID="kategoriler" runat="server" CellPadding="0" CellSpacing="0" RepeatColumns="3" Width="100%" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
    </p>
    <p>
        <span style="color: #0000CC">Yazının Başlığı :
        <br />
        <asp:TextBox ID="txtBaslik" runat="server" Width="450px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
    <p>
        <table cellpadding="0" cellspacing="0" style="width: 100%">
            <tr>
                <td>
        <span style="color: #0000CC">Yazının İçeriği :
        </span>
                </td>
                <td style="text-align: right">
                    <asp:LinkButton ID="Label2" runat="server"></asp:LinkButton>
                </td>
            </tr>
        </table>
        <span style="color: #0000CC">
        <asp:TextBox ID="txtIcerik" runat="server" Width="100%" Height="420px" TextMode="MultiLine"></asp:TextBox>
        </span>
    </p>
    <p>
        <span style="color: #0000CC">
        <br />
        Yazının Kapak Resmini Seçiniz :
        <br />
        <asp:LinkButton ID="Label1" runat="server"></asp:LinkButton>
        </span>

        
       <asp:HiddenField ID="txtKapak" runat="server"/>
    </p>
    <div id="secilenKapakResmi" runat="server">
    </div>
    <p>
        <span style="color: #0000CC">Bunu Biliyor muydunuz? : <span style="font-weight: normal; color: #000000">(Opsiyonel)</span></span></p>
                                            <p>
                                                &nbsp;<span style="color: #0000CC"><span style="font-weight: normal; color: #000000"><asp:TextBox ID="txtBiliyor" runat="server" Width="400px" CssClass="form-control" Height="128px" TextMode="MultiLine"></asp:TextBox>
        </span> </span>
        </p>
                                            <p>
                                                <span style="color: #0000CC">
        <br />
        <br />
        Yayınlansın mı ?<br />
                                                </span>
        <asp:RadioButtonList ID="yayin" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="E">Evet</asp:ListItem>
            <asp:ListItem Value="H" Selected="True">Hayır</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="btn_1" Text="DEĞİŞİKLİKLERİ KAYDET" OnClick="Button1_Click" />
    </p>
        <p>
        <br />
    </p>
              <script>
                  $(document).ready(function () {
                      $('#ctl00_ContentPlaceHolder1_txtIcerik').summernote({
                          toolbar: [
                            // [groupName, [list of button]]
                            ['style', ['bold', 'italic', 'underline', 'clear']],
                            ['color', ['color']],
                            ['para', ['ul', 'ol', 'paragraph']],
                            ['height', ['height']],
                            ['undo', ['undo']],
                            ['redo', ['redo']],
                            ['codeview', ['codeview']],
                            ['fullscreen', ['fullscreen']]

                          ],
                          height: 400
                      });

                  });

  </script>

                                        </td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                        </tr>
                    </table>




   
</asp:Content>

