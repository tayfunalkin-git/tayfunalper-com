using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Web.UI.HtmlControls;

public partial class NewMasterPage : System.Web.UI.MasterPage
{

    ebebaba_connect_class ta = new ebebaba_connect_class();
    forum_class fc = new forum_class();
    protected void Page_Load(object sender, EventArgs e)
    {
       
            anaMenuYukle();
            duyuruYukle();

            //Page.MaintainScrollPositionOnPostBack = true;
       
    }

    private void duyuruYukle()
    {

        MySqlConnection connect_word = ta.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from duyurular where yayin='1' order by CAST(sira as UNSIGNED) asc", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        int a = 0;
        string sonuc = "";
        for (int b = 0; b < dt.Rows.Count; b++)
        {
            if (b == 0)
            {

                if (dt.Rows[a]["link"].ToString() != "")
                {
                    sonuc += "<li><div class='baslik10'><a href='" + dt.Rows[a]["link"].ToString() + "'>" + dt.Rows[a]["konu"].ToString() + "</a></div><div class='baslik20'><a href='" + dt.Rows[a]["link"].ToString() + "'>" + dt.Rows[a]["metin"].ToString() + "</a></div><div><br><br><br><br><br></div></li>";
                }
                else
                {
                    sonuc += "<li><div class='baslik10'>" + dt.Rows[a]["konu"].ToString() + "</div><div class='baslik20'>" + dt.Rows[a]["metin"].ToString() + "</div><div><br><br><br><br><br></div></li>";
                }
            }
            else
            {
                if (dt.Rows[a]["link"].ToString() != "")
                {
                    sonuc += "<li><div class='baslik10'><a href='" + dt.Rows[a]["link"].ToString() + "'>" + dt.Rows[a]["konu"].ToString() + "</a></div><div class='baslik20'><a href='" + dt.Rows[a]["link"].ToString() + "'>" + dt.Rows[a]["metin"].ToString() + "</a></div></li>";
                }
                else
                {
                    sonuc += "<li><div class='baslik10'>" + dt.Rows[a]["konu"].ToString() + "</div><div class='baslik20'>" + dt.Rows[a]["metin"].ToString() + "</div></li>";
                }
            }

            a++;
        }

        bxslider.InnerHtml = sonuc;
    
    }

