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
          

           HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
           String hasta_id = islemdekihasta["HastaID"];
           adi.Text = mp_class.hasta_adi_bul(hasta_id);
           ID.Text = hasta_id;
           sonucyukle();
      

         
        }

        //document.getElementById('ctl00_ContentPlaceHolder1_gizlenecek').style.display = 'block';

    
    }


    private void sonucyukle()
    {
        heyetbasvurulariniyukle();
    }

    void heyetbasvurulariniyukle()
    {

        try
        {
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from heyetbasvuru where hastaID="+ID.Text.ToString()+" order by sonuc asc , str_to_date(kayittarihi,'%d.%m.%Y') desc", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            list.DataSource = mp_dt;
            list.DataBind();

            Label1.Text = adi.Text + " Adlý Hastanýn Daha Önceki Baþvuru ve Sonuçlarý Ýle Ýlgili Toplam  " + mp_dt.Rows.Count + " Kayýt Bulundu.";          

            int i = 0;
            foreach (GridViewRow str in list.Rows)
            {
                Label ad = new Label();
                ad = (Label)str.FindControl("hastaAdi");
                ad.Text = mp_class.hasta_adi_bul(mp_dt.Rows[i]["hastaID"].ToString());
                
                Label ht = new Label();
                ht = (Label)str.FindControl("heyettarihi");
                ht.Text = tarihial(mp_dt.Rows[i]["heyetID"].ToString());

                PlaceHolder ph = new PlaceHolder();
                ph = (PlaceHolder)str.FindControl("ph");
           
                LinkButton iptal = new LinkButton();
                iptal = (LinkButton)str.FindControl("ipt");
                iptal.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                iptal.CommandName = ad.Text;


                LinkButton sil = new LinkButton();
                sil = (LinkButton)str.FindControl("lbSil");
                sil.CommandArgument = mp_dt.Rows[i]["heyetID"].ToString();
                sil.CommandName = mp_dt.Rows[i]["hastaID"].ToString();

                Label durum = new Label();
                durum = (Label)str.FindControl("drm");

                Label sonuc = new Label();
                sonuc = (Label)str.FindControl("sonuc");

                //ImageButton incele = new ImageButton();
                //incele = (ImageButton)str.FindControl("incele");


                //incele.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                //incele.OnClientClick = "window.open('surec.aspx?ID=" + raporID(mp_dt.Rows[i]["heyetID"].ToString())+"','','location=1,status=0,scrollbars=1,width=600,height=500');";

                sonuc.Text = sonucAl(mp_dt.Rows[i]["heyetID"].ToString(),ID.Text);




                if (mp_dt.Rows[i]["sonuc"].ToString() == "+")
                {

                    durum.Text = "Heyette Görüþüldü";
                    durum.ForeColor = System.Drawing.Color.Green;
                    //iptal.Enabled = false;

                    //Label a1 = new Label();
                    //a1.Text = "Tüp bebek tedavisine uygun mu : ";
                    //Label a2 = new Label();
                    //Label a3 = new Label();
                    //Label a4 = new Label();
                    //a4.Text = "<br>Resmi rapor verildi mi : ";
                    //Label a5 = new Label();
                    //Label a6 = new Label();

                    //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyetraporsonuclari where heyetID=" + mp_dt.Rows[i]["heyetID"].ToString() + " and hastaID=" + ID.Text.ToString() + "", mp_connection);
                    //DataTable mp_dt2 = new DataTable();
                    //mp_da2.Fill(mp_dt2);
                    //if (mp_dt2.Rows[0]["tibbiraporverildimi"].ToString() == "+")
                    //{
                    //    a2.Text = "Evet";
                    //    a2.ForeColor = System.Drawing.Color.Green;
                    //    a3.Text = " / " + tibbikontrolevet(mp_dt2.Rows[0]["tibbiraporverilmenedeni"].ToString());

                    //}
                    //else
                    //{
                    //    a2.Text = "Hayýr";
                    //    a2.ForeColor = System.Drawing.Color.Red;
                    //    a3.Text = " / " + tibbikontrol(mp_dt2.Rows[0]["tibbiraporverilmemenedeni"].ToString());

                    //}


                    //if (mp_dt2.Rows[0]["resmiraporverildimi"].ToString() == "+")
                    //{
                    //    a5.Text = "Evet";
                    //    a5.ForeColor = System.Drawing.Color.Green;
                    //    a6.Text = " / " + resmikontrolevet(mp_dt2.Rows[0]["resmiraporverilmenedeni"].ToString());

                    //}
                    //else
                    //{
                    //    a5.Text = "Hayýr";
                    //    a5.ForeColor = System.Drawing.Color.Red;
                    //    a6.Text = " / " + resmikontrol(mp_dt2.Rows[0]["resmiraporverilmemenedeni"].ToString());

                    //}

                    //ph.Controls.Add(a1);
                    //ph.Controls.Add(a2);
                    //ph.Controls.Add(a3);
                    //ph.Controls.Add(a4);
                    //ph.Controls.Add(a5);
                    //ph.Controls.Add(a6);
                

                }
                else
                { 
                 durum.Text = "Baþvuru Aþamasýnda";
                 durum.ForeColor = System.Drawing.Color.Red;
                 iptal.Enabled = true;
               
                 sonuc.Text = "-";
                }




              
                i++;

            }
        }
        catch
        {

        }
    }

    private string sonucAl(string heyetID, string hastaID)
    {

        string sonuc = "";

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID= "+hastaID.ToString()+" and H.heyetID="+heyetID.ToString()+" and H.tibbiraporverildimi = '+' and H.ay is null and H.yil is null and H.hafta is null and H.tedaviiptal2 is null and H.tedaviomudisindanerede is null and H.mazeretlimi is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);
        DataTable dt = new DataTable();
        da.Fill(dt);

        if (dt.Rows.Count == 1)
        {
           sonuc = "Randevu Bekleyenler Listesinde.";
        }

        MySqlDataAdapter da2 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = "+hastaID.ToString()+" and H.heyetID="+heyetID.ToString()+" and not H.genelhafta is null and tedavisurecinde is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        if (dt2.Rows.Count == 1)
        {
            sonuc = "Randevu Listesinde.";
        }

        MySqlDataAdapter da3 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + " and not H.genelhafta is null and not tedavisurecinde is null and tedaviiptal is null and tedavibittimi is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);
        DataTable dt3 = new DataTable();
        da3.Fill(dt3);

        if (dt3.Rows.Count == 1)
        {
            sonuc = "Tedavi Sürecinde Listesinde.";
        }

        MySqlDataAdapter da4 = new MySqlDataAdapter("Select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + " and not H.transfertarihi is null and H.tedavisurecinde ='+' and H.opuiptal is null and H.transferiptal is null and H.siklusiptal2 is null and H.tedaviiptal2 is null  and H.tedavibittimi is null and (DATEDIFF(NOW(),str_to_date(H.transfertarihi,'%d.%m.%Y %H:%i:%s')) >=1 or H.transfer='+')", mp_connection);
        DataTable dt4 = new DataTable();
        da4.Fill(dt4);

        if (dt4.Rows.Count == 1)
        {
            sonuc = "Gebelik Sonucu Bekleyenler Listesinde.";
        }


        MySqlDataAdapter da5 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + " and (H.tedavibittimi = '+' or H.opuiptal = '+' or H.transferiptal = '+' or H.siklusiptal2 = '+') and not H.tedaviomudemi = '-'", mp_connection);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        if (dt5.Rows.Count == 1)
        {
            sonuc = "Tedavisi Bitenler Listesinde.";
        }


        MySqlDataAdapter da6 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + "  and H.tedaviomudemi = '-' and H.tedavibittimi is null", mp_connection);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);

        if (dt6.Rows.Count == 1)
        {
            sonuc = "Tedavisi MP-SAMSUN Dýþýnda Devam Edenler Listesinde.";
        }

        MySqlDataAdapter da7 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + "  and  H.tedaviiptal = '+' order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);
        DataTable dt7 = new DataTable();
        da7.Fill(dt7);

        if (dt7.Rows.Count == 1)
        {
            sonuc = "Tedavisi Ertelenenler Listesinde.";
        }


        MySqlDataAdapter da8 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + " and H.mazeretlimi = '+'", mp_connection);
        DataTable dt8 = new DataTable();
        da8.Fill(dt8);
        if (dt8.Rows.Count == 1)
        {
            sonuc = "Beklemedekiler Listesinde.";
        }

        MySqlDataAdapter da9 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + "  and H.tedaviiptal2 = '+'", mp_connection);
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);
        if (dt9.Rows.Count == 1)
        {
            sonuc = "Tedavisi Ýptal Edilenler Listesinde.";
        }


        MySqlDataAdapter da10 = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.hastaID = " + hastaID.ToString() + " and H.heyetID=" + heyetID.ToString() + "  and H.tedaviomudemi = '-' and H.tedavibittimi='+' order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);
        DataTable dt10 = new DataTable();
        da10.Fill(dt10);
        if (dt10.Rows.Count == 1)
        {
            sonuc = "Tedavisi MP-SAMSUN Dýþýnda Bitenler Listesinde.";
        }


        return sonuc;

    }

    protected void hasta_adi_Command(object sender, CommandEventArgs e)
    {
        HttpCookie mpKullanilan2 = Request.Cookies["AdminOturumSuresi"];
        string sure = mpKullanilan2["Adminsure"].ToString();
        HttpCookie islemdekihasta = new HttpCookie("HastaBilgi");
        islemdekihasta["HastaID"] = e.CommandArgument.ToString();
        islemdekihasta.Expires = DateTime.Now.AddMinutes(int.Parse(sure.ToString()));
        Response.Cookies.Add(islemdekihasta);
        Response.Redirect("hasta_modulu/");
    }

    protected void ipt_Command1(object sender, CommandEventArgs e)
    {
        try
        {
           
            string basvuruId = e.CommandArgument.ToString();

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand mp_cmd = new MySqlCommand("delete  from heyetbasvuru where ID=" + basvuruId.ToString() + "", mp_connection);

            mp_connection.Open();
            int eks = mp_cmd.ExecuteNonQuery();
            mp_connection.Close();

            if (eks == 1)
            {
               
                Label3.Text = "Baþvuru Kaydý Baþarýyla Ýptal Edildi.";
                Label3.ForeColor = System.Drawing.Color.Green;

                HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
                string islem = e.CommandName.ToString() + " adlý hastanýn heyet baþvurusunun iptali";
                mp_class.log_kaydet(kullaniciAdiAdmin, islem);

                heyetbasvurulariniyukle();
         
            }
            else
            {
              
               Label3.Text = "Baþvuru Kaydý Ýptal Edilemedi!";
               Label3.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch
        {
           
            Label3.Text = "Baþvuru Kaydý Silme Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz!";
            Label3.ForeColor = System.Drawing.Color.Red;
        
        }
    }

    private string resmikontrol(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from resmi_rapor where ID=" + p + "", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["Adi"].ToString();
    }

    private string resmikontrolevet(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from resmi_rapor_v where ID=" + p + "", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["Adi"].ToString();
    }

    private string tibbikontrol(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from tibbi_rapor where ID=" + p + "", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["Adi"].ToString();

    }

    private string tibbikontrolevet(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from tibbi_rapor_v where ID=" + p + "", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["Adi"].ToString();

    }

     string tarihial(string ID)
    {
        try
        {
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyettarihleri where ID=" + ID + "", mp_connection);
            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);

            if (mp_dt2.Rows[0]["gunluk"].ToString() == "+")
                return mp_dt2.Rows[0]["tarih"].ToString() + " G";
            else
                return mp_dt2.Rows[0]["tarih"].ToString();

        }
        catch
        {

            return "";
        }
    
    }


    string raporID(string ID)
    {
        try
        {

           HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
           String hasta_id = islemdekihasta["HastaID"];


            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyetraporsonuclari where heyetID=" + ID + " and hastaID="+hasta_id+"", mp_connection);
            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);

           return mp_dt2.Rows[0]["raporID"].ToString();
           
        }
        catch
        {

            return "";
        }

    }



    protected void lbSil_Command(object sender, CommandEventArgs e)
    {


        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
        string ekleyen = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);


        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand cmd = new MySqlCommand("Delete From heyetbasvuru where heyetID ="+e.CommandArgument.ToString()+" and hastaID = "+e.CommandName.ToString()+"",mp_connection);
        MySqlCommand cmd2 = new MySqlCommand("Delete From heyetraporsonuclari where heyetID =" + e.CommandArgument.ToString() + " and hastaID = " + e.CommandName.ToString() + "", mp_connection);

        mp_connection.Open();

        cmd.ExecuteNonQuery();
        int eks = cmd.ExecuteNonQuery();
        int eks2 = cmd2.ExecuteNonQuery();
        
        mp_connection.Close();

        heyetbasvurulariniyukle();


    }
}


