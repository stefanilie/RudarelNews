using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RudarelNews
{
    public class Article
    {
        public string id { get; set; }
        public string title { get; set; }

        public string text { get; set; }

        public string author { get; set; }

        public DateTime date_publised { get; set; }

        public string category { get; set; }

        public string image { get; set; }


        public Article(string id, string image, string title, string text, string author, DateTime date_published, string category)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.author = author;
            this.date_publised = date_publised;
            this.category = category;
            this.image = image;
        }

        public Article (string title, string image, string text, string author, DateTime date_published, string category)
        {
            this.title = title;
            this.text = text;
            this.author = author;
            this.date_publised = date_publised;
            this.category = category;
            this.image = image; 
        }

        public static void AddArticle(Article article)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ToString();
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("", conn);
            string query = string.Format(
                @"INSERT INTO Article VALUES ('{0}', '{1}', @date_published, '{2}', '{3}', '{4}', '{5}', '{6}')",
                article.id, article.title, article.author, article.category, article.text, article.image);
            command.CommandText = query;
            command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date_publised", article.date_publised));
            try
            {
                conn.Open();
                command.ExecuteNonQuery();  
            }
            finally
            {
                conn.Close();
                command.Parameters.Clear();
            }
        }
    }
}