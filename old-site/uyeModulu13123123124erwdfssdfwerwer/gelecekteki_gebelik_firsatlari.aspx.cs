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

public partial class ivfyonetici_hasta_modulu_gelecekteki_gebelik_firsatlari : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();


    protected void Page_Load(object sender, EventArgs e)
    {
 
        firsatyukle();
        gunyukle();
        bilgi_yukle();

        if (!IsPostBack)
        {
            sonyukle();
        }

    }
    protected void btnEvet_Click(object sender, ImageClickEventArgs e)
    {


        DateTime dsat = mp_class.tarihcevir2(hasta_at.Text);
        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        sat_kaydet(dsat, hasta_id, mp_connection);




    }
    protected void btnHayir_Click(object sender, ImageClickEventArgs e)
    {
        btnEvet.Visible = false;
        btnHayir.Visible = false;
        Panel4.Visible = false;
    }


    void firsatyukle()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select uye_dogum_tarihi from uye_hasta where uye_id=" + hasta_id.ToString() + "", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            Label1.Text = mp_dt.Rows[0]["uye_dogum_tarihi"].ToString().Substring(0, 10);

            DateTime dogum_tarihi = DateTime.Parse(mp_dt.Rows[0]["uye_dogum_tarihi"].ToString());
            TimeSpan sure = DateTime.Now - dogum_tarihi;
            int hasta_yas = sure.Days / 365;

            int b = 1;


            for (int a = hasta_yas; a < 43; a++)
            {

                string stm = "yas" + b.ToString();

                Panel pnlm = (Panel)Panel1.FindControl(stm);
                Label lbl = new Label();
                lbl.Text = a.ToString();
                lbl.Font.Size = 8;

                lbl.Font.Name = "verdana";




                pnlm.Controls.Add(lbl);
                if (a > 17 && a < 31)
                {


                    pnlm.BackColor = System.Drawing.Color.FromName("#95C563");


                }

                else if (a > 30 && a < 36)
                {
                    pnlm.BackColor = System.Drawing.Color.FromName("#8CF88C");

                }
                else if (a > 35 && a < 40)
                {
                    pnlm.BackColor = System.Drawing.Color.FromName("#B3FAB3");

                }
                else
                {

                    pnlm.BackColor = System.Drawing.Color.FromName("#D9FDD9");


                }


                b++;
            }

            for (int a = b; a < 25; a++)
            {

                string stm = "yas" + a.ToString();

                Panel pnlm = (Panel)Panel1.FindControl(stm);
                Label lbl = new Label();
                lbl.Text = " ";

                pnlm.Controls.Add(lbl);

                pnlm.BackColor = System.Drawing.Color.FromName("#dcdcdc");

                //style=" border-left-width: 1px;
                //        border-left-color: #d3d3d3; border-bottom-width: 1px; border-bottom-color: #d3d3d3;
                //        width: 100%;  #d3d3d3; border-right-width: 1px; border-right-color: #d3d3d3"



            }



            ay_yukle(dogum_tarihi);

        }

        catch
        { 
        
        
        }
    }



    void ay_yukle( DateTime dt)
    {

        try
        {


            int Da = dt.Month;
            int gun = dt.Day;

            int yil = DateTime.Now.Date.Year;
            string yenistr = gun.ToString() + "." + Da.ToString() + "." + yil.ToString();

            DateTime yenitarih = DateTime.Parse(yenistr);

            DateTime simdikitarih = DateTime.Now.Date;


            if (simdikitarih > yenitarih)
            {

                yenitarih = yenitarih.AddYears(1);


            }

            int son = 0;

            if (yenitarih.Month == simdikitarih.Month)
            {


                Label lbl2 = new Label();
                lbl2.Text = mp_class.ayadi(simdikitarih.Month).ToString() + " " + simdikitarih.Year.ToString();

                lbl2.Font.Size = 8;
                lbl2.Font.Name = "arial";
                ay1.Controls.Add(lbl2);
                simdikitarih = simdikitarih.AddMonths(1);
            }

            else
            {






                for (int a = 1; a < 13; a++)
                {


                    if (a == 1)
                    {


                        Label lbl2 = new Label();
                        lbl2.Text = mp_class.ayadi(simdikitarih.Month).ToString() + " " + simdikitarih.Year.ToString();


                        lbl2.Font.Size = 8;
                        lbl2.Font.Name = "arial";
                        ay1.Controls.Add(lbl2);
                        simdikitarih = simdikitarih.AddMonths(1);

                    }

                    else if (a != 1)
                    {
                        if (simdikitarih.Month == yenitarih.Month)
                        {

                            son = a;

                            break;
                        }
                        else
                        {
                            if (simdikitarih < yenitarih)
                            {

                                Panel pnlm = (Panel)Panel1.FindControl("ay" + a.ToString());

                                Label lbl2 = new Label();
                                lbl2.Text = mp_class.ayadi(simdikitarih.Month).ToString() + " " + simdikitarih.Year.ToString();


                                lbl2.Font.Size = 8;
                                lbl2.Font.Name = "arial";

                                pnlm.Controls.Add(lbl2);

                                simdikitarih = simdikitarih.AddMonths(1);
                            }
                        }
                    }

                }

                if (simdikitarih.Month == yenitarih.Month)
                {


                    Panel pnlm2 = (Panel)Panel1.FindControl("ay" + son.ToString());

                    Label lbl3 = new Label();
                    lbl3.Text = mp_class.ayadi(simdikitarih.Month).ToString() + " " + yenitarih.Year.ToString();


                    lbl3.Font.Size = 8;
                    lbl3.Font.Name = "arial";

                    pnlm2.Controls.Add(lbl3);
                }


            }



        }

        catch
        { 
        
        
        }
    }





    void gunyukle()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select sat from hasta_sat where hasta_id='" + hasta_id.ToString() + "' order by str_to_date(sat,'%d.%m.%Y') desc limit 0,3", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);



            string sat1 = "";
            string sat2 = "";
            string sat3 = "";


            if (mp_dt.Rows.Count == 0)
            {

                Panel2.Visible = true;
                Label3.Text = "Bu Hastaya Ait bir AT deðeri bulunamadý !";
                Label3.ForeColor = System.Drawing.Color.Red;
                Panel3.Visible = false;


            }

            else
            {

                try
                {
                    sat1 = mp_dt.Rows[0]["sat"].ToString();
                }
                catch
                { }
                try
                {
                    sat2 = mp_dt.Rows[1]["sat"].ToString();
                }
                catch
                { }
                try
                {
                    sat3 = mp_dt.Rows[2]["sat"].ToString();
                }
                catch
                { }




                TimeSpan sure5 = DateTime.Now.Date - DateTime.Parse(sat1);

                if (sure5.Days > 35)
                {

                    Panel2.Visible = true;
                    Label3.Text = "Sisteme girilen SAT tarihinin yenilenmesi gerekmektedir !";
                    Label3.ForeColor = System.Drawing.Color.Red;
                    Panel3.Visible = false;

                }

                else
                {

                    int fark1;
                    int fark2;
                    int snc;
                    int ekleme = 9;

                    int siklus = 28;

                    string yeni_sat = "";
                    string start = "";
                    if (sat1 != "" && sat2 != "" && sat3 != "")
                    {
                        TimeSpan sure = DateTime.Parse(sat2) - DateTime.Parse(sat3);
                        fark1 = sure.Days;



                        TimeSpan sure2 = DateTime.Parse(sat1) - DateTime.Parse(sat2);
                        fark2 = sure2.Days;
                        snc = (fark1 + fark2) / 2;

                        if ((fark1 < 21) || (fark1 > 35) || (fark2 < 21) || (fark2 > 35) || (snc < 21) || (snc > 35))
                        {

                            siklus = 28;
                            yeni_sat = (DateTime.Parse(sat1)).AddDays(28).ToString();
                            ekleme = siklus - 28;

                            start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();

                        }

                        else
                        {

                            siklus = snc;

                            yeni_sat = (DateTime.Parse(sat1)).AddDays(snc).ToString();
                            ekleme = siklus - 28;

                            start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();


                        }
                    }

                    else if (sat1 != "" && sat2 != "" && sat3 == "")
                    {
                        TimeSpan sure2 = DateTime.Parse(sat1) - DateTime.Parse(sat2);
                        fark2 = sure2.Days;

                        if (fark2 < 21 || fark2 > 35)
                        {

                            siklus = 28;

                            yeni_sat = (DateTime.Parse(sat1)).AddDays(28).ToString();
                            ekleme = siklus - 28;

                            start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();



                        }

                        else
                        {
                            siklus = fark2;

                            yeni_sat = (DateTime.Parse(sat1)).AddDays(fark2).ToString();
                            ekleme = siklus - 28;

                            start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();


                        }

                    }


                    else if (sat1 != "" && sat2 == "" && sat3 == "")
                    {

                        siklus = 28;

                        yeni_sat = (DateTime.Parse(sat1)).AddDays(28).ToString();
                        ekleme = siklus - 28;

                        start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();



                    }



                    else if (sat1 != "" && sat2 == "" && sat3 != "")
                    {


                        TimeSpan sure2 = DateTime.Parse(sat1) - DateTime.Parse(sat3);
                        fark2 = sure2.Days / 2;


                        if (fark2 < 21 || fark2 > 35)
                        {

                            siklus = 28;

                            yeni_sat = (DateTime.Parse(sat1)).AddDays(28).ToString();
                            ekleme = siklus - 28;

                            start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();

                        }

                        else
                        {
                            siklus = fark2;

                            yeni_sat = (DateTime.Parse(sat1)).AddDays(fark2).ToString();
                            ekleme = siklus - 28;

                            start = DateTime.Parse(sat1).AddDays(9).AddDays(ekleme).ToString();



                        }


                    }


                    for (int b = 1; b < 7; b++)
                    {


                        Panel pnlm = (Panel)Panel3.FindControl("tar" + b.ToString());
                        Label lbl = new Label();
                        lbl.Text = DateTime.Parse(start).AddDays(b - 1).Day.ToString() + " " + mp_class.ayadi(DateTime.Parse(start).AddDays(b - 1).Month) + "<br>" + mp_class.gunadi(DateTime.Parse(start).AddDays(b - 1).DayOfWeek.ToString());


                        lbl.Font.Size = 8;

                        lbl.Font.Name = "verdana";




                        pnlm.Controls.Add(lbl);



                    }




                    st.Text = sat1.ToString();

                    sk.Text = siklus.ToString();

                    at.Text = yeni_sat.ToString().Substring(0, 10);





                }




            }
        }

        catch
        { 
        
        
        }
    }



    //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    //{

    //    DateTime dsat = mp_class.tarihcevir2(hasta_at.Text);

    //    if (dsat > DateTime.Now)
    //    {
    //        Panel4.Visible = true;
    //        Labelsonuc.Text = "Sistem Tarihinden Büyük Bir Tarih Girildi !Ýþlem Baþarýsýz.";
    //        Labelsonuc.ForeColor = System.Drawing.Color.Red;

    //    }
    //    else
    //    {


    //        try
    //        {


    //            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
    //            String hasta_id = islemdekihasta["HastaID"];

    //            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
    //            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' and sat='" + dsat.ToString().Substring(0,10)+ "'", mp_connection);
    //            DataTable mp_dt = new DataTable();
    //            mp_da.Fill(mp_dt);



    //            if (mp_dt.Rows.Count == 1)
    //            {

    //                Panel4.Visible = true;
    //                Labelsonuc.Text = "Girilen Tarih Daha Önce Kaydedilmiþtir !Ýþlem Baþarýsýz.";
    //                Labelsonuc.ForeColor = System.Drawing.Color.Red;

    //            }

    //            else
    //           {


    //                HttpCookie mpKullanilan = Request.Cookies["AdminK"];
    //                string kullaniciAdi = mp_class.doktor_kullanici_adi_bul(mpKullanilan["AdminKKA"].ToString());
    //                MySqlCommand cmd = new MySqlCommand("insert into hasta_sat(sat,hasta_id,eklenme_tarihi,ekleyen) values ('" + dsat.ToString().Substring(0,10) + "','" + hasta_id.ToString() + "','" + DateTime.Now.ToString() + "','" + kullaniciAdi.ToString() + "')", mp_connection);

    //                mp_connection.Open();
    //                int snc = cmd.ExecuteNonQuery();
    //                mp_connection.Close();


    //                //Buradan itibaren yeni eklenenler

    //                string gunkontrol = dsat.Day.ToString();
    //                string aykontrol = dsat.Month.ToString();
    //                string yilkontrol = dsat.Year.ToString();

    //    DateTime yenitarihim = new DateTime(int.Parse(yilkontrol), int.Parse(aykontrol), int.Parse(gunkontrol));

    
    //    string kullaniciAdi2 = mpKullanilan["AdminKKA"].ToString();
    //    MySqlCommand mp_cmd = new MySqlCommand("insert into siklus_ana_tab(siklus_ay,siklus_yil,hasta_id,siklus_ekleyen,siklus_eklenme_tarihi,siklus_ay2) values ('" + mp_class.ayadi(int.Parse(aykontrol.ToString())) + "','" + yilkontrol.ToString() + "','" + hasta_id.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdi2.ToString()) + "','" + DateTime.Now.ToString() + "','" + aykontrol.ToString() + "')", mp_connection);


    //    mp_connection.Open();
    //    int eks = mp_cmd.ExecuteNonQuery();
    //    mp_connection.Close();


    //    if (eks == 1 && snc ==1)
    //    {


    //        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select * from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay='" + mp_class.ayadi(int.Parse(aykontrol.ToString())) + "' and siklus_yil='" + yilkontrol.ToString() + "' order by str_to_date(siklus_eklenme_tarihi,'%d.%m.%Y') desc limit 0,1", mp_connection);

    //        DataTable mp_dt2 = new DataTable();
    //        mp_da2.Fill(mp_dt2);

            
    //        MySqlDataAdapter mp_da25 = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' and sat='" + yenitarihim.Date.ToString().Substring(0, 10) + "'", mp_connection);

    //        DataTable mp_dt25 = new DataTable();
    //        mp_da25.Fill(mp_dt25);

    //        if (mp_dt25.Rows.Count == 0)
    //        {
    //            MySqlCommand mp_cmd3 = new MySqlCommand("insert into hasta_sat(hasta_id,sat,eklenme_tarihi,ekleyen) values ('" + hasta_id.ToString() + "','" + yenitarihim.Date.ToString().Substring(0, 10) + "','" + DateTime.Now.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdi2.ToString()) + "')", mp_connection);

    //            mp_connection.Open();
    //            int eks3 = mp_cmd3.ExecuteNonQuery();
    //            mp_connection.Close();

    //        }

    //        string[] sonuc_gelen = new string[4];

    //        sonuc_gelen = taniyukle().Split('/');

    //        MySqlCommand mp_cmd35 = new MySqlCommand("insert into kisa_siklus(sat,siklus_id,tani1,tani2,tani3,tani4) values ('" + yenitarihim.Date.ToString().Substring(0, 10) + "','" + mp_dt2.Rows[0]["siklus_id"].ToString() + "','" + sonuc_gelen[0] + "','" + sonuc_gelen[1] + "','" + sonuc_gelen[2] + "','" + sonuc_gelen[3] + "')", mp_connection);
    //        mp_connection.Open();
    //        int eks35 = mp_cmd35.ExecuteNonQuery();
    //        mp_connection.Close();


    //        Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + mp_dt2.Rows[0]["siklus_id"].ToString());



    //        Panel4.Visible = true;
    //        Labelsonuc.Text = "Adet Tarihi Baþarýyla Kaydedilmiþtir.";
    //        Labelsonuc.ForeColor = System.Drawing.Color.Green;

    //        bilgi_yukle();
    //        hasta_at.Text = "";
    //        firsatyukle();

    //        gunyukle();
    //    }


    //    else
    //    {
    //        Panel4.Visible = true;
    //        Labelsonuc.Text = "Kaydetme Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";

    //        Labelsonuc.ForeColor = System.Drawing.Color.Red;

    //    }
  



    //           }

    //        }

    //        catch
    //        {
    //            Panel4.Visible = true;
    //            Labelsonuc.Text = "Kaydetme Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";

    //            Labelsonuc.ForeColor = System.Drawing.Color.Red;


    //        }


    //    }


      
    
    //}
    void bilgi_yukle()
    {

        //try
        //{
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' order by str_to_date(sat,'%d.%m.%Y') desc", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            list.DataSource = mp_dt;
            list.DataBind();

            LinkButton lbtn = new LinkButton();
            int i = 0;
            foreach (GridViewRow str in list.Rows)
            {

                lbtn = (LinkButton)str.FindControl("sil");

                lbtn.CommandArgument = mp_dt.Rows[i]["sat_id"].ToString();
                lbtn.CommandName = mp_dt.Rows[i]["sat"].ToString();

                i++;



            }

            //Panel4.Visible = true;

            Labelsonuc.Text = " Toplam Kayýtlý AT Sayýsý : " + mp_dt.Rows.Count;
        //}


        //catch
        //{
        //    Panel4.Visible = true;

        //    Labelsonuc.Text = "Bilgiler Yüklenirken Hata Oluþtu !";

        //}

    }
    protected void list_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        list.PageIndex = e.NewPageIndex;
        list.DataBind();




    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select K.sat from kisa_siklus K,siklus_ana_tab S where S.siklus_id=K.siklus_id and K.sat='" + e.CommandName.ToString() + "' and S.hasta_id='"+hasta_id.ToString()+"'", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);


            if (mp_dt.Rows.Count > 0)
            {
                Panel4.Visible = true;
                Label5.Text = "Silinmek Ýstenilen Tarih Sistem Tarafýndan Kullanýlýyor.Silme Ýþlemi Baþarýsýz !";


                Label5.ForeColor = System.Drawing.Color.Red;


            }
            else
            {

                MySqlCommand cmd = new MySqlCommand("delete from hasta_sat where sat_id=" + e.CommandArgument.ToString() + "", mp_connection);

                mp_connection.Open();
                int snc = cmd.ExecuteNonQuery();
                mp_connection.Close();

                if (snc == 1)
                {

                    Panel4.Visible = true;
                    Label5.Text = "Adet Tarihi Baþarýyla Silindi.";
                    Label5.ForeColor = System.Drawing.Color.Green;

                    bilgi_yukle();
                    firsatyukle();
                    gunyukle();


                }

                else
                {
                    Panel4.Visible = true;
                    Label5.Text = "Silme Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";

                    Label5.ForeColor = System.Drawing.Color.Red;


                }
            }


        }
        catch
        {
            Panel4.Visible = true;
            Label5.Text = "Silme Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";
            Label5.ForeColor = System.Drawing.Color.Red;



    }

    }
    //string taniyukle()
    //{

    //    try
    //    {
    //        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
    //        String hasta_id = islemdekihasta["HastaID"];


    //        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
    //        //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from infertilite2 A,infertilite_adlari S where S.infertilite_id=cint(A.kategori_id) and A.hasta_id='" + hasta_id.ToString() + "' and A.siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);

    //        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from ana_infertilite A,infertilite_adlari S where S.infertilite_id=CAST(A.kategori_id as UNSIGNED) and A.hasta_id='" + hasta_id.ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);
    //        DataTable mp_dt2 = new DataTable();
    //        mp_da2.Fill(mp_dt2);


    //        string sonuc = "";
    //        if (mp_dt2.Rows.Count == 0)
    //        {
    //            sonuc = "Açýklanamayan///";
    //        }

    //        if (mp_dt2.Rows.Count == 1)
    //        {

    //            if (mp_dt2.Rows[0][0].ToString() != "")
    //            {

    //                sonuc += mp_dt2.Rows[0][0].ToString() + "///";

    //            }
    //            else
    //            {
    //                sonuc += "///";
    //            }

    //        }



    //        if (mp_dt2.Rows.Count == 2)
    //        {

    //            if (mp_dt2.Rows[0][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[0][0].ToString() + "/";

    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }


    //            if (mp_dt2.Rows[1][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[1][0].ToString() + "//";

    //            }
    //            else
    //            {
    //                sonuc += "//";
    //            }

    //        }


    //        if (mp_dt2.Rows.Count == 3)
    //        {

    //            if (mp_dt2.Rows[0][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[0][0].ToString() + "/";

    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }


    //            if (mp_dt2.Rows[1][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[1][0].ToString() + "/";

    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }



    //            if (mp_dt2.Rows[2][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[2][0].ToString() + "/";
    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }


    //        }


    //        if (mp_dt2.Rows.Count == 4)
    //        {

    //            if (mp_dt2.Rows[0][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[0][0].ToString() + "/";

    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }


    //            if (mp_dt2.Rows[1][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[1][0].ToString() + "/";

    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }



    //            if (mp_dt2.Rows[2][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[2][0].ToString() + "/";
    //            }
    //            else
    //            {
    //                sonuc += "/";
    //            }


    //            if (mp_dt2.Rows[3][0].ToString() != "")
    //            {
    //                sonuc += mp_dt2.Rows[3][0].ToString();
    //            }
    //            else
    //            {
    //                sonuc += "";
    //            }
    //        }


    //        return sonuc;

    //    }
    //    catch
    //    {


    //        return "Açýklanamayan///";

    //    }
    //}
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        DateTime dsat = mp_class.tarihcevir2(hasta_at.Text);

        if (dsat > DateTime.Now)
        {
            Panel4.Visible = true;
            Label5.Text = "Sistem Tarihinden Büyük Bir Tarih Girildi !Ýþlem Baþarýsýz.";
            Label5.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            //try
            //{
                HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
                String hasta_id = islemdekihasta["HastaID"];
                MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
                MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' and sat='" + dsat.ToString().Substring(0, 10) + "'", mp_connection);
                DataTable mp_dt = new DataTable();
                mp_da.Fill(mp_dt);


                if (mp_dt.Rows.Count == 1)
                {

                    Panel4.Visible = true;
                    Label5.Text = "Girilen Tarih Daha Önce Kaydedilmiþtir !Ýþlem Baþarýsýz.";
                    Label5.ForeColor = System.Drawing.Color.Red;

                }

                else
                {


                    MySqlDataAdapter mp_da5 = new MySqlDataAdapter("Select sat from hasta_sat where hasta_id='" + hasta_id.ToString() + "' order by str_to_date(sat,'%d.%m.%Y') desc limit 0,1", mp_connection);
                    DataTable mp_dt5 = new DataTable();
                    mp_da5.Fill(mp_dt5);



                    if (mp_dt5.Rows.Count == 1)
                    {


                        TimeSpan fark = dsat - DateTime.Parse(mp_dt5.Rows[0][0].ToString());
                        if (fark.Days < 21)
                        {
                            Panel4.Visible = true;
                            Label5.Text = "Sisteme kayýtlý en büyük AT ile yeni girilen AT arasýndaki fark 21 günden daha azdýr.Yine de AT eklensin mi?";
                            Label5.ForeColor = System.Drawing.Color.Red;
                            btnEvet.Visible = true;
                            btnHayir.Visible = true;

                        }
                        else
                        {


                            sat_kaydet(dsat, hasta_id, mp_connection);

                        }
                    }

                    else
                    {
                        sat_kaydet(dsat, hasta_id, mp_connection);
                    }



                }

            //}

            //catch
            //{
            //    Panel4.Visible = true;
            //    Label5.Text = "Kaydetme Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";

            //    Label5.ForeColor = System.Drawing.Color.Red;
            //}
        }
    }

    private void sat_kaydet(DateTime dsat, String hasta_id, MySqlConnection mp_connection)
    {

        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
               string hastaAdi = islemdekihasta["hastaAdi"];

        //MySqlCommand mp_cmd = new MySqlCommand("insert into siklus_ana_tab(siklus_ay,siklus_yil,hasta_id,siklus_ekleyen,siklus_eklenme_tarihi,siklus_ay2) values ('" + mp_class.ayadi(int.Parse(dsat.ToString().Substring(3, 2))) + "','" + dsat.ToString().Substring(6, 4) + "','" + hasta_id.ToString() + "','" +  hastaAdi+ "','" + DateTime.Now.ToString() + "','" + dsat.ToString().Substring(3, 2) + "')", mp_connection);
        //mp_connection.Open();
        //int eks = mp_cmd.ExecuteNonQuery();
        //string siklus_id_sonuc = mp_cmd.LastInsertedId.ToString();
        
        //mp_connection.Close();
        
        

        //if (eks == 1)
        //{

            MySqlDataAdapter mp_da25 = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' and sat='" + dsat + "'", mp_connection);

            DataTable mp_dt25 = new DataTable();
            mp_da25.Fill(mp_dt25);

            if (mp_dt25.Rows.Count == 0)
            {
                MySqlCommand mp_cmd3 = new MySqlCommand("insert into hasta_sat(hasta_id,sat,eklenme_tarihi,ekleyen) values ('" + hasta_id.ToString() + "','" + dsat.ToString().Substring(0, 10) + "','" + DateTime.Now.ToString() + "','" + hastaAdi + "')", mp_connection);

                mp_connection.Open();
                int eks3 = mp_cmd3.ExecuteNonQuery();
                mp_connection.Close();


                if (eks3 == 1)
                { 
                
                    gunyukle();
          
            Panel4.Visible = false;
                     
        }

        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Adet Tarihi Kaydý Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
                
                
                
                }



            //string[] sonuc_gelen = new string[4];

            //sonuc_gelen = taniyukle().Split('/');


            //MySqlCommand mp_cmd35 = new MySqlCommand("insert into kisa_siklus(sat,siklus_id,tani1,tani2,tani3,tani4) values ('" + dsat.ToString().Substring(0, 10) + "','" + siklus_id_sonuc + "','" + sonuc_gelen[0].ToString() + "','" + sonuc_gelen[1].ToString() + "','" + sonuc_gelen[2].ToString() + "','" + sonuc_gelen[3].ToString() + "')", mp_connection);
            //mp_connection.Open();
            //int eks35 = mp_cmd35.ExecuteNonQuery();
            //mp_connection.Close();





        
            ////Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + siklus_id_sonuc);
            //panel_sonuc.Visible = true;
            //sonuc.Text = "Adet Tarihi Kaydý Baþarýyla Gerçekleþtirildi.";
            //sonuc.ForeColor = System.Drawing.Color.Green;

       






        //MySqlCommand cmd = new MySqlCommand("insert into hasta_sat(sat,hasta_id,eklenme_tarihi,ekleyen) values ('" + dsat.ToString().Substring(0, 10) + "','" + hasta_id.ToString() + "','" + DateTime.Now.ToString() + "','" + mp_class.hasta_adi_bul(hasta_id) + "')", mp_connection);

        //mp_connection.Open();
        //int snc = cmd.ExecuteNonQuery();
        //mp_connection.Close();

        //if (snc == 1)
        //{

        //    Panel4.Visible = true;
        //    Labelsonuc.Text = "Adet Tarihi Baþarýyla Kaydedilmiþtir.";
        //    Labelsonuc.ForeColor = System.Drawing.Color.Green;


        //    bilgi_yukle();
        //    hasta_at.Text = "";

        //    ozetadetbilgi();



        //}

        //else
        //{
        //    Panel4.Visible = true;
        //    Labelsonuc.Text = "Kaydetme Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";

        //    Labelsonuc.ForeColor = System.Drawing.Color.Red;


        //}

    }

    string taniyukle()
    {

        //try
        //{
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"].ToString();


            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from infertilite2 A,infertilite_adlari S where S.infertilite_id=cint(A.kategori_id) and A.hasta_id='" + hasta_id.ToString() + "' and A.siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);

            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from ana_infertilite A,infertilite_adlari S where S.infertilite_id=cast(A.kategori_id as UNSIGNED) and A.hasta_id='" + hasta_id.ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);
            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);



            string sonuc = "";
            if (mp_dt2.Rows.Count == 0)
            {
                sonuc = "Açýklanamayan///";
            }

            if (mp_dt2.Rows.Count == 1)
            {

                if (mp_dt2.Rows[0][0].ToString() != "")
                {

                    sonuc += mp_dt2.Rows[0][0].ToString() + "///";

                }
                else
                {
                    sonuc += "///";
                }

            }



            if (mp_dt2.Rows.Count == 2)
            {

                if (mp_dt2.Rows[0][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[0][0].ToString() + "/";

                }
                else
                {
                    sonuc += "/";
                }


                if (mp_dt2.Rows[1][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[1][0].ToString() + "//";

                }
                else
                {
                    sonuc += "//";
                }

            }


            if (mp_dt2.Rows.Count == 3)
            {

                if (mp_dt2.Rows[0][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[0][0].ToString() + "/";

                }
                else
                {
                    sonuc += "/";
                }


                if (mp_dt2.Rows[1][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[1][0].ToString() + "/";

                }
                else
                {
                    sonuc += "/";
                }



                if (mp_dt2.Rows[2][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[2][0].ToString() + "/";
                }
                else
                {
                    sonuc += "/";
                }


            }


            if (mp_dt2.Rows.Count == 4)
            {

                if (mp_dt2.Rows[0][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[0][0].ToString() + "/";

                }
                else
                {
                    sonuc += "/";
                }


                if (mp_dt2.Rows[1][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[1][0].ToString() + "/";

                }
                else
                {
                    sonuc += "/";
                }



                if (mp_dt2.Rows[2][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[2][0].ToString() + "/";
                }
                else
                {
                    sonuc += "/";
                }


                if (mp_dt2.Rows[3][0].ToString() != "")
                {
                    sonuc += mp_dt2.Rows[3][0].ToString();
                }
                else
                {
                    sonuc += "";
                }
            }


            return sonuc;



        //}
        //catch
        //{


        //    return "Açýklanamayan///";

        //}
    }


    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            string deger1, deger2, deger3, deger4;


            if (son.Items[0].Selected)
            {
                deger1 = "+";
            }
            else
            {
                deger1 = "-";
            }

            if (son.Items[1].Selected)
            {
                deger2 = "+";
            }
            else
            {
                deger2 = "-";
            }

            if (son.Items[2].Selected)
            {
                deger3 = "+";
            }
            else
            {
                deger3 = "-";
            }
            if (son.Items[3].Selected)
            {
                deger4 = "+";
            }
            else
            {
                deger4 = "-";
            }


            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand cmd = new MySqlCommand("update uye_hasta set aln1='" + deger1 + "',aln2='" + deger2 + "',aln3='" + deger3 + "',aln4='" + deger4 + "' where uye_id =" + hasta_id + "", mp_connection);


            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();

            sonyukle();

            firsatyukle();


            if (eks == 1)
            {

                Panel5.Visible = true;
                Label7.Text = "Deðiþiklikler baþarýyla gerçekleþtirildi.";
                Label7.ForeColor = System.Drawing.Color.Green;

            }

            else
            {
                Panel5.Visible = true;
                Label7.Text = "Deðiþiklik Aþamasýnda Sistem Bir Hata Ýle Karþýlaþtý !Ýþlem Baþarýsýz";

                Label7.ForeColor = System.Drawing.Color.Red;

            }
        }
        catch
        { }

    }

    private void sonyukle()
    {

        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da4 = new MySqlDataAdapter("Select aln1,aln2,aln3,aln4 from uye_hasta where uye_id=" + hasta_id.ToString() + "", connect_word);
            DataTable dt4 = new DataTable();
            da4.Fill(dt4);

            MySqlDataAdapter da = new MySqlDataAdapter("Select * from mesajlar where id=1", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string mesaj = string.Empty;
            if (dt4.Rows[0]["aln1"].ToString() == "+")
            {
                son.Items[0].Selected = true;
                mesaj = dt.Rows[0]["aln1"].ToString() + "<br>&nbsp;&nbsp;";
            }
            if (dt4.Rows[0]["aln2"].ToString() == "+")
            {
                son.Items[1].Selected = true;
                mesaj = mesaj + dt.Rows[0]["aln2"].ToString() + "<br>&nbsp;&nbsp;";
            }
            if (dt4.Rows[0]["aln3"].ToString() == "+")
            {
                son.Items[2].Selected = true;
                mesaj = mesaj + dt.Rows[0]["aln3"].ToString() + "<br>&nbsp;&nbsp;";
            }

            if (dt4.Rows[0]["aln4"].ToString() == "+")
            {
                son.Items[3].Selected = true;
                mesaj = mesaj + dt.Rows[0]["aln4"].ToString() + "<br>&nbsp;&nbsp;";
            }

            if (mesaj.Length > 0)
            {
                Label8.Visible = true;
                Label8.Text = "&nbsp;&nbsp;" + Label8.Text;
                mesajsonuc.Visible = true;
                mesajsonuc.Text = mesaj;
                Panel6.Visible = false;
            }
            else
            {
                Panel6.Visible = true;
                Label8.Visible = false;
                mesajsonuc.Visible = false;
            }
            






        }
        catch
        {

        }

    }
}
