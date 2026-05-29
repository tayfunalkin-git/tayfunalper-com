<%@ Page Language="C#" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master" AutoEventWireup="true" CodeFile="infertilite2.aspx.cs" Inherits="ivfyonetici_hasta_modulu_infertilite2"  Theme="SkinFile" ValidateRequest="false" EnableEventValidation ="false"%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <script language="Javascript">
   
   <!-- // load htmlarea
_editor_url = "";                     // URL to htmlarea files
var win_ie_ver = parseFloat(navigator.appVersion.split("MSIE")[1]);
if (navigator.userAgent.indexOf('Mac')        >= 0) { win_ie_ver = 0; }
if (navigator.userAgent.indexOf('Windows CE') >= 0) { win_ie_ver = 0; }
if (navigator.userAgent.indexOf('Opera')      >= 0) { win_ie_ver = 0; }
if (win_ie_ver >= 5.5) {
  document.write('<scr' + 'ipt src="' +_editor_url+ 'editor.js"');
  document.write(' language="Javascript"></scr' + 'ipt>');  
} else { document.write('<scr'+'ipt>function editor_generate() { return false; }</scr'+'ipt>'); }
// --></script>


<script language="JavaScript">
<!--
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);
//-->
</script>


<script language="JavaScript"> 

function git5(id)          {open ("../yardim_goruntule.aspx?id="+id,"","height=500,width=500,location=no,scrollbars=yes")                 } 

</script>

<%--<script language="javascript">

var menuwidth='250px' //default menu width
var menubgcolor='#FFFFFF'  //menu bgcolor
var disappeardelay=200  //menu disappear speed onMouseout (in miliseconds)
var hidemenu_onclick="yes" //hide menu when user clicks within menu?

/////No further editting needed

var ie4=document.all
var ns6=document.getElementById&&!document.all

if (ie4||ns6)
document.write('<div id="dropmenudiv" style="visibility:hidden;width:'+menuwidth+';background-color:'+menubgcolor+'" onMouseover="clearhidemenu()" onMouseout="dynamichide(event)"></div>')

function getposOffset(what, offsettype){
var totaloffset=(offsettype=="left")? what.offsetLeft : what.offsetTop;
var parentEl=what.offsetParent;
while (parentEl!=null){
totaloffset=(offsettype=="left")? totaloffset+parentEl.offsetLeft : totaloffset+parentEl.offsetTop;
parentEl=parentEl.offsetParent;
}
return totaloffset;
}


function showhide(obj, e, visible, hidden, menuwidth){
if (ie4||ns6)
dropmenuobj.style.left=dropmenuobj.style.top="-400px"
if (menuwidth!=""){
dropmenuobj.widthobj=dropmenuobj.style
dropmenuobj.widthobj.width=menuwidth
}
if (e.type=="click" && obj.visibility==hidden || e.type=="mouseover")
obj.visibility=visible
else if (e.type=="click")
obj.visibility=hidden
}

function iecompattest(){
return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}

function clearbrowseredge(obj, whichedge){
var edgeoffset=0
if (whichedge=="rightedge"){
var windowedge=ie4 && !window.opera? iecompattest().scrollLeft+iecompattest().clientWidth-15 : window.pageXOffset+window.innerWidth-15
dropmenuobj.contentmeasure=dropmenuobj.offsetWidth
if (windowedge-dropmenuobj.x < dropmenuobj.contentmeasure)
edgeoffset=dropmenuobj.contentmeasure-obj.offsetWidth
}
else{
var topedge=ie4 && !window.opera? iecompattest().scrollTop : window.pageYOffset
var windowedge=ie4 && !window.opera? iecompattest().scrollTop+iecompattest().clientHeight-15 : window.pageYOffset+window.innerHeight-18
dropmenuobj.contentmeasure=dropmenuobj.offsetHeight
if (windowedge-dropmenuobj.y < dropmenuobj.contentmeasure){ //move up?
edgeoffset=dropmenuobj.contentmeasure+obj.offsetHeight
if ((dropmenuobj.y-topedge)<dropmenuobj.contentmeasure) //up no good either?
edgeoffset=dropmenuobj.y+obj.offsetHeight-topedge
}
}
return edgeoffset
}

function populatemenu(what){
if (ie4||ns6)
dropmenuobj.innerHTML=what.join("")
}


function dropdownmenu(obj, e, menucontents, menuwidth){
if (window.event) event.cancelBubble=true
else if (e.stopPropagation) e.stopPropagation()
clearhidemenu()
dropmenuobj=document.getElementById? document.getElementById("dropmenudiv") : dropmenudiv
populatemenu(menucontents)

if (ie4||ns6){
showhide(dropmenuobj.style, e, "visible", "hidden", menuwidth)
dropmenuobj.x=getposOffset(obj, "left")
dropmenuobj.y=getposOffset(obj, "top")
dropmenuobj.style.left=dropmenuobj.x-clearbrowseredge(obj, "rightedge")+"px"
dropmenuobj.style.top=dropmenuobj.y-clearbrowseredge(obj, "bottomedge")+obj.offsetHeight+"px"
}

return clickreturnvalue()
}

function clickreturnvalue(){
if (ie4||ns6) return false
else return true
}

function contains_ns6(a, b) {
while (b.parentNode)
if ((b = b.parentNode) == a)
return true;
return false;
}

function dynamichide(e){
if (ie4&&!dropmenuobj.contains(e.toElement))
delayhidemenu()
else if (ns6&&e.currentTarget!= e.relatedTarget&& !contains_ns6(e.currentTarget, e.relatedTarget))
delayhidemenu()
}

function hidemenu(e){
if (typeof dropmenuobj!="undefined"){
if (ie4||ns6)
dropmenuobj.style.visibility="hidden"
}
}

