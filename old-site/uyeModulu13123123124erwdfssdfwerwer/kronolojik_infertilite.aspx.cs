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

public partial class ivfyonetici_hasta_modulu_kro : System.Web.UI.Page
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

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite where hasta_id='" + hasta_id.ToString() + "' order by str_to_date(islem_tarihi,'%d.%m.%Y') asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);




            if (dt4.Rows.Count == 0)
            {

                say.Text = " (0)";


            }

            else
            {

                say.Text = " (" + dt4.Rows.Count.ToString() + ")";


            }


            inferbilgi.DataSource = dt4;
            inferbilgi.DataBind();


            int a = 0;

            Label tar = new Label();
            Label kat = new Label();
            Label sk = new Label();
            Label msj = new Label();
            Label eklyn = new Label();
            Label ektrh = new Label();
            Label alan = new Label();

            foreach (DataListItem str in inferbilgi.Items)
            {

                tar = (Label)str.FindControl("lbltarih");
                tar.Text = dt4.Rows[a]["islem_tarihi"].ToString();

                alan = (Label)str.FindControl("lblalan");
                alan.Text = kategori_bul(dt4.Rows[a]["alan_id"].ToString());

                kat = (Label)str.FindControl("lblkategori");
                kat.Text = alanbul(dt4.Rows[a]["kategori_id"].ToString());
                
                sk = (Label)str.FindControl("lblsiklus");
                sk.Text = siklus_bul(dt4.Rows[a]["siklus_id"].ToString());

              
                msj = (Label)str.FindControl("lblmesaj");
                msj.Text = "<font color=" + renkbul(dt4.Rows[a]["renk_id"].ToString()) + ">" + dt4.Rows[a]["aciklama"].ToString() + "</font>";

             

                eklyn = (Label)str.FindControl("ekleyen");
                eklyn.Text = dt4.Rows[a]["ilk_ekleyen"].ToString();

                ektrh = (Label)str.FindControl("ektarih");
                ektrh.Text = dt4.Rows[a]["kayit_tarihi"].ToString();


                a++;

            }


        }

        catch
        {

        }

    }




    string kategori_bul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select infertilite_adi from infertilite_adlari where infertilite_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["infertilite_adi"].ToString();
        }
        catch
        {

            return "";

        }

    }


    string alanbul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select kategori_adi from infertilite_kategori where kategori_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["kategori_adi"].ToString();
        }
        catch
        {

            return "";

        }

    }



    string renkbul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select renk_kodu from infertilite_renkler where renk_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {

                return "#000000";

            }
            else
            {
                return dt4.Rows[0]["renk_kodu"].ToString();
            }
        }
        catch
        {

            return "#000000";

        }

    }







    string siklus_bul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select concat(siklus_ay,' - ',siklus_yil) as siklusum from siklus_ana_tab where siklus_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["siklusum"].ToString();
        }
        catch
        {

            return "";

        }

    }




    string kontrol(string ID)
    { 
    
        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + ID.ToString() + "", connect_word);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows.Count == 0)
        {

            return "0";

        }
        else
        {
            return "1";

        }

    }

}
