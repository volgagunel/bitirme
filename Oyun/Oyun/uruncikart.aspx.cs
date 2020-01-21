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
    public partial class uruncikart : System.Web.UI.Page
    {
        string s;
        string t;
        string[] a = new string[5];
        int id;
        string Name, Year, Price, CategoryID, ImagePath;
        int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt.Rows.Clear();

            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Name"), new DataColumn("Year"), new DataColumn("Price"), new DataColumn("CategoryID"), new DataColumn("ImagePath") , new DataColumn("id") });

            if (Request.Cookies["aa"] != null)
            {
                s = Convert.ToString(Request.Cookies["aa"].Value);
                string[] strArr = s.Split('|');

                for (int i = 0; i < strArr.Length; i++)
                {
                    t = Convert.ToString(strArr[i].ToString());
                    string[] strArr1 = t.Split(',');
                    for (int j = 0; j < strArr1.Length; j++)
                    {
                        a[j] = strArr1[j].ToString();
                    }
                    dt.Rows.Add(a[0].ToString(), a[1].ToString(), a[2].ToString(), a[3].ToString(), a[4].ToString(), i.ToString());
                }
            }
            dt.Rows.RemoveAt(id);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["aa"].Expires = DateTime.Now.AddDays(-1);

            foreach (DataRow dr in dt.Rows)
            {
                Name = dr["Name"].ToString();
                Year = dr["Year"].ToString();
                Price = dr["Price"].ToString();
                CategoryID = dr["CategoryID"].ToString();
                ImagePath = dr["ImagePath"].ToString();

                count = count + 1;

            if (count==1)
            {
                Response.Cookies["aa"].Value = Name.ToString() + "," + Year.ToString() + "," + Price.ToString() + "," + CategoryID.ToString() + "," + ImagePath.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
            else
            {
                Response.Cookies["aa"].Value = Request.Cookies["aa"].Value + "|" + Name.ToString() + "," + Year.ToString() + "," + Price.ToString() + "," + CategoryID.ToString() + "," + ImagePath.ToString();
                Response.Cookies["aa"].Expires = DateTime.Now.AddDays(1);
            }
            }
            Response.Redirect("sepet.aspx");
        }
    }
}