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
public class forum_class
{
	public forum_class()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string adresal(int gelen)
    {

     
        string adres = "<font face = 'Tahoma' color = '#666666'><b>Prof.Dr.Tayfun ALPER</b>";
        adres = adres + "<br>" + "Adres  :Ondokuz Mayýs Üniversitesi Týp Fakültesi Kadýn Hastalýklarý ve Doðum Anabilim Dalý Baþkanlýðý Kurupelit/SAMSUN";
        adres = adres + "<br>" + "Tel    :0.362.311 1919 Dahili : 2350";
        adres = adres + "<br>" + "E-Mail :talper@omu.edu.tr</font>";
        return adres;
   
    }

    //public DateTime tarihcevir(string gelen)
    //{

    //    try
    //    {

    //    string yenitarih = "";

          
    //        if (gelen.Length == 6)
    //        {

    //            int yil2 = int.Parse("19" + gelen.Substring(4, 2));
    //                yenitarih = gelen.Substring(0, 2) + "." + gelen.Substring(2, 2) + "." + yil2.ToString();
                  
    //        }

    //        else if(gelen.Length==10)
    //       {

    //           yenitarih = gelen.ToString();
   
    //       }

    //       return DateTime.Parse(yenitarih.Substring(0,10));


    //   }

    //   catch
    //   {

    //       return DateTime.Now.Date;


       
    //   }


    //     }



    //public DateTime tarihcevir2(string gelen)
    //{

    //    try
    //    {

    //        string yenitarih = "";


    //        if (gelen.Length == 6)
    //        {

    //            int yil2 = int.Parse("20" + gelen.Substring(4, 2));
    //            yenitarih = gelen.Substring(0, 2) + "." + gelen.Substring(2, 2) + "." + yil2.ToString();

    //        }

    //        else if (gelen.Length == 10)
    //        {

    //            yenitarih = gelen.ToString();

    //        }

    //                return DateTime.Parse(yenitarih.Substring(0, 10));


    //    }

    //    catch
    //    {

    //        return DateTime.Now.Date.AddYears(5);

    //    }
        
    //}


    public  MySqlConnection connect_forum(int coming)
    {

        if(coming == 0301009184){

        //String Way = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/new_ebebaba_db.mdb");
            //MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=talperweb;User ID=root;Password=0301009184;");
            //MySqlConnection connect = new MySqlConnection("DataSource=94.73.146.242;Database=talperweb;User ID=talperwebtuncay;Password=0301009184;");
  MySqlConnection connect = new MySqlConnection("DataSource=85.159.67.253;Database=talperweb;User ID=talperweb;Password=0301009184;charset=latin5");
           //MySqlConnection connect = new MySqlConnection("DataSource=89.19.29.203;Database=ebebabaforum201;User ID=tuncayhanoglu;Password=0301009184;");
            return connect;

        }
        else
        {
        return null;

        }
        
    }

    //Bu bölümler silinecek ;

   // Bu bölüme kadar olan yerler siliecektir.Sadece eski verilerin aktarýmýnda kullanýlan veritabaný baðlantý tümceleri



    //public static DataTable resimlerial(string gelen)
    //{

    //    String Way = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/new_ebebaba_db.mdb");

    //    MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=new_ebebaba_db;User ID=root;Password=0301009184;");
        
    //    MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select resim from resimtab where album='" + gelen.ToString() + "'", connect);

    //    DataTable ebebaba_dt = new DataTable();
    //    ebebaba_da.Fill(ebebaba_dt);

    //    return ebebaba_dt;

    //}

    public string uyebilgi(string id,string kadi)
    {
        string sonuc2 = kadi;

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from forumebebabauyeler where uye_id =" + id + "", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                if (ebebaba_dt.Rows[0]["uye_adi"].ToString() != "" && ebebaba_dt.Rows[0]["uye_soyadi"].ToString() != "")
                {
                    sonuc2 = ebebaba_dt.Rows[0]["uye_adi"].ToString().ToUpper() + " " + ebebaba_dt.Rows[0]["uye_soyadi"].ToString().ToUpper(); 
                }
            }
            else
            {
                sonuc2 = "";
            }

