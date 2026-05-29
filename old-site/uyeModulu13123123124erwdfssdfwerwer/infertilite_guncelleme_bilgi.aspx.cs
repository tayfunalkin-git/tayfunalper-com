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

public partial class ivfyonetici_hasta_modulu_infertilite_guncelleme_bilgi : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();
    protected void Page_Load(object sender, EventArgs e)
    {

      


        bilgi_yukle();

    }

    void bilgi_yukle()
    {

        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from infertilite_guncelleme G,infertilite I where I.kayit_id=CAST(G.infertilite_id as UNSIGNED) and I.hasta_id='" + hasta_id.ToString() + "' and G.infertilite_id='" + Request.QueryString["ID"] + "' order by date(G.tarih) desc", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);



   list.DataSource = mp_dt;
            list.DataBind();


            if (mp_dt.Rows.Count == 0)
            {

                sonuc.Text = "Kayýtlý Güncelleme Sayýsý : 0";



            }
            else
            {
                sonuc.Text = "Kayýtlý Güncelleme Sayýsý : " + mp_dt.Rows.Count.ToString();

            
            }


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
