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
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString();
            this.title = title;
            this.text = text;
            this.author = author;
            this.date_publised = date_publised;
            this.category = category;
            this.image = image;
        }

        public Article (string title, string image, string text, string author, DateTime date_published, string category)
        {
            this.id = Guid.NewGuid().ToString();
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
            string query = "INSERT INTO Article (id, title, author_name, date_published, category, text, image) values ('" +
                article.id + "','" +
                article.title + "','" +
                article.author + "','" +
                article.date_publised.ToString("dd-MM-yyyy hh:mm:ss") + "','" +
                article.category + "','" +
                article.text + "','" +
                article.image + "')";

            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;

            command.Parameters.AddWithValue("id", article.id);
            command.Parameters.AddWithValue("title", article.title);
            command.Parameters.AddWithValue("author_name", article.author);
            command.Parameters.AddWithValue("date_published", article.date_publised.ToString("dd-MM-yyyy hh:mm:ss"));
            command.Parameters.AddWithValue("category", article.category);
            command.Parameters.AddWithValue("text", article.text);
            command.Parameters.AddWithValue("image", article.image);
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