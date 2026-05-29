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

            Label2.OnClientClick = "return popitup('havuzicerik.aspx?gonderen=icerik','agac2')";
            Label2.Text = "İÇERİĞE RESİM EKLE";
            bilgiYukle();
        }
    }

    private void bilgiYukle()
    {
        
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from iceriktablosu where ID="+Request.QueryString["ID"].ToString()+"", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        txtBaslik.Text = dt.Rows[0]["baslik"].ToString();
        txtIcerik.Text = dt.Rows[0]["icerik"].ToString();

        yayin.SelectedValue = dt.Rows[0]["yayin"].ToString();

    }


   
    protected void Button1_Click(object sender, EventArgs e)
    {

      
       
       if (txtBaslik.Text == "")
        {
            sonuc.Text = "Yazının Başlığını Belirleyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;
        
        }
        else if (txtIcerik.Text == "")
        {
            sonuc.Text = "Yazının İçeriğini Belirleyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
       
           else if (yayin.SelectedIndex == -1)
           {
               sonuc.Text = "Yayın Durumunu Seçiniz.";
               sonuc.ForeColor = System.Drawing.Color.Red;
           }
           else
           {
              
                   kaydet();
  

           }


    }

    private void kaydet()
    {



            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);

            MySqlCommand cmd = new MySqlCommand("Update iceriktablosu set baslik=?1,icerik=?2,yayin=?3,kisaAd=?4 where ID=?5", connect_word);
            cmd.Parameters.AddWithValue("?1", txtBaslik.Text);
            cmd.Parameters.AddWithValue("?2", txtIcerik.Text);
            cmd.Parameters.AddWithValue("?3", yayin.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("?4", GenisletmeMetotlari.ToURL(noc.deveYazimi(txtBaslik.Text)));
            cmd.Parameters.AddWithValue("?5", Request.QueryString["ID"].ToString());

            connect_word.Open();
            int eks = cmd.ExecuteNonQuery();
            connect_word.Close();

            if (eks == 1)
            {
                Response.Redirect("0000194.aspx?&S=" + Request.QueryString["ID"].ToString() + "&islem=G");
                sonuc.Text = "Yazı başarıyla eklendi.";
                sonuc.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                sonuc.Text = "Yazı güncelleme işlemi başarısız!";
                sonuc.ForeColor = System.Drawing.Color.Red;
            }



    }
}