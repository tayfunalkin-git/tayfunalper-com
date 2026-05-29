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

public partial class ivfyonetici_hasta_modulu_in_ks : System.Web.UI.UserControl
{
    ivf_class mp_class = new ivf_class();

    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {

            try
            {

                if (Session["kriterler"] != null)
                {
                    string[] dizim = Session["kriterler"].ToString().Split('|');

                    if (dizim[0] == "0000066.aspx")
                    {
                        menuyukle2();
                        //yetkili_doktor_yukle();
                        fsh_hesap();
                        farkhesap();
                        formyukle();
                        kullanilanyukle();
                        if (Request.QueryString["g"] == "takipli")
                            istatistiktengeln();
                        else
                            Session["kriterler2"] = null;
                    }
                }
            }
            catch
            { }



            try
            {

                if (Session["etkriterler"] != null)
                {
                    string[] dizim = Session["etkriterler"].ToString().Split('|');

                    if (dizim[0] == "0000101.aspx")
                    {
                        menuyukle2();
                        //yetkili_doktor_yukle();
                        fsh_hesap();
                        farkhesap();
                        formyukle();
                        kullanilanyukle();
                        if (Request.QueryString["g"] == "et")
                            istatistiktengeln();
                        else
                            Session["etkriterler2"] = null;

                    }
                }
            }
            catch
            { }




            try
            {

                if (Session["etkriterler103"] != null)
                {
                    string[] dizim = Session["etkriterler103"].ToString().Split('|');

                    if (dizim[0] == "0000103.aspx")
                    {
                        menuyukle2();
                        //yetkili_doktor_yukle();
                        fsh_hesap();
                        farkhesap();
                        formyukle();
                        kullanilanyukle();
                        if (Request.QueryString["g"] == "et")
                            istatistiktengeln();
                        else
                            Session["etkriterler2103"] = null;

                    }
                }
            }
            catch
            { }



            try
            {

                if (Session["opukriterler"] != null)
                {
                    string[] dizim = Session["opukriterler"].ToString().Split('|');

                    if (dizim[0] == "0000070.aspx")
                    {
                        menuyukle2();
                        //yetkili_doktor_yukle();
                        fsh_hesap();
                        farkhesap();
                        formyukle();
                        kullanilanyukle();
                        if (Request.QueryString["g"] == "sat")
                            istatistiktengeln();
                        else
                            Session["opukriterler2"] = null;

                    }
                }
            }
            catch
            { }


            try
            {

                if (Session["sikluskriterler"] != null)
                {

                    string[] dizim = Session["sikluskriterler"].ToString().Split('|');

                    if (dizim[0] == "0000063.aspx")
                    {
                        menuyukle2();
                        //yetkili_doktor_yukle();
                        fsh_hesap();
                        farkhesap();
                        formyukle();
                        kullanilanyukle();
                        if (Request.QueryString["g"] == "siklus")
                            istatistiktengeln();
                        else
                            Session["sikluskriterler2"] = null;
                    }

                }

            }
            catch
            {


            }



            if (Request.QueryString["g"] == null)
            {


               
                menuyukle2();
                //yetkili_doktor_yukle();
                fsh_hesap();
                farkhesap();
                formyukle();
                kullanilanyukle();


            }


            //txtcogul.Attributes.Remove("disabled");


            baslangickontrol();

        }

    }

    private void kullanilanyukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select S.form_adi from siklusformlar S,siklusformverileri V where S.form_id=V.form_id and V.siklus_id="+Request.QueryString["siklus_id"].ToString()+" order by S.sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            formListKullanilan.DataSource = dt6;
            formListKullanilan.DataBind();

            int a = 0;
         Label ab = new Label();
          foreach(DataListItem oge in formListKullanilan.Items)
          { 

             
              ab = (Label) oge.FindControl("kullanilanForm");
              ab.Text = dt6.Rows[a][0].ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp";


              a++;
          }

          if (dt6.Rows.Count == 0)
          {
              Label3.Visible = true;
              Label3.Text = "Henüz herhangi bir form kullanılmadı!";
          }
          else
          {
              Label3.Visible = false;
          }


      }
      catch
      { }

    }

    private void formyukle()
    {

        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from siklusformlar order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            formlist.DataSource = dt6;
            formlist.DataTextField = dt6.Columns["form_adi"].ToString();
            formlist.DataValueField = dt6.Columns["form_id"].ToString();
            formlist.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            formlist.Items.Insert(0, yeni);
        }
        catch
        { }


    }

    private void farkhesap()
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_da = new MySqlDataAdapter("select alan3,alan4 from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);


        if (mp_dt.Rows.Count > 0)
        {
            string opu = mp_dt.Rows[0]["alan3"].ToString();

            string transfer = mp_dt.Rows[0]["alan4"].ToString();
            DateTime oputarihi, transfertarihi;
            if (opu.ToString().Length == 19 && transfer.ToString().Length == 19)
            {

                oputarihi = DateTime.Parse(opu.Substring(0, 10));
                transfertarihi = DateTime.Parse(transfer.Substring(0, 10));

                TimeSpan fark;

                fark = transfertarihi.Subtract(oputarihi);

                int gelen = fark.Days;

                lblfrozen.Text = gelen.ToString();
                txtfrozen.Text = gelen.ToString();











            }
        }

    }

    private void baslangickontrol()
    {


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows[0]["baslangic"].ToString() == "+")
        {

            lblistatistik.Visible = false;
            chbistatistik.Visible = false;

            Label1.Text = "aaa";

        }

    }


    protected void btnKaydet_Click1(object sender, ImageClickEventArgs e)
    {




        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        ksacilan();
        Panel3.Visible = false;
        lblsat.Visible = false;
        txtsat.Visible = true;
        lbltani1.Visible = false;
        txttani1.Visible = true;
        lbltani2.Visible = false;
        txttani2.Visible = true;
        lbltani3.Visible = false;
        txttani3.Visible = true;
        lbltani4.Visible = false;
        txttani4.Visible = true;

        lbltedaviprotokolu.Visible = false;
        txttedaviprotokolu.Visible = true;

        lbloi.Visible = false;
        txtoi.Visible = true;
        lbliui.Visible = false;
        txtiui.Visible = true;
        lblivf.Visible = false;
        txtivf.Visible = true;
        lblgebelik.Visible = false;
        txtgebelik.Visible = true;

        lblabortus.Visible = false;
        txtabortus.Visible = true;


        lblbiyokimyasal.Visible = false;
        txtbiyokimyasal.Visible = true;
        lbldogum.Visible = false;
        txtdogum.Visible = true;
        lblagirlik.Visible = false;
        txtagirlik.Visible = true;
        lblantralsag.Visible = false;
        txtantralsag.Visible = true;
        lblantralsol.Visible = false;
        txtantralsol.Visible = true;
        lbloversag.Visible = false;
        txtoversag.Visible = true;
        lbloversol.Visible = false;
        txtoversol.Visible = true;
        lblbazal.Visible = false;
        txtbazal.Visible = true;
        lblfsh.Visible = false;
        txtfsh.Visible = true;
        lbllh.Visible = false;
        txtlh.Visible = true;
        lble2.Visible = false;
        txte2.Visible = true;
        lblkullanilanfsh.Visible = false;
        lblgebeliksayisi.Visible = false;
        lblkesesayisi.Visible = false;
        lblmonokoryonik.Visible = false;
        lblFKH.Visible = false;
        txtkullanilanfsh.Visible = true;
        txtkullanilanfsh.Enabled = false;

        txtgebeliksayisi.Visible = true;
        txtkesesayisi.Visible = true;
        txtmonokoryonik.Visible = true;
        txtFKH.Visible = true;

        txtkurum.Visible = true;
        txttedavituru.Visible = true;

        txtpcos.Visible = true;
        txtovulasyon.Visible = true;
        txtcogul.Visible = true;
        txthiperstimulasyon.Visible = true;
        ImageButton1.Visible = true;
       
        d_kaydet.Visible = true;
        btnKaydet.Visible = false;

        ipt.Visible = true;
        lblkurum.Visible = false;
        lbltedavituru.Visible = false;

        lblpcos.Visible = false;
        lblovulasyon.Visible = false;
        lblcogul.Visible = false;
        lblhiperstimulasyon.Visible = false;


        lblopuyapildimi.Visible = false;
        rbopuyapildimi.Visible = true;

        lblgv.Visible = false;
        lblolgun.Visible = false;
        lblbilinmeyen.Visible = false;
        lblOlusanYumurta.Visible = false;


        lblDejenere.Visible = false;
        lblPostM.Visible = false;
        lblZona.Visible = false;



        txtDejenere.Visible = true;
        txtPostM.Visible = true;
        txtZona.Visible = true;
        txtOlusanYumurta.Visible = true;




        txtgv.Visible = true;
        txtolgun.Visible = true;
        txtbilinmeyen.Visible = true;

        lbldollenen.Visible = false;
        txtdollenen.Visible = true;

        lblembriyooluştumu.Visible = false;
        rbembriyoolustumu.Visible = true;

        lbltransferedilenembriyo.Visible = false;
        txttransferedilenembriyo.Visible = true;

        lblfrozen.Visible = false;
        txtfrozen.Visible = true;

        lblkalan.Visible = false;
        txtkalan.Visible = true;


        if (Label1.Text != "aaa")
        {
            lblistatistik.Visible = false;


            chbistatistik.Visible = true;
        }

        //try
        //{


        MySqlDataAdapter mp_da34 = new MySqlDataAdapter("select * from siklus_alanlar where ID=1", mp_connection);
        DataTable mp_dt34 = new DataTable();
        mp_da34.Fill(mp_dt34);


        for (int i = 1; i < 11; i++)
        {
            if (mp_dt34.Rows[0]["alan" + i.ToString()].ToString() == "+")
            {

                ((Label)FindControl("lblalan" + i)).Visible = false;

                ((TextBox)FindControl("txtalan" + i)).Visible = true;

                //((Label)FindControl("b" + i)).Visible = true;


            }
        }

        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);



        //   }
        //catch
        //{ }






    }



    void istatistiktengeln()
    {


        ksacilan();



        Panel3.Visible = false;
        lblsat.Visible = false;
        txtsat.Visible = true;
        lbltani1.Visible = false;
        txttani1.Visible = true;
        lbltani2.Visible = false;
        txttani2.Visible = true;
        lbltani3.Visible = false;
        txttani3.Visible = true;
        lbltani4.Visible = false;
        txttani4.Visible = true;
        lbltedaviprotokolu.Visible = false;
        txttedaviprotokolu.Visible = true;

        lbloi.Visible = false;
        txtoi.Visible = true;
        lbliui.Visible = false;
        txtiui.Visible = true;
        lblivf.Visible = false;
        txtivf.Visible = true;
        lblgebelik.Visible = false;
        txtgebelik.Visible = true;

        lblabortus.Visible = false;
        txtabortus.Visible = true;


        lblbiyokimyasal.Visible = false;
        txtbiyokimyasal.Visible = true;
        lbldogum.Visible = false;
        txtdogum.Visible = true;
        lblagirlik.Visible = false;
        txtagirlik.Visible = true;
        lblantralsag.Visible = false;
        txtantralsag.Visible = true;
        lblantralsol.Visible = false;
        txtantralsol.Visible = true;
        lbloversag.Visible = false;
        txtoversag.Visible = true;
        lbloversol.Visible = false;
        txtoversol.Visible = true;
        lblbazal.Visible = false;
        txtbazal.Visible = true;
        lblfsh.Visible = false;
        txtfsh.Visible = true;
        lbllh.Visible = false;
        txtlh.Visible = true;
        lble2.Visible = false;
        txte2.Visible = true;
        lblkullanilanfsh.Visible = false;
        lblgebeliksayisi.Visible = false;
        lblkesesayisi.Visible = false;
        lblmonokoryonik.Visible = false;
        lblFKH.Visible = false;


        txtkullanilanfsh.Visible = true;
        txtkullanilanfsh.Enabled = false;

        txtgebeliksayisi.Visible = true;
        txtmonokoryonik.Visible = true;
        txtFKH.Visible = true;
        txtkesesayisi.Visible = true;
        txtkurum.Visible = true;
        txttedavituru.Visible = true;

        txtpcos.Visible = true;
        txtovulasyon.Visible = true;
        txtcogul.Visible = true;
        txthiperstimulasyon.Visible = true;
        ImageButton1.Visible = true;
       
        d_kaydet.Visible = true;
        btnKaydet.Visible = false;

        ipt.Visible = true;
        lblkurum.Visible = false;
        lbltedavituru.Visible = false;

        lblpcos.Visible = false;
        lblovulasyon.Visible = false;
        lblcogul.Visible = false;
        lblhiperstimulasyon.Visible = false;

        lblopuyapildimi.Visible = false;
        rbopuyapildimi.Visible = true;

        lblgv.Visible = false;
        lblolgun.Visible = false;
        lblbilinmeyen.Visible = false;
        lblOlusanYumurta.Visible = false;

        txtgv.Visible = true;
        txtolgun.Visible = true;
        txtbilinmeyen.Visible = true;

        lblDejenere.Visible = false;
        lblPostM.Visible = false;
        lblZona.Visible = false;

        txtDejenere.Visible = true;
        txtPostM.Visible = true;
        txtZona.Visible = true;
        txtOlusanYumurta.Visible = true;



        lbldollenen.Visible = false;
        txtdollenen.Visible = true;

        lblembriyooluştumu.Visible = false;
        rbembriyoolustumu.Visible = true;

        lbltransferedilenembriyo.Visible = false;
        txttransferedilenembriyo.Visible = true;

        lblfrozen.Visible = false;
        txtfrozen.Visible = true;

        lblkalan.Visible = false;
        txtkalan.Visible = true;





        if (Label1.Text != "aaa")
        {
            lblistatistik.Visible = false;
            chbistatistik.Visible = true;
        }

        //try
        //{

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_da34 = new MySqlDataAdapter("select * from siklus_alanlar where ID=1", mp_connection);
        DataTable mp_dt34 = new DataTable();
        mp_da34.Fill(mp_dt34);


        for (int i = 1; i < 11; i++)
        {
            if (mp_dt34.Rows[0]["alan" + i.ToString()].ToString() == "+")
            {

                ((Label)FindControl("lblalan" + i)).Visible = false;

                ((TextBox)FindControl("txtalan" + i)).Visible = true;

                //((Label)FindControl("b" + i)).Visible = true;


            }
        }

        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);



        //}
        //catch
        //{ }

    }



    protected void ipt_Click1(object sender, ImageClickEventArgs e)
    {


        if (Session["kriterler"] != null)
        {
            string[] dizim = Session["kriterler"].ToString().Split('|');

            if (dizim[0] == "0000066.aspx" && Request.QueryString["g"] == "takipli")
            {

                Session.Add("kriterler2", Session["kriterler"]);
                Response.Redirect("~/ivfyonetici/0000066.aspx");

            }

        }

        if (Session["etkriterler"] != null)
        {
            string[] dizim = Session["etkriterler"].ToString().Split('|');

            if (dizim[0] == "0000101.aspx" && Request.QueryString["g"] == "et")
            {

                Session.Add("etkriterler2", Session["etkriterler"]);
                Response.Redirect("~/ivfyonetici/0000101.aspx");

            }

        }

        if (Session["opukriterler"] != null)
        {
            string[] dizim = Session["opukriterler"].ToString().Split('|');

            if (dizim[0] == "0000070.aspx" && Request.QueryString["g"] == "sat")
            {

                Session.Add("opukriterler2", Session["opukriterler"]);
                Response.Redirect("~/ivfyonetici/0000070.aspx");

            }

        }

        if (Session["sikluskriterler"] != null)
        {
            string[] dizim = Session["sikluskriterler"].ToString().Split('|');

            if (dizim[0] == "0000063.aspx" && Request.QueryString["g"] == "siklus")
            {

                Session.Add("sikluskriterler2", Session["sikluskriterler"]);
                Response.Redirect("~/ivfyonetici/0000063.aspx");

            }

        }


        Response.Redirect("infertilite.aspx?ts=1&siklus_id=" + Request.QueryString["siklus_id"].ToString());

    }
    protected void d_kaydet_Click1(object sender, ImageClickEventArgs e)
    {




        string siklus_id4 = Request.QueryString["siklus_id"].ToString();

        MySqlConnection mp_connection3 = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_dat = new MySqlDataAdapter("Select * from heyetraporsonuclari where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection3);
        DataTable mp_dtt = new DataTable();
        mp_dat.Fill(mp_dtt);

        if (mp_dtt.Rows.Count == 1)
        {


            if (txtalan9.Text.TrimEnd().TrimStart() != "")
            {
                string slmim = "";
                slmim = "Update heyetraporsonuclari set siklusiptal2 = '+' where siklus_id=" + siklus_id4 + "";

                MySqlCommand cmd88 = new MySqlCommand(slmim, mp_connection3);

                mp_connection3.Open();
                int eks88 = cmd88.ExecuteNonQuery();
                mp_connection3.Close();

                HttpCookie islemdekihastasm = Request.Cookies["HastaBilgi"];
                String hasta_id3 = islemdekihastasm["HastaID"];

                HttpCookie mpKullanilan1 = Request.Cookies["AdminK"];
                string kullaniciAdiAdmint = mpKullanilan1["AdminKKA"].ToString();
                string islem8 = mp_class.hasta_adi_bul(hasta_id3) + " adlı hastanın siklusunun iptali";
                mp_class.log_kaydet(kullaniciAdiAdmint, islem8);

                if (txtalan9.Text.TrimEnd().TrimStart() != "")
                {

                    MySqlCommand cmd89 = new MySqlCommand("Update siklus_ana_tab set varsayilan = null where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection3);
                    mp_connection3.Open();
                    int eks89 = cmd89.ExecuteNonQuery();
                    mp_connection3.Close();


                }



            }




            if (rbopuyapildimi.SelectedIndex == 0)
            {


                MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set opu = '+' where siklus_id=" + siklus_id4 + "", mp_connection3);

                mp_connection3.Open();
                int eks = cmd.ExecuteNonQuery();
                mp_connection3.Close();


                MySqlCommand cmd2 = new MySqlCommand("Update kisa_siklus set ovulasyon='+',opuyapildimi='+' where siklus_id=" + siklus_id4 + "", mp_connection3);
                mp_connection3.Open();
                int eks2 = cmd2.ExecuteNonQuery();
                mp_connection3.Close();


            }
            else if (rbopuyapildimi.SelectedIndex == 1)
            {

                MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set opuiptal = '+' where siklus_id=" + siklus_id4 + "", mp_connection3);

                mp_connection3.Open();
                int eks = cmd.ExecuteNonQuery();
                mp_connection3.Close();


                MySqlCommand cmd2 = new MySqlCommand("Update kisa_siklus set gebelik='-',ovulasyon='-',opuyapildimi='-',alan9='OPU İptal' where siklus_id=" + siklus_id4 + "", mp_connection3);
                mp_connection3.Open();
                int eks2 = cmd2.ExecuteNonQuery();
                mp_connection3.Close();




            }


            if (rbembriyoolustumu.SelectedIndex == 0)
            {
                MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set transfer = '+' where siklus_id=" + siklus_id4 + "", mp_connection3);

                mp_connection3.Open();
                int eks = cmd.ExecuteNonQuery();
                mp_connection3.Close();


                MySqlCommand cmd2 = new MySqlCommand("Update kisa_siklus set ovulasyon='+',opuyapildimi='+',embriyoolustumu='+' where siklus_id=" + siklus_id4 + "", mp_connection3);
                mp_connection3.Open();
                int eks2 = cmd2.ExecuteNonQuery();
                mp_connection3.Close();
            }
            else if (rbembriyoolustumu.SelectedIndex == 1)
            {

                MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set transferiptal = '+' where siklus_id=" + siklus_id4 + "", mp_connection3);

                mp_connection3.Open();
                int eks = cmd.ExecuteNonQuery();
                mp_connection3.Close();


                MySqlCommand cmd2 = new MySqlCommand("Update kisa_siklus set gebelik='-',ovulasyon='+',opuyapildimi='+',alan9='ET İptal',embriyoolustumu='-' where siklus_id=" + siklus_id4 + "", mp_connection3);
                mp_connection3.Open();
                int eks2 = cmd2.ExecuteNonQuery();
                mp_connection3.Close();

            }


        }

        ksacilan();


        try
        {
            if (txtsat.Text == "")
            {

                Panel3.Visible = true;
                Label5.Text = "SAT Tarihi Boş Geçilemez !";
                Label5.ForeColor = System.Drawing.Color.Red;

            }


            else
            {
                DateTime dtar = mp_class.tarihcevir2(txtsat.Text.Trim());


                HttpCookie islemdekihastas = Request.Cookies["HastaBilgi"];
                String hasta_ids = islemdekihastas["HastaID"];

                MySqlConnection connect_words = mp_class.connect_ivf(0301009184);

                MySqlDataAdapter mp_das = new MySqlDataAdapter("Select siklus_id from siklus_ana_tab where hasta_id='" + hasta_ids + "' and varsayilan='+'", connect_words);
                DataTable mp_dts = new DataTable();
                mp_das.Fill(mp_dts);

                if (dtar > DateTime.Now.Date)
                {

                    Panel3.Visible = true;
                    Label5.Text = "SAT Geçerli Bir Tarih Değil yada Güncel Tarihten Büyük !";
                    Label5.ForeColor = System.Drawing.Color.Red;

                    txtsat.Focus();

                }
                else if (txttedaviprotokolu.SelectedValue == "54" && mp_dts.Rows.Count > 0 && mp_dts.Rows[0]["siklus_id"].ToString() != Request.QueryString["siklus_id"].ToString())
                {

                    Panel3.Visible = true;
                    Label5.Text = "Hastanın Tedavisi sonlandırılmamış takipte bir siklusu var.Bu siklusun frozen siklus olabilmesi için öncelikle takipteki tedavininin sonlandırılması gerekmektedir !";
                    Label5.ForeColor = System.Drawing.Color.Red;

                }

                else
                {


                    if (txtbazal.Text.Length != 0)
                    {

                        try
                        {
                            DateTime dtar2 = mp_class.tarihcevir2(DateTime.Parse(txtbazal.Text.Trim()).ToShortDateString());

                            if (dtar2 > DateTime.Now.Date)
                            {

                                Panel3.Visible = true;
                                Label5.Text = "Bazal Tarihi Geçerli Bir Tarih Değil yada Güncel Tarihten Büyük !";
                                Label5.ForeColor = System.Drawing.Color.Red;


                                txtbazal.Focus();

                            }
                        }
                        catch
                        {

                            Panel3.Visible = true;
                            Label5.Text = "Bazal Tarihi Geçerli Bir Tarih Değil yada Güncel Tarihten Büyük !";
                            Label5.ForeColor = System.Drawing.Color.Red;


                            txtbazal.Focus();
                        }


                    }



                    HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
                    String hasta_id = islemdekihasta["HastaID"];

                    MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

                    MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
                    DataTable mp_dt = new DataTable();
                    mp_da.Fill(mp_dt);

                    string siklus_sql = "";
                    MySqlCommand mp_cmd = new MySqlCommand();

                    if (mp_dt.Rows.Count == 0)
                    {
                        siklus_sql = "insert into kisa_siklus(sat,siklus_id,tani1,tani2,tani3,tani4,kurum_id,tedavi_turu_id,tedavi_protokolu,oi,iui,ivf,gebelik,biyokimyasal,dogum,agirlik,pcos,antralsag,antralsol,oversag,oversol,bazaltarih,fsh,lh,e2,ovulasyon,kullanilan_fsh,cogul,hiperstimulasyon,tarih,alan1,alan2,alan3,alan4,alan5,alan6,alan7,alan8,alan9,alan10,abortus,istatistik,opuyapildimi,gv,olgun,bilinmeyen,dollenen,embriyoolustumu,transferedilenembriyo,frozen,kalan,dejenere,olusanYumurta,postm,zona,gebeliksayisi,monokoryonik,fkh,kese) values(?1,?2,?3,?4,?5,?6,?7,?8,?9,?10,?11,?12,?13,?14,?15,?16,?17,?18,?19,?20,?21,?22,?23,?24,?25,?26,?27,?28,?29,?30,?31,?32,?33,?34,?35,?36,?37,?38,?39,?40,?41,?42,?43,?44,?45,?46,?47,?48,?49,?50,?51,?52,?53,?54,?55,?56,?57,?58,?59)";
                        mp_cmd.CommandText = siklus_sql;
                        mp_cmd.Connection = connect_word;


                        mp_cmd.Parameters.AddWithValue("?1", mp_class.tarihcevir2(txtsat.Text.Trim()).ToString().Substring(0, 10));
                        mp_cmd.Parameters.AddWithValue("?2", Request.QueryString["siklus_id"].ToString());
                        mp_cmd.Parameters.AddWithValue("?3", txttani1.Text);
                        mp_cmd.Parameters.AddWithValue("?4", txttani2.Text);

                        mp_cmd.Parameters.AddWithValue("?5", txttani3.Text);
                        mp_cmd.Parameters.AddWithValue("?6", txttani4.Text);
                        mp_cmd.Parameters.AddWithValue("?7", txtkurum.SelectedValue.ToString());
                        mp_cmd.Parameters.AddWithValue("?8", txttedavituru.SelectedValue.ToString());

                        mp_cmd.Parameters.AddWithValue("?9", txttedaviprotokolu.SelectedValue.ToString());
                        mp_cmd.Parameters.AddWithValue("?10", txtoi.Text);
                        mp_cmd.Parameters.AddWithValue("?11", txtiui.Text);
                        mp_cmd.Parameters.AddWithValue("?12", txtivf.Text);
                        string gebelik = "";
                        if (txtgebelik.SelectedValue == "+")
                        {
                            gebelik = "+";
                        }
                        else if (txtgebelik.SelectedValue == "-")
                        {
                            gebelik = "-";

                        }
                        else
                        {
                            gebelik = null;
                        }

                        string biyokimyasal = "";
                        if (txtbiyokimyasal.SelectedValue == "+")
                        {
                            biyokimyasal = "+";
                        }
                        else if (txtbiyokimyasal.SelectedValue == "-")
                        {
                            biyokimyasal = "-";

                        }
                        else
                        {
                            biyokimyasal = null;
                        }
                        string dogum = "";

                        if (txtdogum.SelectedValue == "+")
                        {
                            dogum = "+";
                        }
                        else if (txtdogum.SelectedValue == "-")
                        {
                            dogum = "-";

                        }
                        else
                        {
                            dogum = null;
                        }

                        string abortus = "";
                        if (txtabortus.SelectedValue == "+")
                        {
                            abortus = "+";
                        }
                        else if (txtabortus.SelectedValue == "-")
                        {
                            abortus = "-";
                        }
                        else
                        {
                            abortus = null;
                        }

                        mp_cmd.Parameters.AddWithValue("?13", gebelik);
                        mp_cmd.Parameters.AddWithValue("?14", biyokimyasal);


                        mp_cmd.Parameters.AddWithValue("?15", dogum);
                        mp_cmd.Parameters.AddWithValue("?16", txtagirlik.Text);
                        string pcos = "";

                        if (txtpcos.Checked)
                        {
                            pcos = "+";
                        }
                        else
                        {
                            pcos = "-";

                        }


                        mp_cmd.Parameters.AddWithValue("?17", pcos.ToString());
                        mp_cmd.Parameters.AddWithValue("?18", txtantralsag.Text);
                        mp_cmd.Parameters.AddWithValue("?19", txtantralsol.Text);
                        mp_cmd.Parameters.AddWithValue("?20", txtoversag.Text);
                        mp_cmd.Parameters.AddWithValue("?21", txtoversol.Text);

                        string bzl = string.Empty;

                        if (txtbazal.Text.Length != 0)
                        {
                            bzl = mp_class.tarihcevir2(txtbazal.Text).ToString().Substring(0, 10);

                            if (DateTime.Parse(bzl) == DateTime.Now.Date.AddYears(3))
                            {

                                bzl = string.Empty;


                            }

                        }
                        else
                        {
                            bzl = "";


                        }

                        mp_cmd.Parameters.AddWithValue("?22", bzl);
                        mp_cmd.Parameters.AddWithValue("?23", txtfsh.Text);
                        mp_cmd.Parameters.AddWithValue("?24", txtlh.Text);

                        mp_cmd.Parameters.AddWithValue("?25", txte2.Text);

                        string ovulas = "";
                        if (txtovulasyon.SelectedValue == "+")
                        {
                            ovulas = "+";

                        }
                        else if (txtovulasyon.SelectedValue == "-")
                        {
                            ovulas = "-";
                        }
                        else if (txtovulasyon.SelectedValue == "0")
                        {
                            ovulas = "0";
                        }
                        else
                        {
                            ovulas = null;
                        }
                        mp_cmd.Parameters.AddWithValue("?26", ovulas);

                        mp_cmd.Parameters.AddWithValue("?27", txtkullanilanfsh.Text);


                        string cgl = "";
                        if (txtcogul.SelectedValue == "+")
                        {
                            cgl = "+";
                        }
                        else if (txtcogul.SelectedValue == "-")
                        {
                            cgl = "-";
                        }
                        else
                        {
                            cgl = null;
                        }


                        mp_cmd.Parameters.AddWithValue("?28", cgl);

                        string hipers = "";
                        if (txthiperstimulasyon.SelectedValue == "+")
                        {
                            hipers = "+";
                        }
                        else if (txthiperstimulasyon.SelectedValue == "-")
                        {
                            hipers = "-";
                        }
                        else
                        {
                            hipers = null;
                        }


                        mp_cmd.Parameters.AddWithValue("?29", hipers);

                        mp_cmd.Parameters.AddWithValue("?30", DateTime.Now.ToString());


                        mp_cmd.Parameters.AddWithValue("?31", txtalan1.Text);

                        mp_cmd.Parameters.AddWithValue("?32", txtalan2.Text);

                        mp_cmd.Parameters.AddWithValue("?33", txtalan3.Text);
                        mp_cmd.Parameters.AddWithValue("?34", txtalan4.Text);
                        mp_cmd.Parameters.AddWithValue("?35", txtalan5.Text);
                        mp_cmd.Parameters.AddWithValue("?36", txtalan6.Text);
                        mp_cmd.Parameters.AddWithValue("?37", txtalan7.Text);
                        mp_cmd.Parameters.AddWithValue("?38", txtalan8.Text);
                        mp_cmd.Parameters.AddWithValue("?39", txtalan9.Text);
                        mp_cmd.Parameters.AddWithValue("?40", txtalan10.Text);
                        mp_cmd.Parameters.AddWithValue("?41", abortus);

                        string istatistik = null;
                        if (chbistatistik.Checked)
                        {
                            istatistik = "+";
                        }
                        else
                        {

                            istatistik = null;
                        }

                        mp_cmd.Parameters.AddWithValue("?42", istatistik);

                        string oyapildimi = null;
                        string gv = null;
                        string olgun = null;
                        string bilinmeyen = null;
                        string dollenen = null;
                        string embriyoolustumu = null;
                        string transferedilenembriyosayisi = null;
                        string frozen = null;
                        string kalan = null;

                        string dejenere = null;
                        string postm = null;
                        string olusan = null;
                        string zona = null;



                        if (rbopuyapildimi.SelectedIndex == 0)
                        {
                            oyapildimi = "+";
                        }
                        else if (rbopuyapildimi.SelectedIndex == 1)
                        {
                            oyapildimi = "-";
                        }
                        else
                        {
                            oyapildimi = null;
                        }

                        if (txtgv.Text.TrimEnd().TrimStart() != "")
                        {
                            gv = txtgv.Text;

                        }
                        else
                        {
                            gv = null;
                        }

                        if (txtolgun.Text.TrimEnd().TrimStart() != "")
                        {
                            olgun = txtolgun.Text;
                        }
                        else
                        {
                            olgun = null;
                        }


                        if (txtOlusanYumurta.Text.TrimEnd().TrimStart() != "")
                        {
                            olusan = txtOlusanYumurta.Text;
                        }
                        else
                        {
                            olusan = null;
                        }

                        if (txtPostM.Text.TrimEnd().TrimStart() != "")
                        {
                            postm = txtPostM.Text;
                        }
                        else
                        {
                            postm = null;
                        }


                        if (txtZona.Text.TrimEnd().TrimStart() != "")
                        {
                            zona = txtZona.Text;
                        }
                        else
                        {
                            zona = null;
                        }

                        if (txtDejenere.Text.TrimEnd().TrimStart() != "")
                        {
                            dejenere = txtDejenere.Text;
                        }
                        else
                        {
                            dejenere = null;
                        }


                        if (txtbilinmeyen.Text.TrimEnd().TrimStart() != "")
                        {
                            bilinmeyen = txtbilinmeyen.Text;
                        }
                        else
                        {
                            bilinmeyen = null;
                        }
                        if (txtdollenen.Text.TrimEnd().TrimStart() != "")
                        {
                            dollenen = txtdollenen.Text;
                        }
                        else
                        {
                            dollenen = null;
                        }
                        if (rbembriyoolustumu.SelectedIndex == 0)
                        {
                            embriyoolustumu = "+";
                        }
                        else if (rbembriyoolustumu.SelectedIndex == 1)
                        {
                            embriyoolustumu = "-";
                        }
                        else
                        {
                            embriyoolustumu = null;
                        }
                        if (txttransferedilenembriyo.Text.TrimEnd().TrimStart() != "")
                        {
                            transferedilenembriyosayisi = txttransferedilenembriyo.Text;
                        }
                        else
                        {
                            transferedilenembriyosayisi = null;
                        }

                        if (txtfrozen.Text.TrimEnd().TrimStart() != "")
                        {
                            frozen = txtfrozen.Text;
                        }
                        else
                        {
                            frozen = null;
                        }
                        if (txtkalan.Text.TrimEnd().TrimStart() != "")
                        {
                            kalan = txtkalan.Text;
                        }
                        else
                        {
                            kalan = null;
                        }


                        mp_cmd.Parameters.AddWithValue("?43", oyapildimi);
                        mp_cmd.Parameters.AddWithValue("?44", gv);
                        mp_cmd.Parameters.AddWithValue("?45", olgun);
                        mp_cmd.Parameters.AddWithValue("?46", bilinmeyen);
                        mp_cmd.Parameters.AddWithValue("?47", dollenen);
                        mp_cmd.Parameters.AddWithValue("?48", embriyoolustumu);
                        mp_cmd.Parameters.AddWithValue("?49", transferedilenembriyosayisi);
                        mp_cmd.Parameters.AddWithValue("?50", frozen);
                        mp_cmd.Parameters.AddWithValue("?51", kalan);
                        mp_cmd.Parameters.AddWithValue("?52", dejenere);
                        mp_cmd.Parameters.AddWithValue("?53", olusan);
                        mp_cmd.Parameters.AddWithValue("?54", postm);
                        mp_cmd.Parameters.AddWithValue("?55", zona);
                        mp_cmd.Parameters.AddWithValue("?56", txtgebeliksayisi.Text);
                        mp_cmd.Parameters.AddWithValue("?57", txtmonokoryonik.Text);
                        mp_cmd.Parameters.AddWithValue("?58", txtFKH.Text);
                        mp_cmd.Parameters.AddWithValue("?59", txtkesesayisi.Text);



                        //string alnpro = string.Empty;

                        //if (txtalan2.Text.ToString() != "")
                        //{
                        //    alnpro = "+";
                        //}



                        //MySqlParameter parametre42 = new MySqlParameter("parametre42", alnpro);


                        connect_word.Open();
                        int eks = mp_cmd.ExecuteNonQuery();
                        connect_word.Close();



                        tarihguncelle();


                        frozen2();

                        if (eks == 1)
                        {

                            Panel3.Visible = true;
                            Label5.Text = "Kısa Siklus Güncelleştirilmesi Başarıyla Gerçekleştirildi.";
                            Label5.ForeColor = System.Drawing.Color.Green;



                            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

                            string islem = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın " + Label4.Text + " kısa siklusunun güncellenmesi";

                            mp_class.log_kaydet(kullaniciAdiAdmin, islem);


                            kutularikapat();

                            guncelleyen();

                            sat_kaydet();

                            inferekle("26", "9", "21.Gün Progesteron : " + txtalan2.Text);


                            if (Session["kriterler"] != null)
                            {
                                string[] dizim = Session["kriterler"].ToString().Split('|');

                                if (dizim[0] == "0000066.aspx" && Request.QueryString["g"] == "takipli")
                                {

                                    Session.Add("kriterler2", Session["kriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000066.aspx");

                                }

                            }

                            if (Session["etkriterler"] != null)
                            {
                                string[] dizim = Session["etkriterler"].ToString().Split('|');

                                if (dizim[0] == "0000101.aspx" && Request.QueryString["g"] == "et")
                                {

                                    Session.Add("etkriterler2", Session["etkriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000101.aspx");

                                }

                            }


                            if (Session["etkriterler103"] != null)
                            {
                                string[] dizim = Session["etkriterler103"].ToString().Split('|');

                                if (dizim[0] == "0000103.aspx" && Request.QueryString["g"] == "et")
                                {

                                    Session.Add("etkriterler2103", Session["etkriterler103"]);
                                    Response.Redirect("~/ivfyonetici/0000103.aspx");

                                }

                            }

                            if (Session["opukriterler"] != null)
                            {
                                string[] dizim = Session["opukriterler"].ToString().Split('|');

                                if (dizim[0] == "0000070.aspx" && Request.QueryString["g"] == "sat")
                                {

                                    Session.Add("opukriterler2", Session["opukriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000070.aspx");

                                }

                            }

                            if (Session["sikluskriterler"] != null)
                            {
                                string[] dizim = Session["sikluskriterler"].ToString().Split('|');

                                if (dizim[0] == "0000063.aspx" && Request.QueryString["g"] == "siklus")
                                {

                                    Session.Add("sikluskriterler2", Session["sikluskriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000063.aspx");

                                }

                            }



                            kisasiklusyukle();

                        }

                        else
                        {

                            Panel3.Visible = true;
                            Label5.Text = "Kısa Siklus Güncellenirken Hata Oluştu.İşlem Başarısız !";
                            Label5.ForeColor = System.Drawing.Color.Red;

                        }


                    }

                    else if (mp_dt.Rows.Count == 1)
                    {

                        siklus_sql = "update kisa_siklus set sat=?1,tani1=?2,tani2=?3,tani3=?4,tani4=?5,kurum_id=?6,tedavi_turu_id=?7,tedavi_protokolu=?8,oi=?9,iui=?10,ivf=?11,gebelik=?12,biyokimyasal=?13,dogum=?14,agirlik=?15,pcos=?16,antralsag=?17,antralsol=?18,oversag=?19,oversol=?20,bazaltarih=?21,fsh=?22,lh=?23,e2=?24,ovulasyon=?25,kullanilan_fsh=?26,cogul=?27,hiperstimulasyon=?28,alan1=?29,alan2=?30,alan3=?31,alan4=?32,alan5=?33,alan6=?34,alan7=?35,alan8=?36,alan9=?37,alan10=?38,abortus=?39,istatistik=?41,opuyapildimi=?42,gv=?43,olgun=?44,bilinmeyen=?45,dollenen=?46,embriyoolustumu=?47,transferedilenembriyo=?48,frozen=?49,kalan=?50,dejenere=?51,olusanYumurta=?52,postm=?53,zona=?54,gebeliksayisi=?55,monokoryonik=?56,fkh=?57,kese=?58 where siklus_id=?40";

                        mp_cmd.CommandText = siklus_sql;
                        mp_cmd.Connection = connect_word;


                        string gebelik = "";
                        if (txtgebelik.SelectedValue == "+")
                        {
                            gebelik = "+";
                        }
                        else if (txtgebelik.SelectedValue == "-")
                        {
                            gebelik = "-";

                        }
                        else
                        {
                            gebelik = null;
                        }

                        string biyokimyasal = "";
                        if (txtbiyokimyasal.SelectedValue == "+")
                        {
                            biyokimyasal = "+";
                        }
                        else if (txtbiyokimyasal.SelectedValue == "-")
                        {
                            biyokimyasal = "-";

                        }
                        else
                        {
                            biyokimyasal = null;
                        }
                        string dogum = "";

                        if (txtdogum.SelectedValue == "+")
                        {
                            dogum = "+";
                        }
                        else if (txtdogum.SelectedValue == "-")
                        {
                            dogum = "-";

                        }
                        else
                        {
                            dogum = null;
                        }

                        string abortus = "";
                        if (txtabortus.SelectedValue == "+")
                        {
                            abortus = "+";
                        }
                        else if (txtabortus.SelectedValue == "-")
                        {
                            abortus = "-";
                        }
                        else
                        {
                            abortus = null;
                        }

                        mp_cmd.Parameters.AddWithValue("?1", mp_class.tarihcevir2(txtsat.Text.Trim()).ToString().Substring(0, 10));
                        mp_cmd.Parameters.AddWithValue("?2", txttani1.Text);
                        mp_cmd.Parameters.AddWithValue("?3", txttani2.Text);

                        mp_cmd.Parameters.AddWithValue("?4", txttani3.Text);
                        mp_cmd.Parameters.AddWithValue("?5", txttani4.Text);
                        mp_cmd.Parameters.AddWithValue("?6", txtkurum.SelectedValue.ToString());
                        mp_cmd.Parameters.AddWithValue("?7", txttedavituru.SelectedValue.ToString());

                        mp_cmd.Parameters.AddWithValue("?8", txttedaviprotokolu.Text);
                        mp_cmd.Parameters.AddWithValue("?9", txtoi.Text);
                        mp_cmd.Parameters.AddWithValue("?10", txtiui.Text);
                        mp_cmd.Parameters.AddWithValue("?11", txtivf.Text);

                        mp_cmd.Parameters.AddWithValue("?12", gebelik);
                        mp_cmd.Parameters.AddWithValue("?13", biyokimyasal);


                        mp_cmd.Parameters.AddWithValue("?14", dogum);
                        mp_cmd.Parameters.AddWithValue("?15", txtagirlik.Text);
                        string pcos = "";

                        if (txtpcos.Checked)
                        {
                            pcos = "+";
                        }
                        else
                        {
                            pcos = "-";

                        }
                        mp_cmd.Parameters.AddWithValue("?16", pcos.ToString());
                        mp_cmd.Parameters.AddWithValue("?17", txtantralsag.Text);
                        mp_cmd.Parameters.AddWithValue("?18", txtantralsol.Text);
                        mp_cmd.Parameters.AddWithValue("?19", txtoversag.Text);
                        mp_cmd.Parameters.AddWithValue("?20", txtoversol.Text);


                        string bzl = string.Empty;

                        if (txtbazal.Text.Length != 0)
                        {
                            bzl = mp_class.tarihcevir2(txtbazal.Text).ToString().Substring(0, 10);

                            if (DateTime.Parse(bzl) == DateTime.Now.Date.AddYears(3))
                            {

                                bzl = string.Empty;


                            }

                        }
                        else
                        {
                            bzl = "";


                        }





                        mp_cmd.Parameters.AddWithValue("?21", bzl);
                        mp_cmd.Parameters.AddWithValue("?22", txtfsh.Text);
                        mp_cmd.Parameters.AddWithValue("?23", txtlh.Text);

                        mp_cmd.Parameters.AddWithValue("?24", txte2.Text);

                        string ovulas = "";
                        if (txtovulasyon.SelectedValue == "+")
                        {
                            ovulas = "+";

                        }
                        else if (txtovulasyon.SelectedValue == "-")
                        {
                            ovulas = "-";
                        }
                        else if (txtovulasyon.SelectedValue == "0")
                        {
                            ovulas = "0";
                        }
                        else
                        {
                            ovulas = null;
                        }
                        mp_cmd.Parameters.AddWithValue("?25", ovulas);

                        mp_cmd.Parameters.AddWithValue("?26", txtkullanilanfsh.Text);



                        string cgl = "";
                        if (txtcogul.SelectedValue == "+")
                        {
                            cgl = "+";
                        }
                        else if (txtcogul.SelectedValue == "-")
                        {
                            cgl = "-";
                        }
                        else
                        {
                            cgl = null;
                        }


                        mp_cmd.Parameters.AddWithValue("?27", cgl);

                        string hipers = "";
                        if (txthiperstimulasyon.SelectedValue == "+")
                        {
                            hipers = "+";
                        }
                        else if (txthiperstimulasyon.SelectedValue == "-")
                        {
                            hipers = "-";
                        }
                        else
                        {
                            hipers = null;
                        }


                        mp_cmd.Parameters.AddWithValue("?28", hipers);

                        mp_cmd.Parameters.AddWithValue("?40", int.Parse(Request.QueryString["siklus_id"].ToString()));


                        mp_cmd.Parameters.AddWithValue("?29", txtalan1.Text);

                        mp_cmd.Parameters.AddWithValue("?30", txtalan2.Text);

                        mp_cmd.Parameters.AddWithValue("?31", txtalan3.Text);
                        mp_cmd.Parameters.AddWithValue("?32", txtalan4.Text);
                        mp_cmd.Parameters.AddWithValue("?33", txtalan5.Text);
                        mp_cmd.Parameters.AddWithValue("?34", txtalan6.Text);
                        mp_cmd.Parameters.AddWithValue("?35", txtalan7.Text);
                        mp_cmd.Parameters.AddWithValue("?36", txtalan8.Text);
                        mp_cmd.Parameters.AddWithValue("?37", txtalan9.Text);
                        mp_cmd.Parameters.AddWithValue("?38", txtalan10.Text);
                        mp_cmd.Parameters.AddWithValue("?39", abortus);


                        string istatistik = null;
                        if (chbistatistik.Checked)
                        {
                            istatistik = "+";
                        }
                        else
                        {

                            istatistik = null;
                        }
                        mp_cmd.Parameters.AddWithValue("?41", istatistik);


                        string oyapildimi = null;
                        string gv = null;
                        string olgun = null;
                        string bilinmeyen = null;
                        string dollenen = null;
                        string embriyoolustumu = null;
                        string transferedilenembriyosayisi = null;
                        string frozen = null;
                        string kalan = null;
                        string olusan = null;
                        string dejenere = null;
                        string postm = null;
                        string zona = null;

                        if (rbopuyapildimi.SelectedIndex == 0)
                        {
                            oyapildimi = "+";
                        }
                        else if (rbopuyapildimi.SelectedIndex == 1)
                        {
                            oyapildimi = "-";
                        }
                        else
                        {
                            oyapildimi = null;
                        }

                        if (txtgv.Text.TrimEnd().TrimStart() != "")
                        {
                            gv = txtgv.Text;

                        }
                        else
                        {
                            gv = null;
                        }

                        if (txtolgun.Text.TrimEnd().TrimStart() != "")
                        {
                            olgun = txtolgun.Text;
                        }
                        else
                        {
                            olgun = null;
                        }

                        if (txtbilinmeyen.Text.TrimEnd().TrimStart() != "")
                        {
                            bilinmeyen = txtbilinmeyen.Text;
                        }
                        else
                        {
                            bilinmeyen = null;
                        }
                        if (txtdollenen.Text.TrimEnd().TrimStart() != "")
                        {
                            dollenen = txtdollenen.Text;
                        }
                        else
                        {
                            dollenen = null;
                        }
                        if (rbembriyoolustumu.SelectedIndex == 0)
                        {
                            embriyoolustumu = "+";
                        }
                        else if (rbembriyoolustumu.SelectedIndex == 1)
                        {
                            embriyoolustumu = "-";
                        }
                        else
                        {
                            embriyoolustumu = null;
                        }
                        if (txttransferedilenembriyo.Text.TrimEnd().TrimStart() != "")
                        {
                            transferedilenembriyosayisi = txttransferedilenembriyo.Text;
                        }
                        else
                        {
                            transferedilenembriyosayisi = null;
                        }

                        if (txtfrozen.Text.TrimEnd().TrimStart() != "")
                        {
                            frozen = txtfrozen.Text;
                        }
                        else
                        {
                            frozen = null;
                        }
                        if (txtkalan.Text.TrimEnd().TrimStart() != "")
                        {
                            kalan = txtkalan.Text;
                        }
                        else
                        {
                            kalan = null;
                        }


                        if (txtOlusanYumurta.Text.TrimEnd().TrimStart() != "")
                        {
                            olusan = txtOlusanYumurta.Text;
                        }
                        else
                        {
                            olusan = null;
                        }

                        if (txtPostM.Text.TrimEnd().TrimStart() != "")
                        {
                            postm = txtPostM.Text;
                        }
                        else
                        {
                            postm = null;
                        }


                        if (txtZona.Text.TrimEnd().TrimStart() != "")
                        {
                            zona = txtZona.Text;
                        }
                        else
                        {
                            zona = null;
                        }

                        if (txtDejenere.Text.TrimEnd().TrimStart() != "")
                        {
                            dejenere = txtDejenere.Text;
                        }
                        else
                        {
                            dejenere = null;
                        }


                        mp_cmd.Parameters.AddWithValue("?42", oyapildimi);
                        mp_cmd.Parameters.AddWithValue("?43", gv);
                        mp_cmd.Parameters.AddWithValue("?44", olgun);
                        mp_cmd.Parameters.AddWithValue("?45", bilinmeyen);
                        mp_cmd.Parameters.AddWithValue("?46", dollenen);
                        mp_cmd.Parameters.AddWithValue("?47", embriyoolustumu);
                        mp_cmd.Parameters.AddWithValue("?48", transferedilenembriyosayisi);
                        mp_cmd.Parameters.AddWithValue("?49", frozen);
                        mp_cmd.Parameters.AddWithValue("?50", kalan);
                        mp_cmd.Parameters.AddWithValue("?51", dejenere);
                        mp_cmd.Parameters.AddWithValue("?52", olusan);
                        mp_cmd.Parameters.AddWithValue("?53", postm);
                        mp_cmd.Parameters.AddWithValue("?54", zona);
                        mp_cmd.Parameters.AddWithValue("?55", txtgebeliksayisi.Text);
                        mp_cmd.Parameters.AddWithValue("?56", txtmonokoryonik.Text);
                        mp_cmd.Parameters.AddWithValue("?57", txtFKH.Text);
                        mp_cmd.Parameters.AddWithValue("?58", txtkesesayisi.Text);
                        //string alnpro2 = "";

                        //if (txtalan2.Text.ToString() != "")
                        //{
                        //    alnpro2 = "+";
                        //}

                        //MySqlParameter parametre42 = new MySqlParameter("parametre42", alnpro2);



                        //mp_cmd.Parameters.Add(parametre42);

                        connect_word.Open();
                        int eks = mp_cmd.ExecuteNonQuery();
                        connect_word.Close();

                        tarihguncelle();
                        frozen2();


                        if (eks == 1)
                        {

                            Panel3.Visible = true;
                            Label5.Text = "Kısa Siklus Güncelleştirilmesi Başarıyla Gerçekleştirildi.";
                            Label5.ForeColor = System.Drawing.Color.Green;


                            HttpCookie mpKullanilan2 = Request.Cookies["AdminK"];
                            string kullaniciAdiAdmin2 = mpKullanilan2["AdminKKA"].ToString();

                            string islem2 = mp_class.hasta_adi_bul(hasta_id) + " isimli hastanın " + Label4.Text + " kısa siklusunun güncellenmesi";

                            mp_class.log_kaydet(kullaniciAdiAdmin2, islem2);



                            kutularikapat();

                            guncelleyen();


                            sat_kaydet();

                            inferekle("26", "9", "21.Gün Progesteron : " + txtalan2.Text);

                            if (Session["kriterler"] != null)
                            {
                                string[] dizim = Session["kriterler"].ToString().Split('|');

                                if (dizim[0] == "0000066.aspx" && Request.QueryString["g"] == "takipli")
                                {
                                    Session.Add("kriterler2", Session["kriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000066.aspx");

                                }
                            }

                            if (Session["etkriterler"] != null)
                            {
                                string[] dizim = Session["etkriterler"].ToString().Split('|');

                                if (dizim[0] == "0000101.aspx" && Request.QueryString["g"] == "et")
                                {

                                    Session.Add("etkriterler2", Session["etkriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000101.aspx");

                                }

                            }


                            if (Session["etkriterler103"] != null)
                            {
                                string[] dizim = Session["etkriterler103"].ToString().Split('|');

                                if (dizim[0] == "0000103.aspx" && Request.QueryString["g"] == "et")
                                {

                                    Session.Add("etkriterler2103", Session["etkriterler103"]);
                                    Response.Redirect("~/ivfyonetici/0000103.aspx");

                                }

                            }



                            if (Session["opukriterler"] != null)
                            {
                                string[] dizim = Session["opukriterler"].ToString().Split('|');

                                if (dizim[0] == "0000070.aspx" && Request.QueryString["g"] == "sat")
                                {

                                    Session.Add("opukriterler2", Session["opukriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000070.aspx");

                                }

                            }

                            if (Session["sikluskriterler"] != null)
                            {
                                string[] dizim = Session["sikluskriterler"].ToString().Split('|');

                                if (dizim[0] == "0000063.aspx" && Request.QueryString["g"] == "siklus")
                                {

                                    Session.Add("sikluskriterler2", Session["sikluskriterler"]);
                                    Response.Redirect("~/ivfyonetici/0000063.aspx");

                                }

                            }


                            kisasiklusyukle();

                        }

                        else
                        {

                            Panel3.Visible = true;
                            Label5.Text = "Kısa Siklus Güncellenirken Hata Oluştu.İşlem Başarısız !";
                            Label5.ForeColor = System.Drawing.Color.Red;

                        }





                    }

                }



            }

        }


        catch
        {


            Panel3.Visible = true;
            Label5.Text = "Kısa Siklus Güncellenirken Hata Oluştu.İşlem Başarısız !";
            Label5.ForeColor = System.Drawing.Color.Red;

        }
    }

    private void tarihguncelle()
    {
        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from heyetraporsonuclari where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        if (mp_dt.Rows.Count > 0)
        {

            if (mp_dt.Rows[0]["oputarihi"].ToString() != "" && txtalan3.Text != "")
            {
                MySqlCommand cmd1 = new MySqlCommand("Update heyetraporsonuclari set oputarihi = '" + txtalan3.Text + "' where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
                connect_word.Open();
                cmd1.ExecuteNonQuery();
                connect_word.Close();
            }

            if (mp_dt.Rows[0]["transfertarihi"].ToString() != "" && txtalan4.Text != "")
            {


                MySqlCommand cmd2 = new MySqlCommand("Update heyetraporsonuclari set transfertarihi = '" + txtalan4.Text + "' where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
                connect_word.Open();
                cmd2.ExecuteNonQuery();
                connect_word.Close();



            }






        }
    }



    void frozen2()
    {


        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];


        if (txttedaviprotokolu.SelectedValue == "54")
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from heyetraporsonuclari where siklus_id=" + Request.QueryString["siklus_id"].ToString() + " and frozen='+'", connect_word);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);
            if (mp_dt.Rows.Count == 0)
            {


                MySqlCommand cmd1 = new MySqlCommand("Insert into heyetraporsonuclari(hastaID,tedavisurecinde,siklus_id,tedavibaslamatarihi,frozen) values (" + hasta_id + ",'+'," + Request.QueryString["siklus_id"].ToString() + ",'" + DateTime.Now.Date.ToShortDateString() + "','+')", connect_word);
                connect_word.Open();
                cmd1.ExecuteNonQuery();
                connect_word.Close();

                MySqlCommand cmd2 = new MySqlCommand("Update siklus_ana_tab set varsayilan = null where hasta_id='" + hasta_id + "'", connect_word);
                connect_word.Open();
                cmd2.ExecuteNonQuery();
                connect_word.Close();

                MySqlCommand cmd3 = new MySqlCommand("Update siklus_ana_tab set varsayilan='+' where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
                connect_word.Open();
                cmd3.ExecuteNonQuery();
                connect_word.Close();

            }
        }


    }
    private void ksacilan()
    {
        gizlenecek2.Style["display"] = "block";
        ac2.Style["display"] = "none";
        kapa2.Style["display"] = "block";
    }
    private void kskapanan()
    {
        gizlenecek2.Style["display"] = "none";
        ac2.Style["display"] = "block";
        kapa2.Style["display"] = "none";
    }
    //protected void paylas_Command(object sender, CommandEventArgs e)
    //{
    //    try
    //    {

    //        string doktor_id = doktor_list.SelectedValue.ToString();
    //        string siklus_id = Request.QueryString["siklus_id"].ToString();



    //        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
    //        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from hasta_paylas where doktor_id ='" + doktor_id.ToString() + "' and siklus_id='" + siklus_id.ToString() + "'", mp_connection);

    //        DataTable mp_dt2 = new DataTable();
    //        mp_da2.Fill(mp_dt2);

    //        if (mp_dt2.Rows.Count == 1)
    //        {


    //            Panel3.Visible = true;
    //            Label5.Text = "Bu Siklus Seçili Doktora Daha Önce Yetkilendirilmiştir !";
    //            Label5.ForeColor = System.Drawing.Color.Red;

    //        }
    //        else if (mp_dt2.Rows.Count == 0)
    //        {


    //            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
    //            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();


    //            MySqlCommand mp_cmd = new MySqlCommand("insert into hasta_paylas(doktor_id,siklus_id,islem_yapan,tarih) values (?1,?2,?3,?4)", mp_connection);


    //            mp_cmd.Parameters.AddWithValue("?1",doktor_id.ToString());
    //            mp_cmd.Parameters.AddWithValue("?2", siklus_id.ToString());
    //            mp_cmd.Parameters.AddWithValue("?3", mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin).ToString());

    //            mp_cmd.Parameters.AddWithValue("?4", DateTime.Now.ToString());

    //            mp_connection.Open();

    //            int eks = mp_cmd.ExecuteNonQuery();

    //            mp_connection.Close();

    //            if (eks == 1)
    //            {


    //                yetkili_doktor_yukle();


    //                Panel3.Visible = true;
    //                Label5.Text = "Yetkilendirme Başarıyla Gerçekleştirildi.";
    //                Label5.ForeColor = System.Drawing.Color.Green;
    //                mail_gonderimi(doktor_id, siklus_id);




    //            }
    //            else
    //            {
    //                Panel3.Visible = true;
    //                Label5.Text = "Yetkilendirme Esansında Sistem Bir Hata İle Karşılaştı !";
    //                Label5.ForeColor = System.Drawing.Color.Red;

    //            }
    //        }

    //    }

    //    catch
    //    {

    //    }
    //}
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

        //try
        //{

        //    HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        //    String hasta_id = islemdekihasta["HastaID"];

        //    MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        //    MySqlDataAdapter mp_da = new MySqlDataAdapter("select top 1 sat from hasta_sat where hasta_id='" + hasta_id.ToString() + "' order by cdate(sat) desc", mp_connection);
        //    DataTable mp_dt = new DataTable();
        //    mp_da.Fill(mp_dt);

        //    if (mp_dt.Rows.Count == 0)
        //    {


        //        Panel3.Visible = true;
        //        Label5.Text = "Sisteme Kayıtlı Hastaya Ait SAT Bulunamadı !";
        //        Label5.ForeColor = System.Drawing.Color.Red;

        //    }

        //    else
        //    {

        //        txtsat.Text = mp_dt.Rows[0]["sat"].ToString();




        //    }

        //}


        //catch
        //{
        //    Panel3.Visible = true;
        //    Label5.Text = "SAT Yüklenirken Hata Oluştu !";
        //    Label5.ForeColor = System.Drawing.Color.Red;


        //}


        taniyukle();



    }
    void inferekle(string kategori, string alan, string aciklama)
    {


        try
        {


            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from infertilite where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' and aciklama = '" + aciklama + "'", mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            if (mp_dt.Rows.Count == 0 && txtalan2.Text != "")
            {

                MySqlCommand mp_cmd = new MySqlCommand("insert into infertilite(kategori_id,alan_id,siklus_id,hasta_id,aciklama,kayit_tarihi,islem_tarihi,ilk_ekleyen) values (?1,?2,?3,?4,?5,?6,?7,?8)", mp_connection);

                mp_cmd.Parameters.AddWithValue("?1", kategori);
                mp_cmd.Parameters.AddWithValue("?2", alan);
                mp_cmd.Parameters.AddWithValue("?3", Request.QueryString["siklus_id"].ToString());
                mp_cmd.Parameters.AddWithValue("?4", hasta_id.ToString());

                mp_cmd.Parameters.AddWithValue("?5", aciklama);
                mp_cmd.Parameters.AddWithValue("?6", DateTime.Now.ToString());
                mp_cmd.Parameters.AddWithValue("?7", DateTime.Now.ToString().Substring(0, 10));
                mp_cmd.Parameters.AddWithValue("?8", mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin.ToString()));


                mp_connection.Open();

                int eks = mp_cmd.ExecuteNonQuery();

                mp_connection.Close();

                menuyukle2();
            }






        }
        catch
        {

        }




    }
    void sat_kaydet()
    {

        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];


            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from hasta_sat where hasta_id='" + hasta_id.ToString() + "' and sat='" + mp_class.tarihcevir2(txtsat.Text.Trim()).ToString().Substring(0, 10) + "' ", connect_word);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            if (mp_dt.Rows.Count == 0)
            {

                MySqlCommand mp_cmd = new MySqlCommand("insert into hasta_sat(hasta_id,sat,eklenme_tarihi,ekleyen) values ('" + hasta_id.ToString() + "','" + mp_class.tarihcevir2(txtsat.Text.Trim()).ToString().Substring(0, 10) + "','" + DateTime.Now.ToString() + "','" + mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin.ToString()) + "')", connect_word);
                connect_word.Open();

                int eks = mp_cmd.ExecuteNonQuery();

                connect_word.Close();

            }

        }

        catch
        {


        }
    }
    void guncelleyen()
    {

        try
        {


            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();

            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand mp_cmd = new MySqlCommand("insert into kisa_siklus_guncellemeleri(siklus_id,guncelleyen,tarih) values (?1,?2,?3)", mp_connection);

            mp_cmd.Parameters.AddWithValue("?1", Request.QueryString["siklus_id"].ToString());
            mp_cmd.Parameters.AddWithValue("?2", mp_class.doktor_kullanici_adi_bul(kullaniciAdiAdmin.ToString()));

            mp_cmd.Parameters.AddWithValue("?3", DateTime.Now.ToString());

            mp_connection.Open();

            int eks = mp_cmd.ExecuteNonQuery();

            mp_connection.Close();

            if (eks == 1)
            {

            }
            else
            {
                Panel3.Visible = true;
                Label5.Text = "Veriler Güncelleştirildi.Fakat Güncelleştiren Bilgisi Kaydedilemedi !";
                Label5.ForeColor = System.Drawing.Color.Red;

            }

        }

        catch
        {

            Panel3.Visible = true;
            Label5.Text = "Güncelleştiren Bilgisi Kaydedilirken Sistem Bir Hata İle Karşılaştı !";
            Label5.ForeColor = System.Drawing.Color.Red;

        }



    }
    void kutularikapat()
    {
        lblsat.Visible = true;
        txtsat.Visible = false;
        lbltani1.Visible = true;
        txttani1.Visible = false;
        lbltani2.Visible = true;
        txttani2.Visible = false;
        lbltani3.Visible = true;
        txttani3.Visible = false;
        lbltani4.Visible = true;
        txttani4.Visible = false;
        lbltedaviprotokolu.Visible = true;
        txttedaviprotokolu.Visible = false;
        lbloi.Visible = true;
        txtoi.Visible = false;
        lbliui.Visible = true;
        txtiui.Visible = false;
        lblivf.Visible = true;
        txtivf.Visible = false;
        lblgebelik.Visible = true;
        txtgebelik.Visible = false;
        lblabortus.Visible = true;
        txtabortus.Visible = false;
        if (Label1.Text != "aaa")
        {
            lblistatistik.Visible = true;
            chbistatistik.Visible = false;
        }

        lblbiyokimyasal.Visible = true;
        txtbiyokimyasal.Visible = false;
        lbldogum.Visible = true;
        txtdogum.Visible = false;
        lblagirlik.Visible = true;
        txtagirlik.Visible = false;
        lblantralsag.Visible = true;
        txtantralsag.Visible = false;
        lblantralsol.Visible = true;
        txtantralsol.Visible = false;
        lbloversag.Visible = true;
        txtoversag.Visible = false;
        lbloversol.Visible = true;
        txtoversol.Visible = false;
        lblbazal.Visible = true;
        txtbazal.Visible = false;
        lblfsh.Visible = true;
        txtfsh.Visible = false;
        lbllh.Visible = true;
        txtlh.Visible = false;
        lble2.Visible = true;
        txte2.Visible = false;
        lblkullanilanfsh.Visible = true;
        lblgebeliksayisi.Visible = true;
        lblkesesayisi.Visible = true;
        txtkesesayisi.Visible = false;
        txtkullanilanfsh.Visible = false;
        txtgebeliksayisi.Visible = false;
        lblmonokoryonik.Visible = true;
        txtmonokoryonik.Visible = false;
        lblFKH.Visible = true;
        txtFKH.Visible = false;




        txtkurum.Visible = false;
        txttedavituru.Visible = false;

        txtpcos.Visible = false;
        txtovulasyon.Visible = false;
        txtcogul.Visible = false;
        txthiperstimulasyon.Visible = false;
        ImageButton1.Visible = false;
     


        d_kaydet.Visible = false;
        btnKaydet.Visible = true;

        ipt.Visible = false;
        lblkurum.Visible = true;
        lbltedavituru.Visible = true;

        lblpcos.Visible = true;
        lblovulasyon.Visible = true;
        lblcogul.Visible = true;
        lblhiperstimulasyon.Visible = true;




        txtalan1.Visible = false;
        txtalan2.Visible = false;
        txtalan3.Visible = false;
        txtalan4.Visible = false;
        txtalan5.Visible = false;
        txtalan6.Visible = false;
        txtalan7.Visible = false;
        txtalan8.Visible = false;
        txtalan9.Visible = false;
        txtalan10.Visible = false;






        lblopuyapildimi.Visible = true;
        rbopuyapildimi.Visible = false;

        lblgv.Visible = true;
        lblolgun.Visible = true;
        lblbilinmeyen.Visible = true;
        lblOlusanYumurta.Visible = true;

        txtgv.Visible = false;
        txtolgun.Visible = false;
        txtbilinmeyen.Visible = false;

        lblDejenere.Visible = true;
        lblPostM.Visible = true;
        lblZona.Visible = true;

        txtDejenere.Visible = false;
        txtPostM.Visible = false;
        txtZona.Visible = false;
        txtOlusanYumurta.Visible = false;

        lbldollenen.Visible = true;
        txtdollenen.Visible = false;

        lblembriyooluştumu.Visible = true;
        rbembriyoolustumu.Visible = false;

        lbltransferedilenembriyo.Visible = true;
        txttransferedilenembriyo.Visible = false;

        lblfrozen.Visible = true;
        txtfrozen.Visible = false;

        lblkalan.Visible = true;
        txtkalan.Visible = false;




    }


    //void yetkili_doktor_yukle()
    //{

    //    try
    //    {

    //        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);


    //        MySqlDataAdapter mp_da3 = new MySqlDataAdapter("select * from hasta_paylas where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", mp_connection);
    //        DataTable mp_dt3 = new DataTable();
    //        mp_da3.Fill(mp_dt3);


    //        doktorlistesi.DataSource = mp_dt3;
    //        doktorlistesi.DataBind();

    //        int k = 0;
    //        foreach (DataListItem satir in doktorlistesi.Items)
    //        {
    //            MySqlDataAdapter mp_da4 = new MySqlDataAdapter("select * from uye_doktor where uye_id=" + mp_dt3.Rows[k]["doktor_id"].ToString() + "", mp_connection);
    //            DataTable mp_dt4 = new DataTable();
    //            mp_da4.Fill(mp_dt4);

    //            Label doktorunadi = new Label();
    //            LinkButton kal = new LinkButton();

    //            doktorunadi = (Label)satir.FindControl("doktor_adi");
    //            kal = (LinkButton)satir.FindControl("kaldir");
    //            doktorunadi.Text = mp_dt4.Rows[0]["uye_adi"].ToString() + " " + mp_dt4.Rows[0]["uye_soyadi"].ToString();

    //            kal.CommandArgument = mp_dt3.Rows[k]["doktor_id"].ToString();

    //            k++;



    //        }





    //    }

    //    catch
    //    {


    //    }



    //}
    void kisasiklusyukle()
    {
        //try
        //{


        //doldur();


        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];


        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);


        MySqlDataAdapter mp_da10 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", connect_word);
        DataTable mp_dt10 = new DataTable();
        mp_da10.Fill(mp_dt10);


        if (mp_dt.Rows.Count == 1)
        {

            lblsat.Text = mp_dt.Rows[0]["sat"].ToString();
            txtsat.Text = mp_dt.Rows[0]["sat"].ToString();
            if (mp_dt.Rows[0]["sat"].ToString() == "")
            {
                lblsat.Text = "-&nbsp; &nbsp;";

            }


            lbltani1.Text = mp_dt.Rows[0]["tani1"].ToString();
            txttani1.Text = mp_dt.Rows[0]["tani1"].ToString();


            if (mp_dt.Rows[0]["tani1"].ToString() == "")
            {
                lbltani1.Text = "-&nbsp; &nbsp;";

            }

            lbltani2.Text = mp_dt.Rows[0]["tani2"].ToString();
            txttani2.Text = mp_dt.Rows[0]["tani2"].ToString();


            if (mp_dt.Rows[0]["tani2"].ToString() == "")
            {
                lbltani2.Text = "-&nbsp; &nbsp;";

            }

            lbltani3.Text = mp_dt.Rows[0]["tani3"].ToString();
            txttani3.Text = mp_dt.Rows[0]["tani3"].ToString();

            if (mp_dt.Rows[0]["tani3"].ToString() == "")
            {
                lbltani3.Text = "-&nbsp; &nbsp;";

            }

            lbltani4.Text = mp_dt.Rows[0]["tani4"].ToString();
            txttani4.Text = mp_dt.Rows[0]["tani4"].ToString();

            if (mp_dt.Rows[0]["tani4"].ToString() == "")
            {
                lbltani4.Text = "-&nbsp; &nbsp;";

            }



            lbloi.Text = mp_dt.Rows[0]["oi"].ToString();
            txtoi.Text = mp_dt.Rows[0]["oi"].ToString();


            if (mp_dt.Rows[0]["oi"].ToString() == "")
            {
                lbloi.Text = "-&nbsp; &nbsp;";

            }



            lbliui.Text = mp_dt.Rows[0]["iui"].ToString();
            txtiui.Text = mp_dt.Rows[0]["iui"].ToString();


            if (mp_dt.Rows[0]["iui"].ToString() == "")
            {
                lbliui.Text = "-&nbsp; &nbsp;";

            }





            lblivf.Text = mp_dt.Rows[0]["ivf"].ToString();
            txtivf.Text = mp_dt.Rows[0]["ivf"].ToString();



            if (mp_dt.Rows[0]["ivf"].ToString() == "")
            {
                lblivf.Text = "-&nbsp; &nbsp;";

            }


            lblagirlik.Text = mp_dt.Rows[0]["agirlik"].ToString();
            txtagirlik.Text = mp_dt.Rows[0]["agirlik"].ToString();

            if (mp_dt.Rows[0]["agirlik"].ToString() == "")
            {
                lblagirlik.Text = "-&nbsp; &nbsp;";

            }


            lblantralsag.Text = mp_dt.Rows[0]["antralsag"].ToString();
            txtantralsag.Text = mp_dt.Rows[0]["antralsag"].ToString();


            if (mp_dt.Rows[0]["antralsag"].ToString() == "")
            {
                lblantralsag.Text = "-&nbsp; &nbsp;";

            }


            lblantralsol.Text = mp_dt.Rows[0]["antralsol"].ToString();
            txtantralsol.Text = mp_dt.Rows[0]["antralsol"].ToString();



            if (mp_dt.Rows[0]["antralsol"].ToString() == "")
            {
                lblantralsol.Text = "-&nbsp; &nbsp;";

            }


            lbloversag.Text = mp_dt.Rows[0]["oversag"].ToString();
            txtoversag.Text = mp_dt.Rows[0]["oversag"].ToString();


            if (mp_dt.Rows[0]["gebeliksayisi"].ToString() == "")
            {
                lblgebeliksayisi.Text = "-&nbsp; &nbsp;";

            }
            else
            {

                lblgebeliksayisi.Text = mp_dt.Rows[0]["gebeliksayisi"].ToString();
                txtgebeliksayisi.Text = mp_dt.Rows[0]["gebeliksayisi"].ToString();

            }



            if (mp_dt.Rows[0]["kese"].ToString() == "")
            {
                lblkesesayisi.Text = "-&nbsp; &nbsp;";

            }
            else
            {

                lblkesesayisi.Text = mp_dt.Rows[0]["kese"].ToString();
                txtkesesayisi.Text = mp_dt.Rows[0]["kese"].ToString();

            }





            if (mp_dt.Rows[0]["monokoryonik"].ToString() == "")
            {
                lblmonokoryonik.Text = "-&nbsp; &nbsp;";

            }
            else
            {

                lblmonokoryonik.Text = mp_dt.Rows[0]["monokoryonik"].ToString();
                txtmonokoryonik.Text = mp_dt.Rows[0]["monokoryonik"].ToString();

            }


      


            if (mp_dt.Rows[0]["oversag"].ToString() == "")
            {
                lbloversag.Text = "-&nbsp; &nbsp;";

            }

            lbloversol.Text = mp_dt.Rows[0]["oversol"].ToString();
            txtoversol.Text = mp_dt.Rows[0]["oversol"].ToString();



            if (mp_dt.Rows[0]["oversol"].ToString() == "")
            {
                lbloversol.Text = "-&nbsp; &nbsp;";

            }

            lblbazal.Text = mp_class.tarihcevir2(mp_dt.Rows[0]["bazaltarih"].ToString()).ToShortDateString();
            txtbazal.Text = mp_class.tarihcevir2(mp_dt.Rows[0]["bazaltarih"].ToString()).ToShortDateString();


            if (mp_dt.Rows[0]["bazaltarih"].ToString() == "")
            {
                lblbazal.Text = "-&nbsp; &nbsp;";

            }

            lblfsh.Text = mp_dt.Rows[0]["fsh"].ToString();
            txtfsh.Text = mp_dt.Rows[0]["fsh"].ToString();


            if (mp_dt.Rows[0]["fsh"].ToString() == "")
            {
                lblfsh.Text = "-&nbsp; &nbsp;";

            }
            lbllh.Text = mp_dt.Rows[0]["lh"].ToString();
            txtlh.Text = mp_dt.Rows[0]["lh"].ToString();


            if (mp_dt.Rows[0]["lh"].ToString() == "")
            {
                lbllh.Text = "-&nbsp; &nbsp;";

            }

            lble2.Text = mp_dt.Rows[0]["e2"].ToString();
            txte2.Text = mp_dt.Rows[0]["e2"].ToString();

            if (mp_dt.Rows[0]["e2"].ToString() == "")
            {
                lble2.Text = "-&nbsp; &nbsp;";

            }

            //lblkullanilanfsh.Text = mp_dt.Rows[0]["kullanilan_fsh"].ToString();
            //txtkullanilanfsh.Text = mp_dt.Rows[0]["kullanilan_fsh"].ToString();

            //if (mp_dt.Rows[0]["kullanilan_fsh"].ToString() == "")
            //{
            //    lblkullanilanfsh.Text = "0&nbsp; &nbsp;";

            //}


            if (mp_dt.Rows[0]["ovulasyon"].ToString() == "-")
            {
                lblovulasyon.Text = "Yok";
                txtovulasyon.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["ovulasyon"].ToString() == "+")
            {
                lblovulasyon.Text = "Var";
                txtovulasyon.SelectedValue = "+";
            }
            else if (mp_dt.Rows[0]["ovulasyon"].ToString() == "0")
            {
                lblovulasyon.Text = "Bilinmiyor";
                txtovulasyon.SelectedValue = "0";
            }
            else
            {
                lblovulasyon.Text = "-&nbsp;&nbsp;";
                txtovulasyon.SelectedIndex = 0;
            }

            if (mp_dt.Rows[0]["cogul"].ToString() == "-")
            {
                lblcogul.Text = "Yok";
                txtcogul.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["cogul"].ToString() == "+")
            {
                lblcogul.Text = "Var";
                txtcogul.SelectedValue = "+";
            }
            else
            {
                lblcogul.Text = "-&nbsp;&nbsp;";
                txtcogul.SelectedIndex = 0;
            }


            if (mp_dt.Rows[0]["fkh"].ToString() == "-")
            {
                lblFKH.Text = "Hayır";
                txtFKH.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["fkh"].ToString() == "+")
            {
                lblFKH.Text = "Evet";
                txtFKH.SelectedValue = "+";
            }
            else
            {
                lblFKH.Text = "-&nbsp;&nbsp;";
                txtFKH.SelectedIndex = 0;
            }


            if (mp_dt.Rows[0]["hiperstimulasyon"].ToString() == "-")
            {
                lblhiperstimulasyon.Text = "Yok";
                txthiperstimulasyon.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["hiperstimulasyon"].ToString() == "+")
            {
                lblhiperstimulasyon.Text = "Var";
                txthiperstimulasyon.SelectedValue = "+";
            }
            else
            {
                lblhiperstimulasyon.Text = "-&nbsp;&nbsp;";
                txthiperstimulasyon.SelectedIndex = 0;
            }



            if (mp_dt.Rows[0]["pcos"].ToString() == "-" || mp_dt.Rows[0]["pcos"].ToString() == "")
            {


                lblpcos.Text = "-&nbsp;&nbsp;";
                txtpcos.Checked = false;

            }
            else
            {
                lblpcos.Text = "Var";
                txtpcos.Checked = true;

            }




            if (mp_dt.Rows[0]["gebelik"].ToString() == "-")
            {
                lblgebelik.Text = "Yok";
                txtgebelik.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["gebelik"].ToString() == "+")
            {
                lblgebelik.Text = "Var";
                txtgebelik.SelectedValue = "+";
            }
            else
            {
                lblgebelik.Text = "-&nbsp;&nbsp;";
                txtgebelik.SelectedIndex = 0;
            }



            if (mp_dt.Rows[0]["biyokimyasal"].ToString() == "-")
            {
                lblbiyokimyasal.Text = "Yok";
                txtbiyokimyasal.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["biyokimyasal"].ToString() == "+")
            {
                lblbiyokimyasal.Text = "Var";
                txtbiyokimyasal.SelectedValue = "+";
            }
            else
            {
                lblbiyokimyasal.Text = "-&nbsp;&nbsp;";
                txtbiyokimyasal.SelectedIndex = 0;
            }


            if (mp_dt.Rows[0]["abortus"].ToString() == "-")
            {
                lblabortus.Text = "Yok";
                txtabortus.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["abortus"].ToString() == "+")
            {
                lblabortus.Text = "Var";
                txtabortus.SelectedValue = "+";
            }
            else
            {
                lblabortus.Text = "-&nbsp;&nbsp;";
                txtabortus.SelectedIndex = 0;
            }
            if (Label1.Text != "aaa")
            {
                if (mp_dt.Rows[0]["istatistik"].ToString() == "+")
                {

                    lblistatistik.Text = "İstatistiklerde Gösterilmiyor.";
                    lblistatistik.ForeColor = System.Drawing.Color.Red;

                    chbistatistik.Checked = true;


                }
                else
                {
                    lblistatistik.Text = "İstatistiklerde Gösteriliyor.";
                    lblistatistik.ForeColor = System.Drawing.Color.Green;

                    chbistatistik.Checked = false;

                }
            }



            if (mp_dt.Rows[0]["dogum"].ToString() == "-")
            {
                lbldogum.Text = "Yok";
                txtdogum.SelectedValue = "-";
            }
            else if (mp_dt.Rows[0]["dogum"].ToString() == "+")
            {
                lbldogum.Text = "Var";
                txtdogum.SelectedValue = "+";
            }
            else
            {
                lbldogum.Text = "-&nbsp;&nbsp;";
                txtdogum.SelectedIndex = 0;
            }



            if (mp_dt.Rows[0]["opuyapildimi"].ToString() == "+")
            {
                lblopuyapildimi.Text = "Evet";
                rbopuyapildimi.SelectedIndex = 0;

                Panel1.Visible = true;
                Panel4.Visible = true;
                Panel5.Visible = true;
            }
            else if (mp_dt.Rows[0]["opuyapildimi"].ToString() == "-")
            {
                lblopuyapildimi.Text = "Hayır";
                rbopuyapildimi.SelectedIndex = 1;

                Panel1.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
            }
            else
            {
                lblopuyapildimi.Text = "-&nbsp;&nbsp;";
                rbopuyapildimi.SelectedIndex = -1;

                Panel1.Visible = false;
                Panel4.Visible = false;
                Panel5.Visible = false;
            }



            lblgv.Text = mp_dt.Rows[0]["gv"].ToString();
            txtgv.Text = mp_dt.Rows[0]["gv"].ToString();

            if (mp_dt.Rows[0]["gv"].ToString() == "")
            {
                lblgv.Text = "-&nbsp; &nbsp;";

            }

            lblolgun.Text = mp_dt.Rows[0]["olgun"].ToString();
            txtolgun.Text = mp_dt.Rows[0]["olgun"].ToString();

            if (mp_dt.Rows[0]["olgun"].ToString() == "")
            {
                lblolgun.Text = "-&nbsp; &nbsp;";

            }

            lblDejenere.Text = mp_dt.Rows[0]["dejenere"].ToString();
            txtDejenere.Text = mp_dt.Rows[0]["dejenere"].ToString();

            if (mp_dt.Rows[0]["dejenere"].ToString() == "")
            {
                lblDejenere.Text = "-&nbsp; &nbsp;";

            }

            lblOlusanYumurta.Text = mp_dt.Rows[0]["olusanYumurta"].ToString();
            txtOlusanYumurta.Text = mp_dt.Rows[0]["olusanYumurta"].ToString();

            if (mp_dt.Rows[0]["olusanYumurta"].ToString() == "")
            {
                lblOlusanYumurta.Text = "-&nbsp; &nbsp;";

            }


            lblPostM.Text = mp_dt.Rows[0]["postm"].ToString();
            txtPostM.Text = mp_dt.Rows[0]["postm"].ToString();

            if (mp_dt.Rows[0]["postm"].ToString() == "")
            {
                lblPostM.Text = "-&nbsp; &nbsp;";
            }

            lblZona.Text = mp_dt.Rows[0]["zona"].ToString();
            txtZona.Text = mp_dt.Rows[0]["zona"].ToString();

            if (mp_dt.Rows[0]["zona"].ToString() == "")
            {
                lblZona.Text = "-&nbsp; &nbsp;";
            }



            lblbilinmeyen.Text = mp_dt.Rows[0]["bilinmeyen"].ToString();
            txtbilinmeyen.Text = mp_dt.Rows[0]["bilinmeyen"].ToString();

            if (mp_dt.Rows[0]["bilinmeyen"].ToString() == "")
            {
                lblbilinmeyen.Text = "-&nbsp; &nbsp;";

            }


            lbldollenen.Text = mp_dt.Rows[0]["dollenen"].ToString();
            txtdollenen.Text = mp_dt.Rows[0]["dollenen"].ToString();

            if (mp_dt.Rows[0]["dollenen"].ToString() == "")
            {
                lbldollenen.Text = "-&nbsp; &nbsp;";

            }


            if (mp_dt.Rows[0]["embriyoolustumu"].ToString() == "+")
            {
                lblembriyooluştumu.Text = "Evet";
                rbembriyoolustumu.SelectedIndex = 0;

                Panel6.Visible = true;
                Panel7.Visible = true;
                Panel8.Visible = true;
            }
            else if (mp_dt.Rows[0]["embriyoolustumu"].ToString() == "-")
            {
                lblembriyooluştumu.Text = "Hayır";
                rbembriyoolustumu.SelectedIndex = 1;

                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
            }
            else
            {
                lblembriyooluştumu.Text = "-&nbsp;&nbsp;";
                rbembriyoolustumu.SelectedIndex = -1;

                Panel6.Visible = false;
                Panel7.Visible = false;
                Panel8.Visible = false;
            }

            lbltransferedilenembriyo.Text = mp_dt.Rows[0]["transferedilenembriyo"].ToString();
            txttransferedilenembriyo.Text = mp_dt.Rows[0]["transferedilenembriyo"].ToString();

            if (mp_dt.Rows[0]["transferedilenembriyo"].ToString() == "")
            {
                lbltransferedilenembriyo.Text = "-&nbsp; &nbsp;";

            }

            lblfrozen.Text = mp_dt.Rows[0]["frozen"].ToString();
            txtfrozen.Text = mp_dt.Rows[0]["frozen"].ToString();

            if (mp_dt.Rows[0]["frozen"].ToString() == "")
            {
                lblfrozen.Text = "-&nbsp; &nbsp;";

            }

            lblkalan.Text = mp_dt.Rows[0]["kalan"].ToString();
            txtkalan.Text = mp_dt.Rows[0]["kalan"].ToString();

            if (mp_dt.Rows[0]["kalan"].ToString() == "")
            {
                lblkalan.Text = "-&nbsp; &nbsp;";

            }


            if (mp_dt.Rows[0]["kurum_id"].ToString() != "")
            {
                txtkurum.SelectedValue = mp_dt.Rows[0]["kurum_id"].ToString();
                MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select * from kurumlar where kurum_id=" + mp_dt.Rows[0]["kurum_id"].ToString() + " order by sira asc", connect_word);
                DataTable mp_dt2 = new DataTable();
                mp_da2.Fill(mp_dt2);

                lblkurum.Text = mp_dt2.Rows[0]["kurum_adi"].ToString();
            }

            else
            {
                lblkurum.Text = "-&nbsp;&nbsp;";

            }

            if (mp_dt.Rows[0]["tedavi_turu_id"].ToString() != "")
            {
                txttedavituru.SelectedValue = mp_dt.Rows[0]["tedavi_turu_id"].ToString();

                MySqlDataAdapter mp_da3 = new MySqlDataAdapter("Select * from tedavi_turleri where tur_id=" + mp_dt.Rows[0]["tedavi_turu_id"].ToString() + " order by sira asc", connect_word);
                DataTable mp_dt3 = new DataTable();
                mp_da3.Fill(mp_dt3);

                lbltedavituru.Text = mp_dt3.Rows[0]["tedavi_adi"].ToString();

            }

            else
            {
                lbltedavituru.Text = "-&nbsp;&nbsp;";

            }




            if (mp_dt.Rows[0]["tedavi_protokolu"].ToString() != "")
            {
                txttedaviprotokolu.SelectedValue = mp_dt.Rows[0]["tedavi_protokolu"].ToString();

                MySqlDataAdapter mp_da3 = new MySqlDataAdapter("Select * from tedavi_protokolleri where protokol_id=" + mp_dt.Rows[0]["tedavi_protokolu"].ToString() + " order by sira asc", connect_word);
                DataTable mp_dt3 = new DataTable();
                mp_da3.Fill(mp_dt3);

                lbltedaviprotokolu.Text = mp_dt3.Rows[0]["protokol_adi"].ToString();

            }

            else
            {
                lbltedaviprotokolu.Text = "-&nbsp;&nbsp;";

            }


            MySqlDataAdapter mp_da34 = new MySqlDataAdapter("select * from siklus_alanlar where ID=1", connect_word);
            DataTable mp_dt34 = new DataTable();
            mp_da34.Fill(mp_dt34);


            for (int i = 1; i < 11; i++)
            {
                if (mp_dt34.Rows[0]["alan" + i.ToString()].ToString() == "+")
                {

                    Label yeni = new Label();
                    yeni = (Label)FindControl("etkalan" + i);

                    yeni.Visible = true;
                    yeni.Text = "&nbsp;" + mp_dt34.Rows[0]["etk" + i.ToString()].ToString() + " :&nbsp;";

                    Label yeni2 = new Label();
                    yeni2 = (Label)FindControl("lblalan" + i);

                    yeni2.Visible = true;


                    TextBox yeni3 = new TextBox();
                    yeni3 = (TextBox)FindControl("txtalan" + i);

                    if (mp_dt.Rows[0]["alan" + i.ToString()].ToString().Length == 0)
                    {
                        yeni2.Text = " &nbsp;-  ";

                    }
                    else if (mp_dt.Rows[0]["alan" + i.ToString()].ToString().Length > 0)
                    {
                        yeni2.Text = "&nbsp;" + mp_dt.Rows[0]["alan" + i.ToString()].ToString();
                        yeni3.Text = mp_dt.Rows[0]["alan" + i.ToString()].ToString();

                    }
                }


            }


            MySqlDataAdapter mp_da6 = new MySqlDataAdapter("Select * from uye_hasta where uye_id=" + hasta_id.ToString() + "", connect_word);

            DataTable mp_dt6 = new DataTable();
            mp_da6.Fill(mp_dt6);

            DateTime dogum_tarihi = DateTime.Parse(mp_dt6.Rows[0]["uye_dogum_tarihi"].ToString());
            TimeSpan sure = DateTime.Parse(mp_dt10.Rows[0]["siklus_eklenme_tarihi"].ToString().Substring(0, 10)) - dogum_tarihi;
            int yeni_yas = sure.Days / 365;
            lblyas.Text = yeni_yas.ToString();

            if (mp_dt6.Rows[0]["boy"].ToString() != "" || mp_dt6.Rows[0]["kilo"].ToString() != "")
            {
                int kilo = int.Parse(mp_dt6.Rows[0]["kilo"].ToString());
                double boy = double.Parse(mp_dt6.Rows[0]["boy"].ToString()) * double.Parse(mp_dt6.Rows[0]["boy"].ToString()) / 10000;
                double vki = kilo / boy;

                lblvki.Text = vki.ToString().Substring(0, 4);
            }
            else
            {

                lblvki.Text = "Boy veya Kilo Girilmemiş !";
            }



        }

        else
        {


            Panel3.Visible = true;
            Label5.Text = "Bu Siklusa Henüz Veri Girişinde Bulunulmadı !";
            Label5.ForeColor = System.Drawing.Color.Red;


        }






        //}
        //catch
        //{ }




    }
    void mail_gonderimi(string gelen, string s_id)
    {

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select uye_email,uye_adi,uye_soyadi from uye_doktor where uye_id =" + gelen.ToString() + "", mp_connection);

        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);


        if (mp_dt2.Rows[0]["uye_email"].ToString() != "")
        {


            MySqlDataAdapter mp_da = new MySqlDataAdapter("select siklus_ay,siklus_yil,hasta_id from siklus_ana_tab where siklus_id =" + s_id.ToString() + "", mp_connection);


            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            MySqlDataAdapter mp_da22 = new MySqlDataAdapter("select uye_email,uye_adi,uye_soyadi from uye_hasta where uye_id =" + mp_dt.Rows[0]["hasta_id"].ToString() + "", mp_connection);

            DataTable mp_dt22 = new DataTable();
            mp_da22.Fill(mp_dt22);

            //string mesaj2 = "<font face='Arial'>Merhaba " + mp_dt2.Rows[0]["uye_adi"].ToString().ToUpper() + " " + mp_dt2.Rows[0]["uye_soyadi"].ToString().ToUpper();

            //mesaj2 = mesaj2 + "<br>" + DateTime.Now + " tarihinde " + mp_dt22.Rows[0]["uye_adi"].ToString() + " " + mp_dt22.Rows[0]["uye_soyadi"].ToString() + " isimli hastanın ,";

            //mesaj2 = mesaj2 + mp_dt.Rows[0]["siklus_ay"].ToString() + "-" + mp_dt.Rows[0]["siklus_yil"].ToString() + " siklus bilgileri , sizinle paylaşılmıştır.<br>";

            //mesaj2 = mesaj2 + "Bu hastaya ait bilgileri görebilmeniz için lütfen " + "<a href='http://www.mp.com'>mp.com</a> 'u ziyaret ediniz.</font><br><br>";
            //mp_class.mailsend("Konsültasyon Bilgilendirme", mp_dt2.Rows[0]["uye_email"].ToString(), mesaj2);


            //if (mp_dt22.Rows[0]["uye_email"].ToString() != "")
            //{


            //    string mesaj22 = "<font face='Arial'>Merhaba " + mp_dt22.Rows[0]["uye_adi"].ToString().ToUpper() + " " + mp_dt22.Rows[0]["uye_soyadi"].ToString().ToUpper();

            //    mesaj22 = mesaj22 + "<br>" + DateTime.Now + " tarihinde " + mp_dt.Rows[0]["siklus_ay"].ToString() + "-" + mp_dt.Rows[0]["siklus_yil"].ToString() + " siklusunuz Doktor " + mp_dt2.Rows[0]["uye_adi"].ToString() + " " + mp_dt2.Rows[0]["uye_soyadi"].ToString() + " ile ";

            //    mesaj22 = mesaj22 + "paylaşılmıştır.<br>";

            //    mesaj22 = mesaj22 + "Bilgilerinizde meydana gelen değişiklikleri görebilmeniz için lütfen " + "<a href='http://www.mp.com'>mp.com</a> 'u ziyaret ediniz.</font><br><br>";
            //    mp_class.mailsend("Konsültasyon Bilgilendirme", mp_dt22.Rows[0]["uye_email"].ToString(), mesaj22);

            //}



        }



    }
    void menuyukle2()
    {
        try
        {

            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];
            if (Request.QueryString["siklus_id"] != null && Request.QueryString["ts"] != null)
            {

                ts.Visible = true;
                kurum_yukle();
                tedavi_turu_yukle();
                tedavi_protokolu_yukle();

                kisasiklusyukle();

                //yetkili_doktor_yukle();

            }

            string siklus_id = Request.QueryString["siklus_id"].ToString();

            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id=" + siklus_id + "", connect_word);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);

            Label4.Text = dt5.Rows[0]["siklus_ay"] + " - " + dt5.Rows[0]["siklus_yil"].ToString();


        }


        catch
        {

        }





    }
    //void doldur()
    //{

    //    try
    //    {
    //        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);


    //        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select uye_id as id,concat(uye_adi,' ',uye_soyadi) as ad  from uye_doktor order by concat(uye_adi,' ',uye_soyadi) asc", mp_connection);
    //        DataTable mp_dt2 = new DataTable();
    //        mp_da2.Fill(mp_dt2);

    //        doktor_list.DataSource = mp_dt2;
    //        doktor_list.DataTextField = mp_dt2.Columns["ad"].ToString();
    //        doktor_list.DataValueField = mp_dt2.Columns["id"].ToString();

    //        doktor_list.DataBind();

    //        ListItem yeni = new ListItem();
    //        yeni.Text = "Seçiniz";
    //        yeni.Value = "";
    //        doktor_list.Items.Insert(0, yeni);




    //    }

    //    catch
    //    {

    //    }
    //}
    void kurum_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from kurumlar order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            txtkurum.DataSource = dt6;
            txtkurum.DataTextField = dt6.Columns["kurum_adi"].ToString();
            txtkurum.DataValueField = dt6.Columns["kurum_id"].ToString();
            txtkurum.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            txtkurum.Items.Insert(0, yeni);
        }
        catch
        { }

    }
    void tedavi_turu_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from tedavi_turleri order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            txttedavituru.DataSource = dt6;
            txttedavituru.DataTextField = dt6.Columns["tedavi_adi"].ToString();
            txttedavituru.DataValueField = dt6.Columns["tur_id"].ToString();
            txttedavituru.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            txttedavituru.Items.Insert(0, yeni);
        }
        catch
        { }

    }
    void tedavi_protokolu_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from tedavi_protokolleri order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            txttedaviprotokolu.DataSource = dt6;
            txttedaviprotokolu.DataTextField = dt6.Columns["protokol_adi"].ToString();
            txttedaviprotokolu.DataValueField = dt6.Columns["protokol_id"].ToString();
            txttedaviprotokolu.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Seçiniz";
            yeni.Value = "";

            yeni.Selected = true;

            txttedaviprotokolu.Items.Insert(0, yeni);
        }
        catch
        { }

    }
    private void taniyukle()
    {

        try
        {
            HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
            String hasta_id = islemdekihasta["HastaID"];


            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
            //MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from infertilite2 A,infertilite_adlari S where S.infertilite_id=cint(A.kategori_id) and A.hasta_id='" + hasta_id.ToString() + "' and A.siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);

            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("Select S.infertilite_adi,S.sira from ana_infertilite A,infertilite_adlari S where S.infertilite_id=CAST(A.kategori_id as UNSIGNED) and A.hasta_id='" + hasta_id.ToString() + "' and (A.renk_kodu_id='1' or A.renk_kodu_id='3') order by S.sira asc", connect_word);
            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);


            if (mp_dt2.Rows.Count > 0)
            {
                if (mp_dt2.Rows[0][0].ToString() != "")
                {
                    lbltani1.Text = mp_dt2.Rows[0][0].ToString();
                    txttani1.Text = mp_dt2.Rows[0][0].ToString();

                }
                else
                {
                    lbltani1.Text = "-&nbsp; &nbsp;";
                }

                if (mp_dt2.Rows[1][0].ToString() != "")
                {
                    lbltani2.Text = mp_dt2.Rows[1][0].ToString();
                    txttani2.Text = mp_dt2.Rows[1][0].ToString();

                }
                else
                {
                    lbltani2.Text = "-&nbsp; &nbsp;";
                }
                if (mp_dt2.Rows[2][0].ToString() != "")
                {
                    lbltani3.Text = mp_dt2.Rows[2][0].ToString();
                    txttani3.Text = mp_dt2.Rows[2][0].ToString();

                }
                else
                {
                    lbltani3.Text = "-&nbsp; &nbsp;";
                }

                if (mp_dt2.Rows[3][0].ToString() != "")
                {
                    lbltani4.Text = mp_dt2.Rows[3][0].ToString();
                    txttani4.Text = mp_dt2.Rows[3][0].ToString();

                }
                else
                {
                    lbltani4.Text = "-&nbsp; &nbsp;";
                }

            }

        }
        catch
        {

        }
    }
    void fsh_hesap()
    {

        double kullanilan_fsh_degeri = 0;


        try
        {
            MySqlConnection connect_word = mp_class.connect_ivf(0301009184);

            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from takipli_siklus1 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows.Count == 1)
            {

                for (int i = 1; i < 15; i++)
                {

                    dt1.Rows[0]["iki" + i.ToString()].ToString();

                    if (dt1.Rows[0]["iki" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt1.Rows[0]["iki" + i.ToString()].ToString().Trim());


                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }


                }


                for (int i = 1; i < 15; i++)
                {
                    if (dt1.Rows[0]["uc" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt1.Rows[0]["uc" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }

            }




            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from takipli_siklus2 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            if (dt2.Rows.Count == 1)
            {


                for (int i = 1; i < 15; i++)
                {
                    if (dt2.Rows[0]["iki2" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt2.Rows[0]["iki2" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }


                for (int i = 1; i < 15; i++)
                {

                    if (dt2.Rows[0]["uc2" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt2.Rows[0]["uc2" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }

            }


            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from takipli_siklus3 where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "'", connect_word);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            if (dt3.Rows.Count == 1)
            {

                for (int i = 1; i < 8; i++)
                {

                    if (dt3.Rows[0]["iki3" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt3.Rows[0]["iki3" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }


                for (int i = 1; i < 8; i++)
                {
                    if (dt3.Rows[0]["uc3" + i.ToString()].ToString() != "")
                    {
                        try
                        {
                            double yeni_deger = double.Parse(dt3.Rows[0]["uc3" + i.ToString()].ToString().Trim());

                            kullanilan_fsh_degeri += yeni_deger;
                        }
                        catch
                        { }
                    }
                }

            }

            lblkullanilanfsh.Text = kullanilan_fsh_degeri.ToString();
            txtkullanilanfsh.Text = kullanilan_fsh_degeri.ToString();


        }

        catch
        {

        }





    }



    protected void kaldir_Command(object sender, CommandEventArgs e)
    {

        try
        {
            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlCommand cmd = new MySqlCommand("delete from hasta_paylas where siklus_id='" + Request.QueryString["siklus_id"].ToString() + "' and doktor_id='" + e.CommandArgument.ToString() + "'", mp_connection);


            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();
            if (eks == 1)
            {


                Panel3.Visible = true;
                Label5.Text = "Konsülte İşlemi Başarıyla İptal Edildi.";
                Label5.ForeColor = System.Drawing.Color.Green;

                //yetkili_doktor_yukle();

            }
            else
            {
                Panel3.Visible = true;
                Label5.Text = "Konsülte İşlemi İptal Edilemedi!";
                Label5.ForeColor = System.Drawing.Color.Red;

            }

        }
        catch
        {
            Panel3.Visible = true;
            Label5.Text = "Konsülte İşlemi İptal Edilemedi!";
            Label5.ForeColor = System.Drawing.Color.Red;
        }

    }

    //void hastalari_yukle(string gelen)
    //{

    //    MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

    //    MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select concat(U.uye_adi,' ',U.uye_soyadi,'-',S.siklus_ay,' ',S.siklus_yil) as ad from hasta_paylas H,siklus_ana_tab S,uye_hasta U where S.siklus_id = CAST(H.siklus_id as UNSIGNED) and CAST(S.hasta_id as UNSIGNED) = U.uye_id and H.doktor_id='" + gelen.ToString() + "' order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);
    //    DataTable mp_dt2 = new DataTable();
    //    mp_da2.Fill(mp_dt2);

    //    konsulte.DataSource = mp_dt2;
    //    konsulte.DataTextField = mp_dt2.Columns["ad"].ToString();
    //    konsulte.DataValueField = mp_dt2.Columns["ad"].ToString();
    //    konsulte.DataBind();

    //    ListItem yeni = new ListItem();
    //    yeni.Text = "Doktorun Konsülte Hastaları (" + mp_dt2.Rows.Count + ")";
    //    yeni.Value = "";
    //    konsulte.Items.Insert(0, yeni);


    //}
    //void kendi_hastalarini_yukle(string gelen)
    //{
    //    MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

    //    MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select concat(uye_adi,' ',uye_soyadi) as ad from uye_hasta where uye_ekleyen='" + gelen.ToString() + "' order by concat(uye_adi,' ',uye_soyadi) asc", mp_connection);
    //    DataTable mp_dt2 = new DataTable();
    //    mp_da2.Fill(mp_dt2);

    //    kendi.DataSource = mp_dt2;
    //    kendi.DataTextField = mp_dt2.Columns["ad"].ToString();
    //    kendi.DataBind();

    //    ListItem yeni = new ListItem();
    //    yeni.Text = "Doktorun Kendi Hastaları (" + mp_dt2.Rows.Count + ")";
    //    yeni.Value = "";
    //    kendi.Items.Insert(0, yeni);




    //}
    //protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    //{
    //    Label1.Text = "<br><br>&nbsp;";
    //    konsulte.Visible = true;
    //    kendi.Visible = true;
    //    hastalari_yukle(doktor_list.SelectedValue);
    //    kendi_hastalarini_yukle(doktor_list.SelectedValue);
    //}

    protected void txtgebelik_SelectedIndexChanged1(object sender, EventArgs e)
    {

        if (txtgebelik.SelectedValue == "+")
        {

            txtovulasyon.SelectedValue = "+";
            txtbiyokimyasal.SelectedIndex = 0;
            txtabortus.SelectedIndex = 0;
            txtcogul.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;
            txtbiyokimyasal.Enabled = true;
            txtabortus.Enabled = true;
            txtcogul.Enabled = true;
            txtdogum.Enabled = true;
            txtgebeliksayisi.Enabled = true;
           

        }
        else if (txtgebelik.SelectedValue == "-")
        {
            txtbiyokimyasal.SelectedIndex = 0;
            txtabortus.SelectedIndex = 0;
            txtcogul.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;
            txtbiyokimyasal.Enabled = false;
            txtabortus.Enabled = false;
            txtcogul.Enabled = false;
            txtdogum.Enabled = false;
            txtgebeliksayisi.Text = "";

            txtgebeliksayisi.Enabled = false;


        }

        else if (txtgebelik.SelectedIndex == 0)
        {
            txtovulasyon.SelectedIndex = 0;
            txtbiyokimyasal.Enabled = false;
            txtabortus.Enabled = false;
            txtcogul.Enabled = false;
            txtdogum.Enabled = false;

        }

    }
    protected void txtbiyokimyasal_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (txtbiyokimyasal.SelectedValue == "+")
        {

            txtabortus.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;
            txtagirlik.Enabled = false;
            txtabortus.Enabled = false;
            txtdogum.Enabled = false;
            txtagirlik.Text = "";
        }
        else if (txtbiyokimyasal.SelectedValue == "-")
        {

            txtabortus.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;


            txtagirlik.Enabled = true;
            txtabortus.Enabled = true;
            txtdogum.Enabled = true;
            txtagirlik.Enabled = true;

        }

        else if (txtbiyokimyasal.SelectedIndex == 0)
        {
            txtagirlik.Enabled = true;
            txtabortus.Enabled = true;
            txtdogum.Enabled = true;

        }

    }
    protected void txtabortus_SelectedIndexChanged(object sender, EventArgs e)
    {


        if (txtabortus.SelectedValue == "+")
        {

            txtbiyokimyasal.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;
            txtagirlik.Enabled = false;
            txtbiyokimyasal.Enabled = false;
            txtdogum.Enabled = false;
            txtagirlik.Text = "";
        }
        else if (txtabortus.SelectedValue == "-")
        {

            txtbiyokimyasal.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;


            txtagirlik.Enabled = true;
            txtbiyokimyasal.Enabled = true;
            txtdogum.Enabled = true;
            txtagirlik.Enabled = true;

        }

        else if (txtabortus.SelectedIndex == 0)
        {
            txtagirlik.Enabled = true;
            txtabortus.Enabled = true;
            txtdogum.Enabled = true;

        }





    }
    protected void txtdogum_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (txtdogum.SelectedValue == "+")
        {

            txtbiyokimyasal.SelectedIndex = 0;
            txtabortus.SelectedIndex = 0;
            txtagirlik.Enabled = true;
            txtbiyokimyasal.Enabled = false;
            txtabortus.Enabled = false;

        }
        else if (txtdogum.SelectedValue == "-")
        {

            txtbiyokimyasal.SelectedIndex = 0;
            txtdogum.SelectedIndex = 0;
            txtagirlik.Text = "";

            txtbiyokimyasal.Enabled = true;
            txtabortus.Enabled = true;
            txtagirlik.Enabled = false;

        }

        else if (txtdogum.SelectedIndex == 0)
        {
            txtagirlik.Enabled = true;
            txtabortus.Enabled = true;
            txtdogum.Enabled = true;

        }
    }
    protected void rbopuyapildimi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbopuyapildimi.SelectedIndex == 0)
        {

            Panel1.Visible = true;
            Panel4.Visible = true;
            Panel5.Visible = true;
        }
        else
        {

            Panel1.Visible = false;
            Panel4.Visible = false;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;


            txtgv.Text = "";
            txtolgun.Text = "";
            txtdollenen.Text = "";
            rbembriyoolustumu.SelectedIndex = -1;

            txtbilinmeyen.Text = "";
            txttransferedilenembriyo.Text = "";
            txtfrozen.Text = "";
            txtkalan.Text = "";


        }
    }
    protected void rbembriyoolustumu_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbembriyoolustumu.SelectedIndex == 0)
        {
            Panel6.Visible = true;
            Panel7.Visible = true;
            Panel8.Visible = true;
        }
        else
        {
            Panel6.Visible = false;
            Panel7.Visible = false;
            Panel8.Visible = false;
            txttransferedilenembriyo.Text = "";
            txtfrozen.Text = "";
            txtkalan.Text = "";
        }
    }
    protected void formlist_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label2.Text = "";


        if (formlist.SelectedValue != "")
        {

            pnl.Visible = true;
            edit.Visible = true;


            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from siklusformlar where form_id=" + formlist.SelectedValue.ToString(), mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from siklusformverileri where siklus_id=" + Request.QueryString["siklus_id"].ToString() + " and form_id=" + formlist.SelectedValue.ToString() + "", mp_connection);

            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);

            int sayim = mp_dt2.Rows.Count;



            for (int i = 1; i < 21; i++)
            {

                Label etiket = new Label();
                Label degerlb = new Label();
                TextBox degerim = new TextBox();
                etiket = (Label)pnl.FindControl("e" + i.ToString());
                degerlb = (Label)pnl.FindControl("etiket" + i.ToString());
                degerim = (TextBox)pnl.FindControl("deger" + i.ToString());
                //etiket.Visible = true;
                //degeroncesi.Visible = true;
                //degersonrasi.Visible = true;
                //degerim.Visible = true;
                //degerim.Text = "";

                etiket.Text = mp_dt.Rows[0]["e" + i.ToString()].ToString();

                if (mp_dt.Rows[0]["e" + i.ToString()].ToString() != "")
                {
                    etiket.Text = etiket.Text + " : ";

                    etiket.Visible = true;
                    //degeroncesi.Visible = false;
                    //degersonrasi.Visible = false;
                    degerlb.Visible = true;


                }
                else if (mp_dt.Rows[0]["e" + i.ToString()].ToString().TrimStart().TrimEnd() == "")
                {

                    etiket.Visible = false;
                    //degeroncesi.Visible = false;
                    //degersonrasi.Visible = false;
                    degerim.Visible = false;
                    degerlb.Visible = false;


                }

                //if (mp_dt.Rows[0]["do" + i.ToString()].ToString() != "")
                //{

                //    degeroncesi.Text = degeroncesi.Text + " ";


                //}
                //if (mp_dt.Rows[0]["ds" + i.ToString()].ToString() != "")
                //{

                //    degersonrasi.Text = " " + degersonrasi.Text;


                //}

                if (sayim == 1)
                {
                    string degeralan = "alan" + i.ToString();


                    if (mp_dt2.Rows[0][degeralan].ToString() == "")
                    {
                        degerlb.Text = "-";
                        degerim.Text = "";

                    }
                    else
                    {
                        degerlb.Text = mp_dt2.Rows[0][degeralan].ToString();
                        degerim.Text = mp_dt2.Rows[0][degeralan].ToString();

                    }

                }
                else
                {

                    degerlb.Text = "-";
                    degerim.Text = "";

                }


                if (edit.Visible == false)
                {

                    if (mp_dt.Rows[0]["e" + i.ToString()].ToString() != "")
                    {
                        degerim.Visible = true;
                        degerlb.Visible = false;
                    }
                    else
                    {
                        degerim.Visible = false;

                    }

                }


            }

        }
        else
        {
            pnl.Visible = false;
            edit.Visible = false;
            save.Visible = false;

        }
    }
    protected void edit_Click(object sender, ImageClickEventArgs e)
    {
        edit.Visible = false;
        save.Visible = true;


        Label etiket = new Label();
        Label degerlb = new Label();
        TextBox degerim = new TextBox();

        for (int i = 1; i < 21; i++)
        {

            etiket = (Label)pnl.FindControl("e" + i.ToString());
            degerlb = (Label)pnl.FindControl("etiket" + i.ToString());
            degerim = (TextBox)pnl.FindControl("deger" + i.ToString());

            degerlb.Visible = false;

            if (etiket.Visible == true)
            {
                degerim.Visible = true;
            }
            else
            {
                degerim.Visible = false;
            }
        }
    }
    protected void save_Click(object sender, ImageClickEventArgs e)
    {
        edit.Visible = true;
        save.Visible = false;

        string form_id = formlist.SelectedValue.ToString();

        Label etiket = new Label();
        Label degerlb = new Label();
        TextBox degerim = new TextBox();
        string[] degisken = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };

        for (int i = 1; i < 21; i++)
        {

            etiket = (Label)pnl.FindControl("e" + i.ToString());
            degerlb = (Label)pnl.FindControl("etiket" + i.ToString());
            degerim = (TextBox)pnl.FindControl("deger" + i.ToString());

            if (degerim.Visible == true && degerim.Text.TrimEnd().TrimStart() != "")
            {
                degisken[i] = degerim.Text;
            }
            else if (degerim.Visible == false)
            {
                degisken[i] = "";
            }

        }


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from siklusformverileri where siklus_id=" + Request.QueryString["siklus_id"].ToString() + " and form_id=" + formlist.SelectedValue.ToString() + "", mp_connection);

        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        string sql = "";

        if (mp_dt2.Rows.Count == 1)
        {
            MySqlCommand cmd = new MySqlCommand("Update siklusformverileri set alan1=?1,alan2=?2,alan3=?3,alan4=?4,alan5=?5,alan6=?6,alan7=?7,alan8=?8,alan9=?9,alan10=?10,alan11=?11,alan12=?12,alan13=?13,alan14=?14,alan15=?15,alan16=?16,alan17=?17,alan18=?18,alan19=?19,alan20=?20 where form_id=" + form_id.ToString() + " and siklus_id=" + Request.QueryString["siklus_id"].ToString() + "", mp_connection);
            cmd.Parameters.AddWithValue("?1", degisken[1].ToString());
            cmd.Parameters.AddWithValue("?2", degisken[2].ToString());
            cmd.Parameters.AddWithValue("?3", degisken[3].ToString());
            cmd.Parameters.AddWithValue("?4", degisken[4].ToString());
            cmd.Parameters.AddWithValue("?5", degisken[5].ToString());
            cmd.Parameters.AddWithValue("?6", degisken[6].ToString());
            cmd.Parameters.AddWithValue("?7", degisken[7].ToString());
            cmd.Parameters.AddWithValue("?8", degisken[8].ToString());
            cmd.Parameters.AddWithValue("?9", degisken[9].ToString());
            cmd.Parameters.AddWithValue("?10", degisken[10].ToString());
            cmd.Parameters.AddWithValue("?11", degisken[11].ToString());
            cmd.Parameters.AddWithValue("?12", degisken[12].ToString());
            cmd.Parameters.AddWithValue("?13", degisken[13].ToString());
            cmd.Parameters.AddWithValue("?14", degisken[14].ToString());
            cmd.Parameters.AddWithValue("?15", degisken[15].ToString());
            cmd.Parameters.AddWithValue("?16", degisken[16].ToString());
            cmd.Parameters.AddWithValue("?17", degisken[17].ToString());
            cmd.Parameters.AddWithValue("?18", degisken[18].ToString());
            cmd.Parameters.AddWithValue("?19", degisken[19].ToString());
            cmd.Parameters.AddWithValue("?20", degisken[20].ToString());


            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();
            if (eks == 1)
            {
                Label2.Text = "Form verileri başarıyla güncellendi.";
                Label2.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label2.Text = "Form verileri güncelleme işlemi başarısız !";
                Label2.ForeColor = System.Drawing.Color.Red;
            }

        }

        else
        {


            MySqlCommand cmd = new MySqlCommand("insert into siklusformverileri(form_id,siklus_id,alan1,alan2,alan3,alan4,alan5,alan6,alan7,alan8,alan9,alan10,alan11,alan12,alan13,alan14,alan15,alan16,alan17,alan18,alan19,alan20) values (?21,?22,?1,?2,?3,?4,?5,?6,?7,?8,?9,?10,?11,?12,?13,?14,?15,?16,?17,?18,?19,?20)", mp_connection);


            cmd.Parameters.AddWithValue("?21", form_id.ToString());
            cmd.Parameters.AddWithValue("?22", Request.QueryString["siklus_id"].ToString());
            cmd.Parameters.AddWithValue("?1", degisken[1].ToString());
            cmd.Parameters.AddWithValue("?2", degisken[2].ToString());
            cmd.Parameters.AddWithValue("?3", degisken[3].ToString());
            cmd.Parameters.AddWithValue("?4", degisken[4].ToString());
            cmd.Parameters.AddWithValue("?5", degisken[5].ToString());
            cmd.Parameters.AddWithValue("?6", degisken[6].ToString());
            cmd.Parameters.AddWithValue("?7", degisken[7].ToString());
            cmd.Parameters.AddWithValue("?8", degisken[8].ToString());
            cmd.Parameters.AddWithValue("?9", degisken[9].ToString());
            cmd.Parameters.AddWithValue("?10", degisken[10].ToString());
            cmd.Parameters.AddWithValue("?11", degisken[11].ToString());
            cmd.Parameters.AddWithValue("?12", degisken[12].ToString());
            cmd.Parameters.AddWithValue("?13", degisken[13].ToString());
            cmd.Parameters.AddWithValue("?14", degisken[14].ToString());
            cmd.Parameters.AddWithValue("?15", degisken[15].ToString());
            cmd.Parameters.AddWithValue("?16", degisken[16].ToString());
            cmd.Parameters.AddWithValue("?17", degisken[17].ToString());
            cmd.Parameters.AddWithValue("?18", degisken[18].ToString());
            cmd.Parameters.AddWithValue("?19", degisken[19].ToString());
            cmd.Parameters.AddWithValue("?20", degisken[20].ToString());


            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();
            if (eks == 1)
            {
                Label2.Text = "Form verileri başarıyla kaydedildi.";
                Label2.ForeColor = System.Drawing.Color.Green;
                kullanilanyukle();

            }
            else
            {
                Label2.Text = "Form verileri kayıt işlemi başarısız !";
                Label2.ForeColor = System.Drawing.Color.Red;
            }


        }





        for (int i = 1; i < 21; i++)
        {
            degerim = (TextBox)pnl.FindControl("deger" + i.ToString());
            degerim.Visible = false;

        }

        formyukle2();

    }

    private void formyukle2()
    {


        if (formlist.SelectedValue != "")
        {

            pnl.Visible = true;
            edit.Visible = true;


            MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from siklusformlar where form_id=" + formlist.SelectedValue.ToString(), mp_connection);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from siklusformverileri where siklus_id=" + Request.QueryString["siklus_id"].ToString() + " and form_id=" + formlist.SelectedValue.ToString() + "", mp_connection);

            DataTable mp_dt2 = new DataTable();
            mp_da2.Fill(mp_dt2);

            int sayim = mp_dt2.Rows.Count;



            for (int i = 1; i < 21; i++)
            {

                Label etiket = new Label();
                Label degerlb = new Label();
                TextBox degerim = new TextBox();
                etiket = (Label)pnl.FindControl("e" + i.ToString());
                degerlb = (Label)pnl.FindControl("etiket" + i.ToString());
                degerim = (TextBox)pnl.FindControl("deger" + i.ToString());
                //etiket.Visible = true;
                //degeroncesi.Visible = true;
                //degersonrasi.Visible = true;
                //degerim.Visible = true;
                //degerim.Text = "";

                etiket.Text = mp_dt.Rows[0]["e" + i.ToString()].ToString();

                if (mp_dt.Rows[0]["e" + i.ToString()].ToString() != "")
                {
                    etiket.Text = etiket.Text + " : ";

                    etiket.Visible = true;
                    //degeroncesi.Visible = false;
                    //degersonrasi.Visible = false;
                    degerlb.Visible = true;


                }
                else if (mp_dt.Rows[0]["e" + i.ToString()].ToString().TrimStart().TrimEnd() == "")
                {

                    etiket.Visible = false;
                    //degeroncesi.Visible = false;
                    //degersonrasi.Visible = false;
                    degerim.Visible = false;
                    degerlb.Visible = false;


                }

                //if (mp_dt.Rows[0]["do" + i.ToString()].ToString() != "")
                //{

                //    degeroncesi.Text = degeroncesi.Text + " ";


                //}
                //if (mp_dt.Rows[0]["ds" + i.ToString()].ToString() != "")
                //{

                //    degersonrasi.Text = " " + degersonrasi.Text;


                //}

                if (sayim == 1)
                {
                    string degeralan = "alan" + i.ToString();


                    if (mp_dt2.Rows[0][degeralan].ToString() == "")
                    {
                        degerlb.Text = "-";
                        degerim.Text = "";

                    }
                    else
                    {
                        degerlb.Text = mp_dt2.Rows[0][degeralan].ToString();
                        degerim.Text = mp_dt2.Rows[0][degeralan].ToString();

                    }

                }
                else
                {

                    degerlb.Text = "-";
                    degerim.Text = "";

                }


                if (edit.Visible == false)
                {

                    if (mp_dt.Rows[0]["e" + i.ToString()].ToString() != "")
                    {
                        degerim.Visible = true;
                        degerlb.Visible = false;
                    }
                    else
                    {
                        degerim.Visible = false;

                    }

                }


            }

        }
        else
        {
            pnl.Visible = false;
            edit.Visible = false;
            save.Visible = false;

        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        HttpCookie islemdekihastasm = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihastasm["HastaID"];

        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from  heyetraporsonuclari where siklus_id = "+Request.QueryString["siklus_id"].ToString()+"", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);


        if (dt6.Rows.Count > 0)
        {
            string ad = mp_class.hasta_adi_bul(hasta_id);
            if (etkalan3.Text == "")
            {


                string a = "~/ivfyonetici/0000058.aspx?islem=opu&ID=" + dt6.Rows[0]["raporID"].ToString() + "&adim=yeni&ad=" + ad + " - OPU Tarihi";

                Response.Redirect(a);

            }
            else if (etkalan3.Text != "")
            {

                string b = "~/ivfyonetici/0000058.aspx?islem=opu&ID=" + dt6.Rows[0]["raporID"].ToString() + "&adim=guncelle&ad=" + ad + " - OPU Tarihi Değiştir&tarih=" + dt6.Rows[0]["oputarihi"].ToString().Substring(0,10) + "";
                Response.Redirect(b);

            }
        }
        else
        {
            Panel3.Visible = true;
            Label5.Text = "Hasta tedavi sürecinde değil veya aktif siklus belirtilmedi!";
            Label5.ForeColor = System.Drawing.Color.Red;
        }

       
       
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {


        HttpCookie islemdekihastasm = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihastasm["HastaID"];

        string ad = mp_class.hasta_adi_bul(hasta_id);

        MySqlConnection connect_word = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from  heyetraporsonuclari where siklus_id = " + Request.QueryString["siklus_id"].ToString() + "", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);


        if (dt6.Rows.Count > 0)
        {


            if (etkalan4.Text == "")
            {
                string c = "~/ivfyonetici/0000058.aspx?islem=et&ID=" + dt6.Rows[0]["raporID"].ToString() + "&adim=yeni&ad=" + ad + " - ET Tarihi";
                Response.Redirect(c);


            }
            else if (etkalan4.Text != "")
            {
                string d = "~/ivfyonetici/0000058.aspx?islem=et&ID=" + dt6.Rows[0]["raporID"].ToString() + "&adim=guncelle&ad=" + ad + " - ET Tarihi Değiştir&tarih=" + dt6.Rows[0]["transfertarihi"].ToString().Substring(0, 10) + "";
                Response.Redirect(d);

            }
        }

        else
        {
            Panel3.Visible = true;
            Label5.Text = "Hasta tedavi sürecinde değil veya aktif siklus belirtilmedi!";
            Label5.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void txtcogul_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (txtcogul.SelectedValue == "+")
        {

            txtgebeliksayisi.Text = "";        
        }
        else if (txtcogul.SelectedValue == "-")
        {

            txtgebeliksayisi.Text = "1";
        }

    }
}
