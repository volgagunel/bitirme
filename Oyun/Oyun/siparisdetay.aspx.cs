using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Oyun
{
    
    public partial class siparisdetay : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected void Page_Load(object sender, EventArgs e)
        {



            cnn.Close();
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            cnn.Open();

            string sorgu = "Insert into Orders (isim, soyisim , sehir , adres ,KullaniciID)  Values(@isim , @soyisim, @sehir, @adres , (SELECT KullaniciID FROM Kullanicilar WHERE KullaniciAdi='" +Session["kullaniciadi"].ToString()+"')) ";
            SqlCommand cmd = new SqlCommand(sorgu, cnn);          
            cmd.Parameters.AddWithValue("@isim", t1.Text);
            cmd.Parameters.AddWithValue("@soyisim", t2.Text);
            cmd.Parameters.AddWithValue("@sehir", t3.Text);
            cmd.Parameters.AddWithValue("@adres", t4.Text);
            cmd.ExecuteNonQuery();

            cnn.Close();

            Response.Redirect("odemebasarili.aspx");
        }
    }
}