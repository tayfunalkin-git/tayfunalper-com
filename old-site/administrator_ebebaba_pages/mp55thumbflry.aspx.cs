using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ivfyonetici_mp55thumb : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();

    protected void Page_Load(object sender, EventArgs e)
    {
       // denetim();


        if (!IsPostBack)
        { hastabilgi();
            yukle();
           
        }
    }


    private void denetim()
    {

        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
        int a = 0;
        if (kullaniciAdiAdmin == "tayfun" || kullaniciAdiAdmin == "ipek")
        {
            a = 1;
        }

        if (a == 0)
        { 
         Response.Redirect("signout.aspx");
        }
        //MySqlConnection connect_word = mp_class.connect_flry(0301009184);
        //MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from uye_doktor where (superAdmin ='+' or muhasebe='+') and  uye_k_adi='" + kullaniciAdiAdmin + "'", connect_word);
        //DataTable dtsub = new DataTable();
        //da3.Fill(dtsub);

        //if (dtsub.Rows.Count != 1)
        //{
           
        //}




    }

    private void hastabilgi()
    {

        MySqlConnection connect_word = mp_class.connect_flry(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select U.uye_id,U.uye_adi,U.uye_soyadi,S.siklus_ay,S.siklus_yil from siklus_ana_tab S,uye_hasta U where U.uye_id=S.hasta_id and S.siklus_id="+Request.QueryString["id"].ToString()+"", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);


        Label1.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
        Label3.Text = dt.Rows[0][0].ToString();
        Label2.Text = dt.Rows[0][3].ToString() + "-" + dt.Rows[0][4].ToString() + " Siklusu";

        Page.Title = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + "/" + dt.Rows[0][3].ToString() + "-" + dt.Rows[0][4].ToString() + " Siklusu";






    }

    private void yukle()
    {

        siklusDr.Items.Clear();
        disDr.Items.Clear();

        MySqlConnection connect_word = mp_class.connect_flry(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select uye_adi,uye_soyadi from uye_doktor where siklusdoktoru='+'", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        for (int m = 0; m < dt.Rows.Count; m++)
        {
            string deger = "";

            if (dt.Rows[m][0].ToString().IndexOf(' ') > 0)
            {
                int snc = dt.Rows[m][0].ToString().LastIndexOf(' ') + 1;
                deger = "" + dt.Rows[m][0].ToString().Substring(snc, 1).ToUpper() + dt.Rows[m][1].ToString().Substring(0, 1).ToUpper();
            }
            else
            {
                deger = "" + dt.Rows[m][0].ToString().Substring(0, 1).ToUpper() + dt.Rows[m][1].ToString().Substring(0, 1).ToUpper();

            }

            ListItem oge = new ListItem();
            oge.Text = deger;
            oge.Value = deger;
            siklusDr.Items.Add(oge);

        }

        ListItem yeni22 = new ListItem();
        yeni22.Text = "Seç/Sil";
        yeni22.Value = "";
        siklusDr.Items.Insert(0, yeni22);

        MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" +  Request.QueryString["id"].ToString() + "", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        if (dt5.Rows.Count > 0)
        {
            if (dt5.Rows[0]["dr"].ToString() == "")
            {

                siklusDr.SelectedIndex = 0;
                lblSiklusDr.Text = "Seç/Sil";
            }
            else
            {
                siklusDr.SelectedValue = dt5.Rows[0]["dr"].ToString().Substring(4, 2);
                lblSiklusDr.Text = dt5.Rows[0]["dr"].ToString().Substring(4, 2);
            }

        }

        MySqlDataAdapter dam = new MySqlDataAdapter("Select kisaAd,uye_id from uye_doktor where disdoktor='+' and not kisaAd='' order by kisaAd asc", connect_word);
        DataTable dtm = new DataTable();
        dam.Fill(dtm);

        for (int n = 0; n < dtm.Rows.Count; n++)
        {
            ListItem oge = new ListItem();
            oge.Text = dtm.Rows[n][0].ToString();
            oge.Value = dtm.Rows[n][1].ToString();
            disDr.Items.Add(oge);
        }

        ListItem yeni22m = new ListItem();
        yeni22m.Text = "Seç/Sil";
        yeni22m.Value = "";
        disDr.Items.Insert(0, yeni22m);

        MySqlDataAdapter da55 = new MySqlDataAdapter("Select U.uye_id from uye_doktor U,atama A where A.doktorID=U.uye_id and A.siklusID=" + Request.QueryString["id"].ToString() + "", connect_word);
        DataTable dt55 = new DataTable();
        da55.Fill(dt55);

        if (dt55.Rows.Count == 0)
        {
            disDr.SelectedIndex = 0;
            lblDisDr.Text = "Seç/Sil";
        }
        else
        {
            disDr.SelectedValue = dt55.Rows[0][0].ToString();
            lblDisDr.Text = disDr.SelectedItem.Text;
        }



        MySqlDataAdapter da555 = new MySqlDataAdapter("Select txt78,txt79,txt80,txt81,deger from labProtokol where siklusID=" + Request.QueryString["id"].ToString() + "", connect_word);
        DataTable dt555 = new DataTable();
        da555.Fill(dt555);

        if (dt555.Rows.Count != 0)
        {
            txtCp.Text = dt555.Rows[0][0].ToString();
            txtBat.Text = dt555.Rows[0][1].ToString();
            txtBit.Text = dt555.Rows[0][2].ToString();
            txtKt.Text = dt555.Rows[0][3].ToString();
            txtDeger.Text = dt555.Rows[0][4].ToString();

            lblCp.Text = dt555.Rows[0][0].ToString();
            lblBat.Text = dt555.Rows[0][1].ToString();
            lblBit.Text = dt555.Rows[0][2].ToString();
            lblKt.Text = dt555.Rows[0][3].ToString();
            lblDeger.Text = dt555.Rows[0][4].ToString();

            Button1.Enabled = true;

        }

            }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        MySqlConnection connect_word = mp_class.connect_flry(0301009184);
        if (disDr.SelectedIndex != 0)
        {

            MySqlDataAdapter da22 = new MySqlDataAdapter("Select * from atama where siklusID=" + Request.QueryString["id"].ToString() + "", connect_word);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);

            if (dt22.Rows.Count == 1)
            {
                MySqlCommand mp_cmd = new MySqlCommand("Update atama set doktorID=?1 where siklusID=?2", connect_word);
                mp_cmd.Parameters.AddWithValue("?1", disDr.SelectedValue.ToString());
                mp_cmd.Parameters.AddWithValue("?2", Request.QueryString["id"].ToString());
                connect_word.Open();
                int eks2 = mp_cmd.ExecuteNonQuery();
                connect_word.Close();

            }
            else
            {

                MySqlCommand mp_cmd = new MySqlCommand("Insert into atama(hastaID,doktorID,siklusID) values (?1,?2,?3)", connect_word);
                mp_cmd.Parameters.AddWithValue("?1", Label3.Text);
                mp_cmd.Parameters.AddWithValue("?2", disDr.SelectedValue.ToString());
                mp_cmd.Parameters.AddWithValue("?3", Request.QueryString["id"].ToString());
                connect_word.Open();
                int eks2 = mp_cmd.ExecuteNonQuery();
                connect_word.Close();

            }
        }
        else
        {
            MySqlCommand mp_cmd = new MySqlCommand("Delete from atama where siklusID=?2", connect_word);

            mp_cmd.Parameters.AddWithValue("?2", Request.QueryString["id"].ToString());
            connect_word.Open();
            int eks2 = mp_cmd.ExecuteNonQuery();
            connect_word.Close();


        }



        if (siklusDr.SelectedIndex != 0)
        {

            MySqlCommand mp_cmd = new MySqlCommand("Update kisa_siklus set dr=?1,alan8=?2 where siklus_id=?4", connect_word);
            mp_cmd.Parameters.AddWithValue("?1", "Dr. " + siklusDr.SelectedValue.ToString());
            mp_cmd.Parameters.AddWithValue("?2", txtBat.Text);
            mp_cmd.Parameters.AddWithValue("?4", Request.QueryString["id"].ToString());
            connect_word.Open();
            int eks5 = mp_cmd.ExecuteNonQuery();
            connect_word.Close();
        }
        else
        {
            MySqlCommand mp_cmd = new MySqlCommand("Update kisa_siklus set dr=?1,alan8=?2 where siklus_id=?4", connect_word);
            mp_cmd.Parameters.AddWithValue("?1", "");
            mp_cmd.Parameters.AddWithValue("?2", txtBat.Text);
            mp_cmd.Parameters.AddWithValue("?4", Request.QueryString["id"].ToString());
            connect_word.Open();
            int eks5 = mp_cmd.ExecuteNonQuery();
            connect_word.Close();
        }

        MySqlDataAdapter da555 = new MySqlDataAdapter("Select * from labProtokol where siklusID=" + Request.QueryString["id"].ToString() + "", connect_word);
        DataTable dt555 = new DataTable();
        da555.Fill(dt555);

        if (dt555.Rows.Count != 0)
        {

            MySqlCommand cmd = new MySqlCommand("Update labProtokol set txt78=?1,txt79=?2,txt80=?3,txt81=?4,deger=?6 where siklusID=?5", connect_word);

            cmd.Parameters.AddWithValue("?1", txtCp.Text);
            cmd.Parameters.AddWithValue("?2", txtBat.Text);
            cmd.Parameters.AddWithValue("?3", txtBit.Text);
            cmd.Parameters.AddWithValue("?4", txtKt.Text);
            cmd.Parameters.AddWithValue("?6", txtDeger.Text);
            cmd.Parameters.AddWithValue("?5", Request.QueryString["id"].ToString());

            connect_word.Open();
            int eks54 = cmd.ExecuteNonQuery();
            connect_word.Close();
        }
        else
        {

            MySqlCommand cmd = new MySqlCommand("Insert into labProtokol(siklusID,txt78,txt79,txt80,txt81,deger) values (?1,?2,?3,?4,?5,?6)", connect_word);

            cmd.Parameters.AddWithValue("?1", Request.QueryString["id"].ToString());
            cmd.Parameters.AddWithValue("?2", txtCp.Text);
            cmd.Parameters.AddWithValue("?3", txtBat.Text);
            cmd.Parameters.AddWithValue("?4", txtBit.Text);
            cmd.Parameters.AddWithValue("?5", txtKt.Text);
            cmd.Parameters.AddWithValue("?6", txtDeger.Text);
            

            connect_word.Open();
            int eks54 = cmd.ExecuteNonQuery();
            connect_word.Close();
        
        
        
        }

        
        string logKayit = "";

        if (lblDisDr.Text != disDr.SelectedItem.Text)
        {
            logKayit = logKayit + "Dış Dr:" + disDr.SelectedItem.Text + " , ";
        }
        if (lblSiklusDr.Text != siklusDr.SelectedItem.Text)
        {
            logKayit = logKayit + "Siklus Dr:" + siklusDr.SelectedItem.Text + " , ";
        }
        if (lblCp.Text != txtCp.Text)
        {
            logKayit = logKayit + "Ç.Protol Kodu:" + txtCp.Text + " , ";
        }
        if (lblBat.Text != txtBat.Text)
        {
            logKayit = logKayit + "Baş. Tarihi:" + txtBat.Text + " , ";
        }
        if (lblBit.Text != txtBit.Text)
        {
            logKayit = logKayit + "Bit. Tarihi:" + txtBit.Text + " , ";
        }
        if (lblKt.Text != txtKt.Text)
        {
            logKayit = logKayit + "Kayıt Tarihi:" + txtKt.Text + " , ";
        }

        if (lblDeger.Text != txtDeger.Text)
        {
            logKayit = logKayit + "Değer:" + txtDeger.Text + " , ";
        }

        if (logKayit == "")
        {
            logKayit = Label1.Text + " ("+ Label2.Text + ") --> Değişiklik yapmadan olduğu gibi güncellendi. (Lokasyon: Tüm OPU)";
        }
        else
        { 
         int son = logKayit.LastIndexOf(',');
        string bol = logKayit.Substring(0, son);
        logKayit = Label1.Text + " ("+ Label2.Text + ") --> "+ bol + " olarak değiştirildi. (Lokasyon: Tüm OPU)";

        }
       
        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

        string doktorAdi = mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin);

            MySqlCommand mp_cmd2 = new MySqlCommand("insert into calismaLog(kullaniciAdi,islem,tarih) values (?1,?2,?3)", connect_word);
            mp_cmd2.Parameters.AddWithValue("?1", doktorAdi);
            mp_cmd2.Parameters.AddWithValue("?2", logKayit);
            mp_cmd2.Parameters.AddWithValue("?3", DateTime.Now.ToString());

            connect_word.Open();
            int eks = mp_cmd2.ExecuteNonQuery();
            connect_word.Close();


            if (eks == 1)
            {

                yukle();

                Label4.Text = "İşlem Başarıyla Gerçekleşti";
                Label4.ForeColor = System.Drawing.Color.Green;

                siklusDr.Enabled = false;
                disDr.Enabled = false;
                txtBat.Enabled = false;
                txtBit.Enabled = false;
                txtCp.Enabled = false;
                txtKt.Enabled = false;
                txtDeger.Enabled = false;
                Button1.Enabled = false;
                Button2.Visible = true;



            }
            else
            {
                Label4.Text = "İşlem Başarısız !";
                Label4.ForeColor = System.Drawing.Color.Red;
                Button2.Visible = true;
            }




    }
}