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

public partial class ivfyonetici_hasta_modulu_Default : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();

    protected void Page_Load(object sender, EventArgs e)
    {

        bilgi_yukle();
        bilgi_yukle2();
        ozet_yukle();
     

    }

    void bilgi_yukle()
    {


        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite where hasta_id='" + hasta_id.ToString() + "' and kategori_id='27' order by str_to_date(islem_tarihi,'%d.%m.%Y') asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {

                say.Text = " (0)";


            }

            else
            {

                say.Text = " (" + dt4.Rows.Count.ToString() + ")";


            }


            inferbilgi.DataSource = dt4;
            inferbilgi.DataBind();


            int a = 0;

            Label tar = new Label();
            Label kat = new Label();
            Label sk = new Label();
            Label msj = new Label();
            Label eklyn = new Label();
            Label ektrh = new Label();
            ImageButton ack = new ImageButton();
            ImageButton kpl = new ImageButton();

            foreach (DataListItem str in inferbilgi.Items)
            {


            
                tar = (Label)str.FindControl("lbltarih");
                tar.Text = dt4.Rows[a]["islem_tarihi"].ToString();

                kat = (Label)str.FindControl("lblkategori");
                kat.Text = kategori_bul(dt4.Rows[a]["alan_id"].ToString());


                sk = (Label)str.FindControl("lblsiklus");
                sk.Text = siklus_bul(dt4.Rows[a]["siklus_id"].ToString());

              
                msj = (Label)str.FindControl("lblmesaj");
                msj.Text = "<font color=" + renkbul(dt4.Rows[a]["renk_id"].ToString()) + ">" + dt4.Rows[a]["aciklama"].ToString() + "</font>";

             

                eklyn = (Label)str.FindControl("ekleyen");
                eklyn.Text = dt4.Rows[a]["ilk_ekleyen"].ToString();

                ektrh = (Label)str.FindControl("ektarih");
                ektrh.Text = dt4.Rows[a]["kayit_tarihi"].ToString();


                a++;

            }


        }

        catch
        {

        }

    }




    void bilgi_yukle2()
    {
        
        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from infertilite where hasta_id='" + hasta_id.ToString() + "' and kategori_id='28' order by str_to_date(islem_tarihi,'%d.%m.%Y') asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {

                say2.Text = " (0)";


            }

            else
            {

                say2.Text = " (" + dt4.Rows.Count.ToString() + ")";


            }


            inferbilgi2.DataSource = dt4;
            inferbilgi2.DataBind();


            int a = 0;

            Label tar = new Label();
            Label kat = new Label();
            Label sk = new Label();
            Label msj = new Label();
            Label eklyn = new Label();
            Label ektrh = new Label();

            foreach (DataListItem str in inferbilgi2.Items)
            {

                tar = (Label)str.FindControl("lbltarih2");
                tar.Text = dt4.Rows[a]["islem_tarihi"].ToString();

                kat = (Label)str.FindControl("lblkategori2");
                kat.Text = kategori_bul(dt4.Rows[a]["alan_id"].ToString());


                sk = (Label)str.FindControl("lblsiklus2");
                sk.Text = siklus_bul(dt4.Rows[a]["siklus_id"].ToString());


                msj = (Label)str.FindControl("lblmesaj2");
                msj.Text = "<font color=" + renkbul(dt4.Rows[a]["renk_id"].ToString()) + ">" + dt4.Rows[a]["aciklama"].ToString() + "</font>";



                eklyn = (Label)str.FindControl("ekleyen2");
                eklyn.Text = dt4.Rows[a]["ilk_ekleyen"].ToString();

                ektrh = (Label)str.FindControl("ektarih2");
                ektrh.Text = dt4.Rows[a]["kayit_tarihi"].ToString();


                a++;

            }


        }

        catch
        {

        }

    }









    string kategori_bul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select infertilite_adi from infertilite_adlari where infertilite_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["infertilite_adi"].ToString();
        }
        catch
        {

            return "";

        }

    }


    string renkbul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select renk_kodu from infertilite_renkler where renk_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            if (dt4.Rows.Count == 0)
            {

                return "#000000";

            }
            else
            {
                return dt4.Rows[0]["renk_kodu"].ToString();
            }
        }
        catch
        {

            return "#000000";

        }

    }







    string siklus_bul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select concat(siklus_ay,' - ',siklus_yil) as siklusum from siklus_ana_tab where siklus_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["siklusum"].ToString();
        }
        catch
        {

            return "";

        }

    }




    void ozet_yukle()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select S.siklus_id,S.siklus_ekleyen,S.siklus_eklenme_tarihi from siklus_ana_tab S,kisa_siklus K where  S.hasta_id='" + hasta_id.ToString() + "' and (S.siklus_ay2 ='01' or S.siklus_ay2 ='02' or S.siklus_ay2 ='03' or S.siklus_ay2 ='04' or S.siklus_ay2 ='05' or S.siklus_ay2 ='06' or S.siklus_ay2 ='07' or S.siklus_ay2 ='08' or S.siklus_ay2 ='09' or S.siklus_ay2 ='10' or S.siklus_ay2 ='11' or S.siklus_ay2 ='12') and K.siklus_id = S.siklus_id order by str_to_date(concat('01.',S.siklus_ay2,'.',S.siklus_yil),'%d.%m.%Y') asc", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);


            ozet.DataSource = dt4;
            ozet.DataBind();

            say3.Text = " (" + dt4.Rows.Count.ToString() + ")";



            int a = 0;

            LinkButton sk = new LinkButton();
            Label msj1 = new Label();
            Label msj2 = new Label();
            Label msj3 = new Label();
            Label msj4 = new Label();
            Label msj5 = new Label();
            Label msj6 = new Label();
            Label sayacim = new Label();
            Label eklyn = new Label();
            Label ektrh = new Label();
            ImageButton ack = new ImageButton();
            ImageButton kpl = new ImageButton();


            foreach (DataListItem str in ozet.Items)
            {


                ack = (ImageButton)str.FindControl("acik");
                kpl = (ImageButton)str.FindControl("kapali");

                ack.CommandArgument = a.ToString();
                kpl.CommandArgument = a.ToString();



                sayacim = (Label)str.FindControl("Label3");
                sayacim.Text = a.ToString();

                sk = (LinkButton)str.FindControl("lblsiklus3");
                sk.Text = siklus_bul(dt4.Rows[a]["siklus_id"].ToString());
                sk.PostBackUrl = "infertilite.aspx?ts=1&siklus_id=" + dt4.Rows[a]["siklus_id"].ToString();

                eklyn = (Label)str.FindControl("ekleyen3");
                eklyn.Text = dt4.Rows[a]["siklus_ekleyen"].ToString();

                ektrh = (Label)str.FindControl("ektarih3");
                ektrh.Text = dt4.Rows[a]["siklus_eklenme_tarihi"].ToString();

                msj1 = (Label)str.FindControl("lblmesaj1");
                msj2 = (Label)str.FindControl("lblmesaj2");
                msj3 = (Label)str.FindControl("lblmesaj3");
                msj4 = (Label)str.FindControl("lblmesaj4");
                msj5 = (Label)str.FindControl("lblmesaj5");
                msj6 = (Label)str.FindControl("lblmesaj6");

                MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + dt4.Rows[a]["siklus_id"].ToString() + "", connect_word);
                DataTable mp_dt = new DataTable();
                mp_da.Fill(mp_dt);

                //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from infertilite2 A,infertilite_adlari S where S.infertilite_id=cint(A.kategori_id) and A.hasta_id='" + hasta_id.ToString() + "' and A.siklus_id='" + dt4.Rows[a]["siklus_id"].ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);

                MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from ana_infertilite A,infertilite_adlari S where S.infertilite_id=CAST(A.kategori_id as UNSIGNED) and A.hasta_id='" + hasta_id.ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);
                DataTable mp_dt2 = new DataTable();
                mp_da2.Fill(mp_dt2);


                if (mp_dt.Rows.Count != 0)
                {

                    string eklenecek1 = "";
                    string eklenecek2 = "";
                    string eklenecek3 = "";
                    string eklenecek4 = "";
                    string eklenecek5 = "";
                    string eklenecek6 = "";
                    string tanilar = "";

                    if (mp_dt.Rows[0]["sat"].ToString() != "")
                    {
                        eklenecek1 = eklenecek1 + "SAT : " + mp_dt.Rows[0]["sat"].ToString() + "<br>";

                    }
                    else
                    {
                        eklenecek1 = eklenecek1 + "SAT :<br>";

                    }
                    
                    if (mp_dt2.Rows.Count==0)
                    {
                        tanilar = "Açýklanamayan" + "<br>";

                    }
                    else if (mp_dt2.Rows.Count > 0)
                    {

                        if (mp_dt.Rows[0]["tani1"].ToString() != "")
                        {
                            tanilar += mp_dt.Rows[0]["tani1"].ToString() + "<br>";

                        }
                        if (mp_dt.Rows[0]["tani2"].ToString() != "")
                        {
                            tanilar += mp_dt.Rows[0]["tani2"].ToString() + "<br>";

                        }
                        if (mp_dt.Rows[0]["tani3"].ToString() != "")
                        {
                            tanilar += mp_dt.Rows[0]["tani3"].ToString() + "<br>";

                        }
                        if (mp_dt.Rows[0]["tani4"].ToString() != "")
                        {
                            tanilar += mp_dt.Rows[0]["tani4"].ToString() + "<br>";

                        }


                    
                    }
                    eklenecek1 = eklenecek1 + tanilar;
        
                    if (mp_dt.Rows[0]["tedavi_turu_id"].ToString() != "")
                    {
                        eklenecek2 = eklenecek2 + turbul(mp_dt.Rows[0]["tedavi_turu_id"].ToString()) + "<br>";

                    }
                    if (mp_dt.Rows[0]["tedavi_protokolu"].ToString() != "")
                    {
                        eklenecek2 = eklenecek2 + protokolbul(mp_dt.Rows[0]["tedavi_protokolu"].ToString()) + "<br>";

                    }
                    if (mp_dt.Rows[0]["cogul"].ToString() == "+")
                    {
                        eklenecek2 = eklenecek2 + "Çoðul Gebelik : Var" + "<br>";

                    }


                    if (mp_dt.Rows[0]["hiperstimulasyon"].ToString() == "+")
                    {
                        eklenecek2 = eklenecek2 + "Hiperstimülasyon : Var" + "<br>";

                    }
                    
                    string snc = fsh_hesap(dt4.Rows[a]["siklus_id"].ToString());




                    if (snc != "" && snc !="0")
                    { 
                    
                    eklenecek2 = eklenecek2 + "Kullanýlan FSH : " + snc + "<br>";

                    }
                  
                    if (mp_dt.Rows[0]["alan9"].ToString().Length != 0)
                    {
                        eklenecek3 = eklenecek3 + "Siklus Ýptal : " +mp_dt.Rows[0]["alan9"].ToString()+ "<br>";

                    }
                  
                    if (mp_dt.Rows[0]["ovulasyon"].ToString() == "+")
                    {
                        eklenecek3 = eklenecek3 + "Ovulasyon : Var" + "<br>";

                    }
                    else if (mp_dt.Rows[0]["ovulasyon"].ToString() == "0")
                    {
                        eklenecek3 = eklenecek3 + "Ovulasyon : Bilinmiyor" + "<br>";

                    }
                    else
                    {
                        eklenecek3 = eklenecek3 + "Ovulasyon : Yok" + "<br>";

                    }

                    if (mp_dt.Rows[0]["gebelik"].ToString() == "+")
                    {
                        eklenecek3 = eklenecek3 + "Gebelik : Var" + "<br>";

                    }
                    if (mp_dt.Rows[0]["biyokimyasal"].ToString() == "+")
                    {
                        eklenecek3 = eklenecek3 + "Biyokimyasal : Var" + "<br>";

                    }
                    if (mp_dt.Rows[0]["abortus"].ToString() == "+")
                    {
                        eklenecek3 = eklenecek3 + "Abortus : Var" + "<br>";

                    }
                    if (mp_dt.Rows[0]["dogum"].ToString() == "+")
                    {
                        eklenecek3 = eklenecek3 + "Doðum : Var" + "<br>";

                    }

                    if (mp_dt.Rows[0]["agirlik"].ToString() == "+")
                    {
                        eklenecek3 = eklenecek3 + "Aðýrlýk : Var" + "<br>";

                    }


                    MySqlDataAdapter mp_da3 = new MySqlDataAdapter("Select etk3 , etk4 , alan3,alan4 from siklus_alanlar where ID=1", connect_word);
                    DataTable mp_dt3 = new DataTable();
                    mp_da3.Fill(mp_dt3);

                    if (mp_dt3.Rows[0]["alan3"].ToString() == "+" && mp_dt.Rows[0]["alan3"].ToString() != "")
                    {


                        eklenecek3 = eklenecek3 + mp_dt3.Rows[0]["etk3"].ToString() +" : "+mp_dt.Rows[0]["alan3"].ToString() + "<br>";

                    
                    }
                    if (mp_dt3.Rows[0]["alan4"].ToString() == "+" && mp_dt.Rows[0]["alan4"].ToString() != "")
                    {


                        eklenecek3 = eklenecek3 + mp_dt3.Rows[0]["etk4"].ToString() + " : " + mp_dt.Rows[0]["alan4"].ToString() + "<br>";


                    }

                    if (mp_dt.Rows[0]["kurum_id"].ToString() != "")
                    {
                        eklenecek4 = eklenecek4 + "Kurum : " + kurumbul(mp_dt.Rows[0]["kurum_id"].ToString()) + "<br>Daha Önceki Tedaviler : <br>";


                    }


                    if (mp_dt.Rows[0]["oi"].ToString() != "")
                    {
                        eklenecek4 = eklenecek4 + "OI : " + mp_dt.Rows[0]["oi"].ToString() + "<br>";

                    }

                    if (mp_dt.Rows[0]["iui"].ToString() != "")
                    {
                        eklenecek4 = eklenecek4 + "IUI : " + mp_dt.Rows[0]["iui"].ToString() + "<br>";

                    }

                    if (mp_dt.Rows[0]["ivf"].ToString() != "")
                    {
                        eklenecek4 = eklenecek4 + "IVF : " + mp_dt.Rows[0]["ivf"].ToString() + "<br>";

                    }

                    MySqlDataAdapter mp_da6 = new MySqlDataAdapter("Select * from uye_hasta where uye_id=" + hasta_id.ToString() + "", connect_word);

                    DataTable mp_dt6 = new DataTable();
                    mp_da6.Fill(mp_dt6);

                    DateTime dogum_tarihi = DateTime.Parse(mp_dt6.Rows[0]["uye_dogum_tarihi"].ToString());
                    TimeSpan sure = DateTime.Parse(dt4.Rows[a]["siklus_eklenme_tarihi"].ToString().Substring(0, 10)) - dogum_tarihi;
                    int yeni_yas = sure.Days / 365;

                    eklenecek5 = eklenecek5 + "Yaþ : " + yeni_yas.ToString() + "<br>";


                    if (mp_dt.Rows[0]["fsh"].ToString() != "")
                    {
                        eklenecek5 = eklenecek5 + "FSH : " + mp_dt.Rows[0]["fsh"].ToString() + "<br>";

                    }
                    if (mp_dt.Rows[0]["lh"].ToString() != "")
                    {
                        eklenecek5 = eklenecek5 + "LH : " + mp_dt.Rows[0]["lh"].ToString() + "<br>";

                    }
                    if (mp_dt.Rows[0]["e2"].ToString() != "")
                    {
                        eklenecek5 = eklenecek5 + "E2 : " + mp_dt.Rows[0]["e2"].ToString() + "<br>";

                    }
                    if (mp_dt.Rows[0]["pcos"].ToString() == "+")
                    {
                        eklenecek6 = eklenecek6 + "Pcos : Var" + "<br>";

                    }
                    if (mp_dt.Rows[0]["antralsag"].ToString() != "")
                    {
                        eklenecek6 = eklenecek6 + "Antral Fol Sayýsý(SAÐ) : " + mp_dt.Rows[0]["antralsag"].ToString() + "<br>";

                    }
                    if (mp_dt.Rows[0]["antralsol"].ToString() != "")
                    {
                        eklenecek6 = eklenecek6 + "Antral Fol Sayýsý(SOL) : " + mp_dt.Rows[0]["antralsol"].ToString() + "<br>";

                    }
                    if (mp_dt.Rows[0]["oversag"].ToString() != "")
                    {
                        eklenecek6 = eklenecek6 + "Over Hacmi(SAÐ) : " + mp_dt.Rows[0]["oversag"].ToString() + "<br>";

                    }
                    if (mp_dt.Rows[0]["oversol"].ToString() != "")
                    {
                        eklenecek6 = eklenecek6 + "Over Hacmi(SOL) : " + mp_dt.Rows[0]["oversol"].ToString() + "<br>";

                    }



                    msj1.Text = eklenecek1;
                    msj2.Text = eklenecek2;
                    msj3.Text = eklenecek3;
                    msj4.Text = eklenecek4;
                    msj5.Text = eklenecek5;
                    msj6.Text = eklenecek6;



                }



                a++;

            }
        }
        catch
        {


        }


    }



    string  fsh_hesap(string siklus_idm)
    {

        double kullanilan_fsh_degeri = 0;


        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from takipli_siklus1 where siklus_id='" + siklus_idm + "'", connect_word);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows.Count == 1)
            {

                for (int i = 1; i < 15; i++)
                {

                    dt1.Rows[0]["iki" + i.ToString()].ToString();

                    if (dt1.Rows[0]["iki" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt1.Rows[0]["iki" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;

                        }
                        catch
                        { }
                    }


                }


                for (int i = 1; i < 15; i++)
                {
                    if (dt1.Rows[0]["uc" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt1.Rows[0]["uc" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }

            }




            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from takipli_siklus2 where siklus_id='" + siklus_idm +"'", connect_word);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            if (dt2.Rows.Count == 1)
            {


                for (int i = 1; i < 15; i++)
                {
                    if (dt2.Rows[0]["iki2" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt2.Rows[0]["iki2" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }


                for (int i = 1; i < 15; i++)
                {

                    if (dt2.Rows[0]["uc2" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt2.Rows[0]["uc2" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }

            }


            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from takipli_siklus3 where siklus_id='" + siklus_idm + "'", connect_word);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            if (dt3.Rows.Count == 1)
            {

                for (int i = 1; i < 8; i++)
                {

                    if (dt3.Rows[0]["iki3" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt3.Rows[0]["iki3" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch { }
                    }
                }


                for (int i = 1; i < 8; i++)
                {
                    if (dt3.Rows[0]["uc3" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt3.Rows[0]["uc3" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }

            }

            return kullanilan_fsh_degeri.ToString();
          
        }

        catch
        {
            return "0";
        }





    }


    string kontrol(string ID)
    { 
    
        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + ID.ToString() + "", connect_word);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows.Count == 0)
        {

            return "0";

        }
        else
        {
            return "1";

        }

    }
    string kurumbul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select kurum_adi from kurumlar where kurum_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["kurum_adi"].ToString();
        }
        catch
        {

            return "";

        }

    }
    string turbul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select tedavi_adi from tedavi_turleri where tur_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["tedavi_adi"].ToString();
        }
        catch
        {

            return "";

        }

    }
    string protokolbul(string ID)
    {

        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select protokol_adi from tedavi_protokolleri where protokol_id=" + ID.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            return dt4.Rows[0]["protokol_adi"].ToString();
        }
        catch
        {

            return "";

        }

    }
    protected void siklus_adi_Command(object sender, CommandEventArgs e)
    {
        Panel ypnl = new Panel();

        ypnl = (Panel)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("ayr");

        if (ypnl.Visible == true)
            ypnl.Visible = false;
        else if (ypnl.Visible == false)
            ypnl.Visible = true;

    }
    protected void kapali_Command(object sender, CommandEventArgs e)
    { 

        Panel ypnl = new Panel();

        ypnl = (Panel)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("ayr");

        ypnl.Visible = false;

        ImageButton reskapali = new ImageButton();
        reskapali = (ImageButton)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("kapali");
        reskapali.Visible = false;
        
        ImageButton resacik = new ImageButton();
        resacik = (ImageButton)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("acik");
        resacik.Visible = true;


    }
    protected void acik_Command1(object sender, CommandEventArgs e)
    {

        Panel ypnl = new Panel();

        ypnl = (Panel)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("ayr");

        ypnl.Visible = true;

        ImageButton reskapali = new ImageButton();
        reskapali = (ImageButton)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("kapali");
        reskapali.Visible = true;

        ImageButton resacik = new ImageButton();
        resacik = (ImageButton)ozet.Items[int.Parse(e.CommandArgument.ToString())].FindControl("acik");
        resacik.Visible = false;

    }


 }
