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

public partial class administrator_ebebaba_pages_0000006 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            doktor_yukle();


        }

        if (!IsPostBack && Request.QueryString["gdid"]!=null)
        {

            doktor_yukle();
            doktorList.SelectedValue = Request.QueryString["gdid"].ToString();

            yukle();



        } 


    }


    void doktor_yukle()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_id,concat(uye_adi,' ',uye_soyadi) as ad_soyad from uye_doktor order by concat(uye_adi,' ',uye_soyadi) asc ", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);
            doktorList.DataSource = ebebaba_dt;
            doktorList.DataTextField = ebebaba_dt.Columns["ad_soyad"].ColumnName;
            doktorList.DataValueField = ebebaba_dt.Columns["uye_id"].ColumnName;
            doktorList.DataBind();


            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";
            doktorList.Items.Insert(0, yeni);

        }

        catch
        { 
        
        }



    }




    
   
    void kayit_guncelle()
    {


        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlCommand ebebaba_cmd = new MySqlCommand("Update uye_doktor set uye_adi=?1,uye_soyadi=?2,uye_ev_tel=?3,uye_is_tel=?4,uye_cep_tel=?5,uye_email=?6,uye_adres=?7,uye_tip_doktor=?8,uye_tip_admin=?9,ortak_kullanici=?10 where uye_id = "+doktorList.SelectedValue+"", ebebaba_connection);
           
            ebebaba_cmd.Parameters.AddWithValue("?1", doktor_adi.Text.Replace(doktor_adi.Text.TrimStart().Substring(0,1),doktor_adi.Text.TrimStart().ToUpper().Substring(0,1)));
            ebebaba_cmd.Parameters.AddWithValue("?2", doktor_soyadi.Text.ToUpper().TrimEnd().TrimStart().ToString());
            ebebaba_cmd.Parameters.AddWithValue("?3", evtel.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?4", istel.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?5", ceptel.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?6", email.Text.ToString());
            ebebaba_cmd.Parameters.AddWithValue("?7", doktor_adres.Text.ToString());
         
            if (doktoryetki.Checked)
            {
                ebebaba_cmd.Parameters.AddWithValue("?8", "+");
            }
            else
            {
                ebebaba_cmd.Parameters.AddWithValue("?8", "-");

            }
            if (yoneticiyetki.Checked)
            {
                ebebaba_cmd.Parameters.AddWithValue("?9", "+");
                ebebaba_cmd.Parameters.AddWithValue("?10", "+");
            }
            else
            {
                ebebaba_cmd.Parameters.AddWithValue("?9", "-");
                ebebaba_cmd.Parameters.AddWithValue("?10", "-");

            }


           ebebaba_connection.Open();

           int eks = ebebaba_cmd.ExecuteNonQuery();

           ebebaba_connection.Close();

            if (eks == 1)
            {
                panel_sonuc.Visible = true;
                sonuc.Text = "Doktor Kaydý Baþarýyla Güncelleþtirildi.";
                sonuc.ForeColor = System.Drawing.Color.Green;
                doktor_adi.Enabled = false ;
                doktor_soyadi.Enabled=false;
                doktor_adres.Enabled=false;
                evtel.Enabled=false;
                ceptel.Enabled=false;
                istel.Enabled=false;
                email.Enabled=false;
                yoneticiyetki.Enabled = false;
                doktoryetki.Enabled = false;

                btnKaydet.Enabled = false;
      
            }
            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Doktor Kayýt Güncelleme Ýþlemi Gerçekleþemedi !";
                sonuc.ForeColor = System.Drawing.Color.Red ;
            }
        }
        catch
        {
            Exception ex = new Exception();
            
            panel_sonuc.Visible = true;
            sonuc.Text = "Doktor Kaydý Güncelleþtirilirken Bir Hata Oluþtu !";

            sonuc.ForeColor = System.Drawing.Color.Red;

        }




    }





    void yukle()
    {

        try
        {
            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select * from uye_doktor where uye_id=" + doktorList.SelectedValue + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {

               doktor_adi.Text = ebebaba_dt.Rows[0]["uye_adi"].ToString();
                doktor_soyadi.Text = ebebaba_dt.Rows[0]["uye_soyadi"].ToString();
                evtel.Text = ebebaba_dt.Rows[0]["uye_ev_tel"].ToString();
                ceptel.Text = ebebaba_dt.Rows[0]["uye_cep_tel"].ToString();
                istel.Text = ebebaba_dt.Rows[0]["uye_is_tel"].ToString();
                doktor_adres.Text = ebebaba_dt.Rows[0]["uye_adres"].ToString();
                email.Text = ebebaba_dt.Rows[0]["uye_email"].ToString();
                kullanici_adi.Text = ebebaba_dt.Rows[0]["uye_k_adi"].ToString();
                sifre.Text = "******";

                if (ebebaba_dt.Rows[0]["uye_tip_doktor"].ToString() == "+")
                {
                    doktoryetki.Checked = true ;


                }
                else

                {
                    doktoryetki.Checked = false;

                }
                if (ebebaba_dt.Rows[0]["uye_tip_admin"].ToString() == "+")
                {
                    yoneticiyetki.Checked = true;


                }
                else
                {
                    yoneticiyetki.Checked = false;

                }

                btnKaydet.Enabled = true;
                doktor_adi.Enabled = true;
                doktor_soyadi.Enabled = true;
                evtel.Enabled = true;
                istel.Enabled = true;
                doktor_adres.Enabled = true;
                email.Enabled = true;
                doktoryetki.Enabled = true;
                yoneticiyetki.Enabled = true;
                ceptel.Enabled = true;




            }

            else
            {

                panel_sonuc.Visible = true;
                sonuc.Text = "Seçilen Doktor Kaydý Bulunamadý !";

            }



        }
        catch
        {


            panel_sonuc.Visible = true;
            sonuc.Text = "Doktor Kayýt Bilgileri Yüklenirken Hata Oluþtu!";

        }




    }


    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {

        kayit_guncelle();
        doktor_yukle();
    }
    protected void doktorList_SelectedIndexChanged(object sender, EventArgs e)
    {
        panel_sonuc.Visible = false;




        if (doktorList.SelectedIndex == 0)
        {
            btnKaydet.Enabled = false;
            doktor_adi.Enabled = false;
            doktor_soyadi.Enabled = false;
            evtel.Enabled = false;
            istel.Enabled = false;
            doktor_adres.Enabled = false;
            email.Enabled = false;
            doktoryetki.Enabled = false;
            yoneticiyetki.Enabled = false;
            ceptel.Enabled = false;


        }
        else

        {

            btnKaydet.Enabled = true;
            doktor_adi.Enabled = true;
            doktor_soyadi.Enabled = true;
            evtel.Enabled = true;
            istel.Enabled = true;
            doktor_adres.Enabled = true;
            email.Enabled = true;
            doktoryetki.Enabled = true;
            yoneticiyetki.Enabled = true;
            ceptel.Enabled = true;


            
            yukle();
        }
        
    }
}
