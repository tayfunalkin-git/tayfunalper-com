using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;
using MySql.Data.MySqlClient;


public partial class ivfyonetici_talper : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
      
                if (!IsPostBack)
                {
                    HttpCookie mpKullanilan = Request.Cookies["Doktor"];
                    string kullaniciAdi = mpKullanilan["doktorKullaniciAdi"].ToString();
                    if (kullaniciAdi == "tayfun")
                    {
                        if (Request.QueryString["islem"] != null)
                        {
                            if (Request.QueryString["islem"].ToString() == "ok")
                            {
                                yil.SelectedValue = DateTime.Now.Year.ToString();
                                ay.SelectedValue = yeniTarih(DateTime.Now.Date.ToShortDateString()).Substring(3, 2);

                            }
                            else
                            {
                                Response.Redirect("Default.aspx");
                            }
                        }
                        else
                        {
                            Response.Redirect("Default.aspx");
                        }
                    }
                    else
                    {
                        Response.Redirect("Default.aspx");
                    
                    }


                  
                }

    }
  
    private void listeYukle()
    {
        MySqlConnection connect_word = connect_ivf(0301009184);
        // sarf Listesi detay yükle Florya
        MySqlDataAdapter da9 = new MySqlDataAdapter("Select * from sarfmalzemekategori order by sira asc", connect_word);
        da9.SelectCommand.CommandTimeout = 1200;
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);

        sarfList.DataSource = dt9;
        sarfList.DataBind();

        Label toplamTutar = new Label();
        LinkButton toplamSiklus = new LinkButton();
        Label ortalama = new Label();
        Label toplamTutarIVF = new Label();
        LinkButton toplamSiklusIVF = new LinkButton();
        Label ortalamaIVF = new Label();
        string ekQuery = "";
        string ekTarih = "";

        if (ay.SelectedValue == "")
        {
            ekQuery = "tarihTur=yil&yil=" + yil.SelectedValue + "";
            ekTarih = yil.SelectedValue + " - Hepsi";
        }
        else
        {
            ekQuery = "tarihTur=ay&yil=" + yil.SelectedValue + "&ay=" + ay.SelectedValue;
            ekTarih = ay.SelectedItem.Text + " - " + yil.SelectedValue;
        }


        int y = 0;
        foreach (GridViewRow str in sarfList.Rows)
        {
            toplamTutar = (Label)str.FindControl("toplamTutar");
            toplamSiklus = (LinkButton)str.FindControl("toplamSiklus");
            ortalama = (Label)str.FindControl("ortalama");

            toplamTutarIVF = (Label)str.FindControl("toplamTutarIVF");
            toplamSiklusIVF = (LinkButton)str.FindControl("toplamSiklusIVF");
            ortalamaIVF = (Label)str.FindControl("ortalamaIVF");

            double ttutar = 0;
            double tsiklus = 0;
            double tortalama = 0;
            double tTutarIVF =0;
            double tortalamaIVF = 0;
            double tSiklusIVF=0;


            string flryTutar = flryToplamTutarAl(dt9.Rows[y][0].ToString());
            string flrySiklus = flryToplamSiklusAl(dt9.Rows[y][0].ToString());
            
            string ivfTutar = ivfToplamTutarAl(dt9.Rows[y][0].ToString());
            string ivfSiklus = ivfToplamSiklusAl(dt9.Rows[y][0].ToString());


            if(flryTutar != "0" && flryTutar !="")
            {
                ttutar = double.Parse(flryTutar);
            }

            if(flrySiklus != "0" && flrySiklus !="")
            {
                tsiklus = double.Parse(flrySiklus);
            }


            if(ivfTutar != "0" && ivfTutar !="")
            {
                tTutarIVF = double.Parse(ivfTutar);
            }

            if(ivfSiklus != "0" && ivfSiklus !="")
            {
                tSiklusIVF = double.Parse(ivfSiklus);
            }

            if(tsiklus != 0)
            {
            tortalama = ttutar / tsiklus;
            }


            if(tSiklusIVF != 0)
            {
            tortalamaIVF = tTutarIVF / tSiklusIVF;
            }

            // Yazdır
            if (ttutar != 0)
            {
                toplamTutar.Text = ttutar.ToString("C");
            }
            else
            {
                toplamTutar.Text = "-";
            }


            if (tsiklus != 0)
            {
                toplamSiklus.Text = tsiklus.ToString();
                toplamSiklus.OnClientClick = "createWindow('detay.aspx?site=flry&kategoriAdi=" + dt9.Rows[y][1].ToString() + "&kategori=" + dt9.Rows[y][0].ToString() + "&" + ekQuery + "','" + ekTarih + " - " + dt9.Rows[y][1].ToString() + "','90%','530','');return false;";

            }
            else
            {
                toplamSiklus.Text = "-";
                toplamSiklus.OnClientClick = "return false;";

            }



            if (tortalama != 0)
            {
                ortalama.Text = tortalama.ToString("C");
            }
            else
            {
                ortalama.Text = "-";
            }



            if (tTutarIVF != 0)
            {

                toplamTutarIVF.Text = tTutarIVF.ToString("C");
            }
            else
            {
                toplamTutarIVF.Text = "-";
            }


            if (tSiklusIVF != 0)
            {
                toplamSiklusIVF.Text = tSiklusIVF.ToString();
                toplamSiklusIVF.OnClientClick = "createWindow('detay.aspx?site=ivf&kategoriAdi=" + dt9.Rows[y][1].ToString() + "&kategori=" + dt9.Rows[y][0].ToString() + "&" + ekQuery + "','" + ekTarih + " - " + dt9.Rows[y][1].ToString() + "','90%','530','');return false;";

            }
            else
            {
                toplamSiklusIVF.Text = "-";
                toplamSiklusIVF.OnClientClick = "return false;";
            }



            if (tortalamaIVF != 0)
            {
                ortalamaIVF.Text = tortalamaIVF.ToString("C");
            }

            else
            {
                ortalamaIVF.Text = "-";
            }
        
           




            y++;
        
        }

        }


    private string flryToplamSiklusAl(string p)
    {
       

            string sql9 = "Select count(distinct(M.siklusID)) as sayi from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID where ";

            if (ay.SelectedValue == "")
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
            }
            else
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
            }

            MySqlConnection connect_word = connect_ivf2(0301009184);
            MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);

            return dt9.Rows[0][0].ToString();

      
     


    }

    private string flryToplamTutarAl(string p)
    {
       

            string sql9 = "Select CAST(round(sum((F.fiyat / F.adet) * M.adet)) as UNSIGNED) as toplam from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID where ";

            if (ay.SelectedValue == "")
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
            }
            else
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
            }

            MySqlConnection connect_word = connect_ivf2(0301009184);
            MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);

            return dt9.Rows[0][0].ToString();

     
     


    }

    private string ivfToplamSiklusAl(string p)
    {
        
        string sql9 = "Select count(distinct(M.siklusID)) as sayi from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID where ";

        if (ay.SelectedValue == "")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
        }
        else
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
        }


        MySqlConnection connect_word = connect_ivf(0301009184);
        MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
        da9.SelectCommand.CommandTimeout = 1200;
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);

        return dt9.Rows[0][0].ToString();





    }

    private string ivfToplamTutarAl(string p)
    {

       

        string sql9 = "Select CAST(round(sum((F.fiyat / F.adet) * M.adet)) as UNSIGNED) as toplam from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID where ";

        if (ay.SelectedValue == "")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
        }
        else
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + "";
        }


        MySqlConnection connect_word = connect_ivf(0301009184);
        MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
        da9.SelectCommand.CommandTimeout = 1200;
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);

        return dt9.Rows[0][0].ToString();
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        listeYukle();
      
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/administrator_ebebaba_pages/Default.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("5534.aspx");
    }

    public MySqlConnection connect_ivf2(int coming)
    {

        //try
        // {

       // MySqlConnection connect = new MySqlConnection("DataSource=localhost;Database=florya;User ID=root;Password=0301009184;");
        MySqlConnection connect = new MySqlConnection("DataSource=94.73.150.121;Database=FLORYAdbB5043B;User ID=userB5043B;Password=EInt63E8;charset=latin5;convert zero datetime=True");

        return connect;
        //        }
        //        catch
        //{
        //   return null;
        // }

    }

    public MySqlConnection connect_ivf(int coming)
    {

        //try
        // {

         MySqlConnection connect = new MySqlConnection("DataSource=85.159.67.232;Database=ivfdb;User ID=ivfdb;Password=0301009184;charset=latin5");

        return connect;
        //        }
        //        catch
        //{
        //   return null;
        // }

    }

    public string yeniTarih(string p)
    {
        string gun = "";
        string ay = "";
        string yil = "";
        string tarih = "";


        string[] dizi = p.Split('.');

        if (dizi.Length == 3)
        {
            if (dizi[0].Length == 1)
            { gun = "0" + dizi[0].ToString(); }
            else if (dizi[0].Length == 2)
            { gun = dizi[0].ToString(); }

            if (dizi[1].Length == 1)
            { ay = "0" + dizi[1].ToString(); }
            else if (dizi[1].Length == 2)
            { ay = dizi[1].ToString(); }

            yil = dizi[2].ToString();

            tarih = gun + "." + ay + "." + yil;

            return tarih;
        }
        else
        {
            return "";
        }


    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("3455.aspx?islem=ok");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("3456.aspx?islem=ok");
    }
}