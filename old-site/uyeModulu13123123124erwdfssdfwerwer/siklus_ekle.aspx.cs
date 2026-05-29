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

public partial class ivfyonetici_hasta_modulu_siklus_ekle : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();

   

    protected void Page_Load(object sender, EventArgs e)
    {
        Session.LCID = 1055;


        if (!IsPostBack)
        {
            ayyilyukle();
        }

       
    }

    void kontrol()
    {
        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];


            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from siklus_ana_tab where hasta_id='"+hasta_id.ToString()+"' and siklus_ay='"+ mp_class.ayadi(int.Parse(DateTime.Now.Date.Month.ToString()))+"' and siklus_yil='"+DateTime.Now.Date.Year.ToString()+"'", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            if (mp_dt.Rows.Count == 0)
            {
                siklus_kaydet();
                btnKaydet.Enabled = true;

            }
            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Belirtilen Ay ve Yýl Ýçin Kayýtlý Bir Siklus Olduðundan Yeni Siklus Eklenemez !";
                sonuc.ForeColor = System.Drawing.Color.Red;
                btnKaydet.Enabled = false;
                           
            }
        }
        
        
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Siklus Ekleme Ýþlemi Þu An Yapýlamýyor.Lütfen Daha Sonra Tekrar Deneyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }


    void siklus_kaydet()
    { 
    
    
    
    }

    void ayyilyukle()
    {

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
    

    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {
        try
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
                sonuc.Text = "Ýleri Tarihli Siklus Eklenemez !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

                else
            {


                MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
                MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay='" + siklus_ay.SelectedItem.ToString() + "' and siklus_yil='" + siklus_yil.SelectedItem.ToString() + "'", mp_connection);

                DataTable mp_dt = new DataTable();
                mp_da.Fill(mp_dt);

                if (mp_dt.Rows.Count > 0)
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Belirtilen Ay ve Yýl Ýçin Kayýtlý Bir Siklus Bulundu.Yine de eklemek istediðinize Eminmisiniz?";
                    sonuc.ForeColor = System.Drawing.Color.Red;
                    btnKaydet.Enabled = false;
                    Button1.Visible = true;
                    Button2.Visible = true;

                    siklus_yil.Enabled = false;
                    siklus_ay.Enabled = false;
                    siklus_gun.Enabled = false;
                    
                
                }
                else
                {

                    HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                    string kullaniciAdi = mpKullanilan["AdminKKA"].ToString();

                    MySqlCommand mp_cmd = new MySqlCommand("insert into siklus_ana_tab(siklus_ay,siklus_yil,hasta_id,siklus_ekleyen,siklus_eklenme_tarihi,siklus_ay2) values ('" + siklus_ay.SelectedItem.ToString() + "','" + siklus_yil.SelectedItem.ToString() + "','" + hasta_id.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdi.ToString()) + "','" + DateTime.Now.ToString() + "','"+siklus_ay.SelectedValue.ToString()+"')", mp_connection);


                    mp_connection.Open();
                    int eks = mp_cmd.ExecuteNonQuery();
                    int snc = int.Parse(mp_cmd.LastInsertedId.ToString());
                    mp_connection.Close();


                    if (eks == 1)
                    {


                        //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select * from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay='" + siklus_ay.SelectedItem.ToString() + "' and siklus_yil='" + siklus_yil.SelectedItem.ToString() + "' order by date(siklus_eklenme_tarihi) desc limit 0,1", mp_connection);

                        //DataTable mp_dt2 = new DataTable();
                        //mp_da2.Fill(mp_dt2);



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


                        Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + snc.ToString());

                    }

                    else
                    {
                        panel_sonuc.Visible = true;
                        sonuc.Text = "Siklus Kaydý Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
                        sonuc.ForeColor = System.Drawing.Color.Red;

                    }


                }
            }
        }

        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Siklus Kaydý Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }



    }
    protected void Button1_Click1(object sender, ImageClickEventArgs e)
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdi = mpKullanilan["AdminKKA"].ToString();
        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];

        string gunkontrol = siklus_gun.SelectedItem.Text;

        string aykontrol = siklus_ay.SelectedValue;
        string yilkontrol = siklus_yil.SelectedValue;

        DateTime yenitarihim = new DateTime(int.Parse(yilkontrol), int.Parse(aykontrol), int.Parse(gunkontrol));
          
        MySqlCommand mp_cmd = new MySqlCommand("insert into siklus_ana_tab(siklus_ay,siklus_yil,hasta_id,siklus_ekleyen,siklus_eklenme_tarihi,siklus_ay2) values ('" + siklus_ay.SelectedItem.ToString() + "','" + siklus_yil.SelectedItem.ToString() + "','" + hasta_id.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdi.ToString()) + "','" + DateTime.Now.ToString() + "','"+siklus_ay.SelectedValue.ToString()+"')", mp_connection);


        mp_connection.Open();
        int eks = mp_cmd.ExecuteNonQuery();
        int snc = int.Parse(mp_cmd.LastInsertedId.ToString());
        mp_connection.Close();


        if (eks == 1)
        {


            //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select * from siklus_ana_tab where hasta_id='" + hasta_id.ToString() + "' and siklus_ay='" + siklus_ay.SelectedItem.ToString() + "' and siklus_yil='" + siklus_yil.SelectedItem.ToString() + "' order by str_to_date(siklus_eklenme_tarihi,'%d.%m.%Y') desc limit 0,1", mp_connection);

            //DataTable mp_dt2 = new DataTable();
            //mp_da2.Fill(mp_dt2);

            
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



            MySqlCommand mp_cmd35 = new MySqlCommand("insert into kisa_siklus(sat,siklus_id,tani1,tani2,tani3,tani4) values ('" + yenitarihim.Date.ToString().Substring(0, 10) + "','" +snc.ToString() + "','" + sonuc_gelen[0] + "','" + sonuc_gelen[1] + "','" + sonuc_gelen[2] + "','" + sonuc_gelen[3] + "')", mp_connection);
            mp_connection.Open();
            int eks35 = mp_cmd35.ExecuteNonQuery();
            mp_connection.Close();




            string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanýn " + siklus_ay.SelectedItem.ToString() + "-" + siklus_yil.SelectedItem.ToString() + " siklusunun sisteme eklenmesi";

            mp_class.log_kaydet(kullaniciAdi, islem);







            Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + snc.ToString());





        }

        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Siklus Kaydý Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;
            Button2.Visible = false;
            Button1.Visible = false;


        }
    }
    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {
        siklus_ay.Enabled = true;
        siklus_yil.Enabled = true;
        siklus_gun.Enabled = true;
        btnKaydet.Enabled = true;
        panel_sonuc.Visible = false;
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


}



