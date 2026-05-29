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

    }
    protected void btn_kaydet_Click(object sender, ImageClickEventArgs e)
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand da = new MySqlCommand("select max(sira) from duyurular", ebebaba_connection);


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



            MySqlCommand ebebaba_cmd = new MySqlCommand("insert into duyurular(konu,metin,tarih,sira,yayin,link) values (?1,?2,?3,?4,?5,?6)", ebebaba_connection);

            ebebaba_cmd.Parameters.AddWithValue("?1", konu.Text);
            ebebaba_cmd.Parameters.AddWithValue("?2", anasayfametni.Text);
            ebebaba_cmd.Parameters.AddWithValue("?3", DateTime.Now.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?4", eklenecek_sira);
            ebebaba_cmd.Parameters.AddWithValue("?5", yyn);
            ebebaba_cmd.Parameters.AddWithValue("?6", link.Text.TrimEnd().TrimStart());

            ebebaba_connection.Open();
            int eks = ebebaba_cmd.ExecuteNonQuery();
            string LID = ebebaba_cmd.LastInsertedId.ToString();
            ebebaba_connection.Close();

            if (eks == 1)
            {

                Response.Redirect("0000080.aspx");
            }

            else
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Duyuru Ekleme Ýþlemi Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {

            panel_sonuc.Visible = true;
            sonuc.Text = "Duyuru eklenemedi.Lütfen tekrar deneyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }



    }

}
