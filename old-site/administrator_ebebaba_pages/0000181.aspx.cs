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
            bilgiYukle();
        }
    }

    private void bilgiYukle()
    {

        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
        MySqlDataAdapter da = new MySqlDataAdapter("Select * from ekipiceriktablosu where ID="+Request.QueryString["ID"].ToString()+"", connect_word);
        DataTable dt = new DataTable();
        da.Fill(dt);

        kategoriList.SelectedValue = dt.Rows[0]["kategori"].ToString();
        txtBaslik.Text = dt.Rows[0]["baslik"].ToString();
        txtAciklama.Text = dt.Rows[0]["aciklama"].ToString();
        txtYoutube.Text = dt.Rows[0]["youtube"].ToString();
        txtFacebook.Text = dt.Rows[0]["facebook"].ToString();
        txtInstagram.Text = dt.Rows[0]["instagram"].ToString();
        txtPosta.Text = dt.Rows[0]["mail"].ToString();

        yayin.SelectedValue = dt.Rows[0]["yayin"].ToString();
        txtKapak.Value = dt.Rows[0]["kapakResmi"].ToString();
        secilenKapakResmi.InnerHtml = "<img src='../uploadImages/" + txtKapak.Value + "_450.jpg'/>";

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
            panel2.Visible = true;
            Label4.Text = "Üye pozisyonunu seçiniz!";
            Label4.ForeColor = System.Drawing.Color.Red;


        }

        else if (txtBaslik.Text == "")
        {
            panel2.Visible = true;
            Label4.Text = "Ekip üyesinin ad-soyad bilgisini giriniz!";
            Label4.ForeColor = System.Drawing.Color.Red;


        }

        else if (txtKapak.Value == "")
        {
            panel2.Visible = true;
            Label4.Text = "Ekip üyesinin resmini seçiniz!";
            Label4.ForeColor = System.Drawing.Color.Red;
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


        
        MySqlCommand cmd = new MySqlCommand("Update ekipiceriktablosu set baslik=?1,aciklama=?2,kapakResmi=?3,youtube=?4,facebook=?5,instagram=?6,yayin=?7,kategori=?8,mail=?9 where ID=?10", connect_word);
      
        cmd.Parameters.AddWithValue("?1",txtBaslik.Text);
        cmd.Parameters.AddWithValue("?2",txtAciklama.Text);
        cmd.Parameters.AddWithValue("?3",txtKapak.Value);
        cmd.Parameters.AddWithValue("?4", txtYoutube.Text);
        cmd.Parameters.AddWithValue("?5", txtFacebook.Text);
        cmd.Parameters.AddWithValue("?6", txtInstagram.Text);
        cmd.Parameters.AddWithValue("?7", yayin.SelectedValue.ToString());
        cmd.Parameters.AddWithValue("?8", kategoriList.SelectedValue);
        cmd.Parameters.AddWithValue("?9", txtPosta.Text);
        cmd.Parameters.AddWithValue("?10", Request.QueryString["ID"].ToString());

        connect_word.Open();
        int eks = cmd.ExecuteNonQuery();
        connect_word.Close();

        if (eks == 1)
        {
            Response.Redirect("0000176.aspx?ID=" + kategoriList.SelectedValue + "&S=" + Request.QueryString["ID"].ToString() + "&islem=G");
        }
        else
        {
            panel2.Visible = true;
            Label4.Text = "Güncelleme işlemi başarısız!";
            Label4.ForeColor = System.Drawing.Color.Red;
        }

    }
}