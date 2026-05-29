using System;
using System.Web;
using System.Collections;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using MySql.Data.MySqlClient;


/// <summary>
/// Summary description for kisiler
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class kisiler : System.Web.Services.WebService {

    public kisiler () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
 
    public string[] KisiArama(String aranacak,int sayi)
    {
        
        ebebaba_connect_class ebebaba_class = new ebebaba_connect_class();
        MySqlConnection baglanti = ebebaba_class.connect_ebebaba(0301009184);
        DataTable ebebaba_dt = new DataTable();
        MySqlDataAdapter  ebebaba_da  = new MySqlDataAdapter("Select uye_adi &' '&uye_soyadi from uye_hasta order by (uye_adi &' '&uye_soyadi) asc",baglanti);
        ebebaba_da.Fill(ebebaba_dt);

        string[] dizimiz = new string[ebebaba_dt.Rows.Count];

        int a=0;

        foreach(DataRow rows in ebebaba_dt.Rows)
        {
        
        if(rows[0].ToString().StartsWith(aranacak,StringComparison.OrdinalIgnoreCase))
        {
        
            dizimiz[a] = rows[0].ToString();



        }

            a++;

        }

        return dizimiz;

    }

  
}

