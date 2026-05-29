<%@ Page Title="" Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000190.aspx.cs" Inherits="mainAdminPagesHdn_0000073" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
    
  <link href="https://netdna.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.css" rel="stylesheet">
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.js"></script> 
<script src="https://netdna.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.js"></script> 
        <br>

     <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
               <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TR><TD 
style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2 valign="middle"><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TR><TD style="WIDTH: 202px; HEIGHT: 24px" 
vAlign=middle> &nbsp;<asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Yeni Site Ekle"></asp:Label></TD><TD 
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
    <p>
        &nbsp;</p>
                                            <p>
                                                <span style="color: #0000CC">Site Adı : <span style="font-size: 12px">(Ör: Samsun Tüp Bebek)</span><br />
        <asp:TextBox ID="txtSiteAdi" runat="server" Width="500px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
                                            <p>
                                                <span style="color: #0000CC">Footer Metni : <span style="font-size: 12px">(Ör: Samsun Tüp Bebek)</span><asp:TextBox ID="txtFooter" runat="server" Width="500px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
                                            <p>
                                                <span style="color: #0000CC">Adresi : <span style="font-size: 12px">(Ör: http://www.samsuntupbebek.com)</span>
        <asp:TextBox ID="txtAdres" runat="server" Width="500px" CssClass="form-control"></asp:TextBox>
        &nbsp;
        <br />
                                                Resim : <br />
        </span>
                                                <asp:LinkButton ID="LinkButton1" runat="server">Seç</asp:LinkButton>

        
       <asp:HiddenField ID="txtKapak" runat="server"/>
    </p>
    <div id="secilenKapakResmi" runat="server">
    </div>
        <p>
            <span style="color: #0000CC">
        Yayınlansın mı ?</span><asp:RadioButtonList ID="yayin" runat="server" RepeatDirection="Horizontal" CellPadding="10" CellSpacing="10">
            <asp:ListItem Value="+">Evet&nbsp;&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem Value="-" Selected="True">Hayır</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="btn_1" Text="KAYDET" OnClick="Button1_Click" />
    </p>
        <p>
        <br />
    </p>
            
   
       <script>
           $(document).ready(function () {
               $('#ctl00_ContentPlaceHolder1_txtEgitim').summernote({
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
                   height: 200
               });

               $('#ctl00_ContentPlaceHolder1_txtYayin').summernote({
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
                   height: 200
               });

               $("#ctl00_ContentPlaceHolder1_txtEgitim").summernote('code', '<div style="font-family: Arial;font-size:14px;color:#000;"><br></div>')
               $("#ctl00_ContentPlaceHolder1_txtYayin").summernote('code', '<div style="font-family: Arial;font-size:14px;color:#000;"><br></div>')

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

