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

public partial class ivfyonetici_hasta_modulu_infertilite : System.Web.UI.Page
{
   ivf_class mp_class = new ivf_class();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["siklus_id"] == null)
        {
            Response.Redirect("default.aspx");
        }
 
  }


  
    protected void LinkButton4_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("infertilite.aspx?snc=1&siklus_id=" + Request.QueryString["siklus_id"].ToString());

    }
   
}

