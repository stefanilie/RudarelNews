﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RudarelNews
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            List<Article> arrArticles = Article.getArticlesByType("*");
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            List<Article> arrSortedByDate = arrArticles.OrderBy(a => a.date_publised).ToList();
            List<Article> arrSortedByName = arrArticles.OrderBy(a => a.title).ToList();
            
            foreach (Article article in arrArticles)
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
            lblOutputHome.Text = sb.ToString();

        }

        protected void btnOrderTitle_Click(object sender, EventArgs e)
        {
            //todo
        }

        protected void btnOrderDate_Click(object sender, EventArgs e)
        {
            //todo
        }
    }
}