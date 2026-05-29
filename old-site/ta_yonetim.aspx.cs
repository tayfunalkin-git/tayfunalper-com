using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using MySql.Data.MySqlClient;

public partial class _doktor_modulu : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {

        //Menu yeni = (Menu)Master.FindControl("mainMenu");
        //yeni.Items[5].Selected = true;

        //Page.Title = "Ebebaba - Doktor Giriþ Sayfasý";
        //    //if (Request.IsSecureConnection==false)
        //    //{
        //    //    Response.Redirect("http://www.ebebaba.com");
        //    //}

        //HtmlMeta a = new HtmlMeta();
        //a = (HtmlMeta)Master.FindControl("ttl");
        //a.Content = "Tayfun ALPER - Doktor Giriþ Sayfasý";


        //HtmlMeta b = new HtmlMeta();
        //b = (HtmlMeta)Master.FindControl("kw");
        //b.Content = "Tayfun ALPER ,Doktor Giriþi , Doktor Giriþ Sayfasý ,Ebebaba,Samsun,Tüp Bebek,Omü,Ondokuz Mayýs Üniversitesi,Tayfun,ALPER,Tayfun ALPER Ebebaba";


        
        if (!IsPostBack)
        {
            uye_k_adi.Focus();
            C_Control();

          

        }
  //ebebaba_class.istatistiksayfa(Request.ServerVariables["REMOTE_ADDR"].ToString(), "Admin Giriþi","Sayfa");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("yeni_hasta_kaydi.aspx");

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("yeni_doktor_kaydi.aspx");

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("hasta_modulu.aspx");

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("doktor_modulu.aspx");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("yeni_hasta_kaydi.aspx");
    }  
    void C_Control()
    {

        try
        {
            HttpCookie Ebebaba2 = Request.Cookies["Doktor"];



            if (Ebebaba2["beniHatirla"] == "1")
            {
                beni_hatirla.Checked = true;

                uye_k_adi.Text = Ebebaba2["doktorKullaniciAdi"].ToString();
                uye_k_adi.Enabled = false;
                uye_adi.Text = "Merhaba " + Ebebaba2["doktorAdi"].ToString() +" ;";

                uye_sifre.Focus();

            }
            else
            {
                beni_hatirla.Checked = false;

                uye_k_adi.Focus();

            }


        




        }

        catch
        { 
        
        
        }
    }
    protected void beni_unut_Click(object sender, EventArgs e)
    {


        try
        {

            HttpCookie Ebebaba2 = Request.Cookies["Doktor"];
            Ebebaba2.Expires = DateTime.Now.Date.AddDays(-3);
            Response.Cookies.Add(Ebebaba2);
        }
        catch
        {


        }

        finally
        { 
        
            Response.Redirect("ta_yonetim.aspx");
        }
    





    }
    void doktor_girisi()
    {


            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter();


            MySqlCommand ebebaba_cmd = new MySqlCommand("Select * from uye_doktor where uye_k_adi=?kadi and uye_sifre=?sif", ebebaba_connection);
            
        
        ebebaba_cmd.Parameters.AddWithValue("?kadi",uye_k_adi.Text);

            ebebaba_cmd.Parameters.AddWithValue("?sif",uye_sifre.Text);

            ebebaba_da.SelectCommand = ebebaba_cmd;


            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);


            if (ebebaba_dt.Rows.Count == 1)
            {
                HttpCookie Ebebaba2 = new HttpCookie("Doktor");
                Ebebaba2["doktorKullaniciAdi"] = uye_k_adi.Text;
                Ebebaba2.Expires = DateTime.Now.Date.AddDays(10);
                Ebebaba2["beniHatirla"] = "0";

                Ebebaba2["doktorAdi"] = "";

                if (beni_hatirla.Checked == true)
                {
                    Ebebaba2["beniHatirla"] = "1";
                    Response.Cookies.Add(Ebebaba2);
                    Ebebaba2["doktorAdi"] = ebebaba_dt.Rows[0]["uye_adi"].ToString() + " " + ebebaba_dt.Rows[0]["uye_soyadi"].ToString();

                }
                else if (beni_hatirla.Checked == false)
                {
                    Ebebaba2["beniHatirla"] = "0";
                    Response.Cookies.Add(Ebebaba2);

                }

Ebebaba2["beniHatirlayonetici"] = "1";
                    Response.Cookies.Add(Ebebaba2);
              

                MySqlCommand ssgt = new MySqlCommand();
                ssgt.CommandText = "insert into ssgt(uye_k_adi , tarih) values ('" + uye_k_adi.Text + "' , '" + DateTime.Now.ToString() + "')";
                ssgt.Connection = ebebaba_connection;
                ebebaba_connection.Open();
                ssgt.ExecuteNonQuery();
                ebebaba_connection.Close();



                if (ebebaba_dt.Rows[0]["uye_tip_admin"].ToString() == "+")
                {


                    HttpCookie EbebabaKullanilan = new HttpCookie("AdminK");
                    EbebabaKullanilan["AdminKKA"] = uye_k_adi.Text;
                    EbebabaKullanilan["Adminsure"] = "5000";
                    EbebabaKullanilan.Expires = DateTime.Now.AddDays(10);

                    Response.Cookies.Add(EbebabaKullanilan);

                    FormsAuthentication.RedirectFromLoginPage(uye_k_adi.Text, beni_hatirla.Checked);

                    Response.Redirect("~/administrator_ebebaba_pages/default.aspx");
                }
                else
                {

                    HttpCookie EbebabaKullanilan = new HttpCookie("DoktorK");
                    EbebabaKullanilan["DoktorKKA"] = uye_k_adi.Text;
                    EbebabaKullanilan["Doktorsure"] = "5000";
                    EbebabaKullanilan.Expires = DateTime.Now.AddDays(10);
                    Response.Cookies.Add(EbebabaKullanilan);


                    FormsAuthentication.RedirectFromLoginPage(uye_k_adi.Text, beni_hatirla.Checked);

                    Response.Redirect("~/ebebaba_doktor_modulu/default.aspx");
                }

            }

            else
            {
              
                sonuc.Text = "Giriþ Baþarýsýz !";
                sonuc.ForeColor = System.Drawing.Color.Red;

            }

  

    
    }
    protected void uye_k_adi_TextChanged(object sender, EventArgs e)
    {
        doktor_girisi();

    }
    protected void uye_sifre_TextChanged(object sender, EventArgs e)
    {
        doktor_girisi();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        doktor_girisi();
    }
}
