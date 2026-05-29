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
using System.IO;
public partial class administrator_ebebaba_pages_0000036 : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            resimdoldur();

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
                Label2.Text = "Toplam 0 resim bulundu !";

            }
            else
            {
                Label2.Text = "Toplam " + dt.Rows.Count.ToString() + " resim bulundu !";

            }

        }
        catch
        {

        }
    }

  
    void resim_yukle()
    {
        try
        {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("select * from resimler where resim_adi='" + resim_upl.FileName + "'", ebebaba_connection);
            ebebaba_connection.Open();
            object sonuc3 = cmd.ExecuteScalar();
            ebebaba_connection.Close();

            if (sonuc3 != null)
            {
                panel_sonuc.Visible = true;
                sonuc2.Text = "Bu isimde daha önce bir resim kaydý yapýlmýþ.Lütfen resim adýný deðiþtirip tekrar deneyiniz.";
                sonuc2.ForeColor = System.Drawing.Color.Red;
           
            }

            else
            {
                resim_yukle2();

            }
        }

        catch
        {

        }
    }



    void resim_yukle2()
    {

        try
        {




            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("insert into resimler(resim_adi,tarih) values ('" + resim_upl.FileName + "' , '" + DateTime.Now + "')", ebebaba_connection);

            ebebaba_connection.Open();
            int sonuc3 = cmd.ExecuteNonQuery();
            ebebaba_connection.Close();
            if (sonuc3 == 1)
            {
                resim_upl.PostedFile.SaveAs(Server.MapPath("~/imgyardim/" + resim_upl.FileName));
                             
                panel_sonuc.Visible = true;
                sonuc2.Text = "Resim baþarýyla yüklendi.";
                sonuc2.ForeColor = System.Drawing.Color.Green;

                resimdoldur();

            }
            else
            {
                panel_sonuc.Visible = true;
                sonuc2.Text = "Resim Yüklenme Esnasýnda bir hata oluþtu.Lütfen daha sonra tekrar deneyiniz.";
                sonuc2.ForeColor = System.Drawing.Color.Red;
            }

        }

        catch
        {
        }

    }

    void silme(string resim_ID)
    {
        try
        {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

             MySqlDataAdapter da = new MySqlDataAdapter("Select * from resimler where resim_id="+resim_ID+"", ebebaba_connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MySqlCommand cmd = new MySqlCommand("delete from resimler where resim_id=" + resim_ID + "", ebebaba_connection);
            ebebaba_connection.Open();
            int sonuc3 = cmd.ExecuteNonQuery();
            ebebaba_connection.Close();

            if (sonuc3 == 1)
            {

                FileInfo yeni = new FileInfo(Server.MapPath("~/imgyardim/"+dt.Rows[0]["resim_adi"].ToString()));
                yeni.Delete();
                
                panel_sonuc.Visible = true;
                sonuc2.Text = "Resim baþarýyla silindi.";
                sonuc2.ForeColor = System.Drawing.Color.Green;
                resimdoldur();

            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc2.Text = "Silme Esnasýnda bir hata oluþtu.Lütfen daha sonra tekrar deneyiniz.";
                sonuc2.ForeColor = System.Drawing.Color.Red;
            }

        }

        catch
        {

        }

    }


    protected void sil_Command(object sender, CommandEventArgs e)
    {
        silme(e.CommandArgument.ToString());
    }
    protected void Button3_Click(object sender, ImageClickEventArgs e)
    {
        string uzanti = System.IO.Path.GetExtension(resim_upl.FileName).ToLower();
        if (uzanti == ".jpg" || uzanti == ".gif" || uzanti == ".jpeg")
        {

            if (!resim_upl.HasFile)
            {
                panel_sonuc.Visible = true;
                sonuc2.Text = "Resmin yolunun doðru olduðundan emin olunuz !";
                sonuc2.ForeColor = System.Drawing.Color.Red;

            }
            else
            {

                resim_yukle();

            }

        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc2.Text = "jpeg yada gif uzantýlý bir resim yükleyiniz !";
            sonuc2.ForeColor = System.Drawing.Color.Red;
        }
    }
}
