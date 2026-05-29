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

public partial class ivfyonetici_hasta_modulu_in_ts : System.Web.UI.UserControl
{
    
    ivf_class mp_class = new ivf_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["k"] != null && Request.QueryString["k"] == "baslangic")
            {

                tsson.Visible = true;

                Button1.Visible = true;
                Button2.Visible = true;

                menuyukle2();



                if (gizlenecek.Style["display"] == "block")
                {

                    gizlenecek.Style["display"] = "block";


                }
                else
                {
                    gizlenecek.Style["display"] = "none";

                }


            }
            else
            { 
                 
                MySqlConnection connect_word = mp_class.connect_ivf(0301009184);        
                MySqlDataAdapter da22 = new MySqlDataAdapter("Select baslangic from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"] + "", connect_word);
                DataTable dt22 = new DataTable();
                da22.Fill(dt22);

                if (dt22.Rows[0]["baslangic"].ToString() == "+")
        
                {
            
                    tsson.Visible = false;
       
                }

      
                else

        
                {
            
                    tsson.Visible = true;
                    Button1.Visible = false;
                    Button2.Visible = false;
                    menuyukle2();
                    
          
            if (gizlenecek.Style["display"] == "block")
        
            {

            gizlenecek.Style["display"] = "block";

        
            }
        else
        {
            gizlenecek.Style["display"] = "none";

        }
        }
            
            }
   

        }


    

    }

    private void kisaSiklusYukle()
    {
        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        lblDr.Visible = true;
        lblistenecek.Visible = true;
        lblSonrakiKontrol.Visible = true;

        dr.Visible = false;
        istenecek.Visible = false;
        sonrakiKontrol.Visible = false;

        if (dt5.Rows.Count > 0)
        {
            if (dt5.Rows[0]["dr"].ToString() == "")
            {

                lblDr.Text = "-";

            }
            else
            {
                lblDr.Text = dt5.Rows[0]["dr"].ToString();

            }

            if (dt5.Rows[0]["sonrakiKontrol"].ToString() == "")
            {

                lblSonrakiKontrol.Text = "-";

            }
            else
            {

                lblSonrakiKontrol.Text = yeniTarih(dt5.Rows[0]["sonrakiKontrol"].ToString());

            }


            if (dt5.Rows[0]["istenecekler"].ToString() == "")
            {

                lblistenecek.Text = "-";

            }
            else
            {
                lblistenecek.Text = dt5.Rows[0]["istenecekler"].ToString();
                istenecek.SelectedValue = dt5.Rows[0]["istenecekler"].ToString();
            }
        }


    }
    protected void Button6_Click1(object sender, ImageClickEventArgs e)
    {

        tsacilan();
  
        if (ts2.Visible == false && ts3.Visible == false)
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);


            MySqlDataAdapter da5 = new MySqlDataAdapter("Select siklus_id from takipli_siklus2 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);


            if (dt5.Rows.Count == 0)
            {
                MySqlCommand cmd = new MySqlCommand("insert into takipli_siklus2(siklus_id) values ('" + Request.QueryString["siklus_id"] + "')", connect_word);

                connect_word.Open();
                int eks = cmd.ExecuteNonQuery();
                connect_word.Close();


                if (eks == 1)
                {


                    HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                    string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

                    HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
                    String hasta_id = islemdekihasta["HastaID"];



                    string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın " + Label1.Text + " takipli siklusuna yeni tablonun eklenmesi";

                    mp_class.log_kaydet(kullaniciAdiAdmin, islem);




                    takipli_siklus_islemleri();
                    guncellemealan();
                    guncelleyenekle();


                    Panel5.Visible = true;
                    Label7.Text = "Yeni Tablo Başarıyla Açıldı.";
                    Label7.ForeColor = System.Drawing.Color.Green;



                }
                else
                {
                    Panel5.Visible = true;
                    Label7.Text = "Tablo Eklenemedi !";
                    Label7.ForeColor = System.Drawing.Color.Red;

                }


            }



        }
        else if (ts2.Visible == true && ts3.Visible == false)
        {



            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);


            MySqlDataAdapter da5 = new MySqlDataAdapter("Select siklus_id from takipli_siklus3 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);


            if (dt5.Rows.Count == 0)
            {
                MySqlCommand cmd = new MySqlCommand("insert into takipli_siklus3(siklus_id) values ('" + Request.QueryString["siklus_id"] + "')", connect_word);

                connect_word.Open();
                int eks = cmd.ExecuteNonQuery();
                connect_word.Close();


                if (eks == 1)
                {

                    guncelleyenekle();

                    takipli_siklus_islemleri();
                    guncellemealan();
                    Button6.Enabled = false;

                    Panel5.Visible = true;
                    Label7.Text = "Yeni Tablo Başarıyla Açıldı.";
                    Label7.ForeColor = System.Drawing.Color.Green;



                }
                else
                {
                    Panel5.Visible = true;
                    Label7.Text = "Tablo Eklenemedi !";
                    Label7.ForeColor = System.Drawing.Color.Red;

                }


            }







        }



    }
    protected void Button4_Click1(object sender, ImageClickEventArgs e)
    {
        tsacilan();
   
        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);


            MySqlDataAdapter da5 = new MySqlDataAdapter("Select siklus_id from takipli_siklus1 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);

            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            if (dt5.Rows.Count == 1)
            {
                ts1guncelle();

            }


            else
            {

                MySqlCommand mp_cmd = new MySqlCommand("insert into takipli_siklus1(siklus_id) values (?1)", connect_word);

                mp_cmd.Parameters.AddWithValue("?1",Request.QueryString["siklus_id"].ToString());


             
                connect_word.Open();

                int eks2 = mp_cmd.ExecuteNonQuery();

                connect_word.Close();


                if (eks2 == 1)
                {
                    ts1guncelle();




                }


            }
        }

        catch
        {

            Panel5.Visible = true;
            Label7.Text = "Güncelleme Esnasında Sistem Bir Hata İle Karşılaştı !";
            Label7.ForeColor = System.Drawing.Color.Red;


        }

        if (ts2.Visible == true)
        {

            try
            {

                ts2guncelle();

            }

            catch
            {

                Panel5.Visible = true;
                Label7.Text = "Güncelleme Esnasında Sistem Bir Hata İle Karşılaştı !";
                Label7.ForeColor = System.Drawing.Color.Red;


            }
        }

        if (ts3.Visible == true)
        {

            try
            {

                ts3guncelle();

            }

            catch
            {

                Panel5.Visible = true;
                Label7.Text = "Güncelleme Esnasında Sistem Bir Hata İle Karşılaştı !";
                Label7.ForeColor = System.Drawing.Color.Red;


            }
        }


        kisaSiklusGuncelle();



        takipli_siklus_islemleri();


        kontrolleri_kapat();

       
        

    }

    private void kisaSiklusGuncelle()
    {

        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
        MySqlCommand mp_cmd = new MySqlCommand("Update kisa_siklus set dr=?1,sonrakiKontrol=?2,istenecekler=?3 where siklus_id=?4", connect_word);
        mp_cmd.Parameters.AddWithValue("?1", dr.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?2", sonrakiKontrol.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?3", istenecek.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?4", Request.QueryString["siklus_id"].ToString());
        connect_word.Open();
        int eks2 = mp_cmd.ExecuteNonQuery();
        connect_word.Close();


    }
    protected void Button5_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + Request.QueryString["siklus_id"].ToString());

    }
    protected void Button3_Click1(object sender, ImageClickEventArgs e)
    {


        tsacilan();
        guncellemealan();

        lblDr.Visible = false;
        lblistenecek.Visible = false;
        lblSonrakiKontrol.Visible = false;

        dr.Visible = true;
        istenecek.Visible = true;
        sonrakiKontrol.Visible = true;

        sonrakiKontrol.Items.Clear();
        dr.Items.Clear();

        for (int a = 0; a < 13; a++)
        {
            ListItem oge = new ListItem();
           
            oge.Text = yeniTarih(DateTime.Now.AddDays(a + 1).ToShortDateString());
            oge.Value = DateTime.Now.AddDays(a + 1).ToShortDateString();
            sonrakiKontrol.Items.Add(oge);
        
        }

        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da2 = new MySqlDataAdapter("Select sonrakiKontrol from kisa_siklus where siklus_id="+Request.QueryString["siklus_id"].ToString()+"", connect_word);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        string alinanTarih = dt2.Rows[0][0].ToString();

        if (alinanTarih.ToString().Length == 10 && sonrakiKontrol.Items.FindByValue(alinanTarih) is ListItem)
        {
            sonrakiKontrol.Items.FindByValue(alinanTarih).Selected = true;

        }
        else if (alinanTarih.ToString().Length == 10 && sonrakiKontrol.Items.FindByValue(alinanTarih) is ListItem == false)
        {
            ListItem yeni = new ListItem();
            yeni.Text = yeniTarih(alinanTarih);
            yeni.Value = alinanTarih;

            sonrakiKontrol.Items.Insert(0,yeni);
            sonrakiKontrol.Items[0].Selected = true;

        }

        int deg = sonrakiKontrol.Items.Count;


            ListItem yeni2 = new ListItem();
            yeni2.Text = "Kontrol Yok";
            yeni2.Value = "";
            sonrakiKontrol.Items.Insert(deg,yeni2);


            MySqlDataAdapter da = new MySqlDataAdapter("Select uye_adi,uye_soyadi from uye_doktor where siklusdoktoru='+'", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);



            for (int a = 0; a < dt.Rows.Count; a++)
            {
                string deger = "";

                if (dt.Rows[a][0].ToString().IndexOf(' ') > 0)
                {
                    int snc = dt.Rows[a][0].ToString().LastIndexOf(' ')+1;
                    deger = "Dr. " + dt.Rows[a][0].ToString().Substring(snc, 1).ToUpper() + dt.Rows[a][1].ToString().Substring(0, 1).ToUpper();
                }
                else
                {
                    deger = "Dr. " + dt.Rows[a][0].ToString().Substring(0, 1).ToUpper() + dt.Rows[a][1].ToString().Substring(0, 1).ToUpper();

                }

                ListItem oge = new ListItem();
                oge.Text = deger;
                oge.Value = deger;
                dr.Items.Add(oge);

            }


            if (lblDr.Text.ToString() != "-" && dr.Items.FindByValue(lblDr.Text) is ListItem)
            {
                dr.Items.FindByValue(lblDr.Text).Selected = true;
            }
          

                ListItem yeni22 = new ListItem();
                yeni22.Text = "Seçiniz";
                yeni22.Value = "";
                dr.Items.Insert(0, yeni22);
            
         
   
    }

    string yeniTarih(string gelen)
    {

        string goruntu = gelen.Substring(0, 5);

        DateTime tarih = DateTime.Parse(gelen);

        if (tarih.DayOfWeek == DayOfWeek.Sunday)
        {
            goruntu += ",Pazar";

        }
        else if (tarih.DayOfWeek == DayOfWeek.Monday)
        {
            goruntu += ",Pazartesi";

        }
        else if (tarih.DayOfWeek == DayOfWeek.Tuesday)
        {
            goruntu += ",Salı";

        }
        else if (tarih.DayOfWeek == DayOfWeek.Wednesday)
        {
            goruntu += ",Çarşamba";

        }
        else if (tarih.DayOfWeek == DayOfWeek.Thursday)
        {
            goruntu += ",Perşembe";

        }
        else if (tarih.DayOfWeek == DayOfWeek.Friday)
        {
            goruntu += ",Cuma";

        }
        else if (tarih.DayOfWeek == DayOfWeek.Saturday)
        {
            goruntu += ",Cumartesi";

        }

        return goruntu;
    
    }

    private void tsacilan()
    {
        gizlenecek.Style["display"] = "block";
        ac1.Style["display"] = "none";
        kapa1.Style["display"] = "block";
    }
    private void tskapanan()
    {
        gizlenecek.Style["display"] = "none";
        ac1.Style["display"] = "block";
        kapa1.Style["display"] = "none";
    }
    void ts1guncelle()
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand mp_cmd = new MySqlCommand("Update takipli_siklus1 set aln1=?1,aln2=?2,aln3=?3,aln4=?4,aln5=?5,aln6=?6,aln7=?7,aln8=?8,aln9=?9,aln10=?10,aln11=?11,aln12=?12,aln13=?13,aln14=?14,iki1=?15,iki2=?16,iki3=?17,iki4=?18,iki5=?19,iki6=?20,iki7=?21,iki8=?22,iki9=?23,iki10=?24,iki11=?25,iki12=?26,iki13=?27,iki14=?28,uc1=?29,uc2=?30,uc3=?31,uc4=?32,uc5=?33,uc6=?34,uc7=?35,uc8=?36,uc9=?37,uc10=?38,uc11=?39,uc12=?40,uc13=?41,uc14=?42,dort1=?43,dort2=?44,dort3=?45,dort4=?46,dort5=?47,dort6=?48,dort7=?49,dort8=?50,dort9=?51,dort10=?52,dort11=?53,dort12=?54,dort13=?55,dort14=?56,bes1=?57,bes2=?58,bes3=?59,bes4=?60,bes5=?61,bes6=?62,bes7=?63,bes8=?64,bes9=?65,bes10=?66,bes11=?67,bes12=?68,bes13=?69,bes14=?70,alti1=?71,alti2=?72,alti3=?73,alti4=?74,alti5=?75,alti6=?76,alti7=?77,alti8=?78,alti9=?79,alti10=?80,alti11=?81,alti12=?82,alti13=?83,alti14=?84,alnbaslik=?85,ikibaslik=?86,ucbaslik=?87,dortbaslik=?88,besbaslik=?89 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);


        mp_cmd.Parameters.AddWithValue("?1",txtaln1.Text);

        mp_cmd.Parameters.AddWithValue("?2", txtaln2.Text);

        mp_cmd.Parameters.AddWithValue("?3", txtaln3.Text);
        mp_cmd.Parameters.AddWithValue("?4", txtaln4.Text);
        mp_cmd.Parameters.AddWithValue("?5", txtaln5.Text);
        mp_cmd.Parameters.AddWithValue("?6", txtaln6.Text);
        mp_cmd.Parameters.AddWithValue("?7", txtaln7.Text);
        mp_cmd.Parameters.AddWithValue("?8", txtaln8.Text);
        mp_cmd.Parameters.AddWithValue("?9", txtaln9.Text);
        mp_cmd.Parameters.AddWithValue("?10", txtaln10.Text);
        mp_cmd.Parameters.AddWithValue("?11", txtaln11.Text);
        mp_cmd.Parameters.AddWithValue("?12", txtaln12.Text);
        mp_cmd.Parameters.AddWithValue("?13", txtaln13.Text);
        mp_cmd.Parameters.AddWithValue("?14", txtaln14.Text);


        mp_cmd.Parameters.AddWithValue("?15", txtiki1.Text);
        mp_cmd.Parameters.AddWithValue("?16", txtiki2.Text);
        mp_cmd.Parameters.AddWithValue("?17", txtiki3.Text);
        mp_cmd.Parameters.AddWithValue("?18", txtiki4.Text);
        mp_cmd.Parameters.AddWithValue("?19", txtiki5.Text);
        mp_cmd.Parameters.AddWithValue("?20", txtiki6.Text);
        mp_cmd.Parameters.AddWithValue("?21", txtiki7.Text);
        mp_cmd.Parameters.AddWithValue("?22", txtiki8.Text);
        mp_cmd.Parameters.AddWithValue("?23", txtiki9.Text);
        mp_cmd.Parameters.AddWithValue("?24", txtiki10.Text);
        mp_cmd.Parameters.AddWithValue("?25", txtiki11.Text);
        mp_cmd.Parameters.AddWithValue("?26", txtiki12.Text);
        mp_cmd.Parameters.AddWithValue("?27", txtiki13.Text);
        mp_cmd.Parameters.AddWithValue("?28", txtiki14.Text);

        mp_cmd.Parameters.AddWithValue("?29", txtuc1.Text);
        mp_cmd.Parameters.AddWithValue("?30", txtuc2.Text);
        mp_cmd.Parameters.AddWithValue("?31", txtuc3.Text);
        mp_cmd.Parameters.AddWithValue("?32", txtuc4.Text);
        mp_cmd.Parameters.AddWithValue("?33", txtuc5.Text);
        mp_cmd.Parameters.AddWithValue("?34", txtuc6.Text);
        mp_cmd.Parameters.AddWithValue("?35", txtuc7.Text);
        mp_cmd.Parameters.AddWithValue("?36", txtuc8.Text);
        mp_cmd.Parameters.AddWithValue("?37", txtuc9.Text);
        mp_cmd.Parameters.AddWithValue("?38", txtuc10.Text);
        mp_cmd.Parameters.AddWithValue("?39", txtuc11.Text);
        mp_cmd.Parameters.AddWithValue("?40", txtuc12.Text);
        mp_cmd.Parameters.AddWithValue("?41", txtuc13.Text);
        mp_cmd.Parameters.AddWithValue("?42", txtuc14.Text);

        mp_cmd.Parameters.AddWithValue("?43", txtdort1.Text);
        mp_cmd.Parameters.AddWithValue("?44", txtdort2.Text);
        mp_cmd.Parameters.AddWithValue("?45", txtdort3.Text);
        mp_cmd.Parameters.AddWithValue("?46", txtdort4.Text);
        mp_cmd.Parameters.AddWithValue("?47", txtdort5.Text);
        mp_cmd.Parameters.AddWithValue("?48", txtdort6.Text);
        mp_cmd.Parameters.AddWithValue("?49", txtdort7.Text);
        mp_cmd.Parameters.AddWithValue("?50", txtdort8.Text);

        mp_cmd.Parameters.AddWithValue("?51", txtdort9.Text);
        mp_cmd.Parameters.AddWithValue("?52", txtdort10.Text);
        mp_cmd.Parameters.AddWithValue("?53", txtdort11.Text);
        mp_cmd.Parameters.AddWithValue("?54", txtdort12.Text);
        mp_cmd.Parameters.AddWithValue("?55", txtdort13.Text);
        mp_cmd.Parameters.AddWithValue("?56", txtdort14.Text);



        mp_cmd.Parameters.AddWithValue("?57", txtbes1.Text);
        mp_cmd.Parameters.AddWithValue("?58", txtbes2.Text);
        mp_cmd.Parameters.AddWithValue("?59", txtbes3.Text);
        mp_cmd.Parameters.AddWithValue("?60", txtbes4.Text);
        mp_cmd.Parameters.AddWithValue("?61", txtbes5.Text);
        mp_cmd.Parameters.AddWithValue("?62", txtbes6.Text);
        mp_cmd.Parameters.AddWithValue("?63", txtbes7.Text);
        mp_cmd.Parameters.AddWithValue("?64", txtbes8.Text);
        mp_cmd.Parameters.AddWithValue("?65", txtbes9.Text);
        mp_cmd.Parameters.AddWithValue("?66", txtbes10.Text);
        mp_cmd.Parameters.AddWithValue("?67", txtbes11.Text);
        mp_cmd.Parameters.AddWithValue("?68", txtbes12.Text);
        mp_cmd.Parameters.AddWithValue("?69", txtbes13.Text);
        mp_cmd.Parameters.AddWithValue("?70", txtbes14.Text);




        mp_cmd.Parameters.AddWithValue("?71", txtalti1.Text);
        mp_cmd.Parameters.AddWithValue("?72", txtalti2.Text);
        mp_cmd.Parameters.AddWithValue("?73", txtalti3.Text);
        mp_cmd.Parameters.AddWithValue("?74", txtalti4.Text);
        mp_cmd.Parameters.AddWithValue("?75", txtalti5.Text);
        mp_cmd.Parameters.AddWithValue("?76", txtalti6.Text);
        mp_cmd.Parameters.AddWithValue("?77", txtalti7.Text);
        mp_cmd.Parameters.AddWithValue("?78", txtalti8.Text);
        mp_cmd.Parameters.AddWithValue("?79", txtalti9.Text);
        mp_cmd.Parameters.AddWithValue("?80", txtalti10.Text);
        mp_cmd.Parameters.AddWithValue("?81", txtalti11.Text);
        mp_cmd.Parameters.AddWithValue("?82", txtalti12.Text);
        mp_cmd.Parameters.AddWithValue("?83", txtalti13.Text);
        mp_cmd.Parameters.AddWithValue("?84", txtalti14.Text);

        mp_cmd.Parameters.AddWithValue("?85", txtalnbaslik.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?86", txtikibaslik.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?87", txtucbaslik.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?88", txtdortbaslik.SelectedValue.ToString());
        mp_cmd.Parameters.AddWithValue("?89", txtbesbaslik.SelectedValue.ToString());





        MySqlCommand mp_cmd2 = new MySqlCommand("Update takipli_siklus1 set yedi1=?1,yedi2=?2,yedi3=?3,yedi4=?4,yedi5=?5,yedi6=?6,yedi7=?7,yedi8=?8,yedi9=?9,yedi10=?10,yedi11=?11,yedi12=?12,yedi13=?13,yedi14=?14,sekiz1=?15,sekiz2=?16,sekiz3=?17,sekiz4=?18,sekiz5=?19,sekiz6=?20,sekiz7=?21,sekiz8=?22,sekiz9=?23,sekiz10=?24,sekiz11=?25,sekiz12=?26,sekiz13=?27,sekiz14=?28,dokuz1=?29,dokuz2=?30,dokuz3=?31,dokuz4=?32,dokuz5=?33,dokuz6=?34,dokuz7=?35,dokuz8=?36,dokuz9=?37,dokuz10=?38,dokuz11=?39,dokuz12=?40,dokuz13=?41,dokuz14=?42,on1=?43,on2=?44,on3=?45,on4=?46,on5=?47,on6=?48,on7=?49,on8=?50,on9=?51,on10=?52,on11=?53,on12=?54,on13=?55,on14=?56,onbir1=?57,onbir2=?58,onbir3=?59,onbir4=?60,onbir5=?61,onbir6=?62,onbir7=?63,onbir8=?64,onbir9=?65,onbir10=?66,onbir11=?67,onbir12=?68,onbir13=?69,onbir14=?70,oniki1=?71,oniki2=?72,oniki3=?73,oniki4=?74,oniki5=?75,oniki6=?76,oniki7=?77,oniki8=?78,oniki9=?79,oniki10=?80,oniki11=?81,oniki12=?82,oniki13=?83,oniki14=?84 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);


        mp_cmd2.Parameters.AddWithValue("?1",txtyedi1.Text);
        mp_cmd2.Parameters.AddWithValue("?2", txtyedi2.Text);
        mp_cmd2.Parameters.AddWithValue("?3", txtyedi3.Text);
        mp_cmd2.Parameters.AddWithValue("?4", txtyedi4.Text);
        mp_cmd2.Parameters.AddWithValue("?5", txtyedi5.Text);
        mp_cmd2.Parameters.AddWithValue("?6", txtyedi6.Text);
        mp_cmd2.Parameters.AddWithValue("?7", txtyedi7.Text);
        mp_cmd2.Parameters.AddWithValue("?8", txtyedi8.Text);
        mp_cmd2.Parameters.AddWithValue("?9", txtyedi9.Text);
        mp_cmd2.Parameters.AddWithValue("?10", txtyedi10.Text);
        mp_cmd2.Parameters.AddWithValue("?11", txtyedi11.Text);
        mp_cmd2.Parameters.AddWithValue("?12", txtyedi12.Text);
        mp_cmd2.Parameters.AddWithValue("?13", txtyedi13.Text);
        mp_cmd2.Parameters.AddWithValue("?14", txtyedi14.Text);


        mp_cmd2.Parameters.AddWithValue("?15", txtsekiz1.Text);
        mp_cmd2.Parameters.AddWithValue("?16", txtsekiz2.Text);
        mp_cmd2.Parameters.AddWithValue("?17", txtsekiz3.Text);
        mp_cmd2.Parameters.AddWithValue("?18", txtsekiz4.Text);
        mp_cmd2.Parameters.AddWithValue("?19", txtsekiz5.Text);
        mp_cmd2.Parameters.AddWithValue("?20", txtsekiz6.Text);
        mp_cmd2.Parameters.AddWithValue("?21", txtsekiz7.Text);
        mp_cmd2.Parameters.AddWithValue("?22", txtsekiz8.Text);
        mp_cmd2.Parameters.AddWithValue("?23", txtsekiz9.Text);
        mp_cmd2.Parameters.AddWithValue("?24", txtsekiz10.Text);
        mp_cmd2.Parameters.AddWithValue("?25", txtsekiz11.Text);
        mp_cmd2.Parameters.AddWithValue("?26", txtsekiz12.Text);
        mp_cmd2.Parameters.AddWithValue("?27", txtsekiz13.Text);
        mp_cmd2.Parameters.AddWithValue("?28", txtsekiz14.Text);


        mp_cmd2.Parameters.AddWithValue("?29", txtdokuz1.Text);
        mp_cmd2.Parameters.AddWithValue("?30", txtdokuz2.Text);
        mp_cmd2.Parameters.AddWithValue("?31", txtdokuz3.Text);
        mp_cmd2.Parameters.AddWithValue("?32", txtdokuz4.Text);
        mp_cmd2.Parameters.AddWithValue("?33", txtdokuz5.Text);
        mp_cmd2.Parameters.AddWithValue("?34", txtdokuz6.Text);
        mp_cmd2.Parameters.AddWithValue("?35", txtdokuz7.Text);
        mp_cmd2.Parameters.AddWithValue("?36", txtdokuz8.Text);
        mp_cmd2.Parameters.AddWithValue("?37", txtdokuz9.Text);
        mp_cmd2.Parameters.AddWithValue("?38", txtdokuz10.Text);
        mp_cmd2.Parameters.AddWithValue("?39", txtdokuz11.Text);
        mp_cmd2.Parameters.AddWithValue("?40", txtdokuz12.Text);
        mp_cmd2.Parameters.AddWithValue("?41", txtdokuz13.Text);
        mp_cmd2.Parameters.AddWithValue("?42", txtdokuz14.Text);



        mp_cmd2.Parameters.AddWithValue("?43", txton1.Text);
        mp_cmd2.Parameters.AddWithValue("?44", txton2.Text);
        mp_cmd2.Parameters.AddWithValue("?45", txton3.Text);
        mp_cmd2.Parameters.AddWithValue("?46", txton4.Text);
        mp_cmd2.Parameters.AddWithValue("?47", txton5.Text);
        mp_cmd2.Parameters.AddWithValue("?48", txton6.Text);
        mp_cmd2.Parameters.AddWithValue("?49", txton7.Text);
        mp_cmd2.Parameters.AddWithValue("?50", txton8.Text);
        mp_cmd2.Parameters.AddWithValue("?51", txton9.Text);
        mp_cmd2.Parameters.AddWithValue("?52", txton10.Text);
        mp_cmd2.Parameters.AddWithValue("?53", txton11.Text);
        mp_cmd2.Parameters.AddWithValue("?54", txton12.Text);
        mp_cmd2.Parameters.AddWithValue("?55", txton13.Text);
        mp_cmd2.Parameters.AddWithValue("?56", txton14.Text);




        mp_cmd2.Parameters.AddWithValue("?57", txtonbir1.Text);
        mp_cmd2.Parameters.AddWithValue("?58", txtonbir2.Text);
        mp_cmd2.Parameters.AddWithValue("?59", txtonbir3.Text);
        mp_cmd2.Parameters.AddWithValue("?60", txtonbir4.Text);
        mp_cmd2.Parameters.AddWithValue("?61", txtonbir5.Text);
        mp_cmd2.Parameters.AddWithValue("?62", txtonbir6.Text);
        mp_cmd2.Parameters.AddWithValue("?63", txtonbir7.Text);
        mp_cmd2.Parameters.AddWithValue("?64", txtonbir8.Text);
        mp_cmd2.Parameters.AddWithValue("?65", txtonbir9.Text);
        mp_cmd2.Parameters.AddWithValue("?66", txtonbir10.Text);
        mp_cmd2.Parameters.AddWithValue("?67", txtonbir11.Text);
        mp_cmd2.Parameters.AddWithValue("?68", txtonbir12.Text);
        mp_cmd2.Parameters.AddWithValue("?69", txtonbir13.Text);
        mp_cmd2.Parameters.AddWithValue("?70", txtonbir14.Text);


        mp_cmd2.Parameters.AddWithValue("?71", txtoniki1.Text);
        mp_cmd2.Parameters.AddWithValue("?72", txtoniki2.Text);
        mp_cmd2.Parameters.AddWithValue("?73", txtoniki3.Text);
        mp_cmd2.Parameters.AddWithValue("?74", txtoniki4.Text);
        mp_cmd2.Parameters.AddWithValue("?75", txtoniki5.Text);
        mp_cmd2.Parameters.AddWithValue("?76", txtoniki6.Text);
        mp_cmd2.Parameters.AddWithValue("?77", txtoniki7.Text);
        mp_cmd2.Parameters.AddWithValue("?78", txtoniki8.Text);
        mp_cmd2.Parameters.AddWithValue("?79", txtoniki9.Text);
        mp_cmd2.Parameters.AddWithValue("?80", txtoniki10.Text);
        mp_cmd2.Parameters.AddWithValue("?81", txtoniki11.Text);
        mp_cmd2.Parameters.AddWithValue("?82", txtoniki12.Text);
        mp_cmd2.Parameters.AddWithValue("?83", txtoniki13.Text);
        mp_cmd2.Parameters.AddWithValue("?84", txtoniki14.Text);



        MySqlCommand mp_cmd3 = new MySqlCommand("Update takipli_siklus1 set onuc1=?1,onuc2=?2,onuc3=?3,onuc4=?4,onuc5=?5,onuc6=?6,onuc7=?7,onuc8=?8,onuc9=?9,onuc10=?10,onuc11=?11,onuc12=?12,onuc13=?13,onuc14=?14,ondort1=?15,ondort2=?16,ondort3=?17,ondort4=?18,ondort5=?19,ondort6=?20,ondort7=?21,ondort8=?22,ondort9=?23,ondort10=?24,ondort11=?25,ondort12=?26,ondort13=?27,ondort14=?28,onbes1=?29,onbes2=?30,onbes3=?31,onbes4=?32,onbes5=?33,onbes6=?34,onbes7=?35,onbes8=?36,onbes9=?37,onbes10=?38,onbes11=?39,onbes12=?40,onbes13=?41,onbes14=?42 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);


        mp_cmd3.Parameters.AddWithValue("?1", txtonuc1.Text);
        mp_cmd3.Parameters.AddWithValue("?2", txtonuc2.Text);
        mp_cmd3.Parameters.AddWithValue("?3", txtonuc3.Text);
        mp_cmd3.Parameters.AddWithValue("?4", txtonuc4.Text);
        mp_cmd3.Parameters.AddWithValue("?5", txtonuc5.Text);
        mp_cmd3.Parameters.AddWithValue("?6", txtonuc6.Text);
        mp_cmd3.Parameters.AddWithValue("?7", txtonuc7.Text);
        mp_cmd3.Parameters.AddWithValue("?8", txtonuc8.Text);
        mp_cmd3.Parameters.AddWithValue("?9", txtonuc9.Text);
        mp_cmd3.Parameters.AddWithValue("?10", txtonuc10.Text);
        mp_cmd3.Parameters.AddWithValue("?11", txtonuc11.Text);
        mp_cmd3.Parameters.AddWithValue("?12", txtonuc12.Text);
        mp_cmd3.Parameters.AddWithValue("?13", txtonuc13.Text);
        mp_cmd3.Parameters.AddWithValue("?14", txtonuc14.Text);


        mp_cmd3.Parameters.AddWithValue("?15", txtondort1.Text);
        mp_cmd3.Parameters.AddWithValue("?16", txtondort2.Text);
        mp_cmd3.Parameters.AddWithValue("?17", txtondort3.Text);
        mp_cmd3.Parameters.AddWithValue("?18", txtondort4.Text);
        mp_cmd3.Parameters.AddWithValue("?19", txtondort5.Text);
        mp_cmd3.Parameters.AddWithValue("?20", txtondort6.Text);
        mp_cmd3.Parameters.AddWithValue("?21", txtondort7.Text);
        mp_cmd3.Parameters.AddWithValue("?22", txtondort8.Text);
        mp_cmd3.Parameters.AddWithValue("?23", txtondort9.Text);
        mp_cmd3.Parameters.AddWithValue("?24", txtondort10.Text);
        mp_cmd3.Parameters.AddWithValue("?25", txtondort11.Text);
        mp_cmd3.Parameters.AddWithValue("?26", txtondort12.Text);
        mp_cmd3.Parameters.AddWithValue("?27", txtondort13.Text);
        mp_cmd3.Parameters.AddWithValue("?28", txtondort14.Text);


        mp_cmd3.Parameters.AddWithValue("?29", txtonbes1.Text);
        mp_cmd3.Parameters.AddWithValue("?30", txtonbes2.Text);
        mp_cmd3.Parameters.AddWithValue("?31", txtonbes3.Text);
        mp_cmd3.Parameters.AddWithValue("?32", txtonbes4.Text);
        mp_cmd3.Parameters.AddWithValue("?33", txtonbes5.Text);
        mp_cmd3.Parameters.AddWithValue("?34", txtonbes6.Text);
        mp_cmd3.Parameters.AddWithValue("?35", txtonbes7.Text);
        mp_cmd3.Parameters.AddWithValue("?36", txtonbes8.Text);
        mp_cmd3.Parameters.AddWithValue("?37", txtonbes9.Text);
        mp_cmd3.Parameters.AddWithValue("?38", txtonbes10.Text);
        mp_cmd3.Parameters.AddWithValue("?39", txtonbes11.Text);
        mp_cmd3.Parameters.AddWithValue("?40", txtonbes12.Text);
        mp_cmd3.Parameters.AddWithValue("?41", txtonbes13.Text);
        mp_cmd3.Parameters.AddWithValue("?42", txtonbes14.Text);



        mp_connection.Open();

        int eks = mp_cmd.ExecuteNonQuery();
        int eks2 = mp_cmd2.ExecuteNonQuery();
        int eks3 = mp_cmd3.ExecuteNonQuery();


        mp_connection.Close();


        if (eks == 1 || eks2 == 1 || eks3 == 1)
        {

            guncelleyenekle();

            Panel5.Visible = true;
            Label7.Text = "Takipli Siklus Güncelleştirilemesi Başarıyla Gerçekleştirildi.";
            Label7.ForeColor = System.Drawing.Color.Green;

        }

        if (eks == 0 && eks2 == 0 && eks3 == 0)
        {

            Panel5.Visible = true;
            Label7.Text = "Güncelleme Esnasında Sistem Bir Hata İle Karşılaştı !";
            Label7.ForeColor = System.Drawing.Color.Red;



        }

    }
    void ts2guncelle()
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand mp_cmd = new MySqlCommand("Update takipli_siklus2 set aln21=?1,aln22=?2,aln23=?3,aln24=?4,aln25=?5,aln26=?6,aln27=?7,aln28=?8,aln29=?9,aln210=?10,aln211=?11,aln212=?12,aln213=?13,aln214=?14,iki21=?15,iki22=?16,iki23=?17,iki24=?18,iki25=?19,iki26=?20,iki27=?21,iki28=?22,iki29=?23,iki210=?24,iki211=?25,iki212=?26,iki213=?27,iki214=?28,uc21=?29,uc22=?30,uc23=?31,uc24=?32,uc25=?33,uc26=?34,uc27=?35,uc28=?36,uc29=?37,uc210=?38,uc211=?39,uc212=?40,uc213=?41,uc214=?42,dort21=?43,dort22=?44,dort23=?45,dort24=?46,dort25=?47,dort26=?48,dort27=?49,dort28=?50,dort29=?51,dort210=?52,dort211=?53,dort212=?54,dort213=?55,dort214=?56,bes21=?57,bes22=?58,bes23=?59,bes24=?60,bes25=?61,bes26=?62,bes27=?63,bes28=?64,bes29=?65,bes210=?66,bes211=?67,bes212=?68,bes213=?69,bes214=?70,alti21=?71,alti22=?72,alti23=?73,alti24=?74,alti25=?75,alti26=?76,alti27=?77,alti28=?78,alti29=?79,alti210=?80,alti211=?81,alti212=?82,alti213=?83,alti214=?84 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);


        mp_cmd.Parameters.AddWithValue("?1",txtaln21.Text);
        mp_cmd.Parameters.AddWithValue("?2", txtaln22.Text);
        mp_cmd.Parameters.AddWithValue("?3", txtaln23.Text);
        mp_cmd.Parameters.AddWithValue("?4", txtaln24.Text);
        mp_cmd.Parameters.AddWithValue("?5", txtaln25.Text);
        mp_cmd.Parameters.AddWithValue("?6", txtaln26.Text);
        mp_cmd.Parameters.AddWithValue("?7", txtaln27.Text);
        mp_cmd.Parameters.AddWithValue("?8", txtaln28.Text);
        mp_cmd.Parameters.AddWithValue("?9", txtaln29.Text);
        mp_cmd.Parameters.AddWithValue("?10", txtaln210.Text);
        mp_cmd.Parameters.AddWithValue("?11", txtaln211.Text);
        mp_cmd.Parameters.AddWithValue("?12", txtaln212.Text);
        mp_cmd.Parameters.AddWithValue("?13", txtaln213.Text);
        mp_cmd.Parameters.AddWithValue("?14", txtaln214.Text);


        mp_cmd.Parameters.AddWithValue("?15", txtiki21.Text);
        mp_cmd.Parameters.AddWithValue("?16", txtiki22.Text);
        mp_cmd.Parameters.AddWithValue("?17", txtiki23.Text);
        mp_cmd.Parameters.AddWithValue("?18", txtiki24.Text);
        mp_cmd.Parameters.AddWithValue("?19", txtiki25.Text);
        mp_cmd.Parameters.AddWithValue("?20", txtiki26.Text);
        mp_cmd.Parameters.AddWithValue("?21", txtiki27.Text);
        mp_cmd.Parameters.AddWithValue("?22", txtiki28.Text);
        mp_cmd.Parameters.AddWithValue("?23", txtiki29.Text);
        mp_cmd.Parameters.AddWithValue("?24", txtiki210.Text);
        mp_cmd.Parameters.AddWithValue("?25", txtiki211.Text);
        mp_cmd.Parameters.AddWithValue("?26", txtiki212.Text);
        mp_cmd.Parameters.AddWithValue("?27", txtiki213.Text);
        mp_cmd.Parameters.AddWithValue("?28", txtiki214.Text);

        mp_cmd.Parameters.AddWithValue("?29", txtuc21.Text);
        mp_cmd.Parameters.AddWithValue("?30", txtuc22.Text);
        mp_cmd.Parameters.AddWithValue("?31", txtuc23.Text);
        mp_cmd.Parameters.AddWithValue("?32", txtuc24.Text);
        mp_cmd.Parameters.AddWithValue("?33", txtuc25.Text);
        mp_cmd.Parameters.AddWithValue("?34", txtuc26.Text);
        mp_cmd.Parameters.AddWithValue("?35", txtuc27.Text);
        mp_cmd.Parameters.AddWithValue("?36", txtuc28.Text);
        mp_cmd.Parameters.AddWithValue("?37", txtuc29.Text);
        mp_cmd.Parameters.AddWithValue("?38", txtuc210.Text);
        mp_cmd.Parameters.AddWithValue("?39", txtuc211.Text);
        mp_cmd.Parameters.AddWithValue("?40", txtuc212.Text);
        mp_cmd.Parameters.AddWithValue("?41", txtuc213.Text);
        mp_cmd.Parameters.AddWithValue("?42", txtuc214.Text);



        mp_cmd.Parameters.AddWithValue("?43", txtdort21.Text);
        mp_cmd.Parameters.AddWithValue("?44", txtdort22.Text);
        mp_cmd.Parameters.AddWithValue("?45", txtdort23.Text);
        mp_cmd.Parameters.AddWithValue("?46", txtdort24.Text);
        mp_cmd.Parameters.AddWithValue("?47", txtdort25.Text);
        mp_cmd.Parameters.AddWithValue("?48", txtdort26.Text);
        mp_cmd.Parameters.AddWithValue("?49", txtdort27.Text);
        mp_cmd.Parameters.AddWithValue("?50", txtdort28.Text);
        mp_cmd.Parameters.AddWithValue("?51", txtdort29.Text);
        mp_cmd.Parameters.AddWithValue("?52", txtdort210.Text);
        mp_cmd.Parameters.AddWithValue("?53", txtdort211.Text);
        mp_cmd.Parameters.AddWithValue("?54", txtdort212.Text);
        mp_cmd.Parameters.AddWithValue("?55", txtdort213.Text);
        mp_cmd.Parameters.AddWithValue("?56", txtdort214.Text);



        mp_cmd.Parameters.AddWithValue("?57", txtbes21.Text);
        mp_cmd.Parameters.AddWithValue("?58", txtbes22.Text);
        mp_cmd.Parameters.AddWithValue("?59", txtbes23.Text);
        mp_cmd.Parameters.AddWithValue("?60", txtbes24.Text);
        mp_cmd.Parameters.AddWithValue("?61", txtbes25.Text);
        mp_cmd.Parameters.AddWithValue("?62", txtbes26.Text);
        mp_cmd.Parameters.AddWithValue("?63", txtbes27.Text);
        mp_cmd.Parameters.AddWithValue("?64", txtbes28.Text);
        mp_cmd.Parameters.AddWithValue("?65", txtbes29.Text);
        mp_cmd.Parameters.AddWithValue("?66", txtbes210.Text);
        mp_cmd.Parameters.AddWithValue("?67", txtbes211.Text);
        mp_cmd.Parameters.AddWithValue("?68", txtbes212.Text);
        mp_cmd.Parameters.AddWithValue("?69", txtbes213.Text);
        mp_cmd.Parameters.AddWithValue("?70", txtbes214.Text);




        mp_cmd.Parameters.AddWithValue("?71", txtalti21.Text);
        mp_cmd.Parameters.AddWithValue("?72", txtalti22.Text);
        mp_cmd.Parameters.AddWithValue("?73", txtalti23.Text);
        mp_cmd.Parameters.AddWithValue("?74", txtalti24.Text);
        mp_cmd.Parameters.AddWithValue("?75", txtalti25.Text);
        mp_cmd.Parameters.AddWithValue("?76", txtalti26.Text);
        mp_cmd.Parameters.AddWithValue("?77", txtalti27.Text);
        mp_cmd.Parameters.AddWithValue("?78", txtalti28.Text);
        mp_cmd.Parameters.AddWithValue("?79", txtalti29.Text);
        mp_cmd.Parameters.AddWithValue("?80", txtalti210.Text);
        mp_cmd.Parameters.AddWithValue("?81", txtalti211.Text);
        mp_cmd.Parameters.AddWithValue("?82", txtalti212.Text);
        mp_cmd.Parameters.AddWithValue("?83", txtalti213.Text);
        mp_cmd.Parameters.AddWithValue("?84", txtalti214.Text);




        MySqlCommand mp_cmd2 = new MySqlCommand("Update takipli_siklus2 set yedi21=?1,yedi22=?2,yedi23=?3,yedi24=?4,yedi25=?5,yedi26=?6,yedi27=?7,yedi28=?8,yedi29=?9,yedi210=?10,yedi211=?11,yedi212=?12,yedi213=?13,yedi214=?14,sekiz21=?15,sekiz22=?16,sekiz23=?17,sekiz24=?18,sekiz25=?19,sekiz26=?20,sekiz27=?21,sekiz28=?22,sekiz29=?23,sekiz210=?24,sekiz211=?25,sekiz212=?26,sekiz213=?27,sekiz214=?28,dokuz21=?29,dokuz22=?30,dokuz23=?31,dokuz24=?32,dokuz25=?33,dokuz26=?34,dokuz27=?35,dokuz28=?36,dokuz29=?37,dokuz210=?38,dokuz211=?39,dokuz212=?40,dokuz213=?41,dokuz214=?42,on21=?43,on22=?44,on23=?45,on24=?46,on25=?47,on26=?48,on27=?49,on28=?50,on29=?51,on210=?52,on211=?53,on212=?54,on213=?55,on214=?56,onbir21=?57,onbir22=?58,onbir23=?59,onbir24=?60,onbir25=?61,onbir26=?62,onbir27=?63,onbir28=?64,onbir29=?65,onbir210=?66,onbir211=?67,onbir212=?68,onbir213=?69,onbir214=?70,oniki21=?71,oniki22=?72,oniki23=?73,oniki24=?74,oniki25=?75,oniki26=?76,oniki27=?77,oniki28=?78,oniki29=?79,oniki210=?80,oniki211=?81,oniki212=?82,oniki213=?83,oniki214=?84 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);



        mp_cmd2.Parameters.AddWithValue("?1",txtyedi21.Text);
        mp_cmd2.Parameters.AddWithValue("?2", txtyedi22.Text);
        mp_cmd2.Parameters.AddWithValue("?3", txtyedi23.Text);
        mp_cmd2.Parameters.AddWithValue("?4", txtyedi24.Text);
        mp_cmd2.Parameters.AddWithValue("?5", txtyedi25.Text);
        mp_cmd2.Parameters.AddWithValue("?6", txtyedi26.Text);
        mp_cmd2.Parameters.AddWithValue("?7", txtyedi27.Text);
        mp_cmd2.Parameters.AddWithValue("?8", txtyedi28.Text);
        mp_cmd2.Parameters.AddWithValue("?9", txtyedi29.Text);
        mp_cmd2.Parameters.AddWithValue("?10", txtyedi210.Text);
        mp_cmd2.Parameters.AddWithValue("?11", txtyedi211.Text);
        mp_cmd2.Parameters.AddWithValue("?12", txtyedi212.Text);
        mp_cmd2.Parameters.AddWithValue("?13", txtyedi213.Text);
        mp_cmd2.Parameters.AddWithValue("?14", txtyedi214.Text);


        mp_cmd2.Parameters.AddWithValue("?15", txtsekiz21.Text);
        mp_cmd2.Parameters.AddWithValue("?16", txtsekiz22.Text);
        mp_cmd2.Parameters.AddWithValue("?17", txtsekiz23.Text);
        mp_cmd2.Parameters.AddWithValue("?18", txtsekiz24.Text);
        mp_cmd2.Parameters.AddWithValue("?19", txtsekiz25.Text);
        mp_cmd2.Parameters.AddWithValue("?20", txtsekiz26.Text);
        mp_cmd2.Parameters.AddWithValue("?21", txtsekiz27.Text);
        mp_cmd2.Parameters.AddWithValue("?22", txtsekiz28.Text);
        mp_cmd2.Parameters.AddWithValue("?23", txtsekiz29.Text);
        mp_cmd2.Parameters.AddWithValue("?24", txtsekiz210.Text);
        mp_cmd2.Parameters.AddWithValue("?25", txtsekiz211.Text);
        mp_cmd2.Parameters.AddWithValue("?26", txtsekiz212.Text);
        mp_cmd2.Parameters.AddWithValue("?27", txtsekiz213.Text);
        mp_cmd2.Parameters.AddWithValue("?28", txtsekiz214.Text);


        mp_cmd2.Parameters.AddWithValue("?29", txtdokuz21.Text);
        mp_cmd2.Parameters.AddWithValue("?30", txtdokuz22.Text);
        mp_cmd2.Parameters.AddWithValue("?31", txtdokuz23.Text);
        mp_cmd2.Parameters.AddWithValue("?32", txtdokuz24.Text);
        mp_cmd2.Parameters.AddWithValue("?33", txtdokuz25.Text);
        mp_cmd2.Parameters.AddWithValue("?34", txtdokuz26.Text);
        mp_cmd2.Parameters.AddWithValue("?35", txtdokuz27.Text);
        mp_cmd2.Parameters.AddWithValue("?36", txtdokuz28.Text);
        mp_cmd2.Parameters.AddWithValue("?37", txtdokuz29.Text);
        mp_cmd2.Parameters.AddWithValue("?38", txtdokuz210.Text);
        mp_cmd2.Parameters.AddWithValue("?39", txtdokuz211.Text);
        mp_cmd2.Parameters.AddWithValue("?40", txtdokuz212.Text);
        mp_cmd2.Parameters.AddWithValue("?41", txtdokuz213.Text);
        mp_cmd2.Parameters.AddWithValue("?42", txtdokuz214.Text);



        mp_cmd2.Parameters.AddWithValue("?43", txton21.Text);
        mp_cmd2.Parameters.AddWithValue("?44", txton22.Text);
        mp_cmd2.Parameters.AddWithValue("?45", txton23.Text);
        mp_cmd2.Parameters.AddWithValue("?46", txton24.Text);
        mp_cmd2.Parameters.AddWithValue("?47", txton25.Text);
        mp_cmd2.Parameters.AddWithValue("?48", txton26.Text);
        mp_cmd2.Parameters.AddWithValue("?49", txton27.Text);
        mp_cmd2.Parameters.AddWithValue("?50", txton28.Text);
        mp_cmd2.Parameters.AddWithValue("?51", txton29.Text);
        mp_cmd2.Parameters.AddWithValue("?52", txton210.Text);
        mp_cmd2.Parameters.AddWithValue("?53", txton211.Text);
        mp_cmd2.Parameters.AddWithValue("?54", txton212.Text);
        mp_cmd2.Parameters.AddWithValue("?55", txton213.Text);
        mp_cmd2.Parameters.AddWithValue("?56", txton214.Text);


        mp_cmd2.Parameters.AddWithValue("?57", txtonbir21.Text);
        mp_cmd2.Parameters.AddWithValue("?58", txtonbir22.Text);
        mp_cmd2.Parameters.AddWithValue("?59", txtonbir23.Text);
        mp_cmd2.Parameters.AddWithValue("?60", txtonbir24.Text);
        mp_cmd2.Parameters.AddWithValue("?61", txtonbir25.Text);
        mp_cmd2.Parameters.AddWithValue("?62", txtonbir26.Text);
        mp_cmd2.Parameters.AddWithValue("?63", txtonbir27.Text);
        mp_cmd2.Parameters.AddWithValue("?64", txtonbir28.Text);
        mp_cmd2.Parameters.AddWithValue("?65", txtonbir29.Text);
        mp_cmd2.Parameters.AddWithValue("?66", txtonbir210.Text);
        mp_cmd2.Parameters.AddWithValue("?67", txtonbir211.Text);
        mp_cmd2.Parameters.AddWithValue("?68", txtonbir212.Text);
        mp_cmd2.Parameters.AddWithValue("?69", txtonbir213.Text);
        mp_cmd2.Parameters.AddWithValue("?70", txtonbir214.Text);


        mp_cmd2.Parameters.AddWithValue("?71", txtoniki21.Text);
        mp_cmd2.Parameters.AddWithValue("?72", txtoniki22.Text);
        mp_cmd2.Parameters.AddWithValue("?73", txtoniki23.Text);
        mp_cmd2.Parameters.AddWithValue("?74", txtoniki24.Text);
        mp_cmd2.Parameters.AddWithValue("?75", txtoniki25.Text);
        mp_cmd2.Parameters.AddWithValue("?76", txtoniki26.Text);
        mp_cmd2.Parameters.AddWithValue("?77", txtoniki27.Text);
        mp_cmd2.Parameters.AddWithValue("?78", txtoniki28.Text);
        mp_cmd2.Parameters.AddWithValue("?79", txtoniki29.Text);
        mp_cmd2.Parameters.AddWithValue("?80", txtoniki210.Text);
        mp_cmd2.Parameters.AddWithValue("?81", txtoniki211.Text);
        mp_cmd2.Parameters.AddWithValue("?82", txtoniki212.Text);
        mp_cmd2.Parameters.AddWithValue("?83", txtoniki213.Text);
        mp_cmd2.Parameters.AddWithValue("?84", txtoniki214.Text);



        MySqlCommand mp_cmd3 = new MySqlCommand("Update takipli_siklus2 set onuc21=?1,onuc22=?2,onuc23=?3,onuc24=?4,onuc25=?5,onuc26=?6,onuc27=?7,onuc28=?8,onuc29=?9,onuc210=?10,onuc211=?11,onuc212=?12,onuc213=?13,onuc214=?14,ondort21=?15,ondort22=?16,ondort23=?17,ondort24=?18,ondort25=?19,ondort26=?20,ondort27=?21,ondort28=?22,ondort29=?23,ondort210=?24,ondort211=?25,ondort212=?26,ondort213=?27,ondort214=?28,onbes21=?29,onbes22=?30,onbes23=?31,onbes24=?32,onbes25=?33,onbes26=?34,onbes27=?35,onbes28=?36,onbes29=?37,onbes210=?38,onbes211=?39,onbes212=?40,onbes213=?41,onbes214=?42 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);



        mp_cmd3.Parameters.AddWithValue("?1", txtonuc21.Text);
        mp_cmd3.Parameters.AddWithValue("?2", txtonuc22.Text);
        mp_cmd3.Parameters.AddWithValue("?3", txtonuc23.Text);
        mp_cmd3.Parameters.AddWithValue("?4", txtonuc24.Text);
        mp_cmd3.Parameters.AddWithValue("?5", txtonuc25.Text);
        mp_cmd3.Parameters.AddWithValue("?6", txtonuc26.Text);
        mp_cmd3.Parameters.AddWithValue("?7", txtonuc27.Text);
        mp_cmd3.Parameters.AddWithValue("?8", txtonuc28.Text);
        mp_cmd3.Parameters.AddWithValue("?9", txtonuc29.Text);
        mp_cmd3.Parameters.AddWithValue("?10", txtonuc210.Text);
        mp_cmd3.Parameters.AddWithValue("?11", txtonuc211.Text);
        mp_cmd3.Parameters.AddWithValue("?12", txtonuc212.Text);
        mp_cmd3.Parameters.AddWithValue("?13", txtonuc213.Text);
        mp_cmd3.Parameters.AddWithValue("?14", txtonuc214.Text);


        mp_cmd3.Parameters.AddWithValue("?15", txtondort21.Text);
        mp_cmd3.Parameters.AddWithValue("?16", txtondort22.Text);
        mp_cmd3.Parameters.AddWithValue("?17", txtondort23.Text);
        mp_cmd3.Parameters.AddWithValue("?18", txtondort24.Text);
        mp_cmd3.Parameters.AddWithValue("?19", txtondort25.Text);
        mp_cmd3.Parameters.AddWithValue("?20", txtondort26.Text);
        mp_cmd3.Parameters.AddWithValue("?21", txtondort27.Text);
        mp_cmd3.Parameters.AddWithValue("?22", txtondort28.Text);
        mp_cmd3.Parameters.AddWithValue("?23", txtondort29.Text);
        mp_cmd3.Parameters.AddWithValue("?24", txtondort210.Text);
        mp_cmd3.Parameters.AddWithValue("?25", txtondort211.Text);
        mp_cmd3.Parameters.AddWithValue("?26", txtondort212.Text);
        mp_cmd3.Parameters.AddWithValue("?27", txtondort213.Text);
        mp_cmd3.Parameters.AddWithValue("?28", txtondort214.Text);


        mp_cmd3.Parameters.AddWithValue("?29", txtonbes21.Text);
        mp_cmd3.Parameters.AddWithValue("?30", txtonbes22.Text);
        mp_cmd3.Parameters.AddWithValue("?31", txtonbes23.Text);
        mp_cmd3.Parameters.AddWithValue("?32", txtonbes24.Text);
        mp_cmd3.Parameters.AddWithValue("?33", txtonbes25.Text);
        mp_cmd3.Parameters.AddWithValue("?34", txtonbes26.Text);
        mp_cmd3.Parameters.AddWithValue("?35", txtonbes27.Text);
        mp_cmd3.Parameters.AddWithValue("?36", txtonbes28.Text);
        mp_cmd3.Parameters.AddWithValue("?37", txtonbes29.Text);
        mp_cmd3.Parameters.AddWithValue("?38", txtonbes210.Text);
        mp_cmd3.Parameters.AddWithValue("?39", txtonbes211.Text);
        mp_cmd3.Parameters.AddWithValue("?40", txtonbes212.Text);
        mp_cmd3.Parameters.AddWithValue("?41", txtonbes213.Text);
        mp_cmd3.Parameters.AddWithValue("?42", txtonbes214.Text);

        mp_connection.Open();

        int eks = mp_cmd.ExecuteNonQuery();
        int eks2 = mp_cmd2.ExecuteNonQuery();
        int eks3 = mp_cmd3.ExecuteNonQuery();
        mp_connection.Close();



        if (eks == 0 && eks2 == 0 && eks3 == 0)
        {

            Panel5.Visible = true;
            Label7.Text = "Güncelleme Esnasında Sistem Bir Hata İle Karşılaştı !";
            Label7.ForeColor = System.Drawing.Color.Red;



        }



    }
    void ts3guncelle()
    {


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand mp_cmd = new MySqlCommand("Update takipli_siklus3 set aln31=?1,aln32=?2,aln33=?3,aln34=?4,aln35=?5,aln36=?6,aln37=?7,iki31=?8,iki32=?9,iki33=?10,iki34=?11,iki35=?12,iki36=?13,iki37=?14,uc31=?15,uc32=?16,uc33=?17,uc34=?18,uc35=?19,uc36=?20,uc37=?21,dort31=?22,dort32=?23,dort33=?24,dort34=?25,dort35=?26,dort36=?27,dort37=?28,bes31=?29,bes32=?30,bes33=?31,bes34=?32,bes35=?33,bes36=?34,bes37=?35,alti31=?36,alti32=?37,alti33=?38,alti34=?39,alti35=?40,alti36=?41,alti37=?42 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);


        mp_cmd.Parameters.AddWithValue("?1",txtaln31.Text);
        mp_cmd.Parameters.AddWithValue("?2", txtaln32.Text);
        mp_cmd.Parameters.AddWithValue("?3", txtaln33.Text);
        mp_cmd.Parameters.AddWithValue("?4", txtaln34.Text);
        mp_cmd.Parameters.AddWithValue("?5", txtaln35.Text);
        mp_cmd.Parameters.AddWithValue("?6", txtaln36.Text);
        mp_cmd.Parameters.AddWithValue("?7", txtaln37.Text);



        mp_cmd.Parameters.AddWithValue("?8", txtiki31.Text);
        mp_cmd.Parameters.AddWithValue("?9", txtiki32.Text);
        mp_cmd.Parameters.AddWithValue("?10", txtiki33.Text);
        mp_cmd.Parameters.AddWithValue("?11", txtiki34.Text);
        mp_cmd.Parameters.AddWithValue("?12", txtiki35.Text);
        mp_cmd.Parameters.AddWithValue("?13", txtiki36.Text);
        mp_cmd.Parameters.AddWithValue("?14", txtiki37.Text);


        mp_cmd.Parameters.AddWithValue("?15", txtuc31.Text);
        mp_cmd.Parameters.AddWithValue("?16", txtuc32.Text);
        mp_cmd.Parameters.AddWithValue("?17", txtuc33.Text);
        mp_cmd.Parameters.AddWithValue("?18", txtuc34.Text);
        mp_cmd.Parameters.AddWithValue("?19", txtuc35.Text);
        mp_cmd.Parameters.AddWithValue("?20", txtuc36.Text);
        mp_cmd.Parameters.AddWithValue("?21", txtuc37.Text);




        mp_cmd.Parameters.AddWithValue("?22", txtdort31.Text);
        mp_cmd.Parameters.AddWithValue("?23", txtdort32.Text);
        mp_cmd.Parameters.AddWithValue("?24", txtdort33.Text);
        mp_cmd.Parameters.AddWithValue("?25", txtdort34.Text);
        mp_cmd.Parameters.AddWithValue("?26", txtdort35.Text);
        mp_cmd.Parameters.AddWithValue("?27", txtdort36.Text);
        mp_cmd.Parameters.AddWithValue("?28", txtdort37.Text);

        mp_cmd.Parameters.AddWithValue("?29", txtbes31.Text);
        mp_cmd.Parameters.AddWithValue("?30", txtbes32.Text);
        mp_cmd.Parameters.AddWithValue("?31", txtbes33.Text);
        mp_cmd.Parameters.AddWithValue("?32", txtbes34.Text);
        mp_cmd.Parameters.AddWithValue("?33", txtbes35.Text);
        mp_cmd.Parameters.AddWithValue("?34", txtbes36.Text);
        mp_cmd.Parameters.AddWithValue("?35", txtbes37.Text);





        mp_cmd.Parameters.AddWithValue("?36", txtalti31.Text);
        mp_cmd.Parameters.AddWithValue("?37", txtalti32.Text);
        mp_cmd.Parameters.AddWithValue("?38", txtalti33.Text);
        mp_cmd.Parameters.AddWithValue("?39", txtalti34.Text);
        mp_cmd.Parameters.AddWithValue("?40", txtalti35.Text);
        mp_cmd.Parameters.AddWithValue("?41", txtalti36.Text);
        mp_cmd.Parameters.AddWithValue("?42", txtalti37.Text);





        MySqlCommand mp_cmd2 = new MySqlCommand("Update takipli_siklus3 set yedi31=?1,yedi32=?2,yedi33=?3,yedi34=?4,yedi35=?5,yedi36=?6,yedi37=?7,sekiz31=?8,sekiz32=?9,sekiz33=?10,sekiz34=?11,sekiz35=?12,sekiz36=?13,sekiz37=?14,dokuz31=?15,dokuz32=?16,dokuz33=?17,dokuz34=?18,dokuz35=?19,dokuz36=?20,dokuz37=?21,on31=?22,on32=?23,on33=?24,on34=?25,on35=?26,on36=?27,on37=?28,onbir31=?29,onbir32=?30,onbir33=?31,onbir34=?32,onbir35=?33,onbir36=?34,onbir37=?35,oniki31=?36,oniki32=?37,oniki33=?38,oniki34=?39,oniki35=?40,oniki36=?41,oniki37=?42 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);

        mp_cmd2.Parameters.AddWithValue("?1",txtyedi31.Text);
        mp_cmd2.Parameters.AddWithValue("?2", txtyedi32.Text);
        mp_cmd2.Parameters.AddWithValue("?3", txtyedi33.Text);
        mp_cmd2.Parameters.AddWithValue("?4", txtyedi34.Text);
        mp_cmd2.Parameters.AddWithValue("?5", txtyedi35.Text);
        mp_cmd2.Parameters.AddWithValue("?6", txtyedi36.Text);
        mp_cmd2.Parameters.AddWithValue("?7", txtyedi37.Text);


        mp_cmd2.Parameters.AddWithValue("?8", txtsekiz31.Text);
        mp_cmd2.Parameters.AddWithValue("?9", txtsekiz32.Text);
        mp_cmd2.Parameters.AddWithValue("?10", txtsekiz33.Text);
        mp_cmd2.Parameters.AddWithValue("?11", txtsekiz34.Text);
        mp_cmd2.Parameters.AddWithValue("?12", txtsekiz35.Text);
        mp_cmd2.Parameters.AddWithValue("?13", txtsekiz36.Text);
        mp_cmd2.Parameters.AddWithValue("?14", txtsekiz37.Text);


        mp_cmd2.Parameters.AddWithValue("?15", txtdokuz31.Text);
        mp_cmd2.Parameters.AddWithValue("?16", txtdokuz32.Text);
        mp_cmd2.Parameters.AddWithValue("?17", txtdokuz33.Text);
        mp_cmd2.Parameters.AddWithValue("?18", txtdokuz34.Text);
        mp_cmd2.Parameters.AddWithValue("?19", txtdokuz35.Text);
        mp_cmd2.Parameters.AddWithValue("?20", txtdokuz36.Text);
        mp_cmd2.Parameters.AddWithValue("?21", txtdokuz37.Text);



        mp_cmd2.Parameters.AddWithValue("?22", txton31.Text);
        mp_cmd2.Parameters.AddWithValue("?23", txton32.Text);
        mp_cmd2.Parameters.AddWithValue("?24", txton33.Text);
        mp_cmd2.Parameters.AddWithValue("?25", txton34.Text);
        mp_cmd2.Parameters.AddWithValue("?26", txton35.Text);
        mp_cmd2.Parameters.AddWithValue("?27", txton36.Text);
        mp_cmd2.Parameters.AddWithValue("?28", txton37.Text);



        mp_cmd2.Parameters.AddWithValue("?29", txtonbir31.Text);
        mp_cmd2.Parameters.AddWithValue("?30", txtonbir32.Text);
        mp_cmd2.Parameters.AddWithValue("?31", txtonbir33.Text);
        mp_cmd2.Parameters.AddWithValue("?32", txtonbir34.Text);
        mp_cmd2.Parameters.AddWithValue("?33", txtonbir35.Text);
        mp_cmd2.Parameters.AddWithValue("?34", txtonbir36.Text);
        mp_cmd2.Parameters.AddWithValue("?35", txtonbir37.Text);


        mp_cmd2.Parameters.AddWithValue("?36", txtoniki31.Text);
        mp_cmd2.Parameters.AddWithValue("?37", txtoniki32.Text);
        mp_cmd2.Parameters.AddWithValue("?38", txtoniki33.Text);
        mp_cmd2.Parameters.AddWithValue("?39", txtoniki34.Text);
        mp_cmd2.Parameters.AddWithValue("?40", txtoniki35.Text);
        mp_cmd2.Parameters.AddWithValue("?41", txtoniki36.Text);
        mp_cmd2.Parameters.AddWithValue("?42", txtoniki37.Text);


        mp_connection.Open();

        int eks = mp_cmd.ExecuteNonQuery();
        int eks2 = mp_cmd2.ExecuteNonQuery();

        mp_connection.Close();


        if (eks == 0 && eks2 == 0)
        {

            Panel5.Visible = true;
            Label7.Text = "Güncelleme Esnasında Sistem Bir Hata İle Karşılaştı !";
            Label7.ForeColor = System.Drawing.Color.Red;



        }



    }
    void kontrolleri_kapat()
    {


        txtalnbaslik.Visible = false;
        txtikibaslik.Visible = false;
        txtucbaslik.Visible = false;
        txtdortbaslik.Visible = false;
        txtbesbaslik.Visible = false;


        alnbaslik.Visible = true;
        ikibaslik.Visible = true;
        ucbaslik.Visible = true;
        dortbaslik.Visible = true;
        besbaslik.Visible = true;

        Button3.Visible = true;
        Button4.Visible = false;
        Button5.Visible = false;
        Button6.Visible = false;



        if (ts1.Visible == true)
        {


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("aln" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtaln" + i.ToString());
                yeni2.Visible = false;


            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("iki" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtiki" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("uc" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtuc" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("dort" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtdort" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("bes" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtbes" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("alti" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtalti" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("yedi" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtyedi" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("sekiz" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtsekiz" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("dokuz" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtdokuz" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("on" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txton" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("onbir" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtonbir" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("oniki" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtoniki" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("onuc" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtonuc" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("ondort" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtondort" + i.ToString());
                yeni2.Visible = false;

            }
            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("onbes" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtonbes" + i.ToString());
                yeni2.Visible = false;

            }



        }

        if (ts2.Visible == true)
        {

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("aln2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtaln2" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("iki2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtiki2" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("uc2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtuc2" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("dort2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtdort2" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("bes2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtbes2" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("alti2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtalti2" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("yedi2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtyedi2" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("sekiz2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtsekiz2" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("dokuz2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtdokuz2" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("on2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txton2" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("onbir2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtonbir2" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("oniki2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtoniki2" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("onuc2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtonuc2" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("ondort2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtondort2" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("onbes2" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtonbes2" + i.ToString());
                yeni2.Visible = false;

            }





        }
        if (ts3.Visible == true)
        {





            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("aln3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtaln3" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("iki3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtiki3" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("uc3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtuc3" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("dort3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtdort3" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("bes3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtbes3" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("alti3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtalti3" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("yedi3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtyedi3" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("sekiz3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtsekiz3" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("dokuz3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtdokuz3" + i.ToString());
                yeni2.Visible = false;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("on3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txton3" + i.ToString());
                yeni2.Visible = false;

            }

            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("onbir3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtonbir3" + i.ToString());
                yeni2.Visible = false;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("oniki3" + i.ToString());
                yeni.Visible = true;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtoniki3" + i.ToString());
                yeni2.Visible = false;

            }






        }


        lblDr.Visible = true;
        lblSonrakiKontrol.Visible = true;
        lblistenecek.Visible = true;
        dr.Visible = false;
        sonrakiKontrol.Visible = false;
        istenecek.Visible = false;

        kisaSiklusYukle();



    }
    void takipli_siklus_islemleri()
    {

        kutulari_ac();

        kontrolleri_ac();

        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select sat from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            if (dt5.Rows.Count == 0)
            {

                Panel5.Visible = true;
                Label7.Text = "Bu Siklusta Hasta SAT Değeri Girilmedi !";

                Label7.ForeColor = System.Drawing.Color.Red;

            }

            else
            {
                DateTime kayitlisat = new DateTime();
                kayitlisat = DateTime.Parse(dt5.Rows[0][0].ToString());

                if (ts1.Visible == true)
                {

                    Button6.Enabled = true;

                    for (int i = 1; i < 15; i++)
                    {
                        Label trh = new Label();
                        trh = (Label)ts1.FindControl("tr" + i.ToString());
                        trh.Text = kayitlisat.Day.ToString();

                        kayitlisat = kayitlisat.AddDays(1);

                    }


                }

                if (ts2.Visible == true)
                {
                    Button6.Enabled = true;

                    for (int i = 15; i < 29; i++)
                    {


                        Label trh = new Label();
                        trh = (Label)ts2.FindControl("tr" + i.ToString());
                        trh.Text = kayitlisat.Day.ToString();

                        kayitlisat = kayitlisat.AddDays(1);

                    }


                }


                if (ts3.Visible == true)
                {

                    Button6.Enabled = false;


                    for (int i = 29; i < 36; i++)
                    {


                        Label trh = new Label();
                        trh = (Label)ts3.FindControl("tr" + i.ToString());
                        trh.Text = kayitlisat.Day.ToString();

                        kayitlisat = kayitlisat.AddDays(1);

                    }


                }
                Panel5.Visible = false;


            }








        }

        catch
        {


        }
    }
    void guncellemealan()
    {

        txtalnbaslik.Visible = true;
        txtikibaslik.Visible = true;
        txtucbaslik.Visible = true;
        txtdortbaslik.Visible = true;
        txtbesbaslik.Visible = true;


        alnbaslik.Visible = false;
        ikibaslik.Visible = false;
        ucbaslik.Visible = false;
        dortbaslik.Visible = false;
        besbaslik.Visible = false;


        Button3.Visible = false;
        Button4.Visible = true;
        Button5.Visible = true;
        Button6.Visible = true;



        if (ts1.Visible == true)
        {


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("aln" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtaln" + i.ToString());
                yeni2.Visible = true;


            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("iki" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtiki" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("uc" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtuc" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("dort" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtdort" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("bes" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtbes" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("alti" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtalti" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("yedi" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtyedi" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("sekiz" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtsekiz" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("dokuz" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtdokuz" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("on" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txton" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("onbir" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtonbir" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("oniki" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtoniki" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("onuc" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtonuc" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("ondort" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtondort" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts1.FindControl("onbes" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts1.FindControl("txtonbes" + i.ToString());
                yeni2.Visible = true;

            }

        }

        if (ts2.Visible == true)
        {

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("aln2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtaln2" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("iki2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtiki2" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("uc2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtuc2" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("dort2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtdort2" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("bes2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtbes2" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("alti2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtalti2" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("yedi2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtyedi2" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("sekiz2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtsekiz2" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("dokuz2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtdokuz2" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("on2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txton2" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("onbir2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtonbir2" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("oniki2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtoniki2" + i.ToString());
                yeni2.Visible = true;

            }
            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("onuc2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtonuc2" + i.ToString());
                yeni2.Visible = true;

            }
            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("ondort2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtondort2" + i.ToString());
                yeni2.Visible = true;

            }
            for (int i = 1; i < 15; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts2.FindControl("onbes2" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts2.FindControl("txtonbes2" + i.ToString());
                yeni2.Visible = true;

            }

        }
        if (ts3.Visible == true)
        {





            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("aln3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtaln3" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("iki3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtiki3" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("uc3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtuc3" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("dort3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtdort3" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("bes3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtbes3" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("alti3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtalti3" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("yedi3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtyedi3" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("sekiz3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtsekiz3" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("dokuz3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtdokuz3" + i.ToString());
                yeni2.Visible = true;

            }


            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("on3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txton3" + i.ToString());
                yeni2.Visible = true;

            }

            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("onbir3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtonbir3" + i.ToString());
                yeni2.Visible = true;

            }



            for (int i = 1; i < 8; i++)
            {
                Label yeni = new Label();
                yeni = (Label)ts3.FindControl("oniki3" + i.ToString());
                yeni.Visible = false;
                TextBox yeni2 = new TextBox();
                yeni2 = (TextBox)ts3.FindControl("txtoniki3" + i.ToString());
                yeni2.Visible = true;

            }






        }





    }
    void guncelleyenekle()
    {
        try
        {


            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];



            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand mp_cmd = new MySqlCommand("insert into takipli_siklus_guncellemeleri(siklus_id,guncelleyen,tarih) values (?1,?2,?3)", mp_connection);


            mp_cmd.Parameters.AddWithValue("?1",Request.QueryString["siklus_id"].ToString());
            mp_cmd.Parameters.AddWithValue("?2", mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin.ToString()));

            mp_cmd.Parameters.AddWithValue("?3", DateTime.Now.ToString());


            mp_connection.Open();

            int eks = mp_cmd.ExecuteNonQuery();

            mp_connection.Close();

            if (eks == 1)
            {

                string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın " + Label1.Text + " takipli siklusunun güncellenmesi";

                mp_class.log_kaydet(kullaniciAdiAdmin, islem);



            }
            else
            {
                Panel5.Visible = true;
                Label7.Text = "Veriler Güncelleştirildi.Fakat Güncelleştiren Bilgisi Kaydedilemedi !";
                Label7.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {

            Panel5.Visible = true;
            Label7.Text = "Güncelleştiren Bilgisi Kaydedilirken Sistem Bir Hata İle Karşılaştı !";
            Label7.ForeColor = System.Drawing.Color.Red;

        }






    }
    void kontrolleri_ac()
    {

        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from takipli_siklus1 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows.Count == 1)
            {

                secmelileridoldur();


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("aln" + i.ToString());
                    yeni.Text = dt1.Rows[0]["aln" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtaln" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["aln" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("iki" + i.ToString());
                    yeni.Text = dt1.Rows[0]["iki" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtiki" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["iki" + i.ToString()].ToString();

                                   }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("uc" + i.ToString());
                    yeni.Text = dt1.Rows[0]["uc" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtuc" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["uc" + i.ToString()].ToString();

                 
                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("dort" + i.ToString());
                    yeni.Text = dt1.Rows[0]["dort" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtdort" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["dort" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("bes" + i.ToString());
                    yeni.Text = dt1.Rows[0]["bes" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtbes" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["bes" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("alti" + i.ToString());
                    yeni.Text = dt1.Rows[0]["alti" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtalti" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["alti" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("yedi" + i.ToString());
                    yeni.Text = dt1.Rows[0]["yedi" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtyedi" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["yedi" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("sekiz" + i.ToString());
                    yeni.Text = dt1.Rows[0]["sekiz" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtsekiz" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["sekiz" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("dokuz" + i.ToString());
                    yeni.Text = dt1.Rows[0]["dokuz" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtdokuz" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["dokuz" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("on" + i.ToString());
                    yeni.Text = dt1.Rows[0]["on" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txton" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["on" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("onbir" + i.ToString());
                    yeni.Text = dt1.Rows[0]["onbir" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtonbir" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["onbir" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("oniki" + i.ToString());
                    yeni.Text = dt1.Rows[0]["oniki" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtoniki" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["oniki" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("onuc" + i.ToString());
                    yeni.Text = dt1.Rows[0]["onuc" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtonuc" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["onuc" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("ondort" + i.ToString());
                    yeni.Text = dt1.Rows[0]["ondort" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtondort" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["ondort" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts1.FindControl("onbes" + i.ToString());
                    yeni.Text = dt1.Rows[0]["onbes" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts1.FindControl("txtonbes" + i.ToString());
                    yeni2.Text = dt1.Rows[0]["onbes" + i.ToString()].ToString();

                }
            }




            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from takipli_siklus2 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            if (dt2.Rows.Count == 1)
            {
                ts2.Visible = true;

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("aln2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["aln2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtaln2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["aln2" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("iki2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["iki2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtiki2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["iki2" + i.ToString()].ToString();


                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("uc2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["uc2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtuc2" + i.ToString());

                    yeni2.Text = dt2.Rows[0]["uc2" + i.ToString()].ToString();

                
                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("dort2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["dort2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtdort2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["dort2" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("bes2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["bes2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtbes2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["bes2" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("alti2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["alti2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtalti2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["alti2" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("yedi2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["yedi2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtyedi2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["yedi2" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("sekiz2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["sekiz2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtsekiz2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["sekiz2" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("dokuz2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["dokuz2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtdokuz2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["dokuz2" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("on2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["on2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txton2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["on2" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("onbir2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["onbir2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtonbir2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["onbir2" + i.ToString()].ToString();

                }



                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("oniki2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["oniki2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtoniki2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["oniki2" + i.ToString()].ToString();

                }


                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("onuc2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["onuc2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtonuc2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["onuc2" + i.ToString()].ToString();

                }

                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("ondort2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["ondort2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtondort2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["ondort2" + i.ToString()].ToString();

                }
                for (int i = 1; i < 15; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts2.FindControl("onbes2" + i.ToString());
                    yeni.Text = dt2.Rows[0]["onbes2" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts2.FindControl("txtonbes2" + i.ToString());
                    yeni2.Text = dt2.Rows[0]["onbes2" + i.ToString()].ToString();

                }




            }


            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from takipli_siklus3 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            if (dt3.Rows.Count == 1)
            {
                ts3.Visible = true;

                Button6.Enabled = false;

                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("aln3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["aln3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtaln3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["aln3" + i.ToString()].ToString();

                }

                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("iki3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["iki3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtiki3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["iki3" + i.ToString()].ToString();

                }


                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("uc3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["uc3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtuc3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["uc3" + i.ToString()].ToString();

                }



                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("dort3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["dort3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtdort3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["dort3" + i.ToString()].ToString();

                }



                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("bes3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["bes3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtbes3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["bes3" + i.ToString()].ToString();

                }



                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("alti3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["alti3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtalti3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["alti3" + i.ToString()].ToString();

                }


                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("yedi3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["yedi3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtyedi3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["yedi3" + i.ToString()].ToString();

                }



                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("sekiz3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["sekiz3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtsekiz3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["sekiz3" + i.ToString()].ToString();

                }


                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("dokuz3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["dokuz3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtdokuz3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["dokuz3" + i.ToString()].ToString();

                }


                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("on3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["on3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txton3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["on3" + i.ToString()].ToString();

                }

                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("onbir3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["onbir3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtonbir3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["onbir3" + i.ToString()].ToString();

                }



                for (int i = 1; i < 8; i++)
                {
                    Label yeni = new Label();
                    yeni = (Label)ts3.FindControl("oniki3" + i.ToString());
                    yeni.Text = dt3.Rows[0]["oniki3" + i.ToString()].ToString();
                    TextBox yeni2 = new TextBox();
                    yeni2 = (TextBox)ts3.FindControl("txtoniki3" + i.ToString());
                    yeni2.Text = dt3.Rows[0]["oniki3" + i.ToString()].ToString();

                }

            }

        }

        catch
        {

        }





    }
    void kutulari_ac()
    {
        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from gnrha order by sira asc", connect_word);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);

        txtalnbaslik.DataSource = dt1;

        txtalnbaslik.DataTextField = dt1.Columns["adi"].ToString();
        txtalnbaslik.DataValueField = dt1.Columns["id"].ToString();
        txtalnbaslik.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        yeni.Selected = true;

        txtalnbaslik.Items.Insert(0, yeni);


        MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from fshmenogon order by sira asc", connect_word);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);



        txtikibaslik.DataSource = dt2;

        txtikibaslik.DataTextField = dt2.Columns["adi"].ToString();
        txtikibaslik.DataValueField = dt2.Columns["id"].ToString();
        txtikibaslik.DataBind();

        ListItem yeni2 = new ListItem();
        yeni2.Text = "Seçiniz";
        yeni2.Value = "";

        yeni2.Selected = true;

        txtikibaslik.Items.Insert(0, yeni2);





        MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from rfsh order by sira asc", connect_word);
        DataTable dt3 = new DataTable();
        da3.Fill(dt3);



        txtucbaslik.DataSource = dt3;

        txtucbaslik.DataTextField = dt3.Columns["adi"].ToString();
        txtucbaslik.DataValueField = dt3.Columns["id"].ToString();
        txtucbaslik.DataBind();

        ListItem yeni3 = new ListItem();
        yeni3.Text = "Seçiniz";
        yeni3.Value = "";

        yeni3.Selected = true;

        txtucbaslik.Items.Insert(0, yeni3);


        MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from ccletrozol order by sira asc", connect_word);
        DataTable dt4 = new DataTable();
        da4.Fill(dt4);



        txtdortbaslik.DataSource = dt4;

        txtdortbaslik.DataTextField = dt4.Columns["adi"].ToString();
        txtdortbaslik.DataValueField = dt4.Columns["id"].ToString();
        txtdortbaslik.DataBind();

        ListItem yeni4 = new ListItem();
        yeni4.Text = "Seçiniz";
        yeni4.Value = "";

        yeni4.Selected = true;

        txtdortbaslik.Items.Insert(0, yeni4);


        MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from gnrhat order by sira asc", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);



        txtbesbaslik.DataSource = dt5;

        txtbesbaslik.DataTextField = dt5.Columns["adi"].ToString();
        txtbesbaslik.DataValueField = dt5.Columns["id"].ToString();
        txtbesbaslik.DataBind();

        ListItem yeni5 = new ListItem();
        yeni5.Text = "Seçiniz";
        yeni5.Value = "";

        yeni5.Selected = true;

        txtbesbaslik.Items.Insert(0, yeni5);
    }
    void secmelileridoldur()
    {


        try
        {

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from takipli_siklus1 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);


            DataTable dt2 = new DataTable();
            da2.Fill(dt2);


            if (dt2.Rows[0]["alnbaslik"].ToString() != "")
            {
                txtalnbaslik.SelectedValue = dt2.Rows[0]["alnbaslik"].ToString();
                alnbaslik.Text = txtalnbaslik.SelectedItem.Text.ToString();
                aln2baslik.Text = txtalnbaslik.SelectedItem.Text.ToString();
                aln3baslik.Text = txtalnbaslik.SelectedItem.Text.ToString();
            }

            if (dt2.Rows[0]["ikibaslik"].ToString() != "")
            {
                txtikibaslik.SelectedValue = dt2.Rows[0]["ikibaslik"].ToString();
                ikibaslik.Text = txtikibaslik.SelectedItem.Text.ToString();
                iki2baslik.Text = txtikibaslik.SelectedItem.Text.ToString();
                iki3baslik.Text = txtikibaslik.SelectedItem.Text.ToString();
            }


            if (dt2.Rows[0]["ucbaslik"].ToString() != "")
            {
                txtucbaslik.SelectedValue = dt2.Rows[0]["ucbaslik"].ToString();
                ucbaslik.Text = txtucbaslik.SelectedItem.Text.ToString();
                uc2baslik.Text = txtucbaslik.SelectedItem.Text.ToString();
                uc3baslik.Text = txtucbaslik.SelectedItem.Text.ToString();
            }


            if (dt2.Rows[0]["dortbaslik"].ToString() != "")
            {
                txtdortbaslik.SelectedValue = dt2.Rows[0]["dortbaslik"].ToString();
                dortbaslik.Text = txtdortbaslik.SelectedItem.Text.ToString();
                dort2baslik.Text = txtdortbaslik.SelectedItem.Text.ToString();
                dort3baslik.Text = txtdortbaslik.SelectedItem.Text.ToString();
            }


            if (dt2.Rows[0]["besbaslik"].ToString() != "")
            {
                txtbesbaslik.SelectedValue = dt2.Rows[0]["besbaslik"].ToString();
                besbaslik.Text = txtbesbaslik.SelectedItem.Text.ToString();
                bes2baslik.Text = txtbesbaslik.SelectedItem.Text.ToString();
                bes3baslik.Text = txtbesbaslik.SelectedItem.Text.ToString();
            }

        }


        catch
        {



        }
    }
    void menuyukle2()
    {

            if (Request.QueryString["siklus_id"] != null && Request.QueryString["infertilite_kategori_id"] != null)
            {

                   snc.Visible = false;
            }


            if (Request.QueryString["siklus_id"] != null && Request.QueryString["ts"] != null)
            {

       
                snc.Visible = true;
  
                ozelbilgiyukle();

                takipli_siklus_islemleri();

                kisaSiklusYukle();

            }
    }
    void ozelbilgiyukle()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];


            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            string siklus_id = Request.QueryString["siklus_id"].ToString();

            Label1.Text = dt5.Rows[0]["siklus_ay"].ToString().ToUpper() + " - " + dt5.Rows[0]["siklus_yil"].ToString();
            ts2label.Text = dt5.Rows[0]["siklus_ay"].ToString().ToUpper() + " - " + dt5.Rows[0]["siklus_yil"].ToString();
            ts3label.Text = dt5.Rows[0]["siklus_ay"].ToString().ToUpper() + " - " + dt5.Rows[0]["siklus_yil"].ToString();

             }

        catch
        {

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        string ay = "";

        if (dt5.Rows[0]["siklus_ay"].ToString() == "Ocak")
        {
            ay = "01";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Şubat")
        {
            ay = "02";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Mart")
        {
            ay = "03";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Nisan")
        {
            ay = "04";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Mayıs")
        {
            ay = "05";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Haziran")
        {
            ay = "06";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Temmuz")
        {
            ay = "07";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Ağustos")
        {
            ay = "08";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Eylül")
        {
            ay = "09";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Ekim")
        {
            ay = "10";
        }
        else if (dt5.Rows[0]["siklus_ay"].ToString() == "Kasım")
        {
            ay = "11";
        }
        else
        {
            ay = "12";
        }


        MySqlCommand cmd = new MySqlCommand("Update siklus_ana_tab set baslangic = null ,siklus_ay2='"+ay+"' where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);

        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();


        if (eks == 1)
        {

            Response.Redirect("~/ivfyonetici/0000067.aspx?snc=true");
        }

        else
        {
            Panel5.Visible = true;
            Label7.Text = "Siklus değişim işlemi başarısız !";
            Label7.ForeColor = System.Drawing.Color.Red;

        }


    }
    protected void Button2_Click(object sender, EventArgs e)
    {





        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlCommand cmd = new MySqlCommand("Update siklus_ana_tab set onay = null where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);

        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();


        if (eks == 1)
        {

            Response.Redirect("~/ivfyonetici/0000067.aspx?snc=true");

        }

        else
        {
            Panel5.Visible = true;
            Label7.Text = "Siklus değişim işlemi başarısız !";
            Label7.ForeColor = System.Drawing.Color.Red;

        }


    }

    protected void Button7_Click(object sender, EventArgs e)
    {




        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];


        MySqlConnection connection = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter da = new MySqlDataAdapter("Select * from siklus_ana_tab where varsayilan='+' and hasta_id='" + hasta_id + "'", connection);
        DataTable dt = new DataTable();
        da.Fill(dt);

        string eskisiklus="";

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

            MySqlCommand cmd2 = new MySqlCommand("Update siklus_ana_tab set varsayilan = '+' where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connection);

            connection.Open();
            int eks2 = cmd2.ExecuteNonQuery();
            connection.Close();

            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
            string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın varsayılan siklusunun değiştirilmesi";
            mp_class.log_kaydet(kullaniciAdiAdmin, islem);


            if (eskisiklus.ToString() != "")
            {

                MySqlCommand cmd3 = new MySqlCommand("Update heyetraporsonuclari set siklus_id = "+Request.QueryString["siklus_id"]+" where siklus_id=" + eskisiklus + "", connection);

                connection.Open();
                int eks3 = cmd3.ExecuteNonQuery();
                connection.Close();
            
            }

            Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + Request.QueryString["siklus_id"].ToString());
        }
        else
        {
            Panel5.Visible = true;
            Label7.Text = "Varsayılan siklus değişim işlemi başarısız !";
            Label7.ForeColor = System.Drawing.Color.Red;
        }




    }
}