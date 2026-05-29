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

public partial class ivfyonetici_opurandevu : System.Web.UI.Page
{
    ivf_class mp_class = new ivf_class();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {          
            sikluslariyukle();
            //hastalariyukle();
        }
    }

    private void sikluslariyukle()
    {

        HttpCookie islemdekihasta = Request.Cookies["HastaBilgi"];
        String hasta_id = islemdekihasta["HastaID"];

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from heyetraporsonuclari H ,kisa_siklus S where H.hastaID = "+hasta_id+" and S.siklus_id = H.siklus_id and H.transfer is null and H.tedavisurecinde ='+'", mp_connection);
        DataTable mp_dt = new DataTable();
        mp_da.Fill(mp_dt);

        listopu.DataSource = mp_dt;
        listopu.DataBind();
        

        
        int i = 0;
                foreach (GridViewRow str in listopu.Rows)
                {

                    Label raporid = new Label();
                    raporid = (Label)str.FindControl("raporID");
                    raporid.Text = mp_dt.Rows[i]["raporID"].ToString();
                    
                    Label tarih = new Label();
                    tarih = (Label)str.FindControl("tarih0");
                    tarih.Text = tarih_bul(mp_dt.Rows[i]["heyetID"].ToString());

                    Label sat = new Label();
                    sat = (Label)str.FindControl("sat");
                    sat.Text = " / " + mp_dt.Rows[i]["sat"].ToString();

                    Label siklus = new Label();
                    siklus = (Label)str.FindControl("siklus");
                    siklus.Text = siklus_adi_bul(mp_dt.Rows[i]["siklus_id"].ToString());
                    

                    
                    
                    i++;
                }

            
        ////baslik.Text = "Siklusun " + birlestir + ". Gününde Olanlar";
        
        ////try
        //    //{
            

        //    //sayi.Text = mp_dt.Rows.Count.ToString();


        
        
        
        




        
        
        //int i = 0;





        //    foreach (GridViewRow str in listopu.Rows)
        //    {

        //        LinkButton ad = new LinkButton();
        //        ad = (LinkButton)str.FindControl("hastaAdi0");
        //        ad.Text = mp_class.hasta_adi_bul(mp_dt.Rows[i]["hastaID"].ToString());
        //        ad.CommandArgument = mp_dt.Rows[i]["hastaID"].ToString();
        //        ad.OnClientClick = "window.open('hasta_modulu/arasayfa.aspx?id=" + mp_dt.Rows[i]["hastaID"].ToString() + "','','location=1,status=0,scrollbars=1,width=1000,height=750');";


        //        Label tarih = new Label();
        //        tarih = (Label)str.FindControl("tarih0");
        //        tarih.Text = tarih_bul(mp_dt.Rows[i]["heyetID"].ToString());

        //        Label ID = new Label();
        //        ID = (Label)str.FindControl("hastaIDSatir");
        //        ID.Text = mp_dt.Rows[i]["hastaID"].ToString();

                
        //        //RequiredFieldValidator kontrol = new RequiredFieldValidator();
        //        //kontrol = (RequiredFieldValidator)str.FindControl("kontrol2");
        //        //kontrol.ValidationGroup = "kontrolet2" + i.ToString();

        //        //ImageButton onayla = new ImageButton();
        //        //onayla = (ImageButton)str.FindControl("btnOnayla2");
        //        //onayla.CommandArgument = mp_dt.Rows[i]["raporID"].ToString();
        //        //onayla.CommandName = i.ToString();
        //        //onayla.ValidationGroup = "kontrolet2" + i.ToString();


        //        //ImageButton evet = new ImageButton();
        //        //evet = (ImageButton)str.FindControl("evet");
        //        //evet.CommandArgument = mp_dt.Rows[i]["raporID"].ToString();
        //        //evet.CommandName = mp_dt.Rows[i]["hastaID"].ToString(); 


        //        //LinkButton iptal = new LinkButton();
        //        //iptal = (LinkButton)str.FindControl("iptal");
        //        //iptal.CommandArgument = mp_dt.Rows[i]["raporID"].ToString();
        //        //iptal.CommandName = mp_dt.Rows[i]["hastaID"].ToString(); 

        //        //DropDownList drptarih2 = new DropDownList();
        //        //drptarih2 = (DropDownList)str.FindControl("drptarih2");

        //        //Label durum = new Label();
        //        //durum = (Label)str.FindControl("durum");
                

                
                //if (mp_dt.Rows[i]["tedaviiptal"].ToString() == "+")
                //{
                //    durum.Text = "Tedavi iptal edildi.";
                //    durum.ForeColor = System.Drawing.Color.Red;
                   
                //    str.Cells[1].Enabled = false;
                //    str.Cells[2].Enabled = false;
                //    str.Cells[3].Enabled = false;
                //    str.Cells[4].Enabled = false;
                


                //}
                //else if (mp_dt.Rows[i]["tedavisurecinde"].ToString() == "+")
                //{
                    
                //    durum.Text = "Tedavi sürecinde.";
                //    durum.ForeColor = System.Drawing.Color.Green;
                    
                //    str.Cells[1].Enabled = false;
                //    str.Cells[2].Enabled = false;
                //    str.Cells[3].Enabled = false;
                //    str.Cells[4].Enabled = false;
                //}
                //else
                //{
                //    str.Enabled = true;
                //    durum.Text = "Tedavi henüz baþlamadý.";
                //    durum.ForeColor = System.Drawing.Color.Black;
                //}



                //int baslangicy = DateTime.Now.Date.Day / 7;
                //int haftay = 0;
                //if (baslangicy == 0)
                //{
                //    haftay = 1;
                //}
                //else if (baslangicy == 1)
                //{
                //    haftay = 2;
                //}
                //else if (baslangicy == 2)
                //{
                //    haftay = 3;
                //}
                //else
                //{
                //    haftay = 4;
                //}
                //int ayy = DateTime.Now.Date.Month;

                //int yily = DateTime.Now.Date.Year;

                //ListItem sec = new ListItem();
                //sec.Text = "Seçiniz";
                //sec.Value = "";
                //drptarih2.Items.Add(sec);

                //for (int k = haftay; k < 5; k++)
                //{
                //    ListItem oge = new ListItem();
                //    oge.Text = mp_class.ayadi(ayy) + "-" + yily.ToString() + " / " + k.ToString() + ".Hafta";
                //    oge.Value = k.ToString() + "," + ayy.ToString() + "," + yily.ToString();
                //    drptarih2.Items.Add(oge);
                //}

                //int ay2y = DateTime.Now.Date.Month;
                //int yil2y = DateTime.Now.Date.Year;

                //for (int m = 1; m < 4; m++)
                //{
                //    ay2y = DateTime.Now.Date.AddMonths(m).Month;
                //    yil2y = DateTime.Now.Date.AddMonths(m).Year;

                //    for (int s = 1; s < 5; s++)
                //    {
                //        ListItem oge2 = new ListItem();

                //        oge2.Text = mp_class.ayadi(ay2y) + "-" + yil2y.ToString() + " / " + s.ToString() + ".Hafta";
                //        oge2.Value = s.ToString() + "," + ay2y.ToString() + "," + yil2y.ToString();
                //        drptarih2.Items.Add(oge2);
                //    }



                //}

                //drptarih2.Items.Remove(drptarih2.Items.FindByValue(birlestir));



            //    i++;
            //}
            ////}

            //catch
            //{

            //}

        }

    private string siklus_adi_bul(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);

        MySqlDataAdapter da = new MySqlDataAdapter("Select * from siklus_ana_tab where siklus_id="+p.ToString()+"", mp_connection);

        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt.Rows[0]["siklus_ay"].ToString() + " - " + dt.Rows[0]["siklus_yil"].ToString();
    }


    //private void hastalariyukle()
    //{

    //    //try
    //    //{
    //        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
    //        MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from heyetraporsonuclari H,uye_hasta U where H.hastaID = U.uye_id and H.tibbiraporverildimi = '+' and H.ay is null and H.yil is null and H.hafta is null and H.tedaviomudisindanerede is null order by concat(U.uye_adi,' ',U.uye_soyadi) asc", mp_connection);


    //        DataTable mp_dt = new DataTable();
    //        mp_da.Fill(mp_dt);

    //        list1.DataSource = mp_dt;
    //        list1.DataBind();
    //        Label111.Text = mp_dt.Rows.Count.ToString();
    //        int i = 0;

    //        foreach (GridViewRow str in list1.Rows)
    //        {

    //            LinkButton ad = new LinkButton();
    //            ad = (LinkButton)str.FindControl("hastaAdi0");
    //            ad.Text = mp_class.hasta_adi_bul(mp_dt.Rows[i]["hastaID"].ToString());
    //            ad.CommandArgument = mp_dt.Rows[i]["hastaID"].ToString();
    //            ad.OnClientClick = "window.open('hasta_modulu/arasayfa.aspx?id=" + mp_dt.Rows[i]["hastaID"].ToString() + "','','location=1,status=0,scrollbars=1,width=1000,height=750');";



    //            Label tarih = new Label();
    //            tarih = (Label)str.FindControl("tarih0");
    //            tarih.Text = tarih_bul(mp_dt.Rows[i]["heyetID"].ToString());

    //            Label ID = new Label();
    //            ID = (Label)str.FindControl("hastaIDSatir");
    //            ID.Text = mp_dt.Rows[i]["hastaID"].ToString();

    //            RadioButtonList yer = new RadioButtonList();
    //            yer = (RadioButtonList)str.FindControl("yer");
    //            yer.Items[0].Value = "+" + i.ToString();
    //            yer.Items[1].Value = "-" + i.ToString();

    //            RequiredFieldValidator kontrol = new RequiredFieldValidator();
    //            kontrol = (RequiredFieldValidator)str.FindControl("kontrol");
    //            kontrol.ValidationGroup = "kontrolet" + i.ToString(); 

    //            ImageButton onayla = new ImageButton();
    //            onayla = (ImageButton)str.FindControl("btnOnayla");
    //            onayla.CommandArgument = mp_dt.Rows[i]["raporID"].ToString();
    //            onayla.CommandName = i.ToString();
    //            onayla.ValidationGroup = "kontrolet" + i.ToString();



    //            DropDownList drptarih = new DropDownList();
    //            drptarih = (DropDownList)str.FindControl("drptarih");
                               
    //            int baslangic = DateTime.Now.Date.Day / 7;
    //            int hafta = 0;
    //            if (baslangic == 0)
    //            {
    //                hafta = 1;
    //            }
    //            else if (baslangic == 1)
    //            {
    //                hafta = 2;
    //            }
    //            else if (baslangic == 2)
    //            {
    //                hafta = 3;
    //            }
    //            else
    //            {
    //                hafta = 4;
    //            }
    //            int ay = DateTime.Now.Date.Month;
                
    //            int yil = DateTime.Now.Date.Year;

    //            ListItem sec = new ListItem();
    //            sec.Text = "Seçiniz";
    //            sec.Value = null;
    //            drptarih.Items.Add(sec);

    //            for (int k = hafta; k < 5; k++)
    //            {
    //                ListItem oge = new ListItem();
    //                oge.Text = mp_class.ayadi(ay) + "-" + yil.ToString() + " / " + k.ToString() + ".Hafta";
    //                oge.Value = k.ToString() + "," + ay.ToString() + "," + yil.ToString();
    //                drptarih.Items.Add(oge);                   
    //            }

    //            int ay2 = DateTime.Now.Date.Month;
    //            int yil2 = DateTime.Now.Date.Year;

    //            for (int m = 1; m < 4; m++)
    //            {
    //                ay2 = DateTime.Now.Date.AddMonths(m).Month;
    //                yil2 = DateTime.Now.Date.AddMonths(m).Year;
                   
    //                for (int s = 1; s < 5; s++)
    //                {
    //                    ListItem oge2 = new ListItem();

    //                    oge2.Text = mp_class.ayadi(ay2) + "-" + yil2.ToString() + " / " + s.ToString() + ".Hafta";
    //                    oge2.Value = s.ToString() + "," + ay2.ToString() + "," + yil2.ToString();
    //                    drptarih.Items.Add(oge2);   
    //                }

                   

    //            }


    //            i++;
    //        }
    //    //}
           
    //    //catch
    //    //{

    //    //}

    //}


    private string tarih_bul(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from heyettarihleri where ID=" + p + "", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["tarih"].ToString();
    }


    private string resmikontrol(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from resmi_rapor where ID=" + p + "", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["Adi"].ToString();
    }

    private string tibbikontrol(string p)
    {
        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter mp_da2 = new MySqlDataAdapter("select * from tibbi_rapor where ID="+p+"", mp_connection);
        DataTable mp_dt2 = new DataTable();
        mp_da2.Fill(mp_dt2);

        return mp_dt2.Rows[0]["Adi"].ToString();

    }

    //protected void heyettarihleri_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    if (heyettarihleri.SelectedIndex !=0)
    //    {
           
    //           hastalariyukle();
               
    //    }
    //}
    protected void hastaAdi_Command(object sender, CommandEventArgs e)
    {

    }
    //protected void btnOnayla_Command(object sender, CommandEventArgs e)
    //{
    //    int raporID = int.Parse(e.CommandArgument.ToString());
    //    int satir = int.Parse(e.CommandName.ToString());
        
    //    Label hastaID = new Label();
    //    hastaID = (Label)list1.Rows[satir].FindControl("hastaIDSatir");

    //    RadioButtonList yer = new RadioButtonList();
    //    yer = (RadioButtonList)list1.Rows[satir].FindControl("yer");

    //    TextBox txtyer = new TextBox();
    //    txtyer = (TextBox)list1.Rows[satir].FindControl("txtyer");

    //    ImageButton onayla = new ImageButton();
    //    onayla = (ImageButton)list1.Rows[satir].FindControl("btnOnayla");
       
    //    DropDownList drptarih = new DropDownList();
    //    drptarih = (DropDownList)list1.Rows[satir].FindControl("drptarih");

            
    //    string tedaviomudemi = null;
    //    string hafta = null;
    //    string ay = null;
    //    string yil = null;
    //    string tedavidisardanerede = null;
    //    string sonuc = string.Empty;

    //    if (yer.SelectedIndex == 0)
    //    {
    //        tedaviomudemi = "+";
    //        sonuc = "tedavisinin OMÜTB ' de yapýlacaðý onaylandý.";
    //        if (drptarih.SelectedIndex != 0)
    //        {

    //            string tarih = drptarih.SelectedValue.ToString();
    //            string[] tarihim = tarih.ToString().Split(',');
    //            string hafta2 = tarihim[0].ToString();
    //            string ay2 = tarihim[1].ToString();
    //            string yil2 = tarihim[2].ToString();

    //            hafta = hafta2;
    //            ay = ay2;
    //            yil = yil2;

    //            sonuc = "tedavisinin OMÜTB ' de hangi tarihte yapýlacaðý belirtildi.";
    //        }
    //    }
    //    else
    //    {
    //        sonuc = "tedavisinin OMÜTB dýþýnda yapýlacaðý belirtildi.";


    //        tedaviomudemi = "-";
    //        if (txtyer.Text == "")
    //        {
    //            tedavidisardanerede = "-";
    //        }
    //        else
    //        {
    //            tedavidisardanerede = txtyer.Text;
    //        }


    //    }
        
        
        
        
        
        
    //    MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
    //    MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set tedaviomudemi=?1,ay=?2,yil=?3,hafta=?4,tedaviomudisindanerede=?5,tedavitarihiverilistarihi=?6 where raporID=" + raporID.ToString() + "", mp_connection);


    //    cmd.Parameters.AddWithValue("?1", tedaviomudemi);
    //    cmd.Parameters.AddWithValue("?2", ay);
    //    cmd.Parameters.AddWithValue("?3", yil);
    //    cmd.Parameters.AddWithValue("?4", hafta);
    //    cmd.Parameters.AddWithValue("?5", tedavidisardanerede);
    //    cmd.Parameters.AddWithValue("?6", DateTime.Now.ToShortDateString());

    //    mp_connection.Open();
    //    int eks = cmd.ExecuteNonQuery();
    //    mp_connection.Close();

    //    if (eks == 1)
    //    {
    //        panel_sonuc.Visible = true;
    //        sonuc2.Text = "Ýþlem baþarýyla gerçekleþtirildi.";
    //        sonuc2.ForeColor = System.Drawing.Color.Green;
            
    //        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
    //        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
    //        string islem = mp_class.hasta_adi_bul(hastaID.Text) + " adlý hastanýn "+ sonuc.ToString();
            
    //        mp_class.log_kaydet(kullaniciAdiAdmin, islem);
    //        hastalariyukle();
    //        yukle(sonuc.Text);

    //    }
    //    else
    //    {
    //        panel_sonuc.Visible = true;
    //        sonuc2.Text = "Ýþlem Baþarýsýz !";
    //        sonuc2.ForeColor = System.Drawing.Color.Red;
    //    }
    //}


    //protected void raporyazildimi_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    DropDownList rpryazildimi = (DropDownList)sender;

    //    string satir = rpryazildimi.Items[0].Value.Substring(1, rpryazildimi.Items[0].Value.Length - 1);
    //    Label tedavinerede = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lbltedavinerede");
    //    DropDownList tedavilist = (DropDownList)list1.Rows[int.Parse(satir.ToString())].FindControl("tedavilistesi");
    //    tedavilist.Items[1].Value = "1" + satir.ToString();
    //    tedavilist.Items[2].Value = "2" + satir.ToString();

    //    Label tedaviyeri = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lbltedaviyeri");
    //    TextBox tedaviyeritxt = (TextBox)list1.Rows[int.Parse(satir.ToString())].FindControl("txttedaviyeri");
    //    Label tedavitarih = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lbltedavitarihi");
    //    DropDownList ay = (DropDownList)list1.Rows[int.Parse(satir.ToString())].FindControl("ay");
    //    DropDownList yil = (DropDownList)list1.Rows[int.Parse(satir.ToString())].FindControl("yil");
    //    ImageButton onayla = (ImageButton)list1.Rows[int.Parse(satir.ToString())].FindControl("btnOnayla");


    //    if (rpryazildimi.SelectedIndex == 0)
    //    {
    //        tedavinerede.Visible = true;
    //        tedavilist.Visible = true;
    //        onayla.Visible = true;
    //    }
    //    else
    //    {

    //        onayla.Visible = false;
    //        tedavinerede.Visible = false;
            
    //        tedavilist.Visible = false;
    //        tedavilist.SelectedIndex = 0;
    //        tedavinerede.Visible = false;
    //        tedaviyeritxt.Visible = false;
    //        tedavitarih.Visible = false;
    //        ay.Visible = false;
    //        ay.SelectedIndex = 0;
    //        yil.SelectedIndex = 0;
    //        yil.Visible = false;
    //        tedaviyeritxt.Text = "";

    //    }




    //}
    //protected void tedavilistesi_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    DropDownList  = (DropDownList)sender;

    //    string satir = liste.Items[0].Value.Substring(1, liste.Items[0].Value.Length - 1);
        
    //    Label lblyer = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lblyer");
    //    TextBox txtyer = (TextBox)list1.Rows[int.Parse(satir.ToString())].FindControl("txtyer");
    //    Label lbltarih = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lbltarih");
    //    DropDownList drptarih = (DropDownList)list1.Rows[int.Parse(satir.ToString())].FindControl("drptarih");
        

    //    if (liste.SelectedIndex == 1)
    //    {
    //        tedaviyeri.Visible = false;
    //        tedaviyeritxt.Visible = false;
    //        tedavitarih.Visible = true;
    //        ay.Visible = true;
    //        yil.Visible = true;
            
    //    }
    //    else if (liste.SelectedIndex == 2)
    //    {
    //        tedaviyeri.Visible = true;
    //        tedaviyeritxt.Visible = true;
    //        tedavitarih.Visible = false;
    //        ay.Visible = false;
    //        yil.Visible = false;

    //    }

    //    else
    //    {
    //        tedaviyeri.Visible = false;
    //        tedaviyeritxt.Visible = false;
    //        tedavitarih.Visible = false;
    //        ay.Visible = false;
    //        yil.Visible = false;
    //        ay.SelectedIndex = 0;
    //        yil.SelectedIndex = 0;
    //        tedaviyeritxt.Text = "";
            
    //    }





    //}
    //protected void yer_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //    RadioButtonList yer = (RadioButtonList)sender;

    //    string satir = yer.Items[0].Value.Substring(1, yer.Items[0].Value.Length - 1);

    //    Label lblyer = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lblyer");
    //    TextBox txtyer = (TextBox)list1.Rows[int.Parse(satir.ToString())].FindControl("txtyer");
    //    Label lbltarih = (Label)list1.Rows[int.Parse(satir.ToString())].FindControl("lbltarih");
    //    DropDownList drptarih = (DropDownList)list1.Rows[int.Parse(satir.ToString())].FindControl("drptarih");


    //    if (yer.SelectedIndex == 0)
    //    {
    //        lbltarih.Visible = true;
    //        drptarih.Visible = true;
    //        lblyer.Visible = false;
    //        txtyer.Visible = false;
     
    //    }
    //    else
    //    {
    //        lbltarih.Visible = false;
    //        drptarih.Visible = false;
    //        lblyer.Visible = true;
    //        txtyer.Visible = true;
    //    }



    //}


    protected void btnOnayla_Command2(object sender, CommandEventArgs e)
    {



    }
 
    protected void iptal_Command(object sender, CommandEventArgs e)
    {

        string ID = e.CommandArgument.ToString();
        string hastaID = e.CommandName.ToString();

        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set tedaviiptal = '+',tedaviiptaltarihi = '"+DateTime.Now.ToShortDateString()+"' where raporID=" + ID.ToString() + "", mp_connection);
                
        mp_connection.Open();
        int eks = cmd.ExecuteNonQuery();
        mp_connection.Close();

        if (eks == 1)
        {
            panel_sonuc2.Visible = true;
            sonuc22.Text = "Ýþlem baþarýyla gerçekleþtirildi.";
            sonuc22.ForeColor = System.Drawing.Color.Green;

            HttpCookie mpKullanilan = Request.Cookies["AdminK"];
            string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
            string islem = mp_class.hasta_adi_bul(hastaID) + " adlý hastanýn tedavisinin iptal edilmesi";


            mp_class.log_kaydet(kullaniciAdiAdmin, islem);

            //yukle(sonuc.Text);



        }
        else
        {
            panel_sonuc2.Visible = true;
            sonuc22.Text = "Ýþlem Baþarýsýz !";
            sonuc22.ForeColor = System.Drawing.Color.Red;
        }


    }
    protected void evet_Command(object sender, CommandEventArgs e)
    {

        string ID = e.CommandArgument.ToString();
        string hastaID = e.CommandName.ToString();


        MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("select * from siklus_ana_tab where hasta_id='" + hastaID.ToString() + "' and varsayilan='+'", mp_connection);
        DataTable dt = new DataTable();
        da.Fill(dt);


        string siklusID = "";
        if (dt.Rows.Count != 1)
        {
            panel_sonuc2.Visible = true;
            sonuc22.Text = "Hastanýn varsayýlan siklusu belirtilmediði için iþlem baþarýsýz!";
            sonuc22.ForeColor = System.Drawing.Color.Red;
        }
        else
        {

            siklusID = dt.Rows[0]["siklus_id"].ToString();

            MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set tedavisurecinde = '+',tedavibaslamatarihi = '" + DateTime.Now.ToShortDateString() + "',siklus_id="+siklusID.ToString()+" where raporID=" + ID.ToString() + "", mp_connection);

            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();

            if (eks == 1)
            {
                panel_sonuc2.Visible = true;
                sonuc22.Text = "Ýþlem baþarýyla gerçekleþtirildi.";
                sonuc22.ForeColor = System.Drawing.Color.Green;

                HttpCookie mpKullanilan = Request.Cookies["AdminK"];
                string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
                string islem = mp_class.hasta_adi_bul(hastaID) + " adlý hastanýn tedavi sürecinin baþlatýlmasý";


                mp_class.log_kaydet(kullaniciAdiAdmin, islem);

                //yukle(sonuc.Text);
            }
            else
            {
                panel_sonuc2.Visible = true;
                sonuc22.Text = "Ýþlem Baþarýsýz !";
                sonuc22.ForeColor = System.Drawing.Color.Red;
            }

            
     

        
        }





       
    }
    //protected void btnOnayla2_Command(object sender, CommandEventArgs e)
    //{

    //    string satir = e.CommandName.ToString();
    //    string ID = e.CommandArgument.ToString();
    //    string hastaID = ((Label)listopu.Rows[int.Parse(satir.ToString())].FindControl("hastaIDSatir")).Text;
    //    DropDownList tarih = (DropDownList)listopu.Rows[int.Parse(satir.ToString())].FindControl("drptarih2");

    //    string[] gelen = tarih.SelectedValue.ToString().Split(',');
    //    string hafta = gelen[0].ToString();
    //    string ay = gelen[1].ToString();
    //    string yil = gelen[2].ToString();

    //    MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
    //    MySqlCommand cmd = new MySqlCommand("Update heyetraporsonuclari set hafta = "+hafta.ToString()+",ay = "+ay.ToString()+" , yil = "+yil.ToString()+"  where raporID=" + ID.ToString() + "", mp_connection);


    //    mp_connection.Open();
    //    int eks = cmd.ExecuteNonQuery();
    //    mp_connection.Close();

    //    if (eks == 1)
    //    {
    //        panel_sonuc2.Visible = true;
    //        sonuc22.Text = "Tedavi baþlangýç tarihi baþarýyla deðiþtirildi.";
    //        sonuc22.ForeColor = System.Drawing.Color.Green;

    //        HttpCookie mpKullanilan = Request.Cookies["AdminK"];
    //        string kullaniciAdiAdmin = mpKullanilan["AdminKKA"].ToString();
    //        string islem = mp_class.hasta_adi_bul(hastaID) + " adlý hastanýn tedavi baþlama tarihinin deðiþtirilmesi";
            
    //        mp_class.log_kaydet(kullaniciAdiAdmin, islem);

    //        //yukle(sonuc.Text);



    //    }
    //    else
    //    {
    //        panel_sonuc2.Visible = true;
    //        sonuc22.Text = "Ýþlem Baþarýsýz !";
    //        sonuc22.ForeColor = System.Drawing.Color.Red;
    //    }

    //}
    protected void list5_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    //protected void ac_Command(object sender, CommandEventArgs e)
    //{


    //    int satir = int.Parse(e.CommandArgument.ToString());
    //    ((GridView)list5.Items[satir].FindControl("listopu")).Visible = true;
    //    ((ImageButton)list5.Items[satir].FindControl("kapat")).Visible = true;
    //    ((ImageButton)list5.Items[satir].FindControl("ac")).Visible = false;

    //}
    //protected void kapat_Command(object sender, CommandEventArgs e)
    //{
    //    int satir = int.Parse(e.CommandArgument.ToString());
    //    ((GridView)list5.Items[satir].FindControl("listopu")).Visible = false;
    //    ((ImageButton)list5.Items[satir].FindControl("kapat")).Visible = false;
    //    ((ImageButton)list5.Items[satir].FindControl("ac")).Visible = true;
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
         DateTime dtar = mp_class.tarihcevir2(tarih.Text.Trim());


         if (dtar < DateTime.Now.Date)
         {
             panel_sonuc2.Visible = false;
             sonuc22.Text = "Sistem tarihinden küçük tarih seçildi!";
             sonuc22.ForeColor = System.Drawing.Color.Red;
         }
         else
         {
             panel_sonuc2.Visible = false;

             MySqlConnection mp_connection = mp_class.connect_ivf(0301009184);
             MySqlDataAdapter mp_da = new MySqlDataAdapter("select * from randevuayar", mp_connection);
             DataTable mp_dt = new DataTable();
             mp_da.Fill(mp_dt);

             if (mp_dt.Rows.Count != 1)
             {
                 panel_sonuc2.Visible = false;
                 sonuc22.Text = "Randevu saati ayarlarý güncel deðil !";
                 sonuc22.ForeColor = System.Drawing.Color.Red;


             }
             else
             {
                 Label1.Text = dtar.ToShortDateString();
                 Label2.Text = " tarihli randevu kayýtlarý";
                 int periyot = int.Parse(mp_dt.Rows[0]["periyot"].ToString());
                 string baslangic = mp_dt.Rows[0]["baslangic"].ToString();
                 string bitis = mp_dt.Rows[0]["bitis"].ToString();

                 DateTime baslangictarihi = DateTime.Parse(Label1.Text + " " + baslangic.ToString());
                 DateTime bitistarihi = DateTime.Parse(Label1.Text + " " + bitis.ToString());

                 DataTable dt = new DataTable();
                 dt.Columns.Add("aralik");
                  
                 while(baslangictarihi <= bitistarihi)


                  {
                      DataRow dr = dt.NewRow();
                      dr[0] = baslangictarihi.ToShortTimeString();
                      dt.Rows.Add(dr);
                      baslangictarihi = baslangictarihi.AddMinutes(periyot);            
                  }


                  GridView1.DataSource = dt;
                  GridView1.DataBind();






             }
         }
     }
}


