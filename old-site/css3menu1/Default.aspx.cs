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
using MySql.Data.MySqlClient;

public partial class bolum : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            HtmlMeta a = new HtmlMeta();
            a = (HtmlMeta)Master.FindControl("ttl");
            a.Content = "Tayfun ALPER Ondokuz Mayýs Üniversitesi Týp Fakültesi Kadýn Hastalýklarý ve Doðum Anabilim Dalý Baþkaný";


            HtmlMeta b = new HtmlMeta();
            b = (HtmlMeta)Master.FindControl("kw");
            b.Content = "Tayfun ALPER,Forum,Samsun,Omü,Ondokuz Mayýs Üniversitesi,Kadýn Hastalýklarý ve Doðum,Tayfun,ALPER,Prof.Dr.Tayfun ALPER,Prof.Dr. Tayfun ALPER,Rektör Adayý";


            //string IPAdres = HttpContext.Current.Request.UserHostAddress;
            //ebebaba_class.istatistiksayfa(IPAdres, "Anasayfa","Sayfa");

            te.InnerHtml = "<div class='fb-like' data-href='http://www.tayfunalper.com' data-send='false' data-width='150' data-show-faces='true' data-action='recommend' data-font='Tahoma'></div>";


        }

    }

}

