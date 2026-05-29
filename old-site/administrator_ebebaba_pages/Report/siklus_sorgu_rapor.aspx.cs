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

public partial class rapor_siklusum : System.Web.UI.Page
{
    ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
  
    protected void Page_Load(object sender, EventArgs e)
    {
              //yukle();

              string[] kriterdizisi = Session["kriterler"].ToString().Split('|');
              string[] siklusdizisi = Session["siklus_oran"].ToString().Split('|');
              string[] hastadizisi =  Session["hasta_oran"].ToString().Split('|');
              siklus_sorgu ss = new siklus_sorgu();
             

              #region kriterler
              DataTable dt = new DataTable("sorgu");
              DataColumn dc0 = new DataColumn("K");
              DataColumn dc1 = new DataColumn("TT");
              DataColumn dc2 = new DataColumn("TP");
              DataColumn dc3 = new DataColumn("BAT");
              DataColumn dc4 = new DataColumn("BIT");

              DataColumn dcs0 = new DataColumn("GS");
              DataColumn dcs1 = new DataColumn("OS");
              DataColumn dcs2 = new DataColumn("AS");
              DataColumn dcs3 = new DataColumn("CS");
              DataColumn dcs4 = new DataColumn("DS");
              DataColumn dcs5 = new DataColumn("HS");

              DataColumn dcsy0 = new DataColumn("GSY");
              DataColumn dcsy1 = new DataColumn("OSY");
              DataColumn dcsy2 = new DataColumn("ASY");
              DataColumn dcsy3 = new DataColumn("CSY");
              DataColumn dcsy4 = new DataColumn("DSY");
              DataColumn dcsy5 = new DataColumn("HSY");

              DataColumn dch0 = new DataColumn("GH");
              DataColumn dch1 = new DataColumn("OH");
              DataColumn dch2 = new DataColumn("AH");
              DataColumn dch3 = new DataColumn("CH");
              DataColumn dch4 = new DataColumn("DH");
              DataColumn dch5 = new DataColumn("HH");


              DataColumn dchy0 = new DataColumn("GHY");
              DataColumn dchy1 = new DataColumn("OHY");
              DataColumn dchy2 = new DataColumn("AHY");
              DataColumn dchy3 = new DataColumn("CHY");
              DataColumn dchy4 = new DataColumn("DHY");
              DataColumn dchy5 = new DataColumn("HHY");

              DataColumn dct0 = new DataColumn("ST");
              DataColumn dct1 = new DataColumn("HT");

              
              dt.Columns.Add(dc0);
              dt.Columns.Add(dc1);
              dt.Columns.Add(dc2);
              dt.Columns.Add(dc3);
              dt.Columns.Add(dc4);
              dt.Columns.Add(dcs0);
              dt.Columns.Add(dcs1);
              dt.Columns.Add(dcs2);
              dt.Columns.Add(dcs3);
              dt.Columns.Add(dcs4);
              dt.Columns.Add(dcs5);
              dt.Columns.Add(dcsy0);
              dt.Columns.Add(dcsy1);
              dt.Columns.Add(dcsy2);
              dt.Columns.Add(dcsy3);
              dt.Columns.Add(dcsy4);
              dt.Columns.Add(dcsy5);
              dt.Columns.Add(dch0);
              dt.Columns.Add(dch1);
              dt.Columns.Add(dch2);
              dt.Columns.Add(dch3);
              dt.Columns.Add(dch4);
              dt.Columns.Add(dch5);
              dt.Columns.Add(dchy0);
              dt.Columns.Add(dchy1);
              dt.Columns.Add(dchy2);
              dt.Columns.Add(dchy3);
              dt.Columns.Add(dchy4);
              dt.Columns.Add(dchy5);
              dt.Columns.Add(dct0);
              dt.Columns.Add(dct1);

              DataRow dr;
              dr = dt.NewRow();


              dr[0] = kriterdizisi[0].ToString();
              dr[1] = kriterdizisi[1].ToString();
              dr[2] = kriterdizisi[2].ToString();
              dr[3] = kriterdizisi[3].ToString();
              dr[4] = kriterdizisi[4].ToString();
              dr[5] = siklusdizisi[0].ToString();
              dr[6] = siklusdizisi[2].ToString();
              dr[7] = siklusdizisi[4].ToString();
              dr[8] = siklusdizisi[6].ToString();
              dr[9] = siklusdizisi[8].ToString();
              dr[10] = siklusdizisi[10].ToString();
              dr[11] = siklusdizisi[1].ToString();
              dr[12] = siklusdizisi[3].ToString();
              dr[13] = siklusdizisi[5].ToString();
              dr[14] = siklusdizisi[7].ToString();
              dr[15] = siklusdizisi[9].ToString();
              dr[16] = siklusdizisi[11].ToString();
              dr[17] = hastadizisi[0].ToString();
              dr[18] = hastadizisi[2].ToString();
              dr[19] = hastadizisi[4].ToString();
              dr[20] = hastadizisi[6].ToString();
              dr[21] = hastadizisi[8].ToString();
              dr[22] = hastadizisi[10].ToString();
              dr[23] = hastadizisi[1].ToString();
              dr[24] = hastadizisi[3].ToString();
              dr[25] = hastadizisi[5].ToString();
              dr[26] = hastadizisi[7].ToString();
              dr[27] = hastadizisi[9].ToString();
              dr[28] = hastadizisi[11].ToString();
              dr[29] = siklusdizisi[12].ToString();
              dr[30] = hastadizisi[12].ToString();

              dt.Rows.Add(dr);

           
              #endregion

              #region kriterler2
              DataTable sayi = new DataTable("siklus_sayisi");
            
              DataColumn dcss0 = new DataColumn("sayi");

              sayi.Columns.Add(dcss0);
            
              DataRow drsayi1;
              drsayi1 = sayi.NewRow();
              drsayi1[0] = siklusdizisi[0].ToString();
              sayi.Rows.Add(drsayi1);
              DataRow drsayi2;
              drsayi2 = sayi.NewRow();
              drsayi2[0] = siklusdizisi[2].ToString();
              sayi.Rows.Add(drsayi2);
              DataRow drsayi3;
              drsayi3 = sayi.NewRow();
              drsayi3[0] = siklusdizisi[4].ToString();
              sayi.Rows.Add(drsayi3);
              DataRow drsayi4;
              drsayi4 = sayi.NewRow();
              drsayi4[0] = siklusdizisi[6].ToString();
              sayi.Rows.Add(drsayi4);
              DataRow drsayi5;
              drsayi5 = sayi.NewRow();
              drsayi5[0] = siklusdizisi[8].ToString();
              sayi.Rows.Add(drsayi5);
              DataRow drsayi6;
              drsayi6 = sayi.NewRow();
              drsayi6[0] = siklusdizisi[10].ToString();
              sayi.Rows.Add(drsayi6);


              DataSet ds = new DataSet("hano");
              ds.Tables.Add(sayi);
              ds.Tables.Add(dt);

              GridView1.DataSource = sayi;
              GridView1.DataBind();

              #endregion
           
                     
              ReportDocument rp = new ReportDocument();
              rp.Load(Server.MapPath("sorgu_report.rpt"));
              rp.SetDataSource(ds as DataSet);
              //rp.Database.Tables["siklus_sayisi"].SetDataSource(sayi as DataTable);
              //rp.Database.Tables["sorgu"].SetDataSource(dt as DataTable);
              raporum.ReportSource = rp;


    }



}
