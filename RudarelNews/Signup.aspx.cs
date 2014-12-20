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
                SqlConnection objCOnnection = new SqlConnection(
                    ConfigurationManager.ConnectionStrings[""]);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your registration is successful!");
        }
    }
}