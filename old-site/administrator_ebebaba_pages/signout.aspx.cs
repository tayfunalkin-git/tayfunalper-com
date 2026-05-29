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
public partial class administrator_ebebaba_pages_signout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


          HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];

          if (EbebabaKullanilan == null)
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
            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
            EbebabaKullanilan.Expires = DateTime.Now.AddMinutes(-121);
            Response.Cookies.Add(EbebabaKullanilan);
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
