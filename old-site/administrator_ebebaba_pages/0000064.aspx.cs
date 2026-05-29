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

public partial class administrator_ebebaba_pages_0000064 : System.Web.UI.Page
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

       

        try
        { 
                        MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);

                        MySqlDataAdapter da33 = new MySqlDataAdapter("Select * from kitap_konulari where konu_id =" + Request.QueryString["ID"].ToString() + "", ebebaba_connection);
        DataTable dtsub3 = new DataTable();
        da33.Fill(dtsub3);


        Label15.Text = dtsub3.Rows[0]["konu"].ToString();

            
            if (Session["aranan9"] != null)
            {
                Label2.Text = "Aranan Kelime | " + Session["aranan9"].ToString();

            }
            else
            {
                Label2.Text = "";


            }
                   
           
            string sqltext = "select * from kitap_yardim where konu='"+Request.QueryString["ID"].ToString()+"' order by hit desc,date(tarih) desc";

            if (Session["aramali9"] != null)
            {
                sqltext = Session["aramali9"].ToString();
                arasonc.Visible = true;

            
            }
            
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter(sqltext, ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);
  
            gelenmesajlar.DataSource = ebebaba_dt2;
            
            gelenmesajlar.DataBind ();

            
            int a = 0;

            int okunmamis = 0;



            int ind = gelenmesajlar.PageIndex;

            a = ind * 15;


            
            foreach (GridViewRow str in gelenmesajlar.Rows)

            {


                Label gonderenTip = new Label();
                Label gonderimTip = new Label();
                Label mesajTip = new Label();
                
                LinkButton lbtn = new LinkButton();
                lbtn = (LinkButton)str.FindControl("konum");
                lbtn.CommandArgument = ebebaba_dt2.Rows[a]["mesaj_id"].ToString();
             
                gonderenTip = (Label)str.FindControl("gonderenTip");
                gonderimTip = (Label)str.FindControl("gonderimTip");
                mesajTip = (Label)str.FindControl("mesajTip");

                gonderenTip.Text = ebebaba_dt2.Rows[a]["gonderenTipi"].ToString();
                mesajTip.Text = ebebaba_dt2.Rows[a]["fikirTipi"].ToString();

                gonderimTip.Text = ebebaba_dt2.Rows[a]["kayitTipi"].ToString();



                Image cvp = new Image ();
                Image yn = new Image();
                Image okunan = new Image();

                if (ebebaba_dt2.Rows[a]["hit"].ToString() == "1")
                {

                    str.Cells[1].Font.Bold = true;
                 
                    str.Cells[3].Font.Bold = true;

                    yn = (Image)str.Cells[0].FindControl("yeni");
                    yn.Visible = true;
                    cvp = (Image)str.Cells[0].FindControl("cevap");
                    cvp.Visible = false;
                    okunan = (Image)str.Cells[0].FindControl("okundu");
                    okunan.Visible = false;
                    
                    okunmamis++;


                }
                else
                {

                    if (ebebaba_dt2.Rows[a]["cevap"].ToString() == "1")
                {
                    cvp = (Image)str.Cells[0].FindControl("cevap");
                    cvp.Visible = true;
                    okunan = (Image)str.Cells[0].FindControl("okundu");
                    okunan.Visible = false;
                    yn = (Image)str.Cells[0].FindControl("yeni");
                    yn.Visible = false;
                }
                else
                {

                    cvp = (Image)str.Cells[0].FindControl("cevap");
                    cvp.Visible = false;
                    okunan = (Image)str.Cells[0].FindControl("okundu");
                    okunan.Visible = true;
                    yn = (Image)str.Cells[0].FindControl("yeni");
                    yn.Visible = false;


                }

                  

                
                }

                     
                    str.Cells [1].Text = ebebaba_dt2.Rows[a]["ad_soyad"].ToString();
                      
                
                a++;

            }


            mesaj_say();

}

        catch
        {

        }
    }


    void mesaj_say()
    {

        try
        {

            string sqltext = "select * from kitap_yardim where konu='" + Request.QueryString["ID"].ToString() + "'order by hit desc,date(tarih) desc";


            if (Session["aramali9"] != null)
            {
                sqltext = Session["aramali9"].ToString();
                arasonc.Visible = true;

            }


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter(sqltext, ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);

            int okunmayan = 0;

            for (int a = 0; a < ebebaba_dt2.Rows.Count; a++)
            {
                if (ebebaba_dt2.Rows[a]["hit"].ToString() == "1")
                {
                    okunmayan++;

                }

            }


            Label1.Text = okunmayan + " / " + ebebaba_dt2.Rows.Count + " Mesaj";

            if (ebebaba_dt2.Rows.Count == 0)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Hiç Mesaj Yok !";

                sonuc.ForeColor = System.Drawing.Color.Red;

                Button1.Enabled = false;
                Button2.Enabled = false;

            }
            else
            {


                if (okunmayan > 0)
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = okunmayan.ToString() + " Yeni Mesaj Var.";


                    sonuc.ForeColor = System.Drawing.Color.Green;
                    Button1.Enabled = true;
                    Button2.Enabled = true;



                }
                else
                {
                    Button1.Enabled = false;
                    Button2.Enabled = true;
                    panel_sonuc.Visible = false;

                }

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

        Session.Add("mesaj_id9", e.CommandArgument.ToString());

        Response.Redirect("0000066.aspx?kaynak=gelen_mesajlar&mesaj_id=" + mesaj_id + "&kat="+Request.QueryString["ID"].ToString());


     }
 
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

        try
        {
            string sqltext = "select * from kitap_yardim where konu='" + Request.QueryString["ID"].ToString() + "'order by hit desc,date(tarih) desc";



            if (Session["aramali9"] != null)
            {
                sqltext = Session["aramali9"].ToString();
                arasonc.Visible = true;
            }

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da2 = new MySqlDataAdapter(sqltext, ebebaba_connection);
            DataTable ebebaba_dt2 = new DataTable();
            ebebaba_da2.Fill(ebebaba_dt2);

            int a = 0;


            foreach (GridViewRow str in gelenmesajlar.Rows)
            {

            CheckBox isaret = new CheckBox();
                isaret = (CheckBox)str.Cells[0].FindControl("secmesaj");

                if (isaret.Checked == true)
                {
                    if (ebebaba_dt2.Rows[a]["hit"].ToString() == "1")
                    {

                        ebebaba_dt2.Rows[a]["hit"] = "0";

                        okundu(ebebaba_dt2.Rows[a]["mesaj_id"].ToString());

                    }

                }

                a++;



            }


            
            mesaj_yukle();

        }


        catch
        { 
        
        
        }
    }


    void okundu(string id) {


        try
        { 
        MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
        MySqlCommand ebebaba_cmd3 = new MySqlCommand("update kitap_yardim set hit = '0' where mesaj_id=" + id + "", ebebaba_connection);
        ebebaba_connection.Open();
        int eks3 = ebebaba_cmd3.ExecuteNonQuery();
        ebebaba_connection.Close();

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
        MySqlCommand ebebaba_cmd3 = new MySqlCommand("delete from kitap_yardim where mesaj_id=" + id + "", ebebaba_connection);
        ebebaba_connection.Open();
        int eks3 = ebebaba_cmd3.ExecuteNonQuery();
        ebebaba_connection.Close();

 }
        catch
        {
        }

    }

    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {

        try
        {
            string sqltext = "select * from kitap_yardim where konu='" + Request.QueryString["ID"].ToString() + "'order by hit desc,date(tarih) desc";


            if (Session["aramali9"] != null)
            {
                sqltext = Session["aramali9"].ToString();
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


    protected void arasonc_Click(object sender, EventArgs e)
    {
        if(Session["aramali9"]!=null)
        {
            Session["aramali9"] = null;
            Session["aranan9"] = null;

            arasonc.Visible = false;
            panel_sonuc.Visible = false;
            mesaj_yukle();
            aranacak.Text = "";

        }

    }

    protected void Button3_Click1(object sender, ImageClickEventArgs e)
    {


        try
        {

            String Sqlifadesi = "Select * from kitap_yardim where konu='" + Request.QueryString["ID"].ToString() + "' and (ad_soyad like '%" + aranacak.Text.ToString() + "%' or konu like '%" + aranacak.Text.ToString() + "%' or mesaj like '%" + aranacak.Text.ToString() + "%') order by hit desc,date(tarih) desc";

            Session.Add("aramali9", Sqlifadesi.ToString());
            Session.Add("aranan9", aranacak.Text.ToString());

            arasonc.Visible = true;


            Label2.Text = "Aranan Kelime | " + Session["aranan9"].ToString();


            mesaj_yukle();
        }


        catch
        {



        }


    }
}
