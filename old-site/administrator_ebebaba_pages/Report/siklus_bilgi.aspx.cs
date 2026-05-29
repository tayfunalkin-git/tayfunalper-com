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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;

public partial class siklus_bilgi_admin : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hasta_yukle();
 
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string hasta_id = hasta_list.SelectedValue.ToString();
        string siklus_id = siklus_list.SelectedValue.ToString();
        string sql = string.Empty;
    
        if (hasta_id == "0" && (siklus_list.SelectedItem == null || siklus_list.SelectedIndex==0))
        {
            sql = "select S.siklus_id,U.uye_adi as Ad,U.uye_soyadi as Soyad,concat(S.siklus_ay,' ',S.siklus_yil) as Siklus,K.sat as Sat,K.tani1 as Tani1,K.tani2 as Tani2,K.tani3 as Tani3,K.tani4 as Tani4,K.kurum_id as Kurum,K.tedavi_turu_id as Tedavi_Turu,K.tedavi_protokolu as Tedavi_Protokolu,K.alan1 as Zamaninda_iliski,K.alan2 as 21_gun_progesteron,K.oi as Oi,K.iui as iui,K.ivf as ivf,K.kullanilan_fsh as Kullanilan_Fsh,K.hiperstimulasyon as Hiperstimulasyon,K.ovulasyon as Ovulasyon,K.alan3 as opu,K.alan4 as transfer,K.gebelik as gebelik,K.biyokimyasal as biyokimyasal,K.abortus as abortus,K.cogul as cogul,K.agirlik as agirlik,K.dogum as dogum,pcos,antralsag,antralsol,oversag,oversol,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y'))) as yas,fsh,lh,e2,left((cast(U.kilo as DECIMAL)/(cast(U.boy as DECIMAL) * cast(U.boy as DECIMAL) / 10000)),4) as vki,K.bazaltarih as bazal from siklus_ana_tab S,kisa_siklus K, uye_hasta U where K.siklus_id = S.siklus_id and cast(S.hasta_id as UNSIGNED) = U.uye_id order by concat(U.uye_adi,' ',U.uye_soyadi) asc ";
        }
        else if (hasta_id != "0" && siklus_id == "0" && siklus_id != "")
        {
            sql = "select S.siklus_id,U.uye_adi as Ad,U.uye_soyadi as Soyad,concat(S.siklus_ay,' ',S.siklus_yil) as Siklus,K.sat as Sat,K.tani1 as Tani1,K.tani2 as Tani2,K.tani3 as Tani3,K.tani4 as Tani4,K.kurum_id as Kurum,K.tedavi_turu_id as Tedavi_Turu,K.tedavi_protokolu as Tedavi_Protokolu,K.alan1 as Zamaninda_iliski,K.alan2 as 21_gun_progesteron,K.oi as Oi,K.iui as iui,K.ivf as ivf,K.kullanilan_fsh as Kullanilan_Fsh,K.hiperstimulasyon as Hiperstimulasyon,K.ovulasyon as Ovulasyon,K.alan3 as opu,K.alan4 as transfer,K.gebelik as gebelik,K.biyokimyasal as biyokimyasal,K.abortus as abortus,K.cogul as cogul,K.agirlik as agirlik,K.dogum as dogum,pcos,antralsag,antralsol,oversag,oversol,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y'))) as yas,fsh,lh,e2,left((cast(U.kilo as DECIMAL)/(cast(U.boy as DECIMAL) * cast(U.boy as DECIMAL) / 10000)),4) as vki,K.bazaltarih as bazal from siklus_ana_tab S,kisa_siklus K, uye_hasta U  where K.siklus_id = S.siklus_id and S.hasta_id = '" + hasta_id + "' and cast(S.hasta_id as UNSIGNED) = U.uye_id  order by Date_Format(cast(concat('01.',S.siklus_ay2,'.',S.siklus_yil) as Date),'%d.%m.%y') asc";
        }
        else if (hasta_id != "0" && siklus_id != "0")
        {
            sql = "select S.siklus_id,U.uye_adi as Ad,U.uye_soyadi as Soyad,concat(S.siklus_ay,' ',S.siklus_yil) as Siklus,K.sat as Sat,K.tani1 as Tani1,K.tani2 as Tani2,K.tani3 as Tani3,K.tani4 as Tani4,K.kurum_id as Kurum,K.tedavi_turu_id as Tedavi_Turu,K.tedavi_protokolu as Tedavi_Protokolu,K.alan1 as Zamaninda_iliski,K.alan2 as 21_gun_progesteron,K.oi as Oi,K.iui as iui,K.ivf as ivf,K.kullanilan_fsh as Kullanilan_Fsh,K.hiperstimulasyon as Hiperstimulasyon,K.ovulasyon as Ovulasyon,K.alan3 as opu,K.alan4 as transfer,K.gebelik as gebelik,K.biyokimyasal as biyokimyasal,K.abortus as abortus,K.cogul as cogul,K.agirlik as agirlik,K.dogum as dogum,pcos,antralsag,antralsol,oversag,oversol,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y'))) as yas,fsh,lh,e2, left((cast(U.kilo as DECIMAL)/(cast(U.boy as DECIMAL) * cast(U.boy as DECIMAL) / 10000)),4) as vki,K.bazaltarih as bazal from siklus_ana_tab S,kisa_siklus K, uye_hasta U  where K.siklus_id = S.siklus_id and S.siklus_id = " + siklus_id + " and cast(S.hasta_id as UNSIGNED) = U.uye_id order by Date_Format(cast(concat('01.',S.siklus_ay2,'.',S.siklus_yil) as Date),'%d.%m.%y') asc";
        }
        else
        {
            sql = "";
        }


        Session.Add("sqlim_siklus", sql);

        Response.Redirect("rapor_goster.aspx");


  

    
    }

  
    protected void hasta_list_SelectedIndexChanged(object sender, EventArgs e)
    {

        Session.Clear();


        if (hasta_list.SelectedIndex == 0)
        {
            siklus_list.Enabled = false;
            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
            yeni.Value = "0";
            siklus_list.Items.Insert(0, yeni);
            siklus_list.SelectedIndex = 0;
        }
        else
        {
            siklus_list.Enabled = true;
            doldur();
        }


    }


  

    void doldur()
    {

         try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select siklus_id , concat(siklus_ay,' ',siklus_yil) as sikls from siklus_ana_tab  where hasta_id='" + hasta_list.SelectedValue.ToString() + "' order by date('01.' & siklus_ay2 & '.' & siklus_yil) desc", ebebaba_connection);      
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);




            siklus_list.DataSource = ebebaba_dt;
            siklus_list.DataTextField = ebebaba_dt.Columns["sikls"].ToString();
            siklus_list.DataValueField = ebebaba_dt.Columns["siklus_id"].ToString();

            siklus_list.DataBind();



            if (ebebaba_dt.Rows.Count > 1)
            {
                ListItem yeni = new ListItem();
                yeni.Text = "Hepsi";
                yeni.Value = "0";
                siklus_list.Items.Insert(0, yeni);
            }

        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc2.Text = "Siklus Listesi Yüklenirken Hata Oluştu !";
            sonuc2.ForeColor = System.Drawing.Color.Red;

        }

    }


    void hasta_yukle()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("select uye_id as id,concat(uye_adi,' ',uye_soyadi) as ad  from uye_hasta order by concat(uye_adi,' ',uye_soyadi) asc", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            hasta_list.DataSource = ebebaba_dt;
            hasta_list.DataTextField = ebebaba_dt.Columns["ad"].ToString();
            hasta_list.DataValueField = ebebaba_dt.Columns["id"].ToString();

            hasta_list.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
            yeni.Value = "0";
            hasta_list.Items.Insert(0, yeni);



        }
        catch
        {

            panel_sonuc.Visible = true;
            sonuc2.Text = "Hasta Listesi Yüklenirken Hata Oluştu !";
            sonuc2.ForeColor = System.Drawing.Color.Red;

        }

    }


    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Report_List.aspx");

    }
}
