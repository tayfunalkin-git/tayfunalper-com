using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Services;
using System.Text.RegularExpressions;
public partial class makaleGoruntule : System.Web.UI.Page
{
    tayfunalpercom mp_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            if (Request.QueryString["ID"] != null)
            {
                comID.Value = Request.QueryString["ID"].ToString();
                blogIcerikYukle(Request.QueryString["ID"].ToString());
                digerKonulariYukle();
            }
            else
            {
                comID.Value = "";
                Response.Redirect("blog.aspx");

            }


            ipNedir();

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

    protected string StripHtml(string Txt)
    {
        return Regex.Replace(Txt, "<(.|\\n)*?>", string.Empty);
    }    
    private void blogIcerikYukle(string blogID)
    {



        try
        {

            MySqlConnection mp_connection = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from blogiceriktablosu where kisaAd='" + blogID + "' and yayin='E'", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string blogicerik = "";


            if (dt.Rows.Count > 0)
            {


                

                MySqlDataAdapter da0 = new MySqlDataAdapter("Select Adi from kategorilistblog where ID=" + dt.Rows[0]["kategoriler"].ToString() + "", mp_connection);
                DataTable dt0 = new DataTable();
                da0.Fill(dt0);


                if (dt0.Rows.Count == 1)
                {
                    blogKategorisi.InnerText = dt0.Rows[0][0].ToString();
                    blogKategorisi.Visible = true;
                }


                DateTime tarih = DateTime.Parse(dt.Rows[0]["eklenmeTarihi"].ToString());
                string gun = tarih.Day.ToString();
                string ay = tarih.Month.ToString();
                if (ay == "1" || ay == "01") { ay = "Oca"; } else if (ay == "2" || ay == "02") { ay = "Şub"; } else if (ay == "3" || ay == "03") { ay = "Mar"; } else if (ay == "4" || ay == "04") { ay = "Nis"; } else if (ay == "5" || ay == "05") { ay = "May"; } else if (ay == "6" || ay == "06") { ay = "Haz"; } else if (ay == "7" || ay == "07") { ay = "Tem"; } else if (ay == "8" || ay == "08") { ay = "Ağu"; } else if (ay == "9" || ay == "09") { ay = "Eyl"; } else if (ay == "10") { ay = "Eki"; } else if (ay == "11") { ay = "Kas"; } else if (ay == "12") { ay = "Ara"; }
                string yil = tarih.Year.ToString();
                string yeniTarih = gun + " " + ay + " " + yil;

                string ozetMetni = dt.Rows[0]["icerik"].ToString();
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



                blogicerik += "<article class='post post-large blog-single-post'><div class='post-image'>";
                blogicerik += "<div><div class='d-block'><img class='img-fluid' src='http://www.samsuntupbebek.com/uploadImages/" + dt.Rows[0]["kapakResmi"].ToString() + "_520.jpg' width='100%' alt=''>";
                blogicerik += "</div></div></div>";
                blogicerik += "<div class='post-date'>";
                blogicerik += "<span class='day'>" + gun + "</span>";
                blogicerik += "<span class='month'>" + ay + "</span></div>";
                blogicerik += "<div class='post-content'>";
                blogicerik += "<div class='post-meta'><span><i class='fa fa-user'></i>" + dt.Rows[0]["yazar"].ToString() + "</span>";
                blogicerik += "</div><p>" + ozetMetni + "</p></div></article>";

                baslik.InnerText = dt.Rows[0]["baslik"].ToString();


                Page.Title = "Prof.Dr.Tayfun ALPER - " + dt.Rows[0]["baslik"].ToString();

                System.Web.UI.HtmlControls.HtmlMeta a = new System.Web.UI.HtmlControls.HtmlMeta();
                a = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("kw");
                string ek = "";
                string[] anahtarKelimeler = dt.Rows[0]["baslik"].ToString().Split(' ');
                foreach (string ic in anahtarKelimeler)
                {
                    ek += ic + ",";
                }
                a.Content = ek + "Tayfun ALPER," + dt.Rows[0]["baslik"].ToString() + ",Samsun,Omü,Ondokuz Mayıs Üniversitesi,Tayfun,ALPER,Prof.Dr.Tayfun ALPER,VM Medical Park Samsun Hastanesi,samsuntupbebek.com,IVF,Tüp Bebek,Emekli,Kadın Doğum Uzmanı,Kadın Doğum";

                System.Web.UI.HtmlControls.HtmlMeta b = new System.Web.UI.HtmlControls.HtmlMeta();
                b = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("dsc");
                string temizleme = StripHtml(ozetMetni);
                if (temizleme.Length > 158)
                {
                    b.Content = temizleme.Substring(0, 158);
                }
                else
                {
                    b.Content = temizleme;
                }
              
               
                string okunmaSayisiDiv = "";
                okunmaSayisiDiv += "<div class='counters counters-text-dark' style='float:right;'>";
                okunmaSayisiDiv += "<div class='counter appear-animation' data-appear-animation='fadeInUp' data-appear-animation-delay='300'>";
                okunmaSayisiDiv += "<i class='fa fa-user'></i>";
                okunmaSayisiDiv += "<strong data-to='" + dt.Rows[0]["hit"].ToString() + "'>0</strong>";
                okunmaSayisiDiv += "<p class='text-color-primary '>defa okundu.</p></div></div>";
                blogicerik += okunmaSayisiDiv;
                blogicerik += yorumMetniAl(dt.Rows[0]["ID"].ToString());

                okunduOlarakIsaretle(dt.Rows[0]["ID"].ToString());
        //        yorumAlani.Visible = true;

            }
            else
            {


                blogicerik += "<div class='alert alert-secondary'>";
                blogicerik += "Bu yazı şu an görüntülenemiyor. Lütfen daha sonra tekrar deneyiniz !</div>";
          //      yorumAlani.Visible = false;

            }



            icerik.InnerHtml = blogicerik;


        }
        catch
        {

            Response.Redirect("default.aspx");
        }



    }

