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
public class tayfunalpercom
{
    public tayfunalpercom()
	{
	
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

            return DateTime.Now.Date.AddYears(5);

        }

    }
    public  MySqlConnection connect_ebebaba(int coming)
    {
        try
        {
            // MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=talperivf;User ID=root;Password=0301009184;charset=latin5");
            MySqlConnection connect = new MySqlConnection("DataSource= 85.159.67.248;Database=talperivf;User ID=talperivf;Password=0301009184;charset=latin5");
            return connect;
        }
        catch
        {
            return null;
        }
    }


    public MySqlConnection connect_tbc(int coming)
    {

        try
        {
            //String Way = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/new_ebebaba_db.mdb");
            //   MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=tupbebekcevaplari;User ID=root;Password=0301009184;");
            MySqlConnection connect = new MySqlConnection("DataSource= 94.73.144.235;Database=db2DC2548028;User ID=user2DC2548028;Password=TY426666ty;charset=latin5");
            return connect;

        }
        catch
        {
            return null;
        }
    }


    public MySqlConnection connect_stb(int coming)
    {
        try
        {
           //  MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=vmsamsuntupbebek;User ID=root;Password=0301009184;charset=latin5");
           MySqlConnection connect = new MySqlConnection("DataSource=94.73.146.226;Database=dbCC431937E4;User ID=userCC431937E4;Password=ZMsa35A4;charset=latin5");
            return connect;

        }
        catch
        {

            return null;
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
    //public void mailsend(string konu,string alici,string mesaj)

    //{

    //    try
    //    {

    //    MailMessage message = new MailMessage();
    //    message.IsBodyHtml = true;
    //    message.Subject = konu;
    //    message.Body = mesaj;
      

    //        message.To.Add(alici);
                      
    //        message.From = new MailAddress("EBEBABA<info@ebebaba.com>");


    //    SmtpClient server = new SmtpClient("mail.ebebaba.com");
    //    server.Credentials = new System.Net.NetworkCredential("info@ebebaba.com", "tuncay");
    //    server.Send(message);

    //    }

    //    catch
    //    {

        
    //    }
    
    //}
    public void istatistiksayfa(string IP, string sayfa, string tip)
    {
        try
        {

            if (ipkontrol(IP) == 0)
            {

                string referralUrl = "";
                string kaynaksite = "";
                string aramaKelimesi = "";
                if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_REFERER"] != null &&
                     System.Web.HttpContext.Current.Request.ServerVariables["HTTP_REFERER"].Trim() != "")
                {
                    //burada önceki sayfanýn adresini alýyoruz. 
                    referralUrl = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_REFERER"].ToLower();

                    //sayfanýn adresini parse edip sitenin adýný alýyoruz. 
                    int sIndex1 = referralUrl.IndexOf("https://");
                    int eIndex1 = referralUrl.IndexOf("/", sIndex1 + 8);
                    kaynaksite = referralUrl.Substring(sIndex1, eIndex1 - sIndex1 + 1);

                    //eðer kaynak site google ise bu sefer arama kelimesini bulabilmek için aþaðýdaki gibi parse ediyoruz. 
                    if (kaynaksite.Contains(".google."))
                    {
                        //google üzerinden gelmiþ.. googleda genelde arama kelimesi &q= ile baþlar ve bir sonraki & iþaretinde biter. Farklý alternatifler içinde kodu güncellemeniz gerekebilir. 
                        int sIndex = referralUrl.IndexOf("q=");
                        int eIndex = referralUrl.IndexOf("&", sIndex + 1);
                        aramaKelimesi = referralUrl.Substring(sIndex + 2, eIndex - sIndex - 2);
                        //google arama kelimesinde bazý özel karakterleri ayrýca temizlemeniz gerekiyor. Örneðin %20 yazan yeri boþluk %2f yazan yeri / ile deðiþtirmeniz gerekiyor. 
                        //temizleme iþini size býrakýyorum. 
                    }
                }

                if (referralUrl.IndexOf("https://www.tayfunalper.com/") > 0)
                {

                    referralUrl = "Site içinden";

                }
                else
                {
                    referralUrl = referralUrl;

                }


                MySqlConnection baglanti = connect_ebebaba(0301009184);
                MySqlCommand cmd = new MySqlCommand("Insert into istatistik(sayfa,IP,tarih,tip,ref,kaynakSite,kelime) values ('" + sayfa + "','" + IP + "','" + DateTime.Now.ToString() + "','" + tip + "','" + referralUrl + "','" + kaynaksite + "','" + aramaKelimesi + "')", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        catch
        { 
        }

    }
    public void istatistikkonu(string IP, string konuID, string bolumID)
    {
        if (ipkontrol(IP) == 0)
        {
            MySqlConnection baglanti = connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("Insert into istatistik(konuID,IP,tarih,kitapID,saat) values ('" + konuID + "','" + IP + "','" + DateTime.Now.ToShortDateString() + "'," + bolumID + ",'" + DateTime.Now.ToLongTimeString() + "')", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
    }

    public void istatistikforum(string IP, string forumID, string Forum)
    {
        if (ipkontrol(IP) == 0)
        {
            MySqlConnection baglanti = connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("Insert into istatistik(forumID,IP,tarih,kitapID,saat) values ('" + forumID + "','" + IP + "','" + DateTime.Now.ToShortDateString() + "','" + Forum + "','" + DateTime.Now.ToLongTimeString() + "')", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
    }

   public int ipkontrol(string gelen)
    {

            MySqlConnection ebebaba_connection = connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from ip_kisitlama where IP='" + gelen + "'", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);
            return ebebaba_dt.Rows.Count;
       
    }
}