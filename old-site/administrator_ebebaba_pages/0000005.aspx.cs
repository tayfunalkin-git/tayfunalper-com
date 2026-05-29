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

public partial class administrator_ebebaba_pages_0000005 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            doktor_yukle();
        
        }
    }
    

    void doktor_yukle()
    {

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from uye_doktor order by concat(uye_adi,' ',uye_soyadi) asc", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            doktor_listesi.DataSource = ebebaba_dt;
            doktor_listesi.DataBind();


            Label ad_soyad = new Label();
            LinkButton admin = new LinkButton();
            LinkButton doktor = new LinkButton();
            LinkButton ortak = new LinkButton();
            ImageButton bilgi_guncelle = new ImageButton();
            ImageButton diger_bilgiler = new ImageButton();
            ImageButton sil = new ImageButton();


            int i = 0;


            foreach (GridViewRow satir in doktor_listesi.Rows)
            {


                ad_soyad = (Label)satir.FindControl("adi_soyadi");
                ad_soyad.Text = ebebaba_dt.Rows[i]["uye_adi"].ToString() + " " + ebebaba_dt.Rows[i]["uye_soyadi"].ToString();
                admin = (LinkButton)satir.FindControl("admin_uyelik");
                doktor = (LinkButton)satir.FindControl("doktor_uyelik");

                ortak = (LinkButton)satir.FindControl("ortak_kullanici");
                admin.Text = ebebaba_dt.Rows[i]["uye_tip_admin"].ToString();
                doktor.Text = ebebaba_dt.Rows[i]["uye_tip_doktor"].ToString();
                admin.CommandArgument = ebebaba_dt.Rows[i]["uye_id"].ToString();
                doktor.CommandArgument = ebebaba_dt.Rows[i]["uye_id"].ToString();
                admin.CommandName = ebebaba_dt.Rows[i]["uye_tip_admin"].ToString();
                doktor.CommandName = ebebaba_dt.Rows[i]["uye_tip_doktor"].ToString();
                ortak.Text = ebebaba_dt.Rows[i]["ortak_kullanici"].ToString();
                ortak.CommandArgument = ebebaba_dt.Rows[i]["uye_id"].ToString();
                ortak.CommandName = ebebaba_dt.Rows[i]["ortak_kullanici"].ToString();


                bilgi_guncelle = (ImageButton)satir.FindControl("bilgi_guncelle");
                bilgi_guncelle.CommandArgument = ebebaba_dt.Rows[i]["uye_id"].ToString();


                diger_bilgiler = (ImageButton)satir.FindControl("diger_bilgiler");
                diger_bilgiler.CommandArgument = ebebaba_dt.Rows[i]["uye_id"].ToString();
                sil = (ImageButton)satir.FindControl("sil");
                sil.CommandArgument = ebebaba_dt.Rows[i]["uye_id"].ToString();


                i++;

            }
        }
        catch
        { 
        
        }
    }

    protected void bilgi_guncelle_Command(object sender, CommandEventArgs e)
    {


        other_info.Visible = false;

        Response.Redirect("0000006.aspx?gdid="+e.CommandArgument.ToString());

    }
    protected void doktor_uyelik_Command(object sender, CommandEventArgs e)
    {
        try
        {

            other_info.Visible = false;

            string deger = "+";

            if (e.CommandName.ToString() == "+")
            {
                deger = "-";


            }
            else if (e.CommandName.ToString() == "-")
            {

                deger = "+";

            }

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("Update uye_doktor set uye_tip_doktor='" + deger.ToString() + "' where uye_id=" + e.CommandArgument + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks == 1)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Yetki Deðiþikliði Baþarýyla Deðiþtirildi.";
                sonuc.ForeColor = System.Drawing.Color.Green;
                doktor_yukle();

            }
            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Yetki Deðiþtirme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }
        }

        catch
        { 
        
        }



    }
    protected void admin_uyelik_Command(object sender, CommandEventArgs e)
    {



        try
        {

            other_info.Visible = false;

            string deger = "-";
            string ortak = "-";
            if (e.CommandName.ToString() == "+")
            {
                deger = "-";
                ortak = "-";


            }
            else if (e.CommandName.ToString() == "-")
            {

                deger = "+";
                ortak = "+";

            }


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("Update uye_doktor set uye_tip_admin='" + deger.ToString() + "',ortak_kullanici='" + ortak.ToString() + "' where uye_id=" + e.CommandArgument + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks == 1)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Yetki Deðiþikliði Baþarýyla Deðiþtirildi.";
                sonuc.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("0000005.aspx");

                doktor_yukle();

            }
            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Yetki Deðiþtirme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }

        catch
        { 
        
        }
        }
    protected void diger_bilgiler_Command(object sender, CommandEventArgs e)
    {
        other_info.Visible = true;

        panel_sonuc.Visible = false;


        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from uye_doktor where uye_id=" + e.CommandArgument + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            Label2.Text = ebebaba_dt.Rows[0]["uye_adi"].ToString();
            Label3.Text = ebebaba_dt.Rows[0]["uye_soyadi"].ToString();
            Label4.Text = ebebaba_dt.Rows[0]["uye_email"].ToString();

            Label6.Text = ebebaba_dt.Rows[0]["uye_adres"].ToString();
            Label9.Text = ebebaba_dt.Rows[0]["uye_ev_tel"].ToString();
            Label11.Text = ebebaba_dt.Rows[0]["uye_cep_tel"].ToString();
            Label10.Text = ebebaba_dt.Rows[0]["uye_is_tel"].ToString();

            Label7.Text = ebebaba_dt.Rows[0]["uye_k_adi"].ToString();
            Label8.Text = ebebaba_dt.Rows[0]["uye_sifre"].ToString();



            hastalari_yukle(e.CommandArgument.ToString());
            kendi_hastalarini_yukle(e.CommandArgument.ToString());


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Doktor Diðer Bilgileri Yüklenirken Hata Oluþtu!";
        }








    }
    void hastalari_yukle(string gelen)
    {

        MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

        MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select * from hasta_paylas where doktor_id='" + gelen.ToString() + "' order by CAST(siklus_id as UNSIGNED) asc", ebebaba_connection);
        DataTable ebebaba_dt2 = new DataTable();
        ebebaba_da2.Fill(ebebaba_dt2);

        Label1.Text = "(" + ebebaba_dt2.Rows.Count.ToString()+")";

        doktorlistesi.DataSource = ebebaba_dt2;
        doktorlistesi.DataBind();

        int k = 0;
        foreach (GridViewRow str in doktorlistesi.Rows)
        {
            MySqlDataAdapter ebebaba_da3 = new MySqlDataAdapter("select concat(U.uye_adi,' ',U.uye_soyadi) as ad , concat(S.siklus_ay,' ',S.siklus_yil) as tarih , U.uye_id  from siklus_ana_tab S,uye_hasta U where CAST(S.hasta_id as UNSIGNED) = U.uye_id and S.siklus_id=" + ebebaba_dt2.Rows[k]["siklus_id"].ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt3 = new DataTable();
            ebebaba_da3.Fill(ebebaba_dt3);

            LinkButton adi = new LinkButton();
            adi = (LinkButton)str.FindControl("hasta_adi");
            adi.Text = ebebaba_dt3.Rows[0]["ad"].ToString();
            adi.CommandArgument = ebebaba_dt3.Rows[0]["uye_id"].ToString();

            LinkButton skl = new LinkButton();
            skl = (LinkButton)str.FindControl("siklus_adi");
            skl.Text = ebebaba_dt3.Rows[0]["tarih"].ToString();
            skl.CommandName = ebebaba_dt2.Rows[k]["siklus_id"].ToString();
            skl.CommandArgument = ebebaba_dt3.Rows[0]["uye_id"].ToString();

            LinkButton iptal = new LinkButton();
            iptal = (LinkButton)str.FindControl("ipt");
            iptal.CommandArgument = ebebaba_dt2.Rows[k]["paylas_id"].ToString();
            iptal.CommandName = gelen.ToString();

            k++;


        }

    }
    void kendi_hastalarini_yukle(string gelen)
    {
        MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

        MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select uye_id,concat(uye_adi,' ',uye_soyadi) from uye_hasta where uye_ekleyen='" + gelen.ToString() + "' order by concat(uye_adi,' ',uye_soyadi) asc", ebebaba_connection);
        DataTable ebebaba_dt2 = new DataTable();
        ebebaba_da2.Fill(ebebaba_dt2);

        Label12.Text = "(" + ebebaba_dt2.Rows.Count.ToString() + ")";


        kendilistesi.DataSource = ebebaba_dt2;
        kendilistesi.DataBind();

        int k = 0;
        foreach (GridViewRow str in kendilistesi.Rows)
        {

            MySqlDataAdapter ebebaba_da3 = new MySqlDataAdapter("select concat(U.uye_adi,' ',U.uye_soyadi) as ad , concat(S.siklus_ay,' ',S.siklus_yil) as tarih , U.uye_id  from siklus_ana_tab S,uye_hasta U where CAST(S.hasta_id as UNSIGNED) = U.uye_id and S.hasta_id = '" + ebebaba_dt2.Rows[k]["uye_id"].ToString() + "'", ebebaba_connection);
            DataTable ebebaba_dt3 = new DataTable();
            ebebaba_da3.Fill(ebebaba_dt3);

            LinkButton adi = new LinkButton();
            adi = (LinkButton)str.FindControl("hasta_adi");
            adi.Text = ebebaba_dt3.Rows[0]["ad"].ToString();
            adi.CommandArgument = ebebaba_dt3.Rows[0]["uye_id"].ToString();

            k++;


        }

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {

        try
        {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from uye_doktor where uye_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            MySqlCommand ebebaba_cmd = new MySqlCommand("delete from  hasta_paylas where doktor_id='" + e.CommandArgument.ToString() + "'", ebebaba_connection);
            MySqlCommand ebebaba_cmd2 = new MySqlCommand("delete from ssgt where uye_k_adi='" + ebebaba_dt.Rows[0]["uye_k_adi"].ToString()+ "'", ebebaba_connection);
            MySqlCommand ebebaba_cmd3 = new MySqlCommand("update uye_hasta set uye_ekleyen = '"+ebebaba_class.doktor_adi_bul(e.CommandArgument.ToString())+"' where uye_ekleyen='" +e.CommandArgument.ToString()+ "'", ebebaba_connection);
            MySqlCommand ebebaba_cmd4 = new MySqlCommand("delete from  uye_doktor where uye_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


            MySqlCommand ebebaba_cmd13 = new MySqlCommand("update gelen_mesajlar set gonderen='" + ebebaba_class.doktor_adi_bul(e.CommandArgument.ToString()) + "' where gonderen = '" + ebebaba_dt.Rows[0]["uye_k_adi"].ToString() + "'", ebebaba_connection);
            MySqlCommand ebebaba_cmd14 = new MySqlCommand("update giden_mesajlar set alici='" + ebebaba_class.doktor_adi_bul(e.CommandArgument.ToString()) + "'  where alici = '" + ebebaba_dt.Rows[0]["uye_k_adi"].ToString() + "'", ebebaba_connection);
            MySqlCommand ebebaba_cmd16 = new MySqlCommand("update gelen_mesajlar set alici='" + ebebaba_class.doktor_adi_bul(e.CommandArgument.ToString()) + "' where alici = '" + ebebaba_dt.Rows[0]["uye_k_adi"].ToString() + "'", ebebaba_connection);
            MySqlCommand ebebaba_cmd17 = new MySqlCommand("update giden_mesajlar set gonderen='" + ebebaba_class.doktor_adi_bul(e.CommandArgument.ToString()) + "' where gonderen = '" + ebebaba_dt.Rows[0]["uye_k_adi"].ToString() + "'", ebebaba_connection);

            ebebaba_connection.Open();
            ebebaba_cmd.ExecuteNonQuery();
            ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_cmd13.ExecuteNonQuery();
            ebebaba_cmd14.ExecuteNonQuery();
            ebebaba_cmd16.ExecuteNonQuery();
            ebebaba_cmd17.ExecuteNonQuery();
            int eks = ebebaba_cmd4.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
                string kullaniciAdi = EbebabaKullanilan["AdminKKA"].ToString();

                if (ebebaba_class.doktor_id_bul(kullaniciAdi.ToString()) == e.CommandArgument.ToString())
                {
                    Response.Redirect("~/signout.aspx");

                }
                else
                {

                    panel_sonuc.Visible = true;
                    sonuc.Text = "Doktor Kaydý Baþarýyla Silindi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;

                    other_info.Visible = false;
                    doktor_yukle();
                }


            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Doktor Kaydý Silinemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Doktor Kaydý Silme Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
    protected void ortak_kullanici_Command(object sender, CommandEventArgs e)
    {
        try
        {
            other_info.Visible = false;

            string deger = "+";

            if (e.CommandName.ToString() == "+")
            {
                deger = "-";


            }
            else if (e.CommandName.ToString() == "-")
            {

                deger = "+";

            }




            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd2 = new MySqlCommand("Select uye_tip_admin from uye_doktor where uye_id=" + e.CommandArgument + "", ebebaba_connection);
            ebebaba_connection.Open();
            object eks2 = ebebaba_cmd2.ExecuteScalar();

            ebebaba_connection.Close();

            if (eks2.ToString() == "-")
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Ortak Kullanýcýlar Sadece Admin Yetkisi Olan Üyelerde Kullanýlýr !";
                sonuc.ForeColor = System.Drawing.Color.Red;

                doktor_yukle();

            }
            else
            {
                MySqlCommand ebebaba_cmd = new MySqlCommand("Update uye_doktor set ortak_kullanici='" + deger.ToString() + "' where uye_id=" + e.CommandArgument + "", ebebaba_connection);
                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();

                if (eks == 1)
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Ortak Kullanýcý Baþarýyla Deðiþtirildi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;

                    Response.Redirect("0000005.aspx");


                }
                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Ortak Kullanýcý Deðiþtirme Ýþlemi Baþarýsýz !";
                    sonuc.ForeColor = System.Drawing.Color.Red;
                }
            }






        }

        catch
        { 
        
        
        }


    }
    protected void ipt_Command(object sender, CommandEventArgs e)
    {


        try
        {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("delete from hasta_paylas where paylas_id = " + e.CommandArgument.ToString() + "", ebebaba_connection);

            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks == 1)
            {

              
                panel_sonuc.Visible = true;
                sonuc.Text = "Seçilen Doktordaki Hasta Paylaþýmý Baþarýyla Ýptal Edilmiþtir.";
                sonuc.ForeColor = System.Drawing.Color.Green;


                hastalari_yukle(e.CommandName.ToString());

            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Seçilen Siklustaki Doktor Paylaþýmý Ýptal Edilemedi.";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Seçilen Siklustaki Doktor Paylaþýmý Ýptal Edilemedi.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    }
    protected void siklus_adi_Command(object sender, CommandEventArgs e)
    {

        HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
        string sure = EbebabaKullanilan["Adminsure"].ToString();

        HttpCookie islemdekihasta = new HttpCookie("HastaBilgi");
        islemdekihasta["HastaID"] = e.CommandArgument.ToString();

        islemdekihasta.Expires = DateTime.Now.AddMinutes(int.Parse(sure.ToString()));
        Response.Cookies.Add(islemdekihasta);

        Response.Redirect("hasta_modulu/infertilite.aspx?ts=1&siklus_id=" + e.CommandName.ToString());


    }
    protected void hasta_adi_Command(object sender, CommandEventArgs e)
    {
        HttpCookie islemdekihasta = new HttpCookie("HastaBilgi");
        islemdekihasta["HastaID"] = e.CommandArgument.ToString();

        HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
        string sure = EbebabaKullanilan["Adminsure"].ToString();

        islemdekihasta.Expires = DateTime.Now.AddMinutes(int.Parse(sure.ToString()));
        Response.Cookies.Add(islemdekihasta);

        Response.Redirect("hasta_modulu/");

    }
}
