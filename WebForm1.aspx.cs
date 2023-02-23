using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPLoginSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection SqlConn = new SqlConnection("Data Source=DESKTOP-7C3479M\\SQLEXPRESS; Initial Catalog=ASPLogin; Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginClick(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserAcc WHERE UserName='" +  username.Text + "' AND Password='" + passwd.Text + "'", SqlConn);  
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                confirmationlbl.Text = "You've successfully logged into the system!";
                confirmationlbl.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                confirmationlbl.Text = "Invalid UserName or Password!";
                confirmationlbl.ForeColor = System.Drawing.Color.Red;
            }
            confirmationlbl.Visible = true;
        }

        protected void resetClick(object sender, EventArgs e)
        {
            username.Text = "";
            passwd.Text = "";
            confirmationlbl.Visible = false;
            confirmationlbl.ForeColor = System.Drawing.Color.Green;
        }
    }
}