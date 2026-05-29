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

public partial class ivfyonetici_hasta_modulu_renk_guncelleme_bilgi : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();
    protected void Page_Load(object sender, EventArgs e)
    {

        bilgi_yukle();
        bilgi_yukle2();
        bilgi_yukle3();

    }

    void bilgi_yukle()
    {

        try
        {

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select infertilite_adi from infertilite_adlari where infertilite_id=" + Request.QueryString["kategori_id"] + "", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            alan.Text = mp_dt.Rows[0]["infertilite_adi"].ToString();

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

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from ana_renk_infertilite where hasta_id='" + hasta_id.ToString() + "' and kategori_id='" + Request.QueryString["kategori_id"] + "' order by Date_Format(Cast(guncelleme_tarihi as Date),'%d.%m.%y %h:%m:%s') desc", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            list.DataSource = mp_dt;
            list.DataBind();

            sonuc.Text = "Toplam Renk Bilgileri Güncelleme Sayýsý : " + mp_dt.Rows.Count;

         
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

            Page.Title = "..:: " + mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString() + "  &  Ýnfertilite Renk Bilgileri Güncelleme Detaylarý ::..";
        }

        catch
        {

            sonuc.Text = "Bilgiler Yüklenirken Hata Oluþtu !";

        }

    }




}
