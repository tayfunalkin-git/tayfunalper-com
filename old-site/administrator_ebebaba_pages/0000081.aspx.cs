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

           
        if (Request.QueryString["ID"] != null)
        {

            try
            {

                MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
                MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from duyurular where ID=" + Request.QueryString["ID"].ToString() + "", ebebaba_connection);
                DataTable ebebaba_dt = new DataTable();
                ebebaba_da.Fill(ebebaba_dt);



                if (ebebaba_dt.Rows.Count == 1)
                {

                    y_konu.Text = ebebaba_dt.Rows[0]["konu"].ToString();
                    anasayfametni.Text = ebebaba_dt.Rows[0]["metin"].ToString();
                    link.Text = ebebaba_dt.Rows[0]["link"].ToString();

                    if (ebebaba_dt.Rows[0]["yayin"].ToString() == "1")
                    {

                        yayin.Checked = true;


                    }
                    else
                    {

                        yayin.Checked = false;

                    }
                }

                else
                {

                    Response.Redirect("0000079.aspx");


                }


            }

            catch
            {
                Response.Redirect("0000079.aspx");

            }

        }



         

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
          

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

            MySqlCommand ebebaba_cmd = new MySqlCommand("update duyurular set konu=?1,metin=?2,yayin=?3,link=?4 where ID=" + Request.QueryString["ID"].ToString() + "", ebebaba_connection);

           ebebaba_cmd.Parameters.AddWithValue("?1", y_konu.Text);
           ebebaba_cmd.Parameters.AddWithValue("?2", anasayfametni.Text.ToString());
           ebebaba_cmd.Parameters.AddWithValue("?3", yyn);
           ebebaba_cmd.Parameters.AddWithValue("?4", link.Text);

           ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            ebebaba_connection.Close();


            if (eks == 1)
            {

                Response.Redirect("0000080.aspx");


            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Duyuru Güncelleme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Duyuru Güncelleme Ýþlemi Baþarýsýz !";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }





    }
 




    protected void Button1_Click1(object sender, ImageClickEventArgs e)
    {

       
                Response.Redirect("0000080.aspx");
                
          

}



  
}

