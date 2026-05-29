using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class ivfyonetici_talper_5534 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //yukle();
            denetim();
        }
    }

    private void denetim()
    {

        HttpCookie mpKullanilan = Request.Cookies["Doktor"];
        string kullaniciAdiAdmin = mpKullanilan["doktorKullaniciAdi"].ToString();

        if (kullaniciAdiAdmin != "tayfun")
        {
            Response.Redirect("Default.aspx");
        }

    }

    //void yukle()
    //{
    //    Label15.Text = "1";
    //    try
    //    {
    //        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
    //        MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from kaynaklog order by islemTarihi desc", mp_connection);

    //        DataTable mp_dt = new DataTable();
    //        mp_da.Fill(mp_dt);

    //        loglist.DataSource = mp_dt;
    //        loglist.DataBind();


    //    }
    //    catch
    //    {


    //        panel_sonuc.Visible = true;
    //        sonuc.Text = "Log Yüklenirken Hata Oluştu!";

    //    }

    //}

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label15.Text = "0";
        yukle2();

    }

    private void yukle2()
    {


        try
        {
            MySqlConnection mp_connection = connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from kaynaklog where islem like '%" + arama.Text + "%' or hastaAdi like '%"+arama.Text+"%' order by islemTarihi desc", mp_connection);

            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);



            loglist.DataSource = mp_dt;
            loglist.DataBind();





            if (mp_dt.Rows.Count == 0)
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Aranılan kelimeyi içeren Kayıt Bulunamadı !";

            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Aranılan kelimeye ait " + mp_dt.Rows.Count + " kayıt bulundu.";

            }



        }
        catch
        {


            panel_sonuc.Visible = true;
            sonuc.Text = "Log Yüklenirken Hata Oluştu!";

        }



    }
 
    protected void loglist_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        loglist.PageIndex = e.NewPageIndex;
        loglist.DataBind();

        if (Label15.Text == "0")
        {
            yukle2();
        }
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/administrator_ebebaba_pages/Default.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("3455.aspx?islem=ok");
    }


    public MySqlConnection connect_ivf(int coming)
    {

        //try
        // {

        // MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=florya;User ID=root;Password=0301009184;");
        MySqlConnection connect = new MySqlConnection("DataSource=94.73.150.121;Database=FLORYAdbB5043B;User ID=userB5043B;Password=EInt63E8;charset=latin5;convert zero datetime=True");

        return connect;
        //        }
        //        catch
        //{
        //   return null;
        // }

    }

}