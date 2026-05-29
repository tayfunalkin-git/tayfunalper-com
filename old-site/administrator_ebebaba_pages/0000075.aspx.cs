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

public partial class ebebaba_0000063 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
    forum_class fc = new forum_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            baslangicay.SelectedIndex = DateTime.Now.Month - 1;
            bitisay.SelectedIndex = DateTime.Now.Month - 1;

            baslangicgun.SelectedIndex = DateTime.Now.Day - 1;
            bitisgun.SelectedIndex = DateTime.Now.Day - 1;

            baslangicyil.SelectedValue = DateTime.Now.Year.ToString();
            bitisyil.SelectedValue = DateTime.Now.Year.ToString();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        string sql = "select sayfa,IP,left(tarih,10) as tarih2,ID,SUBSTRING(tarih,4,2) as AY from istatistik where ";
        yukle(sql);

    }


    void yukle(string sql)
    {

        string baslangic = baslangicgun.SelectedValue + "." + baslangicay.SelectedValue + "." + baslangicyil.SelectedValue;
        string bitis = bitisgun.SelectedValue + "." + bitisay.SelectedValue + "." + bitisyil.SelectedValue;

        DateTime basla = DateTime.Parse(baslangic);
        DateTime bitir = DateTime.Parse(bitis);

        TimeSpan ts = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
        if (ts.Days < 0)
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Baþlangýç tarihi , bitiþ tarihinden büyük olamaz !";
            sonuc.ForeColor = System.Drawing.Color.Red;

            Panel1.Visible = false;
        }
        else
        {


            if (RadioButtonList1.SelectedIndex == 0)
            {


                string yenisql = sql + " str_to_date(tarih,'%d.%m.%Y') Between str_to_date('" + baslangic + "','%d.%m.%Y') And str_to_date('" + bitis + "','%d.%m.%Y')";

                MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
                MySqlDataAdapter da6 = new MySqlDataAdapter(yenisql, connect_word);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);


                if (dt6.Rows.Count == 0)
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Seçilen kriterlere göre gösterim sayýsý bulunamadý !";
                    sonuc.ForeColor = System.Drawing.Color.Red;
                    Panel1.Visible = false;

                }
                else
                {

                    Label1.Text = "Toplam : " + dt6.Rows.Count.ToString() + " Gösterim";
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Panel1.Visible = true;
                    panel_sonuc.Visible = false;
                    DataTable dt = new DataTable();

                    DataColumn dc = new DataColumn("Tarih");
                    DataColumn dc2 = new DataColumn("Sayfa Sayýsý");
                    DataColumn dc3 = new DataColumn("Kullanýcý Sayýsý");


                    dt.Columns.Add(dc);
                    dt.Columns.Add(dc2);

                    dt.Columns.Add(dc3);
                    while (bitir >= basla)
                    {

                        DataRow[] gebeliksatiri = dt6.Select("tarih2='" + basla.ToShortDateString() + "'");
                        DataTable gebelikdt = dt6.Copy();
                        gebelikdt.Clear();
                        foreach (DataRow yeni in gebeliksatiri)
                        {
                            gebelikdt.ImportRow(yeni);

                        }

                        DataTable gebelikdt2 = gebelikdt.DefaultView.ToTable(true, new string[] { "IP" });

                        DataTable gebelikdt3 = gebelikdt.DefaultView.ToTable(true, new string[] { "sayfa" });


                        DataRow dr = dt.NewRow();
                        dr[0] = basla.ToShortDateString();
                        dr[1] = gebelikdt.Rows.Count.ToString()  + " / " + gebelikdt3.Rows.Count.ToString();
                        dr[2] = gebelikdt2.Rows.Count.ToString();

                        dt.Rows.Add(dr);

                        basla = basla.AddDays(1);


                    }
                    GridView1.DataSource = dt;
                    GridView1.DataBind();

                    int ka = 0 ;
                    foreach (GridViewRow satir in GridView1.Rows)
                    {

                        LinkButton tarih = new LinkButton();
                        Label sayfa = new Label();
                        Label ziyaretci = new Label();

                        tarih = (LinkButton)satir.FindControl("tarih");
                        sayfa = (Label)satir.FindControl("sayfa");
                        ziyaretci = (Label)satir.FindControl("ziyaretci");
                        

                        tarih.Text = dt.Rows[ka][0].ToString();
                        sayfa.Text = dt.Rows[ka][1].ToString();
                        ziyaretci.Text = dt.Rows[ka][2].ToString();


                        tarih.OnClientClick = "window.open('tarihistatistik.aspx?tarih=" + dt.Rows[ka][0].ToString() + "','','toolbar=0,scrollbars=1,location=0,statusbar=0,menubar=0,resizable=0,width=1100,height=700,left = 200,top = 200');return false;";

                       

                    ka++;
                    }






                }


            }
            else if (RadioButtonList1.SelectedIndex == 1)
            {


                baslangic = "01." + baslangicay.SelectedValue + "." + baslangicyil.SelectedValue;

                bitis = "01." + bitisay.SelectedValue + "." + bitisyil.SelectedValue;

                basla = DateTime.Parse(baslangic);
                bitir = DateTime.Parse(bitis).AddMonths(1).AddDays(-1);

                string yenisql = sql + " str_to_date(tarih,'%d.%m.%Y') Between str_to_date('" + basla + "','%d.%m.%Y') And str_to_date('" + bitir + "','%d.%m.%Y')";

                MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
                MySqlDataAdapter da6 = new MySqlDataAdapter(yenisql, connect_word);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);

            
                if (dt6.Rows.Count == 0)
                {
                    panel_sonuc.Visible = true;
                    sonuc.Text = "Seçilen kriterlere göre gösterim sayýsý bulunamadý !";
                    sonuc.ForeColor = System.Drawing.Color.Red;
                    Panel1.Visible = false;

                }
                else
                {

                    Label1.Text = "Toplam : " + dt6.Rows.Count.ToString() + " Gösterim";
                    Label1.ForeColor = System.Drawing.Color.Green;
                    Panel1.Visible = true;
                    panel_sonuc.Visible = false;
                    DataTable dt = new DataTable();

                    DataColumn dc = new DataColumn("Tarih");
                    DataColumn dc2 = new DataColumn("Gösterim Sayýsý");
                    DataColumn dc3 = new DataColumn("Farklý Kullanýcý Sayýsý");


                    dt.Columns.Add(dc);
                    dt.Columns.Add(dc2);

                    dt.Columns.Add(dc3);
                   
                    while (bitir >= basla)
                    {

                        string yeni1 = basla.ToShortDateString();
                        string yeni2 = basla.AddMonths(1).ToShortDateString();


                        DataRow[] gebeliksatiri = dt6.Select("AY = '" + basla.ToShortDateString().Substring(3,2) + "'");
                        DataTable gebelikdt = dt6.Copy();
                        gebelikdt.Clear();
                        foreach (DataRow yeni in gebeliksatiri)
                        {
                            gebelikdt.ImportRow(yeni);

                        }
                     
                        DataTable gebelikdt2 = gebelikdt.DefaultView.ToTable(true, new string[] { "IP" });

                        DataTable gebelikdt3 = gebelikdt.DefaultView.ToTable(true, new string[] { "sayfa" });

                        DataRow dr = dt.NewRow();
                        dr[0] = ebebaba_class.ayadi(int.Parse(basla.ToShortDateString().Substring(3, 2))) + " - " + basla.Year.ToString();
                        dr[1] = gebelikdt.Rows.Count.ToString()  + " / " + gebelikdt3.Rows.Count.ToString();
                        dr[2] = gebelikdt2.Rows.Count.ToString();
                        dt.Rows.Add(dr);

                        basla = basla.AddMonths(1);


                    }
                    GridView1.DataSource = dt;
                    GridView1.DataBind();


                    int ka = 0;
                    foreach (GridViewRow satir in GridView1.Rows)
                    {

                        LinkButton tarih = new LinkButton();
                        Label sayfa = new Label();
                        Label ziyaretci = new Label();

                        tarih = (LinkButton)satir.FindControl("tarih");
                        sayfa = (Label)satir.FindControl("sayfa");
                        ziyaretci = (Label)satir.FindControl("ziyaretci");


                        tarih.Text = dt.Rows[ka][0].ToString();
                        sayfa.Text = dt.Rows[ka][1].ToString();
                        ziyaretci.Text = dt.Rows[ka][2].ToString();


                        tarih.OnClientClick = "window.open('tarihistatistik.aspx?tarih=" + dt.Rows[ka][0].ToString() + "','','toolbar=0,scrollbars=1,location=0,statusbar=0,menubar=0,resizable=0,width=1100,height=700,left = 200,top = 200');return false;";

                        ka++;
                    }


                }


            

            
            }
                      
        }

    }

}
