using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RudarelNews
{
    public partial class AddNewArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string selectedValue = ddImage.SelectedValue;
            ShowImages();
            ddImage.SelectedValue = selectedValue;
        }

        private void ShowImages()
        {
            string[] images = System.IO.Directory.GetFiles(Server.MapPath("~/Images/RudarelNews"));
            System.Collections.ArrayList imageList = new System.Collections.ArrayList();

            foreach(string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\") + 1);
                imageList.Add(imageName);
            }

            ddImage.DataSource = imageList;
            ddImage.DataBind();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearTextFields()
        {
            tbArticleText.Text = "";
            tbArticleTitle.Text = "";
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string strFilename = System.IO.Path.GetFileName(FileUpload.FileName);
                FileUpload.SaveAs(Server.MapPath("~/Images/RudarelNews/") + strFilename);
                labelResults.Text = "Image " + strFilename + " succesfully uploaded!";
                Page_Load(sender, e);
            }
            catch(Exception)
            {
                labelResults.Text = "Upload failed!";
            }
        }

        protected void btnPublishArticle_Click(object sender, EventArgs e)
        {
            try
            {
                Guid guid = Guid.NewGuid();
                //string id = guid.ToString();
                string title = tbArticleTitle.Text;
                string author = User.Identity.Name.ToString();
                string text = tbArticleText.Text;
                string category = ddCategory.SelectedItem.Text;
                string image = "../Images/RudarelNews/" + ddImage.SelectedValue;
                DateTime date_published = DateTime.Now;

                //Article article = new Article(id, title, image, text, author, date_published, category);
                Article article = new Article(title, image, text, author, date_published, category);
                Article.AddArticle(article);
                labelResults.Text = "Upload Succesfull!";
                ClearTextFields();
                
            }
            catch (Exception ex)
            {
                labelResults.Text = "Upload failed!\n Error: " + ex.ToString();
            }
        }
    }
}