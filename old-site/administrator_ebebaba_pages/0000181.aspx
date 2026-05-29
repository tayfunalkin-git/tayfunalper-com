<%@ Page Title="" Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000181.aspx.cs" Inherits="mainAdminPagesHdn_0000073" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
          

    
  <link href="https://netdna.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.css" rel="stylesheet">
<script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.js"></script> 
<script src="https://netdna.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.js"></script> 


      <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: #000000 1px solid; border-top: #000000 1px solid; border-left: #000000 1px solid; border-bottom: #000000 1px solid;">
       <tr>
           <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
               border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
               <TABLE cellSpacing=0 cellPadding=0 width="100%" border=0><TR><TD 
style="HEIGHT: 24px" 
background="../imgs/ust_menu_bg.jpg" colSpan=2 valign="middle"><TABLE style="WIDTH: 100%" cellSpacing=0 
cellPadding=0><TR><TD style="WIDTH: 202px; HEIGHT: 24px" 
vAlign=middle> &nbsp;<asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Ekip Üyesi Bilgi Düzenle"></asp:Label></TD><TD 
style="HEIGHT: 24px; TEXT-ALIGN: right" vAlign=middle>  &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;</TD></TR></TABLE></TD></TR></TABLE>
               <asp:Panel ID="panel2" runat="server" Visible="False" Width="100%" HorizontalAlign="Center">
                   <br />
                               <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="11px" ForeColor="Black"></asp:Label><br />
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
        <span style="color: #0000CC">Adı Soyadı : <br />
        <asp:TextBox ID="txtBaslik" runat="server" Width="300px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
                                            <p>
                                                <span style="color: rgb(32, 33, 36); font-family: arial, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Ör Whatsapp :&nbsp;&lt;a href=&#39;<a href="https://wa.me/+905306673200">https://wa.me/+905306673200</a>&#39; style=&#39;text-decoration:none;&#39; target=&#39;_blank&#39;&gt;&lt;img src=&#39;https://www.tayfunalper.com/images/whatsapp.png&#39; style=&#39;width:20px;display: inline-block;margin-bottom:-3px;&#39;/&gt; 530 667 32 00&lt;/a&gt;</span></p>
                                            <p>
                                                &nbsp;</p>
                                            <p>
                                                <span style="color: #0000CC">Pozisyon :<asp:DropDownList ID="kategoriList" runat="server" CssClass="form-control" Width="198px">
        </asp:DropDownList>
    &nbsp;<br />
            E-Posta (Opsiyonel) :
        <asp:TextBox ID="txtPosta" runat="server" Width="300px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
    <p>
        <span style="color: #0000CC">
        Resim : <br />
                                                <asp:LinkButton ID="LinkButton1" runat="server">Seç</asp:LinkButton>

        
        </span>

        
       <asp:HiddenField ID="txtKapak" runat="server"/>
    </p>
    <div id="secilenKapakResmi" runat="server">
    </div>
        <p>
            <span style="color: #0000CC">Kısa Açıklama :&nbsp;
        </span><span style="color: #000000; font-weight: normal;">(Opsiyonel)<br />
            <span style="color: #0000CC">
        <asp:TextBox ID="txtAciklama" runat="server" Width="350px" Height="150px" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
        </span>
        </span><span style="color: #0000CC">
            <br />
            </span>
        </p>
    <p>
        <span style="color: #0000CC">
        Youtube Kanalı: <span style="font-weight: normal; color: #000000">Opsiyonel - Tam Adresi - <span style="font-size: 14px">Ör: <a href="https://www.youtube.com/channel/UCEofNe2qCJLIPpRLMVXG9Mw">https://www.youtube.com/channel/UCEofNe2qCJLIPpRLMVXG9Mw</a></span></span><asp:TextBox ID="txtYoutube" runat="server" Width="305px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
                                            <p>
                                                <span style="color: #0000CC">
        <br />
                                                Facebook Adresi : <span style="font-weight: normal; color: #000000">Opsiyonel - Tam Adresi - <span style="font-size: 14px">Ör: <a href="https://www.facebook.com/tayfun.alper.9)">https://www.facebook.com/tayfun.alper.9</a></span></span><asp:TextBox ID="txtFacebook" runat="server" Width="300px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
                                            <p>
                                                &nbsp;</p>
                                            <p>
                                                <span style="color: #0000CC">
                                                Instagram Adresi : <span style="font-weight: normal; color: #000000">(Opsiyonel - Tam Adresi - <span style="font-size: 14px">Ör: <a href="https://www.instagram.com/prof.dr.tayfunalper/?hl=tr)">https://www.instagram.com/prof.dr.tayfunalper/?hl=tr</a></span><a href="https://www.instagram.com/prof.dr.tayfunalper/?hl=tr)">)</a></span><asp:TextBox ID="txtInstagram" runat="server" Width="300px" CssClass="form-control"></asp:TextBox>
        </span>
    </p>
        <p>
            <span style="color: #0000CC">
        <br />
        Yayınlansın mı ?</span><asp:RadioButtonList ID="yayin" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="E">Evet&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</asp:ListItem>
            <asp:ListItem Value="H" Selected="True">Hayır</asp:ListItem>
        </asp:RadioButtonList>
        </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="btn_1" Text="KAYDET" OnClick="Button1_Click" />
    </p>
        <p>
        <br />
    </p>

                                        </td>
                                    </tr>
                                </table>
                                <br />
                            </td>
                        </tr>
                    </table>














    

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

          
          });




  </script>


   
</asp:Content>

