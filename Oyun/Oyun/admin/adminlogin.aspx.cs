using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Oyun.admin
{
    public partial class adminlogin : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * From adminlogin Where Username = @username AND Password = @password";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);

            cmd.Parameters.AddWithValue("@username", t1.Text);
            cmd.Parameters.AddWithValue("@password", t2.Text);

            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                Session.Add("username", t1.Text);
                Response.Redirect("admindefault.aspx");
            }

            else
            {
                l1.Text = "Kullanıcı girişi sağlanamadı";
            }



            cnn.Close();
        }
    }
}