    private void anaMenuYukle()
    {

        try
        {

            HtmlGenericControl ulListe = new HtmlGenericControl("ul");

            ulListe.Attributes.Add("class", "topmenu");
            ulListe.Attributes.Add("id", "css3menu1");

            HtmlGenericControl liListe2 = new HtmlGenericControl("li");

            liListe2.InnerHtml = "<a href='Default.aspx' style='height:15px;line-height:15px;'>Anasayfa</a>";
            liListe2.Attributes.Add("class", "active");

            HtmlGenericControl liListe22 = new HtmlGenericControl("li");

            //liListe22.InnerHtml = "<a href='http://www.tayfunalper.com/forum/konu_goruntule.aspx?Konu_ID=2' style='height:15px;line-height:15px;'>Forum</a>";
            //liListe22.Attributes.Add("class", "active");

           
            ulListe.Controls.Add(liListe2);
            //ulListe.Controls.Add(liListe22);
          

            MySqlConnection connect_word = ta.connect_ebebaba(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from kitaplar where not id=299 and goster='1' order by CAST(sira as UNSIGNED) asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);



            MySqlDataAdapter da44 = new MySqlDataAdapter("Select * from kitaplar where not id=299 order by CAST(sira as UNSIGNED) asc", connect_word);
            DataTable dt44 = new DataTable();
            da44.Fill(dt44);



            string eklenecek = "";



            for (int k = 0; k < dt44.Rows.Count; k++)
            {
                eklenecek = "<div class='col'><h2><a href='../Default.aspx'>Anasayfa</a><br><br><a href='http://ivf.tayfunalper.com/makale.aspx?Bolum_ID=326&Konu_ID=533'>İletişim</a><br><br><a href='http://www.tayfunalper.com'>tayfunalper.com</a><br>2012 ©</h2></div>";
            }

            if (!IsPostBack)
            {
                foot.InnerHtml += eklenecek;

            }

            if (dt4.Rows.Count != 0)
            {

                for (int k = 0; k < dt4.Rows.Count; k++)
                {

                    string degerim = "";
                    if (dt4.Rows[k]["id"].ToString() != "326")
                    {
                        degerim = "<div class='col'><h2>" + dt4.Rows[k]["kitap_adi"].ToString() +
    "</h2><ul>";
                    }
                    HtmlGenericControl liListe = new HtmlGenericControl("li");

                    if (dt4.Rows[k]["id"].ToString() != "326")
                    {

                        liListe.InnerHtml = "<a href='#' style='height:15px;line-height:15px;'>" + dt4.Rows[k]["kitap_adi"].ToString() + "</a>";

                        liListe.Attributes.Add("class", "topmenu");
                    }
                    else
                    {
                        liListe.InnerHtml = "<a href='http://ivf.tayfunalper.com/makale.aspx?Bolum_ID=326&Konu_ID=533' style='height:15px;line-height:15px;'>İletişim</a>";
                        liListe.Attributes.Add("class", "topmenu");

                    }

                    MenuItem mItem = new MenuItem(dt4.Rows[k]["kitap_adi"].ToString(), dt4.Rows[k]["id"].ToString(), "", "", "");
                    MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from kitapkategorileri where kitap_id='" + dt4.Rows[k]["id"].ToString() + "' and yayin='1' order by sira asc", connect_word);
                    DataTable dt = new DataTable();
                    da2.Fill(dt);
                    int a = 0;

                    HtmlGenericControl altListe = new HtmlGenericControl("ul");
                    altListe.Attributes.Add("id", "deneme");
                    foreach (DataRow drw in dt.Rows)
                    {
                        MenuItem main = new MenuItem();
                        main.Text = drw["kategori_adi"].ToString();

                        main.Value = drw["id"].ToString();
                        HtmlGenericControl alt2Liste = new HtmlGenericControl("li");
                        if (drw["kategori_adi"].ToString() != "")
                        {


                            alt2Liste.InnerHtml = "<a href='#' style='height:15px;line-height:15px;'>" + drw["kategori_adi"].ToString() + "</a>";
                            altListe.Controls.Add(alt2Liste);


                        }



                        MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from kitap_konulari where kategori_id = '" + drw["id"].ToString() + "' and yayin='1' order by sira asc", connect_word);
                        DataTable dtsub = new DataTable();
                        da3.Fill(dtsub);

                        int b = 0;
                        HtmlGenericControl alt3Liste = new HtmlGenericControl("ul");
                            
                        foreach (DataRow drwsub in dtsub.Rows)
                            {
                                if (dt4.Rows[k]["id"].ToString() != "326")
                                {
                                    degerim += "<li><a href='makale.aspx?Bolum_ID=" + dt4.Rows[k]["id"].ToString() + "&Konu_ID=" + drwsub["konu_id"].ToString() + "'>" + drwsub["konu"].ToString() + "</a></li>";
                                }

                                MenuItem alt = new MenuItem();
                                alt.Text = "<img src ='imgs/menu.gif' border='0'> " + drwsub["konu"].ToString();
                                alt.Value = drwsub["konu_id"].ToString();

                                HtmlGenericControl alt4Liste = new HtmlGenericControl("li");

                                alt4Liste.InnerHtml = "<a href='makale.aspx?Bolum_ID=" + dt4.Rows[k]["id"].ToString() + "&Konu_ID=" + drwsub["konu_id"].ToString() + "'>" + drwsub["konu"].ToString() + "</a>";

                            
                                    alt3Liste.Controls.Add(alt4Liste);
                                    b++;

                                ListItem yeni = new ListItem();

                                yeni.Text = drwsub["konu"].ToString();
                                yeni.Value = drwsub["konu_id"].ToString();

                                //menuler.Items.Add(yeni);

                                ListItem yeni2 = new ListItem();

                                yeni2.Text = dt4.Rows[k]["id"].ToString();
                                yeni2.Value = drwsub["konu_id"].ToString();

                                //menuler2.Items.Add(yeni2);




                            }

                        if (dt4.Rows[k]["id"].ToString() != "326")
                        {

                            alt2Liste.Controls.Add(alt3Liste);
                            liListe.Controls.Add(altListe);

                       
                            a = a + 1; }
                        }
               
                    degerim += "</ul></div>";
                    if (!IsPostBack)
                    {
                        foot.InnerHtml += degerim;
                    }
                    ulListe.Controls.Add(liListe);

                }

            }

            //HtmlGenericControl liListe3 = new HtmlGenericControl("li");

            //liListe3.InnerHtml = "<a href='iletisim.aspx' style='height:15px;line-height:15px;'>İletişim</a>";
            //liListe3.Attributes.Add("class", "toplast");
            //ulListe.Controls.Add(liListe3);


      

            sasa.Controls.Add(ulListe);
        }

        catch
        {
         
        }
    }

    private string uyekontrol()
    {


        try
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



            if (ebebaba_dt.Rows.Count > 0 || ebebaba_dt2.Rows.Count > 0 || ebebaba_dt3.Rows.Count > 0)
            {

                return "1";

            }
            else
            {
                return "0";
            }
        }
        catch
        {

            return "0";
        }
    }

}