            return sonuc2;
        }

        catch
        {
            return "";
        }

    }

    public string uyelikizin()
    {
        string sonuc = "+";

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uyelik from forum_ayar where ID =1", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            return ebebaba_dt.Rows[0]["uyelik"].ToString();
        }

        catch
        {
            return "+";
        }

    }
    public string konuizin()
    {
   

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select konu from forum_ayar where ID =1", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            return ebebaba_dt.Rows[0]["konu"].ToString();
        }

        catch
        {
            return "+";
        }

    }
    public string cevapizin()
    {
        string sonuc = "+";

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select cevap from forum_ayar where ID =1", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            return ebebaba_dt.Rows[0]["cevap"].ToString();
        }

        catch
        {
            return "+";
        }

    }

    public string durum(string email)
    {
        
        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from engelli where email = '"+email+"'", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count > 0)
            {
                return ebebaba_dt.Rows[0]["tarih"].ToString() + " Tarihinde Üyeliðine Son Verilmiþti!";
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
    public string uyebilgi(string id)
    {
        string sonuc2 = "";

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_adi,uye_soyadi,uye_kullanici_adi from forumebebabauyeler where uye_id =" + id + "", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                if (ebebaba_dt.Rows[0]["uye_adi"].ToString() != "" && ebebaba_dt.Rows[0]["uye_soyadi"].ToString() != "")
                {
                    sonuc2 = ebebaba_dt.Rows[0]["uye_adi"].ToString().ToUpper() + " " + ebebaba_dt.Rows[0]["uye_soyadi"].ToString().ToUpper();
                }
                else
                {
                    sonuc2 = ebebaba_dt.Rows[0]["uye_kullanici_adi"].ToString();
                }
            }
            else
            {
                sonuc2 = "Silinmiþ Üye";
            }

            return sonuc2;
        }

        catch
        {
            return "";
        }

    }
    public string uyeemail(string id)
    {
        string sonuc2 = "";

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_email from forumebebabauyeler where uye_id =" + id + "", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

           return ebebaba_dt.Rows[0][0].ToString();
        }

        catch
        {
            return "";
        }

    }

    public bool kullanici_adi_kontrol(string gelen)
    {
        bool sonuc = false;

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_kullanici_adi from forumebebabauyeler where uye_kullanici_adi ='" + gelen + "'", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        catch
        {
            return false;
        }

    }
    public bool eposta_kontrol(string gelen)
    {
        bool sonuc = false;

        try
        {

            MySqlConnection ebebaba_connection = connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_email from forumebebabauyeler where uye_email ='" + gelen + "'", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        catch
        {
            return false;
        }

    }

    //}

    //public string doktor_adi_bul(string uye_id)
    //{

    //    try
    //    {

    //        MySqlConnection ebebaba_connection = connect_ebebaba(0301009184);
    //        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_doktor where uye_id =" + uye_id + "", ebebaba_connection);

    //        DataTable ebebaba_dt = new DataTable();
    //        ebebaba_da.Fill(ebebaba_dt);

    //        string ad = ebebaba_dt.Rows[0]["uye_adi"].ToString() + " " + ebebaba_dt.Rows[0]["uye_soyadi"].ToString();

    //        return ad;
    //    }

    //    catch
    //    {


    //        return "";

    //    }


    //}

    //public string doktor_id_bul(string uye_k_adi)
    //{

    //    try
    //    {

    //        MySqlConnection ebebaba_connection = connect_ebebaba(0301009184);
    //        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_id,uye_adi,uye_soyadi from uye_doktor where uye_k_adi ='" + uye_k_adi + "'", ebebaba_connection);

    //        DataTable ebebaba_dt = new DataTable();
    //        ebebaba_da.Fill(ebebaba_dt);
    //        string ad = ebebaba_dt.Rows[0]["uye_id"].ToString(); 
    //        return ad;
    //    }

    //    catch
    //    {


    //        return "";

    //    }


    //}
    //public string hasta_kullanici_adi_bul(string uye_k_adi)
    //{

    //    try
    //    {


    //        MySqlConnection ebebaba_connection = connect_ebebaba(0301009184);
    //        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_hasta where uye_k_adi ='" + uye_k_adi + "'", ebebaba_connection);

    //        DataTable ebebaba_dt = new DataTable();
    //        ebebaba_da.Fill(ebebaba_dt);
    //        string ad = ebebaba_dt.Rows[0]["uye_adi"].ToString() + " " + ebebaba_dt.Rows[0]["uye_soyadi"].ToString();

    //        return ad;
    //    }

    //    catch
    //    {


    //        return "";

    //    }


    //}


    //public string hasta_kullanici_adi_bul2(string uye_id)
    //{

    //    try
    //    {


    //        MySqlConnection ebebaba_connection = connect_ebebaba(0301009184);
    //        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_adi,uye_soyadi,uye_k_adi from uye_hasta where uye_id =" + uye_id + "", ebebaba_connection);

    //        DataTable ebebaba_dt = new DataTable();
    //        ebebaba_da.Fill(ebebaba_dt);
    //        string ad = ebebaba_dt.Rows[0]["uye_k_adi"].ToString();

    //        return ad;
    //    }

    //    catch
    //    {


    //        return "";

    //    }


    //}
    //public string hasta_adi_bul(string uye_id)
    //{

    //    try
    //    {


    //        MySqlConnection ebebaba_connection = connect_ebebaba(0301009184);
    //        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_adi,uye_soyadi from uye_hasta where uye_id =" + uye_id + "", ebebaba_connection);

    //        DataTable ebebaba_dt = new DataTable();
    //        ebebaba_da.Fill(ebebaba_dt);
    //        string ad = ebebaba_dt.Rows[0]["uye_adi"].ToString() + " " + ebebaba_dt.Rows[0]["uye_soyadi"].ToString();

    //        return ad;
    //    }

    //    catch
    //    {


    //        return "";

    //    }


    //}

    //public string ayadi(int gelen)
    //{

    //    string donen = "";

    //    if (gelen == 1)
    //    {
    //        donen = "Ocak";
    //    }
    //    if (gelen == 2)
    //    {
    //        donen = "Þubat";
    //    }
    //    if (gelen == 3)
    //    {
    //        donen = "Mart";
    //    }
    //    if (gelen == 4)
    //    {
    //        donen = "Nisan";
    //    }
    //    if (gelen == 5)
    //    {
    //        donen = "Mayýs";
    //    }
    //    if (gelen == 6)
    //    {
    //        donen = "Haziran";
    //    }
    //    if (gelen == 7)
    //    {
    //        donen = "Temmuz";
    //    }
    //    if (gelen == 8)
    //    {
    //        donen = "Aðustos";
    //    }
    //    if (gelen == 9)
    //    {
    //        donen = "Eylül";
    //    }
    //    if (gelen == 10)
    //    {
    //        donen = "Ekim";
    //    }
    //    if (gelen == 11)
    //    {
    //        donen = "Kasým";
    //    }
    //    if (gelen == 12)
    //    {
    //        donen = "Aralýk";
    //    }

    //    return donen;


    //}







   


    public void mailsend(string konu,string alici,string mesaj)

    {

        try
        {

        MailMessage message = new MailMessage();
        message.IsBodyHtml = true;
        message.Subject = konu;
        message.Body = mesaj;
        message.To.Add(alici);                 
        message.From = new MailAddress("Prof.Dr.Tayfun ALPER - FORUM<bilgi@tayfunalper.com>");
        SmtpClient server = new SmtpClient("mail.tayfunalper.com");
        server.Credentials = new System.Net.NetworkCredential("bilgi@tayfunalper.com","Ta5856068");
        server.Send(message);
        
        }
        catch
        {

        
        }
    
    }



}
