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

public partial class administrator_ebebaba_pages_0000066 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
    forum_class fc = new forum_class();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Request.QueryString["kaynak"].ToString() != "gelen_mesajlar" || Request.QueryString["mesaj_id"].ToString() != Session["mesaj_id9"].ToString())
            {


                Response.Redirect("0000064.aspx?ID"+Request.QueryString["kat"].ToString());

            }
            else
            {

                mesaji_yukle();
                cevapYukle();
            }
        }
        catch
        { 
        
        }


    }

    void mesaji_yukle()
    {

        try
        {

            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = EbebabaKullanilan["AdminKKA"].ToString();

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select * from kitap_yardim where mesaj_id="+Request.QueryString["mesaj_id"].ToString()+"", ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);


            Label3.Text = ebebaba_dt2.Rows[0]["ad_soyad"].ToString();
            Label6.Text = ebebaba_dt2.Rows[0]["tarih"].ToString();
            Label4.Text = ebebaba_dt2.Rows[0]["konu"].ToString();
            Label5.Text = ebebaba_dt2.Rows[0]["mesaj"].ToString();
            Label12.Text = ebebaba_dt2.Rows[0]["email"].ToString();
            Label15.Text = ebebaba_dt2.Rows[0]["gonderenTipi"].ToString();
            Label16.Text = ebebaba_dt2.Rows[0]["fikirTipi"].ToString();
            Label17.Text = ebebaba_dt2.Rows[0]["kayitTipi"].ToString();
            Label18.Text = ebebaba_dt2.Rows[0]["ip"].ToString();

           
            
            Label7.Text = ebebaba_class.doktor_kullanici_adi_bul(kullaniciAdi.ToString());
            Label9.Text = kullaniciAdi.ToString();
            Label8.Text = ebebaba_dt2.Rows[0]["ad_soyad"].ToString();
            Label10.Text = ebebaba_dt2.Rows[0]["email"].ToString();


            ebebaba_dt2.Rows[0]["hit"] = "0";


            MySqlCommand ebebaba_cmd3 = new MySqlCommand("update kitap_yardim set hit = '0' where mesaj_id=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();


            MySqlDataAdapter da33 = new MySqlDataAdapter("Select * from kitap_konulari where konu_id =" + ebebaba_dt2.Rows[0]["konu"].ToString() + "", ebebaba_connection);
            DataTable dtsub3 = new DataTable();
            da33.Fill(dtsub3);
            Label14.Text = dtsub3.Rows[0]["konu"].ToString() + " e-Demokrasi Gelen Mesaj Detayý";

            Label4.Text = dtsub3.Rows[0]["konu"].ToString();
             msjkonu.Text = "Cevap: " + dtsub3.Rows[0]["konu"].ToString() + " e-Demokrasi Mesajýnýz" ;





                    }

        catch
        {

        }




    }

    void cevapYukle()
    {

        try
        {

            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = EbebabaKullanilan["AdminKKA"].ToString();

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select * from yardim_tab_giden where gelen_mesaj_id=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);

            DataList1.DataSource = ebebaba_dt2;
            DataList1.DataBind();

            if (ebebaba_dt2.Rows.Count == 0)
            {
                panel_sonuc0.Visible = true;
              
                sonuc0.Text = "Bu Mesaja Henüz Cevap Gönderilmedi.";
                sonuc0.ForeColor = System.Drawing.Color.Red;

            }
            else
            {

                panel_sonuc0.Visible = true;

                sonuc0.Text = ebebaba_dt2.Rows.Count.ToString() + " Cevap Gönderildi.";
                sonuc0.ForeColor = System.Drawing.Color.Green;

                Label tarih = new Label();
                Label mesaj = new Label();
                int a = 0;
                foreach (DataListItem oge in DataList1.Items)
                {

                    tarih = (Label)oge.FindControl("tarih");
                    mesaj = (Label)oge.FindControl("mesaj");

                    tarih.Text = ebebaba_dt2.Rows[a]["tarih"].ToString();
                    mesaj.Text = ebebaba_dt2.Rows[a]["mesaj"].ToString();
                    a++;


                }
            }


         

        }

        catch
        {

        }




    }


   
    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {
 try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd3 = new MySqlCommand("Delete from kitap_yardim where mesaj_id=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();



            if (eks3 == 1)
            {


                string yonlendir = "";
                if (Request.QueryString["kaynak"] == "gelen_mesajlar")
                {

                    yonlendir = "0000064.aspx?ID="+Request.QueryString["kat"].ToString();

                }

                Response.Redirect(yonlendir);





            }

            else
            {

                Panel3.Visible = true;
                Label2.Text = "Mesaj Silme Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Mesaj Silinemedi !";
                Label2.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {


            Panel3.Visible = true;
            Label2.Text = "Mesaj Silme Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Mesaj Silinemedi !";
            Label2.ForeColor = System.Drawing.Color.Red;

        }
    }
    protected void Button1_Click1(object sender, ImageClickEventArgs e)
    {

        string yonlendir = "";
        if (Request.QueryString["kaynak"] == "gelen_mesajlar")
        {

            yonlendir = "0000064.aspx?ID="+Request.QueryString["kat"].ToString();

        }

        Response.Redirect(yonlendir);



    }
    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {


        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
        
            MySqlCommand ebebaba_cmd2 = new MySqlCommand("insert into yardim_tab_giden(ad_soyad,gonderen,konu,mesaj,tarih,email,gelen_mesaj_id) values (?1,?2,?3,?4,?5,?6,?7)", ebebaba_connection);


            ebebaba_cmd2.Parameters.AddWithValue("?1",Label8.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?2", Label7.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?3", msjkonu.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?4", msjmesaj.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?5", DateTime.Now.ToString());
            ebebaba_cmd2.Parameters.AddWithValue("?6", Label12.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?7", Request.QueryString["mesaj_id"].ToString());
     
            ebebaba_connection.Open();
            int eks2 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

            MySqlCommand ebebaba_cmd3 = new MySqlCommand("Update kitap_yardim set cevap='1' where mesaj_id=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (Label12.Text != "")
            {

                string mesaj2 = "<font face='Arial'>Merhaba " + Label8.Text.ToUpper().TrimStart().TrimEnd();
                mesaj2 = mesaj2 + "<br>" + Label6.Text + " tarihinde e-Demokrasi sayfasýndan gönderdiðiniz mesaj," + Label7.Text + " tarafýndan aþaðýdaki þekilde cevaplanmýþtýr ;<br>";
                mesaj2 = mesaj2 + "<br><br>Cevap : " + msjmesaj.Text + "<br>";

                mesaj2 = mesaj2 + "<br>" + "<u>Göndermiþ olduðunuz mesajýnýz aþaðýdadýr:</u>" + "<br>";
                mesaj2 = mesaj2 + "<br>" + Label5.Text + "<br></font>";

                mesaj2 = mesaj2 + "<br>" + fc.adresal(0301009184).ToString();

                fc.mailsend(msjkonu.Text, Label12.Text, mesaj2);
                fc.mailsend(msjkonu.Text, "y_tayfun_alper@yahoo.com", mesaj2);
            }

            if (eks2 == 1 && eks3 == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Mesajýnýz Baþarýyla Gönderilmiþtir.";
                sonuc.ForeColor = System.Drawing.Color.Green;
                msjmesaj.Enabled = false;
                btnKaydet.Enabled = false;
                Response.Redirect("0000064.aspx?ID="+Request.QueryString["kat"].ToString());

            }
            else if (eks2 != 1)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Mesajýnýz Baþarýyla Gönderildi.Fakat Giden Kutusuna Kaydedilemedi !";
                sonuc.ForeColor = System.Drawing.Color.Green;

            }




        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Mesaj Cevaplama Esnasýnda Sistem Bir Hata Ýle Karþýlaþtý.Mesajýnýz Gönderilemedi !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }


    }
}
