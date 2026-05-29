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

        if (!IsPostBack)
        {
            konu_yukle();
        }
    }

 
    protected void bilgi_guncelle_Command(object sender, CommandEventArgs e)
    {

        Response.Redirect("0000081.aspx?ID=" + e.CommandArgument.ToString());

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {


        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update duyurular set sira = sira - 1 where sira > " + e.CommandName.ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd2.ExecuteNonQuery();
            ebebaba_connection.Close();

          
            
            MySqlCommand ebebaba_cmd = new MySqlCommand("delete from duyurular where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
           
                        
            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                konu_yukle();
                panel_sonuc.Visible = true;
                sonuc.Text = "Duyuru kaydý baþarýyla silinmiþtir !";
                sonuc.ForeColor = System.Drawing.Color.Green;
            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Duyuru Silinemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }
        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Duyuru Silinirken Sistem Bir Hata Ýle Karþýlaþtý.Ýþlem Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        
        
        }





    }

    void konu_yukle()
    {

        konu_listesi.Visible = true;
     

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from duyurular order by sira asc", ebebaba_connection);

            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            konu_listesi.DataSource = ebebaba_dt;
            konu_listesi.DataBind();
                     
        int k = 0 ;

ImageButton btnsil = new ImageButton();

ImageButton btnbut = new ImageButton();

ImageButton yukari = new ImageButton();
ImageButton asagi = new ImageButton();
LinkButton goruntule = new LinkButton();

            foreach (GridViewRow str in konu_listesi.Rows)
            {
                
                
                yukari = (ImageButton)str.FindControl("ust");
                yukari.CommandArgument = ebebaba_dt.Rows[k]["ID"].ToString();
                yukari.CommandName = ebebaba_dt.Rows[k]["sira"].ToString();

                asagi = (ImageButton)str.FindControl("alt");
                asagi.CommandArgument = ebebaba_dt.Rows[k]["ID"].ToString();
                asagi.CommandName = ebebaba_dt.Rows[k]["sira"].ToString();

                btnbut = (ImageButton)str.Cells[2].FindControl("form_guncelle");
      
                btnsil = (ImageButton)str.Cells[2].FindControl("sil");
                btnsil.CommandName = ebebaba_dt.Rows[k]["sira"].ToString();



                btnbut.CommandArgument = ebebaba_dt.Rows[k]["ID"].ToString();
                btnsil.CommandArgument = ebebaba_dt.Rows[k]["ID"].ToString();

                goruntule = (LinkButton)str.FindControl("goster");


                if (ebebaba_dt.Rows[k]["yayin"].ToString() == "1")
                {
                    goruntule.Text = "+";
                }
                else if (ebebaba_dt.Rows[k]["yayin"].ToString() == "0")
                {
                    goruntule.Text = "-";
                }


                goruntule.CommandArgument = ebebaba_dt.Rows[k]["ID"].ToString();
                goruntule.CommandName = ebebaba_dt.Rows[k]["yayin"].ToString();


                k ++;
            
            }
            

        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Duyurular Yüklenirken Hata Oluþtu !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    
    
    }


    protected void ust_Command(object sender, CommandEventArgs e)
    {

        if (e.CommandName.ToString() != "1")
        {


            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update duyurular set sira = sira + 1 where sira=" + degisecek_sira + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update duyurular set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


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
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from duyurular", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            if (e.CommandName.ToString() != ebebaba_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;


                MySqlCommand ebebaba_cmd2 = new MySqlCommand("update duyurular set sira = sira - 1 where sira=" + degisecek_sira + "", ebebaba_connection);


                ebebaba_connection.Open();
                int eks2 = ebebaba_cmd2.ExecuteNonQuery();
                ebebaba_connection.Close();




                MySqlCommand ebebaba_cmd = new MySqlCommand("update duyurular set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


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

            MySqlCommand ebebaba_cmd2 = new MySqlCommand("update duyurular set yayin='" + gstr.ToString() + "' where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


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
 
}
