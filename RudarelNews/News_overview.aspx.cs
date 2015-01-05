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
    public partial class News_overview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteArticlesFromBD_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection objConnection = new SqlConnection(
                       ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

                string strDeleteQuery = "DELETE FROM Article";

                SqlCommand objSqlCommand = new SqlCommand(strDeleteQuery, objConnection);

                objSqlCommand.CommandType = System.Data.CommandType.Text;
                objSqlCommand.CommandText = strDeleteQuery;
                objSqlCommand.Connection = objConnection;

                objConnection.Open();
                objSqlCommand.ExecuteNonQuery();

                //ToDo: Chenge with login response page.
                Response.Redirect("News_overview.aspx");

                lblEraseBD.Text = "DB erase succesfull.";

                objConnection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.ToString());
            }
        }
        }
    }