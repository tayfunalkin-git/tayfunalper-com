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

public partial class a_heyet : System.Web.UI.Page
{
    ivf_class mp_class = new ivf_class();


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {


            //HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            //String hasta_id = islemdekihasta["HastaID"];
            //ID.Text = hasta_id;
            //heyettarihleriyukle();
            //adi.Text = mp_class.hasta_adi_bul(hasta_id);
            //sonucyukle();
            //gunluk_tarih.Text = DateTime.Now.Date.ToShortDateString();

            //heyetHastalariniYukle();


        }

        //document.getElementById('ctl00_ContentPlaceHolder1_gizlenecek').style.display = 'block';


    }


    protected void onayla_Click1(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        panel_sonuc.Visible = false;
        if (secim.SelectedIndex == 0)
        {
            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
            string ekleyen = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand cmd7 = new MySqlCommand("Insert into heyettarihleri(tarih,sonuc,gunluk) values ('" + DateTime.Now.Date.ToShortDateString() + "' , '+','+')", mp_connection);
            mp_connection.Open();
            cmd7.ExecuteNonQuery();
            int eks2 = int.Parse(cmd7.LastInsertedId.ToString());
            mp_connection.Close();


            if (eks2.ToString() != "")
            {
                int eklenecekID = eks2;

                MySqlCommand mp_cmd = new MySqlCommand("Insert into heyetbasvuru(heyetID,kayittarihi,hastaID,ekleyen,sonuc) values (" + eklenecekID + " , '" + DateTime.Now.ToShortDateString() + "'," + hasta_id.ToString() + ",'" + ekleyen + "','+')", mp_connection);
                mp_connection.Open();
                mp_cmd.ExecuteNonQuery();
                int eks = int.Parse(mp_cmd.LastInsertedId.ToString());
                mp_connection.Close();


                if (eks.ToString() != "")
                {

                    MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyetraporsonuclari where hastaID =" + hasta_id.ToString() + " and tedavibittimi is null and opuiptal is null and transferiptal is null", mp_connection);
                    DataTable mp_dt2 = new DataTable();
                    mp_da2.Fill(mp_dt2);


                    if (mp_dt2.Rows.Count > 0)
                    {

                        MySqlCommand cmd = new MySqlCommand("Delete from heyetbasvuru where ID="+eks+"", mp_connection);

                        mp_connection.Open();
                        int eks5 = cmd.ExecuteNonQuery();
                        mp_connection.Close();


                        panel_sonuc.Visible = true;
                        sonuc2.Text = "Hastanýn Tedavisi Bitmeyen Kaydý Bulundu.Lütfen eski tedavi kaydýný gözden geçiriniz !";
                        sonuc2.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {

                        MySqlCommand cmd = new MySqlCommand("Insert Into heyetraporsonuclari(hastaID,heyetID,tibbiraporverildimi) values (?1,?2,?3)", mp_connection);

                        cmd.Parameters.AddWithValue("?1", hasta_id.ToString());
                        cmd.Parameters.AddWithValue("?2", eks2);
                        cmd.Parameters.AddWithValue("?3", "+");

                        mp_connection.Open();
                        int eks5 = cmd.ExecuteNonQuery();
                        mp_connection.Close();

                        Response.Redirect("~/ivfyonetici/0000089.aspx");
                    }






                }
            }

            else
            {

                panel_sonuc.Visible = true;
                sonuc2.Text = "Ýþlem Baþarýsýz! Lütfen tekrar deneyiniz.";
                sonuc2.ForeColor = System.Drawing.Color.Red;

            }
        }

        else if (secim.SelectedIndex == 1)
        {


            Panel1.Visible = true;

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            DateTime eklenecek = DateTime.Now.Date;
            ListItem sec = new ListItem();
            sec.Text = "Seçiniz";
            sec.Value = "";
            drptarih.Items.Add(sec);

            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from mazeret order by sira asc", mp_connection);
            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);

            drpmazeret.DataSource = mp_dt2;
            drpmazeret.DataTextField = mp_dt2.Columns["Adi"].ToString();
            drpmazeret.DataValueField = mp_dt2.Columns["ID"].ToString();
            drpmazeret.DataBind();


            for (int m = 1; m < 36; m++)
            {
                int eklenecekgenelhafta = WeekNumber_Entire4DayWeekRule(eklenecek);

                DateTime ilkpazartesi = bul(eklenecek);
                string eklenecekhafta = "";

                string eklenecekay = ilkpazartesi.Month.ToString();
                string eklenecekyil = ilkpazartesi.Year.ToString();

                if (ilkpazartesi.Day >= 1 && ilkpazartesi.Day <= 7)
                {
                    eklenecekhafta = "1";

                }
                else if (ilkpazartesi.Day >= 8 && ilkpazartesi.Day <= 14)
                {
                    eklenecekhafta = "2";

                }
                else if (ilkpazartesi.Day >= 15 && ilkpazartesi.Day <= 21)
                {
                    eklenecekhafta = "3";

                }
                else if (ilkpazartesi.Day >= 22 && ilkpazartesi.Day <= 28)
                {
                    eklenecekhafta = "4";

                }
                else if (ilkpazartesi.Day >= 29)
                {
                    eklenecekhafta = "5";

                }

                ListItem oge = new ListItem();
                oge.Text = eklenecekgenelhafta.ToString() + " - " + mp_class.ayadi(int.Parse(eklenecekay.ToString())) + " " + eklenecekyil.ToString() + " / " + eklenecekhafta.ToString() + ".Hafta" + " (" + sayibul(eklenecekgenelhafta) + ")";
                oge.Value = eklenecekhafta + "," + eklenecekay + "," + eklenecekyil.ToString() + "," + eklenecekgenelhafta.ToString();
                drptarih.Items.Add(oge);
                eklenecek = eklenecek.AddDays(7);


            }

            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            drpmazeret.Items.Insert(0, yeni);




        }

     }

    private void digerinegec()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
        string ekleyen = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);

        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        string hasta_id = islemdekihasta["HastaID"];

        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyetraporsonuclari where hastaID =" + hasta_id.ToString() + " and not genelhafta is null and tedavisurecinde is null and opuiptal is null and transferiptal is null", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);


        if (mp_dt2.Rows.Count == 1)
        {
            //siklus ara

            Label17.Text = mp_dt2.Rows[0][0].ToString();

            MySqlDataAdapter da = new MySqlDataAdapter("Select * from siklus_ana_tab where varsayilan='+' and hasta_id='" + hasta_id + "'", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                Label15.Text = dt.Rows[0]["siklus_ay"].ToString() + " " + dt.Rows[0]["siklus_yil"].ToString();
                Label16.Text = dt.Rows[0]["siklus_id"].ToString();
                Panel2.Visible = true;
                Panel3.Visible = true;
            }
            else
            {
                Panel2.Visible = true;

                Panel4.Visible = true;
                Panel3.Visible = false;

                MySqlDataAdapter mp_da = new MySqlDataAdapter("select *,CONCAT(siklus_ay,' ',siklus_yil) as sikl from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay2 <>' ' order by date('01.' & siklus_ay2 & '.' & siklus_yil) desc", mp_connection);
                DataTable mp_dt = new DataTable();
                mp_da.Fill(mp_dt);
                siklus.Items.Clear();


                siklus.DataSource = mp_dt;
                siklus.DataTextField = mp_dt.Columns["sikl"].ToString();
                siklus.DataValueField = mp_dt.Columns["siklus_id"].ToString();
                siklus.DataBind();


                ListItem sec = new ListItem();
                sec.Text = "Seçiniz";
                sec.Value = "";
                siklus.Items.Insert(0, sec);


                if (mp_dt.Rows.Count == 0)
                {
                    kaydet2.Enabled = false;

                }
                else
                {
                    kaydet2.Enabled = true;
                }

            }
        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc2.Text = "Hasta randevu listesinde bulunmamakta veya tedavisi devam etmektedir.Lütfen hasta bilgilerini kontrol ediniz !";
            sonuc2.ForeColor = System.Drawing.Color.Red;
        }
        
    }


    private DateTime bul(DateTime eklenecek)
    {

        int sayi = 0;
        if (eklenecek.DayOfWeek == DayOfWeek.Monday)
        {
            sayi = 0;

        }
        else if (eklenecek.DayOfWeek == DayOfWeek.Tuesday)
        {
            sayi = 1;

        }

        else if (eklenecek.DayOfWeek == DayOfWeek.Wednesday)
        {
            sayi = 2;

        }
        else if (eklenecek.DayOfWeek == DayOfWeek.Thursday)
        {
            sayi = 3;

        }
        else if (eklenecek.DayOfWeek == DayOfWeek.Friday)
        {
            sayi = 4;


        }
        else if (eklenecek.DayOfWeek == DayOfWeek.Saturday)
        {
            sayi = 5;

        }
        else if (eklenecek.DayOfWeek == DayOfWeek.Sunday)
        {
            sayi = 6;

        }


        return eklenecek.AddDays(-sayi);



    }

    private string sayibul(int eklenecekgenelhafta)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyetraporsonuclari where genelhafta = '" + eklenecekgenelhafta.ToString() + "'", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);
        return mp_dt2.Rows.Count.ToString();
    }

    private int WeekNumber_Entire4DayWeekRule(DateTime date)
    {
        const int JAN = 1;
        const int DEC = 12;
        const int LASTDAYOFDEC = 31;
        const int FIRSTDAYOFJAN = 1;
        const int THURSDAY = 4;

        bool ThursdayFlag = false;

        int DayOfYear = date.DayOfYear;

        int StartWeekDayOfYear =
              (int)(new DateTime(date.Year, JAN, FIRSTDAYOFJAN)).DayOfWeek;
        int EndWeekDayOfYear =
             (int)(new DateTime(date.Year, DEC, LASTDAYOFDEC)).DayOfWeek;

        if (StartWeekDayOfYear == 0)
            StartWeekDayOfYear = 7;
        if (EndWeekDayOfYear == 0)
            EndWeekDayOfYear = 7;

        int DaysInFirstWeek = 8 - (StartWeekDayOfYear);
        int DaysInLastWeek = 8 - (EndWeekDayOfYear);

        if (StartWeekDayOfYear == THURSDAY || EndWeekDayOfYear == THURSDAY)
            ThursdayFlag = true;

        int FullWeeks = (int)Math.Ceiling((DayOfYear - (DaysInFirstWeek)) / 7.0);

        int WeekNumber = FullWeeks;

        if (DaysInFirstWeek >= THURSDAY)
            WeekNumber = WeekNumber + 1;

        if (WeekNumber > 52 && !ThursdayFlag)
            WeekNumber = 1;

        if (WeekNumber == 0)
            WeekNumber = WeekNumber_Entire4DayWeekRule(
                  new DateTime(date.Year - 1, DEC, LASTDAYOFDEC));
        return WeekNumber;
    }



    protected void yer_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (yer.SelectedIndex == 0)
        {
            lbltarih.Visible = true;
            drptarih.Visible = true;
            lblyer.Visible = false;
            txtyer.Visible = false;
            lblmazeret.Visible = false;
            drpmazeret.Visible = false;

        }
        else if (yer.SelectedIndex == 1)
        {
            lbltarih.Visible = false;
            drptarih.Visible = false;
            lblyer.Visible = true;
            txtyer.Visible = true;
            lblmazeret.Visible = false;
            drpmazeret.Visible = false;

        }


        else if (yer.SelectedIndex == 2)
        {
            lbltarih.Visible = false;
            drptarih.Visible = false;
            lblyer.Visible = false;
            txtyer.Visible = false;
            lblmazeret.Visible = true;
            drpmazeret.Visible = true;
        }


    }

    protected void kaydet_Click(object sender, ImageClickEventArgs e)
    {

        string raporID = "";


        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
        string ekleyen = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);

        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        string hasta_id = islemdekihasta["HastaID"];

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand cmd7 = new MySqlCommand("Insert into heyettarihleri(tarih,sonuc,gunluk) values ('" + DateTime.Now.Date.ToShortDateString() + "' , '+','+')", mp_connection);
        mp_connection.Open();
        cmd7.ExecuteNonQuery();
        int eks2 = int.Parse(cmd7.LastInsertedId.ToString());
        mp_connection.Close();


        if (eks2.ToString() != "")
        {
            int eklenecekID = eks2;

            MySqlCommand mp_cmd = new MySqlCommand("Insert into heyetbasvuru(heyetID,kayittarihi,hastaID,ekleyen,sonuc) values (" + eklenecekID + " , '" + DateTime.Now.ToShortDateString() + "'," + hasta_id.ToString() + ",'" + ekleyen + "','+')", mp_connection);
            mp_connection.Open();
            mp_cmd.ExecuteNonQuery();
            int eks = int.Parse(mp_cmd.LastInsertedId.ToString());
            mp_connection.Close();


            if (eks.ToString() != "")
            {

                MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyetraporsonuclari where hastaID =" + hasta_id.ToString() + " and tedavibittimi is null and tedavisurecinde ='+' and opuiptal is null and transferiptal is null", mp_connection);
                DataTable mp_dt2 = new DataTable();
                mp_da2.Fill(mp_dt2);


                if (mp_dt2.Rows.Count > 0)
                {

                    panel_sonuc.Visible = true;
                    sonuc2.Text = "Hastanýn Tedavisi Bitmeyen Kaydý Bulundu.Lütfen eski tedavi kaydýný gözden geçiriniz !";
                    sonuc2.ForeColor = System.Drawing.Color.Red;
              
                }
                else
                {

                    MySqlDataAdapter mp_da23 = new MySqlDataAdapter("select * from heyetraporsonuclari where hastaID =" + hasta_id.ToString() + " and tedavibittimi is null and tedavisurecinde is null and opuiptal is null and transferiptal is null and not genelhafta is null", mp_connection);
                    DataTable mp_dt23 = new DataTable();
                    mp_da23.Fill(mp_dt23);

                    if (mp_dt23.Rows.Count > 0)
                    {


                        string raporID2 = mp_dt23.Rows[0]["raporID"].ToString();
                        string tedaviomudemi = null;
                        string hafta = null;
                        string ay = null;
                        string yil = null;
                        string tedavidisardanerede = null;
                        string sonuc = string.Empty;
                        string genelhafta = null;
                        string mazeret = null;
                        string mazeretlimi = null;
                        string mazerettarihi = null;

                        if (yer.SelectedIndex == 0)
                        {
                            tedaviomudemi = "+";
                            sonuc = "tedavisinin OMÜTB ' de yapýlacaðý onaylandý.";
                            if (drptarih.SelectedIndex != 0)
                            {

                                string tarih = drptarih.SelectedValue.ToString();
                                string[] tarihim = tarih.ToString().Split(',');
                                string hafta2 = tarihim[0].ToString();
                                string ay2 = tarihim[1].ToString();
                                string yil2 = tarihim[2].ToString();
                                string genelhafta2 = tarihim[3].ToString();

                                hafta = hafta2;
                                ay = ay2;
                                yil = yil2;
                                genelhafta = genelhafta2;

                                sonuc = "tedavisinin OMÜTB ' de hangi tarihte yapýlacaðý belirtildi.";
                            }
                        }
                        else if (yer.SelectedIndex == 1)
                        {
                            sonuc = "tedavisinin OMÜTB dýþýnda yapýlacaðý belirtildi.";


                            tedaviomudemi = "-";
                            if (txtyer.Text == "")
                            {
                                tedavidisardanerede = "-";
                            }
                            else
                            {
                                tedavidisardanerede = txtyer.Text;
                            }


                        }
                        else if (yer.SelectedIndex == 2)
                        {
                            sonuc = " tedavisi mazeretinden dolayý sonraya býrakýldý.";
                            mazerettarihi = DateTime.Now.ToString();
                            mazeretlimi = "+";
                            mazeret = drpmazeret.SelectedValue.ToString();

                        }

                        MySqlCommand cmd52 = new MySqlCommand("Update heyetraporsonuclari set tedaviomudemi=?1,ay=?2,yil=?3,hafta=?4,tedaviomudisindanerede=?5,tedavitarihiverilistarihi=?6,genelhafta=?7,mazeretID=?8,mazeretTarihi=?9,mazeretlimi=?10 where raporID=" + raporID2.ToString() + "", mp_connection);


                        cmd52.Parameters.AddWithValue("?1", tedaviomudemi);
                        cmd52.Parameters.AddWithValue("?2", ay);
                        cmd52.Parameters.AddWithValue("?3", yil);
                        cmd52.Parameters.AddWithValue("?4", hafta);
                        cmd52.Parameters.AddWithValue("?5", tedavidisardanerede);
                        cmd52.Parameters.AddWithValue("?6", DateTime.Now.ToShortDateString());
                        cmd52.Parameters.AddWithValue("?7", genelhafta);
                        cmd52.Parameters.AddWithValue("?8", mazeret);
                        cmd52.Parameters.AddWithValue("?9", mazerettarihi);
                        cmd52.Parameters.AddWithValue("?10", mazeretlimi);

                        mp_connection.Open();
                        int eks55 = cmd52.ExecuteNonQuery();
                        mp_connection.Close();

                        if (eks55 == 1)
                        {
                            panel_sonuc.Visible = true;
                            sonuc2.Text = "Ýþlem baþarýyla gerçekleþtirildi.";
                            sonuc2.ForeColor = System.Drawing.Color.Green;

                            string islem = mp_class.hasta_adi_bul(hasta_id) + " adlý hastanýn " + sonuc.ToString();


                            mp_class.log_kaydet(kullaniciAdiAdmin, islem);



                            if (yer.SelectedIndex == 0)
                            {

                                digerinegec();

                                //Response.Redirect("~/ivfyonetici/0000088.aspx");

                            }
                            else if (yer.SelectedIndex == 1)
                            {

                                Response.Redirect("~/ivfyonetici/0000090.aspx");

                            }
                            else if (yer.SelectedIndex == 2)
                            {

                                Response.Redirect("~/ivfyonetici/0000098.aspx");

                            }


                            //yukle(sonuctarih.Text);

                        }
                        else
                        {
                            panel_sonuc.Visible = true;
                            sonuc2.Text = "Ýþlem Baþarýsýz !";
                            sonuc2.ForeColor = System.Drawing.Color.Red;
                        }




























                    }
                    else
                    {

                        MySqlCommand cmd = new MySqlCommand("Insert Into heyetraporsonuclari(hastaID,heyetID,tibbiraporverildimi) values (?1,?2,?3)", mp_connection);

                        cmd.Parameters.AddWithValue("?1", hasta_id.ToString());
                        cmd.Parameters.AddWithValue("?2", eks2);
                        cmd.Parameters.AddWithValue("?3", "+");

                        mp_connection.Open();
                        int eks5 = cmd.ExecuteNonQuery();
                        raporID = cmd.LastInsertedId.ToString();
                        mp_connection.Close();



                        string tedaviomudemi = null;
                        string hafta = null;
                        string ay = null;
                        string yil = null;
                        string tedavidisardanerede = null;
                        string sonuc = string.Empty;
                        string genelhafta = null;
                        string mazeret = null;
                        string mazeretlimi = null;
                        string mazerettarihi = null;

                        if (yer.SelectedIndex == 0)
                        {
                            tedaviomudemi = "+";
                            sonuc = "tedavisinin OMÜTB ' de yapýlacaðý onaylandý.";
                            if (drptarih.SelectedIndex != 0)
                            {

                                string tarih = drptarih.SelectedValue.ToString();
                                string[] tarihim = tarih.ToString().Split(',');
                                string hafta2 = tarihim[0].ToString();
                                string ay2 = tarihim[1].ToString();
                                string yil2 = tarihim[2].ToString();
                                string genelhafta2 = tarihim[3].ToString();

                                hafta = hafta2;
                                ay = ay2;
                                yil = yil2;
                                genelhafta = genelhafta2;

                                sonuc = "tedavisinin OMÜTB ' de hangi tarihte yapýlacaðý belirtildi.";
                            }
                        }
                        else if (yer.SelectedIndex == 1)
                        {
                            sonuc = "tedavisinin OMÜTB dýþýnda yapýlacaðý belirtildi.";


                            tedaviomudemi = "-";
                            if (txtyer.Text == "")
                            {
                                tedavidisardanerede = "-";
                            }
                            else
                            {
                                tedavidisardanerede = txtyer.Text;
                            }


                        }
                        else if (yer.SelectedIndex == 2)
                        {
                            sonuc = " tedavisi mazeretinden dolayý sonraya býrakýldý.";
                            mazerettarihi = DateTime.Now.ToString();
                            mazeretlimi = "+";
                            mazeret = drpmazeret.SelectedValue.ToString();

                        }

                        MySqlCommand cmd52 = new MySqlCommand("Update heyetraporsonuclari set tedaviomudemi=?1,ay=?2,yil=?3,hafta=?4,tedaviomudisindanerede=?5,tedavitarihiverilistarihi=?6,genelhafta=?7,mazeretID=?8,mazeretTarihi=?9,mazeretlimi=?10 where raporID=" + raporID.ToString() + "", mp_connection);


                        cmd52.Parameters.AddWithValue("?1", tedaviomudemi);
                        cmd52.Parameters.AddWithValue("?2", ay);
                        cmd52.Parameters.AddWithValue("?3", yil);
                        cmd52.Parameters.AddWithValue("?4", hafta);
                        cmd52.Parameters.AddWithValue("?5", tedavidisardanerede);
                        cmd52.Parameters.AddWithValue("?6", DateTime.Now.ToShortDateString());
                        cmd52.Parameters.AddWithValue("?7", genelhafta);
                        cmd52.Parameters.AddWithValue("?8", mazeret);
                        cmd52.Parameters.AddWithValue("?9", mazerettarihi);
                        cmd52.Parameters.AddWithValue("?10", mazeretlimi);

                        mp_connection.Open();
                        int eks55 = cmd52.ExecuteNonQuery();
                        mp_connection.Close();

                        if (eks55 == 1)
                        {
                            panel_sonuc.Visible = true;
                            sonuc2.Text = "Ýþlem baþarýyla gerçekleþtirildi.";
                            sonuc2.ForeColor = System.Drawing.Color.Green;

                            string islem = mp_class.hasta_adi_bul(hasta_id) + " adlý hastanýn " + sonuc.ToString();


                            mp_class.log_kaydet(kullaniciAdiAdmin, islem);



                            if (yer.SelectedIndex == 0)
                            {

                                digerinegec();

                                //Response.Redirect("~/ivfyonetici/0000088.aspx");

                            }
                            else if (yer.SelectedIndex == 1)
                            {

                                Response.Redirect("~/ivfyonetici/0000090.aspx");

                            }
                            else if (yer.SelectedIndex == 2)
                            {

                                Response.Redirect("~/ivfyonetici/0000098.aspx");

                            }


                            //yukle(sonuctarih.Text);

                        }
                        else
                        {
                            panel_sonuc.Visible = true;
                            sonuc2.Text = "Ýþlem Baþarýsýz !";
                            sonuc2.ForeColor = System.Drawing.Color.Red;
                        }
                    
                    
                    }




                }






            }
        }

        else
        {

            panel_sonuc.Visible = true;
            sonuc2.Text = "Ýþlem Baþarýsýz! Lütfen tekrar deneyiniz.";
            sonuc2.ForeColor = System.Drawing.Color.Red;

        }


      
    }


    protected void kaydet0_Click(object sender, ImageClickEventArgs e)
    {

        baslat(Label16.Text,Label17.Text);

    }

    private void baslat(string p,string p2)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
        string ekleyen = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);

        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        string hasta_id = islemdekihasta["HastaID"];

        string siklusID = p;

            MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set siklus_id=" + siklusID.ToString() + ",tedavisurecinde = '+',tedavibaslamatarihi = '" + DateTime.Now.ToShortDateString() + "' where raporID=" + p2.ToString() + "", mp_connection);

            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();

            if (eks == 1)
            {

                Response.Redirect("~/ivfyonetici/0000093.aspx");

            }
            else
            {
                panel_sonuc.Visible = true;
                sonuc2.Text = "Ýþlem Baþarýsýz! Lütfen tekrar deneyiniz.";
                sonuc2.ForeColor = System.Drawing.Color.Red;
            }
    
    }
    protected void kaydet1_Click(object sender, ImageClickEventArgs e)
    {
        Panel4.Visible = true;
        Panel3.Visible = false;

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
        string ekleyen = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);

        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        string hasta_id = islemdekihasta["HastaID"];

        MySqlDataAdapter mp_da = new MySqlDataAdapter("select *,CONCAT(siklus_ay,' ',siklus_yil) as sikl from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay2 <>' ' and not siklus_id="+Label16.Text+" order by date('01.' & siklus_ay2 & '.' & siklus_yil) desc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        siklus.Items.Clear();

        siklus.DataSource = mp_dt;
        siklus.DataTextField = mp_dt.Columns["sikl"].ToString();
        siklus.DataValueField = mp_dt.Columns["siklus_id"].ToString();
        siklus.DataBind();


        ListItem sec = new ListItem();
        sec.Text = "Seçiniz";
        sec.Value = "";
        siklus.Items.Insert(0,sec);


        if (mp_dt.Rows.Count == 0)
        {
            kaydet2.Enabled = false;

        }
        else
        {
            kaydet2.Enabled = true;
        }
    }
    protected void kaydet2_Click(object sender, ImageClickEventArgs e)
    {

        if (siklus.SelectedIndex == 0)
        {
            panel_sonuc.Visible = true;
            sonuc2.Text = "Lütfen Siklus Seçimi Yapýnýz.";
            sonuc2.ForeColor = System.Drawing.Color.Red;

        }
        else
        { 
        
        
        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];
        MySqlConnection connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from siklus_ana_tab where varsayilan='+' and hasta_id='" + hasta_id + "'", connection);
        DataTable dt = new DataTable();
        da.Fill(dt);

        string eskisiklus = "";

        if (dt.Rows.Count == 1)
        {

            eskisiklus = dt.Rows[0]["siklus_id"].ToString();

        }

            MySqlCommand cmd = new MySqlCommand("Update siklus_ana_tab set varsayilan = null where hasta_id='" + hasta_id.ToString() + "'", connection);
        connection.Open();
        int eks = cmd.ExecuteNonQuery();
        connection.Close();


        if (eks > 0)
        {

            MySqlCommand cmd2 = new MySqlCommand("Update siklus_ana_tab set varsayilan = '+' where siklus_id=" + siklus.SelectedValue.ToString() + "", connection);

            connection.Open();
            int eks2 = cmd2.ExecuteNonQuery();
            connection.Close();

            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
            string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanýn varsayýlan siklusunun deðiþtirilmesi";
            mp_class.log_kaydet(kullaniciAdiAdmin, islem);


            if (eskisiklus.ToString() != "")
            {

                MySqlCommand cmd3 = new MySqlCommand("Update heyetraporsonuclari set siklus_id = " +  siklus.SelectedValue.ToString() + " where siklus_id=" + eskisiklus + "", connection);

                connection.Open();
                int eks3 = cmd3.ExecuteNonQuery();
                connection.Close();

            }

            baslat(siklus.SelectedValue.ToString(),Label17.Text);



        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc2.Text = "Aktif Siklus Deðiþtirme Ýþlemi Baþarýsýz! Lütfen tekrar deneyiniz.";
            sonuc2.ForeColor = System.Drawing.Color.Red;
        }

        
        }



   

    }
    protected void kaydet4_Click(object sender, ImageClickEventArgs e)
    {
 
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];

            string gunkontrol = siklus_gun.SelectedItem.Text;

            string aykontrol = siklus_ay.SelectedValue;
            string yilkontrol = siklus_yil.SelectedValue;

            DateTime yenitarihim = new DateTime(int.Parse(yilkontrol), int.Parse(aykontrol), int.Parse(gunkontrol));

            if (yenitarihim > DateTime.Now.Date)
            {

                panel_sonuc.Visible = true;
                sonuc2.Text = "Ýleri Tarihli Siklus Eklenemez !";
                sonuc2.ForeColor = System.Drawing.Color.Red;


                   }

            else
            {

  MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
              
                MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay='" + siklus_ay.SelectedItem.ToString() + "' and siklus_yil='" + siklus_yil.SelectedItem.ToString() + "'", mp_connection);

                DataTable mp_dt = new DataTable();
                mp_da.Fill(mp_dt);

                
                    HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                    string kullaniciAdi = mpKullanilan["AdminKKA"].ToString();

                    MySqlCommand mp_cmd = new MySqlCommand("insert into siklus_ana_tab(siklus_ay,siklus_yil,hasta_id,siklus_ekleyen,siklus_eklenme_tarihi,siklus_ay2) values ('" + siklus_ay.SelectedItem.ToString() + "','" + siklus_yil.SelectedItem.ToString() + "','" + hasta_id.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdi.ToString()) + "','" + DateTime.Now.ToString() + "','" + siklus_ay.SelectedValue.ToString() + "')", mp_connection);


                    mp_connection.Open();
                    int eks = mp_cmd.ExecuteNonQuery();
                    int snc = int.Parse(mp_cmd.LastInsertedId.ToString());
                    mp_connection.Close();


                    if (eks == 1)
                    {


                        MySqlDataAdapter mp_da25 = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' and sat='" + yenitarihim.Date.ToString().Substring(0, 10) + "'", mp_connection);

                        DataTable mp_dt25 = new DataTable();
                        mp_da25.Fill(mp_dt25);

                        if (mp_dt25.Rows.Count == 0)
                        {
                            MySqlCommand mp_cmd3 = new MySqlCommand("insert into hasta_sat(hasta_id,sat,eklenme_tarihi,ekleyen) values ('" + hasta_id.ToString() + "','" + yenitarihim.Date.ToString().Substring(0, 10) + "','" + DateTime.Now.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdi.ToString()) + "')", mp_connection);

                            mp_connection.Open();
                            int eks3 = mp_cmd3.ExecuteNonQuery();
                            mp_connection.Close();

                        }

                        string[] sonuc_gelen = new string[4];

                        sonuc_gelen = taniyukle().Split('/');

                        MySqlCommand mp_cmd35 = new MySqlCommand("insert into kisa_siklus(sat,siklus_id,tani1,tani2,tani3,tani4) values ('" + yenitarihim.Date.ToString().Substring(0, 10) + "','" + snc.ToString() + "','" + sonuc_gelen[0] + "','" + sonuc_gelen[1] + "','" + sonuc_gelen[2] + "','" + sonuc_gelen[3] + "')", mp_connection);
                        mp_connection.Open();
                        int eks35 = mp_cmd35.ExecuteNonQuery();
                        mp_connection.Close();




                        string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanýn " + siklus_ay.SelectedItem.ToString() + "-" + siklus_yil.SelectedItem.ToString() + " siklusunun sisteme eklenmesi";

                        mp_class.log_kaydet(kullaniciAdi, islem);









                        MySqlConnection connection = mp_class.connect_ivf(0301009184);

                        MySqlDataAdapter da = new MySqlDataAdapter("Select * from siklus_ana_tab where varsayilan='+' and hasta_id='" + hasta_id + "'", connection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        string eskisiklus = "";

                        if (dt.Rows.Count == 1)
                        {

                            eskisiklus = dt.Rows[0]["siklus_id"].ToString();

                        }


                        MySqlCommand cmd5 = new MySqlCommand("Update siklus_ana_tab set varsayilan = null where hasta_id='" + hasta_id.ToString() + "'", connection);
                        connection.Open();
                        int eks5 = cmd5.ExecuteNonQuery();
                        connection.Close();


                        if (eks5 > 0)
                        {

                            MySqlCommand cmd2 = new MySqlCommand("Update siklus_ana_tab set varsayilan = '+' where siklus_id=" + snc.ToString() + "", connection);

                            connection.Open();
                            int eks2 = cmd2.ExecuteNonQuery();
                            connection.Close();

                          
                            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
                            string islem5 = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanýn varsayýlan siklusunun deðiþtirilmesi";
                            mp_class.log_kaydet(kullaniciAdiAdmin, islem5);


                            if (eskisiklus.ToString() != "")
                            {

                                MySqlCommand cmd3 = new MySqlCommand("Update heyetraporsonuclari set siklus_id = " +  snc.ToString() + " where siklus_id=" + eskisiklus + "", connection);

                                connection.Open();
                                int eks3 = cmd3.ExecuteNonQuery();
                                connection.Close();

                            }

                           
                        }
                        else
                        {
                            panel_sonuc.Visible = true;
                            sonuc2.Text = "Aktif siklus deðiþim iþlemi baþarýsýz !";
                            sonuc2.ForeColor = System.Drawing.Color.Red;
                        }


                        baslat(snc.ToString(), Label17.Text);



                    }
                    else
                    {

                        panel_sonuc.Visible = true;
                        sonuc2.Text = "Siklus Kaydý Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
                        sonuc2.ForeColor = System.Drawing.Color.Red;

                    }


            }



    }


    string taniyukle()
    {

        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];


            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from infertilite2 A,infertilite_adlari S where S.infertilite_id=cint(A.kategori_id) and A.hasta_id='" + hasta_id.ToString() + "' and A.siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);

            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from ana_infertilite A,infertilite_adlari S where S.infertilite_id=CAST(A.kategori_id as UNSIGNED) and A.hasta_id='" + hasta_id.ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);
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





        }
        catch
        {


            return "Açýklanamayan///";

        }
    }
    protected void kaydet3_Click1(object sender, ImageClickEventArgs e)
    {
        Panel4.Visible = false;
        Panel5.Visible = true;

        siklus_yil.SelectedValue = DateTime.Now.Date.Year.ToString();

        if (DateTime.Now.Date.Month.ToString().Length == 1)
        {
            siklus_ay.SelectedValue = "0" + DateTime.Now.Date.Month.ToString();

        }
        else
        {

            siklus_ay.SelectedValue = DateTime.Now.Date.Month.ToString();
        }




        siklus_gun.SelectedValue = DateTime.Now.Date.Day.ToString();

    }
}