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
                                // islemYukle();
                                doktorYukle();
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
    private void doktorYukle()
    {
        doktor.Items.Clear();

        MySqlConnection mp_connection2 = connect_ivf(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select uye_adi,uye_soyadi,uye_id from uye_doktor where siklusdoktoru='+'", mp_connection2);
        DataTable dt = new DataTable();
        da.Fill(dt);



        for (int a = 0; a < dt.Rows.Count; a++)
        {
            string deger = "";

            if (dt.Rows[a][0].ToString().IndexOf(' ') > 0)
            {
                int snc = dt.Rows[a][0].ToString().LastIndexOf(' ') + 1;
                deger = "" + dt.Rows[a][0].ToString().Substring(snc, 1).ToUpper() + dt.Rows[a][1].ToString().Substring(0, 1).ToUpper();
            }
            else
            {
                deger = "" + dt.Rows[a][0].ToString().Substring(0, 1).ToUpper() + dt.Rows[a][1].ToString().Substring(0, 1).ToUpper();

            }

            ListItem oge = new ListItem();
            oge.Text = deger;
            oge.Value = deger;
            doktor.Items.Add(oge);

        }



        ListItem yeni22 = new ListItem();
        yeni22.Text = "Hepsi";
        yeni22.Value = "";
        doktor.Items.Insert(0, yeni22);

    }

    private void listeYukle()
    {

        string kaynakEkSutun = "";
        string kaynakEkTablo = "";
        string kaynakEkWhere = "";

        if (anaKaynak.SelectedValue != "" && altKaynak.SelectedValue != "")
        {
            kaynakEkTablo = " left join iskaynak K on K.hastaID=H.uye_id ";
            if (anaKaynak.SelectedValue == "3")
            {
                kaynakEkWhere = " K.saglikCalisaniListesi = '" + altKaynak.SelectedValue + "' and ";
            }

            else if (anaKaynak.SelectedValue == "4")
            {
                kaynakEkWhere = " K.medyaListesi = '" + altKaynak.SelectedValue + "' and ";
            }


        }

        else if (anaKaynak.SelectedValue != "")
        {
            kaynakEkTablo = " left join iskaynak K on K.hastaID=H.uye_id ";
            if (anaKaynak.SelectedValue == "3")
            {
                kaynakEkWhere = " K.saglikCalisani = '+' and ";
            }

            else if (anaKaynak.SelectedValue == "4")
            {
                kaynakEkWhere = " K.medya = '+' and ";
            }
        }

        MySqlConnection connect_word = connect_ivf(0301009184);
        string sql = "Select H.uye_id as HID,cast(SUM(CAST(replace(M.odemeUcret,'.','') as UNSIGNED)) as UNSIGNED) as toplam,Concat(H.uye_adi,' ',H.uye_soyadi) as adi,'muhasebe' as tur from iszekasi M left join uye_hasta H on M.hastaID=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";
   


        if (ay.SelectedValue == "")
        {
            sql += " YEAR(str_to_date(M.odemeTarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.odemeDurum='+' and M.odemeUcret <> 0 and";
        }
        else
        {
            sql += " YEAR(str_to_date(M.odemeTarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.odemeTarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.odemeDurum='+' and M.odemeUcret <> 0 and";
        }

        if (doktor.SelectedIndex != 0)
        {
            sql += " M.dr = '" + doktor.SelectedItem.Text + "' and";
        }


        if (kayitTuru.SelectedIndex != 0)
        {
            sql += " M.tip = '" + kayitTuru.SelectedValue + "' and";
        }
        //else
        //{
        //    sql += " M.tur <> '4' and";
        //}

        int say = sql.Length;
        if (sql.Substring(say - 3, 3) == "and")
        {
            sql = sql.Substring(0, say - 3);

        }

        sql += " group by M.hastaID order by Concat(H.uye_adi,' ',H.uye_soyadi) asc";

        MySqlDataAdapter da = new MySqlDataAdapter(sql, connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);





        string sql2 = "Select H.uye_id as HID,CAST(sum((F.fiyat / F.adet) * M.adet) as UNSIGNED) as toplam,Concat(H.uye_adi,' ',H.uye_soyadi) as adi,'malzeme' as tur from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join siklus_ana_tab S on M.siklusID=S.siklus_id left join kisa_siklus T on T.siklus_id = M.siklusID left join uye_hasta H on S.hasta_id=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";

        if (ay.SelectedValue == "")
        {
            sql2 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and";
        }
        else
        {
            sql2 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and";
        }



        if (doktor.SelectedIndex != 0)
        {
            sql2 += " T.dr = 'Dr. " + doktor.SelectedItem.Text + "' and";
        }

        if (kayitTuru.SelectedIndex == 1)
        {
            sql2 += " H.infertilite='+' and";
        }
        else if (kayitTuru.SelectedIndex == 2 || kayitTuru.SelectedIndex == 3)
        {
            sql2 += " (H.gebe='+' or H.erkek='+') and";
        }
        


        int say2 = sql2.Length;
        if (sql2.Substring(say2 - 3, 3) == "and")
        {
            sql2 = sql2.Substring(0, say2 - 3);

        }

        sql2 += " group by H.uye_id order by Concat(H.uye_adi,' ',H.uye_soyadi) asc";


        MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, connect_word);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        //  sarfListesi.DataSource = dt2;
        //  sarfListesi.DataBind();


        string sql3 = "Select H.uye_id as HID,CAST(sum((F.fiyat / F.adet) * M.adet) as UNSIGNED) as toplam,Concat(H.uye_adi,' ',H.uye_soyadi) as adi,'sperm' as tur from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join erkeksperm S on M.spermID=S.ID left join siklus_ana_tab A on S.hastaID=A.hasta_id left join kisa_siklus T on T.siklus_id = A.siklus_id left join uye_hasta H on S.hastaID=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";



        if (ay.SelectedValue == "")
        {
            sql3 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and";
        }
        else
        {
            sql3 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and";
        }



        if (doktor.SelectedIndex != 0)
        {
            sql3 += " T.dr = 'Dr. " + doktor.SelectedItem.Text + "' and";
        }

        int say3 = sql3.Length;
        if (sql3.Substring(say3 - 3, 3) == "and")
        {
            sql3 = sql3.Substring(0, say3 - 3);

        }

        sql3 += " group by H.uye_id order by Concat(H.uye_adi,' ',H.uye_soyadi) asc";


        MySqlDataAdapter da3 = new MySqlDataAdapter(sql3, connect_word);
        DataTable dt3 = new DataTable();
        da3.Fill(dt3);

        //   spermListesi.DataSource = dt3;
        //   spermListesi.DataBind();





        string sql4 = "Select H.uye_id as HID,CAST(sum((F.fiyat / F.adet) * M.adet) as UNSIGNED) as toplam,Concat(H.uye_adi,' ',H.uye_soyadi) as adi,'cryo' as tur from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join erkekcryo S on M.cryoID=S.ID left join siklus_ana_tab A on S.hastaID=A.hasta_id left join kisa_siklus T on T.siklus_id = A.siklus_id left join uye_hasta H on S.hastaID=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";


        if (ay.SelectedValue == "")
        {
            sql4 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and";
        }
        else
        {
            sql4 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and";
        }



        if (doktor.SelectedIndex != 0)
        {
            sql4 += " T.dr = 'Dr. " + doktor.SelectedItem.Text + "' and";
        }

        int say4 = sql4.Length;
        if (sql4.Substring(say4 - 3, 3) == "and")
        {
            sql4 = sql4.Substring(0, say4 - 3);

        }

        sql4 += " group by H.uye_id order by Concat(H.uye_adi,' ',H.uye_soyadi) asc";


        MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, connect_word);
        DataTable dt4 = new DataTable();
        da4.Fill(dt4);

        //  cryoListesi.DataSource = dt4;
        //  cryoListesi.DataBind();



        string sql5 = "Select H.uye_id as HID,CAST(sum(M.deger) as UNSIGNED) as toplam,Concat(H.uye_adi,' ',H.uye_soyadi) as adi,'calisma' as tur from labprotokol M left join siklus_ana_tab A on M.siklusID=A.siklus_id left join kisa_siklus T on T.siklus_id = A.siklus_id left join uye_hasta H on A.hasta_id=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";

        if (ay.SelectedValue == "")
        {
            sql5 += " M.txt79 <>'' and YEAR(str_to_date(M.txt79 ,'%d.%m.%Y')) = " + yil.SelectedValue + " and";
        }
        else
        {
            sql5 += " M.txt79 <>'' and YEAR(str_to_date(M.txt79 ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.txt79 ,'%d.%m.%Y'))=" + ay.SelectedValue + " and";
        }



        if (doktor.SelectedIndex != 0)
        {
            sql5 += " T.dr = 'Dr. " + doktor.SelectedItem.Text + "' and";
        }

        int say5 = sql5.Length;
        if (sql5.Substring(say5 - 3, 3) == "and")
        {
            sql5 = sql5.Substring(0, say5 - 3);
        }

        sql5 += " group by H.uye_id order by Concat(H.uye_adi,' ',H.uye_soyadi) asc";
        MySqlDataAdapter da5 = new MySqlDataAdapter(sql5, connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);



        string sql6 = "Select H.uye_id as HID,CAST(sum(M.deger) as UNSIGNED) as toplam,Concat(H.uye_adi,' ',H.uye_soyadi) as adi,'calismaErkek' as tur from labprotokolerkek M left join uye_hasta H on M.hastaID=H.uye_id where H.erkek='+' and ";

        if (ay.SelectedValue == "")
        {
            sql6 += " M.txt79 <>'' and YEAR(str_to_date(M.txt79 ,'%d.%m.%Y')) = " + yil.SelectedValue + "";
        }
        else
        {
            sql6 += " M.txt79 <>'' and YEAR(str_to_date(M.txt79 ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.txt79 ,'%d.%m.%Y'))=" + ay.SelectedValue + "";
        }

        sql6 += " group by H.uye_id order by Concat(H.uye_adi,' ',H.uye_soyadi) asc";
        MySqlDataAdapter da6 = new MySqlDataAdapter(sql6, connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);




        //calismaListesi.DataSource = dt5;
        // calismaListesi.DataBind();


        
        dt.Merge(dt2);
        dt.Merge(dt3);
        dt.Merge(dt4);
        dt.Merge(dt5);
        dt.Merge(dt6);


        DataRow[] bosOlmayanSatiri = dt.Select("not HID is null", "adi asc");

        DataTable dt10 = dt.Copy();
        dt10.Clear();

        foreach (DataRow yeni in bosOlmayanSatiri)
        {
            dt10.ImportRow(yeni);

        }


        liste.DataSource = dt10;
        liste.DataBind();

        DataTable distinct = dt10.DefaultView.ToTable(true, "HID");

        DataTable sDt = new DataTable();
        DataColumn dc1 = new DataColumn("uyeID");
        DataColumn dc2 = new DataColumn("uyeAdi");
        DataColumn dc3 = new DataColumn("Muhasebe");
        DataColumn dc4 = new DataColumn("Malzeme");
        DataColumn dc5 = new DataColumn("Sperm");
        DataColumn dc6 = new DataColumn("Cryo");
        DataColumn dc7 = new DataColumn("Çalışma");
        DataColumn dc8 = new DataColumn("ÇalışmaErkek");


        sDt.Columns.Add(dc1);
        sDt.Columns.Add(dc2);
        sDt.Columns.Add(dc3);
        sDt.Columns.Add(dc4);
        sDt.Columns.Add(dc5);
        sDt.Columns.Add(dc6);
        sDt.Columns.Add(dc7);
        sDt.Columns.Add(dc8);


        for (int a = 0; a < distinct.Rows.Count; a++)
        {
            DataRow dr = sDt.NewRow();
            dr[0] = distinct.Rows[a][0].ToString(); // uye id yi alıyoruz

            DataRow[] hastaKayitlari = dt10.Select("HID=" + distinct.Rows[a][0].ToString() + "", "");
            DataTable dtfiltreli = dt10.Copy();
            dtfiltreli.Clear();
            foreach (DataRow yeni in hastaKayitlari)
            {
                dtfiltreli.ImportRow(yeni);
            }

            for (int b = 0; b < dtfiltreli.Rows.Count; b++)
            {
                dr[1] = dtfiltreli.Rows[b]["adi"].ToString(); // üye adını alıyoruz

                if (dtfiltreli.Rows[b]["tur"].ToString() == "muhasebe")
                {
                    dr[2] = dtfiltreli.Rows[b]["toplam"].ToString();
                }
                else if (dtfiltreli.Rows[b]["tur"].ToString() == "malzeme")
                {
                    dr[3] = dtfiltreli.Rows[b]["toplam"].ToString();
                }
                else if (dtfiltreli.Rows[b]["tur"].ToString() == "sperm")
                {
                    dr[4] = dtfiltreli.Rows[b]["toplam"].ToString();
                }
                else if (dtfiltreli.Rows[b]["tur"].ToString() == "cryo")
                {
                    dr[5] = dtfiltreli.Rows[b]["toplam"].ToString();
                }
                else if (dtfiltreli.Rows[b]["tur"].ToString() == "calisma")
                {
                    dr[6] = dtfiltreli.Rows[b]["toplam"].ToString();
                }
                else if (dtfiltreli.Rows[b]["tur"].ToString() == "calismaErkek")
                {
                    dr[7] = dtfiltreli.Rows[b]["toplam"].ToString();
                }
            }

            sDt.Rows.Add(dr);
        }



        liste2.DataSource = sDt;
        liste2.DataBind();

        LinkButton lblAdiSoyadi = new LinkButton();
        Label lblFatura = new Label();
        Label lblSiklus = new Label();
        Label lblSperm = new Label();
        Label lblCryo = new Label();
        Label lblCalisma = new Label();
        Label lblCalismaErkek = new Label();



        int m = 0;

        double toplFatura = 0;
        double toplSiklus = 0;
        double toplSperm = 0;
        double toplCryo = 0;
        double toplCalisma = 0;
        double toplCalismaErkek = 0;
        double siklusSayisi = 0;
        foreach (GridViewRow satir in liste2.Rows)
        {

            double hFatura, hSiklus, hSperm, hCryo, hCalisma, hCalismaErkek;
            lblAdiSoyadi = (LinkButton)satir.FindControl("lblAdiSoyadi");
            lblFatura = (Label)satir.FindControl("lblFatura");
            lblSiklus = (Label)satir.FindControl("lblSiklus");
            lblSperm = (Label)satir.FindControl("lblSperm");
            lblCryo = (Label)satir.FindControl("lblCryo");
            lblCalisma = (Label)satir.FindControl("lblCalisma");
            lblCalismaErkek = (Label)satir.FindControl("lblCalismaErkek");

            lblAdiSoyadi.Text = sDt.Rows[m][1].ToString();
            lblAdiSoyadi.OnClientClick = "createWindow('https://flry.ebebaba.com/ivfyonetici/hasta_modulu/th4820ft.aspx?ID=" + sDt.Rows[m][0].ToString() + "','" + sDt.Rows[m][1].ToString() + "','90%','530','');return false;";

            if (sDt.Rows[m][2].ToString() != "")
            {
                double.TryParse(sDt.Rows[m][2].ToString(), out hFatura);

                if (hFatura != 0)
                {
                    lblFatura.Text = hFatura.ToString("C");
                    toplFatura += hFatura;
                }
                else
                {
                    lblFatura.Text = "";
                }
            }

            if (sDt.Rows[m][3].ToString() != "")
            {
                double.TryParse(sDt.Rows[m][3].ToString(), out hSiklus);

                if (hSiklus != 0)
                {
                    siklusSayisi++;
                    lblSiklus.Text = hSiklus.ToString("C");
                    toplSiklus += hSiklus;
                }
                else
                {
                    lblSiklus.Text = "";
                }
            }


            if (sDt.Rows[m][4].ToString() != "")
            {
                double.TryParse(sDt.Rows[m][4].ToString(), out hSperm);

                if (hSperm != 0)
                {
                    lblSperm.Text = hSperm.ToString("C");
                    toplSperm += hSperm;
                }
                else
                {
                    lblSperm.Text = "";
                }
            }


            if (sDt.Rows[m][5].ToString() != "")
            {
                double.TryParse(sDt.Rows[m][5].ToString(), out hCryo);

                if (hCryo != 0)
                {
                    lblCryo.Text = hCryo.ToString("C");
                    toplCryo += hCryo;
                }
                else
                {
                    lblCryo.Text = "";
                }
            }



            if (sDt.Rows[m][6].ToString() != "")
            {
                double.TryParse(sDt.Rows[m][6].ToString(), out hCalisma);

                if (hCalisma != 0)
                {
                    lblCalisma.Text = hCalisma.ToString("C");
                    toplCalisma += hCalisma;
                }
                else
                {
                    lblCalisma.Text = "";
                }
            }



            if (sDt.Rows[m][7].ToString() != "")
            {
                double.TryParse(sDt.Rows[m][7].ToString(), out hCalismaErkek);

                if (hCalismaErkek != 0)
                {
                    lblCalismaErkek.Text = hCalismaErkek.ToString("C");
                    toplCalismaErkek += hCalismaErkek;
                }
                else
                {
                    lblCalismaErkek.Text = "";
                }
            }



            m++;

        }



        sonucFatura.Text = toplFatura.ToString("C");
        sonucSiklus.Text = toplSiklus.ToString("C");
        sonucSperm.Text = toplSperm.ToString("C");
        sonucCryo.Text = toplCryo.ToString("C");
        sonucCalisma.Text = toplCalisma.ToString("C");
        sonucCalismaErkek.Text = toplCalismaErkek.ToString("C");

        double ortalamaSiklus = 0;
        if (siklusSayisi != 0)
        {
            ortalamaSiklus = toplSiklus / siklusSayisi;
        }

        ortSiklus.Text = "Ort: " + ortalamaSiklus.ToString("C");





        double vmpay = 0;
        if (toplFatura != 0)
        {

            if (kayitTuru.SelectedIndex == 1)
            {
                vmpay = toplFatura * 25 / 100;
                yzd.Text = "25";
            }
            else if (kayitTuru.SelectedIndex == 2)
            {
                vmpay = toplFatura * 60 / 100;
                yzd.Text = "60";
            }
            else
            {
                vmpay = 0;
                yzd.Text = "0";
            }
         
       
        
        }
        sonucVM.Text = vmpay.ToString("C");
        double kalan = 0;
        kalan = toplFatura - toplSiklus - toplSperm - toplCryo - toplCalisma - toplCalismaErkek - vmpay;
        sonucKalan.Text = kalan.ToString("C");


        // sarf Listesi detay yükle Florya

        MySqlDataAdapter da9 = new MySqlDataAdapter("Select * from sarfmalzemekategori order by sira asc", connect_word);
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);

        sarfList.DataSource = dt9;
        sarfList.DataBind();

        Label toplamTutar = new Label();
        Label toplamSiklus = new Label();
        Label ortalama = new Label();
        Label toplamTutarIVF = new Label();
        Label toplamSiklusIVF = new Label();
        Label ortalamaIVF = new Label();


        int y = 0;
        foreach (GridViewRow str in sarfList.Rows)
        {
            toplamTutar = (Label)str.FindControl("toplamTutar");
            toplamSiklus = (Label)str.FindControl("toplamSiklus");
            ortalama = (Label)str.FindControl("ortalama");

            toplamTutarIVF = (Label)str.FindControl("toplamTutarIVF");
            toplamSiklusIVF = (Label)str.FindControl("toplamSiklusIVF");
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
            }
            else
            {
                toplamSiklus.Text = "-";
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
            }
            else
            {
                toplamSiklusIVF.Text = "-";
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



            //ttutar = double.Parse();
            //tsiklus = double.Parse(dt9.Rows[y][3].ToString());

            //toplamTutar.Text = ttutar.ToString("C");
            //toplamSiklus.Text = dt9.Rows[y][3].ToString();


            //if (dt9.Rows[y][3].ToString() != "" && dt9.Rows[y][3].ToString() != "0")
            //{

            //    tortalama = ttutar / tsiklus;


            //}



            //ortalama.Text = tortalama.ToString("C");


            //if ((kayitTuru.SelectedIndex == 0 || kayitTuru.SelectedIndex == 1) && doktor.SelectedIndex == 0 && anaKaynak.SelectedIndex == 0)
            //{
            //    string gelen = ivfdenToplamTutarAl(dt9.Rows[y][0].ToString());
            //    string gelenSiklus = ivfdenToplamSiklusAl(dt9.Rows[y][0].ToString());


            //    if (gelen != "")
            //    {
            //         = double.Parse(gelen);
            //        toplamTutarIVF.Text = tTutarIVF.ToString("C");
            //    }

            //    if (gelenSiklus != "")
            //    {
            //         = double.Parse(gelenSiklus);
            //        toplamSiklusIVF.Text = tSiklusIVF.ToString();
            //    }
            //    else
            //    {
            //        toplamSiklusIVF.Text = "0";
            //    }



            //    if (gelen != "" && gelenSiklus != "" && gelen != "0" && gelenSiklus != "0")
            //    {

            //        tortalamaIVF = double.Parse(gelen) / double.Parse(gelenSiklus);
            //        ortalamaIVF.Text = tortalamaIVF.ToString("C");

            //    }







            //}


            //y++;

        }


    private string ivfToplamSiklusAl(string p)
    {
        if (doktor.SelectedIndex == 0 && anaKaynak.SelectedIndex == 0 && (kayitTuru.SelectedIndex == 0 || kayitTuru.SelectedIndex == 1))
        {

            string sql9 = "Select count(distinct(M.siklusID)) as sayi from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID where ";

            if (ay.SelectedValue == "")
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null";
            }
            else
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null";
            }

            MySqlConnection connect_word = connect_ivf2(0301009184);
            MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);

            return dt9.Rows[0][0].ToString();

        }
        else
        {

            return "0";
        }
       
     


    }

    private string ivfToplamTutarAl(string p)
    {
        if (doktor.SelectedIndex == 0 && anaKaynak.SelectedIndex == 0 && (kayitTuru.SelectedIndex == 0 || kayitTuru.SelectedIndex == 1))
        {

            string sql9 = "Select CAST(sum((F.fiyat / F.adet) * M.adet) as UNSIGNED) as toplam from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID where ";

            if (ay.SelectedValue == "")
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null";
            }
            else
            {
                sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null";
            }

            MySqlConnection connect_word = connect_ivf2(0301009184);
            MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
            DataTable dt9 = new DataTable();
            da9.Fill(dt9);

            return dt9.Rows[0][0].ToString();

        }
        else
        {

            return "0";
        }
       
     


    }

    private string flryToplamSiklusAl(string p)
    {
        string kaynakEkSutun = "";
        string kaynakEkTablo = "";
        string kaynakEkWhere = "";

        if (anaKaynak.SelectedValue != "" && altKaynak.SelectedValue != "")
        {
            kaynakEkTablo = " left join iskaynak K on K.hastaID=H.uye_id ";
            if (anaKaynak.SelectedValue == "3")
            {
                kaynakEkWhere = " K.saglikCalisaniListesi = '" + altKaynak.SelectedValue + "' and ";
            }

            else if (anaKaynak.SelectedValue == "4")
            {
                kaynakEkWhere = " K.medyaListesi = '" + altKaynak.SelectedValue + "' and ";
            }


        }
        else if (anaKaynak.SelectedValue != "")
        {
            kaynakEkTablo = " left join iskaynak K on K.hastaID=H.uye_id ";
            if (anaKaynak.SelectedValue == "3")
            {
                kaynakEkWhere = " K.saglikCalisani = '+' and ";
            }

            else if (anaKaynak.SelectedValue == "4")
            {
                kaynakEkWhere = " K.medya = '+' and ";
            }
        }

        string sql9 = "Select count(distinct(M.siklusID)) as sayi from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join siklus_ana_tab S on M.siklusID=S.siklus_id left join kisa_siklus T on T.siklus_id = M.siklusID left join uye_hasta H on S.hasta_id=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";

        if (ay.SelectedValue == "")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null and";
        }
        else
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null and";
        }



        if (doktor.SelectedIndex != 0)
        {
            sql9 += " T.dr = 'Dr. " + doktor.SelectedItem.Text + "' and";
        }

        if (kayitTuru.SelectedIndex == 1)
        {
            sql9 += " H.infertilite='+' and";
        }
        else if (kayitTuru.SelectedIndex == 2 || kayitTuru.SelectedIndex == 3)
        {
            sql9 += " (H.gebe='+' or H.erkek='+') and";
        }


        int say9 = sql9.Length;
        if (sql9.Substring(say9 - 3, 3) == "and")
        {
            sql9 = sql9.Substring(0, say9 - 3);

        }


        MySqlConnection connect_word = connect_ivf(0301009184);
        MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);

        return dt9.Rows[0][0].ToString();





    }

    private string flryToplamTutarAl(string p)
    {

        string kaynakEkSutun = "";
        string kaynakEkTablo = "";
        string kaynakEkWhere = "";

        if (anaKaynak.SelectedValue != "" && altKaynak.SelectedValue != "")
        {
            kaynakEkTablo = " left join iskaynak K on K.hastaID=H.uye_id ";
            if (anaKaynak.SelectedValue == "3")
            {
                kaynakEkWhere = " K.saglikCalisaniListesi = '" + altKaynak.SelectedValue + "' and ";
            }

            else if (anaKaynak.SelectedValue == "4")
            {
                kaynakEkWhere = " K.medyaListesi = '" + altKaynak.SelectedValue + "' and ";
            }


        }
        else if (anaKaynak.SelectedValue != "")
        {
            kaynakEkTablo = " left join iskaynak K on K.hastaID=H.uye_id ";
            if (anaKaynak.SelectedValue == "3")
            {
                kaynakEkWhere = " K.saglikCalisani = '+' and ";
            }

            else if (anaKaynak.SelectedValue == "4")
            {
                kaynakEkWhere = " K.medya = '+' and ";
            }
        }

        string sql9 = "Select CAST(sum((F.fiyat / F.adet) * M.adet) as UNSIGNED) as toplam from sarfmalzemekullanilan M left join sarfmalzeme F on M.malzemeID = F.ID left join siklus_ana_tab S on M.siklusID=S.siklus_id left join kisa_siklus T on T.siklus_id = M.siklusID left join uye_hasta H on S.hasta_id=H.uye_id " + kaynakEkTablo + " where " + kaynakEkWhere + "";

        if (ay.SelectedValue == "")
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null and";
        }
        else
        {
            sql9 += " YEAR(str_to_date(M.tarih ,'%d.%m.%Y')) = " + yil.SelectedValue + " and MONTH(str_to_date(M.tarih ,'%d.%m.%Y'))=" + ay.SelectedValue + " and M.adet <> '0' and M.kategoriID=" + p + " and M.cryoID is null and spermID is null and";
        }



        if (doktor.SelectedIndex != 0)
        {
            sql9 += " T.dr = 'Dr. " + doktor.SelectedItem.Text + "' and";
        }

        if (kayitTuru.SelectedIndex == 1)
        {
            sql9 += " H.infertilite='+' and";
        }
        else if (kayitTuru.SelectedIndex == 2 || kayitTuru.SelectedIndex == 3)
        {
            sql9 += " (H.gebe='+' or H.erkek='+') and";
        }


        int say9 = sql9.Length;
        if (sql9.Substring(say9 - 3, 3) == "and")
        {
            sql9 = sql9.Substring(0, say9 - 3);

        }


        MySqlConnection connect_word = connect_ivf(0301009184);
        MySqlDataAdapter da9 = new MySqlDataAdapter(sql9, connect_word);
        DataTable dt9 = new DataTable();
        da9.Fill(dt9);

        return dt9.Rows[0][0].ToString();





    }

    
    private void islemYukle()
    {
        string sql1 = "Select * from muhasebeinfertilite order by sira asc";
        string sql2 = "Select * from muhasebemuayene order by sira asc";
        string sql3 = "Select * from muhasebediger order by sira asc";
        string sql4 = "Select * from muhasebesgk order by sira asc";

        MySqlConnection connect_word = connect_ivf(0301009184);

        MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, connect_word);
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);

        MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, connect_word);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

        MySqlDataAdapter da3 = new MySqlDataAdapter(sql3, connect_word);
        DataTable dt3 = new DataTable();
        da3.Fill(dt3);

        MySqlDataAdapter da4 = new MySqlDataAdapter(sql4, connect_word);
        DataTable dt4 = new DataTable();
        da4.Fill(dt4);

        ListItem yeni = new ListItem();
        yeni.Text = "---> Tüp Bebek <---";
        yeni.Value = "";
        islem.Items.Add(yeni);

        for (int a = 0; a < dt1.Rows.Count; a++)
        {
            ListItem yeni1 = new ListItem();
            yeni1.Text = dt1.Rows[a]["Adi"].ToString();
            yeni1.Value = "1-" + dt1.Rows[a]["ID"].ToString();
            islem.Items.Add(yeni1);
        }
        ListItem yeni2 = new ListItem();
        yeni2.Text = "---> Tüp Bebek Dışı <---";
        yeni2.Value = "";
        islem.Items.Add(yeni2);

        for (int a = 0; a < dt2.Rows.Count; a++)
        {
            ListItem yeni3 = new ListItem();
            yeni3.Text = dt2.Rows[a]["Adi"].ToString();
            yeni3.Value = "2-" + dt2.Rows[a]["ID"].ToString();
            islem.Items.Add(yeni3);
        }

        ListItem yeni5 = new ListItem();
        yeni5.Text = "---> Diğer <---";
        yeni5.Value = "";
        islem.Items.Add(yeni5);

        for (int a = 0; a < dt3.Rows.Count; a++)
        {
            ListItem yeni6 = new ListItem();
            yeni6.Text = dt3.Rows[a]["Adi"].ToString();
            yeni6.Value = "3-" + dt3.Rows[a]["ID"].ToString();
            islem.Items.Add(yeni6);
        }


        ListItem yeni555 = new ListItem();
        yeni555.Text = "---> Kurum Ödemeleri <---";
        yeni555.Value = "";
        islem.Items.Add(yeni555);

        for (int a = 0; a < dt4.Rows.Count; a++)
        {
            ListItem yeni666 = new ListItem();
            yeni666.Text = dt4.Rows[a]["Adi"].ToString();
            yeni666.Value = "4-" + dt4.Rows[a]["ID"].ToString();
            islem.Items.Add(yeni666);
        }

        for (int a = 0; a < dt4.Rows.Count; a++)
        {
            ListItem yeni666 = new ListItem();
            yeni666.Text = dt4.Rows[a]["kisaAd"].ToString();
            yeni666.Value = "5-" + dt4.Rows[a]["ID"].ToString();
            islem.Items.Add(yeni666);
        }

        ListItem yeni4 = new ListItem();
        yeni4.Text = "Seçiniz";
        yeni4.Value = "";
        islem.Items.Insert(0, yeni4);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        listeYukle();
        Panel2.Visible = true;
        sarfDetayYukle();

    }

    private void sarfDetayYukle()
    {
        
    }
    protected void anaKaynak_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (anaKaynak.SelectedValue == "3")
        {

            saglikCalisaniYukle();

        }
        else if (anaKaynak.SelectedValue == "4")
        {

            medyaYukle();

        }
        else
        {

            altKaynak.Items.Clear();
            ListItem oge = new ListItem();
            oge.Value = "";
            oge.Text = "Hepsi";

            altKaynak.Items.Insert(0, oge);

        }
    }

    private void saglikCalisaniYukle()
    {

        altKaynak.Items.Clear();

        MySqlConnection connect_word = connect_ivf(0301009184);
        MySqlDataAdapter da5 = new MySqlDataAdapter("Select distinct UPPER(U.adi) as adi,U.ID from saglikCalisani U,iskaynak K where U.ID=K.saglikCalisaniListesi and K.saglikCalisaniListesi <>'' order by U.adi asc", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        altKaynak.DataSource = dt5;
        altKaynak.DataTextField = dt5.Columns["adi"].ToString();
        altKaynak.DataValueField = dt5.Columns["ID"].ToString();
        altKaynak.DataBind();

        ListItem oge = new ListItem();
        oge.Value = "";
        oge.Text = "Hepsi";

        altKaynak.Items.Insert(0, oge);

    }

    private void medyaYukle()
    {

        altKaynak.Items.Clear();

        MySqlConnection connect_word = connect_ivf(0301009184);
        MySqlDataAdapter da5 = new MySqlDataAdapter("Select distinct UPPER(U.adi) as adi,U.ID  from kaynak U,iskaynak K where U.ID = K.medyaListesi and K.medyaListesi <>'' order by U.adi asc", connect_word);
        DataTable dt5 = new DataTable();
        da5.Fill(dt5);

        altKaynak.DataSource = dt5;
        altKaynak.DataTextField = dt5.Columns["adi"].ToString();
        altKaynak.DataValueField = dt5.Columns["ID"].ToString();
        altKaynak.DataBind();

        ListItem oge = new ListItem();
        oge.Value = "";
        oge.Text = "Hepsi";

        altKaynak.Items.Insert(0, oge);

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/administrator_ebebaba_pages/Default.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("5534.aspx");
    }

    public MySqlConnection connect_ivf(int coming)
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

    public MySqlConnection connect_ivf2(int coming)
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
        Response.Redirect("3456.aspx?islem=ok");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("3457.aspx?islem=ok");
    }
}