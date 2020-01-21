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
    public partial class odemebasarili : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        string order_id;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected void Page_Load(object sender, EventArgs e)
        {
            cnn.Open();
            
            
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Kullanicilar where KullaniciAdi='" + Session["kullaniciadi"].ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                
                SqlCommand cmd2 = cnn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT OrderID FROM Orders o INNER JOIN Kullanicilar u ON u.KullaniciID= o.KullaniciID WHERE KullaniciAdi='" + Session["kullaniciadi"].ToString() + "'";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);
                foreach (DataRow dr2 in dt2.Rows)
                {
                    order_id = dr2["OrderID"].ToString();
                }



                        SqlCommand cmd3 = cnn.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.CommandText = "INSERT INTO OrderDetails(OrderID , ProductID) values(('"+order_id.ToString()+ "') , (SELECT TOP 1 p.ProductID FROM Product p INNER JOIN OrderDetails o ON o.ProductID= p.ProductID))";
                        cmd3.ExecuteNonQuery();

                            



            

            cnn.Close();

            Session["user"] = "";

            Response.Redirect("urungoster.aspx");
        }
    }
}