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
            yukle();
            LinkButton1.OnClientClick = "return popitup('havuzAnasayfa.aspx?gonderen=kapak','agac')";
        }
    }

    private void yukle()
    {

        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("select * from siteler where ID="+Request.QueryString["ID"].ToString()+"", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);
        txtAdres.Text = dt.Rows[0]["adres"].ToString();
        txtSiteAdi.Text = dt.Rows[0]["siteAdi"].ToString();
        secilenKapakResmi.InnerHtml = "<img src='../uploadImages/" + dt.Rows[0]["resim"].ToString() + "_450.jpg'/>";
        txtKapak.Value = dt.Rows[0]["resim"].ToString();
        yayin.SelectedValue = dt.Rows[0]["yayin"].ToString();
        txtFooter.Text = dt.Rows[0]["footer"].ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtAdres.Text != "" && txtKapak.Value != "" && txtSiteAdi.Text != "" && txtFooter.Text != "")
        {
            secilenKapakResmi.InnerHtml = "<img src='../uploadImages/" + txtKapak.Value + "_450.jpg'/>";
            kaydet();
        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Formdaki tüm alanları doldurunuz!";
            sonuc.ForeColor = System.Drawing.Color.Red;
        }
    }

    private void kaydet()
    {


        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update siteler set siteAdi=?1,adres=?2,resim=?3,yayin=?4,footer=?6 where ID=?5", connect_word);
      
        cmd.Parameters.AddWithValue("?1",txtSiteAdi.Text);
        cmd.Parameters.AddWithValue("?2",txtAdres.Text);
        cmd.Parameters.AddWithValue("?3",txtKapak.Value);
        cmd.Parameters.AddWithValue("?4", yayin.SelectedValue);
        cmd.Parameters.AddWithValue("?6", txtFooter.Text);
        cmd.Parameters.AddWithValue("?5", Request.QueryString["ID"].ToString());

        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();

        if (eks == 1)
        {
            Response.Redirect("0000191.aspx?S=" + Request.QueryString["ID"].ToString() + "&islem=G");
        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text  = "Site güncelleme işlemi başarısız!";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
}