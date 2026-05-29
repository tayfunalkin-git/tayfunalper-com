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

public partial class ivfyonetici_hasta_modulu_hasta_kimlik_guncelleme_bilgi : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();
    protected void Page_Load(object sender, EventArgs e)
    {

      


        bilgi_yukle();
        bilgi_yukle2();
        bilgi_yukle3();
      }



    void bilgi_yukle3()
    {

        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from uye_hasta where uye_id=" + hasta_id.ToString() + "", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            Page.Title = "..:: " + mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString() + "  &  Kýsa Siklus Güncelleme Detaylarý ::..   ";
        }

        catch
        {

            sonuc.Text = "Bilgiler Yüklenirken Hata Oluþtu !";

        }

    }


    void bilgi_yukle()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus_guncellemeleri where siklus_id='" +Request.QueryString["siklus_id"].ToString() + "' order by date(tarih) desc", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            list.DataSource = mp_dt;
            list.DataBind();


            sonuc.Text = " Toplam Kýsa Siklus Güncelleme Sayýsý : " + mp_dt.Rows.Count;
        }


        catch
        {

            sonuc.Text = "Bilgiler Yüklenirken Hata Oluþtu !";
        
        }

    }


    void bilgi_yukle2()
    {

        try
        {
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);


            alan.Text = dt5.Rows[0]["siklus_ay"].ToString() + " - " + dt5.Rows[0]["siklus_yil"].ToString() + " | " + "Kýsa Siklus Güncellemeleri";


        }


        catch
        {

            sonuc.Text = "Bilgiler Yüklenirken Hata Oluþtu !";


        }

    }
   

    protected void list_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        list.PageIndex = e.NewPageIndex;
        list.DataBind();


    }
}
