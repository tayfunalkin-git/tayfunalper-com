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
using System.IO;

public partial class ebebabaadmin : System.Web.UI.Page
{
    forum_class fc = new forum_class();

    protected void Page_Load(object sender, EventArgs e)
    {

        mesajsay();

        if (!IsPostBack)
        {
            menuadmin.Items[2].Selected = true;
            menuyukle();
          
        }

    }
    void menuyukle()
    {


        //try
        //{


                if (menuadmin.SelectedValue == "kategori")
                {

                    kategoripanel.Visible = true;
                    cevappanel.Visible = false;
                    konupanel.Visible = false;
                    sikayetpanel.Visible = false;
                    mailpanel.Visible = false;
                    forumpanel.Visible = false;
                    alan_yukle();
                    uyepanel.Visible = false;
                    guncelle.Visible = false;
                    forumpanel.Visible = false;

                }
                else if (menuadmin.SelectedValue == "cevap")
                {
                    kategoripanel.Visible = false;
                    cevappanel.Visible = true;
                    konupanel.Visible = false;
                    sikayetpanel.Visible = false;
                    mailpanel.Visible = false;
                    forumpanel.Visible = false;
                    uyepanel.Visible = false;
                    cevapyukle();
                    forumpanel.Visible = false;
                }
                else if (menuadmin.SelectedValue == "konu")
                {
                    kategoripanel.Visible = false;
                    cevappanel.Visible = false;
                    konupanel.Visible = true;
                    sikayetpanel.Visible = false;
                    mailpanel.Visible = false;
                    forumpanel.Visible = false;
                    konuyukle(); forumpanel.Visible = false;

                }
                else if (menuadmin.SelectedValue == "sikayet")
                {
                    kategoripanel.Visible = false;
                    cevappanel.Visible = false;
                    konupanel.Visible = false;
                    sikayetpanel.Visible = true;
                    mailpanel.Visible = false;
                    forumpanel.Visible = false;
                    uyepanel.Visible = false;
                    forumpanel.Visible = false;

                }
                else if (menuadmin.SelectedValue == "mail")
                {
                    kategoripanel.Visible = false;
                    cevappanel.Visible = false;
                    konupanel.Visible = false;
                    sikayetpanel.Visible = false;
                    mailpanel.Visible = true;
                    forumpanel.Visible = false;
                    Label1.Text = "";
                    uyepanel.Visible = false;
                    gidenpanel.Visible = true;
                    gidenmesajoku.Visible = false;
                    Session.Add("mailmesajsession", "select * from toplu_mesajlar order by str_to_date(gonderme_tarihi,'%d.%m.%Y %H:%i:%s') desc");

                    gidenmesajlariyukle();
                    forumpanel.Visible = false;

                }

                else if (menuadmin.SelectedValue == "ayar")
                {
                    kategoripanel.Visible = false;
                    cevappanel.Visible = false;
                    konupanel.Visible = false;
                    sikayetpanel.Visible = false;
                    mailpanel.Visible = false;
                    forumpanel.Visible = true;
                    uyepanel.Visible = false;
                    ayaryukle();
                    ayarsnc.Text = "";
                    
                }

                else if (menuadmin.SelectedValue == "uye")
                {
                    kategoripanel.Visible = false;
                    cevappanel.Visible = false;
                    konupanel.Visible = false;
                    sikayetpanel.Visible = false;
                    mailpanel.Visible = false;
                    forumpanel.Visible = false;
                    uyepanel.Visible = true;
                    ayaryukle();
                    ayarsnc.Text = "";
                    onaybekleyenuyeyukle();
                    snc.Text = "";

                }
 

        //}
        //catch
        //{ 
        
        //}
    }

    private void onaybekleyenuyeyukle()
    {
        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forumebebabauyeler where uyelik_aktifmi='+' and onayverildimi='-'", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);

        uyelist.DataSource = ebebaba_dt;
        uyelist.DataBind();


        Label4.Text = ebebaba_dt.Rows.Count.ToString();


        Label ad = new Label();
        Label id = new Label();
        Label durum = new Label();
        Label mail = new Label();
        ImageButton sil = new ImageButton();
        ImageButton onay = new ImageButton();

        int a = 0;
        foreach (DataListItem str in uyelist.Items)
        {
            ad = (Label)str.FindControl("uyead");
            id = (Label)str.FindControl("uye_id");
            mail = (Label)str.FindControl("uyemail");
            durum = (Label)str.FindControl("durum");           
            sil = (ImageButton)str.FindControl("imgsil");
            onay = (ImageButton)str.FindControl("imgonay");


            ad.Text = fc.uyebilgi(ebebaba_dt.Rows[a]["uye_id"].ToString());
            id.Text  = ebebaba_dt.Rows[a]["uye_id"].ToString();
            sil.CommandArgument = ebebaba_dt.Rows[a]["uye_id"].ToString(); 
            onay.CommandArgument = ebebaba_dt.Rows[a]["uye_id"].ToString();
            durum.Text = fc.durum(ebebaba_dt.Rows[a]["uye_email"].ToString());
            onay.CommandName= ebebaba_dt.Rows[a]["uye_email"].ToString();
            mail.Text = ebebaba_dt.Rows[a]["uye_email"].ToString();

            a++;



        }
        
    }

