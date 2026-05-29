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
           
        }
    }


    private void yukle1()
    {
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from anasayfatasarimi where ID<>1 order by ID asc", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        baslik2.Text = dt.Rows[0]["satir1"].ToString();
        baslik3.Text = dt.Rows[1]["satir1"].ToString();
        baslik4.Text = dt.Rows[2]["satir1"].ToString();
        baslik5.Text = dt.Rows[3]["satir1"].ToString();
        baslik6.Text = dt.Rows[4]["satir1"].ToString();
        baslik7.Text = dt.Rows[5]["satir1"].ToString();
        baslik8.Text = dt.Rows[6]["satir1"].ToString();

        siralama2.SelectedValue = dt.Rows[0]["sira"].ToString();
        siralama3.SelectedValue = dt.Rows[1]["sira"].ToString();
        siralama4.SelectedValue = dt.Rows[2]["sira"].ToString();
        siralama5.SelectedValue = dt.Rows[3]["sira"].ToString();
        siralama6.SelectedValue = dt.Rows[4]["sira"].ToString();
        siralama7.SelectedValue = dt.Rows[5]["sira"].ToString();
        siralama8.SelectedValue = dt.Rows[6]["sira"].ToString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "";
        sql += "Update anasayfatasarimi set sira=" + siralama2.SelectedValue + " where ID=2;";
        sql += "Update anasayfatasarimi set sira=" + siralama3.SelectedValue + " where ID=3;";
        sql += "Update anasayfatasarimi set sira=" + siralama4.SelectedValue + " where ID=4;";
        sql += "Update anasayfatasarimi set sira=" + siralama5.SelectedValue + " where ID=5;";
        sql += "Update anasayfatasarimi set sira=" + siralama6.SelectedValue + " where ID=6;";
        sql += "Update anasayfatasarimi set sira=" + siralama7.SelectedValue + " where ID=7;";
        sql += "Update anasayfatasarimi set sira=" + siralama8.SelectedValue + " where ID=8";



        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlCommand cmd = new MySqlCommand(sql, connect_word);

        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();

        if (eks > 0)
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