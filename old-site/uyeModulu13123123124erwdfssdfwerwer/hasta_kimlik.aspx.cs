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

public partial class ivfyonetici_hasta_modulu_hasta_kimlik : System.Web.UI.Page
{
    ivf_class mp_class = new ivf_class();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            yukle();

        }
    }

    void yukle()
    {

        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from uye_hasta where uye_id="+hasta_id.ToString ()+"", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            if (mp_dt.Rows.Count == 1)
            {



                hasta_adi.Text = mp_dt.Rows[0]["uye_adi"].ToString();
                hasta_soyadi.Text = mp_dt.Rows[0]["uye_soyadi"].ToString();
                hasta_dt.Text = mp_dt.Rows[0]["uye_dogum_tarihi"].ToString().Substring(0, 10);
                hasta_es_adi.Text = mp_dt.Rows[0]["esinin_adi"].ToString();
                hasta_es_yas.Text = mp_dt.Rows[0]["esinin_yasi"].ToString();
                evtel.Text = mp_dt.Rows[0]["uye_ev_tel"].ToString();
                ceptel.Text = mp_dt.Rows[0]["uye_cep_tel"].ToString();
                istel.Text = mp_dt.Rows[0]["uye_is_tel"].ToString();
                cepteles.Text = mp_dt.Rows[0]["uye_cep_tel_esi"].ToString();
                email.Text = mp_dt.Rows[0]["uye_email"].ToString();
                kullanici_adi.Text = mp_dt.Rows[0]["uye_k_adi"].ToString();
                sifre.Text = mp_dt.Rows[0]["uye_sifre"].ToString();
                sg.Text = mp_dt.Rows[0]["sg"].ToString();
                sp.Text = mp_dt.Rows[0]["sp"].ToString();
                sa.Text = mp_dt.Rows[0]["sa"].ToString();
                sc.Text = mp_dt.Rows[0]["sc"].ToString();
                se.Text = mp_dt.Rows[0]["se"].ToString();
                kilo.Text = mp_dt.Rows[0]["kilo"].ToString();
                boy.Text = mp_dt.Rows[0]["boy"].ToString();
            }

            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Hasta Kaydý Yüklenemedi.Bu Hastanýn Sistemde Olduðundan Eminseniz Lütfen Hasta Sayfasýný Yeniden Açýnýz !";
                sonuc.ForeColor = System.Drawing .Color .Red ;

            }



        }
        catch
        {


            panel_sonuc.Visible = true;
            sonuc.Text = "Hasta Bilgileri Yüklenirken Hata Oluþtu!";
             sonuc.ForeColor = System.Drawing .Color .Red ;
        }




    }



 
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }


    void kimlik_guncelle()
    {


        try
        {

            if (sifre.Text.TrimEnd().TrimStart().Length >= 6)
            {

                HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
                String hasta_id = islemdekihasta["HastaID"];

                MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
                MySqlCommand mp_cmd = new MySqlCommand("Update uye_hasta set uye_adi=?1,uye_soyadi=?2,uye_dogum_tarihi=?3,esinin_adi=?4,esinin_yasi=?5,uye_ev_tel=?6,uye_is_tel=?7,uye_cep_tel=?8,uye_cep_tel_esi=?9,uye_email=?10,boy=?11,kilo=?12,sg=?13,sp=?14,sa=?15,sc=?16,se=?17,uye_sifre=?20 where uye_id=" + hasta_id.ToString() + "", mp_connection);


                mp_cmd.Parameters.AddWithValue("?1", hasta_adi.Text.Replace(hasta_adi.Text.TrimStart().Substring(0, 1), hasta_adi.Text.TrimStart().ToUpper().Substring(0, 1)));
                mp_cmd.Parameters.AddWithValue("?2", hasta_soyadi.Text.ToUpper().TrimEnd().TrimStart().ToString());
                mp_cmd.Parameters.AddWithValue("?3", mp_class.tarihcevir(hasta_dt.Text.Trim()).ToShortDateString().ToString());
                mp_cmd.Parameters.AddWithValue("?4", hasta_es_adi.Text.ToUpper().TrimStart().TrimEnd());

                mp_cmd.Parameters.AddWithValue("?5", hasta_es_yas.Text.ToString());
                mp_cmd.Parameters.AddWithValue("?6", evtel.Text.ToString());
                mp_cmd.Parameters.AddWithValue("?7", istel.Text.ToString());
                mp_cmd.Parameters.AddWithValue("?8", ceptel.Text.ToString());

                mp_cmd.Parameters.AddWithValue("?9", cepteles.Text.ToString());
                mp_cmd.Parameters.AddWithValue("?10", email.Text.ToString());
                mp_cmd.Parameters.AddWithValue("?11", boy.Text);
                mp_cmd.Parameters.AddWithValue("?12", kilo.Text);

                mp_cmd.Parameters.AddWithValue("?13", sg.Text);
                mp_cmd.Parameters.AddWithValue("?14", sp.Text);
                mp_cmd.Parameters.AddWithValue("?15", sa.Text);

                mp_cmd.Parameters.AddWithValue("?16", sc.Text);
                mp_cmd.Parameters.AddWithValue("?17", se.Text);

                mp_cmd.Parameters.AddWithValue("?20", sifre.Text.TrimEnd().TrimStart());
                mp_connection.Open();

                int eks = mp_cmd.ExecuteNonQuery();

                mp_connection.Close();

                if (eks == 1)
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Bilgileriniz baþarýyla güncelleþtirildi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;
                    hasta_adi.Enabled = false;
                    hasta_soyadi.Enabled = false;
                    hasta_dt.Enabled = false;
                    hasta_es_adi.Enabled = false;
                   

                    sg.Enabled = false;
                    sp.Enabled = false;
                    sa.Enabled = false;
                    sc.Enabled = false;
                    se.Enabled = false;
                 
                    guncelleyen_ekle();

                


                }
                else
                {

                    panel_sonuc.Visible = true;
                    sonuc.Text = "Bilgileriniz Güncelleþtirilemedi.Lütfen Bilgileri Kontrol Ediniz !";
                    sonuc.ForeColor = System.Drawing.Color.Red;
                }

            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Þifreniz en az 6 karakterden oluþmalýdýr !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch
        {
                       panel_sonuc.Visible = true;
                       sonuc.Text = "Bilgileriniz Güncelleþtirilemedi.Güncelleme Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý !";

            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    }




    void guncelleyen_ekle()
    {


        try
        {
            
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            string hastaAdi = islemdekihasta["hastaAdi"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand mp_cmd = new MySqlCommand("insert into hasta_kimlik_guncellemeleri(hasta_id,guncelleyen,tarih) values ('" + hasta_id.ToString() + "','" + hastaAdi + "','" + DateTime.Now + "')", mp_connection);

            mp_connection.Open();

            int eks = mp_cmd.ExecuteNonQuery();

            mp_connection.Close();


            if (eks != 1)
            {

                sonuc.Text = sonuc .Text + "Güncelleyen Bilgileri Kaydedilemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }
        }

        catch
        { 
        

        }
    
    }


    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {

        kimlik_guncelle();


        
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        hasta_adi.Enabled = true;
        hasta_dt.Enabled = true;
        hasta_es_adi.Enabled = true;
        hasta_es_yas.Enabled = true;
        hasta_soyadi.Enabled = true;
        evtel.Enabled = true;
        istel.Enabled = true;

        ceptel.Enabled = true;
        cepteles.Enabled = true;
        email.Enabled = true;
        kilo.Enabled = true;
        boy.Enabled = true;
        sg.Enabled = true;
        sp.Enabled = true;
        sa.Enabled = true;
        sc.Enabled = true;
        se.Enabled = true;
        btnKaydet.Enabled = true;
        
        panel_sonuc.Visible = false;


        yukle();

    }
}
