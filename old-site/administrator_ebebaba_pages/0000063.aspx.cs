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

public partial class administrator_ebebaba_pages_0000023 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
   
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (Request.QueryString["kaynak"].ToString() != "giden_mesajlar" || Request.QueryString["mesaj_id"].ToString() != Session["mesaj_id8"].ToString())
            {


                Response.Redirect("0000061.aspx");

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

                     MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter("select * from sorutable_giden where ID="+Request.QueryString["mesaj_id"].ToString()+"", ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);


            Label3.Text = ebebaba_dt2.Rows[0]["gonderen"].ToString();
            Label7.Text = ebebaba_dt2.Rows[0]["eposta"].ToString();
  
            Label6.Text = ebebaba_dt2.Rows[0]["tarih"].ToString();
            Label4.Text = ebebaba_dt2.Rows[0]["soru"].ToString();
            Label5.Text = ebebaba_dt2.Rows[0]["cevap"].ToString();
          
                          }

        catch
        {

        }




    }








   
   


    protected void Button1_Click1(object sender, ImageClickEventArgs e)
    {
        string yonlendir = "";
        if (Request.QueryString["kaynak"] == "giden_mesajlar")
        {

            yonlendir = "0000061.aspx";

        }

        Response.Redirect(yonlendir);


    }
    protected void Button2_Click1(object sender, ImageClickEventArgs e)
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd3 = new MySqlCommand("delete from sorutable_giden where ID=" + Request.QueryString["mesaj_id"].ToString() + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (eks3 == 1)
            {


                string yonlendir = "";
                if (Request.QueryString["kaynak"] == "giden_mesajlar")
                {

                    yonlendir = "0000061.aspx";

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
}
