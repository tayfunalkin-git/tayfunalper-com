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

public partial class administrator_ebebaba_pages_0000065 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();

    forum_class fc = new forum_class();
  

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            mesaj_yukle();        
        
        }
        
    }

    void mesaj_yukle()
    {

        //try
        //{
            if (Session["aranan1111"] != null)
            {
                Label2.Text = "Aranan Kelime | " + Session["aranan1111"].ToString();

            }
            else
            {
                Label2.Text = "";


            }
           
            string sqltext = "select * from yardim_tab_giden order by date(tarih) desc";


            if (Session["aramali11111"] != null)
            {
                sqltext = Session["aramali11111"].ToString();
                arasonc.Visible = true;
            }


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter(sqltext, ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);
  
            gelenmesajlar.DataSource = ebebaba_dt2;
            
            gelenmesajlar.DataBind ();

            
            int a = 0;

            int ind = gelenmesajlar.PageIndex;

            a = ind * 15;

           
            foreach (GridViewRow str in gelenmesajlar.Rows)

            {

              LinkButton lbtn = new LinkButton();

                lbtn = (LinkButton)str.Cells[2].FindControl("konum");
                lbtn.CommandArgument = ebebaba_dt2.Rows[a]["mesaj_id"].ToString();
                lbtn.Text = ebebaba_dt2.Rows[a]["konu"].ToString();

                str.Cells[1].Text = ebebaba_dt2.Rows[a]["ad_soyad"].ToString();
            
                
                a++;

            }


            mesaj_say();

//}

//        catch
//        {

//        }
    }


    void mesaj_say()
    {

        try
        {

            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = EbebabaKullanilan["AdminKKA"].ToString();

            string sqltext = "select * from yardim_tab_giden order by date(tarih) desc";




            if (Session["aramali11111"] != null)
            {
                sqltext = Session["aramali11111"].ToString();
                arasonc.Visible = true;
            }



            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter(sqltext, ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);


            Label1.Text = ebebaba_dt2.Rows.Count + " Mesaj";
            if (ebebaba_dt2.Rows.Count == 0)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Hiç Giden Mesaj Yok !";

                sonuc.ForeColor = System.Drawing.Color.Red;



                Button2.Enabled = false;

            }
        }

        catch
        { 
        
        
        }
        }
    protected void gelenmesajlar_RowDataBound(object sender, GridViewRowEventArgs e)
    {

   
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal)
                bicimlendir(e);
            if (e.Row.RowState == DataControlRowState.Alternate)
                bicimlendir(e);
        }
   
    }


    void bicimlendir(GridViewRowEventArgs e)
    {


        e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='WhiteSmoke'");
        e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='White'");
       


    } 

   protected void gelenmesajlar_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        
        gelenmesajlar.PageIndex = e.NewPageIndex;
        gelenmesajlar.DataBind();
      
        mesaj_yukle();

        
    }

    protected void konu_Command(object sender, CommandEventArgs e)
    {



        string mesaj_id = e.CommandArgument.ToString();

        Session.Add("mesaj_id10", e.CommandArgument.ToString());

        Response.Redirect("0000067.aspx?kaynak=giden_mesajlar&mesaj_id=" + mesaj_id);

       


    }
 
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {

        try
        {

            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = EbebabaKullanilan["AdminKKA"].ToString();

            string sqltext = "select * from yardim_tab_giden order by date(tarih) desc";

            
            if (Session["aramali11111"] != null)
            {
                sqltext = Session["aramali11111"].ToString();
                arasonc.Visible = true;
            }



            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter(sqltext, ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);

            int a = 0;

            CheckBox isaret = new CheckBox();

            foreach (GridViewRow str in gelenmesajlar.Rows)
            {

                isaret = (CheckBox)str.Cells[0].FindControl("secmesaj");

                if (isaret.Checked == true)
                {

                    silinecekler(ebebaba_dt2.Rows[a]["mesaj_id"].ToString());



                }

                a++;

            }

     
            mesaj_yukle();


        }


        catch
        { 
        
        
        
        }
    }

    void silinecekler(string id)
    {
        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd3 = new MySqlCommand("delete from yardim_tab_giden where mesaj_id=" + id + "", ebebaba_connection);
            ebebaba_connection.Open();
            int eks3 = ebebaba_cmd3.ExecuteNonQuery();
            ebebaba_connection.Close();

        }
        catch
        {
        }

    }

    protected void arasonc_Click(object sender, EventArgs e)
    {
        if (Session["aramali11111"] != null)
        {
            Session["aramali11111"] = null;
            Session["aranan1111"] = null;
            arasonc.Visible = false;
            aranacak.Text = "";
            mesaj_yukle();
            panel_sonuc.Visible = false;

        }

    }
    protected void Button3_Click1(object sender, ImageClickEventArgs e)
    {


        try
        {
            HttpCookie EbebabaKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdi = EbebabaKullanilan["AdminKKA"].ToString();

            String Sqlifadesi = "Select * from yardim_tab_giden where (ad_soyad like '%" + aranacak.Text.ToString() + "%' or gonderen like '%" + aranacak.Text.ToString() + "%' or konu like '%" + aranacak.Text.ToString() + "%' or mesaj like '%" + aranacak.Text.ToString() + "%')order by date(tarih) desc";

            Session.Add("aramali11111", Sqlifadesi.ToString());

            Session.Add("aranan1111", aranacak.Text.ToString());
            Label2.Text = "Aranan Kelime | " + Session["aranan1111"].ToString();

            arasonc.Visible = true;

            mesaj_yukle();
        }


        catch
        {

        }

    }
}
