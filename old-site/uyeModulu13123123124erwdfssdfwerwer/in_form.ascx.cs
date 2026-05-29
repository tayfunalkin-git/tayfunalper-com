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

public partial class ivfyonetici_hasta_modulu_in_form : System.Web.UI.UserControl
{
    ivf_class mp_class = new ivf_class();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            siklus_hazirlama_metodlari();
            doktorlar();
            katater();
            ongoing();
            gebelik();
            transfer_medyumu();
            kultur_medyumu();
            embriyologlar();
            transfer_ozelligi();
            ilac();
            pipet();
            siklus_tipi();
            endikasyonlar();

            durumKontrol();

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da22 = new MySqlDataAdapter("Select baslangic from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"] + "", connect_word);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);

            if (dt22.Rows[0]["baslangic"].ToString() == "+")
            {

                form.Visible = false;

            }
            else
            {
                form.Visible = true;
            }


            kutularKapali();

            Button1.Visible = false;
            d_kaydet.Visible = false;
            ipt.Visible = false;
            btnKaydet.Visible = false;
            Button2.Visible = false;
        }
    }

    private void durumKontrol()
    {

        HttpCookie islemdekihastasm = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihastasm["HastaID"];

        string siklus_id = Request.QueryString["siklus_id"].ToString();
        string hastaAdi = mp_class.hasta_adi_bul(hasta_id);

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + siklus_id + "", mp_connection);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        string siklusAdi = dt5.Rows[0]["siklus_ay"] + " - " + dt5.Rows[0]["siklus_yil"].ToString();
        lblHastaAdi.Text = hastaAdi;
        lblHastaID.Text = hasta_id;
        lblSiklusAdi.Text = siklusAdi;
        lblSiklusID.Text = siklus_id;
        lblSiklusTarihi.Text = dt5.Rows[0]["siklus_eklenme_tarihi"].ToString();
        lblSiklusAy.Text = dt5.Rows[0]["siklus_ay2"].ToString();
        lblSiklusYil.Text = dt5.Rows[0]["siklus_yil"].ToString();

        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from labsonuc where hastaID=" + hasta_id + " and siklusID=" + siklus_id + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows.Count == 0)
        {
            durum.Text = hastaAdi + " Adlı Hastanın " + siklusAdi + " Siklusuna Henüz Form Girişi Yapılmadı!";
            durum.ForeColor = System.Drawing.Color.Red;
            
            Panel4.Visible = true;
            kutularAcik();
            Button2.Visible = false;
            Button1.Visible = true;
            btnKaydet.Visible = false;
            d_kaydet.Visible = true;

        }
        else if (mp_dt.Rows.Count == 1)
        {
            durum.Text = hastaAdi + " Adlı Hastanın " + siklusAdi + " Siklusuna " + mp_dt.Rows[0]["tarih"].ToString() + " Tarihinde Girişi Yapılan Veriler Aşağıda Listelenmiştir.";
            durum.ForeColor = System.Drawing.Color.Green;
            Panel4.Visible = true;
            kutularKapali();
            verileriYukle();

        }




    }

    private void verileriYukle()
    {
        Button1.Visible = false; btnKaydet.Visible = true;
        Button2.Visible = true; d_kaydet.Visible = false;
        
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from labsonuc where siklusID="+Request.QueryString["siklus_id"].ToString() +"", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        lbl1.Text = mp_dt.Rows[0]["txt1"].ToString();
        lbl2.Text = mp_dt.Rows[0]["txt2"].ToString();
        lbl3.Text = mp_dt.Rows[0]["txt3"].ToString();
        lbl4.Text = mp_dt.Rows[0]["txt4"].ToString();
        lbl5.Text = mp_dt.Rows[0]["txt5"].ToString();
        lbl6.Text = mp_dt.Rows[0]["txt6"].ToString();
        lbl7.Text = mp_dt.Rows[0]["txt7"].ToString();
        lbl8.Text = mp_dt.Rows[0]["txt8"].ToString();
        lbl9.Text = mp_dt.Rows[0]["txt9"].ToString();
        lbl10.Text = mp_dt.Rows[0]["txt10"].ToString();
        lbl11.Text = mp_dt.Rows[0]["txt11"].ToString();
        lbl12.Text = mp_dt.Rows[0]["txt12"].ToString();
        lbl13.Text = mp_dt.Rows[0]["txt13"].ToString();

        if (txt14.Items.FindByValue(mp_dt.Rows[0]["txt14"].ToString()).Value != "")
        {
            lbl14.Text = txt14.Items.FindByValue(mp_dt.Rows[0]["txt14"].ToString()).Text;
        }
        
        lbl15.Text = mp_dt.Rows[0]["txt15"].ToString();
        lbl16.Text = mp_dt.Rows[0]["txt16"].ToString();
        lbl17.Text = mp_dt.Rows[0]["txt17"].ToString();
        lbl18.Text = mp_dt.Rows[0]["txt18"].ToString();
        lbl19.Text = mp_dt.Rows[0]["txt19"].ToString();
        lbl20.Text = mp_dt.Rows[0]["txt20"].ToString();
        lbl21.Text = mp_dt.Rows[0]["txt21"].ToString();
        if (txt22.Items.FindByValue(mp_dt.Rows[0]["txt22"].ToString()).Value != "")
        {
            lbl22.Text = txt22.Items.FindByValue(mp_dt.Rows[0]["txt22"].ToString()).Text;
        }
        lbl23.Text = mp_dt.Rows[0]["txt23"].ToString();
      
        lbl25.Text = mp_dt.Rows[0]["txt25"].ToString();
        if (txt26.Items.FindByValue(mp_dt.Rows[0]["txt26"].ToString()).Value != "")
        {
            lbl26.Text = txt26.Items.FindByValue(mp_dt.Rows[0]["txt26"].ToString()).Text;
        }
        if (txt27.Items.FindByValue(mp_dt.Rows[0]["txt27"].ToString()).Value != "")
        {
            lbl27.Text = txt27.Items.FindByValue(mp_dt.Rows[0]["txt27"].ToString()).Text;
        }
        if (txt28.Items.FindByValue(mp_dt.Rows[0]["txt28"].ToString()).Value != "")
        {
            lbl28.Text = txt28.Items.FindByValue(mp_dt.Rows[0]["txt28"].ToString()).Text;
        }
        if (txt29.Items.FindByValue(mp_dt.Rows[0]["txt29"].ToString()).Value != "")
        {
            lbl29.Text = txt29.Items.FindByValue(mp_dt.Rows[0]["txt29"].ToString()).Text;
        }

        lbl30.Text = mp_dt.Rows[0]["txt30"].ToString();
        if (txt31.Items.FindByValue(mp_dt.Rows[0]["txt31"].ToString()).Value != "")
        {
            lbl31.Text = txt31.Items.FindByValue(mp_dt.Rows[0]["txt31"].ToString()).Text;
        }
        lbl33.Text = mp_dt.Rows[0]["txt33"].ToString();
        lbl77.Text = mp_dt.Rows[0]["txt77"].ToString();
        if (txt34.Items.FindByValue(mp_dt.Rows[0]["txt34"].ToString()).Value != "")
        {
            lbl34.Text = txt34.Items.FindByValue(mp_dt.Rows[0]["txt34"].ToString()).Text;
        }
      
        lbl36.Text = mp_dt.Rows[0]["txt36"].ToString();
        if (txt37.Items.FindByValue(mp_dt.Rows[0]["txt37"].ToString()).Value != "")
        {
            lbl37.Text = txt37.Items.FindByValue(mp_dt.Rows[0]["txt37"].ToString()).Text;
        }
        lbl38.Text = mp_dt.Rows[0]["txt38"].ToString();
        if (txt39.Items.FindByValue(mp_dt.Rows[0]["txt39"].ToString()).Value != "")
        {
            lbl39.Text = txt39.Items.FindByValue(mp_dt.Rows[0]["txt39"].ToString()).Text;
        }
        lbl40.Text = mp_dt.Rows[0]["txt40"].ToString();
        if (txt41.Items.FindByValue(mp_dt.Rows[0]["txt41"].ToString()).Value != "")
        {
            lbl41.Text = txt41.Items.FindByValue(mp_dt.Rows[0]["txt41"].ToString()).Text;
        }
        lbl42.Text = mp_dt.Rows[0]["txt42"].ToString();
        lbl43.Text = mp_dt.Rows[0]["txt43"].ToString();
      
        lbl45.Text = mp_dt.Rows[0]["txt45"].ToString();
        lbl46.Text = mp_dt.Rows[0]["txt46"].ToString();
        lbl47.Text = mp_dt.Rows[0]["txt47"].ToString();
      
        lbl50.Text = mp_dt.Rows[0]["txt50"].ToString();
        lbl51.Text = mp_dt.Rows[0]["txt51"].ToString();
        lbl52.Text = mp_dt.Rows[0]["txt52"].ToString();
        lbl53.Text = mp_dt.Rows[0]["txt53"].ToString();
        lbl54.Text = mp_dt.Rows[0]["txt54"].ToString();
        lbl55.Text = mp_dt.Rows[0]["txt55"].ToString();
        lbl56.Text = mp_dt.Rows[0]["txt56"].ToString();
        lbl57.Text = mp_dt.Rows[0]["txt57"].ToString();
        lbl58.Text = mp_dt.Rows[0]["txt58"].ToString();
        lbl59.Text = mp_dt.Rows[0]["txt59"].ToString();
        lbl60.Text = mp_dt.Rows[0]["txt60"].ToString();
        lbl61.Text = mp_dt.Rows[0]["txt61"].ToString();
        lbl62.Text = mp_dt.Rows[0]["txt62"].ToString();
        lbl63.Text = mp_dt.Rows[0]["txt63"].ToString();
        lbl64.Text = mp_dt.Rows[0]["txt64"].ToString();
        lbl65.Text = mp_dt.Rows[0]["txt65"].ToString();
        lbl66.Text = mp_dt.Rows[0]["txt66"].ToString();
        lbl67.Text = mp_dt.Rows[0]["txt67"].ToString();
        lbl68.Text = mp_dt.Rows[0]["txt68"].ToString();
        lbl69.Text = mp_dt.Rows[0]["txt69"].ToString();
        lbl70.Text = mp_dt.Rows[0]["txt70"].ToString();
        lbl71.Text = mp_dt.Rows[0]["txt71"].ToString();
        lbl72.Text = mp_dt.Rows[0]["txt72"].ToString();
        lbl73.Text = mp_dt.Rows[0]["txt73"].ToString();
        lbl74.Text = mp_dt.Rows[0]["txt74"].ToString();
        lbl75.Text = mp_dt.Rows[0]["txt75"].ToString();
        lbl76.Text = mp_dt.Rows[0]["txt76"].ToString();


        txt1.Text = mp_dt.Rows[0]["txt1"].ToString();
        txt2.Text = mp_dt.Rows[0]["txt2"].ToString();
        txt3.Text = mp_dt.Rows[0]["txt3"].ToString();
        txt4.Text = mp_dt.Rows[0]["txt4"].ToString();
        txt5.Text = mp_dt.Rows[0]["txt5"].ToString();
        txt6.Text = mp_dt.Rows[0]["txt6"].ToString();
        txt7.Text = mp_dt.Rows[0]["txt7"].ToString();
        txt8.Text = mp_dt.Rows[0]["txt8"].ToString();
        txt9.Text = mp_dt.Rows[0]["txt9"].ToString();
        txt10.Text = mp_dt.Rows[0]["txt10"].ToString();
        txt11.Text = mp_dt.Rows[0]["txt11"].ToString();
        txt12.Text = mp_dt.Rows[0]["txt12"].ToString();
        txt13.Text = mp_dt.Rows[0]["txt13"].ToString();
        txt14.SelectedValue = mp_dt.Rows[0]["txt14"].ToString();
        txt15.Text = mp_dt.Rows[0]["txt15"].ToString();
        txt16.Text = mp_dt.Rows[0]["txt16"].ToString();
        txt17.Text = mp_dt.Rows[0]["txt17"].ToString();
        txt18.Text = mp_dt.Rows[0]["txt18"].ToString();
        txt19.Text = mp_dt.Rows[0]["txt19"].ToString();
        txt20.Text = mp_dt.Rows[0]["txt20"].ToString();
        txt21.Text = mp_dt.Rows[0]["txt21"].ToString();
        txt22.SelectedValue = mp_dt.Rows[0]["txt22"].ToString();
        txt23.Text = mp_dt.Rows[0]["txt23"].ToString();
      
        txt25.Text = mp_dt.Rows[0]["txt25"].ToString();
        txt26.SelectedValue = mp_dt.Rows[0]["txt26"].ToString();
        txt27.SelectedValue = mp_dt.Rows[0]["txt27"].ToString();
        txt28.SelectedValue = mp_dt.Rows[0]["txt28"].ToString();
        txt29.SelectedValue = mp_dt.Rows[0]["txt29"].ToString();
        txt30.Text = mp_dt.Rows[0]["txt30"].ToString();
        txt31.SelectedValue = mp_dt.Rows[0]["txt31"].ToString();
       
        txt33.Text = mp_dt.Rows[0]["txt33"].ToString();
        txt77.Text = mp_dt.Rows[0]["txt77"].ToString();
        txt34.SelectedValue = mp_dt.Rows[0]["txt34"].ToString();
       
        txt36.Text = mp_dt.Rows[0]["txt36"].ToString();
        txt37.SelectedValue = mp_dt.Rows[0]["txt37"].ToString();
        txt38.Text = mp_dt.Rows[0]["txt38"].ToString();
        txt39.SelectedValue = mp_dt.Rows[0]["txt39"].ToString();
        txt40.Text = mp_dt.Rows[0]["txt40"].ToString();
        txt41.SelectedValue = mp_dt.Rows[0]["txt41"].ToString();
        txt42.Text = mp_dt.Rows[0]["txt42"].ToString();
        txt43.Text = mp_dt.Rows[0]["txt43"].ToString();
    
        txt45.Text = mp_dt.Rows[0]["txt45"].ToString();
        txt46.Text = mp_dt.Rows[0]["txt46"].ToString();
        txt47.Text = mp_dt.Rows[0]["txt47"].ToString();
       
        txt50.Text = mp_dt.Rows[0]["txt50"].ToString();
        txt51.Text = mp_dt.Rows[0]["txt51"].ToString();
        txt52.Text = mp_dt.Rows[0]["txt52"].ToString();
        txt53.Text = mp_dt.Rows[0]["txt53"].ToString();
        txt54.Text = mp_dt.Rows[0]["txt54"].ToString();
        txt55.Text = mp_dt.Rows[0]["txt55"].ToString();
        txt56.Text = mp_dt.Rows[0]["txt56"].ToString();
        txt57.Text = mp_dt.Rows[0]["txt57"].ToString();
        txt58.Text = mp_dt.Rows[0]["txt58"].ToString();
        txt59.Text = mp_dt.Rows[0]["txt59"].ToString();
        txt60.Text = mp_dt.Rows[0]["txt60"].ToString();
        txt61.Text = mp_dt.Rows[0]["txt61"].ToString();
        txt62.Text = mp_dt.Rows[0]["txt62"].ToString();
        txt63.Text = mp_dt.Rows[0]["txt63"].ToString();
        txt64.Text = mp_dt.Rows[0]["txt64"].ToString();
        txt65.Text = mp_dt.Rows[0]["txt65"].ToString();
        txt66.Text = mp_dt.Rows[0]["txt66"].ToString();
        txt67.Text = mp_dt.Rows[0]["txt67"].ToString();
        txt68.Text = mp_dt.Rows[0]["txt68"].ToString();
        txt69.Text = mp_dt.Rows[0]["txt69"].ToString();
        txt70.Text = mp_dt.Rows[0]["txt70"].ToString();
        txt71.Text = mp_dt.Rows[0]["txt71"].ToString();
        txt72.Text = mp_dt.Rows[0]["txt72"].ToString();
        txt73.Text = mp_dt.Rows[0]["txt73"].ToString();
        txt74.Text = mp_dt.Rows[0]["txt74"].ToString();
        txt75.Text = mp_dt.Rows[0]["txt75"].ToString();
        txt76.Text = mp_dt.Rows[0]["txt76"].ToString();


        lbl24.Text = "";
        lbl32.Text = "";
        lbl35.Text = "";
        lbl48.Text = "";
        lbl49.Text = "";
        lbl44.Text = "";

        if (mp_dt.Rows[0]["txt24"].ToString() != "" && mp_dt.Rows[0]["txt24"].ToString().Split('-').Length > 0)
        {

            txt24.Items[0].Selected = false;
            for (int a = 0; a < mp_dt.Rows[0]["txt24"].ToString().Split('-').Length; a++)
            {
                if (mp_dt.Rows[0]["txt24"].ToString().Split('-')[a].ToString() != "")
                {
                    txt24.Items.FindByValue(mp_dt.Rows[0]["txt24"].ToString().Split('-')[a].ToString()).Selected = true;
                    lbl24.Text += txt24.Items.FindByValue(mp_dt.Rows[0]["txt24"].ToString().Split('-')[a].ToString()).Text + "-";
                }
            }

            if (lbl24.Text != "")
            {
                lbl24.Text = lbl24.Text.Remove(lbl24.Text.Length - 1, 1);
            }
        }
        else if (mp_dt.Rows[0]["txt24"].ToString().TrimStart().TrimEnd() == "")
        {
            txt24.Items[0].Selected = true;
        }
        if (mp_dt.Rows[0]["txt32"].ToString() != "" && mp_dt.Rows[0]["txt32"].ToString().Split('-').Length > 0)
        {

            txt32.Items[0].Selected = false;
            for (int a = 0; a < mp_dt.Rows[0]["txt32"].ToString().Split('-').Length; a++)
            {

                if (mp_dt.Rows[0]["txt32"].ToString().Split('-')[a].ToString() != "")
                {
                    txt32.Items.FindByValue(mp_dt.Rows[0]["txt32"].ToString().Split('-')[a].ToString()).Selected = true;
                    lbl32.Text += txt32.Items.FindByValue(mp_dt.Rows[0]["txt32"].ToString().Split('-')[a].ToString()).Text + "-";
                }
            }
            if (lbl32.Text != "")
            {
                lbl32.Text = lbl32.Text.Remove(lbl32.Text.Length - 1, 1);
            }

        }
        else if (mp_dt.Rows[0]["txt32"].ToString().TrimStart().TrimEnd() == "")
        {
            txt32.Items[0].Selected = true;
        }

        if (mp_dt.Rows[0]["txt35"].ToString() != "" && mp_dt.Rows[0]["txt35"].ToString().Split('-').Length > 0)
        {

            txt35.Items[0].Selected = false;
            for (int a = 0; a < mp_dt.Rows[0]["txt35"].ToString().Split('-').Length; a++)
            {

                if (mp_dt.Rows[0]["txt35"].ToString().Split('-')[a].ToString() != "")
                {
                    txt35.Items.FindByValue(mp_dt.Rows[0]["txt35"].ToString().Split('-')[a].ToString()).Selected = true;
                    lbl35.Text += txt35.Items.FindByValue(mp_dt.Rows[0]["txt35"].ToString().Split('-')[a].ToString()).Text + "-";
                }
            }
            if (lbl35.Text != "")
            {
                lbl35.Text = lbl35.Text.Remove(lbl35.Text.Length - 1, 1);
            }

        }
        else if (mp_dt.Rows[0]["txt35"].ToString().TrimStart().TrimEnd() == "")
        {
            txt35.Items[0].Selected = true;
        
        }

        if (mp_dt.Rows[0]["txt44"].ToString() != "" && mp_dt.Rows[0]["txt44"].ToString().Split('-').Length > 0)
        {

            txt44.Items[0].Selected = false;
            for (int a = 0; a < mp_dt.Rows[0]["txt44"].ToString().Split('-').Length; a++)
            {

                if (mp_dt.Rows[0]["txt44"].ToString().Split('-')[a].ToString() != "")
                {
                    txt44.Items.FindByValue(mp_dt.Rows[0]["txt44"].ToString().Split('-')[a].ToString()).Selected = true;
                    lbl44.Text += txt44.Items.FindByValue(mp_dt.Rows[0]["txt44"].ToString().Split('-')[a].ToString()).Text + "-";
                }
            }
            if (lbl44.Text != "")
            {
                lbl44.Text = lbl44.Text.Remove(lbl44.Text.Length - 1, 1);
            }
        }
        else if (mp_dt.Rows[0]["txt44"].ToString().TrimStart().TrimEnd() == "")
        {

            txt44.Items[0].Selected = true;
        }


        if (mp_dt.Rows[0]["txt48"].ToString() != "" && mp_dt.Rows[0]["txt48"].ToString().Split('-').Length > 0)
        {

            txt48.Items[0].Selected = false;
            for (int a = 0; a < mp_dt.Rows[0]["txt48"].ToString().Split('-').Length; a++)
            {

                if (mp_dt.Rows[0]["txt48"].ToString().Split('-')[a].ToString() != "")
                {
                    txt48.Items.FindByValue(mp_dt.Rows[0]["txt48"].ToString().Split('-')[a].ToString()).Selected = true;
                    lbl48.Text += txt48.Items.FindByValue(mp_dt.Rows[0]["txt48"].ToString().Split('-')[a].ToString()).Text + "-";
                }
            }
            if (lbl48.Text != "")
            {
                lbl48.Text = lbl48.Text.Remove(lbl48.Text.Length - 1, 1);
            }
        }

        else if (mp_dt.Rows[0]["txt48"].ToString().TrimStart().TrimEnd() == "")
        {
            txt48.Items[0].Selected = true;
        
        
        }
        if (mp_dt.Rows[0]["txt49"].ToString() != "" && mp_dt.Rows[0]["txt49"].ToString().Split('-').Length > 0)
        {

            txt49.Items[0].Selected = false;
            for (int a = 0; a < mp_dt.Rows[0]["txt49"].ToString().Split('-').Length; a++)
            {

                if (mp_dt.Rows[0]["txt49"].ToString().Split('-')[a].ToString() != "")
                {
                    txt49.Items.FindByValue(mp_dt.Rows[0]["txt49"].ToString().Split('-')[a].ToString()).Selected = true;
                    lbl49.Text += txt49.Items.FindByValue(mp_dt.Rows[0]["txt49"].ToString().Split('-')[a].ToString()).Text + "-";
                }
            }
            if (lbl49.Text != "")
            {
                lbl49.Text = lbl49.Text.Remove(lbl49.Text.Length - 1, 1);
            }
        }
        else if (mp_dt.Rows[0]["txt49"].ToString().TrimStart().TrimEnd() == "")
        {

            txt49.Items[0].Selected = true;
        
        }
    }

    private void endikasyonlar()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=7 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt48.DataSource = mp_dt;
        txt48.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt48.DataValueField = mp_dt.Columns["kod"].ToString();
        txt48.DataBind();

        txt49.DataSource = mp_dt;
        txt49.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt49.DataValueField = mp_dt.Columns["kod"].ToString();
        txt49.DataBind();



        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt48.Items.Insert(0, yeni);
        txt49.Items.Insert(0, yeni);
    }

    private void siklus_tipi()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=8 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt44.DataSource = mp_dt;
        txt44.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt44.DataValueField = mp_dt.Columns["kod"].ToString();
        txt44.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt44.Items.Insert(0, yeni);
    }

    private void gebelik()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=14 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt37.DataSource = mp_dt;
        txt37.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt37.DataValueField = mp_dt.Columns["kod"].ToString();
        txt37.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt37.Items.Insert(0, yeni);
    }
    private void ongoing()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=15 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt39.DataSource = mp_dt;
        txt39.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt39.DataValueField = mp_dt.Columns["kod"].ToString();
        txt39.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt39.Items.Insert(0, yeni);
    }

    private void pipet()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=11 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt41.DataSource = mp_dt;
        txt41.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt41.DataValueField = mp_dt.Columns["kod"].ToString();
        txt41.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt41.Items.Insert(0, yeni);
    }

    private void ilac()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=6 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt35.DataSource = mp_dt;
        txt35.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt35.DataValueField = mp_dt.Columns["kod"].ToString();
        txt35.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt35.Items.Insert(0, yeni);
    }

    private void transfer_ozelligi()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=12 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt32.DataSource = mp_dt;
        txt32.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt32.DataValueField = mp_dt.Columns["kod"].ToString();
        txt32.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt32.Items.Insert(0, yeni);
    }

    private void embriyologlar()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=1 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt27.DataSource = mp_dt;
        txt27.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt27.DataValueField = mp_dt.Columns["kod"].ToString();
        txt27.DataBind();

        txt28.DataSource = mp_dt;
        txt28.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt28.DataValueField = mp_dt.Columns["kod"].ToString();
        txt28.DataBind();

        txt34.DataSource = mp_dt;
        txt34.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt34.DataValueField = mp_dt.Columns["kod"].ToString();
        txt34.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt27.Items.Insert(0, yeni);
        txt28.Items.Insert(0, yeni);
        txt34.Items.Insert(0, yeni);

    }

    private void doktorlar()
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=2 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt22.DataSource = mp_dt;
        txt22.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt22.DataValueField = mp_dt.Columns["kod"].ToString();
        txt22.DataBind();

        txt29.DataSource = mp_dt;
        txt29.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt29.DataValueField = mp_dt.Columns["kod"].ToString();
        txt29.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt22.Items.Insert(0, yeni);
        txt29.Items.Insert(0, yeni);


    }

    private void transfer_medyumu()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=4 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt26.DataSource = mp_dt;
        txt26.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt26.DataValueField = mp_dt.Columns["kod"].ToString();
        txt26.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt26.Items.Insert(0, yeni);
    }
    private void kultur_medyumu()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=16 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt31.DataSource = mp_dt;
        txt31.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt31.DataValueField = mp_dt.Columns["kod"].ToString();
        txt31.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt31.Items.Insert(0, yeni);
    }
    private void katater()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=10 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt24.DataSource = mp_dt;
        txt24.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt24.DataValueField = mp_dt.Columns["kod"].ToString();
        txt24.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt24.Items.Insert(0, yeni);
    }

    private void siklus_hazirlama_metodlari()
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kodlar where kategori=5 order by kod asc", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        txt14.DataSource = mp_dt;
        txt14.DataTextField = mp_dt.Columns["degisken"].ToString();
        txt14.DataValueField = mp_dt.Columns["kod"].ToString();
        txt14.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        txt14.Items.Insert(0, yeni);

    }

    private void kutularAcik()
    {
        LinkButton3.Visible = true;

        txt1.Visible = true;
        txt2.Visible = true;
        txt3.Visible = true;
        txt4.Visible = true;
        txt5.Visible = true;
        txt6.Visible = true;
        txt7.Visible = true;
        txt8.Visible = true;
        txt9.Visible = true;
        txt10.Visible = true;
        txt11.Visible = true;
        txt12.Visible = true;
        txt13.Visible = true;
        txt14.Visible = true;
        txt15.Visible = true;
        txt16.Visible = true;
        txt17.Visible = true;
        txt18.Visible = true;
        txt19.Visible = true;
        txt20.Visible = true;
        txt21.Visible = true;
        txt22.Visible = true;
        txt23.Visible = true;
        txt24.Visible = true;
        txt25.Visible = true;
        txt26.Visible = true;
        txt27.Visible = true;
        txt28.Visible = true;
        txt29.Visible = true;
        txt30.Visible = true;
        txt31.Visible = true;
        txt32.Visible = true;
        txt33.Visible = true;
        txt77.Visible = true;
        txt34.Visible = true;
        txt35.Visible = true;
        txt36.Visible = true;
        txt37.Visible = true;
        txt38.Visible = true;
        txt39.Visible = true;
        txt40.Visible = true;
        txt41.Visible = true;
        txt42.Visible = true;
        txt43.Visible = true;
        txt44.Visible = true;
        txt45.Visible = true;
        txt46.Visible = true;
        txt47.Visible = true;
        txt48.Visible = true;
        txt49.Visible = true;
        txt50.Visible = true;
        txt51.Visible = true;
        txt52.Visible = true;
        txt53.Visible = true;
        txt54.Visible = true;
        txt55.Visible = true;
        txt56.Visible = true;
        txt57.Visible = true;
        txt58.Visible = true;
        txt59.Visible = true;
        txt60.Visible = true;
        txt61.Visible = true;
        txt62.Visible = true;
        txt63.Visible = true;
        txt64.Visible = true;
        txt65.Visible = true;
        txt66.Visible = true;
        txt67.Visible = true;
        txt68.Visible = true;
        txt69.Visible = true;
        txt70.Visible = true;
        txt71.Visible = true;
        txt72.Visible = true;
        txt73.Visible = true;
        txt74.Visible = true;
        txt75.Visible = true;
        txt76.Visible = true;

        lbl1.Visible = false;
        lbl2.Visible = false;
        lbl3.Visible = false;
        lbl4.Visible = false;
        lbl5.Visible = false;
        lbl6.Visible = false;
        lbl7.Visible = false;
        lbl8.Visible = false;
        lbl9.Visible = false;
        lbl10.Visible = false;
        lbl11.Visible = false;
        lbl12.Visible = false;
        lbl13.Visible = false;
        lbl14.Visible = false;
        lbl15.Visible = false;
        lbl16.Visible = false;
        lbl17.Visible = false;
        lbl18.Visible = false;
        lbl19.Visible = false;
        lbl20.Visible = false;
        lbl21.Visible = false;
        lbl22.Visible = false;
        lbl23.Visible = false;
        lbl24.Visible = false;
        lbl25.Visible = false;
        lbl26.Visible = false;
        lbl27.Visible = false;
        lbl28.Visible = false;
        lbl29.Visible = false;
        lbl30.Visible = false;
        lbl31.Visible = false;
        lbl32.Visible = false;
        lbl33.Visible = false;
        lbl77.Visible = false;
        lbl34.Visible = false;
        lbl35.Visible = false;
        lbl36.Visible = false;
        lbl37.Visible = false;
        lbl38.Visible = false;
        lbl39.Visible = false;
        lbl40.Visible = false;
        lbl41.Visible = false;
        lbl42.Visible = false;
        lbl43.Visible = false;
        lbl44.Visible = false;
        lbl45.Visible = false;
        lbl46.Visible = false;
        lbl47.Visible = false;
        lbl48.Visible = false;
        lbl49.Visible = false;
        lbl50.Visible = false;
        lbl51.Visible = false;
        lbl52.Visible = false;
        lbl53.Visible = false;
        lbl54.Visible = false;
        lbl55.Visible = false;
        lbl56.Visible = false;
        lbl57.Visible = false;
        lbl58.Visible = false;
        lbl59.Visible = false;
        lbl60.Visible = false;
        lbl61.Visible = false;
        lbl62.Visible = false;
        lbl63.Visible = false;
        lbl64.Visible = false;
        lbl65.Visible = false;
        lbl66.Visible = false;
        lbl67.Visible = false;
        lbl68.Visible = false;
        lbl69.Visible = false;
        lbl70.Visible = false;
        lbl71.Visible = false;
        lbl72.Visible = false;
        lbl73.Visible = false;
        lbl74.Visible = false;
        lbl75.Visible = false;
        lbl76.Visible = false;

    }

    private void kutularKapali()
    {

        LinkButton3.Visible = false;
        txt1.Visible = false;
        txt2.Visible = false;
        txt3.Visible = false;
        txt4.Visible = false;
        txt5.Visible = false;
        txt6.Visible = false;
        txt7.Visible = false;
        txt8.Visible = false;
        txt9.Visible = false;
        txt10.Visible = false;
        txt11.Visible = false;
        txt12.Visible = false;
        txt13.Visible = false;
        txt14.Visible = false;
        txt15.Visible = false;
        txt16.Visible = false;
        txt17.Visible = false;
        txt18.Visible = false;
        txt19.Visible = false;
        txt20.Visible = false;
        txt21.Visible = false;
        txt22.Visible = false;
        txt23.Visible = false;
        txt24.Visible = false;
        txt25.Visible = false;
        txt26.Visible = false;
        txt27.Visible = false;
        txt28.Visible = false;
        txt29.Visible = false;
        txt30.Visible = false;
        txt31.Visible = false;
        txt32.Visible = false;
        txt33.Visible = false;
        txt77.Visible = false;
        txt34.Visible = false;
        txt35.Visible = false;
        txt36.Visible = false;
        txt37.Visible = false;
        txt38.Visible = false;
        txt39.Visible = false; 
        txt40.Visible = false;
        txt41.Visible = false;
        txt42.Visible = false;
        txt43.Visible = false;
        txt44.Visible = false;
        txt45.Visible = false;
        txt46.Visible = false;
        txt47.Visible = false;
        txt48.Visible = false;
        txt49.Visible = false;
        txt50.Visible = false;
        txt51.Visible = false;
        txt52.Visible = false;
        txt53.Visible = false;
        txt54.Visible = false;
        txt55.Visible = false;
        txt56.Visible = false;
        txt57.Visible = false;
        txt58.Visible = false;
        txt59.Visible = false;
        txt60.Visible = false;
        txt61.Visible = false;
        txt62.Visible = false;
        txt63.Visible = false;
        txt64.Visible = false;
        txt65.Visible = false;
        txt66.Visible = false;
        txt67.Visible = false;
        txt68.Visible = false;
        txt69.Visible = false;
        txt70.Visible = false;
        txt71.Visible = false;
        txt72.Visible = false;
        txt73.Visible = false;
        txt74.Visible = false;
        txt75.Visible = false;
        txt76.Visible = false;

        lbl1.Visible = true;
        lbl2.Visible = true;
        lbl3.Visible = true;
        lbl4.Visible = true;
        lbl5.Visible = true;
        lbl6.Visible = true;
        lbl7.Visible = true;
        lbl8.Visible = true;
        lbl9.Visible = true;
        lbl10.Visible = true;
        lbl11.Visible = true;
        lbl12.Visible = true;
        lbl13.Visible = true;
        lbl14.Visible = true;
        lbl15.Visible = true;
        lbl16.Visible = true;
        lbl17.Visible = true;
        lbl18.Visible = true;
        lbl19.Visible = true;
        lbl20.Visible = true;
        lbl21.Visible = true;
        lbl22.Visible = true;
        lbl23.Visible = true;
        lbl24.Visible = true;
        lbl25.Visible = true;
        lbl26.Visible = true;
        lbl27.Visible = true;
        lbl28.Visible = true;
        lbl29.Visible = true;
        lbl30.Visible = true;
        lbl31.Visible = true;
        lbl32.Visible = true;
        lbl33.Visible = true;
        lbl77.Visible = true;
        lbl34.Visible = true;
        lbl35.Visible = true;
        lbl36.Visible = true;
        lbl37.Visible = true;
        lbl38.Visible = true;
        lbl39.Visible = true;
        lbl40.Visible = true;
        lbl41.Visible = true;
        lbl42.Visible = true;
        lbl43.Visible = true;
        lbl44.Visible = true;
        lbl45.Visible = true;
        lbl46.Visible = true;
        lbl47.Visible = true;
        lbl48.Visible = true;
        lbl49.Visible = true;
        lbl50.Visible = true;
        lbl51.Visible = true;
        lbl52.Visible = true;
        lbl53.Visible = true;
        lbl54.Visible = true;
        lbl55.Visible = true;
        lbl56.Visible = true;
        lbl57.Visible = true;
        lbl58.Visible = true;
        lbl59.Visible = true;
        lbl60.Visible = true;
        lbl61.Visible = true;
        lbl62.Visible = true;
        lbl63.Visible = true;
        lbl64.Visible = true;
        lbl65.Visible = true;
        lbl66.Visible = true;
        lbl67.Visible = true;
        lbl68.Visible = true;
        lbl69.Visible = true;
        lbl70.Visible = true;
        lbl71.Visible = true;
        lbl72.Visible = true;
        lbl73.Visible = true;
        lbl74.Visible = true;
        lbl75.Visible = true;
        lbl76.Visible = true;
    }

    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {
        kutularAcik();
        verileriYukle();
        Button2.Visible = false;
        Button1.Visible = true;
        Label6.Visible = false; d_kaydet.Visible = true;
        btnKaydet.Visible = false;
        ksacilan();
        ipt.Visible = true;
        iptal.Visible = true;
    }
    protected void d_kaydet_Click1(object sender, ImageClickEventArgs e)
    {

        ksacilan();

        HttpCookie islemdekihastasm = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihastasm["HastaID"];

        string siklus_id = Request.QueryString["siklus_id"].ToString();


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from labsonuc where hastaID=" + hasta_id + " and siklusID=" + siklus_id + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows.Count == 0)
        {
            YeniEkle();
        }
        else if (mp_dt.Rows.Count == 1)
        {
            guncelle();
        }
    }

    private void guncelle()
    {
            string katater = "";

        foreach (ListItem oge in txt24.Items)
        {
            if (oge.Selected)
            {
                katater += oge.Value+"-";
            }
        }

        katater = katater.TrimStart().TrimEnd();


  if (katater != "")
        {
 if (katater.Substring(0, 1) == "-")
        {
            katater = katater.Remove(0, 1);
        }
        if (katater.Length > 0)
        {
            katater = katater.Remove(katater.Length - 1, 1);
        }


}
else

{

katater="";
}


       string transferOzelligi = "";

        foreach (ListItem oge in txt32.Items)
        {
            if (oge.Selected)
            {
                transferOzelligi += oge.Value + "-";
            }
        }


        transferOzelligi = transferOzelligi.TrimStart().TrimEnd();


if (transferOzelligi != "")

{

 if (transferOzelligi.Substring(0, 1) == "-")
        {
            transferOzelligi = transferOzelligi.Remove(0, 1);
        }
        if (transferOzelligi.Length > 0)
        {
            transferOzelligi = transferOzelligi.Remove(transferOzelligi.Length - 1, 1);
        }



}
else

{

transferOzelligi = "";

}



       


























        string ilac = "";

        foreach (ListItem oge in txt35.Items)
        {
            if (oge.Selected)
            {
                ilac += oge.Value + "-";
            }
        }


        ilac = ilac.TrimStart().TrimEnd();

if (ilac != "")
{
  if (ilac.Substring(0, 1) == "-")
        {
            ilac = ilac.Remove(0, 1);
        }
        if (ilac.Length > 0)
        {
            ilac = ilac.Remove(ilac.Length - 1, 1);

        }

}
else

{ 

ilac="";


}



      





















        string stipi = "";

        foreach (ListItem oge in txt44.Items)
        {
            if (oge.Selected)
            {
                stipi += oge.Value + "-";
            }
        }


        stipi = stipi.TrimStart().TrimEnd();


if (stipi != "")
{


    if (stipi.Substring(0, 1) == "-")
        {
            stipi = stipi.Remove(0, 1);
        }
        if (stipi.Length > 0)
        {
            stipi = stipi.Remove(stipi.Length - 1, 1);
        }


}

else

{

stipi="";

}



    























        string male = "";

        foreach (ListItem oge in txt48.Items)
        {
            if (oge.Selected)
            {
                male += oge.Value + "-";
            }
        }

        male = male.TrimStart().TrimEnd();


if(male != "")
{

 if (male.Substring(0, 1) == "-")
        {
            male = male.Remove(0, 1);
        }
        if (male.Length > 0)
        {
            male = male.Remove(male.Length - 1, 1);
        }

}

else

{


male="";

}

       
















        string female = "";

        foreach (ListItem oge in txt49.Items)
        {
            if (oge.Selected)
            {
                female += oge.Value + "-";
            }
        }

        female = female.TrimStart().TrimEnd();

 if (female != "" )
{

 if (female.Substring(0, 1) == "-")
        {
            female = female.Remove(0, 1);
        }
if (female.Length > 0)
        {
            female = female.Remove(female.Length - 1, 1);
        }

}
else
{

female="";

}

      
     

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update labsonuc set txt1=?1,txt2=?2,txt3=?3,txt4=?4,txt5=?5,txt6=?6,txt7=?7,txt8=?8,txt9=?9,txt10=?10,txt11=?11,txt12=?12,txt13=?13,txt14=?14,txt15=?15,txt16=?16,txt17=?17,txt18=?18,txt19=?19,txt20=?20,txt21=?21,txt22=?22,txt23=?23,txt24=?24,txt25=?25,txt26=?26,txt27=?27,txt28=?28,txt29=?29,txt30=?30,txt31=?31,txt32=?32,txt33=?33,txt34=?34,txt35=?35,txt36=?36,txt37=?37,txt38=?38,txt39=?39,txt40=?40,txt41=?41,txt42=?42,txt43=?43,txt44=?44,txt45=?45,txt46=?46,txt47=?47,txt48=?48,txt49=?49,txt50=?50,txt51=?51,txt52=?52,txt53=?53,txt54=?54,txt55=?55,txt56=?56,txt57=?57,txt58=?58,txt59=?59,txt60=?60,txt61=?61,txt62=?62,txt63=?63,txt64=?64,txt65=?65,txt66=?66,txt67=?67,txt68=?68,txt69=?69,txt70=?70,txt71=?71,txt72=?72,txt73=?73,txt74=?74,txt75=?75,tarih=?76,txt76=?77,txt77=?78 where siklusID=?siklus", mp_connection);

        cmd.Parameters.AddWithValue("?siklus", lblSiklusID.Text.ToString());
        cmd.Parameters.AddWithValue("?1", txt1.Text.ToString());
        cmd.Parameters.AddWithValue("?2", txt2.Text.ToString());
        cmd.Parameters.AddWithValue("?3", txt3.Text.ToString());
        cmd.Parameters.AddWithValue("?4", txt4.Text.ToString());
        cmd.Parameters.AddWithValue("?5", txt5.Text.ToString());
        cmd.Parameters.AddWithValue("?6", txt6.Text.ToString());
        cmd.Parameters.AddWithValue("?7", txt7.Text.ToString());
        cmd.Parameters.AddWithValue("?8", txt8.Text.ToString());
        cmd.Parameters.AddWithValue("?9", txt9.Text.ToString());
        cmd.Parameters.AddWithValue("?10", txt10.Text.ToString());
        cmd.Parameters.AddWithValue("?11", txt11.Text.ToString());
        cmd.Parameters.AddWithValue("?12", txt12.Text.ToString());
        cmd.Parameters.AddWithValue("?13", txt13.Text.ToString());
        cmd.Parameters.AddWithValue("?14", txt14.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?15", txt15.Text.ToString());
        cmd.Parameters.AddWithValue("?16", txt16.Text.ToString());
        cmd.Parameters.AddWithValue("?17", txt17.Text.ToString());
        cmd.Parameters.AddWithValue("?18", txt18.Text.ToString());
        cmd.Parameters.AddWithValue("?19", txt19.Text.ToString());
        cmd.Parameters.AddWithValue("?20", txt20.Text.ToString());
        cmd.Parameters.AddWithValue("?21", txt21.Text.ToString());
        cmd.Parameters.AddWithValue("?22", txt22.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?23", txt23.Text.ToString());
        cmd.Parameters.AddWithValue("?24", katater.ToString());
        cmd.Parameters.AddWithValue("?25", txt25.Text.ToString());
        cmd.Parameters.AddWithValue("?26", txt26.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?27", txt27.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?28", txt28.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?29", txt29.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?30", txt30.Text.ToString());
        cmd.Parameters.AddWithValue("?31", txt31.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?32", transferOzelligi.ToString());
        cmd.Parameters.AddWithValue("?33", txt33.Text.ToString());
        cmd.Parameters.AddWithValue("?34", txt34.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?35", ilac.ToString());
        cmd.Parameters.AddWithValue("?36", txt36.Text.ToString());
        cmd.Parameters.AddWithValue("?37", txt37.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?38", txt38.Text.ToString());
        cmd.Parameters.AddWithValue("?39", txt39.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?40", txt40.Text.ToString());
        cmd.Parameters.AddWithValue("?41", txt41.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?42", txt42.Text.ToString());
        cmd.Parameters.AddWithValue("?43", txt43.Text.ToString());
        cmd.Parameters.AddWithValue("?44", stipi.ToString());
        cmd.Parameters.AddWithValue("?45", txt45.Text.ToString());
        cmd.Parameters.AddWithValue("?46", txt46.Text.ToString());
        cmd.Parameters.AddWithValue("?47", txt47.Text.ToString());
        cmd.Parameters.AddWithValue("?48", male.ToString());
        cmd.Parameters.AddWithValue("?49", female.ToString());
        cmd.Parameters.AddWithValue("?50", txt50.Text.ToString());
        cmd.Parameters.AddWithValue("?51", txt51.Text.ToString());
        cmd.Parameters.AddWithValue("?52", txt52.Text.ToString());
        cmd.Parameters.AddWithValue("?53", txt53.Text.ToString());
        cmd.Parameters.AddWithValue("?54", txt54.Text.ToString());
        cmd.Parameters.AddWithValue("?55", txt55.Text.ToString());
        cmd.Parameters.AddWithValue("?56", txt56.Text.ToString());
        cmd.Parameters.AddWithValue("?57", txt57.Text.ToString());
        cmd.Parameters.AddWithValue("?58", txt58.Text.ToString());
        cmd.Parameters.AddWithValue("?59", txt59.Text.ToString());
        cmd.Parameters.AddWithValue("?60", txt60.Text.ToString());
        cmd.Parameters.AddWithValue("?61", txt61.Text.ToString());
        cmd.Parameters.AddWithValue("?62", txt62.Text.ToString());
        cmd.Parameters.AddWithValue("?63", txt63.Text.ToString());
        cmd.Parameters.AddWithValue("?64", txt64.Text.ToString());
        cmd.Parameters.AddWithValue("?65", txt65.Text.ToString());
        cmd.Parameters.AddWithValue("?66", txt66.Text.ToString());
        cmd.Parameters.AddWithValue("?67", txt67.Text.ToString());
        cmd.Parameters.AddWithValue("?68", txt68.Text.ToString());
        cmd.Parameters.AddWithValue("?69", txt69.Text.ToString());
        cmd.Parameters.AddWithValue("?70", txt70.Text.ToString());
        cmd.Parameters.AddWithValue("?71", txt71.Text.ToString());
        cmd.Parameters.AddWithValue("?72", txt72.Text.ToString());
        cmd.Parameters.AddWithValue("?73", txt73.Text.ToString());
        cmd.Parameters.AddWithValue("?74", txt74.Text.ToString());
        cmd.Parameters.AddWithValue("?75", txt75.Text.ToString());
        cmd.Parameters.AddWithValue("?76", DateTime.Now.Date.ToShortDateString());
        cmd.Parameters.AddWithValue("?77", txt76.Text.ToString());
        cmd.Parameters.AddWithValue("?78", txt77.Text.ToString());

        mp_connection.Open();
        int eks = cmd.ExecuteNonQuery();
        mp_connection.Close();

        if (eks == 1)
        {


            kutularKapali();
            durumKontrol();
            Label6.Text = "Güncelleme İşlemi Başarıyla Gerçekleşti.";
            Label6.ForeColor = System.Drawing.Color.Green;
            Label7.Text = "Güncelleme İşlemi Başarıyla Gerçekleşti.";
            Label7.ForeColor = System.Drawing.Color.Green;
            ipt.Visible = false;
            iptal.Visible = false;


        }
        else
        {
            Label6.Text = "Güncelleme İşlemi Başarısız.Lütfen Tekrar Deneyiniz!";
            Label6.ForeColor = System.Drawing.Color.Red;
            Label7.Text = "Güncelleme İşlemi Başarısız.Lütfen Tekrar Deneyiniz!";
            Label7.ForeColor = System.Drawing.Color.Red;
          
        }




    }

    private void YeniEkle()
    {
        string katater = "";

        foreach (ListItem oge in txt24.Items)
        {
            if (oge.Selected)
            {
                katater += oge.Value + "-";
            }
        }

        katater = katater.TrimStart().TrimEnd();


        if (katater != "")
        {
            if (katater.Substring(0, 1) == "-")
            {
                katater = katater.Remove(0, 1);
            }
            if (katater.Length > 0)
            {
                katater = katater.Remove(katater.Length - 1, 1);
            }


        }
        else
        {

            katater = "";
        }


        string transferOzelligi = "";

        foreach (ListItem oge in txt32.Items)
        {
            if (oge.Selected)
            {
                transferOzelligi += oge.Value + "-";
            }
        }


        transferOzelligi = transferOzelligi.TrimStart().TrimEnd();


        if (transferOzelligi != "")
        {

            if (transferOzelligi.Substring(0, 1) == "-")
            {
                transferOzelligi = transferOzelligi.Remove(0, 1);
            }
            if (transferOzelligi.Length > 0)
            {
                transferOzelligi = transferOzelligi.Remove(transferOzelligi.Length - 1, 1);
            }



        }
        else
        {

            transferOzelligi = "";

        }






























        string ilac = "";

        foreach (ListItem oge in txt35.Items)
        {
            if (oge.Selected)
            {
                ilac += oge.Value + "-";
            }
        }


        ilac = ilac.TrimStart().TrimEnd();

        if (ilac != "")
        {
            if (ilac.Substring(0, 1) == "-")
            {
                ilac = ilac.Remove(0, 1);
            }
            if (ilac.Length > 0)
            {
                ilac = ilac.Remove(ilac.Length - 1, 1);

            }

        }
        else
        {

            ilac = "";


        }

























        string stipi = "";

        foreach (ListItem oge in txt44.Items)
        {
            if (oge.Selected)
            {
                stipi += oge.Value + "-";
            }
        }


        stipi = stipi.TrimStart().TrimEnd();


        if (stipi != "")
        {


            if (stipi.Substring(0, 1) == "-")
            {
                stipi = stipi.Remove(0, 1);
            }
            if (stipi.Length > 0)
            {
                stipi = stipi.Remove(stipi.Length - 1, 1);
            }


        }

        else
        {

            stipi = "";

        }



























        string male = "";

        foreach (ListItem oge in txt48.Items)
        {
            if (oge.Selected)
            {
                male += oge.Value + "-";
            }
        }

        male = male.TrimStart().TrimEnd();


        if (male != "")
        {

            if (male.Substring(0, 1) == "-")
            {
                male = male.Remove(0, 1);
            }
            if (male.Length > 0)
            {
                male = male.Remove(male.Length - 1, 1);
            }

        }

        else
        {


            male = "";

        }


















        string female = "";

        foreach (ListItem oge in txt49.Items)
        {
            if (oge.Selected)
            {
                female += oge.Value + "-";
            }
        }

        female = female.TrimStart().TrimEnd();

        if (female != "")
        {

            if (female.Substring(0, 1) == "-")
            {
                female = female.Remove(0, 1);
            }
            if (female.Length > 0)
            {
                female = female.Remove(female.Length - 1, 1);
            }

        }
        else
        {

            female = "";

        }

        

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand cmd = new MySqlCommand("Insert into labsonuc(siklusID,hastaID,txt1,txt2,txt3,txt4,txt5,txt6,txt7,txt8,txt9,txt10,txt11,txt12,txt13,txt14,txt15,txt16,txt17,txt18,txt19,txt20,txt21,txt22,txt23,txt24,txt25,txt26,txt27,txt28,txt29,txt30,txt31,txt32,txt33,txt34,txt35,txt36,txt37,txt38,txt39,txt40,txt41,txt42,txt43,txt44,txt45,txt46,txt47,txt48,txt49,txt50,txt51,txt52,txt53,txt54,txt55,txt56,txt57,txt58,txt59,txt60,txt61,txt62,txt63,txt64,txt65,txt66,txt67,txt68,txt69,txt70,txt71,txt72,txt73,txt74,txt75,tarih,txt76,txt77) values (?siklus,?hasta,?1,?2,?3,?4,?5,?6,?7,?8,?9,?10,?11,?12,?13,?14,?15,?16,?17,?18,?19,?20,?21,?22,?23,?24,?25,?26,?27,?28,?29,?30,?31,?32,?33,?34,?35,?36,?37,?38,?39,?40,?41,?42,?43,?44,?45,?46,?47,?48,?49,?50,?51,?52,?53,?54,?55,?56,?57,?58,?59,?60,?61,?62,?63,?64,?65,?66,?67,?68,?69,?70,?71,?72,?73,?74,?75,?76,?77,?78)", mp_connection);

        cmd.Parameters.AddWithValue("?siklus",lblSiklusID.Text.ToString());
        cmd.Parameters.AddWithValue("?hasta", lblHastaID.Text.ToString());
        cmd.Parameters.AddWithValue("?1", txt1.Text.ToString());
        cmd.Parameters.AddWithValue("?2", txt2.Text.ToString());
        cmd.Parameters.AddWithValue("?3", txt3.Text.ToString());
        cmd.Parameters.AddWithValue("?4", txt4.Text.ToString());
        cmd.Parameters.AddWithValue("?5", txt5.Text.ToString());
        cmd.Parameters.AddWithValue("?6", txt6.Text.ToString());
        cmd.Parameters.AddWithValue("?7", txt7.Text.ToString());
        cmd.Parameters.AddWithValue("?8", txt8.Text.ToString());
        cmd.Parameters.AddWithValue("?9", txt9.Text.ToString());
        cmd.Parameters.AddWithValue("?10", txt10.Text.ToString());
        cmd.Parameters.AddWithValue("?11", txt11.Text.ToString());
        cmd.Parameters.AddWithValue("?12", txt12.Text.ToString());
        cmd.Parameters.AddWithValue("?13", txt13.Text.ToString());
        cmd.Parameters.AddWithValue("?14", txt14.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?15", txt15.Text.ToString());
        cmd.Parameters.AddWithValue("?16", txt16.Text.ToString());
        cmd.Parameters.AddWithValue("?17", txt17.Text.ToString());
        cmd.Parameters.AddWithValue("?18", txt18.Text.ToString());
        cmd.Parameters.AddWithValue("?19", txt19.Text.ToString());
        cmd.Parameters.AddWithValue("?20", txt20.Text.ToString());
        cmd.Parameters.AddWithValue("?21", txt21.Text.ToString());
        cmd.Parameters.AddWithValue("?22", txt22.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?23", txt23.Text.ToString());
        cmd.Parameters.AddWithValue("?24", katater.ToString());
        cmd.Parameters.AddWithValue("?25", txt25.Text.ToString());
        cmd.Parameters.AddWithValue("?26", txt26.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?27", txt27.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?28", txt28.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?29", txt29.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?30", txt30.Text.ToString());
        cmd.Parameters.AddWithValue("?31", txt31.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?32", transferOzelligi.ToString());
        cmd.Parameters.AddWithValue("?33", txt33.Text.ToString());
        cmd.Parameters.AddWithValue("?34", txt34.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?35", ilac.ToString());
        cmd.Parameters.AddWithValue("?36", txt36.Text.ToString());
        cmd.Parameters.AddWithValue("?37", txt37.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?38", txt38.Text.ToString());
        cmd.Parameters.AddWithValue("?39", txt39.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?40", txt40.Text.ToString());
        cmd.Parameters.AddWithValue("?41", txt41.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?42", txt42.Text.ToString());
        cmd.Parameters.AddWithValue("?43", txt43.Text.ToString());
        cmd.Parameters.AddWithValue("?44", stipi.ToString());
        cmd.Parameters.AddWithValue("?45", txt45.Text.ToString());
        cmd.Parameters.AddWithValue("?46", txt46.Text.ToString());
        cmd.Parameters.AddWithValue("?47", txt47.Text.ToString());
        cmd.Parameters.AddWithValue("?48", male.ToString());
        cmd.Parameters.AddWithValue("?49", female.ToString());
        cmd.Parameters.AddWithValue("?50", txt50.Text.ToString());
        cmd.Parameters.AddWithValue("?51", txt51.Text.ToString());
        cmd.Parameters.AddWithValue("?52", txt52.Text.ToString());
        cmd.Parameters.AddWithValue("?53", txt53.Text.ToString());
        cmd.Parameters.AddWithValue("?54", txt54.Text.ToString());
        cmd.Parameters.AddWithValue("?55", txt55.Text.ToString());
        cmd.Parameters.AddWithValue("?56", txt56.Text.ToString());
        cmd.Parameters.AddWithValue("?57", txt57.Text.ToString());
        cmd.Parameters.AddWithValue("?58", txt58.Text.ToString());
        cmd.Parameters.AddWithValue("?59", txt59.Text.ToString());
        cmd.Parameters.AddWithValue("?60", txt60.Text.ToString());
        cmd.Parameters.AddWithValue("?61", txt61.Text.ToString());
        cmd.Parameters.AddWithValue("?62", txt62.Text.ToString());
        cmd.Parameters.AddWithValue("?63", txt63.Text.ToString());
        cmd.Parameters.AddWithValue("?64", txt64.Text.ToString());
        cmd.Parameters.AddWithValue("?65", txt65.Text.ToString());
        cmd.Parameters.AddWithValue("?66", txt66.Text.ToString());
        cmd.Parameters.AddWithValue("?67", txt67.Text.ToString());
        cmd.Parameters.AddWithValue("?68", txt68.Text.ToString());
        cmd.Parameters.AddWithValue("?69", txt69.Text.ToString());
        cmd.Parameters.AddWithValue("?70", txt70.Text.ToString());
        cmd.Parameters.AddWithValue("?71", txt71.Text.ToString());
        cmd.Parameters.AddWithValue("?72", txt72.Text.ToString());
        cmd.Parameters.AddWithValue("?73", txt73.Text.ToString());
        cmd.Parameters.AddWithValue("?74", txt74.Text.ToString());
        cmd.Parameters.AddWithValue("?75", txt75.Text.ToString());
        cmd.Parameters.AddWithValue("?76", DateTime.Now.Date.ToShortDateString());
        cmd.Parameters.AddWithValue("?77", txt76.Text);
        cmd.Parameters.AddWithValue("?78", txt77.Text);
        mp_connection.Open();
        int eks = cmd.ExecuteNonQuery();
        mp_connection.Close();

        if (eks == 1)
        {

          
            kutularKapali();
  durumKontrol();
  Label6.Text = "Kayıt İşlemi Başarıyla Gerçekleştirildi.";
  Label6.ForeColor = System.Drawing.Color.Green;

  Label7.Text = "Kayıt İşlemi Başarıyla Gerçekleştirildi.";
  Label7.ForeColor = System.Drawing.Color.Green;

  ipt.Visible = false;
  iptal.Visible = false;
        }
        else
        {

            Label6.Text = "Kayıt İşlemi Başarısız.Lütfen Tekrar Deneyiniz!";
            Label6.ForeColor = System.Drawing.Color.Red;
            Label7.Text = "Kayıt İşlemi Başarısız.Lütfen Tekrar Deneyiniz!";
            Label7.ForeColor = System.Drawing.Color.Red;
        }




    }
    
    protected void ipt_Click1(object sender, ImageClickEventArgs e)
    {
        kutularKapali();
        durumKontrol();
        ipt.Visible = false;
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        ksacilan();
        veritabanindaki_veriler();



    }

    private void veritabanindaki_veriler()
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da6 = new MySqlDataAdapter("Select * from uye_hasta where uye_id=" + lblHastaID.Text.ToString() + "", mp_connection);

        DataTable mp_dt6 = new DataTable();
        mp_da6.Fill(mp_dt6);

        DateTime dogum_tarihi = DateTime.Parse(mp_dt6.Rows[0]["uye_dogum_tarihi"].ToString());
        TimeSpan sure = DateTime.Parse(lblSiklusTarihi.Text.ToString().Substring(0, 10)) - dogum_tarihi;
        int yeni_yas = sure.Days / 365;
        txt9.Text = yeni_yas.ToString();
        txt1.Text = lblSiklusYil.Text;
        txt2.Text = lblSiklusAy.Text;
        txt6.Text = lblHastaAdi.Text;
        txt7.Text = mp_dt6.Rows[0]["esinin_adi"].ToString();
        txt8.Text = mp_dt6.Rows[0]["uye_cep_tel"].ToString();

        MySqlDataAdapter mp_da66 = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + lblSiklusID.Text.ToString() + "", mp_connection);

        DataTable mp_dt66 = new DataTable();
        mp_da66.Fill(mp_dt66);

        string opuTarihi = mp_dt66.Rows[0]["alan3"].ToString();

        if (opuTarihi.Length > 8)
        {
            opuTarihi = opuTarihi.Substring(0, 10);
            txt11.Text = opuTarihi.Substring(0, 2);
            txt12.Text = opuTarihi.Substring(3, 2);
            txt13.Text = opuTarihi.Substring(6, 4);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie islemdekihastasm = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihastasm["HastaID"];

        string siklus_id = Request.QueryString["siklus_id"].ToString();


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from labsonuc where hastaID=" + hasta_id + " and siklusID=" + siklus_id + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows.Count == 0)
        {
            YeniEkle();
        }
        else if (mp_dt.Rows.Count == 1)
        {
            guncelle();
        }



    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        kutularAcik();
        verileriYukle();
        Button2.Visible = false;
        Button1.Visible = true;
        d_kaydet.Visible = true;
        btnKaydet.Visible = false;
        Label6.Visible = false;
        iptal.Visible = true;
        ipt.Visible = true;
        

    }

    private void verileriYukle2()
    {
        
    }
    private void ksacilan()
    {
        gizlenecek3.Style["display"] = "block";
        ac3.Style["display"] = "none";
        kapa3.Style["display"] = "block";
    }
    private void kskapanan()
    {
        gizlenecek3.Style["display"] = "none";
        ac3.Style["display"] = "block";
        kapa3.Style["display"] = "none";
    }
    protected void iptal_Click(object sender, EventArgs e)
    {
        kutularKapali();
        durumKontrol();
        iptal.Visible = false;
        ipt.Visible = false;

    }

}
