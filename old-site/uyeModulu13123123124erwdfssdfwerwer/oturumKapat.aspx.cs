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
using System.IO;
public partial class ivfyonetici_signout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        HttpCookie mpKullanilan = Request.Cookies["HastaBilgi"];

          if (mpKullanilan == null)
          {
              Response.Redirect("cikis.aspx");
          }

          cikis();


    }
     
 
    void cikis()
    {


        try
        {
            FormsAuthentication.SignOut();
            HttpCookie mpKullanilan = Request.Cookies["HastaBilgi"];
          
            mpKullanilan.Expires = DateTime.Now.AddDays(-50);
            Response.Cookies.Add(mpKullanilan);
            Response.Redirect("cikis.aspx");
        }
        catch
        { }
        finally
        {
            Response.Redirect("cikis.aspx");
        }
        

    
    }

}
