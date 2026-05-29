using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class siteHaritasi : System.Web.UI.Page
{
    tayfunalpercom mp_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {
        SiteHaritasiniDondur();
    }

    private void SiteHaritasiniDondur()
    {

        StringBuilder strBuilder = new StringBuilder();

        strBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");

        strBuilder.AppendLine("<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">");



        #region AnaSayfa

        //AnaSayfamizi manuel olarak  Ekliyoruz.

        //veritabanindan çekerek olusturamayacaginiz degisken olmayan linkleri bu seklide ekleyin.

        strBuilder.AppendLine("<url>");



        strBuilder.AppendLine("<loc>");

        string makaleLink = String.Format("http://www.tayfunalper.com");

        strBuilder.AppendLine(makaleLink);

        strBuilder.AppendLine("</loc>");



        strBuilder.AppendLine("<changefreq>");

        strBuilder.AppendLine("always");

        strBuilder.AppendLine("</changefreq>");



        strBuilder.AppendLine("<priority>");

        strBuilder.AppendLine("1");

        strBuilder.AppendLine("</priority>");



        strBuilder.AppendLine("</url>");

        strBuilder.AppendLine("<url>");



        strBuilder.AppendLine("<loc>");

        string makaleLink2 = String.Format("http://www.tayfunalper.com/tup-bebek-cevaplari.aspx");

        strBuilder.AppendLine(makaleLink2);

        strBuilder.AppendLine("</loc>");



        strBuilder.AppendLine("<changefreq>");

        strBuilder.AppendLine("always");

        strBuilder.AppendLine("</changefreq>");



        strBuilder.AppendLine("<priority>");

        strBuilder.AppendLine("1");

        strBuilder.AppendLine("</priority>");



        strBuilder.AppendLine("</url>");

        #endregion



        //kategorilere gore sayfalari ekle

        #region Kategoriler

   
        MySqlConnection connect_word2 = mp_class.connect_ebebaba(0301009184);
        MySqlConnection connect_word3 = mp_class.connect_tbc(0301009184);
        // Tedavi Öncesi

        MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='1' and yayin='E'", connect_word2);
        DataTable dt = new DataTable();
        da.Fill(dt);

        for (int a = 0 ; a < dt.Rows.Count ; a++)
        {
            strBuilder.AppendLine("<url>");
            strBuilder.AppendLine("<loc>");
            //linki olusturuken & yerine &amp; kullaniyoruz. aksi takdirde hata verir.
            makaleLink = "https://www.tayfunalper.com/tup-bebek-tedavi-oncesi-"+dt.Rows[a]["kisaAd"].ToString()+".aspx";
            strBuilder.AppendLine(makaleLink);
            strBuilder.AppendLine("</loc>");
            strBuilder.AppendLine("<changefreq>");
            strBuilder.AppendLine("always");
            strBuilder.AppendLine("</changefreq>");
            strBuilder.AppendLine("</url>");
        }

        // Tedavi Süreci
        MySqlDataAdapter da0 = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='2' and yayin='E'", connect_word2);
        DataTable dt0 = new DataTable();
        da0.Fill(dt0);

        for (int a = 0; a < dt0.Rows.Count; a++)
        {
            strBuilder.AppendLine("<url>");
            strBuilder.AppendLine("<loc>");
            //linki olusturuken & yerine &amp; kullaniyoruz. aksi takdirde hata verir.
            makaleLink = "https://www.tayfunalper.com/tup-bebek-tedavi-sureci-" + dt0.Rows[a]["kisaAd"].ToString() + ".aspx";
            strBuilder.AppendLine(makaleLink);
            strBuilder.AppendLine("</loc>");
            strBuilder.AppendLine("<changefreq>");
            strBuilder.AppendLine("always");
            strBuilder.AppendLine("</changefreq>");
            strBuilder.AppendLine("</url>");
        }

        // Tedavi Süreci
        MySqlDataAdapter da1= new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='3' and yayin='E'", connect_word2);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);

        for (int a = 0; a < dt1.Rows.Count; a++)
        {
            strBuilder.AppendLine("<url>");
            strBuilder.AppendLine("<loc>");
            //linki olusturuken & yerine &amp; kullaniyoruz. aksi takdirde hata verir.
            makaleLink = "https://www.tayfunalper.com/tup-bebek-tedavi-sonrasi-" + dt1.Rows[a]["kisaAd"].ToString() + ".aspx";
            strBuilder.AppendLine(makaleLink);
            strBuilder.AppendLine("</loc>");
            strBuilder.AppendLine("<changefreq>");
            strBuilder.AppendLine("always");
            strBuilder.AppendLine("</changefreq>");
            strBuilder.AppendLine("</url>");
        }


        // Makaleler
        MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from kitap_konulari where yayin='1'", connect_word2);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        for (int a = 0; a < dt2.Rows.Count; a++)
        {
            strBuilder.AppendLine("<url>");
            strBuilder.AppendLine("<loc>");
            //linki olusturuken & yerine &amp; kullaniyoruz. aksi takdirde hata verir.
            makaleLink = "https://www.tayfunalper.com/makale-" + dt2.Rows[a]["link"].ToString() + ".aspx";
            strBuilder.AppendLine(makaleLink);
            strBuilder.AppendLine("</loc>");
            strBuilder.AppendLine("<changefreq>");
            strBuilder.AppendLine("always");
            strBuilder.AppendLine("</changefreq>");
            strBuilder.AppendLine("</url>");
        }

        // Tüp Bebek Kategorileri
        MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from kategori K where K.ID<>'145' and K.ID<>'155' and K.ID<>'151' and K.goruntu='+' order by K.sira asc", connect_word3);
        DataTable dt4 = new DataTable();
        da4.Fill(dt4);

        for (int a = 0; a < dt4.Rows.Count; a++)
        {
            strBuilder.AppendLine("<url>");
            strBuilder.AppendLine("<loc>");
            //linki olusturuken & yerine &amp; kullaniyoruz. aksi takdirde hata verir.
            makaleLink = "https://www.tayfunalper.com/tup-bebek-cevaplari-" + dt4.Rows[a]["ID"].ToString() + ".aspx";
            strBuilder.AppendLine(makaleLink);
            strBuilder.AppendLine("</loc>");
            strBuilder.AppendLine("<changefreq>");
            strBuilder.AppendLine("always");
            strBuilder.AppendLine("</changefreq>");
            strBuilder.AppendLine("</url>");
        }


          // Blog
        //MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from blogiceriktablosu where yayin='E' order by eklenmeTarihi desc", connect_word);
        //DataTable dt5 = new DataTable();
        //da5.Fill(dt5);

        //for (int a = 0; a < dt5.Rows.Count; a++)
        //{
        //    strBuilder.AppendLine("<url>");
        //    strBuilder.AppendLine("<loc>");
        //    //linki olusturuken & yerine &amp; kullaniyoruz. aksi takdirde hata verir.
        //    makaleLink = "https://www.tayfunalper.com/blog-icerik-" + dt5.Rows[a]["kisaAd"].ToString() + ".aspx";
        //    strBuilder.AppendLine(makaleLink);
        //    strBuilder.AppendLine("</loc>");
        //    strBuilder.AppendLine("<changefreq>");
        //    strBuilder.AppendLine("always");
        //    strBuilder.AppendLine("</changefreq>");
        //    strBuilder.AppendLine("</url>");
        //}






        



        #endregion
        strBuilder.AppendLine("</urlset>");
        Response.ContentType = "text/xml";
        Response.Write(strBuilder.ToString());
        Response.End();
    }
}