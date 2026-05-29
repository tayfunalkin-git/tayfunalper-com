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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;

public partial class rapor_admin : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
  
    protected void Page_Load(object sender, EventArgs e)
    {
              yukle();

    }



    void yukle()
    {

        if (Session["sqlim_siklus"] != null)
        {
            string sql = Session["sqlim_siklus"].ToString();

            MySqlConnection con = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            hasta_siklus ds = new hasta_siklus();
            //da.Fill(dt);
            da.Fill(ds.siklus_table);


            for (int a = 0; a < ds.siklus_table.Rows.Count; a++)
            {

                if (ds.siklus_table.Rows[a]["kurum"].ToString() != "")
                {
                    ds.siklus_table.Rows[a]["kurum"] = kurumlar(ds.siklus_table.Rows[a]["kurum"].ToString());

                }
                if (ds.siklus_table.Rows[a]["Tedavi_Protokolu"].ToString() != "")
                {
                    ds.siklus_table.Rows[a]["Tedavi_Protokolu"] = tedavi_protokolu_yukle(ds.siklus_table.Rows[a]["Tedavi_Protokolu"].ToString());

                }
                if (ds.siklus_table.Rows[a]["Tedavi_Turu"].ToString() != "")
                {
                    ds.siklus_table.Rows[a]["Tedavi_Turu"] = tedavi_turleri(ds.siklus_table.Rows[a]["Tedavi_Turu"].ToString());

                }
                ds.siklus_table.Rows[a]["Kullanilan_Fsh"] = fsh_hesap(ds.siklus_table.Rows[a]["siklus_id"].ToString());


                for (int i = 1; i < 39; i++)
                {


                    if (ds.siklus_table.Rows[a][i].ToString() == "")
                    {

                        ds.siklus_table.Rows[a][i] = "-";
                    }
                
                
                }




            }

            //GridView1.DataSource = dt;
            //GridView1.DataBind();



            ReportDocument rp = new ReportDocument();
            rp.Load(Server.MapPath("siklus_report.rpt"));
            //rp.Database.Tables[0].SetDataSource(ds.Tables["DataTable1"]);
            rp.SetDataSource(ds);
            raporum.ReportSource = rp;

        }
    }


    private string kurumlar(string gelen)
    {
        try
        {
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select kurum_adi from kurumlar where kurum_id = "+gelen+"", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            return dt6.Rows[0][0].ToString();
            
          
        }
        catch
        {
            return "";
        }

    }
    private string tedavi_turleri(string gelen)
    {



        try
        {
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select tedavi_adi from tedavi_turleri where tur_id = " + gelen + "", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            return dt6.Rows[0][0].ToString();


        }
        catch
        {
            return "";
        }

    }
    private string tedavi_protokolu_yukle(string gelen)
    {



        try
        {
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da6 = new MySqlDataAdapter("Select protokol_adi from tedavi_protokolleri where protokol_id = " + gelen + "", connect_word);
            DataTable dt6 = new DataTable();
            da6.Fill(dt6);

            return dt6.Rows[0][0].ToString();


        }
        catch
        {
            return "";
        }


    }
    private string fsh_hesap(string gelen)
    {

        int kullanilan_fsh_degeri = 0;


        try
        {
            MySqlConnection connect_word = ebebaba_class.connect_ebebaba(0301009184);

            MySqlDataAdapter da1 = new MySqlDataAdapter("Select * from takipli_siklus1 where siklus_id='" + gelen + "'", connect_word);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows.Count == 1)
            {

                for (int i = 1; i < 15; i++)
                {

                    dt1.Rows[0]["iki" + i.ToString()].ToString();

                    if (dt1.Rows[0]["iki" + i.ToString()].ToString() != "")
                    {
                        int yeni_deger = int.Parse(dt1.Rows[0]["iki" + i.ToString()].ToString().Trim());

                        kullanilan_fsh_degeri += yeni_deger;
                    }


                }


                for (int i = 1; i < 15; i++)
                {
                    if (dt1.Rows[0]["uc" + i.ToString()].ToString() != "")
                    {
                        int yeni_deger = int.Parse(dt1.Rows[0]["uc" + i.ToString()].ToString().Trim());

                        kullanilan_fsh_degeri += yeni_deger;
                    }
                }

            }




            MySqlDataAdapter da2 = new MySqlDataAdapter("Select * from takipli_siklus2 where siklus_id='" + gelen + "'", connect_word);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            if (dt2.Rows.Count == 1)
            {


                for (int i = 1; i < 15; i++)
                {
                    if (dt2.Rows[0]["iki2" + i.ToString()].ToString() != "")
                    {
                        int yeni_deger = int.Parse(dt2.Rows[0]["iki2" + i.ToString()].ToString().Trim());

                        kullanilan_fsh_degeri += yeni_deger;
                    }
                }


                for (int i = 1; i < 15; i++)
                {

                    if (dt2.Rows[0]["uc2" + i.ToString()].ToString() != "")
                    {
                        int yeni_deger = int.Parse(dt2.Rows[0]["uc2" + i.ToString()].ToString().Trim());

                        kullanilan_fsh_degeri += yeni_deger;
                    }
                }

            }


            MySqlDataAdapter da3 = new MySqlDataAdapter("Select * from takipli_siklus3 where siklus_id='" + gelen + "'", connect_word);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);

            if (dt3.Rows.Count == 1)
            {

                for (int i = 1; i < 8; i++)
                {

                    if (dt3.Rows[0]["iki3" + i.ToString()].ToString() != "")
                    {
                        int yeni_deger = int.Parse(dt3.Rows[0]["iki3" + i.ToString()].ToString().Trim());

                        kullanilan_fsh_degeri += yeni_deger;
                    }
                }


                for (int i = 1; i < 8; i++)
                {
                    if (dt3.Rows[0]["uc3" + i.ToString()].ToString() != "")
                    {
                        int yeni_deger = int.Parse(dt3.Rows[0]["uc3" + i.ToString()].ToString().Trim());

                        kullanilan_fsh_degeri += yeni_deger;
                    }
                }

            }

            return kullanilan_fsh_degeri.ToString();
    


        }

        catch
        {
            return "";

        }





    }
    protected void s_ekran_Click(object sender, EventArgs e)
    {
        Response.Redirect("siklus_bilgi.aspx");
    }
}
