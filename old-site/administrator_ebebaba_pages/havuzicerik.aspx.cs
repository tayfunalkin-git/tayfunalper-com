using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mainAdminPagesHdn_havuz : System.Web.UI.Page
{
    ebebaba_connect_class noc = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            resimYukle();
        }
    }

    private void resimYukle()
    {

        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from resimhavuzuicerik where onay='+' order by tarih desc", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);
        Label15.Text = dt6.Rows.Count.ToString();

        resimList.DataSource = dt6;
        resimList.DataBind();

        int a = 0;
        Label resim = new Label();
       
        Button sil = new Button();

        foreach (DataListItem oge in resimList.Items)
        {
            resim = (Label)oge.FindControl("resim");
            resim.Text = "<div class='hovergallery'><img onclick='ekle(this.title,this.alt);' width='225px' alt='"+Request.QueryString["gonderen"].ToString()+"' title='" + dt6.Rows[a]["adi"].ToString() + "' src='../uploadImages/" + dt6.Rows[a]["adi"].ToString() + "_thumb.jpg'/></div>";


            sil = (Button)oge.FindControl("sil");
            sil.CommandArgument = dt6.Rows[a]["ID"].ToString();
            sil.CommandName  = dt6.Rows[a]["adi"].ToString();

            a++;
        }


    }
    protected void sil_Command(object sender, CommandEventArgs e)
    {

        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlCommand cmd = new MySqlCommand("delete from  resimhavuzuicerik where ID=" + e.CommandArgument.ToString() + "", connect_word);

        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();


        if (eks == 1)
        {

            resimYukle();
          //  ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('BAŞARILI !', 'Resim başarıyla silindi.', 'success');", true);

        }
        else
        {
         //   ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Resim silme aşamasında hata oluştu.Lütfen tekrar deneyiniz...', 'error');", true);

        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("resimYukleIcerik.aspx?gonderen=" + Request.QueryString["gonderen"].ToString());
    }
}