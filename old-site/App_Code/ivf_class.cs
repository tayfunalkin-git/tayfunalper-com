using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
using System.Net.Mail;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;


/// <summary>
/// Summary description for gelisim_student_class
/// </summary>
public class ivf_class
{
	public ivf_class()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public string adresal(int gelen)
    {


        string adres = "<font face = 'Arial' color = '#666666'><b>Ebebaba Özel Saðlýk Hizmetleri Tic.Ltd.Þti</b>";
        adres = adres + "<br>" + "Adres  :Ýstiklal Caddesi No : 35   SAMSUN";
        adres = adres + "<br>" + "Tel    :0.362.431 8000";
        adres = adres + "<br>" + "Fax    :0.362.435 5155";
        adres = adres + "<br>" + "E-Mail :info@ebebaba.com - talper@omu.edu.tr</font>";


        return adres;



    }

    public void mailsend(string konu, string alici, string mesaj)
    {

        try
        {
            mesaj += "<hr> <br> Prof.Dr. Tayfun ALPER <br>Ondokuz Mayýs Üniversitesi (Samsun) <br> Týp Fakültesi, Kadýn Hastalýklarý ve Doðum Anabilim Dalý Öðretim Üyesi<br>";
            mesaj += "Baþvuru-Randevu için  : 0 362 437 19 88 - Medical Park Tüp Bebek Merkezi<br>";
            mesaj += "Medical Park Samsun Adres : Mimar Sinan Mah. Alparslan Bulvarý, No: 17 Atakum Samsun<br>";
            mesaj += "Medical Park Samsun Tel : 0 (362) 311 40 40"; 


            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.Subject = konu;
            message.Body = mesaj;
            message.To.Add(alici);
            message.From = new MailAddress("TÜP BEBEK MERKEZÝ<info@ebebaba.com>");


            SmtpClient server = new SmtpClient("mail.ebebaba.com");
            server.Credentials = new System.Net.NetworkCredential("info@ebebaba.com", "tuncay");
            server.Send(message);

        }

        catch
        {


        }

    }
    public MySqlConnection connect_ivf(int coming)
    {

        //try
        // {

        //MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=ivfdb;User ID=root;Password=0301009184;convert zero datetime=True");
        MySqlConnection connect = new MySqlConnection("DataSource=85.159.67.232;Database=ivfdb;User ID=ivfdb;Password=0301009184;charset=latin5");

        return connect;
        //        }
        //        catch
        //{
        //   return null;
        // }

    }


    public MySqlConnection connect_flry(int coming)
    {
        //try
        // {

        MySqlConnection connect = new MySqlConnection("DataSource=94.73.150.121;Database=FLORYAdbB5043B;User ID=userB5043B;Password=EInt63E8;charset=latin5;convert zero datetime=True");

        return connect;
        //        }
        //        catch
        //{
        //   return null;
        // }

    }
    public MySqlConnection connect_pendik(int coming)
    {
        //try
        // {

        MySqlConnection connect = new MySqlConnection("DataSource=94.73.150.121;Database=u6529584_pendik;User ID=u6529584_userEE4;Password=GVfp66V8;charset=latin5;convert zero datetime=True");
        // MySqlConnection connect = new MySqlConnection("DataSource=85.159.67.232;Database=ivfdb;User ID=ivfdb;Password=0301009184;charset=latin5");

        return connect;
        //        }
        //        catch
        //{
        //   return null;
        // }

    }


    public MySqlConnection connect_ebebaba(int coming)
    {

        try
        {

            //MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=new_ebebaba_db;User ID=root;Password=0301009184;");
            //MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=new_ebebaba_db;User ID=root;Password=0301009184;");
            MySqlConnection connect = new MySqlConnection("DataSource=89.19.29.203;Database=new_ebebaba_db;User ID=talpertuncay;Password=0301009184;");

            return connect;
        }

        catch
        {
            return null;
        }

    }

