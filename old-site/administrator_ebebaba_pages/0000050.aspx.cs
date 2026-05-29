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

public partial class administrator_ebebaba_pages_0000050 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {
 try
                              {

        if (!IsPostBack)
        {
            kitap_yukle();
       
        if (Request.QueryString["kat_id"] != null)
                          {

                             

                                  MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                                  MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitapkategorileri where id=" + Request.QueryString["kat_id"].ToString() + "", ebebaba_connection);
                                  DataTable ebebaba_dt = new DataTable();
                                  ebebaba_da.Fill(ebebaba_dt);



                                  if (ebebaba_dt.Rows.Count == 1)
                                  {


 
                                      kitap_yukle();
                                      kitaplist.SelectedValue = ebebaba_dt.Rows[0]["kitap_id"].ToString();
                                       
                                      kategori_yukle();
                                      kategorilist.Enabled = true;
                                      kategorilist.SelectedValue = Request.QueryString["kat_id"].ToString();

    
                                      panel_sonuc.Visible = false;
                                      konu_listesi.Visible = false;
                                      Label3.Visible = false;

                                      konu_yukle();

                                    

                                  }

                                  else
                                  {


                                      panel_sonuc.Visible = true;
                                      sonuc.Text = "Kitap Kategorisi Bulunamadý !";
                                      sonuc.ForeColor = System.Drawing.Color.Red;

                                  }


                             

                          }

                    }  
 
 }

