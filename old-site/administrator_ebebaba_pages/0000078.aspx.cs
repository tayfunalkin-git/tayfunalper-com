using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mainAdminPagesHdn_0000073 : System.Web.UI.Page
{
    ebebaba_connect_class noc = new ebebaba_connect_class();

   


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            tipleriYukle();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {


        MySqlConnection mp_connection = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from kategorilist where Adi='" + kategoriAdi.Text.ToUpper() + "'", mp_connection);
        DataTable dt = new DataTable();
        da2.Fill(dt);

        if (dt.Rows.Count > 0)
        {

            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Bu isimde daha önce kaydedilmiş kategori bulundu. Lütfen kontrol ediniz..', 'error');", true);

        }
        else
        {

            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from kategorilist", mp_connection);
            DataTable mp_dt = new DataTable();
            da.Fill(mp_dt);
            int sirano = 0; if (mp_dt.Rows[0][0].ToString() == "") { sirano = 1; } else { sirano = 0; if (mp_dt.Rows[0][0].ToString() == "") { sirano = 1; } else { sirano = int.Parse(mp_dt.Rows[0][0].ToString()) + 1; } }





            MySqlCommand mp_cmd = new MySqlCommand("insert into kategorilist(Adi,sira,goruntu,kisaAd) values ('" + kategoriAdi.Text.ToUpper() + "'," + sirano + ",'+',?1)", mp_connection);
            mp_cmd.Parameters.AddWithValue("?1",GenisletmeMetotlari.ToURL(noc.deveYazimi(kategoriAdi.Text)));

            mp_connection.Open();
            int eks = mp_cmd.ExecuteNonQuery();
            mp_connection.Close();



            kategoriAdi.Text = "";


            if (eks == 1)
            {
                tipleriYukle();

                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('BAŞARILI', 'Yeni Kategori Başarıyla Kaydedildi.', 'success');", true);
            }

            else
            {

                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Kategori Kayıt İşlemi Başarısız ! Lütfen Tekrar Deneyiniz.', 'error');", true);

            }


        }



    }

    private void tipleriYukle()
    {

        try
        {
            MySqlConnection mp_connection = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kategorilist order by sira asc", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            list.DataSource = mp_dt;
            list.DataBind();
            ImageButton kaydet = new ImageButton();
            ImageButton duzenle = new ImageButton();
            ImageButton sil = new ImageButton();
            ImageButton ust = new ImageButton();
            ImageButton alt = new ImageButton();
            Label lblTip = new Label();
            TextBox txtTip = new TextBox();
            Label lblID = new Label();



            RequiredFieldValidator RequiredFieldValidator4 = new RequiredFieldValidator();


            int i = 0;

            foreach (GridViewRow str in list.Rows)
            {

                lblTip = (Label)str.FindControl("lblTip");
                lblTip.Text = mp_dt.Rows[i]["Adi"].ToString();

                txtTip = (TextBox)str.FindControl("txtTip");
                txtTip.Text = mp_dt.Rows[i]["Adi"].ToString();

                lblID = (Label)str.FindControl("lblID");
                lblID.Text = mp_dt.Rows[i]["ID"].ToString();

                RequiredFieldValidator4 = (RequiredFieldValidator)str.FindControl("RequiredFieldValidator4");
                RequiredFieldValidator4.ValidationGroup = "guncel" + i.ToString();
                kaydet.ValidationGroup = "guncel" + i.ToString();




                duzenle = (ImageButton)str.FindControl("duzenle");
                sil = (ImageButton)str.FindControl("sil");
                kaydet = (ImageButton)str.FindControl("kaydet");
                kaydet.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                kaydet.CommandName = i.ToString();

                duzenle.CommandArgument = i.ToString();
                sil.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                sil.CommandName = mp_dt.Rows[i]["sira"].ToString();

                ust = (ImageButton)str.FindControl("ust");
                ust.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                ust.CommandName = mp_dt.Rows[i]["sira"].ToString();

                alt = (ImageButton)str.FindControl("alt");
                alt.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                alt.CommandName = mp_dt.Rows[i]["sira"].ToString();


                i++;

            }
        }


        catch
        {


        }


    }

    protected void ust_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName.ToString() != "1")
        {

            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection mp_connection = noc.connect_ebebaba(0301009184);
                MySqlCommand mp_cmd2 = new MySqlCommand("update kategorilist set sira = sira + 1 where sira=" + degisecek_sira + "", mp_connection);

                mp_connection.Open();
                int eks2 = mp_cmd2.ExecuteNonQuery();
                mp_connection.Close();


                MySqlCommand mp_cmd = new MySqlCommand("update kategorilist set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", mp_connection);
              

                mp_connection.Open();
                int eks = mp_cmd.ExecuteNonQuery();
                mp_connection.Close();

                tipleriYukle();



            }

            catch
            {


            }


        }
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == System.Web.UI.WebControls.DataControlRowType.DataRow)
        {
            // when mouse is over the row, save original color to new attribute, and change it to highlight color
            e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#f5f5f5'");

            // when mouse leaves the row, change the bg color to its original value   
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
        }
    }


    protected void ImageButton4_Command(object sender, CommandEventArgs e)
    {
        try
        {

            MySqlConnection mp_connection = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from kategorilist", mp_connection);
            DataTable mp_dt = new DataTable();
            da.Fill(mp_dt);

            if (e.CommandName.ToString() != mp_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;


                MySqlCommand mp_cmd2 = new MySqlCommand("update kategorilist set sira = sira - 1 where sira=" + degisecek_sira + "", mp_connection);


                mp_connection.Open();
                int eks2 = mp_cmd2.ExecuteNonQuery();
                mp_connection.Close();




                MySqlCommand mp_cmd = new MySqlCommand("update kategorilist set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", mp_connection);


                mp_connection.Open();
                int eks = mp_cmd.ExecuteNonQuery();
                mp_connection.Close();




                tipleriYukle();
            }

        }


        catch
        {


        }

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection mp_connection = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("select * from tedaviiceriktablosu where kategoriler like '%" + e.CommandArgument.ToString() + "%'", mp_connection);
        DataTable mp_dt = new DataTable();
        da.Fill(mp_dt);



            if (mp_dt.Rows.Count == 0)
            {
        MySqlCommand mp_cmd2 = new MySqlCommand("update kategorilist set sira = sira - 1 where sira > " + e.CommandName.ToString() + "", mp_connection);



        mp_connection.Open();
        int eks3 = mp_cmd2.ExecuteNonQuery();
        mp_connection.Close();




        MySqlCommand mp_cmd = new MySqlCommand("delete from kategorilist where ID=" + e.CommandArgument.ToString() + "", mp_connection);


        mp_connection.Open();
        int eks = mp_cmd.ExecuteNonQuery();
        mp_connection.Close();


        if (eks == 1)
        {
            tipleriYukle();

            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('BAŞARILI', 'Kategori silme işlemi başarıyla gerçekleştirildi.', 'success');", true);
        }

        else
        {

            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Kategori silme işlemi başarısız! Lütfen tekrar deneyiniz..', 'error');", true);

        }

            }

            else
            {
                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Bu kategoriye kayıtlı yazı bulunmaktadır. Silme işlemi başarısız !', 'error');", true);

            }

    }
    protected void kaydet_Command(object sender, CommandEventArgs e)
    {

        string yeniAd = ((TextBox)list.Rows[int.Parse(e.CommandName.ToString())].FindControl("txtTip")).Text.ToUpper();

        if (yeniAd != "")
        {


            MySqlConnection mp_connection = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select * from kategorilist where not ID=" + e.CommandArgument + " and Adi='" + yeniAd + "'", mp_connection);
            DataTable mp_dt = new DataTable();
            da.Fill(mp_dt);

            if (mp_dt.Rows.Count > 0)
            {

                ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Bu isimde kayıtlı başka bir kategori bulundu. Lütfen kontrol ediniz..', 'error');", true);

            }
            else
            {

                MySqlCommand mp_cmd2 = new MySqlCommand("update kategorilist set Adi=?1,kisaAd=?2 where ID=?3", mp_connection);
                mp_cmd2.Parameters.AddWithValue("?1", yeniAd);
                mp_cmd2.Parameters.AddWithValue("?2", GenisletmeMetotlari.ToURL(noc.deveYazimi(yeniAd)));
                mp_cmd2.Parameters.AddWithValue("?3", e.CommandArgument.ToString());
               


                mp_connection.Open();
                int eks2 = mp_cmd2.ExecuteNonQuery();
                mp_connection.Close();


                if (eks2 == 1)
                {
                    tipleriYukle();

                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('BAŞARILI', 'Kategori bilgisi başarıyla değiştirildi.', 'success');", true);
                }

                else
                {

                    ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Kategori bilgisi değiştirme işlemi başarısız.Lütfen tekrar deneyiniz.', 'error');", true);

                }

            }
        }
        else
        {
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Kategori Adı boş geçilemez !', 'error');", true);

        }
    }
    protected void duzenle_Command(object sender, CommandEventArgs e)
    {

        ((TextBox)list.Rows[int.Parse(e.CommandArgument.ToString())].FindControl("txtTip")).Visible = true;
        ((Label)list.Rows[int.Parse(e.CommandArgument.ToString())].FindControl("lblTip")).Visible = false;
        ((ImageButton)list.Rows[int.Parse(e.CommandArgument.ToString())].FindControl("kaydet")).Visible = true;
        ((ImageButton)list.Rows[int.Parse(e.CommandArgument.ToString())].FindControl("duzenle")).Visible = false;




    }
}