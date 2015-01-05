using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RudarelNews
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoginUser"]!=null)
            {
                lblWelcome.Text += Session["LoginUser"].ToString() + "!";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["LoginUser"] = null;
            Session["UserType"] = null;
            Response.Redirect("Home.aspx");
        }
    }
}