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

public partial class ivfyonetici_0000068 : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();
   
    protected void Page_Load(object sender, EventArgs e)
    {
 // denetim();

        if (!IsPostBack)
        {
          
            yukle();
        }

        
    }

    private void denetim()
    {
      
          HttpCookie mpKullanilan = Request.Cookies["AdminK"];
          string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

        
            if(kullaniciAdiAdmin != "tayfun")
            {
                    Response.Redirect("signout.aspx");
                }

               
    }


   

  

    void yukle()
    {
        Label15.Text = "1";
        try
        {
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from calismaLog order by str_to_date(tarih,'%d.%m.%Y %H:%i:%s') desc", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

                loglist.DataSource = mp_dt;
                loglist.DataBind();

         
        }
        catch
        {


            panel_sonuc.Visible = true;
            sonuc.Text = "Log55 Yüklenirken Hata Oluþtu!";

        }

    }


  
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label15.Text = "0";
        yukle2();


      
    }

    private void yukle2()
    {


        try
        {
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from calismaLog where islem like '%" + arama.Text + "%' order by str_to_date(tarih,'%d.%m.%Y') desc", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);



            loglist.DataSource = mp_dt;
            loglist.DataBind();





            if (mp_dt.Rows.Count == 0)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Aranýlan kelimeyi içeren Kayýt Bulunamadý !";

            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Aranýlan kelimeye ait " + mp_dt.Rows.Count + " kayýt bulundu.";

            }



        }
        catch
        {


            panel_sonuc.Visible = true;
            sonuc.Text = "Log55 Yüklenirken Hata Oluþtu!";

        }



    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("log55.aspx");
    }
    protected void loglist_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        loglist.PageIndex = e.NewPageIndex;
        loglist.DataBind();

        if (Label15.Text == "0")
        {
            yukle2();
        }
        else
        { 
        yukle();
        }
            
        

    }
}
