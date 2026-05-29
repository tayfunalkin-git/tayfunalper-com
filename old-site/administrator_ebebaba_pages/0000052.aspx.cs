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

public partial class administrator_ebebaba_pages_0000047 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {
        alan_yukle();
        Page.MaintainScrollPositionOnPostBack = false;

    }

    void alan_yukle()
    {

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from video_islemleri order by sira asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            list.DataSource = ebebaba_dt;
            list.DataBind();


            ImageButton btn_guncelle = new ImageButton();
            ImageButton btn_sil = new ImageButton();
            ImageButton yukari = new ImageButton();
            ImageButton asagi = new ImageButton();
            LinkButton goruntule = new LinkButton();
            Image resim = new Image();
            LinkButton ad = new LinkButton();
            int i = 0;

            foreach (GridViewRow str in list.Rows)
            {


                ad = (LinkButton)str.FindControl("adi");
                ad.Text = ebebaba_dt.Rows[i]["kitap_adi"].ToString();
                ad.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                btn_guncelle = (ImageButton)str.FindControl("ad_guncelle");
                btn_sil = (ImageButton)str.FindControl("sil");
                btn_guncelle.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                btn_sil.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();

                btn_sil.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                yukari = (ImageButton)str.FindControl("ust");
                yukari.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                yukari.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

                asagi = (ImageButton)str.FindControl("alt");
                asagi.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                asagi.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();


                goruntule = (LinkButton)str.FindControl("goster");
             

                if (ebebaba_dt.Rows[i]["goster"].ToString() == "1")
                {
                    goruntule.Text = "+";
                }
                else if (ebebaba_dt.Rows[i]["goster"].ToString() == "0")
                {
                    goruntule.Text = "-";
                }


                goruntule.CommandArgument = ebebaba_dt.Rows[i]["id"].ToString();
                goruntule.CommandName = ebebaba_dt.Rows[i]["goster"].ToString();
                resim = (Image)str.FindControl("kitap_res");
                resim.ImageUrl = "~/imgvideo/" + ebebaba_dt.Rows[i]["resim"].ToString();
                if (ebebaba_dt.Rows[i]["resim"].ToString() == "")
                {

                    resim.Visible = false;

                
                }


                if (ebebaba_dt.Rows[i]["id"].ToString() == "299")
                {
                    btn_sil.Enabled = false;

                }


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
            Panel1.Visible = false;

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from video_islemleri where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            alanadi2.Text = ebebaba_dt.Rows[0]["kitap_adi"].ToString();
            Label2.Text = ebebaba_dt.Rows[0]["id"].ToString();
            alanadi4.Text = ebebaba_dt.Rows[0]["url"].ToString();

            alanadi5.Text = ebebaba_dt.Rows[0]["acilis"].ToString();
            if (ebebaba_dt.Rows[0]["goster"].ToString() == "1")
            {
                yayin2.Checked = true;

            }
            else
            {
                yayin2.Checked = false;

            }

            resim2.ImageUrl = "~/imgvideo/" + ebebaba_dt.Rows[0]["resim"].ToString();

          


        }

        catch
        { 
        
        }

    }

    void yeniden_yukle()
    {


        try
        {
            guncelle.Visible = true;
            panel_sonuc.Visible = false;

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from video_islemleri where id=" + Label2.Text.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            alanadi2.Text = ebebaba_dt.Rows[0]["kitap_adi"].ToString();
            Label2.Text = ebebaba_dt.Rows[0]["id"].ToString();

            if (ebebaba_dt.Rows[0]["goster"].ToString() == "1")
            {
                yayin2.Checked = true;

            }
            else
            {
                yayin2.Checked = false;

            }

            resim2.ImageUrl = "~/imgvideo/" + ebebaba_dt.Rows[0]["resim"].ToString();




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

    
            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update video_islemleri set sira = sira - 1 where sira > " + e.CommandName.ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();



            MySqlCommand ebebaba_cmd = new MySqlCommand("delete from video_islemleri where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Video Kaydý Baþarýyla Silindi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();



            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Video Kaydý Silme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        }

         catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Kitap Silme Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

      

    }
    protected void yeni_kaydet_Click(object sender, EventArgs e)
    {
        
        guncelle.Visible = false;

    }

    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {

        try
        {

            string gstr = "0";
            if (yayin2.Checked)
            {

                gstr = "1";
            }
            else
            {
                gstr = "0";

            }


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("update video_islemleri set kitap_adi = '" + alanadi2.Text.TrimEnd().TrimStart().ToString() + "',goster='"+gstr+"',url='"+alanadi4.Text+"',acilis='"+alanadi5.Text+"' where id="+Label2.Text+"", ebebaba_connection);


            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Video Bilgileri Baþarýyla Güncelleþtirildi";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                alanadi2.Text = "";
                alanadi4.Text = "";
                alanadi5.Text = "";
                guncelle.Visible = false;
                
            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Video Bilgileri Güncelleþtirilmesi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Video Bilgileri Güncelleþtirilmesi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }





    protected void ust_Command(object sender, CommandEventArgs e)
    {

        guncelle.Visible = false;

        if (e.CommandName.ToString() != "1")
        {


            
            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update video_islemleri set sira = sira + 1 where sira=" + degisecek_sira + "", ebebaba_connection);

                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();


                MySqlCommand ebebaba_cmd = new MySqlCommand("update video_islemleri set sira = " + degisecek_sira + "  where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();

                alan_yukle();



            }

            catch
            {


            }


        }

    }
    protected void alt_Command(object sender, CommandEventArgs e)
    {
 guncelle.Visible = false;
        try
        {

           

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from video_islemleri", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            if (e.CommandName.ToString() != ebebaba_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;
                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update video_islemleri set sira = sira - 1 where sira=" + degisecek_sira + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update video_islemleri set sira = " + degisecek_sira + "  where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();




                alan_yukle();
            }

        }


        catch
        {


        }


    }


    protected void goster_Command(object sender, CommandEventArgs e)
    {


        guncelle.Visible = false;


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

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update video_islemleri set goster='" + gstr.ToString() + "' where id=" + e.CommandArgument.ToString() + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();

            if(eks2==1)
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
      protected void Button1_Click(object sender, ImageClickEventArgs e)
    {


        string uzanti = System.IO.Path.GetExtension(kitap_res.FileName).ToLower();
        if (uzanti == ".jpg" || uzanti == ".gif" || uzanti == ".jpeg")
        {

            if (!kitap_res.HasFile)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Resmin yolunun doðru olduðundan emin olunuz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }
            else
            {

                resim_yukle();
            
            
            }

        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "jpeg yada gif uzantýlý bir resim yükleyiniz !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }


    }



    void resim_yukle()
    {
        try
        {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("select * from video_islemleri where resim='" + kitap_res.FileName + "'", ebebaba_connection);
            ebebaba_connection.Open();
            object sonuc4 = cmd.ExecuteScalar();
            ebebaba_connection.Close();

            if (sonuc4 != null)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Bu isimde daha önce bir resim kaydý yapýlmýþ.Lütfen resim adýný deðiþtirip tekrar deneyiniz.";
                sonuc.ForeColor = System.Drawing.Color.Red;


            }

            else
            {

                kitap_res.PostedFile.SaveAs(Server.MapPath("~/imgvideo/" + kitap_res.FileName));


                kaydet();

            }
        }

        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Resim Yüklenme Esnasýnda bir hata oluþtu.Lütfen daha sonra tekrar deneyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }




    void kaydet()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from video_islemleri", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            int sirano = 0; if (ebebaba_dt.Rows[0][0].ToString() == "") { sirano = 1; } else { sirano = int.Parse(ebebaba_dt.Rows[0][0].ToString()) + 1; }

            string yyn = "0";
            if (yayin.Checked)
            {
                yyn = "1";
            }
            else
            {
                yyn = "0";

            }

            MySqlCommand ebebaba_cmd = new MySqlCommand("insert into video_islemleri(kitap_adi,sira,resim,goster,url,acilis) values ('" + alanadi1.Text.TrimEnd().TrimStart().ToString() + "'," + sirano + ",'" + kitap_res.FileName.ToString() + "','" + yyn.ToString() + "','"+alanadi3.Text+"','"+alanadi6.Text+"')", ebebaba_connection);

            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Video Kaydý Baþarýyla Gerçekleþti";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                yayin.Checked = false;

                alanadi1.Text = "";
                alanadi3.Text = "";
                alanadi6.Text = "";
                guncelle.Visible = false;


            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Video Kayýt Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Video Kayýt Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }


    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
     
        string uzanti = System.IO.Path.GetExtension(kitap_res2.FileName).ToLower();
        if (uzanti == ".jpg" || uzanti == ".gif" || uzanti == ".jpeg")
        {

            if (!kitap_res2.HasFile)
            {
                Panel1.Visible = true;
                Label3.Text = "Resmin yolunun doðru olduðundan emin olunuz !";
                Label3.ForeColor = System.Drawing.Color.Red;

            }
            else
            {

                resim_yukle22();


            }

        }
        else
        {
            Panel1.Visible = true;
            Label3.Text = "jpeg yada gif uzantýlý bir resim yükleyiniz !";
            Label3.ForeColor = System.Drawing.Color.Red;


        }




    }



    void resim_yukle22()
    {
        try
        {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("select * from video_islemleri where resim='" + kitap_res2.FileName + "'", ebebaba_connection);
            ebebaba_connection.Open();
            object sonuc4 = cmd.ExecuteScalar();
            ebebaba_connection.Close();

            if (sonuc4 != null)
            {

                Panel1.Visible = true;
                Label3.Text = "Bu isimde daha önce bir resim kaydý yapýlmýþ.Lütfen resim adýný deðiþtirip tekrar deneyiniz.";
                Label3.ForeColor = System.Drawing.Color.Red;


            }

            else
            {

                kitap_res2.PostedFile.SaveAs(Server.MapPath("~/imgvideo/" + kitap_res2.FileName));


                kaydet22();

            }
        }

        catch
        {
            Panel1.Visible = true;
            Label3.Text = "Resim Yüklenme Esnasýnda bir hata oluþtu.Lütfen daha sonra tekrar deneyiniz.";
            Label3.ForeColor = System.Drawing.Color.Red;

        }
    }




    void kaydet22()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlCommand ebebaba_cmd = new MySqlCommand("update video_islemleri set resim='" + kitap_res2.FileName + "' where id=" + Label2.Text + "", ebebaba_connection);

            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                Panel1.Visible = true;
                Label3.Text = "Resim Baþarýyla Güncelleþtirildi.";
                Label3.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                yeniden_yukle();

            }

            else
            {
                Panel1.Visible = true;
                Label3.Text = "Resim Güncelleþtirilemedi !";
                Label3.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
            Panel1.Visible = true;
            Label3.Text = "Resim Güncelleþtirilemedi !";
            Label3.ForeColor = System.Drawing.Color.Red;

        }
    }


    protected void adi_Command(object sender, CommandEventArgs e)
    {

        Response.Redirect("0000048.aspx?kitap_id="+e.CommandArgument.ToString());


    }

}
