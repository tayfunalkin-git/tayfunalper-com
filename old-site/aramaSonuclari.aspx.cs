using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class aramaSonuclari : System.Web.UI.Page
{
    tayfunalpercom mp_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            sonuclariYukle();
        }

    }

    private void sonuclariYukle()
    {
        string arananKelime = Request.QueryString["search"].ToString().Remove(0,1);
        if (arananKelime != "")
        {
            baslik.InnerHtml = "Aranan Kelime : " + arananKelime;
            sonuclar(arananKelime);
        }
        else
        {
            baslik.InnerHtml = "Aranan Kelime : -";
        }
       
       
    }

    private void sonuclar(string arananKelime)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da0 = new MySqlDataAdapter("Select K.konu as baslik,K.tarih as tarih,K.link,'0' as tur,'' as resim from kitap_konulari K,kitapkategorileri A,kitaplar T where K.kategori_id=A.id and A.kitap_id=T.id and (K.konu like '%" + arananKelime + "%' or K.metin like '%" + arananKelime + "%') and K.yayin='1' and A.yayin='1' and T.goster='1'", connect_word);
            DataTable dt0 = new DataTable();
            da0.Fill(dt0);// tayfun alperin yazılarından bulunanlar

            MySqlConnection connect_word2 = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da1 = new MySqlDataAdapter("Select baslik as baslik,eklenmeTarihi as tarih,concat('blog-icerik-',kisaAd,'.aspx') as link,'0' as tur,concat('http://www.samsuntupbebek.com/uploadImages/',kapakResmi,'_520.jpg') as resim from blogiceriktablosu where baslik like '%" + arananKelime + "%' or icerik like '%" + arananKelime + "%' and yayin='E'", connect_word2);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); // blog içerikten gelenler

            MySqlDataAdapter da2 = new MySqlDataAdapter("Select baslik as baslik,eklenmeTarihi as tarih,concat(kisaAd,'.aspx') as link,tur as tur,concat('http://www.samsuntupbebek.com/uploadImages/',kapakResmi,'_500.jpg') as resim from tedaviiceriktablosu where baslik like '%" + arananKelime + "%' or icerik like '%" + arananKelime + "%' or biliyor like '%" + arananKelime + "%' and yayin='E'", connect_word2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2); // tedavi sayfasından gelenlerde tur 1,2,3 tedavi öncesi tedavi süreci linklerini alacak.

            
            DataTable dt = new DataTable();
            DataColumn dc = new DataColumn("baslik");
            DataColumn dc2 = new DataColumn("tarih");
            DataColumn dc3 = new DataColumn("link");
            DataColumn dc4 = new DataColumn("tur");
            DataColumn dc5 = new DataColumn("resim");

            dt.Columns.Add(dc);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);

            for (int a = 0; a < dt0.Rows.Count; a++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = dt0.Rows[a][0].ToString();
                dr[1] = DateTime.Parse(dt0.Rows[a][1].ToString());
                dr[2] = "makale-"+dt0.Rows[a][2].ToString()+".aspx";
                dr[3] = dt0.Rows[a][3].ToString();
                dr[4] = dt0.Rows[a][4].ToString();
                dt.Rows.Add(dr);
            }

           // for (int a = 0; a < dt1.Rows.Count; a++)
           // {
           //     DataRow dr = dt.NewRow();
           //     dr[0] = dt1.Rows[a][0].ToString();
           //     dr[1] = DateTime.Parse(dt1.Rows[a][1].ToString());
           //     dr[2] = dt1.Rows[a][2].ToString();
             //   dr[3] = dt1.Rows[a][3].ToString();
            //    dr[4] = dt1.Rows[a][4].ToString();
            //    dt.Rows.Add(dr);
            //}

            for (int a = 0; a < dt2.Rows.Count; a++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = dt2.Rows[a][0].ToString();
                dr[1] = DateTime.Parse(dt2.Rows[a][1].ToString());

                if (dt2.Rows[a][3].ToString() == "1")
                {
                    dr[2] = "tup-bebek-tedavi-oncesi-" + dt2.Rows[a][2].ToString();
                }
                else if (dt2.Rows[a][3].ToString() == "2")
                {
                    dr[2] = "tup-bebek-tedavi-sureci-" + dt2.Rows[a][2].ToString();
                }
                else if (dt2.Rows[a][3].ToString() == "3")
                {
                    dr[2] = "tup-bebek-tedavi-sonrasi-" + dt2.Rows[a][2].ToString();
                }

                dr[3] = dt2.Rows[a][3].ToString();
                dr[4] = dt2.Rows[a][4].ToString();
                dt.Rows.Add(dr);
            }



            DataTable filtrelidt = dt.DefaultView.ToTable(true, new string[] { "baslik", "tarih", "link", "tur", "resim" });

          
            string eklenecekSonuc = "";

            if (filtrelidt.Rows.Count > 0)
            {

                eklenecekSonuc += "<h4 class='heading-primary'>'" + arananKelime + "' araması için <strong>" + filtrelidt.Rows.Count.ToString() + " sonuç bulundu.<br><br><br></strong></h4>";
              
               // eklenecekSonuc += "<ul class='simple-post-list'>";
                for (int a = 0; a < filtrelidt.Rows.Count; a++)
                {

                    string tarihCevir = DateTime.Parse(filtrelidt.Rows[a]["tarih"].ToString()).ToLongDateString();


                    eklenecekSonuc += "<li>";

                    string resimEk = "";

                    //if (filtrelidt.Rows[a][4].ToString() != "")
                    //{
                    //    resimEk = "<img src='" + filtrelidt.Rows[a][4].ToString() + "' width='120' style='margin-right:15px;' alt=''/>";

                    //}

                    if (resimEk != "")
                    {
                        eklenecekSonuc += "<h3>" + resimEk + "<a href='" + filtrelidt.Rows[a]["link"].ToString() + "'  style='text-decoration:none;'>" + filtrelidt.Rows[a]["baslik"].ToString() + "</a></h3>";

                    }
                    else
                    {
                        eklenecekSonuc += "<h3><a href='" + filtrelidt.Rows[a]["link"].ToString() + "' style='text-decoration:none;'>" + filtrelidt.Rows[a]["baslik"].ToString() + "</a></h3>";

                    }
                    eklenecekSonuc += "<div>" + tarihCevir + "</div>";
                    eklenecekSonuc += "</li>";



                  //  eklenecekSonuc += "<li>" + resimEk + "<div class='post-info'><a href='" + filtrelidt.Rows[a]["link"].ToString() + "'>" + filtrelidt.Rows[a]["baslik"].ToString() + "</a>";

                 

                }
                eklenecekSonuc = "<ul class='text-list text-list-base'>" +eklenecekSonuc + "</ul>";

            }
            else
            {


                eklenecekSonuc += "<div class='alert alert-info'>";
                eklenecekSonuc += "<p class='mb-0'><strong>'" + arananKelime + "'</strong> aranan kelimesi için sonuç bulunamadı!</p></div>";

            }


            aramaSonuclariDiv.InnerHtml = eklenecekSonuc;
        }
        catch
        {
            string eklenecekSonuc = "";
            eklenecekSonuc += "<div class='alert alert-info'>";
            eklenecekSonuc += "<p class='mb-0'><strong>'" + arananKelime + "'</strong> aranan kelimesi için sonuç bulunamadı!</p></div>";
            aramaSonuclariDiv.InnerHtml = eklenecekSonuc;

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("arama-sonuclari.aspx?" + txtAranacakKelime.Text);
    }
}