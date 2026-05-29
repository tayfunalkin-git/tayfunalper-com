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
            konu_yukle();
            //comIPMakale.Value = ipAl();
            tedaviSureciYukle();
            tedaviOncesiYukle();
         


        }
    }


    private void menuYukle(string gelen)
    {

        try
        {
            string menu = "";

            DataTable dtm = new DataTable();
            DataColumn dcm = new DataColumn("link");
            DataColumn dcm1 = new DataColumn("sira");
            dtm.Columns.Add(dcm);
            dtm.Columns.Add(dcm1);




            MySqlConnection mp_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select id,kitap_adi from kitaplar where goster='1' order by sira asc", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            int sira = 0;
            for (int a = 0; a < dt.Rows.Count; a++)
            {

                MySqlDataAdapter da1 = new MySqlDataAdapter("Select id,kategori_adi from kitapkategorileri where kitap_id='" + dt.Rows[a][0].ToString() + "' and yayin='1' order by sira asc", mp_connection);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);


                for (int b = 0; b < dt1.Rows.Count; b++)
                {

                    MySqlDataAdapter da2 = new MySqlDataAdapter("Select konu_id,konu,link from kitap_konulari where kategori_id='" + dt1.Rows[b][0].ToString() + "' and yayin='1' order by sira asc", mp_connection);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    for (int c = 0; c < dt2.Rows.Count; c++)
                    {

                        menu += "<li><a href='makale-" + dt2.Rows[c]["link"].ToString() + ".aspx'>" + dt2.Rows[c]["konu"].ToString() + "</a></li>";
                        DataRow dr = dtm.NewRow();
                        dr[0] = "makale-" + dt2.Rows[c]["link"].ToString() + ".aspx";
                        dr[1] = sira;
                        sira++;
                        dtm.Rows.Add(dr);

                    }

                    if (dt1.Rows[b][0].ToString() == "117")
                    {

                        MySqlConnection connectABO = new MySqlConnection("DataSource= 94.73.150.121;Database=u6529584_dbB01;User ID=u6529584_userB01;Password=ZEig11J3;charset=latin5");
                        MySqlDataAdapter da21 = new MySqlDataAdapter("Select kategoriAdi,link from hosgeldiniz where neIseYarar='+' and yayin='+' order by sira asc", connectABO);
                        DataTable dt21 = new DataTable();
                        da21.Fill(dt21);

                        for (int c = 0; c < dt21.Rows.Count; c++)
                        {

                            menu += "<li><a href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
                            DataRow dr = dtm.NewRow();
                            dr[0] = "neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx";

                            dr[1] = sira;
                            sira++;
                            dtm.Rows.Add(dr);

                        }
                    }
                    if (dt1.Rows[b][0].ToString() == "118")
                    {

                        MySqlConnection connectABO = new MySqlConnection("DataSource= 94.73.150.121;Database=u6529584_dbB01;User ID=u6529584_userB01;Password=ZEig11J3;charset=latin5");
                        MySqlDataAdapter da21 = new MySqlDataAdapter("Select kategoriAdi,link from hosgeldiniz where nasilKullanilir='+' and yayin='+' order by sira asc", connectABO);
                        DataTable dt21 = new DataTable();
                        da21.Fill(dt21);

                        for (int c = 0; c < dt21.Rows.Count; c++)
                        {

                            menu += "<li><a href='nasilKullanilir-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
                            DataRow dr = dtm.NewRow();
                            dr[0] = "nasilKullanilir-" + dt21.Rows[c]["link"].ToString() + ".aspx";
                            dr[1] = sira;
                            sira++;
                            dtm.Rows.Add(dr);
                        }
                    }

                }


            }

            //GridView1.DataSource = dtm;
            //GridView1.DataBind();


            DataRow[] devamsatiri = dtm.Select("link='makale-" + gelen + ".aspx'");
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
        catch
        { 
        
        }
  
    }

    private void tedaviOncesiYukle()
    {
        try
        {
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='1' and yayin='E' order by RAND() LIMIT 0,3", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string eklenecekifade = "";
            for (int a = 0; a < dt.Rows.Count; a++)
            {

                eklenecekifade += "<li style='text-transform:none;'>";
                eklenecekifade += "<a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>";
                eklenecekifade += "<img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' alt='' />";
                //eklenecekifade += "<span>February 12, 2020</span>";
                eklenecekifade += dt.Rows[a]["baslik"].ToString();
                eklenecekifade += "</a>";
                eklenecekifade += "</li>";



                //eklenecekifade += "<li><div class='post-image'><div class='img-thumbnail d-block'>";
                //eklenecekifade += "<a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'><img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' width='50' alt=''>";
                //eklenecekifade += "</a></div></div><div class='post-info'><a href='tup-bebek-tedavi-oncesi-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a>";
                //eklenecekifade += "</div></li>";
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
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur='2' and yayin='E' order by RAND() LIMIT 0,3", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string eklenecekifade = "";
            for (int a = 0; a < dt.Rows.Count; a++)
            {

                eklenecekifade += "<li style='text-transform:none;'>";
                eklenecekifade += "<a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>";
                eklenecekifade += "<img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' alt='' />";
                //eklenecekifade += "<span>February 12, 2020</span>";
                eklenecekifade += dt.Rows[a]["baslik"].ToString();
                eklenecekifade += "</a>";
                eklenecekifade += "</li>";

                //eklenecekifade += "<li><div class='post-image'><div class='img-thumbnail d-block'>";
                //eklenecekifade += "<a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'><img src='https://www.tayfunalper.com/uploadImages/" + dt.Rows[a]["kapakResmi"].ToString() + "_500.jpg' width='50' alt=''>";
                //eklenecekifade += "</a></div></div><div class='post-info'><a href='tup-bebek-tedavi-sureci-" + dt.Rows[a]["kisaAd"].ToString() + ".aspx'>" + dt.Rows[a]["baslik"].ToString() + "</a>";
                //eklenecekifade += "</div></li>";
            }
            tedaviSureciIcerik.InnerHtml = eklenecekifade;
        }
        catch
        {

        }
    }




    private void digerKonulariYukle(string ID,string acikID)
    {

        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from kitap_konulari where kategori_id='" + ID + "' and yayin='1' order by sira asc", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        string ekKategori = "<ul>";

        for(int a = 0; a< dt.Rows.Count ; a++)
        {
            ekKategori += "<li style='text-transform:none;'><a href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx' style='text-transform:none;'>" + dt.Rows[a]["konu"].ToString() + "</a></li>";
                  

            //if (acikID == dt.Rows[a]["konu_id"].ToString())
            //{
            //    ekKategori += " <li><a href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx'>"+dt.Rows[a]["konu"].ToString()+"</a></li>";
                  
            //}
            //else
            //{
            //    ekKategori += "<li class='nav-item'><a class='nav-link' href='makale-" + dt.Rows[a]["link"].ToString() + ".aspx'>" + dt.Rows[a]["konu"].ToString() + "</a></li>";

            //}

        
        }

        if (ID == "117")
        {// ne işe yarar?

            MySqlConnection connectABO = new MySqlConnection("DataSource= 94.73.150.121;Database=u6529584_dbB01;User ID=u6529584_userB01;Password=ZEig11J3;charset=latin5");
            MySqlDataAdapter da21 = new MySqlDataAdapter("Select kategoriAdi,link from hosgeldiniz where neIseYarar='+' and yayin='+' order by sira asc", connectABO);
            DataTable dt21 = new DataTable();
            da21.Fill(dt21); // Kategorideki konular

            for (int c = 0; c < dt21.Rows.Count; c++)
            {
               // ekKategori += "<li class='nav-item'><a class='nav-link' href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
                ekKategori += "<li style='text-transform:none;'><a href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx' style='text-transform:none;'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
              
           //     menu += "<li><a class='dropdown-item' href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";

            }
        }
        if (ID == "118")
        {

            MySqlConnection connectABO = new MySqlConnection("DataSource= 94.73.150.121;Database=u6529584_dbB01;User ID=u6529584_userB01;Password=ZEig11J3;charset=latin5");
            MySqlDataAdapter da21 = new MySqlDataAdapter("Select kategoriAdi,link from hosgeldiniz where nasilKullanilir='+' and yayin='+' order by sira asc", connectABO);
            DataTable dt21 = new DataTable();
            da21.Fill(dt21); // Kategorideki konular

            for (int c = 0; c < dt21.Rows.Count; c++)
            {
                //ekKategori += "<li class='nav-item'><a class='nav-link' href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
                ekKategori += "<li style='text-transform:none;'><a href='nasilKullanilir-" + dt21.Rows[c]["link"].ToString() + ".aspx' style='text-transform:none;'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
             //   menu += "<li><a class='dropdown-item' href='nasilKullanilir-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";

            }



        }




        kategoridekiDigerBasliklar.InnerHtml = ekKategori + "</ul>";


       
    }
    protected string StripHtml(string Txt)
    {
        return Regex.Replace(Txt, "<(.|\\n)*?>", string.Empty);
    }    

    void konu_yukle()
    {
    //    try
    //    {

            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da_kitap = new MySqlDataAdapter("Select * from kitap_konulari where link='" + Request.QueryString["ID"].ToString() + "'", connect_word);
            DataTable dt_kitap = new DataTable();
            da_kitap.Fill(dt_kitap);

            if (dt_kitap.Rows.Count != 0)
            {

               // comIDMakale.Value = dt_kitap.Rows[0]["konu_id"].ToString();

                baslik.InnerHtml = dt_kitap.Rows[0]["konu"].ToString();

                digerKonulariYukle(dt_kitap.Rows[0]["kategori_id"].ToString(), dt_kitap.Rows[0]["konu_id"].ToString());

                //  baslik4.Text = dt_kitap.Rows[0]["konu"].ToString() + " için";

                string IPAdres = HttpContext.Current.Request.UserHostAddress;
                ebebaba_class.istatistiksayfa(IPAdres, dt_kitap.Rows[0]["konu"].ToString(), "Sayfa");

                Page.Title = "Prof.Dr.Tayfun ALPER - " + dt_kitap.Rows[0]["konu"].ToString();
                
                System.Web.UI.HtmlControls.HtmlMeta a = new System.Web.UI.HtmlControls.HtmlMeta();
                a = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("kw");
                string ek = "";
                string[] anahtarKelimeler = dt_kitap.Rows[0]["konu"].ToString().Split(' ');
                foreach (string ic in anahtarKelimeler)
                {
                    ek += ic + ",";
                }
                a.Content = ek + "Tayfun ALPER," + dt_kitap.Rows[0]["konu"].ToString() + ",Samsun,Omü,Ondokuz Mayıs Üniversitesi,Tayfun,ALPER,Prof.Dr.Tayfun ALPER,VM Medical Park Samsun Hastanesi,samsuntupbebek.com,IVF,Tüp Bebek,Emekli,Kadın Doğum Uzmanı,Kadın Doğum";

                // System.Web.UI.Controls.GenericControl.Meta a = new System.Web.UI.Controls.Meta();
           
                string eski = dt_kitap.Rows[0]["metin"].ToString();
                string yeni = eski.Replace("../imgyardim/", "imgyardim/");


                System.Web.UI.HtmlControls.HtmlMeta b = new System.Web.UI.HtmlControls.HtmlMeta();
                b = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("dsc");
                string temizleme = StripHtml(yeni);
                if (temizleme.Length > 158)
                {
                    b.Content = temizleme.Substring(0, 158);
                }
                else
                {
                    b.Content = temizleme;
                }

                kategoribul(dt_kitap.Rows[0]["kategori_id"].ToString());

                okunduOlarakIsaretle(dt_kitap.Rows[0]["konu_id"].ToString());
                
              //  string okunmaSayisiDiv = "<hr class='tall'>";
                // string okunmaSayisiDiv = "";
                //okunmaSayisiDiv += "<div class='counters counters-text-dark' style='float:right;'>";
                //okunmaSayisiDiv += "<div class='counter appear-animation' data-appear-animation='fadeInUp' data-appear-animation-delay='300'>";
                //okunmaSayisiDiv += "<i class='fa fa-user'></i>";
                //okunmaSayisiDiv += "<strong data-to='" + dt_kitap.Rows[0]["hit"].ToString() + "'>0</strong>";
                //okunmaSayisiDiv += "<p class='text-color-primary '>defa okundu.</p></div></div>";


                //yeni += okunmaSayisiDiv;
          //      yeni += yorumMetniAl(dt_kitap.Rows[0]["konu_id"].ToString());
                icerik.InnerHtml = yeni;

                menuYukle(Request.QueryString["ID"].ToString());

            }

            else
            {
                Response.Redirect("Default.aspx");
            }


        //}
        //catch
        //{
           
        //}

    }

    string ipAl()
    {
        string ipaddress;
        ipaddress = Context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (ipaddress == "" || ipaddress == null)
            ipaddress = Context.Request.ServerVariables["REMOTE_ADDR"];
        return ipaddress;

    }

    private void okunduOlarakIsaretle(string p)
    {
        try
        {
            string ipAdresi = ipAl();
            MySqlConnection mp_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from blogokundu where blogID=" + p + " and IP='" + ipAdresi + "'", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                MySqlCommand cmd = new MySqlCommand("Update kitap_konulari set hit=hit+1 where konu_id=" + p + "", mp_connection);
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

    void kategoribul(string gelen)
    {
        try
        {
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da_kitap = new MySqlDataAdapter("Select K.kategori_adi,A.kitap_adi from kitapkategorileri K,kitaplar A where A.id=K.kitap_id and K.id=" + gelen.ToString() + "", connect_word);
            DataTable dt_kitap = new DataTable();
            da_kitap.Fill(dt_kitap);

            if (dt_kitap.Rows.Count != 0)
            {
                anaKategoriAdi.InnerHtml = "<a href='#'>"+dt_kitap.Rows[0]["kitap_adi"].ToString().ToUpper()+"</a>";
                altKategoriAdi.InnerHtml = "<a href='#'>" + dt_kitap.Rows[0]["kategori_adi"].ToString().ToUpper() + "</a>";
                altKategori2.InnerHtml = dt_kitap.Rows[0]["kategori_adi"].ToString().ToUpper();
            }
            else
            {
                anaKategoriAdi.InnerHtml = "";
                altKategoriAdi.InnerHtml = "";
                altKategori2.InnerHtml = "";

            }

        }
        catch
        {
            anaKategoriAdi.InnerHtml = "";
            altKategoriAdi.InnerHtml = "";
            altKategori2.InnerHtml = "";


        }

    }


  
}