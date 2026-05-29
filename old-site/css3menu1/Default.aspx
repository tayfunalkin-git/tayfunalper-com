<%@ Page Language="C#" MasterPageFile="~/NewMasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="bolum" Theme="SkinFile" ValidateRequest="false"%>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>



<%@ Register src="anasayfa.ascx" tagname="anasayfa" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contentplaceholder2" Runat="Server">
        <script type="text/javascript" src="js/jquery-1.5.1.min.js"></script>
 <link type="text/css" href="js/basic.css" rel="stylesheet" media="screen" />

 <link type="text/css" href="js/basic_ie.css" rel="stylesheet" media="screen" />

 <link type="text/css" href="js/gg_fb.css" rel="stylesheet" media="screen" />
 <script type="text/javascript" src="js/jquery.simplemodal.1.4.1.min.js"></script>
  <div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/tr_TR/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>

      <table cellpadding="0" cellspacing="0"  class="style1">
        <tr>
            <td>
                &nbsp;</td>
            <td style="width: 640px" valign="top">
                    
                    <img src="anaResim.jpg" width="605" height="650" border="0" usemap="#Map" />
<map name="Map" id="Map"><area shape="rect" coords="19, 112, 121, 151" 
        href="makale.aspx?Bolum_ID=318&amp;Konu_ID=435" />
<area shape="rect" coords="19, 152, 277, 190" 
        href="makale.aspx?Bolum_ID=318&amp;Konu_ID=439" />
<area shape="rect" coords="21, 227, 138, 256" 
        href="makale.aspx?Bolum_ID=327&amp;Konu_ID=431" />
<area shape="rect" coords="23, 260, 222, 293" 
        href="makale.aspx?Bolum_ID=327&amp;Konu_ID=433" />
<area shape="rect" coords="24, 296, 269, 364" 
        href="makale.aspx?Bolum_ID=327&amp;Konu_ID=442" />
<area shape="rect" coords="7, 431, 107, 473" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=488" />
<area shape="rect" coords="7, 474, 164, 505" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=489" />
<area shape="rect" coords="7, 504, 49, 541" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=491" />
<area shape="rect" coords="51, 506, 144, 542" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=493" />
<area shape="rect" coords="9, 539, 107, 572" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=494" />
<area shape="rect" coords="107, 544, 198, 574" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=495" />
<area shape="rect" coords="9, 574, 162, 610" 
        href="makale.aspx?Bolum_ID=324&amp;Konu_ID=496" />
<area shape="circle" coords="540, 165, 67" 
        href="makale.aspx?Bolum_ID=319&amp;Konu_ID=428" />
<area shape="rect" coords="394, 335, 582, 404" 
        href="makale.aspx?Bolum_ID=327&amp;Konu_ID=434" />
<area shape="rect" coords="335, 429, 484, 477" 
        href="makale.aspx?Bolum_ID=321&Konu_ID=457" />
<area shape="rect" coords="335, 479, 583, 527" 
        href="makale.aspx?Bolum_ID=321&amp;Konu_ID=474" />
<area shape="rect" coords="435, 575, 583, 610" 
        href="makale.aspx?Bolum_ID=328&amp;Konu_ID=475" />
<area shape="rect" coords="436, 612, 521, 644" href="iletisim.aspx" />
</map>
                    
                    
                    </td>
            <td style="width: 6px" class="ara">
                &nbsp;&nbsp;</td>
            <td style="width: 250px" valign="top">
                <table cellpadding="0" cellspacing="0" >
                    <tr>
                        <td class="icerik12">
                                                        <uc1:anasayfa ID="anasayfa1" runat="server" />
                            </td>
                    </tr>
                </table>
                <table cellspacing="1" style="width: 100%">
                    <tr>
                        <td style="width: 1px">
                            &nbsp;</td>
                        <td>

                        <div id="te" runat="server">
                        
                        </div>
                                        
</td>
                    </tr>
                </table>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
           
</asp:Content>




