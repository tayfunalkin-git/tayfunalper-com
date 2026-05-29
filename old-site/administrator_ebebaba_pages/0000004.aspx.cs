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

public partial class administrator_ebebaba_pages_0000004 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
    forum_class fc = new forum_class();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack && Request.QueryString["obdid"] != null)
        {

            yukle();

        } 
    }


    void yukle()
    {

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from uye_doktor_ob where uye_id=" + Request.QueryString["obdid"].ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1 && ebebaba_dt.Rows[0]["uye_onay"].ToString() == "1")
            {



                panel_sonuc.Visible = true;
                sonuc.Text = "Onay Bekleyen Doktor Kaydý Bilgilerini Onaylayarak Sistem Veritabanlarýna Kaydýn Geçiþini Saðlayýnýz !";

               doktor_adi.Text = ebebaba_dt.Rows[0]["uye_adi"].ToString();
                doktor_soyadi.Text = ebebaba_dt.Rows[0]["uye_soyadi"].ToString();
                evtel.Text = ebebaba_dt.Rows[0]["uye_ev_tel"].ToString();
                ceptel.Text = ebebaba_dt.Rows[0]["uye_cep_tel"].ToString();
                istel.Text = ebebaba_dt.Rows[0]["uye_is_tel"].ToString();
                doktor_adres.Text = ebebaba_dt.Rows[0]["uye_adres"].ToString();
                email.Text = ebebaba_dt.Rows[0]["uye_email"].ToString();
                kullanici_adi.Text = ebebaba_dt.Rows[0]["uye_k_adi"].ToString();
                sifre.Text = ebebaba_dt.Rows[0]["uye_sifre"].ToString();


            }

            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Onay Bekleyen Doktor Kaydý Bulunamadý !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }



        }
        catch
        {


            panel_sonuc.Visible = true;
            sonuc.Text = "Onay Bekleyen Doktor Kayýt Bilgileri Yüklenirken Hata Oluþtu!";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    }








    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (kullanici_adi.Text == "")
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Kullanýcý Adý Alaný Boþ Olduðundan Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;
        }
        else
        {

            if (kullanici_adi_kontrol(kullanici_adi.Text) == true)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Kullanýcý Adý Kullanýlabilir.";
                sonuc.ForeColor = System.Drawing.Color.Green;


            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Bu Kullanýcý Adý Baþka Bir Kullanýcýya Aittir.Kullanýlamaz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }
        
        }

    }


    void kayit_ekle()
    {


        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("Insert Into uye_doktor(uye_adi,uye_soyadi,uye_ev_tel,uye_is_tel,uye_cep_tel,uye_email,uye_k_adi,uye_sifre,uye_kayit_tarihi,uye_ekleyen,uye_adres,uye_tip_doktor,uye_tip_admin,ortak_kullanici) values (?1,?2,?3,?4,?5,?6,?7,?8,?9,?10,?11,?12,?13,?14)", ebebaba_connection);
           


            ebebaba_cmd.Parameters.AddWithValue("?1", doktor_adi.Text.Replace(doktor_adi.Text.TrimStart().Substring(0,1),doktor_adi.Text.TrimStart().ToUpper().Substring(0,1)));
            ebebaba_cmd.Parameters.AddWithValue("?2", doktor_soyadi.Text.ToUpper().TrimEnd().TrimStart().ToString());
            ebebaba_cmd.Parameters.AddWithValue("?3", evtel.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?4", istel.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?5", ceptel.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?6", email.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?7", kullanici_adi.Text.ToLower().TrimStart().TrimEnd());
            ebebaba_cmd.Parameters.AddWithValue("?8", sifre.Text.TrimEnd().TrimStart().ToString());

            ebebaba_cmd.Parameters.AddWithValue("?9", DateTime.Now.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?10", ebebaba_class.doktor_kullanici_adi_bul(((Label)Master.FindControl("kullanici_adi")).Text));
            ebebaba_cmd.Parameters.AddWithValue("?11", doktor_adres.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?12", "+");
            string onay = "-" ;
            string ortak = "-";
            if (yonetici_onay.Checked)
            { onay = "+";
            ortak = "+";
            
            }
            else { onay = "-";

            ortak = "-";

        }
        
            ebebaba_cmd.Parameters.AddWithValue("?13", onay.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?14", ortak.ToString());

                     ebebaba_connection.Open();

           int eks = ebebaba_cmd.ExecuteNonQuery();

           ebebaba_connection.Close();

            if (eks == 1)
            {


                panel_sonuc.Visible = true;
                sonuc.Text = "Doktor Kaydý Baþarýyla Gerçekleþtirildi.";
                sonuc.ForeColor = System.Drawing.Color.Green;
                doktor_adi.Enabled = false ;
                doktor_soyadi.Enabled=false;
                doktor_adres.Enabled=false;
                evtel.Enabled=false;
                ceptel.Enabled=false;
                istel.Enabled=false;
                email.Enabled=false;
                kullanici_adi.Enabled=false;
                sifre.Enabled=false;
                ImageButton1.Enabled = false;
                ImageButton2.Enabled = false;
                btnKaydet.Enabled = false;
                yonetici_onay.Enabled = false;

                if (Request.QueryString["obdid"] != null)
                {

                    onayver();




                }


                if (email.Text != "")
                {


                    string mesaj2 = "<font face='Tahoma'>Merhaba " + doktor_adi.Text.ToUpper() + " " +doktor_soyadi.Text.ToUpper();
                    mesaj2 = mesaj2 + "<br>" + "Bu maili Ebebaba ailesinin bir üyesi olduðunuz için almýþ bulunmaktasýnýz.<br>";
                    mesaj2 = mesaj2 + "Sisteme giriþ yapabilmek için gerekli olan üyelik bilgileriniz aþaðýdaki gibidir ;<br>Kullanýcý Adýnýz : "+ kullanici_adi.Text + " <br>Þifreniz : "+ sifre.Text+ "<br>";


                    mesaj2 = mesaj2 + "<br><br>Sisteme giriþ için Doktor Giriþi menüsünü kullanabilirsiniz yada " + "<a href='http://www.tayfunalper.com/doktor_modulu.aspx'>Buraya Týklayarak Hýzlý Giriþ Yapabilirsiniz...</a></font>";

                    mesaj2 = mesaj2 + "<br><br>" + fc.adresal(0301009184).ToString();

                    fc.mailsend("tayfunalper.com 'a Hoþgeldiniz.", email.Text, mesaj2);
                    fc.mailsend("tayfunalper.com 'a Hoþgeldiniz.", "y_tayfun_alper@yahoo.com", mesaj2);


                }

                Response.Redirect("0000005.aspx");




            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Doktor Kaydý Gerçekleþemedi.Lütfen Bilgileri Kontrol Ediniz !";
                sonuc.ForeColor = System.Drawing.Color.Red ;
            }
        }
        catch
        {
            Exception ex = new Exception();
            
            panel_sonuc.Visible = true;
            sonuc.Text = "Doktor Kaydý Gerçekleþirken Bir Hata Oluþtu.Hata Kodu : " + ex.Message;

            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    }



    void onayver()
    {


        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("Update uye_doktor_ob set uye_onay ='0' where uye_id=" + Request.QueryString["obdid"].ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            string mesaj2 = "<font face='Tahoma'>Merhaba " + doktor_adi.Text.ToUpper() + " " + doktor_soyadi.Text.ToUpper();
            mesaj2 = mesaj2 + "<br>" + "Bu maili tayfunalper.com ailesinin bir üyesi olduðunuz için almýþ bulunmaktasýnýz.<br>";
            mesaj2 = mesaj2 + "Sisteme giriþ yapabilmek için gerekli olan üyelik bilgileriniz aþaðýdaki gibidir ;<br>Kullanýcý Adýnýz : " + kullanici_adi.Text + " <br>Þifreniz : " + sifre.Text + "<br>";


            mesaj2 = mesaj2 + "<br><br>Sisteme giriþ için sünü kullanabilirsiniz yada " + "<a href='http://www.ebebaba.com/doktor_modulu.aspx'>Buraya Týklayarak Hýzlý Giriþ Yapabilirsiniz...</a></font>";

            mesaj2 = mesaj2 + "<br><br>" + fc.adresal(0301009184).ToString();


            string konu = doktor_adi.Text.ToUpper() + " " + doktor_soyadi.Text.ToUpper() + " isimli doktorun onay mesajý";


            fc.mailsend(konu, "y_tayfun_alper@yahoo.com", mesaj2);


        }

        catch
        { 
        }
    }





    bool kullanici_adi_kontrol(string gelen_k_adi)
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select uye_k_adi from uye_doktor where uye_k_adi = '" + gelen_k_adi.ToString().TrimStart().TrimEnd() + "'", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("Select uye_k_adi from uye_hasta where uye_k_adi = '" + gelen_k_adi.ToString().TrimStart().TrimEnd() + "'", ebebaba_connection);

            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);



            if (ebebaba_dt.Rows.Count == 0 && ebebaba_dt2.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;

            }


        }

        catch
        {

            return false;


        }

    }





    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {

        if (doktor_adi.Text == "" || doktor_soyadi.Text == "")
        {
           
            panel_sonuc.Visible = true;
            sonuc.Text = "Otomatik Kullanýcý Adý ve Þifre Ýçin Ad ve Soyad Alanlarý Boþ Geçilemez !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }

        else

        {

            try
            {
                string k_adi = oto_k_adi_al(doktor_adi.Text.Trim(), doktor_soyadi.Text.Trim());
                string sifreuretilen = sifre_al(doktor_adi.Text.Trim(), doktor_soyadi.Text.Trim());
                kullanici_adi.Text = k_adi.ToString();
                sifre.Text = sifreuretilen.ToString();
                panel_sonuc.Visible =false;


                if (k_adi == "")
                {

                    panel_sonuc.Visible = true;
                    sonuc.Text = "Sistem Tarafýndan Kullanýcý Adý Türetilemedi !";
                    sonuc.ForeColor = System.Drawing.Color.Red;

                
                }


            }
            catch
            {
                kullanici_adi.Text = "";
                sifre.Text = "";

                panel_sonuc.Visible = true;
                sonuc.Text = "Otomatik Kullanýcý Adý ve Þifre Alýnýrken Hata Oluþtu !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        
        }


    }

    string oto_k_adi_al(string ad, string soyad)
    {

        try
        {



            if (kullanici_adi_kontrol(ad) == true)
            {

                return ad.Trim();

            }
            else if (kullanici_adi_kontrol(soyad) == true)
            {

                return soyad.Trim();

            }

            else if (kullanici_adi_kontrol(ad + soyad) == true)
            {

                return ad.Trim() + soyad.Trim();


            }
            else if (kullanici_adi_kontrol(ad + soyad.Substring(0, 1)) == true)
            {

                return ad.Trim() + soyad.Substring(0, 1).Trim();


            }

            else if (kullanici_adi_kontrol(soyad + ad.Substring(0, 1)) == true)
            {

                return soyad.Trim() + ad.Substring(0, 1).Trim();

            }

           
                      else
            {
                return "";

            }

        }
        catch
        {

            return "";
 
        
        }

    
    }

    string sifre_al(string ad, string soyad)
    {
        try
        {
            Random yenisifre = new Random();
            int uretilen = yenisifre.Next(100000, 999999);

            return uretilen.ToString();

        }
        catch
        {
            return "";

        
        }
       




    }

    bool mail_kontrol(string mailim)
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select uye_k_adi from uye_doktor where uye_email = '" + mailim.ToString() + "'", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("Select uye_k_adi from uye_hasta where uye_email = '" + mailim.ToString() + "'", ebebaba_connection);

            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);



            if (ebebaba_dt.Rows.Count == 0 && ebebaba_dt2.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;

            }


        }

        catch
        {

            return false;


        }

    }



    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {
        if (kullanici_adi_kontrol(kullanici_adi.Text) == false)
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Bu Kullanýcý Adý Baþka Bir Kullanýcýya Aittir.Kullanýlamaz !";
            sonuc.ForeColor = System.Drawing.Color.Red;



        }
        else
        {
            if (sifre.Text.Length < 6)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Þifre En Az 6 Karakterden Oluþmalýdýr !";
                sonuc.ForeColor = System.Drawing.Color.Red;


            }
            else
            {



                if (email.Text != "")
                {

                    if (mail_kontrol(email.Text) == false)
                    {

                        panel_sonuc.Visible = true;
                        sonuc.Text = "Bu Mail Adresi Sistemde Baþka Bir Kullanýcýya Aittir.Lütfen Baþka Bir Mail Adresi Deneyiniz yada Maili Boþ Geçiniz !";
                        sonuc.ForeColor = System.Drawing.Color.Red;


                    }
                    else
                    {
                        kayit_ekle();
                    }

                }
                else
                { 
                
                   kayit_ekle();
                }

             



            }
        }


    }
}
