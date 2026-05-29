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

public partial class ivfyonetici_hasta_modulu_infertilite2 : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();


    string[] diziyigetir(string gelen_id)
    {
        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter da5 = new MySqlDataAdapter("Select konu_id,konu from yardim_konulari where infertilite='" + gelen_id + "' order by sira asc", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        string[] dizim = new string[dt5.Rows.Count];

        for (int i = 0; i < dt5.Rows.Count; i++)
        {

         
              dizim[i] = string.Format("<a href=\"javascript:git5({0})\"><span style=\"font-size: 12px; font-family: Arial ;color:#000000; text-decoration:none \"><img border=0 src=\"../images/menu.gif\"> &nbsp;{1}</span></a>",dt5.Rows[i]["konu_id"].ToString(),dt5.Rows[i]["konu"].ToString());
        

        }
           
    
        return dizim;

    }

    //void aciklama_yukle()
    //{

    //    string[] dizimiz = diziyigetir(Request.QueryString["kategori_id"]);


    //    for (int a = 0; a < dizimiz.Length; a++)
    //    {

    //        MenuItem yeni = new MenuItem();
    //        yeni.Text = dizimiz[a];

    //        aciklama_menusu.Items[0].ChildItems.Add(yeni);

    //    }
    //    aciklama_menusu.Items[0].Text = alan_adi_ver() + " Hakkýnda Açýklamalar ";

    //}


    protected void Page_Load(object sender, EventArgs e)
    {
      // string strScript = "<script language=\"javascript\">";
      //strScript += "var menu1=new Array()";

      //  string[] menu1 = diziyigetir(Request.QueryString["kategori_id"]);

      //  for (int a = 0; a < menu1.Length; a++)
      //  {
      //      strScript += "menu1" + "['" + a + "']=" + menu1[a];


      //  }
      //  strScript += "</script>";

      //  this.RegisterClientScriptBlock("clientScript", strScript);





        ozelbilgiyukle();

  if (!IsPostBack)
       {

            renk_yukle();

            bilgi_yukle();


  }


  //aciklama_yukle();
   }



    void yeniden_git()
    {

        Response.Redirect("infertilite2.aspx?kategori_id=" + Request.QueryString["kategori_id"].ToString());

    }

    void ozelbilgiyukle()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            alan_adi();

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from ana_infertilite where kategori_id='" + Request.QueryString["kategori_id"].ToString() + "' and hasta_id='"+hasta_id.ToString()+"'", connect_word);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            if (dt5.Rows.Count == 1)
            {

                MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from infertilite_renkler where renk_id=" + dt5.Rows[0]["renk_kodu_id"].ToString() + "", connect_word);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);


                infertilite_ana_panel.BackColor = System.Drawing.Color.FromName(dt6.Rows[0]["renk_kodu"].ToString());


            }
            else
            {

                infertilite_ana_panel.BackColor = System.Drawing.Color.FromName("#c5c5c5");

            }


        }

        catch
        { 
        
        }
}


    string alan_adi_ver()
    {
        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite_adlari where infertilite_id = " + Request.QueryString["kategori_id"] + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["infertilite_adi"].ToString();

        }
        catch
        {
            return "";

        }
    
    }


    void alan_adi()
    {
        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite_adlari where infertilite_id = " + Request.QueryString["kategori_id"] + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            infertilite_alan.Text = dt4.Rows[0]["infertilite_adi"].ToString();

        }
        catch
        { 
        
        
        }

    
    }

    void renk_yukle()
    {
        try
        {


            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from infertilite_renkler order by renk_id", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            infertilite_renk.DataSource = dt6;
            infertilite_renk.DataTextField = dt6.Columns["renk_etiket"].ToString();
            infertilite_renk.DataValueField = dt6.Columns["renk_id"].ToString();
            infertilite_renk.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            infertilite_renk.Items.Insert(0, yeni);
        }


        catch
        {
        
        }

    }


    protected void infertilite_renk_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);


            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = mp_class.doktor_kullanici_adi_bul(mpKullanilan["AdminKKA"].ToString());

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlDataAdapter da4 = new MySqlDataAdapter("Select renk_id from ana_infertilite where hasta_id='" + hasta_id.ToString() + "' and kategori_id='" + Request.QueryString["kategori_id"].ToString() + "'", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 1)
            {

                MySqlCommand cmd = new MySqlCommand("update ana_infertilite set renk_kodu_id='" + infertilite_renk.SelectedValue + "' where renk_id=" + dt4.Rows[0]["renk_id"].ToString() + "", connect_word);
                connect_word.Open();
                int eks = cmd.ExecuteNonQuery();
                connect_word.Close();

                if (eks == 1)
                {
                    
                    MySqlCommand cmd2 = new MySqlCommand("insert into ana_renk_infertilite(hasta_id,kategori_id,guncelleyen,guncelleme_tarihi,renk) values ('" + hasta_id.ToString() + "','" + Request.QueryString["kategori_id"].ToString() + "','" + kullaniciAdi.ToString() + "','" + DateTime.Now + "','" + infertilite_renk.SelectedItem.Text.ToString() + "')", connect_word);
                    connect_word.Open();
                    int eks2 = cmd2.ExecuteNonQuery();
                    connect_word.Close();
                   
                    
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Deðiþikliði Baþarýyla Gerçekleþti.";
                    sonuc.ForeColor = System.Drawing.Color.Green;




                    string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
                    string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanýn " + infertilite_alan.Text + " renginin deðiþtirilmesi";

                    mp_class.log_kaydet(kullaniciAdiAdmin, islem);



                    yeniden_git();


                }
                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Deðiþtirme Ýþlemi Baþarýsýz !";
                    sonuc.ForeColor = System.Drawing.Color.Green;
                }



            }
            else
            {


                MySqlCommand cmd = new MySqlCommand("insert into ana_infertilite(hasta_id,renk_kodu_id,kategori_id) values ('" + hasta_id.ToString() + "','" + infertilite_renk.SelectedValue.ToString() + "','" + Request.QueryString["kategori_id"].ToString() + "')", connect_word);
                connect_word.Open();
                int eks = cmd.ExecuteNonQuery();
                connect_word.Close();
                if (eks == 1)
                {



                    MySqlCommand cmd2 = new MySqlCommand("insert into ana_renk_infertilite(hasta_id,kategori_id,guncelleyen,guncelleme_tarihi,renk) values ('" + hasta_id.ToString() + "','" + Request.QueryString["kategori_id"].ToString() + "','" + kullaniciAdi.ToString() + "','" + DateTime.Now + "','" + infertilite_renk.SelectedItem.Text.ToString() + "')", connect_word);

                    connect_word.Open();
                    int eks2 = cmd2.ExecuteNonQuery();
                    connect_word.Close();

                   
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Deðiþikliði Baþarýyla Gerçekleþti.";
                    sonuc.ForeColor = System.Drawing.Color.Green;
                    yeniden_git();



                }
                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Deðiþtirme Ýþlemi Baþarýsýz !";
                    sonuc.ForeColor = System.Drawing.Color.Red;

                }



            }

        }

        catch
        { }

    }



    void bilgi_yukle()
    {


        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite where hasta_id='" + hasta_id.ToString() + "' and alan_id='" + Request.QueryString["kategori_id"].ToString() + "' order by str_to_date(islem_tarihi,'%d.%m.%Y') asc", connect_word);

            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {
              
                say.Text = " (0)";
              

            }

            else
            {
               
                say.Text = " ("+dt4.Rows.Count.ToString()+")";
        

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
            ImageButton sl = new ImageButton();
            ImageButton gnc = new ImageButton();


            foreach (DataListItem str in inferbilgi.Items)
            {

                tar = (Label)str.FindControl("lbltarih");
                tar.Text = dt4.Rows[a]["islem_tarihi"].ToString();

                kat = (Label)str.FindControl("lblkategori");
                kat.Text = kategori_bul(dt4.Rows[a]["kategori_id"].ToString());


                sk = (Label)str.FindControl("lblsiklus");
                sk.Text = siklus_bul(dt4.Rows[a]["siklus_id"].ToString());

                sl = (ImageButton)str.FindControl("sil");
                sl.CommandArgument = dt4.Rows[a]["kayit_id"].ToString();
                sl.CommandName = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanýn " + sk.Text + " siklusunun " + infertilite_alan.Text + " alanýndan kayýt silinmesi";



                msj = (Label)str.FindControl("lblmesaj");
                msj.Text = "<font color=" + renkbul(dt4.Rows[a]["renk_id"].ToString()) + ">" + dt4.Rows[a]["aciklama"].ToString() + "</font>";

                gnc = (ImageButton)str.FindControl("guncelle");
                gnc.CommandArgument = dt4.Rows[a]["kayit_id"].ToString();

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

 protected void sil_Command(object sender, CommandEventArgs e)
    {


        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlCommand mp_cmd = new MySqlCommand("delete from infertilite where kayit_id=" + e.CommandArgument.ToString() + "", connect_word);
            connect_word.Open();
            int eks = mp_cmd.ExecuteNonQuery();
            connect_word.Close();

            if (eks == 1)
            {

               
                panel_sonuc.Visible = true;
                sonuc.Text = "Kayýt Baþarýyla Silindi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

                HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

                string islem = e.CommandName.ToString();


                mp_class.log_kaydet(kullaniciAdiAdmin, islem);


                bilgi_yukle();

            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Kayýt Silinemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Kayýt Silinme Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý !";
            sonuc.ForeColor = System.Drawing.Color.Red;
       

        }






    }
    protected void guncelle_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("infertilite_update.aspx?ID=" + e.CommandArgument.ToString() + "&Ref=infertilite_ana_menu");

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("infertilite_add.aspx?infertilite_kategori_id=" + Request.QueryString["kategori_id"].ToString());



    }
}



