<%@ Control Language="C#" AutoEventWireup="true" CodeFile="in_ks.ascx.cs" Inherits="ivfyonetici_hasta_modulu_in_ks" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>

      <style type="text/css">
          .style1
          {
              height: 27px;
          }
      </style>

<%--<script>
    $(function () {
        $.datepicker.setDefaults($.datepicker.regional[""]);
        $("#ctl00_ContentPlaceHolder1_In_ks1_txtalan3").datepicker($.datepicker.regional["tr"]);
        $("#locale").change(function () {
            $("#ctl00_ContentPlaceHolder1_In_ks1_txtalan3").datepicker("option",
				$.datepicker.regional[$(this).val()]);
        });
    });

    $(function () {
        $.datepicker.setDefaults($.datepicker.regional[""]);
        $("#ctl00_ContentPlaceHolder1_In_ks1_txtalan4").datepicker($.datepicker.regional["tr"]);
        $("#locale").change(function () {
            $("#ctl00_ContentPlaceHolder1_In_ks1_txtalan4").datepicker("option",
				$.datepicker.regional[$(this).val()]);
        });
    });

	</script>--%>

<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
&nbsp;<table border="0" cellpadding="0" cellspacing="0" style="width: 96%" align=center>
        <tr>
            <td style="text-align: left; height: 67px;">
            
            <asp:Panel ID="ts" runat="server" Visible="False" Width="99%" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px">
                    <table align="center" border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px;
        border-left-width: 1px; border-left-color: #dcdcdc; border-bottom-width: 1px;
        border-bottom-color: #dcdcdc; border-top-color: #dcdcdc; border-right-width: 1px;
        border-right-color: #dcdcdc" width="100%">
                        <tr>
                            <td style="border-top-width: 1px;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3; text-align: center;" valign="top">
                                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                    <tr>
                                        <td style="border-bottom-width: 1px; border-bottom-color: #d3d3d3; font-size: 12pt; font-family: Times New Roman; height: 22px; border-top-width: 1px; border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="top">
                                            <asp:Panel ID="Panel2" runat="server" Width="100%">
                                                <table border="0" cellpadding="0" cellspacing="0" style="width: 100%; border-bottom-width: 1px; border-bottom-color: lightgrey; border-top-style: none; border-right-style: none; border-left-style: none;" height="24">
                                                    <tr>
                                                        <td background="images/ust_menu_bg.jpg" style="width: 7px; height: 22px; text-align: left">
                                                        </td>
                                                        <td background="images/ust_menu_bg.jpg" style="width: 20px; height: 22px; text-align: left">
                                                            <img id="ac2" src="images/ac.gif" runat="server" onclick ="ac2();" style ="display:none" /><img id="kapa2" runat="server" src="images/kapat.gif" onclick ="kapa2();" /></td>
                                                        <td style="height: 22px; text-align: left;" background="images/ust_menu_bg.jpg">
                                                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label>&nbsp;</td>
                                                        <td style="text-align: right; height: 22px; font-size: 12pt; font-family: Times New Roman;" background="images/ust_menu_bg.jpg">
                                                            <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
                                                            <asp:ImageButton ID="btnKaydet" runat="server" 
                                                                ImageUrl="~/imgs/btnguncelle.gif" OnClick="btnKaydet_Click1" 
                                                                ImageAlign="AbsMiddle" ViewStateMode="Disabled" Visible="False" />
                                                            <asp:ImageButton ID="d_kaydet" runat="server" ImageUrl="~/imgs/btn_kaydet.gif" OnClick="d_kaydet_Click1" Visible="False" ImageAlign="AbsMiddle" ValidationGroup="ynmtc"/>
                                                            <asp:ImageButton ID="ipt" runat="server" ImageUrl="~/imgs/btniptl.gif" OnClick="ipt_Click1" Visible="False" ImageAlign="AbsMiddle" />
                                                            <img align="absMiddle" onclick="window.open('kisa_siklus_guncelleme_bilgi.aspx?siklus_id=<%=Request.QueryString["siklus_id"] %>','','width=460,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')"
                                    src="images/guncelleyenler.gif" style="cursor: hand" />&nbsp;
                                                        </td>
                                                    </tr>
                                                </table>
                                            </asp:Panel>
                                        </td>
                                    </tr>
                                </table>
                                <asp:Panel ID="Panel3" runat="server" Visible="False" Width="100%">
                                    <table border="0" cellpadding="0" cellspacing="0" style="border-top-width: 1px; width: 100%; border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;">
                                        <tr>
                                            <td style="height: 30px; text-align: center">
                                                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"
                                                    ForeColor="Black"></asp:Label></td>
                                        </tr>
                                    </table>
                                </asp:Panel>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtsat"
                                    Display="Dynamic" ErrorMessage="Ör : SAT Formatı 08.01.2009 veya 080109" Font-Bold="True"
                                    Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d)|(\d\d\d\d\d\d)"
                                    ValidationGroup="ynmtc" Width="220px"></asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtsat"
                                    Display="Dynamic" ErrorMessage="SAT Boş Geçilemez " Font-Bold="True" Font-Names="Arial"
                                    Font-Size="11px" SetFocusOnError="True" ValidationGroup="ynmtc"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="border-top-width: 1px;
                border-top-color: #d3d3d3; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top" id="Td1">
                                
                                <div id="gizlenecek2" runat="server" style="width:100%;  display:block;">
                                <table style="width: 100%; border-bottom: lightgrey 1px solid">
                                    <tr>
                                        <td valign="top" style="width: 400px">
                                            <table width="100%">
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;SAT :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lblsat" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:TextBox ID="txtsat" runat="server" SkinID="txtsiklus" Visible="False" ValidationGroup="ynmtc"></asp:TextBox>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Tanı - 1 :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lbltani1" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:TextBox ID="txttani1" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox>&nbsp;
                                                        <asp:ImageButton
                                                            ID="ImageButton1" runat="server" ImageUrl="~/ivfyonetici/hasta_modulu/images/auto.gif" AlternateText="Tanı Değerlerini Al" BorderColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px" ImageAlign="AbsMiddle" OnClick="ImageButton1_Click" Visible="False" CausesValidation="False" /></td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Tanı - 2 :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lbltani2" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:TextBox ID="txttani2" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Tanı - 3 :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lbltani3" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:TextBox ID="txttani3" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Tanı - 4 :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lbltani4" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:TextBox ID="txttani4" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Kurum :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lblkurum" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:DropDownList ID="txtkurum" runat="server" Visible="False" SkinID="drop">
                                                        </asp:DropDownList>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Tedavi Türü :
                                                    </td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lbltedavituru" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:DropDownList ID="txttedavituru" runat="server" Visible="False" SkinID="drop">
                                                        </asp:DropDownList>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        &nbsp;Tedavi Protokolü :</td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        &nbsp;<asp:Label ID="lbltedaviprotokolu" runat="server" Font-Names="Verdana" Font-Size="11px" Font-Bold="False">-&nbsp;&nbsp;</asp:Label>&nbsp;<asp:DropDownList ID="txttedaviprotokolu" runat="server" Visible="False" SkinID="drop">
                                                        </asp:DropDownList>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        <asp:Label ID="etkalan1" runat="server" Visible="False"></asp:Label></td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        <asp:Label ID="lblalan1" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                            Visible="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:Label ID="b1" runat="server" Visible="False">&nbsp;</asp:Label>&nbsp;
                                                        <asp:TextBox ID="txtalan1" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox></td>
                                                </tr>
                                                <tr>
                                                    <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-weight: normal;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: #000000; border-bottom: lightgrey 1px solid;
                                                        font-style: normal; font-family: arial; text-decoration: none; width: 130px;">
                                                        <asp:Label ID="etkalan2" runat="server" Visible="False"></asp:Label></td>
                                                    <td bgcolor="ghostwhite" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-weight: normal; font-size: 11px; border-left: lightgrey 1px solid; color: #000000;
                                                        border-bottom: lightgrey 1px solid; font-style: normal; font-family: arial;
                                                        text-decoration: none">
                                                        <asp:Label ID="lblalan2" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                            Visible="False">-&nbsp;&nbsp;</asp:Label>
                                                        <asp:Label ID="b2" runat="server" Visible="False">&nbsp;</asp:Label>&nbsp;
                                                        <asp:TextBox ID="txtalan2" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox></td>
                                                </tr>
                                            </table><table cellpadding="0" style="width: 100%">
                                                <tr>
                                                    <td colspan="6" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                                        font-family: Arial; height: 20px; background-color: whitesmoke; text-decoration: none">
                                                        &nbsp;<strong><span style="text-decoration: underline">Daha Önceki Denemeler</span>
                                                            &nbsp;;</strong></td>
                                                </tr>
                                                <tr>
                                                    <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; height: 25px; background-color: #f8f8ff;" colspan="6">
                                                        &nbsp;OI :<asp:Label ID="lbloi" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                    <asp:TextBox ID="txtoi" runat="server" SkinID="txtsiklus" Width="70px" Visible="False"></asp:TextBox>
                                                                    &nbsp; &nbsp; &nbsp; &nbsp;<span style="font-size: 11px">IUI :<asp:Label ID="lbliui" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                    <asp:TextBox ID="txtiui" runat="server" SkinID="txtsiklus" Width="70px" Visible="False"></asp:TextBox>&nbsp;
                                                                    &nbsp;&nbsp; &nbsp;&nbsp; <span style="font-size: 11px">IVF-ICSI :<asp:Label ID="lblivf" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                    <asp:TextBox ID="txtivf" runat="server" SkinID="txtsiklus" Width="70px" Visible="False"></asp:TextBox></span></span></td>
                                                </tr>
                                            </table><table cellpadding="0" style="width: 100%">
                                                <tr>
                                                    <td colspan="6" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                        font-size: 11px; border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                                        font-family: Arial; height: 20px; background-color: whitesmoke; text-decoration: none">
                                                        &nbsp;<strong><span style="text-decoration: underline">Prognostik Faktörler</span> ;</strong></td>
                                                </tr>
                                            </table>
                                <table cellpadding="0" style="width: 100%">
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;PCOS :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lblpcos" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label><asp:CheckBox ID="txtpcos" runat="server" Visible="False" />&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;Antral Fol Sayısı (SAĞ) :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lblantralsag" runat="server" Font-Bold="False" Font-Names="Verdana"
                                                Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtantralsag" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;Antral Fol Sayısı (SOL) :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lblantralsol" runat="server" Font-Bold="False" Font-Names="Verdana"
                                                Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtantralsol" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;Over Hacmi (SAĞ) :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lbloversag" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtoversag" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;Over Hacmi (SOL) :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lbloversol" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtoversol" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;Yaş :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lblyas" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            &nbsp;VKİ :</td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            &nbsp;<asp:Label ID="lblvki" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>&nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; width: 133px; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-align: left; text-decoration: none">
                                            &nbsp;Bazal 
                                            Tarih :</td>
                                        <td bgcolor="#f8f8ff" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                            font-size: 11px; border-left: lightgrey 1px solid; width: 247px; color: black;
                                            border-bottom: lightgrey 1px solid; font-family: Arial; text-decoration: none">
                                            &nbsp;<asp:Label ID="lblbazal" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtbazal" runat="server" SkinID="txtsiklus" Width="107px" Visible="False" ValidationGroup="ynmtc"></asp:TextBox>
                                            </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; width: 133px; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-align: left; text-decoration: none; height: 26px;">
                                            &nbsp;FSH :</td>
                                        <td bgcolor="#f8f8ff" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                            font-size: 11px; border-left: lightgrey 1px solid; width: 247px; color: black;
                                            border-bottom: lightgrey 1px solid; font-family: Arial; text-decoration: none; height: 26px;">
                                            &nbsp;<asp:Label ID="lblfsh" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtfsh" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; width: 133px; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-align: left; text-decoration: none; height: 26px;">
                                            &nbsp;LH :</td>
                                        <td bgcolor="#f8f8ff" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                            font-size: 11px; border-left: lightgrey 1px solid; width: 247px; color: black;
                                            border-bottom: lightgrey 1px solid; font-family: Arial; text-decoration: none; height: 26px;">
                                            &nbsp;<asp:Label ID="lbllh" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtlh" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; width: 133px; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-align: left; text-decoration: none">
                                            &nbsp;E2 :
                                        </td>
                                        <td bgcolor="#f8f8ff" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                            font-size: 11px; border-left: lightgrey 1px solid; width: 247px; color: black;
                                            border-bottom: lightgrey 1px solid; font-family: Arial; text-decoration: none">
                                            &nbsp;<asp:Label ID="lble2" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txte2" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            <asp:Label ID="etkalan5" runat="server" Visible="False"></asp:Label></td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            <asp:Label ID="lblalan5" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:Label ID="b5" runat="server" Visible="False">&nbsp;</asp:Label>&nbsp;
                                            <asp:DropDownList ID="txtalan5" runat="server" Visible="False" SkinID="drop">
                                            </asp:DropDownList></td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 133px; text-align: left;">
                                            <asp:Label ID="etkalan6" runat="server" Visible="False"></asp:Label></td>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-decoration: none; width: 247px;" bgcolor="#f8f8ff">
                                            <asp:Label ID="lblalan6" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                Visible="False">-&nbsp;&nbsp;</asp:Label>
                                            <asp:Label ID="b6" runat="server" Visible="False">&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtalan6" runat="server" SkinID="txtsiklus" Visible="False" Width="90px"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; width: 133px; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-align: left; text-decoration: none">
                                            <asp:Label ID="etkalan7" runat="server" Visible="False"></asp:Label></td>
                                        <td bgcolor="#f8f8ff" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                            font-size: 11px; border-left: lightgrey 1px solid; width: 247px; color: black;
                                            border-bottom: lightgrey 1px solid; font-family: Arial; text-decoration: none">
                                            <asp:Label ID="lblalan7" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                Visible="False">-&nbsp;&nbsp;</asp:Label><asp:Label ID="b7" runat="server" Visible="False">&nbsp;</asp:Label><asp:TextBox ID="txtalan7" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="90px"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; font-size: 11px;
                                            border-left: lightgrey 1px solid; width: 133px; color: black; border-bottom: lightgrey 1px solid;
                                            font-family: Arial; text-align: left; text-decoration: none">
                                            <asp:Label ID="etkalan8" runat="server" Visible="False"></asp:Label></td>
                                        <td bgcolor="#f8f8ff" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                            font-size: 11px; border-left: lightgrey 1px solid; width: 247px; color: black;
                                            border-bottom: lightgrey 1px solid; font-family: Arial; text-decoration: none">
                                            <asp:Label ID="lblalan8" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                Visible="False">-&nbsp;&nbsp;</asp:Label><asp:Label ID="b8" runat="server" Visible="False">&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtalan8" runat="server"
                                                    SkinID="txtsiklus" Visible="False" Width="90px"></asp:TextBox></td>
                                    </tr>
                                </table>
                                        </td>
                                        <td style="font-size: 12pt; color: black; font-family: Arial" valign="top">
                 <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                <ContentTemplate>
                                        <table cellpadding="0" style="width: 100%">
                                            <tr>
                                                <td colspan="6" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                    font-size: 11px; border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                                    font-family: Arial; height: 20px; background-color: whitesmoke; text-decoration: none">
                                                    &nbsp;<strong><span style="text-decoration: underline">Siklus Sonucu</span> ;</strong></td>
                                            </tr>
                                            <tr>
                                                <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; height: 25px; background-color: #f8f8ff;" colspan="6">
                                            &nbsp;<span style="color: navy">Kullanılan FSH : </span>
                                                    <asp:Label ID="lblkullanilanfsh" runat="server" Font-Bold="False" Font-Names="Verdana"
                                                Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                            <asp:TextBox ID="txtkullanilanfsh" runat="server" SkinID="txtsiklus" Width="90px" Visible="False"></asp:TextBox></td>
                                            </tr>
                                            <tr style="font-family: Arial">
                                                <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; height: 25px; background-color: #f8f8ff;" colspan="6">
                                            &nbsp;<span style="color: #330099; background-color: #f8f8ff;">Hiperstimülasyon :</span><span
                                                style="color: #000080"> &nbsp;</span><asp:Label ID="lblhiperstimulasyon" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:DropDownList ID="txthiperstimulasyon" runat="server" Visible="False" SkinID="drop">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                        <asp:ListItem Value="+">Var</asp:ListItem>
                                                        <asp:ListItem Value="-">Yok</asp:ListItem>
                                                    </asp:DropDownList></td>
                                            </tr>
                                            <tr style="font-family: Arial">
                                                <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; height: 25px; background-color: #f8f8ff;" colspan="6">
                                                    <span style="color: #000080">&nbsp;</span><span style="color: #330099; background-color: #f8f8ff;">Ovulasyon : </span>
                                                    <asp:Label ID="lblovulasyon" runat="server" Font-Bold="False" Font-Names="Verdana"
                                                Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:DropDownList ID="txtovulasyon" runat="server" Visible="False" SkinID="drop">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                        <asp:ListItem Value="+">Var</asp:ListItem>
                                                        <asp:ListItem Value="-">Yok</asp:ListItem>
                                                        <asp:ListItem Value="0">Bilinmiyor</asp:ListItem>
                                                    </asp:DropDownList></td>
                                            </tr>
                                            <tr style="font-family: Arial">


                                     
                                      
                                                                         <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; height: 25px; background-color: #f8f8ff;" colspan="6">
                                                    &nbsp;<span style="color: #330099; background-color: #f8f8ff;">Gebelik : </span><span
                                                        style="color: #000080">&nbsp;</span><asp:Label ID="lblgebelik" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                             <asp:DropDownList ID="txtgebelik"  runat="server" Visible="False" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="txtgebelik_SelectedIndexChanged1">
                                                                                 <asp:ListItem Selected="True"></asp:ListItem>
                                                                                 <asp:ListItem Value="+">Var</asp:ListItem>
                                                                                 <asp:ListItem Value="-">Yok</asp:ListItem>
                                                                             </asp:DropDownList>
                                                                    
                                                    &nbsp; &nbsp;&nbsp; <span style="color: navy">
                                                    Biyokimyasal :</span> &nbsp;<asp:Label ID="lblbiyokimyasal" runat="server" Font-Bold="False" Font-Names="Verdana"
                                                                        Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                             &nbsp;
                                                                             <asp:DropDownList ID="txtbiyokimyasal" runat="server" Visible="False" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="txtbiyokimyasal_SelectedIndexChanged">
                                                                                 <asp:ListItem Selected="True"></asp:ListItem>
                                                                                 <asp:ListItem Value="+">Var</asp:ListItem>
                                                                                 <asp:ListItem Value="-">Yok</asp:ListItem>
                                                                             </asp:DropDownList>
                                                                             &nbsp; &nbsp;&nbsp; <span style="color: navy">
                                                    Abortus : </span>
                                                    
                                                    &nbsp;<asp:Label ID="lblabortus" runat="server" Font-Bold="False" Font-Names="Verdana"
                                                                        Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                             <asp:DropDownList ID="txtabortus" runat="server" Visible="False" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="txtabortus_SelectedIndexChanged">
                                                                                 <asp:ListItem Selected="True"></asp:ListItem>
                                                                                 <asp:ListItem Value="+">Var</asp:ListItem>
                                                                                 <asp:ListItem Value="-">Yok</asp:ListItem>
                                                                             </asp:DropDownList></td>
                                           
                                           </tr>
                                            <tr style="font-family: Arial">
                                                <td style="border: 1px solid lightgrey; font-size: 11px; color: black; font-family: Arial; text-decoration: none; background-color: #f8f8ff;" 
                                                    colspan="6" class="style1">
                                            &nbsp;<span style="color: navy">Çoğul Gebelik :</span>
                                                    <asp:Label ID="lblcogul" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:DropDownList ID="txtcogul" runat="server" Visible="False" SkinID="drop" 
                                                        AutoPostBack="True" onselectedindexchanged="txtcogul_SelectedIndexChanged">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                        <asp:ListItem Value="+">Var</asp:ListItem>
                                                        <asp:ListItem Value="-">Yok</asp:ListItem>
                                                    </asp:DropDownList>&nbsp; <span style="color: navy">Gebelik Sayısı :
                                                    <asp:Label ID="lblgebeliksayisi" runat="server" Font-Bold="False" 
                                                        Font-Names="Verdana" Font-Size="11px" style="color: #000000">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:TextBox ID="txtgebeliksayisi" runat="server" MaxLength="1" 
                                                        SkinID="txtsiklus" Visible="False" Width="46px"></asp:TextBox>
                                                    &nbsp; Kese Sayısı :
                                                    <asp:Label ID="lblkesesayisi" runat="server" Font-Bold="False" 
                                                        Font-Names="Verdana" Font-Size="11px" style="color: #000000">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:TextBox ID="txtkesesayisi" runat="server" MaxLength="1" SkinID="txtsiklus" 
                                                        Visible="False" Width="46px"></asp:TextBox>
                                                    &nbsp;&nbsp; Monokoryonik :
                                                    <asp:Label ID="lblmonokoryonik" runat="server" Font-Bold="False" 
                                                        Font-Names="Verdana" Font-Size="11px" style="color: #000000">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:TextBox ID="txtmonokoryonik" runat="server" MaxLength="1" 
                                                        SkinID="txtsiklus" Visible="False" Width="46px"></asp:TextBox>
                                                    &nbsp; FKH Görüldü mü? :
                                                    <asp:Label ID="lblFKH" runat="server" Font-Bold="False" Font-Names="Verdana" 
                                                        Font-Size="11px" style="color: #000000">-&nbsp;&nbsp;</asp:Label>
                                                    <asp:DropDownList ID="txtFKH" runat="server" AutoPostBack="True" 
                                                        onselectedindexchanged="txtcogul_SelectedIndexChanged" SkinID="drop" 
                                                        Visible="False">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                        <asp:ListItem Value="+">Evet</asp:ListItem>
                                                        <asp:ListItem Value="-">Hayır</asp:ListItem>
                                                    </asp:DropDownList>
                                                    &nbsp;</span></td>
                                            </tr>
                                            <tr style="font-family: Arial">
                                                <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; height: 25px; background-color: #f8f8ff;" colspan="6">
                                                                    &nbsp;<span style="color: navy">Doğum : </span>&nbsp;<asp:Label ID="lbldogum" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                    &nbsp;<asp:DropDownList ID="txtdogum" runat="server" Visible="False" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="txtdogum_SelectedIndexChanged">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                        <asp:ListItem Value="+">Var</asp:ListItem>
                                                        <asp:ListItem Value="-">Yok</asp:ListItem>
                                                    </asp:DropDownList>
                                                    &nbsp; &nbsp;&nbsp;
                                                    <span style="color: navy">
                                                    Ağırlık :</span>
                                                    <asp:Label ID="lblagirlik" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px">-&nbsp;&nbsp;</asp:Label>
                                                                    <asp:TextBox ID="txtagirlik" runat="server" SkinID="txtsiklus" Width="70px" Visible="False" Enabled="False"></asp:TextBox></td>
                                            </tr>
                                            <tr style="font-family: Arial">
                                                <td style="font-size: 11px; color: black; font-family: Arial; text-decoration: none; border-right: lightgrey 1px solid; border-top: lightgrey 1px solid; border-left: lightgrey 1px solid; border-bottom: lightgrey 1px solid; background-color: #f8f8ff;" colspan="6">
                                                    <br />
                                                    <asp:Label ID="etkalan9" runat="server" Visible="False" ForeColor="Navy"></asp:Label><asp:Label ID="lblalan9" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                Visible="False">-&nbsp;&nbsp;</asp:Label><asp:Label ID="b9" runat="server" Visible="False">&nbsp;</asp:Label>
                                                    <asp:TextBox ID="txtalan9" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox>&nbsp;&nbsp;
                                                    &nbsp;
                                                    <br />
                                                    &nbsp;<asp:Label ID="lblistatistik" runat="server" ForeColor="Navy"></asp:Label><asp:CheckBox ID="chbistatistik" runat="server" Font-Names="Arial" Font-Size="11px" Text="İstatistiklerde Gösterme" ForeColor="#000099" Visible="False" /><br />
                                                    <asp:Label ID="etkalan10" runat="server" Visible="False" ForeColor="Navy"></asp:Label><asp:Label ID="lblalan10" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px"
                                                Visible="False">-&nbsp;&nbsp;</asp:Label><asp:Label ID="b10" runat="server" Visible="False">&nbsp;</asp:Label>
                                                    <asp:TextBox ID="txtalan10" runat="server" SkinID="txtsiklus" Visible="False"></asp:TextBox><br />
                                                    <br />
                                                </td>
                                            </tr>
                                            <tr style="font-family: Arial">
                                                <td colspan="6" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                    font-size: 11px; border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                                    font-family: Arial; background-color: #f8f8ff; text-decoration: none" valign="top">
                                                    <br />
                                                                        <asp:Label ID="etkalan3" runat="server" Visible="False" ForeColor="Navy"></asp:Label><asp:Label ID="lblalan3"
                                                                        runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px" Visible="False">-&nbsp;&nbsp;</asp:Label><asp:TextBox
                                                                            ID="txtalan3" runat="server" SkinID="txtsiklus" Visible="False" Width="140px"></asp:TextBox>
                                                    <asp:ImageButton ID="ImageButton2" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/Calendar.gif"
                                                        OnClick="ImageButton2_Click" Visible="False" /><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtalan3"
                                                        Display="Dynamic" ErrorMessage="Format : 08.01.2009 12:30:00" Font-Bold="True"
                                                        Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d \d\d:\d\d:\d\d)"
                                                        ValidationGroup="ynmtc" Width="153px"></asp:RegularExpressionValidator>&nbsp;
                                                    <br />
                                                    <asp:Label
                                                                                ID="etkalan4" runat="server" Visible="False" ForeColor="Navy"></asp:Label><asp:Label ID="lblalan4"
                                                                                    runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="11px" Visible="False">-&nbsp;&nbsp;</asp:Label><asp:TextBox
                                                                                        ID="txtalan4" runat="server" SkinID="txtsiklus" Visible="False" Width="140px"></asp:TextBox>
                                                    <asp:ImageButton ID="ImageButton3" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/images/Calendar.gif"
                                                        OnClick="ImageButton3_Click" Visible="False" />
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtalan4"
                                                        Display="Dynamic" ErrorMessage="Format : 08.01.2009 12:30:00" Font-Bold="True"
                                                        Font-Names="Arial" Font-Size="11px" SetFocusOnError="True" ValidationExpression="(\d\d.\d\d.\d\d\d\d \d\d:\d\d:\d\d)"
                                                        ValidationGroup="ynmtc" Width="152px"></asp:RegularExpressionValidator><br />
                                                    <br />
                                                    <span style="color: navy">&nbsp;Opu Yapıldı Mı ?</span>
                                                    <asp:Label ID="lblopuyapildimi" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:RadioButtonList ID="rbopuyapildimi" runat="server" RepeatDirection="Horizontal"
                                                        RepeatLayout="Flow" AutoPostBack="True" OnSelectedIndexChanged="rbopuyapildimi_SelectedIndexChanged" Visible="False">
                                                        <asp:ListItem Value="+">Evet</asp:ListItem>
                                                        <asp:ListItem Value="-">Hayır</asp:ListItem>
                                                    </asp:RadioButtonList><br />
                                                    <br />
                                                    <asp:Panel ID="Panel1" runat="server" Width="100%" Visible="False">
                                                        &nbsp;<span style="color: navy">Oluşan Yumurta Sayısı : 
                                                            <asp:Label ID="lblOlusanYumurta" runat="server" Font-Names="Verdana" Font-Size="11px"
                                                                ForeColor="Black"></asp:Label>
                                                            <asp:TextBox ID="txtOlusanYumurta" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox>&nbsp;</span><br />
                                                        <br />
                                                        &nbsp;<span style="color: navy">GV : </span>
                                                        <asp:Label ID="lblgv" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox ID="txtgv"
                                                            runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox>
                                                        &nbsp; &nbsp; <span style="color: black"><span style="color: navy">M1 :</span> </span>
                                                        <asp:Label ID="lblolgun" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox ID="txtolgun" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox>
                                                        &nbsp; &nbsp; <span style="color: navy">M2 : </span>
                                                        <asp:Label ID="lblbilinmeyen" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox ID="txtbilinmeyen" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox>
                                                        &nbsp; &nbsp; &nbsp;<br />
                                                        <br />
                                                        &nbsp;<span style="color: navy">Dejenere <span style="color: navy">:</span></span>
                                                        <asp:Label ID="lblDejenere" runat="server" Font-Names="Verdana" Font-Size="11px"
                                                            ForeColor="Black"></asp:Label><asp:TextBox ID="txtDejenere" runat="server" SkinID="txtsiklus"
                                                                Visible="False" Width="42px"></asp:TextBox>
                                                        &nbsp; &nbsp;&nbsp; <span style="color: navy">Empty Zona <span style="color: navy">:</span></span>
                                                        <asp:Label ID="lblZona" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                            ID="txtZona" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox>
                                                        &nbsp; &nbsp; <span style="color: navy">PostM <span style="color: navy">:</span> </span>
                                                        <asp:Label ID="lblPostM" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                            ID="txtPostM" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox></asp:Panel>
                                                    <br />
                                                    <asp:Panel ID="Panel4" runat="server" Width="100%" Visible="False">
                                                            &nbsp;<span style="color: navy">Fertilize :</span>
                                                            <asp:Label ID="lbldollenen" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox
                                                                ID="txtdollenen" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox></asp:Panel>
                                                    <br />
                                                    <asp:Panel ID="Panel5" runat="server" Width="100%" Visible="False">
                                                                    &nbsp;<span style="color: navy">Transfer Edilecek Embriyo Oluştu Mu ?</span>
                                                                    <asp:Label ID="lblembriyooluştumu" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:RadioButtonList ID="rbembriyoolustumu" runat="server" RepeatDirection="Horizontal"
                                                        RepeatLayout="Flow" AutoPostBack="True" OnSelectedIndexChanged="rbembriyoolustumu_SelectedIndexChanged" Visible="False">
                                                                        <asp:ListItem Value="+">Evet</asp:ListItem>
                                                                        <asp:ListItem Value="-">Hayır</asp:ListItem>
                                                                    </asp:RadioButtonList></asp:Panel>
                                                    <br />
                                                    <asp:Panel ID="Panel6" runat="server" Width="100%" Visible="False">
                                                                        &nbsp;<span style="color: navy">Transfer Sayısı : </span>
                                                                        <asp:Label ID="lbltransferedilenembriyo" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox
                                                                            ID="txttransferedilenembriyo" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox></asp:Panel>
                                                    <br />
                                                    <asp:Panel ID="Panel7" runat="server" Width="100%" Visible="False">
                                                                                &nbsp;<span style="color: navy">Kaçıncı Gün Transferi : </span>
                                                                                <asp:Label ID="lblfrozen" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox
                                                                                    ID="txtfrozen" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox></asp:Panel>
                                                    <br />
                                                    <asp:Panel ID="Panel8" runat="server" Width="100%" Visible="False">
                                                        &nbsp;<span style="color: navy">Dondurulan Embriyo Sayısı : </span>
                                                        <asp:Label ID="lblkalan" runat="server" ForeColor="Black" Font-Names="Verdana" Font-Size="11px"></asp:Label><asp:TextBox
                                                            ID="txtkalan" runat="server" SkinID="txtsiklus" Visible="False" Width="42px"></asp:TextBox></asp:Panel>
                                                </td>
                                            </tr>
                                            <tr style="font-family: Arial">
                                                <td colspan="6" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                    font-size: 11px; border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                                    font-family: Arial; height: 20px; background-color: whitesmoke; text-decoration: none"
                                                    valign="middle">
                                                    <strong>&nbsp;<span style="text-decoration: underline">Kullanılan <span>Formlar</span></span>
                                                        ;  &nbsp;&nbsp; 
                                                        <asp:Label ID="Label3" runat="server" Font-Bold="False" ForeColor="#FF0000"></asp:Label><br />
                                                        <table style="width: 100%">
                                                            <tr>
                                                                <td>
                                                                    <asp:DataList ID="formListKullanilan" runat="server" RepeatColumns="3" RepeatLayout="Flow"
                                                                        Width="100%">
                                                                        <SeparatorStyle Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False"
                                                                            Font-Underline="False" />
                                                                        <ItemTemplate>
                                                                            <span style="font-size: 11px">+
                                                                                <asp:Label ID="kullanilanForm" runat="server" Font-Bold="False" ForeColor="Navy"></asp:Label></span>
                                                                        </ItemTemplate>
                                                                    </asp:DataList></td>
                                                            </tr>
                                                        </table>
                                                    </strong></td>
                                            </tr>
                                        </table>
                            <table cellpadding="0" style="width: 100%">
                                                <tr>
                                                    <td colspan="6" style="border-right: lightgrey 1px solid; border-top: lightgrey 1px solid;
                                                    font-size: 11px; border-left: lightgrey 1px solid; color: black; border-bottom: lightgrey 1px solid;
                                                    font-family: Arial; background-color: #f8f8ff; text-decoration: none" valign="top">
                                                        <br />
                                                        &nbsp;Form Listesi :
                                                        <asp:DropDownList ID="formlist" runat="server" SkinID="drop" AutoPostBack="True" OnSelectedIndexChanged="formlist_SelectedIndexChanged">
                                                        </asp:DropDownList>&nbsp;
                                                        <asp:ImageButton ID="save" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/ivfyonetici/hasta_modulu/images/save.png"
                                                            OnClick="save_Click" Visible="False" />
                                                        <asp:ImageButton ID="edit" runat="server"
                                                                ImageAlign="AbsMiddle" ImageUrl="~/uyeModulu/images/goruntu.jpg"
                                                                OnClick="edit_Click" Visible="False" Enabled="False" />
                                                        <asp:Label ID="Label2" runat="server"></asp:Label><br />
                                                        <br />
                                                        <asp:Panel ID="pnl" runat="server" Visible="False" Width="100%">
                                                            &nbsp;<asp:Label ID="e1" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket1" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger1" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;
                                                            <asp:Label ID="e2" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket2" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger2" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e3" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket3" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger3" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="e4" runat="server" Font-Bold="False"
                                                                Font-Names="Arial" Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket4" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger4" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp;&nbsp;<br />
                                                            <br />
                                                            &nbsp;<asp:Label ID="e5" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket5" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger5" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="e6" runat="server" Font-Bold="False"
                                                                Font-Names="Arial" Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket6" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger6" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e7" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket7" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger7" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Label ID="e8" runat="server" Font-Bold="False"
                                                                Font-Names="Arial" Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket8" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger8" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e9" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket9" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger9" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                                            <asp:Label ID="e10" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket10" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger10" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e11" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket11" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger11" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp;<asp:Label ID="e12" runat="server" Font-Bold="False" Font-Names="Arial"
                                                                Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket12" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger12" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e13" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket13" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger13" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp;<asp:Label ID="e14" runat="server" Font-Bold="False" Font-Names="Arial"
                                                                Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket14" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger14" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e15" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket15" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger15" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp;&nbsp;
                                                            <asp:Label ID="e16" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket16" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger16" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e17" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket17" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger17" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp;<asp:Label ID="e18" runat="server" Font-Bold="False" Font-Names="Arial"
                                                                Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket18" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger18" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                            &nbsp;<br />
                                                            &nbsp;<asp:Label ID="e19" runat="server" Font-Bold="False" Font-Names="Arial" Font-Size="11px"
                                                                ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket19" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger19" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox>
                                                            &nbsp; &nbsp; &nbsp;<asp:Label ID="e20" runat="server" Font-Bold="False" Font-Names="Arial"
                                                                Font-Size="11px" ForeColor="Navy"></asp:Label>
                                                            <asp:Label ID="etiket20" runat="server" Font-Names="Verdana" Font-Size="11px" ForeColor="Black"></asp:Label><asp:TextBox
                                                                ID="deger20" runat="server" SkinID="txtsiklus" Visible="False" Width="71px"></asp:TextBox><br />
                                                        </asp:Panel>
                                                        <br />
                                                    </td>
                                                </tr>
                                            </table>
                                            
                                            
                                            
                                            <br />
                                        </td>
                                    </tr>
                                </table>
                                
               </ContentTemplate>
                                            </asp:UpdatePanel>
                                </div>
                                
                            </td>
                        </tr>
                    </table>
                    
                   
                    
                    
                </asp:Panel>
            </td>
        </tr>
    </table>
<br />


