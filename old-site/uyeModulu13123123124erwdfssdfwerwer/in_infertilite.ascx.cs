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

public partial class ivfyonetici_hasta_modulu_in_infertilite : System.Web.UI.UserControl
{
    ivf_class mp_class = new ivf_class();
    protected void Page_Load(object sender, EventArgs e)
    {

   
        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];
        if (!IsPostBack)
        {



            renk_yukle();
     
        }
        ozelbilgiyukle();
        menuyukle2();
        

    }

 
    protected void Button7_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("infertilite_add.aspx?infertilite_kategori_id=" + Request.QueryString["infertilite_kategori_id"].ToString() + "&siklus_id=" + Request.QueryString["siklus_id"].ToString() + "&Ref=infer");

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
        { }

    }
    void ozelbilgiyukle()
    {

        //try
        //{


            alan_adi();



            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            string siklus_id = Request.QueryString["siklus_id"].ToString();

            LinkButton3.Text = dt5.Rows[0]["siklus_ay"] + " - " + dt5.Rows[0]["siklus_yil"].ToString();

            if (dt5.Rows[0]["baslangic"].ToString() == "+")
            {
                Label1.Text = "(Başlangıç)";         
            }
            else if (dt5.Rows[0]["varsayilan"].ToString() == "+")
            {
                Label1.Text = "(Aktif)";
            }
            else
            {
                Label1.Text ="";

            }

            if (Request.QueryString["infertilite_kategori_id"] != null)
            {

                MySqlDataAdapter da4 = new MySqlDataAdapter("Select renk_kodu_id from infertilite2 where siklus_id='" + siklus_id.ToString() + "' and hasta_id='" + hasta_id.ToString() + "' and kategori_id='" + Request.QueryString["infertilite_kategori_id"].ToString() + "'", connect_word);
                DataTable dt4 = new DataTable();
                da4.Fill(dt4);

                if (dt4.Rows.Count == 1)
                {

                    MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from infertilite_renkler where renk_id=" + dt4.Rows[0][0].ToString() + "", connect_word);
                    DataTable dt6 = new DataTable();
                    da6.Fill(dt6);


                    infertilite_ana_panel.BackColor = System.Drawing.Color.FromName(dt6.Rows[0]["renk_kodu"].ToString());


                }
                else
                {

                    infertilite_ana_panel.BackColor = System.Drawing.Color.FromName("#c0c0c0");

                }
            }

        //}

        //catch
        //{

        //}
    }
    void alan_adi()
    {
        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite_adlari where infertilite_id = " + Request.QueryString["infertilite_kategori_id"] + " order by sira asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            infertilite_alan.Text = dt4.Rows[0]["infertilite_adi"].ToString();
        }
        catch
        { }


    }
    protected void infertilite_renk_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);


            string siklus_id = Request.QueryString["siklus_id"].ToString();
            Session.Add("siklus_id", siklus_id.ToString());



            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = mp_class.doktor_kullanici_adi_bul(mpKullanilan["AdminKKA"].ToString());

            MySqlDataAdapter da4 = new MySqlDataAdapter("Select renk_id from infertilite2 where siklus_id='" + siklus_id.ToString() + "' and hasta_id='" + hasta_id.ToString() + "' and kategori_id='" + Request.QueryString["infertilite_kategori_id"].ToString() + "'", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 1)
            {

                MySqlCommand cmd = new MySqlCommand("update infertilite2 set renk_kodu_id='" + infertilite_renk.SelectedValue + "' where renk_id=" + dt4.Rows[0]["renk_id"].ToString() + "", connect_word);
                connect_word.Open();
                int eks = cmd.ExecuteNonQuery();
                connect_word.Close();

                if (eks == 1)
                {

                    MySqlCommand cmd2 = new MySqlCommand("insert into siklus_renk(hasta_id,kategori_id,siklus_id,guncelleyen,guncelleme_tarihi,renk) values ('" + hasta_id.ToString() + "','" + Request.QueryString["infertilite_kategori_id"].ToString() + "','" + siklus_id.ToString() + "','" + kullaniciAdi.ToString() + "','" + DateTime.Now + "','" + infertilite_renk.SelectedItem.Text.ToString() + "')", connect_word);
                    connect_word.Open();
                    int eks2 = cmd2.ExecuteNonQuery();
                    connect_word.Close();
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Değişikliği Başarıyla Gerçekleşti.";
                    sonuc.ForeColor = System.Drawing.Color.Green;


                
                    string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

                    string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın " + LinkButton3.Text + " siklusunun " + infertilite_alan.Text + " alanının renginin değiştirilmesi";



                    mp_class.log_kaydet(kullaniciAdiAdmin, islem);


                    yeniden_git();


                }
                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Değiştirme İşlemi Başarısız !";
                    sonuc.ForeColor = System.Drawing.Color.Green;
                }



            }
            else
            {


                MySqlCommand cmd = new MySqlCommand("insert into infertilite2(siklus_id,hasta_id,renk_kodu_id,kategori_id) values ('" + siklus_id.ToString() + "','" + hasta_id.ToString() + "','" + infertilite_renk.SelectedValue.ToString() + "','" + Request.QueryString["infertilite_kategori_id"].ToString() + "')", connect_word);
                connect_word.Open();
                int eks = cmd.ExecuteNonQuery();
                connect_word.Close();
                if (eks == 1)
                {



                    MySqlCommand cmd2 = new MySqlCommand("insert into siklus_renk(hasta_id,kategori_id,siklus_id,guncelleyen,guncelleme_tarihi,renk) values ('" + hasta_id.ToString() + "','" + Request.QueryString["infertilite_kategori_id"].ToString() + "','" + siklus_id.ToString() + "','" + kullaniciAdi.ToString() + "','" + DateTime.Now + "','" + infertilite_renk.SelectedItem.Text.ToString() + "')", connect_word);

                    connect_word.Open();
                    int eks2 = cmd2.ExecuteNonQuery();
                    connect_word.Close();


                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Değişikliği Başarıyla Gerçekleşti.";
                    sonuc.ForeColor = System.Drawing.Color.Green;
                    yeniden_git();



                }
                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Renk Değiştirme İşlemi Başarısız !";
                    sonuc.ForeColor = System.Drawing.Color.Red;

                }



            }

        }

        catch
        { }

    }
    protected void LinkButton3_Command(object sender, CommandEventArgs e)
    {



        Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + Request.QueryString["siklus_id"].ToString());



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
                sonuc.Text = "Kayıt Başarıyla Silindi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

                HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

                string islem = e.CommandName.ToString();


                mp_class.log_kaydet(kullaniciAdiAdmin, islem);



                bilgi_yukle();

                menuyukle2();

            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Kayıt Silinemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Kayıt Silinme Esnasında Sistem Bir Hata İle Karşılaştı !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }






    }
    protected void guncelle_Command(object sender, CommandEventArgs e)
    {

        Response.Redirect("infertilite_update.aspx?ID=" + e.CommandArgument.ToString() + "&Ref=infertilite");



    }
    void yeniden_git()
    {

        Response.Redirect("infertilite.aspx?infertilite_kategori_id=" + Request.QueryString["infertilite_kategori_id"].ToString() + "&siklus_id=" + Request.QueryString["siklus_id"].ToString());

    }
    void bilgi_yukle()
    {


        try
        {


            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite where hasta_id='" + hasta_id.ToString() + "' and alan_id='" + Request.QueryString["infertilite_kategori_id"].ToString() + "' and siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' order by str_to_date(islem_tarihi,'%d.%m.%Y') asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {

                Label2.Text = " (0)";


            }

            else
            {

                Label2.Text = " (" + dt4.Rows.Count.ToString() + ")";

            }


            inferbilgi.DataSource = dt4;
            inferbilgi.DataBind();


            int a = 0;

            Label tar = new Label();
            Label kat = new Label();
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


                gnc = (ImageButton)str.FindControl("guncelle");
                gnc.CommandArgument = dt4.Rows[a]["kayit_id"].ToString();


                sl = (ImageButton)str.FindControl("sil");
                sl.CommandArgument = dt4.Rows[a]["kayit_id"].ToString();
                sl.CommandName = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın " + LinkButton3.Text + " siklusunun " + infertilite_alan.Text + " alanından kayıt silinmesi";

                msj = (Label)str.FindControl("lblmesaj");
                msj.Text = dt4.Rows[a]["aciklama"].ToString();
                msj.ForeColor = System.Drawing.Color.FromName(renkbul(dt4.Rows[a]["renk_id"].ToString()));


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
    void menuyukle2()
    {
        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];



            string siklus_id = Request.QueryString["siklus_id"].ToString();

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + siklus_id + "", connect_word);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            LinkButton3.Text = dt5.Rows[0]["siklus_ay"] + " - " + dt5.Rows[0]["siklus_yil"].ToString();
   

            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite_adlari order by sira asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            inferlist.DataSource = dt4;
            inferlist.DataBind();


            int a = 0;


            Panel infrenk = new Panel();
            LinkButton aadi = new LinkButton();
            Label lblsayi = new Label();

            foreach (DataListItem str in inferlist.Items)
            {

                infrenk = (Panel)str.FindControl("infrrenk");

                aadi = (LinkButton)str.FindControl("inferadi");

                lblsayi = (Label)str.FindControl("sayi");

                aadi.PostBackUrl = "infertilite.aspx?infertilite_kategori_id=" + dt4.Rows[a]["infertilite_id"].ToString() + "&siklus_id=" + siklus_id.ToString();

                MySqlDataAdapter da6 = new MySqlDataAdapter("Select renk_kodu_id from infertilite2 where kategori_id = '" + dt4.Rows[a]["infertilite_id"].ToString() + "' and siklus_id='" + siklus_id.ToString() + "' and hasta_id='" + hasta_id.ToString() + "'", connect_word);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);

                if (dt6.Rows.Count == 1)
                {

                    if (dt6.Rows[0][0].ToString() != "")
                    {

                        MySqlDataAdapter da7 = new MySqlDataAdapter("Select * from infertilite_renkler where renk_id = " + dt6.Rows[0][0].ToString() + "", connect_word);
                        DataTable dt7 = new DataTable();
                        da7.Fill(dt7);
                        aadi.Text = dt4.Rows[a]["infertilite_adi"].ToString();
                        infrenk.BackColor = System.Drawing.Color.FromName(dt7.Rows[0]["renk_kodu"].ToString());




                    }
                    else
                    {
                        aadi.Text = dt4.Rows[a]["infertilite_adi"].ToString();
                        infrenk.BackColor = System.Drawing.Color.FromName("#c0c0c0");



                    }
                }


                else if (dt6.Rows.Count == 0)
                {
                    aadi.Text = dt4.Rows[a]["infertilite_adi"].ToString();
                    infrenk.BackColor = System.Drawing.Color.FromName("#c0c0c0");




                }



                MySqlDataAdapter da8 = new MySqlDataAdapter("Select * from infertilite where siklus_id='" + siklus_id + "' and alan_id='" + dt4.Rows[a]["infertilite_id"].ToString() + "'", connect_word);
                DataTable dt8 = new DataTable();
                da8.Fill(dt8);


                if (dt8.Rows.Count > 0)
                {
                    lblsayi.Text = dt8.Rows.Count.ToString();
                }
                else if (dt8.Rows.Count == 0)
                {

                    lblsayi.Text = "";

                }



                a++;

            }

            if (Request.QueryString["siklus_id"] != null && Request.QueryString["infertilite_kategori_id"] != null)
            {
                panel_sonuc.Visible = false;
                infer.Visible = true;
                bilgi_yukle();


            }


            if (Request.QueryString["siklus_id"] != null && Request.QueryString["ts"] != null)
            {


                infer.Visible = false;

            }


        }


        catch
        {

        }





    }

}
