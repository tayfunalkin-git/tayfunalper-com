<!--#include file="ayarlar.asp" -->
<html>
<style type="text/css">
<!--
.style1 {font-size: 14px}
-->
</style>
<head>

<script language="javascript">
<!--//
function Controlla(){
if (document.form_upload.blob.value==""){
alert("<% = strLangAddCodeUploadIMG %>");
return false;
}
return true;
}
//-->
</script>
<LINK href="include/styles.css" rel=stylesheet>
</head>
<body>
<table width="95%" border="0" cellspacing="0" cellpadding="1" align="center">
  <tr> 
    <td align="center" height="17"><font class="green style1"><b>Resim Yükleme</b></font></td>
  </tr>
  <tr>
    <td align="center" height="39"><a href="JavaScript:onClick=window.close()">Pencereyi Kapat</a></td>
  </tr>
</table>
<form method="POST" enctype="multipart/form-data" action="Resim_Ekle.Asp" name="form_upload" language="javascript" onSubmit="return Controlla();">
  <table width="95%" border="0" cellspacing="0" cellpadding="0" class="tablemenu" align="center">
    <tr> 
      <td>&nbsp;</td>
    </tr>
    <tr> 
      <td align="center"> <input type="file" name="blob" size="25" class="form"> 
      </td>
    </tr>
    <tr> 
      <td align="center">&nbsp;</td>
    </tr>
    <tr> 
      <td align="center">(Yüklenebilir Dosyalar: <% = kinkoffile %> - Max 10000 KB) </td>
    </tr>
    <tr> 
      <td align="center">&nbsp;</td>
    </tr>
    <tr> 
      <td align="center"><input type="hidden" name="strMode" value="<% =Request.QueryString("strMode")%>"></td>
    </tr>
    <tr> 
      <td align="center">&nbsp;</td>
    </tr>
    <tr> 
      <td align="center"><input type="submit" name="enter" value=" Devam " class="form"></td>
    </tr>
    <tr> 
      <td>&nbsp;</td>
    </tr>
    <tr> 
      <td>&nbsp;</td>
    </tr>
  </table>
</form>
<table width="95%" border="0" cellspacing="0" cellpadding="1" align="center">
  <tr>
    <td align="center" height="39"><a href="JavaScript:onClick=window.close()"><% = strLangSelectCloseWindow %></a></td>
  </tr>
</table>
</body>
</html>
