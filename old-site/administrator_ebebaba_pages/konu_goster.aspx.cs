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

public partial class konu_goster2 : System.Web.UI.Page
{

    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
    protected void Page_Load(object sender, EventArgs e)
    {

    
        bilgi_yukle();

    }


    void bilgi_yukle()
    {

        try
        {

            MySqlConnection ebebaba_connection = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter ebebaba_da = new MySqlDataAdapter("Select * from kitap_konulari where konu_id=" + Request.QueryString["Konu_ID"].ToString() + "", ebebaba_connection);
            DataTable ebebaba_dt = new DataTable();
            ebebaba_da.Fill(ebebaba_dt);

            if (ebebaba_dt.Rows.Count == 1)
            {
                sonuc.Text = ebebaba_dt.Rows[0]["konu"].ToString();
                Page.Title = ebebaba_dt.Rows[0]["konu"].ToString();
                eklenmetarihi.Text = ebebaba_dt.Rows[0]["metin"].ToString();
            
            
            }
            
            
        }


        catch
        {

            sonuc.Text = "Bilgiler Yüklenirken Hata Oluþtu !";
        
        }

    }


}
