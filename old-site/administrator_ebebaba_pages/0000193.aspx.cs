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

        }
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
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from iceriktablosu", connect_word);
            DataTable mp_dt = new DataTable();
            da.Fill(mp_dt);

            int sirano = 0;
            if (mp_dt.Rows[0][0].ToString() == "")
            { sirano = 1; }
            else
            {
                sirano = 0;
                if (mp_dt.Rows[0][0].ToString() == "")
                { sirano = 1; }
                else
                { sirano = int.Parse(mp_dt.Rows[0][0].ToString()) + 1; }

            }

            MySqlCommand cmd = new MySqlCommand("Insert into iceriktablosu(baslik,icerik,eklenmeTarihi,yayin,sira,kisaAd) values (?1,?2,?3,?4,?5,?6)", connect_word);

            cmd.Parameters.AddWithValue("?1", txtBaslik.Text);
            cmd.Parameters.AddWithValue("?2", txtIcerik.Text);
            cmd.Parameters.AddWithValue("?3", DateTime.Now);
            cmd.Parameters.AddWithValue("?4", yayin.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("?5", sirano);
            cmd.Parameters.AddWithValue("?6", GenisletmeMetotlari.ToURL(noc.deveYazimi(txtBaslik.Text)));

            connect_word.Open();
            int eks = cmd.ExecuteNonQuery();
            string soneklenen = cmd.LastInsertedId.ToString();
            connect_word.Close();

            if (eks == 1)
            {
                Response.Redirect("0000194.aspx?S=" + soneklenen + "&islem=Y");
            }
            else
            {
               sonuc.Text = "Yazı ekleme işlemi başarısız!";
               sonuc.ForeColor = System.Drawing.Color.Red;
            }

    }
}