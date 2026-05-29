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

public partial class administrator_ebebaba_pages_0000051 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

            kitap_yukle();



        if (Request.QueryString["konu_id"] != null)
        {

            try
            {

                MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitap_konulari where konu_id=" + Request.QueryString["konu_id"].ToString() + "", ebebaba_connection);
                DataTable ebebaba_dt = new DataTable();
                ebebaba_da.Fill(ebebaba_dt);



                if (ebebaba_dt.Rows.Count == 1)
                {
                    kitaplist.SelectedValue = listbul(ebebaba_dt.Rows[0]["kategori_id"].ToString());
                    kategori_yukle();
                    kategorilist.Enabled = true;

                    kategorilist.SelectedValue = ebebaba_dt.Rows[0]["kategori_id"].ToString();
                    konu_yukle();
                    konulist.Enabled = true;

                    konulist.SelectedValue = Request.QueryString["konu_id"].ToString();

                    bilgi_yukle();


                }

                else
                {

                    Response.Redirect("0000050.aspx");


                }


            }

            catch
            {
                Response.Redirect("0000050.aspx");

            }

        }



         

   }


   if (kitaplist.SelectedValue == "")
   {

       panel_sonuc.Visible = false;
       btnKaydet.Enabled = false;
       y_konu.Text = "";
       mesaj.Text = "";
       kategorilist.Enabled = false;
       konulist.Enabled = false;
       y_konu.Enabled = false;
       yayin.Enabled = false;
       
   }


   if (kategorilist.SelectedValue == "")
   {

       panel_sonuc.Visible = false;
       btnKaydet.Enabled = false;
       konulist.Enabled = false;

       y_konu.Text = "";
       mesaj.Text = "";
       konulist.Enabled = false;
       y_konu.Enabled = false;
       yayin.Enabled = false;

   }

   
   if (konulist.SelectedValue == "")
   {

            panel_sonuc.Visible = false;
       btnKaydet.Enabled = false;

       y_konu.Text = "";
       mesaj.Text = "";

       y_konu.Enabled = false;
       yayin.Enabled = false;
       konu_yukle();

   }

   else
   {


       btnKaydet.Enabled = true ;


   }


   if (kitaplist.SelectedValue == "299")
   {

       Label3.Visible = true;
       anasayfametni.Visible = true;
       RequiredFieldValidator6.Visible = true;



   }
   else
   {
       Label3.Visible = false;
       anasayfametni.Visible = false;
       RequiredFieldValidator6.Visible = false;


   }

    }


    string listbul(string kategori_id)
    {

        MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
        MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitapkategorileri where id="+kategori_id.ToString()+"", ebebaba_connection);
        DataTable ebebaba_dt = new DataTable();
        ebebaba_da.Fill(ebebaba_dt);

        string deger = "";

        if (ebebaba_dt.Rows.Count != 0)
        {
            deger = ebebaba_dt.Rows[0]["kitap_id"].ToString();

        }
        else
        {
            deger = "";
        
        }

        return deger;

    
    
    
    }

    void kitap_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitaplar order by sira asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            kitaplist.DataSource = ebebaba_dt;
            kitaplist.DataTextField = ebebaba_dt.Columns["kitap_adi"].ToString();
            kitaplist.DataValueField = ebebaba_dt.Columns["id"].ToString();

            kitaplist.DataBind();

            ListItem yeni2 = new ListItem();
            yeni2.Text = "Seçiniz";
            yeni2.Value = "";
            kitaplist.Items.Insert(0, yeni2);



        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Kitaplar Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }



    void bilgi_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitap_konulari where konu_id=" + konulist.SelectedValue.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                mesaj.Text = ebebaba_dt.Rows[0]["metin"].ToString();
                y_konu.Text = ebebaba_dt.Rows[0]["konu"].ToString();
                anasayfametni.Text = ebebaba_dt.Rows[0]["anasayfametni"].ToString();
                resim2.ImageUrl = "~/resimler/" + ebebaba_dt.Rows[0]["konu_id"].ToString() + "_thumb.jpg";
                Label15.Text = ebebaba_dt.Rows[0]["konu_id"].ToString();

                if (ebebaba_dt.Rows[0]["yayin"].ToString() == "1")
                {

                    yayin.Checked = true;


                }
                else
                {

                    yayin.Checked = false;
                
                }
                
                btnKaydet.Enabled = true;
                    Button1.Enabled = true;
                    panel_sonuc.Visible = false;
                    y_konu.Enabled = true;
                    yayin.Enabled = true;

        

            }


        }


        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Konu Ýçeriði Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }


    protected void btn_kaydet_Click(object sender, ImageClickEventArgs e)
    {

       try
        {

            string yyn = "1";

            if (yayin.Checked)
            {
                yyn = "1";

            }
            else
            {
                yyn = "0";

            }

            string link = GenisletmeMetotlari.ToURL(y_konu.Text);
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlCommand ebebaba_cmd = new MySqlCommand("update kitap_konulari set konu=?1,metin=?2,yayin=?3,anasayfametni=?4,link=?5 where konu_id=" + konulist.SelectedValue.ToString() + "", ebebaba_connection);

           ebebaba_cmd.Parameters.AddWithValue("?1",y_konu.Text);
           ebebaba_cmd.Parameters.AddWithValue("?2", mesaj.Text);
           ebebaba_cmd.Parameters.AddWithValue("?3", yyn);
           ebebaba_cmd.Parameters.AddWithValue("?4", anasayfametni.Text.ToString());
           ebebaba_cmd.Parameters.AddWithValue("?5", link);

           ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                Response.Redirect("0000050.aspx?kat_id="+kategorilist.SelectedValue.ToString());


                mesaj.Enabled = false;
                y_konu.Enabled = false;

                btnKaydet.Enabled = false;
                yayin.Enabled = false;

                panel_sonuc.Visible = true;
                sonuc.Text = "Konu Güncelleme Ýþlemi Baþarýyla Gerçekleþti";
                sonuc.ForeColor = System.Drawing.Color.Green;



            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Konu Güncelleme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Konu Güncelleme Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }





    }
   
    protected void kategorilist_SelectedIndexChanged(object sender, EventArgs e)
    {
        konu_yukle();
        konulist.Enabled = true;
        btnKaydet.Enabled = false;

        y_konu.Text = "";
        mesaj.Text = "";

        y_konu.Enabled = false;
        yayin.Enabled = false;
    }


    void kategori_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitapkategorileri where kitap_id = '" + kitaplist.SelectedValue.ToString() + "' order by sira asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            kategorilist.DataSource = ebebaba_dt;
            kategorilist.DataTextField = ebebaba_dt.Columns["kategori_adi"].ToString();
            kategorilist.DataValueField = ebebaba_dt.Columns["id"].ToString();

            kategorilist.DataBind();

            ListItem yeni2 = new ListItem();
            yeni2.Text = "Seçiniz";
            yeni2.Value = "";
            kategorilist.Items.Insert(0, yeni2);



        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Yardým Kategorileri Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }



    void konu_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitap_konulari where kategori_id = '" + kategorilist.SelectedValue.ToString() + "' order by sira asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            konulist.DataSource = ebebaba_dt;
            konulist.DataTextField = ebebaba_dt.Columns["konu"].ToString();
            konulist.DataValueField = ebebaba_dt.Columns["konu_id"].ToString();

            konulist.DataBind();

            ListItem yeni2 = new ListItem();
            yeni2.Text = "Seçiniz";
            yeni2.Value = "";
            konulist.Items.Insert(0, yeni2);



        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Yardým Konularý Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }









    protected void kitaplist_SelectedIndexChanged(object sender, EventArgs e)
    {
        kategori_yukle();
        kategorilist.Enabled = true;
        konulist.Enabled = false;
        btnKaydet.Enabled = false;

        y_konu.Text = "";
        mesaj.Text = "";

        y_konu.Enabled = false;
        yayin.Enabled = false;


    }
    protected void konulist_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (konulist.SelectedValue == "")
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Lütfen Bir Konu Seçiniz !";
            sonuc.ForeColor = System.Drawing.Color.Red;


            btnKaydet.Enabled = false;
            Button1.Enabled = false;
            y_konu.Text = "";
            mesaj.Text = "";


        }

        else
        {


            btnKaydet.Enabled = true;
            Button1.Enabled = true;

            bilgi_yukle();
        }





        
        
    }
    protected void Button1_Click1(object sender, ImageClickEventArgs e)
    {

        try
        {

  
        if (Request.QueryString["konu_id"] != null)
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitap_konulari where konu_id=" + Request.QueryString["konu_id"].ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                Response.Redirect("0000050.aspx?kat_id=" + ebebaba_dt.Rows[0]["kategori_id"].ToString());
                
            }



        }
        else
        {
            Response.Redirect("0000050.aspx?kat_id=" + kategorilist.SelectedValue.ToString());
       
        }
        


    }

        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Geri Dönme Ýþlemi Baþarýsýz!";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

}



    void resimdoldur()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from resimler order by str_to_date(tarih,'%d.%m.%Y %H:%i:%s') desc", ebebaba_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            resimler.DataSource = dt;
            resimler.DataBind();

            if (dt.Rows.Count == 0)
            {
                Panel1.Visible = true;
                Label2.Text = "Toplam 0 resim bulundu !";

            }
            else
            {
                Panel1.Visible = true;
                Label2.Text = "Toplam " + dt.Rows.Count.ToString() + " resim bulundu !";

            }

        }
        catch
        {

        }
    }
    protected void ekle_command(object sender, CommandEventArgs e)
    {
        mesaj.Text = mesaj.Text + "</br>" + "<img src=" + "'../imgyardim/" + e.CommandName.ToString() + "'>";

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        resimdoldur();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {

            string LID = Label15.Text;


            resim.SaveAs(Server.MapPath("~/resimler/" + LID + ".jpg"));

            resimislem yeniresim = new resimislem();
            System.Drawing.Image kucuk0 = yeniresim.ResimOlustur(100, Server.MapPath("~/resimler/" + LID + ".jpg"));

            kucuk0.Save(Server.MapPath("~/resimler/" + LID + "_thumb.jpg"));
            bilgi_yukle();

            panel_sonuc.Visible = true;
            sonuc.Text = "Resim baþarýyla yüklendi / güncellendi.";
            sonuc.ForeColor = System.Drawing.Color.Green;

            resim2.ImageUrl = "~/resimler/" + LID + "_thumb.jpg";


        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Resim Yüklenemedi. Lütfen tekrar deneyiniz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
}

