using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace RudarelNews
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            SqlConnection objConnection = new SqlConnection(
                   ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            objConnection.Open();
            string strCheckUser = "select count(*) from Users where username='" + tbLogUsr.Text + "'";
            SqlCommand objSqlCommand = new SqlCommand(strCheckUser, objConnection);
            int nReturned = Convert.ToInt32(objSqlCommand.ExecuteScalar().ToString());
            objConnection.Close();
            if (nReturned == 1)
            {
                objConnection.Open();
                string strCheckPass = "select password from Users where username='" + tbLogUsr.Text + "'";
                SqlCommand objSqlCommandPass = new SqlCommand(strCheckPass, objConnection);
                string strPassword = objSqlCommandPass.ExecuteScalar().ToString();
                if(strPassword.Trim()==tbLogPass.Text.Trim())
                {
                    Session["New"] = tbLogUsr.Text;
                    Response.Write("Password is correct");
                }
                else
                {
                    Response.Write("Password incorrect");
                }
            }
            else
            {
                Response.Write("Username incorrect");
            }

            objConnection.Close();
        }
    }
}