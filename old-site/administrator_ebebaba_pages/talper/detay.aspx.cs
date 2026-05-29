using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ivfyonetici_talper_detay : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
        ivfyukle();
        flryYukle();
        }

    }

    private void ivfyukle()
    {
        MySqlConnection connect_word = connect_ivf(0301009184);
   

        string sql9 = "Select (F.fiyat / F.adet) as birimFiyati,M.adet,((F.fiyat / F.adet) * M.adet) as kalemFiyati,M.siklusID,concat(U.uye_adi,' ',U.uye_soyadi) as ad,U.uye_id as HID,L.malzemeAdi,concat(S.siklus_ay,'-',S.siklus_yil) as siklus,M.tarih from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join siklus_ana_tab S on M.siklusID=S.siklus_id left join kisa_siklus K on S.siklus_id=K.siklus_id left join uye_hasta U on S.hasta_id=U.uye_id left join sarfmalzemelistesi L on F.kalemID=L.ID where ";

        if (Request.QueryString["tarihTur"].ToString() == "yil")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + Request.QueryString["yil"].ToString() + " and M.adet <> '0' and M.kategoriID=" + Request.QueryString["kategori"].ToString() + " and M.cryoID is null and spermID is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc";
        }
        else if (Request.QueryString["tarihTur"].ToString() == "ay")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + Request.QueryString["yil"].ToString() + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + Request.QueryString["ay"].ToString() + " and M.adet <> '0' and M.kategoriID=" + Request.QueryString["kategori"].ToString() + " and M.cryoID is null and spermID is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc,L.malzemeAdi asc";
        }

        MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
        da9.SelectCommand.CommandTimeout = 1200;
        DataTable dt = new DataTable();
        da9.Fill(dt);

        DataTable dtSiklus = dt.DefaultView.ToTable(true, new string[] { "siklusID" });
        anaListe.DataSource = dtSiklus;
        anaListe.DataBind();


        Label hastaAdi = new Label();
        GridView altListe = new GridView();
        Label siklus = new Label();
        Label toplam = new Label();
        ImageButton ac = new ImageButton();
        ImageButton kapat = new ImageButton();
        double malzemeToplami = 0;
        double siklusSayisi = 0;
        double ortalama = 0;

        int a = 0;
        foreach (DataListItem oge in anaListe.Items)
        {
            hastaAdi = (Label)oge.FindControl("hastaAdi");
            altListe = (GridView)oge.FindControl("altListe");
            siklus = (Label)oge.FindControl("siklus");
            toplam = (Label)oge.FindControl("toplam");

            ac = (ImageButton)oge.FindControl("ac");
            kapat = (ImageButton)oge.FindControl("kapat");

            DataRow[] listeRow = dt.Select("siklusID='" + dtSiklus.Rows[a][0].ToString() + "'");
            DataTable listeDt = dt.Copy();
            listeDt.Clear();

            foreach (DataRow yeni in listeRow)
            {
                listeDt.ImportRow(yeni);
            }

            hastaAdi.Text = listeDt.Rows[0]["ad"].ToString();
            siklus.Text = listeDt.Rows[0]["siklus"].ToString();
            toplam.Text = "";
            altListe.DataSource = listeDt;
            altListe.DataBind();

            ac.CommandArgument = a.ToString();
            kapat.CommandArgument = a.ToString();


            Label lblBirimFiyat = new Label();
            Label lblToplamFiyat = new Label();

            int b = 0;
            double siklusToplami = 0;
            foreach (GridViewRow satir in altListe.Rows)
            {

                lblBirimFiyat = (Label)satir.FindControl("lblBirimFiyat");
                lblToplamFiyat = (Label)satir.FindControl("lblToplamFiyat");

                lblBirimFiyat.Text = double.Parse(listeDt.Rows[b]["birimFiyati"].ToString()).ToString("C");
                double kalemToplami = double.Parse(listeDt.Rows[b]["birimFiyati"].ToString()) * double.Parse(listeDt.Rows[b]["adet"].ToString());
                lblToplamFiyat.Text = kalemToplami.ToString("C");
                siklusToplami += kalemToplami;

                b++;
            
            }

            toplam.Text = siklusToplami.ToString("C");
            malzemeToplami += siklusToplami;
            siklusSayisi += 1;



            a++;
          
        
        }

        Label1.Text = malzemeToplami.ToString("C");
        Label2.Text = siklusSayisi.ToString();
        double ort = malzemeToplami / siklusSayisi;
        Label3.Text = ort.ToString("C");
        Label0.Text = Request.QueryString["kategoriAdi"].ToString();

        DataTable dtMalzeme = dt.DefaultView.ToTable(true, new string[] { "malzemeAdi" });

        malzemeList.DataSource = dtMalzeme;
        malzemeList.DataBind();


        Label lblToplamKullanilan = new Label();
        Label lblToplamTutar = new Label();
     
        int c = 0;
        foreach (GridViewRow str in malzemeList.Rows)
        {
            lblToplamKullanilan = (Label)str.FindControl("lblToplamKullanilan");
            lblToplamTutar = (Label)str.FindControl("lblToplamTutar");


            DataRow[] mlzRow = dt.Select("malzemeAdi='" + dtMalzeme.Rows[c][0].ToString() + "'");
            DataTable mlzDt = dt.Copy();
            mlzDt.Clear();

            foreach (DataRow yeni in mlzRow)
            {
                mlzDt.ImportRow(yeni);
            }

            double mlzAdet = 0;
            double mlzToplam = 0;
            for (int m = 0; m < mlzDt.Rows.Count; m++)
            {
                mlzAdet += int.Parse(mlzDt.Rows[m]["adet"].ToString());
                mlzToplam += int.Parse(mlzDt.Rows[m]["adet"].ToString()) * double.Parse(mlzDt.Rows[m]["birimFiyati"].ToString());
            }

            lblToplamKullanilan.Text = mlzAdet.ToString();
            lblToplamTutar.Text = mlzToplam.ToString("C");


            c++;
        }





    }
    protected void ac_Command(object sender, CommandEventArgs e)
    {
        int satir = int.Parse(e.CommandArgument.ToString());
        ((GridView)anaListe.Items[satir].FindControl("altListe")).Visible = true;
        ((ImageButton)anaListe.Items[satir].FindControl("ac")).Visible = false;
        ((ImageButton)anaListe.Items[satir].FindControl("kapat")).Visible = true;


    }
    protected void kapat_Command(object sender, CommandEventArgs e)
    {
        int satir = int.Parse(e.CommandArgument.ToString());
        ((GridView)anaListe.Items[satir].FindControl("altListe")).Visible = false;
        ((ImageButton)anaListe.Items[satir].FindControl("ac")).Visible = true;
        ((ImageButton)anaListe.Items[satir].FindControl("kapat")).Visible = false;

    }

    private void flryYukle()
    {
        MySqlConnection connect_word = connect_ivf2(0301009184);


        string sql9 = "Select (F.fiyat / F.adet) as birimFiyati,M.adet,((F.fiyat / F.adet) * M.adet) as kalemFiyati,M.siklusID,concat(U.uye_adi,' ',U.uye_soyadi) as ad,U.uye_id as HID,L.malzemeAdi,concat(S.siklus_ay,'-',S.siklus_yil) as siklus,M.tarih from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join siklus_ana_tab S on M.siklusID=S.siklus_id left join kisa_siklus K on S.siklus_id=K.siklus_id left join uye_hasta U on S.hasta_id=U.uye_id left join sarfmalzemelistesi L on F.kalemID=L.ID where ";

        if (Request.QueryString["tarihTur"].ToString() == "yil")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + Request.QueryString["yil"].ToString() + " and M.adet <> '0' and M.kategoriID=" + Request.QueryString["kategori"].ToString() + " and M.cryoID is null and spermID is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc";
        }
        else if (Request.QueryString["tarihTur"].ToString() == "ay")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + Request.QueryString["yil"].ToString() + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + Request.QueryString["ay"].ToString() + " and M.adet <> '0' and M.kategoriID=" + Request.QueryString["kategori"].ToString() + " and M.cryoID is null and spermID is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc,L.malzemeAdi asc";
        }

        MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
        da9.SelectCommand.CommandTimeout = 1200;
        DataTable dt = new DataTable();
        da9.Fill(dt);

        DataTable dtSiklus = dt.DefaultView.ToTable(true, new string[] { "siklusID" });
        anaListe0.DataSource = dtSiklus;
        anaListe0.DataBind();


        Label hastaAdi = new Label();
        GridView altListe = new GridView();
        Label siklus = new Label();
        Label toplam = new Label();
        ImageButton ac = new ImageButton();
        ImageButton kapat = new ImageButton();
        double malzemeToplami = 0;
        double siklusSayisi = 0;
        double ortalama = 0;

        int a = 0;
        foreach (DataListItem oge in anaListe0.Items)
        {
            hastaAdi = (Label)oge.FindControl("hastaAdi0");
            altListe = (GridView)oge.FindControl("altListe0");
            siklus = (Label)oge.FindControl("siklus0");
            toplam = (Label)oge.FindControl("toplam0");

            ac = (ImageButton)oge.FindControl("ac0");
            kapat = (ImageButton)oge.FindControl("kapat0");

            DataRow[] listeRow = dt.Select("siklusID='" + dtSiklus.Rows[a][0].ToString() + "'");
            DataTable listeDt = dt.Copy();
            listeDt.Clear();

            foreach (DataRow yeni in listeRow)
            {
                listeDt.ImportRow(yeni);
            }

            hastaAdi.Text = listeDt.Rows[0]["ad"].ToString();
            siklus.Text = listeDt.Rows[0]["siklus"].ToString();
            toplam.Text = "";
            altListe.DataSource = listeDt;
            altListe.DataBind();

            ac.CommandArgument = a.ToString();
            kapat.CommandArgument = a.ToString();


            Label lblBirimFiyat = new Label();
            Label lblToplamFiyat = new Label();

            int b = 0;
            double siklusToplami = 0;
            foreach (GridViewRow satir in altListe.Rows)
            {

                lblBirimFiyat = (Label)satir.FindControl("lblBirimFiyat0");
                lblToplamFiyat = (Label)satir.FindControl("lblToplamFiyat0");

                lblBirimFiyat.Text = double.Parse(listeDt.Rows[b]["birimFiyati"].ToString()).ToString("C");
                double kalemToplami = double.Parse(listeDt.Rows[b]["birimFiyati"].ToString()) * double.Parse(listeDt.Rows[b]["adet"].ToString());
                lblToplamFiyat.Text = kalemToplami.ToString("C");
                siklusToplami += kalemToplami;

                b++;

            }

            toplam.Text = siklusToplami.ToString("C");
            malzemeToplami += siklusToplami;
            siklusSayisi += 1;



            a++;


        }

        Label5.Text = malzemeToplami.ToString("C");
        Label6.Text = siklusSayisi.ToString();
        double ort = malzemeToplami / siklusSayisi;
        Label7.Text = ort.ToString("C");
        Label4.Text = Request.QueryString["kategoriAdi"].ToString();

        DataTable dtMalzeme = dt.DefaultView.ToTable(true, new string[] { "malzemeAdi" });

        malzemeList0.DataSource = dtMalzeme;
        malzemeList0.DataBind();


        Label lblToplamKullanilan = new Label();
        Label lblToplamTutar = new Label();

        int c = 0;
        foreach (GridViewRow str in malzemeList0.Rows)
        {
            lblToplamKullanilan = (Label)str.FindControl("lblToplamKullanilan0");
            lblToplamTutar = (Label)str.FindControl("lblToplamTutar0");


            DataRow[] mlzRow = dt.Select("malzemeAdi='" + dtMalzeme.Rows[c][0].ToString() + "'");
            DataTable mlzDt = dt.Copy();
            mlzDt.Clear();

            foreach (DataRow yeni in mlzRow)
            {
                mlzDt.ImportRow(yeni);
            }

            double mlzAdet = 0;
            double mlzToplam = 0;
            for (int m = 0; m < mlzDt.Rows.Count; m++)
            {
                mlzAdet += int.Parse(mlzDt.Rows[m]["adet"].ToString());
                mlzToplam += int.Parse(mlzDt.Rows[m]["adet"].ToString()) * double.Parse(mlzDt.Rows[m]["birimFiyati"].ToString());
            }

            lblToplamKullanilan.Text = mlzAdet.ToString();
            lblToplamTutar.Text = mlzToplam.ToString("C");


            c++;
        }





    }
    
    
    public MySqlConnection connect_ivf2(int coming)
    {
        MySqlConnection connect = new MySqlConnection("DataSource=94.73.150.121;Database=FLORYAdbB5043B;User ID=userB5043B;Password=EInt63E8;charset=latin5;convert zero datetime=True");
        return connect;
    }

    public MySqlConnection connect_ivf(int coming)
    {
        MySqlConnection connect = new MySqlConnection("DataSource=85.159.67.232;Database=ivfdb;User ID=ivfdb;Password=0301009184;charset=latin5");
        return connect;
    }

    protected void ac0_Command(object sender, CommandEventArgs e)
    {
        int satir = int.Parse(e.CommandArgument.ToString());
        ((GridView)anaListe0.Items[satir].FindControl("altListe0")).Visible = true;
        ((ImageButton)anaListe0.Items[satir].FindControl("ac0")).Visible = false;
        ((ImageButton)anaListe0.Items[satir].FindControl("kapat0")).Visible = true;
    }
    protected void kapat0_Command(object sender, CommandEventArgs e)
    {
        int satir = int.Parse(e.CommandArgument.ToString());
        ((GridView)anaListe0.Items[satir].FindControl("altListe0")).Visible = false;
        ((ImageButton)anaListe0.Items[satir].FindControl("ac0")).Visible = true;
        ((ImageButton)anaListe0.Items[satir].FindControl("kapat0")).Visible = false;

    }
}