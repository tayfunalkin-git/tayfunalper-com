<%@ Page Title="" Language="C#" MasterPageFile="~/administrator_ebebaba_pages/Ebebaba_Master_New.master" EnableEventValidation="false" ValidateRequest="false" AutoEventWireup="true" CodeFile="0000188.aspx.cs" Inherits="mainAdminPagesHdn_0000073" %>

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
vAlign=middle> &nbsp;<asp:Label id="Label14" runat="server" Font-Size="11px" Font-Names="Tahoma" Font-Bold="True" Text="Bölüm Sıralamaları"></asp:Label></TD><TD 
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
                                            <br />
                                            <table style="border: 1px solid #808080; width: 100%">
                                                <tr>
                                                    <td style="padding: 10px; color: #FFFFFF; width: 98px; background-color: #666666;"><b>Bölüm</b></td>
                                                    <td style="padding: 10px; color: #FFFFFF; background-color: #666666;"><b>Başlık</b></td>
                                                    <td style="padding: 10px; color: #FFFFFF; background-color: #666666;"><b>Sıralama</b></td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">1</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">Prof. Dr. Tayfun ALPER</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama9" runat="server" Enabled="False" style="font-size: 15px">
                                                            <asp:ListItem>1</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">2</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik2" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama2" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">3</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik3" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama3" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">4</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik4" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama4" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">5</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik5" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama5" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">6</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik6" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama6" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">7</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik7" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama7" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">8</td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:Label ID="baslik8" runat="server" style="font-size: 15px"></asp:Label>
                                                    </td>
                                                    <td style="padding: 10px; border-bottom-style: solid; border-bottom-width: 1px; border-bottom-color: #999999">
                                                        <asp:DropDownList ID="siralama8" runat="server" style="font-size: 15px">
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                            <asp:ListItem>6</asp:ListItem>
                                                            <asp:ListItem>7</asp:ListItem>
                                                            <asp:ListItem>8</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                            </table>
                                            <p>
                                                &nbsp;</p>
                                            <p>
        <asp:Button ID="Button1" runat="server" CssClass="btn_1" Text="Kaydet / Güncelle" OnClick="Button1_Click" />
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

