using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ivfyonetici_talper_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "5856068")
        {
            Response.Redirect("3455.aspx?islem=ok");
        }
        else
        {
            Label1.Text = "İşleminize şu an devam edilemiyor.Lütfen daha sonra tekrar deneyiniz.";
        }
    }
}