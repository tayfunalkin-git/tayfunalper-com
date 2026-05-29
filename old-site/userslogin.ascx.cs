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

public partial class userslogin : System.Web.UI.UserControl
{
    forum_class fc = new forum_class();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //HttpCookie EbebabaForum = Request.Cookies["EbebabaForumUye"];
        //if (EbebabaForum != null)
        //{

        //    Response.Redirect("Default.aspx");
        //}
      
   }



    //private void cookiecontrol()
    //{
    //    HttpCookie EbebabaForum = Request.Cookies["EbebabaForumUye"];
    //    if (EbebabaForum == null)
    //    {
    //        Panel1.Visible = true;
    //        //Panel2.Visible = false;
    //    }
    //    else
    //    {

    //        Panel1.Visible = false;
    //        //Panel2.Visible = true;


    //        if (EbebabaForum["beniHatirla"].ToString() == "1")
    //        {
    //            EbebabaForum.Expires = DateTime.Now.AddDays(30);
    //        }

    //        else
    //        {
    //            EbebabaForum.Expires = DateTime.Now.AddMinutes(20);
    //        }






    //    }

    //}


}
