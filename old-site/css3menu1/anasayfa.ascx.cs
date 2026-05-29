using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

public partial class anasayfa : System.Web.UI.UserControl
{
    ebebaba_connect_class ta = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
         
         yukle();
         //yukle2();
        }
    }


    private void yukle()
    {

        HttpCookie taMakale = Request.Cookies["taMakale"];
        string[] IDList = { }; 
        string sqlCumle = "";
        string sql = "";
        if (taMakale != null)
        {
            IDList = taMakale["ID"].ToString().Split(',');
          
            if (IDList.Length > 0)
            {
                foreach (string ID in IDList)
                {
                    if (ID.ToString().Length > 0)
                    {
                        sqlCumle += " and not T.konu_id=" + ID;
                    }
                }


                sql = "Select K.kitap_id as KID,T.konu_id as ID,T.konu as konu,T.metin as metin from kitapkategorileri K,kitap_konulari T where K.id=CAST(T.kategori_id as UNSIGNED) and not K.kitap_id='299' and not K.kitap_id='314' and T.yayin='1'" + sqlCumle + " order by T.hit asc limit 0,5";


            }
            else
            {

                sqlCumle = "";
                sql = "Select K.kitap_id as KID,T.konu_id as ID,T.konu as konu,T.metin as metin from kitapkategorileri K,kitap_konulari T where K.id=CAST(T.kategori_id as UNSIGNED) and not K.kitap_id='299' and not K.kitap_id='314' and T.yayin='1' order by T.hit asc limit 0,5";
            }
        }
        else
        {


            sql = "Select K.kitap_id as KID,T.konu_id as ID,T.konu as konu,T.metin as metin from kitapkategorileri K,kitap_konulari T where K.id=CAST(T.kategori_id as UNSIGNED) and not K.kitap_id='299' and not K.kitap_id='314' and T.yayin='1' order by T.hit asc limit 0,5";
        
        
        }

       
   
        MySqlConnection connect_word = ta.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter(sql, connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        MySqlDataAdapter da2 = new MySqlDataAdapter("Select K.kitap_id as KID,T.konu_id as ID,T.konu as konu,T.metin as metin from kitapkategorileri K,kitap_konulari T where K.id=CAST(T.kategori_id as UNSIGNED) and not K.kitap_id='299' and not K.kitap_id='314' and T.yayin='1'", connect_word);
        DataTable dt2 = new DataTable();
        da2.Fill(dt2);

       
            HttpCookie taMakale5 = Request.Cookies["taMakale"];

            if (taMakale5 != null)
            {
                int Cs = taMakale5["ID"].Split(',').Length;
                int say = dt2.Rows.Count;

                if (say - Cs < 6)
                {

                    if (taMakale5["ID"].Split(',').Length > 1)
                    {
                        taMakale5["ID"] = taMakale5["ID"].Remove(0, 4);
                        taMakale5.Expires = DateTime.Now.AddYears(1);
                        Response.Cookies.Add(taMakale5);
                    }
                }
            }
    
        ana.DataSource = dt;
        ana.DataBind();


        int a = 0;
        LinkButton baslik = new LinkButton();
        Image resim = new Image();
        LinkButton icerik = new LinkButton();
        ImageButton kapat = new ImageButton();

        foreach (GridViewRow satir in ana.Rows)
        {
            baslik = (LinkButton)satir.FindControl("baslik");
            resim = (Image)satir.FindControl("resim");

            icerik = (LinkButton)satir.FindControl("icerik");
            kapat = (ImageButton)satir.FindControl("kapat");
            kapat.CommandArgument = dt.Rows[a]["ID"].ToString();
            baslik.Text = dt.Rows[a]["konu"].ToString();
            string deger = RemoveHTML(dt.Rows[a]["metin"].ToString());

            if (deger.Length < 150)
            {

                icerik.Text = deger.TrimEnd();
            }
            else
            {
                icerik.Text = deger.Substring(0, 150).TrimEnd() + "...";
            }

            baslik.PostBackUrl = "makale.aspx?Bolum_ID=" + dt.Rows[a]["KID"].ToString() + "&Konu_ID=" + dt.Rows[a]["ID"].ToString();

            icerik.PostBackUrl = "makale.aspx?Bolum_ID=" + dt.Rows[a]["KID"].ToString() + "&Konu_ID=" + dt.Rows[a]["ID"].ToString();
            resim.ImageUrl = "~/resimler/" + dt.Rows[a]["ID"].ToString() + "_thumb.jpg";

            a++;

        }





    }

//    void yukle2()
//    {

//        string adres = "http://www.tayfunalper.com/makale.aspx?Bolum_ID=309&Konu_ID=326"; //1
//WebRequest istek = HttpWebRequest.Create(adres); //2
// WebResponse cevap; //3
// cevap = istek.GetResponse(); //4
// StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream()); //5
//string gelen = donenBilgiler.ReadToEnd(); //6
// int titleIndexBaslangici = gelen.IndexOf("Çocukluğum",0,2) + 6; //7

//Label1.Text = gelen.Substring(titleIndexBaslangici, 200); //9

    
//    }

    public string RemoveHTML(string source)
    {
        Regex _htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);

        return _htmlRegex.Replace(source, string.Empty);
    }
   
   protected void ana_RowDataBound(object sender, GridViewRowEventArgs e)
    {
  if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Normal  || e.Row.RowState == DataControlRowState.Alternate)
                bicimlendir(e);
         
  }
    }

    void bicimlendir(GridViewRowEventArgs e)
    {
    

       //ImageButton kapat = (ImageButton)e.Row.FindControl("kapat");
       //kapat.Visible = false;

       int sayi = e.Row.RowIndex + 2;

       //e.Row.Attributes.Add("onmouseover", "document.getElementById('ctl00_ContentPlaceHolder2_anasayfa1_ana_ctl0" + sayi.ToString() + "_kapat').style.visibility='visible';");

       //e.Row.Attributes.Add("onmouseout", "document.getElementById('ctl00_ContentPlaceHolder2_anasayfa1_ana_ctl0" + sayi.ToString() + "_kapat').style.visibility='hidden';");


    }

    protected void kapat_Command(object sender, CommandEventArgs e)
    {
        HttpCookie ta2Makale = Request.Cookies["taMakale"];


        if (ta2Makale != null)
        {

            string var = ta2Makale["ID"].ToString();

            if (var.Contains(e.CommandArgument.ToString()) == false)
            {

                ta2Makale["ID"] = ta2Makale["ID"] + "," + e.CommandArgument.ToString();
                ta2Makale.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(ta2Makale);

            }

        }
        else
        {
            HttpCookie taMakale = new HttpCookie("taMakale");
            taMakale["ID"] = e.CommandArgument.ToString();
            taMakale.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(taMakale);
        }



        yukle();
    }
}