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

public partial class administrator_ebebaba_pages_0000049 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
    

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            kitap_yukle();
           
         

        }
        if (kitaplist.SelectedValue == "299")
        {

            Label3.Visible = true;
            anasayfametni.Visible = true;
            RequiredFieldValidator4.Visible = true;



        }
        else
        {
            Label3.Visible = false;
            anasayfametni.Visible = false;
            RequiredFieldValidator4.Visible = false;


        }
    }


    void resimdoldur()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from resimler order by date(tarih) desc", ebebaba_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            resimler.DataSource = dt;
            resimler.DataBind();

            if (dt.Rows.Count == 0)
            {
                Panel1.Visible = true ;
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
            sonuc.Text = "Yardým Kategorileri Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }




 



    protected void Button1_Click(object sender, EventArgs e)
    {
        mesaj.Enabled = true;
        konu.Enabled = true;
        kitaplist.Enabled = true;
        

        mesaj.Text = "";
        konu.Text = "";
        kitaplist.SelectedValue = "";
        panel_sonuc.Visible = false;
btnKaydet.Enabled = true;
       
    }
    protected void btn_kaydet_Click(object sender, ImageClickEventArgs e)
    {

        //try
        //{

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand da = new MySqlCommand("select max(sira) from kitap_konulari where kategori_id='" + kategorilist.SelectedValue.ToString() + "'", ebebaba_connection);


            ebebaba_connection.Open();
            object eks3 = da.ExecuteScalar();
            ebebaba_connection.Close();


            int eklenecek_sira = 0;


            string donustur = eks3.ToString();


            if (donustur == "")
            {

                eklenecek_sira = 1;



            }
            else
            {

                int donusen = int.Parse(donustur);


                eklenecek_sira = donusen + 1;


            }

            string yyn = "0";

            if (yayin.Checked)
            {

                yyn = "1";

            }
            else
            {
                yyn = "0";

            }


            string link = GenisletmeMetotlari.ToURL(konu.Text);

            MySqlCommand ebebaba_cmd = new MySqlCommand("insert into kitap_konulari(kategori_id,konu,metin,tarih,sira,ilksayfa,hit,yayin,anasayfametni,link) values (?1,?2,?3,?4,?5,?6,?7,?8,?9,?10)", ebebaba_connection);

            ebebaba_cmd.Parameters.AddWithValue("?1",kategorilist.SelectedValue.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?2", konu.Text);
            ebebaba_cmd.Parameters.AddWithValue("?3", mesaj.Text);
            ebebaba_cmd.Parameters.AddWithValue("?4", DateTime.Now.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?5", eklenecek_sira);
            ebebaba_cmd.Parameters.AddWithValue("?6", "-");
            ebebaba_cmd.Parameters.AddWithValue("?7", "0");
            ebebaba_cmd.Parameters.AddWithValue("?8", yyn);
            ebebaba_cmd.Parameters.AddWithValue("?9", anasayfametni.Text);
            ebebaba_cmd.Parameters.AddWithValue("?10", link);

            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            string LID = ebebaba_cmd.LastInsertedId.ToString();
            ebebaba_connection.Close();

            Label15.Text = LID;

            if (eks == 1)
            {

                resim.SaveAs(Server.MapPath("~/resimler/" + LID + ".jpg"));

                resimislem yeniresim = new resimislem();
                System.Drawing.Image kucuk0 = yeniresim.ResimOlustur(100, Server.MapPath("~/resimler/" + LID + ".jpg"));

                kucuk0.Save(Server.MapPath("~/resimler/" + LID + "_thumb.jpg"));


                Response.Redirect("0000050.aspx?kat_id=" + kategorilist.SelectedValue.ToString());
                mesaj.Enabled = false;
                konu.Enabled = false;
                kitaplist.Enabled = false;
                btnKaydet.Enabled = false;
               



                panel_sonuc.Visible = true;
                sonuc.Text = "Konu Ekleme Ýþlemi Baþarýyla Gerçekleþti";
                sonuc.ForeColor = System.Drawing.Color.Green;

            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Konu Ekleme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        //}

        //catch
        //{

        //    panel_sonuc.Visible = true;
        //    sonuc.Text = "Konu baþarýyla eklendi. Fakat resim yüklenemedi. Lütfen resmi aþaðýdaki düðmeyi kullanarak tekrar yüklemeye çalýþýnýz. Resim Yüklendiðinde otomatik olarak kategori sayfasýna yönlendirileceksiniz.";
        //    sonuc.ForeColor = System.Drawing.Color.Red;
        //    kitaplist.Enabled = false;
        //    konu.Enabled = false;
        //    kategorilist.Enabled = false;
        //    yayin.Enabled = false;
        //    btnKaydet.Visible = false;
        //    Button2.Visible = true;

        //}



    }
    protected void kitaplist_SelectedIndexChanged(object sender, EventArgs e)
    {
        kategori_yukle();
        kategorilist.Enabled = true;


    }
    void kategori_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitapkategorileri where kitap_id = '"+kitaplist.SelectedValue.ToString()+"' order by sira asc", ebebaba_connection);
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

    protected void ekle_command(object sender, CommandEventArgs e)
    {
        mesaj.Text = mesaj.Text + "</br>" + "<img src="+"'../imgyardim/"+e.CommandName .ToString()+"'>";

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


            Response.Redirect("0000050.aspx?kat_id=" + kategorilist.SelectedValue.ToString());

        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Resim Yüklenemedi. Lütfen tekrar deneyiniz !";
            sonuc.ForeColor = System.Drawing.Color.Red;
        
        }





    }
}
