using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class ivfyonetici_hasta_modulu_arasayfa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        HttpCookie mpKullanilan2 = Request.Cookies["AdminOturumSuresi"];
        string sure = mpKullanilan2["Adminsure"].ToString();

        HttpCookie islemdekihasta = new HttpCookie("HastaBilgi");
        islemdekihasta["HastaID"] = Request.QueryString["id"].ToString();
        islemdekihasta.Expires = DateTime.Now.AddMinutes(int.Parse(sure.ToString()));
        Response.Cookies.Add(islemdekihasta);

        if(Request.QueryString["siklus_id"]!=null)

            Response.Redirect("infertilite.aspx?ts=1&siklus_id="+Request.QueryString["siklus_id"].ToString());

        else
Response.Redirect("Default.aspx");


    }
}
