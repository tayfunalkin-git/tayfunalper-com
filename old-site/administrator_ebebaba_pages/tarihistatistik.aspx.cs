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
            page_label0.Text = Request.QueryString["tarih"].ToString();
            page_label.Text = " tarihli Ýstatistikler";

            Page.Title = page_label0.Text + " Tarihli Ýstatistikler";
            yukle();
            kullanici();
        }
    }

    void kullanici()
    {

        string tarihim = page_label0.Text;
        string sql2 = "select distinct IP from istatistik where left(tarih,10) = '" + tarihim + "' and not sayfa is null";

        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
        MySqlDataAdapter da66 = new MySqlDataAdapter(sql2, connect_word);
        DataTable dt66 = new DataTable();
        da66.Fill(dt66);


        GridView2.DataSource = dt66;
        GridView2.DataBind();

        int a = 0;
        foreach (GridViewRow satir in GridView2.Rows)
        {
            LinkButton ip = new LinkButton();
            ip = (LinkButton)satir.FindControl("ip");


            ip.Text = dt66.Rows[a][0].ToString();
            ip.CommandArgument = dt66.Rows[a][0].ToString();
            a++;
        }




    }


    void yukle()
    {
        string tarihim = page_label0.Text;

        string sql = "select * from istatistik where left(tarih,10) = '" + tarihim + "'";
        string sql1 = "select distinct sayfa from istatistik where left(tarih,10) = '" + tarihim + "' and not sayfa is null";
       
        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
                MySqlDataAdapter da = new MySqlDataAdapter(sql, connect_word);
                DataTable dt = new DataTable();
                da.Fill(dt);        
                MySqlDataAdapter da6 = new MySqlDataAdapter(sql1, connect_word);
                DataTable dt6 = new DataTable();
                da6.Fill(dt6);


                DataTable dtson = new DataTable();
                DataColumn dcson = new DataColumn("Sayfa Adý");
                DataColumn dcson2 = new DataColumn("Gösterim Sayýsý",Type.GetType("System.Int32"));
                DataColumn dcson3 = new DataColumn("Farklý Ziyaretçi Sayýsý");

                dtson.Columns.Add(dcson);
                dtson.Columns.Add(dcson2);
                dtson.Columns.Add(dcson3);
        
                foreach (DataRow dr in dt6.Rows)
                { 
                
                      DataRow[] gebeliksatiri2 = dt.Select("sayfa='" + dr[0] + "'");

                      DataTable gebelikdt = dt.Copy();
                      gebelikdt.Clear();

                      foreach (DataRow yeni in gebeliksatiri2)
                      {
                       gebelikdt.ImportRow(yeni);
                      }
                DataTable gebelikdt2 = gebelikdt.DefaultView.ToTable(true, new string[] { "IP" });

                      DataRow eklenecek = dtson.NewRow();
                    
                      eklenecek[0] = dr[0];
                      eklenecek[1] = gebelikdt.Rows.Count.ToString();

                      eklenecek[2] = gebelikdt2.Rows.Count.ToString();
                   
                     

                     dtson.Rows.Add(eklenecek);
                }



                DataView dataView = new DataView(dtson); 
                dataView.Sort = "Gösterim Sayýsý DESC";        


                if (dtson.Rows.Count > 0)
                {
                    Panel1.Visible = true;
                    GridView1.DataSource = dataView;
                    GridView1.DataBind();

                

                    int say1 = 0;
                    int say2 = 0;
                    foreach (DataRow d in dtson.Rows)
                    {
                        say1 += int.Parse(d[1].ToString());
                       
                                            
                    }
                    Label3.Text = say1.ToString();

                    DataTable dsn = dt.DefaultView.ToTable(true, new string[] { "IP" });

                    Label4.Text = dsn.Rows.Count.ToString();
                    sonuc.Text = "";

                }
                else
                {
                    Panel1.Visible = false;
                    sonuc.Text = "Gösterilecek Kayýt Bulunamadý!";
                
                }
                }


    protected void ip_Command(object sender, CommandEventArgs e)
    {



        GridView3.Visible = true;


        page_label2.Text = e.CommandArgument.ToString() + " IP adresli kullanýcý detayý";

        string tarihim = page_label0.Text;
        string sql2 = "select sayfa,IP,tarih from istatistik where left(tarih,10) = '" + tarihim + "' and IP='"+e.CommandArgument.ToString() +"' order by str_to_date(tarih,'%d.%m.%Y %T') asc";

        MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
        MySqlDataAdapter da66 = new MySqlDataAdapter(sql2, connect_word);
        DataTable dt66 = new DataTable();
        da66.Fill(dt66);


        GridView3.DataSource = dt66;
        GridView3.DataBind();

        int a = 0;
        foreach (GridViewRow satir in GridView3.Rows)
        {
            Label sayfa = new Label();
            Label saat = new Label();
            Label sure = new Label();

            sayfa = (Label)satir.FindControl("sayfa");
            saat = (Label)satir.FindControl("saat");
            sure = (Label)satir.FindControl("sure");

            sayfa.Text = dt66.Rows[a]["sayfa"].ToString();
            saat.Text = dt66.Rows[a]["tarih"].ToString().Substring(10, 9);

            if (dt66.Rows.Count > 1)
            {


                if (dt66.Rows.Count > a+1)
                {

                    string baslangic = dt66.Rows[a]["tarih"].ToString();
                    string bitis = dt66.Rows[a + 1]["tarih"].ToString();

                    TimeSpan ts = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                    if(ts.Minutes > 0)
                    {

                        if (ts.Hours > 0)
                        {
                            sure.Text = ts.Hours.ToString() + " Sa." + ts.Minutes.ToString() + " Dk.";

                        }
                        else
                        { 
                        
                         sure.Text = ts.Minutes.ToString() + " Dk.";
                        }
                     
                    
                    
                    }
                    else
                    {
                    sure.Text = ts.Seconds.ToString() + " Sn.";
                    
                    }
                }
                else
                {
                    sure.Text = "-";

                }




            }
            else
            {
                sure.Text = "-";            
            }

          






            a++;
        
        }



    }
    protected void LinkButton1_Command(object sender, CommandEventArgs e)
    {

        DateTime yeni =  DateTime.Parse(page_label0.Text).AddDays(-1);
        page_label0.Text = yeni.ToShortDateString();
        page_label.Text = " tarihli Ýstatistikler";
        yukle();
        kullanici();
        GridView3.Visible = false;
        page_label2.Text = "";

        Page.Title = page_label0.Text + " Tarihli Ýstatistikler";



    }
    protected void LinkButton2_Command(object sender, CommandEventArgs e)
    {

       DateTime yeni =  DateTime.Parse(page_label0.Text).AddDays(1);
       page_label0.Text = yeni.ToShortDateString();
       page_label.Text = " tarihli Ýstatistikler";
       yukle();
       kullanici();
       GridView3.Visible = false;
       page_label2.Text = "";

       Page.Title = page_label0.Text + " Tarihli Ýstatistikler";
    }
}