    private void okunduOlarakIsaretle(string p)
    {
        try
        {
            string ipAdresi = ipAl();
            MySqlConnection mp_connection = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from blogokundu where blogID=" + p + " and IP='" + ipAdresi + "'", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {


                MySqlCommand cmd = new MySqlCommand("Update blogiceriktablosu set hit=hit+1 where ID=" + p + "", mp_connection);
                mp_connection.Open();
                int eks = cmd.ExecuteNonQuery();
                mp_connection.Close();

                if (eks > 0)
                {
                    MySqlCommand cmd1 = new MySqlCommand("Insert into blogokundu(IP,blogID) values ('" + ipAdresi + "'," + p + ")", mp_connection);
                    mp_connection.Open();
                    int eks1 = cmd1.ExecuteNonQuery();
                    mp_connection.Close();
                }
            }
        }
        catch
        { 
        
        }
    }

    private string yorumMetniAl(string p)
    {
        
            MySqlConnection mp_connection = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from blogyorumlaritablosu where blogID=" + p + " and onay='+' and tur='N' order by gonderimTarihi desc", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
               int toplamYorum = 0;

            string yorumIfadesi = "";

            for(int a = 0; a < dt.Rows.Count ; a++)
            {
                toplamYorum ++;

                MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from blogyorumlaritablosu where cevap=" + dt.Rows[a]["ID"].ToString() + " and onay='+' and tur='Y' order by gonderimTarihi asc", mp_connection);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
            
                if(dt2.Rows.Count > 0)
                {

                    yorumIfadesi += "<li><div class='comment'><div class='img-thumbnail d-none d-sm-block'><img class='avatar' alt='' src='img/useravatar.jpg'></div><div class='comment-block'><div class='comment-arrow'></div>";
                    yorumIfadesi += "<span class='comment-by'><strong>"+dt.Rows[a]["adiSoyadi"].ToString()+"</strong></span>";
                    yorumIfadesi += "<p>"+dt.Rows[a]["mesaji"].ToString()+"</p>";
                    yorumIfadesi += "<span class='date float-right'>" + DateTime.Parse(dt.Rows[a]["gonderimTarihi"].ToString()).ToLongDateString() + " " + DateTime.Parse(dt.Rows[a]["gonderimTarihi"].ToString()).ToLongTimeString() + "</span></div></div>";
                  
                    for(int b = 0;b < dt2.Rows.Count ; b++)
                    {
                        toplamYorum ++;  yorumIfadesi += "<ul class='comments reply'>";
                        yorumIfadesi += "<li><div class='comment'><div class='img-thumbnail d-none d-sm-block'><img class='avatar' alt='' src='img/talperavatar.jpg'></div><div class='comment-block'><div class='comment-arrow'></div>";
					        yorumIfadesi +="<span class='comment-by'><strong>"+dt2.Rows[b]["adiSoyadi"].ToString()+"</strong></span>";
                            yorumIfadesi +="<p>"+dt2.Rows[b]["mesaji"].ToString()+"</p>";
                            yorumIfadesi +="<span class='date float-right'>"+DateTime.Parse(dt2.Rows[b]["gonderimTarihi"].ToString()).ToLongDateString() + " " + DateTime.Parse(dt2.Rows[b]["gonderimTarihi"].ToString()).ToLongTimeString() +"</span>";
                            yorumIfadesi +="</div></div></li>"; yorumIfadesi += "</ul>";

                    }


                    yorumIfadesi += "</li>";
                
                }
                else
                {

                    yorumIfadesi += "<li><div class='comment'><div class='img-thumbnail d-none d-sm-block'><img class='avatar' alt='' src='img/useravatar.jpg'></div><div class='comment-block'><div class='comment-arrow'></div>";
                    yorumIfadesi += "<span class='comment-by'><strong>"+dt.Rows[a]["adiSoyadi"].ToString()+"</strong></span>";
                    yorumIfadesi += "<p>"+dt.Rows[a]["mesaji"].ToString()+"</p>";
                    yorumIfadesi += "<span class='date float-right'>" + DateTime.Parse(dt.Rows[a]["gonderimTarihi"].ToString()).ToLongDateString() + " " + DateTime.Parse(dt.Rows[a]["gonderimTarihi"].ToString()).ToLongTimeString() + "</span></div></div></li>";
            
                }
         
            }


            string donecekYorumIfadesi = "<div class='post-comments clearfix'>";
    
                donecekYorumIfadesi += "<h3 class='heading-primary'><i class='fa fa-comments'></i> Yorumlar (" + toplamYorum.ToString() + ")</h3>";

                if (toplamYorum != 0)
                {
                    donecekYorumIfadesi += "<ul class='comments'>" + yorumIfadesi + "</ul></div>";
                }
                else
                {
                    donecekYorumIfadesi += "<div class='col-lg-4 alert alert-warning alert-dismissible' role='alert'><strong>Bu yazıya henüz yorum yapılmadı.</strong></br>İlk yorumu sen yaz!</div></div>";
                }
        
                        


        
                return donecekYorumIfadesi;	
           




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




  

    void ipNedir()
    {
        string ipaddress;
        ipaddress = Context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (ipaddress == "" || ipaddress == null)
            ipaddress = Context.Request.ServerVariables["REMOTE_ADDR"];
        comIP.Value = ipaddress;
       
    }


    string ipAl()
    {
        string ipaddress;
        ipaddress = Context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (ipaddress == "" || ipaddress == null)
            ipaddress = Context.Request.ServerVariables["REMOTE_ADDR"];
       return ipaddress;

    }

   




}