using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oyun
{
    public partial class Kaydol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDurum.Visible = false;
        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {

            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");

                string sorgu = "INSERT INTO Kullanicilar(KullaniciAdi, Sifre) Values(@kullaniciadi , @sifre)";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sorgu, cnn);
                cnn.Open();

                try
                {
                    cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                    cmd.ExecuteNonQuery();
                    cnn.Close();

                   
                    pnlKayit.Visible = false;
                    pnlDurum.Visible = true;

                    Session.Add("kullaniciadi", txtKullaniciAdi.Text);

                    lblDurum.Text = "Başarıyla kayıt yapılmıştır.";
                }

                catch (Exception)
                {
                    lblSonuc.Text = "Kaydınız gerçekleşmemiştir.";
                }

            }

            else
            {
                lblSonuc.Text = "Boş alanları doldurmanız gerekir.";
            }



        }
    }
}
    