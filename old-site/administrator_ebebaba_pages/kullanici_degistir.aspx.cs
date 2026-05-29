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




public partial class administrator_ebebaba_pages_kullanici_degistir : System.Web.UI.Page
{ 
    
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ortak_kullanici_yukle();

  
        }


    }

    public void ortak_kullanici_yukle()
    {

        try
        {
          
            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];

            EbebabaKullanilan.Expires = DateTime.Now.AddMinutes(-121);
            Response.Cookies.Add(EbebabaKullanilan);

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select uye_k_adi,concat(uye_adi,' ',uye_soyadi) as adi from uye_doktor where ortak_kullanici='+' order by concat(uye_adi,' ',uye_soyadi) asc", ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);


            ortak_kullanici_kutu.DataSource = ebebaba_dt2;
            ortak_kullanici_kutu.DataTextField = ebebaba_dt2.Columns["adi"].ToString();
            ortak_kullanici_kutu.DataValueField = ebebaba_dt2.Columns["uye_k_adi"].ToString();

            ortak_kullanici_kutu.DataBind();


            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            ortak_kullanici_kutu.Items.Insert(0, yeni);
        
        }

        catch
        {

        }




    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //try
        //{


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select uye_k_adi,concat(uye_adi,' ',uye_soyadi) as adi from uye_doktor where ortak_kullanici='+' and uye_k_adi='" + ortak_kullanici_kutu.SelectedValue.ToString() + "' and uye_sifre='" + txtsifre.Text.ToString() + "'", ebebaba_connection);

            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);

            if (ebebaba_dt2.Rows.Count == 1)
            {



                HttpCookie EbebabaKullanilan = new HttpCookie("AdminK");
                EbebabaKullanilan["AdminKKA"] = ebebaba_dt2.Rows[0]["uye_k_adi"].ToString();
                EbebabaKullanilan["Adminsure"] = baglanti_suresi.SelectedValue;

                EbebabaKullanilan.Expires = DateTime.Now.AddMinutes(int.Parse(baglanti_suresi.SelectedValue));

                Response.Cookies.Add(EbebabaKullanilan);



                if (Session["sonsayfa"] != null && Session["sonsayfa"].ToString() != "")
                {
                    Response.Redirect(Session["sonsayfa"].ToString().Substring(0, 12));
                }
                else
                {

                    Response.Redirect("0000002.aspx");



                }


            }
            else
            {
                sonuc.Text = "Giriþ Baþarýsýz.Bilgilerinizi Kontrol Ediniz !";
                sonuc.ForeColor = System.Drawing.Color.Red;


            }


        //}

        //catch
        //{

        //    sonuc.Text = "Oturum Açma Esnasýnda Bir Hata Oluþtu.Ýþlem Baþarýsýz !";
        //    sonuc.ForeColor = System.Drawing.Color.Red;

        //}
    }
}
