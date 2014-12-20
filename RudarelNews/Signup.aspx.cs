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
    public partial class SIgnup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                SqlConnection objConnection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                objConnection.Open();
                string strCheckUser = "select count(*) from Users where username='"+ tbUsername.Text+"'";
                SqlCommand objSqlCommand = new SqlCommand(strCheckUser, objConnection);
                int nReturned = Convert.ToInt32(objSqlCommand.ExecuteScalar().ToString());
                if(nReturned == 1)
                {
                    //ToDo: change this with alert.
                    Response.Write("User already exists");
                }
                objConnection.Close();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConnection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                objConnection.Open();
                string strInserQuery = "insert into Users (first_name, last_name, username, password, email, user_type) values (@tbFirstName, @tbLastName, @tbUsername, @tbPass, @tbEmail, @ddUserType)";
                SqlCommand objSqlCommand = new SqlCommand(strInserQuery, objConnection);
                
                objSqlCommand.Parameters.AddWithValue("@first_name", tbFirstName.Text);
                objSqlCommand.Parameters.AddWithValue("@last_name", tbLastName.Text);
                objSqlCommand.Parameters.AddWithValue("@username", tbUsername.Text);
                objSqlCommand.Parameters.AddWithValue("@password", tbPass.Text);
                objSqlCommand.Parameters.AddWithValue("@email", tbEmail.Text);
                objSqlCommand.Parameters.AddWithValue("@user_type", ddUserType.SelectedItem.ToString());

                objSqlCommand.ExecuteNonQuery();

                //ToDo: Chenge with login response page.
                Response.Redirect("Manager.aspx");

                //ToDo: change this with response page
                Response.Write("Your registration is successful!");
                
                objConnection.Close();
            }
            catch(Exception ex)
            {
                Response.Redirect("Errorpage.aspx");
                Response.Write("Error: "+ ex.Message);
            }
        }
    }
}