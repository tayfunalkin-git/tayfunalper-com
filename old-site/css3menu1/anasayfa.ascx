<%@ Control Language="C#" AutoEventWireup="true" CodeFile="anasayfa.ascx.cs" Inherits="anasayfa" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
 
 <style type="text/css"> 
 
    @import url("css3menu1/Style.css"); 

 </style>
 <style type="text/css">
    .style1221
    {
        width: 250px;
    }
    .style33363
    {        height: 32px;
        width: 234px;
    }
         
    
    .style456525
    {
        height: 32px;
        width: 14px;
    }
    
     .style122142
    {
        visibility:hidden;

    }
         
    
     .style122143
     {
         height: 9px;
     }
         
    
 </style>
<asp:ScriptManager id="ScriptManager1" runat="server"/>

               
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>


    <asp:GridView ID="ana" runat="server" AutoGenerateColumns="False" 
    EnableModelValidation="True" GridLines="None" onrowdatabound="ana_RowDataBound" 
    ShowHeader="False">
    <Columns>
        <asp:TemplateField>
            <ItemTemplate>
                <table cellpadding="2" class="style1221" 
                    style="border-bottom-style: dotted; border-bottom-width: 1px; border-bottom-color: #999999">
                    <tr>
                        <td class="style33363">
                            <asp:LinkButton ID="baslik" runat="server" CssClass="anaYazi" 
                                Font-Underline="False"></asp:LinkButton>
                        </td>
                        <td class="style456525">
                            <asp:ImageButton ID="kapat" runat="server" CssClass="style122142" 
                                ImageUrl="~/images/kapat.png" oncommand="kapat_Command" />
                        </td>
                    </tr>
                    <tr>
                        <td align="justify" colspan="2" valign="top">
                            <asp:Image ID="resim" runat="server" CssClass="anaYaziResim" 
                                ImageAlign="Left" />
                            <asp:LinkButton ID="icerik" runat="server" Font-Names="tahoma" Font-Size="12px" 
                                Font-Underline="False" ForeColor="#666666"></asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td align="justify" class="style122143" colspan="2" valign="top">
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>


</ContentTemplate>
                 </asp:UpdatePanel>



