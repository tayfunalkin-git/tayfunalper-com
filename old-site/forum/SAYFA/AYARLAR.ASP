<%
maxsizefile=500000
kinkoffile = "htm,asp,php,html"  'Resim Yukleme Dosya Türleri
StrPathShort = "../../../dosyalar"

Set Trncbag = Server.CreateObject("ADODB.Connection")
Trncbag.Open "DRIVER={Microsoft Access Driver (*.mdb)}; DBQ=" & Server.MapPath("../../../sistem/fizik.mdb")
%>
<link href="styles.css" rel="stylesheet" type="text/css">
<title>Ayarlar</title>