    private void ayaryukle()
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forum_ayar where ID=1", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);
        
        if (ebebaba_dt.Rows[0]["uyelik"].ToString() == "+")
        {
            uyelik.Checked = true;

        }
        else
        {
            uyelik.Checked = false;
        }


        if (ebebaba_dt.Rows[0]["konu"].ToString() == "+")
        {

            cbkonu.Checked = true;

        }
        else
        {
            cbkonu.Checked = false;
        }


        if (ebebaba_dt.Rows[0]["cevap"].ToString() == "+")
        {
            cbcevap.Checked = true;
        }
        else
        {
            cbcevap.Checked = false;
        }


    }

    void mesajsay()
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forum_konulari where yayin='-'", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);

        MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("Select * from forum_cevaplari where yayin='-'", ebebaba_connection);
        DataTable ebebaba_dt2 = new DataTable();
        ebebaba_da2.Fill(ebebaba_dt2);

        MySqlDataAdapter ebebaba_da3 = new MySqlDataAdapter("Select * from forumebebabauyeler where onayverildimi='-'", ebebaba_connection);
        DataTable ebebaba_dt3 = new DataTable();
        ebebaba_da3.Fill(ebebaba_dt3);

        menuadmin.Items[1].Text = "Onay Bekleyen Üyeler (<b><font color='navy'>" + ebebaba_dt3.Rows.Count.ToString() + "</font></b>)";
        menuadmin.Items[2].Text = "Onay Bekleyen Konular (<b><font color='navy'>" + ebebaba_dt.Rows.Count.ToString() + "</font></b>)";
        menuadmin.Items[3].Text = "Onay Bekleyen Cevaplar (<b><font color='navy'>" + ebebaba_dt2.Rows.Count .ToString() + "</font></b>)";

    }


    private void konuyukle()
    {

        //try
        //{
        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forum_konulari F,kategoriler K , forumebebabauyeler U  where F.kategoriID = K.ID and U.uye_id = CAST(F.yazan as UNSIGNED) and F.yayin='-'", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);

        konusayisi.Text = ebebaba_dt.Rows.Count.ToString();


        konular.DataSource = ebebaba_dt;
            konular.DataBind();

            //baslik.Text = ebebaba_dt.Rows[0]["baslik"].ToString();

            LinkButton adsoyad = new LinkButton();
            Label acilankonu = new Label();
            Label acilantarih = new Label();
            Label acilanimza = new Label();
            Label forum = new Label();

            Label acilanicerik = new Label();
            Label tip = new Label();
            Image resim = new Image();
            Panel imzapaneli = new Panel();
            Image imgdurum = new Image();
            Label durum = new Label();

            ImageButton btnonay = new ImageButton();
            ImageButton btnsil = new ImageButton();

            int a = 0;
            foreach (DataListItem oge in konular.Items)
            {
                acilankonu = (Label)oge.FindControl("baslik");
                acilantarih = (Label)oge.FindControl("tarih");
                acilanimza = (Label)oge.FindControl("imza");
                acilanicerik = (Label)oge.FindControl("icerik");
                adsoyad = (LinkButton)oge.FindControl("adsoyad");
                resim = (Image)oge.FindControl("uyeResim");
                imzapaneli = (Panel)oge.FindControl("imzapaneli");
                imgdurum = (Image)oge.FindControl("imgdurum");
                durum = (Label)oge.FindControl("durum");
                forum = (Label)oge.FindControl("forum");
                tip = (Label)oge.FindControl("tip");
                acilankonu.Text = ebebaba_dt.Rows[a]["baslik"].ToString();
                acilanimza.Text = ebebaba_dt.Rows[a]["imza"].ToString();
                acilantarih.Text = ebebaba_dt.Rows[a]["tarih"].ToString();
                adsoyad.Text = fc.uyebilgi(ebebaba_dt.Rows[a]["yazan"].ToString());
                adsoyad.OnClientClick = "window.open('uyeprofilpopup.aspx?ID=" + ebebaba_dt.Rows[a]["yazan"].ToString() + "','','toolbar=0,scrollbars=0,location=0,statusbar=0,menubar=0,resizable=0,width=600,height=500,left = 600,top = 200');return false;";

                btnonay = (ImageButton)oge.FindControl("btnonay");
                
                btnsil = (ImageButton)oge.FindControl("btnsil");

                forum.Text = ebebaba_dt.Rows[a]["kategoriAdi"].ToString();
                btnonay.CommandArgument = ebebaba_dt.Rows[a]["ID"].ToString();
                btnsil.CommandArgument = ebebaba_dt.Rows[a]["ID"].ToString();

                btnonay.CommandName = ebebaba_dt.Rows[a]["yazan"].ToString();
                btnsil.CommandName = ebebaba_dt.Rows[a]["yazan"].ToString();


                acilanicerik.Text = ebebaba_dt.Rows[a]["icerik"].ToString();

                FileInfo res = new FileInfo(Server.MapPath("~/forum/uyeResim/" + ebebaba_dt.Rows[a]["yazan"].ToString() + "_thumb.jpg"));

                if (res.Exists)
                {
                    resim.ImageUrl = "~/forum/uyeResim/" + ebebaba_dt.Rows[a]["yazan"].ToString() + "_thumb.jpg";
                }
                else
                {
                    resim.ImageUrl = "~/forum/imgs/forum.png";

                }



                if (ebebaba_dt.Rows[a]["imza"].ToString() != "")
                {

                    imzapaneli.Visible = true;

                }
                else
                {
                    imzapaneli.Visible = false;
                }

                if (durumkontrol(ebebaba_dt.Rows[a]["yazan"].ToString()) == true)
                {

                    imgdurum.ImageUrl = "~/forum/imgs/onlinebaslik.png";
                    durum.Text = "Çevrimiçi";
                    durum.ForeColor = System.Drawing.Color.Green;

                }
                else
                {
                    imgdurum.ImageUrl = "~/forum/imgs/cevrimdisi.png";
                    durum.Text = "Çevrimdışı";
                    durum.ForeColor = System.Drawing.Color.Gray;

                }



                if (yoneticimi(ebebaba_dt.Rows[a]["yazan"].ToString()) == true)
                {

                    tip.Text = "Yönetici";
                    tip.Font.Bold = true;
                    tip.ForeColor = System.Drawing.Color.Maroon;

                }
                else
                {
                    tip.Text = "Normal Üye";
                    tip.Font.Bold = false;
                    tip.ForeColor = System.Drawing.Color.Maroon;

                }



                a++;
            }
        
        //}

        //catch
        //{
        //    Response.Redirect("~/Default.aspx");


        //}


    }

    private void cevapyukle()
    {

        //try
        //{
        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forum_cevaplari where yayin = '-'", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);

        Label6.Text = ebebaba_dt.Rows.Count.ToString();


        cevaplar.DataSource = ebebaba_dt;
        cevaplar.DataBind();

        //baslik.Text = ebebaba_dt.Rows[0]["baslik"].ToString();

        LinkButton adsoyad = new LinkButton();
        Label acilankonu = new Label();
        Label acilantarih = new Label();
        Label acilanimza = new Label();
        Label forum = new Label();

        Label acilanicerik = new Label();
        Label tip = new Label();
        Image resim = new Image();
        Panel imzapaneli = new Panel();
        Image imgdurum = new Image();
        Label durum = new Label();

        ImageButton btnonay = new ImageButton();
        ImageButton btnsil = new ImageButton();

        int a = 0;
        foreach (DataListItem oge in cevaplar.Items)
        {
            acilankonu = (Label)oge.FindControl("baslik");
            acilantarih = (Label)oge.FindControl("tarih");
            acilanimza = (Label)oge.FindControl("imza");
            acilanicerik = (Label)oge.FindControl("icerik");
            adsoyad = (LinkButton)oge.FindControl("adsoyad");
            resim = (Image)oge.FindControl("uyeResim");
            imzapaneli = (Panel)oge.FindControl("imzapaneli");
            imgdurum = (Image)oge.FindControl("imgdurum");
            durum = (Label)oge.FindControl("durum");
            forum = (Label)oge.FindControl("forum");
            tip = (Label)oge.FindControl("tip");
   btnonay = (ImageButton)oge.FindControl("btnonay");
            btnsil = (ImageButton)oge.FindControl("btnsil");

         
            string[] kat = kategoribul(ebebaba_dt.Rows[a]["konuID"].ToString()).Split('|');

            if (kat.Length > 0)
            {
                if (kat[0].ToString() == "-")
                {

                acilankonu.Text = "Silinmiş Konu";
                forum.Text = "-";
                acilankonu.ForeColor = System.Drawing.Color.Red;
                btnonay.Visible = false;
                
                }
                else
                {
                    btnonay.Visible = true;
                    acilankonu.ForeColor = System.Drawing.Color.Black;
                 acilankonu.Text = kat[1].ToString();
                    forum.Text = kat[0].ToString();
                }
            }



            if (ebebaba_dt.Rows[a]["yazan"].ToString() == "-")
            {

                acilanimza.Text = "";
                acilantarih.Text = ebebaba_dt.Rows[a]["tarih"].ToString();
                adsoyad.Text = ebebaba_dt.Rows[a]["nick"].ToString();
                acilanicerik.Text = ebebaba_dt.Rows[a]["icerik"].ToString();
                tip.Text = "Ziyaretçi";
                resim.ImageUrl = "~/forum/imgs/forum.png";
                imgdurum.Visible = false;
                btnonay.CommandArgument = ebebaba_dt.Rows[a]["ID"].ToString();
                btnsil.CommandArgument = ebebaba_dt.Rows[a]["ID"].ToString();


                btnonay.CommandName = ebebaba_dt.Rows[a]["yazan"].ToString();
                btnsil.CommandName = ebebaba_dt.Rows[a]["yazan"].ToString();

            }
            else
            {


                MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("Select * from forumebebabauyeler where uye_id=" + ebebaba_dt.Rows[a]["yazan"].ToString(), ebebaba_connection);
                DataTable ebebaba_dt2 = new DataTable();
                ebebaba_da2.Fill(ebebaba_dt2);

                acilanimza.Text = ebebaba_dt2.Rows[0]["imza"].ToString();
                acilantarih.Text = ebebaba_dt.Rows[a]["tarih"].ToString();
                adsoyad.Text = ebebaba_dt2.Rows[0]["uye_adi"].ToString() + " " + ebebaba_dt2.Rows[0]["uye_soyadi"].ToString();
                adsoyad.OnClientClick = "window.open('uyeprofilpopup.aspx?ID=" + ebebaba_dt.Rows[a]["yazan"].ToString() + "','','toolbar=0,scrollbars=0,location=0,statusbar=0,menubar=0,resizable=0,width=600,height=500,left = 600,top = 200');return false;";


                btnonay.CommandArgument = ebebaba_dt.Rows[a]["ID"].ToString();
                btnsil.CommandArgument = ebebaba_dt.Rows[a]["ID"].ToString();


                btnonay.CommandName = ebebaba_dt.Rows[a]["yazan"].ToString();
                btnsil.CommandName = ebebaba_dt.Rows[a]["yazan"].ToString();



                acilanicerik.Text = ebebaba_dt.Rows[a]["icerik"].ToString();
                FileInfo res = new FileInfo(Server.MapPath("~/forum/uyeResim/" + ebebaba_dt.Rows[a]["yazan"].ToString() + "_thumb.jpg"));

                if (res.Exists)
                {
                    resim.ImageUrl = "~/forum/uyeResim/" + ebebaba_dt.Rows[a]["yazan"].ToString() + "_thumb.jpg";
                }
                else
                {
                    resim.ImageUrl = "~/forum/imgs/forum.png";

                }
                if (ebebaba_dt2.Rows[0]["imza"].ToString() != "")
                {

                    imzapaneli.Visible = true;

                }
                else
                {
                    imzapaneli.Visible = false;
                }

                if (durumkontrol(ebebaba_dt.Rows[a]["yazan"].ToString()) == true)
                {

                    imgdurum.ImageUrl = "~/forum/imgs/onlinebaslik.png";
                    durum.Text = "Çevrimiçi";
                    durum.ForeColor = System.Drawing.Color.Green;

                }
                else
                {
                    imgdurum.ImageUrl = "~/forum/imgs/cevrimdisi.png";
                    durum.Text = "Çevrimdışı";
                    durum.ForeColor = System.Drawing.Color.Gray;

                }



                if (yoneticimi(ebebaba_dt.Rows[a]["yazan"].ToString()) == true)
                {

                    tip.Text = "Yönetici";
                    tip.Font.Bold = true;
                    tip.ForeColor = System.Drawing.Color.Maroon;

                }
                else
                {
                    tip.Text = "Normal Üye";
                    tip.Font.Bold = false;
                    tip.ForeColor = System.Drawing.Color.Maroon;

                }


            
            
            }




         

            a++;
        }

        //}

        //catch
        //{
        //    Response.Redirect("~/Default.aspx");


        //}


    }

    private string kategoribul(string p)
    {

        try
        {
            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select K.kategoriAdi as ka,F.baslik as bas from forum_konulari F,kategoriler K where K.ID = F.kategoriID and F.ID=" + p.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            return ebebaba_dt.Rows[0]["ka"].ToString() + "|" + ebebaba_dt.Rows[0]["bas"].ToString();


        }
        catch
        {
            return "-|Silinmiş Konu";

        }
    }


    protected void menumesaj_MenuItemClick(object sender, MenuEventArgs e)
    {
        menuyukle();
    }
    private bool durumkontrol(string p)
    {


        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from forumebebabauyeler where TIMESTAMPDIFF(minute,NOW(),str_to_date(songiris,'%d.%m.%Y %H:%i:%s')) > 0 and uye_id=" + p.ToString() + "", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);


        if (ebebaba_dt.Rows.Count == 1)
        {

            return true;
        }
        else
        {
            return false;
        }



    }


    private bool yoneticimi(string p)
    {


        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_tipi from forumebebabauyeler where uye_id=" + p.ToString() + "", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);


        if (ebebaba_dt.Rows[0][0].ToString() == "+")
        {

            return true;
        }
        else
        {
            return false;
        }



    }

    void alan_yukle()
    {

        try
        {
            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from kategoriler order by sira asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            list.DataSource = ebebaba_dt;
            list.DataBind();


            ImageButton btn_guncelle = new ImageButton();
            ImageButton btn_sil = new ImageButton();
            ImageButton yukari = new ImageButton();
            ImageButton asagi = new ImageButton();
            int i = 0;

            foreach (GridViewRow str in list.Rows)
            {



                btn_guncelle = (ImageButton)str.FindControl("ad_guncelle");
                btn_sil = (ImageButton)str.FindControl("sil");
                btn_guncelle.CommandArgument = ebebaba_dt.Rows[i]["ID"].ToString();
                btn_sil.CommandArgument = ebebaba_dt.Rows[i]["ID"].ToString();

                btn_sil.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                yukari = (ImageButton)str.FindControl("ust");
                yukari.CommandArgument = ebebaba_dt.Rows[i]["ID"].ToString();
                yukari.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                asagi = (ImageButton)str.FindControl("alt");
                asagi.CommandArgument = ebebaba_dt.Rows[i]["ID"].ToString();
                asagi.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();




                i++;

            }
        }


        catch
        {

        }
    }
    protected void ad_guncelle_Command(object sender, CommandEventArgs e)
    {

        try
        {
            guncelle.Visible = true;
            sonuc.Visible = false;

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from kategoriler where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            alanadi2.Text = ebebaba_dt.Rows[0]["kategoriAdi"].ToString();

            Label2.Text = ebebaba_dt.Rows[0]["ID"].ToString();
            aciklama2.Text = ebebaba_dt.Rows[0]["kategoriAciklama"].ToString();
        }

        catch
        {

        }

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {
        guncelle.Visible = false;

        try
        {

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);

            //MySqlDataAdapter da = new MySqlDataAdapter("select kurum_id from kisa_siklus where kurum_id='" + e.CommandArgument.ToString() + "'", ebebaba_connection);
            //DataTable ebebaba_dt = new DataTable();
            //da.Fill(ebebaba_dt);



            //if (ebebaba_dt.Rows.Count == 0)
            //{


                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kategoriler set sira = sira - 1 where sira > " + e.CommandName.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks3 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();



                MySqlCommand ebebaba_cmd = new MySqlCommand("delete from kategoriler where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();


                if (eks == 1)
                {

                  
                    sonuc.Text = "Kategori Kaydı Başarıyla Silindi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;

                    alan_yukle();



                }

                else
                {
                 
                    sonuc.Text = "Kategori Kaydı Silme İşlemi Başarısız !";
                    sonuc.ForeColor = System.Drawing.Color.Red;

                }

            }

          
        catch
        {
          
            sonuc.Text = "Kategori Kaydı Silme İşlemi Başarısız !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
    protected void yeni_kaydet_Click(object sender, EventArgs e)
    {

        guncelle.Visible = false;

    }

    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {

        try
        {
            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("update kategoriler set kategoriAdi = ?1,kategoriAciklama = ?2 where ID =" + Label2.Text + "", ebebaba_connection);

            ebebaba_cmd.Parameters.AddWithValue("?1", alanadi2.Text.TrimEnd().TrimStart().ToString());
            ebebaba_cmd.Parameters.AddWithValue("?2", aciklama2.Text.ToString());


            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

              
                sonuc.Text = "Kategori Kaydı Başarıyla Güncelleştirildi";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                alanadi2.Text = "";
                aciklama2.Text = "";
                guncelle.Visible = false;

            }

            else
            {
             
                sonuc.Text = "Kategori Kaydı Güncelleştirilmesi Başarısız !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
     
            sonuc.Text = "Kategori Kaydı Güncelleştirilmesi Başarısız !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }
    protected void ust_Command(object sender, CommandEventArgs e)
    {

        if (e.CommandName.ToString() != "1")
        {

            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kategoriler set sira = sira + 1 where sira=" + degisecek_sira + "", ebebaba_connection);

                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();


                MySqlCommand ebebaba_cmd = new MySqlCommand("update kategoriler set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();

                alan_yukle();



            }

            catch
            {


            }


        }

    }
    protected void alt_Command(object sender, CommandEventArgs e)
    {

        try
        {

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from kategoriler", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            if (e.CommandName.ToString() != ebebaba_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;


                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kategoriler set sira = sira - 1 where sira=" + degisecek_sira + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update kategoriler set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();




                alan_yukle();
            }

        }


        catch
        {


        }


    }
    protected void Button1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);

            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from kategoriler", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            int sirano = 0; if (ebebaba_dt.Rows[0][0].ToString() == "") { sirano = 1; } else { sirano = int.Parse(ebebaba_dt.Rows[0][0].ToString()) + 1; }




            MySqlCommand ebebaba_cmd = new MySqlCommand("insert into kategoriler(kategoriAdi,kategoriAciklama,sira) values (?1,?2,?3)", ebebaba_connection);


            ebebaba_cmd.Parameters.AddWithValue("?1",alanadi1.Text.TrimEnd().TrimStart().ToString());
            ebebaba_cmd.Parameters.AddWithValue("?2",aciklama1.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?3",sirano);



            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                sonuc.Text = "Kategori Kaydı Başarıyla Gerçekleşti";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                alanadi1.Text = "";
                aciklama1.Text = "";


                guncelle.Visible = false;


            }

            else
            {
              
                sonuc.Text = "Kategori Kaydı İşlemi Başarısız !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
          
            sonuc.Text = "Kategori Kaydı İşlemi Başarısız !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }
    protected void mesajgonder_Click(object sender, ImageClickEventArgs e)
    {

        try
        {

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_id,uye_email from forumebebabauyeler", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            MySqlCommand cmd = new MySqlCommand("Insert into toplu_mesajlar(konu,mesaj,gonderme_tarihi) values (?1,?2,?3) ", ebebaba_connection);

            cmd.Parameters.AddWithValue("?1", konu.Text.ToString());
            cmd.Parameters.AddWithValue("?2", mesaj.Text.ToString());
            cmd.Parameters.AddWithValue("?3", DateTime.Now.ToString());

            ebebaba_connection.Open();
            int snc = cmd.ExecuteNonQuery();
            ebebaba_connection.Close();

            gidenmesajlariyukle();


            if (snc == 1)
            {
                int toplam = ebebaba_dt.Rows.Count;

                for (int a = 0; a < toplam; a++)
                {
                    fc.mailsend(konu.Text.ToString(), ebebaba_dt.Rows[a]["uye_email"].ToString(), mesaj.Text.ToString());

                }

                Label1.Text = "Mail Başarıyla Gönderildi.";
                Label1.ForeColor = System.Drawing.Color.Green;
                konu.Text = "";
                mesaj.Text = "";
            }
            else
            {
                Label1.Text = "Mail Gönderme Başarısız !";
                Label1.ForeColor = System.Drawing.Color.Red;
            }

        }
        catch
        {

            Label1.Text = "Mail Gönderme Başarısız !";
            Label1.ForeColor = System.Drawing.Color.Red;
        }
        
    }


    protected void gidenkonu_Command(object sender, CommandEventArgs e)
    {

        try
        {

            gidenpanel.Visible = false;
            gidenmesajoku.Visible = true;

   

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from toplu_mesajlar where mesaj_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            mesajokumesajid2.Text = e.CommandArgument.ToString();
            mesajokutarih2.Text = ebebaba_dt.Rows[0]["gonderme_tarihi"].ToString();
            mesajokukonu2.Text = ebebaba_dt.Rows[0]["konu"].ToString();
            mesajokumesaj2.Text = ebebaba_dt.Rows[0]["mesaj"].ToString();


        }
        catch
        {

        }
    }
    protected void gidendeara_TextChanged(object sender, EventArgs e)
    {
        try
        {

       

            Session["mailmesajsession"] = "select * from toplu_mesajlar where konu like '%" + gidendeara.Text + "%' or mesaj like '%" + gidendeara.Text + "%' order by str_to_date(gonderme_tarihi,'%d.%m.%Y %H:%i:%s') desc";

            gidenmesajlariyukle();
        }
        catch
        {

            gidenmesajlariyukle();

        }
    }
    protected void gidensil_Click(object sender, EventArgs e)
    {


        try
        {
         

            int toplamsilinen = 0;
            int sayi = gidenmesajlistesi.Items.Count;

            CheckBox cb = new CheckBox();

            Label mesajID = new Label();

            for (int a = 0; a < sayi; a++)
            {
                cb = (CheckBox)gidenmesajlistesi.Items[a].FindControl("gidensec");
                mesajID = (Label)gidenmesajlistesi.Items[a].FindControl("gidenmesajID");

                if (cb.Checked == true)
                {


                    MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);

                    MySqlCommand cmd = new MySqlCommand("delete  from toplu_mesajlar where mesaj_id=" + mesajID.Text + "", ebebaba_connection);

                    ebebaba_connection.Open();
                    int snc = cmd.ExecuteNonQuery();
                    ebebaba_connection.Close();

                    if (snc == 1)
                    {
                        toplamsilinen++;
                    }

                }



            }

            if (toplamsilinen > 0)
            {
                Label10.Text = "Seçilen Mesajlar Başarıyla Silindi.";
                Label10.ForeColor = System.Drawing.Color.Green;



                gidenmesajlariyukle();

                //menuyukle();


                //ebebaba_master a = (ebebaba_master)this.Master;
                //a.menuyukle();



            }
            else
            {
                Label10.Text = "Mesajlar Silinemedi!";
                Label10.ForeColor = System.Drawing.Color.Red;

            }

        }
        catch
        {

        }


    }
    protected void gidenedon_Click(object sender, EventArgs e)
    {

        gidenmesajlariyukle();
        gidenmesajoku.Visible = false;
        gidenpanel.Visible = true;

    }
    protected void gidenmesajsil_Command(object sender, CommandEventArgs e)
    {

        try
        {

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlCommand cmd = new MySqlCommand("Delete from toplu_mesajlar where mesaj_id=" + mesajokumesajid2.Text + "", ebebaba_connection);

            ebebaba_connection.Open();
            cmd.ExecuteNonQuery();
            ebebaba_connection.Close();

            gidenmesajlariyukle();
            gidenmesajoku.Visible = false;
            gidenpanel.Visible = true;
        }
        catch
        { }


    }
    private void gidenmesajlariyukle()
    {


        //try
        //{

           

            MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter(Session["mailmesajsession"].ToString(), ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            gidenmesajlistesi.DataSource = ebebaba_dt;
            gidenmesajlistesi.DataBind();

            if (ebebaba_dt.Rows.Count == 0)
            {
                gidensil.Enabled = false;
                Label10.Text = "Daha Önce Gönderilen Toplu Mesaj Yok !";
                Label10.ForeColor = System.Drawing.Color.Red;
                Label10.Visible = true;
            }
            else
            {
                gidensil.Enabled = true;
                Label10.Visible = false;
            }

            gidensayi.Text = "(" + ebebaba_dt.Rows.Count.ToString() + ")";


            int a = 0;

          
            LinkButton konu = new LinkButton();
            Label tarih = new Label();
            Label mesajID = new Label();
            Image resim = new Image();

            string hepsinisec = "if(document.getElementById('ctl00_Contentplaceholder2_gidensecana').checked == true){";
            string hepsiiptal = "} else if(document.getElementById('ctl00_Contentplaceholder2_gidensecana').checked == false){";

            string silinecekbak = "if(";


            int toplam = ebebaba_dt.Rows.Count - 1;

            foreach (DataListItem oge in gidenmesajlistesi.Items)
            {

               
                konu = (LinkButton)oge.FindControl("gidenkonu");
                tarih = (Label)oge.FindControl("gidistarih");
                mesajID = (Label)oge.FindControl("gidenmesajID");
                mesajID.Text = ebebaba_dt.Rows[a]["mesaj_id"].ToString();

                konu.Text = ebebaba_dt.Rows[a]["konu"].ToString();

                konu.CommandArgument = ebebaba_dt.Rows[a]["mesaj_id"].ToString();

                tarih.Text = ebebaba_dt.Rows[a]["gonderme_tarihi"].ToString();


                if (a < 10)
                {

                    hepsinisec += "document.getElementById('ctl00_Contentplaceholder2_gidenmesajlistesi_ctl0" + a.ToString() + "_gidensec').checked = true";
                    hepsiiptal += "document.getElementById('ctl00_Contentplaceholder2_gidenmesajlistesi_ctl0" + a.ToString() + "_gidensec').checked = false";
                    silinecekbak += "document.getElementById('ctl00_Contentplaceholder2_gidenmesajlistesi_ctl0" + a.ToString() + "_gidensec').checked == false";

                    if (a != toplam)
                    {
                        hepsinisec += ";";
                        hepsiiptal += ";";
                        silinecekbak += " && ";
                    }
                }
                else
                {

                    hepsinisec += "document.getElementById('ctl00_Contentplaceholder2_gidenmesajlistesi_ctl" + a.ToString() + "_gidensec').checked = true";
                    hepsiiptal += "document.getElementById('ctl00_Contentplaceholder2_gidenmesajlistesi_ctl" + a.ToString() + "_gidensec').checked = false";
                    silinecekbak += "document.getElementById('ctl00_Contentplaceholder2_gidenmesajlistesi_ctl" + a.ToString() + "_gidensec').checked == false";

                    if (a != toplam)
                    {
                        hepsinisec += ";";
                        hepsiiptal += ";";
                        silinecekbak += " && ";
                    }
                }

                if (a == toplam)
                {
                    hepsiiptal += "}";
                    silinecekbak += ") {alert('Lütfen Silmek İstediğiniz Mesajı veya Mesajları Seçiniz !');return false;}";
                }

                a++;

            }


            string birlestir = hepsinisec + hepsiiptal;

            gidensecana.Attributes.Add("OnClick", birlestir);

            gidensil.OnClientClick = silinecekbak;

          


        //}
        //catch
        //{


        //}

    }
    protected void btnonay_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update forum_konulari  set yayin='+' where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
        ebebaba_connection.Open();
        cmd.ExecuteNonQuery();
        ebebaba_connection.Close();

        konuyukle();
        mesajsay();


        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forum_konulari where ID="+e.CommandArgument.ToString()+"", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);


        string alici = fc.uyeemail(e.CommandName.ToString());
        string mesaj = "Merhaba " + fc.uyebilgi(e.CommandName.ToString()) + "<br>" + ebebaba_dt.Rows[0]["tarih"].ToString() + " Tarihinde yazmış olduğunuz aşağıdaki konu yönetici tarafından yayınlanmıştır.<br><br>Konu : " + ebebaba_dt.Rows[0]["baslik"].ToString() + "<br>İçerik : " + ebebaba_dt.Rows[0]["icerik"].ToString() + "<br><br>Prof.Dr.Tayfun ALPER Sağlıklı Günler Diler...";

        fc.mailsend("tayfunalper.com Forum'da Açtığınız Konu Onaylanmıştır.",alici,mesaj);



    }
    protected void btnsil_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Delete from forum_konulari where ID="+e.CommandArgument.ToString()+"", ebebaba_connection);
        ebebaba_connection.Open();
        cmd.ExecuteNonQuery();
        ebebaba_connection.Close();

        konuyukle();
        mesajsay();
    }
    protected void btnonay2_Command(object sender, CommandEventArgs e)
    {

  MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update forum_cevaplari set yayin='+' where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
        ebebaba_connection.Open();
        cmd.ExecuteNonQuery();
        ebebaba_connection.Close();
   cevapyukle();
        mesajsay();
        if (e.CommandName != "-")
        { 
        
           MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from forum_cevaplari where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);


        string alici = fc.uyeemail(e.CommandName.ToString());
        string mesaj = "Merhaba " + fc.uyebilgi(e.CommandName.ToString()) + "<br>" + ebebaba_dt.Rows[0]["tarih"].ToString() + " Tarihinde tayfunalper.com Forumda Yazmış Olduğunuz Cevap Yönetici Tarafından Yayınlanmıştır.<br><br>İçerik : " + ebebaba_dt.Rows[0]["icerik"].ToString() + "<br><br>Ebebaba Forum Sağlıklı Günler Diler...";
        
        fc.mailsend("tayfunalper.com Forum'da Yazdığınız Cevap Yayınlanmıştır.", alici, mesaj);

        
        }
      

     


     


    }
    protected void btnsil2_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Delete from forum_cevaplari where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
        ebebaba_connection.Open();
        cmd.ExecuteNonQuery();
        ebebaba_connection.Close();

        cevapyukle();
        mesajsay();
    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {



        string suyelik = "";
        string skonu = "";
        string scevap = "";

        if (uyelik.Checked == true)
            suyelik = "+";
        else
            suyelik = "-";

        if (cbkonu.Checked == true)
            skonu = "+";
        else
            skonu = "-";

        if (cbcevap.Checked == true)
            scevap = "+";
        else
            scevap = "-";


        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update forum_ayar set uyelik='"+suyelik+"',konu = '"+skonu+"',cevap='"+scevap+"' where ID=1", ebebaba_connection);
        ebebaba_connection.Open();
        int a = cmd.ExecuteNonQuery();
        ebebaba_connection.Close();



        if (a == 1)
        {
            ayarsnc.Text = "Değişiklikler Başarıyla Kaydedildi";
            ayarsnc.ForeColor = System.Drawing.Color.Green;
        }
        else
        {
            ayarsnc.Text = "Değişiklikler Kaydedilemedi!";
            ayarsnc.ForeColor = System.Drawing.Color.Red;
        }


    }
    protected void imgsil_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Delete from forumebebabauyeler where uye_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


        ebebaba_connection.Open();
        int a = cmd.ExecuteNonQuery();
        ebebaba_connection.Close();

        if (a == 1)
        {
            snc.Text = "Üye Kaydı Başarıyla Silindi.";
            snc.ForeColor = System.Drawing.Color.Green;
            onaybekleyenuyeyukle();
            mesajsay();

        }
        else
        {

            snc.Text = "Üye Kaydı Silinemedi!";
            snc.ForeColor = System.Drawing.Color.Red;

        
        }
    }
    protected void imgonay_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection ebebaba_connection = fc.connect_forum(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update forumebebabauyeler  set onayverildimi = '+' where uye_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


        ebebaba_connection.Open();
        int a = cmd.ExecuteNonQuery();
        ebebaba_connection.Close();

        if (a == 1)
        {
            snc.Text = "Üyenin Hesabı Başarıyla Aktif Hale Getirildi.";
            snc.ForeColor = System.Drawing.Color.Green;
            onaybekleyenuyeyukle();
            mesajsay();

            string gidecekmesaj = "Merhaba " + fc.uyebilgi(e.CommandArgument.ToString()) + "<br><br>" + "tayfunalper.com Forum Üyeliğiniz " + DateTime.Now.ToString() + " Tarihi itibariyle aktif hale getirilmiştir.<br>Prof.Dr.Tayfun ALPER Sağlıklı Günler Diler...";


            fc.mailsend("tayfunalper.com Forum Hesabınız Aktif Hale Getirildi", e.CommandName.ToString(), gidecekmesaj);



        }
        else
        {

            snc.Text = "Üye Hesabı Aktif Hale Getirilemedi!";
            snc.ForeColor = System.Drawing.Color.Red;


        }



    }
}
