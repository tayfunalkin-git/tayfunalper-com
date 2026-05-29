using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Script.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yorumKaydet : System.Web.UI.Page
{
    tayfunalpercom mp_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {

     //   save(Request.QueryString["name"].ToString(), Request.QueryString["email"].ToString(), Request.QueryString["comment"].ToString(), Request.QueryString["ID"].ToString());

    }

    [System.Web.Services.WebMethod]
    [ScriptMethod]
    public void save(string name,string email,string comment, string ID)
    {

        MySqlConnection mp_connection = mp_class.connect_stb(0301009184);
        MySqlCommand cmd = new MySqlCommand("Insert into blogyorumlaritablosu(blogID,adiSoyadi,ePostaAdresi,mesaji,gonderimTarihi,ipAdresi,onay,tur) values (?1,?2,?3,?4,?5,?6,?7,?8)", mp_connection);
        cmd.Parameters.AddWithValue("?1", ID);
        cmd.Parameters.AddWithValue("?2", "asd");
        cmd.Parameters.AddWithValue("?3", "asd");
        cmd.Parameters.AddWithValue("?4", "asd");
        cmd.Parameters.AddWithValue("?5", DateTime.Now);
        cmd.Parameters.AddWithValue("?6", "asd");
        cmd.Parameters.AddWithValue("?7", "-");
        cmd.Parameters.AddWithValue("?8", "N");

        mp_connection.Open();
        int eks = cmd.ExecuteNonQuery();
        mp_connection.Close();


    }

    


    string ipNedir()
    {
        string ipaddress;
        ipaddress = Context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (ipaddress == "" || ipaddress == null)
            ipaddress = Context.Request.ServerVariables["REMOTE_ADDR"];
        return ipaddress;
    }


    string IDAl(string ad)
    {
       
            MySqlConnection connect_word = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select ID from blogiceriktablosu where kisaAd='"+ad+"'", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

        return dt.Rows[0][0].ToString();

    }


}