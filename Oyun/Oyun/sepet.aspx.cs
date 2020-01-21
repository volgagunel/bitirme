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
    public partial class sepet : System.Web.UI.Page
    {
        string s;
        string t;
        string[] a = new string[5];
        int tot = 0;
        int id;

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-UKL91NP\ISKALLORD;Initial Catalog=Oyun;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Name"), new DataColumn("Year"), new DataColumn("Price"), new DataColumn("CategoryID"), new DataColumn("ImagePath"), new DataColumn("id") });

            if (Request.Cookies["aa"]!= null)
            {
                s = Convert.ToString(Request.Cookies["aa"].Value);
                string[] strArr = s.Split('|');

                for(int i =0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');
                    for (int j=0; j<strArr1.Length; j++)
                    {
                        a[j] = strArr1[j].ToString();
                    }
                    dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString() , i.ToString());

                    tot = tot + (Convert.ToInt32(a[2].ToString()));
                }
            }
            
            d1.DataSource = dt;
            d1.DataBind();

            l1.Text = "Ödemeniz gereken Tutar :" + tot.ToString();
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            Response.Redirect("odeme.aspx");
        }
    }
}