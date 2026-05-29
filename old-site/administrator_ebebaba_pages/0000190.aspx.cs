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
           
            LinkButton1.OnClientClick = "return popitup('havuzAnasayfa.aspx?gonderen=kapak','agac')";
        }
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
        MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from siteler", connect_word);
        DataTable mp_dt = new DataTable();
        da.Fill(mp_dt);

        int sirano = 0; 
        if (mp_dt.Rows[0][0].ToString() == "")
        { sirano = 1; } 
        else 
        { sirano = 0; 
            if (mp_dt.Rows[0][0].ToString() == "") 
            { sirano = 1; } else 
            { sirano = int.Parse(mp_dt.Rows[0][0].ToString()) + 1; }
        
        }


        MySqlCommand cmd = new MySqlCommand("Insert into siteler(siteAdi,adres,resim,sira,yayin,footer) values (?1,?2,?3,?4,?5,?6)", connect_word);
      
        cmd.Parameters.AddWithValue("?1",txtSiteAdi.Text);
        cmd.Parameters.AddWithValue("?2",txtAdres.Text);
        cmd.Parameters.AddWithValue("?3",txtKapak.Value);
        cmd.Parameters.AddWithValue("?4",sirano.ToString());
        cmd.Parameters.AddWithValue("?5", yayin.SelectedValue);
        cmd.Parameters.AddWithValue("?6", txtFooter.Text);


        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        string soneklenen = cmd.LastInsertedId.ToString();
        connect_word.Close();

        if (eks == 1)
        {
            Response.Redirect("0000191.aspx?S=" + soneklenen + "&islem=Y");
        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text  = "Site ekleme işlemi başarısız!";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
}