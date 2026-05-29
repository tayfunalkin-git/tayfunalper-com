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

public partial class administrator_ebebaba_pages_0000026 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {

        alan_yukle();

    }

    void alan_yukle()
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from ip_kisitlama order by id desc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            list.DataSource = ebebaba_dt;
            list.DataBind();


            ImageButton btn_guncelle = new ImageButton();
            ImageButton btn_sil = new ImageButton();
          
            int i = 0;

            foreach (GridViewRow str in list.Rows)
            {



                btn_guncelle = (ImageButton)str.FindControl("ad_guncelle");
                btn_sil = (ImageButton)str.FindControl("sil");
                btn_guncelle.CommandArgument = ebebaba_dt.Rows[i]["ID"].ToString();
                btn_sil.CommandArgument = ebebaba_dt.Rows[i]["ID"].ToString();

                btn_sil.CommandName = ebebaba_dt.Rows[i]["sira"].ToString();

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
            panel_sonuc.Visible = false;


            guncelle.Visible = true;

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from ip_kisitlama where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);

            alanadi2.Text = ebebaba_dt.Rows[0]["IP"].ToString();
            tanim2.Text = ebebaba_dt.Rows[0]["tanim"].ToString();
            Label2.Text = ebebaba_dt.Rows[0]["ID"].ToString();
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
            MySqlCommand ebebaba_cmd = new MySqlCommand("delete from ip_kisitlama where ID=" + e.CommandArgument.ToString() + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "IP Adresi Baþarýyla Silindi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();



            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "IP Adresi Silme iþlemi baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }
        }


        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "IP Adresi Silme Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
    protected void yeni_kaydet_Click(object sender, EventArgs e)
    {

        guncelle.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {


        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from ip_kisitlama where IP = '" + alanadi1.Text + "'", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            da.Fill(ebebaba_dt);


            if (ebebaba_dt.Rows.Count == 0)
            {
                MySqlCommand ebebaba_cmd = new MySqlCommand("insert into ip_kisitlama(IP,tanim) values ('" + alanadi1.Text.TrimEnd().TrimStart().ToString() + "','"+tanim.Text+"')", ebebaba_connection);


                ebebaba_connection.Open();
                int eks = ebebaba_cmd.ExecuteNonQuery();
                ebebaba_connection.Close();


                if (eks == 1)
                {

                    panel_sonuc.Visible = true;
                    sonuc.Text = "IP Adresi Baþarýyla Kaydedildi.";
                    sonuc.ForeColor = System.Drawing.Color.Green;

                    alan_yukle();
                    alanadi1.Text = "";
                    tanim.Text = "";
                    guncelle.Visible = false;


                }

                else
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "IP Adresi Kaydedilemedi!";
                    sonuc.ForeColor = System.Drawing.Color.Red;

                }

            }
            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Girilen IP Adresi zaten kayýtlý !";
                sonuc.ForeColor = System.Drawing.Color.Red;


            }
        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "IP Adresi Kaydý Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }


    }

    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("update ip_kisitlama set IP = '" + alanadi2.Text.TrimEnd().TrimStart().ToString() + "',tanim='"+ tanim2.Text +"' where ID=" + Label2.Text + "", ebebaba_connection);


            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "IP Adresi Baþarýyla Güncelleþtirildi";
                sonuc.ForeColor = System.Drawing.Color.Green;

                alan_yukle();
                alanadi2.Text = "";
                tanim2.Text = "";
                guncelle.Visible = false;

            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "IP Adresi Güncelleþtirilmesi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }


        }
        catch
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "IP Adresi Güncelleþtirilmesi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
    }
}
