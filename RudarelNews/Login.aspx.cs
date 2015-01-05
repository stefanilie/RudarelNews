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
            string strCheckUser = "select count(*) from Users where username='" + tbLogUsr.Text.Trim() + "'";
            SqlCommand objSqlCommand = new SqlCommand(strCheckUser, objConnection);
            int nReturned = Convert.ToInt32(objSqlCommand.ExecuteScalar().ToString());
            objConnection.Close();
            if (nReturned == 1)
            {
                objConnection.Open();
                string strCheckPass = "select password from Users where username='" + tbLogUsr.Text + "'";
                string strCheckUserType = "select user_type from Users where username='" + tbLogUsr.Text + "'";
                SqlCommand objSqlCommandPass = new SqlCommand(strCheckPass, objConnection);
                SqlCommand objSqlCommandUsrType = new SqlCommand(strCheckUserType, objConnection);
                string strPassword = objSqlCommandPass.ExecuteScalar().ToString();
                string strUserType = objSqlCommandUsrType.ExecuteScalar().ToString();
                if(strPassword.Trim()==tbLogPass.Text.Trim())
                {
                    Session["LoginUser"] = tbLogUsr.Text;
                    Session["UserRole"] = strUserType.Trim();
                    Response.Redirect("User.aspx");
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