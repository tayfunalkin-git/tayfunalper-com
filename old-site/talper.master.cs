using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class talper : System.Web.UI.MasterPage
{

    tayfunalpercom mp_class = new tayfunalpercom();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            menuYukle();
            siteleriYukle();
        }
    }


    private void siteleriYukle()
    {


        try
        {
            MySqlConnection connect_word = mp_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from siteler where yayin='+' order by sira asc", connect_word);
            DataTable dt = new DataTable();
            da.Fill(dt);

            string eklenecekSiteler = "";
            for (int a = 0; a < dt.Rows.Count; a++)
            {

                eklenecekSiteler += "<li><a href='" + dt.Rows[a]["adres"].ToString() + "' target='_blank'>" + dt.Rows[a]["footer"].ToString() + "</a></li>";
             

            }

            siteler.InnerHtml = eklenecekSiteler;

        }
        catch
        {

        }
    }


    private void menuYukle()
    {


        //try
        //{





              //<li class="dropdown">
              //          <a href="#">Pages</a>
              //          <ul>
              //              <li class="dropdown-submenu">
              //                  <a>About</a>
              //                  <ul>
              //                      <li><a href="about.html">About</a></li>
              //                      <li><a href="team.html">Team</a></li>
              //                      <li><a href="history.html">History</a></li>
              //                  </ul>
              //              </li>
              //              <li class="dropdown-submenu">
              //                  <a href="#">Services</a>
              //                  <ul>
              //                      <li><a href="service-1.html">Security audits</a></li>
              //                      <li><a href="service-2.html">Artificial intelligence</a></li>
              //                      <li><a href="service-3.html">Bots and support</a></li>
              //                  </ul>
              //              </li>
              //              <li class="dropdown-submenu">
              //                  <a>Others</a>
              //                  <ul>
              //                      <li><a href="prices.html">Prices</a></li>
              //                      <li><a href="faq.html">Faq</a></li>
              //                      <li><a href="events.html">Events</a></li>
              //                      <li><a href="gallery.html">Gallery</a></li>
              //                      <li><a href="career.html">Career</a></li>
              //                  </ul>
              //              </li>
              //              <li>
              //                  <a href="elements/components/buttons.html">Elements</a>
              //              </li>
              //          </ul>
              //      </li>





        string menu = "";

            MySqlConnection mp_connection = mp_class.connect_ebebaba(0301009184);
            MySqlDataAdapter da = new MySqlDataAdapter("Select id,kitap_adi from kitaplar where goster='1' order by sira asc", mp_connection);
            DataTable dt = new DataTable();
            da.Fill(dt); // Kitap Adı


            for (int a = 0; a < dt.Rows.Count; a++)
            {

                MySqlDataAdapter da1 = new MySqlDataAdapter("Select id,kategori_adi from kitapkategorileri where kitap_id='" + dt.Rows[a][0].ToString() + "' and yayin='1' order by sira asc", mp_connection);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1); // Kitaptaki kategoriler



                menu += "<li class='dropdown'>";
                menu += "<a href='#'>"+dt.Rows[a]["kitap_adi"].ToString().ToUpper()+"</a>";
                menu += "<ul>";

                //menu += "<li class='dropdown dropdown-mega'>";
                //menu += "<a class='dropdown-item dropdown-toggle' href='#'>";
                //menu += dt.Rows[a]["kitap_adi"].ToString().ToUpper();
                //menu += "</a>";
                //menu += "<ul class='dropdown-menu'><li><div class='dropdown-mega-content'><div class='row'>";

                for (int b = 0; b < dt1.Rows.Count; b++)
                {


                    MySqlDataAdapter da2 = new MySqlDataAdapter("Select konu_id,konu,link from kitap_konulari where kategori_id='" + dt1.Rows[b][0].ToString() + "' and yayin='1' order by sira asc", mp_connection);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2); // Kategorideki konular


                    //if (dt1.Rows.Count >= 4)
                    //{
                    //    menu += "<div class='col-lg-3'>";
                    //}
                    //else
                    //{
                    //    if (dt1.Rows.Count <= 1)
                    //    {
                    //        menu += "<div class='col-lg-12'>";
                    //    }
                    //    else if (dt1.Rows.Count == 2)
                    //    {
                    //        menu += "<div class='col-lg-6'>";
                    //    }
                    //    else if (dt1.Rows.Count == 3)
                    //    {
                    //        menu += "<div class='col-lg-4'>";
                    //    }

                    //}


                    menu += "<li class='dropdown-submenu'>";
                    menu += "<a>"+dt1.Rows[b]["kategori_adi"].ToString().ToUpper()+"</a>";
                    menu += "<ul>";
                                

 
                   // menu += "<span class='dropdown-mega-sub-title'>" + dt1.Rows[b]["kategori_adi"].ToString().ToUpper() + "</span>";
                   // menu += "<ul class='dropdown-mega-sub-nav'>";




                    for (int c = 0; c < dt2.Rows.Count; c++)
                    {

                        menu += "<li><a href='makale-" + dt2.Rows[c]["link"].ToString() + ".aspx'>"+dt2.Rows[c]["konu"].ToString()+"</a></li>";
                        //menu += "<li><a class='dropdown-item' href='makale-" + dt2.Rows[c]["link"].ToString() + ".aspx'>" + dt2.Rows[c]["konu"].ToString() + "</a></li>";

                    }


                    if (dt1.Rows[b][0].ToString() == "117")
                    {// ne işe yarar?

                        MySqlConnection connectABO = new MySqlConnection("DataSource= 94.73.150.121;Database=u6529584_dbB01;User ID=u6529584_userB01;Password=ZEig11J3;charset=latin5");
                        MySqlDataAdapter da21 = new MySqlDataAdapter("Select kategoriAdi,link from hosgeldiniz where neIseYarar='+' and yayin='+' order by sira asc", connectABO);
                        DataTable dt21 = new DataTable();
                        da21.Fill(dt21); // Kategorideki konular

                        for (int c = 0; c < dt21.Rows.Count; c++)
                        {

                           // menu += "<li><a class='dropdown-item' href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
                        menu += "<li><a href='neIseYarar-" + dt21.Rows[c]["link"].ToString() + ".aspx'>"+dt21.Rows[c]["kategoriAdi"].ToString()+"</a></li>";

                        }
                    }
                    if (dt1.Rows[b][0].ToString() == "118")
                    {

                        MySqlConnection connectABO = new MySqlConnection("DataSource= 94.73.150.121;Database=u6529584_dbB01;User ID=u6529584_userB01;Password=ZEig11J3;charset=latin5");
                        MySqlDataAdapter da21 = new MySqlDataAdapter("Select kategoriAdi,link from hosgeldiniz where nasilKullanilir='+' and yayin='+' order by sira asc", connectABO);
                        DataTable dt21 = new DataTable();
                        da21.Fill(dt21); // Kategorideki konular

                        for (int c = 0; c < dt21.Rows.Count; c++)
                        {

                            //menu += "<li><a class='dropdown-item' href='nasilKullanilir-" + dt21.Rows[c]["link"].ToString() + ".aspx'>" + dt21.Rows[c]["kategoriAdi"].ToString() + "</a></li>";
                        menu += "<li><a href='nasilKullanilir-" + dt21.Rows[c]["link"].ToString() + ".aspx'>"+dt21.Rows[c]["kategoriAdi"].ToString()+"</a></li>";

                        }



                    }

   
                    menu += "</ul></li>";


                }
                menu += "</ul>";

            }
            // menu += "<li>";
            //menu += "<a class='dropdown-item' href='https://www.tayfunalper.com/tup-bebek-cevaplari.aspx'>";
            //menu += "SORU-CEVAP VİDEOLARI";
            //menu += "</a>";

            menu += "</li>";


            menu += "<li class='nav-label'>";
            menu += "<a href='https://www.tayfunalper.com/icerikYazilariOnizleme.aspx?ID=Randevu'>Randevu Al</a>";
            menu += "</li>";

  
        menu = "<ul id='main-menu'>" + menu + "</ul>";

        menu += "<div class='menu-right' style='text-decoration:none;'>";
        menu += "<div class='custom-area' style='text-decoration:none;'>";
        menu += "";
        menu +="";
        menu += "<a href='mailto://bilgi@tayfunalper.com' target='_blank' style='text-decoration:none;color:#ffffff;'>E-Posta: bilgi@tayfunalper.com</a></div>";

        menu += "<div id='searchform' class='search-btn'>";
        menu += "<div class='search-box-menu'>";
        menu += "<input type='text' placeholder='Sitede Ara ...' id='arama'>";
        menu += "<i></i>";
        menu += "</div>";
        menu += "</div>";

        menu += "<div class='icon-links icon-social social-colors-hover'>";
        menu += "<a target='_blank' class='facebook' href='https://www.facebook.com/tayfun.alper.9'><i class='icon-facebook'></i></a>";
        menu += "<a target='_blank' class='instagram' href='https://www.instagram.com/prof.dr.tayfunalper/'><i class='icon-instagram'></i></a>";
        menu += "</div>";
        menu += "</div>";



        menum.InnerHtml = menu;
        
        //}
        //catch
        //{ }

    }
}
