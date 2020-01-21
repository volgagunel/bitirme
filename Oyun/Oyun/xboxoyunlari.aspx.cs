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
    public partial class xboxoyunlari : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected void Page_Load(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
 
            cmd.CommandType = CommandType.Text;
            if (Request.QueryString["category"]== null)
            {
                cmd.CommandText = "SELECT * from product tp JOIN SubCategory ts ON tp.SubCategoryID = ts.SubCategoryID WHERE CategoryID= 3";

            }
            else
            {
                cmd.CommandText = "SELECT * from product tp JOIN SubCategory ts ON tp.SubCategoryID = ts.SubCategoryID WHERE CategoryID= 3 AND ts.SubCategoryName='" + Request.QueryString["category"] .ToString()+ "'";
            }

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();

            cnn.Close();
        }
    }
}