                              catch
                              {
                                  panel_sonuc.Visible = true;
                                  sonuc.Text = "Kitap Kategorisi Bulunamadý !";
                                  sonuc.ForeColor = System.Drawing.Color.Red;

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
            sonuc.Text = "Kitap Kategorileri Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }


    void kategori_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitapkategorileri where kitap_id='"+kitaplist.SelectedValue.ToString()+"'", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            kategorilist.DataSource = ebebaba_dt;
            kategorilist.DataTextField = ebebaba_dt.Columns["kategori_adi"].ToString();
            kategorilist.DataValueField = ebebaba_dt.Columns["id"].ToString();

            kategorilist.DataBind();
    
            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";
            kategorilist.Items.Insert(0, yeni);




                  }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Kitap Kategorileri Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }






    protected void bilgi_guncelle_Command(object sender, CommandEventArgs e)
    {

        Response.Redirect("0000051.aspx?konu_id=" + e.CommandArgument.ToString());

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {


        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitap_konulari set sira = sira - 1 where sira > " + e.CommandName.ToString() + " and kategori_id='"+kategorilist.SelectedValue.ToString()+"'", ebebaba_connection);


            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

          
            
            MySqlCommand ebebaba_cmd = new MySqlCommand("delete from kitap_konulari where konu_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);
           
                        
            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                konu_yukle();
                panel_sonuc.Visible = true;
                sonuc.Text = "Kitap Konusu Baþarýyla Silinmiþtir !";
                sonuc.ForeColor = System.Drawing.Color.Green;
            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Kitap Konusu Silinemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Kitap Konusu Silinirken Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        
        
        }





    }

    void konu_yukle()
    {

        konu_listesi.Visible = true;
        Label3.Visible = true;

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from kitap_konulari where kategori_id='"+kategorilist.SelectedValue.ToString()+"' order by sira asc", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            konu_listesi.DataSource = ebebaba_dt;
            konu_listesi.DataBind();
                     
            Label3.Text = "Seçilen Kitap ve Kategoriye Kayýtlý Konu Sayýsý : " + ebebaba_dt.Rows.Count.ToString();
        

int k = 0 ;

ImageButton btnsil = new ImageButton();

ImageButton btnbut = new ImageButton();

ImageButton yukari = new ImageButton();
ImageButton asagi = new ImageButton();
LinkButton goruntule = new LinkButton();
LinkButton acls = new LinkButton();
Image resim = new Image();
            foreach (GridViewRow str in konu_listesi.Rows)
            {
                
                
                yukari = (ImageButton)str.FindControl("ust");
                yukari.CommandArgument = ebebaba_dt.Rows[k]["konu_id"].ToString();
                yukari.CommandName = ebebaba_dt.Rows[k]["sira"].ToString();

                asagi = (ImageButton)str.FindControl("alt");
                asagi.CommandArgument = ebebaba_dt.Rows[k]["konu_id"].ToString();
                asagi.CommandName = ebebaba_dt.Rows[k]["sira"].ToString();

                btnbut = (ImageButton)str.Cells[2].FindControl("form_guncelle");
      
                btnsil = (ImageButton)str.Cells[2].FindControl("sil");
                btnsil.CommandName = ebebaba_dt.Rows[k]["sira"].ToString();


                resim = (Image)str.FindControl("resim");
                resim.ImageUrl = "~/resimler/" + ebebaba_dt.Rows[k]["konu_id"].ToString() + "_thumb.jpg";

               btnbut.CommandArgument = ebebaba_dt.Rows[k]["konu_id"].ToString();
                btnsil.CommandArgument = ebebaba_dt.Rows[k]["konu_id"].ToString();

                goruntule = (LinkButton)str.FindControl("goster");


                if (ebebaba_dt.Rows[k]["yayin"].ToString() == "1")
                {
                    goruntule.Text = "+";
                }
                else if (ebebaba_dt.Rows[k]["yayin"].ToString() == "0")
                {
                    goruntule.Text = "-";
                }


                goruntule.CommandArgument = ebebaba_dt.Rows[k]["konu_id"].ToString();
                goruntule.CommandName = ebebaba_dt.Rows[k]["yayin"].ToString();


                acls = (LinkButton)str.FindControl("acilis");
                
                acls.CommandArgument = ebebaba_dt.Rows[k]["konu_id"].ToString();
                acls.CommandName = ebebaba_dt.Rows[k]["ilksayfa"].ToString();

                acls.Text = ebebaba_dt.Rows[k]["ilksayfa"].ToString();

                k ++;
            
            }
            

        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Kitap Konularý Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    
    
    }


    protected void Button1_Click(object sender, EventArgs e)
    {


       


        konu_yukle();



        //if (yardim_kategori.SelectedIndex == 0)
        //{
        //    panel_sonuc.Visible = false;

        
        //}
    

      

    }


    protected void ust_Command(object sender, CommandEventArgs e)
    {

        if (e.CommandName.ToString() != "1")
        {


            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitap_konulari set sira = sira + 1 where sira=" + degisecek_sira + " and kategori_id='"+kategorilist.SelectedValue.ToString()+"'", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update kitap_konulari set sira = " + degisecek_sira + "  where konu_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();




               konu_yukle();



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
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from kitap_konulari where kategori_id = '"+kategorilist.SelectedValue.ToString()+"'", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            if (e.CommandName.ToString() != ebebaba_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;


                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitap_konulari set sira = sira - 1 where sira=" + degisecek_sira + " and kategori_id='" + kategorilist.SelectedValue.ToString() + "'", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update kitap_konulari set sira = " + degisecek_sira + "  where konu_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();




                konu_yukle();
            }

        }


        catch
        {


        }


    }



    protected void kategorilist_SelectedIndexChanged(object sender, EventArgs e)
    {

        panel_sonuc.Visible = false;


        konu_yukle();



    }
    protected void kitaplist_SelectedIndexChanged(object sender, EventArgs e)
    {
        kategori_yukle();
        kategorilist.Enabled = true;
        panel_sonuc.Visible = false;
        konu_listesi.Visible = false;
        Label3.Visible = false;


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

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitap_konulari set yayin='" + gstr.ToString() + "' where konu_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks2 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks2 == 1)
            {
 konu_yukle();
                panel_sonuc.Visible = true;
                sonuc.Text = "Görüntüleme Ýþlemi Baþarýyla Deðiþtirildi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

            
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
    protected void acilis_Command(object sender, CommandEventArgs e)
    {

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update kitap_konulari set ilksayfa='-' where kategori_id='" + kategorilist.SelectedValue.ToString() + "'", ebebaba_connection);


            ebebaba_connection.Open();
            int eks2 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks2 > 0)
            {
                MySqlCommand ebebaba_cmd = new MySqlCommand("update kitap_konulari set ilksayfa='+' where konu_id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();

                if (eks == 1)
                {
                    MySqlCommand ebebaba_cmd22 = new MySqlCommand("update kitaplar set acilis='" + e.CommandArgument.ToString() + "' where id="+kitaplist.SelectedValue.ToString()+"", ebebaba_connection);

                    ebebaba_connection.Open();
                    int eks22 = ebebaba_cmd22.ExecuteNonQuery();
                    ebebaba_connection.Close();

                    if (eks22 == 1)
                    {
     konu_yukle();
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Anasayfada Görüntüleme Ýþlemi Baþarýyla Deðiþtirildi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        panel_sonuc.Visible = true;
                        sonuc.Text = "Anasayfada Görüntüleme Ýþlemi Deðiþtirilemedi !";
                        sonuc.ForeColor = System.Drawing.Color.Red;

                    }
               

                }

                else
                {

                    panel_sonuc.Visible = true;
                    sonuc.Text = "Anasayfada Görüntüleme Ýþlemi Deðiþtirilemedi !";
                    sonuc.ForeColor = System.Drawing.Color.Red;


                }


            }

            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Anasayfada Görüntüleme Ýþlemi Deðiþtirilemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;


            }



        }


        catch
        {


        }






    }
}
