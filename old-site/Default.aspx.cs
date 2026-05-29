using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    ebebaba_connect_class noc = new ebebaba_connect_class();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           // blogYukle();
            bolumleriYukle();
          //  ekipYukle();
            siteleriYukle();
        }
    }

    private void siteleriYukle()
    {


        try
        {
            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from siteler where yayin='+' order by sira asc", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string eklenecekSiteler = "";
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                eklenecekSiteler += "<div class='grid-item'>";
                eklenecekSiteler += "<div class='cnt-box cnt-box-top-icon boxed'>";
                eklenecekSiteler += "<a href='" + dt.Rows[a]["adres"].ToString() + "'  style='text-decoration:none;'>";
                eklenecekSiteler += "<img src='uploadImages/" + dt.Rows[a]["resim"].ToString() + "_450.jpg' />";
                eklenecekSiteler += "<div class='caption'>";
                eklenecekSiteler += "<h2 style='text-align:center;'>" + dt.Rows[a]["siteAdi"].ToString() + "</h2>";
                eklenecekSiteler += "</div>";
                eklenecekSiteler += "</a>";
                eklenecekSiteler += "</div>";
                eklenecekSiteler += "</div>";



            }



            divSiteler.InnerHtml = eklenecekSiteler;

        }
        catch
        { 
        
        }
    }

    private void bolumleriYukle()
    {

        try
        {

            MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from anasayfatasarimi order by sira asc", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string bolum1Metni = "";
            bolum1Metni += "<h3 class='text-color-2' style='text-transform:none;'>";
            if (dt.Rows[0]["satir1"].ToString() != "")
            {
                bolum1Metni += dt.Rows[0]["satir1"].ToString();
            }
            if (dt.Rows[0]["satir2"].ToString() != "")
            {
                bolum1Metni += "<br>" + dt.Rows[0]["satir2"].ToString();
            }
            bolum1Metni += "</h3>";
            bolum1Metni += "<ul class='slider' data-options='arrows:false,nav:false,autoplay:3000,controls:out'>";
            bolum1Metni += "<li><h1 class='text-uppercase'>";
            if (dt.Rows[0]["satir3"].ToString() != "")
            {
                bolum1Metni += dt.Rows[0]["satir3"].ToString();
            }
            if (dt.Rows[0]["satir4"].ToString() != "")
            {
                bolum1Metni += "<br>" + dt.Rows[0]["satir4"].ToString();
            }
            if (dt.Rows[0]["satir5"].ToString() != "")
            {
                bolum1Metni += "<br>" + dt.Rows[0]["satir5"].ToString();
            }
            bolum1Metni += "</h1>";
            bolum1Metni += "<div style='padding:15px;margin-top:10px;margin-left:-40px;'>";
            bolum1Metni += "<ul>";

            if (dt.Rows[0]["satir6"].ToString() != "")
            {
                bolum1Metni += "<li>" + dt.Rows[0]["satir6"].ToString() + "</li>";
            }
            if (dt.Rows[0]["satir7"].ToString() != "")
            {
                bolum1Metni += "<li>" + dt.Rows[0]["satir7"].ToString() + "</li>";
            }
            if (dt.Rows[0]["satir8"].ToString() != "")
            {
                bolum1Metni += "<li>" + dt.Rows[0]["satir8"].ToString() + "</li>";
            }
            if (dt.Rows[0]["satir9"].ToString() != "")
            {
                bolum1Metni += "<li>" + dt.Rows[0]["satir9"].ToString() + "</li>";
            }
            if (dt.Rows[0]["satir10"].ToString() != "")
            {
                bolum1Metni += "<li>" + dt.Rows[0]["satir10"].ToString() + "</li>";
            }

            bolum1Metni += "</ul>";
            bolum1Metni += "</div></li></ul>";

            bolum1.InnerHtml = bolum1Metni;



            string bolum2Metni = "";

            if (dt.Rows[1]["hizalama"].ToString() == "L")
            {
                bolum2Metni += "<div class='col-lg-6'>";
                bolum2Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum2Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[1]["satir3"].ToString() != "")
                {
                    bolum2Metni += "<a href='" + dt.Rows[1]["satir3"].ToString() + "' ><img src='uploadImages/" + dt.Rows[1]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum2Metni += "<img src='uploadImages/" + dt.Rows[1]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum2Metni += "</span>";
                bolum2Metni += "</li>";
                bolum2Metni += "</ul>";
                bolum2Metni += "</div>";

                bolum2Metni += "<div class='col-lg-6'>";
                bolum2Metni += "<div class='title'>";
                if (dt.Rows[1]["satir1"].ToString() != "")
                {
                    bolum2Metni += "<h2>" + dt.Rows[1]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[1]["satir6"].ToString() != "")
                {
                    bolum2Metni += "<p>" + dt.Rows[1]["satir6"].ToString() + "</p>";

                }
                bolum2Metni += "</div>";
                if (dt.Rows[1]["satir2"].ToString() != "")
                {
                    bolum2Metni += "<p>" + dt.Rows[1]["satir2"].ToString() + "</p>";

                }
                bolum2Metni += "<div style='text-align:left;'>";
                if (dt.Rows[1]["satir5"].ToString() != "")
                {
                    if (dt.Rows[1]["satir3"].ToString() != "")
                    {
                        bolum2Metni += "<a href='" + dt.Rows[1]["satir3"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[1]["satir5"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum2Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[1]["satir5"].ToString() + "</a>";

                    }

                }
                bolum2Metni += "</div></div>";
            }
            else
            {

                bolum2Metni += "<div class='col-lg-6'>";
                bolum2Metni += "<div class='title'>";
                if (dt.Rows[1]["satir1"].ToString() != "")
                {
                    bolum2Metni += "<h2>" + dt.Rows[1]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[1]["satir6"].ToString() != "")
                {
                    bolum2Metni += "<p>" + dt.Rows[1]["satir6"].ToString() + "</p>";

                }
                bolum2Metni += "</div>";
                if (dt.Rows[1]["satir2"].ToString() != "")
                {
                    bolum2Metni += "<p>" + dt.Rows[1]["satir2"].ToString() + "</p>";

                }
                bolum2Metni += "<div style='text-align:left;'>";
                if (dt.Rows[1]["satir5"].ToString() != "")
                {
                    if (dt.Rows[1]["satir3"].ToString() != "")
                    {
                        bolum2Metni += "<a href='" + dt.Rows[1]["satir3"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[1]["satir5"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum2Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[1]["satir5"].ToString() + "</a>";

                    }

                }
                bolum2Metni += "</div></div>";

                bolum2Metni += "<div class='col-lg-6'>";
                bolum2Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum2Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[1]["satir3"].ToString() != "")
                {
                    bolum2Metni += "<a href='" + dt.Rows[1]["satir3"].ToString() + "' ><img src='uploadImages/" + dt.Rows[1]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum2Metni += "<img src='uploadImages/" + dt.Rows[1]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum2Metni += "</span>";
                bolum2Metni += "</li>";
                bolum2Metni += "</ul>";
                bolum2Metni += "</div>";
            }

            if (dt.Rows[1]["yayin"].ToString() == "+")
            {
                bolum2.InnerHtml = bolum2Metni;
            }



            string bolum3Metni = "";

            if (dt.Rows[2]["hizalama"].ToString() == "L")
            {
                bolum3Metni += "<div class='col-lg-6'>";
                bolum3Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum3Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";

                if (dt.Rows[2]["satir4"].ToString() != "")
                {
                    bolum3Metni += "<a href='" + dt.Rows[2]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[2]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum3Metni += "<img src='uploadImages/" + dt.Rows[2]["resim"].ToString() + "_450.jpg' alt=''>";
                }

                bolum3Metni += "</span>";
                bolum3Metni += "</li>";
                bolum3Metni += "</ul>";
                bolum3Metni += "</div>";

                bolum3Metni += "<div class='col-lg-6'>";
                bolum3Metni += "<div class='title'>";
                if (dt.Rows[2]["satir1"].ToString() != "")
                {
                    bolum3Metni += "<h2>" + dt.Rows[2]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[2]["satir8"].ToString() != "")
                {
                    bolum3Metni += "<p>" + dt.Rows[2]["satir8"].ToString() + "</p>";

                }
                bolum3Metni += "</div>";
                if (dt.Rows[2]["satir2"].ToString() != "")
                {
                    bolum3Metni += "<p>" + dt.Rows[2]["satir2"].ToString() + "</p>";

                }
                bolum3Metni += "<div style='text-align:left;'>";
                if (dt.Rows[2]["satir3"].ToString() != "")
                {
                    if (dt.Rows[2]["satir4"].ToString() != "")
                    {
                        bolum3Metni += "<a href='" + dt.Rows[2]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[2]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum3Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[2]["satir3"].ToString() + "</a>";

                    }

                }

                if (dt.Rows[2]["satir5"].ToString() != "")
                {
                    if (dt.Rows[2]["satir6"].ToString() != "")
                    {
                        bolum3Metni += "<a href='" + dt.Rows[2]["satir6"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[2]["satir5"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum3Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[2]["satir5"].ToString() + "</a>";

                    }

                }


                bolum3Metni += "</div></div>";
            }
            else
            {

                bolum3Metni += "<div class='col-lg-6'>";
                bolum3Metni += "<div class='title'>";
                if (dt.Rows[2]["satir1"].ToString() != "")
                {
                    bolum3Metni += "<h2>" + dt.Rows[2]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[2]["satir8"].ToString() != "")
                {
                    bolum3Metni += "<p>" + dt.Rows[2]["satir8"].ToString() + "</p>";

                }
                bolum3Metni += "</div>";
                if (dt.Rows[2]["satir2"].ToString() != "")
                {
                    bolum3Metni += "<p>" + dt.Rows[2]["satir2"].ToString() + "</p>";

                }
                bolum3Metni += "<div style='text-align:left;'>";
                if (dt.Rows[2]["satir3"].ToString() != "")
                {
                    if (dt.Rows[2]["satir4"].ToString() != "")
                    {
                        bolum3Metni += "<a href='" + dt.Rows[2]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[2]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum3Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[2]["satir3"].ToString() + "</a>";

                    }

                }

                if (dt.Rows[2]["satir5"].ToString() != "")
                {
                    if (dt.Rows[2]["satir6"].ToString() != "")
                    {
                        bolum3Metni += "<a href='" + dt.Rows[2]["satir6"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[2]["satir5"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum3Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[2]["satir5"].ToString() + "</a>";

                    }

                }


                bolum3Metni += "</div></div>";

                bolum3Metni += "<div class='col-lg-6'>";
                bolum3Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum3Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[2]["satir4"].ToString() != "")
                {
                    bolum3Metni += "<a href='" + dt.Rows[2]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[2]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum3Metni += "<img src='uploadImages/" + dt.Rows[2]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum3Metni += "</span>";
                bolum3Metni += "</li>";
                bolum3Metni += "</ul>";
                bolum3Metni += "</div>";


            }

            if (dt.Rows[2]["yayin"].ToString() == "+")
            {
                string arkaRenk = "#fff;";
                if (dt.Rows[2]["arkaplan"].ToString() != "")
                {
                    arkaRenk = "#E4EDF3;";
                }

                string once = "<section class='section-base' style='padding-top:40px;padding-bottom:40px;background-color:" + arkaRenk + "'>";
                once += "<div class='container'><div class='row row-fit-lg' data-anima='fade-bottom' data-time='1000'>";
                once += bolum3Metni;
                once += "</div></div></section>";


                bolum3.InnerHtml = once;
            }





















            string bolum4Metni = "";

            if (dt.Rows[3]["hizalama"].ToString() == "L")
            {
                bolum4Metni += "<div class='col-lg-6'>";
                bolum4Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum4Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[3]["satir4"].ToString() != "")
                {
                    bolum4Metni += "<a href='" + dt.Rows[3]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[3]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum4Metni += "<img src='uploadImages/" + dt.Rows[3]["resim"].ToString() + "_450.jpg' alt=''>";
                }

                bolum4Metni += "</span>";
                bolum4Metni += "</li>";
                bolum4Metni += "</ul>";
                bolum4Metni += "</div>";

                bolum4Metni += "<div class='col-lg-6'>";
                bolum4Metni += "<div class='title'>";
                if (dt.Rows[3]["satir1"].ToString() != "")
                {
                    bolum4Metni += "<h2>" + dt.Rows[3]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[3]["satir5"].ToString() != "")
                {
                    bolum4Metni += "<p>" + dt.Rows[3]["satir5"].ToString() + "</p>";

                }
                bolum4Metni += "</div>";
                if (dt.Rows[3]["satir2"].ToString() != "")
                {
                    bolum4Metni += "<p>" + dt.Rows[3]["satir2"].ToString() + "</p>";

                }
                bolum4Metni += "<div style='text-align:left;'>";
                if (dt.Rows[3]["satir3"].ToString() != "")
                {
                    if (dt.Rows[3]["satir4"].ToString() != "")
                    {
                        bolum4Metni += "<a href='" + dt.Rows[3]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[3]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum4Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[3]["satir3"].ToString() + "</a>";

                    }

                }


                bolum4Metni += "</div></div>";
            }
            else
            {

                bolum4Metni += "<div class='col-lg-6'>";
                bolum4Metni += "<div class='title'>";
                if (dt.Rows[3]["satir1"].ToString() != "")
                {
                    bolum4Metni += "<h2>" + dt.Rows[3]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[3]["satir5"].ToString() != "")
                {
                    bolum4Metni += "<p>" + dt.Rows[3]["satir5"].ToString() + "</p>";

                }
                bolum4Metni += "</div>";
                if (dt.Rows[3]["satir2"].ToString() != "")
                {
                    bolum4Metni += "<p>" + dt.Rows[3]["satir2"].ToString() + "</p>";

                }
                bolum4Metni += "<div style='text-align:left;'>";
                if (dt.Rows[3]["satir3"].ToString() != "")
                {
                    if (dt.Rows[3]["satir4"].ToString() != "")
                    {
                        bolum4Metni += "<a href='" + dt.Rows[3]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[3]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum4Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[3]["satir3"].ToString() + "</a>";

                    }

                }


                bolum4Metni += "</div></div>";


                bolum4Metni += "<div class='col-lg-6'>";
                bolum4Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum4Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[3]["satir4"].ToString() != "")
                {
                    bolum4Metni += "<a href='" + dt.Rows[3]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[3]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum4Metni += "<img src='uploadImages/" + dt.Rows[3]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum4Metni += "</span>";
                bolum4Metni += "</li>";
                bolum4Metni += "</ul>";
                bolum4Metni += "</div>";

            }

            if (dt.Rows[3]["yayin"].ToString() == "+")
            {
                string arkaRenk = "#fff;";
                if (dt.Rows[3]["arkaplan"].ToString() != "")
                {
                    arkaRenk = "#E4EDF3;";
                }

                string once = "<section class='section-base' style='padding-top:40px;padding-bottom:40px;background-color:" + arkaRenk + "'>";
                once += "<div class='container'><div class='row row-fit-lg' data-anima='fade-bottom' data-time='1000'>";
                once += bolum4Metni;
                once += "</div></div></section>";


                bolum4.InnerHtml = once;
            }










            string bolum5Metni = "";

            if (dt.Rows[4]["hizalama"].ToString() == "L")
            {
                bolum5Metni += "<div class='col-lg-6'>";
                bolum5Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum5Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";

                if (dt.Rows[4]["satir4"].ToString() != "")
                {
                    bolum5Metni += "<a href='" + dt.Rows[4]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[4]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum5Metni += "<img src='uploadImages/" + dt.Rows[4]["resim"].ToString() + "_450.jpg' alt=''>";
                }

                bolum5Metni += "</span>";
                bolum5Metni += "</li>";
                bolum5Metni += "</ul>";
                bolum5Metni += "</div>";

                bolum5Metni += "<div class='col-lg-6'>";
                bolum5Metni += "<div class='title'>";
                if (dt.Rows[4]["satir1"].ToString() != "")
                {
                    bolum5Metni += "<h2>" + dt.Rows[4]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[4]["satir5"].ToString() != "")
                {
                    bolum5Metni += "<p>" + dt.Rows[4]["satir5"].ToString() + "</p>";

                }
                bolum5Metni += "</div>";
                if (dt.Rows[4]["satir2"].ToString() != "")
                {
                    bolum5Metni += "<p>" + dt.Rows[4]["satir2"].ToString() + "</p>";

                }
                bolum5Metni += "<div style='text-align:left;'>";
                if (dt.Rows[4]["satir3"].ToString() != "")
                {
                    if (dt.Rows[4]["satir4"].ToString() != "")
                    {
                        bolum5Metni += "<a href='" + dt.Rows[4]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[4]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum5Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[4]["satir3"].ToString() + "</a>";

                    }

                }


                bolum5Metni += "</div></div>";
            }
            else
            {

                bolum5Metni += "<div class='col-lg-6'>";
                bolum5Metni += "<div class='title'>";
                if (dt.Rows[4]["satir1"].ToString() != "")
                {
                    bolum5Metni += "<h2>" + dt.Rows[4]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[4]["satir5"].ToString() != "")
                {
                    bolum5Metni += "<p>" + dt.Rows[4]["satir5"].ToString() + "</p>";

                }
                bolum5Metni += "</div>";
                if (dt.Rows[4]["satir2"].ToString() != "")
                {
                    bolum5Metni += "<p>" + dt.Rows[4]["satir2"].ToString() + "</p>";

                }
                bolum5Metni += "<div style='text-align:left;'>";
                if (dt.Rows[4]["satir3"].ToString() != "")
                {
                    if (dt.Rows[4]["satir4"].ToString() != "")
                    {
                        bolum5Metni += "<a href='" + dt.Rows[4]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[4]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum5Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[4]["satir3"].ToString() + "</a>";

                    }

                }


                bolum5Metni += "</div></div>";


                bolum5Metni += "<div class='col-lg-6'>";
                bolum5Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum5Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[4]["satir4"].ToString() != "")
                {
                    bolum5Metni += "<a href='" + dt.Rows[4]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[4]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum5Metni += "<img src='uploadImages/" + dt.Rows[4]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum5Metni += "</span>";
                bolum5Metni += "</li>";
                bolum5Metni += "</ul>";
                bolum5Metni += "</div>";

            }

            if (dt.Rows[4]["yayin"].ToString() == "+")
            {
                string arkaRenk = "#fff;";
                if (dt.Rows[4]["arkaplan"].ToString() != "")
                {
                    arkaRenk = "#E4EDF3;";
                }

                string once = "<section class='section-base' style='padding-top:40px;padding-bottom:40px;background-color:" + arkaRenk + "'>";
                once += "<div class='container'><div class='row row-fit-lg' data-anima='fade-bottom' data-time='1000'>";
                once += bolum5Metni;
                once += "</div></div></section>";


                bolum5.InnerHtml = once;
            }















            string bolum6Metni = "";

            if (dt.Rows[5]["hizalama"].ToString() == "L")
            {
                bolum6Metni += "<div class='col-lg-6'>";
                bolum6Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum6Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[5]["satir4"].ToString() != "")
                {
                    bolum6Metni += "<a href='" + dt.Rows[5]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[5]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum6Metni += "<img src='uploadImages/" + dt.Rows[5]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum6Metni += "</span>";
                bolum6Metni += "</li>";
                bolum6Metni += "</ul>";
                bolum6Metni += "</div>";

                bolum6Metni += "<div class='col-lg-6'>";
                bolum6Metni += "<div class='title'>";
                if (dt.Rows[5]["satir1"].ToString() != "")
                {
                    bolum6Metni += "<h2>" + dt.Rows[5]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[5]["satir5"].ToString() != "")
                {
                    bolum6Metni += "<p>" + dt.Rows[5]["satir5"].ToString() + "</p>";

                }
                bolum6Metni += "</div>";
                if (dt.Rows[5]["satir2"].ToString() != "")
                {
                    bolum6Metni += "<p>" + dt.Rows[5]["satir2"].ToString() + "</p>";

                }
                bolum6Metni += "<div style='text-align:left;'>";
                if (dt.Rows[5]["satir3"].ToString() != "")
                {
                    if (dt.Rows[5]["satir4"].ToString() != "")
                    {
                        bolum6Metni += "<a href='" + dt.Rows[5]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[5]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum6Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[5]["satir3"].ToString() + "</a>";

                    }

                }


                bolum6Metni += "</div></div>";
            }
            else
            {

                bolum6Metni += "<div class='col-lg-6'>";
                bolum6Metni += "<div class='title'>";
                if (dt.Rows[5]["satir1"].ToString() != "")
                {
                    bolum6Metni += "<h2>" + dt.Rows[5]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[5]["satir5"].ToString() != "")
                {
                    bolum6Metni += "<p>" + dt.Rows[5]["satir5"].ToString() + "</p>";

                }
                bolum6Metni += "</div>";
                if (dt.Rows[5]["satir2"].ToString() != "")
                {
                    bolum6Metni += "<p>" + dt.Rows[5]["satir2"].ToString() + "</p>";

                }
                bolum6Metni += "<div style='text-align:left;'>";
                if (dt.Rows[5]["satir3"].ToString() != "")
                {
                    if (dt.Rows[5]["satir4"].ToString() != "")
                    {
                        bolum6Metni += "<a href='" + dt.Rows[5]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[5]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum6Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[5]["satir3"].ToString() + "</a>";

                    }

                }


                bolum6Metni += "</div></div>";


                bolum6Metni += "<div class='col-lg-6'>";
                bolum6Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum6Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[5]["satir4"].ToString() != "")
                {
                    bolum6Metni += "<a href='" + dt.Rows[5]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[5]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum6Metni += "<img src='uploadImages/" + dt.Rows[5]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum6Metni += "</span>";
                bolum6Metni += "</li>";
                bolum6Metni += "</ul>";
                bolum6Metni += "</div>";

            }

            if (dt.Rows[5]["yayin"].ToString() == "+")
            {
                string arkaRenk = "#fff;";
                if (dt.Rows[5]["arkaplan"].ToString() != "")
                {
                    arkaRenk = "#E4EDF3;";
                }

                string once = "<section class='section-base' style='padding-top:40px;padding-bottom:40px;background-color:" + arkaRenk + "'>";
                once += "<div class='container'><div class='row row-fit-lg' data-anima='fade-bottom' data-time='1000'>";
                once += bolum6Metni;
                once += "</div></div></section>";


                bolum6.InnerHtml = once;
            }










            string bolum7Metni = "";

            if (dt.Rows[6]["hizalama"].ToString() == "L")
            {
                bolum7Metni += "<div class='col-lg-6'>";
                bolum7Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum7Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[6]["satir4"].ToString() != "")
                {
                    bolum7Metni += "<a href='" + dt.Rows[6]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[6]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum7Metni += "<img src='uploadImages/" + dt.Rows[6]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum7Metni += "</span>";
                bolum7Metni += "</li>";
                bolum7Metni += "</ul>";
                bolum7Metni += "</div>";

                bolum7Metni += "<div class='col-lg-6'>";
                bolum7Metni += "<div class='title'>";
                if (dt.Rows[6]["satir1"].ToString() != "")
                {
                    bolum7Metni += "<h2>" + dt.Rows[6]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[6]["satir5"].ToString() != "")
                {
                    bolum7Metni += "<p>" + dt.Rows[6]["satir5"].ToString() + "</p>";

                }
                bolum7Metni += "</div>";
                if (dt.Rows[6]["satir2"].ToString() != "")
                {
                    bolum7Metni += "<p>" + dt.Rows[6]["satir2"].ToString() + "</p>";

                }
                bolum7Metni += "<div style='text-align:left;'>";
                if (dt.Rows[6]["satir3"].ToString() != "")
                {
                    if (dt.Rows[6]["satir4"].ToString() != "")
                    {
                        bolum7Metni += "<a href='" + dt.Rows[6]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[6]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum7Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[6]["satir3"].ToString() + "</a>";

                    }

                }


                bolum7Metni += "</div></div>";
            }
            else
            {

                bolum7Metni += "<div class='col-lg-6'>";
                bolum7Metni += "<div class='title'>";
                if (dt.Rows[6]["satir1"].ToString() != "")
                {
                    bolum7Metni += "<h2>" + dt.Rows[6]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[6]["satir5"].ToString() != "")
                {
                    bolum7Metni += "<p>" + dt.Rows[6]["satir5"].ToString() + "</p>";

                }
                bolum7Metni += "</div>";
                if (dt.Rows[6]["satir2"].ToString() != "")
                {
                    bolum7Metni += "<p>" + dt.Rows[6]["satir2"].ToString() + "</p>";

                }
                bolum7Metni += "<div style='text-align:left;'>";
                if (dt.Rows[6]["satir3"].ToString() != "")
                {
                    if (dt.Rows[6]["satir4"].ToString() != "")
                    {
                        bolum7Metni += "<a href='" + dt.Rows[6]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[6]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum7Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[6]["satir3"].ToString() + "</a>";

                    }

                }


                bolum7Metni += "</div></div>";


                bolum7Metni += "<div class='col-lg-6'>";
                bolum7Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum7Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[6]["satir4"].ToString() != "")
                {
                    bolum7Metni += "<a href='" + dt.Rows[6]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[6]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum7Metni += "<img src='uploadImages/" + dt.Rows[6]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum7Metni += "</span>";
                bolum7Metni += "</li>";
                bolum7Metni += "</ul>";
                bolum7Metni += "</div>";

            }

            if (dt.Rows[6]["yayin"].ToString() == "+")
            {
                string arkaRenk = "#fff;";
                if (dt.Rows[6]["arkaplan"].ToString() != "")
                {
                    arkaRenk = "#E4EDF3;";
                }

                string once = "<section class='section-base' style='padding-top:40px;padding-bottom:40px;background-color:" + arkaRenk + "'>";
                once += "<div class='container'><div class='row row-fit-lg' data-anima='fade-bottom' data-time='1000'>";
                once += bolum7Metni;
                once += "</div></div></section>";


                bolum7.InnerHtml = once;
            }






            string bolum8Metni = "";

            if (dt.Rows[7]["hizalama"].ToString() == "L")
            {
                bolum8Metni += "<div class='col-lg-6'>";
                bolum8Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum8Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[7]["satir4"].ToString() != "")
                {
                    bolum8Metni += "<a href='" + dt.Rows[7]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[7]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum8Metni += "<img src='uploadImages/" + dt.Rows[7]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum8Metni += "</span>";
                bolum8Metni += "</li>";
                bolum8Metni += "</ul>";
                bolum8Metni += "</div>";

                bolum8Metni += "<div class='col-lg-6'>";
                bolum8Metni += "<div class='title'>";
                if (dt.Rows[7]["satir1"].ToString() != "")
                {
                    bolum8Metni += "<h2>" + dt.Rows[7]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[7]["satir5"].ToString() != "")
                {
                    bolum8Metni += "<p>" + dt.Rows[7]["satir5"].ToString() + "</p>";

                }
                bolum8Metni += "</div>";
                if (dt.Rows[7]["satir2"].ToString() != "")
                {
                    bolum8Metni += "<p>" + dt.Rows[7]["satir2"].ToString() + "</p>";

                }
                bolum8Metni += "<div style='text-align:left;'>";
                if (dt.Rows[7]["satir3"].ToString() != "")
                {
                    if (dt.Rows[7]["satir4"].ToString() != "")
                    {
                        bolum8Metni += "<a href='" + dt.Rows[7]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[7]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum8Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[7]["satir3"].ToString() + "</a>";

                    }

                }


                bolum8Metni += "</div></div>";
            }
            else
            {

                bolum8Metni += "<div class='col-lg-6'>";
                bolum8Metni += "<div class='title'>";
                if (dt.Rows[7]["satir1"].ToString() != "")
                {
                    bolum8Metni += "<h2>" + dt.Rows[7]["satir1"].ToString() + "</h2>";
                }
                if (dt.Rows[7]["satir5"].ToString() != "")
                {
                    bolum8Metni += "<p>" + dt.Rows[7]["satir5"].ToString() + "</p>";

                }
                bolum8Metni += "</div>";
                if (dt.Rows[7]["satir2"].ToString() != "")
                {
                    bolum8Metni += "<p>" + dt.Rows[7]["satir2"].ToString() + "</p>";

                }
                bolum8Metni += "<div style='text-align:left;'>";
                if (dt.Rows[7]["satir3"].ToString() != "")
                {
                    if (dt.Rows[7]["satir4"].ToString() != "")
                    {
                        bolum8Metni += "<a href='" + dt.Rows[7]["satir4"].ToString() + "'  class='btn width-190 full-width-sm' >" + dt.Rows[7]["satir3"].ToString() + "</a>";

                    }
                    else
                    {
                        bolum8Metni += "<a href='#'  class='btn width-190 full-width-sm'>" + dt.Rows[7]["satir3"].ToString() + "</a>";

                    }

                }


                bolum8Metni += "</div></div>";


                bolum8Metni += "<div class='col-lg-6'>";
                bolum8Metni += "<ul class='slider' data-options='arrows:false,nav:false'>";
                bolum8Metni += "<li><span class='img-box img-box-caption'  data-lightbox-anima='fade-top'>";
                if (dt.Rows[7]["satir4"].ToString() != "")
                {
                    bolum8Metni += "<a href='" + dt.Rows[7]["satir4"].ToString() + "' ><img src='uploadImages/" + dt.Rows[7]["resim"].ToString() + "_450.jpg' alt=''></a>";
                }
                else
                {
                    bolum8Metni += "<img src='uploadImages/" + dt.Rows[7]["resim"].ToString() + "_450.jpg' alt=''>";
                }
                bolum8Metni += "</span>";
                bolum8Metni += "</li>";
                bolum8Metni += "</ul>";
                bolum8Metni += "</div>";

            }

            if (dt.Rows[7]["yayin"].ToString() == "+")
            {
                string arkaRenk = "#fff;";
                if (dt.Rows[7]["arkaplan"].ToString() != "")
                {
                    arkaRenk = "#E4EDF3;";
                }

                string once = "<section class='section-base' style='padding-top:40px;padding-bottom:40px;background-color:" + arkaRenk + "'>";
                once += "<div class='container'><div class='row row-fit-lg' data-anima='fade-bottom' data-time='1000'>";
                once += bolum8Metni;
                once += "</div></div></section>";


                bolum8.InnerHtml = once;
            }


        }
        catch
        { 
        
        
        
        
        }
    }

    //private void ekipYukle()
    //{


    //    try
    //    {
    //        string ustEkleme = "";
    //        string altEkleme = "";

    //        MySqlConnection connect_word = noc.connect_ebebaba(0301009184);
    //        MySqlDataAdapter da = new MySqlDataAdapter("Select * from ekipiceriktablosu E left join kategorilistekip K on E.kategori=K.ID where E.yayin='E' order by K.sira asc,E.sira asc", connect_word);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);


    //        DataRow[] devamsatiri = dt.Select("kategori=14", ""); // ftıp yardımcısı kişi
    //        DataTable devamdt = dt.Copy();
    //        devamdt.Clear();

    //        foreach (DataRow yeni in devamsatiri)
    //        {
    //            devamdt.ImportRow(yeni);

    //        }

    //        if (devamdt.Rows.Count > 0)
    //        {
    //            ustEkleme += "<div class='col-lg-6'>";
    //            ustEkleme += "<div class='cnt-box cnt-box-side boxed'>";
    //            ustEkleme += "<a href='#' class='img-box'><img src='uploadImages/" + devamdt.Rows[0]["kapakResmi"].ToString()+ "_450.jpg' alt='' /></a>";
    //            ustEkleme += "<div class='caption' style='text-transform:none;'>";
    //            ustEkleme += "<h2>" + devamdt.Rows[0]["baslik"].ToString() + "</h2>";
    //            ustEkleme += "<div class='extra-field' style='text-transform:none;'>" + devamdt.Rows[0]["Adi"].ToString() + "</div>";
               
    //            ustEkleme += "<p>"+devamdt.Rows[0]["aciklama"].ToString()+"</p>";
    //            ustEkleme += "<span class='icon-links' style='margin-top:-1px;margin-left:-5px;margin-bottom:-10px;'>";
    //            if (devamdt.Rows[0]["facebook"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='" + devamdt.Rows[0]["facebook"].ToString() + "' ><i class='icon-facebook'></i></a>";

    //            }

    //            if (devamdt.Rows[0]["youtube"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='" + devamdt.Rows[0]["youtube"].ToString() + "' ><i class='icon-youtube'></i></a>";

    //            }

    //            if (devamdt.Rows[0]["instagram"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='" + devamdt.Rows[0]["instagram"].ToString() + "' ><i class='icon-instagram'></i></a>";

    //            }
    //            if (devamdt.Rows[0]["mail"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='mailto:" + devamdt.Rows[0]["mail"].ToString() + "' ><i class='icon-envelope'></i></a>";

    //            }
    //            ustEkleme += "</span>";
    //            ustEkleme += "</div></div></div>";
    //        }



    //        DataRow[] devamsatiri2 = dt.Select("kategori=15", ""); // tb yardımcısı
    //        DataTable devamdt2 = dt.Copy();
    //        devamdt2.Clear();

    //        foreach (DataRow yeni in devamsatiri2)
    //        {
    //            devamdt2.ImportRow(yeni);

    //        }

    //        if (devamdt2.Rows.Count > 0)
    //        {
    //            ustEkleme += "<div class='col-lg-6'>";
    //            ustEkleme += "<div class='cnt-box cnt-box-side boxed'>";
    //            ustEkleme += "<a href='#' class='img-box'><img src='uploadImages/" + devamdt2.Rows[0]["kapakResmi"].ToString() + "_450.jpg' alt='' /></a>";
    //            ustEkleme += "<div class='caption'>";
    //            ustEkleme += "<h2 style='text-transform:none;'>" + devamdt2.Rows[0]["baslik"].ToString() + "</h2>";
    //            ustEkleme += "<div class='extra-field' style='text-transform:none;'>" + devamdt2.Rows[0]["Adi"].ToString() + "</div>";
           
    //            ustEkleme += "<p>" + devamdt2.Rows[0]["aciklama"].ToString() + "</p>";
    //            ustEkleme += "<span class='icon-links' style='margin-top:-1px;margin-left:-5px;margin-bottom:-10px;'>";
    //            if (devamdt2.Rows[0]["facebook"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='" + devamdt2.Rows[0]["facebook"].ToString() + "' ><i class='icon-facebook'></i></a>";

    //            }

    //            if (devamdt2.Rows[0]["youtube"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='" + devamdt2.Rows[0]["youtube"].ToString() + "' ><i class='icon-youtube'></i></a>";

    //            }

    //            if (devamdt2.Rows[0]["instagram"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='" + devamdt2.Rows[0]["instagram"].ToString() + "' ><i class='icon-instagram'></i></a>";

    //            }
    //            if (devamdt2.Rows[0]["mail"].ToString() != "")
    //            {
    //                ustEkleme += "<a href='mailto:" + devamdt2.Rows[0]["mail"].ToString() + "' ><i class='icon-envelope'></i></a>";

    //            }
    //            ustEkleme += "</span>";
    //            ustEkleme += "</div></div></div>";
    //        }


    //        if (ustEkleme != "")
    //        {
    //            ustEkip.InnerHtml = ustEkleme;
            
    //        }


    //        DataRow[] devamsatiri3 = dt.Select("kategori <> 14 and kategori <> 15", "sira1 asc"); // diğer üyeler
    //        DataTable devamdt3 = dt.Copy();
    //        devamdt3.Clear();

    //        foreach (DataRow yeni in devamsatiri3)
    //        {
    //            devamdt3.ImportRow(yeni);

    //        }

    //        if (devamdt3.Rows.Count > 0)
    //        {


    //            for (int a = 0; a < devamdt3.Rows.Count; a++)
    //            { 
                
    //            altEkleme +="<div class='grid-item'>";
    //            altEkleme += "<div class='cnt-box cnt-box-team boxed'>";
    //            altEkleme += "<img src='uploadImages/" + devamdt3.Rows[a]["kapakResmi"].ToString() + "_450.jpg' alt='' />";
    //            altEkleme += "<div class='caption'>";
    //            altEkleme += "<h2 style='text-transform:none;'>" + devamdt3.Rows[a]["baslik"].ToString() + "</h2>";
    //            altEkleme += "<span style='text-transform:none;'>" + devamdt3.Rows[a]["Adi"].ToString() + "</span>";
    //            altEkleme += "<span class='icon-links'>";
    //            if (devamdt3.Rows[a]["facebook"].ToString() != "")
    //            {
    //                altEkleme += "<a href='" + devamdt3.Rows[a]["facebook"].ToString() + "' ><i class='icon-facebook'></i></a>";

    //            }

    //            if (devamdt3.Rows[a]["youtube"].ToString() != "")
    //            {
    //                altEkleme += "<a href='" + devamdt3.Rows[a]["youtube"].ToString() + "' ><i class='icon-youtube'></i></a>";

    //            }

    //            if (devamdt3.Rows[a]["instagram"].ToString() != "")
    //                {
    //                    altEkleme += "<a href='" + devamdt3.Rows[a]["instagram"].ToString() + "' ><i class='icon-instagram'></i></a>";

    //                }
    //            if (devamdt3.Rows[a]["mail"].ToString() != "")
    //            {
    //                altEkleme += "<a href='mailto:" + devamdt3.Rows[a]["mail"].ToString() + "' ><i class='icon-envelope'></i></a>";

    //            }
    //            altEkleme += "</span>";
    //            altEkleme += "<p>" + devamdt3.Rows[a]["aciklama"].ToString() + "</p>";
    //            altEkleme += "</div>";
    //            altEkleme += "</div>";
    //            altEkleme += "</div>";
    //            }

    //        }

    //        if (altEkleme != "")
    //        {
    //            altEkip.InnerHtml = altEkleme;
            
    //        }



    //        if (altEkleme == "" && ustEkleme == "")
    //        {
    //            ekip.Visible = false;
    //        }
    //        else
    //        {
    //            ekip.Visible = true;
    //        }

    //    }
    //    catch
    //    { 
        
        
    //    }


        

    //}


    //private void blogYukle()
    //{
    //    try
    //    {

    //        XmlTextReader okuyucu = new XmlTextReader("http://annebabaoluyoruz.com/blog/feed/");
    //        XmlDocument dokuman = new XmlDocument();
    //        dokuman.Load(okuyucu);

    //        XmlNode rss = dokuman.SelectSingleNode("/rss");
    //        XmlNodeList title = dokuman.SelectNodes("/rss/channel/item/title");
    //        XmlNodeList link = dokuman.SelectNodes("/rss/channel/item/link");
    //        XmlNodeList description = dokuman.SelectNodes("/rss/channel/item/description");

    //        string eklenecekBlog = "";

    //        for (int a = 0; a < 3; a++)
    //        {

    //            var nodes = dokuman.GetElementsByTagName("content:encoded");
    //            var href = nodes[a].InnerText;
    //            string matchString = Regex.Match(href, @"(<img([^>]+)>)").Value;
    //            string matchString2 = Regex.Match(matchString, "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;






    //             string sonBlog = "<div class='grid-item'>";
    //             sonBlog += "<div class='cnt-box cnt-box-info boxed'>";
    //            sonBlog += "<a href='" + link.Item(a).InnerText.ToString() + "'  class='img-box'><img height='230' src='" + matchString2 + "' alt='' /></a>";
    //            sonBlog += "<div class='caption'  style='min-height:410px;'>";
    //            sonBlog += "<h2>" + title.Item(a).InnerText.ToString() + "</h2>";
    //            //sonBlog += "<div class='cnt-info'>";
    //            ////sonBlog += "<div><span>Price</span><span>$50</span></div>";
    //            ////sonBlog += "<div><span>Type</span><span>Software</span></div>";
    //            ////sonBlog += "<div><span>Client</span><span>Private</span></div>";
    //            //sonBlog += "</div>";

    //            int say = description.Item(a).InnerText.ToString().IndexOf("The post");
    //                string aciklama = description.Item(a).InnerText.ToString().Substring(0,say);
    //                string eklenecekAciklama = "";
    //                if (aciklama.Length > 200)
    //                {
    //                    eklenecekAciklama = aciklama.Substring(0, 200) + "... <hr class='space-sm' style='float:right;bottom:0;' /><a href='" + link.Item(a).InnerText.ToString() + "' class='btn-text active'>Devamını Oku</a>";
                    
                        

    //                }
    //                else
    //                {
    //                    eklenecekAciklama = aciklama + "<hr class='space-sm' /><a href='" + link.Item(a).InnerText.ToString() + "' class='btn-text active'>Devamını Oku</a>";
    //                }





    //            sonBlog += "<p>";
    //            sonBlog += eklenecekAciklama;
    //            sonBlog += "</p>";
    //            sonBlog += "</div>";
    //            sonBlog += "</div>";
    //            sonBlog += "</div>";






    //            //string sonBlog = "<div class='col-lg-4 isotope-item blog'>";
    //            //sonBlog += "<div class='portfolio-item'>";
    //            //sonBlog += "<a href='" + link.Item(a).InnerText.ToString() + "' >";
    //            //sonBlog += "<span class='thumb-info thumb-info-lighten'>";
    //            //sonBlog += "<span class='thumb-info-wrapper'>";
    //            //sonBlog += "<img src='" + matchString2 + "' class='img-fluid' alt=''>";
    //            //sonBlog += "<span class='thumb-info-title thumb-info-type'>" + title.Item(a).InnerText.ToString() + "</span></span></span></a></div>";
    //            //sonBlog += "</div>";

    //            eklenecekBlog += sonBlog;
    //        }

    //        blogList.InnerHtml = eklenecekBlog;
    //    }
    //    catch
    //    { }

    //}
}










