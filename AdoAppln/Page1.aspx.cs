using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
    

namespace AdoAppln
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-3HUC9PM\SQLEXPRESS;database=NovDB;integrated security=true");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strinsert = "insert into tabN values('"+TextBox1.Text+"',"+TextBox2.Text+",'"+TextBox3.Text+"')";
            SqlCommand cmd = new SqlCommand(strinsert, con);//cmd= insert query
            con.Open();
            int i=cmd.ExecuteNonQuery();//i= no of row inserted
            con.Close();
            if(i!=0)
            {
                Label4.Text = "inserted";
            }
        }
    }
}