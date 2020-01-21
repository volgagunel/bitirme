using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Oyun
{
    public partial class main : System.Web.UI.MasterPage
    {


        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["kullaniciadi"];
            if (kullanici != null)
            {
                pnlGiris.Visible = false;
                pnlKullanici.Visible = true;
                lblKullaniciAdi.Text = kullanici.ToString();
            }
            else
            {
                pnlGiris.Visible = true;
                pnlKullanici.Visible = false;


            }
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from SubCategory ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dd.DataSource = dt;
            dd.DataBind();

            cnn.Close();
            
        }


        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From Kullanicilar Where KullaniciAdi = @kullaniciadi AND Sifre = @sifre";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);

            cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Session.Add("kullaniciadi", txtKullaniciAdi.Text);
                Response.Redirect(Request.RawUrl);
            }

            else
            {
                lblSonuc.Text = "Kullanıcı girişi sağlanamadı";
            }



            cnn.Close();
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.RawUrl);
        }

        protected void sepet_Click(object sender, EventArgs e)
        {
            Response.Redirect("sepet.aspx");
        }
    }
}