    public MySqlConnection connect_tupbebek(int coming)
    {

        try
        {

            // MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=new_ebebaba_db;User ID=root;Password=0301009184;");
            //MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=omu_tup_bebek;User ID=root;Password=0301009184;");
            MySqlConnection connect = new MySqlConnection("DataSource=89.19.29.203;Database=omu_tup_bebek;User ID=omu_tup_bebek;Password=0301009184;");

            return connect;
        }

        catch
        {
            return null;
        }

    }


    public string doktor_adi_bul_uzak(string uye_id)
    {

        try
        {

            MySqlConnection mp_connection = connect_ebebaba(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_doktor where uye_id =" + uye_id + "", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            string ad = mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString();

            return ad;
        }

        catch
        {


            return "";

        }


    }

    public MySqlConnection connect_senk(int coming)
    {

        try
        {
            MySqlConnection connect = new MySqlConnection("DataSource=89.19.29.203;Database=senkranizasyon;User ID=ebebaba;Password=0301009184;");

            //MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=senkranizasyon;User ID=root;Password=0301009184;");
            //MySqlConnection connect = new MySqlConnection("DataSource=89.19.29.203;Database=tupbebek;User ID=tuncay;Password=tuncay;");

            return connect;
        }

        catch
        {
            return null;
        }

    }

    public DateTime tarihcevir(string gelen)
    {

        try
        {

        string yenitarih = "";

          
            if (gelen.Length == 6)
            {

                int yil2 = int.Parse("19" + gelen.Substring(4, 2));
                    yenitarih = gelen.Substring(0, 2) + "." + gelen.Substring(2, 2) + "." + yil2.ToString();
                  
            }

            else if(gelen.Length==10)
           {

               yenitarih = gelen.ToString();
   
           }

           return DateTime.Parse(yenitarih.Substring(0,10));


       }

       catch
       {

           return DateTime.Now.Date;


       
       }


         }
    public DateTime tarihcevir2(string gelen)
    {

        try
        {

            string yenitarih = "";


            if (gelen.Length == 6)
            {

                int yil2 = int.Parse("20" + gelen.Substring(4, 2));
                yenitarih = gelen.Substring(0, 2) + "." + gelen.Substring(2, 2) + "." + yil2.ToString();

            }

            else if (gelen.Length == 10)
            {

                yenitarih = gelen.ToString();

            }

                    return DateTime.Parse(yenitarih.Substring(0, 10));


        }

        catch
        {

            return DateTime.Now.Date;

        }
        
    }



    public string yeniTarih(string p)
    {
        string gun = "";
        string ay = "";
        string yil = "";
        string tarih = "";
       

        string[] dizi = p.Split('.');

        if (dizi.Length == 3)
        {
            if (dizi[0].Length == 1)
            { gun = "0" + dizi[0].ToString(); }
            else if (dizi[0].Length == 2)
            { gun = dizi[0].ToString(); }

            if (dizi[1].Length == 1)
            { ay = "0" + dizi[1].ToString(); }
            else if (dizi[1].Length == 2)
            { ay = dizi[1].ToString(); }

            yil = dizi[2].ToString();

            tarih = gun + "." + ay + "." + yil;

            return tarih;
        }
        else
        {
            return "";
        }


    }

    public string yeniTarihSaatDondur(string p)
    {

        string tarih = "";
        string zaman = "";
        string[] dizi = p.Split(' ');

        tarih = yeniTarih(dizi[0].ToString());
        zaman = dizi[1].ToString();



        return tarih + " " + zaman;

    }
 
    public void log_kaydet(string ID,string islem)
    {

        try
        {
            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlCommand mp_cmd = new MySqlCommand("insert into uye_log(uye_id,islem,tarih) values (?1,?2,?3)", mp_connection);
        mp_cmd.Parameters.AddWithValue ("?1",ID);
        mp_cmd.Parameters.AddWithValue ("?2",islem);
        mp_cmd.Parameters.AddWithValue ("?3",DateTime.Now.ToString());

            mp_connection.Open();
            int eks = mp_cmd.ExecuteNonQuery();
            mp_connection.Close();
        }
        catch
        {

        }
    }
    public string doktor_kullanici_adi_bul(string uye_k_adi)
    {

        try
        {

            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_doktor where uye_k_adi ='" + uye_k_adi + "'", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            string ad = mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString();
            return ad;
        }

        catch
        {
            return "";
        }
        
    
    }
    public string doktor_adi_bul(string uye_id)
    {

        try
        {

            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_doktor where uye_id =" + uye_id + "", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            string ad = mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString();

            return ad;
        }

        catch
        {


            return "";

        }


    }
    public string doktor_id_bul(string uye_k_adi)
    {

        try
        {

            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_id,uye_adi,uye_soyadi from uye_doktor where uye_k_adi ='" + uye_k_adi + "'", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            string ad = mp_dt.Rows[0]["uye_id"].ToString(); 
            return ad;
        }

        catch
        {


            return "";

        }



    }

    public string doktor_kullaniciadi_bul(string uye_id)
    {

        try
        {

            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_k_adi from uye_doktor where uye_id =" + uye_id + "", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            string ad = mp_dt.Rows[0]["uye_k_adi"].ToString();
            return ad;
        }

        catch
        {


            return "";

        }


    }

    public string hasta_kullanici_adi_bul(string uye_k_adi)
    {

        try
        {


            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_hasta where uye_k_adi ='" + uye_k_adi + "'", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            string ad = mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString();

            return ad;
        }

        catch
        {


            return "";

        }


    }
    public string hasta_kullanici_adi_bul2(string uye_id)
    {

        try
        {


            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_adi,uye_soyadi,uye_k_adi from uye_hasta where uye_id =" + uye_id + "", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            string ad = mp_dt.Rows[0]["uye_k_adi"].ToString();

            return ad;
        }

        catch
        {


            return "";

        }


    }
    public string hasta_adi_bul(string uye_id)
    {

        try
        {


            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_hasta where uye_id =" + uye_id + "", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            string ad = mp_dt.Rows[0]["uye_adi"].ToString() + " " + mp_dt.Rows[0]["uye_soyadi"].ToString();

            return ad;
        }

        catch
        {


            return "";

        }


    }
    public string ayadi(int gelen)
    {

        string donen = "";

        if (gelen == 1)
        {
            donen = "Ocak";
        }
        if (gelen == 2)
        {
            donen = "Þubat";
        }
        if (gelen == 3)
        {
            donen = "Mart";
        }
        if (gelen == 4)
        {
            donen = "Nisan";
        }
        if (gelen == 5)
        {
            donen = "Mayýs";
        }
        if (gelen == 6)
        {
            donen = "Haziran";
        }
        if (gelen == 7)
        {
            donen = "Temmuz";
        }
        if (gelen == 8)
        {
            donen = "Aðustos";
        }
        if (gelen == 9)
        {
            donen = "Eylül";
        }
        if (gelen == 10)
        {
            donen = "Ekim";
        }
        if (gelen == 11)
        {
            donen = "Kasým";
        }
        if (gelen == 12)
        {
            donen = "Aralýk";
        }

        return donen;


    }
    public string gunadi(string gelen)
    {

        string donen = "";

        if (gelen == "Sunday")
        {
            donen = "Pazar";
        }
        if (gelen == "Monday")
        {
            donen = "Pazartesi";
        }
        if (gelen == "Tuesday")
        {
            donen = "Salý";
        }
        if (gelen == "Wednesday")
        {
            donen = "Çarþamba";
        }
        if (gelen == "Thursday")
        {
            donen = "Perþembe";
        }
        if (gelen == "Friday")
        {
            donen = "Cuma";
        }
        if (gelen == "Saturday")
        {
            donen = "Cumartesi";
        }
       
        return donen;


    }

}
