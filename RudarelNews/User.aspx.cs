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
            if (Session["LoginUser"] != null)
            {
                lblWelcome.Text += Session["LoginUser"].ToString() + "!";
                if (Session["UserRole"].ToString() == "Admin")
                {
                    btnUsers.Visible = true;
                    btnArticles.Visible = false;
                    btnAddArticle.Visible = false;
                }
                else
                {
                    if (Session["UserRole"].ToString() == "Editor")
                    {
                        btnUsers.Visible = false;
                        btnArticles.Visible = true;
                        btnAddArticle.Visible = true;
                    }
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["LoginUser"] = null;
            Session["UserType"] = null;
            Response.Redirect("Home.aspx");
        }

        protected void btnUsers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manager.aspx");
        }

        protected void btnArticles_Click(object sender, EventArgs e)
        {
            Response.Redirect("News_overview.aspx");
        }

        protected void btnAddArticle_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddNewArticle.aspx");
        }
    }
}