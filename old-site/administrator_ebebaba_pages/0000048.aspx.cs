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

public partial class administrator_ebebaba_pages_0000048 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            kitaplistesiyukle();


            if (Request.QueryString["kitap_id"] != null)
            {

                kitaplist.SelectedValue = Request.QueryString["kitap_id"].ToString();

                panel_sonuc.Visible = false;
                guncelle.Visible = false;
                
                alan_yukle();


            }


        }

    }




    void kitaplistesiyukle()
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
            sonuc.Text = "Kitap Kategorileri Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }




 






    void alan_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from kitapkategorileri where kitap_id='"+kitaplist.SelectedValue.ToString()+"' order by sira asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            list.DataSource = ebebaba_dt;
            list.DataBind();

            Label3.Text = kitaplist.SelectedItem.Text + " Kitabýnda Bulunan Kategori Sayýsý : " + ebebaba_dt.Rows.Count.ToString();


            ImageButton btn_guncelle = new ImageButton();
            ImageButton btn_sil = new ImageButton();

           ImageButton yukari = new  ImageButton();
           ImageButton  asagi = new ImageButton();
           LinkButton goruntule = new LinkButton();
           LinkButton kat = new LinkButton();
            int i = 0;

            foreach (GridViewRow str in list.Rows)
            {

                
                  kat = (LinkButton)str.FindControl("kat_adi");

                kat.Text = ebebaba_dt.Rows[i]["kategori_adi"].ToString();
                kat.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();



                yukari = (ImageButton)str.FindControl("ust");
                yukari.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                yukari.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                asagi = (ImageButton)str.FindControl("alt");
                asagi.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                asagi.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                btn_guncelle = (ImageButton)str.FindControl("ad_guncelle");
                btn_sil = (ImageButton)str.FindControl("sil");
              
                
                btn_guncelle.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                btn_sil.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                btn_sil.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                goruntule = (LinkButton)str.FindControl("goster");


                if (ebebaba_dt.Rows[i]["yayin"].ToString() == "1")
                {
                    goruntule.Text = "+";
                }
                else if (ebebaba_dt.Rows[i]["yayin"].ToString() == "0")
                {
                    goruntule.Text = "-";
                }

                goruntule.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                goruntule.CommandName = ebebaba_dt.Rows[i]["yayin"].ToString();

              


                i++;

            }
        }


        catch

        { 
        
        
        }
    }
    protected void ad_guncelle_Command(object sender, CommandEventArgs e)
    {
        try
        {

            guncelle.Visible = true;
            panel_sonuc.Visible = false;

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from kitapkategorileri where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            alanadi2.Text = ebebaba_dt.Rows[0]["kategori_adi"].ToString();
            Label2.Text = ebebaba_dt.Rows[0]["id"].ToString();

            if (ebebaba_dt.Rows[0]["yayin"].ToString() == "1")
            {
                yayin.Checked = true;
                
            }
            else if (ebebaba_dt.Rows[0]["yayin"].ToString() == "0")
            {
                yayin.Checked = false;

            }

        }


        catch
        { 
        
        }

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {
        guncelle.Visible = false;


        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from kitap_konulari where kategori_id='" + e.CommandArgument.ToString() + "'", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count > 0)
            {


                panel_sonuc.Visible = true;
                sonuc.Text = "Bu Kategoriye Ait Konular Olduðu Ýçin Kategori Silinemez !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }
            else
            {



                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitapkategorileri set sira = sira - 1 where sira > " + e.CommandName.ToString() + " and kitap_id='"+kitaplist.SelectedValue.ToString()+"'", ebebaba_connection);


                ebebaba_connection.Open();
                int eks3 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();





                MySqlCommand ebebaba_cmd = new MySqlCommand("delete from kitapkategorileri where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();


                if (eks == 1)
                {

                    panel_sonuc.Visible = true;
                    sonuc.Text = "Kategori Baþarýyla Silindi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;

                    alan_yukle();



                }

                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Kategori Silme Ýþlemi Baþarýsýz !";
                    sonuc.ForeColor = System.Drawing.Color.Red;

                }

            }
        }


        catch
        { 
          panel_sonuc.Visible = true;
            sonuc.Text = "Kategori Silme Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;
        
        }

    
    }


    protected void yeni_kaydet_Click(object sender, EventArgs e)
    {
        
        guncelle.Visible = false;

    }

    
    protected void ust_Command(object sender, CommandEventArgs e)
    {

        if (e.CommandName.ToString() != "1")
        {

            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitapkategorileri set sira = sira + 1 where sira=" + degisecek_sira + " and kitap_id='"+kitaplist.SelectedValue.ToString()+"'", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update kitapkategorileri set sira = " + degisecek_sira + "  where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();

                alan_yukle();

                panel_sonuc.Visible = false;

            }

            catch
            { 
            
            
            }


        }





    }
    protected void alt_Command(object sender, CommandEventArgs e)
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from kitapkategorileri where kitap_id='"+kitaplist.SelectedValue.ToString()+"'", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            if (e.CommandName.ToString() != ebebaba_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;


                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitapkategorileri set sira = sira - 1 where sira=" + degisecek_sira + " and kitap_id='"+kitaplist.SelectedValue.ToString()+"'", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update kitapkategorileri set sira = " + degisecek_sira + "  where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();

                panel_sonuc.Visible = false;


                alan_yukle();
            }

        }


        catch
        { 
        
        
        }


        }

    protected void Button1_Click(object sender, ImageClickEventArgs e)
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand da = new MySqlCommand("select max(sira) from kitapkategorileri where kitap_id='"+kitaplist.SelectedValue.ToString()+"'", ebebaba_connection);

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




            MySqlCommand ebebaba_cmd = new MySqlCommand("insert into kitapkategorileri(kitap_id,kategori_adi,yayin,tarih,sira) values ('"+kitaplist.SelectedValue.ToString()+"','" + alanadi1.Text.TrimEnd().TrimStart().ToString() + "','0','" + DateTime.Now.ToString() + "'," + eklenecek_sira + ")", ebebaba_connection);



            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Kategori Ekleme Ýþlemi Baþarýyla Gerçekleþti";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                alanadi1.Text = "";

                guncelle.Visible = false;


            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Kategori Ekleme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Kategori Ekleme Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }
    }
    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {






       try
        {


            string gstrm = "0";

            if (yayin.Checked)
            {
                gstrm = "1";
            }
            else if (yayin.Checked == false)
            {
                gstrm = "0";

            }





            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("update kitapkategorileri set kategori_adi = '" + alanadi2.Text.TrimEnd().TrimStart().ToString() + "',yayin='"+gstrm+"' where id="+Label2.Text+"", ebebaba_connection);


            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Kategori Adý Baþarýyla Güncelleþtirildi";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                alanadi2.Text = "";
                guncelle.Visible = false;
                
            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Kategori Adý Güncelleþtirilmesi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

           
       }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Kategori Adý Güncelleþtirilmesi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

   


    }
    protected void kitaplist_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (kitaplist.SelectedValue == "")
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Kitap Seçilmedi !";
            sonuc.ForeColor = System.Drawing.Color.Red;
            Label3.Visible = false;
            list.Visible = false;

            guncelle.Visible = false;


        }
        else
        {

            panel_sonuc.Visible = false;
            guncelle.Visible = false;
            Label3.Visible = true;
            list.Visible = true;


            alan_yukle();
        }
    }
    protected void goster_Command(object sender, CommandEventArgs e)
    {


        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            string gstr = "0";

            if (e.CommandName.ToString() == "1")
            {
                gstr = "0";
            }
            else
            {
                gstr = "1";
            }

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitapkategorileri set yayin='" + gstr.ToString() + "' where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks2 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks2 == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Görüntüleme Ýþlemi Baþarýyla Deðiþtirildi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();


            }

            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Görüntüleme Ýþlemi Deðiþtirilemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;


            }



        }


        catch
        {


        }



    }
    protected void kat_adi_Command(object sender, CommandEventArgs e)
    {

        Response.Redirect("0000050.aspx?kat_id=" + e.CommandArgument.ToString());


    }
}
