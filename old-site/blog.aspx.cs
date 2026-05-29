using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class makaleGoruntule : System.Web.UI.Page
{
    tayfunalpercom mp_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

            digerKonulariYukle();

            string gelenKategoriID = "";
            if (Request.QueryString["ID"] != null)
            {
                gelenKategoriID = Request.QueryString["ID"].ToString();
            }
            blogYukle(gelenKategoriID);

            tedaviOncesiYukle();
            tedaviSureciYukle();
           
        }


    }

  

    private void tedaviOncesiYukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='1' and yayin='E' order by RAND() LIMIT 0,3", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string eklenecekifade = "";
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                eklenecekifade += "<li><div class='post-image'><div class='img-thumbnail d-block'>";
                eklenecekifade += "<a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'><img src='http://www.samsuntupbebek.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' width='50' alt=''>";
                eklenecekifade += "</a></div></div><div class='post-info'><a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a>";
                eklenecekifade += "</div></li>";
            }
            tedaviOncesiIcerik.InnerHtml = eklenecekifade;
        }
        catch
        {

        }
    }

    private void tedaviSureciYukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='2' and yayin='E' order by RAND() LIMIT 0,3", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string eklenecekifade = "";
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                eklenecekifade += "<li><div class='post-image'><div class='img-thumbnail d-block'>";
                eklenecekifade += "<a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'><img src='http://www.samsuntupbebek.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' width='50' alt=''>";
                eklenecekifade += "</a></div></div><div class='post-info'><a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a>";
                eklenecekifade += "</div></li>";
            }
            tedaviSureciIcerik.InnerHtml = eklenecekifade;
        }
        catch
        {

        }
    }


    private void digerKonulariYukle()
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select *,(Select count(*) from blogiceriktablosu where kategoriler=B.ID) as sayi from kategorilistblog B where B.goruntu='+' order by B.sira asc", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ekKategori = "";

            for (int a = 0; a < dt.Rows.Count; a++)
            {

                ekKategori += "<li class='nav-item'><a class='nav-link active' href='blog-kategorileri-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["Adi"].ToString() + " (" + dt.Rows[a]["sayi"].ToString() + ")</a></li>";
               
            }

            kategoridekiDigerBasliklar.InnerHtml = ekKategori;


        }
        catch
        {

            Response.Redirect("Default.aspx");


        }



    }


    private void blogYukle(string kategoriID)
    {
 
        MySqlConnection mp_connection = mp_class.connect_stb(0301009184);
        
        string ek = "";

        if (kategoriID != "")
        {
            MySqlDataAdapter da0 = new MySqlDataAdapter("Select ID,Adi from kategorilistblog where kisaAd='"+kategoriID+"'", mp_connection);
            DataTable dt0 = new DataTable();
            da0.Fill(dt0);

            if (dt0.Rows.Count == 1)
            {
                ek = " and kategoriler = '" + dt0.Rows[0][0].ToString() + "' ";
              //  blogKategorisi.Visible = true;
             //   blogKategorisi.InnerText = dt0.Rows[0][1].ToString();
                baslik.InnerText = dt0.Rows[0][1].ToString();
            }
            else
            {
                ek = "";
                blogKategorisi.Visible = false;
                blogKategorisi.InnerText = "";
                baslik.InnerText = "Blog";

            }
        }

       
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from blogiceriktablosu where yayin='E' "+ek+"  order by eklenmeTarihi desc", mp_connection);
        DataTable dt = new DataTable();
        da.Fill(dt);

        string blogicerik = "";


        if (dt.Rows.Count > 0)
        {
            for (int a = 0; a < dt.Rows.Count; a++)
            {

                DateTime tarih = DateTime.Parse(dt.Rows[a]["eklenmeTarihi"].ToString());
                string gun = tarih.Day.ToString();
                string ay = tarih.Month.ToString();
                if (ay == "1" || ay == "01") { ay = "Oca"; } else if (ay == "2" || ay == "02") { ay = "Şub"; } else if (ay == "3" || ay == "03") { ay = "Mar"; } else if (ay == "4" || ay == "04") { ay = "Nis"; } else if (ay == "5" || ay == "05") { ay = "May"; } else if (ay == "6" || ay == "06") { ay = "Haz"; } else if (ay == "7" || ay == "07") { ay = "Tem"; } else if (ay == "8" || ay == "08") { ay = "Ağu"; } else if (ay == "9" || ay == "09") { ay = "Eyl"; } else if (ay == "10") { ay = "Eki"; } else if (ay == "11") { ay = "Kas"; } else if (ay == "12") { ay = "Ara"; }
                string yil = tarih.Year.ToString();
                string yeniTarih = gun + " " + ay + " " + yil;

                string ozetMetni = dt.Rows[a]["ozet"].ToString();
                ozetMetni = ozetMetni.Replace("<p>", "");
                ozetMetni = ozetMetni.Replace("<span id=\"sceditor-end-marker\" class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\"> </span>", "");
                ozetMetni = ozetMetni.Replace("<span id=\"sceditor-start-marker\" class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\"> </span>", "");
                ozetMetni = ozetMetni.Replace("<span class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\" id=\"sceditor-end-marker\"> </span>", "");
                ozetMetni = ozetMetni.Replace("<span class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\" id=\"sceditor-start-marker\"> </span>", "");
                ozetMetni = ozetMetni.Replace("<p style=\"text-align: justify;\">", "");
                ozetMetni = ozetMetni.Replace("<div style=\"text-align: justify;\">", "");
                ozetMetni = ozetMetni.Replace("<div style=\"text-align: center;\">", "");
                ozetMetni = ozetMetni.Replace("<p style=\"\" class=\"\">", "");
                ozetMetni = ozetMetni.Replace("&emsp;", "");
                ozetMetni = ozetMetni.Replace("<div align=\"justify\">", "");
                ozetMetni = ozetMetni.Replace("<p style=\"text-align: justify; \" class=\"\">", "");
                ozetMetni = ozetMetni.Replace("<p align=\"justify\">", "");
                ozetMetni = ozetMetni.Replace("<div align=\"center\">", "");
                ozetMetni = ozetMetni.Replace("<div align=\"left\">", "");
                ozetMetni = ozetMetni.Replace("<p align=\"center\">", "");
                ozetMetni = ozetMetni.Replace("<p style=\"text-align: center;\">", "");
                ozetMetni = ozetMetni.Replace("<p class=\"MsoNormal\">", "");
                ozetMetni = ozetMetni.Replace("</span>", "");
                ozetMetni = ozetMetni.Replace("</p>", "</br>");
                ozetMetni = ozetMetni.Replace("</br><br></br>", "</br></br>");
                ozetMetni = ozetMetni.Replace("<br><br><br>", "</br></br>");
                ozetMetni = ozetMetni.Replace("<br></br></br>", "</br></br>");
                ozetMetni = ozetMetni.Replace("</br></br></br>", "</br></br>");
                ozetMetni = ozetMetni.Replace("<i><br></i>", "");
                ozetMetni = ozetMetni.Replace("<i><b><br></b></i>", "");
                ozetMetni = ozetMetni.Replace("<b><b><br></b></b>", "");
                ozetMetni = ozetMetni.Replace("<b><br></b>", "");
                ozetMetni = ozetMetni.Replace("<br></br>", "<br>");


                blogicerik += "<article class='post post-medium'>";
                blogicerik += "<div class='row'><div class='col-lg-5'><div class='post-image'>";
                //blogicerik += "<div class='owl-carousel owl-theme' data-plugin-options='{'items':1}'>";
                blogicerik += "<div><div class='d-block'><img class='img-fluid' src='http://www.samsuntupbebek.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_520.jpg' alt=''/>";
                blogicerik += "</div></div></div></div><div class='col-lg-7'><div class='post-content'>";
                blogicerik += "<h2><a href='blog-icerik-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a></h2>";
                blogicerik += "<p>" + ozetMetni + "</p></div></div></div><div class='row'><div class='col'>";
                blogicerik += "<div class='post-meta'><span><i class='fa fa-calendar'></i> " + yeniTarih + " </span>";
                blogicerik += "<span><i class='fa fa-user'></i>" + dt.Rows[a]["yazar"].ToString() + "</span>";
                blogicerik += "<span class='d-block d-md-inline-block float-md-right mt-3 mt-md-0'><a href='blog-icerik-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx' class='btn btn-xs btn-primary'>Devamını Oku ...</a></span>";
                blogicerik += "</div></div></div></article>";





            }
        }
        else
        {


            blogicerik += "<div class='alert alert-secondary'>";
               blogicerik += "Seçilen kategoride blog yazısı bulunmamaktadır !</div>";


        }

       

        icerik.InnerHtml = blogicerik;






    }




















       




    //private void digerKonulariYukle()
    //{

    //    try
    //    {

    //        string ilkKonuID = "";


    //        MySqlConnection connect_word = ebebaba_class.connect_stb(0301009184);
    //        MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviturleri order by ID asc", connect_word);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);

    //        string ekKategori = "";

    //        for (int a = 0; a < dt.Rows.Count; a++)
    //        {
    //            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur=" + dt.Rows[a][0].ToString() + " and yayin='E' order by sira asc", connect_word);
    //            DataTable dt2 = new DataTable();
    //            da2.Fill(dt2);

    //            if (dt2.Rows.Count > 0)
    //            {
    //                if (dt.Rows[a][0].ToString() == "1")
    //                {

    //                    ilkKonuID = dt2.Rows[0]["kisaAd"].ToString(); // Tedavi Öncesi Sayfası olduğu için 1 e aldım

    //                    ekKategori += "<li class='nav-item'><a class='nav-link active' href='tup-bebek-tedavi-oncesi.aspx'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";

    //                    for (int b = 0; b < dt2.Rows.Count; b++)
    //                    {
    //                        ekKategori += "<li class='nav-item'><a class='nav-link' href='tup-bebek-tedavi-oncesi-" + dt2.Rows[b]["kisaAd"].ToString() + ".aspx'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
    //                    }
    //                    ekKategori += "</ul></li>";

    //                }
    //                else if (dt.Rows[a][0].ToString() == "2")
    //                {
    //                    ekKategori += "<li class='nav-item'><a class='nav-link active' href='tup-bebek-tedavi-sureci.aspx'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";
    //                    for (int b = 0; b < dt2.Rows.Count; b++)
    //                    {
    //                        ekKategori += "<li class='nav-item'><a class='nav-link' href='tup-bebek-tedavi-sureci-" + dt2.Rows[b]["kisaAd"].ToString() + ".aspx'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
    //                    }
    //                    ekKategori += "</ul></li>";

    //                }
    //                else if (dt.Rows[a][0].ToString() == "3")
    //                {
    //                    ekKategori += "<li class='nav-item'><a class='nav-link active' href='tup-bebek-tedavi-sonrasi.aspx'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";
    //                    for (int b = 0; b < dt2.Rows.Count; b++)
    //                    {
    //                        ekKategori += "<li class='nav-item'><a class='nav-link' href='tup-bebek-tedavi-sonrasi-" + dt2.Rows[b]["kisaAd"].ToString() + ".aspx'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
    //                    }
    //                    ekKategori += "</ul></li>";

    //                }
    //                else
    //                {
    //                    ekKategori += "<li class='nav-item'><a class='nav-link active' href='#'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";
    //                    for (int b = 0; b < dt2.Rows.Count; b++)
    //                    {
    //                        ekKategori += "<li class='nav-item'><a class='nav-link' href='#'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
    //                    }
    //                    ekKategori += "</ul></li>";
    //                }





    //            }
    //            //if (acikID == dt.Rows[a]["konu_id"].ToString())
    //            //{
    //            //    ekKategori += "<li class='nav-item'><a class='nav-link active' href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx'>" + dt.Rows[a]["konu"].ToString() + "</a></li>";
    //            //}
    //            //else
    //            //{
    //            //    ekKategori += "<li class='nav-item'><a class='nav-link' href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx'>" + dt.Rows[a]["konu"].ToString() + "</a></li>";
    //            //}
    //        }

    //        kategoridekiDigerBasliklar.InnerHtml = ekKategori;


    //        if (Request.QueryString["ID"] == null)
    //        {

    //            konuYukle(ilkKonuID);


    //        }
    //        else
    //        {
    //            konuYukle(Request.QueryString["ID"].ToString());

    //        }

    //    }
    //    catch
    //    {
    //        Response.Redirect("Default.aspx");
        
    //    }

    //}


    //void konuYukle(string ID)
    //{
    //    try
    //    {

    //        MySqlConnection connect_word = ebebaba_class.connect_stb(0301009184);
    //        MySqlDataAdapter da_kitap = new MySqlDataAdapter("Select * from tedaviiceriktablosu where kisaAd='" + ID + "'", connect_word);
    //        DataTable dt_kitap = new DataTable();
    //        da_kitap.Fill(dt_kitap);

    //        if (dt_kitap.Rows.Count != 0)
    //        {

    //            baslik.InnerText = dt_kitap.Rows[0]["baslik"].ToString();
    //            string icerikMetni = "<img src='http://www.samsuntupbebek.com/uploadImages/" + dt_kitap.Rows[0]["kapakResmi"].ToString() + "_500.jpg'/></br></br>";
    //            icerikMetni += dt_kitap.Rows[0]["icerik"].ToString();

    //            if (dt_kitap.Rows[0]["biliyor"].ToString() != "")
    //            {
    //                icerikMetni += "<hr class='tall'><h4>Bunu biliyor muydunuz?</h4><div class='row'><div class='col-lg-12'><blockquote class='blockquote-primary'><p>"+dt_kitap.Rows[0]["biliyor"].ToString()+"</p></blockquote></div></div>";
    //            }

    //            icerikMetni = icerikMetni.Replace("<span id=\"sceditor-end-marker\" class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\"> </span>", "");
    //            icerikMetni = icerikMetni.Replace("<span id=\"sceditor-start-marker\" class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\"> </span>", "");
    //            icerikMetni = icerikMetni.Replace("<span class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\" id=\"sceditor-end-marker\"> </span>", "");
    //            icerikMetni = icerikMetni.Replace("<span class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\" id=\"sceditor-start-marker\"> </span>", "");
    //            icerikMetni = icerikMetni.Replace("<p style=\"text-align: justify;\">", "");
    //            icerikMetni = icerikMetni.Replace("<div style=\"text-align: justify;\">", "");
    //            icerikMetni = icerikMetni.Replace("<div style=\"text-align: center;\">", "");
    //            icerikMetni = icerikMetni.Replace("<p style=\"\" class=\"\">", "");
    //            icerikMetni = icerikMetni.Replace("&emsp;", "");
    //            icerikMetni = icerikMetni.Replace("<div align=\"justify\">", "");
    //            icerikMetni = icerikMetni.Replace("<p style=\"text-align: justify; \" class=\"\">", "");
    //            icerikMetni = icerikMetni.Replace("<p align=\"justify\">", "");
    //            icerikMetni = icerikMetni.Replace("<div align=\"center\">", "");
    //            icerikMetni = icerikMetni.Replace("<div align=\"left\">", "");
    //            icerikMetni = icerikMetni.Replace("<p align=\"center\">", "");
    //            icerikMetni = icerikMetni.Replace("<p style=\"text-align: center;\">", "");
    //            icerikMetni = icerikMetni.Replace("<p class=\"MsoNormal\">", "");
    //            icerikMetni = icerikMetni.Replace("</span>", "");
    //            icerikMetni = icerikMetni.Replace("</p>", "</br>");
    //            icerikMetni = icerikMetni.Replace("</br><br></br>", "</br></br>");
    //            icerikMetni = icerikMetni.Replace("<br><br><br>", "</br></br>");
    //            icerikMetni = icerikMetni.Replace("<br></br></br>", "</br></br>");
    //            icerikMetni = icerikMetni.Replace("</br></br></br>", "</br></br>");
    //            icerikMetni = icerikMetni.Replace("<i><br></i>", "");
    //            icerikMetni = icerikMetni.Replace("<i><b><br></b></i>", "");
    //            icerikMetni = icerikMetni.Replace("<b><b><br></b></b>", "");
    //            icerikMetni = icerikMetni.Replace("<b><br></b>", "");
    //            icerikMetni = icerikMetni.Replace("<br></br>", "<br>");



              
    //            icerik.InnerHtml = icerikMetni;

    //        }

    //        else
    //        {
    //            Response.Redirect("Default.aspx");
    //        }


    //    }
    //    catch
    //    {
    //        Response.Redirect("Default.aspx");
    //    }

    //}

  
}