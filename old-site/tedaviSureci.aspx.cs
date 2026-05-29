using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class makaleGoruntule : System.Web.UI.Page
{
    tayfunalpercom ebebaba_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            digerKonulariYukle();
            //konu_yukle();
            ////comIPMakale.Value = ipAl();
            //tedaviSureciYukle();
            //tedaviOncesiYukle();
            try
            {
                siralamaYukle();
            }
            catch
            {

            }
        }
    }

    private void siralamaYukle()
    {
        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
        MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from tedaviiceriktablosu where yayin='E' order by tur asc,sira asc", connect_word);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        DataTable dtm = new DataTable();
        DataColumn dcm = new DataColumn("link");
        DataColumn dcm1 = new DataColumn("sira");
        dtm.Columns.Add(dcm);
        dtm.Columns.Add(dcm1);

        int sira = 0;
        for (int a = 0; a < dt2.Rows.Count; a++)
        {
            DataRow dr = dtm.NewRow();
            if (dt2.Rows[a]["tur"].ToString() == "1")
            {
                dr[0] = "tup-bebek-tedavi-oncesi-" + dt2.Rows[a]["kisaAd"].ToString() + ".aspx";
            }
            else if (dt2.Rows[a]["tur"].ToString() == "2")
            {
                dr[0] = "tup-bebek-tedavi-sureci-" + dt2.Rows[a]["kisaAd"].ToString() + ".aspx";
            }
            else if (dt2.Rows[a]["tur"].ToString() == "3")
            {
                dr[0] = "tup-bebek-tedavi-sonrasi-" + dt2.Rows[a]["kisaAd"].ToString() + ".aspx";
            }

            dr[1] = sira;
            sira++;
            dtm.Rows.Add(dr);

        }

        if (Request.QueryString["ID"] != null)
        {
            DataRow[] devamsatiri = dtm.Select("link='tup-bebek-tedavi-sureci-" + Request.QueryString["ID"].ToString() + ".aspx'");
            DataTable devamdt = dtm.Copy();
            devamdt.Clear();

            foreach (DataRow yeni in devamsatiri)
            {
                devamdt.ImportRow(yeni);
            }




            if (devamdt.Rows.Count == 1)
            {

                int siram = int.Parse(devamdt.Rows[0]["sira"].ToString());
                int ust = siram + 1;
                int alt = siram - 1;


                try
                {
                    if (dtm.Rows[alt] != null)
                    {
                        lblGeri.Text = "<a href='" + dtm.Rows[alt]["link"].ToString() + "' class='btn align-left-sm' style='width:125px;'>&nbsp;< Geri</a>";

                    }

                }
                catch
                {

                }






                try
                {

                    if (dtm.Rows[ust] != null)
                    {
                        lblIleri.Text = "<a href='" + dtm.Rows[ust]["link"].ToString() + "' class='btn align-right-sm' style='width:125px;'>İleri >&nbsp;</a>";

                    }

                }
                catch
                {

                }

            }
        }
        else
        {

            int ust = 1;

            try
            {

                if (dtm.Rows[ust] != null)
                {
                    lblIleri.Text = "<a href='" + dtm.Rows[ust]["link"].ToString() + "' class='btn align-right-sm' style='width:125px;'>İleri >&nbsp;</a>";

                }

            }
            catch
            {

            }
        }








    }


    //private void tedaviOncesiYukle()
    //{
    //    try
    //    {
    //        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
    //        MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='1' and yayin='E' order by RAND() LIMIT 0,3", connect_word);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);
    //        string eklenecekifade = "";
    //        for (int a = 0; a < dt.Rows.Count; a++)
    //        {

    //            eklenecekifade += "<li style='text-transform:none;'>";
    //            eklenecekifade += "<a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>";
    //            eklenecekifade += "<img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' alt='' />";
    //            //eklenecekifade += "<span>February 12, 2020</span>";
    //            eklenecekifade += dt.Rows[a]["baslik"].ToString();
    //            eklenecekifade += "</a>";
    //            eklenecekifade += "</li>";



    //            //eklenecekifade += "<li><div class='post-image'><div class='img-thumbnail d-block'>";
    //            //eklenecekifade += "<a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'><img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' width='50' alt=''>";
    //            //eklenecekifade += "</a></div></div><div class='post-info'><a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a>";
    //            //eklenecekifade += "</div></li>";
    //        }
    //        tedaviOncesiIcerik.InnerHtml = eklenecekifade;
    //    }
    //    catch
    //    {

    //    }
    //}

    //private void tedaviSureciYukle()
    //{
    //    try
    //    {
    //        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
    //        MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='2' and yayin='E' order by RAND() LIMIT 0,3", connect_word);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);
    //        string eklenecekifade = "";
    //        for (int a = 0; a < dt.Rows.Count; a++)
    //        {

    //            eklenecekifade += "<li style='text-transform:none;'>";
    //            eklenecekifade += "<a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>";
    //            eklenecekifade += "<img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' alt='' />";
    //            //eklenecekifade += "<span>February 12, 2020</span>";
    //            eklenecekifade += dt.Rows[a]["baslik"].ToString();
    //            eklenecekifade += "</a>";
    //            eklenecekifade += "</li>";

    //            //eklenecekifade += "<li><div class='post-image'><div class='img-thumbnail d-block'>";
    //            //eklenecekifade += "<a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'><img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' width='50' alt=''>";
    //            //eklenecekifade += "</a></div></div><div class='post-info'><a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a>";
    //            //eklenecekifade += "</div></li>";
    //        }
    //        tedaviSureciIcerik.InnerHtml = eklenecekifade;
    //    }
    //    catch
    //    {

    //    }
    //}

    private void digerKonulariYukle()
    {

        try
        {

            string ilkKonuID = "";


            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviturleri order by ID asc", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string ekKategori = "<ul>";

            for (int a = 0; a < dt.Rows.Count; a++)
            {
                MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur=" + dt.Rows[a][0].ToString() + " and yayin='E' order by sira asc", connect_word);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    if (dt.Rows[a][0].ToString() == "1")
                    {

                       // ilkKonuID = dt2.Rows[0]["kisaAd"].ToString(); // Tedavi Öncesi Sayfası olduğu için 1 e aldım

                        ekKategori += "<li style='text-transform:none;'><a style='text-transform:none;' href='tup-bebek-tedavi-oncesi.aspx'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";

                        for (int b = 0; b < dt2.Rows.Count; b++)
                        {
                            ekKategori += "<li style='text-transform:none;'><a style='text-transform:none;' href='tup-bebek-tedavi-oncesi-" + dt2.Rows[b]["kisaAd"].ToString() + ".aspx'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
                        }
                        ekKategori += "</ul></li>";

                    }
                    else if (dt.Rows[a][0].ToString() == "2")
                    {
                        ilkKonuID = dt2.Rows[0]["kisaAd"].ToString(); // Tedavi Öncesi Sayfası olduğu için 1 e aldım


                        ekKategori += "<li style='text-transform:none;'><a style='text-transform:none;' href='tup-bebek-tedavi-sureci.aspx'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";
                        for (int b = 0; b < dt2.Rows.Count; b++)
                        {
                            ekKategori += "<li style='text-transform:none;'><a style='text-transform:none;' href='tup-bebek-tedavi-sureci-" + dt2.Rows[b]["kisaAd"].ToString() + ".aspx'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
                        }
                        ekKategori += "</ul></li>";

                    }
                    else if (dt.Rows[a][0].ToString() == "3")
                    {
                        ekKategori += "<li style='text-transform:none;'><a style='text-transform:none;' href='tup-bebek-tedavi-sonrasi.aspx'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";
                        for (int b = 0; b < dt2.Rows.Count; b++)
                        {
                            ekKategori += "<li style='text-transform:none;'><a style='text-transform:none;' href='tup-bebek-tedavi-sonrasi-" + dt2.Rows[b]["kisaAd"].ToString() + ".aspx'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
                        }
                        ekKategori += "</ul></li>";

                    }
                    else
                    {
                        ekKategori += "<li style='text-transform:none;'><a href='#'>" + dt.Rows[a]["tur"].ToString() + "</a><ul>";
                        for (int b = 0; b < dt2.Rows.Count; b++)
                        {
                            ekKategori += "<li style='text-transform:none;'><a  href='#' style='text-transform:none;'>" + dt2.Rows[b]["baslik"].ToString() + "</a></li>";
                        }
                        ekKategori += "</ul></li>";
                    }





                }
                //if (acikID == dt.Rows[a]["konu_id"].ToString())
                //{
                //    ekKategori += "<li class='nav-item'><a class='nav-link active' href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx'>" + dt.Rows[a]["konu"].ToString() + "</a></li>";
                //}
                //else
                //{
                //    ekKategori += "<li class='nav-item'><a class='nav-link' href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx'>" + dt.Rows[a]["konu"].ToString() + "</a></li>";
                //}
            }

            kategoridekiDigerBasliklar.InnerHtml = ekKategori + "</ul>";


            if (Request.QueryString["ID"] == null)
            {

                konuYukle(ilkKonuID);


            }
            else
            {
                konuYukle(Request.QueryString["ID"].ToString());

            }

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

    void konuYukle(string ID)
    {
        try
        {

            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da_kitap = new MySqlDataAdapter("Select * from tedaviiceriktablosu where kisaAd='" + ID + "'", connect_word);
            DataTable dt_kitap = new DataTable();
            da_kitap.Fill(dt_kitap);

            if (dt_kitap.Rows.Count != 0)
            {

                baslik.InnerText = dt_kitap.Rows[0]["baslik"].ToString();
                string icerikMetni = "<img src='https://www.tayfunalper.com/uploadImages/" + dt_kitap.Rows[0]["kapakResmi"].ToString() + "_500.jpg'/></br></br>";
                icerikMetni += dt_kitap.Rows[0]["icerik"].ToString();



                Page.Title = "Prof.Dr.Tayfun ALPER - " + dt_kitap.Rows[0]["baslik"].ToString();

                System.Web.UI.HtmlControls.HtmlMeta a = new System.Web.UI.HtmlControls.HtmlMeta();
                a = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("kw");
                string ek = "";
                string[] anahtarKelimeler = dt_kitap.Rows[0]["baslik"].ToString().Split(' ');
                foreach (string ic in anahtarKelimeler)
                {
                    ek += ic + ",";
                }
                a.Content = ek + "Tayfun ALPER," + dt_kitap.Rows[0]["baslik"].ToString() + ",Samsun,Omü,Ondokuz Mayıs Üniversitesi,Tayfun,ALPER,Prof.Dr.Tayfun ALPER,VM Medical Park Samsun Hastanesi,samsuntupbebek.com,IVF,Tüp Bebek,Emekli,Kadın Doğum Uzmanı,Kadın Doğum";




                if (dt_kitap.Rows[0]["biliyor"].ToString() != "")
                {
                    icerikMetni += "<hr class='tall'><h4>Bunu biliyor muydunuz?</h4><div class='row'><div class='col-lg-12'><blockquote class='blockquote-primary'><p>" + dt_kitap.Rows[0]["biliyor"].ToString() + "</p></blockquote></div></div>";
                }

                icerikMetni = icerikMetni.Replace("<span id=\"sceditor-end-marker\" class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\"> </span>", "");
                icerikMetni = icerikMetni.Replace("<span id=\"sceditor-start-marker\" class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\"> </span>", "");
                icerikMetni = icerikMetni.Replace("<span class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\" id=\"sceditor-end-marker\"> </span>", "");
                icerikMetni = icerikMetni.Replace("<span class=\"sceditor-selection sceditor-ignore\" style=\"line-height: 0; display: none;\" id=\"sceditor-start-marker\"> </span>", "");
                icerikMetni = icerikMetni.Replace("<p style=\"text-align: justify;\">", "");
                icerikMetni = icerikMetni.Replace("<div style=\"text-align: justify;\">", "");
                icerikMetni = icerikMetni.Replace("<div style=\"text-align: center;\">", "");
                icerikMetni = icerikMetni.Replace("<p style=\"\" class=\"\">", "");
                icerikMetni = icerikMetni.Replace("&emsp;", "");
                icerikMetni = icerikMetni.Replace("<div align=\"justify\">", "");
                icerikMetni = icerikMetni.Replace("<p style=\"text-align: justify; \" class=\"\">", "");
                icerikMetni = icerikMetni.Replace("<p align=\"justify\">", "");
                icerikMetni = icerikMetni.Replace("<div align=\"center\">", "");
                icerikMetni = icerikMetni.Replace("<div align=\"left\">", "");
                icerikMetni = icerikMetni.Replace("<p align=\"center\">", "");
                icerikMetni = icerikMetni.Replace("<p style=\"text-align: center;\">", "");
                icerikMetni = icerikMetni.Replace("<p class=\"MsoNormal\">", "");
                icerikMetni = icerikMetni.Replace("</span>", "");
                icerikMetni = icerikMetni.Replace("</p>", "</br>");
                icerikMetni = icerikMetni.Replace("</br><br></br>", "</br></br>");
                icerikMetni = icerikMetni.Replace("<br><br><br>", "</br></br>");
                icerikMetni = icerikMetni.Replace("<br></br></br>", "</br></br>");
                icerikMetni = icerikMetni.Replace("</br></br></br>", "</br></br>");
                icerikMetni = icerikMetni.Replace("<i><br></i>", "");
                icerikMetni = icerikMetni.Replace("<i><b><br></b></i>", "");
                icerikMetni = icerikMetni.Replace("<b><b><br></b></b>", "");
                icerikMetni = icerikMetni.Replace("<b><br></b>", "");
                icerikMetni = icerikMetni.Replace("<br></br>", "<br>");


                System.Web.UI.HtmlControls.HtmlMeta b = new System.Web.UI.HtmlControls.HtmlMeta();
                b = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("dsc");
                string temizleme = StripHtml(icerikMetni);
                if (temizleme.Length > 158)
                {
                    b.Content = temizleme.Substring(0, 158);
                }
                else
                {
                    b.Content = temizleme;
                }

                icerik.InnerHtml = icerikMetni;

            }

            else
            {
                Response.Redirect("Default.aspx");
            }


        }
        catch
        {
            Response.Redirect("Default.aspx");
        }

    }

  
}