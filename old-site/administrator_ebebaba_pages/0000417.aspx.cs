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
using System.IO;


public partial class ivfyonetici_0000070 : System.Web.UI.Page
{

    ivf_class mp_class = new ivf_class();
    protected void Page_Load(object sender, EventArgs e)
    {

      //  denetim();

        if (!IsPostBack)
        {
            renkYukle();
            kurum_yukle();
            dr_yukle();
            dis_dr_yukle();
            s_dr_yukle();
            tedavi_turu_yukle();
            tedavi_protokolu_yukle();
            Label33.Text = DateTime.Now.ToShortDateString();
            baslangicay.SelectedValue = "01";
            baslangicyil.SelectedValue = "2015";

            bitisyil.SelectedValue = DateTime.Now.Date.Year.ToString();
            bitisay.SelectedValue = mp_class.yeniTarih(DateTime.Now.Date.ToString()).Substring(3, 2);
        }
    }

    void renkYukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from siklusrenk order by ID asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            renk.DataSource = dt6;
            renk.DataTextField = dt6.Columns["renk"].ToString();
            renk.DataValueField = dt6.Columns["ID"].ToString();
            renk.DataBind();




        }
        catch
        {


        }

    }
    private void denetim()
    {

        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();


        MySqlConnection connect_word = mp_class.connect_flry(0301009184);
        MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from uye_doktor where (superAdmin ='+' or muhasebe='+') and  uye_k_adi='" + kullaniciAdiAdmin + "'", connect_word);
        DataTable dtsub = new DataTable();
        da3.Fill(dtsub);

        if (dtsub.Rows.Count != 1)
        {
            Response.Redirect("signout.aspx");
        }

    }

    private void s_dr_yukle()
    {

        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select uye_id,kisaAd from uye_doktor where disdoktor='+' and kisaAd != ''", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            drp_dr2.DataSource = dt6;
            drp_dr2.DataTextField = dt6.Columns[1].ToString();
            drp_dr2.DataValueField = dt6.Columns[0].ToString();
            drp_dr2.DataBind();

        }
        catch
        {


        }



    }
    void kurum_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from kurumlar order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            txtkurum.DataSource = dt6;
            txtkurum.DataTextField = dt6.Columns["kurum_adi"].ToString();
            txtkurum.DataValueField = dt6.Columns["kurum_id"].ToString();
            txtkurum.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
            yeni.Value = "";

            yeni.Selected = true;

            txtkurum.Items.Insert(0, yeni);
            txtkurum.SelectedValue = "36";

        }
        catch
        {


        }

    }
    void dr_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select distinct dr from kisa_siklus", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            drp_dr.DataSource = dt6;
            drp_dr.DataTextField = dt6.Columns[0].ToString();
            drp_dr.DataValueField = dt6.Columns[0].ToString();
            drp_dr.DataBind();

            drp_dr.Items.Remove(drp_dr.Items.FindByValue(""));

            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
            yeni.Value = "";

            yeni.Selected = true;

            drp_dr.Items.Insert(0, yeni);


        }
        catch
        {


        }

    }

    void dis_dr_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select uye_id,kisaAd from uye_doktor where disdoktor='+' and kisaAd <>'' order by kisaAd asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            drp_dis.DataSource = dt6;
            drp_dis.DataTextField = dt6.Columns[1].ToString();
            drp_dis.DataValueField = dt6.Columns[0].ToString();
            drp_dis.DataBind();

            drp_dis.Items.Remove(drp_dis.Items.FindByValue(""));

            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
            yeni.Value = "";

            yeni.Selected = true;

            drp_dis.Items.Insert(0, yeni);


        }
        catch
        {


        }

    }
    void tedavi_turu_yukle()
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from tedavi_turleri order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            txttedavituru.DataSource = dt6;
            txttedavituru.DataTextField = dt6.Columns["tedavi_adi"].ToString();
            txttedavituru.DataValueField = dt6.Columns["tur_id"].ToString();
            txttedavituru.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
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
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from tedavi_protokolleri order by sira asc", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            txttedaviprotokolu.DataSource = dt6;
            txttedaviprotokolu.DataTextField = dt6.Columns["protokol_adi"].ToString();
            txttedaviprotokolu.DataValueField = dt6.Columns["protokol_id"].ToString();
            txttedaviprotokolu.DataBind();

            ListItem yeni = new ListItem();
            yeni.Text = "Hepsi";
            yeni.Value = "";

            yeni.Selected = true;

            txttedaviprotokolu.Items.Insert(0, yeni);
        }
        catch
        { }

    }
    string protokolbul(string gelen)
    {
        try
        {
            MySqlConnection connect_word = mp_class.connect_flry(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select protokol_adi from tedavi_protokolleri where protokol_id=" + gelen + "", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            if (dt6.Rows.Count == 1)
            {
                return dt6.Rows[0][0].ToString();

            }
            else
            {
                return "";
            }

        }
        catch
        {

            return "";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {


        //int sayi = list.Items.Count;
        //for (int a = 0; a < sayi; a++)
        //{ 

        //GridView c = new GridView();
        //ImageButton ac = new ImageButton();
        //ac = (ImageButton)list.Items[a].FindControl("ac");
        //ac.Visible = false;

        //ImageButton kapat = new ImageButton();
        //kapat = (ImageButton)list.Items[a].FindControl("kapat");
        //kapat.Visible = false;

        //c = (GridView)list.Items[a].FindControl("detay2");
        //c.Visible = false;

        //}





        //GridiExceleKaydet();


    }
    protected void GridiExceleKaydet()
    {

        //// Gönderilecek cevaba gridin içeriðini yazdýrmak için GridView1 kontrolünü render etmek gerekli. Bu iþlemleri 
        //// StringWriter ve HtmlTextWriter nesnelerini ile yürütüyoruz. StringWriter, System.IO isim alaný altýnda yer alýr
        //StringWriter stringYaz = new StringWriter();
        //HtmlTextWriter htw = new HtmlTextWriter(stringYaz);

        //StringWriter stringYaz2 = new StringWriter();
        //HtmlTextWriter htw2 = new HtmlTextWriter(stringYaz2);

        //headr.Visible = true;
        //headr.RenderControl(htw);
        //snc2.RenderControl(htw);
        //list.RenderControl(htw2);

        // // Ýstemciye gönderilecek cevabý oluþturuyoruz. Öncelikli olarak cevapta(response da) þu ana kadar oluþan
        //// bilgileri silip, cevabýn baþlýk bilgisine gönderilecek dosya ile ilgili bilgileri ekliyoruz.  Dosya tipini belirttikten
        //// sonra yukarýda oluþturulan StringWriter nesnesini  ToString metodu ile cevaba yazdýrýyoruz

        //Response.Clear();
        //Response.ContentEncoding = System.Text.Encoding.GetEncoding("windows-1254");
        //Response.Charset = "windows-1254";

        //Response.AddHeader("content-disposition", "attachment;filename=mp0000064.xls");
        //Response.ContentType = "application/ms-excel";

        //Label28.Visible = true;
        //Label29.Visible = true;
        //Label30.Visible = true;
        //Label31.Visible = true;
        //Label32.Visible = true; 
        //Label44.Visible = true;


        //Label28.Visible = false;
        //Label29.Visible = false;
        //Label30.Visible = false;
        //Label31.Visible = false;
        //Label32.Visible = false;
        //Label44.Visible = false;

        //Response.Write(stringYaz.ToString());
        //Response.Write(stringYaz2.ToString());
        //Response.End();
        //headr.Visible = false;


    }
    protected void editres_Command(object sender, CommandEventArgs e)
    {

        string[] satirlar = e.CommandName.ToString().Split(',');
        int a = int.Parse(satirlar[0]);
        int b = int.Parse(satirlar[1]);

        GridView yeni = new GridView();
        yeni = (GridView)list3.Items[a].FindControl("detay3");

        ((ImageButton)yeni.Rows[b].FindControl("save")).Visible = true;
        ((ImageButton)yeni.Rows[b].FindControl("save")).CommandArgument = e.CommandArgument.ToString();
        ((ImageButton)yeni.Rows[b].FindControl("save")).CommandName = e.CommandName.ToString();


        ((ImageButton)yeni.Rows[b].FindControl("edt")).Visible = false;
        ((Label)yeni.Rows[b].FindControl("calismaProtokolKodu")).Visible = false;
        ((Label)yeni.Rows[b].FindControl("baslamaTarihi")).Visible = false;
        ((Label)yeni.Rows[b].FindControl("bitisTarihi")).Visible = false;
        ((Label)yeni.Rows[b].FindControl("kayitTarihi")).Visible = false;
        ((Label)yeni.Rows[b].FindControl("deger")).Visible = false;


        ((Label)yeni.Rows[b].FindControl("lblSDr")).Visible = true;
        ((Label)yeni.Rows[b].FindControl("lblDDr")).Visible = true;




        ((DropDownList)yeni.Rows[b].FindControl("sDr")).Visible = true;
        ((DropDownList)yeni.Rows[b].FindControl("dDr")).Visible = true;

        ((TextBox)yeni.Rows[b].FindControl("txtCalismaProtokolKodu")).Visible = true;
        ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Visible = true;
        ((TextBox)yeni.Rows[b].FindControl("txtBitisTarihi")).Visible = true;
        ((TextBox)yeni.Rows[b].FindControl("txtKayitTarihi")).Visible = true;
        ((TextBox)yeni.Rows[b].FindControl("txtDeger")).Visible = true;


        ((TextBox)yeni.Rows[b].FindControl("txtCalismaProtokolKodu")).Text = ((Label)yeni.Rows[b].FindControl("calismaProtokolKodu")).Text;
        ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Text = ((Label)yeni.Rows[b].FindControl("baslamaTarihi")).Text;
        ((TextBox)yeni.Rows[b].FindControl("txtBitisTarihi")).Text = ((Label)yeni.Rows[b].FindControl("bitisTarihi")).Text;
        ((TextBox)yeni.Rows[b].FindControl("txtKayitTarihi")).Text = ((Label)yeni.Rows[b].FindControl("kayitTarihi")).Text;
        ((TextBox)yeni.Rows[b].FindControl("txtDeger")).Text = ((Label)yeni.Rows[b].FindControl("deger")).Text;


        DropDownList siklusDr = new DropDownList();
        siklusDr = (DropDownList)yeni.Rows[b].FindControl("sDr");

        DropDownList disDr = new DropDownList();
        disDr = (DropDownList)yeni.Rows[b].FindControl("dDr");

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



        MySqlDataAdapter da5 = new MySqlDataAdapter("Select * from kisa_siklus where siklus_id=" + e.CommandArgument + "", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        if (dt5.Rows.Count > 0)
        {
            if (dt5.Rows[0]["dr"].ToString() == "")
            {

                siklusDr.SelectedIndex = 0;
                ((Label)yeni.Rows[b].FindControl("lblSiklusDr")).Text = "Seç/Sil";

            }
            else
            {
                siklusDr.SelectedValue = dt5.Rows[0]["dr"].ToString().Substring(4, 2);
                ((Label)yeni.Rows[b].FindControl("lblSiklusDr")).Text = dt5.Rows[0]["dr"].ToString().Substring(4, 2);
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

        MySqlDataAdapter da55 = new MySqlDataAdapter("Select U.uye_id from uye_doktor U,atama A where A.doktorID=U.uye_id and A.siklusID=" + e.CommandArgument + "", connect_word);
        DataTable dt55 = new DataTable();
        da55.Fill(dt55);

        if (dt55.Rows.Count == 0)
        {
            disDr.SelectedIndex = 0;
            ((Label)yeni.Rows[b].FindControl("lblDisDr")).Text = "Seç/Sil";
        }
        else
        {
            disDr.SelectedValue = dt55.Rows[0][0].ToString();
            ((Label)yeni.Rows[b].FindControl("lblDisDr")).Text = disDr.SelectedItem.Text;
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        Panel1.Visible = true;
        list3.Visible = true;
        list.Visible = false;

        Label28.Text = txtkurum.SelectedItem.ToString();
        Label29.Text = txttedavituru.SelectedItem.ToString();
        Label30.Text = txttedaviprotokolu.SelectedItem.ToString();
        Label31.Text = baslangicay.SelectedItem.ToString() + " " + baslangicyil.SelectedItem.ToString();
        Label32.Text = bitisay.SelectedItem.ToString() + " " + bitisyil.SelectedItem.ToString();
        Label76.Text = drp_dis.SelectedItem.Text;
        Label34.Text = drp_dr.SelectedItem.Text;
        Label44.Text = suzgec.SelectedValue.ToString();
        //list.Visible = false;

        DateTime baslangictarihi = DateTime.Parse("01." + baslangicay.SelectedValue.ToString() + "." + baslangicyil.SelectedValue.ToString());
        DateTime bitistarihi = DateTime.Parse("01." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString());

        if (baslangictarihi > bitistarihi)
        {

            Label42.Text = "Baþlangýç tarihi bitiþ tarihinden büyük olamaz !";

        }

        else
        {

            siklusyukle31();


        }


    }
    void siklusyukle31()
    {

        DateTime baslangictarihi = DateTime.Parse("01." + baslangicay.SelectedValue.ToString() + "." + baslangicyil.SelectedValue.ToString());

        DateTime bitistarihi = DateTime.Parse("01." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString());


        DateTime.TryParse("31." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString(), out bitistarihi);

        DateTime.TryParse("30." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString(), out bitistarihi);

        DateTime.TryParse("29." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString(), out bitistarihi);

        DateTime.TryParse("28." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString(), out bitistarihi);

        string sql = String.Empty;
        string sql2 = String.Empty;


        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex == 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU  , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.istatistik is null and  (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU  , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.istatistik is null and  (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc";
        }
        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex != 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU  , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id  where  K.alan3 <>'' and  K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry, U.uye_id as hID  from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id  where K.alan3 <>'' and   K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }
        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex == 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }

        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex == 0)
        {

            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU, L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "'  and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "'  and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }
        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex != 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null and  (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }
        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex != 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger,S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay ,str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU ,  K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }
        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex == 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU ,  L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger,S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }
        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex != 0)
        {
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU ,  L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
            sql2 = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,L.txt9 as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay ,str_to_date(K.alan3,'%d.%m.%Y %H:%i:%s') as OPU ,  K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , L.txt50 as oosit ,L.txt69 as totalfertilize ,L.txt33 as kriyo , K.gebeliksayisi as gs,P.txt78 as protokol,P.txt79 as bat, P.txt80 as bit, P.txt81 as kat,P.deger as deger, S.siklus_id as SID,K.fkh as FKH,K.kriyoyapildimi as kry , U.uye_id as hID from siklus_ana_tab S LEFT JOIN labSonuc as L ON L.siklusID=S.siklus_id LEFT JOIN labProtokol as P ON P.siklusID=S.siklus_id LEFT JOIN uye_hasta U ON U.uye_id = CAST(S.hasta_id as UNSIGNED) LEFT JOIN kisa_siklus K ON K.siklus_id=S.siklus_id LEFT JOIN atama as A ON A.siklusID=S.siklus_id LEFT JOIN uye_doktor as D ON A.doktorID=D.uye_id where K.alan3 <>'' and  K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null and (P.txt78 <>'' or P.txt79 <>'' or P.txt80<>'' or P.txt81) order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s')  asc";
        }


        if (drp_dr.SelectedIndex != 0 && drp_dr.SelectedValue != "bos")
        {
            int sncm = sql.IndexOf("order");
            sql = sql.Insert(sncm, " and K.dr='" + drp_dr.SelectedValue.ToString() + "' ");
        }
        else if (drp_dr.SelectedValue == "bos")
        {
            int sncm = sql.IndexOf("order");
            sql = sql.Insert(sncm, " and (K.dr='' or K.dr is null) ");
        }


        if (drp_dis.SelectedIndex != 0 && drp_dis.SelectedValue != "bos")
        {
            int sncm = sql.IndexOf("order");
            sql = sql.Insert(sncm, " and A.doktorID='" + drp_dis.SelectedValue.ToString() + "' ");
        }

        if (kategori.SelectedIndex != 0 && kategori.SelectedValue != "")
        {
            int sncm = sql.IndexOf("order");
            sql = sql.Insert(sncm, " and D.kategori='" + kategori.SelectedValue.ToString() + "' ");
        }


        if (ckt.Checked == true)
        {
            int sncm = sql.IndexOf("order");
            sql = sql.Insert(sncm, " and (P.txt81 ='' or P.txt81 = null or P.txt81='-') ");
        
        }



        MySqlConnection mp_connection = mp_class.connect_flry(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter(sql, mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        MySqlDataAdapter mp_da_yeni = new MySqlDataAdapter(sql2, mp_connection);
        DataTable mp_dt_yeni = new DataTable();
        mp_da_yeni.Fill(mp_dt_yeni);

        string goruntulemesekli = string.Empty;


        DataTable dttarih = new DataTable();
        DataColumn dc = new DataColumn("ay");
        DataColumn dc2 = new DataColumn("yil");

        dttarih.Columns.Add(dc);
        dttarih.Columns.Add(dc2);



        Label42.Text = "";

        if (suzgec.SelectedIndex == 0)
        {

            while (baslangictarihi <= bitistarihi)
            {

                DataRow dr = dttarih.NewRow();

                if (baslangictarihi.Month < 10)
                {
                    dr[0] = "0" + baslangictarihi.Month.ToString();
                }
                else
                {
                    dr[0] = baslangictarihi.Month.ToString();
                }


                dr[1] = baslangictarihi.Year.ToString();
                dttarih.Rows.Add(dr);

                baslangictarihi = baslangictarihi.AddMonths(1);


            }


        }
        else if (suzgec.SelectedIndex == 1)
        {

            while (baslangictarihi.Year <= bitistarihi.Year)
            {

                DataRow dr = dttarih.NewRow();

                dr[1] = baslangictarihi.Year.ToString();
                dttarih.Rows.Add(dr);

                baslangictarihi = baslangictarihi.AddYears(1);


            }

        }


        list3.DataSource = dttarih;
        list3.DataBind();


        Label label68 = new Label();
        Label label71 = new Label();
        Label label70 = new Label();
        Label label69 = new Label();


        Label label72 = new Label();
        Label label73 = new Label();
        Label label74 = new Label();
        Label label75 = new Label();
        Label label175 = new Label();


        GridView listehasta = new GridView();
        ImageButton ac = new ImageButton();
        ImageButton kapat = new ImageButton();


        if (suzgec.SelectedIndex == 0)
        {

            int a = 0;

            double protokol = 0, bat = 0, bit = 0, kat = 0;
            //double biyokimyasalh_yeni = 0, biyokimyasalh2 = 0, gebelikh2 = 0, ovulasyonh2 = 0, abortush2 = 0, cgebelikh2 = 0, dogumh2 = 0, hiperstimulasyonh2 = 0;
            //double abortush_yeni = 0, biyoyuzde = 0, canliyuzde = 0, gebeyuzde = 0, ovuyuzde = 0, aboyuzde = 0, cgebeyuzde = 0, dogmyuzde = 0, hiperyuzde = 0;
            //double dogum_yeni = 0, dogumh_yeni = 0, biyoyuzdeh = 0, canliyuzdeh = 0, gebeyuzdeh = 0, ovuyuzdeh = 0, aboyuzdeh = 0, cgebeyuzdeh = 0, dogmyuzdeh = 0, hiperyuzdeh = 0;
            //double toplamsiklussayisi = 0;
            //double biyokimyasal = 0, gebelik = 0, canli = 0, ovulasyon = 0, abortus = 0, cgebelik = 0, dogum = 0, hiperstimulasyon = 0;
            //double biyokimyasal2 = 0, gebelik2 = 0, ovulasyon2 = 0, abortus2 = 0, cgebelik2 = 0, dogum2 = 0, hiperstimulasyon2 = 0;
            int toplamhastasayisih = 0;

            foreach (DataListItem str in list3.Items)
            {

                label68 = (Label)str.FindControl("Label68");
                label68.Text = mp_class.ayadi(int.Parse(dttarih.Rows[a][0].ToString())) + " - " + dttarih.Rows[a][1].ToString();

                DataRow[] gebeliksatiri0 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'", "");


                DataTable gebelikdt0 = mp_dt.Copy();
                gebelikdt0.Clear();

                foreach (DataRow yeni in gebeliksatiri0)
                {
                    gebelikdt0.ImportRow(yeni);

                }
                int protokolsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["protokol"].ToString().TrimEnd().TrimStart() != "")
                    {

                        protokolsay++;

                    }
                }


                int batsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["bat"].ToString().TrimEnd().TrimStart() != "")
                    {

                        batsay++;

                    }
                }



                int bitsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["bit"].ToString().TrimEnd().TrimStart() != "")
                    {

                        bitsay++;
                    }
                }


                int katsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["kat"].ToString().TrimEnd().TrimStart() != "")
                    {

                        katsay++;
                    }
                }

                int degsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["deger"].ToString().TrimEnd().TrimStart() != "")
                    {
                        int deg = 0;
                        int.TryParse(gebelikdt0.Rows[c]["deger"].ToString(), out deg);
                        degsay += deg;
                    }
                }


                label72 = (Label)str.FindControl("Label72");
                if (protokolsay == 0)
                {
                    label72.Text = "-";
                }
                else
                {
                    label72.Text = protokolsay.ToString();
                }
                label73 = (Label)str.FindControl("Label73");
                if (batsay == 0)
                {
                    label73.Text = "-";
                }
                else
                {
                    label73.Text = batsay.ToString();
                }
                label74 = (Label)str.FindControl("Label74");
                if (bitsay == 0)
                {
                    label74.Text = "-";
                }
                else
                {
                    label74.Text = bitsay.ToString();
                }



                label75 = (Label)str.FindControl("Label75");
                if (katsay == 0)
                {
                    label75.Text = "-";
                }
                else
                {
                    label75.Text = katsay.ToString();
                }


                label175 = (Label)str.FindControl("Label175");
                if (degsay == 0)
                {
                    label175.Text = "-";
                }
                else
                {
                    label175.Text = degsay.ToString();
                }


                //Label44.Text = opumh.ToString();


                toplamhastasayisih = gebelikdt0.Rows.Count;


                int toplamsiklussayisi = gebelikdt0.Rows.Count;


                listehasta = (GridView)str.FindControl("detay3");

                listehasta.DataSource = gebelikdt0;
                listehasta.DataBind();


                ImageButton edt = new ImageButton();
                LinkButton adiSoyadi = new LinkButton();
                Label calismaProtokolKodu = new Label();
                Label baslamaTarihi = new Label();
                Label bitisTarihi = new Label();
                Label kayitTarihi = new Label();
                Label deger = new Label();

                Label lblSDr = new Label();
                Label lblDdr = new Label();

                Label hID = new Label();
                Label skls = new Label();


                DropDownList sdr = new DropDownList();
                DropDownList ddr = new DropDownList();

                TextBox txtAdiSoyadi = new TextBox();
                TextBox txtCalismaProtokolKodu = new TextBox();
                TextBox txtBaslamaTarihi = new TextBox();
                TextBox txtBitisTarihi = new TextBox();
                TextBox txtKayitTarihi = new TextBox();
                TextBox txtDeger = new TextBox();




                int klm = 0;
                foreach (GridViewRow satir in listehasta.Rows)
                {

                    edt = (ImageButton)satir.FindControl("edt");
                    adiSoyadi = (LinkButton)satir.FindControl("adiSoyadi");
                    calismaProtokolKodu = (Label)satir.FindControl("calismaProtokolKodu");
                    baslamaTarihi = (Label)satir.FindControl("baslamaTarihi");
                    bitisTarihi = (Label)satir.FindControl("bitisTarihi");
                    kayitTarihi = (Label)satir.FindControl("kayitTarihi");
                    deger = (Label)satir.FindControl("deger");

                    hID = (Label)satir.FindControl("hID");
                    skls = (Label)satir.FindControl("skls");

                    txtCalismaProtokolKodu = (TextBox)satir.FindControl("txtCalismaProtokolKodu");
                    txtBaslamaTarihi = (TextBox)satir.FindControl("txtBaslamaTarihi");
                    txtBitisTarihi = (TextBox)satir.FindControl("txtBitisTarihi");
                    txtKayitTarihi = (TextBox)satir.FindControl("txtKayitTarihi");
                    txtDeger = (TextBox)satir.FindControl("txtDeger");
                    edt.OnClientClick = "window.open('mp55thumbflry.aspx?id=" + gebelikdt0.Rows[klm]["SID"].ToString() + "','','location=0,status=0,scrollbars=1,width=350,height=400');return false;";

                    //edt.CommandArgument = gebelikdt0.Rows[klm]["SID"].ToString();
                    //edt.CommandName = a.ToString() + "," + klm.ToString();
                    adiSoyadi.Text = gebelikdt0.Rows[klm]["ad"].ToString();
                    adiSoyadi.OnClientClick = "createWindow('https://flry.ebebaba.com/ivfyonetici/hasta_modulu/th4820ft.aspx?ID=" + gebelikdt0.Rows[klm]["hID"].ToString() + "','" + gebelikdt0.Rows[klm]["ad"].ToString() + "','90%','530','');return false;";

                //    adiSoyadi.CommandArgument = gebelikdt0.Rows[klm]["SID"].ToString();
                    skls.Text = gebelikdt0.Rows[klm]["siklus"].ToString();
                    calismaProtokolKodu.Text = gebelikdt0.Rows[klm]["protokol"].ToString();
                    baslamaTarihi.Text = gebelikdt0.Rows[klm]["bat"].ToString();
                    bitisTarihi.Text = gebelikdt0.Rows[klm]["bit"].ToString();
                    kayitTarihi.Text = gebelikdt0.Rows[klm]["kat"].ToString();
                    deger.Text = gebelikdt0.Rows[klm]["deger"].ToString();
                    hID.Text = gebelikdt0.Rows[klm]["hID"].ToString();


                    txtCalismaProtokolKodu.Text = gebelikdt0.Rows[klm]["protokol"].ToString();
                    txtBaslamaTarihi.Text = gebelikdt0.Rows[klm]["bat"].ToString();
                    txtBitisTarihi.Text = gebelikdt0.Rows[klm]["bit"].ToString();
                    txtKayitTarihi.Text = gebelikdt0.Rows[klm]["kat"].ToString();
                    txtDeger.Text = gebelikdt0.Rows[klm]["deger"].ToString();

                    //satir.Cells[0].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[1].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[2].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[3].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[4].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[5].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[0].ForeColor = System.Drawing.Color.Black;


                    if (gebelikdt0.Rows[klm]["ge"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);

                    }

                    if (gebelikdt0.Rows[klm]["ge"].ToString() == "-")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);

                    }


                    if (gebelikdt0.Rows[klm]["biy"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);

                    }

                    if (gebelikdt0.Rows[klm]["ab"].ToString() == "+")
                    {

                        if (gebelikdt0.Rows[klm]["fkh"].ToString() == "+")
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);

                        }
                        else
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);

                        }

                    }

                    if (gebelikdt0.Rows[klm]["kry"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                    }



                    klm++;

                }









                ac = (ImageButton)str.FindControl("ac");
                kapat = (ImageButton)str.FindControl("kapat");
                if (toplamsiklussayisi < 1)
                {
                    ac.Visible = false;
                }
                else
                {
                    ac.Visible = true;
                }

                int k = a + 1;

                if (k < 10)
                {


                    ac.OnClientClick = "ctl00_ContentPlaceHolder1_list3_ctl01_detay3";



                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_detay3').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_detay3').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_ac').style.display='';return false;";


                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }
                else
                {
                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_detay3').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_detay3').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_ac').style.display='';return false;";



                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }




                label71 = (Label)str.FindControl("Label71");
                label71.Text = "S : " + toplamsiklussayisi.ToString();
                //+ " / H : " + toplamhastasayisih.ToString();

                if (toplamsiklussayisi == 0)
                {
                    str.Enabled = false;
                }


                DataRow[] gebeliksatiriO = mp_dt.Select("Ov='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] gebeliksatiri2O = mp_dt.Select("Ov='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");

                DataTable gebelikdtO = mp_dt.Copy();
                gebelikdtO.Clear();

                foreach (DataRow yeni in gebeliksatiriO)
                {
                    gebelikdtO.ImportRow(yeni);

                }

                DataTable gebelikdt5O = mp_dt.Copy();
                gebelikdt5O.Clear();

                foreach (DataRow yeni in gebeliksatiri2O)
                {
                    gebelikdt5O.ImportRow(yeni);

                }




                label69 = (Label)str.FindControl("Label69");
                label69.Text = " - ";


                label70 = (Label)str.FindControl("Label70");


                if (goruntu.SelectedIndex == 0)
                {


                    DataRow[] canlisatiri = mp_dt.Select("Do='+' and Co='-' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                    DataTable canlidt = mp_dt.Copy();
                    canlidt.Clear();

                    foreach (DataRow yeni in canlisatiri)
                    {
                        canlidt.ImportRow(yeni);

                    }

                    DataTable canlidt2 = canlidt.DefaultView.ToTable(true, new string[] { "ad" });
                    int canlih = canlidt2.Rows.Count;


                    label69.Text = canlih.ToString();

                    if (toplamsiklussayisi != 0)
                    {
                        double say1 = 100 * canlidt.Rows.Count / toplamsiklussayisi;
                        double say2 = 100 * canlih / toplamhastasayisih;


                        //label70.Text = virgulolayi(say2) + " %";
                    }
                    else
                    {

                        label70.Text = " 0 % ";


                    }
                }
                else
                {

                    label69.Text = " - ";


                    label70.Text = " - ";
                }



                //label40 = (Label)str.FindControl("Label40");
                ////label40.Text = hiperstimulasyonh.ToString();
                //label40.Text = totalfertilizesay.ToString() + " / " + fertilalt.ToString();


                //label41 = (Label)str.FindControl("Label41");

                //if (virgulolayi(hiperyuzdeh) == "NaN")
                //{
                //    label41.Text = "0 %";
                //}
                //else
                //{
                //    label41.Text = virgulolayi(hiperyuzdeh) + " %";
                //}












                for (int s = 0; s < list3.Items.Count; s++)
                {

                    if (((Label)list3.Items[s].FindControl("Label71")).Text == "S : 0")
                    {


                        list3.Items[s].CssClass = "gizle";

                        //.Attributes.Add("style", "display:none;");
                    }

                }
                a++;
            }


        }

        else if (suzgec.SelectedIndex == 1)
        {

            int a = 0;

            double protokol = 0, bat = 0, bit = 0, kat = 0;
            //double biyokimyasalh_yeni = 0, biyokimyasalh2 = 0, gebelikh2 = 0, ovulasyonh2 = 0, abortush2 = 0, cgebelikh2 = 0, dogumh2 = 0, hiperstimulasyonh2 = 0;
            //double abortush_yeni = 0, biyoyuzde = 0, canliyuzde = 0, gebeyuzde = 0, ovuyuzde = 0, aboyuzde = 0, cgebeyuzde = 0, dogmyuzde = 0, hiperyuzde = 0;
            //double dogum_yeni = 0, dogumh_yeni = 0, biyoyuzdeh = 0, canliyuzdeh = 0, gebeyuzdeh = 0, ovuyuzdeh = 0, aboyuzdeh = 0, cgebeyuzdeh = 0, dogmyuzdeh = 0, hiperyuzdeh = 0;
            //double toplamsiklussayisi = 0;
            //double biyokimyasal = 0, gebelik = 0, canli = 0, ovulasyon = 0, abortus = 0, cgebelik = 0, dogum = 0, hiperstimulasyon = 0;
            //double biyokimyasal2 = 0, gebelik2 = 0, ovulasyon2 = 0, abortus2 = 0, cgebelik2 = 0, dogum2 = 0, hiperstimulasyon2 = 0;
            int toplamhastasayisih = 0;

            foreach (DataListItem str in list3.Items)
            {

                label68 = (Label)str.FindControl("Label68");
                label68.Text = dttarih.Rows[a][1].ToString();

                DataRow[] gebeliksatiri0 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "'", "");


                DataTable gebelikdt0 = mp_dt.Copy();
                gebelikdt0.Clear();

                foreach (DataRow yeni in gebeliksatiri0)
                {
                    gebelikdt0.ImportRow(yeni);

                }
                int protokolsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["protokol"].ToString().TrimEnd().TrimStart() != "")
                    {

                        protokolsay++;

                    }
                }


                int batsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["bat"].ToString().TrimEnd().TrimStart() != "")
                    {

                        batsay++;

                    }
                }



                int bitsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["bit"].ToString().TrimEnd().TrimStart() != "")
                    {

                        bitsay++;
                    }
                }


                int katsay = 0;

                for (int c = 0; c < gebelikdt0.Rows.Count; c++)
                {
                    if (gebelikdt0.Rows[c]["kat"].ToString().TrimEnd().TrimStart() != "")
                    {

                        katsay++;
                    }
                }


                label72 = (Label)str.FindControl("Label72");
                if (protokolsay == 0)
                {
                    label72.Text = "-";
                }
                else
                {
                    label72.Text = protokolsay.ToString();
                }
                label73 = (Label)str.FindControl("Label73");
                if (batsay == 0)
                {
                    label73.Text = "-";
                }
                else
                {
                    label73.Text = batsay.ToString();
                }
                label74 = (Label)str.FindControl("Label74");
                if (bitsay == 0)
                {
                    label74.Text = "-";
                }
                else
                {
                    label74.Text = bitsay.ToString();
                }



                label75 = (Label)str.FindControl("Label75");
                if (katsay == 0)
                {
                    label75.Text = "-";
                }
                else
                {
                    label75.Text = katsay.ToString();
                }



                //Label44.Text = opumh.ToString();


                toplamhastasayisih = gebelikdt0.Rows.Count;


                int toplamsiklussayisi = gebelikdt0.Rows.Count;


                listehasta = (GridView)str.FindControl("detay3");

                listehasta.DataSource = gebelikdt0;
                listehasta.DataBind();

                ImageButton edt = new ImageButton();
                LinkButton adiSoyadi = new LinkButton();
                Label calismaProtokolKodu = new Label();
                Label baslamaTarihi = new Label();
                Label bitisTarihi = new Label();
                Label kayitTarihi = new Label();
                Label deger = new Label();

                Label lblSDr = new Label();
                Label lblDdr = new Label();

                Label hID = new Label();
                Label skls = new Label();


                DropDownList sdr = new DropDownList();
                DropDownList ddr = new DropDownList();

                TextBox txtAdiSoyadi = new TextBox();
                TextBox txtCalismaProtokolKodu = new TextBox();
                TextBox txtBaslamaTarihi = new TextBox();
                TextBox txtBitisTarihi = new TextBox();
                TextBox txtKayitTarihi = new TextBox();
                TextBox txtDeger = new TextBox();


                int klm = 0;
                foreach (GridViewRow satir in listehasta.Rows)
                {

                    edt = (ImageButton)satir.FindControl("edt");
                    adiSoyadi = (LinkButton)satir.FindControl("adiSoyadi");
                    calismaProtokolKodu = (Label)satir.FindControl("calismaProtokolKodu");
                    baslamaTarihi = (Label)satir.FindControl("baslamaTarihi");
                    bitisTarihi = (Label)satir.FindControl("bitisTarihi");
                    kayitTarihi = (Label)satir.FindControl("kayitTarihi");
                    deger = (Label)satir.FindControl("deger");
                    skls = (Label)satir.FindControl("skls");
                    hID = (Label)satir.FindControl("hID");


                    txtCalismaProtokolKodu = (TextBox)satir.FindControl("txtCalismaProtokolKodu");
                    txtBaslamaTarihi = (TextBox)satir.FindControl("txtBaslamaTarihi");
                    txtBitisTarihi = (TextBox)satir.FindControl("txtBitisTarihi");
                    txtKayitTarihi = (TextBox)satir.FindControl("txtKayitTarihi");
                    txtDeger = (TextBox)satir.FindControl("txtDeger");
                    edt.OnClientClick = "window.open('mp55thumbflry.aspx?id=" + gebelikdt0.Rows[klm]["SID"].ToString() + "','','location=0,status=0,scrollbars=1,width=350,height=400');return false;";

                    //edt.CommandArgument = gebelikdt0.Rows[klm]["SID"].ToString();
                    //edt.CommandName = a.ToString() + "," + klm.ToString();
                    skls.Text = gebelikdt0.Rows[klm]["siklus"].ToString();
                    adiSoyadi.Text = gebelikdt0.Rows[klm]["ad"].ToString();
                    adiSoyadi.OnClientClick = "createWindow('https://flry.ebebaba.com/ivfyonetici/hasta_modulu/th4820ft.aspx?ID=" + gebelikdt0.Rows[klm]["hID"].ToString() + "','" + gebelikdt0.Rows[klm]["ad"].ToString() + "','90%','530','');return false;";

                 //   adiSoyadi.CommandArgument = gebelikdt0.Rows[klm]["SID"].ToString();
                    calismaProtokolKodu.Text = gebelikdt0.Rows[klm]["protokol"].ToString();
                    baslamaTarihi.Text = gebelikdt0.Rows[klm]["bat"].ToString();
                    bitisTarihi.Text = gebelikdt0.Rows[klm]["bit"].ToString();
                    kayitTarihi.Text = gebelikdt0.Rows[klm]["kat"].ToString();
                    deger.Text = gebelikdt0.Rows[klm]["deger"].ToString();
                    hID.Text = gebelikdt0.Rows[klm]["hID"].ToString();


                    txtCalismaProtokolKodu.Text = gebelikdt0.Rows[klm]["protokol"].ToString();
                    txtBaslamaTarihi.Text = gebelikdt0.Rows[klm]["bat"].ToString();
                    txtBitisTarihi.Text = gebelikdt0.Rows[klm]["bit"].ToString();
                    txtKayitTarihi.Text = gebelikdt0.Rows[klm]["kat"].ToString();
                    txtDeger.Text = gebelikdt0.Rows[klm]["deger"].ToString();

                    //satir.Cells[0].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[1].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[2].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[3].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[4].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[5].BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.Cells[0].ForeColor = System.Drawing.Color.Black;





                    if (gebelikdt0.Rows[klm]["ge"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);

                    }

                    if (gebelikdt0.Rows[klm]["ge"].ToString() == "-")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);

                    }


                    if (gebelikdt0.Rows[klm]["biy"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);

                    }

                    if (gebelikdt0.Rows[klm]["ab"].ToString() == "+")
                    {

                        if (gebelikdt0.Rows[klm]["fkh"].ToString() == "+")
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);

                        }
                        else
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);

                        }

                    }

                    if (gebelikdt0.Rows[klm]["kry"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                    }

                    klm++;

                }









                ac = (ImageButton)str.FindControl("ac");
                kapat = (ImageButton)str.FindControl("kapat");
                if (toplamsiklussayisi < 1)
                {
                    ac.Visible = false;
                }
                else
                {
                    ac.Visible = true;
                }

                int k = a + 1;

                if (k < 10)
                {


                    ac.OnClientClick = "ctl00_ContentPlaceHolder1_list3_ctl01_detay3";



                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_detay3').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_detay3').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl0" + k + "_ac').style.display='';return false;";


                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }
                else
                {
                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_detay3').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_detay3').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list3_ctl" + k + "_ac').style.display='';return false;";



                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }




                label71 = (Label)str.FindControl("Label71");
                label71.Text = "S : " + toplamsiklussayisi.ToString();
                //+ " / H : " + toplamhastasayisih.ToString();

                if (toplamsiklussayisi == 0)
                {
                    str.Enabled = false;
                }


                DataRow[] gebeliksatiriO = mp_dt.Select("Ov='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] gebeliksatiri2O = mp_dt.Select("Ov='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");

                DataTable gebelikdtO = mp_dt.Copy();
                gebelikdtO.Clear();

                foreach (DataRow yeni in gebeliksatiriO)
                {
                    gebelikdtO.ImportRow(yeni);

                }

                DataTable gebelikdt5O = mp_dt.Copy();
                gebelikdt5O.Clear();

                foreach (DataRow yeni in gebeliksatiri2O)
                {
                    gebelikdt5O.ImportRow(yeni);

                }




                label69 = (Label)str.FindControl("Label69");
                label69.Text = " - ";


                label70 = (Label)str.FindControl("Label70");


                if (goruntu.SelectedIndex == 0)
                {


                    DataRow[] canlisatiri = mp_dt.Select("Do='+' and Co='-' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                    DataTable canlidt = mp_dt.Copy();
                    canlidt.Clear();

                    foreach (DataRow yeni in canlisatiri)
                    {
                        canlidt.ImportRow(yeni);

                    }

                    DataTable canlidt2 = canlidt.DefaultView.ToTable(true, new string[] { "ad" });
                    int canlih = canlidt2.Rows.Count;


                    label69.Text = canlih.ToString();

                    if (toplamsiklussayisi != 0)
                    {
                        double say1 = 100 * canlidt.Rows.Count / toplamsiklussayisi;
                        double say2 = 100 * canlih / toplamhastasayisih;


                        //label70.Text = virgulolayi(say2) + " %";
                    }
                    else
                    {

                        label70.Text = " 0 % ";


                    }
                }
                else
                {

                    label69.Text = " - ";


                    label70.Text = " - ";
                }



                //label40 = (Label)str.FindControl("Label40");
                ////label40.Text = hiperstimulasyonh.ToString();
                //label40.Text = totalfertilizesay.ToString() + " / " + fertilalt.ToString();


                //label41 = (Label)str.FindControl("Label41");

                //if (virgulolayi(hiperyuzdeh) == "NaN")
                //{
                //    label41.Text = "0 %";
                //}
                //else
                //{
                //    label41.Text = virgulolayi(hiperyuzdeh) + " %";
                //}












                for (int s = 0; s < list3.Items.Count; s++)
                {

                    if (((Label)list3.Items[s].FindControl("Label71")).Text == "S : 0")
                    {


                        list3.Items[s].CssClass = "gizle";

                        //.Attributes.Add("style", "display:none;");
                    }

                }
                a++;
            }


        }


    }
    protected void save_Command(object sender, CommandEventArgs e)
    {

        string[] satirlar = e.CommandName.ToString().Split(',');
        int a = int.Parse(satirlar[0]);
        int b = int.Parse(satirlar[1]);

        GridView yeni = new GridView();
        yeni = (GridView)list3.Items[a].FindControl("detay3");

        //((ImageButton)yeni.Rows[b].FindControl("save")).Visible = true;

        //((ImageButton)yeni.Rows[b].FindControl("edt")).Visible = false;


        DropDownList siklusDr = new DropDownList();
        siklusDr = (DropDownList)yeni.Rows[b].FindControl("sDr");

        DropDownList disDr = new DropDownList();
        disDr = (DropDownList)yeni.Rows[b].FindControl("dDr");

        MySqlConnection connect_word = mp_class.connect_flry(0301009184);
        if (disDr.SelectedIndex != 0)
        {

            MySqlDataAdapter da22 = new MySqlDataAdapter("Select * from atama where siklusID=" + e.CommandArgument + "", connect_word);
            DataTable dt22 = new DataTable();
            da22.Fill(dt22);

            if (dt22.Rows.Count == 1)
            {
                MySqlCommand mp_cmd = new MySqlCommand("Update atama set doktorID=?1 where siklusID=?2", connect_word);
                mp_cmd.Parameters.AddWithValue("?1", disDr.SelectedValue.ToString());
                mp_cmd.Parameters.AddWithValue("?2", e.CommandArgument.ToString());
                connect_word.Open();
                int eks2 = mp_cmd.ExecuteNonQuery();
                connect_word.Close();

            }
            else
            {

                MySqlCommand mp_cmd = new MySqlCommand("Insert into atama(hastaID,doktorID,siklusID) values (?1,?2,?3)", connect_word);
                mp_cmd.Parameters.AddWithValue("?1", ((Label)yeni.Rows[b].FindControl("hID")).Text);
                mp_cmd.Parameters.AddWithValue("?2", disDr.SelectedValue.ToString());
                mp_cmd.Parameters.AddWithValue("?3", e.CommandArgument.ToString());
                connect_word.Open();
                int eks2 = mp_cmd.ExecuteNonQuery();
                connect_word.Close();

            }
        }
        else
        {
            MySqlCommand mp_cmd = new MySqlCommand("Delete from atama where siklusID=?2", connect_word);

            mp_cmd.Parameters.AddWithValue("?2", e.CommandArgument.ToString());
            connect_word.Open();
            int eks2 = mp_cmd.ExecuteNonQuery();
            connect_word.Close();


        }



        if (siklusDr.SelectedIndex != 0)
        {

            MySqlCommand mp_cmd = new MySqlCommand("Update kisa_siklus set dr=?1,alan8=?2 where siklus_id=?4", connect_word);
            mp_cmd.Parameters.AddWithValue("?1", "Dr. " + siklusDr.SelectedValue.ToString());
            mp_cmd.Parameters.AddWithValue("?2", ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Text);
            mp_cmd.Parameters.AddWithValue("?4", e.CommandArgument.ToString());
            connect_word.Open();
            int eks5 = mp_cmd.ExecuteNonQuery();
            connect_word.Close();
        }
        else
        {
            MySqlCommand mp_cmd = new MySqlCommand("Update kisa_siklus set dr=?1,alan8=?2 where siklus_id=?4", connect_word);
            mp_cmd.Parameters.AddWithValue("?1", "");
            mp_cmd.Parameters.AddWithValue("?2", ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Text);
            mp_cmd.Parameters.AddWithValue("?4", e.CommandArgument.ToString());
            connect_word.Open();
            int eks5 = mp_cmd.ExecuteNonQuery();
            connect_word.Close();
        }


        MySqlCommand cmd = new MySqlCommand("Update labProtokol set txt78=?1,txt79=?2,txt80=?3,txt81=?4,deger=?6 where siklusID=?5", connect_word);

        cmd.Parameters.AddWithValue("?1", ((TextBox)yeni.Rows[b].FindControl("txtCalismaProtokolKodu")).Text);
        cmd.Parameters.AddWithValue("?2", ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Text);
        cmd.Parameters.AddWithValue("?3", ((TextBox)yeni.Rows[b].FindControl("txtBitisTarihi")).Text);
        cmd.Parameters.AddWithValue("?4", ((TextBox)yeni.Rows[b].FindControl("txtKayitTarihi")).Text);
        cmd.Parameters.AddWithValue("?6", ((TextBox)yeni.Rows[b].FindControl("txtDeger")).Text);
        cmd.Parameters.AddWithValue("?5", e.CommandArgument.ToString());

        connect_word.Open();
        int eks54 = cmd.ExecuteNonQuery();
        connect_word.Close();


        string logKayit = "";



        if (((Label)yeni.Rows[b].FindControl("lblDisDr")).Text != ((DropDownList)yeni.Rows[b].FindControl("dDr")).SelectedItem.Text)
        {
            logKayit = logKayit + "Dýþ Dr:" + ((DropDownList)yeni.Rows[b].FindControl("dDr")).SelectedItem.Text + " , ";
        }
        if (((Label)yeni.Rows[b].FindControl("lblSiklusDr")).Text != ((DropDownList)yeni.Rows[b].FindControl("sDr")).SelectedItem.Text)
        {
            logKayit = logKayit + "Siklus Dr:" + ((DropDownList)yeni.Rows[b].FindControl("sDr")).SelectedItem.Text + " , ";
        }
        if (((Label)yeni.Rows[b].FindControl("calismaProtokolKodu")).Text != ((TextBox)yeni.Rows[b].FindControl("txtCalismaProtokolKodu")).Text)
        {
            logKayit = logKayit + "Ç.Protol Kodu:" + ((TextBox)yeni.Rows[b].FindControl("txtCalismaProtokolKodu")).Text + " , ";
        }
        if (((Label)yeni.Rows[b].FindControl("baslamaTarihi")).Text != ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Text)
        {
            logKayit = logKayit + "Baþ. Tarihi:" + ((TextBox)yeni.Rows[b].FindControl("txtBaslamaTarihi")).Text + " , ";
        }
        if (((Label)yeni.Rows[b].FindControl("bitisTarihi")).Text != ((TextBox)yeni.Rows[b].FindControl("txtBitisTarihi")).Text)
        {
            logKayit = logKayit + "Bit. Tarihi:" + ((TextBox)yeni.Rows[b].FindControl("txtBitisTarihi")).Text + " , ";
        }
        if (((Label)yeni.Rows[b].FindControl("kayitTarihi")).Text != ((TextBox)yeni.Rows[b].FindControl("txtKayitTarihi")).Text)
        {
            logKayit = logKayit + "Kayýt Tarihi:" + ((TextBox)yeni.Rows[b].FindControl("txtKayitTarihi")).Text + " , ";
        }
        if (((Label)yeni.Rows[b].FindControl("deger")).Text != ((TextBox)yeni.Rows[b].FindControl("txtDeger")).Text)
        {
            logKayit = logKayit + "Deðer:" + ((TextBox)yeni.Rows[b].FindControl("txtDeger")).Text + " , ";
        }

        if (logKayit == "")
        {
            logKayit = ((LinkButton)yeni.Rows[b].FindControl("adiSoyadi")).Text + " (" + ((Label)yeni.Rows[b].FindControl("skls")).Text + " Siklusu) " + " --> Deðiþiklik yapmadan olduðu gibi güncellendi. (Lokasyon: Çalýþma Takibi)";
        }
        else
        {
            int son = logKayit.LastIndexOf(',');
            string bol = logKayit.Substring(0, son);
            logKayit = ((LinkButton)yeni.Rows[b].FindControl("adiSoyadi")).Text + " (" + ((Label)yeni.Rows[b].FindControl("skls")).Text + " Siklusu) " + " --> " + bol + " olarak deðiþtirildi. (Lokasyon: Çalýþma Takibi)";

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



        Panel1.Visible = true;
        list3.Visible = true;
        DateTime baslangictarihi = DateTime.Parse("01." + baslangicay.SelectedValue.ToString() + "." + baslangicyil.SelectedValue.ToString());
        DateTime bitistarihi = DateTime.Parse("01." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString());

        if (baslangictarihi > bitistarihi)
        {

            Label42.Text = "Baþlangýç tarihi bitiþ tarihinden büyük olamaz !";

        }

        else
        {

            siklusyukle31();


        }






    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        list3.Visible = false;
        list.Visible = true;
        DateTime baslangictarihi = DateTime.Parse("01." + baslangicay.SelectedValue.ToString() + "." + baslangicyil.SelectedValue.ToString());
        DateTime bitistarihi = DateTime.Parse("01." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString());

        if (baslangictarihi > bitistarihi)
        {

            Label42.Text = "Baþlangýç tarihi bitiþ tarihinden büyük olamaz !";

        }

        else if (suzgec.SelectedIndex == -1)
        {
            Label42.Text = "Süzgeç tipi seçilmedi !";
        }
        else
        {
            siklusyukle2();
        }
        //hastayukle();




        Label28.Text = txtkurum.SelectedItem.ToString();
        Label29.Text = txttedavituru.SelectedItem.ToString();
        Label30.Text = txttedaviprotokolu.SelectedItem.ToString();
        Label31.Text = baslangicay.SelectedItem.ToString() + " " + baslangicyil.SelectedItem.ToString();
        Label32.Text = bitisay.SelectedItem.ToString() + " " + bitisyil.SelectedItem.ToString();
        Label76.Text = drp_dis.SelectedItem.Text;

        Label34.Text = drp_dr.SelectedItem.Text;
        Label44.Text = suzgec.SelectedValue.ToString();
        string krt = "0000070.aspx|" + txtkurum.SelectedIndex + "|" + txttedavituru.SelectedIndex + "|" + txttedaviprotokolu.SelectedIndex + "|" + baslangicay.SelectedIndex + "|" + baslangicyil.SelectedIndex + "|" + bitisay.SelectedIndex + "|" + bitisyil.SelectedIndex + "|" + goruntu.SelectedIndex + "|" + drp_dr.SelectedIndex + "|" + suzgec.SelectedIndex + "|opu";

        Session.Add("opukriterler", krt);


        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();


        string islem = "Gebelik - siklus sorgulama iþlemi";
        mp_class.log_kaydet(kullaniciAdiAdmin, islem);


        //bilgiyukle();


        //}
        //catch
        //{
        //    panel_sonuc.Visible = true;
        //    sonuc.Text = "Sorgulama Esnasýnda Bir Hata Oluþtu Ýþlem Baþarýsýz !";

        //}


    }


    void siklusyukle2()
    {
        DateTime baslangictarihi = DateTime.Parse("01." + baslangicay.SelectedValue.ToString() + "." + baslangicyil.SelectedValue.ToString());
        DateTime bitistarihi = DateTime.Parse("01." + bitisay.SelectedValue.ToString() + "." + bitisyil.SelectedValue.ToString());

        string sql = String.Empty;

        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex != 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad ,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay , K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh   from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex == 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus , SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay,  K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi, K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh      from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex == 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus , SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay,K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh      from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.kurum_id='" + txtkurum.SelectedValue.ToString() + "'  and K.istatistik is null order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex != 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus , SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay,K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh      from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null  order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex == 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus , SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay,K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh      from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.istatistik is null order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex == 0 && txttedaviprotokolu.SelectedIndex != 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus , SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) as ay,K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh      from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.istatistik is null  order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex != 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex == 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus , SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) ay,K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh      from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.kurum_id='" + txtkurum.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null  order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (txtkurum.SelectedIndex == 0 && txttedavituru.SelectedIndex != 0 && txttedaviprotokolu.SelectedIndex != 0)
            sql = " Select S.siklus_id,concat(U.uye_adi,' ',U.uye_soyadi) as ad,(year(str_to_date(S.siklus_eklenme_tarihi ,'%d.%m.%Y')) - year(str_to_date(U.uye_dogum_tarihi ,'%d.%m.%Y')))  as yas , concat(S.siklus_ay,' ',S.siklus_yil) as Siklus ,SUBSTRING(K.alan3,7,4) as yil,SUBSTRING(K.alan3,4,2) ay, K.Sat as SAT , K.tani1 as T1,K.tani2 as T2,K.tani3 as T3,K.tani4 as T4, K.tedavi_protokolu, K.gebelik as Ge,K.ovulasyon as Ov,K.abortus as Ab,K.cogul as Co,K.dogum as Do,K.hiperstimulasyon as Hi , K.biyokimyasal as Biy,K.alan3 as OPU , K.alan4 as ET ,S.siklus_id as SID,K.kriyoyapildimi as kry,K.dr as sDr,K.fkh as fkh     from siklus_ana_tab S,kisa_siklus K,uye_hasta U where U.uye_id = CAST(S.hasta_id as UNSIGNED) and K.siklus_id=S.siklus_id and K.tedavi_protokolu='" + txttedaviprotokolu.SelectedValue.ToString() + "' and K.tedavi_turu_id='" + txttedavituru.SelectedValue.ToString() + "' and K.istatistik is null  order by str_to_date(K.alan3 ,'%d.%m.%Y %H:%i:%s') asc,str_to_date(K.SAT ,'%d.%m.%Y') asc";

        if (drp_dr.SelectedIndex != 0)
        {

            int sncm = sql.IndexOf("order");
            sql = sql.Insert(sncm, " and K.dr='" + drp_dr.SelectedValue.ToString() + "' ");

        }
     

        if (drp_dis.SelectedIndex != 0)
        {

          

            if(kategori.SelectedValue == "")
            {
              int sncm = sql.IndexOf("where");
            sql = sql.Insert(sncm, ",atama A ");

            int sncm2 = sql.IndexOf("U.uye_id");
            sql = sql.Insert(sncm2, " A.siklusID=K.siklus_id and A.doktorID= '" + drp_dis.SelectedValue.ToString() + "' and ");

            
            }
            else
            {

                int sncm = sql.IndexOf("where");
                sql = sql.Insert(sncm, ",atama A,uye_doktor D ");

                int sncm2 = sql.IndexOf("U.uye_id");
                sql = sql.Insert(sncm2, " A.siklusID=K.siklus_id and A.doktorID=D.uye_id and D.kategori='"+kategori.SelectedValue+"' and A.doktorID= '" + drp_dis.SelectedValue.ToString() + "' and ");

            
            }



        }
        else if (drp_dis.SelectedIndex == 0)
        {



            if (kategori.SelectedValue != "")
             {

                int sncm = sql.IndexOf("where");
                sql = sql.Insert(sncm, ",atama A,uye_doktor D ");

                int sncm2 = sql.IndexOf("U.uye_id");
                sql = sql.Insert(sncm2, " A.siklusID=K.siklus_id and A.doktorID=D.uye_id and D.kategori='" + kategori.SelectedValue + "' and ");


            }



        }


        MySqlConnection mp_connection = mp_class.connect_flry(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter(sql, mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        string goruntulemesekli = string.Empty;

        if (goruntu.SelectedValue == "+")
        {
            goruntulemesekli = "-";
        }
        else
        {
            goruntulemesekli = "+";
        }


        DataTable dttarih = new DataTable();
        DataColumn dc = new DataColumn("ay");
        DataColumn dc2 = new DataColumn("yil");

        dttarih.Columns.Add(dc);
        dttarih.Columns.Add(dc2);



        Label42.Text = "";

        if (suzgec.SelectedIndex == 0)
        {

            while (baslangictarihi <= bitistarihi)
            {

                DataRow dr = dttarih.NewRow();

                if (baslangictarihi.Month < 10)
                {
                    dr[0] = "0" + baslangictarihi.Month.ToString();
                }
                else
                {
                    dr[0] = baslangictarihi.Month.ToString();
                }


                dr[1] = baslangictarihi.Year.ToString();
                dttarih.Rows.Add(dr);

                baslangictarihi = baslangictarihi.AddMonths(1);


            }


        }
        else if (suzgec.SelectedIndex == 1)
        {

            while (baslangictarihi.Year <= bitistarihi.Year)
            {

                DataRow dr = dttarih.NewRow();

                dr[1] = baslangictarihi.Year.ToString();
                dttarih.Rows.Add(dr);

                baslangictarihi = baslangictarihi.AddYears(1);


            }

        }



        list.DataSource = dttarih;
        list.DataBind();


        Label label1 = new Label();

        Label label9 = new Label();
        Label label10 = new Label();
        Label label43 = new Label();


        Label label13 = new Label();

        Label label14 = new Label();

        Label label40 = new Label();
        Label label41 = new Label();

        Label label17 = new Label();
        Label label18 = new Label();

        Label label21 = new Label();
        Label label22 = new Label();

        Label label25 = new Label();
        Label label26 = new Label();

        Label label36 = new Label();
        Label label37 = new Label();

        Label label44 = new Label();
        Label label45 = new Label();

        Label label46 = new Label();
        Label label47 = new Label();




        GridView listehasta = new GridView();
        ImageButton ac = new ImageButton();
        ImageButton kapat = new ImageButton();


        if (suzgec.SelectedIndex == 0)
        {

            int a = 0;

            double opum = 0, opumh = 0, opumyuzde = 0, etm = 0, etmh = 0, etmyuzde = 0, biyokimyasalh = 0, canlih = 0, gebelikh = 0, ovulasyonh = 0, abortush = 0, cgebelikh = 0, dogumh = 0, hiperstimulasyonh = 0;
            double biyokimyasalh2 = 0, gebelikh2 = 0, ovulasyonh2 = 0, abortush2 = 0, cgebelikh2 = 0, dogumh2 = 0, hiperstimulasyonh2 = 0;
            double biyoyuzde = 0, canliyuzde = 0, gebeyuzde = 0, ovuyuzde = 0, aboyuzde = 0, cgebeyuzde = 0, dogmyuzde = 0, hiperyuzde = 0;
            double biyoyuzdeh = 0, canliyuzdeh = 0, gebeyuzdeh = 0, ovuyuzdeh = 0, aboyuzdeh = 0, cgebeyuzdeh = 0, dogmyuzdeh = 0, hiperyuzdeh = 0;
            double toplamsiklussayisi = 0;
            double biyokimyasal = 0, gebelik = 0, canli = 0, ovulasyon = 0, abortus = 0, cgebelik = 0, dogum = 0, hiperstimulasyon = 0;
            double biyokimyasal2 = 0, gebelik2 = 0, ovulasyon2 = 0, abortus2 = 0, cgebelik2 = 0, dogum2 = 0, hiperstimulasyon2 = 0;
            int toplamhastasayisih = 0;

            foreach (DataListItem str in list.Items)
            {

                label1 = (Label)str.FindControl("Label1");
                label1.Text = mp_class.ayadi(int.Parse(dttarih.Rows[a][0].ToString())) + " - " + dttarih.Rows[a][1].ToString();


                DataRow[] gebeliksatiri4 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                DataRow[] gebeliksatiri0 = mp_dt.Select("OPU<>'' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] gebeliksatiri10 = mp_dt.Select("ET<>'' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");



                DataRow[] gebeliksatiri = mp_dt.Select("Ge='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] gebeliksatiri2 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] gebeliksatiri3 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                DataTable gebelikdt0 = mp_dt.Copy();
                gebelikdt0.Clear();

                foreach (DataRow yeni in gebeliksatiri0)
                {
                    gebelikdt0.ImportRow(yeni);

                }

                DataTable gebelikdt10 = mp_dt.Copy();
                gebelikdt10.Clear();

                foreach (DataRow yeni in gebeliksatiri10)
                {
                    gebelikdt10.ImportRow(yeni);

                }

                DataTable gebelikdt4 = mp_dt.Copy();
                gebelikdt4.Clear();

                foreach (DataRow yeni in gebeliksatiri4)
                {
                    gebelikdt4.ImportRow(yeni);

                }

                DataTable gebelikdt = mp_dt.Copy();
                gebelikdt.Clear();

                foreach (DataRow yeni in gebeliksatiri)
                {
                    gebelikdt.ImportRow(yeni);

                }

                DataTable gebelikdt5 = mp_dt.Copy();
                gebelikdt5.Clear();

                foreach (DataRow yeni in gebeliksatiri2)
                {
                    gebelikdt5.ImportRow(yeni);

                }

                DataTable gebelikdt2 = gebelikdt.DefaultView.ToTable(true, new string[] { "ad" });
                gebelikh = gebelikdt2.Rows.Count;



                DataTable gebelikdt6 = gebelikdt5.DefaultView.ToTable(true, new string[] { "ad" });
                gebelikh2 = gebelikdt6.Rows.Count;


                gebelik = gebeliksatiri.Length;
                gebelik2 = gebeliksatiri2.Length;
                gebeyuzde = 100 * gebelik / (gebelik + gebelik2);
                gebeyuzdeh = 100 * gebelikh / (gebelikh + gebelikh2);

                label44 = (Label)str.FindControl("Label44");
                label45 = (Label)str.FindControl("Label45");

                DataTable gebelikdt7 = gebelikdt0.DefaultView.ToTable(true, new string[] { "ad" });
                opumh = gebelikdt7.Rows.Count;

                //label44.Text = opumh.ToString();

                DataTable gebelikdt8 = gebelikdt10.DefaultView.ToTable(true, new string[] { "ad" });
                etmh = gebelikdt8.Rows.Count;

                //label45.Text = etmh.ToString();


                DataTable sayidt = mp_dt.Copy();
                sayidt.Clear();

                foreach (DataRow yeni in gebeliksatiri3)
                {
                    sayidt.ImportRow(yeni);
                }

                DataTable sayidtson = sayidt.DefaultView.ToTable(true, new string[] { "ad" });

                toplamhastasayisih = sayidtson.Rows.Count;


                toplamsiklussayisi = sayidt.Rows.Count;

                //label10 = (Label)str.FindControl("Label10");
                //label10.Text = gebelikh.ToString();

                opumyuzde = 100 * opumh / toplamsiklussayisi;
                etmyuzde = 100 * etmh / toplamsiklussayisi;

                //label46 = (Label)str.FindControl("Label46");
                //label47 = (Label)str.FindControl("Label47");



                //if (virgulolayi(opumyuzde) == "NaN")
                //{
                //    label46.Text = "0 %";
                //}
                //else
                //{
                //    label46.Text = virgulolayi(opumyuzde) + " %";
                //}

                //if (virgulolayi(etmyuzde) == "NaN")
                //{
                //    label47.Text = "0 %";
                //}
                //else
                //{
                //    label47.Text = virgulolayi(etmyuzde) + " %";
                //}


                listehasta = (GridView)str.FindControl("detay2");
                listehasta.DataSource = gebelikdt4;
                listehasta.DataBind();




                ImageButton edt = new ImageButton();
                LinkButton lbAd = new LinkButton();

                int klm = 0;

                foreach (GridViewRow satir in listehasta.Rows)
                {
                    edt = (ImageButton)satir.FindControl("edt");
                    lbAd = (LinkButton)satir.FindControl("lbAd");
                    lbAd.Text = gebelikdt4.Rows[klm]["ad"].ToString();
                    //edt.CommandArgument = gebelikdt4.Rows[klm]["SID"].ToString();
                    edt.OnClientClick = "window.open('mp55thumbflry.aspx?id=" + gebelikdt4.Rows[klm]["SID"].ToString() + "','','location=0,status=0,scrollbars=1,width=350,height=400');return false;";
                    lbAd.CommandArgument = gebelikdt4.Rows[klm]["SID"].ToString();
                    //satir.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.ForeColor = System.Drawing.Color.Black;




                    MySqlDataAdapter da22 = new MySqlDataAdapter("Select doktorID from atama where siklusID=" + gebelikdt4.Rows[klm]["SID"].ToString() + "", mp_connection);
                    DataTable dt22 = new DataTable();
                    da22.Fill(dt22);

                    if (dt22.Rows.Count != 0)
                    {

                        if (drp_dr2.Items.FindByValue(dt22.Rows[0][0].ToString()) != null)
                        {
                            satir.Cells[6].Text = drp_dr2.Items.FindByValue(dt22.Rows[0][0].ToString()).Text;
                        }




                    }




                    if (gebelikdt4.Rows[klm]["ge"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);

                    }

                    if (gebelikdt4.Rows[klm]["ge"].ToString() == "-")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);

                    }


                    if (gebelikdt4.Rows[klm]["biy"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);

                    }

                    if (gebelikdt4.Rows[klm]["ab"].ToString() == "+")
                    {

                        if (gebelikdt4.Rows[klm]["fkh"].ToString() == "+")
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);

                        }
                        else
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);

                        }

                    }

                    if (gebelikdt4.Rows[klm]["kry"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                    }

                    klm++;
                }









                ac = (ImageButton)str.FindControl("ac");
                kapat = (ImageButton)str.FindControl("kapat");
                if (toplamsiklussayisi < 1)
                {
                    ac.Visible = false;
                }
                else
                {
                    ac.Visible = true;
                }

                int k = a + 1;

                if (k < 10)
                {


                    ac.OnClientClick = "ctl00_ContentPlaceHolder1_list_ctl01_detay2";



                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_detay2').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_detay2').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_ac').style.display='';return false;";


                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }
                else
                {
                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_detay2').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_detay2').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_ac').style.display='';return false;";



                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }





                //listehasta.DataSource = gebelikdt;
                //listehasta.DataBind();

                //label9 = (Label)str.FindControl("Label9");

                //if (virgulolayi(gebeyuzdeh) == "NaN")
                //{
                //    label9.Text = "0 %";
                //}
                //else
                //{
                //    label9.Text = virgulolayi(gebeyuzdeh) + " %";
                //}

                label43 = (Label)str.FindControl("Label43");
                label43.Text = "S : " + toplamsiklussayisi.ToString();
                //+ " / H : " + toplamhastasayisih.ToString();






                DataRow[] gebeliksatiriO = mp_dt.Select("Ov='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] gebeliksatiri2O = mp_dt.Select("Ov='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");

                DataTable gebelikdtO = mp_dt.Copy();
                gebelikdtO.Clear();

                foreach (DataRow yeni in gebeliksatiriO)
                {
                    gebelikdtO.ImportRow(yeni);

                }

                DataTable gebelikdt5O = mp_dt.Copy();
                gebelikdt5O.Clear();

                foreach (DataRow yeni in gebeliksatiri2O)
                {
                    gebelikdt5O.ImportRow(yeni);

                }

                DataTable gebelikdt2O = gebelikdtO.DefaultView.ToTable(true, new string[] { "ad" });
                ovulasyonh = gebelikdt2O.Rows.Count;

                DataTable gebelikdt6O = gebelikdt5O.DefaultView.ToTable(true, new string[] { "ad" });
                ovulasyonh2 = gebelikdt6O.Rows.Count;


                ovulasyon = gebeliksatiriO.Length;
                ovulasyon2 = gebeliksatiri2O.Length;
                ovuyuzde = 100 * ovulasyon / (ovulasyon + ovulasyon2);
                ovuyuzdeh = 100 * ovulasyonh / (ovulasyonh + ovulasyonh2);




                label14 = (Label)str.FindControl("Label14");
                label14.Text = " - ";


                label13 = (Label)str.FindControl("Label13");


                if (goruntu.SelectedIndex == 0)
                {


                    DataRow[] canlisatiri = mp_dt.Select("Do='+' and Co='-' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                    DataTable canlidt = mp_dt.Copy();
                    canlidt.Clear();

                    foreach (DataRow yeni in canlisatiri)
                    {
                        canlidt.ImportRow(yeni);

                    }

                    DataTable canlidt2 = canlidt.DefaultView.ToTable(true, new string[] { "ad" });
                    canlih = canlidt2.Rows.Count;


                    label14.Text = canlih.ToString();

                    if (toplamsiklussayisi != 0)
                    {
                        double say1 = 100 * canlidt.Rows.Count / toplamsiklussayisi;
                        double say2 = 100 * canlih / toplamhastasayisih;


                        label13.Text = virgulolayi(say2) + " %";
                    }
                    else
                    {

                        label13.Text = " 0 % ";


                    }
                }
                else
                {

                    label14.Text = " - ";


                    label13.Text = " - ";
                }




                DataRow[] hiperstimulasyonsatiri = mp_dt.Select("Hi='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] hiperstimulasyonsatiri2 = mp_dt.Select("Hi='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                DataTable hiperstimulasyondt = mp_dt.Copy();
                hiperstimulasyondt.Clear();

                foreach (DataRow yeni in hiperstimulasyonsatiri)
                {
                    hiperstimulasyondt.ImportRow(yeni);
                }


                DataTable hiperstimulasyondt5 = mp_dt.Copy();
                hiperstimulasyondt5.Clear();

                foreach (DataRow yeni in hiperstimulasyonsatiri2)
                {
                    hiperstimulasyondt5.ImportRow(yeni);
                }


                DataTable hiperstimulasyondt2 = hiperstimulasyondt.DefaultView.ToTable(true, new string[] { "ad" });
                hiperstimulasyonh = hiperstimulasyondt2.Rows.Count;
                DataTable hiperstimulasyondt6 = hiperstimulasyondt5.DefaultView.ToTable(true, new string[] { "ad" });
                hiperstimulasyonh2 = hiperstimulasyondt6.Rows.Count;

                hiperstimulasyon = hiperstimulasyonsatiri.Length;
                hiperstimulasyon2 = hiperstimulasyonsatiri2.Length;
                hiperyuzde = 100 * hiperstimulasyon / (hiperstimulasyon + hiperstimulasyon2);
                hiperyuzdeh = 100 * hiperstimulasyonh / (hiperstimulasyonh + hiperstimulasyonh2);

                //label40 = (Label)str.FindControl("Label40");
                //label40.Text = hiperstimulasyonh.ToString();

                //label41 = (Label)str.FindControl("Label41");

                //if (virgulolayi(hiperyuzdeh) == "NaN")
                //{
                //    label41.Text = "0 %";
                //}
                //else
                //{
                //    label41.Text = virgulolayi(hiperyuzdeh) + " %";
                //}



                DataRow[] biyosatiri = mp_dt.Select("Biy='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] biyosatiri2 = mp_dt.Select("Biy='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                DataTable biydt = mp_dt.Copy();
                biydt.Clear();

                foreach (DataRow yeni in biyosatiri)
                {
                    biydt.ImportRow(yeni);
                }

                DataTable biydt5 = mp_dt.Copy();
                biydt5.Clear();

                foreach (DataRow yeni in biyosatiri2)
                {
                    biydt5.ImportRow(yeni);
                }

                DataTable biydt2 = biydt.DefaultView.ToTable(true, new string[] { "ad" });
                biyokimyasalh = biydt2.Rows.Count;

                DataTable biydt6 = biydt5.DefaultView.ToTable(true, new string[] { "ad" });
                biyokimyasalh2 = biydt6.Rows.Count;

                biyokimyasal = biyosatiri.Length;
                biyokimyasal2 = biyosatiri2.Length;
                biyoyuzde = 100 * biyokimyasal / gebelik;
                biyoyuzdeh = 100 * biyokimyasalh / gebelikh;


                //label18 = (Label)str.FindControl("Label18");
                //label18.Text = biyokimyasalh.ToString();



                //label17 = (Label)str.FindControl("Label17");

                //if (virgulolayi(biyoyuzdeh) == "NaN")
                //{
                //    label17.Text = "0 %";
                //}
                //else
                //{
                //    label17.Text = virgulolayi(biyoyuzdeh) + " %";
                //}



                DataRow[] abortussatiri = mp_dt.Select("Ab='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] abortussatiri2 = mp_dt.Select("Ab='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                DataTable abortusdt = mp_dt.Copy();
                abortusdt.Clear();

                foreach (DataRow yeni in abortussatiri)
                {
                    abortusdt.ImportRow(yeni);
                }


                DataTable abortusdt5 = mp_dt.Copy();
                abortusdt5.Clear();

                foreach (DataRow yeni in abortussatiri2)
                {
                    abortusdt5.ImportRow(yeni);
                }

                DataTable abortusdt2 = abortusdt.DefaultView.ToTable(true, new string[] { "ad" });
                abortush = abortusdt2.Rows.Count;

                DataTable abortusdt6 = abortusdt5.DefaultView.ToTable(true, new string[] { "ad" });
                abortush2 = abortusdt6.Rows.Count;



                abortus = abortussatiri.Length;
                abortus2 = abortussatiri2.Length;
                aboyuzde = 100 * abortus / gebelik;
                aboyuzdeh = 100 * abortush / gebelikh;



                //label22 = (Label)str.FindControl("Label22");
                //label22.Text = abortush.ToString();


                //label21 = (Label)str.FindControl("Label21");

                //if (virgulolayi(aboyuzdeh) == "NaN")
                //{
                //    label21.Text = "0 %";
                //}
                //else
                //{
                //    label21.Text = virgulolayi(aboyuzdeh) + " %";
                //}





                DataRow[] dogumsatiri = mp_dt.Select("Do='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] dogumsatiri2 = mp_dt.Select("Do='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");

                DataTable dogumdt = mp_dt.Copy();
                dogumdt.Clear();

                foreach (DataRow yeni in dogumsatiri)
                {
                    dogumdt.ImportRow(yeni);
                }

                DataTable dogumdt5 = mp_dt.Copy();
                dogumdt5.Clear();

                foreach (DataRow yeni in dogumsatiri2)
                {
                    dogumdt5.ImportRow(yeni);
                }


                DataTable dogumdt2 = dogumdt.DefaultView.ToTable(true, new string[] { "ad" });
                dogumh = dogumdt2.Rows.Count;

                DataTable dogumdt6 = dogumdt5.DefaultView.ToTable(true, new string[] { "ad" });
                dogumh2 = dogumdt6.Rows.Count;





                dogum = dogumsatiri.Length;
                dogum2 = dogumsatiri2.Length;
                dogmyuzde = 100 * dogum / gebelik;
                dogmyuzdeh = 100 * dogumh / gebelikh;



                //label26 = (Label)str.FindControl("Label26");
                //label26.Text = dogumh.ToString();



                //label25 = (Label)str.FindControl("Label25");

                //if (virgulolayi(dogmyuzdeh) == "NaN")
                //{
                //    label25.Text = "0 %";
                //}
                //else
                //{
                //    label25.Text = virgulolayi(dogmyuzdeh) + " %";
                //}







                DataRow[] cogulgebeliksatiri = mp_dt.Select("Co='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");
                DataRow[] cogulgebeliksatiri2 = mp_dt.Select("Co='" + goruntulemesekli + "'and yil='" + dttarih.Rows[a][1].ToString() + "' and ay = '" + dttarih.Rows[a][0].ToString() + "'");


                DataTable cogulgebelikdt = mp_dt.Copy();
                cogulgebelikdt.Clear();

                foreach (DataRow yeni in cogulgebeliksatiri)
                {
                    cogulgebelikdt.ImportRow(yeni);
                }

                DataTable cogulgebelikdt5 = mp_dt.Copy();
                cogulgebelikdt5.Clear();

                foreach (DataRow yeni in cogulgebeliksatiri2)
                {
                    cogulgebelikdt5.ImportRow(yeni);
                }


                DataTable coguldt2 = cogulgebelikdt.DefaultView.ToTable(true, new string[] { "ad" });
                cgebelikh = coguldt2.Rows.Count;

                DataTable coguldt6 = cogulgebelikdt5.DefaultView.ToTable(true, new string[] { "ad" });
                cgebelikh2 = coguldt6.Rows.Count;




                cgebelik = cogulgebeliksatiri.Length;
                cgebelik2 = cogulgebeliksatiri2.Length;
                cgebeyuzde = 100 * cgebelik / gebelik;
                cgebeyuzdeh = 100 * cgebelikh / gebelikh;




                //label37 = (Label)str.FindControl("Label37");
                //label37.Text = cgebelikh.ToString();



                //label36 = (Label)str.FindControl("Label36");

                //if (virgulolayi(cgebeyuzdeh) == "NaN")
                //{
                //    label36.Text = "0 %";
                //}
                //else
                //{
                //    label36.Text = virgulolayi(cgebeyuzdeh) + " %";
                //}


                //Label Label3 = new Label();
                //Label3 = (Label)str.FindControl("Label3");
                //double devam = gebelikh - biyokimyasalh - abortush;
                //Label3.Text = devam.ToString();

                //Label Label4 = new Label();
                //Label4 = (Label)str.FindControl("Label4");
                //double devamYuzde = 100 * devam / toplamsiklussayisi;

                //if (virgulolayi(devamYuzde) == "NaN")
                //{
                //    Label4.Text = "0 %";
                //}
                //else
                //{
                //    Label4.Text = virgulolayi(devamYuzde) + " %";
                //}








                a++;

            }




        }


        else
        {
            int a = 0;

            double opum = 0, opumh = 0, opumyuzde = 0, etm = 0, etmh = 0, etmyuzde = 0, biyokimyasalh = 0, canlih = 0, gebelikh = 0, ovulasyonh = 0, abortush = 0, cgebelikh = 0, dogumh = 0, hiperstimulasyonh = 0;
            double biyokimyasalh2 = 0, gebelikh2 = 0, ovulasyonh2 = 0, abortush2 = 0, cgebelikh2 = 0, dogumh2 = 0, hiperstimulasyonh2 = 0;
            double biyoyuzde = 0, canliyuzde = 0, gebeyuzde = 0, ovuyuzde = 0, aboyuzde = 0, cgebeyuzde = 0, dogmyuzde = 0, hiperyuzde = 0;
            double biyoyuzdeh = 0, canliyuzdeh = 0, gebeyuzdeh = 0, ovuyuzdeh = 0, aboyuzdeh = 0, cgebeyuzdeh = 0, dogmyuzdeh = 0, hiperyuzdeh = 0;
            double toplamsiklussayisi = 0;
            double biyokimyasal = 0, gebelik = 0, canli = 0, ovulasyon = 0, abortus = 0, cgebelik = 0, dogum = 0, hiperstimulasyon = 0;
            double biyokimyasal2 = 0, gebelik2 = 0, ovulasyon2 = 0, abortus2 = 0, cgebelik2 = 0, dogum2 = 0, hiperstimulasyon2 = 0;
            int toplamhastasayisih = 0;

            foreach (DataListItem str in list.Items)
            {

                label1 = (Label)str.FindControl("Label1");
                label1.Text = dttarih.Rows[a][1].ToString();


                DataRow[] gebeliksatiri4 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "'");


                DataRow[] gebeliksatiri0 = mp_dt.Select("OPU<>'' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] gebeliksatiri10 = mp_dt.Select("ET<>'' and yil='" + dttarih.Rows[a][1].ToString() + "'");



                DataRow[] gebeliksatiri = mp_dt.Select("Ge='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] gebeliksatiri2 = mp_dt.Select("Ge='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] gebeliksatiri3 = mp_dt.Select("yil='" + dttarih.Rows[a][1].ToString() + "'");

                DataTable gebelikdt = mp_dt.Copy();
                gebelikdt.Clear();


                DataTable gebelikdt0 = mp_dt.Copy();
                gebelikdt0.Clear();

                foreach (DataRow yeni in gebeliksatiri0)
                {
                    gebelikdt0.ImportRow(yeni);

                }

                DataTable gebelikdt10 = mp_dt.Copy();
                gebelikdt10.Clear();

                foreach (DataRow yeni in gebeliksatiri10)
                {
                    gebelikdt10.ImportRow(yeni);

                }

                DataTable gebelikdt4 = mp_dt.Copy();
                gebelikdt4.Clear();

                foreach (DataRow yeni in gebeliksatiri4)
                {
                    gebelikdt4.ImportRow(yeni);

                }


                foreach (DataRow yeni in gebeliksatiri)
                {
                    gebelikdt.ImportRow(yeni);

                }

                DataTable gebelikdt5 = mp_dt.Copy();
                gebelikdt5.Clear();

                foreach (DataRow yeni in gebeliksatiri2)
                {
                    gebelikdt5.ImportRow(yeni);

                }

                DataTable gebelikdt2 = gebelikdt.DefaultView.ToTable(true, new string[] { "ad" });
                gebelikh = gebelikdt2.Rows.Count;

                DataTable gebelikdt6 = gebelikdt5.DefaultView.ToTable(true, new string[] { "ad" });
                gebelikh2 = gebelikdt6.Rows.Count;

                label44 = (Label)str.FindControl("Label44");
                label45 = (Label)str.FindControl("Label45");

                DataTable gebelikdt7 = gebelikdt0.DefaultView.ToTable(true, new string[] { "ad" });
                opumh = gebelikdt7.Rows.Count;

                //label44.Text = opumh.ToString();

                DataTable gebelikdt8 = gebelikdt10.DefaultView.ToTable(true, new string[] { "ad" });
                etmh = gebelikdt8.Rows.Count;

                //label45.Text = etmh.ToString();

                gebelik = gebeliksatiri.Length;
                gebelik2 = gebeliksatiri2.Length;
                gebeyuzde = 100 * gebelik / (gebelik + gebelik2);
                gebeyuzdeh = 100 * gebelikh / (gebelikh + gebelikh2);


                DataTable sayidt = mp_dt.Copy();
                sayidt.Clear();

                foreach (DataRow yeni in gebeliksatiri3)
                {
                    sayidt.ImportRow(yeni);
                }

                DataTable sayidtson = sayidt.DefaultView.ToTable(true, new string[] { "ad" });

                toplamhastasayisih = sayidtson.Rows.Count;


                toplamsiklussayisi = sayidt.Rows.Count;

                //label10 = (Label)str.FindControl("Label10");
                //label10.Text = gebelikh.ToString();

                //opumyuzde = 100 * opumh / toplamsiklussayisi;
                //etmyuzde = 100 * etmh / toplamsiklussayisi;

                //label46 = (Label)str.FindControl("Label46");
                //label47 = (Label)str.FindControl("Label47");



                //if (virgulolayi(opumyuzde) == "NaN")
                //{
                //    label46.Text = "0 %";
                //}
                //else
                //{
                //    label46.Text = virgulolayi(opumyuzde) + " %";
                //}

                //if (virgulolayi(etmyuzde) == "NaN")
                //{
                //    label47.Text = "0 %";
                //}
                //else
                //{
                //    label47.Text = virgulolayi(etmyuzde) + " %";
                //}




                listehasta = (GridView)str.FindControl("detay2");
                listehasta.DataSource = gebelikdt4;
                listehasta.DataBind();


                ImageButton edt = new ImageButton();
                LinkButton lbAd = new LinkButton();
                int klm = 0;

                foreach (GridViewRow satir in listehasta.Rows)
                {


                    edt = (ImageButton)satir.FindControl("edt");
            

                    //edt.CommandArgument = gebelikdt4.Rows[klm]["SID"].ToString();
                    edt.OnClientClick = "window.open('mp55thumbflry.aspx?id=" + gebelikdt4.Rows[klm]["SID"].ToString() + "','','location=1,status=0,scrollbars=1,width=350,height=400');return false;";
                    lbAd = (LinkButton)satir.FindControl("lbAd");
                    lbAd.Text = gebelikdt4.Rows[klm]["ad"].ToString();
                    //edt.CommandArgument = gebelikdt4.Rows[klm]["SID"].ToString();
                    edt.OnClientClick = "window.open('mp55thumbflry.aspx?id=" + gebelikdt4.Rows[klm]["SID"].ToString() + "','','location=0,status=0,scrollbars=1,width=350,height=400');return false;";
                    lbAd.CommandArgument = gebelikdt4.Rows[klm]["SID"].ToString();



                    //satir.BackColor = System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.Yellow);
                    //satir.ForeColor = System.Drawing.Color.Black;


                    MySqlDataAdapter da22 = new MySqlDataAdapter("Select doktorID from atama where siklusID=" + gebelikdt4.Rows[klm]["SID"].ToString() + "", mp_connection);
                    DataTable dt22 = new DataTable();
                    da22.Fill(dt22);

                    if (dt22.Rows.Count != 0)
                    {

                        if (drp_dr2.Items.FindByValue(dt22.Rows[0][0].ToString()) != null)
                        {
                            satir.Cells[6].Text = drp_dr2.Items.FindByValue(dt22.Rows[0][0].ToString()).Text;
                        }




                    }

                    if (gebelikdt4.Rows[klm]["ge"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("1").Text);

                    }

                    if (gebelikdt4.Rows[klm]["ge"].ToString() == "-")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("2").Text);

                    }


                    if (gebelikdt4.Rows[klm]["biy"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("3").Text);

                    }

                    if (gebelikdt4.Rows[klm]["ab"].ToString() == "+")
                    {

                        if (gebelikdt4.Rows[klm]["fkh"].ToString() == "+")
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("4").Text);

                        }
                        else
                        {

                            satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);
                            satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("5").Text);

                        }

                    }

                    if (gebelikdt4.Rows[klm]["kry"].ToString() == "+")
                    {
                        satir.Cells[0].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                        satir.Cells[1].BackColor = System.Drawing.Color.FromName("#" + renk.Items.FindByValue("6").Text);
                    }
                    klm++;
                }





                ac = (ImageButton)str.FindControl("ac");
                kapat = (ImageButton)str.FindControl("kapat");
                if (toplamsiklussayisi < 1)
                {
                    ac.Visible = false;
                }
                else
                {
                    ac.Visible = true;
                }
                int k = a + 1;

                if (k < 10)
                {


                    ac.OnClientClick = "ctl00_ContentPlaceHolder1_list_ctl01_detay2";



                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_detay2').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_detay2').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl0" + k + "_ac').style.display='';return false;";


                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }
                else
                {
                    string sozcuk1 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_detay2').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_kapat').style.display='';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_ac').style.display='none';return false;";
                    string sozcuk2 = "document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_detay2').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_kapat').style.display='none';document.getElementById('ctl00_ContentPlaceHolder1_list_ctl" + k + "_ac').style.display='';return false;";



                    ac.OnClientClick = sozcuk1;
                    kapat.OnClientClick = sozcuk2;

                }


                //label9 = (Label)str.FindControl("Label9");

                //if (virgulolayi(gebeyuzdeh) == "NaN")
                //{
                //    label9.Text = "0 %";
                //}
                //else
                //{
                //    label9.Text = virgulolayi(gebeyuzdeh) + " %";
                //}

                label43 = (Label)str.FindControl("Label43");
                label43.Text = "S : " + toplamsiklussayisi.ToString();
                //+ " / H : " + toplamhastasayisih.ToString();






                DataRow[] gebeliksatiriO = mp_dt.Select("Ov='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] gebeliksatiri2O = mp_dt.Select("Ov='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");

                DataTable gebelikdtO = mp_dt.Copy();
                gebelikdtO.Clear();

                foreach (DataRow yeni in gebeliksatiriO)
                {
                    gebelikdtO.ImportRow(yeni);

                }

                DataTable gebelikdt5O = mp_dt.Copy();
                gebelikdt5O.Clear();

                foreach (DataRow yeni in gebeliksatiri2O)
                {
                    gebelikdt5O.ImportRow(yeni);

                }

                DataTable gebelikdt2O = gebelikdtO.DefaultView.ToTable(true, new string[] { "ad" });
                ovulasyonh = gebelikdt2O.Rows.Count;

                DataTable gebelikdt6O = gebelikdt5O.DefaultView.ToTable(true, new string[] { "ad" });
                ovulasyonh2 = gebelikdt6O.Rows.Count;


                ovulasyon = gebeliksatiriO.Length;
                ovulasyon2 = gebeliksatiri2O.Length;
                ovuyuzde = 100 * ovulasyon / (ovulasyon + ovulasyon2);
                ovuyuzdeh = 100 * ovulasyonh / (ovulasyonh + ovulasyonh2);





                label14 = (Label)str.FindControl("Label14");
                label14.Text = " - ";


                label13 = (Label)str.FindControl("Label13");


                if (goruntu.SelectedIndex == 0)
                {


                    DataRow[] canlisatiri = mp_dt.Select("Do='+' and Co='-' and yil='" + dttarih.Rows[a][1].ToString() + "'");


                    DataTable canlidt = mp_dt.Copy();
                    canlidt.Clear();

                    foreach (DataRow yeni in canlisatiri)
                    {
                        canlidt.ImportRow(yeni);

                    }

                    DataTable canlidt2 = canlidt.DefaultView.ToTable(true, new string[] { "ad" });
                    canlih = canlidt2.Rows.Count;


                    label14.Text = canlih.ToString();

                    if (toplamsiklussayisi != 0)
                    {
                        double say1 = 100 * canlidt.Rows.Count / toplamsiklussayisi;
                        double say2 = 100 * canlih / toplamhastasayisih;


                        label13.Text = virgulolayi(say2) + " %";
                    }
                    else
                    {

                        label13.Text = " 0 % ";


                    }
                }
                else
                {

                    label14.Text = " - ";


                    label13.Text = " - ";
                }




                DataRow[] hiperstimulasyonsatiri = mp_dt.Select("Hi='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] hiperstimulasyonsatiri2 = mp_dt.Select("Hi='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");


                DataTable hiperstimulasyondt = mp_dt.Copy();
                hiperstimulasyondt.Clear();

                foreach (DataRow yeni in hiperstimulasyonsatiri)
                {
                    hiperstimulasyondt.ImportRow(yeni);
                }


                DataTable hiperstimulasyondt5 = mp_dt.Copy();
                hiperstimulasyondt5.Clear();

                foreach (DataRow yeni in hiperstimulasyonsatiri2)
                {
                    hiperstimulasyondt5.ImportRow(yeni);
                }


                DataTable hiperstimulasyondt2 = hiperstimulasyondt.DefaultView.ToTable(true, new string[] { "ad" });
                hiperstimulasyonh = hiperstimulasyondt2.Rows.Count;
                DataTable hiperstimulasyondt6 = hiperstimulasyondt5.DefaultView.ToTable(true, new string[] { "ad" });
                hiperstimulasyonh2 = hiperstimulasyondt6.Rows.Count;

                hiperstimulasyon = hiperstimulasyonsatiri.Length;
                hiperstimulasyon2 = hiperstimulasyonsatiri2.Length;
                hiperyuzde = 100 * hiperstimulasyon / (hiperstimulasyon + hiperstimulasyon2);
                hiperyuzdeh = 100 * hiperstimulasyonh / (hiperstimulasyonh + hiperstimulasyonh2);


                //label40 = (Label)str.FindControl("Label40");
                //label40.Text = hiperstimulasyonh.ToString();

                //label41 = (Label)str.FindControl("Label41");

                //if (virgulolayi(hiperyuzdeh) == "NaN")
                //{
                //    label41.Text = "0 %";
                //}
                //else
                //{
                //    label41.Text = virgulolayi(hiperyuzdeh) + " %";
                //}



                DataRow[] biyosatiri = mp_dt.Select("Biy='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] biyosatiri2 = mp_dt.Select("Biy='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");


                DataTable biydt = mp_dt.Copy();
                biydt.Clear();

                foreach (DataRow yeni in biyosatiri)
                {
                    biydt.ImportRow(yeni);
                }

                DataTable biydt5 = mp_dt.Copy();
                biydt5.Clear();

                foreach (DataRow yeni in biyosatiri2)
                {
                    biydt5.ImportRow(yeni);
                }

                DataTable biydt2 = biydt.DefaultView.ToTable(true, new string[] { "ad" });
                biyokimyasalh = biydt2.Rows.Count;

                DataTable biydt6 = biydt5.DefaultView.ToTable(true, new string[] { "ad" });
                biyokimyasalh2 = biydt6.Rows.Count;

                biyokimyasal = biyosatiri.Length;
                biyokimyasal2 = biyosatiri2.Length;
                biyoyuzde = 100 * biyokimyasal / gebelik;
                biyoyuzdeh = 100 * biyokimyasalh / gebelikh;


                //label18 = (Label)str.FindControl("Label18");
                //label18.Text = biyokimyasalh.ToString();




                //label17 = (Label)str.FindControl("Label17");

                //if (virgulolayi(biyoyuzdeh) == "NaN")
                //{
                //    label17.Text = "0 %";
                //}
                //else
                //{
                //    label17.Text = virgulolayi(biyoyuzdeh) + " %";
                //}



                DataRow[] abortussatiri = mp_dt.Select("Ab='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] abortussatiri2 = mp_dt.Select("Ab='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");


                DataTable abortusdt = mp_dt.Copy();
                abortusdt.Clear();

                foreach (DataRow yeni in abortussatiri)
                {
                    abortusdt.ImportRow(yeni);
                }


                DataTable abortusdt5 = mp_dt.Copy();
                abortusdt5.Clear();

                foreach (DataRow yeni in abortussatiri2)
                {
                    abortusdt5.ImportRow(yeni);
                }

                DataTable abortusdt2 = abortusdt.DefaultView.ToTable(true, new string[] { "ad" });
                abortush = abortusdt2.Rows.Count;

                DataTable abortusdt6 = abortusdt5.DefaultView.ToTable(true, new string[] { "ad" });
                abortush2 = abortusdt6.Rows.Count;



                abortus = abortussatiri.Length;
                abortus2 = abortussatiri2.Length;
                aboyuzde = 100 * abortus / gebelik;
                aboyuzdeh = 100 * abortush / gebelikh;



                //label22 = (Label)str.FindControl("Label22");
                //label22.Text = abortush.ToString();



                //label21 = (Label)str.FindControl("Label21");

                //if (virgulolayi(aboyuzdeh) == "NaN")
                //{
                //    label21.Text = "0 %";
                //}
                //else
                //{
                //    label21.Text = virgulolayi(aboyuzdeh) + " %";
                //}





                DataRow[] dogumsatiri = mp_dt.Select("Do='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] dogumsatiri2 = mp_dt.Select("Do='" + goruntulemesekli + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");

                DataTable dogumdt = mp_dt.Copy();
                dogumdt.Clear();

                foreach (DataRow yeni in dogumsatiri)
                {
                    dogumdt.ImportRow(yeni);
                }

                DataTable dogumdt5 = mp_dt.Copy();
                dogumdt5.Clear();

                foreach (DataRow yeni in dogumsatiri2)
                {
                    dogumdt5.ImportRow(yeni);
                }


                DataTable dogumdt2 = dogumdt.DefaultView.ToTable(true, new string[] { "ad" });
                dogumh = dogumdt2.Rows.Count;

                DataTable dogumdt6 = dogumdt5.DefaultView.ToTable(true, new string[] { "ad" });
                dogumh2 = dogumdt6.Rows.Count;





                dogum = dogumsatiri.Length;
                dogum2 = dogumsatiri2.Length;
                dogmyuzde = 100 * dogum / gebelik;
                dogmyuzdeh = 100 * dogumh / gebelikh;



                //label26 = (Label)str.FindControl("Label26");
                //label26.Text = dogumh.ToString();




                //label25 = (Label)str.FindControl("Label25");

                //if (virgulolayi(dogmyuzdeh) == "NaN")
                //{
                //    label25.Text = "0 %";
                //}
                //else
                //{
                //    label25.Text = virgulolayi(dogmyuzdeh) + " %";
                //}







                DataRow[] cogulgebeliksatiri = mp_dt.Select("Co='" + goruntu.SelectedValue.ToString() + "' and yil='" + dttarih.Rows[a][1].ToString() + "'");
                DataRow[] cogulgebeliksatiri2 = mp_dt.Select("Co='" + goruntulemesekli + "'and yil='" + dttarih.Rows[a][1].ToString() + "'");


                DataTable cogulgebelikdt = mp_dt.Copy();
                cogulgebelikdt.Clear();

                foreach (DataRow yeni in cogulgebeliksatiri)
                {
                    cogulgebelikdt.ImportRow(yeni);
                }

                DataTable cogulgebelikdt5 = mp_dt.Copy();
                cogulgebelikdt5.Clear();

                foreach (DataRow yeni in cogulgebeliksatiri2)
                {
                    cogulgebelikdt5.ImportRow(yeni);
                }


                DataTable coguldt2 = cogulgebelikdt.DefaultView.ToTable(true, new string[] { "ad" });
                cgebelikh = coguldt2.Rows.Count;

                DataTable coguldt6 = cogulgebelikdt5.DefaultView.ToTable(true, new string[] { "ad" });
                cgebelikh2 = coguldt6.Rows.Count;




                cgebelik = cogulgebeliksatiri.Length;
                cgebelik2 = cogulgebeliksatiri2.Length;
                cgebeyuzde = 100 * cgebelik / gebelik;
                cgebeyuzdeh = 100 * cgebelikh / gebelikh;



                //label37 = (Label)str.FindControl("Label37");
                //label37.Text = cgebelikh.ToString();




                //label36 = (Label)str.FindControl("Label36");

                //if (virgulolayi(cgebeyuzdeh) == "NaN")
                //{
                //    label36.Text = "0 %";
                //}
                //else
                //{
                //    label36.Text = virgulolayi(cgebeyuzdeh) + " %";
                //}





                //Label Label3 = new Label();
                //Label3 = (Label)str.FindControl("Label3");
                //double devam = gebelikh - biyokimyasalh - abortush;
                //Label3.Text = devam.ToString();

                //Label Label4 = new Label();
                //Label4 = (Label)str.FindControl("Label4");
                //double devamYuzde = 100 * devam / toplamsiklussayisi;

                //if (virgulolayi(devamYuzde) == "NaN")
                //{
                //    Label4.Text = "0 %";
                //}
                //else
                //{
                //    Label4.Text = virgulolayi(devamYuzde) + " %";
                //}



                a++;

            }




        }




    }

    string virgulolayi(double a)
    {

        //double m = 784;
        //Response.Write(m.ToString().LastIndexOf(','));


        int k = a.ToString().LastIndexOf(',');

        if (k == -1)
        {


            return a.ToString();


        }
        else
        {
            return a.ToString().Substring(0, k + 2);
        }


    }


    protected void lbAd_Command(object sender, CommandEventArgs e)
    {
        MySqlConnection mp_connection = mp_class.connect_flry(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("select hasta_id from siklus_ana_tab where siklus_id=" + e.CommandArgument.ToString() + "", mp_connection);

        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        HttpCookie mpKullanilan = new HttpCookie("HastaBilgi");
        mpKullanilan["HastaID"] = mp_dt.Rows[0]["hasta_id"].ToString();
        mpKullanilan.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(mpKullanilan);

        Response.Redirect("hasta_modulu/infertilite.aspx?ts=1&siklus_id=" + e.CommandArgument.ToString());


    }
    protected void adiSoyadi_Command(object sender, CommandEventArgs e)
    {
        MySqlConnection mp_connection = mp_class.connect_flry(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("select hasta_id from siklus_ana_tab where siklus_id=" + e.CommandArgument.ToString() + "", mp_connection);

        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        HttpCookie mpKullanilan = new HttpCookie("HastaBilgi");
        mpKullanilan["HastaID"] = mp_dt.Rows[0]["hasta_id"].ToString();
        mpKullanilan.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(mpKullanilan);

        Response.Redirect("hasta_modulu/infertilite.aspx?ts=1&siklus_id=" + e.CommandArgument.ToString());
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}