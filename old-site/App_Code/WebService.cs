using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class WebService : System.Web.Services.WebService {

    tayfunalpercom mp_class = new tayfunalpercom();

    public WebService () {

    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string save(string name, string email, string comment, string ID, string IP)
    {

        try
        {
            MySqlConnection mp_connection = mp_class.connect_stb(0301009184);
            MySqlCommand cmd = new MySqlCommand("Insert into blogyorumlaritablosu(blogID,adiSoyadi,ePostaAdresi,mesaji,gonderimTarihi,ipAdresi,onay,tur) values (?1,?2,?3,?4,?5,?6,?7,?8)", mp_connection);
            cmd.Parameters.AddWithValue("?1", IDAl(ID));
            cmd.Parameters.AddWithValue("?2", name);
            cmd.Parameters.AddWithValue("?3", email);
            cmd.Parameters.AddWithValue("?4", comment);
            cmd.Parameters.AddWithValue("?5", DateTime.Now);
            cmd.Parameters.AddWithValue("?6", IP);
            cmd.Parameters.AddWithValue("?7", "-");
            cmd.Parameters.AddWithValue("?8", "N");

            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();
            mailGonder(name, "VM-Samsun Tüp Bebek", comment);
            return eks.ToString();

        }
        catch
        {
            return "0";
        }
    }




    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string saveMakaleYorum(string name, string email, string comment, string ID, string IP)
    {

        try
        {
            MySqlConnection mp_connection = mp_class.connect_ebebaba(0301009184);
            MySqlCommand cmd = new MySqlCommand("Insert into blogyorumlaritablosu(blogID,adiSoyadi,ePostaAdresi,mesaji,gonderimTarihi,ipAdresi,onay,tur) values (?1,?2,?3,?4,?5,?6,?7,?8)", mp_connection);
            cmd.Parameters.AddWithValue("?1", ID);
            cmd.Parameters.AddWithValue("?2", name);
            cmd.Parameters.AddWithValue("?3", email);
            cmd.Parameters.AddWithValue("?4", comment);
            cmd.Parameters.AddWithValue("?5", DateTime.Now);
            cmd.Parameters.AddWithValue("?6", IP);
            cmd.Parameters.AddWithValue("?7", "-");
            cmd.Parameters.AddWithValue("?8", "N");

            mp_connection.Open();
            int eks = cmd.ExecuteNonQuery();
            mp_connection.Close();
            mailGonder(name, "tayfunalper.com", comment);
            return eks.ToString();

        }
        catch
        {
            return "0";
        }
    }

    string IDAl(string ad)
    {
        try
        {

            MySqlConnection connect_word = mp_class.connect_stb(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select ID from blogiceriktablosu where kisaAd='" + ad + "'", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0][0].ToString();
        }
        catch
        {
            return "0";
        }
    }


    void mailGonder(string adi,string site,string mesaj)
    {

        try
        {
            string mesajGonderilecek = DateTime.Now.ToString() + " tarihinde " + adi + " isimli kullanıcı " + site + " sitesindeki yazınıza yorum yaptı.Lütfen onaylayın!<br><br>";
            mesajGonderilecek += mesaj;

            MailMessage messageee = new MailMessage();
            messageee.IsBodyHtml = true;
            messageee.Subject = "Sitede yeni yorum";
            messageee.Body = mesajGonderilecek;
            messageee.To.Add("tuncayhanoglu@hotmail.com");
            messageee.From = new MailAddress("samsuntupbebek<bilgi@samsuntupbebek.com>");
            SmtpClient server = new SmtpClient("mail.samsuntupbebek.com");
            server.Credentials = new System.Net.NetworkCredential("bilgi@samsuntupbebek.com", "GJuj47T0");
            server.Port = 587;
            server.Send(messageee);
        }
        catch
        { 
        
        }

    
    }


    
}