function delayhidemenu(){
if (ie4||ns6)
delayhide=setTimeout("hidemenu()",disappeardelay)
}

function clearhidemenu(){
if (typeof delayhide!="undefined")
clearTimeout(delayhide)
}

if (hidemenu_onclick=="yes")
document.onclick=hidemenu

</script>--%>
    <table align="center" style="width: 100%;" cellpadding="0" cellspacing="0">
        <tr>
            <td style="text-align: left;">
                &nbsp;<br />
                </td>
        </tr>
    </table>
    <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 95%; border-right: black 1px solid; border-top: black 1px solid; border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td style="border-top-width: 1px; border-left-width: 1px; border-left-color: #d3d3d3;
                border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-top-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3" valign="bottom">
                <table border="0" cellpadding="0" cellspacing="0" width="100%">
                    <tr>
                        <td style="border-bottom-width: 1px; border-bottom-color: #d3d3d3; height: 21px; border-top-width: 1px; border-top-color: #d3d3d3; border-right-style: none; border-left-style: none;" valign="middle">
                <asp:Panel ID="infertilite_ana_panel" runat="server" Width="100%" Direction="LeftToRight">
                    <table border="0" cellpadding="1" cellspacing="1" style="width: 100%">
                        <tr>
                            <td style="height: 21px;">
                                &nbsp;<asp:Label ID="infertilite_alan" runat="server" Font-Bold="True" Font-Names="Arial"
                                    Font-Size="12px"></asp:Label>&nbsp;<asp:Label ID="say" runat="server" Font-Bold="True"
                                        Font-Names="Arial" Font-Size="12px"></asp:Label></td>
                            <td style="text-align: right; height: 21px;" valign="middle">
                                <div style="text-align: right">
                                                <asp:DropDownList ID="infertilite_renk" runat="server" BackColor="Transparent" Font-Bold="False"
                                    Font-Names="verdana" Font-Size="11px" AutoPostBack="True" 
                                                    OnSelectedIndexChanged="infertilite_renk_SelectedIndexChanged" 
                                                    ValidationGroup="yn" SkinID="drop" Visible="False">
                                </asp:DropDownList>
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnekle.gif"
                                    OnClick="ImageButton1_Click" Visible="False" />
                                
                                <img align="absMiddle" src="images/guncelleyenler.gif" onclick="window.open('ana_renk_guncelleme_bilgi.aspx?kategori_id=<%=Request.QueryString["kategori_id"]%>','','width=500,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')" style="cursor:hand;" />&nbsp;
                                </div>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                        </td>
                    </tr>
                </table>
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
                border-top-color: #d3d3d3; height: 77px; border-left-width: 1px; border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3;" valign="top" id="yeni_kayit">
                <asp:DataList ID="inferbilgi" runat="server" CellPadding="2" CellSpacing="2" RepeatColumns="1"
                    Width="100%" BorderWidth="0px">
                    <ItemTemplate>
                        <table style="border-right: gainsboro 1px solid; border-top: gainsboro 1px solid; border-left: gainsboro 1px solid; border-bottom: gainsboro 1px solid;" border="0" cellpadding="3" cellspacing="0" width="100%">
                            <tr>
                                <td style="border-right: lightgrey 1px solid;" valign="top" bordercolordark="#ffffff" width="110">
                                    <asp:Label ID="lbltarih" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <br />
                                    <asp:Label ID="lblkategori" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label><br />
                                    <br />
                                    <asp:Label ID="lblsiklus" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="11px"></asp:Label></td>
                                <td valign="top">
                                    <asp:Label ID="lblmesaj" runat="server" Font-Names="Arial" Font-Size="12px"></asp:Label>&nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td bordercolordark="#ffffff" style="border-right: lightgrey 1px solid" valign="top"
                                    width="110">
                                    &nbsp;</td>
                                <td bgcolor="ghostwhite" style="border-top: gainsboro 1px solid; text-align: right"
                                    valign="top">
                                    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
                                        <tr>
                                            <td style="text-align: left">
                                                <span style="font-size: 11px; font-family: Arial">Kayýt Tarihi : </span>
                                                <asp:Label ID="ektarih" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                <span style="font-size: 11px; font-family: Arial">&nbsp;<span style="color: black">
                                                    |</span> &nbsp; &nbsp; Kaydeden :&nbsp; </span>
                                                <asp:Label ID="ekleyen" runat="server" Font-Names="Arial" Font-Size="11px" ForeColor="DimGray"></asp:Label>
                                                <span style="font-size: 11px; cursor :hand ; font-family: Arial">&nbsp; | &nbsp; &nbsp; <a onclick="window.open('infertilite_guncelleme_bilgi.aspx?ID=<%#DataBinder.Eval(Container.DataItem , "kayit_id")%>','','width=500,height=500,menubar=yes,location=yes,resizable=no,scrollbars=yes,status=yes,toolbar=yes')">
                                                    Güncelleyenler</a></span></td>
                                            <td style="text-align: right">
                                                <asp:ImageButton ID="guncelle" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnguncelle.gif"
                                                    OnCommand="guncelle_Command" Visible="False" />
                                                <asp:ImageButton ID="sil" runat="server" ImageAlign="AbsMiddle" ImageUrl="~/imgs/btnsil.gif"
                                                    OnClientClick="return confirm('Ýnfertilite Kaydý Kalýcý Olarak Silinecektir.Onaylýyormusunuz?')"
                                                    OnCommand="sil_Command" Visible="False" />&nbsp;</td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <ItemStyle Wrap="True" />
                    <SeparatorStyle BackColor="Olive" />
                </asp:DataList>
            </td>
        </tr>
    </table>
    <br />

    
</asp:Content>


































