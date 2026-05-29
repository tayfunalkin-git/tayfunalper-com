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
            yukle1();
            LinkButton1.OnClientClick = "return popitup('havuzAnasayfa.aspx?gonderen=kapak','agac')";
            LinkButton2.OnClientClick = "return popitup('havuzLink.aspx?gonderen=txtSatir3','link')";

        }
    }


    private void yukle1()
    {
        //1.Bölüm
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from anasayfatasarimi where ID=2", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);
        txtSatir1.Text = dt.Rows[0]["satir1"].ToString();
        txtSatir2.Text = dt.Rows[0]["satir2"].ToString();
        txtSatir3.Text = dt.Rows[0]["satir3"].ToString();
        if (dt.Rows[0]["yayin"].ToString() == "+")
        {
            txtSatir4.Checked = true;
        }
        else
        {
            txtSatir4.Checked = false;
        }
        txtSatir5.Text = dt.Rows[0]["satir5"].ToString();
        txtSatir6.Text = dt.Rows[0]["satir6"].ToString();
        secilenKapakResmi.InnerHtml = "<img src='../uploadImages/" + dt.Rows[0]["resim"].ToString() + "_450.jpg'/>";
        txtKapak.Value = dt.Rows[0]["resim"].ToString();
        hizalama.SelectedValue = dt.Rows[0]["hizalama"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string yayin = "";
        if (txtSatir4.Checked == true)
        {
            yayin = "+";
        }
        else
        {
            yayin = "-";
        }

        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update anasayfatasarimi set satir1=?1,satir2=?2,satir3=?3,yayin=?4,satir5=?5,satir6=?6,resim=?10,hizalama=?12 where ID=2", connect_word);

        cmd.Parameters.AddWithValue("?1", txtSatir1.Text);
        cmd.Parameters.AddWithValue("?2", txtSatir2.Text);
        cmd.Parameters.AddWithValue("?3", txtSatir3.Text);
        cmd.Parameters.AddWithValue("?4", yayin);
        cmd.Parameters.AddWithValue("?5", txtSatir5.Text);
        cmd.Parameters.AddWithValue("?6", txtSatir6.Text);
        cmd.Parameters.AddWithValue("?10", txtKapak.Value);
        cmd.Parameters.AddWithValue("?12", hizalama.SelectedValue);


        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();

        if (eks == 1)
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Başarıyla güncellendi.";
            sonuc.ForeColor = System.Drawing.Color.Green;
            yukle1();

        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Güncelleme işlemi başarısız!";
            sonuc.ForeColor = System.Drawing.Color.Red;
        }
    }
}