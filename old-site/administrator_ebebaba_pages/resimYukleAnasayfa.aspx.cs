using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SD = System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;


public partial class administrator_ebebaba_pages_resimYukle : System.Web.UI.Page
{

    String path = HttpContext.Current.Request.PhysicalApplicationPath + @"uploadImages\";
    ebebaba_connect_class noc = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {



    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string kod = aktivasyonKodu(20);

        MySqlConnection baglanti = noc.connect_ebebaba(0301009184);
        MySqlCommand cmd = new MySqlCommand("Insert into resimhavuzuanasayfa(adi,tarih,onay) values (?1,?2,?3)", baglanti);
        cmd.Parameters.AddWithValue("?1", kod);
        cmd.Parameters.AddWithValue("?2", DateTime.Now);
        cmd.Parameters.AddWithValue("?3", "-");
   

        baglanti.Open();
        int eks = cmd.ExecuteNonQuery();
        Label3.Text = cmd.LastInsertedId.ToString();
        baglanti.Close();
        if (eks == 1)
        {
            string resimAdi = kod;
            Label2.Text = resimAdi;
            resim.SaveAs(Server.MapPath("~/uploadImages/" + resimAdi + ".jpg"));

            FileInfo dosya = new FileInfo(Server.MapPath("~/uploadImages/" + resimAdi + ".jpg"));

            if (dosya.Exists)
            {
                Panel1.Visible = true;
               
                resimislem2 yeniresim2 = new resimislem2();
                System.Drawing.Image kucuk2 = yeniresim2.ResimOlustur(600, Server.MapPath("~/uploadImages/" + Label2.Text + ".jpg"));
                kucuk2.Save(Server.MapPath("~/uploadImages/" + Label2.Text + "_500.jpg"));
                resim500.ImageUrl = "~/uploadImages/" + resimAdi + "_500.jpg";

                Button2.Visible = true;
             
            }
            else
            {


            }



        }
        else
        {
            // ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "swal('HATA !', 'Kayıt işlemi başarısız ! Lütfen bilgileri kontrol ederek tekrar deneyiniz...', 'error');", true);
        }

      
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
    
        string ImageName = Label2.Text + "_500.jpg";
        int w = Convert.ToInt32(W500.Value);
        int h = Convert.ToInt32(H500.Value);
        int x = Convert.ToInt32(X500.Value);
        int y = Convert.ToInt32(Y500.Value);

        byte[] CropImage = Crop(path + ImageName, w, h, x, y);
        using (MemoryStream ms = new MemoryStream(CropImage, 0, CropImage.Length))
        {
            ms.Write(CropImage, 0, CropImage.Length);
            using (SD.Image CroppedImage = SD.Image.FromStream(ms, true))
            {
                string SaveTo = path + Label2.Text + "_450.jpg";
                CroppedImage.Save(SaveTo, CroppedImage.RawFormat);
                //pnlCrop.Visible = false;
                //pnlCropped.Visible = true;
                //imgCropped.ImageUrl = "/resimler/crop" + Request.QueryString["id"].ToString() + "_500.jpg";
            }
        }

  //      this.ClientScript.RegisterClientScriptBlock(this.GetType(), "Close", "window.close()", true);


        // resim500.ImageUrl = "~/otelImages/" + Label2.Text + "_900.jpg";

        digerleriniYukle();

      
    }

    private void digerleriniYukle()
    {
        MySqlConnection baglanti = noc.connect_ebebaba(0301009184);
        //resimislem yeniresim2 = new resimislem();
        //System.Drawing.Image kucuk2 = yeniresim2.ResimOlustur(300, Server.MapPath("~/uploadImages/" + Label2.Text + "_450.jpg"));

        //resimislem yeniresim3 = new resimislem();
        //System.Drawing.Image kucuk3 = yeniresim3.ResimOlustur(225, Server.MapPath("~/uploadImages/" + Label2.Text + "_450.jpg"));

        //kucuk2.Save(Server.MapPath("~/uploadImages/" + Label2.Text + "_300.jpg"));
        //kucuk3.Save(Server.MapPath("~/uploadImages/" + Label2.Text + "_225.jpg"));

        MySqlCommand cmd2 = new MySqlCommand("Update resimhavuzuanasayfa set onay='+' where ID=" + Label3.Text + "", baglanti);
        baglanti.Open();
        int eks2 = cmd2.ExecuteNonQuery();
        baglanti.Close();


        Response.Redirect("havuzAnasayfa.aspx?gonderen=kapak");
       // ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Close", "parent.jQuery.colorbox.close();", true);
       // ScriptManager.RegisterClientScriptBlock(this.Page, this.GetType(), "Fonksiyon", "parent.location.reload();", true);
        


    }

    static byte[] Crop(string Img, int Width, int Height, int X, int Y)
    {
        try
        {
            using (SD.Image OriginalImage = SD.Image.FromFile(Img))
            {
                using (SD.Bitmap bmp = new SD.Bitmap(Width, Height))
                {
                    bmp.SetResolution(OriginalImage.HorizontalResolution, OriginalImage.VerticalResolution);
                    using (SD.Graphics Graphic = SD.Graphics.FromImage(bmp))
                    {
                        Graphic.SmoothingMode = SmoothingMode.AntiAlias;
                        Graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        Graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        Graphic.DrawImage(OriginalImage, new SD.Rectangle(0, 0, Width, Height), X, Y, Width, Height, SD.GraphicsUnit.Pixel);
                        MemoryStream ms = new MemoryStream();
                        bmp.Save(ms, OriginalImage.RawFormat);
                        return ms.GetBuffer();
                    }
                }
            }
        }
        catch (Exception Ex)
        {
            throw (Ex);
        }
    }
    public string aktivasyonKodu(int codeLength)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        System.Random objRandom = new System.Random();

        string[] strChars = { "A","B","C","D","E","F","G","H","I", 

                            "J","K","L","M","N","O","P","Q","R",

                            "S","T","U","V","W","X","Y","Z",

                            "1","2","3","4","5","6","7","8","9","0",

                            "a","b","c","d","e","f","g","h","i","j","k",

                            "l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};

        int maxRand = strChars.GetUpperBound(0);
        for (int i = 0; i <= codeLength; i++)
        { int rndNumber = objRandom.Next(maxRand); sb.Append(strChars[rndNumber]); }
        return sb.ToString();
    }
}