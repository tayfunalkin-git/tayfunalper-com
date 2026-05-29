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

public partial class administrator_ebebaba_pages_0000022 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
    forum_class fc = new forum_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Request.QueryString["kaynak"].ToString() != "gelen_mesajlar" || Request.QueryString["mesaj_id"].ToString() != Session["mesaj_id7"].ToString())
            {


                Response.Redirect("0000060.aspx");

            }
            else
            {

                mesaji_yukle();

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
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select * from sorutable where ID=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);


            Label3.Text = ebebaba_dt2.Rows[0]["gonderen"].ToString();
            Label6.Text = ebebaba_dt2.Rows[0]["tarih"].ToString();
        
            Label4.Text = ebebaba_dt2.Rows[0]["soru"].ToString();
     
            Label12.Text = ebebaba_dt2.Rows[0]["eposta"].ToString();


        
            Label9.Text = kullaniciAdi.ToString();
            Label8.Text = ebebaba_dt2.Rows[0]["gonderen"].ToString();
            Label10.Text = ebebaba_dt2.Rows[0]["eposta"].ToString();


            ebebaba_dt2.Rows[0]["okundu"] = "0";


            MySqlCommand ebebaba_cmd3 = new MySqlCommand("update sorutable set okundu = '0' where ID=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();





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
            MySqlCommand ebebaba_cmd3 = new MySqlCommand("Delete from sorutable where ID=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();



            if (eks3 == 1)
            {


                string yonlendir = "";
                if (Request.QueryString["kaynak"] == "gelen_mesajlar")
                {

                    yonlendir = "0000060.aspx";

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

            yonlendir = "0000060.aspx";

        }

        Response.Redirect(yonlendir);



    }
    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {


        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("insert into sorutable_giden(gonderen,soru,cevap,tarih,eposta) values (?1,?2,?3,?4,?5)", ebebaba_connection);

            ebebaba_cmd2.Parameters.AddWithValue("?1",Label8.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?2", Label4.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?3", msjmesaj.Text);
            ebebaba_cmd2.Parameters.AddWithValue("?4", DateTime.Now.ToString());
            ebebaba_cmd2.Parameters.AddWithValue("?5",Label12.Text);

 
            ebebaba_connection.Open();
            int eks2 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

            MySqlCommand ebebaba_cmd3 = new MySqlCommand("Update sorutable set cevap='1' where ID=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (Label12.Text != "")
            {

                string mesaj2 = "<font face='Tahoma'>Merhaba " + Label3.Text.ToUpper().TrimStart().TrimEnd();
                mesaj2 = mesaj2 + "<br>" + Label6.Text + " tarihinde sitemiz üzerinden Prof.Dr.Tayfun ALPER'e yönelttiðiniz soru ,"+Label7.Text +" tarafýndan aþaðýdaki þekilde cevaplanmýþtýr ;<br>";
                mesaj2 = mesaj2 + "<br><br>Cevap : " +msjmesaj.Text + "<br>";

                mesaj2 = mesaj2 + "<br>" + "<u>Göndermiþ olduðunuz soru aþaðýdadýr:</u>"+"<br>";
                mesaj2 = mesaj2 + "<br>" +Label4.Text+ "<br></font>";

                
                
                mesaj2 = mesaj2 + "<br>" + fc.adresal(0301009184).ToString();

                fc.mailsend("Prof.Dr.Tayfun ALPER Sorunuzu Cevapladý.", Label12.Text, mesaj2);
                fc.mailsend("Prof.Dr.Tayfun ALPER Sorunuzu Cevapladý.", "y_tayfun_alper@yahoo.com", mesaj2);

            }

            if (eks2 == 1 && eks3 == 1)
            {



                panel_sonuc.Visible = true;
                sonuc.Text = "Mesajýnýz Baþarýyla Gönderilmiþtir.";
                sonuc.ForeColor = System.Drawing.Color.Green;
                msjmesaj.Enabled = false;
                btnKaydet.Enabled = false;
                Response.Redirect("0000060.aspx");

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
