using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class makaleGoruntule : System.Web.UI.Page
{
  
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            Page.Title = "Prof.Dr.Tayfun ALPER - " + "'Kısırlık Tüp Bebek Hasta Kılavuzu' Kitabım";

            System.Web.UI.HtmlControls.HtmlMeta a = new System.Web.UI.HtmlControls.HtmlMeta();
            a = (System.Web.UI.HtmlControls.HtmlMeta)Master.FindControl("kw");
            string ek = "";

            a.Content = ek + "Tayfun ALPER,Kısırlık,Tüp Bebek Hasta Kılavuzu,Kitap,Samsun,Omü,Ondokuz Mayıs Üniversitesi,Tayfun,ALPER,Prof.Dr.Tayfun ALPER,VM Medical Park Samsun Hastanesi,samsuntupbebek.com,IVF,Tüp Bebek,Emekli,Kadın Doğum Uzmanı,Kadın Doğum";

            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"100%\" height=\"800px\" trusted=\"yes\">";
            embed += "Tarayıcınız pdf okumayı desteklememektedir. İsterseniz <a href = \"{0}\">burayı</a>";
            embed += " tıklayarak kitabı pdf olarak ÜCRETSİZ indirebilirsiniz. İstediğiniz kişilerle paylaşabilirsiniz.";
            embed += "</object>";
            icerik.InnerHtml = string.Format(embed, ResolveUrl("~/tupBebek.pdf#view=FitH"));
        }
    }

  
}