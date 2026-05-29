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
            turYukle();

            if (Request.QueryString["ID"] != null)
            {
                turList.SelectedValue = Request.QueryString["ID"].ToString();
                Label1.Text = Request.QueryString["ID"].ToString();
                listeYukle();
               

            }

            if (Request.QueryString["S"] != null)
            {
                renklendir(Request.QueryString["S"].ToString());
            }

            if (Request.QueryString["islem"] != null)
            {
                mesajver(Request.QueryString["islem"].ToString());
            }
        }
    }

    private void mesajver(string p)
    {
        if (p == "G")
        {
            sonuc.Text = "Yazı başarıyla güncellendi.";
            sonuc.ForeColor = System.Drawing.Color.Green;
        }
        else if (p == "Y")
        {
            ScrollToControl("enalt");
            sonuc.Text = "Yazı başarıyla eklendi.";
            sonuc.ForeColor = System.Drawing.Color.Green;
        }
    }

    private void renklendir(string p)
    {

        foreach (GridViewRow satir in list.Rows)
        {

            if (((Label)satir.FindControl("lblID")).Text == p)
            {

                satir.BackColor = System.Drawing.Color.LightYellow;

            
            }

        
        }


    }


    private void ScrollToControl(string controlId)
    {
        //scroll to button
        string script =
            "$(document).ready(function() {" +
                "$('html,body').animate({ " +
                    "scrollTop: $('#" + controlId + "').offset().top " +
                "}, 1000);" +
            "});";

        if (!Page.ClientScript.IsStartupScriptRegistered("ScrollToElement"))
            Page.ClientScript.RegisterStartupScript(this.GetType(), "ScrollToElement", script, true);
    }

    private void turYukle()
    {
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from tedaviturleri order by ID asc", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);

        turList.DataSource = dt6;
        turList.DataTextField = dt6.Columns["tur"].ToString();
        turList.DataValueField = dt6.Columns["ID"].ToString();
        turList.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        turList.Items.Insert(0, yeni);

    }

    
    protected void ust_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName.ToString() != "1")
        {

            try
            {

                int degisecek_sira = int.Parse(e.CommandName.ToString()) - 1;


                MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
                MySqlCommand mp_cmd2 = new MySqlCommand("update tedaviiceriktablosu set sira = sira + 1 where sira=" + degisecek_sira + " and tur=" + Label1.Text + "", connect_word);

                connect_word.Open();
                int eks2 = mp_cmd2.ExecuteNonQuery();
                connect_word.Close();


                MySqlCommand mp_cmd = new MySqlCommand("update tedaviiceriktablosu set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", connect_word);


                connect_word.Open();
                int eks = mp_cmd.ExecuteNonQuery();
                connect_word.Close();

                listeYukle();



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

            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from tedaviiceriktablosu where tur=" + Label1.Text + "", connect_word);
            DataTable mp_dt = new DataTable();
            da.Fill(mp_dt);

            if (e.CommandName.ToString() != mp_dt.Rows[0][0].ToString())
            {


                int degisecek_sira = int.Parse(e.CommandName.ToString()) + 1;


                MySqlCommand mp_cmd2 = new MySqlCommand("update tedaviiceriktablosu set sira = sira - 1 where sira=" + degisecek_sira + " and tur=" + Label1.Text + "", connect_word);


                connect_word.Open();
                int eks2 = mp_cmd2.ExecuteNonQuery();
                connect_word.Close();




                MySqlCommand mp_cmd = new MySqlCommand("update tedaviiceriktablosu set sira = " + degisecek_sira + "  where ID=" + e.CommandArgument.ToString() + "", connect_word);


                connect_word.Open();
                int eks = mp_cmd.ExecuteNonQuery();
                connect_word.Close();

                listeYukle();
            }

        }


        catch
        {


        }

    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);

        MySqlCommand mp_cmd2 = new MySqlCommand("update tedaviiceriktablosu set sira = sira - 1 where sira > " + e.CommandName.ToString() + " and tur=" + Label1.Text + "", connect_word);

        connect_word.Open();
        int eks3 = mp_cmd2.ExecuteNonQuery();
        connect_word.Close();




        MySqlCommand mp_cmd = new MySqlCommand("delete from tedaviiceriktablosu where ID=" + e.CommandArgument.ToString() + "", connect_word);


        connect_word.Open();
        int eks = mp_cmd.ExecuteNonQuery();
        connect_word.Close();


        if (eks == 1)
        {
            listeYukle();
            sonuc.Text = "Yazı silme işlemi başarıyla gerçekleştirildi.";
            sonuc.ForeColor = System.Drawing.Color.Green;
        }

        else
        {
            sonuc.Text = "Yazı silme işlemi başarısız! Lütfen tekrar deneyiniz..";
            sonuc.ForeColor = System.Drawing.Color.Green;

        }

        //}

        //else
        //{
        //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Bu sinav tipini kullanan sinav bulunduğu için silme işlemi başarısız!', 'error');", true);

        //}

    }
  
    protected void duzenle_Command(object sender, CommandEventArgs e)
    {

        Response.Redirect("0000077.aspx?ID=" + e.CommandArgument.ToString());


    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        if (turList.SelectedValue == "")
        {
            Label1.Text = "";
            Label2.Text = "Lütfen sayfa seçiniz";
            list.Visible = false;

        }
        else
        {
            Label1.Text = turList.SelectedValue;
            listeYukle();
           
        }

    }

    private void listeYukle()
    {
        try
        {
            list.Visible = true;
            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from tedaviiceriktablosu where tur=" + Label1.Text + " order by sira asc", connect_word);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            list.DataSource = mp_dt;
            list.DataBind();

            Label2.Text ="Seçilen sayfadaki toplam yazı sayısı : " +  mp_dt.Rows.Count.ToString();

            ImageButton duzenle = new ImageButton();
            ImageButton sil = new ImageButton();
            ImageButton ust = new ImageButton();
            ImageButton alt = new ImageButton();
            Image resim = new Image();
            Label lblTip = new Label();
            Label lblID = new Label();
            LinkButton goruntu = new LinkButton();
          //  Label onizle = new Label();


            int i = 0;

            foreach (GridViewRow str in list.Rows)
            {

                lblTip = (Label)str.FindControl("lblTip");
                lblTip.Text = mp_dt.Rows[i]["baslik"].ToString();

           //     onizle = (Label)str.FindControl("onizle");
          //      onizle.Text = "<a href='yaziOnizle.aspx?tur=" + Label1.Text + "&ID=" + mp_dt.Rows[i]["kisaAd"].ToString() + "#gallery-details-" + mp_dt.Rows[i]["kisaAd"].ToString() + "' target='_blank'><img src='images/onizle.png'/></a>";

                lblID = (Label)str.FindControl("lblID");
                lblID.Text = mp_dt.Rows[i]["ID"].ToString();

                duzenle = (ImageButton)str.FindControl("duzenle");
                sil = (ImageButton)str.FindControl("sil");

                resim = (Image)str.FindControl("resim");
                goruntu = (LinkButton)str.FindControl("goruntu");
                goruntu.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                goruntu.CommandName = mp_dt.Rows[i]["yayin"].ToString();

                resim.ImageUrl = "~/uploadImages/" + mp_dt.Rows[i]["kapakResmi"].ToString() + "_225.jpg";

                duzenle.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                sil.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                sil.CommandName = mp_dt.Rows[i]["sira"].ToString();

                ust = (ImageButton)str.FindControl("ust");
                ust.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                ust.CommandName = mp_dt.Rows[i]["sira"].ToString();

                alt = (ImageButton)str.FindControl("alt");
                alt.CommandArgument = mp_dt.Rows[i]["ID"].ToString();
                alt.CommandName = mp_dt.Rows[i]["sira"].ToString();

                if (mp_dt.Rows[i]["yayin"].ToString() == "E")
                {

                    goruntu.Text = "+";
                    goruntu.ForeColor = System.Drawing.Color.Green;
                }
                else
                {

                    goruntu.Text = "-";
                    goruntu.ForeColor = System.Drawing.Color.Red;
                }



                i++;

            }
        }


        catch
        {


        }

    }
    protected void goruntu_Command(object sender, CommandEventArgs e)
    {
        string yayin = "";

        if (e.CommandName == "E")
        {
            yayin = "H";
        }
        else
        {
            yayin = "E";
        }


        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);

        MySqlCommand mp_cmd2 = new MySqlCommand("update tedaviiceriktablosu set yayin='" + yayin + "' where ID=" + e.CommandArgument.ToString() + "", connect_word);


            connect_word.Open();
                int eks2 = mp_cmd2.ExecuteNonQuery();
                connect_word.Close();


                listeYukle();

    }
    protected void onizle_Command(object sender, CommandEventArgs e)
    {
        sonuc.Text = "Önizleme sayfası kullanıcının göreceği sayfa son halini alınca yapılacak.";
        sonuc.ForeColor = System.Drawing.Color.Red;

    }
   
}