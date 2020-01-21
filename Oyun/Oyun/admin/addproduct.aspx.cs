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
    public partial class addproduct : System.Web.UI.Page
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        string a;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected void b1_Click(object sender, EventArgs e)
        {
            f1.SaveAs(Request.PhysicalApplicationPath + "./images/" + f1.FileName.ToString());
            a = "images/" + f1.FileName.ToString();

            cnn.Open();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Product values('" + t1.Text + "' ,'" + t2.Text + "' ," + t3.Text + "," + t4.Text + "," + t5.Text + ",'" + a.ToString() + "')";
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}