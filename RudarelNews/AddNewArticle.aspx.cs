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
    }
}