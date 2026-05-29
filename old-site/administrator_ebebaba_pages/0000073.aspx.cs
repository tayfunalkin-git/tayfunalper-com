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
            turYukle();
            kategoriYukle();
            Label1.OnClientClick = "return popitup('havuz.aspx?gonderen=kapak','agac')";
            Label1.Text = "SEÇ";

            Label2.OnClientClick = "return popitup('havuzicerik.aspx?gonderen=icerik','agac2')";
            Label2.Text = "İÇERİĞE RESİM EKLE";

        }
    }


    private void turYukle()
    {
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from tedaviturleri order by ID asc", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);

        turList.DataSource = dt6;
        turList.DataTextField = dt6.Columns["tur"].ToString();
        turList.DataValueField = dt6.Columns["ID"].ToString();
        turList.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";



        //yeni.Selected = true;

        turList.Items.Insert(0, yeni);

    }

   

    private void kategoriYukle()
    {
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from kategorilist order by sira asc", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);

        kategoriler.DataSource = dt6;
        kategoriler.DataTextField = dt6.Columns["Adi"].ToString();
        kategoriler.DataValueField = dt6.Columns["ID"].ToString();
        kategoriler.DataBind();


    }
    protected void Button1_Click(object sender, EventArgs e)
    {

       secilenKapakResmi.InnerHtml = "<img src='../uploadImages/"+txtKapak.Value+"_225.jpg'/>";

        if (turList.SelectedValue == "")
        {
            sonuc.Text = "Yazının Hangi Sayfaya Ekleneceğini Seçiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
        else if (txtBaslik.Text == "")
        {
            sonuc.Text = "Yazının Başlığını Belirleyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;
        
        }
        else if (txtIcerik.Text == "")
        {
            sonuc.Text = "Yazının İçeriğini Belirleyiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }
        else if (txtKapak.Value == "")
        {
            sonuc.Text = "Kapak Resmi Seçiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;
        }
        else if (yayin.SelectedIndex == -1)
        {
            sonuc.Text = "Yayın Durumunu Seçiniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            string secilen = "";

            foreach(ListItem oge in kategoriler.Items)
            {
                if (oge.Selected == true)
                {
                    secilen += oge.Value + ",";
                }
            }
            if (secilen == "")
            {
                sonuc.Text = "Hangi Kategorilerde Görüneceğini Seçiniz.";
                sonuc.ForeColor = System.Drawing.Color.Red;
                
            }
            else
            {
                secilen = secilen.Substring(0, secilen.Length - 1);
                kaydet(secilen);
            
            }

            
        
        
        
        }


    }

    private void kaydet(string secilen)
    {
        int islem = 0;
        int baslama = 0;
        int bitis = 0;
        int fark = 0;
        int badd = 0;
        int bass = 0;
        int bidd = 0;
        int biss = 0;
      

        if (islem == 0)
        {

            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from tedaviiceriktablosu where tur=" + turList.SelectedValue + "", connect_word);
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

            MySqlCommand cmd = new MySqlCommand("Insert into tedaviiceriktablosu(baslik,icerik,eklenmeTarihi,kapakResmi,videoBaglanti,siteBaglanti,yayin,kategoriler,tur,sira,kisaAd,biliyor,baslama,bitis,fark,baslamad,baslamas,bitisd,bitiss) values (?1,?2,?3,?4,?5,?6,?7,?8,?9,?10,?11,?12,?13,?14,?15,?16,?17,?18,?19)", connect_word);

            cmd.Parameters.AddWithValue("?1", txtBaslik.Text);
            cmd.Parameters.AddWithValue("?2", txtIcerik.Text);
            cmd.Parameters.AddWithValue("?3", DateTime.Now);
            cmd.Parameters.AddWithValue("?4", txtKapak.Value);
            cmd.Parameters.AddWithValue("?5", "");
            cmd.Parameters.AddWithValue("?6", "");
            cmd.Parameters.AddWithValue("?7", yayin.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("?8", secilen);
            cmd.Parameters.AddWithValue("?9", turList.SelectedValue);
            cmd.Parameters.AddWithValue("?10", sirano);
            cmd.Parameters.AddWithValue("?11", GenisletmeMetotlari.ToURL(noc.deveYazimi(txtBaslik.Text)));
            cmd.Parameters.AddWithValue("?12", txtBiliyor.Text);
            cmd.Parameters.AddWithValue("?13", baslama.ToString());
            cmd.Parameters.AddWithValue("?14", bitis.ToString());
            cmd.Parameters.AddWithValue("?15", fark.ToString());
            cmd.Parameters.AddWithValue("?16", "");
            cmd.Parameters.AddWithValue("?17", "");
            cmd.Parameters.AddWithValue("?18", "");
            cmd.Parameters.AddWithValue("?19", "");


            connect_word.Open();
            int eks = cmd.ExecuteNonQuery();
            string soneklenen = cmd.LastInsertedId.ToString();
            connect_word.Close();

            if (eks == 1)
            {
                Response.Redirect("0000074.aspx?ID=" + turList.SelectedValue + "&S=" + soneklenen + "&islem=Y");
                sonuc.Text = "Yazı başarıyla eklendi.";
                sonuc.ForeColor = System.Drawing.Color.Green;

            }
            else
            {
               sonuc.Text = "Yazı ekleme işlemi başarısız!";
               sonuc.ForeColor = System.Drawing.Color.Red;
            }

        }
        else
        {
            sonuc.Text = "Video zamanlamasında hata var.Lütfen kontrol ediniz.";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }





    }
}