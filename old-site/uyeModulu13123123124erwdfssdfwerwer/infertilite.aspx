<%@ Page Language="C#" MasterPageFile="~/uyeModulu/mp_Hasta_Master_New.master"  AutoEventWireup="true" Debug="true" CodeFile="infertilite.aspx.cs" Inherits="ivfyonetici_hasta_modulu_infertilite"  Theme="SkinFile"  EnableEventValidation="false"%>


<%@ Register Src="in_ts.ascx" TagName="in_ts" TagPrefix="uc2" %>
<%@ Register Src="in_ks.ascx" TagName="in_ks" TagPrefix="uc3" %>
<%@ Register Src="in_infertilite.ascx" TagName="in_infertilite" TagPrefix="uc1" %>
 <%@ Register Src="in_form.ascx" TagName="in_form" TagPrefix="uc4" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<script language="javascript">

function ac2()
{
document.getElementById('ctl00_ContentPlaceHolder1_In_ks1_gizlenecek2').style.display = 'block';
document.getElementById('ctl00_ContentPlaceHolder1_In_ks1_ac2').style.display = 'none';
document.getElementById('ctl00_ContentPlaceHolder1_In_ks1_kapa2').style.display = 'block';
}

function kapa2()
{
    document.getElementById('ctl00_ContentPlaceHolder1_In_ks1_gizlenecek2').style.display = 'none';
    document.getElementById('ctl00_ContentPlaceHolder1_In_ks1_ac2').style.display = 'block';
    document.getElementById('ctl00_ContentPlaceHolder1_In_ks1_kapa2').style.display = 'none';
}

function ac()
{
    document.getElementById('ctl00_ContentPlaceHolder1_In_ts1_gizlenecek').style.display = 'block';
    document.getElementById('ctl00_ContentPlaceHolder1_In_ts1_ac1').style.display = 'none';
    document.getElementById('ctl00_ContentPlaceHolder1_In_ts1_kapa1').style.display = 'block';
}

function kapa()
{
    document.getElementById('ctl00_ContentPlaceHolder1_In_ts1_gizlenecek').style.display = 'none';
    document.getElementById('ctl00_ContentPlaceHolder1_In_ts1_ac1').style.display = 'block';
    document.getElementById('ctl00_ContentPlaceHolder1_In_ts1_kapa1').style.display = 'none';
}

function ac3() {
    document.getElementById('ctl00_ContentPlaceHolder1_In_form1_gizlenecek3').style.display = 'block';
    document.getElementById('ctl00_ContentPlaceHolder1_In_form1_ac3').style.display = 'none';
    document.getElementById('ctl00_ContentPlaceHolder1_In_form1_kapa3').style.display = 'block';
}

function kapa3() {
    document.getElementById('ctl00_ContentPlaceHolder1_In_form1_gizlenecek3').style.display = 'none';
    document.getElementById('ctl00_ContentPlaceHolder1_In_form1_ac3').style.display = 'block';
    document.getElementById('ctl00_ContentPlaceHolder1_In_form1_kapa3').style.display = 'none';
}
</script>


    <uc1:in_infertilite id="In_infertilite1" runat="server">
    </uc1:in_infertilite>
   
    <br />
 <%if (Request.QueryString["ts"] != null && Request.QueryString["siklus_id"] != null)
   { %>   
    <uc2:in_ts id="In_ts1" runat="server">
    </uc2:in_ts>
 
    <uc3:in_ks id="In_ks1" runat="server">
    </uc3:in_ks>

     <uc4:in_form id="In_form1" runat="server">
    </uc4:in_form>


        <%} %>
          
</asp:Content>



