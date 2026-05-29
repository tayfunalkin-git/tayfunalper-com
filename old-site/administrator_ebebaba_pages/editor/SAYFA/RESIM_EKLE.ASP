<!--#include file="ayarlar.asp" -->
<!--#include file="include/Resim_Boyutu.asp" -->
<!--#include file="include/Resim_Yukle.asp" -->
<%
Dim Uploader, File, nome_file, strMode, msg
Set Uploader = New FileUploader
Uploader.maxFileSize = maxsizefile

Uploader.fileExt = kinkoffile

Uploader.Upload()

strMode = Uploader.Form("strMode")
msg = ""
strPath2 = Server.MapPath(strPathShort) & "\"

If Uploader.Files.Count = 0 Then
   If Uploader.Error Then
    msg = "<b>Hata :</b><br><br>" & Uploader.ErrorDesc
   End if 
msg = msg & "<br><div align=""center""><b>Dosya Yuklenemedi </b></div><br><br><br><br>"
Else
   If Uploader.Error Then
   msg = "<b>Hata :</b><br><br>" & Uploader.ErrorDesc & "<br><br><br><br><br>"
   End if
   For Each File In Uploader.Files.Items
     File.SaveToDisk strPath2
	 nome_file = File.FileName
       If Not IsImage(StrPathShort & File.FileName) Then
         msg = "<b> Hata:</b><br><br><b>" & File.FileName & "</b> Dosya Yuklenemedi <br><br><br><br><br>"
	     Set fso = CreateObject("Scripting.FileSystemObject")
            If fso.FileExists(strPath2 & File.FileName) Then fso.DeleteFile(strPath2 & File.FileName)
         Set fso = Nothing
       End if
   Next
End If
%>


</head>
<body>
<table width="95%" border="0" cellspacing="0" cellpadding="0" class="tablemenu" align="center">
        <tr> 
          <td width="100%">&nbsp;</td>
        </tr>
        <tr>
          <td width="100%"><div align="center"><font color="#0000FF">Resim <strong>root_/resimler/</strong> 
        klasörünüze yüklenmistir.</font></div></td>
        </tr>
        <tr>
          <td width="100%">&nbsp;</td>
        </tr>	
</table>
<table width="95%" border="0" cellspacing="0" cellpadding="1" align="center">
  <tr>
    <td align="center" height="39"><a href="JavaScript:onClick=window.close()">Kapat</a><font class="green"> | </font><a href="javascript:history.go(-1)">
    Geri</a></td>
  </tr>
</table>
</body>
</html>

