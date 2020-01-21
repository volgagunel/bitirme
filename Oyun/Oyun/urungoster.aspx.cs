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
    public partial class urungoster : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        int id;
        string Name, Year, Price, CategoryID, ImagePath;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["id"] == null)
            {
                Response.Redirect("xboxoyunlari.aspx");

            }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Product tp JOIN SubCategory ts ON tp.SubCategoryID = ts.SubCategoryID WHERE tp.ProductID='" + Request.QueryString["id"].ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();

                cnn.Close();
            }


        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected void b1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product tp JOIN SubCategory ts ON tp.SubCategoryID = ts.SubCategoryID WHERE tp.ProductID='" + Request.QueryString["id"].ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Name = dr["Name"].ToString();
                Year = dr["Year"].ToString();
                Price = dr["Price"].ToString();
                CategoryID = dr["CategoryID"].ToString();
                ImagePath = dr["ImagePath"].ToString();
            }

            if (Request.Cookies["aa"]== null)
            {
                Response.Cookies["aa"].Value = Name.ToString() + "," + Year.ToString() + "," + Price.ToString() + "," + CategoryID.ToString() + "," + ImagePath.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + Name.ToString() + "," + Year.ToString() + "," + Price.ToString() + "," + CategoryID.ToString() + "," + ImagePath.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }


            cnn.Close();
        }
    }
}