using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class randevu : System.Web.UI.Page
{

    ebebaba_connect_class noc = new ebebaba_connect_class();


    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            yukle();
        
        }

    }

    private void yukle()
    {

        try
        {

            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter mp_da = new MySqlDataAdapter("Select * from iceriktablosu where kisaAd='" + Request.QueryString["ID"].ToString() + "' and yayin='E'", connect_word);
            DataTable mp_dt = new DataTable();
            mp_da.Fill(mp_dt);

            if (mp_dt.Rows.Count == 1)
            {
                baslik.InnerText = mp_dt.Rows[0]["baslik"].ToString();
                icerik.InnerHtml = mp_dt.Rows[0]["icerik"].ToString().Replace("../uploadImages", "uploadImages");
            }
            else
            {
                Response.Redirect("Default.aspx");

            
            }
        }
        catch
        {

            Response.Redirect("Default.aspx");
        }

    }
}