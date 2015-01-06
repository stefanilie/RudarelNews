using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RudarelNews
{
    public class Article
    {
        public Guid id { get; set; }
        public string title { get; set; }

        public string text { get; set; }

        public string author { get; set; }

        public string date_publised { get; set; }

        public string category { get; set; }

        public string image { get; set; }


        public Article(Guid id, string image, string title, string text, string author, string date_published, string category)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.author = author;
            this.date_publised = date_publised;
            this.category = category;
            this.image = image;
        }

        public Article (string title, string image, string text, string author, string date_published, string category)
        {
            this.id = Guid.NewGuid();
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
                article.id.ToString() + "','" +
                article.title + "','" +
                article.author + "','" +
                article.date_publised + "','" +
                article.category + "','" +
                article.text + "','" +
                article.image + "')";

            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
            command.Connection = conn;

            command.Parameters.AddWithValue("id", article.id.ToString());
            command.Parameters.AddWithValue("title", article.title);
            command.Parameters.AddWithValue("author_name", article.author);
            command.Parameters.AddWithValue("date_published", article.date_publised);
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

        public static System.Collections.ArrayList getArticlesByType(string strArticleType)
        {
            System.Collections.ArrayList arrArticles = new System.Collections.ArrayList();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ToString();
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connectionString);
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("", conn);
            string strQuery = "SELECT * FROM Article WHERE category LIKE '" + strArticleType.Trim() + "'";

            try
            {
                conn.Open();
                command.CommandText = strQuery;
                System.Data.SqlClient.SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    //Guid id = sqlReader.GetGuid(0);
                    string title = sqlReader.GetString(0);
                    string author_name = sqlReader.GetString(1);               
                    string date = sqlReader.GetString(2);
                    string category = sqlReader.GetString(3);
                    string text = sqlReader.GetString(4);
                    string image = sqlReader.GetString(5);

                    Article objArticle = new Article(title, image, text, author_name, date, category);
                    //Article objArticle = new Article(id, image, title, text, author_name, date, category);

                    arrArticles.Add(objArticle);
                }
            }
            finally
            {
                conn.Close();
                command.Parameters.Clear();
            }

            return arrArticles;
        }
    }
}