using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class mainAdminPagesHdn_0000073 : System.Web.UI.Page
{
    ebebaba_connect_class noc = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            kategoriYukle();
            LinkButton1.OnClientClick = "return popitup('havuzEkip.aspx?gonderen=kapak','agac')";
        }
    }


    private void kategoriYukle()
    {
        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da6 = new MySqlDataAdapter("Select * from kategorilistekip order by sira asc", connect_word);
        DataTable dt6 = new DataTable();
        da6.Fill(dt6);

        kategoriList.DataSource = dt6;
        kategoriList.DataTextField = dt6.Columns["Adi"].ToString();
        kategoriList.DataValueField = dt6.Columns["ID"].ToString();
        kategoriList.DataBind();

        ListItem yeni = new ListItem();
        yeni.Text = "Seçiniz";
        yeni.Value = "";

        //yeni.Selected = true;

        kategoriList.Items.Insert(0, yeni);

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        secilenKapakResmi.InnerHtml = "<img src='../uploadImages/"+txtKapak.Value+"_450.jpg'/>";

        if (kategoriList.SelectedValue == "")
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Üye pozisyonunu seçiniz!";
            sonuc.ForeColor = System.Drawing.Color.Red;


        }
       
        else if (txtBaslik.Text == "")
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Ekip üyesinin ad-soyad bilgisini giriniz!";
            sonuc.ForeColor = System.Drawing.Color.Red;
         
        
        }
       
        else if (txtKapak.Value == "")
        {
            panel_sonuc.Visible = true;
            sonuc.Text = "Ekip üyesinin resmini seçiniz!";
            sonuc.ForeColor = System.Drawing.Color.Red;
        }
       
        else
        {
       
                kaydet();
         
        }


    }

    private void kaydet()
    {


        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("select max(sira) from ekipiceriktablosu where kategori=" + kategoriList.SelectedValue + "", connect_word);
        DataTable mp_dt = new DataTable();
        da.Fill(mp_dt);

        int sirano = 0; 
        if (mp_dt.Rows[0][0].ToString() == "")
        { sirano = 1; } 
        else 
        { sirano = 0; 
            if (mp_dt.Rows[0][0].ToString() == "") 
            { sirano = 1; } else 
            { sirano = int.Parse(mp_dt.Rows[0][0].ToString()) + 1; }
        
        }


        
        MySqlCommand cmd = new MySqlCommand("Insert into ekipiceriktablosu(baslik,eklenmeTarihi,kapakResmi,youtube,facebook,instagram,sira,kategori,mail,yayin,aciklama) values (?1,?2,?3,?4,?5,?6,?7,?8,?9,?10,?11)", connect_word);
      
        cmd.Parameters.AddWithValue("?1",txtBaslik.Text);
        cmd.Parameters.AddWithValue("?2",DateTime.Now);
        cmd.Parameters.AddWithValue("?3",txtKapak.Value);
        cmd.Parameters.AddWithValue("?4",txtYoutube.Text);
        cmd.Parameters.AddWithValue("?5",txtFacebook.Text);
        cmd.Parameters.AddWithValue("?6", txtInstagram.Text);
        cmd.Parameters.AddWithValue("?7", sirano);
        cmd.Parameters.AddWithValue("?8", kategoriList.SelectedValue);
        cmd.Parameters.AddWithValue("?9", txtPosta.Text);
        cmd.Parameters.AddWithValue("?10", yayin.SelectedValue);
        cmd.Parameters.AddWithValue("?11", txtAciklama.Text);


        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        string soneklenen = cmd.LastInsertedId.ToString();
        connect_word.Close();

        if (eks == 1)
        {
            Response.Redirect("0000176.aspx?ID=" + kategoriList.SelectedValue + "&S=" + soneklenen + "&islem=Y");
            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('BAŞARILI', 'Ekip üyesi başarıyla eklendi.', 'success');", true);
        }
        else
        {
            panel_sonuc.Visible = true;
            sonuc.Text  = "Ekip üyesi ekleme işlemi başarısız!";
            sonuc.ForeColor = System.Drawing.Color.Red;

        }

    }
}