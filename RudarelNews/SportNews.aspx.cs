using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RudarelNews
{
    public partial class SportNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            System.Collections.ArrayList arrArticles = Article.getArticlesByType("Sport");
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach(Article article in arrArticles)
            {
                sb.Append(string.Format(@"<table class='articleTable'>
                <tr>
                    <th>Title:</th>
                    <td>{2}</td>
                </tr>

                <tr>
                    <th rowspan='6' width='150px'><img runat='server' src='{0}' /></th>
                    <td></td>
                </tr>

                <tr>
                    <th>Author:</th>
                    <td>{3}</td>
                </tr>

                <tr>
                    <th>Date published:</th>
                    <td>{4}</td>
                </tr>

                <tr>
                    <th>Text:</th>
                    <td>{1}</td>
                </tr>
                
                </table>", article.title, article.image, article.author, article.date_publised, article.text));
            }
            lblOutputSport.Text = sb.ToString();

        }
    }
}